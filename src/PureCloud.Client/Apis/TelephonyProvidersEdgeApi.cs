using System.Collections.Specialized;
using System.Net.Http.Json;
using Microsoft.Extensions.Options;
using PureCloud.Client.Contracts;
using PureCloud.Client.Http;
using PureCloud.Client.Json;
using PureCloud.Client.Models;

namespace PureCloud.Client.Apis;

/// <inheritdoc />
public sealed class TelephonyProvidersEdgeApi : ITelephonyProvidersEdgeApi
{
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly PureCloudJsonSerializerOptions _options;

    public TelephonyProvidersEdgeApi(IHttpClientFactory httpClientFactory, IOptions<PureCloudJsonSerializerOptions> options)
    {
        _httpClientFactory = httpClientFactory;
        _options = options.Value;
    }

    /// <inheritdoc />

    public async Task<Edge> GetEdgeAsync(string edgeId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(edgeId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"/api/v2/telephony/providers/edges/{Uri.EscapeDataString(edgeId)}", cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Edge>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />

    public async Task DeleteEdgeAsync(string edgeId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(edgeId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"/api/v2/telephony/providers/edges/{Uri.EscapeDataString(edgeId)}", cancellationToken);
        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />

    public async Task<EdgeEntityListing> GetEdgesAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync("/api/v2/telephony/providers/edges", cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<EdgeEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<Edge> CreateEdgeAsync(Edge body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("/api/v2/telephony/providers/edges", body, _options.JsonSerializerOptions, cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Edge>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<Edge> UpdateEdgeAsync(string edgeId, Edge body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(edgeId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync($"/api/v2/telephony/providers/edges/{Uri.EscapeDataString(edgeId)}", body, _options.JsonSerializerOptions, cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Edge>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<DIDPool> GetDidPoolAsync(string didPoolId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(nameof(didPoolId), didPoolId);

        var uri = UriHelper.GetUri($"/api/v2/telephony/providers/edges/didpools/{didPoolId}", null);
        var response = await _httpClient.GetAsync(uri, cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DIDPool>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<DIDPool> CreateDidPoolAsync(DIDPool body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body, nameof(body));

        var uri = UriHelper.GetUri("/api/v2/telephony/providers/edges/didpools", null);
        var response = await _httpClient.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DIDPool>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<DIDPool> UpdateDidPoolAsync(string didPoolId, DIDPool body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(nameof(didPoolId), didPoolId);

        ArgumentNullException.ThrowIfNull(body, nameof(body));

        var uri = UriHelper.GetUri($"/api/v2/telephony/providers/edges/didpools/{didPoolId}", null);
        var response = await _httpClient.PutAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DIDPool>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />

    public async Task DeleteDidPoolAsync(string didPoolId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(nameof(didPoolId), didPoolId);

        var uri = UriHelper.GetUri($"/api/v2/telephony/providers/edges/didpools/{didPoolId}", null);
        var response = await _httpClient.DeleteAsync(uri, cancellationToken);
        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />

    public async Task<Site> GetSiteAsync(string siteId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(nameof(siteId), siteId);

        var uri = UriHelper.GetUri($"/api/v2/telephony/providers/edges/sites/{siteId}", null);
        var response = await _httpClient.GetAsync(uri, cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Site>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<Site> CreateSiteAsync(Site body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body, nameof(body));

        var uri = UriHelper.GetUri("/api/v2/telephony/providers/edges/sites", null);
        var response = await _httpClient.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Site>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<Site> UpdateSiteAsync(string siteId, Site body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(nameof(siteId), siteId);

        ArgumentNullException.ThrowIfNull(body, nameof(body));

        var uri = UriHelper.GetUri($"/api/v2/telephony/providers/edges/sites/{siteId}", null);
        var response = await _httpClient.PutAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Site>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />

    public async Task DeleteSiteAsync(string siteId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(nameof(siteId), siteId);

        var uri = UriHelper.GetUri($"/api/v2/telephony/providers/edges/sites/{siteId}", null);
        var response = await _httpClient.DeleteAsync(uri, cancellationToken);
        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />

    public async Task<DomainCertificateAuthority> GetCertificateAuthorityAsync(string certificateId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(nameof(certificateId), certificateId);

        var uri = UriHelper.GetUri($"/api/v2/telephony/providers/edges/certificateauthorities/{certificateId}", null);
        var response = await _httpClient.GetAsync(uri, cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DomainCertificateAuthority>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<DomainCertificateAuthority> CreateCertificateAuthorityAsync(DomainCertificateAuthority body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body, nameof(body));

        var uri = UriHelper.GetUri("/api/v2/telephony/providers/edges/certificateauthorities", null);
        var response = await _httpClient.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DomainCertificateAuthority>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<DomainCertificateAuthority> UpdateCertificateAuthorityAsync(string certificateId, DomainCertificateAuthority body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(nameof(certificateId), certificateId);

        ArgumentNullException.ThrowIfNull(body, nameof(body));

        var uri = UriHelper.GetUri($"/api/v2/telephony/providers/edges/certificateauthorities/{certificateId}", null);
        var response = await _httpClient.PutAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DomainCertificateAuthority>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />

    public async Task DeleteCertificateAuthorityAsync(string certificateId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(nameof(certificateId), certificateId);

        var uri = UriHelper.GetUri($"/api/v2/telephony/providers/edges/certificateauthorities/{certificateId}", null);
        var response = await _httpClient.DeleteAsync(uri, cancellationToken);
        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />

    public async Task<ExtensionPool> GetExtensionPoolAsync(string extensionPoolId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(nameof(extensionPoolId), extensionPoolId);

        var uri = UriHelper.GetUri($"/api/v2/telephony/providers/edges/extensionpools/{extensionPoolId}", null);
        var response = await _httpClient.GetAsync(uri, cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ExtensionPool>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<ExtensionPool> CreateExtensionPoolAsync(ExtensionPool body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body, nameof(body));

        var uri = UriHelper.GetUri("/api/v2/telephony/providers/edges/extensionpools", null);
        var response = await _httpClient.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ExtensionPool>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<ExtensionPool> UpdateExtensionPoolAsync(string extensionPoolId, ExtensionPool body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(nameof(extensionPoolId), extensionPoolId);

        ArgumentNullException.ThrowIfNull(body, nameof(body));

        var uri = UriHelper.GetUri($"/api/v2/telephony/providers/edges/extensionpools/{extensionPoolId}", null);
        var response = await _httpClient.PutAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ExtensionPool>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />

    public async Task DeleteExtensionPoolAsync(string extensionPoolId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(extensionPoolId);

        var uri = UriHelper.GetUri($"/api/v2/telephony/providers/edges/extensionpools/{Uri.EscapeDataString(extensionPoolId)}", null);
        var response = await _httpClient.DeleteAsync(uri, cancellationToken);
        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />

    public async Task<EdgeEntityListing> GetEdgesAsync(int? pageSize = null, int? pageNumber = null, string name = null, string siteId = null, string edgeGroupId = null, string sortBy = null, bool? managed = null, CancellationToken cancellationToken = default)
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

        if (!string.IsNullOrEmpty(name))
        {
            parameters.Add("name", UriHelper.ParameterToString(name));
        }

        if (!string.IsNullOrEmpty(siteId))
        {
            parameters.Add("site.id", UriHelper.ParameterToString(siteId));
        }

        if (!string.IsNullOrEmpty(edgeGroupId))
        {
            parameters.Add("edgeGroup.id", UriHelper.ParameterToString(edgeGroupId));
        }

        if (!string.IsNullOrEmpty(sortBy))
        {
            parameters.Add("sortBy", UriHelper.ParameterToString(sortBy));
        }

        if (managed.HasValue)
        {
            parameters.Add("managed", UriHelper.ParameterToString(managed.Value));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("/api/v2/telephony/providers/edges", parameters);
        var response = await client.GetAsync(uri, cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<EdgeEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<EdgeNetworkDiagnosticResponse> GetEdgeDiagnosticNslookupAsync(string edgeId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(edgeId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"/api/v2/telephony/providers/edges/{Uri.EscapeDataString(edgeId)}/diagnostic/nslookup", cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<EdgeNetworkDiagnosticResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<EdgeNetworkDiagnosticResponse> GetEdgeDiagnosticPingAsync(string edgeId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(edgeId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"/api/v2/telephony/providers/edges/{Uri.EscapeDataString(edgeId)}/diagnostic/ping", cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<EdgeNetworkDiagnosticResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<EdgeNetworkDiagnosticResponse> GetEdgeDiagnosticRouteAsync(string edgeId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(edgeId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"/api/v2/telephony/providers/edges/{Uri.EscapeDataString(edgeId)}/diagnostic/route", cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<EdgeNetworkDiagnosticResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<EdgeNetworkDiagnosticResponse> GetEdgeDiagnosticTracepathAsync(string edgeId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(edgeId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"/api/v2/telephony/providers/edges/{Uri.EscapeDataString(edgeId)}/diagnostic/tracepath", cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<EdgeNetworkDiagnosticResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<DomainLogicalInterface> GetEdgeLogicalinterfaceAsync(string edgeId, string interfaceId, IEnumerable<string> expand = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(edgeId);
        ArgumentException.ThrowIfNullOrEmpty(interfaceId);

        var parameters = new NameValueCollection();

        if (expand != null)
        {
            foreach (var item in expand)
            {
                parameters.Add("expand", UriHelper.ParameterToString(item));
            }
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"/api/v2/telephony/providers/edges/{Uri.EscapeDataString(edgeId)}/logicalinterfaces/{Uri.EscapeDataString(interfaceId)}", parameters);
        var response = await client.GetAsync(uri, cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DomainLogicalInterface>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<LogicalInterfaceEntityListing> GetEdgeLogicalinterfacesAsync(string edgeId, IEnumerable<string> expand = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(edgeId);

        var parameters = new NameValueCollection();

        if (expand != null)
        {
            foreach (var item in expand)
            {
                parameters.Add("expand", UriHelper.ParameterToString(item));
            }
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"/api/v2/telephony/providers/edges/{Uri.EscapeDataString(edgeId)}/logicalinterfaces", parameters);
        var response = await client.GetAsync(uri, cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<LogicalInterfaceEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />

    public async Task DeleteEdgeLogicalinterfaceAsync(string edgeId, string interfaceId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(edgeId);
        ArgumentException.ThrowIfNullOrEmpty(interfaceId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"/api/v2/telephony/providers/edges/{Uri.EscapeDataString(edgeId)}/logicalinterfaces/{Uri.EscapeDataString(interfaceId)}", cancellationToken);
        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />

    public async Task<EdgeLogsJob> GetEdgeLogsJobAsync(string edgeId, string jobId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(edgeId);
        ArgumentException.ThrowIfNullOrEmpty(jobId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"/api/v2/telephony/providers/edges/{Uri.EscapeDataString(edgeId)}/logs/jobs/{Uri.EscapeDataString(jobId)}", cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<EdgeLogsJob>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<EdgeMetrics> GetEdgeMetricsAsync(string edgeId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(edgeId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"/api/v2/telephony/providers/edges/{Uri.EscapeDataString(edgeId)}/metrics", cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<EdgeMetrics>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<DomainPhysicalInterface> GetEdgePhysicalinterfaceAsync(string edgeId, string interfaceId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(edgeId);
        ArgumentException.ThrowIfNullOrEmpty(interfaceId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"/api/v2/telephony/providers/edges/{Uri.EscapeDataString(edgeId)}/physicalinterfaces/{Uri.EscapeDataString(interfaceId)}", cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DomainPhysicalInterface>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<PhysicalInterfaceEntityListing> GetEdgePhysicalinterfacesAsync(string edgeId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(edgeId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"/api/v2/telephony/providers/edges/{Uri.EscapeDataString(edgeId)}/physicalinterfaces", cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<PhysicalInterfaceEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />

    public async Task DeleteEdgeSoftwareupdateAsync(string edgeId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(edgeId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"/api/v2/telephony/providers/edges/{Uri.EscapeDataString(edgeId)}/softwareupdate", cancellationToken);
        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />

    public async Task<DomainEdgeSoftwareUpdateDto> GetEdgeSoftwareupdateAsync(string edgeId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(edgeId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"/api/v2/telephony/providers/edges/{Uri.EscapeDataString(edgeId)}/softwareupdate", cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DomainEdgeSoftwareUpdateDto>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<DomainEdgeSoftwareVersionDtoEntityListing> GetEdgeSoftwareversionsAsync(string edgeId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(edgeId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"/api/v2/telephony/providers/edges/{Uri.EscapeDataString(edgeId)}/softwareversions", cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DomainEdgeSoftwareVersionDtoEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<Line> GetEdgeLineAsync(string edgeId, string lineId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(edgeId);
        ArgumentException.ThrowIfNullOrEmpty(lineId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"/api/v2/telephony/providers/edges/{Uri.EscapeDataString(edgeId)}/lines/{Uri.EscapeDataString(lineId)}", cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Line>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<LineEntityListing> GetEdgeLinesAsync(string edgeId, int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(edgeId);

        var parameters = new NameValueCollection();

        if (pageSize.HasValue)
        {
            parameters.Add("pageSize", UriHelper.ParameterToString(pageSize.Value));
        }

        if (pageNumber.HasValue)
        {
            parameters.Add("pageNumber", UriHelper.ParameterToString(pageNumber.Value));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"/api/v2/telephony/providers/edges/{Uri.EscapeDataString(edgeId)}/lines", parameters);
        var response = await client.GetAsync(uri, cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<LineEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }
}