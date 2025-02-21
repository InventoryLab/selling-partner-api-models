// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace IL.Library.Amazon.SPAPI.Entitlements
{
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for EntitlementsClient.
    /// </summary>
    public static partial class EntitlementsClientExtensions
    {
            /// <summary>
            /// Post an Update for Entitlement Info for Emerald dashboard.
            ///
            /// **Usage Plan:**
            ///
            /// | Rate (requests per second) | Burst |
            /// | ---- | ---- |
            /// | 1 | 5 |
            ///
            /// For more information, see "Usage Plans and Rate Limits" in the Selling
            /// Partner API documentation.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='entitlementType'>
            /// Entitlement type for which info entitlement information needs to be updated
            /// for the selling partner.
            /// </param>
            /// <param name='body'>
            /// </param>
            public static ErrorList UpdateEntitlement(this IEntitlementsClient operations, string entitlementType, UpdateEntitlementRequest body)
            {
                return operations.UpdateEntitlementAsync(entitlementType, body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Post an Update for Entitlement Info for Emerald dashboard.
            ///
            /// **Usage Plan:**
            ///
            /// | Rate (requests per second) | Burst |
            /// | ---- | ---- |
            /// | 1 | 5 |
            ///
            /// For more information, see "Usage Plans and Rate Limits" in the Selling
            /// Partner API documentation.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='entitlementType'>
            /// Entitlement type for which info entitlement information needs to be updated
            /// for the selling partner.
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ErrorList> UpdateEntitlementAsync(this IEntitlementsClient operations, string entitlementType, UpdateEntitlementRequest body, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateEntitlementWithHttpMessagesAsync(entitlementType, body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create a bulletin item for Emerald dashboard.
            ///
            /// **Usage Plan:**
            ///
            /// | Rate (requests per second) | Burst |
            /// | ---- | ---- |
            /// | 1 | 5 |
            ///
            /// For more information, see "Usage Plans and Rate Limits" in the Selling
            /// Partner API documentation.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='bulletinItemType'>
            /// The bulletin item type identifier provided by developer shared with
            /// bulletin templates.
            /// </param>
            /// <param name='body'>
            /// </param>
            public static object CreateBulletinItem(this IEntitlementsClient operations, string bulletinItemType, CreateBulletinItemRequest body)
            {
                return operations.CreateBulletinItemAsync(bulletinItemType, body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create a bulletin item for Emerald dashboard.
            ///
            /// **Usage Plan:**
            ///
            /// | Rate (requests per second) | Burst |
            /// | ---- | ---- |
            /// | 1 | 5 |
            ///
            /// For more information, see "Usage Plans and Rate Limits" in the Selling
            /// Partner API documentation.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='bulletinItemType'>
            /// The bulletin item type identifier provided by developer shared with
            /// bulletin templates.
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> CreateBulletinItemAsync(this IEntitlementsClient operations, string bulletinItemType, CreateBulletinItemRequest body, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateBulletinItemWithHttpMessagesAsync(bulletinItemType, body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
