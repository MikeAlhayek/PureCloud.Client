using PureCloud.Client.Models;
using PureCloud.Client.Models.Users;

namespace PureCloud.Client.Contracts;

public interface IOrganizationAuthorizationApi
{
    Task<TrustEntityListing> GetTrusteesAsync(int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default);

    Task<Trustee> GetTrusteeAsync(string trusteeOrgId, CancellationToken cancellationToken = default);

    Task<Trustee> CreateTrusteeAsync(TrustCreate body, CancellationToken cancellationToken = default);

    Task<Trustee> UpdateTrusteeAsync(string trusteeOrgId, TrustUpdate body, CancellationToken cancellationToken = default);

    Task<bool> DeleteTrusteeAsync(string trusteeOrgId, CancellationToken cancellationToken = default);

    Task<bool> DeleteTrusteeClonedUserAsync(string trusteeOrgId, string trusteeUserId, CancellationToken cancellationToken = default);

    Task<bool> DeleteTrusteeGroupAsync(string trusteeOrgId, string trusteeGroupId, CancellationToken cancellationToken = default);

    Task<bool> DeleteTrusteeGroupRolesAsync(string trusteeOrgId, string trusteeGroupId, CancellationToken cancellationToken = default);

    Task<bool> DeleteTrusteeUserAsync(string trusteeOrgId, string trusteeUserId, CancellationToken cancellationToken = default);

    Task<bool> DeleteTrusteeUserRolesAsync(string trusteeOrgId, string trusteeUserId, CancellationToken cancellationToken = default);

    Task<bool> DeleteTrusteesAsync(IEnumerable<string> ids, CancellationToken cancellationToken = default);

    Task<bool> DeleteTrustorAsync(string trustorOrgId, CancellationToken cancellationToken = default);

    Task<bool> DeleteTrustorClonedUserAsync(string trustorOrgId, string trusteeUserId, CancellationToken cancellationToken = default);

    Task<bool> DeleteTrustorGroupAsync(string trustorOrgId, string trustorGroupId, CancellationToken cancellationToken = default);

    Task<bool> DeleteTrustorUserAsync(string trustorOrgId, string trusteeUserId, CancellationToken cancellationToken = default);

    Task<bool> DeleteTrustorsAsync(IEnumerable<string> ids, CancellationToken cancellationToken = default);

    Task<TrustRequest> GetPairingAsync(string pairingId, CancellationToken cancellationToken = default);

    Task<ClonedUserEntityListing> GetTrusteeClonedUsersAsync(string trusteeOrgId, CancellationToken cancellationToken = default);

    Task<TrustGroup> GetTrusteeGroupAsync(string trusteeOrgId, string trusteeGroupId, CancellationToken cancellationToken = default);

    Task<UserAuthorization> GetTrusteeGroupRolesAsync(string trusteeOrgId, string trusteeGroupId, CancellationToken cancellationToken = default);

    Task<TrustGroupEntityListing> GetTrusteeGroupsAsync(string trusteeOrgId, int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default);

    Task<TrustUser> GetTrusteeUserAsync(string trusteeOrgId, string trusteeUserId, CancellationToken cancellationToken = default);

    Task<UserAuthorization> GetTrusteeUserRolesAsync(string trusteeOrgId, string trusteeUserId, CancellationToken cancellationToken = default);

    Task<TrustUserEntityListing> GetTrusteeUsersAsync(string trusteeOrgId, int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default);

    Task<TrusteeReferenceList> GetTrusteesCareAsync(CancellationToken cancellationToken = default);

    Task<Trustee> GetTrusteesDefaultAsync(CancellationToken cancellationToken = default);

    Task<TrustorEntityListing> GetTrustorsAsync(int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default);

    Task<Trustor> GetTrustorAsync(string trustorOrgId, CancellationToken cancellationToken = default);

    Task<ClonedUser> GetTrustorClonedUserAsync(string trustorOrgId, string trusteeUserId, CancellationToken cancellationToken = default);

    Task<ClonedUserEntityListing> GetTrustorClonedUsersAsync(string trustorOrgId, CancellationToken cancellationToken = default);

    Task<TrustGroup> GetTrustorGroupAsync(string trustorOrgId, string trustorGroupId, CancellationToken cancellationToken = default);

    Task<TrustGroupEntityListing> GetTrustorGroupsAsync(string trustorOrgId, int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default);

    Task<TrustUser> GetTrustorUserAsync(string trustorOrgId, string trusteeUserId, CancellationToken cancellationToken = default);

    Task<TrustUserEntityListing> GetTrustorUsersAsync(string trustorOrgId, int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default);

    Task<TrustRequest> CreatePairingAsync(TrustRequestCreate body, CancellationToken cancellationToken = default);

    Task<TrustGroup> CreateTrusteeGroupAsync(string trusteeOrgId, TrustMemberCreate body, CancellationToken cancellationToken = default);

    Task<TrustUser> CreateTrusteeUserAsync(string trusteeOrgId, TrustMemberCreate body, CancellationToken cancellationToken = default);

    Task<TrustEntityListing> CreateTrusteesAuditsAsync(TrusteeAuditQueryRequest body, int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default);

    Task<TrustEntityListing> CreateTrusteesCareAsync(CancellationToken cancellationToken = default);

    Task<Trustee> CreateTrusteesDefaultAsync(CancellationToken cancellationToken = default);

    Task<TrustorEntityListing> CreateTrustorAuditsAsync(TrustorAuditQueryRequest body, int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default);

    Task<UserAuthorization> UpdateTrusteeGroupRoleDivisionsAsync(string trusteeOrgId, string trusteeGroupId, object body, CancellationToken cancellationToken = default);

    Task<UserAuthorization> UpdateTrusteeGroupRolesAsync(string trusteeOrgId, string trusteeGroupId, IEnumerable<string> body, CancellationToken cancellationToken = default);

    Task<UserAuthorization> UpdateTrusteeUserRoleDivisionsAsync(string trusteeOrgId, string trusteeUserId, object body, CancellationToken cancellationToken = default);

    Task<UserAuthorization> UpdateTrusteeUserRolesAsync(string trusteeOrgId, string trusteeUserId, IEnumerable<string> body, CancellationToken cancellationToken = default);

    Task<ClonedUser> UpdateTrustorClonedUserAsync(string trustorOrgId, string trusteeUserId, ClonedUser body, CancellationToken cancellationToken = default);

    Task<TrustGroup> UpdateTrustorGroupAsync(string trustorOrgId, string trustorGroupId, TrustGroup body, CancellationToken cancellationToken = default);

    Task<TrustUser> UpdateTrustorUserAsync(string trustorOrgId, string trusteeUserId, TrustUser body, CancellationToken cancellationToken = default);
}