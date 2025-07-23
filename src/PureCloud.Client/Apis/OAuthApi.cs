using System.Collections.Specialized;
using System.Net.Http.Json;
using System.Text.Json;
using Microsoft.Extensions.Options;
using PureCloud.Client.Contracts;
using PureCloud.Client.Http;
using PureCloud.Client.Json;
using PureCloud.Client.Models;

namespace PureCloud.Client.Apis;

/// <inheritdoc />
public sealed class OAuthApi : IOAuthApi
{
    private readonly HttpClient _httpClient;
    private readonly JsonSerializerOptions _options;

    public OAuthApi(IHttpClientFactory httpClientFactory, IOptions<PureCloudJsonSerializerOptions> options)
    {
        _httpClient = httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        _options = options.Value.JsonSerializerOptions;
    }

    /// <inheritdoc />
    public async Task DeleteOauthClientAsync(string clientId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(clientId);

        var response = await _httpClient.DeleteAsync($"api/v2/oauth/clients/{clientId}", cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task<OAuthAuthorization> GetOauthAuthorizationAsync(string clientId, string acceptLanguage = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(clientId);

        var response = await _httpClient.GetAsync($"api/v2/oauth/authorizations/{clientId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<OAuthAuthorization>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<OAuthAuthorizationListing> GetOauthAuthorizationsAsync(string acceptLanguage = null, CancellationToken cancellationToken = default)
    {
        var response = await _httpClient.GetAsync("api/v2/oauth/authorizations", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<OAuthAuthorizationListing>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<OAuthClient> GetOauthClientAsync(string clientId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(clientId);

        var response = await _httpClient.GetAsync($"api/v2/oauth/clients/{clientId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<OAuthClient>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<ApiUsageQueryResult> GetOauthClientUsageQueryResultAsync(string executionId, string clientId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(executionId);
        ArgumentException.ThrowIfNullOrEmpty(clientId);

        var response = await _httpClient.GetAsync($"api/v2/oauth/clients/{clientId}/usage/query/{executionId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ApiUsageQueryResult>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<UsageExecutionResult> GetOauthClientUsageSummaryAsync(string clientId, string days = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(clientId);

        var parameters = new NameValueCollection();

        if (!string.IsNullOrEmpty(days))
        {
            parameters.Add("days", days);
        }

        var uri = UriHelper.GetUri($"api/v2/oauth/clients/{clientId}/usage/summary", parameters);

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<UsageExecutionResult>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<OAuthClientEntityListing> GetOauthClientsAsync(CancellationToken cancellationToken = default)
    {
        var response = await _httpClient.GetAsync("api/v2/oauth/clients", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<OAuthClientEntityListing>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<OAuthScope> GetOauthScopeAsync(string scopeId, string acceptLanguage = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(scopeId);

        var response = await _httpClient.GetAsync($"api/v2/oauth/scopes/{scopeId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<OAuthScope>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<OAuthScopeListing> GetOauthScopesAsync(string acceptLanguage = null, CancellationToken cancellationToken = default)
    {
        var response = await _httpClient.GetAsync("api/v2/oauth/scopes", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<OAuthScopeListing>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<OAuthClient> CreateOauthClientSecretAsync(string clientId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(clientId);

        var response = await _httpClient.PostAsync($"api/v2/oauth/clients/{clientId}/secret", null, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<OAuthClient>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<UsageExecutionResult> CreateOauthClientUsageQueryAsync(string clientId, ApiUsageClientQuery body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(clientId);
        ArgumentNullException.ThrowIfNull(body);

        var response = await _httpClient.PostAsJsonAsync($"api/v2/oauth/clients/{clientId}/usage/query", body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<UsageExecutionResult>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<OAuthClient> CreateOauthClientAsync(OAuthClientRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var response = await _httpClient.PostAsJsonAsync("api/v2/oauth/clients", body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<OAuthClient>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<OAuthClient> UpdateOauthClientAsync(string clientId, OAuthClientRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(clientId);
        ArgumentNullException.ThrowIfNull(body);

        var response = await _httpClient.PutAsJsonAsync($"api/v2/oauth/clients/{clientId}", body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<OAuthClient>(_options, cancellationToken);
    }
}