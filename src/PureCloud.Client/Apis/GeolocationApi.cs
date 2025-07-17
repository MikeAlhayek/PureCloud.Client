using System.Net.Http.Json;
using Microsoft.Extensions.Options;
using PureCloud.Client.Contracts;
using PureCloud.Client.Http;
using PureCloud.Client.Json;
using PureCloud.Client.Models;

namespace PureCloud.Client.Apis;

public sealed class GeolocationApi : IGeolocationApi
{
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly PureCloudJsonSerializerOptions _options;

    public GeolocationApi(
        IHttpClientFactory httpClientFactory,
        IOptions<PureCloudJsonSerializerOptions> options)
    {
        _httpClientFactory = httpClientFactory;
        _options = options.Value;
    }

    public async Task<GeolocationSettings> GetGeolocationsSettingsAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync("api/v2/geolocations/settings", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<GeolocationSettings>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<Geolocation> GetUserGeolocationAsync(string userId, string clientId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(userId);

        ArgumentException.ThrowIfNullOrEmpty(clientId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/users/{UriHelper.ParameterToString(userId)}/geolocations/{UriHelper.ParameterToString(clientId)}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Geolocation>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<GeolocationSettings> UpdateGeolocationsSettingsAsync(GeolocationSettings body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PatchAsJsonAsync("api/v2/geolocations/settings", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<GeolocationSettings>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<Geolocation> PatchUserGeolocationAsync(string userId, string clientId, Geolocation body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(userId);

        ArgumentException.ThrowIfNullOrEmpty(clientId);

        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PatchAsJsonAsync($"api/v2/users/{UriHelper.ParameterToString(userId)}/geolocations/{UriHelper.ParameterToString(clientId)}", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Geolocation>(_options.JsonSerializerOptions, cancellationToken);
    }

}
