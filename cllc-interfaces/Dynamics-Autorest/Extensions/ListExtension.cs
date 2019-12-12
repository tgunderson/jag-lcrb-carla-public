﻿using Gov.Lclb.Cllb.Interfaces.Models;
using Microsoft.Rest;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Gov.Lclb.Cllb.Interfaces
{

    public partial class Lists : IServiceOperations<DynamicsClient>, ILists
    {

        /// <summary>
        /// Add a list member
        /// </summary>
        /// <param name='listId'>
        /// key: adoxio_workerid
        /// </param>
        /// <param name='fieldname'>
        /// key: fieldname
        /// </param>
        /// <param name='entityId'>
        /// reference value
        /// </param>
        /// <param name='customHeaders'>
        /// Headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        /// <return>
        /// A response object containing the response body and response headers.
        /// </return>
        public async Task<HttpOperationResponse> AddMemberWithHttpMessagesAsync(string listId, EntityIdReference entityId = default(EntityIdReference), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (listId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "workerId");
            }
            
            if (entityId != null)
            {
                entityId.Validate();
            }
            // Tracing
            bool _shouldTrace = ServiceClientTracing.IsEnabled;
            string _invocationId = null;
            if (_shouldTrace)
            {
                _invocationId = ServiceClientTracing.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("listId", listId);
                tracingParameters.Add("odataid", entityId);
                tracingParameters.Add("cancellationToken", cancellationToken);
                ServiceClientTracing.Enter(_invocationId, this, "AddReference", tracingParameters);
            }
            // Construct URL
            var _baseUrl = Client.BaseUri.AbsoluteUri;
            var _url = new System.Uri(new System.Uri(_baseUrl + (_baseUrl.EndsWith("/") ? "" : "/")), "lists({listId})/Microsoft.Dynamics.CRM.AddMemberList").ToString();
            _url = _url.Replace("{listId}", System.Uri.EscapeDataString(listId));            
            // Create HTTP transport objects
            var _httpRequest = new HttpRequestMessage();
            HttpResponseMessage _httpResponse = null;
            _httpRequest.Method = new HttpMethod("POST");
            _httpRequest.RequestUri = new System.Uri(_url);
            // Set Headers


            if (customHeaders != null)
            {
                foreach (var _header in customHeaders)
                {
                    if (_httpRequest.Headers.Contains(_header.Key))
                    {
                        _httpRequest.Headers.Remove(_header.Key);
                    }
                    _httpRequest.Headers.TryAddWithoutValidation(_header.Key, _header.Value);
                }
            }

            // Serialize Request
            string _requestContent = null;
            if (entityId != null)
            {
                _requestContent = Microsoft.Rest.Serialization.SafeJsonConvert.SerializeObject(entityId, Client.SerializationSettings);
                _httpRequest.Content = new StringContent(_requestContent, System.Text.Encoding.UTF8);
                _httpRequest.Content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json; charset=utf-8");
            }
            // Set Credentials
            if (Client.Credentials != null)
            {
                cancellationToken.ThrowIfCancellationRequested();
                await Client.Credentials.ProcessHttpRequestAsync(_httpRequest, cancellationToken).ConfigureAwait(false);
            }
            // Send Request
            if (_shouldTrace)
            {
                ServiceClientTracing.SendRequest(_invocationId, _httpRequest);
            }
            cancellationToken.ThrowIfCancellationRequested();
            _httpResponse = await Client.HttpClient.SendAsync(_httpRequest, cancellationToken).ConfigureAwait(false);
            if (_shouldTrace)
            {
                ServiceClientTracing.ReceiveResponse(_invocationId, _httpResponse);
            }
            HttpStatusCode _statusCode = _httpResponse.StatusCode;
            cancellationToken.ThrowIfCancellationRequested();
            string _responseContent = null;
            if ((int)_statusCode != 200) // OK
            {
                var ex = new HttpOperationException(string.Format("Operation returned an invalid status code '{0}'", _statusCode));
                try
                {
                    _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                    Odataerror _errorBody = Microsoft.Rest.Serialization.SafeJsonConvert.DeserializeObject<Odataerror>(_responseContent, Client.DeserializationSettings);
                    if (_errorBody != null)
                    {
                        ex.Body = _errorBody;
                    }
                }
                catch (JsonException)
                {
                    // Ignore the exception
                }
                ex.Request = new HttpRequestMessageWrapper(_httpRequest, _requestContent);
                ex.Response = new HttpResponseMessageWrapper(_httpResponse, _responseContent);
                if (_shouldTrace)
                {
                    ServiceClientTracing.Error(_invocationId, ex);
                }
                _httpRequest.Dispose();
                if (_httpResponse != null)
                {
                    _httpResponse.Dispose();
                }
                throw ex;
            }
            // Create Result
            var _result = new HttpOperationResponse();
            _result.Request = _httpRequest;
            _result.Response = _httpResponse;
            if (_shouldTrace)
            {
                ServiceClientTracing.Exit(_invocationId, _result);
            }
            return _result;
        }
    }

    public partial interface ILists
    {
        /// <summary>
        /// Add reference to adoxio_workers
        /// </summary>
        /// <param name='workerId'>
        /// key: adoxio_workerid
        /// </param>
        /// <param name='fieldname'>
        /// key: fieldname
        /// </param>
        /// <param name='entityId'>
        /// reference value
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse> AddMemberWithHttpMessagesAsync(string listId, EntityIdReference entityId = default(EntityIdReference), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }

    public static partial class ListsExtensions
    {
        /// <summary>
        /// Add reference to adoxio_workers
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='listId'>
        /// key: adoxio_workerid
        /// </param>
        /// <param name='fieldname'>
        /// key: fieldname
        /// </param>
        /// <param name='entityId'>
        /// reference value
        /// </param>
        public static void AddMember(this ILists operations, string listId, EntityIdReference entityId = default(EntityIdReference))
        {
            operations.AddMemberAsync(listId, entityId).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Add reference to adoxio_workers
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='workerId'>
        /// key: adoxio_workerid
        /// </param>
        /// <param name='fieldname'>
        /// key: fieldname
        /// </param>
        /// <param name='entityId'>
        /// reference value
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task AddMemberAsync(this ILists operations, string workerId, EntityIdReference entityId = default(EntityIdReference), CancellationToken cancellationToken = default(CancellationToken))
        {
            (await operations.AddMemberWithHttpMessagesAsync(workerId, entityId, null, cancellationToken).ConfigureAwait(false)).Dispose();
        }
    }
}