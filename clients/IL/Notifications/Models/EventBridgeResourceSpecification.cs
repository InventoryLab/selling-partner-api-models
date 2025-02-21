// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace IL.Library.Amazon.SPAPI.Notifications.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The information required to create an Amazon EventBridge destination.
    /// </summary>
    public partial class EventBridgeResourceSpecification
    {
        /// <summary>
        /// Initializes a new instance of the EventBridgeResourceSpecification
        /// class.
        /// </summary>
        public EventBridgeResourceSpecification()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EventBridgeResourceSpecification
        /// class.
        /// </summary>
        /// <param name="region">The AWS region in which you will be receiving
        /// the notifications.</param>
        /// <param name="accountId">The identifier for the AWS account that is
        /// responsible for charges related to receiving notifications.</param>
        public EventBridgeResourceSpecification(string region, string accountId)
        {
            Region = region;
            AccountId = accountId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the AWS region in which you will be receiving the
        /// notifications.
        /// </summary>
        [JsonProperty(PropertyName = "region")]
        public string Region { get; set; }

        /// <summary>
        /// Gets or sets the identifier for the AWS account that is responsible
        /// for charges related to receiving notifications.
        /// </summary>
        [JsonProperty(PropertyName = "accountId")]
        public string AccountId { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Region == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Region");
            }
            if (AccountId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AccountId");
            }
        }
    }
}
