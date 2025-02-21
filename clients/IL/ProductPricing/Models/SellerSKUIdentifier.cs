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

    public partial class SellerSKUIdentifier
    {
        /// <summary>
        /// Initializes a new instance of the SellerSKUIdentifier class.
        /// </summary>
        public SellerSKUIdentifier()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SellerSKUIdentifier class.
        /// </summary>
        /// <param name="marketplaceId">A marketplace identifier.</param>
        /// <param name="sellerId">The seller identifier submitted for the
        /// operation.</param>
        /// <param name="sellerSKU">The seller stock keeping unit (SKU) of the
        /// item.</param>
        public SellerSKUIdentifier(string marketplaceId, string sellerId, string sellerSKU)
        {
            MarketplaceId = marketplaceId;
            SellerId = sellerId;
            SellerSKU = sellerSKU;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a marketplace identifier.
        /// </summary>
        [JsonProperty(PropertyName = "MarketplaceId")]
        public string MarketplaceId { get; set; }

        /// <summary>
        /// Gets or sets the seller identifier submitted for the operation.
        /// </summary>
        [JsonProperty(PropertyName = "SellerId")]
        public string SellerId { get; set; }

        /// <summary>
        /// Gets or sets the seller stock keeping unit (SKU) of the item.
        /// </summary>
        [JsonProperty(PropertyName = "SellerSKU")]
        public string SellerSKU { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (MarketplaceId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "MarketplaceId");
            }
            if (SellerId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SellerId");
            }
            if (SellerSKU == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SellerSKU");
            }
        }
    }
}
