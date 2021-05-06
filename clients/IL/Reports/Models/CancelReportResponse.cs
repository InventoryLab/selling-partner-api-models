// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace IL.Library.Amazon.SPAPI.Reports.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The response for the cancelReport operation.
    /// </summary>
    public partial class CancelReportResponse
    {
        /// <summary>
        /// Initializes a new instance of the CancelReportResponse class.
        /// </summary>
        public CancelReportResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CancelReportResponse class.
        /// </summary>
        public CancelReportResponse(IList<Error> errors = default(IList<Error>))
        {
            Errors = errors;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "errors")]
        public IList<Error> Errors { get; set; }

    }
}
