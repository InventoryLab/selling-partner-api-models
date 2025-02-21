// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace IL.Library.Amazon.SPAPI.Sellers
{
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for SellersClient.
    /// </summary>
    public static partial class SellersClientExtensions
    {
            /// <summary>
            /// Returns a list of marketplaces that the seller submitting the request can
            /// sell in and information about the seller's participation in those
            /// marketplaces.
            ///
            /// **Usage Plan:**
            ///
            /// | Rate (requests per second) | Burst |
            /// | ---- | ---- |
            /// | .016 | 15 |
            ///
            /// For more information, see "Usage Plans and Rate Limits" in the Selling
            /// Partner API documentation.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static GetMarketplaceParticipationsResponse GetMarketplaceParticipations(this ISellersClient operations)
            {
                return operations.GetMarketplaceParticipationsAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns a list of marketplaces that the seller submitting the request can
            /// sell in and information about the seller's participation in those
            /// marketplaces.
            ///
            /// **Usage Plan:**
            ///
            /// | Rate (requests per second) | Burst |
            /// | ---- | ---- |
            /// | .016 | 15 |
            ///
            /// For more information, see "Usage Plans and Rate Limits" in the Selling
            /// Partner API documentation.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<GetMarketplaceParticipationsResponse> GetMarketplaceParticipationsAsync(this ISellersClient operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetMarketplaceParticipationsWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
