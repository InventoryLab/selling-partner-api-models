// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace IL.Library.Amazon.SPAPI.Finances.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Defines headers for listFinancialEvents operation.
    /// </summary>
    public partial class ListFinancialEventsHeaders
    {
        /// <summary>
        /// Initializes a new instance of the ListFinancialEventsHeaders class.
        /// </summary>
        public ListFinancialEventsHeaders()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ListFinancialEventsHeaders class.
        /// </summary>
        /// <param name="xAmznRequestId">Unique request reference
        /// identifier.</param>
        /// <param name="xAmznRateLimitLimit">Your rate limit (requests per
        /// second) for this operation.
        /// _Note:_ For this status code, the rate limit header is deprecated
        /// and no longer returned.</param>
        public ListFinancialEventsHeaders(string xAmznRequestId = default(string), string xAmznRateLimitLimit = default(string))
        {
            XAmznRequestId = xAmznRequestId;
            XAmznRateLimitLimit = xAmznRateLimitLimit;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets unique request reference identifier.
        /// </summary>
        [JsonProperty(PropertyName = "x-amzn-RequestId")]
        public string XAmznRequestId { get; set; }

        /// <summary>
        /// Gets or sets your rate limit (requests per second) for this
        /// operation.
        /// _Note:_ For this status code, the rate limit header is deprecated
        /// and no longer returned.
        /// </summary>
        [JsonProperty(PropertyName = "x-amzn-RateLimit-Limit")]
        public string XAmznRateLimitLimit { get; set; }

    }
}
