// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace IL.Library.Amazon.SPAPI.Orders.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The number of Amazon Points offered with the purchase of an item, and
    /// their monetary value.
    /// </summary>
    public partial class PointsGrantedDetail
    {
        /// <summary>
        /// Initializes a new instance of the PointsGrantedDetail class.
        /// </summary>
        public PointsGrantedDetail()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PointsGrantedDetail class.
        /// </summary>
        /// <param name="pointsNumber">The number of Amazon Points granted with
        /// the purchase of an item.</param>
        /// <param name="pointsMonetaryValue">The monetary value of the Amazon
        /// Points granted.</param>
        public PointsGrantedDetail(int? pointsNumber = default(int?), Money pointsMonetaryValue = default(Money))
        {
            PointsNumber = pointsNumber;
            PointsMonetaryValue = pointsMonetaryValue;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the number of Amazon Points granted with the purchase
        /// of an item.
        /// </summary>
        [JsonProperty(PropertyName = "PointsNumber")]
        public int? PointsNumber { get; set; }

        /// <summary>
        /// Gets or sets the monetary value of the Amazon Points granted.
        /// </summary>
        [JsonProperty(PropertyName = "PointsMonetaryValue")]
        public Money PointsMonetaryValue { get; set; }

    }
}
