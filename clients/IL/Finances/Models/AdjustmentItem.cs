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
    /// An item in an adjustment to the seller's account.
    /// </summary>
    public partial class AdjustmentItem
    {
        /// <summary>
        /// Initializes a new instance of the AdjustmentItem class.
        /// </summary>
        public AdjustmentItem()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AdjustmentItem class.
        /// </summary>
        /// <param name="quantity">Represents the number of units in the
        /// seller's inventory when the AdustmentType is
        /// FBAInventoryReimbursement.</param>
        /// <param name="perUnitAmount">The per unit value of the item.</param>
        /// <param name="totalAmount">The total value of the item.</param>
        /// <param name="sellerSKU">The seller SKU of the item. The seller SKU
        /// is qualified by the seller's seller ID, which is included with
        /// every call to the Selling Partner API.</param>
        /// <param name="fnSKU">A unique identifier assigned to products stored
        /// in and fulfilled from a fulfillment center.</param>
        /// <param name="productDescription">A short description of the
        /// item.</param>
        /// <param name="aSIN">The Amazon Standard Identification Number (ASIN)
        /// of the item.</param>
        public AdjustmentItem(string quantity = default(string), Currency perUnitAmount = default(Currency), Currency totalAmount = default(Currency), string sellerSKU = default(string), string fnSKU = default(string), string productDescription = default(string), string aSIN = default(string))
        {
            Quantity = quantity;
            PerUnitAmount = perUnitAmount;
            TotalAmount = totalAmount;
            SellerSKU = sellerSKU;
            FnSKU = fnSKU;
            ProductDescription = productDescription;
            ASIN = aSIN;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets represents the number of units in the seller's
        /// inventory when the AdustmentType is FBAInventoryReimbursement.
        /// </summary>
        [JsonProperty(PropertyName = "Quantity")]
        public string Quantity { get; set; }

        /// <summary>
        /// Gets or sets the per unit value of the item.
        /// </summary>
        [JsonProperty(PropertyName = "PerUnitAmount")]
        public Currency PerUnitAmount { get; set; }

        /// <summary>
        /// Gets or sets the total value of the item.
        /// </summary>
        [JsonProperty(PropertyName = "TotalAmount")]
        public Currency TotalAmount { get; set; }

        /// <summary>
        /// Gets or sets the seller SKU of the item. The seller SKU is
        /// qualified by the seller's seller ID, which is included with every
        /// call to the Selling Partner API.
        /// </summary>
        [JsonProperty(PropertyName = "SellerSKU")]
        public string SellerSKU { get; set; }

        /// <summary>
        /// Gets or sets a unique identifier assigned to products stored in and
        /// fulfilled from a fulfillment center.
        /// </summary>
        [JsonProperty(PropertyName = "FnSKU")]
        public string FnSKU { get; set; }

        /// <summary>
        /// Gets or sets a short description of the item.
        /// </summary>
        [JsonProperty(PropertyName = "ProductDescription")]
        public string ProductDescription { get; set; }

        /// <summary>
        /// Gets or sets the Amazon Standard Identification Number (ASIN) of
        /// the item.
        /// </summary>
        [JsonProperty(PropertyName = "ASIN")]
        public string ASIN { get; set; }

    }
}
