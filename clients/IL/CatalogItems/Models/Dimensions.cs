// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace IL.Library.Amazon.SPAPI.CatalogItems.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Dimensions of an Amazon catalog item or item in its packaging.
    /// </summary>
    public partial class Dimensions
    {
        /// <summary>
        /// Initializes a new instance of the Dimensions class.
        /// </summary>
        public Dimensions()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Dimensions class.
        /// </summary>
        /// <param name="height">Height of an item or item package.</param>
        /// <param name="length">Length of an item or item package.</param>
        /// <param name="weight">Weight of an item or item package.</param>
        /// <param name="width">Width of an item or item package.</param>
        public Dimensions(Dimension height = default(Dimension), Dimension length = default(Dimension), Dimension weight = default(Dimension), Dimension width = default(Dimension))
        {
            Height = height;
            Length = length;
            Weight = weight;
            Width = width;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets height of an item or item package.
        /// </summary>
        [JsonProperty(PropertyName = "height")]
        public Dimension Height { get; set; }

        /// <summary>
        /// Gets or sets length of an item or item package.
        /// </summary>
        [JsonProperty(PropertyName = "length")]
        public Dimension Length { get; set; }

        /// <summary>
        /// Gets or sets weight of an item or item package.
        /// </summary>
        [JsonProperty(PropertyName = "weight")]
        public Dimension Weight { get; set; }

        /// <summary>
        /// Gets or sets width of an item or item package.
        /// </summary>
        [JsonProperty(PropertyName = "width")]
        public Dimension Width { get; set; }

    }
}
