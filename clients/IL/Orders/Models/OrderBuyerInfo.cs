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
    /// Buyer information for an order.
    /// </summary>
    public partial class OrderBuyerInfo
    {
        /// <summary>
        /// Initializes a new instance of the OrderBuyerInfo class.
        /// </summary>
        public OrderBuyerInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OrderBuyerInfo class.
        /// </summary>
        /// <param name="amazonOrderId">An Amazon-defined order identifier, in
        /// 3-7-7 format.</param>
        /// <param name="buyerEmail">The anonymized email address of the
        /// buyer.</param>
        /// <param name="buyerName">The name of the buyer.</param>
        /// <param name="buyerCounty">The county of the buyer.</param>
        /// <param name="buyerTaxInfo">Tax information about the buyer.</param>
        /// <param name="purchaseOrderNumber">The purchase order (PO) number
        /// entered by the buyer at checkout. Returned only for orders where
        /// the buyer entered a PO number at checkout.</param>
        public OrderBuyerInfo(string amazonOrderId, string buyerEmail = default(string), string buyerName = default(string), string buyerCounty = default(string), BuyerTaxInfo buyerTaxInfo = default(BuyerTaxInfo), string purchaseOrderNumber = default(string))
        {
            AmazonOrderId = amazonOrderId;
            BuyerEmail = buyerEmail;
            BuyerName = buyerName;
            BuyerCounty = buyerCounty;
            BuyerTaxInfo = buyerTaxInfo;
            PurchaseOrderNumber = purchaseOrderNumber;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets an Amazon-defined order identifier, in 3-7-7 format.
        /// </summary>
        [JsonProperty(PropertyName = "AmazonOrderId")]
        public string AmazonOrderId { get; set; }

        /// <summary>
        /// Gets or sets the anonymized email address of the buyer.
        /// </summary>
        [JsonProperty(PropertyName = "BuyerEmail")]
        public string BuyerEmail { get; set; }

        /// <summary>
        /// Gets or sets the name of the buyer.
        /// </summary>
        [JsonProperty(PropertyName = "BuyerName")]
        public string BuyerName { get; set; }

        /// <summary>
        /// Gets or sets the county of the buyer.
        /// </summary>
        [JsonProperty(PropertyName = "BuyerCounty")]
        public string BuyerCounty { get; set; }

        /// <summary>
        /// Gets or sets tax information about the buyer.
        /// </summary>
        [JsonProperty(PropertyName = "BuyerTaxInfo")]
        public BuyerTaxInfo BuyerTaxInfo { get; set; }

        /// <summary>
        /// Gets or sets the purchase order (PO) number entered by the buyer at
        /// checkout. Returned only for orders where the buyer entered a PO
        /// number at checkout.
        /// </summary>
        [JsonProperty(PropertyName = "PurchaseOrderNumber")]
        public string PurchaseOrderNumber { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (AmazonOrderId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AmazonOrderId");
            }
        }
    }
}
