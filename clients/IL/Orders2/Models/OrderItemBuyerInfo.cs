// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace IL.Library.Amazon.SPAPI.Orders.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A single order item's buyer information.
    /// </summary>
    public partial class OrderItemBuyerInfo
    {
        /// <summary>
        /// Initializes a new instance of the OrderItemBuyerInfo class.
        /// </summary>
        public OrderItemBuyerInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OrderItemBuyerInfo class.
        /// </summary>
        /// <param name="orderItemId">An Amazon-defined order item
        /// identifier.</param>
        /// <param name="buyerCustomizedInfo">Buyer information for custom
        /// orders from the Amazon Custom program.</param>
        /// <param name="giftWrapPrice">The gift wrap price of the
        /// item.</param>
        /// <param name="giftWrapTax">The tax on the gift wrap price.</param>
        /// <param name="giftMessageText">A gift message provided by the
        /// buyer.</param>
        /// <param name="giftWrapLevel">The gift wrap level specified by the
        /// buyer.</param>
        public OrderItemBuyerInfo(string orderItemId, BuyerCustomizedInfoDetail buyerCustomizedInfo = default(BuyerCustomizedInfoDetail), Money giftWrapPrice = default(Money), Money giftWrapTax = default(Money), string giftMessageText = default(string), string giftWrapLevel = default(string))
        {
            OrderItemId = orderItemId;
            BuyerCustomizedInfo = buyerCustomizedInfo;
            GiftWrapPrice = giftWrapPrice;
            GiftWrapTax = giftWrapTax;
            GiftMessageText = giftMessageText;
            GiftWrapLevel = giftWrapLevel;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets an Amazon-defined order item identifier.
        /// </summary>
        [JsonProperty(PropertyName = "OrderItemId")]
        public string OrderItemId { get; set; }

        /// <summary>
        /// Gets or sets buyer information for custom orders from the Amazon
        /// Custom program.
        /// </summary>
        [JsonProperty(PropertyName = "BuyerCustomizedInfo")]
        public BuyerCustomizedInfoDetail BuyerCustomizedInfo { get; set; }

        /// <summary>
        /// Gets or sets the gift wrap price of the item.
        /// </summary>
        [JsonProperty(PropertyName = "GiftWrapPrice")]
        public Money GiftWrapPrice { get; set; }

        /// <summary>
        /// Gets or sets the tax on the gift wrap price.
        /// </summary>
        [JsonProperty(PropertyName = "GiftWrapTax")]
        public Money GiftWrapTax { get; set; }

        /// <summary>
        /// Gets or sets a gift message provided by the buyer.
        /// </summary>
        [JsonProperty(PropertyName = "GiftMessageText")]
        public string GiftMessageText { get; set; }

        /// <summary>
        /// Gets or sets the gift wrap level specified by the buyer.
        /// </summary>
        [JsonProperty(PropertyName = "GiftWrapLevel")]
        public string GiftWrapLevel { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (OrderItemId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "OrderItemId");
            }
        }
    }
}
