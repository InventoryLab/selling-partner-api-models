// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace IL.Library.Amazon.SPAPI.Tokens.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Defines headers for createRestrictedDataToken operation.
    /// </summary>
    public partial class CreateRestrictedDataTokenHeaders
    {
        /// <summary>
        /// Initializes a new instance of the CreateRestrictedDataTokenHeaders
        /// class.
        /// </summary>
        public CreateRestrictedDataTokenHeaders()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CreateRestrictedDataTokenHeaders
        /// class.
        /// </summary>
        /// <param name="xAmznRateLimitLimit">Your rate limit (requests per
        /// second) for this operation.</param>
        /// <param name="xAmznRequestId">Unique request reference
        /// identifier.</param>
        public CreateRestrictedDataTokenHeaders(string xAmznRateLimitLimit = default(string), string xAmznRequestId = default(string))
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
        /// </summary>
        [JsonProperty(PropertyName = "x-amzn-RateLimit-Limit")]
        public string XAmznRateLimitLimit { get; set; }

        /// <summary>
        /// Gets or sets unique request reference identifier.
        /// </summary>
        [JsonProperty(PropertyName = "x-amzn-RequestId")]
        public string XAmznRequestId { get; set; }

    }
}
