// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace IL.Library.Amazon.SPAPI.ListingsRestrictions
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
    /// The Selling Partner API for Listings Restrictions provides programmatic
    /// access to restrictions on Amazon catalog listings.
    ///
    /// For more information, see the [Listings Restrictions API Use Case
    /// Guide](https://github.com/amzn/selling-partner-api-docs/blob/main/guides/en-US/use-case-guides/listings-restrictions-api-use-case-guide/listings-restrictions-api-use-case-guide_2021-08-01.md).
    /// </summary>
    public partial class ListingsRestrictionsClient : ServiceClient<ListingsRestrictionsClient>, IListingsRestrictionsClient
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
        /// Initializes a new instance of the ListingsRestrictionsClient class.
        /// </summary>
        /// <param name='httpClient'>
        /// HttpClient to be used
        /// </param>
        /// <param name='disposeHttpClient'>
        /// True: will dispose the provided httpClient on calling ListingsRestrictionsClient.Dispose(). False: will not dispose provided httpClient</param>
        public ListingsRestrictionsClient(HttpClient httpClient, bool disposeHttpClient) : base(httpClient, disposeHttpClient)
        {
            Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the ListingsRestrictionsClient class.
        /// </summary>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        public ListingsRestrictionsClient(params DelegatingHandler[] handlers) : base(handlers)
        {
            Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the ListingsRestrictionsClient class.
        /// </summary>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        public ListingsRestrictionsClient(HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : base(rootHandler, handlers)
        {
            Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the ListingsRestrictionsClient class.
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
        public ListingsRestrictionsClient(System.Uri baseUri, params DelegatingHandler[] handlers) : this(handlers)
        {
            if (baseUri == null)
            {
                throw new System.ArgumentNullException("baseUri");
            }
            BaseUri = baseUri;
        }

        /// <summary>
        /// Initializes a new instance of the ListingsRestrictionsClient class.
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
        public ListingsRestrictionsClient(System.Uri baseUri, HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : this(rootHandler, handlers)
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
        /// Returns listing restrictions for an item in the Amazon Catalog.
        ///
        /// **Usage Plan:**
        ///
        /// | Rate (requests per second) | Burst |
        /// | ---- | ---- |
        /// | 5 | 10 |
        ///
        /// The `x-amzn-RateLimit-Limit` response header returns the usage plan rate
        /// limits that were applied to the requested operation, when available. The
        /// table above indicates the default rate and burst values for this operation.
        /// Selling partners whose business demands require higher throughput may see
        /// higher rate and burst values then those shown here. For more information,
        /// see [Usage Plans and Rate Limits in the Selling Partner
        /// API](https://github.com/amzn/selling-partner-api-docs/blob/main/guides/en-US/usage-plans-rate-limits/Usage-Plans-and-Rate-Limits.md).
        /// </summary>
        /// <param name='asin'>
        /// The Amazon Standard Identification Number (ASIN) of the item.
        /// </param>
        /// <param name='sellerId'>
        /// A selling partner identifier, such as a merchant account.
        /// </param>
        /// <param name='marketplaceIds'>
        /// A comma-delimited list of Amazon marketplace identifiers for the request.
        /// </param>
        /// <param name='conditionType'>
        /// The condition used to filter restrictions. Possible values include:
        /// 'new_new', 'new_open_box', 'new_oem', 'refurbished_refurbished',
        /// 'used_like_new', 'used_very_good', 'used_good', 'used_acceptable',
        /// 'collectible_like_new', 'collectible_very_good', 'collectible_good',
        /// 'collectible_acceptable', 'club_club'
        /// </param>
        /// <param name='reasonLocale'>
        /// A locale for reason text localization. When not provided, the default
        /// language code of the first marketplace is used. Examples: "en_US", "fr_CA",
        /// "fr_FR". Localized messages default to "en_US" when a localization is not
        /// available in the specified locale.
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
        public async Task<HttpOperationResponse<object,GetListingsRestrictionsHeaders>> GetListingsRestrictionsWithHttpMessagesAsync(string asin, string sellerId, IList<string> marketplaceIds, string conditionType = default(string), string reasonLocale = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (asin == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "asin");
            }
            if (sellerId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "sellerId");
            }
            if (marketplaceIds == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "marketplaceIds");
            }
            // Tracing
            bool _shouldTrace = ServiceClientTracing.IsEnabled;
            string _invocationId = null;
            if (_shouldTrace)
            {
                _invocationId = ServiceClientTracing.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("asin", asin);
                tracingParameters.Add("conditionType", conditionType);
                tracingParameters.Add("sellerId", sellerId);
                tracingParameters.Add("marketplaceIds", marketplaceIds);
                tracingParameters.Add("reasonLocale", reasonLocale);
                tracingParameters.Add("cancellationToken", cancellationToken);
                ServiceClientTracing.Enter(_invocationId, this, "GetListingsRestrictions", tracingParameters);
            }
            // Construct URL
            var _baseUrl = BaseUri.AbsoluteUri;
            var _url = new System.Uri(new System.Uri(_baseUrl + (_baseUrl.EndsWith("/") ? "" : "/")), "listings/2021-08-01/restrictions").ToString();
            List<string> _queryParameters = new List<string>();
            if (asin != null)
            {
                _queryParameters.Add(string.Format("asin={0}", System.Uri.EscapeDataString(asin)));
            }
            if (conditionType != null)
            {
                _queryParameters.Add(string.Format("conditionType={0}", System.Uri.EscapeDataString(SafeJsonConvert.SerializeObject(conditionType, SerializationSettings).Trim('"'))));
            }
            if (sellerId != null)
            {
                _queryParameters.Add(string.Format("sellerId={0}", System.Uri.EscapeDataString(sellerId)));
            }
            if (marketplaceIds != null)
            {
                _queryParameters.Add(string.Format("marketplaceIds={0}", System.Uri.EscapeDataString(string.Join(",", marketplaceIds))));
            }
            if (reasonLocale != null)
            {
                _queryParameters.Add(string.Format("reasonLocale={0}", System.Uri.EscapeDataString(reasonLocale)));
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
            await IL.Library.Amazon.SPAPI.SharedRuntime.SPAPIInterceptor.PrepareRequest(_sPAPIUserKeyPair, _httpRequest, _configuration, _tokenManagement);
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
            var _result = new HttpOperationResponse<object,GetListingsRestrictionsHeaders>();
            _result.Request = _httpRequest;
            _result.Response = _httpResponse;
            // Deserialize Response
            if ((int)_statusCode == 200)
            {
                _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                try
                {
                    _result.Body = SafeJsonConvert.DeserializeObject<RestrictionList>(_responseContent, DeserializationSettings);
                    await IL.Library.Amazon.SPAPI.SharedRuntime.SPAPIInterceptor.PrepareResponse<RestrictionList>((int)_statusCode, _result.Body, _httpResponse);
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
                    _result.Body = SafeJsonConvert.DeserializeObject<IList<Error>>(_responseContent, DeserializationSettings);
                    await IL.Library.Amazon.SPAPI.SharedRuntime.SPAPIInterceptor.PrepareResponse<IList<Error>((int)_statusCode, _result.Body, _httpResponse);
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
                    _result.Body = SafeJsonConvert.DeserializeObject<IList<Error>>(_responseContent, DeserializationSettings);
                    await IL.Library.Amazon.SPAPI.SharedRuntime.SPAPIInterceptor.PrepareResponse<IList<Error>((int)_statusCode, _result.Body, _httpResponse);
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
                    _result.Body = SafeJsonConvert.DeserializeObject<IList<Error>>(_responseContent, DeserializationSettings);
                    await IL.Library.Amazon.SPAPI.SharedRuntime.SPAPIInterceptor.PrepareResponse<IList<Error>((int)_statusCode, _result.Body, _httpResponse);
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
                    _result.Body = SafeJsonConvert.DeserializeObject<IList<Error>>(_responseContent, DeserializationSettings);
                    await IL.Library.Amazon.SPAPI.SharedRuntime.SPAPIInterceptor.PrepareResponse<IList<Error>((int)_statusCode, _result.Body, _httpResponse);
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
                    _result.Body = SafeJsonConvert.DeserializeObject<IList<Error>>(_responseContent, DeserializationSettings);
                    await IL.Library.Amazon.SPAPI.SharedRuntime.SPAPIInterceptor.PrepareResponse<IList<Error>((int)_statusCode, _result.Body, _httpResponse);
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
                    _result.Body = SafeJsonConvert.DeserializeObject<IList<Error>>(_responseContent, DeserializationSettings);
                    await IL.Library.Amazon.SPAPI.SharedRuntime.SPAPIInterceptor.PrepareResponse<IList<Error>((int)_statusCode, _result.Body, _httpResponse);
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
                    _result.Body = SafeJsonConvert.DeserializeObject<IList<Error>>(_responseContent, DeserializationSettings);
                    await IL.Library.Amazon.SPAPI.SharedRuntime.SPAPIInterceptor.PrepareResponse<IList<Error>((int)_statusCode, _result.Body, _httpResponse);
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
                    _result.Body = SafeJsonConvert.DeserializeObject<IList<Error>>(_responseContent, DeserializationSettings);
                    await IL.Library.Amazon.SPAPI.SharedRuntime.SPAPIInterceptor.PrepareResponse<IList<Error>((int)_statusCode, _result.Body, _httpResponse);
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
                _result.Headers = _httpResponse.GetHeadersAsJson().ToObject<GetListingsRestrictionsHeaders>(JsonSerializer.Create(DeserializationSettings));
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
