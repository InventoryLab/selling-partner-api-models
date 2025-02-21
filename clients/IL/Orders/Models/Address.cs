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
    public partial class Address
    {
        /// <summary>
        /// Initializes a new instance of the Address class.
        /// </summary>
        public Address()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Address class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="addressLine1">The street address.</param>
        /// <param name="addressLine2">Additional street address information,
        /// if required.</param>
        /// <param name="addressLine3">Additional street address information,
        /// if required.</param>
        /// <param name="city">The city </param>
        /// <param name="county">The county.</param>
        /// <param name="district">The district.</param>
        /// <param name="stateOrRegion">The state or region.</param>
        /// <param name="municipality">The municipality.</param>
        /// <param name="postalCode">The postal code.</param>
        /// <param name="countryCode">The country code. A two-character country
        /// code, in ISO 3166-1 alpha-2 format.</param>
        /// <param name="phone">The phone number. Not returned for Fulfillment
        /// by Amazon (FBA) orders.</param>
        /// <param name="addressType">The address type of the shipping address.
        /// Possible values include: 'Residential', 'Commercial'</param>
        public Address(string name, string addressLine1 = default(string), string addressLine2 = default(string), string addressLine3 = default(string), string city = default(string), string county = default(string), string district = default(string), string stateOrRegion = default(string), string municipality = default(string), string postalCode = default(string), string countryCode = default(string), string phone = default(string), string addressType = default(string))
        {
            Name = name;
            AddressLine1 = addressLine1;
            AddressLine2 = addressLine2;
            AddressLine3 = addressLine3;
            City = city;
            County = county;
            District = district;
            StateOrRegion = stateOrRegion;
            Municipality = municipality;
            PostalCode = postalCode;
            CountryCode = countryCode;
            Phone = phone;
            AddressType = addressType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the street address.
        /// </summary>
        [JsonProperty(PropertyName = "AddressLine1")]
        public string AddressLine1 { get; set; }

        /// <summary>
        /// Gets or sets additional street address information, if required.
        /// </summary>
        [JsonProperty(PropertyName = "AddressLine2")]
        public string AddressLine2 { get; set; }

        /// <summary>
        /// Gets or sets additional street address information, if required.
        /// </summary>
        [JsonProperty(PropertyName = "AddressLine3")]
        public string AddressLine3 { get; set; }

        /// <summary>
        /// Gets or sets the city
        /// </summary>
        [JsonProperty(PropertyName = "City")]
        public string City { get; set; }

        /// <summary>
        /// Gets or sets the county.
        /// </summary>
        [JsonProperty(PropertyName = "County")]
        public string County { get; set; }

        /// <summary>
        /// Gets or sets the district.
        /// </summary>
        [JsonProperty(PropertyName = "District")]
        public string District { get; set; }

        /// <summary>
        /// Gets or sets the state or region.
        /// </summary>
        [JsonProperty(PropertyName = "StateOrRegion")]
        public string StateOrRegion { get; set; }

        /// <summary>
        /// Gets or sets the municipality.
        /// </summary>
        [JsonProperty(PropertyName = "Municipality")]
        public string Municipality { get; set; }

        /// <summary>
        /// Gets or sets the postal code.
        /// </summary>
        [JsonProperty(PropertyName = "PostalCode")]
        public string PostalCode { get; set; }

        /// <summary>
        /// Gets or sets the country code. A two-character country code, in ISO
        /// 3166-1 alpha-2 format.
        /// </summary>
        [JsonProperty(PropertyName = "CountryCode")]
        public string CountryCode { get; set; }

        /// <summary>
        /// Gets or sets the phone number. Not returned for Fulfillment by
        /// Amazon (FBA) orders.
        /// </summary>
        [JsonProperty(PropertyName = "Phone")]
        public string Phone { get; set; }

        /// <summary>
        /// Gets or sets the address type of the shipping address. Possible
        /// values include: 'Residential', 'Commercial'
        /// </summary>
        [JsonProperty(PropertyName = "AddressType")]
        public string AddressType { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
        }
    }
}
