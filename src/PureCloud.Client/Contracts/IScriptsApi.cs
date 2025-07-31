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
    /// Get a page
    /// </summary>
    /// <param name="scriptId">Script ID</param>
    /// <param name="pageId">Page ID</param>
    /// <param name="scriptDataVersion">Advanced usage - controls the data version of the script</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Page</returns>
    Task<Page> GetScriptPageAsync(string scriptId, string pageId, string scriptDataVersion = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the list of pages
    /// </summary>
    /// <param name="scriptId">Script ID</param>
    /// <param name="scriptDataVersion">Advanced usage - controls the data version of the script</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>List of pages</returns>
    Task<IEnumerable<Page>> GetScriptPagesAsync(string scriptId, string scriptDataVersion = null, CancellationToken cancellationToken = default);

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
    /// Get the metadata for a list of scripts
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
    Task<ScriptEntityListing> GetScriptsDivisionviewsAsync(int? pageSize = null, int? pageNumber = null, string expand = null, string name = null, string feature = null, string flowId = null, string sortBy = null, string sortOrder = null, string scriptDataVersion = null, string divisionIds = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the published scripts
    /// </summary>
    /// <param name="pageSize">Page size</param>
    /// <param name="pageNumber">Page number</param>
    /// <param name="expand">Expand</param>
    /// <param name="name">Name filter</param>
    /// <param name="feature">Feature filter</param>
    /// <param name="flowId">Secure flow id filter</param>
    /// <param name="scriptDataVersion">Advanced usage - controls the data version of the script</param>
    /// <param name="divisionIds">Filters scripts to requested divisionIds</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>ScriptEntityListing</returns>
    Task<ScriptEntityListing> GetScriptsPublishedAsync(int? pageSize = null, int? pageNumber = null, string expand = null, string name = null, string feature = null, string flowId = null, string scriptDataVersion = null, string divisionIds = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the published scripts metadata
    /// </summary>
    /// <param name="pageSize">Page size</param>
    /// <param name="pageNumber">Page number</param>
    /// <param name="expand">Expand</param>
    /// <param name="name">Name filter</param>
    /// <param name="feature">Feature filter</param>
    /// <param name="flowId">Secure flow id filter</param>
    /// <param name="scriptDataVersion">Advanced usage - controls the data version of the script</param>
    /// <param name="divisionIds">Filters scripts to requested divisionIds</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>ScriptEntityListing</returns>
    Task<ScriptEntityListing> GetScriptsPublishedDivisionviewsAsync(int? pageSize = null, int? pageNumber = null, string expand = null, string name = null, string feature = null, string flowId = null, string scriptDataVersion = null, string divisionIds = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the published script
    /// </summary>
    /// <param name="scriptId">Script ID</param>
    /// <param name="scriptDataVersion">Advanced usage - controls the data version of the script</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Script</returns>
    Task<Script> GetScriptsPublishedScriptAsync(string scriptId, string scriptDataVersion = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the published page
    /// </summary>
    /// <param name="scriptId">Script ID</param>
    /// <param name="pageId">Page ID</param>
    /// <param name="scriptDataVersion">Advanced usage - controls the data version of the script</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Page</returns>
    Task<Page> GetScriptsPublishedScriptPageAsync(string scriptId, string pageId, string scriptDataVersion = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the list of published pages
    /// </summary>
    /// <param name="scriptId">Script ID</param>
    /// <param name="scriptDataVersion">Advanced usage - controls the data version of the script</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>List of pages</returns>
    Task<IEnumerable<Page>> GetScriptsPublishedScriptPagesAsync(string scriptId, string scriptDataVersion = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the published variables
    /// </summary>
    /// <param name="scriptId">Script ID</param>
    /// <param name="input">input</param>
    /// <param name="output">output</param>
    /// <param name="type">type</param>
    /// <param name="scriptDataVersion">Advanced usage - controls the data version of the script</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Published variables object</returns>
    Task<ScriptVariablesResponse> GetScriptsPublishedScriptVariablesAsync(string scriptId, string input = null, string output = null, string type = null, string scriptDataVersion = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the upload status of an imported script
    /// </summary>
    /// <param name="uploadId">Upload ID</param>
    /// <param name="longPoll">Enable longPolling endpoint</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>ImportScriptStatusResponse</returns>
    Task<ImportScriptStatusResponse> GetScriptsUploadStatusAsync(string uploadId, bool? longPoll = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Export a script via download service
    /// </summary>
    /// <param name="scriptId">Script ID</param>
    /// <param name="body">Export script request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>ExportScriptResponse</returns>
    Task<ExportScriptResponse> CreateScriptExportAsync(string scriptId, ExportScriptRequest body = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Publish a script
    /// </summary>
    /// <param name="scriptDataVersion">Advanced usage - controls the data version of the script</param>
    /// <param name="body">Publish script request data</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Script</returns>
    Task<Script> CreateScriptsPublishedAsync(string scriptDataVersion = null, PublishScriptRequestData body = null, CancellationToken cancellationToken = default);
}
