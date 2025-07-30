using PureCloud.Client.Models.Channels;

namespace PureCloud.Client.Contracts;

public interface INotificationsApi
{
    /// <summary>
    /// Get available notification topics.
    /// </summary>
    /// <param name="expands">Which fields, if any, to expand</param>
    /// <param name="includePreview">Whether or not to include Preview topics</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<AvailableTopicEntityListing> GetNotificationsAvailableTopicsAsync(IEnumerable<string> expands = null, bool? includePreview = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// The list of existing channels
    /// </summary>
    /// <param name="includeChannels">Include channels</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<ChannelEntityListing> GetNotificationsChannelsAsync(string includeChannels = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a new channel
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<Channel> CreateNotificationsChannelAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// The list of all subscriptions for this channel
    /// </summary>
    /// <param name="channelId">Channel ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<ChannelTopicEntityListing> GetNotificationsChannelSubscriptionsAsync(string channelId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Add a list of subscriptions to the existing list of subscriptions
    /// </summary>
    /// <param name="channelId">Channel ID</param>
    /// <param name="body">Body</param>
    /// <param name="ignoreErrors">Optionally prevent throwing of errors for failed permissions checks</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<ChannelTopicEntityListing> CreateNotificationsChannelSubscriptionsAsync(string channelId, IEnumerable<ChannelTopic> body, bool? ignoreErrors = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Replace the current list of subscriptions with a new list.
    /// </summary>
    /// <param name="channelId">Channel ID</param>
    /// <param name="body">Body</param>
    /// <param name="ignoreErrors">Optionally prevent throwing of errors for failed permissions checks</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<ChannelTopicEntityListing> UpdateNotificationsChannelSubscriptionsAsync(string channelId, IEnumerable<ChannelTopic> body, bool? ignoreErrors = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Remove all subscriptions
    /// </summary>
    /// <param name="channelId">Channel ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<bool> DeleteNotificationsChannelSubscriptionsAsync(string channelId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Verify a channel still exists and is valid
    /// </summary>
    /// <param name="channelId">Channel ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<ApiResponse<object>> VerifyNotificationsChannelAsync(string channelId, CancellationToken cancellationToken = default);
}
