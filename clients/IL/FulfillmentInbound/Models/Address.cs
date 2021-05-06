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
        /// <param name="name">Name of the individual or business.</param>
        /// <param name="addressLine1">The street address information.</param>
        /// <param name="city">The city.</param>
        /// <param name="stateOrProvinceCode">The state or province code.
        ///
        /// If state or province codes are used in your marketplace, it is
        /// recommended that you include one with your request. This helps
        /// Amazon to select the most appropriate Amazon fulfillment center for
        /// your inbound shipment plan.</param>
        /// <param name="countryCode">The country code in two-character ISO
        /// 3166-1 alpha-2 format.</param>
        /// <param name="postalCode">The postal code.
        ///
        /// If postal codes are used in your marketplace, we recommended that
        /// you include one with your request. This helps Amazon select the
        /// most appropriate Amazon fulfillment center for the inbound shipment
        /// plan.</param>
        /// <param name="addressLine2">Additional street address information,
        /// if required.</param>
        /// <param name="districtOrCounty">The district or county.</param>
        public Address(string name, string addressLine1, string city, string stateOrProvinceCode, string countryCode, string postalCode, string addressLine2 = default(string), string districtOrCounty = default(string))
        {
            Name = name;
            AddressLine1 = addressLine1;
            AddressLine2 = addressLine2;
            DistrictOrCounty = districtOrCounty;
            City = city;
            StateOrProvinceCode = stateOrProvinceCode;
            CountryCode = countryCode;
            PostalCode = postalCode;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets name of the individual or business.
        /// </summary>
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the street address information.
        /// </summary>
        [JsonProperty(PropertyName = "AddressLine1")]
        public string AddressLine1 { get; set; }

        /// <summary>
        /// Gets or sets additional street address information, if required.
        /// </summary>
        [JsonProperty(PropertyName = "AddressLine2")]
        public string AddressLine2 { get; set; }

        /// <summary>
        /// Gets or sets the district or county.
        /// </summary>
        [JsonProperty(PropertyName = "DistrictOrCounty")]
        public string DistrictOrCounty { get; set; }

        /// <summary>
        /// Gets or sets the city.
        /// </summary>
        [JsonProperty(PropertyName = "City")]
        public string City { get; set; }

        /// <summary>
        /// Gets or sets the state or province code.
        ///
        /// If state or province codes are used in your marketplace, it is
        /// recommended that you include one with your request. This helps
        /// Amazon to select the most appropriate Amazon fulfillment center for
        /// your inbound shipment plan.
        /// </summary>
        [JsonProperty(PropertyName = "StateOrProvinceCode")]
        public string StateOrProvinceCode { get; set; }

        /// <summary>
        /// Gets or sets the country code in two-character ISO 3166-1 alpha-2
        /// format.
        /// </summary>
        [JsonProperty(PropertyName = "CountryCode")]
        public string CountryCode { get; set; }

        /// <summary>
        /// Gets or sets the postal code.
        ///
        /// If postal codes are used in your marketplace, we recommended that
        /// you include one with your request. This helps Amazon select the
        /// most appropriate Amazon fulfillment center for the inbound shipment
        /// plan.
        /// </summary>
        [JsonProperty(PropertyName = "PostalCode")]
        public string PostalCode { get; set; }

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
            if (AddressLine1 == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AddressLine1");
            }
            if (City == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "City");
            }
            if (StateOrProvinceCode == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "StateOrProvinceCode");
            }
            if (CountryCode == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "CountryCode");
            }
            if (PostalCode == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "PostalCode");
            }
            if (Name != null)
            {
                if (Name.Length > 50)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "Name", 50);
                }
            }
            if (AddressLine1 != null)
            {
                if (AddressLine1.Length > 180)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "AddressLine1", 180);
                }
            }
            if (AddressLine2 != null)
            {
                if (AddressLine2.Length > 60)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "AddressLine2", 60);
                }
            }
            if (DistrictOrCounty != null)
            {
                if (DistrictOrCounty.Length > 25)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "DistrictOrCounty", 25);
                }
            }
            if (City != null)
            {
                if (City.Length > 30)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "City", 30);
                }
            }
            if (PostalCode != null)
            {
                if (PostalCode.Length > 30)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "PostalCode", 30);
                }
            }
        }
    }
}
