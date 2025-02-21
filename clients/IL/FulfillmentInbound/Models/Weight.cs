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
    /// The weight of the package.
    /// </summary>
    public partial class Weight
    {
        /// <summary>
        /// Initializes a new instance of the Weight class.
        /// </summary>
        public Weight()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Weight class.
        /// </summary>
        /// <param name="value">The weight value.</param>
        /// <param name="unit">Possible values include: 'pounds',
        /// 'kilograms'</param>
        public Weight(double value, string unit)
        {
            Value = value;
            Unit = unit;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the weight value.
        /// </summary>
        [JsonProperty(PropertyName = "Value")]
        public double Value { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'pounds', 'kilograms'
        /// </summary>
        [JsonProperty(PropertyName = "Unit")]
        public string Unit { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Unit == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Unit");
            }
        }
    }
}
