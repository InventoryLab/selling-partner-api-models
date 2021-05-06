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
    /// The response for the getReportSchedule operation.
    /// </summary>
    public partial class GetReportScheduleResponse
    {
        /// <summary>
        /// Initializes a new instance of the GetReportScheduleResponse class.
        /// </summary>
        public GetReportScheduleResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GetReportScheduleResponse class.
        /// </summary>
        /// <param name="payload">The payload for the getReportSchedule
        /// operation.</param>
        public GetReportScheduleResponse(ReportSchedule payload = default(ReportSchedule), IList<Error> errors = default(IList<Error>))
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
        /// Gets or sets the payload for the getReportSchedule operation.
        /// </summary>
        [JsonProperty(PropertyName = "payload")]
        public ReportSchedule Payload { get; set; }

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
