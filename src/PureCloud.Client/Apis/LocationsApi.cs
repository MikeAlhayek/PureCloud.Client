using System.Collections.Specialized;
using System.Net.Http.Json;
using System.Text.Json;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Options;
using PureCloud.Client.Contracts;
using PureCloud.Client.Http;
using PureCloud.Client.Json;
using PureCloud.Client.Models.Locations;

namespace PureCloud.Client.Apis;

/// <inheritdoc />
public sealed class LocationsApi : ILocationsApi
{
    private readonly HttpClient _httpClient;
    private readonly JsonSerializerOptions _options;

    public LocationsApi(IHttpClientFactory httpClientFactory, IOptions<PureCloudJsonSerializerOptions> options)
    {
        _httpClient = httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        _options = options.Value.JsonSerializerOptions;
    }

    /// <inheritdoc />
    public async Task DeleteLocationAsync(string locationId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(locationId);

        var response = await _httpClient.DeleteAsync($"api/v2/locations/{locationId}", cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task<LocationDefinition> GetLocationAsync(string locationId, IEnumerable<string> expand = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(locationId);

        var uri = $"api/v2/locations/{locationId}";

        if (expand != null)
        {
            var queryParameters = new List<KeyValuePair<string, string>>();
            foreach (var item in expand)
            {
                queryParameters.Add(new KeyValuePair<string, string>("expand", UriHelper.ParameterToString(item)));
            }
            uri = QueryHelpers.AddQueryString(uri, queryParameters);
        }

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<LocationDefinition>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<LocationEntityListing> GetLocationSublocationsAsync(string locationId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(locationId);

        var response = await _httpClient.GetAsync($"api/v2/locations/{locationId}/sublocations", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<LocationEntityListing>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<LocationEntityListing> GetLocationsAsync(int? pageSize = null, int? pageNumber = null, IEnumerable<string> id = null, string sortOrder = null, CancellationToken cancellationToken = default)
    {
        var uri = "api/v2/locations";
        var queryParameters = new List<KeyValuePair<string, string>>();

        if (pageSize.HasValue)
        {
            queryParameters.Add(new KeyValuePair<string, string>("pageSize", UriHelper.ParameterToString(pageSize.Value)));
        }

        if (pageNumber.HasValue)
        {
            queryParameters.Add(new KeyValuePair<string, string>("pageNumber", UriHelper.ParameterToString(pageNumber.Value)));
        }

        if (id != null)
        {
            foreach (var item in id)
            {
                queryParameters.Add(new KeyValuePair<string, string>("id", UriHelper.ParameterToString(item)));
            }
        }

        if (!string.IsNullOrEmpty(sortOrder))
        {
            queryParameters.Add(new KeyValuePair<string, string>("sortOrder", UriHelper.ParameterToString(sortOrder)));
        }

        if (queryParameters.Count > 0)
        {
            uri = QueryHelpers.AddQueryString(uri, queryParameters);
        }

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<LocationEntityListing>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<LocationsSearchResponse> GetLocationsSearchAsync(string q64, IEnumerable<string> expand = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(q64);

        var uri = "api/v2/locations/search";
        var queryParameters = new List<KeyValuePair<string, string>>
        {
            new("q64", q64)
        };

        if (expand != null)
        {
            foreach (var item in expand)
            {
                queryParameters.Add(new KeyValuePair<string, string>("expand", UriHelper.ParameterToString(item)));
            }
        }

        uri = QueryHelpers.AddQueryString(uri, queryParameters);

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<LocationsSearchResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<LocationDefinition> UpdateLocationAsync(string locationId, LocationUpdateDefinition body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(locationId);
        ArgumentNullException.ThrowIfNull(body);

        var response = await _httpClient.PatchAsJsonAsync($"api/v2/locations/{locationId}", body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<LocationDefinition>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<LocationDefinition> CreateLocationAsync(LocationCreateDefinition body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var response = await _httpClient.PostAsJsonAsync("api/v2/locations", body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<LocationDefinition>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<LocationsSearchResponse> CreateLocationsSearchAsync(LocationSearchRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var response = await _httpClient.PostAsJsonAsync("api/v2/locations/search", body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<LocationsSearchResponse>(_options, cancellationToken);
    }
}