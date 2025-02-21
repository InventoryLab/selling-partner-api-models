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
    /// The response schema for the listFinancialEventGroups operation.
    /// </summary>
    public partial class ListFinancialEventGroupsResponse
    {
        /// <summary>
        /// Initializes a new instance of the ListFinancialEventGroupsResponse
        /// class.
        /// </summary>
        public ListFinancialEventGroupsResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ListFinancialEventGroupsResponse
        /// class.
        /// </summary>
        /// <param name="payload">The payload for the listFinancialEventGroups
        /// operation.</param>
        /// <param name="errors">One or more unexpected errors occurred during
        /// the listFinancialEventGroups operation.</param>
        public ListFinancialEventGroupsResponse(ListFinancialEventGroupsPayload payload = default(ListFinancialEventGroupsPayload), IList<Error> errors = default(IList<Error>))
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
        /// Gets or sets the payload for the listFinancialEventGroups
        /// operation.
        /// </summary>
        [JsonProperty(PropertyName = "payload")]
        public ListFinancialEventGroupsPayload Payload { get; set; }

        /// <summary>
        /// Gets or sets one or more unexpected errors occurred during the
        /// listFinancialEventGroups operation.
        /// </summary>
        [JsonProperty(PropertyName = "errors")]
        public IList<Error> Errors { get; set; }

    }
}
