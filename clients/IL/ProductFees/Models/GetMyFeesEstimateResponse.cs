// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace IL.Library.Amazon.SPAPI.ProductFees.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class GetMyFeesEstimateResponse
    {
        /// <summary>
        /// Initializes a new instance of the GetMyFeesEstimateResponse class.
        /// </summary>
        public GetMyFeesEstimateResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GetMyFeesEstimateResponse class.
        /// </summary>
        /// <param name="payload">The payload for the operation.</param>
        public GetMyFeesEstimateResponse(GetMyFeesEstimateResult payload = default(GetMyFeesEstimateResult), IList<Error> errors = default(IList<Error>))
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
        /// Gets or sets the payload for the operation.
        /// </summary>
        [JsonProperty(PropertyName = "payload")]
        public GetMyFeesEstimateResult Payload { get; set; }

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
