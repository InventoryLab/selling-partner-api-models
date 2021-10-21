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
    /// The destination resource types.
    /// </summary>
    public partial class DestinationResource
    {
        /// <summary>
        /// Initializes a new instance of the DestinationResource class.
        /// </summary>
        public DestinationResource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DestinationResource class.
        /// </summary>
        /// <param name="sqs">An Amazon Simple Queue Service (SQS) queue
        /// destination.</param>
        /// <param name="eventBridge">An Amazon EventBridge
        /// destination.</param>
        public DestinationResource(SqsResource sqs = default(SqsResource), EventBridgeResource eventBridge = default(EventBridgeResource))
        {
            Sqs = sqs;
            EventBridge = eventBridge;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets an Amazon Simple Queue Service (SQS) queue
        /// destination.
        /// </summary>
        [JsonProperty(PropertyName = "sqs")]
        public SqsResource Sqs { get; set; }

        /// <summary>
        /// Gets or sets an Amazon EventBridge destination.
        /// </summary>
        [JsonProperty(PropertyName = "eventBridge")]
        public EventBridgeResource EventBridge { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Sqs != null)
            {
                Sqs.Validate();
            }
            if (EventBridge != null)
            {
                EventBridge.Validate();
            }
        }
    }
}
