﻿using Gov.Lclb.Cllb.Interfaces.Models;
using Gov.Lclb.Cllb.Public.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using Xunit;

namespace Gov.Lclb.Cllb.Public.Test
{
    public class WorkerTests : ApiIntegrationTestBaseWithLogin
    {
        public WorkerTests(CustomWebApplicationFactory<Startup> factory)
          : base(factory)
        { }

        [Fact]
        public async System.Threading.Tasks.Task TestNoAccessToAnonymousUser()
        {
            string id = "SomeRandomId";

            // first confirm we are not logged in
            await GetCurrentUserIsUnauthorized();

            // try a random GET, should return unauthorized
            var request = new HttpRequestMessage(HttpMethod.Get, "/api/worker/" + id);
            var response = await _client.SendAsync(request);
            Assert.Equal(HttpStatusCode.Unauthorized, response.StatusCode);
            string _discard = await response.Content.ReadAsStringAsync();
        }

        [Fact]
        public async System.Threading.Tasks.Task TestBirthdate()
        {

            string initialName = "TestFirst";
            string changedName = "ChangedName";
            string changedEmail = "newEmail@gov.bc.ca";
            string service = "worker";

            // January 1, 1970 - 00:00 with Pacific time.
            // note that this field expects no time.

            DateTimeOffset birthDate = DateTimeOffset.Parse("01/01/1970 00:00 -8:00");


            // register and login as our first user
            var loginUser1 = randomNewUserName("TestServiceCardUser", 6);
            await ServiceCardLogin(loginUser1, loginUser1);

            // C - Create


            var request = new HttpRequestMessage(HttpMethod.Post, $"/api/contact");

            

            ViewModels.Contact contactVM = new ViewModels.Contact()
            {
                firstname = initialName,
                middlename = "TestMiddle",
                lastname = "TestLst",
                emailaddress1 = "testEmail@gov.bc.ca",
                Birthdate = birthDate,
                Gender = ViewModels.Gender.Other
            };

            // the contact service expects certain headers to exist for creation.
            request.Headers.Add("SMGOV_USEREMAIL", contactVM.emailaddress1);
            request.Headers.Add("SMGOV_GIVENNAME", contactVM.firstname);
            request.Headers.Add("SMGOV_SURNAME", contactVM.lastname);


            string jsonString = JsonConvert.SerializeObject(contactVM);
            request.Content = new StringContent(jsonString, Encoding.UTF8, "application/json");

            var response = await _client.SendAsync(request);
            jsonString = await response.Content.ReadAsStringAsync();
            response.EnsureSuccessStatusCode();

            contactVM = JsonConvert.DeserializeObject<ViewModels.Contact>(jsonString);

            request = new HttpRequestMessage(HttpMethod.Post, $"/api/{service}");

            ViewModels.Worker workerVM = new ViewModels.Worker()
            {
                firstname = contactVM.firstname,
                middlename = contactVM.lastname,
                lastname = contactVM.lastname,
                dateofbirth = contactVM.Birthdate,
                email = contactVM.emailaddress1,
                contact = contactVM,
                gender = ViewModels.Gender.Other
            };

            jsonString = JsonConvert.SerializeObject(workerVM);
            request.Content = new StringContent(jsonString, Encoding.UTF8, "application/json");

            response = await _client.SendAsync(request);
            jsonString = await response.Content.ReadAsStringAsync();
            response.EnsureSuccessStatusCode();

            workerVM = JsonConvert.DeserializeObject<ViewModels.Worker>(jsonString);

            // R -Read
            request = new HttpRequestMessage(HttpMethod.Get, $"/api/{service}/{workerVM.id}");
            response = await _client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            jsonString = await response.Content.ReadAsStringAsync();
            workerVM = JsonConvert.DeserializeObject<ViewModels.Worker>(jsonString);
            Assert.NotNull(workerVM?.id);
            
            Assert.Equal(birthDate, workerVM.contact.Birthdate);

            Assert.Equal(birthDate, workerVM.dateofbirth.Value);

            // D - Delete

            request = new HttpRequestMessage(HttpMethod.Post, $"/api/{service}/" + workerVM.id + "/delete");
            response = await _client.SendAsync(request);
            response.EnsureSuccessStatusCode();

            // second delete should return a 404.
            request = new HttpRequestMessage(HttpMethod.Post, $"/api/{service}/" + workerVM.id + "/delete");
            response = await _client.SendAsync(request);
            Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);


            // should get a 404 if we try a get now.
            request = new HttpRequestMessage(HttpMethod.Get, $"/api/{service}/" + workerVM.id);
            response = await _client.SendAsync(request);
            jsonString = await response.Content.ReadAsStringAsync();
            Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);

            await Logout();
        }

        [Fact]
        public async System.Threading.Tasks.Task TestCRUD()
        {

            string initialName = "TestFirst";
            string changedName = "ChangedName";
            string changedEmail = "newEmail@gov.bc.ca";
            string service = "contact";

            // register and login as our first user
            var loginUser1 = randomNewUserName("TestServiceCardUser", 6);
            await ServiceCardLogin(loginUser1, loginUser1);

            // C - Create

            //First create the contact
            var request = new HttpRequestMessage(HttpMethod.Post, $"/api/{service}/worker");
            ViewModels.Contact contactVM = new ViewModels.Contact() {
                firstname  = initialName,
                middlename = "TestMiddle",
                lastname = "TestLst",
                emailaddress1 = "testEmail@gov.bc.ca"
            };

            string jsonString = JsonConvert.SerializeObject(contactVM);
            request.Content = new StringContent(jsonString, Encoding.UTF8, "application/json");

            var response = await _client.SendAsync(request);
            jsonString = await response.Content.ReadAsStringAsync();
            response.EnsureSuccessStatusCode();
          
            contactVM = JsonConvert.DeserializeObject<ViewModels.Contact>(jsonString);

            // R -Read
            request = new HttpRequestMessage(HttpMethod.Get, $"/api/worker/contact/{contactVM.id}");
            response = await _client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            jsonString = await response.Content.ReadAsStringAsync();
            var workerVM = JsonConvert.DeserializeObject<List<ViewModels.Worker>>(jsonString).FirstOrDefault();
            Assert.NotNull(workerVM?.id);
            
            // U - Update            
            workerVM.firstname = changedName;
            workerVM.email = changedEmail;
            request = new HttpRequestMessage(HttpMethod.Put, "/api/worker/" + workerVM.id)
            {
                Content = new StringContent(JsonConvert.SerializeObject(workerVM), Encoding.UTF8, "application/json")
            };
            response = await _client.SendAsync(request);
            response.EnsureSuccessStatusCode();

            // verify that the update persisted.
            request = new HttpRequestMessage(HttpMethod.Get, "/api/worker/" + workerVM.id);
            response = await _client.SendAsync(request);
            response.EnsureSuccessStatusCode();

            jsonString = await response.Content.ReadAsStringAsync();
            var worker2 = JsonConvert.DeserializeObject<ViewModels.Worker>(jsonString);
            Assert.Equal(changedName, worker2.firstname);
            Assert.Equal(changedEmail, worker2.email);

            // D - Delete

            request = new HttpRequestMessage(HttpMethod.Post, "/api/worker/" + workerVM.id + "/delete");
            response = await _client.SendAsync(request);
            response.EnsureSuccessStatusCode();

            // second delete should return a 404.
            request = new HttpRequestMessage(HttpMethod.Post, "/api/worker/" + workerVM.id + "/delete");
            response = await _client.SendAsync(request);
            Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);

            // should get a 404 if we try a get now.
            request = new HttpRequestMessage(HttpMethod.Get, "/api/worker/" + workerVM.id);
            response = await _client.SendAsync(request);
            Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);

            await Logout();
        }
    }
}
