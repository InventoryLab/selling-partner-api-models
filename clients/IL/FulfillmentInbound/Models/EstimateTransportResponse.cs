// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace IL.Library.Amazon.SPAPI.FulfillmentInbound.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The response schema for the estimateTransport operation.
    /// </summary>
    public partial class EstimateTransportResponse
    {
        /// <summary>
        /// Initializes a new instance of the EstimateTransportResponse class.
        /// </summary>
        public EstimateTransportResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EstimateTransportResponse class.
        /// </summary>
        /// <param name="payload">The payload for the estimateTransport
        /// operation.</param>
        public EstimateTransportResponse(CommonTransportResult payload = default(CommonTransportResult), IList<Error> errors = default(IList<Error>))
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
        /// Gets or sets the payload for the estimateTransport operation.
        /// </summary>
        [JsonProperty(PropertyName = "payload")]
        public CommonTransportResult Payload { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "errors")]
        public IList<Error> Errors { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Payload != null)
            {
                Payload.Validate();
            }
            if (Errors != null)
            {
                foreach (var element in Errors)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
