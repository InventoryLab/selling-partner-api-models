// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace IL.Library.Amazon.SPAPI.CatalogItems
{
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for CatalogItemsClient.
    /// </summary>
    public static partial class CatalogItemsClientExtensions
    {
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
            /// The x-amzn-RateLimit-Limit response header returns the usage plan rate
            /// limits that were applied to the requested operation. Rate limits for some
            /// selling partners will vary from the default rate and burst shown in the
            /// table above. For more information, see "Usage Plans and Rate Limits" in the
            /// Selling Partner API documentation.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='asin'>
            /// The Amazon Standard Identification Number (ASIN) of the item.
            /// </param>
            /// <param name='marketplaceIds'>
            /// A comma-delimited list of Amazon marketplace identifiers. Data sets in the
            /// response contain data only for the specified marketplaces.
            /// </param>
            /// <param name='includedData'>
            /// A comma-delimited list of data sets to include in the response.
            /// </param>
            public static object GetCatalogItem(this ICatalogItemsClient operations, string asin, IList<string> marketplaceIds, IList<string> includedData = default(IList<string>))
            {
                return operations.GetCatalogItemAsync(asin, marketplaceIds, includedData).GetAwaiter().GetResult();
            }

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
            /// The x-amzn-RateLimit-Limit response header returns the usage plan rate
            /// limits that were applied to the requested operation. Rate limits for some
            /// selling partners will vary from the default rate and burst shown in the
            /// table above. For more information, see "Usage Plans and Rate Limits" in the
            /// Selling Partner API documentation.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='asin'>
            /// The Amazon Standard Identification Number (ASIN) of the item.
            /// </param>
            /// <param name='marketplaceIds'>
            /// A comma-delimited list of Amazon marketplace identifiers. Data sets in the
            /// response contain data only for the specified marketplaces.
            /// </param>
            /// <param name='includedData'>
            /// A comma-delimited list of data sets to include in the response.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> GetCatalogItemAsync(this ICatalogItemsClient operations, string asin, IList<string> marketplaceIds, IList<string> includedData = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetCatalogItemWithHttpMessagesAsync(asin, marketplaceIds, includedData, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
