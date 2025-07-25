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
public sealed class UserRecordingsApi : IUserRecordingsApi
{
    private readonly HttpClient _httpClient;
    private readonly JsonSerializerOptions _options;

    public UserRecordingsApi(IHttpClientFactory httpClientFactory, IOptions<PureCloudJsonSerializerOptions> options)
    {
        _httpClient = httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        _options = options.Value.JsonSerializerOptions;
    }

    /// <inheritdoc />
    public async Task DeleteUserRecordingAsync(string recordingId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(recordingId, nameof(recordingId));

        var uri = UriHelper.GetUri($"/api/v2/userrecordings/{recordingId}", null);

        var response = await _httpClient.DeleteAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task<UserRecording> GetUserRecordingAsync(string recordingId, IEnumerable<string> expand = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(recordingId, nameof(recordingId));

        var parameters = new NameValueCollection();

        if (expand != null)
        {
            foreach (var item in expand)
            {
                parameters.Add("expand", item);
            }
        }

        var uri = UriHelper.GetUri($"/api/v2/userrecordings/{recordingId}", parameters);

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<UserRecording>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<UserRecordingEntityListing> GetUserRecordingsAsync(int? pageSize = null, int? pageNumber = null, IEnumerable<string> expand = null, CancellationToken cancellationToken = default)
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

        if (expand != null)
        {
            foreach (var item in expand)
            {
                parameters.Add("expand", item);
            }
        }

        var uri = UriHelper.GetUri("/api/v2/userrecordings", parameters);

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<UserRecordingEntityListing>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<FaxSummary> GetUserRecordingsSummaryAsync(CancellationToken cancellationToken = default)
    {
        var uri = UriHelper.GetUri("/api/v2/userrecordings/summary", null);

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<FaxSummary>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<UserRecording> UpdateUserRecordingAsync(string recordingId, UserRecording body, IEnumerable<string> expand = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(recordingId, nameof(recordingId));

        ArgumentNullException.ThrowIfNull(body, nameof(body));

        var parameters = new NameValueCollection();

        if (expand != null)
        {
            foreach (var item in expand)
            {
                parameters.Add("expand", item);
            }
        }

        var uri = UriHelper.GetUri($"/api/v2/userrecordings/{recordingId}", parameters);

        var response = await _httpClient.PutAsJsonAsync(uri, body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<UserRecording>(_options, cancellationToken);
    }
}