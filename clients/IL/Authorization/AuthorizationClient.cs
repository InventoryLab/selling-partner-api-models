// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace IL.Library.Amazon.SPAPI.Authorization
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Models;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// The Selling Partner API for Authorization helps developers manage
    /// authorizations and check the specific permissions associated with a
    /// given authorization.
    /// </summary>
    public partial class AuthorizationClient : ServiceClient<AuthorizationClient>, IAuthorizationClient
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        public System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        public JsonSerializerSettings SerializationSettings { get; private set; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        public JsonSerializerSettings DeserializationSettings { get; private set; }

        /// <summary>
        /// Initializes a new instance of the AuthorizationClient class.
        /// </summary>
        /// <param name='httpClient'>
        /// HttpClient to be used
        /// </param>
        /// <param name='disposeHttpClient'>
        /// True: will dispose the provided httpClient on calling AuthorizationClient.Dispose(). False: will not dispose provided httpClient</param>
        public AuthorizationClient(HttpClient httpClient, bool disposeHttpClient) : base(httpClient, disposeHttpClient)
        {
            Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the AuthorizationClient class.
        /// </summary>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        public AuthorizationClient(params DelegatingHandler[] handlers) : base(handlers)
        {
            Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the AuthorizationClient class.
        /// </summary>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        public AuthorizationClient(HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : base(rootHandler, handlers)
        {
            Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the AuthorizationClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public AuthorizationClient(System.Uri baseUri, params DelegatingHandler[] handlers) : this(handlers)
        {
            if (baseUri == null)
            {
                throw new System.ArgumentNullException("baseUri");
            }
            BaseUri = baseUri;
        }

        /// <summary>
        /// Initializes a new instance of the AuthorizationClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public AuthorizationClient(System.Uri baseUri, HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : this(rootHandler, handlers)
        {
            if (baseUri == null)
            {
                throw new System.ArgumentNullException("baseUri");
            }
            BaseUri = baseUri;
        }

        /// <summary>
        /// An optional partial-method to perform custom initialization.
        ///</summary>
        partial void CustomInitialize();
        /// <summary>
        /// Initializes client properties.
        /// </summary>
        private void Initialize()
        {
            BaseUri = new System.Uri("https://sellingpartnerapi-na.amazon.com");
            SerializationSettings = new JsonSerializerSettings
            {
                Formatting = Newtonsoft.Json.Formatting.Indented,
                DateFormatHandling = Newtonsoft.Json.DateFormatHandling.IsoDateFormat,
                DateTimeZoneHandling = Newtonsoft.Json.DateTimeZoneHandling.Utc,
                NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore,
                ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Serialize,
                ContractResolver = new ReadOnlyJsonContractResolver(),
                Converters = new  List<JsonConverter>
                    {
                        new Iso8601TimeSpanConverter()
                    }
            };
            DeserializationSettings = new JsonSerializerSettings
            {
                DateFormatHandling = Newtonsoft.Json.DateFormatHandling.IsoDateFormat,
                DateTimeZoneHandling = Newtonsoft.Json.DateTimeZoneHandling.Utc,
                NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore,
                ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Serialize,
                ContractResolver = new ReadOnlyJsonContractResolver(),
                Converters = new List<JsonConverter>
                    {
                        new Iso8601TimeSpanConverter()
                    }
            };
            CustomInitialize();
        }
        /// <summary>
        /// Returns the Login with Amazon (LWA) authorization code for an existing
        /// Amazon MWS authorization.
        /// </summary>
        /// <remarks>
        /// With the getAuthorizationCode operation, you can request a Login With
        /// Amazon (LWA) authorization code that will allow you to call a Selling
        /// Partner API on behalf of a seller who has already authorized you to call
        /// Amazon Marketplace Web Service (Amazon MWS). You specify a developer ID, an
        /// MWS auth token, and a seller ID. Taken together, these represent the Amazon
        /// MWS authorization that the seller previously granted you. The operation
        /// returns an LWA authorization code that can be exchanged for a refresh token
        /// and access token representing authorization to call the Selling Partner API
        /// on the seller's behalf. By using this API, sellers who have already
        /// authorized you for Amazon MWS do not need to re-authorize you for the
        /// Selling Partner API.
        ///
        /// **Usage Plan:**
        ///
        /// | Rate (requests per second) | Burst |
        /// | ---- | ---- |
        /// | 1 | 5 |
        ///
        /// For more information, see "Usage Plans and Rate Limits" in the Selling
        /// Partner API documentation.
        /// </remarks>
        /// <param name='sellingPartnerId'>
        /// The seller ID of the seller for whom you are requesting Selling Partner API
        /// authorization. This must be the seller ID of the seller who authorized your
        /// application on the Marketplace Appstore.
        /// </param>
        /// <param name='developerId'>
        /// Your developer ID. This must be one of the developer ID values that you
        /// provided when you registered your application in Developer Central.
        /// </param>
        /// <param name='mwsAuthToken'>
        /// The MWS Auth Token that was generated when the seller authorized your
        /// application on the Marketplace Appstore.
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
        /// <exception cref="SerializationException">
        /// Thrown when unable to deserialize the response
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
        public async Task<HttpOperationResponse<GetAuthorizationCodeResponse,GetAuthorizationCodeHeaders>> GetAuthorizationCodeWithHttpMessagesAsync(string sellingPartnerId, string developerId, string mwsAuthToken, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (sellingPartnerId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "sellingPartnerId");
            }
            if (developerId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "developerId");
            }
            if (mwsAuthToken == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "mwsAuthToken");
            }
            // Tracing
            bool _shouldTrace = ServiceClientTracing.IsEnabled;
            string _invocationId = null;
            if (_shouldTrace)
            {
                _invocationId = ServiceClientTracing.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("sellingPartnerId", sellingPartnerId);
                tracingParameters.Add("developerId", developerId);
                tracingParameters.Add("mwsAuthToken", mwsAuthToken);
                tracingParameters.Add("cancellationToken", cancellationToken);
                ServiceClientTracing.Enter(_invocationId, this, "GetAuthorizationCode", tracingParameters);
            }
            // Construct URL
            var _baseUrl = BaseUri.AbsoluteUri;
            var _url = new System.Uri(new System.Uri(_baseUrl + (_baseUrl.EndsWith("/") ? "" : "/")), "authorization/v1/authorizationCode").ToString();
            List<string> _queryParameters = new List<string>();
            if (sellingPartnerId != null)
            {
                _queryParameters.Add(string.Format("sellingPartnerId={0}", System.Uri.EscapeDataString(sellingPartnerId)));
            }
            if (developerId != null)
            {
                _queryParameters.Add(string.Format("developerId={0}", System.Uri.EscapeDataString(developerId)));
            }
            if (mwsAuthToken != null)
            {
                _queryParameters.Add(string.Format("mwsAuthToken={0}", System.Uri.EscapeDataString(mwsAuthToken)));
            }
            if (_queryParameters.Count > 0)
            {
                _url += "?" + string.Join("&", _queryParameters);
            }
            // Create HTTP transport objects
            var _httpRequest = new HttpRequestMessage();
            HttpResponseMessage _httpResponse = null;
            _httpRequest.Method = new HttpMethod("GET");
            _httpRequest.RequestUri = new System.Uri(_url);
            // Set Headers


            if (customHeaders != null)
            {
                foreach(var _header in customHeaders)
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
            // Send Request
            if (_shouldTrace)
            {
                ServiceClientTracing.SendRequest(_invocationId, _httpRequest);
            }
            cancellationToken.ThrowIfCancellationRequested();
            await IL.Library.Amazon.SPAPI.SharedRuntime.SPAPIInterceptor.PrepareRequest(amazonUserKeyPair, _httpRequest, _configuration, _tokenManagement);
            _httpResponse = await HttpClient.SendAsync(_httpRequest, cancellationToken).ConfigureAwait(false);
            if (_shouldTrace)
            {
                ServiceClientTracing.ReceiveResponse(_invocationId, _httpResponse);
            }
            HttpStatusCode _statusCode = _httpResponse.StatusCode;
            cancellationToken.ThrowIfCancellationRequested();
            string _responseContent = null;
            if ((int)_statusCode != 200 && (int)_statusCode != 400 && (int)_statusCode != 403 && (int)_statusCode != 404 && (int)_statusCode != 413 && (int)_statusCode != 415 && (int)_statusCode != 429 && (int)_statusCode != 500 && (int)_statusCode != 503)
            {
                var ex = new HttpOperationException(string.Format("Operation returned an invalid status code '{0}'", _statusCode));
                if (_httpResponse.Content != null) {
                    _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                }
                else {
                    _responseContent = string.Empty;
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
            var _result = new HttpOperationResponse<GetAuthorizationCodeResponse,GetAuthorizationCodeHeaders>();
            _result.Request = _httpRequest;
            _result.Response = _httpResponse;
            // Deserialize Response
            if ((int)_statusCode == 200)
            {
                _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                try
                {
                    _result.Body = SafeJsonConvert.DeserializeObject<GetAuthorizationCodeResponse>(_responseContent, DeserializationSettings);
                    await IL.Library.Amazon.SPAPI.SharedRuntime.SPAPIInterceptor.PrepareResponse<GetAuthorizationCodeResponse>((int)_statusCode, _result.Body, _httpResponse);
                }
                catch (JsonException ex)
                {
                    _httpRequest.Dispose();
                    if (_httpResponse != null)
                    {
                        _httpResponse.Dispose();
                    }
                    throw new SerializationException("Unable to deserialize the response.", _responseContent, ex);
                }
            }
            // Deserialize Response
            if ((int)_statusCode == 400)
            {
                _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                try
                {
                    _result.Body = SafeJsonConvert.DeserializeObject<GetAuthorizationCodeResponse>(_responseContent, DeserializationSettings);
                    await IL.Library.Amazon.SPAPI.SharedRuntime.SPAPIInterceptor.PrepareResponse<GetAuthorizationCodeResponse>((int)_statusCode, _result.Body, _httpResponse);
                }
                catch (JsonException ex)
                {
                    _httpRequest.Dispose();
                    if (_httpResponse != null)
                    {
                        _httpResponse.Dispose();
                    }
                    throw new SerializationException("Unable to deserialize the response.", _responseContent, ex);
                }
            }
            // Deserialize Response
            if ((int)_statusCode == 403)
            {
                _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                try
                {
                    _result.Body = SafeJsonConvert.DeserializeObject<GetAuthorizationCodeResponse>(_responseContent, DeserializationSettings);
                    await IL.Library.Amazon.SPAPI.SharedRuntime.SPAPIInterceptor.PrepareResponse<GetAuthorizationCodeResponse>((int)_statusCode, _result.Body, _httpResponse);
                }
                catch (JsonException ex)
                {
                    _httpRequest.Dispose();
                    if (_httpResponse != null)
                    {
                        _httpResponse.Dispose();
                    }
                    throw new SerializationException("Unable to deserialize the response.", _responseContent, ex);
                }
            }
            // Deserialize Response
            if ((int)_statusCode == 404)
            {
                _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                try
                {
                    _result.Body = SafeJsonConvert.DeserializeObject<GetAuthorizationCodeResponse>(_responseContent, DeserializationSettings);
                    await IL.Library.Amazon.SPAPI.SharedRuntime.SPAPIInterceptor.PrepareResponse<GetAuthorizationCodeResponse>((int)_statusCode, _result.Body, _httpResponse);
                }
                catch (JsonException ex)
                {
                    _httpRequest.Dispose();
                    if (_httpResponse != null)
                    {
                        _httpResponse.Dispose();
                    }
                    throw new SerializationException("Unable to deserialize the response.", _responseContent, ex);
                }
            }
            // Deserialize Response
            if ((int)_statusCode == 413)
            {
                _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                try
                {
                    _result.Body = SafeJsonConvert.DeserializeObject<GetAuthorizationCodeResponse>(_responseContent, DeserializationSettings);
                    await IL.Library.Amazon.SPAPI.SharedRuntime.SPAPIInterceptor.PrepareResponse<GetAuthorizationCodeResponse>((int)_statusCode, _result.Body, _httpResponse);
                }
                catch (JsonException ex)
                {
                    _httpRequest.Dispose();
                    if (_httpResponse != null)
                    {
                        _httpResponse.Dispose();
                    }
                    throw new SerializationException("Unable to deserialize the response.", _responseContent, ex);
                }
            }
            // Deserialize Response
            if ((int)_statusCode == 415)
            {
                _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                try
                {
                    _result.Body = SafeJsonConvert.DeserializeObject<GetAuthorizationCodeResponse>(_responseContent, DeserializationSettings);
                    await IL.Library.Amazon.SPAPI.SharedRuntime.SPAPIInterceptor.PrepareResponse<GetAuthorizationCodeResponse>((int)_statusCode, _result.Body, _httpResponse);
                }
                catch (JsonException ex)
                {
                    _httpRequest.Dispose();
                    if (_httpResponse != null)
                    {
                        _httpResponse.Dispose();
                    }
                    throw new SerializationException("Unable to deserialize the response.", _responseContent, ex);
                }
            }
            // Deserialize Response
            if ((int)_statusCode == 429)
            {
                _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                try
                {
                    _result.Body = SafeJsonConvert.DeserializeObject<GetAuthorizationCodeResponse>(_responseContent, DeserializationSettings);
                    await IL.Library.Amazon.SPAPI.SharedRuntime.SPAPIInterceptor.PrepareResponse<GetAuthorizationCodeResponse>((int)_statusCode, _result.Body, _httpResponse);
                }
                catch (JsonException ex)
                {
                    _httpRequest.Dispose();
                    if (_httpResponse != null)
                    {
                        _httpResponse.Dispose();
                    }
                    throw new SerializationException("Unable to deserialize the response.", _responseContent, ex);
                }
            }
            // Deserialize Response
            if ((int)_statusCode == 500)
            {
                _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                try
                {
                    _result.Body = SafeJsonConvert.DeserializeObject<GetAuthorizationCodeResponse>(_responseContent, DeserializationSettings);
                    await IL.Library.Amazon.SPAPI.SharedRuntime.SPAPIInterceptor.PrepareResponse<GetAuthorizationCodeResponse>((int)_statusCode, _result.Body, _httpResponse);
                }
                catch (JsonException ex)
                {
                    _httpRequest.Dispose();
                    if (_httpResponse != null)
                    {
                        _httpResponse.Dispose();
                    }
                    throw new SerializationException("Unable to deserialize the response.", _responseContent, ex);
                }
            }
            // Deserialize Response
            if ((int)_statusCode == 503)
            {
                _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                try
                {
                    _result.Body = SafeJsonConvert.DeserializeObject<GetAuthorizationCodeResponse>(_responseContent, DeserializationSettings);
                    await IL.Library.Amazon.SPAPI.SharedRuntime.SPAPIInterceptor.PrepareResponse<GetAuthorizationCodeResponse>((int)_statusCode, _result.Body, _httpResponse);
                }
                catch (JsonException ex)
                {
                    _httpRequest.Dispose();
                    if (_httpResponse != null)
                    {
                        _httpResponse.Dispose();
                    }
                    throw new SerializationException("Unable to deserialize the response.", _responseContent, ex);
                }
            }
            try
            {
                _result.Headers = _httpResponse.GetHeadersAsJson().ToObject<GetAuthorizationCodeHeaders>(JsonSerializer.Create(DeserializationSettings));
            }
            catch (JsonException ex)
            {
                _httpRequest.Dispose();
                if (_httpResponse != null)
                {
                    _httpResponse.Dispose();
                }
                throw new SerializationException("Unable to deserialize the headers.", _httpResponse.GetHeadersAsJson().ToString(), ex);
            }
            if (_shouldTrace)
            {
                ServiceClientTracing.Exit(_invocationId, _result);
            }
            return _result;
        }

    }
}
