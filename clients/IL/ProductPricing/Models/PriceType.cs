// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace IL.Library.Amazon.SPAPI.ProductPricing.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    public partial class PriceType
    {
        /// <summary>
        /// Initializes a new instance of the PriceType class.
        /// </summary>
        public PriceType()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PriceType class.
        /// </summary>
        /// <param name="listingPrice">The listing price of the item including
        /// any promotions that apply.</param>
        /// <param name="landedPrice">The value calculated by adding
        /// ListingPrice + Shipping - Points. Note that if the landed price is
        /// not returned, the listing price represents the product with the
        /// lowest landed price.</param>
        /// <param name="shipping">The shipping cost of the product. Note that
        /// the shipping cost is not always available.</param>
        /// <param name="points">The number of Amazon Points offered with the
        /// purchase of an item, and their monetary value.</param>
        public PriceType(MoneyType listingPrice, MoneyType landedPrice = default(MoneyType), MoneyType shipping = default(MoneyType), Points points = default(Points))
        {
            LandedPrice = landedPrice;
            ListingPrice = listingPrice;
            Shipping = shipping;
            Points = points;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the value calculated by adding ListingPrice + Shipping
        /// - Points. Note that if the landed price is not returned, the
        /// listing price represents the product with the lowest landed price.
        /// </summary>
        [JsonProperty(PropertyName = "LandedPrice")]
        public MoneyType LandedPrice { get; set; }

        /// <summary>
        /// Gets or sets the listing price of the item including any promotions
        /// that apply.
        /// </summary>
        [JsonProperty(PropertyName = "ListingPrice")]
        public MoneyType ListingPrice { get; set; }

        /// <summary>
        /// Gets or sets the shipping cost of the product. Note that the
        /// shipping cost is not always available.
        /// </summary>
        [JsonProperty(PropertyName = "Shipping")]
        public MoneyType Shipping { get; set; }

        /// <summary>
        /// Gets or sets the number of Amazon Points offered with the purchase
        /// of an item, and their monetary value.
        /// </summary>
        [JsonProperty(PropertyName = "Points")]
        public Points Points { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ListingPrice == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ListingPrice");
            }
        }
    }
}
