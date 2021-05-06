// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace IL.Library.Amazon.SPAPI.Finances.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The payload for the listFinancialEvents operation.
    /// </summary>
    public partial class ListFinancialEventsPayload
    {
        /// <summary>
        /// Initializes a new instance of the ListFinancialEventsPayload class.
        /// </summary>
        public ListFinancialEventsPayload()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ListFinancialEventsPayload class.
        /// </summary>
        /// <param name="nextToken">When present and not empty, pass this
        /// string token in the next request to return the next response
        /// page.</param>
        public ListFinancialEventsPayload(string nextToken = default(string), FinancialEvents financialEvents = default(FinancialEvents))
        {
            NextToken = nextToken;
            FinancialEvents = financialEvents;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets when present and not empty, pass this string token in
        /// the next request to return the next response page.
        /// </summary>
        [JsonProperty(PropertyName = "NextToken")]
        public string NextToken { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "FinancialEvents")]
        public FinancialEvents FinancialEvents { get; set; }

    }
}
