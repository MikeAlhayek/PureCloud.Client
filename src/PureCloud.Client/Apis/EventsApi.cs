using System.Net.Http.Json;
using Microsoft.Extensions.Options;
using PureCloud.Client.Contracts;
using PureCloud.Client.Json;
using PureCloud.Client.Models;

namespace PureCloud.Client.Apis;

public class EventsApi : IEventsApi
{
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly PureCloudJsonSerializerOptions _options;

    public EventsApi(
        IHttpClientFactory httpClientFactory,
        IOptions<PureCloudJsonSerializerOptions> options)
    {
        _httpClientFactory = httpClientFactory;
        _options = options.Value;
    }

    public async Task<BatchEventResponse> CreateEventsConversationsAsync(BatchConversationEventRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/events/conversations", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<BatchEventResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<BatchEventResponse> CreateEventsUsersPresenceAsync(BatchUserPresenceEventRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/events/users/presence", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<BatchEventResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<BatchEventResponse> CreateEventsUsersRoutingstatusAsync(BatchUserRoutingStatusEventRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/events/users/routingstatus", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<BatchEventResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

}
