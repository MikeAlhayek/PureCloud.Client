using System.Collections.Specialized;
using System.Net.Http.Json;
using System.Text.Json;
using Microsoft.Extensions.Options;
using PureCloud.Client.Contracts;
using PureCloud.Client.Http;
using PureCloud.Client.Json;
using PureCloud.Client.Models;

namespace PureCloud.Client.Apis;

/// <inheritdoc />
public sealed class MobileDevicesApi : IMobileDevicesApi
{
    private readonly HttpClient _httpClient;
    private readonly JsonSerializerOptions _options;

    public MobileDevicesApi(IHttpClientFactory httpClientFactory, IOptions<PureCloudJsonSerializerOptions> options)
    {
        _httpClient = httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        _options = options.Value.JsonSerializerOptions;
    }

    /// <inheritdoc />
    public async Task DeleteMobileDeviceAsync(string deviceId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(nameof(deviceId), deviceId);

        var uri = UriHelper.GetUri($"/api/v2/mobiledevices/{deviceId}", null);

        var response = await _httpClient.DeleteAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task<UserDevice> GetMobileDeviceAsync(string deviceId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(nameof(deviceId), deviceId);

        var uri = UriHelper.GetUri($"/api/v2/mobiledevices/{deviceId}", null);

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<UserDevice>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<DirectoryUserDevicesListing> GetMobileDevicesAsync(int? pageSize = null, int? pageNumber = null, string sortOrder = null, CancellationToken cancellationToken = default)
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

        if (!string.IsNullOrEmpty(sortOrder))
        {
            parameters.Add("sortOrder", UriHelper.ParameterToString(sortOrder));
        }

        var uri = UriHelper.GetUri("/api/v2/mobiledevices", parameters);

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DirectoryUserDevicesListing>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<UserDevice> CreateMobileDeviceAsync(UserDevice body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body, nameof(body));

        var uri = UriHelper.GetUri("/api/v2/mobiledevices", null);

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<UserDevice>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<UserDevice> UpdateMobileDeviceAsync(string deviceId, UserDevice body = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(nameof(deviceId), deviceId);

        var uri = UriHelper.GetUri($"/api/v2/mobiledevices/{deviceId}", null);

        var response = await _httpClient.PutAsJsonAsync(uri, body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<UserDevice>(_options, cancellationToken);
    }
}