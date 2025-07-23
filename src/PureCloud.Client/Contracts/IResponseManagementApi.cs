using PureCloud.Client.Models;

namespace PureCloud.Client.Contracts;

public interface IResponseManagementApiV2
{
    // Libraries
    Task<SimpleLibraryEntityListing> GetResponseManagementLibrariesAsync(int? pageNumber = null, int? pageSize = null, string messagingTemplateFilter = null, string libraryPrefix = null, CancellationToken cancellationToken = default);
    
    Task<Library> GetResponseManagementLibraryAsync(string libraryId, CancellationToken cancellationToken = default);
    
    Task<Library> CreateResponseManagementLibraryAsync(Library body, CancellationToken cancellationToken = default);
    
    Task<Library> UpdateResponseManagementLibraryAsync(string libraryId, Library body, CancellationToken cancellationToken = default);
    
    Task DeleteResponseManagementLibraryAsync(string libraryId, CancellationToken cancellationToken = default);
    
    Task<SimpleLibraryEntityListing> CreateResponseManagementLibrariesBulkAsync(LibraryBatchRequest body, CancellationToken cancellationToken = default);

    // Responses
    Task<SimpleResponseEntityListing> GetResponseManagementResponsesAsync(string libraryId, int? pageNumber = null, int? pageSize = null, string expand = null, CancellationToken cancellationToken = default);
    
    Task<Response> GetResponseManagementResponseAsync(string responseId, string expand = null, CancellationToken cancellationToken = default);
    
    Task<Response> CreateResponseManagementResponseAsync(Response body, string expand = null, CancellationToken cancellationToken = default);
    
    Task<Response> UpdateResponseManagementResponseAsync(string responseId, Response body, string expand = null, CancellationToken cancellationToken = default);
    
    Task DeleteResponseManagementResponseAsync(string responseId, CancellationToken cancellationToken = default);
    
    Task<SimpleResponseQueryResults> QueryResponseManagementResponsesAsync(ResponseQueryRequest body, CancellationToken cancellationToken = default);

    // Response Assets
    Task<ResponseAsset> GetResponseManagementResponseAssetAsync(string responseAssetId, CancellationToken cancellationToken = default);
    
    Task<ResponseAsset> UpdateResponseManagementResponseAssetAsync(string responseAssetId, ResponseAssetRequest body, CancellationToken cancellationToken = default);
    
    Task DeleteResponseManagementResponseAssetAsync(string responseAssetId, CancellationToken cancellationToken = default);
    
    Task<ResponseAssetSearchResults> SearchResponseManagementResponseAssetsAsync(ResponseAssetSearchRequest body, List<string> expand = null, CancellationToken cancellationToken = default);
    
    Task<CreateResponseAssetResponse> UploadResponseManagementResponseAssetAsync(CreateResponseAssetRequest body, CancellationToken cancellationToken = default);
    
    Task<ResponseAssetStatus> GetResponseManagementResponseAssetStatusAsync(string statusId, CancellationToken cancellationToken = default);
}