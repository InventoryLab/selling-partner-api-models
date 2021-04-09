// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace IL.Library.Amazon.SPAPI.Orders.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Buyer information for custom orders from the Amazon Custom program.
    /// </summary>
    public partial class BuyerCustomizedInfoDetail
    {
        /// <summary>
        /// Initializes a new instance of the BuyerCustomizedInfoDetail class.
        /// </summary>
        public BuyerCustomizedInfoDetail()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BuyerCustomizedInfoDetail class.
        /// </summary>
        /// <param name="customizedURL">The location of a zip file containing
        /// Amazon Custom data.</param>
        public BuyerCustomizedInfoDetail(string customizedURL = default(string))
        {
            CustomizedURL = customizedURL;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the location of a zip file containing Amazon Custom
        /// data.
        /// </summary>
        [JsonProperty(PropertyName = "CustomizedURL")]
        public string CustomizedURL { get; set; }

    }
}
