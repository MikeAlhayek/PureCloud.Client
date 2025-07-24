using PureCloud.Client.Models;

namespace PureCloud.Client.Contracts;

public interface ITaskManagementApi
{
    /// <summary>
    /// Get a workbin
    /// </summary>
    Task<Workbin> GetWorkbinAsync(string workbinId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a workitem
    /// </summary>
    Task<Workitem> GetWorkitemAsync(string workitemId, string? expands = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a worktype
    /// </summary>
    Task<Worktype> GetWorktypeAsync(string worktypeId, IEnumerable<string>? expands = null, CancellationToken cancellationToken = default);

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
    /// Delete a workbin
    /// </summary>
    Task DeleteWorkbinAsync(string workbinId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a workitem
    /// </summary>
    Task DeleteWorkitemAsync(string workitemId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a worktype
    /// </summary>
    Task DeleteWorktypeAsync(string worktypeId, CancellationToken cancellationToken = default);
}