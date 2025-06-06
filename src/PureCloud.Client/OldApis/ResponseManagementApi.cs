using PureCloud.Client.Models;
using RestSharp;

namespace PureCloud.Client.Apis;


/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IResponseManagementApi : IApiAccessor
{
    #region Synchronous Operations

    /// <summary>
    /// Delete an existing response library.
    /// </summary>
    /// <remarks>
    /// This will remove any responses associated with the library.
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="libraryId">Library ID</param>
    /// <returns></returns>

    void DeleteResponsemanagementLibrary(string libraryId);

    /// <summary>
    /// Delete an existing response library.
    /// </summary>
    /// <remarks>
    /// This will remove any responses associated with the library.
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="libraryId">Library ID</param>
    /// <returns>ApiResponse of Object(void)</returns>

    ApiResponse<object> DeleteResponsemanagementLibraryWithHttpInfo(string libraryId);

    /// <summary>
    /// Delete an existing response.
    /// </summary>
    /// <remarks>
    /// This will remove the response from any libraries associated with it.
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="responseId">Response ID</param>
    /// <returns></returns>

    void DeleteResponsemanagementResponse(string responseId);

    /// <summary>
    /// Delete an existing response.
    /// </summary>
    /// <remarks>
    /// This will remove the response from any libraries associated with it.
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="responseId">Response ID</param>
    /// <returns>ApiResponse of Object(void)</returns>

    ApiResponse<object> DeleteResponsemanagementResponseWithHttpInfo(string responseId);

    /// <summary>
    /// Delete response asset
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="responseAssetId">Asset Id</param>
    /// <returns></returns>

    void DeleteResponsemanagementResponseasset(string responseAssetId);

    /// <summary>
    /// Delete response asset
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="responseAssetId">Asset Id</param>
    /// <returns>ApiResponse of Object(void)</returns>

    ApiResponse<object> DeleteResponsemanagementResponseassetWithHttpInfo(string responseAssetId);

    /// <summary>
    /// Gets a list of existing response libraries.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="messagingTemplateFilter">Returns a list of libraries that contain responses with at least one messaging template defined for a specific message channel (optional)</param>
    /// <param name="libraryPrefix">Returns a list of libraries that contain the prefix provided (optional)</param>
    /// <returns>LibraryEntityListing</returns>

    LibraryEntityListing GetResponsemanagementLibraries(int? pageNumber = null, int? pageSize = null, string messagingTemplateFilter = null, string libraryPrefix = null);

    /// <summary>
    /// Gets a list of existing response libraries.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="messagingTemplateFilter">Returns a list of libraries that contain responses with at least one messaging template defined for a specific message channel (optional)</param>
    /// <param name="libraryPrefix">Returns a list of libraries that contain the prefix provided (optional)</param>
    /// <returns>ApiResponse of LibraryEntityListing</returns>

    ApiResponse<LibraryEntityListing> GetResponsemanagementLibrariesWithHttpInfo(int? pageNumber = null, int? pageSize = null, string messagingTemplateFilter = null, string libraryPrefix = null);

    /// <summary>
    /// Get details about an existing response library.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="libraryId">Library ID</param>
    /// <returns>Library</returns>

    Library GetResponsemanagementLibrary(string libraryId);

    /// <summary>
    /// Get details about an existing response library.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="libraryId">Library ID</param>
    /// <returns>ApiResponse of Library</returns>

    ApiResponse<Library> GetResponsemanagementLibraryWithHttpInfo(string libraryId);

    /// <summary>
    /// Get details about an existing response.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="responseId">Response ID</param>
    /// <param name="expand">Expand instructions for the return value. (optional)</param>
    /// <returns>Response</returns>

    Response GetResponsemanagementResponse(string responseId, string expand = null);

    /// <summary>
    /// Get details about an existing response.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="responseId">Response ID</param>
    /// <param name="expand">Expand instructions for the return value. (optional)</param>
    /// <returns>ApiResponse of Response</returns>

    ApiResponse<Response> GetResponsemanagementResponseWithHttpInfo(string responseId, string expand = null);

    /// <summary>
    /// Get response asset information
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="responseAssetId">Asset Id</param>
    /// <returns>ResponseAsset</returns>

    ResponseAsset GetResponsemanagementResponseasset(string responseAssetId);

    /// <summary>
    /// Get response asset information
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="responseAssetId">Asset Id</param>
    /// <returns>ApiResponse of ResponseAsset</returns>

    ApiResponse<ResponseAsset> GetResponsemanagementResponseassetWithHttpInfo(string responseAssetId);

    /// <summary>
    /// Get response asset upload status
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="statusId">Status Id</param>
    /// <returns>ResponseAssetStatus</returns>

    ResponseAssetStatus GetResponsemanagementResponseassetsStatusStatusId(string statusId);

    /// <summary>
    /// Get response asset upload status
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="statusId">Status Id</param>
    /// <returns>ApiResponse of ResponseAssetStatus</returns>

    ApiResponse<ResponseAssetStatus> GetResponsemanagementResponseassetsStatusStatusIdWithHttpInfo(string statusId);

    /// <summary>
    /// Gets a list of existing responses.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="libraryId">Library ID</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="expand">Expand instructions for the return value. (optional)</param>
    /// <returns>ResponseEntityListing</returns>

    ResponseEntityListing GetResponsemanagementResponses(string libraryId, int? pageNumber = null, int? pageSize = null, string expand = null);

    /// <summary>
    /// Gets a list of existing responses.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="libraryId">Library ID</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="expand">Expand instructions for the return value. (optional)</param>
    /// <returns>ApiResponse of ResponseEntityListing</returns>

    ApiResponse<ResponseEntityListing> GetResponsemanagementResponsesWithHttpInfo(string libraryId, int? pageNumber = null, int? pageSize = null, string expand = null);

    /// <summary>
    /// Create a response library.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Library</param>
    /// <returns>Library</returns>

    Library PostResponsemanagementLibraries(Library body);

    /// <summary>
    /// Create a response library.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Library</param>
    /// <returns>ApiResponse of Library</returns>

    ApiResponse<Library> PostResponsemanagementLibrariesWithHttpInfo(Library body);

    /// <summary>
    /// Get response libraries.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">LibraryIDs (max allowed 50)</param>
    /// <returns>LibraryEntityListing</returns>

    LibraryEntityListing PostResponsemanagementLibrariesBulk(LibraryBatchRequest body);

    /// <summary>
    /// Get response libraries.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">LibraryIDs (max allowed 50)</param>
    /// <returns>ApiResponse of LibraryEntityListing</returns>

    ApiResponse<LibraryEntityListing> PostResponsemanagementLibrariesBulkWithHttpInfo(LibraryBatchRequest body);

    /// <summary>
    /// Search response assets
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">request</param>
    /// <param name="expand">Which fields, if any, to expand (optional)</param>
    /// <returns>ResponseAssetSearchResults</returns>

    ResponseAssetSearchResults PostResponsemanagementResponseassetsSearch(ResponseAssetSearchRequest body, List<string> expand = null);

    /// <summary>
    /// Search response assets
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">request</param>
    /// <param name="expand">Which fields, if any, to expand (optional)</param>
    /// <returns>ApiResponse of ResponseAssetSearchResults</returns>

    ApiResponse<ResponseAssetSearchResults> PostResponsemanagementResponseassetsSearchWithHttpInfo(ResponseAssetSearchRequest body, List<string> expand = null);

    /// <summary>
    /// Creates pre-signed url for uploading response asset
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">request</param>
    /// <returns>CreateResponseAssetResponse</returns>

    CreateResponseAssetResponse PostResponsemanagementResponseassetsUploads(CreateResponseAssetRequest body);

    /// <summary>
    /// Creates pre-signed url for uploading response asset
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">request</param>
    /// <returns>ApiResponse of CreateResponseAssetResponse</returns>

    ApiResponse<CreateResponseAssetResponse> PostResponsemanagementResponseassetsUploadsWithHttpInfo(CreateResponseAssetRequest body);

    /// <summary>
    /// Create a response.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Response</param>
    /// <param name="expand">Expand instructions for the return value. (optional)</param>
    /// <returns>Response</returns>

    Response PostResponsemanagementResponses(Response body, string expand = null);

    /// <summary>
    /// Create a response.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Response</param>
    /// <param name="expand">Expand instructions for the return value. (optional)</param>
    /// <returns>ApiResponse of Response</returns>

    ApiResponse<Response> PostResponsemanagementResponsesWithHttpInfo(Response body, string expand = null);

    /// <summary>
    /// Query responses
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Response</param>
    /// <returns>ResponseQueryResults</returns>

    ResponseQueryResults PostResponsemanagementResponsesQuery(ResponseQueryRequest body);

    /// <summary>
    /// Query responses
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Response</param>
    /// <returns>ApiResponse of ResponseQueryResults</returns>

    ApiResponse<ResponseQueryResults> PostResponsemanagementResponsesQueryWithHttpInfo(ResponseQueryRequest body);

    /// <summary>
    /// Update an existing response library.
    /// </summary>
    /// <remarks>
    /// Fields that can be updated: name. The most recent version is required for updates.
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="libraryId">Library ID</param>
    /// <param name="body">Library</param>
    /// <returns>Library</returns>

    Library PutResponsemanagementLibrary(string libraryId, Library body);

    /// <summary>
    /// Update an existing response library.
    /// </summary>
    /// <remarks>
    /// Fields that can be updated: name. The most recent version is required for updates.
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="libraryId">Library ID</param>
    /// <param name="body">Library</param>
    /// <returns>ApiResponse of Library</returns>

    ApiResponse<Library> PutResponsemanagementLibraryWithHttpInfo(string libraryId, Library body);

    /// <summary>
    /// Update an existing response.
    /// </summary>
    /// <remarks>
    /// Fields that can be updated: name, libraries, and texts. The most recent version is required for updates.
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="responseId">Response ID</param>
    /// <param name="body">Response</param>
    /// <param name="expand">Expand instructions for the return value. (optional)</param>
    /// <returns>Response</returns>

    Response PutResponsemanagementResponse(string responseId, Response body, string expand = null);

    /// <summary>
    /// Update an existing response.
    /// </summary>
    /// <remarks>
    /// Fields that can be updated: name, libraries, and texts. The most recent version is required for updates.
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="responseId">Response ID</param>
    /// <param name="body">Response</param>
    /// <param name="expand">Expand instructions for the return value. (optional)</param>
    /// <returns>ApiResponse of Response</returns>

    ApiResponse<Response> PutResponsemanagementResponseWithHttpInfo(string responseId, Response body, string expand = null);

    /// <summary>
    /// Update response asset
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="responseAssetId">Asset Id</param>
    /// <param name="body">request</param>
    /// <returns>ResponseAsset</returns>

    ResponseAsset PutResponsemanagementResponseasset(string responseAssetId, ResponseAssetRequest body);

    /// <summary>
    /// Update response asset
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="responseAssetId">Asset Id</param>
    /// <param name="body">request</param>
    /// <returns>ApiResponse of ResponseAsset</returns>

    ApiResponse<ResponseAsset> PutResponsemanagementResponseassetWithHttpInfo(string responseAssetId, ResponseAssetRequest body);

    #endregion Synchronous Operations

    #region Asynchronous Operations

    /// <summary>
    /// Delete an existing response library.
    /// </summary>
    /// <remarks>
    /// This will remove any responses associated with the library.
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="libraryId">Library ID</param>
    /// <returns>Task of void</returns>

    Task DeleteResponsemanagementLibraryAsync(string libraryId);

    /// <summary>
    /// Delete an existing response library.
    /// </summary>
    /// <remarks>
    /// This will remove any responses associated with the library.
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="libraryId">Library ID</param>
    /// <returns>Task of ApiResponse</returns>

    Task<ApiResponse<object>> DeleteResponsemanagementLibraryAsyncWithHttpInfo(string libraryId);

    /// <summary>
    /// Delete an existing response.
    /// </summary>
    /// <remarks>
    /// This will remove the response from any libraries associated with it.
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="responseId">Response ID</param>
    /// <returns>Task of void</returns>

    Task DeleteResponsemanagementResponseAsync(string responseId);

    /// <summary>
    /// Delete an existing response.
    /// </summary>
    /// <remarks>
    /// This will remove the response from any libraries associated with it.
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="responseId">Response ID</param>
    /// <returns>Task of ApiResponse</returns>

    Task<ApiResponse<object>> DeleteResponsemanagementResponseAsyncWithHttpInfo(string responseId);

    /// <summary>
    /// Delete response asset
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="responseAssetId">Asset Id</param>
    /// <returns>Task of void</returns>

    Task DeleteResponsemanagementResponseassetAsync(string responseAssetId);

    /// <summary>
    /// Delete response asset
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="responseAssetId">Asset Id</param>
    /// <returns>Task of ApiResponse</returns>

    Task<ApiResponse<object>> DeleteResponsemanagementResponseassetAsyncWithHttpInfo(string responseAssetId);

    /// <summary>
    /// Gets a list of existing response libraries.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="messagingTemplateFilter">Returns a list of libraries that contain responses with at least one messaging template defined for a specific message channel (optional)</param>
    /// <param name="libraryPrefix">Returns a list of libraries that contain the prefix provided (optional)</param>
    /// <returns>Task of LibraryEntityListing</returns>

    Task<LibraryEntityListing> GetResponsemanagementLibrariesAsync(int? pageNumber = null, int? pageSize = null, string messagingTemplateFilter = null, string libraryPrefix = null);

    /// <summary>
    /// Gets a list of existing response libraries.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="messagingTemplateFilter">Returns a list of libraries that contain responses with at least one messaging template defined for a specific message channel (optional)</param>
    /// <param name="libraryPrefix">Returns a list of libraries that contain the prefix provided (optional)</param>
    /// <returns>Task of ApiResponse (LibraryEntityListing)</returns>

    Task<ApiResponse<LibraryEntityListing>> GetResponsemanagementLibrariesAsyncWithHttpInfo(int? pageNumber = null, int? pageSize = null, string messagingTemplateFilter = null, string libraryPrefix = null);

    /// <summary>
    /// Get details about an existing response library.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="libraryId">Library ID</param>
    /// <returns>Task of Library</returns>

    Task<Library> GetResponsemanagementLibraryAsync(string libraryId);

    /// <summary>
    /// Get details about an existing response library.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="libraryId">Library ID</param>
    /// <returns>Task of ApiResponse (Library)</returns>

    Task<ApiResponse<Library>> GetResponsemanagementLibraryAsyncWithHttpInfo(string libraryId);

    /// <summary>
    /// Get details about an existing response.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="responseId">Response ID</param>
    /// <param name="expand">Expand instructions for the return value. (optional)</param>
    /// <returns>Task of Response</returns>

    Task<Response> GetResponsemanagementResponseAsync(string responseId, string expand = null);

    /// <summary>
    /// Get details about an existing response.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="responseId">Response ID</param>
    /// <param name="expand">Expand instructions for the return value. (optional)</param>
    /// <returns>Task of ApiResponse (Response)</returns>

    Task<ApiResponse<Response>> GetResponsemanagementResponseAsyncWithHttpInfo(string responseId, string expand = null);

    /// <summary>
    /// Get response asset information
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="responseAssetId">Asset Id</param>
    /// <returns>Task of ResponseAsset</returns>

    Task<ResponseAsset> GetResponsemanagementResponseassetAsync(string responseAssetId);

    /// <summary>
    /// Get response asset information
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="responseAssetId">Asset Id</param>
    /// <returns>Task of ApiResponse (ResponseAsset)</returns>

    Task<ApiResponse<ResponseAsset>> GetResponsemanagementResponseassetAsyncWithHttpInfo(string responseAssetId);

    /// <summary>
    /// Get response asset upload status
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="statusId">Status Id</param>
    /// <returns>Task of ResponseAssetStatus</returns>

    Task<ResponseAssetStatus> GetResponsemanagementResponseassetsStatusStatusIdAsync(string statusId);

    /// <summary>
    /// Get response asset upload status
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="statusId">Status Id</param>
    /// <returns>Task of ApiResponse (ResponseAssetStatus)</returns>

    Task<ApiResponse<ResponseAssetStatus>> GetResponsemanagementResponseassetsStatusStatusIdAsyncWithHttpInfo(string statusId);

    /// <summary>
    /// Gets a list of existing responses.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="libraryId">Library ID</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="expand">Expand instructions for the return value. (optional)</param>
    /// <returns>Task of ResponseEntityListing</returns>

    Task<ResponseEntityListing> GetResponsemanagementResponsesAsync(string libraryId, int? pageNumber = null, int? pageSize = null, string expand = null);

    /// <summary>
    /// Gets a list of existing responses.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="libraryId">Library ID</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="expand">Expand instructions for the return value. (optional)</param>
    /// <returns>Task of ApiResponse (ResponseEntityListing)</returns>

    Task<ApiResponse<ResponseEntityListing>> GetResponsemanagementResponsesAsyncWithHttpInfo(string libraryId, int? pageNumber = null, int? pageSize = null, string expand = null);

    /// <summary>
    /// Create a response library.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Library</param>
    /// <returns>Task of Library</returns>

    Task<Library> PostResponsemanagementLibrariesAsync(Library body);

    /// <summary>
    /// Create a response library.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Library</param>
    /// <returns>Task of ApiResponse (Library)</returns>

    Task<ApiResponse<Library>> PostResponsemanagementLibrariesAsyncWithHttpInfo(Library body);

    /// <summary>
    /// Get response libraries.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">LibraryIDs (max allowed 50)</param>
    /// <returns>Task of LibraryEntityListing</returns>

    Task<LibraryEntityListing> PostResponsemanagementLibrariesBulkAsync(LibraryBatchRequest body);

    /// <summary>
    /// Get response libraries.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">LibraryIDs (max allowed 50)</param>
    /// <returns>Task of ApiResponse (LibraryEntityListing)</returns>

    Task<ApiResponse<LibraryEntityListing>> PostResponsemanagementLibrariesBulkAsyncWithHttpInfo(LibraryBatchRequest body);

    /// <summary>
    /// Search response assets
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">request</param>
    /// <param name="expand">Which fields, if any, to expand (optional)</param>
    /// <returns>Task of ResponseAssetSearchResults</returns>

    Task<ResponseAssetSearchResults> PostResponsemanagementResponseassetsSearchAsync(ResponseAssetSearchRequest body, List<string> expand = null);

    /// <summary>
    /// Search response assets
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">request</param>
    /// <param name="expand">Which fields, if any, to expand (optional)</param>
    /// <returns>Task of ApiResponse (ResponseAssetSearchResults)</returns>

    Task<ApiResponse<ResponseAssetSearchResults>> PostResponsemanagementResponseassetsSearchAsyncWithHttpInfo(ResponseAssetSearchRequest body, List<string> expand = null);

    /// <summary>
    /// Creates pre-signed url for uploading response asset
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">request</param>
    /// <returns>Task of CreateResponseAssetResponse</returns>

    Task<CreateResponseAssetResponse> PostResponsemanagementResponseassetsUploadsAsync(CreateResponseAssetRequest body);

    /// <summary>
    /// Creates pre-signed url for uploading response asset
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">request</param>
    /// <returns>Task of ApiResponse (CreateResponseAssetResponse)</returns>

    Task<ApiResponse<CreateResponseAssetResponse>> PostResponsemanagementResponseassetsUploadsAsyncWithHttpInfo(CreateResponseAssetRequest body);

    /// <summary>
    /// Create a response.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Response</param>
    /// <param name="expand">Expand instructions for the return value. (optional)</param>
    /// <returns>Task of Response</returns>

    Task<Response> PostResponsemanagementResponsesAsync(Response body, string expand = null);

    /// <summary>
    /// Create a response.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Response</param>
    /// <param name="expand">Expand instructions for the return value. (optional)</param>
    /// <returns>Task of ApiResponse (Response)</returns>

    Task<ApiResponse<Response>> PostResponsemanagementResponsesAsyncWithHttpInfo(Response body, string expand = null);

    /// <summary>
    /// Query responses
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Response</param>
    /// <returns>Task of ResponseQueryResults</returns>

    Task<ResponseQueryResults> PostResponsemanagementResponsesQueryAsync(ResponseQueryRequest body);

    /// <summary>
    /// Query responses
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Response</param>
    /// <returns>Task of ApiResponse (ResponseQueryResults)</returns>

    Task<ApiResponse<ResponseQueryResults>> PostResponsemanagementResponsesQueryAsyncWithHttpInfo(ResponseQueryRequest body);

    /// <summary>
    /// Update an existing response library.
    /// </summary>
    /// <remarks>
    /// Fields that can be updated: name. The most recent version is required for updates.
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="libraryId">Library ID</param>
    /// <param name="body">Library</param>
    /// <returns>Task of Library</returns>

    Task<Library> PutResponsemanagementLibraryAsync(string libraryId, Library body);

    /// <summary>
    /// Update an existing response library.
    /// </summary>
    /// <remarks>
    /// Fields that can be updated: name. The most recent version is required for updates.
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="libraryId">Library ID</param>
    /// <param name="body">Library</param>
    /// <returns>Task of ApiResponse (Library)</returns>

    Task<ApiResponse<Library>> PutResponsemanagementLibraryAsyncWithHttpInfo(string libraryId, Library body);

    /// <summary>
    /// Update an existing response.
    /// </summary>
    /// <remarks>
    /// Fields that can be updated: name, libraries, and texts. The most recent version is required for updates.
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="responseId">Response ID</param>
    /// <param name="body">Response</param>
    /// <param name="expand">Expand instructions for the return value. (optional)</param>
    /// <returns>Task of Response</returns>

    Task<Response> PutResponsemanagementResponseAsync(string responseId, Response body, string expand = null);

    /// <summary>
    /// Update an existing response.
    /// </summary>
    /// <remarks>
    /// Fields that can be updated: name, libraries, and texts. The most recent version is required for updates.
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="responseId">Response ID</param>
    /// <param name="body">Response</param>
    /// <param name="expand">Expand instructions for the return value. (optional)</param>
    /// <returns>Task of ApiResponse (Response)</returns>

    Task<ApiResponse<Response>> PutResponsemanagementResponseAsyncWithHttpInfo(string responseId, Response body, string expand = null);

    /// <summary>
    /// Update response asset
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="responseAssetId">Asset Id</param>
    /// <param name="body">request</param>
    /// <returns>Task of ResponseAsset</returns>

    Task<ResponseAsset> PutResponsemanagementResponseassetAsync(string responseAssetId, ResponseAssetRequest body);

    /// <summary>
    /// Update response asset
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="responseAssetId">Asset Id</param>
    /// <param name="body">request</param>
    /// <returns>Task of ApiResponse (ResponseAsset)</returns>

    Task<ApiResponse<ResponseAsset>> PutResponsemanagementResponseassetAsyncWithHttpInfo(string responseAssetId, ResponseAssetRequest body);

    #endregion Asynchronous Operations

}

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public partial class ResponseManagementApi : IResponseManagementApi
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ResponseManagementApi"/> class.
    /// </summary>
    /// <returns></returns>
    public ResponseManagementApi(string basePath)
    {
        Configuration = new Configuration(new ApiClient(basePath));

        // ensure API client has configuration ready
        if (Configuration.ApiClient.Configuration == null)
        {
            Configuration.ApiClient.Configuration = Configuration;
        }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="ResponseManagementApi"/> class
    /// using Configuration object
    /// </summary>
    /// <param name="configuration">An instance of Configuration</param>
    /// <returns></returns>
    public ResponseManagementApi(Configuration configuration = null)
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
    /// Delete an existing response library. 
    /// This will remove any responses associated with the library.
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="libraryId">Library ID</param>
    /// <returns></returns>

    public void DeleteResponsemanagementLibrary(string libraryId)
    {
        DeleteResponsemanagementLibraryWithHttpInfo(libraryId);
    }

    /// <summary>
    /// Delete an existing response library. 
    /// This will remove any responses associated with the library.
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="libraryId">Library ID</param>
    /// <returns>ApiResponse of Object(void)</returns>

    public ApiResponse<object> DeleteResponsemanagementLibraryWithHttpInfo(string libraryId)
    {
        // verify the required parameter 'libraryId' is set
        if (libraryId == null)
        {
            throw new ApiException(400, "Missing required parameter 'libraryId' when calling ResponseManagementApi->DeleteResponsemanagementLibrary");
        }

        var localVarPath = "/api/v2/responsemanagement/libraries/{libraryId}";
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
        if (libraryId != null)
        {
            localVarPathParams.Add("libraryId", Configuration.ApiClient.ParameterToString(libraryId));
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
            Method.Delete, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
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
            throw new ApiException(localVarStatusCode, "Error calling DeleteResponsemanagementLibrary: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling DeleteResponsemanagementLibrary: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<object>(localVarStatusCode,
            localVarHeaders,
            null,
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Delete an existing response library. 
    /// This will remove any responses associated with the library.
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="libraryId">Library ID</param>
    /// <returns>Task of void</returns>

    public async Task DeleteResponsemanagementLibraryAsync(string libraryId)
    {
        await DeleteResponsemanagementLibraryAsyncWithHttpInfo(libraryId);

    }

    /// <summary>
    /// Delete an existing response library. 
    /// This will remove any responses associated with the library.
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="libraryId">Library ID</param>
    /// <returns>Task of ApiResponse</returns>

    public async Task<ApiResponse<object>> DeleteResponsemanagementLibraryAsyncWithHttpInfo(string libraryId)
    {
        // verify the required parameter 'libraryId' is set
        if (libraryId == null)
        {
            throw new ApiException(400, "Missing required parameter 'libraryId' when calling ResponseManagementApi->DeleteResponsemanagementLibrary");
        }

        var localVarPath = "/api/v2/responsemanagement/libraries/{libraryId}";
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
        if (libraryId != null)
        {
            localVarPathParams.Add("libraryId", Configuration.ApiClient.ParameterToString(libraryId));
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
            Method.Delete, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
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
            throw new ApiException(localVarStatusCode, "Error calling DeleteResponsemanagementLibrary: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling DeleteResponsemanagementLibrary: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<object>(localVarStatusCode,
            localVarHeaders,
            null,
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Delete an existing response. 
    /// This will remove the response from any libraries associated with it.
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="responseId">Response ID</param>
    /// <returns></returns>

    public void DeleteResponsemanagementResponse(string responseId)
    {
        DeleteResponsemanagementResponseWithHttpInfo(responseId);
    }

    /// <summary>
    /// Delete an existing response. 
    /// This will remove the response from any libraries associated with it.
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="responseId">Response ID</param>
    /// <returns>ApiResponse of Object(void)</returns>

    public ApiResponse<object> DeleteResponsemanagementResponseWithHttpInfo(string responseId)
    {
        // verify the required parameter 'responseId' is set
        if (responseId == null)
        {
            throw new ApiException(400, "Missing required parameter 'responseId' when calling ResponseManagementApi->DeleteResponsemanagementResponse");
        }

        var localVarPath = "/api/v2/responsemanagement/responses/{responseId}";
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
        if (responseId != null)
        {
            localVarPathParams.Add("responseId", Configuration.ApiClient.ParameterToString(responseId));
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
            Method.Delete, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
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
            throw new ApiException(localVarStatusCode, "Error calling DeleteResponsemanagementResponse: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling DeleteResponsemanagementResponse: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<object>(localVarStatusCode,
            localVarHeaders,
            null,
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Delete an existing response. 
    /// This will remove the response from any libraries associated with it.
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="responseId">Response ID</param>
    /// <returns>Task of void</returns>

    public async Task DeleteResponsemanagementResponseAsync(string responseId)
    {
        await DeleteResponsemanagementResponseAsyncWithHttpInfo(responseId);

    }

    /// <summary>
    /// Delete an existing response. 
    /// This will remove the response from any libraries associated with it.
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="responseId">Response ID</param>
    /// <returns>Task of ApiResponse</returns>

    public async Task<ApiResponse<object>> DeleteResponsemanagementResponseAsyncWithHttpInfo(string responseId)
    {
        // verify the required parameter 'responseId' is set
        if (responseId == null)
        {
            throw new ApiException(400, "Missing required parameter 'responseId' when calling ResponseManagementApi->DeleteResponsemanagementResponse");
        }

        var localVarPath = "/api/v2/responsemanagement/responses/{responseId}";
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
        if (responseId != null)
        {
            localVarPathParams.Add("responseId", Configuration.ApiClient.ParameterToString(responseId));
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
            Method.Delete, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
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
            throw new ApiException(localVarStatusCode, "Error calling DeleteResponsemanagementResponse: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling DeleteResponsemanagementResponse: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<object>(localVarStatusCode,
            localVarHeaders,
            null,
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Delete response asset 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="responseAssetId">Asset Id</param>
    /// <returns></returns>

    public void DeleteResponsemanagementResponseasset(string responseAssetId)
    {
        DeleteResponsemanagementResponseassetWithHttpInfo(responseAssetId);
    }

    /// <summary>
    /// Delete response asset 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="responseAssetId">Asset Id</param>
    /// <returns>ApiResponse of Object(void)</returns>

    public ApiResponse<object> DeleteResponsemanagementResponseassetWithHttpInfo(string responseAssetId)
    {
        // verify the required parameter 'responseAssetId' is set
        if (responseAssetId == null)
        {
            throw new ApiException(400, "Missing required parameter 'responseAssetId' when calling ResponseManagementApi->DeleteResponsemanagementResponseasset");
        }

        var localVarPath = "/api/v2/responsemanagement/responseassets/{responseAssetId}";
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
        if (responseAssetId != null)
        {
            localVarPathParams.Add("responseAssetId", Configuration.ApiClient.ParameterToString(responseAssetId));
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
            Method.Delete, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
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
            throw new ApiException(localVarStatusCode, "Error calling DeleteResponsemanagementResponseasset: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling DeleteResponsemanagementResponseasset: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<object>(localVarStatusCode,
            localVarHeaders,
            null,
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Delete response asset 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="responseAssetId">Asset Id</param>
    /// <returns>Task of void</returns>

    public async Task DeleteResponsemanagementResponseassetAsync(string responseAssetId)
    {
        await DeleteResponsemanagementResponseassetAsyncWithHttpInfo(responseAssetId);

    }

    /// <summary>
    /// Delete response asset 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="responseAssetId">Asset Id</param>
    /// <returns>Task of ApiResponse</returns>

    public async Task<ApiResponse<object>> DeleteResponsemanagementResponseassetAsyncWithHttpInfo(string responseAssetId)
    {
        // verify the required parameter 'responseAssetId' is set
        if (responseAssetId == null)
        {
            throw new ApiException(400, "Missing required parameter 'responseAssetId' when calling ResponseManagementApi->DeleteResponsemanagementResponseasset");
        }

        var localVarPath = "/api/v2/responsemanagement/responseassets/{responseAssetId}";
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
        if (responseAssetId != null)
        {
            localVarPathParams.Add("responseAssetId", Configuration.ApiClient.ParameterToString(responseAssetId));
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
            Method.Delete, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
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
            throw new ApiException(localVarStatusCode, "Error calling DeleteResponsemanagementResponseasset: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling DeleteResponsemanagementResponseasset: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<object>(localVarStatusCode,
            localVarHeaders,
            null,
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Gets a list of existing response libraries. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="messagingTemplateFilter">Returns a list of libraries that contain responses with at least one messaging template defined for a specific message channel (optional)</param>
    /// <param name="libraryPrefix">Returns a list of libraries that contain the prefix provided (optional)</param>
    /// <returns>LibraryEntityListing</returns>

    public LibraryEntityListing GetResponsemanagementLibraries(int? pageNumber = null, int? pageSize = null, string messagingTemplateFilter = null, string libraryPrefix = null)
    {
        ApiResponse<LibraryEntityListing> localVarResponse = GetResponsemanagementLibrariesWithHttpInfo(pageNumber, pageSize, messagingTemplateFilter, libraryPrefix);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Gets a list of existing response libraries. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="messagingTemplateFilter">Returns a list of libraries that contain responses with at least one messaging template defined for a specific message channel (optional)</param>
    /// <param name="libraryPrefix">Returns a list of libraries that contain the prefix provided (optional)</param>
    /// <returns>ApiResponse of LibraryEntityListing</returns>

    public ApiResponse<LibraryEntityListing> GetResponsemanagementLibrariesWithHttpInfo(int? pageNumber = null, int? pageSize = null, string messagingTemplateFilter = null, string libraryPrefix = null)
    {

        var localVarPath = "/api/v2/responsemanagement/libraries";
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
        if (pageNumber != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)));
        }

        if (pageSize != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("pageSize", Configuration.ApiClient.ParameterToString(pageSize)));
        }

        if (messagingTemplateFilter != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("messagingTemplateFilter", Configuration.ApiClient.ParameterToString(messagingTemplateFilter)));
        }

        if (libraryPrefix != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("libraryPrefix", Configuration.ApiClient.ParameterToString(libraryPrefix)));
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
            throw new ApiException(localVarStatusCode, "Error calling GetResponsemanagementLibraries: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetResponsemanagementLibraries: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<LibraryEntityListing>(localVarStatusCode,
            localVarHeaders,
            (LibraryEntityListing)Configuration.ApiClient.Deserialize(localVarResponse, typeof(LibraryEntityListing)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Gets a list of existing response libraries. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="messagingTemplateFilter">Returns a list of libraries that contain responses with at least one messaging template defined for a specific message channel (optional)</param>
    /// <param name="libraryPrefix">Returns a list of libraries that contain the prefix provided (optional)</param>
    /// <returns>Task of LibraryEntityListing</returns>

    public async Task<LibraryEntityListing> GetResponsemanagementLibrariesAsync(int? pageNumber = null, int? pageSize = null, string messagingTemplateFilter = null, string libraryPrefix = null)
    {
        ApiResponse<LibraryEntityListing> localVarResponse = await GetResponsemanagementLibrariesAsyncWithHttpInfo(pageNumber, pageSize, messagingTemplateFilter, libraryPrefix);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Gets a list of existing response libraries. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="messagingTemplateFilter">Returns a list of libraries that contain responses with at least one messaging template defined for a specific message channel (optional)</param>
    /// <param name="libraryPrefix">Returns a list of libraries that contain the prefix provided (optional)</param>
    /// <returns>Task of ApiResponse (LibraryEntityListing)</returns>

    public async Task<ApiResponse<LibraryEntityListing>> GetResponsemanagementLibrariesAsyncWithHttpInfo(int? pageNumber = null, int? pageSize = null, string messagingTemplateFilter = null, string libraryPrefix = null)
    {

        var localVarPath = "/api/v2/responsemanagement/libraries";
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
        if (pageNumber != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)));
        }

        if (pageSize != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("pageSize", Configuration.ApiClient.ParameterToString(pageSize)));
        }

        if (messagingTemplateFilter != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("messagingTemplateFilter", Configuration.ApiClient.ParameterToString(messagingTemplateFilter)));
        }

        if (libraryPrefix != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("libraryPrefix", Configuration.ApiClient.ParameterToString(libraryPrefix)));
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
            throw new ApiException(localVarStatusCode, "Error calling GetResponsemanagementLibraries: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetResponsemanagementLibraries: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<LibraryEntityListing>(localVarStatusCode,
            localVarHeaders,
            (LibraryEntityListing)Configuration.ApiClient.Deserialize(localVarResponse, typeof(LibraryEntityListing)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Get details about an existing response library. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="libraryId">Library ID</param>
    /// <returns>Library</returns>

    public Library GetResponsemanagementLibrary(string libraryId)
    {
        ApiResponse<Library> localVarResponse = GetResponsemanagementLibraryWithHttpInfo(libraryId);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get details about an existing response library. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="libraryId">Library ID</param>
    /// <returns>ApiResponse of Library</returns>

    public ApiResponse<Library> GetResponsemanagementLibraryWithHttpInfo(string libraryId)
    {
        // verify the required parameter 'libraryId' is set
        if (libraryId == null)
        {
            throw new ApiException(400, "Missing required parameter 'libraryId' when calling ResponseManagementApi->GetResponsemanagementLibrary");
        }

        var localVarPath = "/api/v2/responsemanagement/libraries/{libraryId}";
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
        if (libraryId != null)
        {
            localVarPathParams.Add("libraryId", Configuration.ApiClient.ParameterToString(libraryId));
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
            throw new ApiException(localVarStatusCode, "Error calling GetResponsemanagementLibrary: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetResponsemanagementLibrary: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<Library>(localVarStatusCode,
            localVarHeaders,
            (Library)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Library)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Get details about an existing response library. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="libraryId">Library ID</param>
    /// <returns>Task of Library</returns>

    public async Task<Library> GetResponsemanagementLibraryAsync(string libraryId)
    {
        ApiResponse<Library> localVarResponse = await GetResponsemanagementLibraryAsyncWithHttpInfo(libraryId);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Get details about an existing response library. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="libraryId">Library ID</param>
    /// <returns>Task of ApiResponse (Library)</returns>

    public async Task<ApiResponse<Library>> GetResponsemanagementLibraryAsyncWithHttpInfo(string libraryId)
    {
        // verify the required parameter 'libraryId' is set
        if (libraryId == null)
        {
            throw new ApiException(400, "Missing required parameter 'libraryId' when calling ResponseManagementApi->GetResponsemanagementLibrary");
        }

        var localVarPath = "/api/v2/responsemanagement/libraries/{libraryId}";
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
        if (libraryId != null)
        {
            localVarPathParams.Add("libraryId", Configuration.ApiClient.ParameterToString(libraryId));
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
            throw new ApiException(localVarStatusCode, "Error calling GetResponsemanagementLibrary: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetResponsemanagementLibrary: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<Library>(localVarStatusCode,
            localVarHeaders,
            (Library)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Library)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Get details about an existing response. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="responseId">Response ID</param>
    /// <param name="expand">Expand instructions for the return value. (optional)</param>
    /// <returns>Response</returns>

    public Response GetResponsemanagementResponse(string responseId, string expand = null)
    {
        ApiResponse<Response> localVarResponse = GetResponsemanagementResponseWithHttpInfo(responseId, expand);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get details about an existing response. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="responseId">Response ID</param>
    /// <param name="expand">Expand instructions for the return value. (optional)</param>
    /// <returns>ApiResponse of Response</returns>

    public ApiResponse<Response> GetResponsemanagementResponseWithHttpInfo(string responseId, string expand = null)
    {
        // verify the required parameter 'responseId' is set
        if (responseId == null)
        {
            throw new ApiException(400, "Missing required parameter 'responseId' when calling ResponseManagementApi->GetResponsemanagementResponse");
        }

        var localVarPath = "/api/v2/responsemanagement/responses/{responseId}";
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
        if (responseId != null)
        {
            localVarPathParams.Add("responseId", Configuration.ApiClient.ParameterToString(responseId));
        }

        // Query params
        if (expand != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("expand", Configuration.ApiClient.ParameterToString(expand)));
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
            throw new ApiException(localVarStatusCode, "Error calling GetResponsemanagementResponse: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetResponsemanagementResponse: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<Response>(localVarStatusCode,
            localVarHeaders,
            (Response)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Response)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Get details about an existing response. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="responseId">Response ID</param>
    /// <param name="expand">Expand instructions for the return value. (optional)</param>
    /// <returns>Task of Response</returns>

    public async Task<Response> GetResponsemanagementResponseAsync(string responseId, string expand = null)
    {
        ApiResponse<Response> localVarResponse = await GetResponsemanagementResponseAsyncWithHttpInfo(responseId, expand);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Get details about an existing response. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="responseId">Response ID</param>
    /// <param name="expand">Expand instructions for the return value. (optional)</param>
    /// <returns>Task of ApiResponse (Response)</returns>

    public async Task<ApiResponse<Response>> GetResponsemanagementResponseAsyncWithHttpInfo(string responseId, string expand = null)
    {
        // verify the required parameter 'responseId' is set
        if (responseId == null)
        {
            throw new ApiException(400, "Missing required parameter 'responseId' when calling ResponseManagementApi->GetResponsemanagementResponse");
        }

        var localVarPath = "/api/v2/responsemanagement/responses/{responseId}";
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
        if (responseId != null)
        {
            localVarPathParams.Add("responseId", Configuration.ApiClient.ParameterToString(responseId));
        }

        // Query params
        if (expand != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("expand", Configuration.ApiClient.ParameterToString(expand)));
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
            throw new ApiException(localVarStatusCode, "Error calling GetResponsemanagementResponse: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetResponsemanagementResponse: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<Response>(localVarStatusCode,
            localVarHeaders,
            (Response)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Response)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Get response asset information 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="responseAssetId">Asset Id</param>
    /// <returns>ResponseAsset</returns>

    public ResponseAsset GetResponsemanagementResponseasset(string responseAssetId)
    {
        ApiResponse<ResponseAsset> localVarResponse = GetResponsemanagementResponseassetWithHttpInfo(responseAssetId);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get response asset information 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="responseAssetId">Asset Id</param>
    /// <returns>ApiResponse of ResponseAsset</returns>

    public ApiResponse<ResponseAsset> GetResponsemanagementResponseassetWithHttpInfo(string responseAssetId)
    {
        // verify the required parameter 'responseAssetId' is set
        if (responseAssetId == null)
        {
            throw new ApiException(400, "Missing required parameter 'responseAssetId' when calling ResponseManagementApi->GetResponsemanagementResponseasset");
        }

        var localVarPath = "/api/v2/responsemanagement/responseassets/{responseAssetId}";
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
        if (responseAssetId != null)
        {
            localVarPathParams.Add("responseAssetId", Configuration.ApiClient.ParameterToString(responseAssetId));
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
            throw new ApiException(localVarStatusCode, "Error calling GetResponsemanagementResponseasset: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetResponsemanagementResponseasset: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<ResponseAsset>(localVarStatusCode,
            localVarHeaders,
            (ResponseAsset)Configuration.ApiClient.Deserialize(localVarResponse, typeof(ResponseAsset)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Get response asset information 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="responseAssetId">Asset Id</param>
    /// <returns>Task of ResponseAsset</returns>

    public async Task<ResponseAsset> GetResponsemanagementResponseassetAsync(string responseAssetId)
    {
        ApiResponse<ResponseAsset> localVarResponse = await GetResponsemanagementResponseassetAsyncWithHttpInfo(responseAssetId);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Get response asset information 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="responseAssetId">Asset Id</param>
    /// <returns>Task of ApiResponse (ResponseAsset)</returns>

    public async Task<ApiResponse<ResponseAsset>> GetResponsemanagementResponseassetAsyncWithHttpInfo(string responseAssetId)
    {
        // verify the required parameter 'responseAssetId' is set
        if (responseAssetId == null)
        {
            throw new ApiException(400, "Missing required parameter 'responseAssetId' when calling ResponseManagementApi->GetResponsemanagementResponseasset");
        }

        var localVarPath = "/api/v2/responsemanagement/responseassets/{responseAssetId}";
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
        if (responseAssetId != null)
        {
            localVarPathParams.Add("responseAssetId", Configuration.ApiClient.ParameterToString(responseAssetId));
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
            throw new ApiException(localVarStatusCode, "Error calling GetResponsemanagementResponseasset: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetResponsemanagementResponseasset: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<ResponseAsset>(localVarStatusCode,
            localVarHeaders,
            (ResponseAsset)Configuration.ApiClient.Deserialize(localVarResponse, typeof(ResponseAsset)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Get response asset upload status 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="statusId">Status Id</param>
    /// <returns>ResponseAssetStatus</returns>

    public ResponseAssetStatus GetResponsemanagementResponseassetsStatusStatusId(string statusId)
    {
        ApiResponse<ResponseAssetStatus> localVarResponse = GetResponsemanagementResponseassetsStatusStatusIdWithHttpInfo(statusId);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get response asset upload status 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="statusId">Status Id</param>
    /// <returns>ApiResponse of ResponseAssetStatus</returns>

    public ApiResponse<ResponseAssetStatus> GetResponsemanagementResponseassetsStatusStatusIdWithHttpInfo(string statusId)
    {
        // verify the required parameter 'statusId' is set
        if (statusId == null)
        {
            throw new ApiException(400, "Missing required parameter 'statusId' when calling ResponseManagementApi->GetResponsemanagementResponseassetsStatusStatusId");
        }

        var localVarPath = "/api/v2/responsemanagement/responseassets/status/{statusId}";
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
        if (statusId != null)
        {
            localVarPathParams.Add("statusId", Configuration.ApiClient.ParameterToString(statusId));
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
            throw new ApiException(localVarStatusCode, "Error calling GetResponsemanagementResponseassetsStatusStatusId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetResponsemanagementResponseassetsStatusStatusId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<ResponseAssetStatus>(localVarStatusCode,
            localVarHeaders,
            (ResponseAssetStatus)Configuration.ApiClient.Deserialize(localVarResponse, typeof(ResponseAssetStatus)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Get response asset upload status 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="statusId">Status Id</param>
    /// <returns>Task of ResponseAssetStatus</returns>

    public async Task<ResponseAssetStatus> GetResponsemanagementResponseassetsStatusStatusIdAsync(string statusId)
    {
        ApiResponse<ResponseAssetStatus> localVarResponse = await GetResponsemanagementResponseassetsStatusStatusIdAsyncWithHttpInfo(statusId);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Get response asset upload status 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="statusId">Status Id</param>
    /// <returns>Task of ApiResponse (ResponseAssetStatus)</returns>

    public async Task<ApiResponse<ResponseAssetStatus>> GetResponsemanagementResponseassetsStatusStatusIdAsyncWithHttpInfo(string statusId)
    {
        // verify the required parameter 'statusId' is set
        if (statusId == null)
        {
            throw new ApiException(400, "Missing required parameter 'statusId' when calling ResponseManagementApi->GetResponsemanagementResponseassetsStatusStatusId");
        }

        var localVarPath = "/api/v2/responsemanagement/responseassets/status/{statusId}";
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
        if (statusId != null)
        {
            localVarPathParams.Add("statusId", Configuration.ApiClient.ParameterToString(statusId));
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
            throw new ApiException(localVarStatusCode, "Error calling GetResponsemanagementResponseassetsStatusStatusId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetResponsemanagementResponseassetsStatusStatusId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<ResponseAssetStatus>(localVarStatusCode,
            localVarHeaders,
            (ResponseAssetStatus)Configuration.ApiClient.Deserialize(localVarResponse, typeof(ResponseAssetStatus)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Gets a list of existing responses. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="libraryId">Library ID</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="expand">Expand instructions for the return value. (optional)</param>
    /// <returns>ResponseEntityListing</returns>

    public ResponseEntityListing GetResponsemanagementResponses(string libraryId, int? pageNumber = null, int? pageSize = null, string expand = null)
    {
        ApiResponse<ResponseEntityListing> localVarResponse = GetResponsemanagementResponsesWithHttpInfo(libraryId, pageNumber, pageSize, expand);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Gets a list of existing responses. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="libraryId">Library ID</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="expand">Expand instructions for the return value. (optional)</param>
    /// <returns>ApiResponse of ResponseEntityListing</returns>

    public ApiResponse<ResponseEntityListing> GetResponsemanagementResponsesWithHttpInfo(string libraryId, int? pageNumber = null, int? pageSize = null, string expand = null)
    {
        // verify the required parameter 'libraryId' is set
        if (libraryId == null)
        {
            throw new ApiException(400, "Missing required parameter 'libraryId' when calling ResponseManagementApi->GetResponsemanagementResponses");
        }

        var localVarPath = "/api/v2/responsemanagement/responses";
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
        if (libraryId != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("libraryId", Configuration.ApiClient.ParameterToString(libraryId)));
        }

        if (pageNumber != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)));
        }

        if (pageSize != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("pageSize", Configuration.ApiClient.ParameterToString(pageSize)));
        }

        if (expand != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("expand", Configuration.ApiClient.ParameterToString(expand)));
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
            throw new ApiException(localVarStatusCode, "Error calling GetResponsemanagementResponses: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetResponsemanagementResponses: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<ResponseEntityListing>(localVarStatusCode,
            localVarHeaders,
            (ResponseEntityListing)Configuration.ApiClient.Deserialize(localVarResponse, typeof(ResponseEntityListing)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Gets a list of existing responses. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="libraryId">Library ID</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="expand">Expand instructions for the return value. (optional)</param>
    /// <returns>Task of ResponseEntityListing</returns>

    public async Task<ResponseEntityListing> GetResponsemanagementResponsesAsync(string libraryId, int? pageNumber = null, int? pageSize = null, string expand = null)
    {
        ApiResponse<ResponseEntityListing> localVarResponse = await GetResponsemanagementResponsesAsyncWithHttpInfo(libraryId, pageNumber, pageSize, expand);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Gets a list of existing responses. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="libraryId">Library ID</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="expand">Expand instructions for the return value. (optional)</param>
    /// <returns>Task of ApiResponse (ResponseEntityListing)</returns>

    public async Task<ApiResponse<ResponseEntityListing>> GetResponsemanagementResponsesAsyncWithHttpInfo(string libraryId, int? pageNumber = null, int? pageSize = null, string expand = null)
    {
        // verify the required parameter 'libraryId' is set
        if (libraryId == null)
        {
            throw new ApiException(400, "Missing required parameter 'libraryId' when calling ResponseManagementApi->GetResponsemanagementResponses");
        }

        var localVarPath = "/api/v2/responsemanagement/responses";
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
        if (libraryId != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("libraryId", Configuration.ApiClient.ParameterToString(libraryId)));
        }

        if (pageNumber != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)));
        }

        if (pageSize != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("pageSize", Configuration.ApiClient.ParameterToString(pageSize)));
        }

        if (expand != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("expand", Configuration.ApiClient.ParameterToString(expand)));
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
            throw new ApiException(localVarStatusCode, "Error calling GetResponsemanagementResponses: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetResponsemanagementResponses: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<ResponseEntityListing>(localVarStatusCode,
            localVarHeaders,
            (ResponseEntityListing)Configuration.ApiClient.Deserialize(localVarResponse, typeof(ResponseEntityListing)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Create a response library. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Library</param>
    /// <returns>Library</returns>

    public Library PostResponsemanagementLibraries(Library body)
    {
        ApiResponse<Library> localVarResponse = PostResponsemanagementLibrariesWithHttpInfo(body);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Create a response library. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Library</param>
    /// <returns>ApiResponse of Library</returns>

    public ApiResponse<Library> PostResponsemanagementLibrariesWithHttpInfo(Library body)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling ResponseManagementApi->PostResponsemanagementLibraries");
        }

        var localVarPath = "/api/v2/responsemanagement/libraries";
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
            throw new ApiException(localVarStatusCode, "Error calling PostResponsemanagementLibraries: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostResponsemanagementLibraries: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<Library>(localVarStatusCode,
            localVarHeaders,
            (Library)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Library)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Create a response library. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Library</param>
    /// <returns>Task of Library</returns>

    public async Task<Library> PostResponsemanagementLibrariesAsync(Library body)
    {
        ApiResponse<Library> localVarResponse = await PostResponsemanagementLibrariesAsyncWithHttpInfo(body);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Create a response library. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Library</param>
    /// <returns>Task of ApiResponse (Library)</returns>

    public async Task<ApiResponse<Library>> PostResponsemanagementLibrariesAsyncWithHttpInfo(Library body)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling ResponseManagementApi->PostResponsemanagementLibraries");
        }

        var localVarPath = "/api/v2/responsemanagement/libraries";
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
            throw new ApiException(localVarStatusCode, "Error calling PostResponsemanagementLibraries: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostResponsemanagementLibraries: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<Library>(localVarStatusCode,
            localVarHeaders,
            (Library)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Library)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Get response libraries. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">LibraryIDs (max allowed 50)</param>
    /// <returns>LibraryEntityListing</returns>

    public LibraryEntityListing PostResponsemanagementLibrariesBulk(LibraryBatchRequest body)
    {
        ApiResponse<LibraryEntityListing> localVarResponse = PostResponsemanagementLibrariesBulkWithHttpInfo(body);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get response libraries. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">LibraryIDs (max allowed 50)</param>
    /// <returns>ApiResponse of LibraryEntityListing</returns>

    public ApiResponse<LibraryEntityListing> PostResponsemanagementLibrariesBulkWithHttpInfo(LibraryBatchRequest body)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling ResponseManagementApi->PostResponsemanagementLibrariesBulk");
        }

        var localVarPath = "/api/v2/responsemanagement/libraries/bulk";
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
            throw new ApiException(localVarStatusCode, "Error calling PostResponsemanagementLibrariesBulk: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostResponsemanagementLibrariesBulk: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<LibraryEntityListing>(localVarStatusCode,
            localVarHeaders,
            (LibraryEntityListing)Configuration.ApiClient.Deserialize(localVarResponse, typeof(LibraryEntityListing)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Get response libraries. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">LibraryIDs (max allowed 50)</param>
    /// <returns>Task of LibraryEntityListing</returns>

    public async Task<LibraryEntityListing> PostResponsemanagementLibrariesBulkAsync(LibraryBatchRequest body)
    {
        ApiResponse<LibraryEntityListing> localVarResponse = await PostResponsemanagementLibrariesBulkAsyncWithHttpInfo(body);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Get response libraries. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">LibraryIDs (max allowed 50)</param>
    /// <returns>Task of ApiResponse (LibraryEntityListing)</returns>

    public async Task<ApiResponse<LibraryEntityListing>> PostResponsemanagementLibrariesBulkAsyncWithHttpInfo(LibraryBatchRequest body)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling ResponseManagementApi->PostResponsemanagementLibrariesBulk");
        }

        var localVarPath = "/api/v2/responsemanagement/libraries/bulk";
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
            throw new ApiException(localVarStatusCode, "Error calling PostResponsemanagementLibrariesBulk: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostResponsemanagementLibrariesBulk: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<LibraryEntityListing>(localVarStatusCode,
            localVarHeaders,
            (LibraryEntityListing)Configuration.ApiClient.Deserialize(localVarResponse, typeof(LibraryEntityListing)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Search response assets 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">request</param>
    /// <param name="expand">Which fields, if any, to expand (optional)</param>
    /// <returns>ResponseAssetSearchResults</returns>

    public ResponseAssetSearchResults PostResponsemanagementResponseassetsSearch(ResponseAssetSearchRequest body, List<string> expand = null)
    {
        ApiResponse<ResponseAssetSearchResults> localVarResponse = PostResponsemanagementResponseassetsSearchWithHttpInfo(body, expand);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Search response assets 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">request</param>
    /// <param name="expand">Which fields, if any, to expand (optional)</param>
    /// <returns>ApiResponse of ResponseAssetSearchResults</returns>

    public ApiResponse<ResponseAssetSearchResults> PostResponsemanagementResponseassetsSearchWithHttpInfo(ResponseAssetSearchRequest body, List<string> expand = null)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling ResponseManagementApi->PostResponsemanagementResponseassetsSearch");
        }

        var localVarPath = "/api/v2/responsemanagement/responseassets/search";
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
        if (expand != null)
        {
            expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", Configuration.ApiClient.ParameterToString(obj))); });
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
            throw new ApiException(localVarStatusCode, "Error calling PostResponsemanagementResponseassetsSearch: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostResponsemanagementResponseassetsSearch: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<ResponseAssetSearchResults>(localVarStatusCode,
            localVarHeaders,
            (ResponseAssetSearchResults)Configuration.ApiClient.Deserialize(localVarResponse, typeof(ResponseAssetSearchResults)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Search response assets 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">request</param>
    /// <param name="expand">Which fields, if any, to expand (optional)</param>
    /// <returns>Task of ResponseAssetSearchResults</returns>

    public async Task<ResponseAssetSearchResults> PostResponsemanagementResponseassetsSearchAsync(ResponseAssetSearchRequest body, List<string> expand = null)
    {
        ApiResponse<ResponseAssetSearchResults> localVarResponse = await PostResponsemanagementResponseassetsSearchAsyncWithHttpInfo(body, expand);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Search response assets 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">request</param>
    /// <param name="expand">Which fields, if any, to expand (optional)</param>
    /// <returns>Task of ApiResponse (ResponseAssetSearchResults)</returns>

    public async Task<ApiResponse<ResponseAssetSearchResults>> PostResponsemanagementResponseassetsSearchAsyncWithHttpInfo(ResponseAssetSearchRequest body, List<string> expand = null)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling ResponseManagementApi->PostResponsemanagementResponseassetsSearch");
        }

        var localVarPath = "/api/v2/responsemanagement/responseassets/search";
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
        if (expand != null)
        {
            expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", Configuration.ApiClient.ParameterToString(obj))); });
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
            throw new ApiException(localVarStatusCode, "Error calling PostResponsemanagementResponseassetsSearch: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostResponsemanagementResponseassetsSearch: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<ResponseAssetSearchResults>(localVarStatusCode,
            localVarHeaders,
            (ResponseAssetSearchResults)Configuration.ApiClient.Deserialize(localVarResponse, typeof(ResponseAssetSearchResults)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Creates pre-signed url for uploading response asset 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">request</param>
    /// <returns>CreateResponseAssetResponse</returns>

    public CreateResponseAssetResponse PostResponsemanagementResponseassetsUploads(CreateResponseAssetRequest body)
    {
        ApiResponse<CreateResponseAssetResponse> localVarResponse = PostResponsemanagementResponseassetsUploadsWithHttpInfo(body);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Creates pre-signed url for uploading response asset 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">request</param>
    /// <returns>ApiResponse of CreateResponseAssetResponse</returns>

    public ApiResponse<CreateResponseAssetResponse> PostResponsemanagementResponseassetsUploadsWithHttpInfo(CreateResponseAssetRequest body)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling ResponseManagementApi->PostResponsemanagementResponseassetsUploads");
        }

        var localVarPath = "/api/v2/responsemanagement/responseassets/uploads";
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
            throw new ApiException(localVarStatusCode, "Error calling PostResponsemanagementResponseassetsUploads: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostResponsemanagementResponseassetsUploads: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<CreateResponseAssetResponse>(localVarStatusCode,
            localVarHeaders,
            (CreateResponseAssetResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(CreateResponseAssetResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Creates pre-signed url for uploading response asset 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">request</param>
    /// <returns>Task of CreateResponseAssetResponse</returns>

    public async Task<CreateResponseAssetResponse> PostResponsemanagementResponseassetsUploadsAsync(CreateResponseAssetRequest body)
    {
        ApiResponse<CreateResponseAssetResponse> localVarResponse = await PostResponsemanagementResponseassetsUploadsAsyncWithHttpInfo(body);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Creates pre-signed url for uploading response asset 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">request</param>
    /// <returns>Task of ApiResponse (CreateResponseAssetResponse)</returns>

    public async Task<ApiResponse<CreateResponseAssetResponse>> PostResponsemanagementResponseassetsUploadsAsyncWithHttpInfo(CreateResponseAssetRequest body)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling ResponseManagementApi->PostResponsemanagementResponseassetsUploads");
        }

        var localVarPath = "/api/v2/responsemanagement/responseassets/uploads";
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
            throw new ApiException(localVarStatusCode, "Error calling PostResponsemanagementResponseassetsUploads: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostResponsemanagementResponseassetsUploads: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<CreateResponseAssetResponse>(localVarStatusCode,
            localVarHeaders,
            (CreateResponseAssetResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(CreateResponseAssetResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Create a response. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Response</param>
    /// <param name="expand">Expand instructions for the return value. (optional)</param>
    /// <returns>Response</returns>

    public Response PostResponsemanagementResponses(Response body, string expand = null)
    {
        ApiResponse<Response> localVarResponse = PostResponsemanagementResponsesWithHttpInfo(body, expand);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Create a response. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Response</param>
    /// <param name="expand">Expand instructions for the return value. (optional)</param>
    /// <returns>ApiResponse of Response</returns>

    public ApiResponse<Response> PostResponsemanagementResponsesWithHttpInfo(Response body, string expand = null)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling ResponseManagementApi->PostResponsemanagementResponses");
        }

        var localVarPath = "/api/v2/responsemanagement/responses";
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
        if (expand != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("expand", Configuration.ApiClient.ParameterToString(expand)));
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
            throw new ApiException(localVarStatusCode, "Error calling PostResponsemanagementResponses: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostResponsemanagementResponses: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<Response>(localVarStatusCode,
            localVarHeaders,
            (Response)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Response)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Create a response. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Response</param>
    /// <param name="expand">Expand instructions for the return value. (optional)</param>
    /// <returns>Task of Response</returns>

    public async Task<Response> PostResponsemanagementResponsesAsync(Response body, string expand = null)
    {
        ApiResponse<Response> localVarResponse = await PostResponsemanagementResponsesAsyncWithHttpInfo(body, expand);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Create a response. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Response</param>
    /// <param name="expand">Expand instructions for the return value. (optional)</param>
    /// <returns>Task of ApiResponse (Response)</returns>

    public async Task<ApiResponse<Response>> PostResponsemanagementResponsesAsyncWithHttpInfo(Response body, string expand = null)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling ResponseManagementApi->PostResponsemanagementResponses");
        }

        var localVarPath = "/api/v2/responsemanagement/responses";
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
        if (expand != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("expand", Configuration.ApiClient.ParameterToString(expand)));
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
            throw new ApiException(localVarStatusCode, "Error calling PostResponsemanagementResponses: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostResponsemanagementResponses: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<Response>(localVarStatusCode,
            localVarHeaders,
            (Response)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Response)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Query responses 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Response</param>
    /// <returns>ResponseQueryResults</returns>

    public ResponseQueryResults PostResponsemanagementResponsesQuery(ResponseQueryRequest body)
    {
        ApiResponse<ResponseQueryResults> localVarResponse = PostResponsemanagementResponsesQueryWithHttpInfo(body);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Query responses 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Response</param>
    /// <returns>ApiResponse of ResponseQueryResults</returns>

    public ApiResponse<ResponseQueryResults> PostResponsemanagementResponsesQueryWithHttpInfo(ResponseQueryRequest body)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling ResponseManagementApi->PostResponsemanagementResponsesQuery");
        }

        var localVarPath = "/api/v2/responsemanagement/responses/query";
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
            throw new ApiException(localVarStatusCode, "Error calling PostResponsemanagementResponsesQuery: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostResponsemanagementResponsesQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<ResponseQueryResults>(localVarStatusCode,
            localVarHeaders,
            (ResponseQueryResults)Configuration.ApiClient.Deserialize(localVarResponse, typeof(ResponseQueryResults)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Query responses 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Response</param>
    /// <returns>Task of ResponseQueryResults</returns>

    public async Task<ResponseQueryResults> PostResponsemanagementResponsesQueryAsync(ResponseQueryRequest body)
    {
        ApiResponse<ResponseQueryResults> localVarResponse = await PostResponsemanagementResponsesQueryAsyncWithHttpInfo(body);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Query responses 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Response</param>
    /// <returns>Task of ApiResponse (ResponseQueryResults)</returns>

    public async Task<ApiResponse<ResponseQueryResults>> PostResponsemanagementResponsesQueryAsyncWithHttpInfo(ResponseQueryRequest body)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling ResponseManagementApi->PostResponsemanagementResponsesQuery");
        }

        var localVarPath = "/api/v2/responsemanagement/responses/query";
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
            throw new ApiException(localVarStatusCode, "Error calling PostResponsemanagementResponsesQuery: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostResponsemanagementResponsesQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<ResponseQueryResults>(localVarStatusCode,
            localVarHeaders,
            (ResponseQueryResults)Configuration.ApiClient.Deserialize(localVarResponse, typeof(ResponseQueryResults)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Update an existing response library. 
    /// Fields that can be updated: name. The most recent version is required for updates.
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="libraryId">Library ID</param>
    /// <param name="body">Library</param>
    /// <returns>Library</returns>

    public Library PutResponsemanagementLibrary(string libraryId, Library body)
    {
        ApiResponse<Library> localVarResponse = PutResponsemanagementLibraryWithHttpInfo(libraryId, body);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Update an existing response library. 
    /// Fields that can be updated: name. The most recent version is required for updates.
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="libraryId">Library ID</param>
    /// <param name="body">Library</param>
    /// <returns>ApiResponse of Library</returns>

    public ApiResponse<Library> PutResponsemanagementLibraryWithHttpInfo(string libraryId, Library body)
    {
        // verify the required parameter 'libraryId' is set
        if (libraryId == null)
        {
            throw new ApiException(400, "Missing required parameter 'libraryId' when calling ResponseManagementApi->PutResponsemanagementLibrary");
        }
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling ResponseManagementApi->PutResponsemanagementLibrary");
        }

        var localVarPath = "/api/v2/responsemanagement/libraries/{libraryId}";
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
        if (libraryId != null)
        {
            localVarPathParams.Add("libraryId", Configuration.ApiClient.ParameterToString(libraryId));
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
            Method.Put, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
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
            throw new ApiException(localVarStatusCode, "Error calling PutResponsemanagementLibrary: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PutResponsemanagementLibrary: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<Library>(localVarStatusCode,
            localVarHeaders,
            (Library)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Library)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Update an existing response library. 
    /// Fields that can be updated: name. The most recent version is required for updates.
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="libraryId">Library ID</param>
    /// <param name="body">Library</param>
    /// <returns>Task of Library</returns>

    public async Task<Library> PutResponsemanagementLibraryAsync(string libraryId, Library body)
    {
        ApiResponse<Library> localVarResponse = await PutResponsemanagementLibraryAsyncWithHttpInfo(libraryId, body);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Update an existing response library. 
    /// Fields that can be updated: name. The most recent version is required for updates.
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="libraryId">Library ID</param>
    /// <param name="body">Library</param>
    /// <returns>Task of ApiResponse (Library)</returns>

    public async Task<ApiResponse<Library>> PutResponsemanagementLibraryAsyncWithHttpInfo(string libraryId, Library body)
    {
        // verify the required parameter 'libraryId' is set
        if (libraryId == null)
        {
            throw new ApiException(400, "Missing required parameter 'libraryId' when calling ResponseManagementApi->PutResponsemanagementLibrary");
        }

        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling ResponseManagementApi->PutResponsemanagementLibrary");
        }

        var localVarPath = "/api/v2/responsemanagement/libraries/{libraryId}";
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
        if (libraryId != null)
        {
            localVarPathParams.Add("libraryId", Configuration.ApiClient.ParameterToString(libraryId));
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
            Method.Put, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
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
            throw new ApiException(localVarStatusCode, "Error calling PutResponsemanagementLibrary: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PutResponsemanagementLibrary: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<Library>(localVarStatusCode,
            localVarHeaders,
            (Library)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Library)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Update an existing response. 
    /// Fields that can be updated: name, libraries, and texts. The most recent version is required for updates.
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="responseId">Response ID</param>
    /// <param name="body">Response</param>
    /// <param name="expand">Expand instructions for the return value. (optional)</param>
    /// <returns>Response</returns>

    public Response PutResponsemanagementResponse(string responseId, Response body, string expand = null)
    {
        ApiResponse<Response> localVarResponse = PutResponsemanagementResponseWithHttpInfo(responseId, body, expand);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Update an existing response. 
    /// Fields that can be updated: name, libraries, and texts. The most recent version is required for updates.
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="responseId">Response ID</param>
    /// <param name="body">Response</param>
    /// <param name="expand">Expand instructions for the return value. (optional)</param>
    /// <returns>ApiResponse of Response</returns>

    public ApiResponse<Response> PutResponsemanagementResponseWithHttpInfo(string responseId, Response body, string expand = null)
    {
        // verify the required parameter 'responseId' is set
        if (responseId == null)
        {
            throw new ApiException(400, "Missing required parameter 'responseId' when calling ResponseManagementApi->PutResponsemanagementResponse");
        }
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling ResponseManagementApi->PutResponsemanagementResponse");
        }

        var localVarPath = "/api/v2/responsemanagement/responses/{responseId}";
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
        if (responseId != null)
        {
            localVarPathParams.Add("responseId", Configuration.ApiClient.ParameterToString(responseId));
        }

        // Query params
        if (expand != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("expand", Configuration.ApiClient.ParameterToString(expand)));
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
            Method.Put, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
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
            throw new ApiException(localVarStatusCode, "Error calling PutResponsemanagementResponse: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PutResponsemanagementResponse: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<Response>(localVarStatusCode,
            localVarHeaders,
            (Response)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Response)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Update an existing response. 
    /// Fields that can be updated: name, libraries, and texts. The most recent version is required for updates.
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="responseId">Response ID</param>
    /// <param name="body">Response</param>
    /// <param name="expand">Expand instructions for the return value. (optional)</param>
    /// <returns>Task of Response</returns>

    public async Task<Response> PutResponsemanagementResponseAsync(string responseId, Response body, string expand = null)
    {
        ApiResponse<Response> localVarResponse = await PutResponsemanagementResponseAsyncWithHttpInfo(responseId, body, expand);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Update an existing response. 
    /// Fields that can be updated: name, libraries, and texts. The most recent version is required for updates.
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="responseId">Response ID</param>
    /// <param name="body">Response</param>
    /// <param name="expand">Expand instructions for the return value. (optional)</param>
    /// <returns>Task of ApiResponse (Response)</returns>

    public async Task<ApiResponse<Response>> PutResponsemanagementResponseAsyncWithHttpInfo(string responseId, Response body, string expand = null)
    {
        // verify the required parameter 'responseId' is set
        if (responseId == null)
        {
            throw new ApiException(400, "Missing required parameter 'responseId' when calling ResponseManagementApi->PutResponsemanagementResponse");
        }

        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling ResponseManagementApi->PutResponsemanagementResponse");
        }

        var localVarPath = "/api/v2/responsemanagement/responses/{responseId}";
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
        if (responseId != null)
        {
            localVarPathParams.Add("responseId", Configuration.ApiClient.ParameterToString(responseId));
        }

        // Query params
        if (expand != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("expand", Configuration.ApiClient.ParameterToString(expand)));
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
            Method.Put, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
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
            throw new ApiException(localVarStatusCode, "Error calling PutResponsemanagementResponse: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PutResponsemanagementResponse: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<Response>(localVarStatusCode,
            localVarHeaders,
            (Response)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Response)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Update response asset 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="responseAssetId">Asset Id</param>
    /// <param name="body">request</param>
    /// <returns>ResponseAsset</returns>

    public ResponseAsset PutResponsemanagementResponseasset(string responseAssetId, ResponseAssetRequest body)
    {
        ApiResponse<ResponseAsset> localVarResponse = PutResponsemanagementResponseassetWithHttpInfo(responseAssetId, body);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Update response asset 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="responseAssetId">Asset Id</param>
    /// <param name="body">request</param>
    /// <returns>ApiResponse of ResponseAsset</returns>

    public ApiResponse<ResponseAsset> PutResponsemanagementResponseassetWithHttpInfo(string responseAssetId, ResponseAssetRequest body)
    {
        // verify the required parameter 'responseAssetId' is set
        if (responseAssetId == null)
        {
            throw new ApiException(400, "Missing required parameter 'responseAssetId' when calling ResponseManagementApi->PutResponsemanagementResponseasset");
        }
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling ResponseManagementApi->PutResponsemanagementResponseasset");
        }

        var localVarPath = "/api/v2/responsemanagement/responseassets/{responseAssetId}";
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
        if (responseAssetId != null)
        {
            localVarPathParams.Add("responseAssetId", Configuration.ApiClient.ParameterToString(responseAssetId));
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
            Method.Put, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
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
            throw new ApiException(localVarStatusCode, "Error calling PutResponsemanagementResponseasset: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PutResponsemanagementResponseasset: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<ResponseAsset>(localVarStatusCode,
            localVarHeaders,
            (ResponseAsset)Configuration.ApiClient.Deserialize(localVarResponse, typeof(ResponseAsset)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Update response asset 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="responseAssetId">Asset Id</param>
    /// <param name="body">request</param>
    /// <returns>Task of ResponseAsset</returns>

    public async Task<ResponseAsset> PutResponsemanagementResponseassetAsync(string responseAssetId, ResponseAssetRequest body)
    {
        ApiResponse<ResponseAsset> localVarResponse = await PutResponsemanagementResponseassetAsyncWithHttpInfo(responseAssetId, body);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Update response asset 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="responseAssetId">Asset Id</param>
    /// <param name="body">request</param>
    /// <returns>Task of ApiResponse (ResponseAsset)</returns>

    public async Task<ApiResponse<ResponseAsset>> PutResponsemanagementResponseassetAsyncWithHttpInfo(string responseAssetId, ResponseAssetRequest body)
    {
        // verify the required parameter 'responseAssetId' is set
        if (responseAssetId == null)
        {
            throw new ApiException(400, "Missing required parameter 'responseAssetId' when calling ResponseManagementApi->PutResponsemanagementResponseasset");
        }

        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling ResponseManagementApi->PutResponsemanagementResponseasset");
        }

        var localVarPath = "/api/v2/responsemanagement/responseassets/{responseAssetId}";
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
        if (responseAssetId != null)
        {
            localVarPathParams.Add("responseAssetId", Configuration.ApiClient.ParameterToString(responseAssetId));
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
            Method.Put, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
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
            throw new ApiException(localVarStatusCode, "Error calling PutResponsemanagementResponseasset: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PutResponsemanagementResponseasset: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<ResponseAsset>(localVarStatusCode,
            localVarHeaders,
            (ResponseAsset)Configuration.ApiClient.Deserialize(localVarResponse, typeof(ResponseAsset)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



}
