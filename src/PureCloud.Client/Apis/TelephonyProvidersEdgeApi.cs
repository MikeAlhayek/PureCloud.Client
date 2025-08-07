using System.Collections.Specialized;
using System.Net.Http.Json;
using Microsoft.Extensions.Options;
using PureCloud.Client.Contracts;
using PureCloud.Client.Http;
using PureCloud.Client.Json;
using PureCloud.Client.Models;
using PureCloud.Client.Extensions;

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
    public async Task<bool> DeleteEdgeAsync(string edgeId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(edgeId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"/api/v2/telephony/providers/edges/{Uri.EscapeDataString(edgeId)}", cancellationToken);

        return response.IsSuccessStatusCode;
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
        ArgumentException.ThrowIfNullOrEmpty(didPoolId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"/api/v2/telephony/providers/edges/didpools/{Uri.EscapeDataString(didPoolId)}", cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DIDPool>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<DIDPool> CreateDidPoolAsync(DIDPool body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("/api/v2/telephony/providers/edges/didpools", body, _options.JsonSerializerOptions, cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DIDPool>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<DIDPool> UpdateDidPoolAsync(string didPoolId, DIDPool body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(didPoolId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync($"/api/v2/telephony/providers/edges/didpools/{Uri.EscapeDataString(didPoolId)}", body, _options.JsonSerializerOptions, cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DIDPool>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<bool> DeleteDidPoolAsync(string didPoolId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(didPoolId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"/api/v2/telephony/providers/edges/didpools/{Uri.EscapeDataString(didPoolId)}", cancellationToken);

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    public async Task<Site> GetSiteAsync(string siteId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(siteId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"/api/v2/telephony/providers/edges/sites/{Uri.EscapeDataString(siteId)}", cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Site>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<Site> CreateSiteAsync(Site body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("/api/v2/telephony/providers/edges/sites", body, _options.JsonSerializerOptions, cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Site>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<Site> UpdateSiteAsync(string siteId, Site body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(siteId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync($"/api/v2/telephony/providers/edges/sites/{Uri.EscapeDataString(siteId)}", body, _options.JsonSerializerOptions, cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Site>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<bool> DeleteSiteAsync(string siteId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(siteId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"/api/v2/telephony/providers/edges/sites/{Uri.EscapeDataString(siteId)}", cancellationToken);

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    public async Task<DomainCertificateAuthority> GetCertificateAuthorityAsync(string certificateId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(certificateId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"/api/v2/telephony/providers/edges/certificateauthorities/{Uri.EscapeDataString(certificateId)}", cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DomainCertificateAuthority>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<DomainCertificateAuthority> CreateCertificateAuthorityAsync(DomainCertificateAuthority body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("/api/v2/telephony/providers/edges/certificateauthorities", body, _options.JsonSerializerOptions, cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DomainCertificateAuthority>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<DomainCertificateAuthority> UpdateCertificateAuthorityAsync(string certificateId, DomainCertificateAuthority body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(certificateId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync($"/api/v2/telephony/providers/edges/certificateauthorities/{Uri.EscapeDataString(certificateId)}", body, _options.JsonSerializerOptions, cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DomainCertificateAuthority>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<bool> DeleteCertificateAuthorityAsync(string certificateId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(certificateId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"/api/v2/telephony/providers/edges/certificateauthorities/{Uri.EscapeDataString(certificateId)}", cancellationToken);

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    public async Task<ExtensionPool> GetExtensionPoolAsync(string extensionPoolId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(extensionPoolId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"/api/v2/telephony/providers/edges/extensionpools/{Uri.EscapeDataString(extensionPoolId)}", cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ExtensionPool>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<ExtensionPool> CreateExtensionPoolAsync(ExtensionPool body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("/api/v2/telephony/providers/edges/extensionpools", body, _options.JsonSerializerOptions, cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ExtensionPool>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<ExtensionPool> UpdateExtensionPoolAsync(string extensionPoolId, ExtensionPool body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(extensionPoolId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync($"/api/v2/telephony/providers/edges/extensionpools/{Uri.EscapeDataString(extensionPoolId)}", body, _options.JsonSerializerOptions, cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ExtensionPool>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<bool> DeleteExtensionPoolAsync(string extensionPoolId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(extensionPoolId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"/api/v2/telephony/providers/edges/extensionpools/{Uri.EscapeDataString(extensionPoolId)}", cancellationToken);

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    public async Task<EdgeEntityListing> GetEdgesAsync(int? pageSize = null, int? pageNumber = null, string name = null, string siteId = null, string edgeGroupId = null, string sortBy = null, bool? managed = null, CancellationToken cancellationToken = default)
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

        if (!string.IsNullOrEmpty(name))
        {
            parameters.Add("name", name);
        }

        if (!string.IsNullOrEmpty(siteId))
        {
            parameters.Add("site.id", siteId);
        }

        if (!string.IsNullOrEmpty(edgeGroupId))
        {
            parameters.Add("edgeGroup.id", edgeGroupId);
        }

        if (!string.IsNullOrEmpty(sortBy))
        {
            parameters.Add("sortBy", sortBy);
        }

        if (managed.HasValue)
        {
            parameters.Add("managed", managed.Value.ToString().ToLowerInvariant());
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = parameters.ToQueryString("/api/v2/telephony/providers/edges");
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
    public async Task<DomainLogicalInterface> GetEdgeLogicalinterfaceAsync(string edgeId, string interfaceId, IEnumerable<string> expands = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(edgeId);
        ArgumentException.ThrowIfNullOrEmpty(interfaceId);

        var parameters = new NameValueCollection();

        if (expands != null)
        {
            foreach (var expand in expands)
            {
                parameters.Add("expand", expand);
            }
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = parameters.ToQueryString($"/api/v2/telephony/providers/edges/{Uri.EscapeDataString(edgeId)}/logicalinterfaces/{Uri.EscapeDataString(interfaceId)}");
        var response = await client.GetAsync(uri, cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DomainLogicalInterface>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<LogicalInterfaceEntityListing> GetEdgeLogicalinterfacesAsync(string edgeId, IEnumerable<string> expands = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(edgeId);

        var parameters = new NameValueCollection();

        if (expands != null)
        {
            foreach (var expand in expands)
            {
                parameters.Add("expand", expand);
            }
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = parameters.ToQueryString($"/api/v2/telephony/providers/edges/{Uri.EscapeDataString(edgeId)}/logicalinterfaces");
        var response = await client.GetAsync(uri, cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<LogicalInterfaceEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<bool> DeleteEdgeLogicalinterfaceAsync(string edgeId, string interfaceId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(edgeId);
        ArgumentException.ThrowIfNullOrEmpty(interfaceId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"/api/v2/telephony/providers/edges/{Uri.EscapeDataString(edgeId)}/logicalinterfaces/{Uri.EscapeDataString(interfaceId)}", cancellationToken);

        return response.IsSuccessStatusCode;
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
    public async Task<bool> DeleteEdgeSoftwareupdateAsync(string edgeId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(edgeId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"/api/v2/telephony/providers/edges/{Uri.EscapeDataString(edgeId)}/softwareupdate", cancellationToken);

        return response.IsSuccessStatusCode;
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
            parameters.Add("pageSize", pageSize.Value.ToString());
        }

        if (pageNumber.HasValue)
        {
            parameters.Add("pageNumber", pageNumber.Value.ToString());
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = parameters.ToQueryString($"/api/v2/telephony/providers/edges/{Uri.EscapeDataString(edgeId)}/lines");
        var response = await client.GetAsync(uri, cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<LineEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<bool> DeleteEdgeAlertablepresencesAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync("/api/v2/telephony/providers/edges/alertablepresences", cancellationToken);

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    public async Task<VmPairingInfo> GetEdgeSetuppackageAsync(string edgeId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(edgeId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"/api/v2/telephony/providers/edges/{Uri.EscapeDataString(edgeId)}/setuppackage", cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<VmPairingInfo>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<TrunkEntityListing> GetEdgeTrunksAsync(string edgeId, int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, string trunkBaseId = null, string trunkType = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(edgeId);

        var parameters = new NameValueCollection();

        if (pageNumber.HasValue)
        {
            parameters.Add("pageNumber", pageNumber.Value.ToString());
        }

        if (pageSize.HasValue)
        {
            parameters.Add("pageSize", pageSize.Value.ToString());
        }

        if (!string.IsNullOrEmpty(sortBy))
        {
            parameters.Add("sortBy", sortBy);
        }

        if (!string.IsNullOrEmpty(sortOrder))
        {
            parameters.Add("sortOrder", sortOrder);
        }

        if (!string.IsNullOrEmpty(trunkBaseId))
        {
            parameters.Add("trunkBase.id", trunkBaseId);
        }

        if (!string.IsNullOrEmpty(trunkType))
        {
            parameters.Add("trunkType", trunkType);
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = parameters.ToQueryString($"/api/v2/telephony/providers/edges/{Uri.EscapeDataString(edgeId)}/trunks");
        var response = await client.GetAsync(uri, cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<TrunkEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<AlertablePresences> GetEdgeAlertablepresencesAsync(string type = null, CancellationToken cancellationToken = default)
    {
        var parameters = new NameValueCollection();

        if (!string.IsNullOrEmpty(type))
        {
            parameters.Add("type", type);
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = parameters.ToQueryString("/api/v2/telephony/providers/edges/alertablepresences");
        var response = await client.GetAsync(uri, cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AlertablePresences>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<CertificateAuthorityEntityListing> GetEdgeCertificateauthoritiesAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync("/api/v2/telephony/providers/edges/certificateauthorities", cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<CertificateAuthorityEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<DID> GetEdgeDidAsync(string didId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(didId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"/api/v2/telephony/providers/edges/dids/{Uri.EscapeDataString(didId)}", cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DID>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<DIDEntityListing> GetEdgeDidsAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync("/api/v2/telephony/providers/edges/dids", cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DIDEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<DIDPoolEntityListing> GetEdgeDidpoolsAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync("/api/v2/telephony/providers/edges/didpools", cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DIDPoolEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<EdgeGroup> GetEdgeEdgegroupAsync(string edgeGroupId, IEnumerable<string> expands = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(edgeGroupId);

        var parameters = new NameValueCollection();

        if (expands != null)
        {
            foreach (var expand in expands)
            {
                parameters.Add("expand", expand);
            }
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = parameters.ToQueryString($"/api/v2/telephony/providers/edges/edgegroups/{Uri.EscapeDataString(edgeGroupId)}");
        var response = await client.GetAsync(uri, cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<EdgeGroup>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<EdgeGroupEntityListing> GetEdgeEdgegroupsAsync(int? pageSize = null, int? pageNumber = null, string name = null, string sortBy = null, bool? managed = null, CancellationToken cancellationToken = default)
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

        if (!string.IsNullOrEmpty(name))
        {
            parameters.Add("name", name);
        }

        if (!string.IsNullOrEmpty(sortBy))
        {
            parameters.Add("sortBy", sortBy);
        }

        if (managed.HasValue)
        {
            parameters.Add("managed", managed.Value.ToString().ToLowerInvariant());
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = parameters.ToQueryString("/api/v2/telephony/providers/edges/edgegroups");
        var response = await client.GetAsync(uri, cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<EdgeGroupEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<ExtensionPoolEntityListing> GetEdgeExtensionpoolsAsync(int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, CancellationToken cancellationToken = default)
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

        if (!string.IsNullOrEmpty(sortBy))
        {
            parameters.Add("sortBy", sortBy);
        }

        if (!string.IsNullOrEmpty(sortOrder))
        {
            parameters.Add("sortOrder", sortOrder);
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = parameters.ToQueryString("/api/v2/telephony/providers/edges/extensionpools");
        var response = await client.GetAsync(uri, cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ExtensionPoolEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<LineBase> GetEdgeLinebasesettingAsync(string lineBaseId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(lineBaseId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"/api/v2/telephony/providers/edges/linebasesettings/{Uri.EscapeDataString(lineBaseId)}", cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<LineBase>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<LineBaseEntityListing> GetEdgeLinebasesettingsAsync(int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, CancellationToken cancellationToken = default)
    {
        var parameters = new NameValueCollection();

        if (pageNumber.HasValue)
        {
            parameters.Add("pageNumber", pageNumber.Value.ToString());
        }

        if (pageSize.HasValue)
        {
            parameters.Add("pageSize", pageSize.Value.ToString());
        }

        if (!string.IsNullOrEmpty(sortBy))
        {
            parameters.Add("sortBy", sortBy);
        }

        if (!string.IsNullOrEmpty(sortOrder))
        {
            parameters.Add("sortOrder", sortOrder);
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = parameters.ToQueryString("/api/v2/telephony/providers/edges/linebasesettings");
        var response = await client.GetAsync(uri, cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<LineBaseEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<Phone> GetEdgePhoneAsync(string phoneId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(phoneId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"/api/v2/telephony/providers/edges/phones/{Uri.EscapeDataString(phoneId)}", cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Phone>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<PhoneBase> GetEdgePhonebasesettingAsync(string phoneBaseId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(phoneBaseId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"/api/v2/telephony/providers/edges/phonebasesettings/{Uri.EscapeDataString(phoneBaseId)}", cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<PhoneBase>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<PhoneBaseEntityListing> GetEdgePhonebasesettingsAsync(int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string name = null, CancellationToken cancellationToken = default)
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

        if (!string.IsNullOrEmpty(sortBy))
        {
            parameters.Add("sortBy", sortBy);
        }

        if (!string.IsNullOrEmpty(sortOrder))
        {
            parameters.Add("sortOrder", sortOrder);
        }

        if (!string.IsNullOrEmpty(name))
        {
            parameters.Add("name", name);
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = parameters.ToQueryString("/api/v2/telephony/providers/edges/phonebasesettings");
        var response = await client.GetAsync(uri, cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<PhoneBaseEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<PhoneEntityListing> GetEdgePhonesAsync(int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, string siteId = null, string webRtcUserId = null, string phoneBaseSettingsId = null, string linesLoggedInUserId = null, string linesDefaultForUserId = null, string phoneHardwareId = null, string linesId = null, string linesName = null, string name = null, string statusOperationalStatus = null, string secondaryStatusOperationalStatus = null, IEnumerable<string> expands = null, IEnumerable<string> fieldNames = null, CancellationToken cancellationToken = default)
    {
        var parameters = new NameValueCollection();

        if (pageNumber.HasValue)
        {
            parameters.Add("pageNumber", pageNumber.Value.ToString());
        }

        if (pageSize.HasValue)
        {
            parameters.Add("pageSize", pageSize.Value.ToString());
        }

        if (!string.IsNullOrEmpty(sortBy))
        {
            parameters.Add("sortBy", sortBy);
        }

        if (!string.IsNullOrEmpty(sortOrder))
        {
            parameters.Add("sortOrder", sortOrder);
        }

        if (!string.IsNullOrEmpty(siteId))
        {
            parameters.Add("site.id", siteId);
        }

        if (!string.IsNullOrEmpty(webRtcUserId))
        {
            parameters.Add("webRtcUser.id", webRtcUserId);
        }

        if (!string.IsNullOrEmpty(phoneBaseSettingsId))
        {
            parameters.Add("phoneBaseSettings.id", phoneBaseSettingsId);
        }

        if (!string.IsNullOrEmpty(linesLoggedInUserId))
        {
            parameters.Add("lines.loggedInUser.id", linesLoggedInUserId);
        }

        if (!string.IsNullOrEmpty(linesDefaultForUserId))
        {
            parameters.Add("lines.defaultForUser.id", linesDefaultForUserId);
        }

        if (!string.IsNullOrEmpty(phoneHardwareId))
        {
            parameters.Add("phoneHardware.id", phoneHardwareId);
        }

        if (!string.IsNullOrEmpty(linesId))
        {
            parameters.Add("lines.id", linesId);
        }

        if (!string.IsNullOrEmpty(linesName))
        {
            parameters.Add("lines.name", linesName);
        }

        if (!string.IsNullOrEmpty(name))
        {
            parameters.Add("name", name);
        }

        if (!string.IsNullOrEmpty(statusOperationalStatus))
        {
            parameters.Add("status.operationalStatus", statusOperationalStatus);
        }

        if (!string.IsNullOrEmpty(secondaryStatusOperationalStatus))
        {
            parameters.Add("secondaryStatus.operationalStatus", secondaryStatusOperationalStatus);
        }

        if (expands != null)
        {
            foreach (var expand in expands)
            {
                parameters.Add("expand", expand);
            }
        }

        if (fieldNames != null)
        {
            foreach (var fieldName in fieldNames)
            {
                parameters.Add("fields", fieldName);
            }
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = parameters.ToQueryString("/api/v2/telephony/providers/edges/phones");
        var response = await client.GetAsync(uri, cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<PhoneEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<PhoneMetaBaseEntityListing> GetEdgePhonesTemplateAsync(string phoneMetabaseId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(phoneMetabaseId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"/api/v2/telephony/providers/edges/phones/template?phoneMetabaseId={Uri.EscapeDataString(phoneMetabaseId)}", cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<PhoneMetaBaseEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<SiteEntityListing> GetEdgeSitesAsync(int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string name = null, string locationId = null, bool? managed = null, IEnumerable<string> expands = null, CancellationToken cancellationToken = default)
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

        if (!string.IsNullOrEmpty(sortBy))
        {
            parameters.Add("sortBy", sortBy);
        }

        if (!string.IsNullOrEmpty(sortOrder))
        {
            parameters.Add("sortOrder", sortOrder);
        }

        if (!string.IsNullOrEmpty(name))
        {
            parameters.Add("name", name);
        }

        if (!string.IsNullOrEmpty(locationId))
        {
            parameters.Add("location.id", locationId);
        }

        if (managed.HasValue)
        {
            parameters.Add("managed", managed.Value.ToString().ToLowerInvariant());
        }

        if (expands != null)
        {
            foreach (var expand in expands)
            {
                parameters.Add("expand", expand);
            }
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = parameters.ToQueryString("/api/v2/telephony/providers/edges/sites");
        var response = await client.GetAsync(uri, cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<SiteEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<OutboundRouteBase> GetEdgeSiteOutboundrouteAsync(string siteId, string outboundRouteId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(siteId);
        ArgumentException.ThrowIfNullOrEmpty(outboundRouteId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"/api/v2/telephony/providers/edges/sites/{Uri.EscapeDataString(siteId)}/outboundroutes/{Uri.EscapeDataString(outboundRouteId)}", cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<OutboundRouteBase>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<OutboundRouteBaseEntityListing> GetEdgeSiteOutboundroutesAsync(string siteId, int? pageSize = null, int? pageNumber = null, string name = null, string externalTrunkBaseIds = null, string sortBy = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(siteId);

        var parameters = new NameValueCollection();

        if (pageSize.HasValue)
        {
            parameters.Add("pageSize", pageSize.Value.ToString());
        }

        if (pageNumber.HasValue)
        {
            parameters.Add("pageNumber", pageNumber.Value.ToString());
        }

        if (!string.IsNullOrEmpty(name))
        {
            parameters.Add("name", name);
        }

        if (!string.IsNullOrEmpty(externalTrunkBaseIds))
        {
            parameters.Add("externalTrunkBase.ids", externalTrunkBaseIds);
        }

        if (!string.IsNullOrEmpty(sortBy))
        {
            parameters.Add("sortBy", sortBy);
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = parameters.ToQueryString($"/api/v2/telephony/providers/edges/sites/{Uri.EscapeDataString(siteId)}/outboundroutes");
        var response = await client.GetAsync(uri, cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<OutboundRouteBaseEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<TimeZoneEntityListing> GetEdgeTimezonesAsync(int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default)
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

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = parameters.ToQueryString("/api/v2/telephony/providers/edges/timezones");
        var response = await client.GetAsync(uri, cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<TimeZoneEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<Trunk> GetEdgeTrunkAsync(string trunkId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(trunkId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"/api/v2/telephony/providers/edges/trunks/{Uri.EscapeDataString(trunkId)}", cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Trunk>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<TrunkBase> GetEdgeTrunkbasesettingAsync(string trunkBaseSettingsId, bool? ignoreHidden = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(trunkBaseSettingsId);

        var parameters = new NameValueCollection();

        if (ignoreHidden.HasValue)
        {
            parameters.Add("ignoreHidden", ignoreHidden.Value.ToString().ToLowerInvariant());
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = parameters.ToQueryString($"/api/v2/telephony/providers/edges/trunkbasesettings/{Uri.EscapeDataString(trunkBaseSettingsId)}");
        var response = await client.GetAsync(uri, cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<TrunkBase>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<TrunkBaseEntityListing> GetEdgeTrunkbasesettingsAsync(int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, bool? recordingEnabled = null, bool? ignoreHidden = null, bool? managed = null, IEnumerable<string> expands = null, string name = null, CancellationToken cancellationToken = default)
    {
        var parameters = new NameValueCollection();

        if (pageNumber.HasValue)
        {
            parameters.Add("pageNumber", pageNumber.Value.ToString());
        }

        if (pageSize.HasValue)
        {
            parameters.Add("pageSize", pageSize.Value.ToString());
        }

        if (!string.IsNullOrEmpty(sortBy))
        {
            parameters.Add("sortBy", sortBy);
        }

        if (!string.IsNullOrEmpty(sortOrder))
        {
            parameters.Add("sortOrder", sortOrder);
        }

        if (recordingEnabled.HasValue)
        {
            parameters.Add("recordingEnabled", recordingEnabled.Value.ToString().ToLowerInvariant());
        }

        if (ignoreHidden.HasValue)
        {
            parameters.Add("ignoreHidden", ignoreHidden.Value.ToString().ToLowerInvariant());
        }

        if (managed.HasValue)
        {
            parameters.Add("managed", managed.Value.ToString().ToLowerInvariant());
        }

        if (expands != null)
        {
            foreach (var expand in expands)
            {
                parameters.Add("expand", expand);
            }
        }

        if (!string.IsNullOrEmpty(name))
        {
            parameters.Add("name", name);
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = parameters.ToQueryString("/api/v2/telephony/providers/edges/trunkbasesettings");
        var response = await client.GetAsync(uri, cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<TrunkBaseEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<TrunkMetabaseEntityListing> GetEdgeTrunkbasesettingsAvailablemetabasesAsync(string type = null, int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default)
    {
        var parameters = new NameValueCollection();

        if (!string.IsNullOrEmpty(type))
        {
            parameters.Add("type", type);
        }

        if (pageSize.HasValue)
        {
            parameters.Add("pageSize", pageSize.Value.ToString());
        }

        if (pageNumber.HasValue)
        {
            parameters.Add("pageNumber", pageNumber.Value.ToString());
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = parameters.ToQueryString("/api/v2/telephony/providers/edges/trunkbasesettings/availablemetabases");
        var response = await client.GetAsync(uri, cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<TrunkMetabaseEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<TrunkMetrics> GetEdgeTrunkbasesettingsTemplateAsync(string trunkMetabaseId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(trunkMetabaseId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"/api/v2/telephony/providers/edges/trunkbasesettings/template?trunkMetabaseId={Uri.EscapeDataString(trunkMetabaseId)}", cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<TrunkMetrics>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<TrunkRecordingEnabledCount> GetEdgeTrunksMetricsAsync(string trunkIds, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(trunkIds);

        var parameters = new NameValueCollection();
        parameters.Add("trunkIds", trunkIds);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = parameters.ToQueryString("/api/v2/telephony/providers/edges/trunks/metrics");
        var response = await client.GetAsync(uri, cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<TrunkRecordingEnabledCount>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<bool> DeleteEdgeGroupAsync(string edgeGroupId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(edgeGroupId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"/api/v2/telephony/providers/edges/edgegroups/{Uri.EscapeDataString(edgeGroupId)}", cancellationToken);

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    public async Task<bool> DeletePhoneAsync(string phoneId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(phoneId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"/api/v2/telephony/providers/edges/phones/{Uri.EscapeDataString(phoneId)}", cancellationToken);

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    public async Task<bool> DeletePhoneBasesettingAsync(string phoneBaseId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(phoneBaseId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"/api/v2/telephony/providers/edges/phonebasesettings/{Uri.EscapeDataString(phoneBaseId)}", cancellationToken);

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    public async Task<bool> DeleteSiteOutboundrouteAsync(string siteId, string outboundRouteId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(siteId);
        ArgumentException.ThrowIfNullOrEmpty(outboundRouteId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"/api/v2/telephony/providers/edges/sites/{Uri.EscapeDataString(siteId)}/outboundroutes/{Uri.EscapeDataString(outboundRouteId)}", cancellationToken);

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    public async Task<bool> DeleteTrunkbasesettingAsync(string trunkBaseSettingsId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(trunkBaseSettingsId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"/api/v2/telephony/providers/edges/trunkbasesettings/{Uri.EscapeDataString(trunkBaseSettingsId)}", cancellationToken);

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    public async Task<EdgeVersionReport> GetEdgeversionreportAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync("/api/v2/telephony/providers/edges/edgeversionreport", cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<EdgeVersionReport>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<ExpiredEdgeListing> GetExpiredAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync("/api/v2/telephony/providers/edges/expired", cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ExpiredEdgeListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<Extension> GetExtensionAsync(string extensionId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(extensionId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"/api/v2/telephony/providers/edges/extensions/{Uri.EscapeDataString(extensionId)}", cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Extension>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<Line> GetLineAsync(string lineId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(lineId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"/api/v2/telephony/providers/edges/lines/{Uri.EscapeDataString(lineId)}", cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Line>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<Line> GetLinesTemplateAsync(string lineMetabaseId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(lineMetabaseId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"/api/v2/telephony/providers/edges/lines/template?lineMetabaseId={Uri.EscapeDataString(lineMetabaseId)}", cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Line>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<MediaStatisticsListing> GetMediastatisticsConversationAsync(string conversationId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(conversationId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"/api/v2/telephony/providers/edges/mediastatistics/conversations/{Uri.EscapeDataString(conversationId)}", cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<MediaStatisticsListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<IEnumerable<EdgeMetrics>> GetEdgesMetricsAsync(string edgeIds, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(edgeIds);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"/api/v2/telephony/providers/edges/metrics?edgeIds={Uri.EscapeDataString(edgeIds)}", cancellationToken);
        response.EnsureSuccessStatusCode();

        var result = await response.Content.ReadFromJsonAsync<IEnumerable<EdgeMetrics>>(_options.JsonSerializerOptions, cancellationToken);

        return result ?? Array.Empty<EdgeMetrics>();
    }

    /// <inheritdoc />
    public async Task<PhoneBase> GetPhonebasesettingsTemplateAsync(string phoneMetabaseId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(phoneMetabaseId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"/api/v2/telephony/providers/edges/phonebasesettings/template?phoneMetabaseId={Uri.EscapeDataString(phoneMetabaseId)}", cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<PhoneBase>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<PhysicalInterfaceEntityListing> GetPhysicalinterfacesAsync(string edgeIds, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(edgeIds);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"/api/v2/telephony/providers/edges/physicalinterfaces?edgeIds={Uri.EscapeDataString(edgeIds)}", cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<PhysicalInterfaceEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<IEnumerable<NumberPlan>> GetSiteNumberplansAsync(string siteId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(siteId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"/api/v2/telephony/providers/edges/sites/{Uri.EscapeDataString(siteId)}/numberplans", cancellationToken);
        response.EnsureSuccessStatusCode();

        var result = await response.Content.ReadFromJsonAsync<IEnumerable<NumberPlan>>(_options.JsonSerializerOptions, cancellationToken);

        return result ?? Array.Empty<NumberPlan>();
    }

    /// <inheritdoc />
    public async Task<SiteConnections> GetSiteSiteconnectionsAsync(string siteId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(siteId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"/api/v2/telephony/providers/edges/sites/{Uri.EscapeDataString(siteId)}/siteconnections", cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<SiteConnections>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<TrunkMetrics> GetTrunkMetricsAsync(string trunkId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(trunkId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"/api/v2/telephony/providers/edges/trunks/{Uri.EscapeDataString(trunkId)}/metrics", cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<TrunkMetrics>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<TrunkBase> GetTrunkbasesettingsTemplateAsync(string trunkMetabaseId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(trunkMetabaseId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"/api/v2/telephony/providers/edges/trunkbasesettings/template?trunkMetabaseId={Uri.EscapeDataString(trunkMetabaseId)}", cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<TrunkBase>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<TrunkRecordingEnabledCount> GetTrunkswithrecordingAsync(string trunkType = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = "/api/v2/telephony/providers/edges/trunkswithrecording";
        if (!string.IsNullOrEmpty(trunkType))
        {
            uri += $"?trunkType={Uri.EscapeDataString(trunkType)}";
        }

        var response = await client.GetAsync(uri, cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<TrunkRecordingEnabledCount>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<ValidateAddressResponse> ValidateAddressAsync(ValidateAddressRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("/api/v2/telephony/providers/edges/addressvalidation", body, _options.JsonSerializerOptions, cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ValidateAddressResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> RebootEdgeAsync(string edgeId, EdgeRebootParameters body = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(edgeId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync($"/api/v2/telephony/providers/edges/{Uri.EscapeDataString(edgeId)}/reboot", body, _options.JsonSerializerOptions, cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task RebootPhoneAsync(string phoneId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(phoneId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsync($"/api/v2/telephony/providers/edges/phones/{Uri.EscapeDataString(phoneId)}/reboot", null, cancellationToken);
        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task UploadEdgeLogsJobAsync(string edgeId, string jobId, EdgeLogsJobUploadRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(edgeId);
        ArgumentException.ThrowIfNullOrEmpty(jobId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync($"/api/v2/telephony/providers/edges/{Uri.EscapeDataString(edgeId)}/logs/jobs/{Uri.EscapeDataString(jobId)}/upload", body, _options.JsonSerializerOptions, cancellationToken);
        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task<EdgeLogsJobResponse> CreateEdgeLogsJobAsync(string edgeId, EdgeLogsJobRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(edgeId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync($"/api/v2/telephony/providers/edges/{Uri.EscapeDataString(edgeId)}/logs/jobs", body, _options.JsonSerializerOptions, cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<EdgeLogsJobResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<DomainEdgeSoftwareUpdateDto> CreateEdgeSoftwareupdateAsync(string edgeId, DomainEdgeSoftwareUpdateDto body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(edgeId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync($"/api/v2/telephony/providers/edges/{Uri.EscapeDataString(edgeId)}/softwareupdate", body, _options.JsonSerializerOptions, cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DomainEdgeSoftwareUpdateDto>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> ChangeEdgeStatusAsync(string edgeId, EdgeServiceStateRequest body = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(edgeId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync($"/api/v2/telephony/providers/edges/{Uri.EscapeDataString(edgeId)}/statuscode", body, _options.JsonSerializerOptions, cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> UnpairEdgeAsync(string edgeId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(edgeId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsync($"/api/v2/telephony/providers/edges/{Uri.EscapeDataString(edgeId)}/unpair", null, cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<EdgeNetworkDiagnostic> CreateEdgeDiagnosticNslookupAsync(string edgeId, EdgeNetworkDiagnosticRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(edgeId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync($"/api/v2/telephony/providers/edges/{Uri.EscapeDataString(edgeId)}/diagnostic/nslookup", body, _options.JsonSerializerOptions, cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<EdgeNetworkDiagnostic>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<EdgeNetworkDiagnostic> CreateEdgeDiagnosticPingAsync(string edgeId, EdgeNetworkDiagnosticRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(edgeId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync($"/api/v2/telephony/providers/edges/{Uri.EscapeDataString(edgeId)}/diagnostic/ping", body, _options.JsonSerializerOptions, cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<EdgeNetworkDiagnostic>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<EdgeNetworkDiagnostic> CreateEdgeDiagnosticRouteAsync(string edgeId, EdgeNetworkDiagnosticRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(edgeId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync($"/api/v2/telephony/providers/edges/{Uri.EscapeDataString(edgeId)}/diagnostic/route", body, _options.JsonSerializerOptions, cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<EdgeNetworkDiagnostic>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<EdgeNetworkDiagnostic> CreateEdgeDiagnosticTracepathAsync(string edgeId, EdgeNetworkDiagnosticRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(edgeId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync($"/api/v2/telephony/providers/edges/{Uri.EscapeDataString(edgeId)}/diagnostic/tracepath", body, _options.JsonSerializerOptions, cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<EdgeNetworkDiagnostic>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task RebootPhonesAsync(PhonesReboot body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("/api/v2/telephony/providers/edges/phones/reboot", body, _options.JsonSerializerOptions, cancellationToken);
        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task<SitesSearchResponse> SearchSitesAsync(SiteSearchRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("/api/v2/telephony/providers/edges/sites/search", body, _options.JsonSerializerOptions, cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<SitesSearchResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<DomainLogicalInterface> CreateEdgeLogicalinterfaceAsync(string edgeId, DomainLogicalInterface body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(edgeId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync($"/api/v2/telephony/providers/edges/{Uri.EscapeDataString(edgeId)}/logicalinterfaces", body, _options.JsonSerializerOptions, cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DomainLogicalInterface>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<DomainLogicalInterface> UpdateEdgeLogicalinterfaceAsync(string edgeId, string interfaceId, DomainLogicalInterface body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(edgeId);
        ArgumentException.ThrowIfNullOrEmpty(interfaceId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync($"/api/v2/telephony/providers/edges/{Uri.EscapeDataString(edgeId)}/logicalinterfaces/{Uri.EscapeDataString(interfaceId)}", body, _options.JsonSerializerOptions, cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DomainLogicalInterface>(_options.JsonSerializerOptions, cancellationToken);
    }
}
