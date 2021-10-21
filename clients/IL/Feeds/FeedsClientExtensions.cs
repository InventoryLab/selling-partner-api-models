// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace IL.Library.Amazon.SPAPI.Feeds
{
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for FeedsClient.
    /// </summary>
    public static partial class FeedsClientExtensions
    {
            /// <summary>
            /// Returns feed details for the feeds that match the filters that you specify.
            ///
            /// **Usage Plan:**
            ///
            /// | Rate (requests per second) | Burst |
            /// | ---- | ---- |
            /// | 0.0222 | 10 |
            ///
            /// For more information, see "Usage Plans and Rate Limits" in the Selling
            /// Partner API documentation.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='feedTypes'>
            /// A list of feed types used to filter feeds. When feedTypes is provided, the
            /// other filter parameters (processingStatuses, marketplaceIds, createdSince,
            /// createdUntil) and pageSize may also be provided. Either feedTypes or
            /// nextToken is required.
            /// </param>
            /// <param name='marketplaceIds'>
            /// A list of marketplace identifiers used to filter feeds. The feeds returned
            /// will match at least one of the marketplaces that you specify.
            /// </param>
            /// <param name='pageSize'>
            /// The maximum number of feeds to return in a single call.
            /// </param>
            /// <param name='processingStatuses'>
            /// A list of processing statuses used to filter feeds.
            /// </param>
            /// <param name='createdSince'>
            /// The earliest feed creation date and time for feeds included in the
            /// response, in ISO 8601 format. The default is 90 days ago. Feeds are
            /// retained for a maximum of 90 days.
            /// </param>
            /// <param name='createdUntil'>
            /// The latest feed creation date and time for feeds included in the response,
            /// in ISO 8601 format. The default is now.
            /// </param>
            /// <param name='nextToken'>
            /// A string token returned in the response to your previous request. nextToken
            /// is returned when the number of results exceeds the specified pageSize
            /// value. To get the next page of results, call the getFeeds operation and
            /// include this token as the only parameter. Specifying nextToken with any
            /// other parameters will cause the request to fail.
            /// </param>
            public static GetFeedsResponse GetFeeds(this IFeedsClient operations, IList<string> feedTypes = default(IList<string>), IList<string> marketplaceIds = default(IList<string>), int? pageSize = 10, IList<string> processingStatuses = default(IList<string>), System.DateTime? createdSince = default(System.DateTime?), System.DateTime? createdUntil = default(System.DateTime?), string nextToken = default(string))
            {
                return operations.GetFeedsAsync(feedTypes, marketplaceIds, pageSize, processingStatuses, createdSince, createdUntil, nextToken).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns feed details for the feeds that match the filters that you specify.
            ///
            /// **Usage Plan:**
            ///
            /// | Rate (requests per second) | Burst |
            /// | ---- | ---- |
            /// | 0.0222 | 10 |
            ///
            /// For more information, see "Usage Plans and Rate Limits" in the Selling
            /// Partner API documentation.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='feedTypes'>
            /// A list of feed types used to filter feeds. When feedTypes is provided, the
            /// other filter parameters (processingStatuses, marketplaceIds, createdSince,
            /// createdUntil) and pageSize may also be provided. Either feedTypes or
            /// nextToken is required.
            /// </param>
            /// <param name='marketplaceIds'>
            /// A list of marketplace identifiers used to filter feeds. The feeds returned
            /// will match at least one of the marketplaces that you specify.
            /// </param>
            /// <param name='pageSize'>
            /// The maximum number of feeds to return in a single call.
            /// </param>
            /// <param name='processingStatuses'>
            /// A list of processing statuses used to filter feeds.
            /// </param>
            /// <param name='createdSince'>
            /// The earliest feed creation date and time for feeds included in the
            /// response, in ISO 8601 format. The default is 90 days ago. Feeds are
            /// retained for a maximum of 90 days.
            /// </param>
            /// <param name='createdUntil'>
            /// The latest feed creation date and time for feeds included in the response,
            /// in ISO 8601 format. The default is now.
            /// </param>
            /// <param name='nextToken'>
            /// A string token returned in the response to your previous request. nextToken
            /// is returned when the number of results exceeds the specified pageSize
            /// value. To get the next page of results, call the getFeeds operation and
            /// include this token as the only parameter. Specifying nextToken with any
            /// other parameters will cause the request to fail.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<GetFeedsResponse> GetFeedsAsync(this IFeedsClient operations, IList<string> feedTypes = default(IList<string>), IList<string> marketplaceIds = default(IList<string>), int? pageSize = 10, IList<string> processingStatuses = default(IList<string>), System.DateTime? createdSince = default(System.DateTime?), System.DateTime? createdUntil = default(System.DateTime?), string nextToken = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetFeedsWithHttpMessagesAsync(feedTypes, marketplaceIds, pageSize, processingStatuses, createdSince, createdUntil, nextToken, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a feed. Encrypt and upload the contents of the feed document before
            /// calling this operation.
            ///
            /// **Usage Plan:**
            ///
            /// | Rate (requests per second) | Burst |
            /// | ---- | ---- |
            /// | 0.0083 | 15 |
            ///
            /// For more information, see "Usage Plans and Rate Limits" in the Selling
            /// Partner API documentation.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// </param>
            public static CreateFeedResponse CreateFeed(this IFeedsClient operations, CreateFeedSpecification body)
            {
                return operations.CreateFeedAsync(body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a feed. Encrypt and upload the contents of the feed document before
            /// calling this operation.
            ///
            /// **Usage Plan:**
            ///
            /// | Rate (requests per second) | Burst |
            /// | ---- | ---- |
            /// | 0.0083 | 15 |
            ///
            /// For more information, see "Usage Plans and Rate Limits" in the Selling
            /// Partner API documentation.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CreateFeedResponse> CreateFeedAsync(this IFeedsClient operations, CreateFeedSpecification body, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateFeedWithHttpMessagesAsync(body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Cancels the feed that you specify. Only feeds with
            /// processingStatus=IN_QUEUE can be cancelled. Cancelled feeds are returned in
            /// subsequent calls to the getFeed and getFeeds operations.
            ///
            /// **Usage Plan:**
            ///
            /// | Rate (requests per second) | Burst |
            /// | ---- | ---- |
            /// | 0.0222 | 10 |
            ///
            /// For more information, see "Usage Plans and Rate Limits" in the Selling
            /// Partner API documentation.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='feedId'>
            /// The identifier for the feed. This identifier is unique only in combination
            /// with a seller ID.
            /// </param>
            public static CancelFeedResponse CancelFeed(this IFeedsClient operations, string feedId)
            {
                return operations.CancelFeedAsync(feedId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Cancels the feed that you specify. Only feeds with
            /// processingStatus=IN_QUEUE can be cancelled. Cancelled feeds are returned in
            /// subsequent calls to the getFeed and getFeeds operations.
            ///
            /// **Usage Plan:**
            ///
            /// | Rate (requests per second) | Burst |
            /// | ---- | ---- |
            /// | 0.0222 | 10 |
            ///
            /// For more information, see "Usage Plans and Rate Limits" in the Selling
            /// Partner API documentation.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='feedId'>
            /// The identifier for the feed. This identifier is unique only in combination
            /// with a seller ID.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CancelFeedResponse> CancelFeedAsync(this IFeedsClient operations, string feedId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CancelFeedWithHttpMessagesAsync(feedId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns feed details (including the resultDocumentId, if available) for the
            /// feed that you specify.
            ///
            /// **Usage Plan:**
            ///
            /// | Rate (requests per second) | Burst |
            /// | ---- | ---- |
            /// | 2.0 | 15 |
            ///
            /// For more information, see "Usage Plans and Rate Limits" in the Selling
            /// Partner API documentation.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='feedId'>
            /// The identifier for the feed. This identifier is unique only in combination
            /// with a seller ID.
            /// </param>
            public static GetFeedResponse GetFeed(this IFeedsClient operations, string feedId)
            {
                return operations.GetFeedAsync(feedId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns feed details (including the resultDocumentId, if available) for the
            /// feed that you specify.
            ///
            /// **Usage Plan:**
            ///
            /// | Rate (requests per second) | Burst |
            /// | ---- | ---- |
            /// | 2.0 | 15 |
            ///
            /// For more information, see "Usage Plans and Rate Limits" in the Selling
            /// Partner API documentation.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='feedId'>
            /// The identifier for the feed. This identifier is unique only in combination
            /// with a seller ID.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<GetFeedResponse> GetFeedAsync(this IFeedsClient operations, string feedId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetFeedWithHttpMessagesAsync(feedId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a feed document for the feed type that you specify. This operation
            /// returns encryption details for encrypting the contents of the document, as
            /// well as a presigned URL for uploading the encrypted feed document contents.
            /// It also returns a feedDocumentId value that you can pass in with a
            /// subsequent call to the createFeed operation.
            ///
            /// **Usage Plan:**
            ///
            /// | Rate (requests per second) | Burst |
            /// | ---- | ---- |
            /// | 0.0083 | 15 |
            ///
            /// For more information, see "Usage Plans and Rate Limits" in the Selling
            /// Partner API documentation.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// </param>
            public static CreateFeedDocumentResponse CreateFeedDocument(this IFeedsClient operations, CreateFeedDocumentSpecification body)
            {
                return operations.CreateFeedDocumentAsync(body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a feed document for the feed type that you specify. This operation
            /// returns encryption details for encrypting the contents of the document, as
            /// well as a presigned URL for uploading the encrypted feed document contents.
            /// It also returns a feedDocumentId value that you can pass in with a
            /// subsequent call to the createFeed operation.
            ///
            /// **Usage Plan:**
            ///
            /// | Rate (requests per second) | Burst |
            /// | ---- | ---- |
            /// | 0.0083 | 15 |
            ///
            /// For more information, see "Usage Plans and Rate Limits" in the Selling
            /// Partner API documentation.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CreateFeedDocumentResponse> CreateFeedDocumentAsync(this IFeedsClient operations, CreateFeedDocumentSpecification body, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateFeedDocumentWithHttpMessagesAsync(body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns the information required for retrieving a feed document's contents.
            /// This includes a presigned URL for the feed document as well as the
            /// information required to decrypt the document's contents.
            ///
            /// **Usage Plan:**
            ///
            /// | Rate (requests per second) | Burst |
            /// | ---- | ---- |
            /// | 0.0222 | 10 |
            ///
            /// For more information, see "Usage Plans and Rate Limits" in the Selling
            /// Partner API documentation.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='feedDocumentId'>
            /// The identifier of the feed document.
            /// </param>
            public static GetFeedDocumentResponse GetFeedDocument(this IFeedsClient operations, string feedDocumentId)
            {
                return operations.GetFeedDocumentAsync(feedDocumentId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns the information required for retrieving a feed document's contents.
            /// This includes a presigned URL for the feed document as well as the
            /// information required to decrypt the document's contents.
            ///
            /// **Usage Plan:**
            ///
            /// | Rate (requests per second) | Burst |
            /// | ---- | ---- |
            /// | 0.0222 | 10 |
            ///
            /// For more information, see "Usage Plans and Rate Limits" in the Selling
            /// Partner API documentation.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='feedDocumentId'>
            /// The identifier of the feed document.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<GetFeedDocumentResponse> GetFeedDocumentAsync(this IFeedsClient operations, string feedDocumentId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetFeedDocumentWithHttpMessagesAsync(feedDocumentId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
