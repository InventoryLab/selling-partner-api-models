// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace IL.Library.Amazon.SPAPI.FulfillmentInbound.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Reasons why a given seller SKU is not recommended for shipment to
    /// Amazon's fulfillment network.
    /// </summary>
    public partial class SKUInboundGuidance
    {
        /// <summary>
        /// Initializes a new instance of the SKUInboundGuidance class.
        /// </summary>
        public SKUInboundGuidance()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SKUInboundGuidance class.
        /// </summary>
        /// <param name="sellerSKU">The seller SKU of the item.</param>
        /// <param name="aSIN">The Amazon Standard Identification Number (ASIN)
        /// of the item.</param>
        /// <param name="inboundGuidance">Specific inbound guidance for an
        /// item. Possible values include: 'InboundNotRecommended',
        /// 'InboundOK'</param>
        /// <param name="guidanceReasonList">A list of reasons for the current
        /// inbound guidance for this item.</param>
        public SKUInboundGuidance(string sellerSKU, string aSIN, string inboundGuidance, IList<string> guidanceReasonList = default(IList<string>))
        {
            SellerSKU = sellerSKU;
            ASIN = aSIN;
            InboundGuidance = inboundGuidance;
            GuidanceReasonList = guidanceReasonList;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the seller SKU of the item.
        /// </summary>
        [JsonProperty(PropertyName = "SellerSKU")]
        public string SellerSKU { get; set; }

        /// <summary>
        /// Gets or sets the Amazon Standard Identification Number (ASIN) of
        /// the item.
        /// </summary>
        [JsonProperty(PropertyName = "ASIN")]
        public string ASIN { get; set; }

        /// <summary>
        /// Gets or sets specific inbound guidance for an item. Possible values
        /// include: 'InboundNotRecommended', 'InboundOK'
        /// </summary>
        [JsonProperty(PropertyName = "InboundGuidance")]
        public string InboundGuidance { get; set; }

        /// <summary>
        /// Gets or sets a list of reasons for the current inbound guidance for
        /// this item.
        /// </summary>
        [JsonProperty(PropertyName = "GuidanceReasonList")]
        public IList<string> GuidanceReasonList { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (SellerSKU == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SellerSKU");
            }
            if (ASIN == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ASIN");
            }
            if (InboundGuidance == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "InboundGuidance");
            }
        }
    }
}
