// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace IL.Library.Amazon.SPAPI.Reports.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Response schema.
    /// </summary>
    public partial class CreateReportScheduleResponse
    {
        /// <summary>
        /// Initializes a new instance of the CreateReportScheduleResponse
        /// class.
        /// </summary>
        public CreateReportScheduleResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CreateReportScheduleResponse
        /// class.
        /// </summary>
        /// <param name="reportScheduleId">The identifier for the report
        /// schedule. This identifier is unique only in combination with a
        /// seller ID.</param>
        public CreateReportScheduleResponse(string reportScheduleId)
        {
            ReportScheduleId = reportScheduleId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the identifier for the report schedule. This
        /// identifier is unique only in combination with a seller ID.
        /// </summary>
        [JsonProperty(PropertyName = "reportScheduleId")]
        public string ReportScheduleId { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ReportScheduleId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ReportScheduleId");
            }
        }
    }
}
