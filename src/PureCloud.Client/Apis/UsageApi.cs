using System.Collections.Specialized;
using System.Net.Http.Json;
using Microsoft.Extensions.Options;
using PureCloud.Client.Contracts;
using PureCloud.Client.Http;
using PureCloud.Client.Json;
using PureCloud.Client.Models;

namespace PureCloud.Client.Apis;

/// <inheritdoc />

public sealed class UsageApi : IUsageApi
{
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly PureCloudJsonSerializerOptions _options;

    public UsageApi(IHttpClientFactory httpClientFactory, IOptions<PureCloudJsonSerializerOptions> options)
    {
        _httpClientFactory = httpClientFactory;
        _options = options.Value;
    }

    /// <inheritdoc />

    public async Task<ApiUsageQueryResult> GetOauthClientUsageQueryResultAsync(string executionId, string clientId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(executionId, nameof(executionId));
        ArgumentException.ThrowIfNullOrEmpty(clientId, nameof(clientId));

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/oauth/clients/{Uri.EscapeDataString(clientId)}/usage/query/results/{Uri.EscapeDataString(executionId)}", cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ApiUsageQueryResult>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<UsageExecutionResult> GetOauthClientUsageSummaryAsync(string clientId, string days = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(clientId, nameof(clientId));

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        if (!string.IsNullOrEmpty(days))
        {
            var parameters = new NameValueCollection();
            parameters.Add("days", UriHelper.ParameterToString(days));

            var uri = UriHelper.GetUri($"api/v2/oauth/clients/{Uri.EscapeDataString(clientId)}/usage/summary", parameters);
            var response = await client.GetAsync(uri, cancellationToken);
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadFromJsonAsync<UsageExecutionResult>(_options.JsonSerializerOptions, cancellationToken);
        }

        var directResponse = await client.GetAsync($"api/v2/oauth/clients/{Uri.EscapeDataString(clientId)}/usage/summary", cancellationToken);
        directResponse.EnsureSuccessStatusCode();

        return await directResponse.Content.ReadFromJsonAsync<UsageExecutionResult>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<ApiUsageQueryResult> GetUsageQueryResultsAsync(string executionId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(executionId, nameof(executionId));

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/usage/query/{Uri.EscapeDataString(executionId)}/results", cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ApiUsageQueryResult>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<ApiUsageQueryResult> GetUsageSimpleSearchResultsAsync(string executionId, string after = null, int? pageSize = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(executionId, nameof(executionId));

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        if (!string.IsNullOrEmpty(after) || pageSize.HasValue)
        {
            var parameters = new NameValueCollection();
            if (!string.IsNullOrEmpty(after))
            {
                parameters.Add("after", UriHelper.ParameterToString(after));
            }
            if (pageSize.HasValue)
            {
                parameters.Add("pageSize", UriHelper.ParameterToString(pageSize.Value));
            }

            var uri = UriHelper.GetUri($"api/v2/usage/simplesearch/{Uri.EscapeDataString(executionId)}/results", parameters);
            var response = await client.GetAsync(uri, cancellationToken);
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadFromJsonAsync<ApiUsageQueryResult>(_options.JsonSerializerOptions, cancellationToken);
        }

        var directResponse = await client.GetAsync($"api/v2/usage/simplesearch/{Uri.EscapeDataString(executionId)}/results", cancellationToken);
        directResponse.EnsureSuccessStatusCode();

        return await directResponse.Content.ReadFromJsonAsync<ApiUsageQueryResult>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<UsageExecutionResult> CreateOauthClientUsageQueryAsync(string clientId, ApiUsageClientQuery body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(clientId, nameof(clientId));
        ArgumentNullException.ThrowIfNull(body, nameof(body));

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync($"api/v2/oauth/clients/{Uri.EscapeDataString(clientId)}/usage/query", body, _options.JsonSerializerOptions, cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<UsageExecutionResult>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<UsageExecutionResult> CreateUsageQueryAsync(ApiUsageOrganizationQuery body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body, nameof(body));

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/usage/query", body, _options.JsonSerializerOptions, cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<UsageExecutionResult>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<UsageExecutionResult> CreateUsageSimpleSearchAsync(ApiUsageSimpleSearch body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body, nameof(body));

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/usage/simplesearch", body, _options.JsonSerializerOptions, cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<UsageExecutionResult>(_options.JsonSerializerOptions, cancellationToken);
    }
}