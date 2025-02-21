// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace IL.Library.Amazon.SPAPI.ListingsRestrictions
{
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ListingsRestrictionsClient.
    /// </summary>
    public static partial class ListingsRestrictionsClientExtensions
    {
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
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
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
            public static object GetListingsRestrictions(this IListingsRestrictionsClient operations, string asin, string sellerId, IList<string> marketplaceIds, string conditionType = default(string), string reasonLocale = default(string))
            {
                return operations.GetListingsRestrictionsAsync(asin, sellerId, marketplaceIds, conditionType, reasonLocale).GetAwaiter().GetResult();
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
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
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
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> GetListingsRestrictionsAsync(this IListingsRestrictionsClient operations, string asin, string sellerId, IList<string> marketplaceIds, string conditionType = default(string), string reasonLocale = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetListingsRestrictionsWithHttpMessagesAsync(asin, sellerId, marketplaceIds, conditionType, reasonLocale, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
