// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace IL.Library.Amazon.SPAPI.Uploads.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The response schema for the createUploadDestination operation.
    /// </summary>
    public partial class CreateUploadDestinationResponse
    {
        /// <summary>
        /// Initializes a new instance of the CreateUploadDestinationResponse
        /// class.
        /// </summary>
        public CreateUploadDestinationResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CreateUploadDestinationResponse
        /// class.
        /// </summary>
        public CreateUploadDestinationResponse(UploadDestination payload = default(UploadDestination), IList<Error> errors = default(IList<Error>))
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
        /// </summary>
        [JsonProperty(PropertyName = "payload")]
        public UploadDestination Payload { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "errors")]
        public IList<Error> Errors { get; set; }

    }
}
