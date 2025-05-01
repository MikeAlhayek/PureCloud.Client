using PureCloud.Client;
using PureCloud.Client.Models;
using RestSharp;

namespace PureCloud.Client.Apis;


/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IScriptsApi : IApiAccessor
{
    #region Synchronous Operations

    /// <summary>
    /// Get a script
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="scriptId">Script ID</param>
    /// <returns>Script</returns>

    Script GetScript(string scriptId);

    /// <summary>
    /// Get a script
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="scriptId">Script ID</param>
    /// <returns>ApiResponse of Script</returns>

    ApiResponse<Script> GetScriptWithHttpInfo(string scriptId);

    /// <summary>
    /// Get a page
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="scriptId">Script ID</param>
    /// <param name="pageId">Page ID</param>
    /// <param name="scriptDataVersion">Advanced usage - controls the data version of the script (optional)</param>
    /// <returns>Page</returns>

    Page GetScriptPage(string scriptId, string pageId, string scriptDataVersion = null);

    /// <summary>
    /// Get a page
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="scriptId">Script ID</param>
    /// <param name="pageId">Page ID</param>
    /// <param name="scriptDataVersion">Advanced usage - controls the data version of the script (optional)</param>
    /// <returns>ApiResponse of Page</returns>

    ApiResponse<Page> GetScriptPageWithHttpInfo(string scriptId, string pageId, string scriptDataVersion = null);

    /// <summary>
    /// Get the list of pages
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="scriptId">Script ID</param>
    /// <param name="scriptDataVersion">Advanced usage - controls the data version of the script (optional)</param>
    /// <returns>List&lt;Page&gt;</returns>

    List<Page> GetScriptPages(string scriptId, string scriptDataVersion = null);

    /// <summary>
    /// Get the list of pages
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="scriptId">Script ID</param>
    /// <param name="scriptDataVersion">Advanced usage - controls the data version of the script (optional)</param>
    /// <returns>ApiResponse of List&lt;Page&gt;</returns>

    ApiResponse<List<Page>> GetScriptPagesWithHttpInfo(string scriptId, string scriptDataVersion = null);

    /// <summary>
    /// Get the list of scripts
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <param name="expand">Expand (optional)</param>
    /// <param name="name">Name filter (optional)</param>
    /// <param name="feature">Feature filter (optional)</param>
    /// <param name="flowId">Secure flow id filter (optional)</param>
    /// <param name="sortBy">SortBy (optional)</param>
    /// <param name="sortOrder">SortOrder (optional)</param>
    /// <param name="scriptDataVersion">Advanced usage - controls the data version of the script (optional)</param>
    /// <param name="divisionIds">Filters scripts to requested divisionIds (optional)</param>
    /// <returns>ScriptEntityListing</returns>

    ScriptEntityListing GetScripts(int? pageSize = null, int? pageNumber = null, string expand = null, string name = null, string feature = null, string flowId = null, string sortBy = null, string sortOrder = null, string scriptDataVersion = null, string divisionIds = null);

    /// <summary>
    /// Get the list of scripts
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <param name="expand">Expand (optional)</param>
    /// <param name="name">Name filter (optional)</param>
    /// <param name="feature">Feature filter (optional)</param>
    /// <param name="flowId">Secure flow id filter (optional)</param>
    /// <param name="sortBy">SortBy (optional)</param>
    /// <param name="sortOrder">SortOrder (optional)</param>
    /// <param name="scriptDataVersion">Advanced usage - controls the data version of the script (optional)</param>
    /// <param name="divisionIds">Filters scripts to requested divisionIds (optional)</param>
    /// <returns>ApiResponse of ScriptEntityListing</returns>

    ApiResponse<ScriptEntityListing> GetScriptsWithHttpInfo(int? pageSize = null, int? pageNumber = null, string expand = null, string name = null, string feature = null, string flowId = null, string sortBy = null, string sortOrder = null, string scriptDataVersion = null, string divisionIds = null);

    /// <summary>
    /// Get the metadata for a list of scripts
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <param name="expand">Expand (optional)</param>
    /// <param name="name">Name filter (optional)</param>
    /// <param name="feature">Feature filter (optional)</param>
    /// <param name="flowId">Secure flow id filter (optional)</param>
    /// <param name="sortBy">SortBy (optional)</param>
    /// <param name="sortOrder">SortOrder (optional)</param>
    /// <param name="scriptDataVersion">Advanced usage - controls the data version of the script (optional)</param>
    /// <param name="divisionIds">Filters scripts to requested divisionIds (optional)</param>
    /// <returns>ScriptEntityListing</returns>

    ScriptEntityListing GetScriptsDivisionviews(int? pageSize = null, int? pageNumber = null, string expand = null, string name = null, string feature = null, string flowId = null, string sortBy = null, string sortOrder = null, string scriptDataVersion = null, string divisionIds = null);

    /// <summary>
    /// Get the metadata for a list of scripts
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <param name="expand">Expand (optional)</param>
    /// <param name="name">Name filter (optional)</param>
    /// <param name="feature">Feature filter (optional)</param>
    /// <param name="flowId">Secure flow id filter (optional)</param>
    /// <param name="sortBy">SortBy (optional)</param>
    /// <param name="sortOrder">SortOrder (optional)</param>
    /// <param name="scriptDataVersion">Advanced usage - controls the data version of the script (optional)</param>
    /// <param name="divisionIds">Filters scripts to requested divisionIds (optional)</param>
    /// <returns>ApiResponse of ScriptEntityListing</returns>

    ApiResponse<ScriptEntityListing> GetScriptsDivisionviewsWithHttpInfo(int? pageSize = null, int? pageNumber = null, string expand = null, string name = null, string feature = null, string flowId = null, string sortBy = null, string sortOrder = null, string scriptDataVersion = null, string divisionIds = null);

    /// <summary>
    /// Get the published scripts.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <param name="expand">Expand (optional)</param>
    /// <param name="name">Name filter (optional)</param>
    /// <param name="feature">Feature filter (optional)</param>
    /// <param name="flowId">Secure flow id filter (optional)</param>
    /// <param name="scriptDataVersion">Advanced usage - controls the data version of the script (optional)</param>
    /// <param name="divisionIds">Filters scripts to requested divisionIds (optional)</param>
    /// <returns>ScriptEntityListing</returns>

    ScriptEntityListing GetScriptsPublished(int? pageSize = null, int? pageNumber = null, string expand = null, string name = null, string feature = null, string flowId = null, string scriptDataVersion = null, string divisionIds = null);

    /// <summary>
    /// Get the published scripts.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <param name="expand">Expand (optional)</param>
    /// <param name="name">Name filter (optional)</param>
    /// <param name="feature">Feature filter (optional)</param>
    /// <param name="flowId">Secure flow id filter (optional)</param>
    /// <param name="scriptDataVersion">Advanced usage - controls the data version of the script (optional)</param>
    /// <param name="divisionIds">Filters scripts to requested divisionIds (optional)</param>
    /// <returns>ApiResponse of ScriptEntityListing</returns>

    ApiResponse<ScriptEntityListing> GetScriptsPublishedWithHttpInfo(int? pageSize = null, int? pageNumber = null, string expand = null, string name = null, string feature = null, string flowId = null, string scriptDataVersion = null, string divisionIds = null);

    /// <summary>
    /// Get the published scripts metadata.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <param name="expand">Expand (optional)</param>
    /// <param name="name">Name filter (optional)</param>
    /// <param name="feature">Feature filter (optional)</param>
    /// <param name="flowId">Secure flow id filter (optional)</param>
    /// <param name="scriptDataVersion">Advanced usage - controls the data version of the script (optional)</param>
    /// <param name="divisionIds">Filters scripts to requested divisionIds (optional)</param>
    /// <returns>ScriptEntityListing</returns>

    ScriptEntityListing GetScriptsPublishedDivisionviews(int? pageSize = null, int? pageNumber = null, string expand = null, string name = null, string feature = null, string flowId = null, string scriptDataVersion = null, string divisionIds = null);

    /// <summary>
    /// Get the published scripts metadata.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <param name="expand">Expand (optional)</param>
    /// <param name="name">Name filter (optional)</param>
    /// <param name="feature">Feature filter (optional)</param>
    /// <param name="flowId">Secure flow id filter (optional)</param>
    /// <param name="scriptDataVersion">Advanced usage - controls the data version of the script (optional)</param>
    /// <param name="divisionIds">Filters scripts to requested divisionIds (optional)</param>
    /// <returns>ApiResponse of ScriptEntityListing</returns>

    ApiResponse<ScriptEntityListing> GetScriptsPublishedDivisionviewsWithHttpInfo(int? pageSize = null, int? pageNumber = null, string expand = null, string name = null, string feature = null, string flowId = null, string scriptDataVersion = null, string divisionIds = null);

    /// <summary>
    /// Get the published script.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="scriptId">Script ID</param>
    /// <param name="scriptDataVersion">Advanced usage - controls the data version of the script (optional)</param>
    /// <returns>Script</returns>

    Script GetScriptsPublishedScriptId(string scriptId, string scriptDataVersion = null);

    /// <summary>
    /// Get the published script.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="scriptId">Script ID</param>
    /// <param name="scriptDataVersion">Advanced usage - controls the data version of the script (optional)</param>
    /// <returns>ApiResponse of Script</returns>

    ApiResponse<Script> GetScriptsPublishedScriptIdWithHttpInfo(string scriptId, string scriptDataVersion = null);

    /// <summary>
    /// Get the published page.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="scriptId">Script ID</param>
    /// <param name="pageId">Page ID</param>
    /// <param name="scriptDataVersion">Advanced usage - controls the data version of the script (optional)</param>
    /// <returns>Page</returns>

    Page GetScriptsPublishedScriptIdPage(string scriptId, string pageId, string scriptDataVersion = null);

    /// <summary>
    /// Get the published page.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="scriptId">Script ID</param>
    /// <param name="pageId">Page ID</param>
    /// <param name="scriptDataVersion">Advanced usage - controls the data version of the script (optional)</param>
    /// <returns>ApiResponse of Page</returns>

    ApiResponse<Page> GetScriptsPublishedScriptIdPageWithHttpInfo(string scriptId, string pageId, string scriptDataVersion = null);

    /// <summary>
    /// Get the list of published pages
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="scriptId">Script ID</param>
    /// <param name="scriptDataVersion">Advanced usage - controls the data version of the script (optional)</param>
    /// <returns>List&lt;Page&gt;</returns>

    List<Page> GetScriptsPublishedScriptIdPages(string scriptId, string scriptDataVersion = null);

    /// <summary>
    /// Get the list of published pages
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="scriptId">Script ID</param>
    /// <param name="scriptDataVersion">Advanced usage - controls the data version of the script (optional)</param>
    /// <returns>ApiResponse of List&lt;Page&gt;</returns>

    ApiResponse<List<Page>> GetScriptsPublishedScriptIdPagesWithHttpInfo(string scriptId, string scriptDataVersion = null);

    /// <summary>
    /// Get the published variables
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="scriptId">Script ID</param>
    /// <param name="input">input (optional)</param>
    /// <param name="output">output (optional)</param>
    /// <param name="type">type (optional)</param>
    /// <param name="scriptDataVersion">Advanced usage - controls the data version of the script (optional)</param>
    /// <returns>Object</returns>

    object GetScriptsPublishedScriptIdVariables(string scriptId, string input = null, string output = null, string type = null, string scriptDataVersion = null);

    /// <summary>
    /// Get the published variables
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="scriptId">Script ID</param>
    /// <param name="input">input (optional)</param>
    /// <param name="output">output (optional)</param>
    /// <param name="type">type (optional)</param>
    /// <param name="scriptDataVersion">Advanced usage - controls the data version of the script (optional)</param>
    /// <returns>ApiResponse of Object</returns>

    ApiResponse<object> GetScriptsPublishedScriptIdVariablesWithHttpInfo(string scriptId, string input = null, string output = null, string type = null, string scriptDataVersion = null);

    /// <summary>
    /// Get the upload status of an imported script
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="uploadId">Upload ID</param>
    /// <param name="longPoll">Enable longPolling endpoint (optional, default to false)</param>
    /// <returns>ImportScriptStatusResponse</returns>

    ImportScriptStatusResponse GetScriptsUploadStatus(string uploadId, bool? longPoll = null);

    /// <summary>
    /// Get the upload status of an imported script
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="uploadId">Upload ID</param>
    /// <param name="longPoll">Enable longPolling endpoint (optional, default to false)</param>
    /// <returns>ApiResponse of ImportScriptStatusResponse</returns>

    ApiResponse<ImportScriptStatusResponse> GetScriptsUploadStatusWithHttpInfo(string uploadId, bool? longPoll = null);

    /// <summary>
    /// Export a script via download service.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="scriptId">Script ID</param>
    /// <param name="body"> (optional)</param>
    /// <returns>ExportScriptResponse</returns>

    ExportScriptResponse PostScriptExport(string scriptId, ExportScriptRequest body = null);

    /// <summary>
    /// Export a script via download service.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="scriptId">Script ID</param>
    /// <param name="body"> (optional)</param>
    /// <returns>ApiResponse of ExportScriptResponse</returns>

    ApiResponse<ExportScriptResponse> PostScriptExportWithHttpInfo(string scriptId, ExportScriptRequest body = null);

    /// <summary>
    /// Publish a script.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="scriptDataVersion">Advanced usage - controls the data version of the script (optional)</param>
    /// <param name="body">body (optional)</param>
    /// <returns>Script</returns>

    Script PostScriptsPublished(string scriptDataVersion = null, PublishScriptRequestData body = null);

    /// <summary>
    /// Publish a script.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="scriptDataVersion">Advanced usage - controls the data version of the script (optional)</param>
    /// <param name="body">body (optional)</param>
    /// <returns>ApiResponse of Script</returns>

    ApiResponse<Script> PostScriptsPublishedWithHttpInfo(string scriptDataVersion = null, PublishScriptRequestData body = null);

    #endregion Synchronous Operations

    #region Asynchronous Operations

    /// <summary>
    /// Get a script
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="scriptId">Script ID</param>
    /// <returns>Task of Script</returns>

    Task<Script> GetScriptAsync(string scriptId);

    /// <summary>
    /// Get a script
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="scriptId">Script ID</param>
    /// <returns>Task of ApiResponse (Script)</returns>

    Task<ApiResponse<Script>> GetScriptAsyncWithHttpInfo(string scriptId);

    /// <summary>
    /// Get a page
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="scriptId">Script ID</param>
    /// <param name="pageId">Page ID</param>
    /// <param name="scriptDataVersion">Advanced usage - controls the data version of the script (optional)</param>
    /// <returns>Task of Page</returns>

    Task<Page> GetScriptPageAsync(string scriptId, string pageId, string scriptDataVersion = null);

    /// <summary>
    /// Get a page
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="scriptId">Script ID</param>
    /// <param name="pageId">Page ID</param>
    /// <param name="scriptDataVersion">Advanced usage - controls the data version of the script (optional)</param>
    /// <returns>Task of ApiResponse (Page)</returns>

    Task<ApiResponse<Page>> GetScriptPageAsyncWithHttpInfo(string scriptId, string pageId, string scriptDataVersion = null);

    /// <summary>
    /// Get the list of pages
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="scriptId">Script ID</param>
    /// <param name="scriptDataVersion">Advanced usage - controls the data version of the script (optional)</param>
    /// <returns>Task of List&lt;Page&gt;</returns>

    Task<List<Page>> GetScriptPagesAsync(string scriptId, string scriptDataVersion = null);

    /// <summary>
    /// Get the list of pages
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="scriptId">Script ID</param>
    /// <param name="scriptDataVersion">Advanced usage - controls the data version of the script (optional)</param>
    /// <returns>Task of ApiResponse (List&lt;Page&gt;)</returns>

    Task<ApiResponse<List<Page>>> GetScriptPagesAsyncWithHttpInfo(string scriptId, string scriptDataVersion = null);

    /// <summary>
    /// Get the list of scripts
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <param name="expand">Expand (optional)</param>
    /// <param name="name">Name filter (optional)</param>
    /// <param name="feature">Feature filter (optional)</param>
    /// <param name="flowId">Secure flow id filter (optional)</param>
    /// <param name="sortBy">SortBy (optional)</param>
    /// <param name="sortOrder">SortOrder (optional)</param>
    /// <param name="scriptDataVersion">Advanced usage - controls the data version of the script (optional)</param>
    /// <param name="divisionIds">Filters scripts to requested divisionIds (optional)</param>
    /// <returns>Task of ScriptEntityListing</returns>

    Task<ScriptEntityListing> GetScriptsAsync(int? pageSize = null, int? pageNumber = null, string expand = null, string name = null, string feature = null, string flowId = null, string sortBy = null, string sortOrder = null, string scriptDataVersion = null, string divisionIds = null);

    /// <summary>
    /// Get the list of scripts
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <param name="expand">Expand (optional)</param>
    /// <param name="name">Name filter (optional)</param>
    /// <param name="feature">Feature filter (optional)</param>
    /// <param name="flowId">Secure flow id filter (optional)</param>
    /// <param name="sortBy">SortBy (optional)</param>
    /// <param name="sortOrder">SortOrder (optional)</param>
    /// <param name="scriptDataVersion">Advanced usage - controls the data version of the script (optional)</param>
    /// <param name="divisionIds">Filters scripts to requested divisionIds (optional)</param>
    /// <returns>Task of ApiResponse (ScriptEntityListing)</returns>

    Task<ApiResponse<ScriptEntityListing>> GetScriptsAsyncWithHttpInfo(int? pageSize = null, int? pageNumber = null, string expand = null, string name = null, string feature = null, string flowId = null, string sortBy = null, string sortOrder = null, string scriptDataVersion = null, string divisionIds = null);

    /// <summary>
    /// Get the metadata for a list of scripts
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <param name="expand">Expand (optional)</param>
    /// <param name="name">Name filter (optional)</param>
    /// <param name="feature">Feature filter (optional)</param>
    /// <param name="flowId">Secure flow id filter (optional)</param>
    /// <param name="sortBy">SortBy (optional)</param>
    /// <param name="sortOrder">SortOrder (optional)</param>
    /// <param name="scriptDataVersion">Advanced usage - controls the data version of the script (optional)</param>
    /// <param name="divisionIds">Filters scripts to requested divisionIds (optional)</param>
    /// <returns>Task of ScriptEntityListing</returns>

    Task<ScriptEntityListing> GetScriptsDivisionviewsAsync(int? pageSize = null, int? pageNumber = null, string expand = null, string name = null, string feature = null, string flowId = null, string sortBy = null, string sortOrder = null, string scriptDataVersion = null, string divisionIds = null);

    /// <summary>
    /// Get the metadata for a list of scripts
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <param name="expand">Expand (optional)</param>
    /// <param name="name">Name filter (optional)</param>
    /// <param name="feature">Feature filter (optional)</param>
    /// <param name="flowId">Secure flow id filter (optional)</param>
    /// <param name="sortBy">SortBy (optional)</param>
    /// <param name="sortOrder">SortOrder (optional)</param>
    /// <param name="scriptDataVersion">Advanced usage - controls the data version of the script (optional)</param>
    /// <param name="divisionIds">Filters scripts to requested divisionIds (optional)</param>
    /// <returns>Task of ApiResponse (ScriptEntityListing)</returns>

    Task<ApiResponse<ScriptEntityListing>> GetScriptsDivisionviewsAsyncWithHttpInfo(int? pageSize = null, int? pageNumber = null, string expand = null, string name = null, string feature = null, string flowId = null, string sortBy = null, string sortOrder = null, string scriptDataVersion = null, string divisionIds = null);

    /// <summary>
    /// Get the published scripts.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <param name="expand">Expand (optional)</param>
    /// <param name="name">Name filter (optional)</param>
    /// <param name="feature">Feature filter (optional)</param>
    /// <param name="flowId">Secure flow id filter (optional)</param>
    /// <param name="scriptDataVersion">Advanced usage - controls the data version of the script (optional)</param>
    /// <param name="divisionIds">Filters scripts to requested divisionIds (optional)</param>
    /// <returns>Task of ScriptEntityListing</returns>

    Task<ScriptEntityListing> GetScriptsPublishedAsync(int? pageSize = null, int? pageNumber = null, string expand = null, string name = null, string feature = null, string flowId = null, string scriptDataVersion = null, string divisionIds = null);

    /// <summary>
    /// Get the published scripts.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <param name="expand">Expand (optional)</param>
    /// <param name="name">Name filter (optional)</param>
    /// <param name="feature">Feature filter (optional)</param>
    /// <param name="flowId">Secure flow id filter (optional)</param>
    /// <param name="scriptDataVersion">Advanced usage - controls the data version of the script (optional)</param>
    /// <param name="divisionIds">Filters scripts to requested divisionIds (optional)</param>
    /// <returns>Task of ApiResponse (ScriptEntityListing)</returns>

    Task<ApiResponse<ScriptEntityListing>> GetScriptsPublishedAsyncWithHttpInfo(int? pageSize = null, int? pageNumber = null, string expand = null, string name = null, string feature = null, string flowId = null, string scriptDataVersion = null, string divisionIds = null);

    /// <summary>
    /// Get the published scripts metadata.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <param name="expand">Expand (optional)</param>
    /// <param name="name">Name filter (optional)</param>
    /// <param name="feature">Feature filter (optional)</param>
    /// <param name="flowId">Secure flow id filter (optional)</param>
    /// <param name="scriptDataVersion">Advanced usage - controls the data version of the script (optional)</param>
    /// <param name="divisionIds">Filters scripts to requested divisionIds (optional)</param>
    /// <returns>Task of ScriptEntityListing</returns>

    Task<ScriptEntityListing> GetScriptsPublishedDivisionviewsAsync(int? pageSize = null, int? pageNumber = null, string expand = null, string name = null, string feature = null, string flowId = null, string scriptDataVersion = null, string divisionIds = null);

    /// <summary>
    /// Get the published scripts metadata.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <param name="expand">Expand (optional)</param>
    /// <param name="name">Name filter (optional)</param>
    /// <param name="feature">Feature filter (optional)</param>
    /// <param name="flowId">Secure flow id filter (optional)</param>
    /// <param name="scriptDataVersion">Advanced usage - controls the data version of the script (optional)</param>
    /// <param name="divisionIds">Filters scripts to requested divisionIds (optional)</param>
    /// <returns>Task of ApiResponse (ScriptEntityListing)</returns>

    Task<ApiResponse<ScriptEntityListing>> GetScriptsPublishedDivisionviewsAsyncWithHttpInfo(int? pageSize = null, int? pageNumber = null, string expand = null, string name = null, string feature = null, string flowId = null, string scriptDataVersion = null, string divisionIds = null);

    /// <summary>
    /// Get the published script.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="scriptId">Script ID</param>
    /// <param name="scriptDataVersion">Advanced usage - controls the data version of the script (optional)</param>
    /// <returns>Task of Script</returns>

    Task<Script> GetScriptsPublishedScriptIdAsync(string scriptId, string scriptDataVersion = null);

    /// <summary>
    /// Get the published script.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="scriptId">Script ID</param>
    /// <param name="scriptDataVersion">Advanced usage - controls the data version of the script (optional)</param>
    /// <returns>Task of ApiResponse (Script)</returns>

    Task<ApiResponse<Script>> GetScriptsPublishedScriptIdAsyncWithHttpInfo(string scriptId, string scriptDataVersion = null);

    /// <summary>
    /// Get the published page.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="scriptId">Script ID</param>
    /// <param name="pageId">Page ID</param>
    /// <param name="scriptDataVersion">Advanced usage - controls the data version of the script (optional)</param>
    /// <returns>Task of Page</returns>

    Task<Page> GetScriptsPublishedScriptIdPageAsync(string scriptId, string pageId, string scriptDataVersion = null);

    /// <summary>
    /// Get the published page.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="scriptId">Script ID</param>
    /// <param name="pageId">Page ID</param>
    /// <param name="scriptDataVersion">Advanced usage - controls the data version of the script (optional)</param>
    /// <returns>Task of ApiResponse (Page)</returns>

    Task<ApiResponse<Page>> GetScriptsPublishedScriptIdPageAsyncWithHttpInfo(string scriptId, string pageId, string scriptDataVersion = null);

    /// <summary>
    /// Get the list of published pages
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="scriptId">Script ID</param>
    /// <param name="scriptDataVersion">Advanced usage - controls the data version of the script (optional)</param>
    /// <returns>Task of List&lt;Page&gt;</returns>

    Task<List<Page>> GetScriptsPublishedScriptIdPagesAsync(string scriptId, string scriptDataVersion = null);

    /// <summary>
    /// Get the list of published pages
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="scriptId">Script ID</param>
    /// <param name="scriptDataVersion">Advanced usage - controls the data version of the script (optional)</param>
    /// <returns>Task of ApiResponse (List&lt;Page&gt;)</returns>

    Task<ApiResponse<List<Page>>> GetScriptsPublishedScriptIdPagesAsyncWithHttpInfo(string scriptId, string scriptDataVersion = null);

    /// <summary>
    /// Get the published variables
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="scriptId">Script ID</param>
    /// <param name="input">input (optional)</param>
    /// <param name="output">output (optional)</param>
    /// <param name="type">type (optional)</param>
    /// <param name="scriptDataVersion">Advanced usage - controls the data version of the script (optional)</param>
    /// <returns>Task of Object</returns>

    Task<object> GetScriptsPublishedScriptIdVariablesAsync(string scriptId, string input = null, string output = null, string type = null, string scriptDataVersion = null);

    /// <summary>
    /// Get the published variables
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="scriptId">Script ID</param>
    /// <param name="input">input (optional)</param>
    /// <param name="output">output (optional)</param>
    /// <param name="type">type (optional)</param>
    /// <param name="scriptDataVersion">Advanced usage - controls the data version of the script (optional)</param>
    /// <returns>Task of ApiResponse (Object)</returns>

    Task<ApiResponse<object>> GetScriptsPublishedScriptIdVariablesAsyncWithHttpInfo(string scriptId, string input = null, string output = null, string type = null, string scriptDataVersion = null);

    /// <summary>
    /// Get the upload status of an imported script
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="uploadId">Upload ID</param>
    /// <param name="longPoll">Enable longPolling endpoint (optional, default to false)</param>
    /// <returns>Task of ImportScriptStatusResponse</returns>

    Task<ImportScriptStatusResponse> GetScriptsUploadStatusAsync(string uploadId, bool? longPoll = null);

    /// <summary>
    /// Get the upload status of an imported script
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="uploadId">Upload ID</param>
    /// <param name="longPoll">Enable longPolling endpoint (optional, default to false)</param>
    /// <returns>Task of ApiResponse (ImportScriptStatusResponse)</returns>

    Task<ApiResponse<ImportScriptStatusResponse>> GetScriptsUploadStatusAsyncWithHttpInfo(string uploadId, bool? longPoll = null);

    /// <summary>
    /// Export a script via download service.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="scriptId">Script ID</param>
    /// <param name="body"> (optional)</param>
    /// <returns>Task of ExportScriptResponse</returns>

    Task<ExportScriptResponse> PostScriptExportAsync(string scriptId, ExportScriptRequest body = null);

    /// <summary>
    /// Export a script via download service.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="scriptId">Script ID</param>
    /// <param name="body"> (optional)</param>
    /// <returns>Task of ApiResponse (ExportScriptResponse)</returns>

    Task<ApiResponse<ExportScriptResponse>> PostScriptExportAsyncWithHttpInfo(string scriptId, ExportScriptRequest body = null);

    /// <summary>
    /// Publish a script.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="scriptDataVersion">Advanced usage - controls the data version of the script (optional)</param>
    /// <param name="body">body (optional)</param>
    /// <returns>Task of Script</returns>

    Task<Script> PostScriptsPublishedAsync(string scriptDataVersion = null, PublishScriptRequestData body = null);

    /// <summary>
    /// Publish a script.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="scriptDataVersion">Advanced usage - controls the data version of the script (optional)</param>
    /// <param name="body">body (optional)</param>
    /// <returns>Task of ApiResponse (Script)</returns>

    Task<ApiResponse<Script>> PostScriptsPublishedAsyncWithHttpInfo(string scriptDataVersion = null, PublishScriptRequestData body = null);

    #endregion Asynchronous Operations

}

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public partial class ScriptsApi : IScriptsApi
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ScriptsApi"/> class.
    /// </summary>
    /// <returns></returns>
    public ScriptsApi(string basePath)
    {
        Configuration = new Configuration(new ApiClient(basePath));

        // ensure API client has configuration ready
        if (Configuration.ApiClient.Configuration == null)
        {
            Configuration.ApiClient.Configuration = Configuration;
        }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="ScriptsApi"/> class
    /// using Configuration object
    /// </summary>
    /// <param name="configuration">An instance of Configuration</param>
    /// <returns></returns>
    public ScriptsApi(Configuration configuration = null)
    {
        if (configuration == null) // use the default one in Configuration
        {
            Configuration = Configuration.Default;
        }
        else
        {
            Configuration = configuration;
        }

        // ensure API client has configuration ready
        if (Configuration.ApiClient.Configuration == null)
        {
            Configuration.ApiClient.Configuration = Configuration;
        }
    }

    /// <summary>
    /// Gets the base path of the API client.
    /// </summary>
    /// <value>The base path</value>
    public string GetBasePath()
    {
        return Configuration.ApiClient.ClientOptions.BaseUrl.ToString();
    }

    /// <summary>
    /// Sets the base path of the API client.
    /// </summary>
    /// <value>The base path</value>
    [Obsolete("SetBasePath is deprecated, please do 'this.Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
    public void SetBasePath(string basePath)
    {
        // do nothing
    }

    /// <summary>
    /// Gets or sets the configuration object
    /// </summary>
    /// <value>An instance of the Configuration</value>
    public Configuration Configuration { get; set; }

    /// <summary>
    /// Gets the default header.
    /// </summary>
    /// <returns>Dictionary of HTTP header</returns>
    [Obsolete("DefaultHeader is deprecated, please use this.Configuration.DefaultHeader instead.")]
    public Dictionary<string, string> DefaultHeader()
    {
        return Configuration.DefaultHeader;
    }

    /// <summary>
    /// Add default header.
    /// </summary>
    /// <param name="key">Header field name.</param>
    /// <param name="value">Header field value.</param>
    /// <returns></returns>
    [Obsolete("AddDefaultHeader is deprecated, please use this.Configuration.AddDefaultHeader instead.")]
    public void AddDefaultHeader(string key, string value)
    {
        Configuration.AddDefaultHeader(key, value);
    }


    /// <summary>
    /// Get a script 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="scriptId">Script ID</param>
    /// <returns>Script</returns>

    public Script GetScript(string scriptId)
    {
        ApiResponse<Script> localVarResponse = GetScriptWithHttpInfo(scriptId);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get a script 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="scriptId">Script ID</param>
    /// <returns>ApiResponse of Script</returns>

    public ApiResponse<Script> GetScriptWithHttpInfo(string scriptId)
    {
        // verify the required parameter 'scriptId' is set
        if (scriptId == null)
        {
            throw new ApiException(400, "Missing required parameter 'scriptId' when calling ScriptsApi->GetScript");
        }

        var localVarPath = "/api/v2/scripts/{scriptId}";
        var localVarPathParams = new Dictionary<string, string>();
        var localVarQueryParams = new List<Tuple<string, string>>();
        var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<string, string>();
        var localVarFileParams = new Dictionary<string, FileParameter>();
        object localVarPostBody = null;

        // to determine the Content-Type header
        string[] localVarHttpContentTypes = new string[] {
            "application/json"
        };
        string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        string[] localVarHttpHeaderAccepts = new string[] {

            "application/json"


        };
        string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params
        if (scriptId != null)
        {
            localVarPathParams.Add("scriptId", Configuration.ApiClient.ParameterToString(scriptId));
        }

        // Query params

        // Header params

        // Form params

        // Body param


        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!string.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)Configuration.ApiClient.CallApi(localVarPath,
            Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => string.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetScript: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetScript: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<Script>(localVarStatusCode,
            localVarHeaders,
            (Script)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Script)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Get a script 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="scriptId">Script ID</param>
    /// <returns>Task of Script</returns>

    public async Task<Script> GetScriptAsync(string scriptId)
    {
        ApiResponse<Script> localVarResponse = await GetScriptAsyncWithHttpInfo(scriptId);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Get a script 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="scriptId">Script ID</param>
    /// <returns>Task of ApiResponse (Script)</returns>

    public async Task<ApiResponse<Script>> GetScriptAsyncWithHttpInfo(string scriptId)
    {
        // verify the required parameter 'scriptId' is set
        if (scriptId == null)
        {
            throw new ApiException(400, "Missing required parameter 'scriptId' when calling ScriptsApi->GetScript");
        }

        var localVarPath = "/api/v2/scripts/{scriptId}";
        var localVarPathParams = new Dictionary<string, string>();
        var localVarQueryParams = new List<Tuple<string, string>>();
        var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<string, string>();
        var localVarFileParams = new Dictionary<string, FileParameter>();
        object localVarPostBody = null;

        // to determine the Content-Type header
        string[] localVarHttpContentTypes = new string[] {
            "application/json"
        };
        string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        string[] localVarHttpHeaderAccepts = new string[] {

            "application/json"


        };
        string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params
        if (scriptId != null)
        {
            localVarPathParams.Add("scriptId", Configuration.ApiClient.ParameterToString(scriptId));
        }

        // Query params

        // Header params

        // Form params

        // Body param


        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!string.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
            Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => string.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetScript: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetScript: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<Script>(localVarStatusCode,
            localVarHeaders,
            (Script)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Script)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Get a page 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="scriptId">Script ID</param>
    /// <param name="pageId">Page ID</param>
    /// <param name="scriptDataVersion">Advanced usage - controls the data version of the script (optional)</param>
    /// <returns>Page</returns>

    public Page GetScriptPage(string scriptId, string pageId, string scriptDataVersion = null)
    {
        ApiResponse<Page> localVarResponse = GetScriptPageWithHttpInfo(scriptId, pageId, scriptDataVersion);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get a page 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="scriptId">Script ID</param>
    /// <param name="pageId">Page ID</param>
    /// <param name="scriptDataVersion">Advanced usage - controls the data version of the script (optional)</param>
    /// <returns>ApiResponse of Page</returns>

    public ApiResponse<Page> GetScriptPageWithHttpInfo(string scriptId, string pageId, string scriptDataVersion = null)
    {
        // verify the required parameter 'scriptId' is set
        if (scriptId == null)
        {
            throw new ApiException(400, "Missing required parameter 'scriptId' when calling ScriptsApi->GetScriptPage");
        }
        // verify the required parameter 'pageId' is set
        if (pageId == null)
        {
            throw new ApiException(400, "Missing required parameter 'pageId' when calling ScriptsApi->GetScriptPage");
        }

        var localVarPath = "/api/v2/scripts/{scriptId}/pages/{pageId}";
        var localVarPathParams = new Dictionary<string, string>();
        var localVarQueryParams = new List<Tuple<string, string>>();
        var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<string, string>();
        var localVarFileParams = new Dictionary<string, FileParameter>();
        object localVarPostBody = null;

        // to determine the Content-Type header
        string[] localVarHttpContentTypes = new string[] {
            "application/json"
        };
        string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        string[] localVarHttpHeaderAccepts = new string[] {

            "application/json"


        };
        string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params
        if (scriptId != null)
        {
            localVarPathParams.Add("scriptId", Configuration.ApiClient.ParameterToString(scriptId));
        }

        if (pageId != null)
        {
            localVarPathParams.Add("pageId", Configuration.ApiClient.ParameterToString(pageId));
        }

        // Query params
        if (scriptDataVersion != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("scriptDataVersion", Configuration.ApiClient.ParameterToString(scriptDataVersion)));
        }

        // Header params

        // Form params

        // Body param


        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!string.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)Configuration.ApiClient.CallApi(localVarPath,
            Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => string.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetScriptPage: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetScriptPage: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<Page>(localVarStatusCode,
            localVarHeaders,
            (Page)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Page)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Get a page 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="scriptId">Script ID</param>
    /// <param name="pageId">Page ID</param>
    /// <param name="scriptDataVersion">Advanced usage - controls the data version of the script (optional)</param>
    /// <returns>Task of Page</returns>

    public async Task<Page> GetScriptPageAsync(string scriptId, string pageId, string scriptDataVersion = null)
    {
        ApiResponse<Page> localVarResponse = await GetScriptPageAsyncWithHttpInfo(scriptId, pageId, scriptDataVersion);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Get a page 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="scriptId">Script ID</param>
    /// <param name="pageId">Page ID</param>
    /// <param name="scriptDataVersion">Advanced usage - controls the data version of the script (optional)</param>
    /// <returns>Task of ApiResponse (Page)</returns>

    public async Task<ApiResponse<Page>> GetScriptPageAsyncWithHttpInfo(string scriptId, string pageId, string scriptDataVersion = null)
    {
        // verify the required parameter 'scriptId' is set
        if (scriptId == null)
        {
            throw new ApiException(400, "Missing required parameter 'scriptId' when calling ScriptsApi->GetScriptPage");
        }

        // verify the required parameter 'pageId' is set
        if (pageId == null)
        {
            throw new ApiException(400, "Missing required parameter 'pageId' when calling ScriptsApi->GetScriptPage");
        }

        var localVarPath = "/api/v2/scripts/{scriptId}/pages/{pageId}";
        var localVarPathParams = new Dictionary<string, string>();
        var localVarQueryParams = new List<Tuple<string, string>>();
        var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<string, string>();
        var localVarFileParams = new Dictionary<string, FileParameter>();
        object localVarPostBody = null;

        // to determine the Content-Type header
        string[] localVarHttpContentTypes = new string[] {
            "application/json"
        };
        string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        string[] localVarHttpHeaderAccepts = new string[] {

            "application/json"


        };
        string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params
        if (scriptId != null)
        {
            localVarPathParams.Add("scriptId", Configuration.ApiClient.ParameterToString(scriptId));
        }

        if (pageId != null)
        {
            localVarPathParams.Add("pageId", Configuration.ApiClient.ParameterToString(pageId));
        }

        // Query params
        if (scriptDataVersion != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("scriptDataVersion", Configuration.ApiClient.ParameterToString(scriptDataVersion)));
        }

        // Header params

        // Form params

        // Body param


        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!string.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
            Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => string.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetScriptPage: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetScriptPage: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<Page>(localVarStatusCode,
            localVarHeaders,
            (Page)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Page)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Get the list of pages 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="scriptId">Script ID</param>
    /// <param name="scriptDataVersion">Advanced usage - controls the data version of the script (optional)</param>
    /// <returns>List&lt;Page&gt;</returns>

    public List<Page> GetScriptPages(string scriptId, string scriptDataVersion = null)
    {
        ApiResponse<List<Page>> localVarResponse = GetScriptPagesWithHttpInfo(scriptId, scriptDataVersion);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get the list of pages 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="scriptId">Script ID</param>
    /// <param name="scriptDataVersion">Advanced usage - controls the data version of the script (optional)</param>
    /// <returns>ApiResponse of List&lt;Page&gt;</returns>

    public ApiResponse<List<Page>> GetScriptPagesWithHttpInfo(string scriptId, string scriptDataVersion = null)
    {
        // verify the required parameter 'scriptId' is set
        if (scriptId == null)
        {
            throw new ApiException(400, "Missing required parameter 'scriptId' when calling ScriptsApi->GetScriptPages");
        }

        var localVarPath = "/api/v2/scripts/{scriptId}/pages";
        var localVarPathParams = new Dictionary<string, string>();
        var localVarQueryParams = new List<Tuple<string, string>>();
        var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<string, string>();
        var localVarFileParams = new Dictionary<string, FileParameter>();
        object localVarPostBody = null;

        // to determine the Content-Type header
        string[] localVarHttpContentTypes = new string[] {
            "application/json"
        };
        string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        string[] localVarHttpHeaderAccepts = new string[] {

            "application/json"


        };
        string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params
        if (scriptId != null)
        {
            localVarPathParams.Add("scriptId", Configuration.ApiClient.ParameterToString(scriptId));
        }

        // Query params
        if (scriptDataVersion != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("scriptDataVersion", Configuration.ApiClient.ParameterToString(scriptDataVersion)));
        }

        // Header params

        // Form params

        // Body param


        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!string.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)Configuration.ApiClient.CallApi(localVarPath,
            Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => string.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetScriptPages: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetScriptPages: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<List<Page>>(localVarStatusCode,
            localVarHeaders,
            (List<Page>)Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Page>)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Get the list of pages 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="scriptId">Script ID</param>
    /// <param name="scriptDataVersion">Advanced usage - controls the data version of the script (optional)</param>
    /// <returns>Task of List&lt;Page&gt;</returns>

    public async Task<List<Page>> GetScriptPagesAsync(string scriptId, string scriptDataVersion = null)
    {
        ApiResponse<List<Page>> localVarResponse = await GetScriptPagesAsyncWithHttpInfo(scriptId, scriptDataVersion);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Get the list of pages 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="scriptId">Script ID</param>
    /// <param name="scriptDataVersion">Advanced usage - controls the data version of the script (optional)</param>
    /// <returns>Task of ApiResponse (List&lt;Page&gt;)</returns>

    public async Task<ApiResponse<List<Page>>> GetScriptPagesAsyncWithHttpInfo(string scriptId, string scriptDataVersion = null)
    {
        // verify the required parameter 'scriptId' is set
        if (scriptId == null)
        {
            throw new ApiException(400, "Missing required parameter 'scriptId' when calling ScriptsApi->GetScriptPages");
        }

        var localVarPath = "/api/v2/scripts/{scriptId}/pages";
        var localVarPathParams = new Dictionary<string, string>();
        var localVarQueryParams = new List<Tuple<string, string>>();
        var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<string, string>();
        var localVarFileParams = new Dictionary<string, FileParameter>();
        object localVarPostBody = null;

        // to determine the Content-Type header
        string[] localVarHttpContentTypes = new string[] {
            "application/json"
        };
        string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        string[] localVarHttpHeaderAccepts = new string[] {

            "application/json"


        };
        string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params
        if (scriptId != null)
        {
            localVarPathParams.Add("scriptId", Configuration.ApiClient.ParameterToString(scriptId));
        }

        // Query params
        if (scriptDataVersion != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("scriptDataVersion", Configuration.ApiClient.ParameterToString(scriptDataVersion)));
        }

        // Header params

        // Form params

        // Body param


        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!string.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
            Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => string.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetScriptPages: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetScriptPages: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<List<Page>>(localVarStatusCode,
            localVarHeaders,
            (List<Page>)Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Page>)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Get the list of scripts 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <param name="expand">Expand (optional)</param>
    /// <param name="name">Name filter (optional)</param>
    /// <param name="feature">Feature filter (optional)</param>
    /// <param name="flowId">Secure flow id filter (optional)</param>
    /// <param name="sortBy">SortBy (optional)</param>
    /// <param name="sortOrder">SortOrder (optional)</param>
    /// <param name="scriptDataVersion">Advanced usage - controls the data version of the script (optional)</param>
    /// <param name="divisionIds">Filters scripts to requested divisionIds (optional)</param>
    /// <returns>ScriptEntityListing</returns>

    public ScriptEntityListing GetScripts(int? pageSize = null, int? pageNumber = null, string expand = null, string name = null, string feature = null, string flowId = null, string sortBy = null, string sortOrder = null, string scriptDataVersion = null, string divisionIds = null)
    {
        ApiResponse<ScriptEntityListing> localVarResponse = GetScriptsWithHttpInfo(pageSize, pageNumber, expand, name, feature, flowId, sortBy, sortOrder, scriptDataVersion, divisionIds);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get the list of scripts 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <param name="expand">Expand (optional)</param>
    /// <param name="name">Name filter (optional)</param>
    /// <param name="feature">Feature filter (optional)</param>
    /// <param name="flowId">Secure flow id filter (optional)</param>
    /// <param name="sortBy">SortBy (optional)</param>
    /// <param name="sortOrder">SortOrder (optional)</param>
    /// <param name="scriptDataVersion">Advanced usage - controls the data version of the script (optional)</param>
    /// <param name="divisionIds">Filters scripts to requested divisionIds (optional)</param>
    /// <returns>ApiResponse of ScriptEntityListing</returns>

    public ApiResponse<ScriptEntityListing> GetScriptsWithHttpInfo(int? pageSize = null, int? pageNumber = null, string expand = null, string name = null, string feature = null, string flowId = null, string sortBy = null, string sortOrder = null, string scriptDataVersion = null, string divisionIds = null)
    {

        var localVarPath = "/api/v2/scripts";
        var localVarPathParams = new Dictionary<string, string>();
        var localVarQueryParams = new List<Tuple<string, string>>();
        var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<string, string>();
        var localVarFileParams = new Dictionary<string, FileParameter>();
        object localVarPostBody = null;

        // to determine the Content-Type header
        string[] localVarHttpContentTypes = new string[] {
            "application/json"
        };
        string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        string[] localVarHttpHeaderAccepts = new string[] {

            "application/json"


        };
        string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params
        if (pageSize != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("pageSize", Configuration.ApiClient.ParameterToString(pageSize)));
        }

        if (pageNumber != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)));
        }

        if (expand != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("expand", Configuration.ApiClient.ParameterToString(expand)));
        }

        if (name != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("name", Configuration.ApiClient.ParameterToString(name)));
        }

        if (feature != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("feature", Configuration.ApiClient.ParameterToString(feature)));
        }

        if (flowId != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("flowId", Configuration.ApiClient.ParameterToString(flowId)));
        }

        if (sortBy != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("sortBy", Configuration.ApiClient.ParameterToString(sortBy)));
        }

        if (sortOrder != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)));
        }

        if (scriptDataVersion != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("scriptDataVersion", Configuration.ApiClient.ParameterToString(scriptDataVersion)));
        }

        if (divisionIds != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("divisionIds", Configuration.ApiClient.ParameterToString(divisionIds)));
        }

        // Header params

        // Form params

        // Body param


        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!string.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)Configuration.ApiClient.CallApi(localVarPath,
            Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => string.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetScripts: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetScripts: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<ScriptEntityListing>(localVarStatusCode,
            localVarHeaders,
            (ScriptEntityListing)Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScriptEntityListing)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Get the list of scripts 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <param name="expand">Expand (optional)</param>
    /// <param name="name">Name filter (optional)</param>
    /// <param name="feature">Feature filter (optional)</param>
    /// <param name="flowId">Secure flow id filter (optional)</param>
    /// <param name="sortBy">SortBy (optional)</param>
    /// <param name="sortOrder">SortOrder (optional)</param>
    /// <param name="scriptDataVersion">Advanced usage - controls the data version of the script (optional)</param>
    /// <param name="divisionIds">Filters scripts to requested divisionIds (optional)</param>
    /// <returns>Task of ScriptEntityListing</returns>

    public async Task<ScriptEntityListing> GetScriptsAsync(int? pageSize = null, int? pageNumber = null, string expand = null, string name = null, string feature = null, string flowId = null, string sortBy = null, string sortOrder = null, string scriptDataVersion = null, string divisionIds = null)
    {
        ApiResponse<ScriptEntityListing> localVarResponse = await GetScriptsAsyncWithHttpInfo(pageSize, pageNumber, expand, name, feature, flowId, sortBy, sortOrder, scriptDataVersion, divisionIds);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Get the list of scripts 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <param name="expand">Expand (optional)</param>
    /// <param name="name">Name filter (optional)</param>
    /// <param name="feature">Feature filter (optional)</param>
    /// <param name="flowId">Secure flow id filter (optional)</param>
    /// <param name="sortBy">SortBy (optional)</param>
    /// <param name="sortOrder">SortOrder (optional)</param>
    /// <param name="scriptDataVersion">Advanced usage - controls the data version of the script (optional)</param>
    /// <param name="divisionIds">Filters scripts to requested divisionIds (optional)</param>
    /// <returns>Task of ApiResponse (ScriptEntityListing)</returns>

    public async Task<ApiResponse<ScriptEntityListing>> GetScriptsAsyncWithHttpInfo(int? pageSize = null, int? pageNumber = null, string expand = null, string name = null, string feature = null, string flowId = null, string sortBy = null, string sortOrder = null, string scriptDataVersion = null, string divisionIds = null)
    {

        var localVarPath = "/api/v2/scripts";
        var localVarPathParams = new Dictionary<string, string>();
        var localVarQueryParams = new List<Tuple<string, string>>();
        var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<string, string>();
        var localVarFileParams = new Dictionary<string, FileParameter>();
        object localVarPostBody = null;

        // to determine the Content-Type header
        string[] localVarHttpContentTypes = new string[] {
            "application/json"
        };
        string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        string[] localVarHttpHeaderAccepts = new string[] {

            "application/json"


        };
        string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params
        if (pageSize != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("pageSize", Configuration.ApiClient.ParameterToString(pageSize)));
        }

        if (pageNumber != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)));
        }

        if (expand != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("expand", Configuration.ApiClient.ParameterToString(expand)));
        }

        if (name != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("name", Configuration.ApiClient.ParameterToString(name)));
        }

        if (feature != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("feature", Configuration.ApiClient.ParameterToString(feature)));
        }

        if (flowId != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("flowId", Configuration.ApiClient.ParameterToString(flowId)));
        }

        if (sortBy != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("sortBy", Configuration.ApiClient.ParameterToString(sortBy)));
        }

        if (sortOrder != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)));
        }

        if (scriptDataVersion != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("scriptDataVersion", Configuration.ApiClient.ParameterToString(scriptDataVersion)));
        }

        if (divisionIds != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("divisionIds", Configuration.ApiClient.ParameterToString(divisionIds)));
        }

        // Header params

        // Form params

        // Body param


        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!string.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
            Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => string.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetScripts: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetScripts: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<ScriptEntityListing>(localVarStatusCode,
            localVarHeaders,
            (ScriptEntityListing)Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScriptEntityListing)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Get the metadata for a list of scripts 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <param name="expand">Expand (optional)</param>
    /// <param name="name">Name filter (optional)</param>
    /// <param name="feature">Feature filter (optional)</param>
    /// <param name="flowId">Secure flow id filter (optional)</param>
    /// <param name="sortBy">SortBy (optional)</param>
    /// <param name="sortOrder">SortOrder (optional)</param>
    /// <param name="scriptDataVersion">Advanced usage - controls the data version of the script (optional)</param>
    /// <param name="divisionIds">Filters scripts to requested divisionIds (optional)</param>
    /// <returns>ScriptEntityListing</returns>

    public ScriptEntityListing GetScriptsDivisionviews(int? pageSize = null, int? pageNumber = null, string expand = null, string name = null, string feature = null, string flowId = null, string sortBy = null, string sortOrder = null, string scriptDataVersion = null, string divisionIds = null)
    {
        ApiResponse<ScriptEntityListing> localVarResponse = GetScriptsDivisionviewsWithHttpInfo(pageSize, pageNumber, expand, name, feature, flowId, sortBy, sortOrder, scriptDataVersion, divisionIds);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get the metadata for a list of scripts 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <param name="expand">Expand (optional)</param>
    /// <param name="name">Name filter (optional)</param>
    /// <param name="feature">Feature filter (optional)</param>
    /// <param name="flowId">Secure flow id filter (optional)</param>
    /// <param name="sortBy">SortBy (optional)</param>
    /// <param name="sortOrder">SortOrder (optional)</param>
    /// <param name="scriptDataVersion">Advanced usage - controls the data version of the script (optional)</param>
    /// <param name="divisionIds">Filters scripts to requested divisionIds (optional)</param>
    /// <returns>ApiResponse of ScriptEntityListing</returns>

    public ApiResponse<ScriptEntityListing> GetScriptsDivisionviewsWithHttpInfo(int? pageSize = null, int? pageNumber = null, string expand = null, string name = null, string feature = null, string flowId = null, string sortBy = null, string sortOrder = null, string scriptDataVersion = null, string divisionIds = null)
    {

        var localVarPath = "/api/v2/scripts/divisionviews";
        var localVarPathParams = new Dictionary<string, string>();
        var localVarQueryParams = new List<Tuple<string, string>>();
        var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<string, string>();
        var localVarFileParams = new Dictionary<string, FileParameter>();
        object localVarPostBody = null;

        // to determine the Content-Type header
        string[] localVarHttpContentTypes = new string[] {
            "application/json"
        };
        string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        string[] localVarHttpHeaderAccepts = new string[] {

            "application/json"


        };
        string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params
        if (pageSize != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("pageSize", Configuration.ApiClient.ParameterToString(pageSize)));
        }

        if (pageNumber != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)));
        }

        if (expand != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("expand", Configuration.ApiClient.ParameterToString(expand)));
        }

        if (name != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("name", Configuration.ApiClient.ParameterToString(name)));
        }

        if (feature != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("feature", Configuration.ApiClient.ParameterToString(feature)));
        }

        if (flowId != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("flowId", Configuration.ApiClient.ParameterToString(flowId)));
        }

        if (sortBy != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("sortBy", Configuration.ApiClient.ParameterToString(sortBy)));
        }

        if (sortOrder != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)));
        }

        if (scriptDataVersion != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("scriptDataVersion", Configuration.ApiClient.ParameterToString(scriptDataVersion)));
        }

        if (divisionIds != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("divisionIds", Configuration.ApiClient.ParameterToString(divisionIds)));
        }

        // Header params

        // Form params

        // Body param


        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!string.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)Configuration.ApiClient.CallApi(localVarPath,
            Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => string.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetScriptsDivisionviews: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetScriptsDivisionviews: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<ScriptEntityListing>(localVarStatusCode,
            localVarHeaders,
            (ScriptEntityListing)Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScriptEntityListing)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Get the metadata for a list of scripts 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <param name="expand">Expand (optional)</param>
    /// <param name="name">Name filter (optional)</param>
    /// <param name="feature">Feature filter (optional)</param>
    /// <param name="flowId">Secure flow id filter (optional)</param>
    /// <param name="sortBy">SortBy (optional)</param>
    /// <param name="sortOrder">SortOrder (optional)</param>
    /// <param name="scriptDataVersion">Advanced usage - controls the data version of the script (optional)</param>
    /// <param name="divisionIds">Filters scripts to requested divisionIds (optional)</param>
    /// <returns>Task of ScriptEntityListing</returns>

    public async Task<ScriptEntityListing> GetScriptsDivisionviewsAsync(int? pageSize = null, int? pageNumber = null, string expand = null, string name = null, string feature = null, string flowId = null, string sortBy = null, string sortOrder = null, string scriptDataVersion = null, string divisionIds = null)
    {
        ApiResponse<ScriptEntityListing> localVarResponse = await GetScriptsDivisionviewsAsyncWithHttpInfo(pageSize, pageNumber, expand, name, feature, flowId, sortBy, sortOrder, scriptDataVersion, divisionIds);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Get the metadata for a list of scripts 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <param name="expand">Expand (optional)</param>
    /// <param name="name">Name filter (optional)</param>
    /// <param name="feature">Feature filter (optional)</param>
    /// <param name="flowId">Secure flow id filter (optional)</param>
    /// <param name="sortBy">SortBy (optional)</param>
    /// <param name="sortOrder">SortOrder (optional)</param>
    /// <param name="scriptDataVersion">Advanced usage - controls the data version of the script (optional)</param>
    /// <param name="divisionIds">Filters scripts to requested divisionIds (optional)</param>
    /// <returns>Task of ApiResponse (ScriptEntityListing)</returns>

    public async Task<ApiResponse<ScriptEntityListing>> GetScriptsDivisionviewsAsyncWithHttpInfo(int? pageSize = null, int? pageNumber = null, string expand = null, string name = null, string feature = null, string flowId = null, string sortBy = null, string sortOrder = null, string scriptDataVersion = null, string divisionIds = null)
    {

        var localVarPath = "/api/v2/scripts/divisionviews";
        var localVarPathParams = new Dictionary<string, string>();
        var localVarQueryParams = new List<Tuple<string, string>>();
        var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<string, string>();
        var localVarFileParams = new Dictionary<string, FileParameter>();
        object localVarPostBody = null;

        // to determine the Content-Type header
        string[] localVarHttpContentTypes = new string[] {
            "application/json"
        };
        string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        string[] localVarHttpHeaderAccepts = new string[] {

            "application/json"


        };
        string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params
        if (pageSize != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("pageSize", Configuration.ApiClient.ParameterToString(pageSize)));
        }

        if (pageNumber != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)));
        }

        if (expand != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("expand", Configuration.ApiClient.ParameterToString(expand)));
        }

        if (name != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("name", Configuration.ApiClient.ParameterToString(name)));
        }

        if (feature != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("feature", Configuration.ApiClient.ParameterToString(feature)));
        }

        if (flowId != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("flowId", Configuration.ApiClient.ParameterToString(flowId)));
        }

        if (sortBy != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("sortBy", Configuration.ApiClient.ParameterToString(sortBy)));
        }

        if (sortOrder != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)));
        }

        if (scriptDataVersion != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("scriptDataVersion", Configuration.ApiClient.ParameterToString(scriptDataVersion)));
        }

        if (divisionIds != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("divisionIds", Configuration.ApiClient.ParameterToString(divisionIds)));
        }

        // Header params

        // Form params

        // Body param


        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!string.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
            Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => string.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetScriptsDivisionviews: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetScriptsDivisionviews: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<ScriptEntityListing>(localVarStatusCode,
            localVarHeaders,
            (ScriptEntityListing)Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScriptEntityListing)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Get the published scripts. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <param name="expand">Expand (optional)</param>
    /// <param name="name">Name filter (optional)</param>
    /// <param name="feature">Feature filter (optional)</param>
    /// <param name="flowId">Secure flow id filter (optional)</param>
    /// <param name="scriptDataVersion">Advanced usage - controls the data version of the script (optional)</param>
    /// <param name="divisionIds">Filters scripts to requested divisionIds (optional)</param>
    /// <returns>ScriptEntityListing</returns>

    public ScriptEntityListing GetScriptsPublished(int? pageSize = null, int? pageNumber = null, string expand = null, string name = null, string feature = null, string flowId = null, string scriptDataVersion = null, string divisionIds = null)
    {
        ApiResponse<ScriptEntityListing> localVarResponse = GetScriptsPublishedWithHttpInfo(pageSize, pageNumber, expand, name, feature, flowId, scriptDataVersion, divisionIds);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get the published scripts. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <param name="expand">Expand (optional)</param>
    /// <param name="name">Name filter (optional)</param>
    /// <param name="feature">Feature filter (optional)</param>
    /// <param name="flowId">Secure flow id filter (optional)</param>
    /// <param name="scriptDataVersion">Advanced usage - controls the data version of the script (optional)</param>
    /// <param name="divisionIds">Filters scripts to requested divisionIds (optional)</param>
    /// <returns>ApiResponse of ScriptEntityListing</returns>

    public ApiResponse<ScriptEntityListing> GetScriptsPublishedWithHttpInfo(int? pageSize = null, int? pageNumber = null, string expand = null, string name = null, string feature = null, string flowId = null, string scriptDataVersion = null, string divisionIds = null)
    {

        var localVarPath = "/api/v2/scripts/published";
        var localVarPathParams = new Dictionary<string, string>();
        var localVarQueryParams = new List<Tuple<string, string>>();
        var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<string, string>();
        var localVarFileParams = new Dictionary<string, FileParameter>();
        object localVarPostBody = null;

        // to determine the Content-Type header
        string[] localVarHttpContentTypes = new string[] {
            "application/json"
        };
        string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        string[] localVarHttpHeaderAccepts = new string[] {

            "application/json"


        };
        string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params
        if (pageSize != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("pageSize", Configuration.ApiClient.ParameterToString(pageSize)));
        }

        if (pageNumber != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)));
        }

        if (expand != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("expand", Configuration.ApiClient.ParameterToString(expand)));
        }

        if (name != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("name", Configuration.ApiClient.ParameterToString(name)));
        }

        if (feature != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("feature", Configuration.ApiClient.ParameterToString(feature)));
        }

        if (flowId != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("flowId", Configuration.ApiClient.ParameterToString(flowId)));
        }

        if (scriptDataVersion != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("scriptDataVersion", Configuration.ApiClient.ParameterToString(scriptDataVersion)));
        }

        if (divisionIds != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("divisionIds", Configuration.ApiClient.ParameterToString(divisionIds)));
        }

        // Header params

        // Form params

        // Body param


        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!string.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)Configuration.ApiClient.CallApi(localVarPath,
            Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => string.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetScriptsPublished: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetScriptsPublished: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<ScriptEntityListing>(localVarStatusCode,
            localVarHeaders,
            (ScriptEntityListing)Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScriptEntityListing)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Get the published scripts. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <param name="expand">Expand (optional)</param>
    /// <param name="name">Name filter (optional)</param>
    /// <param name="feature">Feature filter (optional)</param>
    /// <param name="flowId">Secure flow id filter (optional)</param>
    /// <param name="scriptDataVersion">Advanced usage - controls the data version of the script (optional)</param>
    /// <param name="divisionIds">Filters scripts to requested divisionIds (optional)</param>
    /// <returns>Task of ScriptEntityListing</returns>

    public async Task<ScriptEntityListing> GetScriptsPublishedAsync(int? pageSize = null, int? pageNumber = null, string expand = null, string name = null, string feature = null, string flowId = null, string scriptDataVersion = null, string divisionIds = null)
    {
        ApiResponse<ScriptEntityListing> localVarResponse = await GetScriptsPublishedAsyncWithHttpInfo(pageSize, pageNumber, expand, name, feature, flowId, scriptDataVersion, divisionIds);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Get the published scripts. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <param name="expand">Expand (optional)</param>
    /// <param name="name">Name filter (optional)</param>
    /// <param name="feature">Feature filter (optional)</param>
    /// <param name="flowId">Secure flow id filter (optional)</param>
    /// <param name="scriptDataVersion">Advanced usage - controls the data version of the script (optional)</param>
    /// <param name="divisionIds">Filters scripts to requested divisionIds (optional)</param>
    /// <returns>Task of ApiResponse (ScriptEntityListing)</returns>

    public async Task<ApiResponse<ScriptEntityListing>> GetScriptsPublishedAsyncWithHttpInfo(int? pageSize = null, int? pageNumber = null, string expand = null, string name = null, string feature = null, string flowId = null, string scriptDataVersion = null, string divisionIds = null)
    {

        var localVarPath = "/api/v2/scripts/published";
        var localVarPathParams = new Dictionary<string, string>();
        var localVarQueryParams = new List<Tuple<string, string>>();
        var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<string, string>();
        var localVarFileParams = new Dictionary<string, FileParameter>();
        object localVarPostBody = null;

        // to determine the Content-Type header
        string[] localVarHttpContentTypes = new string[] {
            "application/json"
        };
        string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        string[] localVarHttpHeaderAccepts = new string[] {

            "application/json"


        };
        string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params
        if (pageSize != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("pageSize", Configuration.ApiClient.ParameterToString(pageSize)));
        }

        if (pageNumber != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)));
        }

        if (expand != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("expand", Configuration.ApiClient.ParameterToString(expand)));
        }

        if (name != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("name", Configuration.ApiClient.ParameterToString(name)));
        }

        if (feature != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("feature", Configuration.ApiClient.ParameterToString(feature)));
        }

        if (flowId != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("flowId", Configuration.ApiClient.ParameterToString(flowId)));
        }

        if (scriptDataVersion != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("scriptDataVersion", Configuration.ApiClient.ParameterToString(scriptDataVersion)));
        }

        if (divisionIds != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("divisionIds", Configuration.ApiClient.ParameterToString(divisionIds)));
        }

        // Header params

        // Form params

        // Body param


        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!string.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
            Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => string.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetScriptsPublished: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetScriptsPublished: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<ScriptEntityListing>(localVarStatusCode,
            localVarHeaders,
            (ScriptEntityListing)Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScriptEntityListing)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Get the published scripts metadata. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <param name="expand">Expand (optional)</param>
    /// <param name="name">Name filter (optional)</param>
    /// <param name="feature">Feature filter (optional)</param>
    /// <param name="flowId">Secure flow id filter (optional)</param>
    /// <param name="scriptDataVersion">Advanced usage - controls the data version of the script (optional)</param>
    /// <param name="divisionIds">Filters scripts to requested divisionIds (optional)</param>
    /// <returns>ScriptEntityListing</returns>

    public ScriptEntityListing GetScriptsPublishedDivisionviews(int? pageSize = null, int? pageNumber = null, string expand = null, string name = null, string feature = null, string flowId = null, string scriptDataVersion = null, string divisionIds = null)
    {
        ApiResponse<ScriptEntityListing> localVarResponse = GetScriptsPublishedDivisionviewsWithHttpInfo(pageSize, pageNumber, expand, name, feature, flowId, scriptDataVersion, divisionIds);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get the published scripts metadata. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <param name="expand">Expand (optional)</param>
    /// <param name="name">Name filter (optional)</param>
    /// <param name="feature">Feature filter (optional)</param>
    /// <param name="flowId">Secure flow id filter (optional)</param>
    /// <param name="scriptDataVersion">Advanced usage - controls the data version of the script (optional)</param>
    /// <param name="divisionIds">Filters scripts to requested divisionIds (optional)</param>
    /// <returns>ApiResponse of ScriptEntityListing</returns>

    public ApiResponse<ScriptEntityListing> GetScriptsPublishedDivisionviewsWithHttpInfo(int? pageSize = null, int? pageNumber = null, string expand = null, string name = null, string feature = null, string flowId = null, string scriptDataVersion = null, string divisionIds = null)
    {

        var localVarPath = "/api/v2/scripts/published/divisionviews";
        var localVarPathParams = new Dictionary<string, string>();
        var localVarQueryParams = new List<Tuple<string, string>>();
        var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<string, string>();
        var localVarFileParams = new Dictionary<string, FileParameter>();
        object localVarPostBody = null;

        // to determine the Content-Type header
        string[] localVarHttpContentTypes = new string[] {
            "application/json"
        };
        string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        string[] localVarHttpHeaderAccepts = new string[] {

            "application/json"


        };
        string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params
        if (pageSize != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("pageSize", Configuration.ApiClient.ParameterToString(pageSize)));
        }

        if (pageNumber != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)));
        }

        if (expand != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("expand", Configuration.ApiClient.ParameterToString(expand)));
        }

        if (name != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("name", Configuration.ApiClient.ParameterToString(name)));
        }

        if (feature != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("feature", Configuration.ApiClient.ParameterToString(feature)));
        }

        if (flowId != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("flowId", Configuration.ApiClient.ParameterToString(flowId)));
        }

        if (scriptDataVersion != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("scriptDataVersion", Configuration.ApiClient.ParameterToString(scriptDataVersion)));
        }

        if (divisionIds != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("divisionIds", Configuration.ApiClient.ParameterToString(divisionIds)));
        }

        // Header params

        // Form params

        // Body param


        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!string.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)Configuration.ApiClient.CallApi(localVarPath,
            Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => string.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetScriptsPublishedDivisionviews: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetScriptsPublishedDivisionviews: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<ScriptEntityListing>(localVarStatusCode,
            localVarHeaders,
            (ScriptEntityListing)Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScriptEntityListing)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Get the published scripts metadata. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <param name="expand">Expand (optional)</param>
    /// <param name="name">Name filter (optional)</param>
    /// <param name="feature">Feature filter (optional)</param>
    /// <param name="flowId">Secure flow id filter (optional)</param>
    /// <param name="scriptDataVersion">Advanced usage - controls the data version of the script (optional)</param>
    /// <param name="divisionIds">Filters scripts to requested divisionIds (optional)</param>
    /// <returns>Task of ScriptEntityListing</returns>

    public async Task<ScriptEntityListing> GetScriptsPublishedDivisionviewsAsync(int? pageSize = null, int? pageNumber = null, string expand = null, string name = null, string feature = null, string flowId = null, string scriptDataVersion = null, string divisionIds = null)
    {
        ApiResponse<ScriptEntityListing> localVarResponse = await GetScriptsPublishedDivisionviewsAsyncWithHttpInfo(pageSize, pageNumber, expand, name, feature, flowId, scriptDataVersion, divisionIds);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Get the published scripts metadata. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <param name="expand">Expand (optional)</param>
    /// <param name="name">Name filter (optional)</param>
    /// <param name="feature">Feature filter (optional)</param>
    /// <param name="flowId">Secure flow id filter (optional)</param>
    /// <param name="scriptDataVersion">Advanced usage - controls the data version of the script (optional)</param>
    /// <param name="divisionIds">Filters scripts to requested divisionIds (optional)</param>
    /// <returns>Task of ApiResponse (ScriptEntityListing)</returns>

    public async Task<ApiResponse<ScriptEntityListing>> GetScriptsPublishedDivisionviewsAsyncWithHttpInfo(int? pageSize = null, int? pageNumber = null, string expand = null, string name = null, string feature = null, string flowId = null, string scriptDataVersion = null, string divisionIds = null)
    {

        var localVarPath = "/api/v2/scripts/published/divisionviews";
        var localVarPathParams = new Dictionary<string, string>();
        var localVarQueryParams = new List<Tuple<string, string>>();
        var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<string, string>();
        var localVarFileParams = new Dictionary<string, FileParameter>();
        object localVarPostBody = null;

        // to determine the Content-Type header
        string[] localVarHttpContentTypes = new string[] {
            "application/json"
        };
        string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        string[] localVarHttpHeaderAccepts = new string[] {

            "application/json"


        };
        string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params
        if (pageSize != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("pageSize", Configuration.ApiClient.ParameterToString(pageSize)));
        }

        if (pageNumber != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)));
        }

        if (expand != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("expand", Configuration.ApiClient.ParameterToString(expand)));
        }

        if (name != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("name", Configuration.ApiClient.ParameterToString(name)));
        }

        if (feature != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("feature", Configuration.ApiClient.ParameterToString(feature)));
        }

        if (flowId != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("flowId", Configuration.ApiClient.ParameterToString(flowId)));
        }

        if (scriptDataVersion != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("scriptDataVersion", Configuration.ApiClient.ParameterToString(scriptDataVersion)));
        }

        if (divisionIds != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("divisionIds", Configuration.ApiClient.ParameterToString(divisionIds)));
        }

        // Header params

        // Form params

        // Body param


        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!string.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
            Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => string.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetScriptsPublishedDivisionviews: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetScriptsPublishedDivisionviews: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<ScriptEntityListing>(localVarStatusCode,
            localVarHeaders,
            (ScriptEntityListing)Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScriptEntityListing)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Get the published script. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="scriptId">Script ID</param>
    /// <param name="scriptDataVersion">Advanced usage - controls the data version of the script (optional)</param>
    /// <returns>Script</returns>

    public Script GetScriptsPublishedScriptId(string scriptId, string scriptDataVersion = null)
    {
        ApiResponse<Script> localVarResponse = GetScriptsPublishedScriptIdWithHttpInfo(scriptId, scriptDataVersion);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get the published script. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="scriptId">Script ID</param>
    /// <param name="scriptDataVersion">Advanced usage - controls the data version of the script (optional)</param>
    /// <returns>ApiResponse of Script</returns>

    public ApiResponse<Script> GetScriptsPublishedScriptIdWithHttpInfo(string scriptId, string scriptDataVersion = null)
    {
        // verify the required parameter 'scriptId' is set
        if (scriptId == null)
        {
            throw new ApiException(400, "Missing required parameter 'scriptId' when calling ScriptsApi->GetScriptsPublishedScriptId");
        }

        var localVarPath = "/api/v2/scripts/published/{scriptId}";
        var localVarPathParams = new Dictionary<string, string>();
        var localVarQueryParams = new List<Tuple<string, string>>();
        var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<string, string>();
        var localVarFileParams = new Dictionary<string, FileParameter>();
        object localVarPostBody = null;

        // to determine the Content-Type header
        string[] localVarHttpContentTypes = new string[] {
            "application/json"
        };
        string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        string[] localVarHttpHeaderAccepts = new string[] {

            "application/json"


        };
        string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params
        if (scriptId != null)
        {
            localVarPathParams.Add("scriptId", Configuration.ApiClient.ParameterToString(scriptId));
        }

        // Query params
        if (scriptDataVersion != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("scriptDataVersion", Configuration.ApiClient.ParameterToString(scriptDataVersion)));
        }

        // Header params

        // Form params

        // Body param


        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!string.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)Configuration.ApiClient.CallApi(localVarPath,
            Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => string.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetScriptsPublishedScriptId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetScriptsPublishedScriptId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<Script>(localVarStatusCode,
            localVarHeaders,
            (Script)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Script)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Get the published script. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="scriptId">Script ID</param>
    /// <param name="scriptDataVersion">Advanced usage - controls the data version of the script (optional)</param>
    /// <returns>Task of Script</returns>

    public async Task<Script> GetScriptsPublishedScriptIdAsync(string scriptId, string scriptDataVersion = null)
    {
        ApiResponse<Script> localVarResponse = await GetScriptsPublishedScriptIdAsyncWithHttpInfo(scriptId, scriptDataVersion);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Get the published script. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="scriptId">Script ID</param>
    /// <param name="scriptDataVersion">Advanced usage - controls the data version of the script (optional)</param>
    /// <returns>Task of ApiResponse (Script)</returns>

    public async Task<ApiResponse<Script>> GetScriptsPublishedScriptIdAsyncWithHttpInfo(string scriptId, string scriptDataVersion = null)
    {
        // verify the required parameter 'scriptId' is set
        if (scriptId == null)
        {
            throw new ApiException(400, "Missing required parameter 'scriptId' when calling ScriptsApi->GetScriptsPublishedScriptId");
        }

        var localVarPath = "/api/v2/scripts/published/{scriptId}";
        var localVarPathParams = new Dictionary<string, string>();
        var localVarQueryParams = new List<Tuple<string, string>>();
        var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<string, string>();
        var localVarFileParams = new Dictionary<string, FileParameter>();
        object localVarPostBody = null;

        // to determine the Content-Type header
        string[] localVarHttpContentTypes = new string[] {
            "application/json"
        };
        string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        string[] localVarHttpHeaderAccepts = new string[] {

            "application/json"


        };
        string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params
        if (scriptId != null)
        {
            localVarPathParams.Add("scriptId", Configuration.ApiClient.ParameterToString(scriptId));
        }

        // Query params
        if (scriptDataVersion != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("scriptDataVersion", Configuration.ApiClient.ParameterToString(scriptDataVersion)));
        }

        // Header params

        // Form params

        // Body param


        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!string.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
            Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => string.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetScriptsPublishedScriptId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetScriptsPublishedScriptId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<Script>(localVarStatusCode,
            localVarHeaders,
            (Script)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Script)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Get the published page. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="scriptId">Script ID</param>
    /// <param name="pageId">Page ID</param>
    /// <param name="scriptDataVersion">Advanced usage - controls the data version of the script (optional)</param>
    /// <returns>Page</returns>

    public Page GetScriptsPublishedScriptIdPage(string scriptId, string pageId, string scriptDataVersion = null)
    {
        ApiResponse<Page> localVarResponse = GetScriptsPublishedScriptIdPageWithHttpInfo(scriptId, pageId, scriptDataVersion);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get the published page. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="scriptId">Script ID</param>
    /// <param name="pageId">Page ID</param>
    /// <param name="scriptDataVersion">Advanced usage - controls the data version of the script (optional)</param>
    /// <returns>ApiResponse of Page</returns>

    public ApiResponse<Page> GetScriptsPublishedScriptIdPageWithHttpInfo(string scriptId, string pageId, string scriptDataVersion = null)
    {
        // verify the required parameter 'scriptId' is set
        if (scriptId == null)
        {
            throw new ApiException(400, "Missing required parameter 'scriptId' when calling ScriptsApi->GetScriptsPublishedScriptIdPage");
        }
        // verify the required parameter 'pageId' is set
        if (pageId == null)
        {
            throw new ApiException(400, "Missing required parameter 'pageId' when calling ScriptsApi->GetScriptsPublishedScriptIdPage");
        }

        var localVarPath = "/api/v2/scripts/published/{scriptId}/pages/{pageId}";
        var localVarPathParams = new Dictionary<string, string>();
        var localVarQueryParams = new List<Tuple<string, string>>();
        var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<string, string>();
        var localVarFileParams = new Dictionary<string, FileParameter>();
        object localVarPostBody = null;

        // to determine the Content-Type header
        string[] localVarHttpContentTypes = new string[] {
            "application/json"
        };
        string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        string[] localVarHttpHeaderAccepts = new string[] {

            "application/json"


        };
        string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params
        if (scriptId != null)
        {
            localVarPathParams.Add("scriptId", Configuration.ApiClient.ParameterToString(scriptId));
        }

        if (pageId != null)
        {
            localVarPathParams.Add("pageId", Configuration.ApiClient.ParameterToString(pageId));
        }

        // Query params
        if (scriptDataVersion != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("scriptDataVersion", Configuration.ApiClient.ParameterToString(scriptDataVersion)));
        }

        // Header params

        // Form params

        // Body param


        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!string.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)Configuration.ApiClient.CallApi(localVarPath,
            Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => string.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetScriptsPublishedScriptIdPage: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetScriptsPublishedScriptIdPage: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<Page>(localVarStatusCode,
            localVarHeaders,
            (Page)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Page)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Get the published page. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="scriptId">Script ID</param>
    /// <param name="pageId">Page ID</param>
    /// <param name="scriptDataVersion">Advanced usage - controls the data version of the script (optional)</param>
    /// <returns>Task of Page</returns>

    public async Task<Page> GetScriptsPublishedScriptIdPageAsync(string scriptId, string pageId, string scriptDataVersion = null)
    {
        ApiResponse<Page> localVarResponse = await GetScriptsPublishedScriptIdPageAsyncWithHttpInfo(scriptId, pageId, scriptDataVersion);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Get the published page. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="scriptId">Script ID</param>
    /// <param name="pageId">Page ID</param>
    /// <param name="scriptDataVersion">Advanced usage - controls the data version of the script (optional)</param>
    /// <returns>Task of ApiResponse (Page)</returns>

    public async Task<ApiResponse<Page>> GetScriptsPublishedScriptIdPageAsyncWithHttpInfo(string scriptId, string pageId, string scriptDataVersion = null)
    {
        // verify the required parameter 'scriptId' is set
        if (scriptId == null)
        {
            throw new ApiException(400, "Missing required parameter 'scriptId' when calling ScriptsApi->GetScriptsPublishedScriptIdPage");
        }

        // verify the required parameter 'pageId' is set
        if (pageId == null)
        {
            throw new ApiException(400, "Missing required parameter 'pageId' when calling ScriptsApi->GetScriptsPublishedScriptIdPage");
        }

        var localVarPath = "/api/v2/scripts/published/{scriptId}/pages/{pageId}";
        var localVarPathParams = new Dictionary<string, string>();
        var localVarQueryParams = new List<Tuple<string, string>>();
        var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<string, string>();
        var localVarFileParams = new Dictionary<string, FileParameter>();
        object localVarPostBody = null;

        // to determine the Content-Type header
        string[] localVarHttpContentTypes = new string[] {
            "application/json"
        };
        string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        string[] localVarHttpHeaderAccepts = new string[] {

            "application/json"


        };
        string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params
        if (scriptId != null)
        {
            localVarPathParams.Add("scriptId", Configuration.ApiClient.ParameterToString(scriptId));
        }

        if (pageId != null)
        {
            localVarPathParams.Add("pageId", Configuration.ApiClient.ParameterToString(pageId));
        }

        // Query params
        if (scriptDataVersion != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("scriptDataVersion", Configuration.ApiClient.ParameterToString(scriptDataVersion)));
        }

        // Header params

        // Form params

        // Body param


        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!string.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
            Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => string.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetScriptsPublishedScriptIdPage: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetScriptsPublishedScriptIdPage: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<Page>(localVarStatusCode,
            localVarHeaders,
            (Page)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Page)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Get the list of published pages 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="scriptId">Script ID</param>
    /// <param name="scriptDataVersion">Advanced usage - controls the data version of the script (optional)</param>
    /// <returns>List&lt;Page&gt;</returns>

    public List<Page> GetScriptsPublishedScriptIdPages(string scriptId, string scriptDataVersion = null)
    {
        ApiResponse<List<Page>> localVarResponse = GetScriptsPublishedScriptIdPagesWithHttpInfo(scriptId, scriptDataVersion);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get the list of published pages 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="scriptId">Script ID</param>
    /// <param name="scriptDataVersion">Advanced usage - controls the data version of the script (optional)</param>
    /// <returns>ApiResponse of List&lt;Page&gt;</returns>

    public ApiResponse<List<Page>> GetScriptsPublishedScriptIdPagesWithHttpInfo(string scriptId, string scriptDataVersion = null)
    {
        // verify the required parameter 'scriptId' is set
        if (scriptId == null)
        {
            throw new ApiException(400, "Missing required parameter 'scriptId' when calling ScriptsApi->GetScriptsPublishedScriptIdPages");
        }

        var localVarPath = "/api/v2/scripts/published/{scriptId}/pages";
        var localVarPathParams = new Dictionary<string, string>();
        var localVarQueryParams = new List<Tuple<string, string>>();
        var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<string, string>();
        var localVarFileParams = new Dictionary<string, FileParameter>();
        object localVarPostBody = null;

        // to determine the Content-Type header
        string[] localVarHttpContentTypes = new string[] {
            "application/json"
        };
        string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        string[] localVarHttpHeaderAccepts = new string[] {

            "application/json"


        };
        string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params
        if (scriptId != null)
        {
            localVarPathParams.Add("scriptId", Configuration.ApiClient.ParameterToString(scriptId));
        }

        // Query params
        if (scriptDataVersion != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("scriptDataVersion", Configuration.ApiClient.ParameterToString(scriptDataVersion)));
        }

        // Header params

        // Form params

        // Body param


        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!string.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)Configuration.ApiClient.CallApi(localVarPath,
            Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => string.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetScriptsPublishedScriptIdPages: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetScriptsPublishedScriptIdPages: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<List<Page>>(localVarStatusCode,
            localVarHeaders,
            (List<Page>)Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Page>)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Get the list of published pages 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="scriptId">Script ID</param>
    /// <param name="scriptDataVersion">Advanced usage - controls the data version of the script (optional)</param>
    /// <returns>Task of List&lt;Page&gt;</returns>

    public async Task<List<Page>> GetScriptsPublishedScriptIdPagesAsync(string scriptId, string scriptDataVersion = null)
    {
        ApiResponse<List<Page>> localVarResponse = await GetScriptsPublishedScriptIdPagesAsyncWithHttpInfo(scriptId, scriptDataVersion);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Get the list of published pages 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="scriptId">Script ID</param>
    /// <param name="scriptDataVersion">Advanced usage - controls the data version of the script (optional)</param>
    /// <returns>Task of ApiResponse (List&lt;Page&gt;)</returns>

    public async Task<ApiResponse<List<Page>>> GetScriptsPublishedScriptIdPagesAsyncWithHttpInfo(string scriptId, string scriptDataVersion = null)
    {
        // verify the required parameter 'scriptId' is set
        if (scriptId == null)
        {
            throw new ApiException(400, "Missing required parameter 'scriptId' when calling ScriptsApi->GetScriptsPublishedScriptIdPages");
        }

        var localVarPath = "/api/v2/scripts/published/{scriptId}/pages";
        var localVarPathParams = new Dictionary<string, string>();
        var localVarQueryParams = new List<Tuple<string, string>>();
        var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<string, string>();
        var localVarFileParams = new Dictionary<string, FileParameter>();
        object localVarPostBody = null;

        // to determine the Content-Type header
        string[] localVarHttpContentTypes = new string[] {
            "application/json"
        };
        string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        string[] localVarHttpHeaderAccepts = new string[] {

            "application/json"


        };
        string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params
        if (scriptId != null)
        {
            localVarPathParams.Add("scriptId", Configuration.ApiClient.ParameterToString(scriptId));
        }

        // Query params
        if (scriptDataVersion != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("scriptDataVersion", Configuration.ApiClient.ParameterToString(scriptDataVersion)));
        }

        // Header params

        // Form params

        // Body param


        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!string.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
            Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => string.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetScriptsPublishedScriptIdPages: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetScriptsPublishedScriptIdPages: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<List<Page>>(localVarStatusCode,
            localVarHeaders,
            (List<Page>)Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Page>)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Get the published variables 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="scriptId">Script ID</param>
    /// <param name="input">input (optional)</param>
    /// <param name="output">output (optional)</param>
    /// <param name="type">type (optional)</param>
    /// <param name="scriptDataVersion">Advanced usage - controls the data version of the script (optional)</param>
    /// <returns>Object</returns>

    public object GetScriptsPublishedScriptIdVariables(string scriptId, string input = null, string output = null, string type = null, string scriptDataVersion = null)
    {
        ApiResponse<object> localVarResponse = GetScriptsPublishedScriptIdVariablesWithHttpInfo(scriptId, input, output, type, scriptDataVersion);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get the published variables 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="scriptId">Script ID</param>
    /// <param name="input">input (optional)</param>
    /// <param name="output">output (optional)</param>
    /// <param name="type">type (optional)</param>
    /// <param name="scriptDataVersion">Advanced usage - controls the data version of the script (optional)</param>
    /// <returns>ApiResponse of Object</returns>

    public ApiResponse<object> GetScriptsPublishedScriptIdVariablesWithHttpInfo(string scriptId, string input = null, string output = null, string type = null, string scriptDataVersion = null)
    {
        // verify the required parameter 'scriptId' is set
        if (scriptId == null)
        {
            throw new ApiException(400, "Missing required parameter 'scriptId' when calling ScriptsApi->GetScriptsPublishedScriptIdVariables");
        }

        var localVarPath = "/api/v2/scripts/published/{scriptId}/variables";
        var localVarPathParams = new Dictionary<string, string>();
        var localVarQueryParams = new List<Tuple<string, string>>();
        var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<string, string>();
        var localVarFileParams = new Dictionary<string, FileParameter>();
        object localVarPostBody = null;

        // to determine the Content-Type header
        string[] localVarHttpContentTypes = new string[] {
            "application/json"
        };
        string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        string[] localVarHttpHeaderAccepts = new string[] {

            "application/json"


        };
        string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params
        if (scriptId != null)
        {
            localVarPathParams.Add("scriptId", Configuration.ApiClient.ParameterToString(scriptId));
        }

        // Query params
        if (input != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("input", Configuration.ApiClient.ParameterToString(input)));
        }

        if (output != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("output", Configuration.ApiClient.ParameterToString(output)));
        }

        if (type != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("type", Configuration.ApiClient.ParameterToString(type)));
        }

        if (scriptDataVersion != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("scriptDataVersion", Configuration.ApiClient.ParameterToString(scriptDataVersion)));
        }

        // Header params

        // Form params

        // Body param


        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!string.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)Configuration.ApiClient.CallApi(localVarPath,
            Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => string.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetScriptsPublishedScriptIdVariables: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetScriptsPublishedScriptIdVariables: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<object>(localVarStatusCode,
            localVarHeaders,
            (object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(object)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Get the published variables 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="scriptId">Script ID</param>
    /// <param name="input">input (optional)</param>
    /// <param name="output">output (optional)</param>
    /// <param name="type">type (optional)</param>
    /// <param name="scriptDataVersion">Advanced usage - controls the data version of the script (optional)</param>
    /// <returns>Task of Object</returns>

    public async Task<object> GetScriptsPublishedScriptIdVariablesAsync(string scriptId, string input = null, string output = null, string type = null, string scriptDataVersion = null)
    {
        ApiResponse<object> localVarResponse = await GetScriptsPublishedScriptIdVariablesAsyncWithHttpInfo(scriptId, input, output, type, scriptDataVersion);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Get the published variables 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="scriptId">Script ID</param>
    /// <param name="input">input (optional)</param>
    /// <param name="output">output (optional)</param>
    /// <param name="type">type (optional)</param>
    /// <param name="scriptDataVersion">Advanced usage - controls the data version of the script (optional)</param>
    /// <returns>Task of ApiResponse (Object)</returns>

    public async Task<ApiResponse<object>> GetScriptsPublishedScriptIdVariablesAsyncWithHttpInfo(string scriptId, string input = null, string output = null, string type = null, string scriptDataVersion = null)
    {
        // verify the required parameter 'scriptId' is set
        if (scriptId == null)
        {
            throw new ApiException(400, "Missing required parameter 'scriptId' when calling ScriptsApi->GetScriptsPublishedScriptIdVariables");
        }

        var localVarPath = "/api/v2/scripts/published/{scriptId}/variables";
        var localVarPathParams = new Dictionary<string, string>();
        var localVarQueryParams = new List<Tuple<string, string>>();
        var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<string, string>();
        var localVarFileParams = new Dictionary<string, FileParameter>();
        object localVarPostBody = null;

        // to determine the Content-Type header
        string[] localVarHttpContentTypes = new string[] {
            "application/json"
        };
        string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        string[] localVarHttpHeaderAccepts = new string[] {

            "application/json"


        };
        string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params
        if (scriptId != null)
        {
            localVarPathParams.Add("scriptId", Configuration.ApiClient.ParameterToString(scriptId));
        }

        // Query params
        if (input != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("input", Configuration.ApiClient.ParameterToString(input)));
        }

        if (output != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("output", Configuration.ApiClient.ParameterToString(output)));
        }

        if (type != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("type", Configuration.ApiClient.ParameterToString(type)));
        }

        if (scriptDataVersion != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("scriptDataVersion", Configuration.ApiClient.ParameterToString(scriptDataVersion)));
        }

        // Header params

        // Form params

        // Body param


        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!string.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
            Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => string.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetScriptsPublishedScriptIdVariables: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetScriptsPublishedScriptIdVariables: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<object>(localVarStatusCode,
            localVarHeaders,
            (object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(object)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Get the upload status of an imported script 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="uploadId">Upload ID</param>
    /// <param name="longPoll">Enable longPolling endpoint (optional, default to false)</param>
    /// <returns>ImportScriptStatusResponse</returns>

    public ImportScriptStatusResponse GetScriptsUploadStatus(string uploadId, bool? longPoll = null)
    {
        ApiResponse<ImportScriptStatusResponse> localVarResponse = GetScriptsUploadStatusWithHttpInfo(uploadId, longPoll);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get the upload status of an imported script 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="uploadId">Upload ID</param>
    /// <param name="longPoll">Enable longPolling endpoint (optional, default to false)</param>
    /// <returns>ApiResponse of ImportScriptStatusResponse</returns>

    public ApiResponse<ImportScriptStatusResponse> GetScriptsUploadStatusWithHttpInfo(string uploadId, bool? longPoll = null)
    {
        // verify the required parameter 'uploadId' is set
        if (uploadId == null)
        {
            throw new ApiException(400, "Missing required parameter 'uploadId' when calling ScriptsApi->GetScriptsUploadStatus");
        }

        var localVarPath = "/api/v2/scripts/uploads/{uploadId}/status";
        var localVarPathParams = new Dictionary<string, string>();
        var localVarQueryParams = new List<Tuple<string, string>>();
        var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<string, string>();
        var localVarFileParams = new Dictionary<string, FileParameter>();
        object localVarPostBody = null;

        // to determine the Content-Type header
        string[] localVarHttpContentTypes = new string[] {
            "application/json"
        };
        string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        string[] localVarHttpHeaderAccepts = new string[] {

            "application/json"


        };
        string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params
        if (uploadId != null)
        {
            localVarPathParams.Add("uploadId", Configuration.ApiClient.ParameterToString(uploadId));
        }

        // Query params
        if (longPoll != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("longPoll", Configuration.ApiClient.ParameterToString(longPoll)));
        }

        // Header params

        // Form params

        // Body param


        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!string.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)Configuration.ApiClient.CallApi(localVarPath,
            Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => string.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetScriptsUploadStatus: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetScriptsUploadStatus: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<ImportScriptStatusResponse>(localVarStatusCode,
            localVarHeaders,
            (ImportScriptStatusResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(ImportScriptStatusResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Get the upload status of an imported script 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="uploadId">Upload ID</param>
    /// <param name="longPoll">Enable longPolling endpoint (optional, default to false)</param>
    /// <returns>Task of ImportScriptStatusResponse</returns>

    public async Task<ImportScriptStatusResponse> GetScriptsUploadStatusAsync(string uploadId, bool? longPoll = null)
    {
        ApiResponse<ImportScriptStatusResponse> localVarResponse = await GetScriptsUploadStatusAsyncWithHttpInfo(uploadId, longPoll);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Get the upload status of an imported script 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="uploadId">Upload ID</param>
    /// <param name="longPoll">Enable longPolling endpoint (optional, default to false)</param>
    /// <returns>Task of ApiResponse (ImportScriptStatusResponse)</returns>

    public async Task<ApiResponse<ImportScriptStatusResponse>> GetScriptsUploadStatusAsyncWithHttpInfo(string uploadId, bool? longPoll = null)
    {
        // verify the required parameter 'uploadId' is set
        if (uploadId == null)
        {
            throw new ApiException(400, "Missing required parameter 'uploadId' when calling ScriptsApi->GetScriptsUploadStatus");
        }

        var localVarPath = "/api/v2/scripts/uploads/{uploadId}/status";
        var localVarPathParams = new Dictionary<string, string>();
        var localVarQueryParams = new List<Tuple<string, string>>();
        var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<string, string>();
        var localVarFileParams = new Dictionary<string, FileParameter>();
        object localVarPostBody = null;

        // to determine the Content-Type header
        string[] localVarHttpContentTypes = new string[] {
            "application/json"
        };
        string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        string[] localVarHttpHeaderAccepts = new string[] {

            "application/json"


        };
        string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params
        if (uploadId != null)
        {
            localVarPathParams.Add("uploadId", Configuration.ApiClient.ParameterToString(uploadId));
        }

        // Query params
        if (longPoll != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("longPoll", Configuration.ApiClient.ParameterToString(longPoll)));
        }

        // Header params

        // Form params

        // Body param


        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!string.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
            Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => string.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetScriptsUploadStatus: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetScriptsUploadStatus: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<ImportScriptStatusResponse>(localVarStatusCode,
            localVarHeaders,
            (ImportScriptStatusResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(ImportScriptStatusResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Export a script via download service. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="scriptId">Script ID</param>
    /// <param name="body"> (optional)</param>
    /// <returns>ExportScriptResponse</returns>

    public ExportScriptResponse PostScriptExport(string scriptId, ExportScriptRequest body = null)
    {
        ApiResponse<ExportScriptResponse> localVarResponse = PostScriptExportWithHttpInfo(scriptId, body);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Export a script via download service. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="scriptId">Script ID</param>
    /// <param name="body"> (optional)</param>
    /// <returns>ApiResponse of ExportScriptResponse</returns>

    public ApiResponse<ExportScriptResponse> PostScriptExportWithHttpInfo(string scriptId, ExportScriptRequest body = null)
    {
        // verify the required parameter 'scriptId' is set
        if (scriptId == null)
        {
            throw new ApiException(400, "Missing required parameter 'scriptId' when calling ScriptsApi->PostScriptExport");
        }

        var localVarPath = "/api/v2/scripts/{scriptId}/export";
        var localVarPathParams = new Dictionary<string, string>();
        var localVarQueryParams = new List<Tuple<string, string>>();
        var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<string, string>();
        var localVarFileParams = new Dictionary<string, FileParameter>();
        object localVarPostBody = null;

        // to determine the Content-Type header
        string[] localVarHttpContentTypes = new string[] {
            "application/json"

        };
        string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        string[] localVarHttpHeaderAccepts = new string[] {

            "application/json"


        };
        string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params
        if (scriptId != null)
        {
            localVarPathParams.Add("scriptId", Configuration.ApiClient.ParameterToString(scriptId));
        }

        // Query params

        // Header params

        // Form params

        // Body param
        if (body != null && body.GetType() != typeof(byte[]))
        {
            localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
        }
        else
        {
            localVarPostBody = body; // byte array
        }



        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!string.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)Configuration.ApiClient.CallApi(localVarPath,
            Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => string.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostScriptExport: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostScriptExport: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<ExportScriptResponse>(localVarStatusCode,
            localVarHeaders,
            (ExportScriptResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(ExportScriptResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Export a script via download service. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="scriptId">Script ID</param>
    /// <param name="body"> (optional)</param>
    /// <returns>Task of ExportScriptResponse</returns>

    public async Task<ExportScriptResponse> PostScriptExportAsync(string scriptId, ExportScriptRequest body = null)
    {
        ApiResponse<ExportScriptResponse> localVarResponse = await PostScriptExportAsyncWithHttpInfo(scriptId, body);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Export a script via download service. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="scriptId">Script ID</param>
    /// <param name="body"> (optional)</param>
    /// <returns>Task of ApiResponse (ExportScriptResponse)</returns>

    public async Task<ApiResponse<ExportScriptResponse>> PostScriptExportAsyncWithHttpInfo(string scriptId, ExportScriptRequest body = null)
    {
        // verify the required parameter 'scriptId' is set
        if (scriptId == null)
        {
            throw new ApiException(400, "Missing required parameter 'scriptId' when calling ScriptsApi->PostScriptExport");
        }

        var localVarPath = "/api/v2/scripts/{scriptId}/export";
        var localVarPathParams = new Dictionary<string, string>();
        var localVarQueryParams = new List<Tuple<string, string>>();
        var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<string, string>();
        var localVarFileParams = new Dictionary<string, FileParameter>();
        object localVarPostBody = null;

        // to determine the Content-Type header
        string[] localVarHttpContentTypes = new string[] {
            "application/json"

        };
        string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        string[] localVarHttpHeaderAccepts = new string[] {

            "application/json"


        };
        string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params
        if (scriptId != null)
        {
            localVarPathParams.Add("scriptId", Configuration.ApiClient.ParameterToString(scriptId));
        }

        // Query params

        // Header params

        // Form params

        // Body param
        if (body != null && body.GetType() != typeof(byte[]))
        {
            localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
        }
        else
        {
            localVarPostBody = body; // byte array
        }



        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!string.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
            Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => string.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostScriptExport: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostScriptExport: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<ExportScriptResponse>(localVarStatusCode,
            localVarHeaders,
            (ExportScriptResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(ExportScriptResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Publish a script. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="scriptDataVersion">Advanced usage - controls the data version of the script (optional)</param>
    /// <param name="body">body (optional)</param>
    /// <returns>Script</returns>

    public Script PostScriptsPublished(string scriptDataVersion = null, PublishScriptRequestData body = null)
    {
        ApiResponse<Script> localVarResponse = PostScriptsPublishedWithHttpInfo(scriptDataVersion, body);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Publish a script. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="scriptDataVersion">Advanced usage - controls the data version of the script (optional)</param>
    /// <param name="body">body (optional)</param>
    /// <returns>ApiResponse of Script</returns>

    public ApiResponse<Script> PostScriptsPublishedWithHttpInfo(string scriptDataVersion = null, PublishScriptRequestData body = null)
    {

        var localVarPath = "/api/v2/scripts/published";
        var localVarPathParams = new Dictionary<string, string>();
        var localVarQueryParams = new List<Tuple<string, string>>();
        var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<string, string>();
        var localVarFileParams = new Dictionary<string, FileParameter>();
        object localVarPostBody = null;

        // to determine the Content-Type header
        string[] localVarHttpContentTypes = new string[] {
            "application/json"

        };
        string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        string[] localVarHttpHeaderAccepts = new string[] {

            "application/json"


        };
        string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params
        if (scriptDataVersion != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("scriptDataVersion", Configuration.ApiClient.ParameterToString(scriptDataVersion)));
        }

        // Header params

        // Form params

        // Body param
        if (body != null && body.GetType() != typeof(byte[]))
        {
            localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
        }
        else
        {
            localVarPostBody = body; // byte array
        }



        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!string.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)Configuration.ApiClient.CallApi(localVarPath,
            Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => string.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostScriptsPublished: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostScriptsPublished: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<Script>(localVarStatusCode,
            localVarHeaders,
            (Script)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Script)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Publish a script. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="scriptDataVersion">Advanced usage - controls the data version of the script (optional)</param>
    /// <param name="body">body (optional)</param>
    /// <returns>Task of Script</returns>

    public async Task<Script> PostScriptsPublishedAsync(string scriptDataVersion = null, PublishScriptRequestData body = null)
    {
        ApiResponse<Script> localVarResponse = await PostScriptsPublishedAsyncWithHttpInfo(scriptDataVersion, body);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Publish a script. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="scriptDataVersion">Advanced usage - controls the data version of the script (optional)</param>
    /// <param name="body">body (optional)</param>
    /// <returns>Task of ApiResponse (Script)</returns>

    public async Task<ApiResponse<Script>> PostScriptsPublishedAsyncWithHttpInfo(string scriptDataVersion = null, PublishScriptRequestData body = null)
    {

        var localVarPath = "/api/v2/scripts/published";
        var localVarPathParams = new Dictionary<string, string>();
        var localVarQueryParams = new List<Tuple<string, string>>();
        var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<string, string>();
        var localVarFileParams = new Dictionary<string, FileParameter>();
        object localVarPostBody = null;

        // to determine the Content-Type header
        string[] localVarHttpContentTypes = new string[] {
            "application/json"

        };
        string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        string[] localVarHttpHeaderAccepts = new string[] {

            "application/json"


        };
        string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params
        if (scriptDataVersion != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("scriptDataVersion", Configuration.ApiClient.ParameterToString(scriptDataVersion)));
        }

        // Header params

        // Form params

        // Body param
        if (body != null && body.GetType() != typeof(byte[]))
        {
            localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
        }
        else
        {
            localVarPostBody = body; // byte array
        }



        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!string.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
            Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => string.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostScriptsPublished: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostScriptsPublished: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<Script>(localVarStatusCode,
            localVarHeaders,
            (Script)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Script)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



}
