using PureCloud.Client.Models;

namespace PureCloud.Client.Contracts;

public interface IContentManagementApi
{
    Task<bool> DeleteContentmanagementDocumentIdAsync(string documentId, bool? overrideFlag = null, CancellationToken cancellationToken = default);

    Task<bool> DeleteContentmanagementShareAsync(string shareId, CancellationToken cancellationToken = default);

    Task<bool> DeleteContentmanagementStatusAsync(string statusId, CancellationToken cancellationToken = default);

    Task<bool> DeleteContentmanagementDocumentAsync(string documentId, bool? overrideFlag = null, CancellationToken cancellationToken = default);

    Task<bool> DeleteContentmanagementWorkspaceMemberAsync(string workspaceId, string memberId, CancellationToken cancellationToken = default);

    Task<bool> DeleteContentmanagementWorkspaceTagvalueAsync(string workspaceId, string tagId, CancellationToken cancellationToken = default);

    Task<Document> GetContentmanagementDocumentAsync(string documentId, List<string> expand = null, CancellationToken cancellationToken = default);

    Task<DownloadResponse> GetContentmanagementDocumentContentAsync(string documentId, string disposition = null, string contentType = null, CancellationToken cancellationToken = default);

    Task<DocumentEntityListing> GetContentmanagementDocumentsAsync(string workspaceId, string name = null, List<string> expand = null, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, CancellationToken cancellationToken = default);

    Task<QueryResults> GetContentmanagementQueryAsync(string queryPhrase, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, List<string> expand = null, CancellationToken cancellationToken = default);

    Task<SecurityProfile> GetContentmanagementSecurityprofileAsync(string securityProfileId, CancellationToken cancellationToken = default);

    Task<SecurityProfileEntityListing> GetContentmanagementSecurityprofilesAsync(CancellationToken cancellationToken = default);

    Task<Share> GetContentmanagementShareAsync(string shareId, List<string> expand = null, CancellationToken cancellationToken = default);

    Task<SharedResponse> GetContentmanagementSharedAsync(string sharedId, string disposition = null, string contentType = null, string expand = null, CancellationToken cancellationToken = default);

    Task<ShareEntityListing> GetContentmanagementSharesAsync(string entityId = null, List<string> expand = null, int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default);

    Task<CommandStatusEntityListing> GetContentmanagementStatusAsync(int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default);

    Task<CommandStatus> GetContentmanagementStatusStatusIdAsync(string statusId, CancellationToken cancellationToken = default);

    Task<Usage> GetContentmanagementUsageAsync(CancellationToken cancellationToken = default);

    Task<Workspace> GetContentmanagementWorkspaceAsync(string workspaceId, List<string> expand = null, CancellationToken cancellationToken = default);

    Task<DocumentEntityListing> GetContentmanagementWorkspaceDocumentsAsync(string workspaceId, List<string> expand = null, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, CancellationToken cancellationToken = default);

    Task<WorkspaceMember> GetContentmanagementWorkspaceMemberAsync(string workspaceId, string memberId, List<string> expand = null, CancellationToken cancellationToken = default);

    Task<WorkspaceMemberEntityListing> GetContentmanagementWorkspaceMembersAsync(string workspaceId, int? pageSize = null, int? pageNumber = null, List<string> expand = null, CancellationToken cancellationToken = default);

    Task<TagValue> GetContentmanagementWorkspaceTagvalueAsync(string workspaceId, string tagId, List<string> expand = null, CancellationToken cancellationToken = default);

    Task<TagValueEntityListing> GetContentmanagementWorkspaceTagvaluesAsync(string workspaceId, string value = null, int? pageSize = null, int? pageNumber = null, List<string> expand = null, CancellationToken cancellationToken = default);

    Task<WorkspaceEntityListing> GetContentmanagementWorkspacesAsync(int? pageSize = null, int? pageNumber = null, List<string> access = null, List<string> expand = null, CancellationToken cancellationToken = default);

    Task<Document> PostContentmanagementDocumentAsync(string documentId, DocumentUpdate body, string expand = null, bool? _override = null, CancellationToken cancellationToken = default);

    Task<ReplaceResponse> PostContentmanagementDocumentContentAsync(string documentId, ReplaceRequest body, bool? _override = null, CancellationToken cancellationToken = default);

    Task<QueryResults> PostContentmanagementQueryAsync(QueryRequest body, string expand = null, CancellationToken cancellationToken = default);

    Task<CreateShareResponse> PostContentmanagementSharesAsync(CreateShareRequest body, CancellationToken cancellationToken = default);

    Task<TagValue> PostContentmanagementWorkspaceTagvaluesAsync(string workspaceId, TagValue body, CancellationToken cancellationToken = default);

    Task<Workspace> PostContentmanagementWorkspacesAsync(WorkspaceCreate body, CancellationToken cancellationToken = default);

    Task<Workspace> PutContentmanagementWorkspaceAsync(string workspaceId, Workspace body, CancellationToken cancellationToken = default);

    Task<WorkspaceMember> PutContentmanagementWorkspaceMemberAsync(string workspaceId, string memberId, WorkspaceMember body, CancellationToken cancellationToken = default);

    Task<TagValue> PutContentmanagementWorkspaceTagvalueAsync(string workspaceId, string tagId, TagValue body, CancellationToken cancellationToken = default);
}
