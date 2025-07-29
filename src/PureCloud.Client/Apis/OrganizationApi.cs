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
}