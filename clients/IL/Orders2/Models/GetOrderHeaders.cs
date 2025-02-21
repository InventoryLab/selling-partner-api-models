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
    /// Defines headers for getOrder operation.
    /// </summary>
    public partial class GetOrderHeaders
    {
        /// <summary>
        /// Initializes a new instance of the GetOrderHeaders class.
        /// </summary>
        public GetOrderHeaders()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GetOrderHeaders class.
        /// </summary>
        /// <param name="xAmznRequestId">Unique request reference ID.</param>
        public GetOrderHeaders(string xAmznRequestId = default(string))
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
