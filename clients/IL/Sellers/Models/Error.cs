// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace IL.Library.Amazon.SPAPI.Sellers.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Error response returned when the request is unsuccessful.
    /// </summary>
    public partial class Error
    {
        /// <summary>
        /// Initializes a new instance of the Error class.
        /// </summary>
        public Error()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Error class.
        /// </summary>
        /// <param name="code">An error code that identifies the type of error
        /// that occured.</param>
        /// <param name="message">A message that describes the error condition
        /// in a human-readable form.</param>
        /// <param name="details">Additional details that can help the caller
        /// understand or fix the issue.</param>
        public Error(string code, string message, string details = default(string))
        {
            Code = code;
            Message = message;
            Details = details;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets an error code that identifies the type of error that
        /// occured.
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets a message that describes the error condition in a
        /// human-readable form.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets additional details that can help the caller understand
        /// or fix the issue.
        /// </summary>
        [JsonProperty(PropertyName = "details")]
        public string Details { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Code == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Code");
            }
            if (Message == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Message");
            }
        }
    }
}
