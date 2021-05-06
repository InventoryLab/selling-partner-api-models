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
    /// A network commingling transaction event.
    /// </summary>
    public partial class NetworkComminglingTransactionEvent
    {
        /// <summary>
        /// Initializes a new instance of the
        /// NetworkComminglingTransactionEvent class.
        /// </summary>
        public NetworkComminglingTransactionEvent()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// NetworkComminglingTransactionEvent class.
        /// </summary>
        /// <param name="transactionType">The type of network item swap.
        ///
        /// Possible values:
        ///
        /// * NetCo - A Fulfillment by Amazon inventory pooling transaction.
        /// Available only in the India marketplace.
        ///
        /// * ComminglingVAT - A commingling VAT transaction. Available only in
        /// the UK, Spain, France, Germany, and Italy marketplaces.</param>
        /// <param name="postedDate">The date and time when the financial event
        /// was posted.</param>
        /// <param name="netCoTransactionID">The identifier for the network
        /// item swap.</param>
        /// <param name="swapReason">The reason for the network item
        /// swap.</param>
        /// <param name="aSIN">The Amazon Standard Identification Number (ASIN)
        /// of the swapped item.</param>
        /// <param name="marketplaceId">The marketplace in which the event took
        /// place.</param>
        /// <param name="taxExclusiveAmount">The price of the swapped item
        /// minus TaxAmount.</param>
        /// <param name="taxAmount">The tax on the network item swap paid by
        /// the seller.</param>
        public NetworkComminglingTransactionEvent(string transactionType = default(string), System.DateTime? postedDate = default(System.DateTime?), string netCoTransactionID = default(string), string swapReason = default(string), string aSIN = default(string), string marketplaceId = default(string), Currency taxExclusiveAmount = default(Currency), Currency taxAmount = default(Currency))
        {
            TransactionType = transactionType;
            PostedDate = postedDate;
            NetCoTransactionID = netCoTransactionID;
            SwapReason = swapReason;
            ASIN = aSIN;
            MarketplaceId = marketplaceId;
            TaxExclusiveAmount = taxExclusiveAmount;
            TaxAmount = taxAmount;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the type of network item swap.
        ///
        /// Possible values:
        ///
        /// * NetCo - A Fulfillment by Amazon inventory pooling transaction.
        /// Available only in the India marketplace.
        ///
        /// * ComminglingVAT - A commingling VAT transaction. Available only in
        /// the UK, Spain, France, Germany, and Italy marketplaces.
        /// </summary>
        [JsonProperty(PropertyName = "TransactionType")]
        public string TransactionType { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the financial event was posted.
        /// </summary>
        [JsonProperty(PropertyName = "PostedDate")]
        public System.DateTime? PostedDate { get; set; }

        /// <summary>
        /// Gets or sets the identifier for the network item swap.
        /// </summary>
        [JsonProperty(PropertyName = "NetCoTransactionID")]
        public string NetCoTransactionID { get; set; }

        /// <summary>
        /// Gets or sets the reason for the network item swap.
        /// </summary>
        [JsonProperty(PropertyName = "SwapReason")]
        public string SwapReason { get; set; }

        /// <summary>
        /// Gets or sets the Amazon Standard Identification Number (ASIN) of
        /// the swapped item.
        /// </summary>
        [JsonProperty(PropertyName = "ASIN")]
        public string ASIN { get; set; }

        /// <summary>
        /// Gets or sets the marketplace in which the event took place.
        /// </summary>
        [JsonProperty(PropertyName = "MarketplaceId")]
        public string MarketplaceId { get; set; }

        /// <summary>
        /// Gets or sets the price of the swapped item minus TaxAmount.
        /// </summary>
        [JsonProperty(PropertyName = "TaxExclusiveAmount")]
        public Currency TaxExclusiveAmount { get; set; }

        /// <summary>
        /// Gets or sets the tax on the network item swap paid by the seller.
        /// </summary>
        [JsonProperty(PropertyName = "TaxAmount")]
        public Currency TaxAmount { get; set; }

    }
}
