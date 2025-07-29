using System.Collections.Specialized;
using System.Net.Http.Json;
using System.Text.Json;
using Microsoft.Extensions.Options;
using PureCloud.Client.Contracts;
using PureCloud.Client.Http;
using PureCloud.Client.Json;
using PureCloud.Client.Models;
using PureCloud.Client.Models.Organizations;

namespace PureCloud.Client.Apis;

/// <inheritdoc />
public sealed class OrganizationApi : IOrganizationApi
{
    private readonly HttpClient _httpClient;
    private readonly JsonSerializerOptions _options;

    public OrganizationApi(IHttpClientFactory httpClientFactory, IOptions<PureCloudJsonSerializerOptions> options)
    {
        _httpClient = httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        _options = options.Value.JsonSerializerOptions;
    }

    /// <inheritdoc />
    public async Task<Organization> GetOrganizationAsync(CancellationToken cancellationToken)
    {
        var response = await _httpClient.GetAsync("/api/v2/organizations/me", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Organization>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<OrgAuthSettings> GetOrganizationAuthenticationSettingsAsync(CancellationToken cancellationToken)
    {
        var response = await _httpClient.GetAsync("/api/v2/organizations/authentication/settings", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<OrgAuthSettings>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<OrgAuthSettings> UpdateOrganizationAuthenticationSettingsAsync(OrgAuthSettings body, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(body);

        var response = await _httpClient.PatchAsJsonAsync("/api/v2/organizations/authentication/settings", body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<OrgAuthSettings>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<Organization> UpdateOrganizationAsync(Organization body, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(body);

        var response = await _httpClient.PutAsJsonAsync("/api/v2/organizations/me", body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Organization>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<LimitChangeRequestDetails> GetOrganizationLimitsChangeRequestAsync(string requestId, CancellationToken cancellationToken)
    {
        ArgumentException.ThrowIfNullOrEmpty(requestId);

        var response = await _httpClient.GetAsync($"/api/v2/organizations/limits/changerequests/{Uri.EscapeDataString(requestId)}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<LimitChangeRequestDetails>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<LimitChangeRequestsEntityListing> GetOrganizationLimitsChangeRequestsAsync(long? after, long? before, string status, int? pageSize, List<string> expand, CancellationToken cancellationToken)
    {
        var parameters = new NameValueCollection();

        if (after.HasValue)
        {
            parameters.Add("after", after.Value.ToString());
        }

        if (before.HasValue)
        {
            parameters.Add("before", before.Value.ToString());
        }

        if (!string.IsNullOrEmpty(status))
        {
            parameters.Add("status", status);
        }

        if (pageSize.HasValue)
        {
            parameters.Add("pageSize", pageSize.Value.ToString());
        }

        if (expand?.Count > 0)
        {
            foreach (var item in expand)
            {
                parameters.Add("expand", item);
            }
        }

        var uri = UriHelper.GetUri("/api/v2/organizations/limits/changerequests", parameters);

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<LimitChangeRequestsEntityListing>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<FieldConfig> GetFieldConfigAsync(string type, CancellationToken cancellationToken)
    {
        ArgumentException.ThrowIfNullOrEmpty(type);

        var parameters = new NameValueCollection { { "type", type } };

        var uri = UriHelper.GetUri("/api/v2/fieldconfig", parameters);

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<FieldConfig>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<EmbeddedIntegration> GetOrganizationEmbeddedIntegrationAsync(CancellationToken cancellationToken)
    {
        var response = await _httpClient.GetAsync("/api/v2/organizations/embeddedintegration", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<EmbeddedIntegration>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<IpAddressAuthentication> GetOrganizationIpAddressAuthenticationAsync(CancellationToken cancellationToken)
    {
        var response = await _httpClient.GetAsync("/api/v2/organizations/ipaddressauthentication", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<IpAddressAuthentication>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<LimitDocumentation> GetOrganizationLimitsDocumentationAsync(CancellationToken cancellationToken)
    {
        var response = await _httpClient.GetAsync("/api/v2/organizations/limits/docs", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<LimitDocumentation>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<FreeTrialLimitDocs> GetOrganizationLimitsFreeTrialDocumentationAsync(CancellationToken cancellationToken)
    {
        var response = await _httpClient.GetAsync("/api/v2/organizations/limits/docs/freetrial", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<FreeTrialLimitDocs>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<LimitsEntityListing> GetOrganizationLimitsNamespaceAsync(string namespaceName, CancellationToken cancellationToken)
    {
        ArgumentException.ThrowIfNullOrEmpty(namespaceName);

        var response = await _httpClient.GetAsync($"/api/v2/organizations/limits/namespaces/{Uri.EscapeDataString(namespaceName)}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<LimitsEntityListing>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<LimitsEntityListing> GetOrganizationLimitsNamespaceDefaultsAsync(string namespaceName, CancellationToken cancellationToken)
    {
        ArgumentException.ThrowIfNullOrEmpty(namespaceName);

        var response = await _httpClient.GetAsync($"/api/v2/organizations/limits/namespaces/{Uri.EscapeDataString(namespaceName)}/defaults", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<LimitsEntityListing>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<object> GetOrganizationLimitsNamespacesAsync(int? pageSize, int? pageNumber, CancellationToken cancellationToken)
    {
        var parameters = new NameValueCollection();

        if (pageSize.HasValue)
        {
            parameters.Add("pageSize", pageSize.Value.ToString());
        }

        if (pageNumber.HasValue)
        {
            parameters.Add("pageNumber", pageNumber.Value.ToString());
        }

        var uri = UriHelper.GetUri("/api/v2/organizations/limits/namespaces", parameters);

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<object>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<OrgWhitelistSettings> GetOrganizationWhitelistAsync(CancellationToken cancellationToken)
    {
        var response = await _httpClient.GetAsync("/api/v2/organizations/whitelist", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<OrgWhitelistSettings>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<OrganizationFeatures> UpdateOrganizationFeatureAsync(string featureName, FeatureState enabled, CancellationToken cancellationToken)
    {
        ArgumentException.ThrowIfNullOrEmpty(featureName);
        ArgumentNullException.ThrowIfNull(enabled);

        var response = await _httpClient.PatchAsJsonAsync($"/api/v2/organizations/features/{Uri.EscapeDataString(featureName)}", enabled, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<OrganizationFeatures>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<EmbeddedIntegration> UpdateOrganizationEmbeddedIntegrationAsync(EmbeddedIntegration body, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(body);

        var response = await _httpClient.PutAsJsonAsync("/api/v2/organizations/embeddedintegration", body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<EmbeddedIntegration>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<IpAddressAuthentication> UpdateOrganizationIpAddressAuthenticationAsync(IpAddressAuthentication body, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(body);

        var response = await _httpClient.PutAsJsonAsync("/api/v2/organizations/ipaddressauthentication", body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<IpAddressAuthentication>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<OrgWhitelistSettings> UpdateOrganizationWhitelistAsync(OrgWhitelistSettings body, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(body);

        var response = await _httpClient.PutAsJsonAsync("/api/v2/organizations/whitelist", body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<OrgWhitelistSettings>(_options, cancellationToken);
    }
}