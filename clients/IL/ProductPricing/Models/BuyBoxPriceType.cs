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

    public partial class BuyBoxPriceType
    {
        /// <summary>
        /// Initializes a new instance of the BuyBoxPriceType class.
        /// </summary>
        public BuyBoxPriceType()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BuyBoxPriceType class.
        /// </summary>
        /// <param name="condition">Indicates the condition of the item. For
        /// example: New, Used, Collectible, Refurbished, or Club.</param>
        /// <param name="landedPrice">The value calculated by adding
        /// ListingPrice + Shipping - Points.</param>
        /// <param name="listingPrice">The price of the item.</param>
        /// <param name="shipping">The shipping cost.</param>
        /// <param name="offerType">Indicates the type of customer that the
        /// offer is valid for.&lt;br&gt;&lt;br&gt;When the offer type is B2C
        /// in a quantity discount, the seller is winning the Buy Box because
        /// others do not have inventory at that quantity, not because they
        /// have a quantity discount on the ASIN. Possible values include:
        /// 'B2C', 'B2B'</param>
        /// <param name="quantityTier">Indicates at what quantity this price
        /// becomes active.</param>
        /// <param name="quantityDiscountType">Indicates the type of quantity
        /// discount this price applies to. Possible values include:
        /// 'QUANTITY_DISCOUNT'</param>
        /// <param name="points">The number of Amazon Points offered with the
        /// purchase of an item.</param>
        /// <param name="sellerId">The seller identifier for the offer.</param>
        public BuyBoxPriceType(string condition, MoneyType landedPrice, MoneyType listingPrice, MoneyType shipping, string offerType = default(string), int? quantityTier = default(int?), string quantityDiscountType = default(string), Points points = default(Points), string sellerId = default(string))
        {
            Condition = condition;
            OfferType = offerType;
            QuantityTier = quantityTier;
            QuantityDiscountType = quantityDiscountType;
            LandedPrice = landedPrice;
            ListingPrice = listingPrice;
            Shipping = shipping;
            Points = points;
            SellerId = sellerId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets indicates the condition of the item. For example: New,
        /// Used, Collectible, Refurbished, or Club.
        /// </summary>
        [JsonProperty(PropertyName = "condition")]
        public string Condition { get; set; }

        /// <summary>
        /// Gets or sets indicates the type of customer that the offer is valid
        /// for.&amp;lt;br&amp;gt;&amp;lt;br&amp;gt;When the offer type is B2C
        /// in a quantity discount, the seller is winning the Buy Box because
        /// others do not have inventory at that quantity, not because they
        /// have a quantity discount on the ASIN. Possible values include:
        /// 'B2C', 'B2B'
        /// </summary>
        [JsonProperty(PropertyName = "offerType")]
        public string OfferType { get; set; }

        /// <summary>
        /// Gets or sets indicates at what quantity this price becomes active.
        /// </summary>
        [JsonProperty(PropertyName = "quantityTier")]
        public int? QuantityTier { get; set; }

        /// <summary>
        /// Gets or sets indicates the type of quantity discount this price
        /// applies to. Possible values include: 'QUANTITY_DISCOUNT'
        /// </summary>
        [JsonProperty(PropertyName = "quantityDiscountType")]
        public string QuantityDiscountType { get; set; }

        /// <summary>
        /// Gets or sets the value calculated by adding ListingPrice + Shipping
        /// - Points.
        /// </summary>
        [JsonProperty(PropertyName = "LandedPrice")]
        public MoneyType LandedPrice { get; set; }

        /// <summary>
        /// Gets or sets the price of the item.
        /// </summary>
        [JsonProperty(PropertyName = "ListingPrice")]
        public MoneyType ListingPrice { get; set; }

        /// <summary>
        /// Gets or sets the shipping cost.
        /// </summary>
        [JsonProperty(PropertyName = "Shipping")]
        public MoneyType Shipping { get; set; }

        /// <summary>
        /// Gets or sets the number of Amazon Points offered with the purchase
        /// of an item.
        /// </summary>
        [JsonProperty(PropertyName = "Points")]
        public Points Points { get; set; }

        /// <summary>
        /// Gets or sets the seller identifier for the offer.
        /// </summary>
        [JsonProperty(PropertyName = "sellerId")]
        public string SellerId { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Condition == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Condition");
            }
            if (LandedPrice == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "LandedPrice");
            }
            if (ListingPrice == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ListingPrice");
            }
            if (Shipping == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Shipping");
            }
        }
    }
}
