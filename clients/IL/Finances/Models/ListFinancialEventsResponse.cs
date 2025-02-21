// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace IL.Library.Amazon.SPAPI.Finances.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The response schema for the listFinancialEvents operation.
    /// </summary>
    public partial class ListFinancialEventsResponse
    {
        /// <summary>
        /// Initializes a new instance of the ListFinancialEventsResponse
        /// class.
        /// </summary>
        public ListFinancialEventsResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ListFinancialEventsResponse
        /// class.
        /// </summary>
        /// <param name="payload">The payload for the listFinancialEvents
        /// operation.</param>
        /// <param name="errors">One or more unexpected errors occurred during
        /// the listFinancialEvents operation.</param>
        public ListFinancialEventsResponse(ListFinancialEventsPayload payload = default(ListFinancialEventsPayload), IList<Error> errors = default(IList<Error>))
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
        /// Gets or sets the payload for the listFinancialEvents operation.
        /// </summary>
        [JsonProperty(PropertyName = "payload")]
        public ListFinancialEventsPayload Payload { get; set; }

        /// <summary>
        /// Gets or sets one or more unexpected errors occurred during the
        /// listFinancialEvents operation.
        /// </summary>
        [JsonProperty(PropertyName = "errors")]
        public IList<Error> Errors { get; set; }

    }
}
