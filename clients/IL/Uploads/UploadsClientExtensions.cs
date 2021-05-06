// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace IL.Library.Amazon.SPAPI.Uploads
{
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for UploadsClient.
    /// </summary>
    public static partial class UploadsClientExtensions
    {
            /// <summary>
            /// Creates an upload destination for a resource that you specify and returns
            /// the information required to upload to that destination.
            ///
            /// **Usage Plan:**
            ///
            /// | Rate (requests per second) | Burst |
            /// | ---- | ---- |
            /// | .1 | 5 |
            ///
            /// For more information, see "Usage Plans and Rate Limits" in the Selling
            /// Partner API documentation.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='marketplaceIds'>
            /// A list of marketplace identifiers. This specifies the marketplaces where
            /// the upload will be available. Only one marketplace can be specified.
            /// </param>
            /// <param name='contentMD5'>
            /// An MD5 hash of the content to be submitted to the upload destination. This
            /// value is used to determine if the data has been corrupted or tampered with
            /// during transit.
            /// </param>
            /// <param name='resource'>
            /// The URL of the resource for the upload destination that you are creating.
            /// For example, to create an upload destination for a Buyer-Seller Messaging
            /// message, the {resource} would be /messaging and the path would be
            /// /uploads/v1/uploadDestinations/messaging
            /// </param>
            /// <param name='contentType'>
            /// The content type of the file to be uploaded.
            /// </param>
            public static CreateUploadDestinationResponse CreateUploadDestinationForResource(this IUploadsClient operations, IList<string> marketplaceIds, string contentMD5, string resource, string contentType = default(string))
            {
                return operations.CreateUploadDestinationForResourceAsync(marketplaceIds, contentMD5, resource, contentType).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates an upload destination for a resource that you specify and returns
            /// the information required to upload to that destination.
            ///
            /// **Usage Plan:**
            ///
            /// | Rate (requests per second) | Burst |
            /// | ---- | ---- |
            /// | .1 | 5 |
            ///
            /// For more information, see "Usage Plans and Rate Limits" in the Selling
            /// Partner API documentation.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='marketplaceIds'>
            /// A list of marketplace identifiers. This specifies the marketplaces where
            /// the upload will be available. Only one marketplace can be specified.
            /// </param>
            /// <param name='contentMD5'>
            /// An MD5 hash of the content to be submitted to the upload destination. This
            /// value is used to determine if the data has been corrupted or tampered with
            /// during transit.
            /// </param>
            /// <param name='resource'>
            /// The URL of the resource for the upload destination that you are creating.
            /// For example, to create an upload destination for a Buyer-Seller Messaging
            /// message, the {resource} would be /messaging and the path would be
            /// /uploads/v1/uploadDestinations/messaging
            /// </param>
            /// <param name='contentType'>
            /// The content type of the file to be uploaded.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CreateUploadDestinationResponse> CreateUploadDestinationForResourceAsync(this IUploadsClient operations, IList<string> marketplaceIds, string contentMD5, string resource, string contentType = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateUploadDestinationForResourceWithHttpMessagesAsync(marketplaceIds, contentMD5, resource, contentType, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
