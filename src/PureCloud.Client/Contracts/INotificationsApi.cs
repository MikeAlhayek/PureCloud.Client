using PureCloud.Client.Models.Channels;

namespace PureCloud.Client.Contracts;

public interface INotificationsApi
{
    /// <summary>
    /// Get available notification topics.
    /// </summary>
    Task<AvailableTopicEntityListing> GetNotificationsAvailableTopicsAsync(IEnumerable<string> expand = null, bool? includePreview = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// The list of existing channels
    /// </summary>
    Task<ChannelEntityListing> GetNotificationsChannelsAsync(string includeChannels = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a new channel
    /// </summary>
    Task<Channel> CreateNotificationsChannelAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// The list of all subscriptions for this channel
    /// </summary>
    Task<ChannelTopicEntityListing> GetNotificationsChannelSubscriptionsAsync(string channelId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Add a list of subscriptions to the existing list of subscriptions
    /// </summary>
    Task<ChannelTopicEntityListing> CreateNotificationsChannelSubscriptionsAsync(string channelId, IEnumerable<ChannelTopic> body, bool? ignoreErrors = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Replace the current list of subscriptions with a new list.
    /// </summary>
    Task<ChannelTopicEntityListing> UpdateNotificationsChannelSubscriptionsAsync(string channelId, IEnumerable<ChannelTopic> body, bool? ignoreErrors = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Remove all subscriptions
    /// </summary>
    Task DeleteNotificationsChannelSubscriptionsAsync(string channelId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Verify a channel still exists and is valid
    /// </summary>
    Task<bool> VerifyNotificationsChannelAsync(string channelId, CancellationToken cancellationToken = default);
}