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
    /// Pallet information.
    /// </summary>
    public partial class Pallet
    {
        /// <summary>
        /// Initializes a new instance of the Pallet class.
        /// </summary>
        public Pallet()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Pallet class.
        /// </summary>
        /// <param name="dimensions">The dimensions of the pallet. Length and
        /// width must be 40 inches by 48 inches. Height must be less than or
        /// equal to 60 inches.</param>
        /// <param name="isStacked">Indicates whether pallets will be stacked
        /// when carrier arrives for pick-up.</param>
        /// <param name="weight">The weight of the pallet.</param>
        public Pallet(Dimensions dimensions, bool isStacked, Weight weight = default(Weight))
        {
            Dimensions = dimensions;
            Weight = weight;
            IsStacked = isStacked;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the dimensions of the pallet. Length and width must be
        /// 40 inches by 48 inches. Height must be less than or equal to 60
        /// inches.
        /// </summary>
        [JsonProperty(PropertyName = "Dimensions")]
        public Dimensions Dimensions { get; set; }

        /// <summary>
        /// Gets or sets the weight of the pallet.
        /// </summary>
        [JsonProperty(PropertyName = "Weight")]
        public Weight Weight { get; set; }

        /// <summary>
        /// Gets or sets indicates whether pallets will be stacked when carrier
        /// arrives for pick-up.
        /// </summary>
        [JsonProperty(PropertyName = "IsStacked")]
        public bool IsStacked { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Dimensions == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Dimensions");
            }
            if (Dimensions != null)
            {
                Dimensions.Validate();
            }
            if (Weight != null)
            {
                Weight.Validate();
            }
        }
    }
}
