// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace IL.Library.Amazon.SPAPI.Entitlements
{
    using Microsoft.Rest;
    using Models;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Provides programmatic access to Amazon Entitlement APIs.
    /// </summary>
    public partial interface IEntitlementsClient : System.IDisposable
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
        /// Post an Update for Entitlement Info for Emerald dashboard.
        ///
        /// **Usage Plan:**
        ///
        /// | Rate (requests per second) | Burst |
        /// | ---- | ---- |
        /// | 1 | 5 |
        ///
        /// For more information, see "Usage Plans and Rate Limits" in the
        /// Selling Partner API documentation.
        /// </summary>
        /// <param name='entitlementType'>
        /// Entitlement type for which info entitlement information needs to be
        /// updated for the selling partner.
        /// </param>
        /// <param name='body'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<ErrorList,UpdateEntitlementHeaders>> UpdateEntitlementWithHttpMessagesAsync(string entitlementType, UpdateEntitlementRequest body, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Create a bulletin item for Emerald dashboard.
        ///
        /// **Usage Plan:**
        ///
        /// | Rate (requests per second) | Burst |
        /// | ---- | ---- |
        /// | 1 | 5 |
        ///
        /// For more information, see "Usage Plans and Rate Limits" in the
        /// Selling Partner API documentation.
        /// </summary>
        /// <param name='bulletinItemType'>
        /// The bulletin item type identifier provided by developer shared with
        /// bulletin templates.
        /// </param>
        /// <param name='body'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<object,CreateBulletinItemHeaders>> CreateBulletinItemWithHttpMessagesAsync(string bulletinItemType, CreateBulletinItemRequest body, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

    }
}
