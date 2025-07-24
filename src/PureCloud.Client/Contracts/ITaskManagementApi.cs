namespace PureCloud.Client.Contracts;

/// <summary>
/// Task Management API for workbins, workitems, and worktypes
/// </summary>
public interface ITaskManagementApi
{
    /// <summary>
    /// Get a workbin
    /// </summary>
    Task<object> GetWorkbinAsync(string workbinId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a workbin  
    /// </summary>
    Task<object> CreateWorkbinAsync(object body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update a workbin
    /// </summary>
    Task<object> UpdateWorkbinAsync(string workbinId, object body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a workbin
    /// </summary>
    Task DeleteWorkbinAsync(string workbinId, CancellationToken cancellationToken = default);
}