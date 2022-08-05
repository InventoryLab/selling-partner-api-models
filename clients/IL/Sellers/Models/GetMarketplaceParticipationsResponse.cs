// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace IL.Library.Amazon.SPAPI.Sellers.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The response schema for the getMarketplaceParticipations operation.
    /// </summary>
    public partial class GetMarketplaceParticipationsResponse
    {
        /// <summary>
        /// Initializes a new instance of the
        /// GetMarketplaceParticipationsResponse class.
        /// </summary>
        public GetMarketplaceParticipationsResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// GetMarketplaceParticipationsResponse class.
        /// </summary>
        /// <param name="payload">The payload for the
        /// getMarketplaceParticipations operation.</param>
        /// <param name="errors">Encountered errors for the
        /// getMarketplaceParticipations operation.</param>
        public GetMarketplaceParticipationsResponse(IList<MarketplaceParticipation> payload = default(IList<MarketplaceParticipation>), IList<Error> errors = default(IList<Error>))
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
        /// Gets or sets the payload for the getMarketplaceParticipations
        /// operation.
        /// </summary>
        [JsonProperty(PropertyName = "payload")]
        public IList<MarketplaceParticipation> Payload { get; set; }

        /// <summary>
        /// Gets or sets encountered errors for the
        /// getMarketplaceParticipations operation.
        /// </summary>
        [JsonProperty(PropertyName = "errors")]
        public IList<Error> Errors { get; set; }

    }
}
