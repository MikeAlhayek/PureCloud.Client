using System.Net.Http.Json;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Options;
using PureCloud.Client.Contracts;
using PureCloud.Client.Http;
using PureCloud.Client.Json;
using PureCloud.Client.Models.Channels;

namespace PureCloud.Client.Apis;

public class ChannelsApi : IChannelsApi
{
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly PureCloudJsonSerializerOptions _options;

    public ChannelsApi(
        IHttpClientFactory httpClientFactory,
        IOptions<PureCloudJsonSerializerOptions> options)
    {
        _httpClientFactory = httpClientFactory;
        _options = options.Value;
    }

    public async Task<Channel> CreateAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsync("api/v2/notifications/channels", content: null, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Channel>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ChannelEntityListing> ListAsync(bool? includeChannels = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = GetNotificationChannelsUri(includeChannels);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ChannelEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<bool> ExistsAsync(string channelId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(channelId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.SendAsync(new HttpRequestMessage(HttpMethod.Head, $"api/v2/notifications/channels/{channelId}"), cancellationToken);

        if (response.IsSuccessStatusCode)
        {
            return true;
        }

        return false;
    }

    public async Task<AvailableTopicEntityListing> AvailableTopicsAsync(IEnumerable<string> expands = null, bool? includePreview = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var queryParameters = new List<KeyValuePair<string, string>>();

        if (expands is not null)
        {
            foreach (var expand in expands)
            {
                queryParameters.Add(new KeyValuePair<string, string>("expand", UriHelper.ParameterToString(expand)));
            }
        }

        if (includePreview.HasValue)
        {
            queryParameters.Add(new KeyValuePair<string, string>("includePreview", UriHelper.ParameterToString(includePreview.Value)));
        }

        var uri = QueryHelpers.AddQueryString("api/v2/notifications/availabletopics", queryParameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AvailableTopicEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    private static string GetNotificationChannelsUri(bool? includeChannels)
    {
        if (includeChannels.HasValue)
        {
            return "api/v2/notifications/channels?includeChannels=" + UriHelper.ParameterToString(includeChannels.Value);
        }

        return "api/v2/notifications/channels";
    }

    #region Subscriptions

    public async Task<bool> DeleteAsync(string channelId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(channelId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/notifications/channels/{channelId}/subscriptions", cancellationToken);

        if (response.IsSuccessStatusCode)
        {
            return true;
        }

        return false;
    }

    public async Task<ChannelTopicEntityListing> GetSubscriptionsAsync(string channelId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(channelId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync("api/v2/notifications/channels/{channelId}/subscriptions", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ChannelTopicEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ChannelTopicEntityListing> AddSubscriptionTopicsAsync(string channelId, IEnumerable<ChannelTopic> topics, bool? ignoreErrors = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(channelId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync(GetSubscriptionTopicUri(channelId, ignoreErrors), topics, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ChannelTopicEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ChannelTopicEntityListing> UpdateSubscriptionTopicsAsync(string channelId, IEnumerable<ChannelTopic> topics, bool? ignoreErrors = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(channelId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync(GetSubscriptionTopicUri(channelId, ignoreErrors), topics, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ChannelTopicEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    private static string GetSubscriptionTopicUri(string channelId, bool? ignoreErrors)
    {
        if (ignoreErrors.HasValue)
        {
            return $"api/v2/notifications/channels/{channelId}/subscriptions?ignoreErrors={UriHelper.ParameterToString(ignoreErrors.Value)}";
        }

        return $"api/v2/notifications/channels/{channelId}/subscriptions";
    }

    #endregion
}
