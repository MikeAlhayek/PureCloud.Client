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
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly JsonSerializerOptions _options;

    public OrganizationApi(IHttpClientFactory httpClientFactory, IOptions<PureCloudJsonSerializerOptions> options)
    {
        _httpClientFactory = httpClientFactory;
        _options = options.Value.JsonSerializerOptions;
    }

    /// <inheritdoc />
    public async Task<Organization> GetOrganizationAsync(CancellationToken cancellationToken)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        var response = await client.GetAsync("api/v2/organizations/me", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Organization>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<OrgAuthSettings> GetOrganizationAuthenticationSettingsAsync(CancellationToken cancellationToken)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        var response = await client.GetAsync("api/v2/organizations/authentication/settings", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<OrgAuthSettings>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<OrgAuthSettings> UpdateOrganizationAuthenticationSettingsAsync(OrgAuthSettings body, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        var response = await client.PatchAsJsonAsync("api/v2/organizations/authentication/settings", body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<OrgAuthSettings>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<Organization> UpdateOrganizationAsync(Organization body, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        var response = await client.PutAsJsonAsync("api/v2/organizations/me", body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Organization>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<LimitChangeRequestDetails> GetOrganizationLimitsChangeRequestAsync(string requestId, CancellationToken cancellationToken)
    {
        ArgumentException.ThrowIfNullOrEmpty(requestId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        var response = await client.GetAsync($"api/v2/organizations/limits/changerequests/{Uri.EscapeDataString(requestId)}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<LimitChangeRequestDetails>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<LimitChangeRequestsEntityListing> GetOrganizationLimitsChangeRequestsAsync(long? after, long? before, string status, int? pageSize, IEnumerable<string> expands, CancellationToken cancellationToken)
    {
        var parameters = new NameValueCollection();

        if (after.HasValue)
        {
            parameters.Add("after", UriHelper.ParameterToString(after.Value));
        }

        if (before.HasValue)
        {
            parameters.Add("before", UriHelper.ParameterToString(before.Value));
        }

        if (!string.IsNullOrEmpty(status))
        {
            parameters.Add("status", UriHelper.ParameterToString(status));
        }

        if (pageSize.HasValue)
        {
            parameters.Add("pageSize", UriHelper.ParameterToString(pageSize.Value));
        }

        if (expands != null)
        {
            foreach (var expand in expands)
            {
                parameters.Add("expand", expand);
            }
        }

        var uri = UriHelper.GetUri("api/v2/organizations/limits/changerequests", parameters);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<LimitChangeRequestsEntityListing>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<FieldConfig> GetFieldConfigAsync(string type, CancellationToken cancellationToken)
    {
        ArgumentException.ThrowIfNullOrEmpty(type);

        var parameters = new NameValueCollection { { "type", type } };

        var uri = UriHelper.GetUri("api/v2/fieldconfig", parameters);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<FieldConfig>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<EmbeddedIntegration> GetOrganizationEmbeddedIntegrationAsync(CancellationToken cancellationToken)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        var response = await client.GetAsync("api/v2/organizations/embeddedintegration", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<EmbeddedIntegration>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<IpAddressAuthentication> GetOrganizationIpAddressAuthenticationAsync(CancellationToken cancellationToken)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        var response = await client.GetAsync("api/v2/organizations/ipaddressauthentication", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<IpAddressAuthentication>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<LimitDocumentation> GetOrganizationLimitsDocsAsync(CancellationToken cancellationToken)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        var response = await client.GetAsync("api/v2/organizations/limits/docs", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<LimitDocumentation>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<FreeTrialLimitDocs> GetOrganizationLimitsDocsFreeTrialAsync(CancellationToken cancellationToken)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        var response = await client.GetAsync("api/v2/organizations/limits/docs/freetrial", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<FreeTrialLimitDocs>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<LimitsEntityListing> GetOrganizationLimitsNamespaceAsync(string namespaceName, CancellationToken cancellationToken)
    {
        ArgumentException.ThrowIfNullOrEmpty(namespaceName);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        var response = await client.GetAsync($"api/v2/organizations/limits/namespaces/{Uri.EscapeDataString(namespaceName)}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<LimitsEntityListing>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<LimitsEntityListing> GetOrganizationLimitsNamespaceDefaultsAsync(string namespaceName, CancellationToken cancellationToken)
    {
        ArgumentException.ThrowIfNullOrEmpty(namespaceName);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        var response = await client.GetAsync($"api/v2/organizations/limits/namespaces/{Uri.EscapeDataString(namespaceName)}/defaults", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<LimitsEntityListing>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<PagedNamespaceListing> GetOrganizationLimitsNamespacesAsync(int? pageSize, int? pageNumber, CancellationToken cancellationToken)
    {
        var parameters = new NameValueCollection();

        if (pageSize.HasValue)
        {
            parameters.Add("pageSize", UriHelper.ParameterToString(pageSize.Value));
        }

        if (pageNumber.HasValue)
        {
            parameters.Add("pageNumber", UriHelper.ParameterToString(pageNumber.Value));
        }

        var uri = UriHelper.GetUri("api/v2/organizations/limits/namespaces", parameters);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<PagedNamespaceListing>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<OrgWhitelistSettings> GetOrganizationWhitelistAsync(CancellationToken cancellationToken)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        var response = await client.GetAsync("api/v2/organizations/whitelist", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<OrgWhitelistSettings>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<OrganizationFeatures> UpdateOrganizationFeatureAsync(string featureName, FeatureState enabled, CancellationToken cancellationToken)
    {
        ArgumentException.ThrowIfNullOrEmpty(featureName);
        ArgumentNullException.ThrowIfNull(enabled);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        var response = await client.PatchAsJsonAsync($"api/v2/organizations/features/{Uri.EscapeDataString(featureName)}", enabled, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<OrganizationFeatures>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<EmbeddedIntegration> UpdateOrganizationEmbeddedIntegrationAsync(EmbeddedIntegration body, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        var response = await client.PutAsJsonAsync("api/v2/organizations/embeddedintegration", body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<EmbeddedIntegration>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<IpAddressAuthentication> UpdateOrganizationIpAddressAuthenticationAsync(IpAddressAuthentication body, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        var response = await client.PutAsJsonAsync("api/v2/organizations/ipaddressauthentication", body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<IpAddressAuthentication>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<OrgWhitelistSettings> UpdateOrganizationWhitelistAsync(OrgWhitelistSettings body, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        var response = await client.PutAsJsonAsync("api/v2/organizations/whitelist", body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<OrgWhitelistSettings>(_options, cancellationToken);
    }
}
