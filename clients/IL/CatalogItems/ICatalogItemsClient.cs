// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace IL.Library.Amazon.SPAPI.CatalogItems
{
    using Microsoft.Rest;
    using Models;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// The Selling Partner API for Catalog Items provides programmatic access
    /// to information about items in the Amazon catalog.
    /// </summary>
    public partial interface ICatalogItemsClient : System.IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        JsonSerializerSettings DeserializationSettings { get; }


        /// <summary>
        /// Retrieves details for an item in the Amazon catalog.
        ///
        /// **Usage Plans:**
        ///
        /// | Plan type | Rate (requests per second) | Burst |
        /// | ---- | ---- | ---- |
        /// |Default| 5 | 5 |
        /// |Selling partner specific| Variable | Variable |
        ///
        /// The x-amzn-RateLimit-Limit response header returns the usage plan
        /// rate limits that were applied to the requested operation. Rate
        /// limits for some selling partners will vary from the default rate
        /// and burst shown in the table above. For more information, see
        /// "Usage Plans and Rate Limits" in the Selling Partner API
        /// documentation.
        /// </summary>
        /// <param name='asin'>
        /// The Amazon Standard Identification Number (ASIN) of the item.
        /// </param>
        /// <param name='marketplaceIds'>
        /// A comma-delimited list of Amazon marketplace identifiers. Data sets
        /// in the response contain data only for the specified marketplaces.
        /// </param>
        /// <param name='includedData'>
        /// A comma-delimited list of data sets to include in the response.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<object,GetCatalogItemHeaders>> GetCatalogItemWithHttpMessagesAsync(string asin, IList<string> marketplaceIds, IList<string> includedData = default(IList<string>), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

    }
}
