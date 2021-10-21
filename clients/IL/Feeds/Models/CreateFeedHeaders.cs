// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace IL.Library.Amazon.SPAPI.Feeds.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Defines headers for createFeed operation.
    /// </summary>
    public partial class CreateFeedHeaders
    {
        /// <summary>
        /// Initializes a new instance of the CreateFeedHeaders class.
        /// </summary>
        public CreateFeedHeaders()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CreateFeedHeaders class.
        /// </summary>
        /// <param name="xAmznRequestId">Unique request reference ID.</param>
        public CreateFeedHeaders(string xAmznRequestId = default(string))
        {
            XAmznRequestId = xAmznRequestId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets unique request reference ID.
        /// </summary>
        [JsonProperty(PropertyName = "x-amzn-RequestId")]
        public string XAmznRequestId { get; set; }

    }
}
