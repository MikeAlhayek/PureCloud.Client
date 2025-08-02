using PureCloud.Client.Models;

namespace PureCloud.Client.Contracts;

/// <summary>
/// Task Management API for workbins, workitems, and worktypes
/// </summary>
public interface ITaskManagementApi
{
    /// <summary>
    /// Get a workbin
    /// </summary>
    /// <param name="workbinId">The ID of the workbin to retrieve.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    Task<Workbin> GetWorkbinAsync(string workbinId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a workitem
    /// </summary>
    /// <param name="workitemId">The ID of the workitem to retrieve.</param>
    /// <param name="expands">Optional comma-separated list of fields to expand in the response.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    Task<Workitem> GetWorkitemAsync(string workitemId, string expands = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a worktype
    /// </summary>
    /// <param name="worktypeId">The ID of the worktype to retrieve.</param>
    /// <param name="expands">Optional list of fields to expand in the response.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    Task<Worktype> GetWorktypeAsync(string worktypeId, IEnumerable<string> expands = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get workitems schema
    /// </summary>
    /// <param name="schemaId">The ID of the schema to retrieve.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    Task<DataSchema> GetWorkitemsSchemaAsync(string schemaId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get workitems schemas
    /// </summary>
    /// <param name="cancellationToken">Cancellation token.</param>
    Task<DataSchemaListing> GetWorkitemsSchemasAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Get workitems core type
    /// </summary>
    /// <param name="coreTypeName">The name of the core type to retrieve.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    Task<Coretype> GetWorkitemsSchemasCoretypeAsync(string coreTypeName, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a workbin  
    /// </summary>
    /// <param name="body">The workbin data to create.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    Task<Workbin> CreateWorkbinAsync(WorkbinCreate body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a workitem
    /// </summary>
    /// <param name="body">The workitem data to create.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    Task<Workitem> CreateWorkitemAsync(WorkitemCreate body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a worktype
    /// </summary>
    /// <param name="body">The worktype data to create.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    Task<Worktype> CreateWorktypeAsync(WorktypeCreate body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create workitems schema
    /// </summary>
    /// <param name="body">The schema data to create.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    Task<DataSchema> CreateWorkitemsSchemaAsync(DataSchema body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update a workbin
    /// </summary>
    /// <param name="workbinId">The ID of the workbin to update.</param>
    /// <param name="body">The workbin data to update.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    Task<Workbin> UpdateWorkbinAsync(string workbinId, WorkbinUpdate body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update a workitem
    /// </summary>
    /// <param name="workitemId">The ID of the workitem to update.</param>
    /// <param name="body">The workitem data to update.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    Task<Workitem> UpdateWorkitemAsync(string workitemId, WorkitemUpdate body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update a worktype
    /// </summary>
    /// <param name="worktypeId">The ID of the worktype to update.</param>
    /// <param name="body">The worktype data to update.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    Task<Worktype> UpdateWorktypeAsync(string worktypeId, WorktypeUpdate body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update workitems schema
    /// </summary>
    /// <param name="schemaId">The ID of the schema to update.</param>
    /// <param name="body">The schema data to update.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    Task<DataSchema> UpdateWorkitemsSchemaAsync(string schemaId, DataSchema body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a workbin
    /// </summary>
    /// <param name="workbinId">The ID of the workbin to delete.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    Task<bool> DeleteWorkbinAsync(string workbinId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a workitem
    /// </summary>
    /// <param name="workitemId">The ID of the workitem to delete.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    Task<bool> DeleteWorkitemAsync(string workitemId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a worktype
    /// </summary>
    /// <param name="worktypeId">The ID of the worktype to delete.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    Task<bool> DeleteWorktypeAsync(string worktypeId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete workitems schema
    /// </summary>
    /// <param name="schemaId">The ID of the schema to delete.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    Task<bool> DeleteWorkitemsSchemaAsync(string schemaId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get workitems schemas limits
    /// </summary>
    /// <param name="cancellationToken">Cancellation token.</param>
    Task<SchemaQuantityLimits> GetWorkitemsSchemasLimitsAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Get workbin history
    /// </summary>
    /// <param name="workbinId">The ID of the workbin.</param>
    /// <param name="after">The cursor for the next page of results.</param>
    /// <param name="pageSize">The page size.</param>
    /// <param name="sortOrder">The sort order.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    Task<WorkbinChangeListing> GetWorkbinHistoryAsync(string workbinId, string after = null, int? pageSize = null, string sortOrder = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get workbin version
    /// </summary>
    /// <param name="workbinId">The ID of the workbin.</param>
    /// <param name="entityVersion">The entity version.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    Task<WorkbinVersion> GetWorkbinVersionAsync(string workbinId, int? entityVersion, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get workbin versions
    /// </summary>
    /// <param name="workbinId">The ID of the workbin.</param>
    /// <param name="after">The cursor for the next page of results.</param>
    /// <param name="pageSize">The page size.</param>
    /// <param name="sortOrder">The sort order.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    Task<WorkbinVersionListing> GetWorkbinVersionsAsync(string workbinId, string after = null, int? pageSize = null, string sortOrder = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get workitem history
    /// </summary>
    /// <param name="workitemId">The ID of the workitem.</param>
    /// <param name="after">The cursor for the next page of results.</param>
    /// <param name="pageSize">The page size.</param>
    /// <param name="sortOrder">The sort order.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    Task<WorkitemChangeListing> GetWorkitemHistoryAsync(string workitemId, string after = null, int? pageSize = null, string sortOrder = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get workitem version
    /// </summary>
    /// <param name="workitemId">The ID of the workitem.</param>
    /// <param name="entityVersion">The entity version.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    Task<WorkitemVersion> GetWorkitemVersionAsync(string workitemId, int? entityVersion, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get workitem versions
    /// </summary>
    /// <param name="workitemId">The ID of the workitem.</param>
    /// <param name="after">The cursor for the next page of results.</param>
    /// <param name="pageSize">The page size.</param>
    /// <param name="sortOrder">The sort order.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    Task<WorkitemVersionListing> GetWorkitemVersionsAsync(string workitemId, string after = null, int? pageSize = null, string sortOrder = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get workitem user wrapups
    /// </summary>
    /// <param name="workitemId">The ID of the workitem.</param>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="expands">Optional fields to expand.</param>
    /// <param name="after">The cursor for the next page of results.</param>
    /// <param name="pageSize">The page size.</param>
    /// <param name="sortOrder">The sort order.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    Task<WorkitemWrapup> GetWorkitemUserWrapupsAsync(string workitemId, string userId, string expands = null, string after = null, int? pageSize = null, string sortOrder = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get workitem wrapups
    /// </summary>
    /// <param name="workitemId">The ID of the workitem.</param>
    /// <param name="expands">Optional fields to expand.</param>
    /// <param name="after">The cursor for the next page of results.</param>
    /// <param name="pageSize">The page size.</param>
    /// <param name="sortOrder">The sort order.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    Task<WorkitemWrapupEntityListing> GetWorkitemWrapupsAsync(string workitemId, string expands = null, string after = null, int? pageSize = null, string sortOrder = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get bulk add job
    /// </summary>
    /// <param name="bulkJobId">The ID of the bulk job.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    Task<BulkJob> GetWorkitemsBulkAddJobAsync(string bulkJobId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get bulk add job results
    /// </summary>
    /// <param name="bulkJobId">The ID of the bulk job.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    Task<BulkJobAddResponse> GetWorkitemsBulkAddJobResultsAsync(string bulkJobId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get bulk jobs for current user
    /// </summary>
    /// <param name="after">The cursor for the next page of results.</param>
    /// <param name="pageSize">The page size.</param>
    /// <param name="sortOrder">The sort order.</param>
    /// <param name="action">The action filter.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    Task<BulkJobsListing> GetWorkitemsBulkJobsUsersMeAsync(string after = null, int? pageSize = null, string sortOrder = null, string action = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get bulk terminate job
    /// </summary>
    /// <param name="bulkJobId">The ID of the bulk job.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    Task<BulkJob> GetWorkitemsBulkTerminateJobAsync(string bulkJobId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get bulk terminate job results
    /// </summary>
    /// <param name="bulkJobId">The ID of the bulk job.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    Task<BulkJobTerminateResultsResponse> GetWorkitemsBulkTerminateJobResultsAsync(string bulkJobId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete bulk add job
    /// </summary>
    /// <param name="bulkJobId">The ID of the bulk job.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    Task<bool> DeleteWorkitemsBulkAddJobAsync(string bulkJobId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete bulk terminate job
    /// </summary>
    /// <param name="bulkJobId">The ID of the bulk job.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    Task<bool> DeleteWorkitemsBulkTerminateJobAsync(string bulkJobId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create bulk add job
    /// </summary>
    /// <param name="body">The bulk job request.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    Task<BulkJob> CreateWorkitemsBulkAddJobAsync(BulkJobAddRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create bulk terminate job
    /// </summary>
    /// <param name="body">The bulk job request.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    Task<BulkJob> CreateWorkitemsBulkTerminateJobAsync(BulkJobTerminateRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update bulk add job
    /// </summary>
    /// <param name="bulkJobId">The ID of the bulk job.</param>
    /// <param name="body">The bulk job update.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    Task<BulkJob> UpdateWorkitemsBulkAddJobAsync(string bulkJobId, BulkJobUpdate body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update bulk terminate job
    /// </summary>
    /// <param name="bulkJobId">The ID of the bulk job.</param>
    /// <param name="body">The bulk job update.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    Task<BulkJob> UpdateWorkitemsBulkTerminateJobAsync(string bulkJobId, BulkJobUpdate body, CancellationToken cancellationToken = default);
}
