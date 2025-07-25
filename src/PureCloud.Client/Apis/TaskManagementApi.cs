using System.Collections.Specialized;
using System.Net.Http.Json;
using Microsoft.Extensions.Options;
using PureCloud.Client.Contracts;
using PureCloud.Client.Http;
using PureCloud.Client.Json;
using PureCloud.Client.Models;

namespace PureCloud.Client.Apis;

/// <inheritdoc />
public sealed class TaskManagementApi : ITaskManagementApi
{
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly PureCloudJsonSerializerOptions _options;

    public TaskManagementApi(
        IHttpClientFactory httpClientFactory,
        IOptions<PureCloudJsonSerializerOptions> options)
    {
        _httpClientFactory = httpClientFactory;
        _options = options.Value;
    }

    /// <inheritdoc />
    public async Task<Workbin> GetWorkbinAsync(string workbinId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(workbinId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/taskmanagement/workbins/{workbinId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Workbin>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<Workitem> GetWorkitemAsync(string workitemId, string expands = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(workitemId);

        var parameters = new NameValueCollection();

        if (!string.IsNullOrEmpty(expands))
        {
            parameters.Add("expands", UriHelper.ParameterToString(expands));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/taskmanagement/workitems/{workitemId}", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Workitem>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<Worktype> GetWorktypeAsync(string worktypeId, IEnumerable<string> expands = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(worktypeId);

        var parameters = new NameValueCollection();

        if (expands != null)
        {
            parameters.Add("expands", UriHelper.ParameterToString(expands));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/taskmanagement/worktypes/{worktypeId}", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Worktype>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<Workbin> CreateWorkbinAsync(WorkbinCreate body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/taskmanagement/workbins", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Workbin>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<Workitem> CreateWorkitemAsync(WorkitemCreate body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/taskmanagement/workitems", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Workitem>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<Worktype> CreateWorktypeAsync(WorktypeCreate body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/taskmanagement/worktypes", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Worktype>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<Workbin> UpdateWorkbinAsync(string workbinId, WorkbinUpdate body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(workbinId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PatchAsJsonAsync($"api/v2/taskmanagement/workbins/{workbinId}", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Workbin>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<Workitem> UpdateWorkitemAsync(string workitemId, WorkitemUpdate body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(workitemId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PatchAsJsonAsync($"api/v2/taskmanagement/workitems/{workitemId}", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Workitem>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<Worktype> UpdateWorktypeAsync(string worktypeId, WorktypeUpdate body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(worktypeId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PatchAsJsonAsync($"api/v2/taskmanagement/worktypes/{worktypeId}", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Worktype>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task DeleteWorkbinAsync(string workbinId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(workbinId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/taskmanagement/workbins/{workbinId}", cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task DeleteWorkitemAsync(string workitemId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(workitemId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/taskmanagement/workitems/{workitemId}", cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task DeleteWorktypeAsync(string worktypeId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(worktypeId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/taskmanagement/worktypes/{worktypeId}", cancellationToken);

        response.EnsureSuccessStatusCode();
    }
}
