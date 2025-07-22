using System.Net.Http.Json;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Options;
using PureCloud.Client.Contracts;
using PureCloud.Client.Http;
using PureCloud.Client.Json;
using PureCloud.Client.Models;

namespace PureCloud.Client.Apis;

public class LogCaptureApi : ILogCaptureApi
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

    public async Task<LogCaptureUserConfiguration> GetLogCaptureUserConfigurationAsync(string userId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(userId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = $"api/v2/diagnostics/logcapture/browser/users/{userId}";

        var response = await client.GetAsync(uri, cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<LogCaptureUserConfiguration>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<PagelessEntityListing> GetLogCaptureUsersAsync(bool? includeExpired = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = "api/v2/diagnostics/logcapture/browser/users";

        if (includeExpired.HasValue)
        {
            var queryParameters = new List<KeyValuePair<string, string>>
            {
                new("includeExpired", UriHelper.ParameterToString(includeExpired.Value))
            };

            uri = QueryHelpers.AddQueryString(uri, queryParameters);
        }

        var response = await client.GetAsync(uri, cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<PagelessEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<LogCaptureDownloadExecutionResponse> GetLogCaptureDownloadJobAsync(string jobId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(jobId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = $"api/v2/diagnostics/logcapture/browser/entries/download/jobs/{jobId}";

        var response = await client.GetAsync(uri, cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<LogCaptureDownloadExecutionResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<LogCaptureDownloadExecutionResponse> CreateLogCaptureDownloadJobAsync(LogCaptureQueryRequest body = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = "api/v2/diagnostics/logcapture/browser/entries/download/jobs";

        var content = body != null ? JsonContent.Create(body, options: _options.JsonSerializerOptions) : null;

        var response = await client.PostAsync(uri, content, cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<LogCaptureDownloadExecutionResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<LogCaptureQueryResponse> CreateLogCaptureQueryAsync(string before = null, string after = null, string pageSize = null, LogCaptureQueryRequest body = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = "api/v2/diagnostics/logcapture/browser/entries/query";

        var queryParameters = new List<KeyValuePair<string, string>>();

        if (!string.IsNullOrEmpty(before))
        {
            queryParameters.Add(new KeyValuePair<string, string>("before", UriHelper.ParameterToString(before)));
        }

        if (!string.IsNullOrEmpty(after))
        {
            queryParameters.Add(new KeyValuePair<string, string>("after", UriHelper.ParameterToString(after)));
        }

        if (!string.IsNullOrEmpty(pageSize))
        {
            queryParameters.Add(new KeyValuePair<string, string>("pageSize", UriHelper.ParameterToString(pageSize)));
        }

        if (queryParameters.Count > 0)
        {
            uri = QueryHelpers.AddQueryString(uri, queryParameters);
        }

        var content = body != null ? JsonContent.Create(body, options: _options.JsonSerializerOptions) : null;

        var response = await client.PostAsync(uri, content, cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<LogCaptureQueryResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task DeleteLogCaptureUserAsync(string userId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(userId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = $"api/v2/diagnostics/logcapture/browser/users/{userId}";

        var response = await client.DeleteAsync(uri, cancellationToken);
        response.EnsureSuccessStatusCode();
    }

    public async Task<LogCaptureUserConfiguration> CreateLogCaptureUserAsync(string userId, LogCaptureUserConfiguration body = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(userId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = $"api/v2/diagnostics/logcapture/browser/users/{userId}";

        var content = body != null ? JsonContent.Create(body, options: _options.JsonSerializerOptions) : null;

        var response = await client.PostAsync(uri, content, cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<LogCaptureUserConfiguration>(_options.JsonSerializerOptions, cancellationToken);
    }
}