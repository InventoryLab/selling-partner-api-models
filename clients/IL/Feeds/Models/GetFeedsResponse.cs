// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace IL.Library.Amazon.SPAPI.Feeds.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Response schema.
    /// </summary>
    public partial class GetFeedsResponse
    {
        /// <summary>
        /// Initializes a new instance of the GetFeedsResponse class.
        /// </summary>
        public GetFeedsResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GetFeedsResponse class.
        /// </summary>
        /// <param name="feeds">The feeds.</param>
        /// <param name="nextToken">Returned when the number of results exceeds
        /// pageSize. To get the next page of results, call the getFeeds
        /// operation with this token as the only parameter.</param>
        public GetFeedsResponse(IList<Feed> feeds, string nextToken = default(string))
        {
            Feeds = feeds;
            NextToken = nextToken;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the feeds.
        /// </summary>
        [JsonProperty(PropertyName = "feeds")]
        public IList<Feed> Feeds { get; set; }

        /// <summary>
        /// Gets or sets returned when the number of results exceeds pageSize.
        /// To get the next page of results, call the getFeeds operation with
        /// this token as the only parameter.
        /// </summary>
        [JsonProperty(PropertyName = "nextToken")]
        public string NextToken { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Feeds == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Feeds");
            }
            if (Feeds != null)
            {
                foreach (var element in Feeds)
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
