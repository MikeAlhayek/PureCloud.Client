using PureCloud.Client.Models;
using PureCloud.Client.Models.Users;

namespace PureCloud.Client.Contracts;

public interface IOrganizationAuthorizationApi
{
    /// <summary>
    /// Get the trustees for the organization.
    /// </summary>
    /// <param name="pageSize">Page size.</param>
    /// <param name="pageNumber">Page number.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the trust entity listing.</returns>
    Task<TrustEntityListing> GetTrusteesAsync(int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a trustee by organization ID.
    /// </summary>
    /// <param name="trusteeOrgId">Trustee organization ID.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the trustee.</returns>
    Task<Trustee> GetTrusteeAsync(string trusteeOrgId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a new trustee.
    /// </summary>
    /// <param name="body">Trust create request.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the created trustee.</returns>
    Task<Trustee> CreateTrusteeAsync(TrustCreate body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update a trustee.
    /// </summary>
    /// <param name="trusteeOrgId">Trustee organization ID.</param>
    /// <param name="body">Trust update request.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the updated trustee.</returns>
    Task<Trustee> UpdateTrusteeAsync(string trusteeOrgId, TrustUpdate body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a trustee.
    /// </summary>
    /// <param name="trusteeOrgId">Trustee organization ID.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>A task that represents the asynchronous operation. The task result indicates whether the operation was successful.</returns>
    Task<bool> DeleteTrusteeAsync(string trusteeOrgId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a trustee cloned user.
    /// </summary>
    /// <param name="trusteeOrgId">Trustee organization ID.</param>
    /// <param name="trusteeUserId">Trustee user ID.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>A task that represents the asynchronous operation. The task result indicates whether the operation was successful.</returns>
    Task<bool> DeleteTrusteeClonedUserAsync(string trusteeOrgId, string trusteeUserId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a trustee group.
    /// </summary>
    /// <param name="trusteeOrgId">Trustee organization ID.</param>
    /// <param name="trusteeGroupId">Trustee group ID.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>A task that represents the asynchronous operation. The task result indicates whether the operation was successful.</returns>
    Task<bool> DeleteTrusteeGroupAsync(string trusteeOrgId, string trusteeGroupId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete trustee group roles.
    /// </summary>
    /// <param name="trusteeOrgId">Trustee organization ID.</param>
    /// <param name="trusteeGroupId">Trustee group ID.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>A task that represents the asynchronous operation. The task result indicates whether the operation was successful.</returns>
    Task<bool> DeleteTrusteeGroupRolesAsync(string trusteeOrgId, string trusteeGroupId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a trustee user.
    /// </summary>
    /// <param name="trusteeOrgId">Trustee organization ID.</param>
    /// <param name="trusteeUserId">Trustee user ID.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>A task that represents the asynchronous operation. The task result indicates whether the operation was successful.</returns>
    Task<bool> DeleteTrusteeUserAsync(string trusteeOrgId, string trusteeUserId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete trustee user roles.
    /// </summary>
    /// <param name="trusteeOrgId">Trustee organization ID.</param>
    /// <param name="trusteeUserId">Trustee user ID.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>A task that represents the asynchronous operation. The task result indicates whether the operation was successful.</returns>
    Task<bool> DeleteTrusteeUserRolesAsync(string trusteeOrgId, string trusteeUserId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete multiple trustees.
    /// </summary>
    /// <param name="ids">Collection of trustee IDs to delete.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>A task that represents the asynchronous operation. The task result indicates whether the operation was successful.</returns>
    Task<bool> DeleteTrusteesAsync(IEnumerable<string> ids, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a trustor.
    /// </summary>
    /// <param name="trustorOrgId">Trustor organization ID.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>A task that represents the asynchronous operation. The task result indicates whether the operation was successful.</returns>
    Task<bool> DeleteTrustorAsync(string trustorOrgId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a trustor cloned user.
    /// </summary>
    /// <param name="trustorOrgId">Trustor organization ID.</param>
    /// <param name="trusteeUserId">Trustee user ID.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>A task that represents the asynchronous operation. The task result indicates whether the operation was successful.</returns>
    Task<bool> DeleteTrustorClonedUserAsync(string trustorOrgId, string trusteeUserId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a trustor group.
    /// </summary>
    /// <param name="trustorOrgId">Trustor organization ID.</param>
    /// <param name="trustorGroupId">Trustor group ID.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>A task that represents the asynchronous operation. The task result indicates whether the operation was successful.</returns>
    Task<bool> DeleteTrustorGroupAsync(string trustorOrgId, string trustorGroupId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a trustor user.
    /// </summary>
    /// <param name="trustorOrgId">Trustor organization ID.</param>
    /// <param name="trusteeUserId">Trustee user ID.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>A task that represents the asynchronous operation. The task result indicates whether the operation was successful.</returns>
    Task<bool> DeleteTrustorUserAsync(string trustorOrgId, string trusteeUserId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete multiple trustors.
    /// </summary>
    /// <param name="ids">Collection of trustor IDs to delete.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>A task that represents the asynchronous operation. The task result indicates whether the operation was successful.</returns>
    Task<bool> DeleteTrustorsAsync(IEnumerable<string> ids, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a pairing request.
    /// </summary>
    /// <param name="pairingId">Pairing ID.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the trust request.</returns>
    Task<TrustRequest> GetPairingAsync(string pairingId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get trustee cloned users.
    /// </summary>
    /// <param name="trusteeOrgId">Trustee organization ID.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the cloned user entity listing.</returns>
    Task<ClonedUserEntityListing> GetTrusteeClonedUsersAsync(string trusteeOrgId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a trustee group.
    /// </summary>
    /// <param name="trusteeOrgId">Trustee organization ID.</param>
    /// <param name="trusteeGroupId">Trustee group ID.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the trust group.</returns>
    Task<TrustGroup> GetTrusteeGroupAsync(string trusteeOrgId, string trusteeGroupId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get trustee group roles.
    /// </summary>
    /// <param name="trusteeOrgId">Trustee organization ID.</param>
    /// <param name="trusteeGroupId">Trustee group ID.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the user authorization.</returns>
    Task<UserAuthorization> GetTrusteeGroupRolesAsync(string trusteeOrgId, string trusteeGroupId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get trustee groups.
    /// </summary>
    /// <param name="trusteeOrgId">Trustee organization ID.</param>
    /// <param name="pageSize">Page size.</param>
    /// <param name="pageNumber">Page number.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the trust group entity listing.</returns>
    Task<TrustGroupEntityListing> GetTrusteeGroupsAsync(string trusteeOrgId, int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a trustee user.
    /// </summary>
    /// <param name="trusteeOrgId">Trustee organization ID.</param>
    /// <param name="trusteeUserId">Trustee user ID.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the trust user.</returns>
    Task<TrustUser> GetTrusteeUserAsync(string trusteeOrgId, string trusteeUserId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get trustee user roles.
    /// </summary>
    /// <param name="trusteeOrgId">Trustee organization ID.</param>
    /// <param name="trusteeUserId">Trustee user ID.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the user authorization.</returns>
    Task<UserAuthorization> GetTrusteeUserRolesAsync(string trusteeOrgId, string trusteeUserId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get trustee users.
    /// </summary>
    /// <param name="trusteeOrgId">Trustee organization ID.</param>
    /// <param name="pageSize">Page size.</param>
    /// <param name="pageNumber">Page number.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the trust user entity listing.</returns>
    Task<TrustUserEntityListing> GetTrusteeUsersAsync(string trusteeOrgId, int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get trustees care.
    /// </summary>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the trustee reference list.</returns>
    Task<TrusteeReferenceList> GetTrusteesCareAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Get default trustee.
    /// </summary>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the trustee.</returns>
    Task<Trustee> GetTrusteesDefaultAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the trustors for the organization.
    /// </summary>
    /// <param name="pageSize">Page size.</param>
    /// <param name="pageNumber">Page number.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the trustor entity listing.</returns>
    Task<TrustorEntityListing> GetTrustorsAsync(int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a trustor by organization ID.
    /// </summary>
    /// <param name="trustorOrgId">Trustor organization ID.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the trustor.</returns>
    Task<Trustor> GetTrustorAsync(string trustorOrgId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a trustor cloned user.
    /// </summary>
    /// <param name="trustorOrgId">Trustor organization ID.</param>
    /// <param name="trusteeUserId">Trustee user ID.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the cloned user.</returns>
    Task<ClonedUser> GetTrustorClonedUserAsync(string trustorOrgId, string trusteeUserId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get trustor cloned users.
    /// </summary>
    /// <param name="trustorOrgId">Trustor organization ID.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the cloned user entity listing.</returns>
    Task<ClonedUserEntityListing> GetTrustorClonedUsersAsync(string trustorOrgId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a trustor group.
    /// </summary>
    /// <param name="trustorOrgId">Trustor organization ID.</param>
    /// <param name="trustorGroupId">Trustor group ID.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the trust group.</returns>
    Task<TrustGroup> GetTrustorGroupAsync(string trustorOrgId, string trustorGroupId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get trustor groups.
    /// </summary>
    /// <param name="trustorOrgId">Trustor organization ID.</param>
    /// <param name="pageSize">Page size.</param>
    /// <param name="pageNumber">Page number.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the trust group entity listing.</returns>
    Task<TrustGroupEntityListing> GetTrustorGroupsAsync(string trustorOrgId, int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a trustor user.
    /// </summary>
    /// <param name="trustorOrgId">Trustor organization ID.</param>
    /// <param name="trusteeUserId">Trustee user ID.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the trust user.</returns>
    Task<TrustUser> GetTrustorUserAsync(string trustorOrgId, string trusteeUserId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get trustor users.
    /// </summary>
    /// <param name="trustorOrgId">Trustor organization ID.</param>
    /// <param name="pageSize">Page size.</param>
    /// <param name="pageNumber">Page number.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the trust user entity listing.</returns>
    Task<TrustUserEntityListing> GetTrustorUsersAsync(string trustorOrgId, int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a pairing request.
    /// </summary>
    /// <param name="body">Trust request create.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the trust request.</returns>
    Task<TrustRequest> CreatePairingAsync(TrustRequestCreate body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a trustee group.
    /// </summary>
    /// <param name="trusteeOrgId">Trustee organization ID.</param>
    /// <param name="body">Trust member create request.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the trust group.</returns>
    Task<TrustGroup> CreateTrusteeGroupAsync(string trusteeOrgId, TrustMemberCreate body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a trustee user.
    /// </summary>
    /// <param name="trusteeOrgId">Trustee organization ID.</param>
    /// <param name="body">Trust member create request.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the trust user.</returns>
    Task<TrustUser> CreateTrusteeUserAsync(string trusteeOrgId, TrustMemberCreate body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create trustees audits.
    /// </summary>
    /// <param name="body">Trustee audit query request.</param>
    /// <param name="pageSize">Page size.</param>
    /// <param name="pageNumber">Page number.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the trust entity listing.</returns>
    Task<TrustEntityListing> CreateTrusteesAuditsAsync(TrusteeAuditQueryRequest body, int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create trustees care.
    /// </summary>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the trust entity listing.</returns>
    Task<TrustEntityListing> CreateTrusteesCareAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Create default trustee.
    /// </summary>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the trustee.</returns>
    Task<Trustee> CreateTrusteesDefaultAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Create trustor audits.
    /// </summary>
    /// <param name="body">Trustor audit query request.</param>
    /// <param name="pageSize">Page size.</param>
    /// <param name="pageNumber">Page number.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the trustor entity listing.</returns>
    Task<TrustorEntityListing> CreateTrustorAuditsAsync(TrustorAuditQueryRequest body, int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update trustee group role divisions.
    /// </summary>
    /// <param name="trusteeOrgId">Trustee organization ID.</param>
    /// <param name="trusteeGroupId">Trustee group ID.</param>
    /// <param name="body">Role division request.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the user authorization.</returns>
    Task<UserAuthorization> UpdateTrusteeGroupRoleDivisionsAsync(string trusteeOrgId, string trusteeGroupId, object body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update trustee group roles.
    /// </summary>
    /// <param name="trusteeOrgId">Trustee organization ID.</param>
    /// <param name="trusteeGroupId">Trustee group ID.</param>
    /// <param name="body">Collection of role IDs.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the user authorization.</returns>
    Task<UserAuthorization> UpdateTrusteeGroupRolesAsync(string trusteeOrgId, string trusteeGroupId, IEnumerable<string> body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update trustee user role divisions.
    /// </summary>
    /// <param name="trusteeOrgId">Trustee organization ID.</param>
    /// <param name="trusteeUserId">Trustee user ID.</param>
    /// <param name="body">Role division request.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the user authorization.</returns>
    Task<UserAuthorization> UpdateTrusteeUserRoleDivisionsAsync(string trusteeOrgId, string trusteeUserId, object body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update trustee user roles.
    /// </summary>
    /// <param name="trusteeOrgId">Trustee organization ID.</param>
    /// <param name="trusteeUserId">Trustee user ID.</param>
    /// <param name="body">Collection of role IDs.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the user authorization.</returns>
    Task<UserAuthorization> UpdateTrusteeUserRolesAsync(string trusteeOrgId, string trusteeUserId, IEnumerable<string> body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update a trustor cloned user.
    /// </summary>
    /// <param name="trustorOrgId">Trustor organization ID.</param>
    /// <param name="trusteeUserId">Trustee user ID.</param>
    /// <param name="body">Cloned user update request.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the cloned user.</returns>
    Task<ClonedUser> UpdateTrustorClonedUserAsync(string trustorOrgId, string trusteeUserId, ClonedUser body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update a trustor group.
    /// </summary>
    /// <param name="trustorOrgId">Trustor organization ID.</param>
    /// <param name="trustorGroupId">Trustor group ID.</param>
    /// <param name="body">Trust group update request.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the trust group.</returns>
    Task<TrustGroup> UpdateTrustorGroupAsync(string trustorOrgId, string trustorGroupId, TrustGroup body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update a trustor user.
    /// </summary>
    /// <param name="trustorOrgId">Trustor organization ID.</param>
    /// <param name="trusteeUserId">Trustee user ID.</param>
    /// <param name="body">Trust user update request.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the trust user.</returns>
    Task<TrustUser> UpdateTrustorUserAsync(string trustorOrgId, string trusteeUserId, TrustUser body, CancellationToken cancellationToken = default);
}
