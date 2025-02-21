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
    /// The response schema for the confirmPreorder operation.
    /// </summary>
    public partial class ConfirmPreorderResponse
    {
        /// <summary>
        /// Initializes a new instance of the ConfirmPreorderResponse class.
        /// </summary>
        public ConfirmPreorderResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ConfirmPreorderResponse class.
        /// </summary>
        /// <param name="payload">The payload for the confirmPreorder
        /// operation.</param>
        public ConfirmPreorderResponse(ConfirmPreorderResult payload = default(ConfirmPreorderResult), IList<Error> errors = default(IList<Error>))
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
        /// Gets or sets the payload for the confirmPreorder operation.
        /// </summary>
        [JsonProperty(PropertyName = "payload")]
        public ConfirmPreorderResult Payload { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "errors")]
        public IList<Error> Errors { get; set; }

    }
}
