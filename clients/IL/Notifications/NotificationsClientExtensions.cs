// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace IL.Library.Amazon.SPAPI.Notifications
{
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for NotificationsClient.
    /// </summary>
    public static partial class NotificationsClientExtensions
    {
            /// <summary>
            /// Returns information about subscriptions of the specified notification type.
            /// You can use this API to get subscription information when you do not have a
            /// subscription identifier.
            ///
            /// **Usage Plan:**
            ///
            /// | Rate (requests per second) | Burst |
            /// | ---- | ---- |
            /// | 1 | 5 |
            ///
            /// For more information, see "Usage Plans and Rate Limits" in the Selling
            /// Partner API documentation.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static GetSubscriptionResponse GetSubscription(this INotificationsClient operations)
            {
                return operations.GetSubscriptionAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns information about subscriptions of the specified notification type.
            /// You can use this API to get subscription information when you do not have a
            /// subscription identifier.
            ///
            /// **Usage Plan:**
            ///
            /// | Rate (requests per second) | Burst |
            /// | ---- | ---- |
            /// | 1 | 5 |
            ///
            /// For more information, see "Usage Plans and Rate Limits" in the Selling
            /// Partner API documentation.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<GetSubscriptionResponse> GetSubscriptionAsync(this INotificationsClient operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetSubscriptionWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a subscription for the specified notification type to be delivered
            /// to the specified destination. Before you can subscribe, you must first
            /// create the destination by calling the createDestination operation.
            ///
            /// **Usage Plan:**
            ///
            /// | Rate (requests per second) | Burst |
            /// | ---- | ---- |
            /// | 1 | 5 |
            ///
            /// For more information, see "Usage Plans and Rate Limits" in the Selling
            /// Partner API documentation.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// </param>
            public static CreateSubscriptionResponse CreateSubscription(this INotificationsClient operations, CreateSubscriptionRequest body)
            {
                return operations.CreateSubscriptionAsync(body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a subscription for the specified notification type to be delivered
            /// to the specified destination. Before you can subscribe, you must first
            /// create the destination by calling the createDestination operation.
            ///
            /// **Usage Plan:**
            ///
            /// | Rate (requests per second) | Burst |
            /// | ---- | ---- |
            /// | 1 | 5 |
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
            public static async Task<CreateSubscriptionResponse> CreateSubscriptionAsync(this INotificationsClient operations, CreateSubscriptionRequest body, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateSubscriptionWithHttpMessagesAsync(body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns information about a subscription for the specified notification
            /// type. The getSubscriptionById API is grantless. For more information, see
            /// "Grantless operations" in the Selling Partner API Developer Guide.
            ///
            /// **Usage Plan:**
            ///
            /// | Rate (requests per second) | Burst |
            /// | ---- | ---- |
            /// | 1 | 5 |
            ///
            /// For more information, see "Usage Plans and Rate Limits" in the Selling
            /// Partner API documentation.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// The identifier for the subscription that you want to get.
            /// </param>
            public static object GetSubscriptionById(this INotificationsClient operations, string subscriptionId)
            {
                return operations.GetSubscriptionByIdAsync(subscriptionId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns information about a subscription for the specified notification
            /// type. The getSubscriptionById API is grantless. For more information, see
            /// "Grantless operations" in the Selling Partner API Developer Guide.
            ///
            /// **Usage Plan:**
            ///
            /// | Rate (requests per second) | Burst |
            /// | ---- | ---- |
            /// | 1 | 5 |
            ///
            /// For more information, see "Usage Plans and Rate Limits" in the Selling
            /// Partner API documentation.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// The identifier for the subscription that you want to get.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> GetSubscriptionByIdAsync(this INotificationsClient operations, string subscriptionId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetSubscriptionByIdWithHttpMessagesAsync(subscriptionId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the subscription indicated by the subscription identifier and
            /// notification type that you specify. The subscription identifier can be for
            /// any subscription associated with your application. After you successfully
            /// call this operation, notifications will stop being sent for the associated
            /// subscription. The deleteSubscriptionById API is grantless. For more
            /// information, see "Grantless operations" in the Selling Partner API
            /// Developer Guide.
            ///
            /// **Usage Plan:**
            ///
            /// | Rate (requests per second) | Burst |
            /// | ---- | ---- |
            /// | 1 | 5 |
            ///
            /// For more information, see "Usage Plans and Rate Limits" in the Selling
            /// Partner API documentation.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// The identifier for the subscription that you want to delete.
            /// </param>
            public static DeleteSubscriptionByIdResponse DeleteSubscriptionById(this INotificationsClient operations, string subscriptionId)
            {
                return operations.DeleteSubscriptionByIdAsync(subscriptionId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the subscription indicated by the subscription identifier and
            /// notification type that you specify. The subscription identifier can be for
            /// any subscription associated with your application. After you successfully
            /// call this operation, notifications will stop being sent for the associated
            /// subscription. The deleteSubscriptionById API is grantless. For more
            /// information, see "Grantless operations" in the Selling Partner API
            /// Developer Guide.
            ///
            /// **Usage Plan:**
            ///
            /// | Rate (requests per second) | Burst |
            /// | ---- | ---- |
            /// | 1 | 5 |
            ///
            /// For more information, see "Usage Plans and Rate Limits" in the Selling
            /// Partner API documentation.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// The identifier for the subscription that you want to delete.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DeleteSubscriptionByIdResponse> DeleteSubscriptionByIdAsync(this INotificationsClient operations, string subscriptionId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeleteSubscriptionByIdWithHttpMessagesAsync(subscriptionId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns information about all destinations. The getDestinations API is
            /// grantless. For more information, see "Grantless operations" in the Selling
            /// Partner API Developer Guide.
            ///
            /// **Usage Plan:**
            ///
            /// | Rate (requests per second) | Burst |
            /// | ---- | ---- |
            /// | 1 | 5 |
            ///
            /// For more information, see "Usage Plans and Rate Limits" in the Selling
            /// Partner API documentation.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static GetDestinationsResponse GetDestinations(this INotificationsClient operations)
            {
                return operations.GetDestinationsAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns information about all destinations. The getDestinations API is
            /// grantless. For more information, see "Grantless operations" in the Selling
            /// Partner API Developer Guide.
            ///
            /// **Usage Plan:**
            ///
            /// | Rate (requests per second) | Burst |
            /// | ---- | ---- |
            /// | 1 | 5 |
            ///
            /// For more information, see "Usage Plans and Rate Limits" in the Selling
            /// Partner API documentation.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<GetDestinationsResponse> GetDestinationsAsync(this INotificationsClient operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetDestinationsWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a destination resource to receive notifications. The
            /// createDestination API is grantless. For more information, see "Grantless
            /// operations" in the Selling Partner API Developer Guide.
            ///
            /// **Usage Plan:**
            ///
            /// | Rate (requests per second) | Burst |
            /// | ---- | ---- |
            /// | 1 | 5 |
            ///
            /// For more information, see "Usage Plans and Rate Limits" in the Selling
            /// Partner API documentation.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// </param>
            public static CreateDestinationResponse CreateDestination(this INotificationsClient operations, CreateDestinationRequest body)
            {
                return operations.CreateDestinationAsync(body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a destination resource to receive notifications. The
            /// createDestination API is grantless. For more information, see "Grantless
            /// operations" in the Selling Partner API Developer Guide.
            ///
            /// **Usage Plan:**
            ///
            /// | Rate (requests per second) | Burst |
            /// | ---- | ---- |
            /// | 1 | 5 |
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
            public static async Task<CreateDestinationResponse> CreateDestinationAsync(this INotificationsClient operations, CreateDestinationRequest body, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateDestinationWithHttpMessagesAsync(body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns information about the destination that you specify. The
            /// getDestination API is grantless. For more information, see "Grantless
            /// operations" in the Selling Partner API Developer Guide.
            ///
            /// **Usage Plan:**
            ///
            /// | Rate (requests per second) | Burst |
            /// | ---- | ---- |
            /// | 1 | 5 |
            ///
            /// For more information, see "Usage Plans and Rate Limits" in the Selling
            /// Partner API documentation.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='destinationId'>
            /// The identifier generated when you created the destination.
            /// </param>
            public static GetDestinationResponse GetDestination(this INotificationsClient operations, string destinationId)
            {
                return operations.GetDestinationAsync(destinationId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns information about the destination that you specify. The
            /// getDestination API is grantless. For more information, see "Grantless
            /// operations" in the Selling Partner API Developer Guide.
            ///
            /// **Usage Plan:**
            ///
            /// | Rate (requests per second) | Burst |
            /// | ---- | ---- |
            /// | 1 | 5 |
            ///
            /// For more information, see "Usage Plans and Rate Limits" in the Selling
            /// Partner API documentation.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='destinationId'>
            /// The identifier generated when you created the destination.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<GetDestinationResponse> GetDestinationAsync(this INotificationsClient operations, string destinationId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetDestinationWithHttpMessagesAsync(destinationId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the destination that you specify. The deleteDestination API is
            /// grantless. For more information, see "Grantless operations" in the Selling
            /// Partner API Developer Guide.
            ///
            /// **Usage Plan:**
            ///
            /// | Rate (requests per second) | Burst |
            /// | ---- | ---- |
            /// | 1 | 5 |
            ///
            /// For more information, see "Usage Plans and Rate Limits" in the Selling
            /// Partner API documentation.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='destinationId'>
            /// The identifier for the destination that you want to delete.
            /// </param>
            public static DeleteDestinationResponse DeleteDestination(this INotificationsClient operations, string destinationId)
            {
                return operations.DeleteDestinationAsync(destinationId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the destination that you specify. The deleteDestination API is
            /// grantless. For more information, see "Grantless operations" in the Selling
            /// Partner API Developer Guide.
            ///
            /// **Usage Plan:**
            ///
            /// | Rate (requests per second) | Burst |
            /// | ---- | ---- |
            /// | 1 | 5 |
            ///
            /// For more information, see "Usage Plans and Rate Limits" in the Selling
            /// Partner API documentation.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='destinationId'>
            /// The identifier for the destination that you want to delete.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DeleteDestinationResponse> DeleteDestinationAsync(this INotificationsClient operations, string destinationId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeleteDestinationWithHttpMessagesAsync(destinationId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
