// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace IL.Library.Amazon.SPAPI.CatalogItems.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// An item in the Amazon catalog.
    /// </summary>
    public partial class Item
    {
        /// <summary>
        /// Initializes a new instance of the Item class.
        /// </summary>
        public Item()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Item class.
        /// </summary>
        public Item(string asin, IDictionary<string, object> attributes = default(IDictionary<string, object>), IList<ItemIdentifiersByMarketplace> identifiers = default(IList<ItemIdentifiersByMarketplace>), IList<ItemImagesByMarketplace> images = default(IList<ItemImagesByMarketplace>), IList<ItemProductTypeByMarketplace> productTypes = default(IList<ItemProductTypeByMarketplace>), IList<ItemSalesRanksByMarketplace> salesRanks = default(IList<ItemSalesRanksByMarketplace>), IList<ItemSummaryByMarketplace> summaries = default(IList<ItemSummaryByMarketplace>), IList<ItemVariationsByMarketplace> variations = default(IList<ItemVariationsByMarketplace>), IList<ItemVendorDetailsByMarketplace> vendorDetails = default(IList<ItemVendorDetailsByMarketplace>))
        {
            Asin = asin;
            Attributes = attributes;
            Identifiers = identifiers;
            Images = images;
            ProductTypes = productTypes;
            SalesRanks = salesRanks;
            Summaries = summaries;
            Variations = variations;
            VendorDetails = vendorDetails;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "asin")]
        public string Asin { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "attributes")]
        public IDictionary<string, object> Attributes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "identifiers")]
        public IList<ItemIdentifiersByMarketplace> Identifiers { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "images")]
        public IList<ItemImagesByMarketplace> Images { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "productTypes")]
        public IList<ItemProductTypeByMarketplace> ProductTypes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "salesRanks")]
        public IList<ItemSalesRanksByMarketplace> SalesRanks { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "summaries")]
        public IList<ItemSummaryByMarketplace> Summaries { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "variations")]
        public IList<ItemVariationsByMarketplace> Variations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "vendorDetails")]
        public IList<ItemVendorDetailsByMarketplace> VendorDetails { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Asin == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Asin");
            }
            if (Identifiers != null)
            {
                foreach (var element in Identifiers)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (Images != null)
            {
                foreach (var element1 in Images)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
            if (SalesRanks != null)
            {
                foreach (var element2 in SalesRanks)
                {
                    if (element2 != null)
                    {
                        element2.Validate();
                    }
                }
            }
            if (Summaries != null)
            {
                foreach (var element3 in Summaries)
                {
                    if (element3 != null)
                    {
                        element3.Validate();
                    }
                }
            }
            if (Variations != null)
            {
                foreach (var element4 in Variations)
                {
                    if (element4 != null)
                    {
                        element4.Validate();
                    }
                }
            }
            if (VendorDetails != null)
            {
                foreach (var element5 in VendorDetails)
                {
                    if (element5 != null)
                    {
                        element5.Validate();
                    }
                }
            }
        }
    }
}
