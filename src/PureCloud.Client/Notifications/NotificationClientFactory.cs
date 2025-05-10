using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using PureCloud.Client.Contracts;
using PureCloud.Client.Json;

namespace PureCloud.Client.Notifications;

public sealed class NotificationClientFactory : INotificationClientFactory
{
    private readonly IChannelsApi _channelRepository;
    private readonly NotificationClientResilienceOptions _resilienceOptions;
    private readonly PureCloudJsonSerializerOptions _options;
    private readonly ILogger _logger;

    public NotificationClientFactory(
        IChannelsApi channelRepository,
        IOptions<PureCloudJsonSerializerOptions> options,
        IOptions<NotificationClientResilienceOptions> resilienceOptions,
        ILogger<NotificationClientFactory> logger)
    {
        _channelRepository = channelRepository;
        _resilienceOptions = resilienceOptions.Value;
        _options = options.Value;
        _logger = logger;
    }

    public NotificationClient Create()
    {
        return new NotificationClient(_channelRepository, _options, _resilienceOptions, _logger);
    }
}
