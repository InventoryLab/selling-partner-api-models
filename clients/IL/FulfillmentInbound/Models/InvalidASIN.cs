// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace IL.Library.Amazon.SPAPI.FulfillmentInbound.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class InvalidASIN
    {
        /// <summary>
        /// Initializes a new instance of the InvalidASIN class.
        /// </summary>
        public InvalidASIN()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the InvalidASIN class.
        /// </summary>
        /// <param name="aSIN">The Amazon Standard Identification Number (ASIN)
        /// of the item.</param>
        /// <param name="errorReason">The reason that the ASIN is invalid.
        /// Possible values include: 'DoesNotExist', 'InvalidASIN'</param>
        public InvalidASIN(string aSIN = default(string), string errorReason = default(string))
        {
            ASIN = aSIN;
            ErrorReason = errorReason;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the Amazon Standard Identification Number (ASIN) of
        /// the item.
        /// </summary>
        [JsonProperty(PropertyName = "ASIN")]
        public string ASIN { get; set; }

        /// <summary>
        /// Gets or sets the reason that the ASIN is invalid. Possible values
        /// include: 'DoesNotExist', 'InvalidASIN'
        /// </summary>
        [JsonProperty(PropertyName = "ErrorReason")]
        public string ErrorReason { get; set; }

    }
}
