// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace IL.Library.Amazon.SPAPI.ListingsRestrictions.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A reason for the restriction, including path forward links that may
    /// allow Selling Partners to remove the restriction, if available.
    /// </summary>
    public partial class Reason
    {
        /// <summary>
        /// Initializes a new instance of the Reason class.
        /// </summary>
        public Reason()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Reason class.
        /// </summary>
        /// <param name="message">A message describing the reason for the
        /// restriction.</param>
        /// <param name="reasonCode">A code indicating why the listing is
        /// restricted. Possible values include: 'APPROVAL_REQUIRED',
        /// 'ASIN_NOT_FOUND', 'NOT_ELIGIBLE'</param>
        /// <param name="links">A list of path forward links that may allow
        /// Selling Partners to remove the restriction.</param>
        public Reason(string message, string reasonCode = default(string), IList<Link> links = default(IList<Link>))
        {
            Message = message;
            ReasonCode = reasonCode;
            Links = links;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a message describing the reason for the restriction.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets a code indicating why the listing is restricted.
        /// Possible values include: 'APPROVAL_REQUIRED', 'ASIN_NOT_FOUND',
        /// 'NOT_ELIGIBLE'
        /// </summary>
        [JsonProperty(PropertyName = "reasonCode")]
        public string ReasonCode { get; set; }

        /// <summary>
        /// Gets or sets a list of path forward links that may allow Selling
        /// Partners to remove the restriction.
        /// </summary>
        [JsonProperty(PropertyName = "links")]
        public IList<Link> Links { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Message == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Message");
            }
            if (Links != null)
            {
                foreach (var element in Links)
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
