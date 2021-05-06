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
    /// Item-level information for a removal shipment.
    /// </summary>
    public partial class RemovalShipmentItem
    {
        /// <summary>
        /// Initializes a new instance of the RemovalShipmentItem class.
        /// </summary>
        public RemovalShipmentItem()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RemovalShipmentItem class.
        /// </summary>
        /// <param name="removalShipmentItemId">An identifier for an item in a
        /// removal shipment.</param>
        /// <param name="taxCollectionModel">The tax collection model applied
        /// to the item.
        ///
        /// Possible values:
        ///
        /// * MarketplaceFacilitator - Tax is withheld and remitted to the
        /// taxing authority by Amazon on behalf of the seller.
        ///
        /// * Standard - Tax is paid to the seller and not remitted to the
        /// taxing authority by Amazon.</param>
        /// <param name="fulfillmentNetworkSKU">The Amazon fulfillment network
        /// SKU for the item.</param>
        /// <param name="quantity">The quantity of the item.</param>
        /// <param name="revenue">The total amount paid to the seller for the
        /// removed item.</param>
        /// <param name="feeAmount">The fee that Amazon charged to the seller
        /// for the removal of the item. The amount is a negative
        /// number.</param>
        /// <param name="taxAmount">Tax collected on the revenue.</param>
        /// <param name="taxWithheld">The tax withheld and remitted to the
        /// taxing authority by Amazon on behalf of the seller. If
        /// TaxCollectionModel=MarketplaceFacilitator, then
        /// TaxWithheld=TaxAmount (except the TaxWithheld amount is a negative
        /// number). Otherwise TaxWithheld=0.</param>
        public RemovalShipmentItem(string removalShipmentItemId = default(string), string taxCollectionModel = default(string), string fulfillmentNetworkSKU = default(string), int? quantity = default(int?), Currency revenue = default(Currency), Currency feeAmount = default(Currency), Currency taxAmount = default(Currency), Currency taxWithheld = default(Currency))
        {
            RemovalShipmentItemId = removalShipmentItemId;
            TaxCollectionModel = taxCollectionModel;
            FulfillmentNetworkSKU = fulfillmentNetworkSKU;
            Quantity = quantity;
            Revenue = revenue;
            FeeAmount = feeAmount;
            TaxAmount = taxAmount;
            TaxWithheld = taxWithheld;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets an identifier for an item in a removal shipment.
        /// </summary>
        [JsonProperty(PropertyName = "RemovalShipmentItemId")]
        public string RemovalShipmentItemId { get; set; }

        /// <summary>
        /// Gets or sets the tax collection model applied to the item.
        ///
        /// Possible values:
        ///
        /// * MarketplaceFacilitator - Tax is withheld and remitted to the
        /// taxing authority by Amazon on behalf of the seller.
        ///
        /// * Standard - Tax is paid to the seller and not remitted to the
        /// taxing authority by Amazon.
        /// </summary>
        [JsonProperty(PropertyName = "TaxCollectionModel")]
        public string TaxCollectionModel { get; set; }

        /// <summary>
        /// Gets or sets the Amazon fulfillment network SKU for the item.
        /// </summary>
        [JsonProperty(PropertyName = "FulfillmentNetworkSKU")]
        public string FulfillmentNetworkSKU { get; set; }

        /// <summary>
        /// Gets or sets the quantity of the item.
        /// </summary>
        [JsonProperty(PropertyName = "Quantity")]
        public int? Quantity { get; set; }

        /// <summary>
        /// Gets or sets the total amount paid to the seller for the removed
        /// item.
        /// </summary>
        [JsonProperty(PropertyName = "Revenue")]
        public Currency Revenue { get; set; }

        /// <summary>
        /// Gets or sets the fee that Amazon charged to the seller for the
        /// removal of the item. The amount is a negative number.
        /// </summary>
        [JsonProperty(PropertyName = "FeeAmount")]
        public Currency FeeAmount { get; set; }

        /// <summary>
        /// Gets or sets tax collected on the revenue.
        /// </summary>
        [JsonProperty(PropertyName = "TaxAmount")]
        public Currency TaxAmount { get; set; }

        /// <summary>
        /// Gets or sets the tax withheld and remitted to the taxing authority
        /// by Amazon on behalf of the seller. If
        /// TaxCollectionModel=MarketplaceFacilitator, then
        /// TaxWithheld=TaxAmount (except the TaxWithheld amount is a negative
        /// number). Otherwise TaxWithheld=0.
        /// </summary>
        [JsonProperty(PropertyName = "TaxWithheld")]
        public Currency TaxWithheld { get; set; }

    }
}
