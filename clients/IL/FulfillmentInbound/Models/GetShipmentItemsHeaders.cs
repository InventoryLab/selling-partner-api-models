// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace IL.Library.Amazon.SPAPI.FulfillmentInbound.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Defines headers for getShipmentItems operation.
    /// </summary>
    public partial class GetShipmentItemsHeaders
    {
        /// <summary>
        /// Initializes a new instance of the GetShipmentItemsHeaders class.
        /// </summary>
        public GetShipmentItemsHeaders()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GetShipmentItemsHeaders class.
        /// </summary>
        /// <param name="xAmznRateLimitLimit">Your rate limit (requests per
        /// second) for this operation.</param>
        /// <param name="xAmznRequestid">Unique request reference
        /// identifier.</param>
        public GetShipmentItemsHeaders(string xAmznRateLimitLimit = default(string), string xAmznRequestid = default(string))
        {
            XAmznRateLimitLimit = xAmznRateLimitLimit;
            XAmznRequestid = xAmznRequestid;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets your rate limit (requests per second) for this
        /// operation.
        /// </summary>
        [JsonProperty(PropertyName = "x-amzn-RateLimit-Limit")]
        public string XAmznRateLimitLimit { get; set; }

        /// <summary>
        /// Gets or sets unique request reference identifier.
        /// </summary>
        [JsonProperty(PropertyName = "x-amzn-requestid")]
        public string XAmznRequestid { get; set; }

    }
}
