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
    /// A fee associated with the event.
    /// </summary>
    public partial class FeeComponent
    {
        /// <summary>
        /// Initializes a new instance of the FeeComponent class.
        /// </summary>
        public FeeComponent()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FeeComponent class.
        /// </summary>
        /// <param name="feeType">The type of fee. For more information about
        /// Selling on Amazon fees, see [Selling on Amazon Fee
        /// Schedule](https://sellercentral.amazon.com/gp/help/200336920) on
        /// Seller Central. For more information about Fulfillment by Amazon
        /// fees, see [FBA features, services and
        /// fees](https://sellercentral.amazon.com/gp/help/201074400) on Seller
        /// Central.</param>
        /// <param name="feeAmount">The amount of the fee.</param>
        public FeeComponent(string feeType = default(string), Currency feeAmount = default(Currency))
        {
            FeeType = feeType;
            FeeAmount = feeAmount;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the type of fee. For more information about Selling on
        /// Amazon fees, see [Selling on Amazon Fee
        /// Schedule](https://sellercentral.amazon.com/gp/help/200336920) on
        /// Seller Central. For more information about Fulfillment by Amazon
        /// fees, see [FBA features, services and
        /// fees](https://sellercentral.amazon.com/gp/help/201074400) on Seller
        /// Central.
        /// </summary>
        [JsonProperty(PropertyName = "FeeType")]
        public string FeeType { get; set; }

        /// <summary>
        /// Gets or sets the amount of the fee.
        /// </summary>
        [JsonProperty(PropertyName = "FeeAmount")]
        public Currency FeeAmount { get; set; }

    }
}
