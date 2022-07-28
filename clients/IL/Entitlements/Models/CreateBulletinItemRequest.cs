// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace IL.Library.Amazon.SPAPI.Entitlements.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The request schema for the createBulletinItem operation.
    /// </summary>
    public partial class CreateBulletinItemRequest
    {
        /// <summary>
        /// Initializes a new instance of the CreateBulletinItemRequest class.
        /// </summary>
        public CreateBulletinItemRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CreateBulletinItemRequest class.
        /// </summary>
        /// <param name="bulletinItemParameters">The dynamic parameters
        /// required to replace all placeholders in bulletin item template
        /// provided in 'bulletinItemType'.</param>
        public CreateBulletinItemRequest(IDictionary<string, object> bulletinItemParameters)
        {
            BulletinItemParameters = bulletinItemParameters;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the dynamic parameters required to replace all
        /// placeholders in bulletin item template provided in
        /// 'bulletinItemType'.
        /// </summary>
        [JsonProperty(PropertyName = "bulletinItemParameters")]
        public IDictionary<string, object> BulletinItemParameters { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (BulletinItemParameters == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "BulletinItemParameters");
            }
        }
    }
}
