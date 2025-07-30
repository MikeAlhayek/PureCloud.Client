using System.Collections.Specialized;
using System.Net.Http.Json;
using Microsoft.Extensions.Options;
using PureCloud.Client.Contracts;
using PureCloud.Client.Http;
using PureCloud.Client.Json;
using PureCloud.Client.Models.Channels;

namespace PureCloud.Client.Apis;

/// <inheritdoc />
public sealed class NotificationsApi : INotificationsApi
{
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly PureCloudJsonSerializerOptions _options;

    public NotificationsApi(IHttpClientFactory httpClientFactory, IOptions<PureCloudJsonSerializerOptions> options)
    {
        _httpClientFactory = httpClientFactory;
        _options = options.Value;
    }

    /// <inheritdoc />
    public async Task<AvailableTopicEntityListing> GetNotificationsAvailableTopicsAsync(IEnumerable<string> expand = null, bool? includePreview = null, CancellationToken cancellationToken = default)
    {
        var parameters = new NameValueCollection();

        if (expand?.Any() == true)
        {
            foreach (var item in expand)
            {
                parameters.Add("expand", UriHelper.ParameterToString(item));
            }
        }

        if (includePreview.HasValue)
        {
            parameters.Add("includePreview", UriHelper.ParameterToString(includePreview.Value));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/notifications/availabletopics", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AvailableTopicEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<ChannelEntityListing> GetNotificationsChannelsAsync(string includeChannels = null, CancellationToken cancellationToken = default)
    {
        var parameters = new NameValueCollection();

        if (!string.IsNullOrEmpty(includeChannels))
        {
            parameters.Add("includechannels", UriHelper.ParameterToString(includeChannels));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/notifications/channels", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ChannelEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<Channel> CreateNotificationsChannelAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsync("api/v2/notifications/channels", null, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Channel>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<ChannelTopicEntityListing> GetNotificationsChannelSubscriptionsAsync(string channelId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(channelId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/notifications/channels/{Uri.EscapeDataString(channelId)}/subscriptions", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ChannelTopicEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<ChannelTopicEntityListing> CreateNotificationsChannelSubscriptionsAsync(string channelId, IEnumerable<ChannelTopic> body, bool? ignoreErrors = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(channelId);
        ArgumentNullException.ThrowIfNull(body);

        var parameters = new NameValueCollection();

        if (ignoreErrors.HasValue)
        {
            parameters.Add("ignoreErrors", UriHelper.ParameterToString(ignoreErrors.Value));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/notifications/channels/{Uri.EscapeDataString(channelId)}/subscriptions", parameters);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ChannelTopicEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<ChannelTopicEntityListing> UpdateNotificationsChannelSubscriptionsAsync(string channelId, IEnumerable<ChannelTopic> body, bool? ignoreErrors = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(channelId);
        ArgumentNullException.ThrowIfNull(body);

        var parameters = new NameValueCollection();

        if (ignoreErrors.HasValue)
        {
            parameters.Add("ignoreErrors", UriHelper.ParameterToString(ignoreErrors.Value));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/notifications/channels/{Uri.EscapeDataString(channelId)}/subscriptions", parameters);

        var response = await client.PutAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ChannelTopicEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task DeleteNotificationsChannelSubscriptionsAsync(string channelId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(channelId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/notifications/channels/{Uri.EscapeDataString(channelId)}/subscriptions", cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task<bool> VerifyNotificationsChannelAsync(string channelId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(channelId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var request = new HttpRequestMessage(HttpMethod.Head, $"api/v2/notifications/channels/{Uri.EscapeDataString(channelId)}");

        var response = await client.SendAsync(request, cancellationToken);

        return response.IsSuccessStatusCode;
    }
}
