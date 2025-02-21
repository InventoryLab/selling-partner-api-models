// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace IL.Library.Amazon.SPAPI.FulfillmentInbound.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The monetary value.
    /// </summary>
    public partial class Amount
    {
        /// <summary>
        /// Initializes a new instance of the Amount class.
        /// </summary>
        public Amount()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Amount class.
        /// </summary>
        /// <param name="currencyCode">Possible values include: 'USD',
        /// 'GBP'</param>
        /// <param name="value">The amount.</param>
        public Amount(string currencyCode, double value)
        {
            CurrencyCode = currencyCode;
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets possible values include: 'USD', 'GBP'
        /// </summary>
        [JsonProperty(PropertyName = "CurrencyCode")]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Gets or sets the amount.
        /// </summary>
        [JsonProperty(PropertyName = "Value")]
        public double Value { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (CurrencyCode == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "CurrencyCode");
            }
        }
    }
}
