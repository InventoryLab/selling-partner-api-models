// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace IL.Library.Amazon.SPAPI.ProductPricing.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The response schema for the getPricing and getCompetitivePricing
    /// operations.
    /// </summary>
    public partial class GetPricingResponse
    {
        /// <summary>
        /// Initializes a new instance of the GetPricingResponse class.
        /// </summary>
        public GetPricingResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GetPricingResponse class.
        /// </summary>
        /// <param name="payload">The payload for the getPricing and
        /// getCompetitivePricing operations.</param>
        /// <param name="errors">One or more unexpected errors occurred during
        /// the operation.</param>
        public GetPricingResponse(IList<Price> payload = default(IList<Price>), IList<Error> errors = default(IList<Error>))
        {
            Payload = payload;
            Errors = errors;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the payload for the getPricing and
        /// getCompetitivePricing operations.
        /// </summary>
        [JsonProperty(PropertyName = "payload")]
        public IList<Price> Payload { get; set; }

        /// <summary>
        /// Gets or sets one or more unexpected errors occurred during the
        /// operation.
        /// </summary>
        [JsonProperty(PropertyName = "errors")]
        public IList<Error> Errors { get; set; }

    }
}
