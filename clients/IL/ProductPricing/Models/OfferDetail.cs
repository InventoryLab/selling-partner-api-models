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

    public partial class OfferDetail
    {
        /// <summary>
        /// Initializes a new instance of the OfferDetail class.
        /// </summary>
        public OfferDetail()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OfferDetail class.
        /// </summary>
        /// <param name="subCondition">The subcondition of the item.
        /// Subcondition values: New, Mint, Very Good, Good, Acceptable, Poor,
        /// Club, OEM, Warranty, Refurbished Warranty, Refurbished, Open Box,
        /// or Other.</param>
        /// <param name="shippingTime">The maximum time within which the item
        /// will likely be shipped once an order has been placed.</param>
        /// <param name="listingPrice">The price of the item.</param>
        /// <param name="shipping">The shipping cost.</param>
        /// <param name="isFulfilledByAmazon">When true, the offer is fulfilled
        /// by Amazon.</param>
        /// <param name="myOffer">When true, this is the seller's
        /// offer.</param>
        /// <param name="sellerFeedbackRating">Information about the seller's
        /// feedback, including the percentage of positive feedback, and the
        /// total number of ratings received.</param>
        /// <param name="points">The number of Amazon Points offered with the
        /// purchase of an item.</param>
        /// <param name="shipsFrom">The state and country from where the item
        /// is shipped.</param>
        /// <param name="isBuyBoxWinner">When true, the offer is currently in
        /// the Buy Box. There can be up to two Buy Box winners at any time per
        /// ASIN, one that is eligible for Prime and one that is not eligible
        /// for Prime.</param>
        /// <param name="isFeaturedMerchant">When true, the seller of the item
        /// is eligible to win the Buy Box.</param>
        public OfferDetail(string subCondition, DetailedShippingTimeType shippingTime, MoneyType listingPrice, MoneyType shipping, bool isFulfilledByAmazon, bool? myOffer = default(bool?), SellerFeedbackType sellerFeedbackRating = default(SellerFeedbackType), Points points = default(Points), ShipsFromType shipsFrom = default(ShipsFromType), bool? isBuyBoxWinner = default(bool?), bool? isFeaturedMerchant = default(bool?))
        {
            MyOffer = myOffer;
            SubCondition = subCondition;
            SellerFeedbackRating = sellerFeedbackRating;
            ShippingTime = shippingTime;
            ListingPrice = listingPrice;
            Points = points;
            Shipping = shipping;
            ShipsFrom = shipsFrom;
            IsFulfilledByAmazon = isFulfilledByAmazon;
            IsBuyBoxWinner = isBuyBoxWinner;
            IsFeaturedMerchant = isFeaturedMerchant;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets when true, this is the seller's offer.
        /// </summary>
        [JsonProperty(PropertyName = "MyOffer")]
        public bool? MyOffer { get; set; }

        /// <summary>
        /// Gets or sets the subcondition of the item. Subcondition values:
        /// New, Mint, Very Good, Good, Acceptable, Poor, Club, OEM, Warranty,
        /// Refurbished Warranty, Refurbished, Open Box, or Other.
        /// </summary>
        [JsonProperty(PropertyName = "SubCondition")]
        public string SubCondition { get; set; }

        /// <summary>
        /// Gets or sets information about the seller's feedback, including the
        /// percentage of positive feedback, and the total number of ratings
        /// received.
        /// </summary>
        [JsonProperty(PropertyName = "SellerFeedbackRating")]
        public SellerFeedbackType SellerFeedbackRating { get; set; }

        /// <summary>
        /// Gets or sets the maximum time within which the item will likely be
        /// shipped once an order has been placed.
        /// </summary>
        [JsonProperty(PropertyName = "ShippingTime")]
        public DetailedShippingTimeType ShippingTime { get; set; }

        /// <summary>
        /// Gets or sets the price of the item.
        /// </summary>
        [JsonProperty(PropertyName = "ListingPrice")]
        public MoneyType ListingPrice { get; set; }

        /// <summary>
        /// Gets or sets the number of Amazon Points offered with the purchase
        /// of an item.
        /// </summary>
        [JsonProperty(PropertyName = "Points")]
        public Points Points { get; set; }

        /// <summary>
        /// Gets or sets the shipping cost.
        /// </summary>
        [JsonProperty(PropertyName = "Shipping")]
        public MoneyType Shipping { get; set; }

        /// <summary>
        /// Gets or sets the state and country from where the item is shipped.
        /// </summary>
        [JsonProperty(PropertyName = "ShipsFrom")]
        public ShipsFromType ShipsFrom { get; set; }

        /// <summary>
        /// Gets or sets when true, the offer is fulfilled by Amazon.
        /// </summary>
        [JsonProperty(PropertyName = "IsFulfilledByAmazon")]
        public bool IsFulfilledByAmazon { get; set; }

        /// <summary>
        /// Gets or sets when true, the offer is currently in the Buy Box.
        /// There can be up to two Buy Box winners at any time per ASIN, one
        /// that is eligible for Prime and one that is not eligible for Prime.
        /// </summary>
        [JsonProperty(PropertyName = "IsBuyBoxWinner")]
        public bool? IsBuyBoxWinner { get; set; }

        /// <summary>
        /// Gets or sets when true, the seller of the item is eligible to win
        /// the Buy Box.
        /// </summary>
        [JsonProperty(PropertyName = "IsFeaturedMerchant")]
        public bool? IsFeaturedMerchant { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (SubCondition == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SubCondition");
            }
            if (ShippingTime == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ShippingTime");
            }
            if (ListingPrice == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ListingPrice");
            }
            if (Shipping == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Shipping");
            }
            if (SellerFeedbackRating != null)
            {
                SellerFeedbackRating.Validate();
            }
        }
    }
}
