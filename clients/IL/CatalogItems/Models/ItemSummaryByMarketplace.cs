// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace IL.Library.Amazon.SPAPI.CatalogItems.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Summary details of an Amazon catalog item for the indicated Amazon
    /// marketplace.
    /// </summary>
    public partial class ItemSummaryByMarketplace
    {
        /// <summary>
        /// Initializes a new instance of the ItemSummaryByMarketplace class.
        /// </summary>
        public ItemSummaryByMarketplace()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ItemSummaryByMarketplace class.
        /// </summary>
        /// <param name="marketplaceId">Amazon marketplace identifier.</param>
        /// <param name="brand">Name of the brand associated with an Amazon
        /// catalog item.</param>
        /// <param name="browseClassification">Classification (browse node)
        /// associated with an Amazon catalog item.</param>
        /// <param name="color">Name of the color associated with an Amazon
        /// catalog item.</param>
        /// <param name="itemClassification">Classification type associated
        /// with the Amazon catalog item. Possible values include:
        /// 'BASE_PRODUCT', 'OTHER', 'PRODUCT_BUNDLE',
        /// 'VARIATION_PARENT'</param>
        /// <param name="itemName">Name, or title, associated with an Amazon
        /// catalog item.</param>
        /// <param name="manufacturer">Name of the manufacturer associated with
        /// an Amazon catalog item.</param>
        /// <param name="modelNumber">Model number associated with an Amazon
        /// catalog item.</param>
        /// <param name="packageQuantity">Quantity of an Amazon catalog item in
        /// one package.</param>
        /// <param name="partNumber">Part number associated with an Amazon
        /// catalog item.</param>
        /// <param name="size">Name of the size associated with an Amazon
        /// catalog item.</param>
        /// <param name="style">Name of the style associated with an Amazon
        /// catalog item.</param>
        /// <param name="websiteDisplayGroup">Name of the website display group
        /// associated with an Amazon catalog item.</param>
        public ItemSummaryByMarketplace(string marketplaceId, string brand = default(string), ItemBrowseClassification browseClassification = default(ItemBrowseClassification), string color = default(string), string itemClassification = default(string), string itemName = default(string), string manufacturer = default(string), string modelNumber = default(string), int? packageQuantity = default(int?), string partNumber = default(string), string size = default(string), string style = default(string), string websiteDisplayGroup = default(string))
        {
            MarketplaceId = marketplaceId;
            Brand = brand;
            BrowseClassification = browseClassification;
            Color = color;
            ItemClassification = itemClassification;
            ItemName = itemName;
            Manufacturer = manufacturer;
            ModelNumber = modelNumber;
            PackageQuantity = packageQuantity;
            PartNumber = partNumber;
            Size = size;
            Style = style;
            WebsiteDisplayGroup = websiteDisplayGroup;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets amazon marketplace identifier.
        /// </summary>
        [JsonProperty(PropertyName = "marketplaceId")]
        public string MarketplaceId { get; set; }

        /// <summary>
        /// Gets or sets name of the brand associated with an Amazon catalog
        /// item.
        /// </summary>
        [JsonProperty(PropertyName = "brand")]
        public string Brand { get; set; }

        /// <summary>
        /// Gets or sets classification (browse node) associated with an Amazon
        /// catalog item.
        /// </summary>
        [JsonProperty(PropertyName = "browseClassification")]
        public ItemBrowseClassification BrowseClassification { get; set; }

        /// <summary>
        /// Gets or sets name of the color associated with an Amazon catalog
        /// item.
        /// </summary>
        [JsonProperty(PropertyName = "color")]
        public string Color { get; set; }

        /// <summary>
        /// Gets or sets classification type associated with the Amazon catalog
        /// item. Possible values include: 'BASE_PRODUCT', 'OTHER',
        /// 'PRODUCT_BUNDLE', 'VARIATION_PARENT'
        /// </summary>
        [JsonProperty(PropertyName = "itemClassification")]
        public string ItemClassification { get; set; }

        /// <summary>
        /// Gets or sets name, or title, associated with an Amazon catalog
        /// item.
        /// </summary>
        [JsonProperty(PropertyName = "itemName")]
        public string ItemName { get; set; }

        /// <summary>
        /// Gets or sets name of the manufacturer associated with an Amazon
        /// catalog item.
        /// </summary>
        [JsonProperty(PropertyName = "manufacturer")]
        public string Manufacturer { get; set; }

        /// <summary>
        /// Gets or sets model number associated with an Amazon catalog item.
        /// </summary>
        [JsonProperty(PropertyName = "modelNumber")]
        public string ModelNumber { get; set; }

        /// <summary>
        /// Gets or sets quantity of an Amazon catalog item in one package.
        /// </summary>
        [JsonProperty(PropertyName = "packageQuantity")]
        public int? PackageQuantity { get; set; }

        /// <summary>
        /// Gets or sets part number associated with an Amazon catalog item.
        /// </summary>
        [JsonProperty(PropertyName = "partNumber")]
        public string PartNumber { get; set; }

        /// <summary>
        /// Gets or sets name of the size associated with an Amazon catalog
        /// item.
        /// </summary>
        [JsonProperty(PropertyName = "size")]
        public string Size { get; set; }

        /// <summary>
        /// Gets or sets name of the style associated with an Amazon catalog
        /// item.
        /// </summary>
        [JsonProperty(PropertyName = "style")]
        public string Style { get; set; }

        /// <summary>
        /// Gets or sets name of the website display group associated with an
        /// Amazon catalog item.
        /// </summary>
        [JsonProperty(PropertyName = "websiteDisplayGroup")]
        public string WebsiteDisplayGroup { get; set; }

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
            if (BrowseClassification != null)
            {
                BrowseClassification.Validate();
            }
        }
    }
}
