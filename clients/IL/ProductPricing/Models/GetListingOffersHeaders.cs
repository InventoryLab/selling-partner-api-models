// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace IL.Library.Amazon.SPAPI.ProductPricing.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Defines headers for getListingOffers operation.
    /// </summary>
    public partial class GetListingOffersHeaders
    {
        /// <summary>
        /// Initializes a new instance of the GetListingOffersHeaders class.
        /// </summary>
        public GetListingOffersHeaders()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GetListingOffersHeaders class.
        /// </summary>
        /// <param name="xAmznRateLimitLimit">Your rate limit (requests per
        /// second) for this operation.
        /// _Note:_ For this status code, the rate limit header is deprecated
        /// and no longer returned.</param>
        /// <param name="xAmznRequestId">Unique request reference ID.</param>
        public GetListingOffersHeaders(string xAmznRateLimitLimit = default(string), string xAmznRequestId = default(string))
        {
            XAmznRateLimitLimit = xAmznRateLimitLimit;
            XAmznRequestId = xAmznRequestId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets your rate limit (requests per second) for this
        /// operation.
        /// _Note:_ For this status code, the rate limit header is deprecated
        /// and no longer returned.
        /// </summary>
        [JsonProperty(PropertyName = "x-amzn-RateLimit-Limit")]
        public string XAmznRateLimitLimit { get; set; }

        /// <summary>
        /// Gets or sets unique request reference ID.
        /// </summary>
        [JsonProperty(PropertyName = "x-amzn-RequestId")]
        public string XAmznRequestId { get; set; }

    }
}
