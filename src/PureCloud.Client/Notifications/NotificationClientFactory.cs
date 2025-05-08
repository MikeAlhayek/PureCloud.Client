using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using PureCloud.Client.Json;
using PureCloud.Client.Repositories;

namespace PureCloud.Client.Notifications;

public class NotificationClientFactory : INotificationClientFactory
{
    private readonly IChannelRepository _channelRepository;
    private readonly PureCloudJsonSerializerOptions _options;
    private readonly ILogger _logger;

    public NotificationClientFactory(
        IChannelRepository channelRepository,
        IOptions<PureCloudJsonSerializerOptions> options,
        ILogger<NotificationClientFactory> logger)
    {
        _channelRepository = channelRepository;
        _options = options.Value;
        _logger = logger;
    }

    public NotificationClient Create()
    {
        return new NotificationClient(_channelRepository, _options, _logger);
    }
}
