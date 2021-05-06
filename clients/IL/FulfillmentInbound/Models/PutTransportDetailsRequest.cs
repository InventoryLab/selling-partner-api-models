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

    /// <summary>
    /// The request schema for a putTransportDetails operation.
    /// </summary>
    public partial class PutTransportDetailsRequest
    {
        /// <summary>
        /// Initializes a new instance of the PutTransportDetailsRequest class.
        /// </summary>
        public PutTransportDetailsRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PutTransportDetailsRequest class.
        /// </summary>
        /// <param name="isPartnered">Indicates whether a putTransportDetails
        /// request is for an Amazon-partnered carrier.</param>
        /// <param name="shipmentType">Possible values include: 'SP',
        /// 'LTL'</param>
        /// <param name="transportDetails">Information required to create an
        /// Amazon-partnered carrier shipping estimate, or to alert the Amazon
        /// fulfillment center to the arrival of an inbound shipment by a
        /// non-Amazon-partnered carrier.</param>
        public PutTransportDetailsRequest(bool isPartnered, string shipmentType, TransportDetailInput transportDetails)
        {
            IsPartnered = isPartnered;
            ShipmentType = shipmentType;
            TransportDetails = transportDetails;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets indicates whether a putTransportDetails request is for
        /// an Amazon-partnered carrier.
        /// </summary>
        [JsonProperty(PropertyName = "IsPartnered")]
        public bool IsPartnered { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'SP', 'LTL'
        /// </summary>
        [JsonProperty(PropertyName = "ShipmentType")]
        public string ShipmentType { get; set; }

        /// <summary>
        /// Gets or sets information required to create an Amazon-partnered
        /// carrier shipping estimate, or to alert the Amazon fulfillment
        /// center to the arrival of an inbound shipment by a
        /// non-Amazon-partnered carrier.
        /// </summary>
        [JsonProperty(PropertyName = "TransportDetails")]
        public TransportDetailInput TransportDetails { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ShipmentType == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ShipmentType");
            }
            if (TransportDetails == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "TransportDetails");
            }
            if (TransportDetails != null)
            {
                TransportDetails.Validate();
            }
        }
    }
}
