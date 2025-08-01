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
    Task<Workbin> GetWorkbinAsync(string workbinId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a workitem
    /// </summary>
    Task<Workitem> GetWorkitemAsync(string workitemId, string expands = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a worktype
    /// </summary>
    Task<Worktype> GetWorktypeAsync(string worktypeId, IEnumerable<string> expands = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get workitems schema
    /// </summary>
    Task<DataSchema> GetWorkitemsSchemaAsync(string schemaId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get workitems schemas
    /// </summary>
    Task<DataSchemaListing> GetWorkitemsSchemasAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Get workitems core type
    /// </summary>
    Task<Coretype> GetWorkitemsSchemasCoretypeAsync(string coreTypeName, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a workbin  
    /// </summary>
    Task<Workbin> CreateWorkbinAsync(WorkbinCreate body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a workitem
    /// </summary>
    Task<Workitem> CreateWorkitemAsync(WorkitemCreate body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a worktype
    /// </summary>
    Task<Worktype> CreateWorktypeAsync(WorktypeCreate body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create workitems schema
    /// </summary>
    Task<DataSchema> CreateWorkitemsSchemaAsync(DataSchema body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update a workbin
    /// </summary>
    Task<Workbin> UpdateWorkbinAsync(string workbinId, WorkbinUpdate body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update a workitem
    /// </summary>
    Task<Workitem> UpdateWorkitemAsync(string workitemId, WorkitemUpdate body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update a worktype
    /// </summary>
    Task<Worktype> UpdateWorktypeAsync(string worktypeId, WorktypeUpdate body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update workitems schema
    /// </summary>
    Task<DataSchema> UpdateWorkitemsSchemaAsync(string schemaId, DataSchema body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a workbin
    /// </summary>
    Task<bool> DeleteWorkbinAsync(string workbinId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a workitem
    /// </summary>
    Task<bool> DeleteWorkitemAsync(string workitemId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a worktype
    /// </summary>
    Task<bool> DeleteWorktypeAsync(string worktypeId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete workitems schema
    /// </summary>
    Task<bool> DeleteWorkitemsSchemaAsync(string schemaId, CancellationToken cancellationToken = default);
}
