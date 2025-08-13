using System.Collections.Specialized;
using System.Net.Http.Json;
using Microsoft.Extensions.Options;
using PureCloud.Client.Contracts;
using PureCloud.Client.Http;
using PureCloud.Client.Json;
using PureCloud.Client.Models;

namespace PureCloud.Client.Apis;

/// <inheritdoc />
public sealed class StationsApi : IStationsApi
{
    private readonly HttpClient _httpClient;
    private readonly PureCloudJsonSerializerOptions _options;

    public StationsApi(IHttpClientFactory httpClientFactory, IOptions<PureCloudJsonSerializerOptions> options)
    {
        _httpClient = httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        _options = options.Value;
    }

    /// <inheritdoc />
    public async Task<bool> DeleteStationAssociatedUserAsync(string stationId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(stationId);

        var uri = $"api/v2/stations/{Uri.EscapeDataString(stationId)}/associateduser";

        var response = await _httpClient.DeleteAsync(uri, cancellationToken);

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    public async Task<Station> GetStationAsync(string stationId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(stationId);

        var uri = $"api/v2/stations/{Uri.EscapeDataString(stationId)}";

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Station>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<StationEntityListing> GetStationsAsync(int? pageSize = null, int? pageNumber = null, string sortBy = null, string name = null, string userSelectable = null, string webRtcUserId = null, string id = null, string lineAppearanceId = null, CancellationToken cancellationToken = default)
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

        if (!string.IsNullOrEmpty(sortBy))
        {
            parameters.Add("sortBy", UriHelper.ParameterToString(sortBy));
        }

        if (!string.IsNullOrEmpty(name))
        {
            parameters.Add("name", UriHelper.ParameterToString(name));
        }

        if (!string.IsNullOrEmpty(userSelectable))
        {
            parameters.Add("userSelectable", UriHelper.ParameterToString(userSelectable));
        }

        if (!string.IsNullOrEmpty(webRtcUserId))
        {
            parameters.Add("webRtcUserId", UriHelper.ParameterToString(webRtcUserId));
        }

        if (!string.IsNullOrEmpty(id))
        {
            parameters.Add("id", UriHelper.ParameterToString(id));
        }

        if (!string.IsNullOrEmpty(lineAppearanceId))
        {
            parameters.Add("lineAppearanceId", UriHelper.ParameterToString(lineAppearanceId));
        }

        var uri = parameters.Count > 0 ? UriHelper.GetUri("api/v2/stations", parameters) : "api/v2/stations";

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<StationEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }
}