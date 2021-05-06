// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace IL.Library.Amazon.SPAPI.Tokens.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A list of error responses returned when a request is unsuccessful.
    /// </summary>
    public partial class ErrorList
    {
        /// <summary>
        /// Initializes a new instance of the ErrorList class.
        /// </summary>
        public ErrorList()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ErrorList class.
        /// </summary>
        public ErrorList(IList<Error> errors = default(IList<Error>))
        {
            Errors = errors;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "errors")]
        public IList<Error> Errors { get; set; }

    }
}
