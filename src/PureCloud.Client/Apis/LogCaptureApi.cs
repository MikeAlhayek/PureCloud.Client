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
public sealed class LogCaptureApi : ILogCaptureApi
{
    private readonly HttpClient _httpClient;
    private readonly JsonSerializerOptions _options;

    public LogCaptureApi(IHttpClientFactory httpClientFactory, IOptions<PureCloudJsonSerializerOptions> options)
    {
        _httpClient = httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        _options = options.Value.JsonSerializerOptions;
    }

    /// <inheritdoc />
    public async Task DeleteLogCaptureBrowserUserAsync(string userId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(userId);

        var uri = UriHelper.GetUri($"/api/v2/diagnostics/logcapture/browser/users/{userId}", null);

        var response = await _httpClient.DeleteAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task<LogCaptureDownloadExecutionResponse> GetLogCaptureDownloadJobAsync(string jobId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(jobId);

        var uri = UriHelper.GetUri($"/api/v2/diagnostics/logcapture/browser/entries/download/jobs/{jobId}", null);

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<LogCaptureDownloadExecutionResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<LogCaptureUserConfiguration> GetLogCaptureBrowserUserAsync(string userId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(userId);

        var uri = UriHelper.GetUri($"/api/v2/diagnostics/logcapture/browser/users/{userId}", null);

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<LogCaptureUserConfiguration>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<PagelessEntityListing> GetLogCaptureBrowserUsersAsync(bool? includeExpired = null, CancellationToken cancellationToken = default)
    {
        var parameters = new NameValueCollection();

        if (includeExpired.HasValue)
        {
            parameters.Add("includeExpired", UriHelper.ParameterToString(includeExpired.Value));
        }

        var uri = UriHelper.GetUri("/api/v2/diagnostics/logcapture/browser/users", parameters);

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<PagelessEntityListing>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<LogCaptureDownloadExecutionResponse> CreateLogCaptureDownloadJobAsync(LogCaptureQueryRequest body = null, CancellationToken cancellationToken = default)
    {
        var uri = UriHelper.GetUri("/api/v2/diagnostics/logcapture/browser/entries/download/jobs", null);

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<LogCaptureDownloadExecutionResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<LogCaptureQueryResponse> CreateLogCaptureEntriesQueryAsync(string before = null, string after = null, string pageSize = null, LogCaptureQueryRequest body = null, CancellationToken cancellationToken = default)
    {
        var parameters = new NameValueCollection();

        if (!string.IsNullOrEmpty(before))
        {
            parameters.Add("before", UriHelper.ParameterToString(before));
        }

        if (!string.IsNullOrEmpty(after))
        {
            parameters.Add("after", UriHelper.ParameterToString(after));
        }

        if (!string.IsNullOrEmpty(pageSize))
        {
            parameters.Add("pageSize", UriHelper.ParameterToString(pageSize));
        }

        var uri = UriHelper.GetUri("/api/v2/diagnostics/logcapture/browser/entries/query", parameters);

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<LogCaptureQueryResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<LogCaptureUserConfiguration> CreateLogCaptureBrowserUserAsync(string userId, LogCaptureUserConfiguration body = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(userId);

        var uri = UriHelper.GetUri($"/api/v2/diagnostics/logcapture/browser/users/{userId}", null);

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<LogCaptureUserConfiguration>(_options, cancellationToken);
    }
}
