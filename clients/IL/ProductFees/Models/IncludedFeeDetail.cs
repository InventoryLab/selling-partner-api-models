// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace IL.Library.Amazon.SPAPI.ProductFees.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The type of fee, fee amount, and other details.
    /// </summary>
    public partial class IncludedFeeDetail
    {
        /// <summary>
        /// Initializes a new instance of the IncludedFeeDetail class.
        /// </summary>
        public IncludedFeeDetail()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IncludedFeeDetail class.
        /// </summary>
        /// <param name="feeType">The type of fee charged to a seller.</param>
        /// <param name="feeAmount">The amount charged for a given fee.</param>
        /// <param name="finalFee">The final fee amount for a given
        /// fee.</param>
        /// <param name="feePromotion">The promotion amount for a given
        /// fee.</param>
        /// <param name="taxAmount">The tax amount for a given fee.</param>
        public IncludedFeeDetail(string feeType, MoneyType feeAmount, MoneyType finalFee, MoneyType feePromotion = default(MoneyType), MoneyType taxAmount = default(MoneyType))
        {
            FeeType = feeType;
            FeeAmount = feeAmount;
            FeePromotion = feePromotion;
            TaxAmount = taxAmount;
            FinalFee = finalFee;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the type of fee charged to a seller.
        /// </summary>
        [JsonProperty(PropertyName = "FeeType")]
        public string FeeType { get; set; }

        /// <summary>
        /// Gets or sets the amount charged for a given fee.
        /// </summary>
        [JsonProperty(PropertyName = "FeeAmount")]
        public MoneyType FeeAmount { get; set; }

        /// <summary>
        /// Gets or sets the promotion amount for a given fee.
        /// </summary>
        [JsonProperty(PropertyName = "FeePromotion")]
        public MoneyType FeePromotion { get; set; }

        /// <summary>
        /// Gets or sets the tax amount for a given fee.
        /// </summary>
        [JsonProperty(PropertyName = "TaxAmount")]
        public MoneyType TaxAmount { get; set; }

        /// <summary>
        /// Gets or sets the final fee amount for a given fee.
        /// </summary>
        [JsonProperty(PropertyName = "FinalFee")]
        public MoneyType FinalFee { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (FeeType == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "FeeType");
            }
            if (FeeAmount == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "FeeAmount");
            }
            if (FinalFee == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "FinalFee");
            }
        }
    }
}
