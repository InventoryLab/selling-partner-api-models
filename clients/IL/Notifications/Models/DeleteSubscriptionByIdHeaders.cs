// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace IL.Library.Amazon.SPAPI.Notifications.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Defines headers for deleteSubscriptionById operation.
    /// </summary>
    public partial class DeleteSubscriptionByIdHeaders
    {
        /// <summary>
        /// Initializes a new instance of the DeleteSubscriptionByIdHeaders
        /// class.
        /// </summary>
        public DeleteSubscriptionByIdHeaders()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DeleteSubscriptionByIdHeaders
        /// class.
        /// </summary>
        /// <param name="xAmznRequestId">Unique request reference
        /// identifier.</param>
        public DeleteSubscriptionByIdHeaders(string xAmznRequestId = default(string))
        {
            XAmznRequestId = xAmznRequestId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets unique request reference identifier.
        /// </summary>
        [JsonProperty(PropertyName = "x-amzn-RequestId")]
        public string XAmznRequestId { get; set; }

    }
}
