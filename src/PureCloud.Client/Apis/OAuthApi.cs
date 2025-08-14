using System.Collections.Specialized;
using System.Net.Http.Json;
using Microsoft.Extensions.Options;
using PureCloud.Client.Contracts;
using PureCloud.Client.Http;
using PureCloud.Client.Json;
using PureCloud.Client.Models;

namespace PureCloud.Client.Apis;

/// <summary>
/// OAuth API for managing OAuth clients, scopes, and authorizations
/// </summary>
public sealed class OAuthApi : IOAuthApi
{
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly PureCloudJsonSerializerOptions _options;

    public OAuthApi(IHttpClientFactory httpClientFactory, IOptions<PureCloudJsonSerializerOptions> options)
    {
        _httpClientFactory = httpClientFactory;
        _options = options.Value;
    }

    /// <summary>
    /// Delete OAuth Client
    /// </summary>
    public async Task<bool> DeleteOauthClientAsync(string clientId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(clientId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/oauth/clients/{Uri.EscapeDataString(clientId)}", cancellationToken);

        return response.IsSuccessfulStatusCode;
    }

    /// <summary>
    /// Get a client that is authorized by the resource owner
    /// </summary>
    public async Task<OAuthAuthorization> GetOauthAuthorizationAsync(string clientId, string acceptLanguage = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(clientId);

        var parameters = new NameValueCollection();

        if (!string.IsNullOrEmpty(acceptLanguage))
        {
            parameters.Add("acceptLanguage", UriHelper.ParameterToString(acceptLanguage));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/oauth/authorizations/{Uri.EscapeDataString(clientId)}", parameters);
        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<OAuthAuthorization>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <summary>
    /// List clients that have been authorized, requested, or revoked by the resource owner
    /// </summary>
    public async Task<OAuthAuthorizationListing> GetOauthAuthorizationsAsync(string acceptLanguage = null, CancellationToken cancellationToken = default)
    {
        var parameters = new NameValueCollection();

        if (!string.IsNullOrEmpty(acceptLanguage))
        {
            parameters.Add("acceptLanguage", UriHelper.ParameterToString(acceptLanguage));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/oauth/authorizations", parameters);
        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<OAuthAuthorizationListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <summary>
    /// Get OAuth Client
    /// </summary>
    public async Task<OAuthClient> GetOauthClientAsync(string clientId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(clientId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/oauth/clients/{Uri.EscapeDataString(clientId)}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<OAuthClient>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <summary>
    /// Get the results of a usage query
    /// </summary>
    public async Task<ApiUsageQueryResult> GetOauthClientUsageQueryResultAsync(string executionId, string clientId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(executionId);
        ArgumentException.ThrowIfNullOrEmpty(clientId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/oauth/clients/{Uri.EscapeDataString(clientId)}/usage/query/results/{Uri.EscapeDataString(executionId)}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ApiUsageQueryResult>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <summary>
    /// Get a summary of OAuth client API usage
    /// </summary>
    public async Task<UsageExecutionResult> GetOauthClientUsageSummaryAsync(string clientId, string days = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(clientId);

        var parameters = new NameValueCollection();

        if (!string.IsNullOrEmpty(days))
        {
            parameters.Add("days", UriHelper.ParameterToString(days));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/oauth/clients/{Uri.EscapeDataString(clientId)}/usage/summary", parameters);
        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<UsageExecutionResult>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <summary>
    /// The list of OAuth clients
    /// </summary>
    public async Task<OAuthClientEntityListing> GetOauthClientsAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync("api/v2/oauth/clients", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<OAuthClientEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <summary>
    /// An OAuth scope
    /// </summary>
    public async Task<OAuthScope> GetOauthScopeAsync(string scopeId, string acceptLanguage = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(scopeId);

        var parameters = new NameValueCollection();

        if (!string.IsNullOrEmpty(acceptLanguage))
        {
            parameters.Add("acceptLanguage", UriHelper.ParameterToString(acceptLanguage));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/oauth/scopes/{Uri.EscapeDataString(scopeId)}", parameters);
        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<OAuthScope>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <summary>
    /// The list of OAuth scopes
    /// </summary>
    public async Task<OAuthScopeListing> GetOauthScopesAsync(string acceptLanguage = null, CancellationToken cancellationToken = default)
    {
        var parameters = new NameValueCollection();

        if (!string.IsNullOrEmpty(acceptLanguage))
        {
            parameters.Add("acceptLanguage", UriHelper.ParameterToString(acceptLanguage));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/oauth/scopes", parameters);
        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<OAuthScopeListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <summary>
    /// Regenerate Client Secret
    /// </summary>
    public async Task<OAuthClient> CreateOauthClientSecretAsync(string clientId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(clientId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsync($"api/v2/oauth/clients/{Uri.EscapeDataString(clientId)}/secret", null, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<OAuthClient>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <summary>
    /// Query for OAuth client API usage
    /// </summary>
    public async Task<UsageExecutionResult> CreateOauthClientUsageQueryAsync(string clientId, ApiUsageClientQuery body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(clientId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync($"api/v2/oauth/clients/{Uri.EscapeDataString(clientId)}/usage/query", body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<UsageExecutionResult>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <summary>
    /// Create OAuth client
    /// </summary>
    public async Task<OAuthClient> CreateOauthClientAsync(OAuthClientRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/oauth/clients", body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<OAuthClient>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <summary>
    /// Update OAuth Client
    /// </summary>
    public async Task<OAuthClient> UpdateOauthClientAsync(string clientId, OAuthClientRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(clientId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync($"api/v2/oauth/clients/{Uri.EscapeDataString(clientId)}", body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<OAuthClient>(_options.JsonSerializerOptions, cancellationToken);
    }
}