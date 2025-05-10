using PureCloud.Client.Models.Channels;

namespace PureCloud.Client.Contracts;

public interface IChannelsApi
{

    Task<AvailableTopicEntityListing> AvailableTopicsAsync(IEnumerable<string> expands = null, bool? includePreview = null, CancellationToken cancellationToken = default);

    Task<Channel> CreateAsync(CancellationToken cancellationToken = default);

    Task<bool> DeleteAsync(string channelId, CancellationToken cancellationToken = default);

    Task<bool> ExistsAsync(string channelId, CancellationToken cancellationToken = default);

    Task<ChannelTopicEntityListing> AddSubscriptionTopicsAsync(string channelId, IEnumerable<ChannelTopic> topics, bool? ignoreErrors = null, CancellationToken cancellationToken = default);

    Task<ChannelTopicEntityListing> GetSubscriptionsAsync(string channelId, CancellationToken cancellationToken = default);

    Task<ChannelEntityListing> ListAsync(bool? includeChannels = null, CancellationToken cancellationToken = default);

    Task<ChannelTopicEntityListing> UpdateSubscriptionTopicsAsync(string channelId, IEnumerable<ChannelTopic> topics, bool? ignoreErrors = null, CancellationToken cancellationToken = default);
}
