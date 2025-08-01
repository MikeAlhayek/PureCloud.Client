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
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly PureCloudJsonSerializerOptions _options;

    public ScriptsApi(
        IHttpClientFactory httpClientFactory,
        IOptions<PureCloudJsonSerializerOptions> options)
    {
        _httpClientFactory = httpClientFactory;
        _options = options.Value;
    }

    /// <inheritdoc />
    public async Task<Script> GetScriptAsync(string scriptId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(scriptId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/scripts/{Uri.EscapeDataString(scriptId)}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Script>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<ScriptEntityListing> GetScriptsAsync(int? pageSize = null, int? pageNumber = null, string expand = null, string name = null, string feature = null, string flowId = null, string sortBy = null, string sortOrder = null, string scriptDataVersion = null, string divisionIds = null, CancellationToken cancellationToken = default)
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

        if (!string.IsNullOrEmpty(expand))
        {
            parameters.Add("expand", UriHelper.ParameterToString(expand));
        }

        if (!string.IsNullOrEmpty(name))
        {
            parameters.Add("name", UriHelper.ParameterToString(name));
        }

        if (!string.IsNullOrEmpty(feature))
        {
            parameters.Add("feature", UriHelper.ParameterToString(feature));
        }

        if (!string.IsNullOrEmpty(flowId))
        {
            parameters.Add("flowId", UriHelper.ParameterToString(flowId));
        }

        if (!string.IsNullOrEmpty(sortBy))
        {
            parameters.Add("sortBy", UriHelper.ParameterToString(sortBy));
        }

        if (!string.IsNullOrEmpty(sortOrder))
        {
            parameters.Add("sortOrder", UriHelper.ParameterToString(sortOrder));
        }

        if (!string.IsNullOrEmpty(scriptDataVersion))
        {
            parameters.Add("scriptDataVersion", UriHelper.ParameterToString(scriptDataVersion));
        }

        if (!string.IsNullOrEmpty(divisionIds))
        {
            parameters.Add("divisionIds", UriHelper.ParameterToString(divisionIds));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/scripts", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ScriptEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<Page> GetScriptPageAsync(string scriptId, string pageId, string scriptDataVersion = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(scriptId);
        ArgumentException.ThrowIfNullOrEmpty(pageId);

        var parameters = new NameValueCollection();

        if (!string.IsNullOrEmpty(scriptDataVersion))
        {
            parameters.Add("scriptDataVersion", UriHelper.ParameterToString(scriptDataVersion));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/scripts/{Uri.EscapeDataString(scriptId)}/pages/{Uri.EscapeDataString(pageId)}", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Page>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<IEnumerable<Page>> GetScriptPagesAsync(string scriptId, string scriptDataVersion = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(scriptId);

        var parameters = new NameValueCollection();

        if (!string.IsNullOrEmpty(scriptDataVersion))
        {
            parameters.Add("scriptDataVersion", UriHelper.ParameterToString(scriptDataVersion));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/scripts/{Uri.EscapeDataString(scriptId)}/pages", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Page[]>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<ScriptEntityListing> GetScriptsDivisionviewsAsync(int? pageSize = null, int? pageNumber = null, string expand = null, string name = null, string feature = null, string flowId = null, string sortBy = null, string sortOrder = null, string scriptDataVersion = null, string divisionIds = null, CancellationToken cancellationToken = default)
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

        if (!string.IsNullOrEmpty(expand))
        {
            parameters.Add("expand", UriHelper.ParameterToString(expand));
        }

        if (!string.IsNullOrEmpty(name))
        {
            parameters.Add("name", UriHelper.ParameterToString(name));
        }

        if (!string.IsNullOrEmpty(feature))
        {
            parameters.Add("feature", UriHelper.ParameterToString(feature));
        }

        if (!string.IsNullOrEmpty(flowId))
        {
            parameters.Add("flowId", UriHelper.ParameterToString(flowId));
        }

        if (!string.IsNullOrEmpty(sortBy))
        {
            parameters.Add("sortBy", UriHelper.ParameterToString(sortBy));
        }

        if (!string.IsNullOrEmpty(sortOrder))
        {
            parameters.Add("sortOrder", UriHelper.ParameterToString(sortOrder));
        }

        if (!string.IsNullOrEmpty(scriptDataVersion))
        {
            parameters.Add("scriptDataVersion", UriHelper.ParameterToString(scriptDataVersion));
        }

        if (!string.IsNullOrEmpty(divisionIds))
        {
            parameters.Add("divisionIds", UriHelper.ParameterToString(divisionIds));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/scripts/divisionviews", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ScriptEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<ScriptEntityListing> GetScriptsPublishedAsync(int? pageSize = null, int? pageNumber = null, string expand = null, string name = null, string feature = null, string flowId = null, string scriptDataVersion = null, string divisionIds = null, CancellationToken cancellationToken = default)
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

        if (!string.IsNullOrEmpty(expand))
        {
            parameters.Add("expand", UriHelper.ParameterToString(expand));
        }

        if (!string.IsNullOrEmpty(name))
        {
            parameters.Add("name", UriHelper.ParameterToString(name));
        }

        if (!string.IsNullOrEmpty(feature))
        {
            parameters.Add("feature", UriHelper.ParameterToString(feature));
        }

        if (!string.IsNullOrEmpty(flowId))
        {
            parameters.Add("flowId", UriHelper.ParameterToString(flowId));
        }

        if (!string.IsNullOrEmpty(scriptDataVersion))
        {
            parameters.Add("scriptDataVersion", UriHelper.ParameterToString(scriptDataVersion));
        }

        if (!string.IsNullOrEmpty(divisionIds))
        {
            parameters.Add("divisionIds", UriHelper.ParameterToString(divisionIds));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/scripts/published", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ScriptEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<ScriptEntityListing> GetScriptsPublishedDivisionviewsAsync(int? pageSize = null, int? pageNumber = null, string expand = null, string name = null, string feature = null, string flowId = null, string scriptDataVersion = null, string divisionIds = null, CancellationToken cancellationToken = default)
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

        if (!string.IsNullOrEmpty(expand))
        {
            parameters.Add("expand", UriHelper.ParameterToString(expand));
        }

        if (!string.IsNullOrEmpty(name))
        {
            parameters.Add("name", UriHelper.ParameterToString(name));
        }

        if (!string.IsNullOrEmpty(feature))
        {
            parameters.Add("feature", UriHelper.ParameterToString(feature));
        }

        if (!string.IsNullOrEmpty(flowId))
        {
            parameters.Add("flowId", UriHelper.ParameterToString(flowId));
        }

        if (!string.IsNullOrEmpty(scriptDataVersion))
        {
            parameters.Add("scriptDataVersion", UriHelper.ParameterToString(scriptDataVersion));
        }

        if (!string.IsNullOrEmpty(divisionIds))
        {
            parameters.Add("divisionIds", UriHelper.ParameterToString(divisionIds));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/scripts/published/divisionviews", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ScriptEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<Script> GetScriptsPublishedScriptAsync(string scriptId, string scriptDataVersion = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(scriptId);

        var parameters = new NameValueCollection();

        if (!string.IsNullOrEmpty(scriptDataVersion))
        {
            parameters.Add("scriptDataVersion", UriHelper.ParameterToString(scriptDataVersion));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/scripts/published/{Uri.EscapeDataString(scriptId)}", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Script>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<Page> GetScriptsPublishedScriptPageAsync(string scriptId, string pageId, string scriptDataVersion = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(scriptId);
        ArgumentException.ThrowIfNullOrEmpty(pageId);

        var parameters = new NameValueCollection();

        if (!string.IsNullOrEmpty(scriptDataVersion))
        {
            parameters.Add("scriptDataVersion", UriHelper.ParameterToString(scriptDataVersion));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/scripts/published/{Uri.EscapeDataString(scriptId)}/pages/{Uri.EscapeDataString(pageId)}", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Page>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<IEnumerable<Page>> GetScriptsPublishedScriptPagesAsync(string scriptId, string scriptDataVersion = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(scriptId);

        var parameters = new NameValueCollection();

        if (!string.IsNullOrEmpty(scriptDataVersion))
        {
            parameters.Add("scriptDataVersion", UriHelper.ParameterToString(scriptDataVersion));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/scripts/published/{Uri.EscapeDataString(scriptId)}/pages", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Page[]>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<ScriptVariablesResponse> GetScriptsPublishedScriptVariablesAsync(string scriptId, string input = null, string output = null, string type = null, string scriptDataVersion = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(scriptId);

        var parameters = new NameValueCollection();

        if (!string.IsNullOrEmpty(input))
        {
            parameters.Add("input", UriHelper.ParameterToString(input));
        }

        if (!string.IsNullOrEmpty(output))
        {
            parameters.Add("output", UriHelper.ParameterToString(output));
        }

        if (!string.IsNullOrEmpty(type))
        {
            parameters.Add("type", UriHelper.ParameterToString(type));
        }

        if (!string.IsNullOrEmpty(scriptDataVersion))
        {
            parameters.Add("scriptDataVersion", UriHelper.ParameterToString(scriptDataVersion));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/scripts/published/{Uri.EscapeDataString(scriptId)}/variables", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        var variables = await response.Content.ReadFromJsonAsync<object>(_options.JsonSerializerOptions, cancellationToken);

        return new ScriptVariablesResponse { Variables = variables };
    }

    /// <inheritdoc />
    public async Task<ImportScriptStatusResponse> GetScriptsUploadStatusAsync(string uploadId, bool? longPoll = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(uploadId);

        var parameters = new NameValueCollection();

        if (longPoll.HasValue)
        {
            parameters.Add("longPoll", UriHelper.ParameterToString(longPoll.Value));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/scripts/uploads/{Uri.EscapeDataString(uploadId)}/status", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ImportScriptStatusResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<ExportScriptResponse> CreateScriptExportAsync(string scriptId, ExportScriptRequest body = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(scriptId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/scripts/{Uri.EscapeDataString(scriptId)}/export", null);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ExportScriptResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<Script> CreateScriptsPublishedAsync(string scriptDataVersion = null, PublishScriptRequestData body = null, CancellationToken cancellationToken = default)
    {
        var parameters = new NameValueCollection();

        if (!string.IsNullOrEmpty(scriptDataVersion))
        {
            parameters.Add("scriptDataVersion", UriHelper.ParameterToString(scriptDataVersion));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/scripts/published", parameters);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Script>(_options.JsonSerializerOptions, cancellationToken);
    }
}
