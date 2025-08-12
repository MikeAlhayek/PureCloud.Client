using System.Collections.Specialized;
using System.Net.Http.Json;
using Microsoft.Extensions.Options;
using PureCloud.Client.Contracts;
using PureCloud.Client.Http;
using PureCloud.Client.Json;
using PureCloud.Client.Models;

namespace PureCloud.Client.Apis;

/// <inheritdoc />
public sealed class LogCaptureApi : ILogCaptureApi
{
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly PureCloudJsonSerializerOptions _options;

    public LogCaptureApi(
        IHttpClientFactory httpClientFactory,
        IOptions<PureCloudJsonSerializerOptions> options)
    {
        _httpClientFactory = httpClientFactory;
        _options = options.Value;
    }

    /// <inheritdoc />
    public async Task<bool> DeleteDiagnosticsLogcaptureBrowserUserAsync(string userId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(userId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/diagnostics/logcapture/browser/users/{Uri.EscapeDataString(userId)}", cancellationToken);

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    public async Task<LogCaptureDownloadExecutionResponse> GetDiagnosticsLogcaptureBrowserEntriesDownloadJobAsync(string jobId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(jobId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/diagnostics/logcapture/browser/entries/download/jobs/{Uri.EscapeDataString(jobId)}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<LogCaptureDownloadExecutionResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<LogCaptureUserConfiguration> GetDiagnosticsLogcaptureBrowserUserAsync(string userId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(userId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/diagnostics/logcapture/browser/users/{Uri.EscapeDataString(userId)}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<LogCaptureUserConfiguration>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<PagelessEntityListing> GetDiagnosticsLogcaptureBrowserUsersAsync(bool? includeExpired = null, CancellationToken cancellationToken = default)
    {
        var parameters = new NameValueCollection();

        if (includeExpired.HasValue)
        {
            parameters.Add("includeExpired", UriHelper.ParameterToString(includeExpired.Value));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/diagnostics/logcapture/browser/users", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<PagelessEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<LogCaptureDownloadExecutionResponse> CreateDiagnosticsLogcaptureBrowserEntriesDownloadJobsAsync(LogCaptureQueryRequest body = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/diagnostics/logcapture/browser/entries/download/jobs", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<LogCaptureDownloadExecutionResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<LogCaptureQueryResponse> CreateDiagnosticsLogcaptureBrowserEntriesQueryAsync(string before = null, string after = null, string pageSize = null, LogCaptureQueryRequest body = null, CancellationToken cancellationToken = default)
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

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/diagnostics/logcapture/browser/entries/query", parameters);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<LogCaptureQueryResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<LogCaptureUserConfiguration> CreateDiagnosticsLogcaptureBrowserUserAsync(string userId, LogCaptureUserConfiguration body = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(userId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync($"api/v2/diagnostics/logcapture/browser/users/{Uri.EscapeDataString(userId)}", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<LogCaptureUserConfiguration>(_options.JsonSerializerOptions, cancellationToken);
    }
}
