// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace IL.Library.Amazon.SPAPI.FulfillmentInbound.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Item information for an inbound shipment. Submitted with a call to the
    /// createInboundShipment or updateInboundShipment operation.
    /// </summary>
    public partial class InboundShipmentItem
    {
        /// <summary>
        /// Initializes a new instance of the InboundShipmentItem class.
        /// </summary>
        public InboundShipmentItem()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the InboundShipmentItem class.
        /// </summary>
        /// <param name="sellerSKU">The seller SKU of the item.</param>
        /// <param name="quantityShipped">The item quantity that you are
        /// shipping.</param>
        /// <param name="shipmentId">A shipment identifier originally returned
        /// by the createInboundShipmentPlan operation.</param>
        /// <param name="fulfillmentNetworkSKU">Amazon's fulfillment network
        /// SKU of the item.</param>
        /// <param name="quantityReceived">The item quantity that has been
        /// received at an Amazon fulfillment center.</param>
        /// <param name="quantityInCase">The item quantity in each case, for
        /// case-packed items. Note that QuantityInCase multiplied by the
        /// number of boxes in the inbound shipment equals QuantityShipped.
        /// Also note that all of the boxes of an inbound shipment must either
        /// be case packed or individually packed. For that reason, when you
        /// submit the createInboundShipment or the updateInboundShipment
        /// operation, the value of QuantityInCase must be provided for every
        /// item in the shipment or for none of the items in the
        /// shipment.</param>
        /// <param name="releaseDate">The date that a pre-order item will be
        /// available for sale.</param>
        public InboundShipmentItem(string sellerSKU, int quantityShipped, string shipmentId = default(string), string fulfillmentNetworkSKU = default(string), int? quantityReceived = default(int?), int? quantityInCase = default(int?), System.DateTime? releaseDate = default(System.DateTime?), IList<PrepDetails> prepDetailsList = default(IList<PrepDetails>))
        {
            ShipmentId = shipmentId;
            SellerSKU = sellerSKU;
            FulfillmentNetworkSKU = fulfillmentNetworkSKU;
            QuantityShipped = quantityShipped;
            QuantityReceived = quantityReceived;
            QuantityInCase = quantityInCase;
            ReleaseDate = releaseDate;
            PrepDetailsList = prepDetailsList;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a shipment identifier originally returned by the
        /// createInboundShipmentPlan operation.
        /// </summary>
        [JsonProperty(PropertyName = "ShipmentId")]
        public string ShipmentId { get; set; }

        /// <summary>
        /// Gets or sets the seller SKU of the item.
        /// </summary>
        [JsonProperty(PropertyName = "SellerSKU")]
        public string SellerSKU { get; set; }

        /// <summary>
        /// Gets or sets amazon's fulfillment network SKU of the item.
        /// </summary>
        [JsonProperty(PropertyName = "FulfillmentNetworkSKU")]
        public string FulfillmentNetworkSKU { get; set; }

        /// <summary>
        /// Gets or sets the item quantity that you are shipping.
        /// </summary>
        [JsonProperty(PropertyName = "QuantityShipped")]
        public int QuantityShipped { get; set; }

        /// <summary>
        /// Gets or sets the item quantity that has been received at an Amazon
        /// fulfillment center.
        /// </summary>
        [JsonProperty(PropertyName = "QuantityReceived")]
        public int? QuantityReceived { get; set; }

        /// <summary>
        /// Gets or sets the item quantity in each case, for case-packed items.
        /// Note that QuantityInCase multiplied by the number of boxes in the
        /// inbound shipment equals QuantityShipped. Also note that all of the
        /// boxes of an inbound shipment must either be case packed or
        /// individually packed. For that reason, when you submit the
        /// createInboundShipment or the updateInboundShipment operation, the
        /// value of QuantityInCase must be provided for every item in the
        /// shipment or for none of the items in the shipment.
        /// </summary>
        [JsonProperty(PropertyName = "QuantityInCase")]
        public int? QuantityInCase { get; set; }

        /// <summary>
        /// Gets or sets the date that a pre-order item will be available for
        /// sale.
        /// </summary>
        [JsonConverter(typeof(DateJsonConverter))]
        [JsonProperty(PropertyName = "ReleaseDate")]
        public System.DateTime? ReleaseDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PrepDetailsList")]
        public IList<PrepDetails> PrepDetailsList { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (SellerSKU == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SellerSKU");
            }
            if (PrepDetailsList != null)
            {
                foreach (var element in PrepDetailsList)
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
