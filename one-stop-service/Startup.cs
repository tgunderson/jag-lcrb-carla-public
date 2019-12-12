﻿using Gov.Lclb.Cllb.Interfaces;
using Hangfire;
using Hangfire.Console;
using Hangfire.MemoryStorage;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.HealthChecks;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using SoapCore;
using Swashbuckle.AspNetCore.Swagger;
using System;
using System.Linq;
using System.Reflection;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Serilog;
using Serilog.Exceptions;
using Microsoft.OpenApi.Models;
using Microsoft.AspNetCore.Server.Kestrel.Core;

namespace Gov.Lclb.Cllb.OneStopService
{
    public class Startup
    {
        private readonly ILoggerFactory _loggerFactory;

        public Startup(IWebHostEnvironment env, ILoggerFactory loggerFactory)
        {
            _loggerFactory = loggerFactory;
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            if (!System.Diagnostics.Debugger.IsAttached)
                builder.AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true);
            builder.AddEnvironmentVariables();

            if (env.IsDevelopment())
            {
                builder.AddUserSecrets<Startup>();
            }

            Configuration = builder.Build();

        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Adjust Kestrel options to allow sync IO
            services.Configure<KestrelServerOptions>(options =>
            {
                options.AllowSynchronousIO = true;
            });


            IDynamicsClient dynamicsClient = DynamicsSetupUtil.SetupDynamics(Configuration);
            services.AddSingleton<IReceiveFromHubService>(new ReceiveFromHubService(dynamicsClient, _loggerFactory.CreateLogger("IReceiveFromHubService"), Configuration));

            services.AddSingleton<Microsoft.Extensions.Logging.ILogger>(_loggerFactory.CreateLogger("OneStopController"));

            services.AddMvc(config =>
            {
                config.EnableEndpointRouting = false;
                if (!string.IsNullOrEmpty(Configuration["JWT_TOKEN_KEY"]))
                {
                    var policy = new AuthorizationPolicyBuilder()
                                 .RequireAuthenticatedUser()
                                 .Build();
                    config.Filters.Add(new AuthorizeFilter(policy));
                }

            });

            // Other ConfigureServices() code...

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "JAG LCRB One Stop Service", Version = "v1" });
            });

            services.AddIdentity<IdentityUser, IdentityRole>()
                .AddDefaultTokenProviders();

            if (!string.IsNullOrEmpty(Configuration["JWT_TOKEN_KEY"]))
            {
                // Configure JWT authentication
                services.AddAuthentication(o =>
                {
                    o.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                    o.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                }).AddJwtBearer(o =>
                {
                    o.SaveToken = true;
                    o.RequireHttpsMetadata = false;
                    o.TokenValidationParameters = new TokenValidationParameters()
                    {
                        RequireExpirationTime = false,
                        ValidIssuer = Configuration["JWT_VALID_ISSUER"],
                        ValidAudience = Configuration["JWT_VALID_AUDIENCE"],
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["JWT_TOKEN_KEY"]))
                    };
                });
            }

            services.AddHangfire(config =>
            {
                // Change this line if you wish to have Hangfire use persistent storage.
                config.UseMemoryStorage();
                // enable console logs for jobs
                config.UseConsole();
            });

            // health checks. 
            services.AddHealthChecks(checks =>
            {
                checks.AddValueTaskCheck("HTTP Endpoint", () => new
                    ValueTask<IHealthCheckResult>(HealthCheckResult.Healthy("Ok")));
            });

            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory loggerFactory)
        {
            
            

            // OneStop does not seem to set the SoapAction properly

            app.Use(async (context, next) =>
            {
                
                if (context.Request.Path.Value.Equals("/receiveFromHub"))
                {                    
                    string soapAction = context.Request.Headers["SOAPAction"];
                    if (string.IsNullOrEmpty(soapAction) || soapAction.Equals("\"\""))
                    {
                        context.Request.Headers["SOAPAction"] = "http://tempuri.org/IReceiveFromHubService/receiveFromHub";
                    }
                }

                await next();

            });

            app.UseSoapEndpoint<IReceiveFromHubService>(path: "/receiveFromHub", binding: new BasicHttpBinding());

            // , serializer: SoapSerializer.XmlSerializer, caseInsensitivePath: true

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            bool startHangfire = true;
#if DEBUG
            // do not start Hangfire if we are running tests.        
            foreach (var assem in Assembly.GetEntryAssembly().GetReferencedAssemblies())
            {
                if (assem.FullName.ToLowerInvariant().StartsWith("xunit"))
                {
                    startHangfire = false;
                    break;
                }
            }
#endif

            if (startHangfire)
            {
                // enable Hangfire, using the default authentication model (local connections only)
                app.UseHangfireServer();

                DashboardOptions dashboardOptions = new DashboardOptions
                {
                    AppPath = null
                };

                app.UseHangfireDashboard("/hangfire", dashboardOptions);
            }

            if (!string.IsNullOrEmpty(Configuration["ENABLE_HANGFIRE_JOBS"]))
            {
                SetupHangfireJobs(app, loggerFactory);
            }

            app.UseAuthentication();
            app.UseMvc();
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "JAG LCRB One Stop Service");
            });

            // enable Splunk logger using Serilog
            if (!string.IsNullOrEmpty(Configuration["SPLUNK_COLLECTOR_URL"]) &&
                !string.IsNullOrEmpty(Configuration["SPLUNK_TOKEN"])
                )
            {
                Log.Logger = new LoggerConfiguration()
                    .Enrich.FromLogContext()
                    .Enrich.WithExceptionDetails()
                    .WriteTo.EventCollector(Configuration["SPLUNK_COLLECTOR_URL"],
                        Configuration["SPLUNK_TOKEN"], restrictedToMinimumLevel: Serilog.Events.LogEventLevel.Error)
                    .CreateLogger();
            }

        }

    

        /// <summary>
        /// Setup the Hangfire jobs.
        /// </summary>
        /// <param name="app"></param>
        /// <param name="loggerFactory"></param>
        private void SetupHangfireJobs(IApplicationBuilder app, ILoggerFactory loggerFactory)
        {
            Microsoft.Extensions.Logging.ILogger log = loggerFactory.CreateLogger(typeof(Startup));
            log.LogInformation("Starting setup of Hangfire job ...");

            try
            {
                using (var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
                {
                    log.LogInformation("Creating Hangfire jobs for License issuance check ...");

                    Microsoft.Extensions.Logging.ILogger oneStopLog = loggerFactory.CreateLogger(typeof(OneStopUtils));
                    RecurringJob.AddOrUpdate(() => new OneStopUtils(Configuration, oneStopLog).CheckForNewLicences(null), Cron.Hourly());

                    Microsoft.Extensions.Logging.ILogger orbookLog = loggerFactory.CreateLogger(typeof(OrgBookUtils));
                    RecurringJob.AddOrUpdate(() => new OrgBookUtils(Configuration, orbookLog).CheckForNewLicences(null), Cron.Hourly());
                    RecurringJob.AddOrUpdate(() => new OrgBookUtils(Configuration, orbookLog).CheckForMissingCredentials(null), Cron.Hourly());
                    RecurringJob.AddOrUpdate(() => new OrgBookUtils(Configuration, orbookLog).CheckForOrgbookLinks(null), Cron.Daily());

                    log.LogInformation("Hangfire License issuance check jobs setup.");
                }
            }
            catch (Exception e)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendLine("Failed to setup Hangfire job.");

                log.LogCritical(new EventId(-1, "Hangfire job setup failed"), e, msg.ToString());
            }
        }

    }
}
