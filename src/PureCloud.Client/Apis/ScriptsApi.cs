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
public sealed class ScriptsApi : IScriptsApi
{
    private readonly HttpClient _httpClient;
    private readonly JsonSerializerOptions _options;

    public ScriptsApi(IHttpClientFactory httpClientFactory, IOptions<PureCloudJsonSerializerOptions> options)
    {
        _httpClient = httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        _options = options.Value.JsonSerializerOptions;
    }

    /// <inheritdoc />
    public async Task<Script> GetScriptAsync(string scriptId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(nameof(scriptId), scriptId);

        var uri = UriHelper.GetUri($"/api/v2/scripts/{scriptId}", null);

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Script>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<ScriptEntityListing> GetScriptsAsync(int? pageSize = null, int? pageNumber = null, string expand = null, string name = null, string feature = null, string flowId = null, string sortBy = null, string sortOrder = null, string scriptDataVersion = null, string divisionIds = null, CancellationToken cancellationToken = default)
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

        if (!string.IsNullOrEmpty(expand))
        {
            parameters.Add("expand", expand);
        }

        if (!string.IsNullOrEmpty(name))
        {
            parameters.Add("name", name);
        }

        if (!string.IsNullOrEmpty(feature))
        {
            parameters.Add("feature", feature);
        }

        if (!string.IsNullOrEmpty(flowId))
        {
            parameters.Add("flowId", flowId);
        }

        if (!string.IsNullOrEmpty(sortBy))
        {
            parameters.Add("sortBy", sortBy);
        }

        if (!string.IsNullOrEmpty(sortOrder))
        {
            parameters.Add("sortOrder", sortOrder);
        }

        if (!string.IsNullOrEmpty(scriptDataVersion))
        {
            parameters.Add("scriptDataVersion", scriptDataVersion);
        }

        if (!string.IsNullOrEmpty(divisionIds))
        {
            parameters.Add("divisionIds", divisionIds);
        }

        var uri = UriHelper.GetUri("/api/v2/scripts", parameters.Count > 0 ? parameters : null);

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ScriptEntityListing>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<ExportScriptResponse> CreateScriptExportAsync(string scriptId, ExportScriptRequest body = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(nameof(scriptId), scriptId);

        var uri = UriHelper.GetUri($"/api/v2/scripts/{scriptId}/export", null);

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ExportScriptResponse>(_options, cancellationToken);
    }
}