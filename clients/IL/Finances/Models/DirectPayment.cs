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
    /// A payment made directly to a seller.
    /// </summary>
    public partial class DirectPayment
    {
        /// <summary>
        /// Initializes a new instance of the DirectPayment class.
        /// </summary>
        public DirectPayment()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DirectPayment class.
        /// </summary>
        /// <param name="directPaymentType">The type of payment.
        ///
        /// Possible values:
        ///
        /// * StoredValueCardRevenue - The amount that is deducted from the
        /// seller's account because the seller received money through a stored
        /// value card.
        ///
        /// * StoredValueCardRefund - The amount that Amazon returns to the
        /// seller if the order that is bought using a stored value card is
        /// refunded.
        ///
        /// * PrivateLabelCreditCardRevenue - The amount that is deducted from
        /// the seller's account because the seller received money through a
        /// private label credit card offered by Amazon.
        ///
        /// * PrivateLabelCreditCardRefund - The amount that Amazon returns to
        /// the seller if the order that is bought using a private label credit
        /// card offered by Amazon is refunded.
        ///
        /// * CollectOnDeliveryRevenue - The COD amount that the seller
        /// collected directly from the buyer.
        ///
        /// * CollectOnDeliveryRefund - The amount that Amazon refunds to the
        /// buyer if an order paid for by COD is refunded.</param>
        /// <param name="directPaymentAmount">The amount of the direct
        /// payment.</param>
        public DirectPayment(string directPaymentType = default(string), Currency directPaymentAmount = default(Currency))
        {
            DirectPaymentType = directPaymentType;
            DirectPaymentAmount = directPaymentAmount;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the type of payment.
        ///
        /// Possible values:
        ///
        /// * StoredValueCardRevenue - The amount that is deducted from the
        /// seller's account because the seller received money through a stored
        /// value card.
        ///
        /// * StoredValueCardRefund - The amount that Amazon returns to the
        /// seller if the order that is bought using a stored value card is
        /// refunded.
        ///
        /// * PrivateLabelCreditCardRevenue - The amount that is deducted from
        /// the seller's account because the seller received money through a
        /// private label credit card offered by Amazon.
        ///
        /// * PrivateLabelCreditCardRefund - The amount that Amazon returns to
        /// the seller if the order that is bought using a private label credit
        /// card offered by Amazon is refunded.
        ///
        /// * CollectOnDeliveryRevenue - The COD amount that the seller
        /// collected directly from the buyer.
        ///
        /// * CollectOnDeliveryRefund - The amount that Amazon refunds to the
        /// buyer if an order paid for by COD is refunded.
        /// </summary>
        [JsonProperty(PropertyName = "DirectPaymentType")]
        public string DirectPaymentType { get; set; }

        /// <summary>
        /// Gets or sets the amount of the direct payment.
        /// </summary>
        [JsonProperty(PropertyName = "DirectPaymentAmount")]
        public Currency DirectPaymentAmount { get; set; }

    }
}
