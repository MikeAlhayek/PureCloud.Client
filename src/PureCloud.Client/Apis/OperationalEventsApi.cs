using System.Collections.Specialized;
using System.Net.Http.Json;
using Microsoft.Extensions.Options;
using PureCloud.Client.Contracts;
using PureCloud.Client.Http;
using PureCloud.Client.Json;
using PureCloud.Client.Models;

namespace PureCloud.Client.Apis;

/// <inheritdoc />
public sealed class OperationalEventsApi : IOperationalEventsApi
{
    private readonly HttpClient _httpClient;
    private readonly PureCloudJsonSerializerOptions _options;

    public OperationalEventsApi(IHttpClientFactory httpClientFactory, IOptions<PureCloudJsonSerializerOptions> options)
    {
        _httpClient = httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        _options = options.Value;
    }

    /// <inheritdoc />
    public async Task<EventDefinition> GetUsageEventsDefinitionAsync(string eventDefinitionId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(eventDefinitionId, nameof(eventDefinitionId));

        var uri = UriHelper.GetUri($"api/v2/usage/events/definitions/{eventDefinitionId}", null);

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<EventDefinition>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<EventDefinitionListing> GetUsageEventsDefinitionsAsync(CancellationToken cancellationToken = default)
    {
        var uri = UriHelper.GetUri("api/v2/usage/events/definitions", null);

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<EventDefinitionListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<EventAggregatesResponse> CreateUsageEventsAggregatesQueryAsync(EventAggregatesQueryRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body, nameof(body));

        var uri = UriHelper.GetUri("api/v2/usage/events/aggregates/query", null);

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<EventAggregatesResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<EventQueryResponse> CreateUsageEventsQueryAsync(EventQueryRequest body, string before = null, string after = null, string pageSize = null, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body, nameof(body));

        var parameters = new NameValueCollection();

        if (!string.IsNullOrEmpty(before))
        {
            parameters.Add("before", UriHelper.ParameterToString(before));
        }

        if (!string.IsNullOrEmpty(after))
        {
            parameters.Add("after", UriHelper.ParameterToString(after));
        }

        if (!string.IsNullOrEmpty(pageSize))
        {
            parameters.Add("pageSize", UriHelper.ParameterToString(pageSize));
        }

        var uri = UriHelper.GetUri("api/v2/usage/events/query", parameters);

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<EventQueryResponse>(_options.JsonSerializerOptions, cancellationToken);
    }
}