// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace IL.Library.Amazon.SPAPI.FulfillmentInbound.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    public partial class InboundShipmentResult
    {
        /// <summary>
        /// Initializes a new instance of the InboundShipmentResult class.
        /// </summary>
        public InboundShipmentResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the InboundShipmentResult class.
        /// </summary>
        /// <param name="shipmentId">The shipment identifier submitted in the
        /// request.</param>
        public InboundShipmentResult(string shipmentId)
        {
            ShipmentId = shipmentId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the shipment identifier submitted in the request.
        /// </summary>
        [JsonProperty(PropertyName = "ShipmentId")]
        public string ShipmentId { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ShipmentId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ShipmentId");
            }
        }
    }
}
