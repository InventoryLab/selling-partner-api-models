// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace IL.Library.Amazon.SPAPI.Feeds
{
    using Microsoft.Rest;
    using Models;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// The Selling Partner API for Feeds lets you upload data to Amazon on
    /// behalf of a selling partner.
    /// </summary>
    public partial interface IFeedsClient : System.IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        JsonSerializerSettings DeserializationSettings { get; }


        /// <summary>
        /// Returns feed details for the feeds that match the filters that you
        /// specify.
        ///
        /// **Usage Plan:**
        ///
        /// | Rate (requests per second) | Burst |
        /// | ---- | ---- |
        /// | 0.0222 | 10 |
        ///
        /// For more information, see "Usage Plans and Rate Limits" in the
        /// Selling Partner API documentation.
        /// </summary>
        /// <param name='feedTypes'>
        /// A list of feed types used to filter feeds. When feedTypes is
        /// provided, the other filter parameters (processingStatuses,
        /// marketplaceIds, createdSince, createdUntil) and pageSize may also
        /// be provided. Either feedTypes or nextToken is required.
        /// </param>
        /// <param name='marketplaceIds'>
        /// A list of marketplace identifiers used to filter feeds. The feeds
        /// returned will match at least one of the marketplaces that you
        /// specify.
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
        /// The latest feed creation date and time for feeds included in the
        /// response, in ISO 8601 format. The default is now.
        /// </param>
        /// <param name='nextToken'>
        /// A string token returned in the response to your previous request.
        /// nextToken is returned when the number of results exceeds the
        /// specified pageSize value. To get the next page of results, call the
        /// getFeeds operation and include this token as the only parameter.
        /// Specifying nextToken with any other parameters will cause the
        /// request to fail.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<object,GetFeedsHeaders>> GetFeedsWithHttpMessagesAsync(IList<string> feedTypes = default(IList<string>), IList<string> marketplaceIds = default(IList<string>), int? pageSize = 10, IList<string> processingStatuses = default(IList<string>), System.DateTime? createdSince = default(System.DateTime?), System.DateTime? createdUntil = default(System.DateTime?), string nextToken = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates a feed. Upload the contents of the feed document before
        /// calling this operation.
        ///
        /// **Usage Plan:**
        ///
        /// | Rate (requests per second) | Burst |
        /// | ---- | ---- |
        /// | 0.0083 | 15 |
        ///
        /// For more information, see "Usage Plans and Rate Limits" in the
        /// Selling Partner API documentation.
        /// </summary>
        /// <param name='body'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<object,CreateFeedHeaders>> CreateFeedWithHttpMessagesAsync(CreateFeedSpecification body, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Cancels the feed that you specify. Only feeds with
        /// processingStatus=IN_QUEUE can be cancelled. Cancelled feeds are
        /// returned in subsequent calls to the getFeed and getFeeds
        /// operations.
        ///
        /// **Usage Plan:**
        ///
        /// | Rate (requests per second) | Burst |
        /// | ---- | ---- |
        /// | 0.0222 | 10 |
        ///
        /// For more information, see "Usage Plans and Rate Limits" in the
        /// Selling Partner API documentation.
        /// </summary>
        /// <param name='feedId'>
        /// The identifier for the feed. This identifier is unique only in
        /// combination with a seller ID.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<ErrorList,CancelFeedHeaders>> CancelFeedWithHttpMessagesAsync(string feedId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Returns feed details (including the resultDocumentId, if available)
        /// for the feed that you specify.
        ///
        /// **Usage Plan:**
        ///
        /// | Rate (requests per second) | Burst |
        /// | ---- | ---- |
        /// | 2.0 | 15 |
        ///
        /// For more information, see "Usage Plans and Rate Limits" in the
        /// Selling Partner API documentation.
        /// </summary>
        /// <param name='feedId'>
        /// The identifier for the feed. This identifier is unique only in
        /// combination with a seller ID.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<object,GetFeedHeaders>> GetFeedWithHttpMessagesAsync(string feedId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates a feed document for the feed type that you specify. This
        /// operation returns a presigned URL for uploading the feed document
        /// contents. It also returns a feedDocumentId value that you can pass
        /// in with a subsequent call to the createFeed operation.
        ///
        /// **Usage Plan:**
        ///
        /// | Rate (requests per second) | Burst |
        /// | ---- | ---- |
        /// | 0.0083 | 15 |
        ///
        /// For more information, see "Usage Plans and Rate Limits" in the
        /// Selling Partner API documentation.
        /// </summary>
        /// <param name='body'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<object,CreateFeedDocumentHeaders>> CreateFeedDocumentWithHttpMessagesAsync(CreateFeedDocumentSpecification body, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Returns the information required for retrieving a feed document's
        /// contents.
        ///
        /// **Usage Plan:**
        ///
        /// | Rate (requests per second) | Burst |
        /// | ---- | ---- |
        /// | 0.0222 | 10 |
        ///
        /// For more information, see "Usage Plans and Rate Limits" in the
        /// Selling Partner API documentation.
        /// </summary>
        /// <param name='feedDocumentId'>
        /// The identifier of the feed document.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<object,GetFeedDocumentHeaders>> GetFeedDocumentWithHttpMessagesAsync(string feedDocumentId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

    }
}
