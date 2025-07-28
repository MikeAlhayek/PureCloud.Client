using System.Collections.Specialized;
using System.Net.Http.Json;
using Microsoft.Extensions.Options;
using PureCloud.Client.Contracts;
using PureCloud.Client.Http;
using PureCloud.Client.Json;
using PureCloud.Client.Models;

namespace PureCloud.Client.Apis;

/// <inheritdoc />
public sealed class WebDeploymentsApi : IWebDeploymentsApi
{
    private readonly HttpClient _httpClient;
    private readonly PureCloudJsonSerializerOptions _options;

    public WebDeploymentsApi(IHttpClientFactory httpClientFactory, IOptions<PureCloudJsonSerializerOptions> options)
    {
        _httpClient = httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        _options = options.Value;
    }

    /// <inheritdoc />
    public async Task<bool> DeleteWebdeploymentsConfigurationAsync(string configurationId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(configurationId);

        var uri = $"/api/v2/webdeployments/configurations/{Uri.EscapeDataString(configurationId)}";

        var response = await _httpClient.DeleteAsync(uri, cancellationToken);

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    public async Task<bool> DeleteWebdeploymentsDeploymentAsync(string deploymentId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(deploymentId);

        var uri = $"/api/v2/webdeployments/deployments/{Uri.EscapeDataString(deploymentId)}";

        var response = await _httpClient.DeleteAsync(uri, cancellationToken);

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    public async Task<bool> DeleteWebdeploymentsDeploymentCobrowseSessionIdAsync(string deploymentId, string sessionId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(deploymentId);
        ArgumentException.ThrowIfNullOrEmpty(sessionId);

        var uri = $"/api/v2/webdeployments/deployments/{Uri.EscapeDataString(deploymentId)}/cobrowse/{Uri.EscapeDataString(sessionId)}";

        var response = await _httpClient.DeleteAsync(uri, cancellationToken);

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    public async Task<bool> DeleteWebdeploymentsTokenRevokeAsync(string xJourneySessionId = null, string xJourneySessionType = null, CancellationToken cancellationToken = default)
    {
        var uri = "/api/v2/webdeployments/token/revoke";

        using var request = new HttpRequestMessage(HttpMethod.Delete, uri);

        if (!string.IsNullOrEmpty(xJourneySessionId))
        {
            request.Headers.Add("X-Journey-Session-Id", xJourneySessionId);
        }

        if (!string.IsNullOrEmpty(xJourneySessionType))
        {
            request.Headers.Add("X-Journey-Session-Type", xJourneySessionType);
        }

        var response = await _httpClient.SendAsync(request, cancellationToken);

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    public async Task<WebDeploymentConfigurationVersion> GetWebdeploymentsConfigurationVersionAsync(string configurationId, string versionId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(configurationId);
        ArgumentException.ThrowIfNullOrEmpty(versionId);

        var uri = $"/api/v2/webdeployments/configurations/{Uri.EscapeDataString(configurationId)}/versions/{Uri.EscapeDataString(versionId)}";

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<WebDeploymentConfigurationVersion>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<WebDeploymentConfigurationVersionEntityListing> GetWebdeploymentsConfigurationVersionsAsync(string configurationId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(configurationId);

        var uri = $"/api/v2/webdeployments/configurations/{Uri.EscapeDataString(configurationId)}/versions";

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<WebDeploymentConfigurationVersionEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<WebDeploymentConfigurationVersion> GetWebdeploymentsConfigurationVersionsDraftAsync(string configurationId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(configurationId);

        var uri = $"/api/v2/webdeployments/configurations/{Uri.EscapeDataString(configurationId)}/versions/draft";

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<WebDeploymentConfigurationVersion>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<WebDeploymentConfigurationVersionEntityListing> GetWebdeploymentsConfigurationsAsync(bool? showOnlyPublished = null, CancellationToken cancellationToken = default)
    {
        var parameters = new NameValueCollection();

        if (showOnlyPublished.HasValue)
        {
            parameters.Add("showOnlyPublished", showOnlyPublished.Value.ToString().ToLowerInvariant());
        }

        var uri = UriHelper.GetUri("/api/v2/webdeployments/configurations", parameters);

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<WebDeploymentConfigurationVersionEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<WebDeployment> GetWebdeploymentsDeploymentAsync(string deploymentId, IEnumerable<string> expands = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(deploymentId);

        var parameters = new NameValueCollection();

        if (expands != null)
        {
            foreach (var expand in expands)
            {
                parameters.Add("expand", expand);
            }
        }

        var uri = UriHelper.GetUri($"/api/v2/webdeployments/deployments/{Uri.EscapeDataString(deploymentId)}", parameters);

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<WebDeployment>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<CobrowseWebMessagingSession> GetWebdeploymentsDeploymentCobrowseSessionIdAsync(string deploymentId, string sessionId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(deploymentId);
        ArgumentException.ThrowIfNullOrEmpty(sessionId);

        var uri = $"/api/v2/webdeployments/deployments/{Uri.EscapeDataString(deploymentId)}/cobrowse/{Uri.EscapeDataString(sessionId)}";

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<CobrowseWebMessagingSession>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<WebDeploymentActiveConfigurationOnDeployment> GetWebdeploymentsDeploymentConfigurationsAsync(string deploymentId, string type = null, IEnumerable<string> expands = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(deploymentId);

        var parameters = new NameValueCollection();

        if (!string.IsNullOrEmpty(type))
        {
            parameters.Add("type", type);
        }

        if (expands != null)
        {
            foreach (var expand in expands)
            {
                parameters.Add("expand", expand);
            }
        }

        var uri = UriHelper.GetUri($"/api/v2/webdeployments/deployments/{Uri.EscapeDataString(deploymentId)}/configurations", parameters);

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<WebDeploymentActiveConfigurationOnDeployment>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<IdentityResolutionConfig> GetWebdeploymentsDeploymentIdentityresolutionAsync(string deploymentId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(deploymentId);

        var uri = $"/api/v2/webdeployments/deployments/{Uri.EscapeDataString(deploymentId)}/identityresolution";

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<IdentityResolutionConfig>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<ExpandableWebDeploymentEntityListing> GetWebdeploymentsDeploymentsAsync(IEnumerable<string> expands = null, CancellationToken cancellationToken = default)
    {
        var parameters = new NameValueCollection();

        if (expands != null)
        {
            foreach (var expand in expands)
            {
                parameters.Add("expand", expand);
            }
        }

        var uri = UriHelper.GetUri("/api/v2/webdeployments/deployments", parameters);

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ExpandableWebDeploymentEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<WebDeploymentConfigurationVersion> CreateWebdeploymentsConfigurationVersionsDraftPublishAsync(string configurationId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(configurationId);

        var uri = $"/api/v2/webdeployments/configurations/{Uri.EscapeDataString(configurationId)}/versions/draft/publish";

        var response = await _httpClient.PostAsync(uri, null, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<WebDeploymentConfigurationVersion>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<WebDeploymentConfigurationVersion> CreateWebdeploymentsConfigurationsAsync(WebDeploymentConfigurationVersion configurationVersion, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(configurationVersion);

        var uri = "/api/v2/webdeployments/configurations";

        var response = await _httpClient.PostAsJsonAsync(uri, configurationVersion, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<WebDeploymentConfigurationVersion>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<WebDeployment> CreateWebdeploymentsDeploymentsAsync(WebDeployment deployment, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(deployment);

        var uri = "/api/v2/webdeployments/deployments";

        var response = await _httpClient.PostAsJsonAsync(uri, deployment, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<WebDeployment>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<WebDeploymentsAuthorizationResponse> CreateWebdeploymentsTokenOauthcodegrantjwtexchangeAsync(WebDeploymentsOAuthExchangeRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var uri = "/api/v2/webdeployments/token/oauthcodegrantjwtexchange";

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<WebDeploymentsAuthorizationResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<SignedData> CreateWebdeploymentsTokenRefreshAsync(WebDeploymentsRefreshJWTRequest body = null, CancellationToken cancellationToken = default)
    {
        var uri = "/api/v2/webdeployments/token/refresh";

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<SignedData>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<WebDeploymentConfigurationVersion> UpdateWebdeploymentsConfigurationVersionsDraftAsync(string configurationId, WebDeploymentConfigurationVersion configurationVersion, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(configurationId);
        ArgumentNullException.ThrowIfNull(configurationVersion);

        var uri = $"/api/v2/webdeployments/configurations/{Uri.EscapeDataString(configurationId)}/versions/draft";

        var response = await _httpClient.PutAsJsonAsync(uri, configurationVersion, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<WebDeploymentConfigurationVersion>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<WebDeployment> UpdateWebdeploymentsDeploymentAsync(string deploymentId, WebDeployment deployment, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(deploymentId);
        ArgumentNullException.ThrowIfNull(deployment);

        var uri = $"/api/v2/webdeployments/deployments/{Uri.EscapeDataString(deploymentId)}";

        var response = await _httpClient.PutAsJsonAsync(uri, deployment, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<WebDeployment>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<IdentityResolutionConfig> UpdateWebdeploymentsDeploymentIdentityresolutionAsync(string deploymentId, IdentityResolutionConfig body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(deploymentId);
        ArgumentNullException.ThrowIfNull(body);

        var uri = $"/api/v2/webdeployments/deployments/{Uri.EscapeDataString(deploymentId)}/identityresolution";

        var response = await _httpClient.PutAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<IdentityResolutionConfig>(_options.JsonSerializerOptions, cancellationToken);
    }
}
