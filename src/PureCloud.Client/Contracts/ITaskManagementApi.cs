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

    // TODO: Add remaining missing endpoints - commenting out for now due to model migration needed
    // The following endpoints require model migration from partial/IEquatable to sealed pattern:
    // - WorkbinQueryRequest, WorkitemQueryJobCreate, etc.
}
