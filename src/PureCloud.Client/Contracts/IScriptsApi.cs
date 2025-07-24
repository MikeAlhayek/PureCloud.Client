using PureCloud.Client.Models;

namespace PureCloud.Client.Contracts;

public interface IScriptsApi
{
    /// <summary>
    /// Get a script
    /// </summary>
    /// <param name="scriptId">Script ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Script</returns>
    Task<Script> GetScriptAsync(string scriptId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the list of scripts
    /// </summary>
    /// <param name="pageSize">Page size</param>
    /// <param name="pageNumber">Page number</param>
    /// <param name="expand">Expand</param>
    /// <param name="name">Name filter</param>
    /// <param name="feature">Feature filter</param>
    /// <param name="flowId">Secure flow id filter</param>
    /// <param name="sortBy">SortBy</param>
    /// <param name="sortOrder">SortOrder</param>
    /// <param name="scriptDataVersion">Advanced usage - controls the data version of the script</param>
    /// <param name="divisionIds">Filters scripts to requested divisionIds</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>ScriptEntityListing</returns>
    Task<ScriptEntityListing> GetScriptsAsync(int? pageSize = null, int? pageNumber = null, string expand = null, string name = null, string feature = null, string flowId = null, string sortBy = null, string sortOrder = null, string scriptDataVersion = null, string divisionIds = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Export a script via download service
    /// </summary>
    /// <param name="scriptId">Script ID</param>
    /// <param name="body">Export script request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>ExportScriptResponse</returns>
    Task<ExportScriptResponse> CreateScriptExportAsync(string scriptId, ExportScriptRequest body = null, CancellationToken cancellationToken = default);
}