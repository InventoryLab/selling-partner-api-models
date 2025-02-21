// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace IL.Library.Amazon.SPAPI.Orders.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The shipping address for the order.
    /// </summary>
    public partial class OrderAddress
    {
        /// <summary>
        /// Initializes a new instance of the OrderAddress class.
        /// </summary>
        public OrderAddress()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OrderAddress class.
        /// </summary>
        /// <param name="amazonOrderId">An Amazon-defined order identifier, in
        /// 3-7-7 format.</param>
        public OrderAddress(string amazonOrderId, Address shippingAddress = default(Address))
        {
            AmazonOrderId = amazonOrderId;
            ShippingAddress = shippingAddress;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets an Amazon-defined order identifier, in 3-7-7 format.
        /// </summary>
        [JsonProperty(PropertyName = "AmazonOrderId")]
        public string AmazonOrderId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ShippingAddress")]
        public Address ShippingAddress { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (AmazonOrderId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AmazonOrderId");
            }
            if (ShippingAddress != null)
            {
                ShippingAddress.Validate();
            }
        }
    }
}
