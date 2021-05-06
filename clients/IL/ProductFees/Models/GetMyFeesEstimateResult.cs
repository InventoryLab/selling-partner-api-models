// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace IL.Library.Amazon.SPAPI.ProductFees.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Response schema.
    /// </summary>
    public partial class GetMyFeesEstimateResult
    {
        /// <summary>
        /// Initializes a new instance of the GetMyFeesEstimateResult class.
        /// </summary>
        public GetMyFeesEstimateResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GetMyFeesEstimateResult class.
        /// </summary>
        /// <param name="feesEstimateResult">The item's estimated fees.</param>
        public GetMyFeesEstimateResult(FeesEstimateResult feesEstimateResult = default(FeesEstimateResult))
        {
            FeesEstimateResult = feesEstimateResult;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the item's estimated fees.
        /// </summary>
        [JsonProperty(PropertyName = "FeesEstimateResult")]
        public FeesEstimateResult FeesEstimateResult { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (FeesEstimateResult != null)
            {
                FeesEstimateResult.Validate();
            }
        }
    }
}
