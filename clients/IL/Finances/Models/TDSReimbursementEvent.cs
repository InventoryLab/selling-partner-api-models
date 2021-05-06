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
    /// A tax deduction at source (TDS) claim reimbursement event on the
    /// seller's account.
    /// </summary>
    public partial class TDSReimbursementEvent
    {
        /// <summary>
        /// Initializes a new instance of the TDSReimbursementEvent class.
        /// </summary>
        public TDSReimbursementEvent()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TDSReimbursementEvent class.
        /// </summary>
        /// <param name="postedDate">The date and time when the financial event
        /// was posted.</param>
        /// <param name="tdsOrderId">A tax deduction at source (TDS) claim
        /// identifier.</param>
        /// <param name="reimbursedAmount">The amount of the
        /// reimbursement.</param>
        public TDSReimbursementEvent(System.DateTime? postedDate = default(System.DateTime?), string tdsOrderId = default(string), Currency reimbursedAmount = default(Currency))
        {
            PostedDate = postedDate;
            TdsOrderId = tdsOrderId;
            ReimbursedAmount = reimbursedAmount;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the date and time when the financial event was posted.
        /// </summary>
        [JsonProperty(PropertyName = "PostedDate")]
        public System.DateTime? PostedDate { get; set; }

        /// <summary>
        /// Gets or sets a tax deduction at source (TDS) claim identifier.
        /// </summary>
        [JsonProperty(PropertyName = "TdsOrderId")]
        public string TdsOrderId { get; set; }

        /// <summary>
        /// Gets or sets the amount of the reimbursement.
        /// </summary>
        [JsonProperty(PropertyName = "ReimbursedAmount")]
        public Currency ReimbursedAmount { get; set; }

    }
}
