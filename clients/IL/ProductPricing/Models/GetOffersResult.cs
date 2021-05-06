// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace IL.Library.Amazon.SPAPI.ProductPricing.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class GetOffersResult
    {
        /// <summary>
        /// Initializes a new instance of the GetOffersResult class.
        /// </summary>
        public GetOffersResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GetOffersResult class.
        /// </summary>
        /// <param name="marketplaceID">A marketplace identifier.</param>
        /// <param name="itemCondition">The condition of the item. Possible
        /// values include: 'New', 'Used', 'Collectible', 'Refurbished',
        /// 'Club'</param>
        /// <param name="status">The status of the operation.</param>
        /// <param name="identifier">Metadata that identifies the item.</param>
        /// <param name="summary">Pricing information about the item.</param>
        /// <param name="offers">A list of offer details. The list is the same
        /// length as the TotalOfferCount in the Summary or 20, whichever is
        /// less.</param>
        /// <param name="aSIN">The Amazon Standard Identification Number (ASIN)
        /// of the item.</param>
        /// <param name="sKU">The stock keeping unit (SKU) of the item.</param>
        public GetOffersResult(string marketplaceID, string itemCondition, string status, ItemIdentifier identifier, Summary summary, IList<OfferDetail> offers, string aSIN = default(string), string sKU = default(string))
        {
            MarketplaceID = marketplaceID;
            ASIN = aSIN;
            SKU = sKU;
            ItemCondition = itemCondition;
            Status = status;
            Identifier = identifier;
            Summary = summary;
            Offers = offers;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a marketplace identifier.
        /// </summary>
        [JsonProperty(PropertyName = "MarketplaceID")]
        public string MarketplaceID { get; set; }

        /// <summary>
        /// Gets or sets the Amazon Standard Identification Number (ASIN) of
        /// the item.
        /// </summary>
        [JsonProperty(PropertyName = "ASIN")]
        public string ASIN { get; set; }

        /// <summary>
        /// Gets or sets the stock keeping unit (SKU) of the item.
        /// </summary>
        [JsonProperty(PropertyName = "SKU")]
        public string SKU { get; set; }

        /// <summary>
        /// Gets or sets the condition of the item. Possible values include:
        /// 'New', 'Used', 'Collectible', 'Refurbished', 'Club'
        /// </summary>
        [JsonProperty(PropertyName = "ItemCondition")]
        public string ItemCondition { get; set; }

        /// <summary>
        /// Gets or sets the status of the operation.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets metadata that identifies the item.
        /// </summary>
        [JsonProperty(PropertyName = "Identifier")]
        public ItemIdentifier Identifier { get; set; }

        /// <summary>
        /// Gets or sets pricing information about the item.
        /// </summary>
        [JsonProperty(PropertyName = "Summary")]
        public Summary Summary { get; set; }

        /// <summary>
        /// Gets or sets a list of offer details. The list is the same length
        /// as the TotalOfferCount in the Summary or 20, whichever is less.
        /// </summary>
        [JsonProperty(PropertyName = "Offers")]
        public IList<OfferDetail> Offers { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (MarketplaceID == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "MarketplaceID");
            }
            if (ItemCondition == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ItemCondition");
            }
            if (Status == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Status");
            }
            if (Identifier == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Identifier");
            }
            if (Summary == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Summary");
            }
            if (Offers == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Offers");
            }
            if (Identifier != null)
            {
                Identifier.Validate();
            }
            if (Summary != null)
            {
                Summary.Validate();
            }
            if (Offers != null)
            {
                foreach (var element in Offers)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
