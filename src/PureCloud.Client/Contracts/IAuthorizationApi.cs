using PureCloud.Client.Models;
using PureCloud.Client.Models.Organizations;
using PureCloud.Client.Models.Users;

namespace PureCloud.Client.Contracts;

public interface IAuthorizationApi
{
    Task<bool> DeleteAuthorizationDivisionAsync(string divisionId, bool? force = null, CancellationToken cancellationToken = default);

    Task<bool> DeleteAuthorizationPoliciesTargetSubjectAsync(string targetName, string subjectId, CancellationToken cancellationToken = default);

    Task<bool> DeleteAuthorizationRoleAsync(string roleId, CancellationToken cancellationToken = default);

    Task<bool> DeleteAuthorizationSubjectDivisionRoleAsync(string subjectId, string divisionId, string roleId, CancellationToken cancellationToken = default);

    Task<AuthzDivision> GetAuthorizationDivisionAsync(string divisionId, bool? objectCount = null, CancellationToken cancellationToken = default);

    Task<AuthzDivisionGrantEntityListing> GetAuthorizationDivisionGrantsAsync(string divisionId, int? pageNumber = null, int? pageSize = null, CancellationToken cancellationToken = default);

    Task<AuthzDivisionEntityListing> GetAuthorizationDivisionsAsync(int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, bool? objectCount = null, List<string> id = null, string name = null, CancellationToken cancellationToken = default);

    Task<AuthzDivisionEntityListing> GetAuthorizationDivisionsDeletedAsync(int? pageNumber = null, int? pageSize = null, CancellationToken cancellationToken = default);

    Task<AuthzDivision> GetAuthorizationDivisionsHomeAsync(CancellationToken cancellationToken = default);

    Task<int?> GetAuthorizationDivisionsLimitAsync(CancellationToken cancellationToken = default);

    Task<AuthzDivisionCursorListing> GetAuthorizationDivisionsQueryAsync(string before = null, string after = null, string pageSize = null, List<string> id = null, string name = null, CancellationToken cancellationToken = default);

    Task<IList<AuthzDivision>> GetAuthorizationDivisionsPermittedMeAsync(string permission, string name = null, CancellationToken cancellationToken = default);

    Task<DivsPermittedEntityListing> GetAuthorizationDivisionsPermittedPagedSubjectAsync(string subjectId, string permission, int? pageNumber = null, int? pageSize = null, CancellationToken cancellationToken = default);

    Task<PermissionCollectionEntityListing> GetAuthorizationPermissionsAsync(int? pageSize = null, int? pageNumber = null, string queryType = null, string query = null, CancellationToken cancellationToken = default);

    Task<AuthorizationPolicyEntityListing> GetAuthorizationPoliciesAsync(string after = null, int? pageSize = null, CancellationToken cancellationToken = default);

    Task<AuthorizationPolicyEntityListing> GetAuthorizationPoliciesSubjectAsync(string subjectId, string after = null, int? pageSize = null, CancellationToken cancellationToken = default);

    Task<AuthorizationPolicyEntityListing> GetAuthorizationPoliciesTargetAsync(string targetName, string after = null, int? pageSize = null, CancellationToken cancellationToken = default);

    Task<AuthorizationPolicy> GetAuthorizationPolicyTargetSubjectAsync(string targetName, string subjectId, CancellationToken cancellationToken = default);
    Task<TargetAttributes> GetAuthorizationPoliciesTargetsAsync(CancellationToken cancellationToken = default);

    Task<AuthorizationPolicy> GetAuthorizationPolicyAsync(string policyId, CancellationToken cancellationToken = default);

    Task<PolicyAttributeSet> GetAuthorizationPolicyAttributesAsync(string policyId, CancellationToken cancellationToken = default);

    Task<OrganizationProductEntityListing> GetAuthorizationProductsAsync(CancellationToken cancellationToken = default);

    Task<DomainOrganizationRole> GetAuthorizationRoleAsync(string roleId, bool? userCount = null, IList<string> expand = null, CancellationToken cancellationToken = default);

    Task<DomainOrgRoleDifference> GetAuthorizationRoleCompareDefaultAsync(string leftRoleId, string rightRoleId, CancellationToken cancellationToken = default);

    Task<SubjectDivisionGrantsEntityListing> GetAuthorizationRoleSubjectGrantsAsync(string roleId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, CancellationToken cancellationToken = default);

    Task<UserReferenceEntityListing> GetAuthorizationRoleUsersAsync(string roleId, int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default);

    Task<OrganizationRoleEntityListing> GetAuthorizationRolesAsync(int? pageSize = null, int? pageNumber = null, string sortBy = null, IList<string> expand = null, string nextPage = null, string previousPage = null, string name = null, IList<string> permission = null, IList<string> defaultRoleId = null, bool? userCount = null, IList<string> id = null, CancellationToken cancellationToken = default);

    Task<RoleSettings> GetAuthorizationRolesSettingsAsync(CancellationToken cancellationToken = default);

    Task<AuthorizationSettings> GetAuthorizationSettingsAsync(CancellationToken cancellationToken = default);

    Task<AuthzSubject> GetAuthorizationSubjectAsync(string subjectId, bool? includeDuplicates = null, CancellationToken cancellationToken = default);

    Task<AuthzSubject> GetAuthorizationSubjectsMeAsync(bool? includeDuplicates = null, CancellationToken cancellationToken = default);

    Task<Dictionary<string, object>> GetAuthorizationSubjectsRoleCountsAsync(IList<string> id = null, CancellationToken cancellationToken = default);

    Task<UserAuthorization> GetUserRolesAsync(string subjectId, CancellationToken cancellationToken = default);

    Task<DomainOrganizationRole> PatchAuthorizationRoleAsync(string roleId, DomainOrganizationRole body, CancellationToken cancellationToken = default);

    Task<AuthorizationSettings> UpdateAuthorizationSettingsAsync(AuthorizationSettings body, CancellationToken cancellationToken = default);

    Task<bool> CreateAuthorizationDivisionObjectAsync(string divisionId, string objectType, List<string> body, CancellationToken cancellationToken = default);

    Task<AuthzDivision> GetAuthorizationDivisionAsync(string divisionId, AuthzDivision body, CancellationToken cancellationToken = default);

    Task<AuthzDivision> CreateAuthorizationDivisionsAsync(AuthzDivision body, CancellationToken cancellationToken = default);

    Task<AuthorizationPolicy> CreateAuthorizationPoliciesTargetAsync(string targetName, AuthorizationPolicy body, CancellationToken cancellationToken = default);

    Task<ValidationErrorListing> ValidateAuthorizationPoliciesTargetAsync(string targetName, AuthorizationPolicy body, CancellationToken cancellationToken = default);

    Task<PolicyTestResult> CreateSimulateAuthorizationPolicyAsync(string policyId, PolicyTestPayload body, CancellationToken cancellationToken = default);

    Task<bool> CreateAuthorizationRoleAsync(string roleId, SubjectDivisions body, string subjectType = null, CancellationToken cancellationToken = default);

    Task<DomainOrgRoleDifference> CreateCompareDefaultAuthorizationRoleAsync(string leftRoleId, string rightRoleId, DomainOrganizationRole body, CancellationToken cancellationToken = default);

    Task<DomainOrganizationRole> CreateAuthorizationRolesAsync(DomainOrganizationRoleCreate body, CancellationToken cancellationToken = default);

    Task<OrganizationRoleEntityListing> CreateAuthorizationRolesDefaultAsync(bool? force = null, CancellationToken cancellationToken = default);

    Task<bool> CreateAuthorizationSubjectBulkAddAsync(string subjectId, RoleDivisionGrants body, string subjectType = null, CancellationToken cancellationToken = default);

    Task<bool> CreateAuthorizationSubjectBulkRemoveAsync(string subjectId, RoleDivisionGrants body, string subjectType = null, CancellationToken cancellationToken = default);

    Task<bool> CreateAuthorizationSubjectBulkReplaceAsync(string subjectId, RoleDivisionGrants body, string subjectType = null, CancellationToken cancellationToken = default);

    Task<bool> CreateAuthorizationSubjectDivisionRoleAsync(string subjectId, string divisionId, string roleId, string subjectType = null, CancellationToken cancellationToken = default);

    Task<AuthzDivision> UpdateAuthorizationDivisionAsync(string divisionId, AuthzDivision body, CancellationToken cancellationToken = default);

    Task<AuthorizationPolicy> UpdateAuthorizationPoliciesTargetAsync(string targetName, AuthorizationPolicy body, CancellationToken cancellationToken = default);

    Task<AuthorizationPolicy> UpdateAuthorizationPolicyAsync(string policyId, AuthorizationPolicy body, CancellationToken cancellationToken = default);

    Task<DomainOrganizationRole> UpdateAuthorizationRoleAsync(string roleId, DomainOrganizationRoleUpdate body, CancellationToken cancellationToken = default);

    Task<IList<string>> CreateAuthorizationRoleUsersAsync(string roleId, IList<string> body, CancellationToken cancellationToken = default);

    Task<IList<string>> UpdateAuthorizationRoleUsersRemoveAsync(string roleId, IList<string> body, CancellationToken cancellationToken = default);

    Task<OrganizationRoleEntityListing> UpdateAuthorizationRolesDefaultAsync(IList<DomainOrganizationRole> body, CancellationToken cancellationToken = default);

    Task<RoleSettings> UpdateAuthorizationRolesSettingsAsync(RoleSettings body, CancellationToken cancellationToken = default);

    Task<UserAuthorization> UpdateUserRolesAsync(string subjectId, IList<string> roles, CancellationToken cancellationToken = default);
}
