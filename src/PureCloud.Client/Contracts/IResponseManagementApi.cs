using PureCloud.Client.Models;

namespace PureCloud.Client.Contracts;

public interface IResponseManagementApiV2
{
    /// <summary>
    /// Gets a list of response management libraries
    /// </summary>
    /// <param name="pageNumber">Page number (optional)</param>
    /// <param name="pageSize">Page size (optional)</param>
    /// <param name="messagingTemplateFilter">Filter by messaging template (optional)</param>
    /// <param name="libraryPrefix">Filter by library prefix (optional)</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A list of response management libraries</returns>
    Task<SimpleLibraryEntityListing> GetResponseManagementLibrariesAsync(int? pageNumber = null, int? pageSize = null, string messagingTemplateFilter = null, string libraryPrefix = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets a response management library by ID
    /// </summary>
    /// <param name="libraryId">The library ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The response management library</returns>
    Task<Library> GetResponseManagementLibraryAsync(string libraryId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Creates a new response management library
    /// </summary>
    /// <param name="body">The library to create</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The created response management library</returns>
    Task<Library> CreateResponseManagementLibraryAsync(Library body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Updates a response management library
    /// </summary>
    /// <param name="libraryId">The library ID</param>
    /// <param name="body">The updated library</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The updated response management library</returns>
    Task<Library> UpdateResponseManagementLibraryAsync(string libraryId, Library body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Deletes a response management library
    /// </summary>
    /// <param name="libraryId">The library ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if the library was successfully deleted</returns>
    Task<bool> DeleteResponseManagementLibraryAsync(string libraryId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Creates multiple response management libraries in bulk
    /// </summary>
    /// <param name="body">The batch request containing libraries to create</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A list of created response management libraries</returns>
    Task<SimpleLibraryEntityListing> CreateResponseManagementLibrariesBulkAsync(LibraryBatchRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets a list of response management responses
    /// </summary>
    /// <param name="libraryId">The library ID</param>
    /// <param name="pageNumber">Page number (optional)</param>
    /// <param name="pageSize">Page size (optional)</param>
    /// <param name="expand">Which fields to expand (optional)</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A list of response management responses</returns>
    Task<SimpleResponseEntityListing> GetResponseManagementResponsesAsync(string libraryId, int? pageNumber = null, int? pageSize = null, string expand = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets a response management response by ID
    /// </summary>
    /// <param name="responseId">The response ID</param>
    /// <param name="expand">Which fields to expand (optional)</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The response management response</returns>
    Task<Response> GetResponseManagementResponseAsync(string responseId, string expand = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Creates a new response management response
    /// </summary>
    /// <param name="body">The response to create</param>
    /// <param name="expand">Which fields to expand (optional)</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The created response management response</returns>
    Task<Response> CreateResponseManagementResponseAsync(Response body, string expand = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Updates a response management response
    /// </summary>
    /// <param name="responseId">The response ID</param>
    /// <param name="body">The updated response</param>
    /// <param name="expand">Which fields to expand (optional)</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The updated response management response</returns>
    Task<Response> UpdateResponseManagementResponseAsync(string responseId, Response body, string expand = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Deletes a response management response
    /// </summary>
    /// <param name="responseId">The response ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if the response was successfully deleted</returns>
    Task<bool> DeleteResponseManagementResponseAsync(string responseId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Queries response management responses
    /// </summary>
    /// <param name="body">The query request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The query results</returns>
    Task<SimpleResponseQueryResults> QueryResponseManagementResponsesAsync(ResponseQueryRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets a response management response asset by ID
    /// </summary>
    /// <param name="responseAssetId">The response asset ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The response management response asset</returns>
    Task<ResponseAsset> GetResponseManagementResponseAssetAsync(string responseAssetId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Updates a response management response asset
    /// </summary>
    /// <param name="responseAssetId">The response asset ID</param>
    /// <param name="body">The updated response asset</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The updated response management response asset</returns>
    Task<ResponseAsset> UpdateResponseManagementResponseAssetAsync(string responseAssetId, ResponseAssetRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Deletes a response management response asset
    /// </summary>
    /// <param name="responseAssetId">The response asset ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if the response asset was successfully deleted</returns>
    Task<bool> DeleteResponseManagementResponseAssetAsync(string responseAssetId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Searches response management response assets
    /// </summary>
    /// <param name="body">The search request</param>
    /// <param name="expand">Which fields to expand (optional)</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The search results</returns>
    Task<ResponseAssetSearchResults> SearchResponseManagementResponseAssetsAsync(ResponseAssetSearchRequest body, IEnumerable<string> expand = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Uploads a response management response asset
    /// </summary>
    /// <param name="body">The upload request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The upload response</returns>
    Task<CreateResponseAssetResponse> UploadResponseManagementResponseAssetAsync(CreateResponseAssetRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets the status of a response management response asset
    /// </summary>
    /// <param name="statusId">The status ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The response asset status</returns>
    Task<ResponseAssetStatus> GetResponseManagementResponseAssetStatusAsync(string statusId, CancellationToken cancellationToken = default);
}
