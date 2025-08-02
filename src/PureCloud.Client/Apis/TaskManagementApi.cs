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

        var response = await client.GetAsync($"api/v2/taskmanagement/workbins/{Uri.EscapeDataString(workbinId)}", cancellationToken);

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

        var uri = UriHelper.GetUri($"api/v2/taskmanagement/workitems/{Uri.EscapeDataString(workitemId)}", parameters);

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

        var uri = UriHelper.GetUri($"api/v2/taskmanagement/worktypes/{Uri.EscapeDataString(worktypeId)}", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Worktype>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<DataSchema> GetWorkitemsSchemaAsync(string schemaId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(schemaId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/taskmanagement/workitems/schemas/{Uri.EscapeDataString(schemaId)}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DataSchema>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<DataSchemaListing> GetWorkitemsSchemasAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync("api/v2/taskmanagement/workitems/schemas", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DataSchemaListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<Coretype> GetWorkitemsSchemasCoretypeAsync(string coreTypeName, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(coreTypeName);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/taskmanagement/workitems/schemas/coretypes/{Uri.EscapeDataString(coreTypeName)}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Coretype>(_options.JsonSerializerOptions, cancellationToken);
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
    public async Task<DataSchema> CreateWorkitemsSchemaAsync(DataSchema body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/taskmanagement/workitems/schemas", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DataSchema>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<Workbin> UpdateWorkbinAsync(string workbinId, WorkbinUpdate body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(workbinId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PatchAsJsonAsync($"api/v2/taskmanagement/workbins/{Uri.EscapeDataString(workbinId)}", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Workbin>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<Workitem> UpdateWorkitemAsync(string workitemId, WorkitemUpdate body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(workitemId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PatchAsJsonAsync($"api/v2/taskmanagement/workitems/{Uri.EscapeDataString(workitemId)}", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Workitem>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<Worktype> UpdateWorktypeAsync(string worktypeId, WorktypeUpdate body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(worktypeId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PatchAsJsonAsync($"api/v2/taskmanagement/worktypes/{Uri.EscapeDataString(worktypeId)}", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Worktype>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<DataSchema> UpdateWorkitemsSchemaAsync(string schemaId, DataSchema body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(schemaId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync($"api/v2/taskmanagement/workitems/schemas/{Uri.EscapeDataString(schemaId)}", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DataSchema>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<bool> DeleteWorkbinAsync(string workbinId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(workbinId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/taskmanagement/workbins/{Uri.EscapeDataString(workbinId)}", cancellationToken);

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    public async Task<bool> DeleteWorkitemAsync(string workitemId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(workitemId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/taskmanagement/workitems/{Uri.EscapeDataString(workitemId)}", cancellationToken);

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    public async Task<bool> DeleteWorktypeAsync(string worktypeId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(worktypeId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/taskmanagement/worktypes/{Uri.EscapeDataString(worktypeId)}", cancellationToken);

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    public async Task<bool> DeleteWorkitemsSchemaAsync(string schemaId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(schemaId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/taskmanagement/workitems/schemas/{Uri.EscapeDataString(schemaId)}", cancellationToken);

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    public async Task<SchemaQuantityLimits> GetWorkitemsSchemasLimitsAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync("api/v2/taskmanagement/workitems/schemas/limits", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<SchemaQuantityLimits>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<WorkbinChangeListing> GetWorkbinHistoryAsync(string workbinId, string after = null, int? pageSize = null, string sortOrder = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(workbinId);

        var parameters = new NameValueCollection();

        if (!string.IsNullOrEmpty(after))
        {
            parameters.Add("after", UriHelper.ParameterToString(after));
        }

        if (pageSize.HasValue)
        {
            parameters.Add("pageSize", UriHelper.ParameterToString(pageSize.Value));
        }

        if (!string.IsNullOrEmpty(sortOrder))
        {
            parameters.Add("sortOrder", UriHelper.ParameterToString(sortOrder));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/taskmanagement/workbins/{Uri.EscapeDataString(workbinId)}/history", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<WorkbinChangeListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<WorkbinVersion> GetWorkbinVersionAsync(string workbinId, int? entityVersion, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(workbinId);
        ArgumentNullException.ThrowIfNull(entityVersion);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/taskmanagement/workbins/{Uri.EscapeDataString(workbinId)}/versions/{entityVersion}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<WorkbinVersion>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<WorkbinVersionListing> GetWorkbinVersionsAsync(string workbinId, string after = null, int? pageSize = null, string sortOrder = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(workbinId);

        var parameters = new NameValueCollection();

        if (!string.IsNullOrEmpty(after))
        {
            parameters.Add("after", UriHelper.ParameterToString(after));
        }

        if (pageSize.HasValue)
        {
            parameters.Add("pageSize", UriHelper.ParameterToString(pageSize.Value));
        }

        if (!string.IsNullOrEmpty(sortOrder))
        {
            parameters.Add("sortOrder", UriHelper.ParameterToString(sortOrder));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/taskmanagement/workbins/{Uri.EscapeDataString(workbinId)}/versions", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<WorkbinVersionListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<WorkitemChangeListing> GetWorkitemHistoryAsync(string workitemId, string after = null, int? pageSize = null, string sortOrder = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(workitemId);

        var parameters = new NameValueCollection();

        if (!string.IsNullOrEmpty(after))
        {
            parameters.Add("after", UriHelper.ParameterToString(after));
        }

        if (pageSize.HasValue)
        {
            parameters.Add("pageSize", UriHelper.ParameterToString(pageSize.Value));
        }

        if (!string.IsNullOrEmpty(sortOrder))
        {
            parameters.Add("sortOrder", UriHelper.ParameterToString(sortOrder));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/taskmanagement/workitems/{Uri.EscapeDataString(workitemId)}/history", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<WorkitemChangeListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<WorkitemVersion> GetWorkitemVersionAsync(string workitemId, int? entityVersion, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(workitemId);
        ArgumentNullException.ThrowIfNull(entityVersion);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/taskmanagement/workitems/{Uri.EscapeDataString(workitemId)}/versions/{entityVersion}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<WorkitemVersion>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<WorkitemVersionListing> GetWorkitemVersionsAsync(string workitemId, string after = null, int? pageSize = null, string sortOrder = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(workitemId);

        var parameters = new NameValueCollection();

        if (!string.IsNullOrEmpty(after))
        {
            parameters.Add("after", UriHelper.ParameterToString(after));
        }

        if (pageSize.HasValue)
        {
            parameters.Add("pageSize", UriHelper.ParameterToString(pageSize.Value));
        }

        if (!string.IsNullOrEmpty(sortOrder))
        {
            parameters.Add("sortOrder", UriHelper.ParameterToString(sortOrder));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/taskmanagement/workitems/{Uri.EscapeDataString(workitemId)}/versions", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<WorkitemVersionListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<WorkitemWrapup> GetWorkitemUserWrapupsAsync(string workitemId, string userId, string expands = null, string after = null, int? pageSize = null, string sortOrder = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(workitemId);
        ArgumentException.ThrowIfNullOrEmpty(userId);

        var parameters = new NameValueCollection();

        if (!string.IsNullOrEmpty(expands))
        {
            parameters.Add("expands", UriHelper.ParameterToString(expands));
        }

        if (!string.IsNullOrEmpty(after))
        {
            parameters.Add("after", UriHelper.ParameterToString(after));
        }

        if (pageSize.HasValue)
        {
            parameters.Add("pageSize", UriHelper.ParameterToString(pageSize.Value));
        }

        if (!string.IsNullOrEmpty(sortOrder))
        {
            parameters.Add("sortOrder", UriHelper.ParameterToString(sortOrder));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/taskmanagement/workitems/{Uri.EscapeDataString(workitemId)}/users/{Uri.EscapeDataString(userId)}/wrapups", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<WorkitemWrapup>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<WorkitemWrapupEntityListing> GetWorkitemWrapupsAsync(string workitemId, string expands = null, string after = null, int? pageSize = null, string sortOrder = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(workitemId);

        var parameters = new NameValueCollection();

        if (!string.IsNullOrEmpty(expands))
        {
            parameters.Add("expands", UriHelper.ParameterToString(expands));
        }

        if (!string.IsNullOrEmpty(after))
        {
            parameters.Add("after", UriHelper.ParameterToString(after));
        }

        if (pageSize.HasValue)
        {
            parameters.Add("pageSize", UriHelper.ParameterToString(pageSize.Value));
        }

        if (!string.IsNullOrEmpty(sortOrder))
        {
            parameters.Add("sortOrder", UriHelper.ParameterToString(sortOrder));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/taskmanagement/workitems/{Uri.EscapeDataString(workitemId)}/wrapups", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<WorkitemWrapupEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<BulkJob> GetWorkitemsBulkAddJobAsync(string bulkJobId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(bulkJobId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/taskmanagement/workitems/bulkjobs/add/{Uri.EscapeDataString(bulkJobId)}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<BulkJob>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<BulkJobAddResponse> GetWorkitemsBulkAddJobResultsAsync(string bulkJobId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(bulkJobId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/taskmanagement/workitems/bulkjobs/add/{Uri.EscapeDataString(bulkJobId)}/results", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<BulkJobAddResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<BulkJobsListing> GetWorkitemsBulkJobsUsersMeAsync(string after = null, int? pageSize = null, string sortOrder = null, string action = null, CancellationToken cancellationToken = default)
    {
        var parameters = new NameValueCollection();

        if (!string.IsNullOrEmpty(after))
        {
            parameters.Add("after", UriHelper.ParameterToString(after));
        }

        if (pageSize.HasValue)
        {
            parameters.Add("pageSize", UriHelper.ParameterToString(pageSize.Value));
        }

        if (!string.IsNullOrEmpty(sortOrder))
        {
            parameters.Add("sortOrder", UriHelper.ParameterToString(sortOrder));
        }

        if (!string.IsNullOrEmpty(action))
        {
            parameters.Add("action", UriHelper.ParameterToString(action));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/taskmanagement/workitems/bulkjobs/users/me", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<BulkJobsListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<BulkJob> GetWorkitemsBulkTerminateJobAsync(string bulkJobId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(bulkJobId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/taskmanagement/workitems/bulkjobs/terminate/{Uri.EscapeDataString(bulkJobId)}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<BulkJob>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<BulkJobTerminateResultsResponse> GetWorkitemsBulkTerminateJobResultsAsync(string bulkJobId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(bulkJobId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/taskmanagement/workitems/bulkjobs/terminate/{Uri.EscapeDataString(bulkJobId)}/results", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<BulkJobTerminateResultsResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<bool> DeleteWorkitemsBulkAddJobAsync(string bulkJobId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(bulkJobId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/taskmanagement/workitems/bulkjobs/add/{Uri.EscapeDataString(bulkJobId)}", cancellationToken);

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    public async Task<bool> DeleteWorkitemsBulkTerminateJobAsync(string bulkJobId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(bulkJobId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/taskmanagement/workitems/bulkjobs/terminate/{Uri.EscapeDataString(bulkJobId)}", cancellationToken);

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    public async Task<BulkJob> CreateWorkitemsBulkAddJobAsync(BulkJobAddRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/taskmanagement/workitems/bulkjobs/add", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<BulkJob>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<BulkJob> CreateWorkitemsBulkTerminateJobAsync(BulkJobTerminateRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/taskmanagement/workitems/bulkjobs/terminate", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<BulkJob>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<BulkJob> UpdateWorkitemsBulkAddJobAsync(string bulkJobId, BulkJobUpdate body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(bulkJobId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PatchAsJsonAsync($"api/v2/taskmanagement/workitems/bulkjobs/add/{Uri.EscapeDataString(bulkJobId)}", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<BulkJob>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<BulkJob> UpdateWorkitemsBulkTerminateJobAsync(string bulkJobId, BulkJobUpdate body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(bulkJobId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PatchAsJsonAsync($"api/v2/taskmanagement/workitems/bulkjobs/terminate/{Uri.EscapeDataString(bulkJobId)}", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<BulkJob>(_options.JsonSerializerOptions, cancellationToken);
    }
}
