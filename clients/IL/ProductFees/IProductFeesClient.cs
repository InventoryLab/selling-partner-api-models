// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace IL.Library.Amazon.SPAPI.ProductFees
{
    using Microsoft.Rest;
    using Models;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// The Selling Partner API for Product Fees lets you programmatically
    /// retrieve estimated fees for a product. You can then account for those
    /// fees in your pricing.
    /// </summary>
    public partial interface IProductFeesClient : System.IDisposable
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
        /// Returns the estimated fees for the item indicated by the specified
        /// seller SKU in the marketplace specified in the request body.
        ///
        /// You can call getMyFeesEstimateForSKU for an item on behalf of a
        /// seller before the seller sets the item's price. They can then take
        /// estimated fees into account. With each fees estimate request, you
        /// must include an original identifier. This identifier is included in
        /// the fees estimate so you can correlate a fees estimate with the
        /// original request.
        ///
        /// **Usage Plans:**
        ///
        /// | Plan type | Rate (requests per second) | Burst |
        /// | ---- | ---- | ---- |
        /// |Default| 1 | 1 |
        /// |Selling partner specific| Variable | Variable |
        ///
        /// The x-amzn-RateLimit-Limit response header returns the usage plan
        /// rate limits that were applied to the requested operation. Rate
        /// limits for some selling partners will vary from the default rate
        /// and burst shown in the table above. For more information, see
        /// "Usage Plans and Rate Limits" in the Selling Partner API
        /// documentation.
        /// </summary>
        /// <param name='body'>
        /// </param>
        /// <param name='sellerSKU'>
        /// Used to identify an item in the given marketplace. SellerSKU is
        /// qualified by the seller's SellerId, which is included with every
        /// operation that you submit.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<GetMyFeesEstimateResponse,GetMyFeesEstimateForSKUHeaders>> GetMyFeesEstimateForSKUWithHttpMessagesAsync(GetMyFeesEstimateRequest body, string sellerSKU, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Returns the estimated fees for the item indicated by the specified
        /// Asin in the marketplace specified in the request body.
        ///
        /// You can call getMyFeesEstimateForASIN for an item on behalf of a
        /// seller before the seller sets the item's price. They can then take
        /// estimated fees into account. With each product fees request, you
        /// must include an original identifier. This identifier is included in
        /// the fees estimate so you can correlate a fees estimate with the
        /// original request.
        ///
        /// **Usage Plans:**
        ///
        /// | Plan type | Rate (requests per second) | Burst |
        /// | ---- | ---- | ---- |
        /// |Default| 1 | 1 |
        /// |Selling partner specific| Variable | Variable |
        ///
        /// The x-amzn-RateLimit-Limit response header returns the usage plan
        /// rate limits that were applied to the requested operation. Rate
        /// limits for some selling partners will vary from the default rate
        /// and burst shown in the table above. For more information, see
        /// "Usage Plans and Rate Limits" in the Selling Partner API
        /// documentation.
        /// </summary>
        /// <param name='body'>
        /// </param>
        /// <param name='asin'>
        /// The Amazon Standard Identification Number (ASIN) of the item.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<GetMyFeesEstimateResponse,GetMyFeesEstimateForASINHeaders>> GetMyFeesEstimateForASINWithHttpMessagesAsync(GetMyFeesEstimateRequest body, string asin, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

    }
}
