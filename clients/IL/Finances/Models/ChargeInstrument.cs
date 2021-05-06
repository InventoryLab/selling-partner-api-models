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
    /// A payment instrument.
    /// </summary>
    public partial class ChargeInstrument
    {
        /// <summary>
        /// Initializes a new instance of the ChargeInstrument class.
        /// </summary>
        public ChargeInstrument()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ChargeInstrument class.
        /// </summary>
        /// <param name="description">A short description of the charge
        /// instrument.</param>
        /// <param name="tail">The account tail (trailing digits) of the charge
        /// instrument.</param>
        /// <param name="amount">The amount charged to this charge
        /// instrument.</param>
        public ChargeInstrument(string description = default(string), string tail = default(string), Currency amount = default(Currency))
        {
            Description = description;
            Tail = tail;
            Amount = amount;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a short description of the charge instrument.
        /// </summary>
        [JsonProperty(PropertyName = "Description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the account tail (trailing digits) of the charge
        /// instrument.
        /// </summary>
        [JsonProperty(PropertyName = "Tail")]
        public string Tail { get; set; }

        /// <summary>
        /// Gets or sets the amount charged to this charge instrument.
        /// </summary>
        [JsonProperty(PropertyName = "Amount")]
        public Currency Amount { get; set; }

    }
}
