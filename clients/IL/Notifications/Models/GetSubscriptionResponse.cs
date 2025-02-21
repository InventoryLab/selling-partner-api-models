// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace IL.Library.Amazon.SPAPI.Notifications.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The response schema for the getSubscription operation.
    /// </summary>
    public partial class GetSubscriptionResponse
    {
        /// <summary>
        /// Initializes a new instance of the GetSubscriptionResponse class.
        /// </summary>
        public GetSubscriptionResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GetSubscriptionResponse class.
        /// </summary>
        /// <param name="payload">The payload for the getSubscription
        /// operation.</param>
        /// <param name="errors">One or more unexpected errors occurred during
        /// the getSubscription operation.</param>
        public GetSubscriptionResponse(Subscription payload = default(Subscription), IList<Error> errors = default(IList<Error>))
        {
            Payload = payload;
            Errors = errors;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the payload for the getSubscription operation.
        /// </summary>
        [JsonProperty(PropertyName = "payload")]
        public Subscription Payload { get; set; }

        /// <summary>
        /// Gets or sets one or more unexpected errors occurred during the
        /// getSubscription operation.
        /// </summary>
        [JsonProperty(PropertyName = "errors")]
        public IList<Error> Errors { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Payload != null)
            {
                Payload.Validate();
            }
            if (Errors != null)
            {
                foreach (var element in Errors)
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
