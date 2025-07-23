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
public sealed class OrganizationAuthorizationApi : IOrganizationAuthorizationApi
{
    private readonly HttpClient _httpClient;
    private readonly JsonSerializerOptions _options;

    public OrganizationAuthorizationApi(IHttpClientFactory httpClientFactory, IOptions<PureCloudJsonSerializerOptions> options)
    {
        _httpClient = httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        _options = options.Value.JsonSerializerOptions;
    }

    /// <inheritdoc />
    public async Task<TrustEntityListing> GetTrusteesAsync(int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default)
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

        var uri = UriHelper.GetUri("api/v2/orgauthorization/trustees", parameters);

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<TrustEntityListing>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<Trustee> GetTrusteeAsync(string trusteeOrgId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(trusteeOrgId);

        var uri = UriHelper.GetUri($"api/v2/orgauthorization/trustees/{trusteeOrgId}", null);

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Trustee>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<Trustee> CreateTrusteeAsync(TrustCreate body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri("api/v2/orgauthorization/trustees", null);

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Trustee>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<Trustee> UpdateTrusteeAsync(string trusteeOrgId, TrustUpdate body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(trusteeOrgId);
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri($"api/v2/orgauthorization/trustees/{trusteeOrgId}", null);

        var response = await _httpClient.PutAsJsonAsync(uri, body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Trustee>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task DeleteTrusteeAsync(string trusteeOrgId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(trusteeOrgId);

        var uri = UriHelper.GetUri($"api/v2/orgauthorization/trustees/{trusteeOrgId}", null);

        var response = await _httpClient.DeleteAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task<TrustorEntityListing> GetTrustorsAsync(int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default)
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

        var uri = UriHelper.GetUri("api/v2/orgauthorization/trustors", parameters);

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<TrustorEntityListing>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<Trustor> GetTrustorAsync(string trustorOrgId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(trustorOrgId);

        var uri = UriHelper.GetUri($"api/v2/orgauthorization/trustors/{trustorOrgId}", null);

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Trustor>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task DeleteTrustorAsync(string trustorOrgId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(trustorOrgId);

        var uri = UriHelper.GetUri($"api/v2/orgauthorization/trustors/{trustorOrgId}", null);

        var response = await _httpClient.DeleteAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task<TrustRequest> GetPairingAsync(string pairingId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(pairingId);

        var uri = UriHelper.GetUri($"api/v2/orgauthorization/pairings/{pairingId}", null);

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<TrustRequest>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<TrustRequest> CreatePairingAsync(TrustRequestCreate body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri("api/v2/orgauthorization/pairings", null);

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<TrustRequest>(_options, cancellationToken);
    }
}