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
    private readonly HttpClient _httpClient;
    private readonly PureCloudJsonSerializerOptions _options;

    public TelephonyProvidersEdgeApi(IHttpClientFactory httpClientFactory, IOptions<PureCloudJsonSerializerOptions> options)
    {
        _httpClient = httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        _options = options.Value;
    }

    /// <inheritdoc />

    public async Task<Edge> GetEdgeAsync(string edgeId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(nameof(edgeId), edgeId);

        var uri = UriHelper.GetUri($"/api/v2/telephony/providers/edges/{edgeId}", null);
        var response = await _httpClient.GetAsync(uri, cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Edge>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />

    public async Task DeleteEdgeAsync(string edgeId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(nameof(edgeId), edgeId);

        var uri = UriHelper.GetUri($"/api/v2/telephony/providers/edges/{edgeId}", null);
        var response = await _httpClient.DeleteAsync(uri, cancellationToken);
        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />

    public async Task<EdgeEntityListing> GetEdgesAsync(CancellationToken cancellationToken = default)
    {
        var uri = UriHelper.GetUri("/api/v2/telephony/providers/edges", null);
        var response = await _httpClient.GetAsync(uri, cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<EdgeEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<Edge> CreateEdgeAsync(Edge body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body, nameof(body));

        var uri = UriHelper.GetUri("/api/v2/telephony/providers/edges", null);
        var response = await _httpClient.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Edge>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<Edge> UpdateEdgeAsync(string edgeId, Edge body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(nameof(edgeId), edgeId);

        ArgumentNullException.ThrowIfNull(body, nameof(body));

        var uri = UriHelper.GetUri($"/api/v2/telephony/providers/edges/{edgeId}", null);
        var response = await _httpClient.PutAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);
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
        ArgumentException.ThrowIfNullOrEmpty(nameof(extensionPoolId), extensionPoolId);

        var uri = UriHelper.GetUri($"/api/v2/telephony/providers/edges/extensionpools/{extensionPoolId}", null);
        var response = await _httpClient.DeleteAsync(uri, cancellationToken);
        response.EnsureSuccessStatusCode();
    }
}