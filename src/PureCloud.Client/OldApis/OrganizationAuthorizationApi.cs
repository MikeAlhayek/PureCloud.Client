using PureCloud.Client.Models;
using RestSharp;

namespace PureCloud.Client.Apis;


/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IOrganizationAuthorizationApi : IApiAccessor
{
    #region Synchronous Operations

    /// <summary>
    /// Delete Org Trust
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <returns></returns>

    void DeleteOrgauthorizationTrustee(string trusteeOrgId);

    /// <summary>
    /// Delete Org Trust
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <returns>ApiResponse of Object(void)</returns>

    ApiResponse<object> DeleteOrgauthorizationTrusteeWithHttpInfo(string trusteeOrgId);

    /// <summary>
    /// Deletes cloned user
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="trusteeUserId">Id of the cloned user to delete</param>
    /// <returns></returns>

    void DeleteOrgauthorizationTrusteeCloneduser(string trusteeOrgId, string trusteeUserId);

    /// <summary>
    /// Deletes cloned user
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="trusteeUserId">Id of the cloned user to delete</param>
    /// <returns>ApiResponse of Object(void)</returns>

    ApiResponse<object> DeleteOrgauthorizationTrusteeCloneduserWithHttpInfo(string trusteeOrgId, string trusteeUserId);

    /// <summary>
    /// Delete Trustee Group
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="trusteeGroupId">Trustee Group Id</param>
    /// <returns></returns>

    void DeleteOrgauthorizationTrusteeGroup(string trusteeOrgId, string trusteeGroupId);

    /// <summary>
    /// Delete Trustee Group
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="trusteeGroupId">Trustee Group Id</param>
    /// <returns>ApiResponse of Object(void)</returns>

    ApiResponse<object> DeleteOrgauthorizationTrusteeGroupWithHttpInfo(string trusteeOrgId, string trusteeGroupId);

    /// <summary>
    /// Delete Trustee Group Roles
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="trusteeGroupId">Trustee Group Id</param>
    /// <returns></returns>

    void DeleteOrgauthorizationTrusteeGroupRoles(string trusteeOrgId, string trusteeGroupId);

    /// <summary>
    /// Delete Trustee Group Roles
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="trusteeGroupId">Trustee Group Id</param>
    /// <returns>ApiResponse of Object(void)</returns>

    ApiResponse<object> DeleteOrgauthorizationTrusteeGroupRolesWithHttpInfo(string trusteeOrgId, string trusteeGroupId);

    /// <summary>
    /// Delete Trustee User
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="trusteeUserId">Trustee User Id</param>
    /// <returns></returns>

    void DeleteOrgauthorizationTrusteeUser(string trusteeOrgId, string trusteeUserId);

    /// <summary>
    /// Delete Trustee User
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="trusteeUserId">Trustee User Id</param>
    /// <returns>ApiResponse of Object(void)</returns>

    ApiResponse<object> DeleteOrgauthorizationTrusteeUserWithHttpInfo(string trusteeOrgId, string trusteeUserId);

    /// <summary>
    /// Delete Trustee User Roles
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="trusteeUserId">Trustee User Id</param>
    /// <returns></returns>

    void DeleteOrgauthorizationTrusteeUserRoles(string trusteeOrgId, string trusteeUserId);

    /// <summary>
    /// Delete Trustee User Roles
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="trusteeUserId">Trustee User Id</param>
    /// <returns>ApiResponse of Object(void)</returns>

    ApiResponse<object> DeleteOrgauthorizationTrusteeUserRolesWithHttpInfo(string trusteeOrgId, string trusteeUserId);

    /// <summary>
    /// Delete Bulk Org Trustees
    /// </summary>
    /// <remarks>
    /// 
    /// DeleteOrgauthorizationTrustees is a preview method and is subject to both breaking and non-breaking changes at any time without notice
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="id">Comma separated list of trustee ids to remove</param>
    /// <returns></returns>

    void DeleteOrgauthorizationTrustees(List<string> id);

    /// <summary>
    /// Delete Bulk Org Trustees
    /// </summary>
    /// <remarks>
    /// 
    /// DeleteOrgauthorizationTrustees is a preview method and is subject to both breaking and non-breaking changes at any time without notice
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="id">Comma separated list of trustee ids to remove</param>
    /// <returns>ApiResponse of Object(void)</returns>

    ApiResponse<object> DeleteOrgauthorizationTrusteesWithHttpInfo(List<string> id);

    /// <summary>
    /// Delete Org Trust
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trustorOrgId">Trustor Organization Id</param>
    /// <returns></returns>

    void DeleteOrgauthorizationTrustor(string trustorOrgId);

    /// <summary>
    /// Delete Org Trust
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trustorOrgId">Trustor Organization Id</param>
    /// <returns>ApiResponse of Object(void)</returns>

    ApiResponse<object> DeleteOrgauthorizationTrustorWithHttpInfo(string trustorOrgId);

    /// <summary>
    /// Delete Cloned User
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trustorOrgId">Trustor Organization Id</param>
    /// <param name="trusteeUserId">Trustee User Id</param>
    /// <returns></returns>

    void DeleteOrgauthorizationTrustorCloneduser(string trustorOrgId, string trusteeUserId);

    /// <summary>
    /// Delete Cloned User
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trustorOrgId">Trustor Organization Id</param>
    /// <param name="trusteeUserId">Trustee User Id</param>
    /// <returns>ApiResponse of Object(void)</returns>

    ApiResponse<object> DeleteOrgauthorizationTrustorCloneduserWithHttpInfo(string trustorOrgId, string trusteeUserId);

    /// <summary>
    /// Delete Trustee Group
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trustorOrgId">Trustor Organization Id</param>
    /// <param name="trustorGroupId">Trustor Group Id</param>
    /// <returns></returns>

    void DeleteOrgauthorizationTrustorGroup(string trustorOrgId, string trustorGroupId);

    /// <summary>
    /// Delete Trustee Group
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trustorOrgId">Trustor Organization Id</param>
    /// <param name="trustorGroupId">Trustor Group Id</param>
    /// <returns>ApiResponse of Object(void)</returns>

    ApiResponse<object> DeleteOrgauthorizationTrustorGroupWithHttpInfo(string trustorOrgId, string trustorGroupId);

    /// <summary>
    /// Delete Trustee User
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trustorOrgId">Trustor Organization Id</param>
    /// <param name="trusteeUserId">Trustee User Id</param>
    /// <returns></returns>

    void DeleteOrgauthorizationTrustorUser(string trustorOrgId, string trusteeUserId);

    /// <summary>
    /// Delete Trustee User
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trustorOrgId">Trustor Organization Id</param>
    /// <param name="trusteeUserId">Trustee User Id</param>
    /// <returns>ApiResponse of Object(void)</returns>

    ApiResponse<object> DeleteOrgauthorizationTrustorUserWithHttpInfo(string trustorOrgId, string trusteeUserId);

    /// <summary>
    /// Delete Bulk Org Trustors
    /// </summary>
    /// <remarks>
    /// 
    /// DeleteOrgauthorizationTrustors is a preview method and is subject to both breaking and non-breaking changes at any time without notice
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="id">Comma separated list of trustor ids to remove</param>
    /// <returns></returns>

    void DeleteOrgauthorizationTrustors(List<string> id);

    /// <summary>
    /// Delete Bulk Org Trustors
    /// </summary>
    /// <remarks>
    /// 
    /// DeleteOrgauthorizationTrustors is a preview method and is subject to both breaking and non-breaking changes at any time without notice
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="id">Comma separated list of trustor ids to remove</param>
    /// <returns>ApiResponse of Object(void)</returns>

    ApiResponse<object> DeleteOrgauthorizationTrustorsWithHttpInfo(List<string> id);

    /// <summary>
    /// Get Pairing Info
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pairingId">Pairing Id</param>
    /// <returns>TrustRequest</returns>

    TrustRequest GetOrgauthorizationPairing(string pairingId);

    /// <summary>
    /// Get Pairing Info
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pairingId">Pairing Id</param>
    /// <returns>ApiResponse of TrustRequest</returns>

    ApiResponse<TrustRequest> GetOrgauthorizationPairingWithHttpInfo(string pairingId);

    /// <summary>
    /// Get Org Trust
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <returns>Trustee</returns>

    Trustee GetOrgauthorizationTrustee(string trusteeOrgId);

    /// <summary>
    /// Get Org Trust
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <returns>ApiResponse of Trustee</returns>

    ApiResponse<Trustee> GetOrgauthorizationTrusteeWithHttpInfo(string trusteeOrgId);

    /// <summary>
    /// The list of cloned users from the trustee organization (i.e. users with a native user record).
    /// </summary>
    /// <remarks>
    /// There can be no more than 5 cloned users per organization, so results are represented as simple list and not paged
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <returns>ClonedUserEntityListing</returns>

    ClonedUserEntityListing GetOrgauthorizationTrusteeClonedusers(string trusteeOrgId);

    /// <summary>
    /// The list of cloned users from the trustee organization (i.e. users with a native user record).
    /// </summary>
    /// <remarks>
    /// There can be no more than 5 cloned users per organization, so results are represented as simple list and not paged
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <returns>ApiResponse of ClonedUserEntityListing</returns>

    ApiResponse<ClonedUserEntityListing> GetOrgauthorizationTrusteeClonedusersWithHttpInfo(string trusteeOrgId);

    /// <summary>
    /// Get Trustee Group
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="trusteeGroupId">Trustee Group Id</param>
    /// <returns>TrustGroup</returns>

    TrustGroup GetOrgauthorizationTrusteeGroup(string trusteeOrgId, string trusteeGroupId);

    /// <summary>
    /// Get Trustee Group
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="trusteeGroupId">Trustee Group Id</param>
    /// <returns>ApiResponse of TrustGroup</returns>

    ApiResponse<TrustGroup> GetOrgauthorizationTrusteeGroupWithHttpInfo(string trusteeOrgId, string trusteeGroupId);

    /// <summary>
    /// Get Trustee Group Roles
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="trusteeGroupId">Trustee Group Id</param>
    /// <returns>UserAuthorization</returns>

    UserAuthorization GetOrgauthorizationTrusteeGroupRoles(string trusteeOrgId, string trusteeGroupId);

    /// <summary>
    /// Get Trustee Group Roles
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="trusteeGroupId">Trustee Group Id</param>
    /// <returns>ApiResponse of UserAuthorization</returns>

    ApiResponse<UserAuthorization> GetOrgauthorizationTrusteeGroupRolesWithHttpInfo(string trusteeOrgId, string trusteeGroupId);

    /// <summary>
    /// The list of trustee groups for this organization (i.e. groups granted access to this organization).
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <returns>TrustGroupEntityListing</returns>

    TrustGroupEntityListing GetOrgauthorizationTrusteeGroups(string trusteeOrgId, int? pageSize = null, int? pageNumber = null);

    /// <summary>
    /// The list of trustee groups for this organization (i.e. groups granted access to this organization).
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <returns>ApiResponse of TrustGroupEntityListing</returns>

    ApiResponse<TrustGroupEntityListing> GetOrgauthorizationTrusteeGroupsWithHttpInfo(string trusteeOrgId, int? pageSize = null, int? pageNumber = null);

    /// <summary>
    /// Get Trustee User
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="trusteeUserId">Trustee User Id</param>
    /// <returns>TrustUser</returns>

    TrustUser GetOrgauthorizationTrusteeUser(string trusteeOrgId, string trusteeUserId);

    /// <summary>
    /// Get Trustee User
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="trusteeUserId">Trustee User Id</param>
    /// <returns>ApiResponse of TrustUser</returns>

    ApiResponse<TrustUser> GetOrgauthorizationTrusteeUserWithHttpInfo(string trusteeOrgId, string trusteeUserId);

    /// <summary>
    /// Get Trustee User Roles
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="trusteeUserId">Trustee User Id</param>
    /// <returns>UserAuthorization</returns>

    UserAuthorization GetOrgauthorizationTrusteeUserRoles(string trusteeOrgId, string trusteeUserId);

    /// <summary>
    /// Get Trustee User Roles
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="trusteeUserId">Trustee User Id</param>
    /// <returns>ApiResponse of UserAuthorization</returns>

    ApiResponse<UserAuthorization> GetOrgauthorizationTrusteeUserRolesWithHttpInfo(string trusteeOrgId, string trusteeUserId);

    /// <summary>
    /// The list of trustee users for this organization (i.e. users granted access to this organization).
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <returns>TrustUserEntityListing</returns>

    TrustUserEntityListing GetOrgauthorizationTrusteeUsers(string trusteeOrgId, int? pageSize = null, int? pageNumber = null);

    /// <summary>
    /// The list of trustee users for this organization (i.e. users granted access to this organization).
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <returns>ApiResponse of TrustUserEntityListing</returns>

    ApiResponse<TrustUserEntityListing> GetOrgauthorizationTrusteeUsersWithHttpInfo(string trusteeOrgId, int? pageSize = null, int? pageNumber = null);

    /// <summary>
    /// The list of trustees for this organization (i.e. organizations granted access to this organization).
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <returns>TrustEntityListing</returns>

    TrustEntityListing GetOrgauthorizationTrustees(int? pageSize = null, int? pageNumber = null);

    /// <summary>
    /// The list of trustees for this organization (i.e. organizations granted access to this organization).
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <returns>ApiResponse of TrustEntityListing</returns>

    ApiResponse<TrustEntityListing> GetOrgauthorizationTrusteesWithHttpInfo(int? pageSize = null, int? pageNumber = null);

    /// <summary>
    /// Get Customer Care organization ids.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>TrusteeReferenceList</returns>

    TrusteeReferenceList GetOrgauthorizationTrusteesCare();

    /// <summary>
    /// Get Customer Care organization ids.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>ApiResponse of TrusteeReferenceList</returns>

    ApiResponse<TrusteeReferenceList> GetOrgauthorizationTrusteesCareWithHttpInfo();

    /// <summary>
    /// Get organization authorization trust with Customer Care, if one exists.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Trustee</returns>

    Trustee GetOrgauthorizationTrusteesDefault();

    /// <summary>
    /// Get organization authorization trust with Customer Care, if one exists.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>ApiResponse of Trustee</returns>

    ApiResponse<Trustee> GetOrgauthorizationTrusteesDefaultWithHttpInfo();

    /// <summary>
    /// Get Org Trust
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trustorOrgId">Trustor Organization Id</param>
    /// <returns>Trustor</returns>

    Trustor GetOrgauthorizationTrustor(string trustorOrgId);

    /// <summary>
    /// Get Org Trust
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trustorOrgId">Trustor Organization Id</param>
    /// <returns>ApiResponse of Trustor</returns>

    ApiResponse<Trustor> GetOrgauthorizationTrustorWithHttpInfo(string trustorOrgId);

    /// <summary>
    /// Get Cloned User
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trustorOrgId">Trustor Organization Id</param>
    /// <param name="trusteeUserId">Trustee User Id</param>
    /// <returns>ClonedUser</returns>

    ClonedUser GetOrgauthorizationTrustorCloneduser(string trustorOrgId, string trusteeUserId);

    /// <summary>
    /// Get Cloned User
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trustorOrgId">Trustor Organization Id</param>
    /// <param name="trusteeUserId">Trustee User Id</param>
    /// <returns>ApiResponse of ClonedUser</returns>

    ApiResponse<ClonedUser> GetOrgauthorizationTrustorCloneduserWithHttpInfo(string trustorOrgId, string trusteeUserId);

    /// <summary>
    /// The list of cloned users in the trustor organization (i.e. users with a native user record).
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trustorOrgId">Trustor Organization Id</param>
    /// <returns>ClonedUserEntityListing</returns>

    ClonedUserEntityListing GetOrgauthorizationTrustorClonedusers(string trustorOrgId);

    /// <summary>
    /// The list of cloned users in the trustor organization (i.e. users with a native user record).
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trustorOrgId">Trustor Organization Id</param>
    /// <returns>ApiResponse of ClonedUserEntityListing</returns>

    ApiResponse<ClonedUserEntityListing> GetOrgauthorizationTrustorClonedusersWithHttpInfo(string trustorOrgId);

    /// <summary>
    /// Get Trustee Group
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trustorOrgId">Trustor Organization Id</param>
    /// <param name="trustorGroupId">Trustor Group Id</param>
    /// <returns>TrustGroup</returns>

    TrustGroup GetOrgauthorizationTrustorGroup(string trustorOrgId, string trustorGroupId);

    /// <summary>
    /// Get Trustee Group
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trustorOrgId">Trustor Organization Id</param>
    /// <param name="trustorGroupId">Trustor Group Id</param>
    /// <returns>ApiResponse of TrustGroup</returns>

    ApiResponse<TrustGroup> GetOrgauthorizationTrustorGroupWithHttpInfo(string trustorOrgId, string trustorGroupId);

    /// <summary>
    /// The list of groups in the trustor organization (i.e. groups granted access).
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trustorOrgId">Trustee Organization Id</param>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <returns>TrustGroupEntityListing</returns>

    TrustGroupEntityListing GetOrgauthorizationTrustorGroups(string trustorOrgId, int? pageSize = null, int? pageNumber = null);

    /// <summary>
    /// The list of groups in the trustor organization (i.e. groups granted access).
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trustorOrgId">Trustee Organization Id</param>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <returns>ApiResponse of TrustGroupEntityListing</returns>

    ApiResponse<TrustGroupEntityListing> GetOrgauthorizationTrustorGroupsWithHttpInfo(string trustorOrgId, int? pageSize = null, int? pageNumber = null);

    /// <summary>
    /// Get Trustee User
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trustorOrgId">Trustor Organization Id</param>
    /// <param name="trusteeUserId">Trustee User Id</param>
    /// <returns>TrustUser</returns>

    TrustUser GetOrgauthorizationTrustorUser(string trustorOrgId, string trusteeUserId);

    /// <summary>
    /// Get Trustee User
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trustorOrgId">Trustor Organization Id</param>
    /// <param name="trusteeUserId">Trustee User Id</param>
    /// <returns>ApiResponse of TrustUser</returns>

    ApiResponse<TrustUser> GetOrgauthorizationTrustorUserWithHttpInfo(string trustorOrgId, string trusteeUserId);

    /// <summary>
    /// The list of users in the trustor organization (i.e. users granted access).
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trustorOrgId">Trustee Organization Id</param>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <returns>TrustUserEntityListing</returns>

    TrustUserEntityListing GetOrgauthorizationTrustorUsers(string trustorOrgId, int? pageSize = null, int? pageNumber = null);

    /// <summary>
    /// The list of users in the trustor organization (i.e. users granted access).
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trustorOrgId">Trustee Organization Id</param>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <returns>ApiResponse of TrustUserEntityListing</returns>

    ApiResponse<TrustUserEntityListing> GetOrgauthorizationTrustorUsersWithHttpInfo(string trustorOrgId, int? pageSize = null, int? pageNumber = null);

    /// <summary>
    /// The list of organizations that have authorized/trusted your organization.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <returns>TrustorEntityListing</returns>

    TrustorEntityListing GetOrgauthorizationTrustors(int? pageSize = null, int? pageNumber = null);

    /// <summary>
    /// The list of organizations that have authorized/trusted your organization.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <returns>ApiResponse of TrustorEntityListing</returns>

    ApiResponse<TrustorEntityListing> GetOrgauthorizationTrustorsWithHttpInfo(int? pageSize = null, int? pageNumber = null);

    /// <summary>
    /// A pairing id is created by the trustee and given to the trustor to create a trust.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Pairing Info</param>
    /// <returns>TrustRequest</returns>

    TrustRequest PostOrgauthorizationPairings(TrustRequestCreate body);

    /// <summary>
    /// A pairing id is created by the trustee and given to the trustor to create a trust.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Pairing Info</param>
    /// <returns>ApiResponse of TrustRequest</returns>

    ApiResponse<TrustRequest> PostOrgauthorizationPairingsWithHttpInfo(TrustRequestCreate body);

    /// <summary>
    /// Add a group to the trust.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="body">Trust</param>
    /// <returns>TrustGroup</returns>

    TrustGroup PostOrgauthorizationTrusteeGroups(string trusteeOrgId, TrustMemberCreate body);

    /// <summary>
    /// Add a group to the trust.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="body">Trust</param>
    /// <returns>ApiResponse of TrustGroup</returns>

    ApiResponse<TrustGroup> PostOrgauthorizationTrusteeGroupsWithHttpInfo(string trusteeOrgId, TrustMemberCreate body);

    /// <summary>
    /// Add a user to the trust.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="body">Trust</param>
    /// <returns>TrustUser</returns>

    TrustUser PostOrgauthorizationTrusteeUsers(string trusteeOrgId, TrustMemberCreate body);

    /// <summary>
    /// Add a user to the trust.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="body">Trust</param>
    /// <returns>ApiResponse of TrustUser</returns>

    ApiResponse<TrustUser> PostOrgauthorizationTrusteeUsersWithHttpInfo(string trusteeOrgId, TrustMemberCreate body);

    /// <summary>
    /// Create a new organization authorization trust. This is required to grant other organizations access to your organization.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Trust</param>
    /// <returns>Trustee</returns>

    Trustee PostOrgauthorizationTrustees(TrustCreate body);

    /// <summary>
    /// Create a new organization authorization trust. This is required to grant other organizations access to your organization.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Trust</param>
    /// <returns>ApiResponse of Trustee</returns>

    ApiResponse<Trustee> PostOrgauthorizationTrusteesWithHttpInfo(TrustCreate body);

    /// <summary>
    /// Get Org Trustee Audits
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Values to scope the request.</param>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <param name="sortBy">Sort by (optional, default to "timestamp")</param>
    /// <param name="sortOrder">Sort order (optional, default to "descending")</param>
    /// <returns>Object</returns>

    object PostOrgauthorizationTrusteesAudits(TrusteeAuditQueryRequest body, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null);

    /// <summary>
    /// Get Org Trustee Audits
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Values to scope the request.</param>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <param name="sortBy">Sort by (optional, default to "timestamp")</param>
    /// <param name="sortOrder">Sort order (optional, default to "descending")</param>
    /// <returns>ApiResponse of Object</returns>

    ApiResponse<object> PostOrgauthorizationTrusteesAuditsWithHttpInfo(TrusteeAuditQueryRequest body, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null);

    /// <summary>
    /// Create a new organization authorization trust with Customer Care. This is required to grant your regional Customer Care organization access to your organization.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="assignDefaultRole">Assign Admin role to default pairing with Customer Care (optional)</param>
    /// <param name="autoExpire">Automatically expire pairing after 30 days (optional)</param>
    /// <param name="assignFullAccess">Grant Customer Care full access to the organization (optional)</param>
    /// <param name="allowTrustedUserAccess">Make Customer Care a Trusted User (optional)</param>
    /// <returns>TrustEntityListing</returns>

    TrustEntityListing PostOrgauthorizationTrusteesCare(bool? assignDefaultRole = null, bool? autoExpire = null, bool? assignFullAccess = null, bool? allowTrustedUserAccess = null);

    /// <summary>
    /// Create a new organization authorization trust with Customer Care. This is required to grant your regional Customer Care organization access to your organization.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="assignDefaultRole">Assign Admin role to default pairing with Customer Care (optional)</param>
    /// <param name="autoExpire">Automatically expire pairing after 30 days (optional)</param>
    /// <param name="assignFullAccess">Grant Customer Care full access to the organization (optional)</param>
    /// <param name="allowTrustedUserAccess">Make Customer Care a Trusted User (optional)</param>
    /// <returns>ApiResponse of TrustEntityListing</returns>

    ApiResponse<TrustEntityListing> PostOrgauthorizationTrusteesCareWithHttpInfo(bool? assignDefaultRole = null, bool? autoExpire = null, bool? assignFullAccess = null, bool? allowTrustedUserAccess = null);

    /// <summary>
    /// Create a new organization authorization trust with Customer Care. This is required to grant your regional Customer Care organization access to your organization.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="assignDefaultRole">Assign Admin role to default pairing with Customer Care (optional)</param>
    /// <param name="autoExpire">Automatically expire pairing after 30 days (optional)</param>
    /// <returns>Trustee</returns>

    Trustee PostOrgauthorizationTrusteesDefault(bool? assignDefaultRole = null, bool? autoExpire = null);

    /// <summary>
    /// Create a new organization authorization trust with Customer Care. This is required to grant your regional Customer Care organization access to your organization.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="assignDefaultRole">Assign Admin role to default pairing with Customer Care (optional)</param>
    /// <param name="autoExpire">Automatically expire pairing after 30 days (optional)</param>
    /// <returns>ApiResponse of Trustee</returns>

    ApiResponse<Trustee> PostOrgauthorizationTrusteesDefaultWithHttpInfo(bool? assignDefaultRole = null, bool? autoExpire = null);

    /// <summary>
    /// Get Org Trustor Audits
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Values to scope the request.</param>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <param name="sortBy">Sort by (optional, default to "timestamp")</param>
    /// <param name="sortOrder">Sort order (optional, default to "descending")</param>
    /// <returns>Object</returns>

    object PostOrgauthorizationTrustorAudits(TrustorAuditQueryRequest body, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null);

    /// <summary>
    /// Get Org Trustor Audits
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Values to scope the request.</param>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <param name="sortBy">Sort by (optional, default to "timestamp")</param>
    /// <param name="sortOrder">Sort order (optional, default to "descending")</param>
    /// <returns>ApiResponse of Object</returns>

    ApiResponse<object> PostOrgauthorizationTrustorAuditsWithHttpInfo(TrustorAuditQueryRequest body, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null);

    /// <summary>
    /// Update Org Trust
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="body">Client</param>
    /// <returns>Trustee</returns>

    Trustee PutOrgauthorizationTrustee(string trusteeOrgId, TrustUpdate body);

    /// <summary>
    /// Update Org Trust
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="body">Client</param>
    /// <returns>ApiResponse of Trustee</returns>

    ApiResponse<Trustee> PutOrgauthorizationTrusteeWithHttpInfo(string trusteeOrgId, TrustUpdate body);

    /// <summary>
    /// Update Trustee Group Roles
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="trusteeGroupId">Trustee Group Id</param>
    /// <param name="body">Set of roles with corresponding divisions to apply</param>
    /// <returns>UserAuthorization</returns>

    UserAuthorization PutOrgauthorizationTrusteeGroupRoledivisions(string trusteeOrgId, string trusteeGroupId, RoleDivisionGrants body);

    /// <summary>
    /// Update Trustee Group Roles
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="trusteeGroupId">Trustee Group Id</param>
    /// <param name="body">Set of roles with corresponding divisions to apply</param>
    /// <returns>ApiResponse of UserAuthorization</returns>

    ApiResponse<UserAuthorization> PutOrgauthorizationTrusteeGroupRoledivisionsWithHttpInfo(string trusteeOrgId, string trusteeGroupId, RoleDivisionGrants body);

    /// <summary>
    /// Update Trustee Group Roles
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="trusteeGroupId">Trustee Group Id</param>
    /// <param name="body">List of roles</param>
    /// <returns>UserAuthorization</returns>

    UserAuthorization PutOrgauthorizationTrusteeGroupRoles(string trusteeOrgId, string trusteeGroupId, List<string> body);

    /// <summary>
    /// Update Trustee Group Roles
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="trusteeGroupId">Trustee Group Id</param>
    /// <param name="body">List of roles</param>
    /// <returns>ApiResponse of UserAuthorization</returns>

    ApiResponse<UserAuthorization> PutOrgauthorizationTrusteeGroupRolesWithHttpInfo(string trusteeOrgId, string trusteeGroupId, List<string> body);

    /// <summary>
    /// Update Trustee User Roles
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="trusteeUserId">Trustee User Id</param>
    /// <param name="body">Set of roles with corresponding divisions to apply</param>
    /// <returns>UserAuthorization</returns>

    UserAuthorization PutOrgauthorizationTrusteeUserRoledivisions(string trusteeOrgId, string trusteeUserId, RoleDivisionGrants body);

    /// <summary>
    /// Update Trustee User Roles
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="trusteeUserId">Trustee User Id</param>
    /// <param name="body">Set of roles with corresponding divisions to apply</param>
    /// <returns>ApiResponse of UserAuthorization</returns>

    ApiResponse<UserAuthorization> PutOrgauthorizationTrusteeUserRoledivisionsWithHttpInfo(string trusteeOrgId, string trusteeUserId, RoleDivisionGrants body);

    /// <summary>
    /// Update Trustee User Roles
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="trusteeUserId">Trustee User Id</param>
    /// <param name="body">List of roles</param>
    /// <returns>UserAuthorization</returns>

    UserAuthorization PutOrgauthorizationTrusteeUserRoles(string trusteeOrgId, string trusteeUserId, List<string> body);

    /// <summary>
    /// Update Trustee User Roles
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="trusteeUserId">Trustee User Id</param>
    /// <param name="body">List of roles</param>
    /// <returns>ApiResponse of UserAuthorization</returns>

    ApiResponse<UserAuthorization> PutOrgauthorizationTrusteeUserRolesWithHttpInfo(string trusteeOrgId, string trusteeUserId, List<string> body);

    /// <summary>
    /// Creates a clone of the trustee user in the trustor org.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trustorOrgId">Trustor Organization Id</param>
    /// <param name="trusteeUserId">Trustee User Id</param>
    /// <returns>ClonedUser</returns>

    ClonedUser PutOrgauthorizationTrustorCloneduser(string trustorOrgId, string trusteeUserId);

    /// <summary>
    /// Creates a clone of the trustee user in the trustor org.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trustorOrgId">Trustor Organization Id</param>
    /// <param name="trusteeUserId">Trustee User Id</param>
    /// <returns>ApiResponse of ClonedUser</returns>

    ApiResponse<ClonedUser> PutOrgauthorizationTrustorCloneduserWithHttpInfo(string trustorOrgId, string trusteeUserId);

    /// <summary>
    /// Add a Trustee Group to the trust.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trustorOrgId">Trustor Organization Id</param>
    /// <param name="trustorGroupId">Trustor Group Id</param>
    /// <returns>TrustGroup</returns>

    TrustGroup PutOrgauthorizationTrustorGroup(string trustorOrgId, string trustorGroupId);

    /// <summary>
    /// Add a Trustee Group to the trust.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trustorOrgId">Trustor Organization Id</param>
    /// <param name="trustorGroupId">Trustor Group Id</param>
    /// <returns>ApiResponse of TrustGroup</returns>

    ApiResponse<TrustGroup> PutOrgauthorizationTrustorGroupWithHttpInfo(string trustorOrgId, string trustorGroupId);

    /// <summary>
    /// Add a Trustee user to the trust.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trustorOrgId">Trustor Organization Id</param>
    /// <param name="trusteeUserId">Trustee User Id</param>
    /// <returns>TrustUser</returns>

    TrustUser PutOrgauthorizationTrustorUser(string trustorOrgId, string trusteeUserId);

    /// <summary>
    /// Add a Trustee user to the trust.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trustorOrgId">Trustor Organization Id</param>
    /// <param name="trusteeUserId">Trustee User Id</param>
    /// <returns>ApiResponse of TrustUser</returns>

    ApiResponse<TrustUser> PutOrgauthorizationTrustorUserWithHttpInfo(string trustorOrgId, string trusteeUserId);

    #endregion Synchronous Operations

    #region Asynchronous Operations

    /// <summary>
    /// Delete Org Trust
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <returns>Task of void</returns>

    Task DeleteOrgauthorizationTrusteeAsync(string trusteeOrgId);

    /// <summary>
    /// Delete Org Trust
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <returns>Task of ApiResponse</returns>

    Task<ApiResponse<object>> DeleteOrgauthorizationTrusteeAsyncWithHttpInfo(string trusteeOrgId);

    /// <summary>
    /// Deletes cloned user
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="trusteeUserId">Id of the cloned user to delete</param>
    /// <returns>Task of void</returns>

    Task DeleteOrgauthorizationTrusteeCloneduserAsync(string trusteeOrgId, string trusteeUserId);

    /// <summary>
    /// Deletes cloned user
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="trusteeUserId">Id of the cloned user to delete</param>
    /// <returns>Task of ApiResponse</returns>

    Task<ApiResponse<object>> DeleteOrgauthorizationTrusteeCloneduserAsyncWithHttpInfo(string trusteeOrgId, string trusteeUserId);

    /// <summary>
    /// Delete Trustee Group
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="trusteeGroupId">Trustee Group Id</param>
    /// <returns>Task of void</returns>

    Task DeleteOrgauthorizationTrusteeGroupAsync(string trusteeOrgId, string trusteeGroupId);

    /// <summary>
    /// Delete Trustee Group
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="trusteeGroupId">Trustee Group Id</param>
    /// <returns>Task of ApiResponse</returns>

    Task<ApiResponse<object>> DeleteOrgauthorizationTrusteeGroupAsyncWithHttpInfo(string trusteeOrgId, string trusteeGroupId);

    /// <summary>
    /// Delete Trustee Group Roles
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="trusteeGroupId">Trustee Group Id</param>
    /// <returns>Task of void</returns>

    Task DeleteOrgauthorizationTrusteeGroupRolesAsync(string trusteeOrgId, string trusteeGroupId);

    /// <summary>
    /// Delete Trustee Group Roles
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="trusteeGroupId">Trustee Group Id</param>
    /// <returns>Task of ApiResponse</returns>

    Task<ApiResponse<object>> DeleteOrgauthorizationTrusteeGroupRolesAsyncWithHttpInfo(string trusteeOrgId, string trusteeGroupId);

    /// <summary>
    /// Delete Trustee User
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="trusteeUserId">Trustee User Id</param>
    /// <returns>Task of void</returns>

    Task DeleteOrgauthorizationTrusteeUserAsync(string trusteeOrgId, string trusteeUserId);

    /// <summary>
    /// Delete Trustee User
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="trusteeUserId">Trustee User Id</param>
    /// <returns>Task of ApiResponse</returns>

    Task<ApiResponse<object>> DeleteOrgauthorizationTrusteeUserAsyncWithHttpInfo(string trusteeOrgId, string trusteeUserId);

    /// <summary>
    /// Delete Trustee User Roles
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="trusteeUserId">Trustee User Id</param>
    /// <returns>Task of void</returns>

    Task DeleteOrgauthorizationTrusteeUserRolesAsync(string trusteeOrgId, string trusteeUserId);

    /// <summary>
    /// Delete Trustee User Roles
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="trusteeUserId">Trustee User Id</param>
    /// <returns>Task of ApiResponse</returns>

    Task<ApiResponse<object>> DeleteOrgauthorizationTrusteeUserRolesAsyncWithHttpInfo(string trusteeOrgId, string trusteeUserId);

    /// <summary>
    /// Delete Bulk Org Trustees
    /// </summary>
    /// <remarks>
    /// 
    /// DeleteOrgauthorizationTrustees is a preview method and is subject to both breaking and non-breaking changes at any time without notice
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="id">Comma separated list of trustee ids to remove</param>
    /// <returns>Task of void</returns>

    Task DeleteOrgauthorizationTrusteesAsync(List<string> id);

    /// <summary>
    /// Delete Bulk Org Trustees
    /// </summary>
    /// <remarks>
    /// 
    /// DeleteOrgauthorizationTrustees is a preview method and is subject to both breaking and non-breaking changes at any time without notice
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="id">Comma separated list of trustee ids to remove</param>
    /// <returns>Task of ApiResponse</returns>

    Task<ApiResponse<object>> DeleteOrgauthorizationTrusteesAsyncWithHttpInfo(List<string> id);

    /// <summary>
    /// Delete Org Trust
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trustorOrgId">Trustor Organization Id</param>
    /// <returns>Task of void</returns>

    Task DeleteOrgauthorizationTrustorAsync(string trustorOrgId);

    /// <summary>
    /// Delete Org Trust
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trustorOrgId">Trustor Organization Id</param>
    /// <returns>Task of ApiResponse</returns>

    Task<ApiResponse<object>> DeleteOrgauthorizationTrustorAsyncWithHttpInfo(string trustorOrgId);

    /// <summary>
    /// Delete Cloned User
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trustorOrgId">Trustor Organization Id</param>
    /// <param name="trusteeUserId">Trustee User Id</param>
    /// <returns>Task of void</returns>

    Task DeleteOrgauthorizationTrustorCloneduserAsync(string trustorOrgId, string trusteeUserId);

    /// <summary>
    /// Delete Cloned User
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trustorOrgId">Trustor Organization Id</param>
    /// <param name="trusteeUserId">Trustee User Id</param>
    /// <returns>Task of ApiResponse</returns>

    Task<ApiResponse<object>> DeleteOrgauthorizationTrustorCloneduserAsyncWithHttpInfo(string trustorOrgId, string trusteeUserId);

    /// <summary>
    /// Delete Trustee Group
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trustorOrgId">Trustor Organization Id</param>
    /// <param name="trustorGroupId">Trustor Group Id</param>
    /// <returns>Task of void</returns>

    Task DeleteOrgauthorizationTrustorGroupAsync(string trustorOrgId, string trustorGroupId);

    /// <summary>
    /// Delete Trustee Group
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trustorOrgId">Trustor Organization Id</param>
    /// <param name="trustorGroupId">Trustor Group Id</param>
    /// <returns>Task of ApiResponse</returns>

    Task<ApiResponse<object>> DeleteOrgauthorizationTrustorGroupAsyncWithHttpInfo(string trustorOrgId, string trustorGroupId);

    /// <summary>
    /// Delete Trustee User
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trustorOrgId">Trustor Organization Id</param>
    /// <param name="trusteeUserId">Trustee User Id</param>
    /// <returns>Task of void</returns>

    Task DeleteOrgauthorizationTrustorUserAsync(string trustorOrgId, string trusteeUserId);

    /// <summary>
    /// Delete Trustee User
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trustorOrgId">Trustor Organization Id</param>
    /// <param name="trusteeUserId">Trustee User Id</param>
    /// <returns>Task of ApiResponse</returns>

    Task<ApiResponse<object>> DeleteOrgauthorizationTrustorUserAsyncWithHttpInfo(string trustorOrgId, string trusteeUserId);

    /// <summary>
    /// Delete Bulk Org Trustors
    /// </summary>
    /// <remarks>
    /// 
    /// DeleteOrgauthorizationTrustors is a preview method and is subject to both breaking and non-breaking changes at any time without notice
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="id">Comma separated list of trustor ids to remove</param>
    /// <returns>Task of void</returns>

    Task DeleteOrgauthorizationTrustorsAsync(List<string> id);

    /// <summary>
    /// Delete Bulk Org Trustors
    /// </summary>
    /// <remarks>
    /// 
    /// DeleteOrgauthorizationTrustors is a preview method and is subject to both breaking and non-breaking changes at any time without notice
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="id">Comma separated list of trustor ids to remove</param>
    /// <returns>Task of ApiResponse</returns>

    Task<ApiResponse<object>> DeleteOrgauthorizationTrustorsAsyncWithHttpInfo(List<string> id);

    /// <summary>
    /// Get Pairing Info
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pairingId">Pairing Id</param>
    /// <returns>Task of TrustRequest</returns>

    Task<TrustRequest> GetOrgauthorizationPairingAsync(string pairingId);

    /// <summary>
    /// Get Pairing Info
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pairingId">Pairing Id</param>
    /// <returns>Task of ApiResponse (TrustRequest)</returns>

    Task<ApiResponse<TrustRequest>> GetOrgauthorizationPairingAsyncWithHttpInfo(string pairingId);

    /// <summary>
    /// Get Org Trust
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <returns>Task of Trustee</returns>

    Task<Trustee> GetOrgauthorizationTrusteeAsync(string trusteeOrgId);

    /// <summary>
    /// Get Org Trust
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <returns>Task of ApiResponse (Trustee)</returns>

    Task<ApiResponse<Trustee>> GetOrgauthorizationTrusteeAsyncWithHttpInfo(string trusteeOrgId);

    /// <summary>
    /// The list of cloned users from the trustee organization (i.e. users with a native user record).
    /// </summary>
    /// <remarks>
    /// There can be no more than 5 cloned users per organization, so results are represented as simple list and not paged
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <returns>Task of ClonedUserEntityListing</returns>

    Task<ClonedUserEntityListing> GetOrgauthorizationTrusteeClonedusersAsync(string trusteeOrgId);

    /// <summary>
    /// The list of cloned users from the trustee organization (i.e. users with a native user record).
    /// </summary>
    /// <remarks>
    /// There can be no more than 5 cloned users per organization, so results are represented as simple list and not paged
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <returns>Task of ApiResponse (ClonedUserEntityListing)</returns>

    Task<ApiResponse<ClonedUserEntityListing>> GetOrgauthorizationTrusteeClonedusersAsyncWithHttpInfo(string trusteeOrgId);

    /// <summary>
    /// Get Trustee Group
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="trusteeGroupId">Trustee Group Id</param>
    /// <returns>Task of TrustGroup</returns>

    Task<TrustGroup> GetOrgauthorizationTrusteeGroupAsync(string trusteeOrgId, string trusteeGroupId);

    /// <summary>
    /// Get Trustee Group
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="trusteeGroupId">Trustee Group Id</param>
    /// <returns>Task of ApiResponse (TrustGroup)</returns>

    Task<ApiResponse<TrustGroup>> GetOrgauthorizationTrusteeGroupAsyncWithHttpInfo(string trusteeOrgId, string trusteeGroupId);

    /// <summary>
    /// Get Trustee Group Roles
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="trusteeGroupId">Trustee Group Id</param>
    /// <returns>Task of UserAuthorization</returns>

    Task<UserAuthorization> GetOrgauthorizationTrusteeGroupRolesAsync(string trusteeOrgId, string trusteeGroupId);

    /// <summary>
    /// Get Trustee Group Roles
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="trusteeGroupId">Trustee Group Id</param>
    /// <returns>Task of ApiResponse (UserAuthorization)</returns>

    Task<ApiResponse<UserAuthorization>> GetOrgauthorizationTrusteeGroupRolesAsyncWithHttpInfo(string trusteeOrgId, string trusteeGroupId);

    /// <summary>
    /// The list of trustee groups for this organization (i.e. groups granted access to this organization).
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <returns>Task of TrustGroupEntityListing</returns>

    Task<TrustGroupEntityListing> GetOrgauthorizationTrusteeGroupsAsync(string trusteeOrgId, int? pageSize = null, int? pageNumber = null);

    /// <summary>
    /// The list of trustee groups for this organization (i.e. groups granted access to this organization).
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <returns>Task of ApiResponse (TrustGroupEntityListing)</returns>

    Task<ApiResponse<TrustGroupEntityListing>> GetOrgauthorizationTrusteeGroupsAsyncWithHttpInfo(string trusteeOrgId, int? pageSize = null, int? pageNumber = null);

    /// <summary>
    /// Get Trustee User
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="trusteeUserId">Trustee User Id</param>
    /// <returns>Task of TrustUser</returns>

    Task<TrustUser> GetOrgauthorizationTrusteeUserAsync(string trusteeOrgId, string trusteeUserId);

    /// <summary>
    /// Get Trustee User
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="trusteeUserId">Trustee User Id</param>
    /// <returns>Task of ApiResponse (TrustUser)</returns>

    Task<ApiResponse<TrustUser>> GetOrgauthorizationTrusteeUserAsyncWithHttpInfo(string trusteeOrgId, string trusteeUserId);

    /// <summary>
    /// Get Trustee User Roles
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="trusteeUserId">Trustee User Id</param>
    /// <returns>Task of UserAuthorization</returns>

    Task<UserAuthorization> GetOrgauthorizationTrusteeUserRolesAsync(string trusteeOrgId, string trusteeUserId);

    /// <summary>
    /// Get Trustee User Roles
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="trusteeUserId">Trustee User Id</param>
    /// <returns>Task of ApiResponse (UserAuthorization)</returns>

    Task<ApiResponse<UserAuthorization>> GetOrgauthorizationTrusteeUserRolesAsyncWithHttpInfo(string trusteeOrgId, string trusteeUserId);

    /// <summary>
    /// The list of trustee users for this organization (i.e. users granted access to this organization).
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <returns>Task of TrustUserEntityListing</returns>

    Task<TrustUserEntityListing> GetOrgauthorizationTrusteeUsersAsync(string trusteeOrgId, int? pageSize = null, int? pageNumber = null);

    /// <summary>
    /// The list of trustee users for this organization (i.e. users granted access to this organization).
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <returns>Task of ApiResponse (TrustUserEntityListing)</returns>

    Task<ApiResponse<TrustUserEntityListing>> GetOrgauthorizationTrusteeUsersAsyncWithHttpInfo(string trusteeOrgId, int? pageSize = null, int? pageNumber = null);

    /// <summary>
    /// The list of trustees for this organization (i.e. organizations granted access to this organization).
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <returns>Task of TrustEntityListing</returns>

    Task<TrustEntityListing> GetOrgauthorizationTrusteesAsync(int? pageSize = null, int? pageNumber = null);

    /// <summary>
    /// The list of trustees for this organization (i.e. organizations granted access to this organization).
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <returns>Task of ApiResponse (TrustEntityListing)</returns>

    Task<ApiResponse<TrustEntityListing>> GetOrgauthorizationTrusteesAsyncWithHttpInfo(int? pageSize = null, int? pageNumber = null);

    /// <summary>
    /// Get Customer Care organization ids.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of TrusteeReferenceList</returns>

    Task<TrusteeReferenceList> GetOrgauthorizationTrusteesCareAsync();

    /// <summary>
    /// Get Customer Care organization ids.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of ApiResponse (TrusteeReferenceList)</returns>

    Task<ApiResponse<TrusteeReferenceList>> GetOrgauthorizationTrusteesCareAsyncWithHttpInfo();

    /// <summary>
    /// Get organization authorization trust with Customer Care, if one exists.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of Trustee</returns>

    Task<Trustee> GetOrgauthorizationTrusteesDefaultAsync();

    /// <summary>
    /// Get organization authorization trust with Customer Care, if one exists.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of ApiResponse (Trustee)</returns>

    Task<ApiResponse<Trustee>> GetOrgauthorizationTrusteesDefaultAsyncWithHttpInfo();

    /// <summary>
    /// Get Org Trust
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trustorOrgId">Trustor Organization Id</param>
    /// <returns>Task of Trustor</returns>

    Task<Trustor> GetOrgauthorizationTrustorAsync(string trustorOrgId);

    /// <summary>
    /// Get Org Trust
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trustorOrgId">Trustor Organization Id</param>
    /// <returns>Task of ApiResponse (Trustor)</returns>

    Task<ApiResponse<Trustor>> GetOrgauthorizationTrustorAsyncWithHttpInfo(string trustorOrgId);

    /// <summary>
    /// Get Cloned User
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trustorOrgId">Trustor Organization Id</param>
    /// <param name="trusteeUserId">Trustee User Id</param>
    /// <returns>Task of ClonedUser</returns>

    Task<ClonedUser> GetOrgauthorizationTrustorCloneduserAsync(string trustorOrgId, string trusteeUserId);

    /// <summary>
    /// Get Cloned User
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trustorOrgId">Trustor Organization Id</param>
    /// <param name="trusteeUserId">Trustee User Id</param>
    /// <returns>Task of ApiResponse (ClonedUser)</returns>

    Task<ApiResponse<ClonedUser>> GetOrgauthorizationTrustorCloneduserAsyncWithHttpInfo(string trustorOrgId, string trusteeUserId);

    /// <summary>
    /// The list of cloned users in the trustor organization (i.e. users with a native user record).
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trustorOrgId">Trustor Organization Id</param>
    /// <returns>Task of ClonedUserEntityListing</returns>

    Task<ClonedUserEntityListing> GetOrgauthorizationTrustorClonedusersAsync(string trustorOrgId);

    /// <summary>
    /// The list of cloned users in the trustor organization (i.e. users with a native user record).
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trustorOrgId">Trustor Organization Id</param>
    /// <returns>Task of ApiResponse (ClonedUserEntityListing)</returns>

    Task<ApiResponse<ClonedUserEntityListing>> GetOrgauthorizationTrustorClonedusersAsyncWithHttpInfo(string trustorOrgId);

    /// <summary>
    /// Get Trustee Group
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trustorOrgId">Trustor Organization Id</param>
    /// <param name="trustorGroupId">Trustor Group Id</param>
    /// <returns>Task of TrustGroup</returns>

    Task<TrustGroup> GetOrgauthorizationTrustorGroupAsync(string trustorOrgId, string trustorGroupId);

    /// <summary>
    /// Get Trustee Group
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trustorOrgId">Trustor Organization Id</param>
    /// <param name="trustorGroupId">Trustor Group Id</param>
    /// <returns>Task of ApiResponse (TrustGroup)</returns>

    Task<ApiResponse<TrustGroup>> GetOrgauthorizationTrustorGroupAsyncWithHttpInfo(string trustorOrgId, string trustorGroupId);

    /// <summary>
    /// The list of groups in the trustor organization (i.e. groups granted access).
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trustorOrgId">Trustee Organization Id</param>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <returns>Task of TrustGroupEntityListing</returns>

    Task<TrustGroupEntityListing> GetOrgauthorizationTrustorGroupsAsync(string trustorOrgId, int? pageSize = null, int? pageNumber = null);

    /// <summary>
    /// The list of groups in the trustor organization (i.e. groups granted access).
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trustorOrgId">Trustee Organization Id</param>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <returns>Task of ApiResponse (TrustGroupEntityListing)</returns>

    Task<ApiResponse<TrustGroupEntityListing>> GetOrgauthorizationTrustorGroupsAsyncWithHttpInfo(string trustorOrgId, int? pageSize = null, int? pageNumber = null);

    /// <summary>
    /// Get Trustee User
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trustorOrgId">Trustor Organization Id</param>
    /// <param name="trusteeUserId">Trustee User Id</param>
    /// <returns>Task of TrustUser</returns>

    Task<TrustUser> GetOrgauthorizationTrustorUserAsync(string trustorOrgId, string trusteeUserId);

    /// <summary>
    /// Get Trustee User
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trustorOrgId">Trustor Organization Id</param>
    /// <param name="trusteeUserId">Trustee User Id</param>
    /// <returns>Task of ApiResponse (TrustUser)</returns>

    Task<ApiResponse<TrustUser>> GetOrgauthorizationTrustorUserAsyncWithHttpInfo(string trustorOrgId, string trusteeUserId);

    /// <summary>
    /// The list of users in the trustor organization (i.e. users granted access).
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trustorOrgId">Trustee Organization Id</param>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <returns>Task of TrustUserEntityListing</returns>

    Task<TrustUserEntityListing> GetOrgauthorizationTrustorUsersAsync(string trustorOrgId, int? pageSize = null, int? pageNumber = null);

    /// <summary>
    /// The list of users in the trustor organization (i.e. users granted access).
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trustorOrgId">Trustee Organization Id</param>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <returns>Task of ApiResponse (TrustUserEntityListing)</returns>

    Task<ApiResponse<TrustUserEntityListing>> GetOrgauthorizationTrustorUsersAsyncWithHttpInfo(string trustorOrgId, int? pageSize = null, int? pageNumber = null);

    /// <summary>
    /// The list of organizations that have authorized/trusted your organization.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <returns>Task of TrustorEntityListing</returns>

    Task<TrustorEntityListing> GetOrgauthorizationTrustorsAsync(int? pageSize = null, int? pageNumber = null);

    /// <summary>
    /// The list of organizations that have authorized/trusted your organization.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <returns>Task of ApiResponse (TrustorEntityListing)</returns>

    Task<ApiResponse<TrustorEntityListing>> GetOrgauthorizationTrustorsAsyncWithHttpInfo(int? pageSize = null, int? pageNumber = null);

    /// <summary>
    /// A pairing id is created by the trustee and given to the trustor to create a trust.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Pairing Info</param>
    /// <returns>Task of TrustRequest</returns>

    Task<TrustRequest> PostOrgauthorizationPairingsAsync(TrustRequestCreate body);

    /// <summary>
    /// A pairing id is created by the trustee and given to the trustor to create a trust.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Pairing Info</param>
    /// <returns>Task of ApiResponse (TrustRequest)</returns>

    Task<ApiResponse<TrustRequest>> PostOrgauthorizationPairingsAsyncWithHttpInfo(TrustRequestCreate body);

    /// <summary>
    /// Add a group to the trust.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="body">Trust</param>
    /// <returns>Task of TrustGroup</returns>

    Task<TrustGroup> PostOrgauthorizationTrusteeGroupsAsync(string trusteeOrgId, TrustMemberCreate body);

    /// <summary>
    /// Add a group to the trust.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="body">Trust</param>
    /// <returns>Task of ApiResponse (TrustGroup)</returns>

    Task<ApiResponse<TrustGroup>> PostOrgauthorizationTrusteeGroupsAsyncWithHttpInfo(string trusteeOrgId, TrustMemberCreate body);

    /// <summary>
    /// Add a user to the trust.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="body">Trust</param>
    /// <returns>Task of TrustUser</returns>

    Task<TrustUser> PostOrgauthorizationTrusteeUsersAsync(string trusteeOrgId, TrustMemberCreate body);

    /// <summary>
    /// Add a user to the trust.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="body">Trust</param>
    /// <returns>Task of ApiResponse (TrustUser)</returns>

    Task<ApiResponse<TrustUser>> PostOrgauthorizationTrusteeUsersAsyncWithHttpInfo(string trusteeOrgId, TrustMemberCreate body);

    /// <summary>
    /// Create a new organization authorization trust. This is required to grant other organizations access to your organization.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Trust</param>
    /// <returns>Task of Trustee</returns>

    Task<Trustee> PostOrgauthorizationTrusteesAsync(TrustCreate body);

    /// <summary>
    /// Create a new organization authorization trust. This is required to grant other organizations access to your organization.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Trust</param>
    /// <returns>Task of ApiResponse (Trustee)</returns>

    Task<ApiResponse<Trustee>> PostOrgauthorizationTrusteesAsyncWithHttpInfo(TrustCreate body);

    /// <summary>
    /// Get Org Trustee Audits
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Values to scope the request.</param>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <param name="sortBy">Sort by (optional, default to "timestamp")</param>
    /// <param name="sortOrder">Sort order (optional, default to "descending")</param>
    /// <returns>Task of Object</returns>

    Task<object> PostOrgauthorizationTrusteesAuditsAsync(TrusteeAuditQueryRequest body, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null);

    /// <summary>
    /// Get Org Trustee Audits
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Values to scope the request.</param>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <param name="sortBy">Sort by (optional, default to "timestamp")</param>
    /// <param name="sortOrder">Sort order (optional, default to "descending")</param>
    /// <returns>Task of ApiResponse (Object)</returns>

    Task<ApiResponse<object>> PostOrgauthorizationTrusteesAuditsAsyncWithHttpInfo(TrusteeAuditQueryRequest body, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null);

    /// <summary>
    /// Create a new organization authorization trust with Customer Care. This is required to grant your regional Customer Care organization access to your organization.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="assignDefaultRole">Assign Admin role to default pairing with Customer Care (optional)</param>
    /// <param name="autoExpire">Automatically expire pairing after 30 days (optional)</param>
    /// <param name="assignFullAccess">Grant Customer Care full access to the organization (optional)</param>
    /// <param name="allowTrustedUserAccess">Make Customer Care a Trusted User (optional)</param>
    /// <returns>Task of TrustEntityListing</returns>

    Task<TrustEntityListing> PostOrgauthorizationTrusteesCareAsync(bool? assignDefaultRole = null, bool? autoExpire = null, bool? assignFullAccess = null, bool? allowTrustedUserAccess = null);

    /// <summary>
    /// Create a new organization authorization trust with Customer Care. This is required to grant your regional Customer Care organization access to your organization.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="assignDefaultRole">Assign Admin role to default pairing with Customer Care (optional)</param>
    /// <param name="autoExpire">Automatically expire pairing after 30 days (optional)</param>
    /// <param name="assignFullAccess">Grant Customer Care full access to the organization (optional)</param>
    /// <param name="allowTrustedUserAccess">Make Customer Care a Trusted User (optional)</param>
    /// <returns>Task of ApiResponse (TrustEntityListing)</returns>

    Task<ApiResponse<TrustEntityListing>> PostOrgauthorizationTrusteesCareAsyncWithHttpInfo(bool? assignDefaultRole = null, bool? autoExpire = null, bool? assignFullAccess = null, bool? allowTrustedUserAccess = null);

    /// <summary>
    /// Create a new organization authorization trust with Customer Care. This is required to grant your regional Customer Care organization access to your organization.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="assignDefaultRole">Assign Admin role to default pairing with Customer Care (optional)</param>
    /// <param name="autoExpire">Automatically expire pairing after 30 days (optional)</param>
    /// <returns>Task of Trustee</returns>

    Task<Trustee> PostOrgauthorizationTrusteesDefaultAsync(bool? assignDefaultRole = null, bool? autoExpire = null);

    /// <summary>
    /// Create a new organization authorization trust with Customer Care. This is required to grant your regional Customer Care organization access to your organization.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="assignDefaultRole">Assign Admin role to default pairing with Customer Care (optional)</param>
    /// <param name="autoExpire">Automatically expire pairing after 30 days (optional)</param>
    /// <returns>Task of ApiResponse (Trustee)</returns>

    Task<ApiResponse<Trustee>> PostOrgauthorizationTrusteesDefaultAsyncWithHttpInfo(bool? assignDefaultRole = null, bool? autoExpire = null);

    /// <summary>
    /// Get Org Trustor Audits
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Values to scope the request.</param>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <param name="sortBy">Sort by (optional, default to "timestamp")</param>
    /// <param name="sortOrder">Sort order (optional, default to "descending")</param>
    /// <returns>Task of Object</returns>

    Task<object> PostOrgauthorizationTrustorAuditsAsync(TrustorAuditQueryRequest body, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null);

    /// <summary>
    /// Get Org Trustor Audits
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Values to scope the request.</param>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <param name="sortBy">Sort by (optional, default to "timestamp")</param>
    /// <param name="sortOrder">Sort order (optional, default to "descending")</param>
    /// <returns>Task of ApiResponse (Object)</returns>

    Task<ApiResponse<object>> PostOrgauthorizationTrustorAuditsAsyncWithHttpInfo(TrustorAuditQueryRequest body, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null);

    /// <summary>
    /// Update Org Trust
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="body">Client</param>
    /// <returns>Task of Trustee</returns>

    Task<Trustee> PutOrgauthorizationTrusteeAsync(string trusteeOrgId, TrustUpdate body);

    /// <summary>
    /// Update Org Trust
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="body">Client</param>
    /// <returns>Task of ApiResponse (Trustee)</returns>

    Task<ApiResponse<Trustee>> PutOrgauthorizationTrusteeAsyncWithHttpInfo(string trusteeOrgId, TrustUpdate body);

    /// <summary>
    /// Update Trustee Group Roles
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="trusteeGroupId">Trustee Group Id</param>
    /// <param name="body">Set of roles with corresponding divisions to apply</param>
    /// <returns>Task of UserAuthorization</returns>

    Task<UserAuthorization> PutOrgauthorizationTrusteeGroupRoledivisionsAsync(string trusteeOrgId, string trusteeGroupId, RoleDivisionGrants body);

    /// <summary>
    /// Update Trustee Group Roles
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="trusteeGroupId">Trustee Group Id</param>
    /// <param name="body">Set of roles with corresponding divisions to apply</param>
    /// <returns>Task of ApiResponse (UserAuthorization)</returns>

    Task<ApiResponse<UserAuthorization>> PutOrgauthorizationTrusteeGroupRoledivisionsAsyncWithHttpInfo(string trusteeOrgId, string trusteeGroupId, RoleDivisionGrants body);

    /// <summary>
    /// Update Trustee Group Roles
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="trusteeGroupId">Trustee Group Id</param>
    /// <param name="body">List of roles</param>
    /// <returns>Task of UserAuthorization</returns>

    Task<UserAuthorization> PutOrgauthorizationTrusteeGroupRolesAsync(string trusteeOrgId, string trusteeGroupId, List<string> body);

    /// <summary>
    /// Update Trustee Group Roles
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="trusteeGroupId">Trustee Group Id</param>
    /// <param name="body">List of roles</param>
    /// <returns>Task of ApiResponse (UserAuthorization)</returns>

    Task<ApiResponse<UserAuthorization>> PutOrgauthorizationTrusteeGroupRolesAsyncWithHttpInfo(string trusteeOrgId, string trusteeGroupId, List<string> body);

    /// <summary>
    /// Update Trustee User Roles
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="trusteeUserId">Trustee User Id</param>
    /// <param name="body">Set of roles with corresponding divisions to apply</param>
    /// <returns>Task of UserAuthorization</returns>

    Task<UserAuthorization> PutOrgauthorizationTrusteeUserRoledivisionsAsync(string trusteeOrgId, string trusteeUserId, RoleDivisionGrants body);

    /// <summary>
    /// Update Trustee User Roles
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="trusteeUserId">Trustee User Id</param>
    /// <param name="body">Set of roles with corresponding divisions to apply</param>
    /// <returns>Task of ApiResponse (UserAuthorization)</returns>

    Task<ApiResponse<UserAuthorization>> PutOrgauthorizationTrusteeUserRoledivisionsAsyncWithHttpInfo(string trusteeOrgId, string trusteeUserId, RoleDivisionGrants body);

    /// <summary>
    /// Update Trustee User Roles
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="trusteeUserId">Trustee User Id</param>
    /// <param name="body">List of roles</param>
    /// <returns>Task of UserAuthorization</returns>

    Task<UserAuthorization> PutOrgauthorizationTrusteeUserRolesAsync(string trusteeOrgId, string trusteeUserId, List<string> body);

    /// <summary>
    /// Update Trustee User Roles
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="trusteeUserId">Trustee User Id</param>
    /// <param name="body">List of roles</param>
    /// <returns>Task of ApiResponse (UserAuthorization)</returns>

    Task<ApiResponse<UserAuthorization>> PutOrgauthorizationTrusteeUserRolesAsyncWithHttpInfo(string trusteeOrgId, string trusteeUserId, List<string> body);

    /// <summary>
    /// Creates a clone of the trustee user in the trustor org.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trustorOrgId">Trustor Organization Id</param>
    /// <param name="trusteeUserId">Trustee User Id</param>
    /// <returns>Task of ClonedUser</returns>

    Task<ClonedUser> PutOrgauthorizationTrustorCloneduserAsync(string trustorOrgId, string trusteeUserId);

    /// <summary>
    /// Creates a clone of the trustee user in the trustor org.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trustorOrgId">Trustor Organization Id</param>
    /// <param name="trusteeUserId">Trustee User Id</param>
    /// <returns>Task of ApiResponse (ClonedUser)</returns>

    Task<ApiResponse<ClonedUser>> PutOrgauthorizationTrustorCloneduserAsyncWithHttpInfo(string trustorOrgId, string trusteeUserId);

    /// <summary>
    /// Add a Trustee Group to the trust.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trustorOrgId">Trustor Organization Id</param>
    /// <param name="trustorGroupId">Trustor Group Id</param>
    /// <returns>Task of TrustGroup</returns>

    Task<TrustGroup> PutOrgauthorizationTrustorGroupAsync(string trustorOrgId, string trustorGroupId);

    /// <summary>
    /// Add a Trustee Group to the trust.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trustorOrgId">Trustor Organization Id</param>
    /// <param name="trustorGroupId">Trustor Group Id</param>
    /// <returns>Task of ApiResponse (TrustGroup)</returns>

    Task<ApiResponse<TrustGroup>> PutOrgauthorizationTrustorGroupAsyncWithHttpInfo(string trustorOrgId, string trustorGroupId);

    /// <summary>
    /// Add a Trustee user to the trust.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trustorOrgId">Trustor Organization Id</param>
    /// <param name="trusteeUserId">Trustee User Id</param>
    /// <returns>Task of TrustUser</returns>

    Task<TrustUser> PutOrgauthorizationTrustorUserAsync(string trustorOrgId, string trusteeUserId);

    /// <summary>
    /// Add a Trustee user to the trust.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trustorOrgId">Trustor Organization Id</param>
    /// <param name="trusteeUserId">Trustee User Id</param>
    /// <returns>Task of ApiResponse (TrustUser)</returns>

    Task<ApiResponse<TrustUser>> PutOrgauthorizationTrustorUserAsyncWithHttpInfo(string trustorOrgId, string trusteeUserId);

    #endregion Asynchronous Operations

}

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public partial class OrganizationAuthorizationApi : IOrganizationAuthorizationApi
{
    /// <summary>
    /// Initializes a new instance of the <see cref="OrganizationAuthorizationApi"/> class.
    /// </summary>
    /// <returns></returns>
    public OrganizationAuthorizationApi(string basePath)
    {
        Configuration = new Configuration(new ApiClient(basePath));

        // ensure API client has configuration ready
        if (Configuration.ApiClient.Configuration == null)
        {
            Configuration.ApiClient.Configuration = Configuration;
        }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="OrganizationAuthorizationApi"/> class
    /// using Configuration object
    /// </summary>
    /// <param name="configuration">An instance of Configuration</param>
    /// <returns></returns>
    public OrganizationAuthorizationApi(Configuration configuration = null)
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
    /// Delete Org Trust 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <returns></returns>

    public void DeleteOrgauthorizationTrustee(string trusteeOrgId)
    {
        DeleteOrgauthorizationTrusteeWithHttpInfo(trusteeOrgId);
    }

    /// <summary>
    /// Delete Org Trust 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <returns>ApiResponse of Object(void)</returns>

    public ApiResponse<object> DeleteOrgauthorizationTrusteeWithHttpInfo(string trusteeOrgId)
    {
        // verify the required parameter 'trusteeOrgId' is set
        if (trusteeOrgId == null)
        {
            throw new ApiException(400, "Missing required parameter 'trusteeOrgId' when calling OrganizationAuthorizationApi->DeleteOrgauthorizationTrustee");
        }

        var localVarPath = "/api/v2/orgauthorization/trustees/{trusteeOrgId}";
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
        if (trusteeOrgId != null)
        {
            localVarPathParams.Add("trusteeOrgId", Configuration.ApiClient.ParameterToString(trusteeOrgId));
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
            throw new ApiException(localVarStatusCode, "Error calling DeleteOrgauthorizationTrustee: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling DeleteOrgauthorizationTrustee: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<object>(localVarStatusCode,
            localVarHeaders,
            null,
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Delete Org Trust 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <returns>Task of void</returns>

    public async Task DeleteOrgauthorizationTrusteeAsync(string trusteeOrgId)
    {
        await DeleteOrgauthorizationTrusteeAsyncWithHttpInfo(trusteeOrgId);

    }

    /// <summary>
    /// Delete Org Trust 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <returns>Task of ApiResponse</returns>

    public async Task<ApiResponse<object>> DeleteOrgauthorizationTrusteeAsyncWithHttpInfo(string trusteeOrgId)
    {
        // verify the required parameter 'trusteeOrgId' is set
        if (trusteeOrgId == null)
        {
            throw new ApiException(400, "Missing required parameter 'trusteeOrgId' when calling OrganizationAuthorizationApi->DeleteOrgauthorizationTrustee");
        }

        var localVarPath = "/api/v2/orgauthorization/trustees/{trusteeOrgId}";
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
        if (trusteeOrgId != null)
        {
            localVarPathParams.Add("trusteeOrgId", Configuration.ApiClient.ParameterToString(trusteeOrgId));
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
            throw new ApiException(localVarStatusCode, "Error calling DeleteOrgauthorizationTrustee: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling DeleteOrgauthorizationTrustee: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<object>(localVarStatusCode,
            localVarHeaders,
            null,
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Deletes cloned user 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="trusteeUserId">Id of the cloned user to delete</param>
    /// <returns></returns>

    public void DeleteOrgauthorizationTrusteeCloneduser(string trusteeOrgId, string trusteeUserId)
    {
        DeleteOrgauthorizationTrusteeCloneduserWithHttpInfo(trusteeOrgId, trusteeUserId);
    }

    /// <summary>
    /// Deletes cloned user 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="trusteeUserId">Id of the cloned user to delete</param>
    /// <returns>ApiResponse of Object(void)</returns>

    public ApiResponse<object> DeleteOrgauthorizationTrusteeCloneduserWithHttpInfo(string trusteeOrgId, string trusteeUserId)
    {
        // verify the required parameter 'trusteeOrgId' is set
        if (trusteeOrgId == null)
        {
            throw new ApiException(400, "Missing required parameter 'trusteeOrgId' when calling OrganizationAuthorizationApi->DeleteOrgauthorizationTrusteeCloneduser");
        }
        // verify the required parameter 'trusteeUserId' is set
        if (trusteeUserId == null)
        {
            throw new ApiException(400, "Missing required parameter 'trusteeUserId' when calling OrganizationAuthorizationApi->DeleteOrgauthorizationTrusteeCloneduser");
        }

        var localVarPath = "/api/v2/orgauthorization/trustees/{trusteeOrgId}/clonedusers/{trusteeUserId}";
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
        if (trusteeOrgId != null)
        {
            localVarPathParams.Add("trusteeOrgId", Configuration.ApiClient.ParameterToString(trusteeOrgId));
        }

        if (trusteeUserId != null)
        {
            localVarPathParams.Add("trusteeUserId", Configuration.ApiClient.ParameterToString(trusteeUserId));
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
            throw new ApiException(localVarStatusCode, "Error calling DeleteOrgauthorizationTrusteeCloneduser: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling DeleteOrgauthorizationTrusteeCloneduser: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<object>(localVarStatusCode,
            localVarHeaders,
            null,
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Deletes cloned user 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="trusteeUserId">Id of the cloned user to delete</param>
    /// <returns>Task of void</returns>

    public async Task DeleteOrgauthorizationTrusteeCloneduserAsync(string trusteeOrgId, string trusteeUserId)
    {
        await DeleteOrgauthorizationTrusteeCloneduserAsyncWithHttpInfo(trusteeOrgId, trusteeUserId);

    }

    /// <summary>
    /// Deletes cloned user 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="trusteeUserId">Id of the cloned user to delete</param>
    /// <returns>Task of ApiResponse</returns>

    public async Task<ApiResponse<object>> DeleteOrgauthorizationTrusteeCloneduserAsyncWithHttpInfo(string trusteeOrgId, string trusteeUserId)
    {
        // verify the required parameter 'trusteeOrgId' is set
        if (trusteeOrgId == null)
        {
            throw new ApiException(400, "Missing required parameter 'trusteeOrgId' when calling OrganizationAuthorizationApi->DeleteOrgauthorizationTrusteeCloneduser");
        }

        // verify the required parameter 'trusteeUserId' is set
        if (trusteeUserId == null)
        {
            throw new ApiException(400, "Missing required parameter 'trusteeUserId' when calling OrganizationAuthorizationApi->DeleteOrgauthorizationTrusteeCloneduser");
        }

        var localVarPath = "/api/v2/orgauthorization/trustees/{trusteeOrgId}/clonedusers/{trusteeUserId}";
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
        if (trusteeOrgId != null)
        {
            localVarPathParams.Add("trusteeOrgId", Configuration.ApiClient.ParameterToString(trusteeOrgId));
        }

        if (trusteeUserId != null)
        {
            localVarPathParams.Add("trusteeUserId", Configuration.ApiClient.ParameterToString(trusteeUserId));
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
            throw new ApiException(localVarStatusCode, "Error calling DeleteOrgauthorizationTrusteeCloneduser: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling DeleteOrgauthorizationTrusteeCloneduser: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<object>(localVarStatusCode,
            localVarHeaders,
            null,
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Delete Trustee Group 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="trusteeGroupId">Trustee Group Id</param>
    /// <returns></returns>

    public void DeleteOrgauthorizationTrusteeGroup(string trusteeOrgId, string trusteeGroupId)
    {
        DeleteOrgauthorizationTrusteeGroupWithHttpInfo(trusteeOrgId, trusteeGroupId);
    }

    /// <summary>
    /// Delete Trustee Group 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="trusteeGroupId">Trustee Group Id</param>
    /// <returns>ApiResponse of Object(void)</returns>

    public ApiResponse<object> DeleteOrgauthorizationTrusteeGroupWithHttpInfo(string trusteeOrgId, string trusteeGroupId)
    {
        // verify the required parameter 'trusteeOrgId' is set
        if (trusteeOrgId == null)
        {
            throw new ApiException(400, "Missing required parameter 'trusteeOrgId' when calling OrganizationAuthorizationApi->DeleteOrgauthorizationTrusteeGroup");
        }
        // verify the required parameter 'trusteeGroupId' is set
        if (trusteeGroupId == null)
        {
            throw new ApiException(400, "Missing required parameter 'trusteeGroupId' when calling OrganizationAuthorizationApi->DeleteOrgauthorizationTrusteeGroup");
        }

        var localVarPath = "/api/v2/orgauthorization/trustees/{trusteeOrgId}/groups/{trusteeGroupId}";
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
        if (trusteeOrgId != null)
        {
            localVarPathParams.Add("trusteeOrgId", Configuration.ApiClient.ParameterToString(trusteeOrgId));
        }

        if (trusteeGroupId != null)
        {
            localVarPathParams.Add("trusteeGroupId", Configuration.ApiClient.ParameterToString(trusteeGroupId));
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
            throw new ApiException(localVarStatusCode, "Error calling DeleteOrgauthorizationTrusteeGroup: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling DeleteOrgauthorizationTrusteeGroup: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<object>(localVarStatusCode,
            localVarHeaders,
            null,
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Delete Trustee Group 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="trusteeGroupId">Trustee Group Id</param>
    /// <returns>Task of void</returns>

    public async Task DeleteOrgauthorizationTrusteeGroupAsync(string trusteeOrgId, string trusteeGroupId)
    {
        await DeleteOrgauthorizationTrusteeGroupAsyncWithHttpInfo(trusteeOrgId, trusteeGroupId);

    }

    /// <summary>
    /// Delete Trustee Group 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="trusteeGroupId">Trustee Group Id</param>
    /// <returns>Task of ApiResponse</returns>

    public async Task<ApiResponse<object>> DeleteOrgauthorizationTrusteeGroupAsyncWithHttpInfo(string trusteeOrgId, string trusteeGroupId)
    {
        // verify the required parameter 'trusteeOrgId' is set
        if (trusteeOrgId == null)
        {
            throw new ApiException(400, "Missing required parameter 'trusteeOrgId' when calling OrganizationAuthorizationApi->DeleteOrgauthorizationTrusteeGroup");
        }

        // verify the required parameter 'trusteeGroupId' is set
        if (trusteeGroupId == null)
        {
            throw new ApiException(400, "Missing required parameter 'trusteeGroupId' when calling OrganizationAuthorizationApi->DeleteOrgauthorizationTrusteeGroup");
        }

        var localVarPath = "/api/v2/orgauthorization/trustees/{trusteeOrgId}/groups/{trusteeGroupId}";
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
        if (trusteeOrgId != null)
        {
            localVarPathParams.Add("trusteeOrgId", Configuration.ApiClient.ParameterToString(trusteeOrgId));
        }

        if (trusteeGroupId != null)
        {
            localVarPathParams.Add("trusteeGroupId", Configuration.ApiClient.ParameterToString(trusteeGroupId));
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
            throw new ApiException(localVarStatusCode, "Error calling DeleteOrgauthorizationTrusteeGroup: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling DeleteOrgauthorizationTrusteeGroup: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<object>(localVarStatusCode,
            localVarHeaders,
            null,
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Delete Trustee Group Roles 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="trusteeGroupId">Trustee Group Id</param>
    /// <returns></returns>

    public void DeleteOrgauthorizationTrusteeGroupRoles(string trusteeOrgId, string trusteeGroupId)
    {
        DeleteOrgauthorizationTrusteeGroupRolesWithHttpInfo(trusteeOrgId, trusteeGroupId);
    }

    /// <summary>
    /// Delete Trustee Group Roles 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="trusteeGroupId">Trustee Group Id</param>
    /// <returns>ApiResponse of Object(void)</returns>

    public ApiResponse<object> DeleteOrgauthorizationTrusteeGroupRolesWithHttpInfo(string trusteeOrgId, string trusteeGroupId)
    {
        // verify the required parameter 'trusteeOrgId' is set
        if (trusteeOrgId == null)
        {
            throw new ApiException(400, "Missing required parameter 'trusteeOrgId' when calling OrganizationAuthorizationApi->DeleteOrgauthorizationTrusteeGroupRoles");
        }
        // verify the required parameter 'trusteeGroupId' is set
        if (trusteeGroupId == null)
        {
            throw new ApiException(400, "Missing required parameter 'trusteeGroupId' when calling OrganizationAuthorizationApi->DeleteOrgauthorizationTrusteeGroupRoles");
        }

        var localVarPath = "/api/v2/orgauthorization/trustees/{trusteeOrgId}/groups/{trusteeGroupId}/roles";
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
        if (trusteeOrgId != null)
        {
            localVarPathParams.Add("trusteeOrgId", Configuration.ApiClient.ParameterToString(trusteeOrgId));
        }

        if (trusteeGroupId != null)
        {
            localVarPathParams.Add("trusteeGroupId", Configuration.ApiClient.ParameterToString(trusteeGroupId));
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
            throw new ApiException(localVarStatusCode, "Error calling DeleteOrgauthorizationTrusteeGroupRoles: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling DeleteOrgauthorizationTrusteeGroupRoles: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<object>(localVarStatusCode,
            localVarHeaders,
            null,
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Delete Trustee Group Roles 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="trusteeGroupId">Trustee Group Id</param>
    /// <returns>Task of void</returns>

    public async Task DeleteOrgauthorizationTrusteeGroupRolesAsync(string trusteeOrgId, string trusteeGroupId)
    {
        await DeleteOrgauthorizationTrusteeGroupRolesAsyncWithHttpInfo(trusteeOrgId, trusteeGroupId);

    }

    /// <summary>
    /// Delete Trustee Group Roles 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="trusteeGroupId">Trustee Group Id</param>
    /// <returns>Task of ApiResponse</returns>

    public async Task<ApiResponse<object>> DeleteOrgauthorizationTrusteeGroupRolesAsyncWithHttpInfo(string trusteeOrgId, string trusteeGroupId)
    {
        // verify the required parameter 'trusteeOrgId' is set
        if (trusteeOrgId == null)
        {
            throw new ApiException(400, "Missing required parameter 'trusteeOrgId' when calling OrganizationAuthorizationApi->DeleteOrgauthorizationTrusteeGroupRoles");
        }

        // verify the required parameter 'trusteeGroupId' is set
        if (trusteeGroupId == null)
        {
            throw new ApiException(400, "Missing required parameter 'trusteeGroupId' when calling OrganizationAuthorizationApi->DeleteOrgauthorizationTrusteeGroupRoles");
        }

        var localVarPath = "/api/v2/orgauthorization/trustees/{trusteeOrgId}/groups/{trusteeGroupId}/roles";
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
        if (trusteeOrgId != null)
        {
            localVarPathParams.Add("trusteeOrgId", Configuration.ApiClient.ParameterToString(trusteeOrgId));
        }

        if (trusteeGroupId != null)
        {
            localVarPathParams.Add("trusteeGroupId", Configuration.ApiClient.ParameterToString(trusteeGroupId));
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
            throw new ApiException(localVarStatusCode, "Error calling DeleteOrgauthorizationTrusteeGroupRoles: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling DeleteOrgauthorizationTrusteeGroupRoles: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<object>(localVarStatusCode,
            localVarHeaders,
            null,
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Delete Trustee User 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="trusteeUserId">Trustee User Id</param>
    /// <returns></returns>

    public void DeleteOrgauthorizationTrusteeUser(string trusteeOrgId, string trusteeUserId)
    {
        DeleteOrgauthorizationTrusteeUserWithHttpInfo(trusteeOrgId, trusteeUserId);
    }

    /// <summary>
    /// Delete Trustee User 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="trusteeUserId">Trustee User Id</param>
    /// <returns>ApiResponse of Object(void)</returns>

    public ApiResponse<object> DeleteOrgauthorizationTrusteeUserWithHttpInfo(string trusteeOrgId, string trusteeUserId)
    {
        // verify the required parameter 'trusteeOrgId' is set
        if (trusteeOrgId == null)
        {
            throw new ApiException(400, "Missing required parameter 'trusteeOrgId' when calling OrganizationAuthorizationApi->DeleteOrgauthorizationTrusteeUser");
        }
        // verify the required parameter 'trusteeUserId' is set
        if (trusteeUserId == null)
        {
            throw new ApiException(400, "Missing required parameter 'trusteeUserId' when calling OrganizationAuthorizationApi->DeleteOrgauthorizationTrusteeUser");
        }

        var localVarPath = "/api/v2/orgauthorization/trustees/{trusteeOrgId}/users/{trusteeUserId}";
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
        if (trusteeOrgId != null)
        {
            localVarPathParams.Add("trusteeOrgId", Configuration.ApiClient.ParameterToString(trusteeOrgId));
        }

        if (trusteeUserId != null)
        {
            localVarPathParams.Add("trusteeUserId", Configuration.ApiClient.ParameterToString(trusteeUserId));
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
            throw new ApiException(localVarStatusCode, "Error calling DeleteOrgauthorizationTrusteeUser: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling DeleteOrgauthorizationTrusteeUser: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<object>(localVarStatusCode,
            localVarHeaders,
            null,
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Delete Trustee User 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="trusteeUserId">Trustee User Id</param>
    /// <returns>Task of void</returns>

    public async Task DeleteOrgauthorizationTrusteeUserAsync(string trusteeOrgId, string trusteeUserId)
    {
        await DeleteOrgauthorizationTrusteeUserAsyncWithHttpInfo(trusteeOrgId, trusteeUserId);

    }

    /// <summary>
    /// Delete Trustee User 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="trusteeUserId">Trustee User Id</param>
    /// <returns>Task of ApiResponse</returns>

    public async Task<ApiResponse<object>> DeleteOrgauthorizationTrusteeUserAsyncWithHttpInfo(string trusteeOrgId, string trusteeUserId)
    {
        // verify the required parameter 'trusteeOrgId' is set
        if (trusteeOrgId == null)
        {
            throw new ApiException(400, "Missing required parameter 'trusteeOrgId' when calling OrganizationAuthorizationApi->DeleteOrgauthorizationTrusteeUser");
        }

        // verify the required parameter 'trusteeUserId' is set
        if (trusteeUserId == null)
        {
            throw new ApiException(400, "Missing required parameter 'trusteeUserId' when calling OrganizationAuthorizationApi->DeleteOrgauthorizationTrusteeUser");
        }

        var localVarPath = "/api/v2/orgauthorization/trustees/{trusteeOrgId}/users/{trusteeUserId}";
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
        if (trusteeOrgId != null)
        {
            localVarPathParams.Add("trusteeOrgId", Configuration.ApiClient.ParameterToString(trusteeOrgId));
        }

        if (trusteeUserId != null)
        {
            localVarPathParams.Add("trusteeUserId", Configuration.ApiClient.ParameterToString(trusteeUserId));
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
            throw new ApiException(localVarStatusCode, "Error calling DeleteOrgauthorizationTrusteeUser: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling DeleteOrgauthorizationTrusteeUser: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<object>(localVarStatusCode,
            localVarHeaders,
            null,
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Delete Trustee User Roles 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="trusteeUserId">Trustee User Id</param>
    /// <returns></returns>

    public void DeleteOrgauthorizationTrusteeUserRoles(string trusteeOrgId, string trusteeUserId)
    {
        DeleteOrgauthorizationTrusteeUserRolesWithHttpInfo(trusteeOrgId, trusteeUserId);
    }

    /// <summary>
    /// Delete Trustee User Roles 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="trusteeUserId">Trustee User Id</param>
    /// <returns>ApiResponse of Object(void)</returns>

    public ApiResponse<object> DeleteOrgauthorizationTrusteeUserRolesWithHttpInfo(string trusteeOrgId, string trusteeUserId)
    {
        // verify the required parameter 'trusteeOrgId' is set
        if (trusteeOrgId == null)
        {
            throw new ApiException(400, "Missing required parameter 'trusteeOrgId' when calling OrganizationAuthorizationApi->DeleteOrgauthorizationTrusteeUserRoles");
        }
        // verify the required parameter 'trusteeUserId' is set
        if (trusteeUserId == null)
        {
            throw new ApiException(400, "Missing required parameter 'trusteeUserId' when calling OrganizationAuthorizationApi->DeleteOrgauthorizationTrusteeUserRoles");
        }

        var localVarPath = "/api/v2/orgauthorization/trustees/{trusteeOrgId}/users/{trusteeUserId}/roles";
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
        if (trusteeOrgId != null)
        {
            localVarPathParams.Add("trusteeOrgId", Configuration.ApiClient.ParameterToString(trusteeOrgId));
        }

        if (trusteeUserId != null)
        {
            localVarPathParams.Add("trusteeUserId", Configuration.ApiClient.ParameterToString(trusteeUserId));
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
            throw new ApiException(localVarStatusCode, "Error calling DeleteOrgauthorizationTrusteeUserRoles: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling DeleteOrgauthorizationTrusteeUserRoles: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<object>(localVarStatusCode,
            localVarHeaders,
            null,
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Delete Trustee User Roles 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="trusteeUserId">Trustee User Id</param>
    /// <returns>Task of void</returns>

    public async Task DeleteOrgauthorizationTrusteeUserRolesAsync(string trusteeOrgId, string trusteeUserId)
    {
        await DeleteOrgauthorizationTrusteeUserRolesAsyncWithHttpInfo(trusteeOrgId, trusteeUserId);

    }

    /// <summary>
    /// Delete Trustee User Roles 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="trusteeUserId">Trustee User Id</param>
    /// <returns>Task of ApiResponse</returns>

    public async Task<ApiResponse<object>> DeleteOrgauthorizationTrusteeUserRolesAsyncWithHttpInfo(string trusteeOrgId, string trusteeUserId)
    {
        // verify the required parameter 'trusteeOrgId' is set
        if (trusteeOrgId == null)
        {
            throw new ApiException(400, "Missing required parameter 'trusteeOrgId' when calling OrganizationAuthorizationApi->DeleteOrgauthorizationTrusteeUserRoles");
        }

        // verify the required parameter 'trusteeUserId' is set
        if (trusteeUserId == null)
        {
            throw new ApiException(400, "Missing required parameter 'trusteeUserId' when calling OrganizationAuthorizationApi->DeleteOrgauthorizationTrusteeUserRoles");
        }

        var localVarPath = "/api/v2/orgauthorization/trustees/{trusteeOrgId}/users/{trusteeUserId}/roles";
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
        if (trusteeOrgId != null)
        {
            localVarPathParams.Add("trusteeOrgId", Configuration.ApiClient.ParameterToString(trusteeOrgId));
        }

        if (trusteeUserId != null)
        {
            localVarPathParams.Add("trusteeUserId", Configuration.ApiClient.ParameterToString(trusteeUserId));
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
            throw new ApiException(localVarStatusCode, "Error calling DeleteOrgauthorizationTrusteeUserRoles: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling DeleteOrgauthorizationTrusteeUserRoles: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<object>(localVarStatusCode,
            localVarHeaders,
            null,
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Delete Bulk Org Trustees 
    /// 
    /// DeleteOrgauthorizationTrustees is a preview method and is subject to both breaking and non-breaking changes at any time without notice
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="id">Comma separated list of trustee ids to remove</param>
    /// <returns></returns>

    public void DeleteOrgauthorizationTrustees(List<string> id)
    {
        DeleteOrgauthorizationTrusteesWithHttpInfo(id);
    }

    /// <summary>
    /// Delete Bulk Org Trustees 
    /// 
    /// DeleteOrgauthorizationTrustees is a preview method and is subject to both breaking and non-breaking changes at any time without notice
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="id">Comma separated list of trustee ids to remove</param>
    /// <returns>ApiResponse of Object(void)</returns>

    public ApiResponse<object> DeleteOrgauthorizationTrusteesWithHttpInfo(List<string> id)
    {
        // verify the required parameter 'id' is set
        if (id == null)
        {
            throw new ApiException(400, "Missing required parameter 'id' when calling OrganizationAuthorizationApi->DeleteOrgauthorizationTrustees");
        }

        var localVarPath = "/api/v2/orgauthorization/trustees";
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
        if (id != null)
        {
            id.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("id", Configuration.ApiClient.ParameterToString(obj))); });
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
            throw new ApiException(localVarStatusCode, "Error calling DeleteOrgauthorizationTrustees: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling DeleteOrgauthorizationTrustees: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<object>(localVarStatusCode,
            localVarHeaders,
            null,
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Delete Bulk Org Trustees 
    /// 
    /// DeleteOrgauthorizationTrustees is a preview method and is subject to both breaking and non-breaking changes at any time without notice
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="id">Comma separated list of trustee ids to remove</param>
    /// <returns>Task of void</returns>

    public async Task DeleteOrgauthorizationTrusteesAsync(List<string> id)
    {
        await DeleteOrgauthorizationTrusteesAsyncWithHttpInfo(id);

    }

    /// <summary>
    /// Delete Bulk Org Trustees 
    /// 
    /// DeleteOrgauthorizationTrustees is a preview method and is subject to both breaking and non-breaking changes at any time without notice
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="id">Comma separated list of trustee ids to remove</param>
    /// <returns>Task of ApiResponse</returns>

    public async Task<ApiResponse<object>> DeleteOrgauthorizationTrusteesAsyncWithHttpInfo(List<string> id)
    {
        // verify the required parameter 'id' is set
        if (id == null)
        {
            throw new ApiException(400, "Missing required parameter 'id' when calling OrganizationAuthorizationApi->DeleteOrgauthorizationTrustees");
        }

        var localVarPath = "/api/v2/orgauthorization/trustees";
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
        if (id != null)
        {
            id.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("id", Configuration.ApiClient.ParameterToString(obj))); });
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
            throw new ApiException(localVarStatusCode, "Error calling DeleteOrgauthorizationTrustees: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling DeleteOrgauthorizationTrustees: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<object>(localVarStatusCode,
            localVarHeaders,
            null,
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Delete Org Trust 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trustorOrgId">Trustor Organization Id</param>
    /// <returns></returns>

    public void DeleteOrgauthorizationTrustor(string trustorOrgId)
    {
        DeleteOrgauthorizationTrustorWithHttpInfo(trustorOrgId);
    }

    /// <summary>
    /// Delete Org Trust 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trustorOrgId">Trustor Organization Id</param>
    /// <returns>ApiResponse of Object(void)</returns>

    public ApiResponse<object> DeleteOrgauthorizationTrustorWithHttpInfo(string trustorOrgId)
    {
        // verify the required parameter 'trustorOrgId' is set
        if (trustorOrgId == null)
        {
            throw new ApiException(400, "Missing required parameter 'trustorOrgId' when calling OrganizationAuthorizationApi->DeleteOrgauthorizationTrustor");
        }

        var localVarPath = "/api/v2/orgauthorization/trustors/{trustorOrgId}";
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
        if (trustorOrgId != null)
        {
            localVarPathParams.Add("trustorOrgId", Configuration.ApiClient.ParameterToString(trustorOrgId));
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
            throw new ApiException(localVarStatusCode, "Error calling DeleteOrgauthorizationTrustor: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling DeleteOrgauthorizationTrustor: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<object>(localVarStatusCode,
            localVarHeaders,
            null,
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Delete Org Trust 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trustorOrgId">Trustor Organization Id</param>
    /// <returns>Task of void</returns>

    public async Task DeleteOrgauthorizationTrustorAsync(string trustorOrgId)
    {
        await DeleteOrgauthorizationTrustorAsyncWithHttpInfo(trustorOrgId);

    }

    /// <summary>
    /// Delete Org Trust 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trustorOrgId">Trustor Organization Id</param>
    /// <returns>Task of ApiResponse</returns>

    public async Task<ApiResponse<object>> DeleteOrgauthorizationTrustorAsyncWithHttpInfo(string trustorOrgId)
    {
        // verify the required parameter 'trustorOrgId' is set
        if (trustorOrgId == null)
        {
            throw new ApiException(400, "Missing required parameter 'trustorOrgId' when calling OrganizationAuthorizationApi->DeleteOrgauthorizationTrustor");
        }

        var localVarPath = "/api/v2/orgauthorization/trustors/{trustorOrgId}";
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
        if (trustorOrgId != null)
        {
            localVarPathParams.Add("trustorOrgId", Configuration.ApiClient.ParameterToString(trustorOrgId));
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
            throw new ApiException(localVarStatusCode, "Error calling DeleteOrgauthorizationTrustor: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling DeleteOrgauthorizationTrustor: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<object>(localVarStatusCode,
            localVarHeaders,
            null,
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Delete Cloned User 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trustorOrgId">Trustor Organization Id</param>
    /// <param name="trusteeUserId">Trustee User Id</param>
    /// <returns></returns>

    public void DeleteOrgauthorizationTrustorCloneduser(string trustorOrgId, string trusteeUserId)
    {
        DeleteOrgauthorizationTrustorCloneduserWithHttpInfo(trustorOrgId, trusteeUserId);
    }

    /// <summary>
    /// Delete Cloned User 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trustorOrgId">Trustor Organization Id</param>
    /// <param name="trusteeUserId">Trustee User Id</param>
    /// <returns>ApiResponse of Object(void)</returns>

    public ApiResponse<object> DeleteOrgauthorizationTrustorCloneduserWithHttpInfo(string trustorOrgId, string trusteeUserId)
    {
        // verify the required parameter 'trustorOrgId' is set
        if (trustorOrgId == null)
        {
            throw new ApiException(400, "Missing required parameter 'trustorOrgId' when calling OrganizationAuthorizationApi->DeleteOrgauthorizationTrustorCloneduser");
        }
        // verify the required parameter 'trusteeUserId' is set
        if (trusteeUserId == null)
        {
            throw new ApiException(400, "Missing required parameter 'trusteeUserId' when calling OrganizationAuthorizationApi->DeleteOrgauthorizationTrustorCloneduser");
        }

        var localVarPath = "/api/v2/orgauthorization/trustors/{trustorOrgId}/clonedusers/{trusteeUserId}";
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
        if (trustorOrgId != null)
        {
            localVarPathParams.Add("trustorOrgId", Configuration.ApiClient.ParameterToString(trustorOrgId));
        }

        if (trusteeUserId != null)
        {
            localVarPathParams.Add("trusteeUserId", Configuration.ApiClient.ParameterToString(trusteeUserId));
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
            throw new ApiException(localVarStatusCode, "Error calling DeleteOrgauthorizationTrustorCloneduser: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling DeleteOrgauthorizationTrustorCloneduser: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<object>(localVarStatusCode,
            localVarHeaders,
            null,
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Delete Cloned User 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trustorOrgId">Trustor Organization Id</param>
    /// <param name="trusteeUserId">Trustee User Id</param>
    /// <returns>Task of void</returns>

    public async Task DeleteOrgauthorizationTrustorCloneduserAsync(string trustorOrgId, string trusteeUserId)
    {
        await DeleteOrgauthorizationTrustorCloneduserAsyncWithHttpInfo(trustorOrgId, trusteeUserId);

    }

    /// <summary>
    /// Delete Cloned User 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trustorOrgId">Trustor Organization Id</param>
    /// <param name="trusteeUserId">Trustee User Id</param>
    /// <returns>Task of ApiResponse</returns>

    public async Task<ApiResponse<object>> DeleteOrgauthorizationTrustorCloneduserAsyncWithHttpInfo(string trustorOrgId, string trusteeUserId)
    {
        // verify the required parameter 'trustorOrgId' is set
        if (trustorOrgId == null)
        {
            throw new ApiException(400, "Missing required parameter 'trustorOrgId' when calling OrganizationAuthorizationApi->DeleteOrgauthorizationTrustorCloneduser");
        }

        // verify the required parameter 'trusteeUserId' is set
        if (trusteeUserId == null)
        {
            throw new ApiException(400, "Missing required parameter 'trusteeUserId' when calling OrganizationAuthorizationApi->DeleteOrgauthorizationTrustorCloneduser");
        }

        var localVarPath = "/api/v2/orgauthorization/trustors/{trustorOrgId}/clonedusers/{trusteeUserId}";
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
        if (trustorOrgId != null)
        {
            localVarPathParams.Add("trustorOrgId", Configuration.ApiClient.ParameterToString(trustorOrgId));
        }

        if (trusteeUserId != null)
        {
            localVarPathParams.Add("trusteeUserId", Configuration.ApiClient.ParameterToString(trusteeUserId));
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
            throw new ApiException(localVarStatusCode, "Error calling DeleteOrgauthorizationTrustorCloneduser: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling DeleteOrgauthorizationTrustorCloneduser: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<object>(localVarStatusCode,
            localVarHeaders,
            null,
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Delete Trustee Group 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trustorOrgId">Trustor Organization Id</param>
    /// <param name="trustorGroupId">Trustor Group Id</param>
    /// <returns></returns>

    public void DeleteOrgauthorizationTrustorGroup(string trustorOrgId, string trustorGroupId)
    {
        DeleteOrgauthorizationTrustorGroupWithHttpInfo(trustorOrgId, trustorGroupId);
    }

    /// <summary>
    /// Delete Trustee Group 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trustorOrgId">Trustor Organization Id</param>
    /// <param name="trustorGroupId">Trustor Group Id</param>
    /// <returns>ApiResponse of Object(void)</returns>

    public ApiResponse<object> DeleteOrgauthorizationTrustorGroupWithHttpInfo(string trustorOrgId, string trustorGroupId)
    {
        // verify the required parameter 'trustorOrgId' is set
        if (trustorOrgId == null)
        {
            throw new ApiException(400, "Missing required parameter 'trustorOrgId' when calling OrganizationAuthorizationApi->DeleteOrgauthorizationTrustorGroup");
        }
        // verify the required parameter 'trustorGroupId' is set
        if (trustorGroupId == null)
        {
            throw new ApiException(400, "Missing required parameter 'trustorGroupId' when calling OrganizationAuthorizationApi->DeleteOrgauthorizationTrustorGroup");
        }

        var localVarPath = "/api/v2/orgauthorization/trustors/{trustorOrgId}/groups/{trustorGroupId}";
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
        if (trustorOrgId != null)
        {
            localVarPathParams.Add("trustorOrgId", Configuration.ApiClient.ParameterToString(trustorOrgId));
        }

        if (trustorGroupId != null)
        {
            localVarPathParams.Add("trustorGroupId", Configuration.ApiClient.ParameterToString(trustorGroupId));
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
            throw new ApiException(localVarStatusCode, "Error calling DeleteOrgauthorizationTrustorGroup: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling DeleteOrgauthorizationTrustorGroup: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<object>(localVarStatusCode,
            localVarHeaders,
            null,
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Delete Trustee Group 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trustorOrgId">Trustor Organization Id</param>
    /// <param name="trustorGroupId">Trustor Group Id</param>
    /// <returns>Task of void</returns>

    public async Task DeleteOrgauthorizationTrustorGroupAsync(string trustorOrgId, string trustorGroupId)
    {
        await DeleteOrgauthorizationTrustorGroupAsyncWithHttpInfo(trustorOrgId, trustorGroupId);

    }

    /// <summary>
    /// Delete Trustee Group 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trustorOrgId">Trustor Organization Id</param>
    /// <param name="trustorGroupId">Trustor Group Id</param>
    /// <returns>Task of ApiResponse</returns>

    public async Task<ApiResponse<object>> DeleteOrgauthorizationTrustorGroupAsyncWithHttpInfo(string trustorOrgId, string trustorGroupId)
    {
        // verify the required parameter 'trustorOrgId' is set
        if (trustorOrgId == null)
        {
            throw new ApiException(400, "Missing required parameter 'trustorOrgId' when calling OrganizationAuthorizationApi->DeleteOrgauthorizationTrustorGroup");
        }

        // verify the required parameter 'trustorGroupId' is set
        if (trustorGroupId == null)
        {
            throw new ApiException(400, "Missing required parameter 'trustorGroupId' when calling OrganizationAuthorizationApi->DeleteOrgauthorizationTrustorGroup");
        }

        var localVarPath = "/api/v2/orgauthorization/trustors/{trustorOrgId}/groups/{trustorGroupId}";
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
        if (trustorOrgId != null)
        {
            localVarPathParams.Add("trustorOrgId", Configuration.ApiClient.ParameterToString(trustorOrgId));
        }

        if (trustorGroupId != null)
        {
            localVarPathParams.Add("trustorGroupId", Configuration.ApiClient.ParameterToString(trustorGroupId));
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
            throw new ApiException(localVarStatusCode, "Error calling DeleteOrgauthorizationTrustorGroup: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling DeleteOrgauthorizationTrustorGroup: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<object>(localVarStatusCode,
            localVarHeaders,
            null,
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Delete Trustee User 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trustorOrgId">Trustor Organization Id</param>
    /// <param name="trusteeUserId">Trustee User Id</param>
    /// <returns></returns>

    public void DeleteOrgauthorizationTrustorUser(string trustorOrgId, string trusteeUserId)
    {
        DeleteOrgauthorizationTrustorUserWithHttpInfo(trustorOrgId, trusteeUserId);
    }

    /// <summary>
    /// Delete Trustee User 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trustorOrgId">Trustor Organization Id</param>
    /// <param name="trusteeUserId">Trustee User Id</param>
    /// <returns>ApiResponse of Object(void)</returns>

    public ApiResponse<object> DeleteOrgauthorizationTrustorUserWithHttpInfo(string trustorOrgId, string trusteeUserId)
    {
        // verify the required parameter 'trustorOrgId' is set
        if (trustorOrgId == null)
        {
            throw new ApiException(400, "Missing required parameter 'trustorOrgId' when calling OrganizationAuthorizationApi->DeleteOrgauthorizationTrustorUser");
        }
        // verify the required parameter 'trusteeUserId' is set
        if (trusteeUserId == null)
        {
            throw new ApiException(400, "Missing required parameter 'trusteeUserId' when calling OrganizationAuthorizationApi->DeleteOrgauthorizationTrustorUser");
        }

        var localVarPath = "/api/v2/orgauthorization/trustors/{trustorOrgId}/users/{trusteeUserId}";
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
        if (trustorOrgId != null)
        {
            localVarPathParams.Add("trustorOrgId", Configuration.ApiClient.ParameterToString(trustorOrgId));
        }

        if (trusteeUserId != null)
        {
            localVarPathParams.Add("trusteeUserId", Configuration.ApiClient.ParameterToString(trusteeUserId));
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
            throw new ApiException(localVarStatusCode, "Error calling DeleteOrgauthorizationTrustorUser: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling DeleteOrgauthorizationTrustorUser: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<object>(localVarStatusCode,
            localVarHeaders,
            null,
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Delete Trustee User 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trustorOrgId">Trustor Organization Id</param>
    /// <param name="trusteeUserId">Trustee User Id</param>
    /// <returns>Task of void</returns>

    public async Task DeleteOrgauthorizationTrustorUserAsync(string trustorOrgId, string trusteeUserId)
    {
        await DeleteOrgauthorizationTrustorUserAsyncWithHttpInfo(trustorOrgId, trusteeUserId);

    }

    /// <summary>
    /// Delete Trustee User 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trustorOrgId">Trustor Organization Id</param>
    /// <param name="trusteeUserId">Trustee User Id</param>
    /// <returns>Task of ApiResponse</returns>

    public async Task<ApiResponse<object>> DeleteOrgauthorizationTrustorUserAsyncWithHttpInfo(string trustorOrgId, string trusteeUserId)
    {
        // verify the required parameter 'trustorOrgId' is set
        if (trustorOrgId == null)
        {
            throw new ApiException(400, "Missing required parameter 'trustorOrgId' when calling OrganizationAuthorizationApi->DeleteOrgauthorizationTrustorUser");
        }

        // verify the required parameter 'trusteeUserId' is set
        if (trusteeUserId == null)
        {
            throw new ApiException(400, "Missing required parameter 'trusteeUserId' when calling OrganizationAuthorizationApi->DeleteOrgauthorizationTrustorUser");
        }

        var localVarPath = "/api/v2/orgauthorization/trustors/{trustorOrgId}/users/{trusteeUserId}";
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
        if (trustorOrgId != null)
        {
            localVarPathParams.Add("trustorOrgId", Configuration.ApiClient.ParameterToString(trustorOrgId));
        }

        if (trusteeUserId != null)
        {
            localVarPathParams.Add("trusteeUserId", Configuration.ApiClient.ParameterToString(trusteeUserId));
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
            throw new ApiException(localVarStatusCode, "Error calling DeleteOrgauthorizationTrustorUser: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling DeleteOrgauthorizationTrustorUser: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<object>(localVarStatusCode,
            localVarHeaders,
            null,
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Delete Bulk Org Trustors 
    /// 
    /// DeleteOrgauthorizationTrustors is a preview method and is subject to both breaking and non-breaking changes at any time without notice
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="id">Comma separated list of trustor ids to remove</param>
    /// <returns></returns>

    public void DeleteOrgauthorizationTrustors(List<string> id)
    {
        DeleteOrgauthorizationTrustorsWithHttpInfo(id);
    }

    /// <summary>
    /// Delete Bulk Org Trustors 
    /// 
    /// DeleteOrgauthorizationTrustors is a preview method and is subject to both breaking and non-breaking changes at any time without notice
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="id">Comma separated list of trustor ids to remove</param>
    /// <returns>ApiResponse of Object(void)</returns>

    public ApiResponse<object> DeleteOrgauthorizationTrustorsWithHttpInfo(List<string> id)
    {
        // verify the required parameter 'id' is set
        if (id == null)
        {
            throw new ApiException(400, "Missing required parameter 'id' when calling OrganizationAuthorizationApi->DeleteOrgauthorizationTrustors");
        }

        var localVarPath = "/api/v2/orgauthorization/trustors";
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
        if (id != null)
        {
            id.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("id", Configuration.ApiClient.ParameterToString(obj))); });
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
            throw new ApiException(localVarStatusCode, "Error calling DeleteOrgauthorizationTrustors: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling DeleteOrgauthorizationTrustors: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<object>(localVarStatusCode,
            localVarHeaders,
            null,
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Delete Bulk Org Trustors 
    /// 
    /// DeleteOrgauthorizationTrustors is a preview method and is subject to both breaking and non-breaking changes at any time without notice
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="id">Comma separated list of trustor ids to remove</param>
    /// <returns>Task of void</returns>

    public async Task DeleteOrgauthorizationTrustorsAsync(List<string> id)
    {
        await DeleteOrgauthorizationTrustorsAsyncWithHttpInfo(id);

    }

    /// <summary>
    /// Delete Bulk Org Trustors 
    /// 
    /// DeleteOrgauthorizationTrustors is a preview method and is subject to both breaking and non-breaking changes at any time without notice
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="id">Comma separated list of trustor ids to remove</param>
    /// <returns>Task of ApiResponse</returns>

    public async Task<ApiResponse<object>> DeleteOrgauthorizationTrustorsAsyncWithHttpInfo(List<string> id)
    {
        // verify the required parameter 'id' is set
        if (id == null)
        {
            throw new ApiException(400, "Missing required parameter 'id' when calling OrganizationAuthorizationApi->DeleteOrgauthorizationTrustors");
        }

        var localVarPath = "/api/v2/orgauthorization/trustors";
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
        if (id != null)
        {
            id.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("id", Configuration.ApiClient.ParameterToString(obj))); });
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
            throw new ApiException(localVarStatusCode, "Error calling DeleteOrgauthorizationTrustors: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling DeleteOrgauthorizationTrustors: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<object>(localVarStatusCode,
            localVarHeaders,
            null,
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Get Pairing Info 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pairingId">Pairing Id</param>
    /// <returns>TrustRequest</returns>

    public TrustRequest GetOrgauthorizationPairing(string pairingId)
    {
        ApiResponse<TrustRequest> localVarResponse = GetOrgauthorizationPairingWithHttpInfo(pairingId);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get Pairing Info 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pairingId">Pairing Id</param>
    /// <returns>ApiResponse of TrustRequest</returns>

    public ApiResponse<TrustRequest> GetOrgauthorizationPairingWithHttpInfo(string pairingId)
    {
        // verify the required parameter 'pairingId' is set
        if (pairingId == null)
        {
            throw new ApiException(400, "Missing required parameter 'pairingId' when calling OrganizationAuthorizationApi->GetOrgauthorizationPairing");
        }

        var localVarPath = "/api/v2/orgauthorization/pairings/{pairingId}";
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
        if (pairingId != null)
        {
            localVarPathParams.Add("pairingId", Configuration.ApiClient.ParameterToString(pairingId));
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
            throw new ApiException(localVarStatusCode, "Error calling GetOrgauthorizationPairing: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetOrgauthorizationPairing: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<TrustRequest>(localVarStatusCode,
            localVarHeaders,
            (TrustRequest)Configuration.ApiClient.Deserialize(localVarResponse, typeof(TrustRequest)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Get Pairing Info 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pairingId">Pairing Id</param>
    /// <returns>Task of TrustRequest</returns>

    public async Task<TrustRequest> GetOrgauthorizationPairingAsync(string pairingId)
    {
        ApiResponse<TrustRequest> localVarResponse = await GetOrgauthorizationPairingAsyncWithHttpInfo(pairingId);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Get Pairing Info 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pairingId">Pairing Id</param>
    /// <returns>Task of ApiResponse (TrustRequest)</returns>

    public async Task<ApiResponse<TrustRequest>> GetOrgauthorizationPairingAsyncWithHttpInfo(string pairingId)
    {
        // verify the required parameter 'pairingId' is set
        if (pairingId == null)
        {
            throw new ApiException(400, "Missing required parameter 'pairingId' when calling OrganizationAuthorizationApi->GetOrgauthorizationPairing");
        }

        var localVarPath = "/api/v2/orgauthorization/pairings/{pairingId}";
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
        if (pairingId != null)
        {
            localVarPathParams.Add("pairingId", Configuration.ApiClient.ParameterToString(pairingId));
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
            throw new ApiException(localVarStatusCode, "Error calling GetOrgauthorizationPairing: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetOrgauthorizationPairing: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<TrustRequest>(localVarStatusCode,
            localVarHeaders,
            (TrustRequest)Configuration.ApiClient.Deserialize(localVarResponse, typeof(TrustRequest)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Get Org Trust 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <returns>Trustee</returns>

    public Trustee GetOrgauthorizationTrustee(string trusteeOrgId)
    {
        ApiResponse<Trustee> localVarResponse = GetOrgauthorizationTrusteeWithHttpInfo(trusteeOrgId);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get Org Trust 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <returns>ApiResponse of Trustee</returns>

    public ApiResponse<Trustee> GetOrgauthorizationTrusteeWithHttpInfo(string trusteeOrgId)
    {
        // verify the required parameter 'trusteeOrgId' is set
        if (trusteeOrgId == null)
        {
            throw new ApiException(400, "Missing required parameter 'trusteeOrgId' when calling OrganizationAuthorizationApi->GetOrgauthorizationTrustee");
        }

        var localVarPath = "/api/v2/orgauthorization/trustees/{trusteeOrgId}";
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
        if (trusteeOrgId != null)
        {
            localVarPathParams.Add("trusteeOrgId", Configuration.ApiClient.ParameterToString(trusteeOrgId));
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
            throw new ApiException(localVarStatusCode, "Error calling GetOrgauthorizationTrustee: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetOrgauthorizationTrustee: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<Trustee>(localVarStatusCode,
            localVarHeaders,
            (Trustee)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Trustee)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Get Org Trust 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <returns>Task of Trustee</returns>

    public async Task<Trustee> GetOrgauthorizationTrusteeAsync(string trusteeOrgId)
    {
        ApiResponse<Trustee> localVarResponse = await GetOrgauthorizationTrusteeAsyncWithHttpInfo(trusteeOrgId);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Get Org Trust 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <returns>Task of ApiResponse (Trustee)</returns>

    public async Task<ApiResponse<Trustee>> GetOrgauthorizationTrusteeAsyncWithHttpInfo(string trusteeOrgId)
    {
        // verify the required parameter 'trusteeOrgId' is set
        if (trusteeOrgId == null)
        {
            throw new ApiException(400, "Missing required parameter 'trusteeOrgId' when calling OrganizationAuthorizationApi->GetOrgauthorizationTrustee");
        }

        var localVarPath = "/api/v2/orgauthorization/trustees/{trusteeOrgId}";
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
        if (trusteeOrgId != null)
        {
            localVarPathParams.Add("trusteeOrgId", Configuration.ApiClient.ParameterToString(trusteeOrgId));
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
            throw new ApiException(localVarStatusCode, "Error calling GetOrgauthorizationTrustee: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetOrgauthorizationTrustee: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<Trustee>(localVarStatusCode,
            localVarHeaders,
            (Trustee)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Trustee)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// The list of cloned users from the trustee organization (i.e. users with a native user record). 
    /// There can be no more than 5 cloned users per organization, so results are represented as simple list and not paged
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <returns>ClonedUserEntityListing</returns>

    public ClonedUserEntityListing GetOrgauthorizationTrusteeClonedusers(string trusteeOrgId)
    {
        ApiResponse<ClonedUserEntityListing> localVarResponse = GetOrgauthorizationTrusteeClonedusersWithHttpInfo(trusteeOrgId);
        return localVarResponse.Data;
    }

    /// <summary>
    /// The list of cloned users from the trustee organization (i.e. users with a native user record). 
    /// There can be no more than 5 cloned users per organization, so results are represented as simple list and not paged
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <returns>ApiResponse of ClonedUserEntityListing</returns>

    public ApiResponse<ClonedUserEntityListing> GetOrgauthorizationTrusteeClonedusersWithHttpInfo(string trusteeOrgId)
    {
        // verify the required parameter 'trusteeOrgId' is set
        if (trusteeOrgId == null)
        {
            throw new ApiException(400, "Missing required parameter 'trusteeOrgId' when calling OrganizationAuthorizationApi->GetOrgauthorizationTrusteeClonedusers");
        }

        var localVarPath = "/api/v2/orgauthorization/trustees/{trusteeOrgId}/clonedusers";
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
        if (trusteeOrgId != null)
        {
            localVarPathParams.Add("trusteeOrgId", Configuration.ApiClient.ParameterToString(trusteeOrgId));
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
            throw new ApiException(localVarStatusCode, "Error calling GetOrgauthorizationTrusteeClonedusers: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetOrgauthorizationTrusteeClonedusers: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<ClonedUserEntityListing>(localVarStatusCode,
            localVarHeaders,
            (ClonedUserEntityListing)Configuration.ApiClient.Deserialize(localVarResponse, typeof(ClonedUserEntityListing)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// The list of cloned users from the trustee organization (i.e. users with a native user record). 
    /// There can be no more than 5 cloned users per organization, so results are represented as simple list and not paged
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <returns>Task of ClonedUserEntityListing</returns>

    public async Task<ClonedUserEntityListing> GetOrgauthorizationTrusteeClonedusersAsync(string trusteeOrgId)
    {
        ApiResponse<ClonedUserEntityListing> localVarResponse = await GetOrgauthorizationTrusteeClonedusersAsyncWithHttpInfo(trusteeOrgId);
        return localVarResponse.Data;

    }

    /// <summary>
    /// The list of cloned users from the trustee organization (i.e. users with a native user record). 
    /// There can be no more than 5 cloned users per organization, so results are represented as simple list and not paged
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <returns>Task of ApiResponse (ClonedUserEntityListing)</returns>

    public async Task<ApiResponse<ClonedUserEntityListing>> GetOrgauthorizationTrusteeClonedusersAsyncWithHttpInfo(string trusteeOrgId)
    {
        // verify the required parameter 'trusteeOrgId' is set
        if (trusteeOrgId == null)
        {
            throw new ApiException(400, "Missing required parameter 'trusteeOrgId' when calling OrganizationAuthorizationApi->GetOrgauthorizationTrusteeClonedusers");
        }

        var localVarPath = "/api/v2/orgauthorization/trustees/{trusteeOrgId}/clonedusers";
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
        if (trusteeOrgId != null)
        {
            localVarPathParams.Add("trusteeOrgId", Configuration.ApiClient.ParameterToString(trusteeOrgId));
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
            throw new ApiException(localVarStatusCode, "Error calling GetOrgauthorizationTrusteeClonedusers: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetOrgauthorizationTrusteeClonedusers: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<ClonedUserEntityListing>(localVarStatusCode,
            localVarHeaders,
            (ClonedUserEntityListing)Configuration.ApiClient.Deserialize(localVarResponse, typeof(ClonedUserEntityListing)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Get Trustee Group 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="trusteeGroupId">Trustee Group Id</param>
    /// <returns>TrustGroup</returns>

    public TrustGroup GetOrgauthorizationTrusteeGroup(string trusteeOrgId, string trusteeGroupId)
    {
        ApiResponse<TrustGroup> localVarResponse = GetOrgauthorizationTrusteeGroupWithHttpInfo(trusteeOrgId, trusteeGroupId);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get Trustee Group 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="trusteeGroupId">Trustee Group Id</param>
    /// <returns>ApiResponse of TrustGroup</returns>

    public ApiResponse<TrustGroup> GetOrgauthorizationTrusteeGroupWithHttpInfo(string trusteeOrgId, string trusteeGroupId)
    {
        // verify the required parameter 'trusteeOrgId' is set
        if (trusteeOrgId == null)
        {
            throw new ApiException(400, "Missing required parameter 'trusteeOrgId' when calling OrganizationAuthorizationApi->GetOrgauthorizationTrusteeGroup");
        }
        // verify the required parameter 'trusteeGroupId' is set
        if (trusteeGroupId == null)
        {
            throw new ApiException(400, "Missing required parameter 'trusteeGroupId' when calling OrganizationAuthorizationApi->GetOrgauthorizationTrusteeGroup");
        }

        var localVarPath = "/api/v2/orgauthorization/trustees/{trusteeOrgId}/groups/{trusteeGroupId}";
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
        if (trusteeOrgId != null)
        {
            localVarPathParams.Add("trusteeOrgId", Configuration.ApiClient.ParameterToString(trusteeOrgId));
        }

        if (trusteeGroupId != null)
        {
            localVarPathParams.Add("trusteeGroupId", Configuration.ApiClient.ParameterToString(trusteeGroupId));
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
            throw new ApiException(localVarStatusCode, "Error calling GetOrgauthorizationTrusteeGroup: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetOrgauthorizationTrusteeGroup: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<TrustGroup>(localVarStatusCode,
            localVarHeaders,
            (TrustGroup)Configuration.ApiClient.Deserialize(localVarResponse, typeof(TrustGroup)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Get Trustee Group 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="trusteeGroupId">Trustee Group Id</param>
    /// <returns>Task of TrustGroup</returns>

    public async Task<TrustGroup> GetOrgauthorizationTrusteeGroupAsync(string trusteeOrgId, string trusteeGroupId)
    {
        ApiResponse<TrustGroup> localVarResponse = await GetOrgauthorizationTrusteeGroupAsyncWithHttpInfo(trusteeOrgId, trusteeGroupId);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Get Trustee Group 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="trusteeGroupId">Trustee Group Id</param>
    /// <returns>Task of ApiResponse (TrustGroup)</returns>

    public async Task<ApiResponse<TrustGroup>> GetOrgauthorizationTrusteeGroupAsyncWithHttpInfo(string trusteeOrgId, string trusteeGroupId)
    {
        // verify the required parameter 'trusteeOrgId' is set
        if (trusteeOrgId == null)
        {
            throw new ApiException(400, "Missing required parameter 'trusteeOrgId' when calling OrganizationAuthorizationApi->GetOrgauthorizationTrusteeGroup");
        }

        // verify the required parameter 'trusteeGroupId' is set
        if (trusteeGroupId == null)
        {
            throw new ApiException(400, "Missing required parameter 'trusteeGroupId' when calling OrganizationAuthorizationApi->GetOrgauthorizationTrusteeGroup");
        }

        var localVarPath = "/api/v2/orgauthorization/trustees/{trusteeOrgId}/groups/{trusteeGroupId}";
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
        if (trusteeOrgId != null)
        {
            localVarPathParams.Add("trusteeOrgId", Configuration.ApiClient.ParameterToString(trusteeOrgId));
        }

        if (trusteeGroupId != null)
        {
            localVarPathParams.Add("trusteeGroupId", Configuration.ApiClient.ParameterToString(trusteeGroupId));
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
            throw new ApiException(localVarStatusCode, "Error calling GetOrgauthorizationTrusteeGroup: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetOrgauthorizationTrusteeGroup: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<TrustGroup>(localVarStatusCode,
            localVarHeaders,
            (TrustGroup)Configuration.ApiClient.Deserialize(localVarResponse, typeof(TrustGroup)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Get Trustee Group Roles 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="trusteeGroupId">Trustee Group Id</param>
    /// <returns>UserAuthorization</returns>

    public UserAuthorization GetOrgauthorizationTrusteeGroupRoles(string trusteeOrgId, string trusteeGroupId)
    {
        ApiResponse<UserAuthorization> localVarResponse = GetOrgauthorizationTrusteeGroupRolesWithHttpInfo(trusteeOrgId, trusteeGroupId);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get Trustee Group Roles 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="trusteeGroupId">Trustee Group Id</param>
    /// <returns>ApiResponse of UserAuthorization</returns>

    public ApiResponse<UserAuthorization> GetOrgauthorizationTrusteeGroupRolesWithHttpInfo(string trusteeOrgId, string trusteeGroupId)
    {
        // verify the required parameter 'trusteeOrgId' is set
        if (trusteeOrgId == null)
        {
            throw new ApiException(400, "Missing required parameter 'trusteeOrgId' when calling OrganizationAuthorizationApi->GetOrgauthorizationTrusteeGroupRoles");
        }
        // verify the required parameter 'trusteeGroupId' is set
        if (trusteeGroupId == null)
        {
            throw new ApiException(400, "Missing required parameter 'trusteeGroupId' when calling OrganizationAuthorizationApi->GetOrgauthorizationTrusteeGroupRoles");
        }

        var localVarPath = "/api/v2/orgauthorization/trustees/{trusteeOrgId}/groups/{trusteeGroupId}/roles";
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
        if (trusteeOrgId != null)
        {
            localVarPathParams.Add("trusteeOrgId", Configuration.ApiClient.ParameterToString(trusteeOrgId));
        }

        if (trusteeGroupId != null)
        {
            localVarPathParams.Add("trusteeGroupId", Configuration.ApiClient.ParameterToString(trusteeGroupId));
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
            throw new ApiException(localVarStatusCode, "Error calling GetOrgauthorizationTrusteeGroupRoles: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetOrgauthorizationTrusteeGroupRoles: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<UserAuthorization>(localVarStatusCode,
            localVarHeaders,
            (UserAuthorization)Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserAuthorization)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Get Trustee Group Roles 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="trusteeGroupId">Trustee Group Id</param>
    /// <returns>Task of UserAuthorization</returns>

    public async Task<UserAuthorization> GetOrgauthorizationTrusteeGroupRolesAsync(string trusteeOrgId, string trusteeGroupId)
    {
        ApiResponse<UserAuthorization> localVarResponse = await GetOrgauthorizationTrusteeGroupRolesAsyncWithHttpInfo(trusteeOrgId, trusteeGroupId);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Get Trustee Group Roles 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="trusteeGroupId">Trustee Group Id</param>
    /// <returns>Task of ApiResponse (UserAuthorization)</returns>

    public async Task<ApiResponse<UserAuthorization>> GetOrgauthorizationTrusteeGroupRolesAsyncWithHttpInfo(string trusteeOrgId, string trusteeGroupId)
    {
        // verify the required parameter 'trusteeOrgId' is set
        if (trusteeOrgId == null)
        {
            throw new ApiException(400, "Missing required parameter 'trusteeOrgId' when calling OrganizationAuthorizationApi->GetOrgauthorizationTrusteeGroupRoles");
        }

        // verify the required parameter 'trusteeGroupId' is set
        if (trusteeGroupId == null)
        {
            throw new ApiException(400, "Missing required parameter 'trusteeGroupId' when calling OrganizationAuthorizationApi->GetOrgauthorizationTrusteeGroupRoles");
        }

        var localVarPath = "/api/v2/orgauthorization/trustees/{trusteeOrgId}/groups/{trusteeGroupId}/roles";
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
        if (trusteeOrgId != null)
        {
            localVarPathParams.Add("trusteeOrgId", Configuration.ApiClient.ParameterToString(trusteeOrgId));
        }

        if (trusteeGroupId != null)
        {
            localVarPathParams.Add("trusteeGroupId", Configuration.ApiClient.ParameterToString(trusteeGroupId));
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
            throw new ApiException(localVarStatusCode, "Error calling GetOrgauthorizationTrusteeGroupRoles: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetOrgauthorizationTrusteeGroupRoles: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<UserAuthorization>(localVarStatusCode,
            localVarHeaders,
            (UserAuthorization)Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserAuthorization)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// The list of trustee groups for this organization (i.e. groups granted access to this organization). 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <returns>TrustGroupEntityListing</returns>

    public TrustGroupEntityListing GetOrgauthorizationTrusteeGroups(string trusteeOrgId, int? pageSize = null, int? pageNumber = null)
    {
        ApiResponse<TrustGroupEntityListing> localVarResponse = GetOrgauthorizationTrusteeGroupsWithHttpInfo(trusteeOrgId, pageSize, pageNumber);
        return localVarResponse.Data;
    }

    /// <summary>
    /// The list of trustee groups for this organization (i.e. groups granted access to this organization). 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <returns>ApiResponse of TrustGroupEntityListing</returns>

    public ApiResponse<TrustGroupEntityListing> GetOrgauthorizationTrusteeGroupsWithHttpInfo(string trusteeOrgId, int? pageSize = null, int? pageNumber = null)
    {
        // verify the required parameter 'trusteeOrgId' is set
        if (trusteeOrgId == null)
        {
            throw new ApiException(400, "Missing required parameter 'trusteeOrgId' when calling OrganizationAuthorizationApi->GetOrgauthorizationTrusteeGroups");
        }

        var localVarPath = "/api/v2/orgauthorization/trustees/{trusteeOrgId}/groups";
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
        if (trusteeOrgId != null)
        {
            localVarPathParams.Add("trusteeOrgId", Configuration.ApiClient.ParameterToString(trusteeOrgId));
        }

        // Query params
        if (pageSize != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("pageSize", Configuration.ApiClient.ParameterToString(pageSize)));
        }

        if (pageNumber != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)));
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
            throw new ApiException(localVarStatusCode, "Error calling GetOrgauthorizationTrusteeGroups: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetOrgauthorizationTrusteeGroups: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<TrustGroupEntityListing>(localVarStatusCode,
            localVarHeaders,
            (TrustGroupEntityListing)Configuration.ApiClient.Deserialize(localVarResponse, typeof(TrustGroupEntityListing)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// The list of trustee groups for this organization (i.e. groups granted access to this organization). 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <returns>Task of TrustGroupEntityListing</returns>

    public async Task<TrustGroupEntityListing> GetOrgauthorizationTrusteeGroupsAsync(string trusteeOrgId, int? pageSize = null, int? pageNumber = null)
    {
        ApiResponse<TrustGroupEntityListing> localVarResponse = await GetOrgauthorizationTrusteeGroupsAsyncWithHttpInfo(trusteeOrgId, pageSize, pageNumber);
        return localVarResponse.Data;

    }

    /// <summary>
    /// The list of trustee groups for this organization (i.e. groups granted access to this organization). 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <returns>Task of ApiResponse (TrustGroupEntityListing)</returns>

    public async Task<ApiResponse<TrustGroupEntityListing>> GetOrgauthorizationTrusteeGroupsAsyncWithHttpInfo(string trusteeOrgId, int? pageSize = null, int? pageNumber = null)
    {
        // verify the required parameter 'trusteeOrgId' is set
        if (trusteeOrgId == null)
        {
            throw new ApiException(400, "Missing required parameter 'trusteeOrgId' when calling OrganizationAuthorizationApi->GetOrgauthorizationTrusteeGroups");
        }

        var localVarPath = "/api/v2/orgauthorization/trustees/{trusteeOrgId}/groups";
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
        if (trusteeOrgId != null)
        {
            localVarPathParams.Add("trusteeOrgId", Configuration.ApiClient.ParameterToString(trusteeOrgId));
        }

        // Query params
        if (pageSize != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("pageSize", Configuration.ApiClient.ParameterToString(pageSize)));
        }

        if (pageNumber != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)));
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
            throw new ApiException(localVarStatusCode, "Error calling GetOrgauthorizationTrusteeGroups: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetOrgauthorizationTrusteeGroups: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<TrustGroupEntityListing>(localVarStatusCode,
            localVarHeaders,
            (TrustGroupEntityListing)Configuration.ApiClient.Deserialize(localVarResponse, typeof(TrustGroupEntityListing)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Get Trustee User 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="trusteeUserId">Trustee User Id</param>
    /// <returns>TrustUser</returns>

    public TrustUser GetOrgauthorizationTrusteeUser(string trusteeOrgId, string trusteeUserId)
    {
        ApiResponse<TrustUser> localVarResponse = GetOrgauthorizationTrusteeUserWithHttpInfo(trusteeOrgId, trusteeUserId);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get Trustee User 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="trusteeUserId">Trustee User Id</param>
    /// <returns>ApiResponse of TrustUser</returns>

    public ApiResponse<TrustUser> GetOrgauthorizationTrusteeUserWithHttpInfo(string trusteeOrgId, string trusteeUserId)
    {
        // verify the required parameter 'trusteeOrgId' is set
        if (trusteeOrgId == null)
        {
            throw new ApiException(400, "Missing required parameter 'trusteeOrgId' when calling OrganizationAuthorizationApi->GetOrgauthorizationTrusteeUser");
        }
        // verify the required parameter 'trusteeUserId' is set
        if (trusteeUserId == null)
        {
            throw new ApiException(400, "Missing required parameter 'trusteeUserId' when calling OrganizationAuthorizationApi->GetOrgauthorizationTrusteeUser");
        }

        var localVarPath = "/api/v2/orgauthorization/trustees/{trusteeOrgId}/users/{trusteeUserId}";
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
        if (trusteeOrgId != null)
        {
            localVarPathParams.Add("trusteeOrgId", Configuration.ApiClient.ParameterToString(trusteeOrgId));
        }

        if (trusteeUserId != null)
        {
            localVarPathParams.Add("trusteeUserId", Configuration.ApiClient.ParameterToString(trusteeUserId));
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
            throw new ApiException(localVarStatusCode, "Error calling GetOrgauthorizationTrusteeUser: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetOrgauthorizationTrusteeUser: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<TrustUser>(localVarStatusCode,
            localVarHeaders,
            (TrustUser)Configuration.ApiClient.Deserialize(localVarResponse, typeof(TrustUser)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Get Trustee User 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="trusteeUserId">Trustee User Id</param>
    /// <returns>Task of TrustUser</returns>

    public async Task<TrustUser> GetOrgauthorizationTrusteeUserAsync(string trusteeOrgId, string trusteeUserId)
    {
        ApiResponse<TrustUser> localVarResponse = await GetOrgauthorizationTrusteeUserAsyncWithHttpInfo(trusteeOrgId, trusteeUserId);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Get Trustee User 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="trusteeUserId">Trustee User Id</param>
    /// <returns>Task of ApiResponse (TrustUser)</returns>

    public async Task<ApiResponse<TrustUser>> GetOrgauthorizationTrusteeUserAsyncWithHttpInfo(string trusteeOrgId, string trusteeUserId)
    {
        // verify the required parameter 'trusteeOrgId' is set
        if (trusteeOrgId == null)
        {
            throw new ApiException(400, "Missing required parameter 'trusteeOrgId' when calling OrganizationAuthorizationApi->GetOrgauthorizationTrusteeUser");
        }

        // verify the required parameter 'trusteeUserId' is set
        if (trusteeUserId == null)
        {
            throw new ApiException(400, "Missing required parameter 'trusteeUserId' when calling OrganizationAuthorizationApi->GetOrgauthorizationTrusteeUser");
        }

        var localVarPath = "/api/v2/orgauthorization/trustees/{trusteeOrgId}/users/{trusteeUserId}";
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
        if (trusteeOrgId != null)
        {
            localVarPathParams.Add("trusteeOrgId", Configuration.ApiClient.ParameterToString(trusteeOrgId));
        }

        if (trusteeUserId != null)
        {
            localVarPathParams.Add("trusteeUserId", Configuration.ApiClient.ParameterToString(trusteeUserId));
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
            throw new ApiException(localVarStatusCode, "Error calling GetOrgauthorizationTrusteeUser: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetOrgauthorizationTrusteeUser: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<TrustUser>(localVarStatusCode,
            localVarHeaders,
            (TrustUser)Configuration.ApiClient.Deserialize(localVarResponse, typeof(TrustUser)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Get Trustee User Roles 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="trusteeUserId">Trustee User Id</param>
    /// <returns>UserAuthorization</returns>

    public UserAuthorization GetOrgauthorizationTrusteeUserRoles(string trusteeOrgId, string trusteeUserId)
    {
        ApiResponse<UserAuthorization> localVarResponse = GetOrgauthorizationTrusteeUserRolesWithHttpInfo(trusteeOrgId, trusteeUserId);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get Trustee User Roles 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="trusteeUserId">Trustee User Id</param>
    /// <returns>ApiResponse of UserAuthorization</returns>

    public ApiResponse<UserAuthorization> GetOrgauthorizationTrusteeUserRolesWithHttpInfo(string trusteeOrgId, string trusteeUserId)
    {
        // verify the required parameter 'trusteeOrgId' is set
        if (trusteeOrgId == null)
        {
            throw new ApiException(400, "Missing required parameter 'trusteeOrgId' when calling OrganizationAuthorizationApi->GetOrgauthorizationTrusteeUserRoles");
        }
        // verify the required parameter 'trusteeUserId' is set
        if (trusteeUserId == null)
        {
            throw new ApiException(400, "Missing required parameter 'trusteeUserId' when calling OrganizationAuthorizationApi->GetOrgauthorizationTrusteeUserRoles");
        }

        var localVarPath = "/api/v2/orgauthorization/trustees/{trusteeOrgId}/users/{trusteeUserId}/roles";
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
        if (trusteeOrgId != null)
        {
            localVarPathParams.Add("trusteeOrgId", Configuration.ApiClient.ParameterToString(trusteeOrgId));
        }

        if (trusteeUserId != null)
        {
            localVarPathParams.Add("trusteeUserId", Configuration.ApiClient.ParameterToString(trusteeUserId));
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
            throw new ApiException(localVarStatusCode, "Error calling GetOrgauthorizationTrusteeUserRoles: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetOrgauthorizationTrusteeUserRoles: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<UserAuthorization>(localVarStatusCode,
            localVarHeaders,
            (UserAuthorization)Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserAuthorization)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Get Trustee User Roles 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="trusteeUserId">Trustee User Id</param>
    /// <returns>Task of UserAuthorization</returns>

    public async Task<UserAuthorization> GetOrgauthorizationTrusteeUserRolesAsync(string trusteeOrgId, string trusteeUserId)
    {
        ApiResponse<UserAuthorization> localVarResponse = await GetOrgauthorizationTrusteeUserRolesAsyncWithHttpInfo(trusteeOrgId, trusteeUserId);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Get Trustee User Roles 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="trusteeUserId">Trustee User Id</param>
    /// <returns>Task of ApiResponse (UserAuthorization)</returns>

    public async Task<ApiResponse<UserAuthorization>> GetOrgauthorizationTrusteeUserRolesAsyncWithHttpInfo(string trusteeOrgId, string trusteeUserId)
    {
        // verify the required parameter 'trusteeOrgId' is set
        if (trusteeOrgId == null)
        {
            throw new ApiException(400, "Missing required parameter 'trusteeOrgId' when calling OrganizationAuthorizationApi->GetOrgauthorizationTrusteeUserRoles");
        }

        // verify the required parameter 'trusteeUserId' is set
        if (trusteeUserId == null)
        {
            throw new ApiException(400, "Missing required parameter 'trusteeUserId' when calling OrganizationAuthorizationApi->GetOrgauthorizationTrusteeUserRoles");
        }

        var localVarPath = "/api/v2/orgauthorization/trustees/{trusteeOrgId}/users/{trusteeUserId}/roles";
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
        if (trusteeOrgId != null)
        {
            localVarPathParams.Add("trusteeOrgId", Configuration.ApiClient.ParameterToString(trusteeOrgId));
        }

        if (trusteeUserId != null)
        {
            localVarPathParams.Add("trusteeUserId", Configuration.ApiClient.ParameterToString(trusteeUserId));
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
            throw new ApiException(localVarStatusCode, "Error calling GetOrgauthorizationTrusteeUserRoles: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetOrgauthorizationTrusteeUserRoles: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<UserAuthorization>(localVarStatusCode,
            localVarHeaders,
            (UserAuthorization)Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserAuthorization)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// The list of trustee users for this organization (i.e. users granted access to this organization). 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <returns>TrustUserEntityListing</returns>

    public TrustUserEntityListing GetOrgauthorizationTrusteeUsers(string trusteeOrgId, int? pageSize = null, int? pageNumber = null)
    {
        ApiResponse<TrustUserEntityListing> localVarResponse = GetOrgauthorizationTrusteeUsersWithHttpInfo(trusteeOrgId, pageSize, pageNumber);
        return localVarResponse.Data;
    }

    /// <summary>
    /// The list of trustee users for this organization (i.e. users granted access to this organization). 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <returns>ApiResponse of TrustUserEntityListing</returns>

    public ApiResponse<TrustUserEntityListing> GetOrgauthorizationTrusteeUsersWithHttpInfo(string trusteeOrgId, int? pageSize = null, int? pageNumber = null)
    {
        // verify the required parameter 'trusteeOrgId' is set
        if (trusteeOrgId == null)
        {
            throw new ApiException(400, "Missing required parameter 'trusteeOrgId' when calling OrganizationAuthorizationApi->GetOrgauthorizationTrusteeUsers");
        }

        var localVarPath = "/api/v2/orgauthorization/trustees/{trusteeOrgId}/users";
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
        if (trusteeOrgId != null)
        {
            localVarPathParams.Add("trusteeOrgId", Configuration.ApiClient.ParameterToString(trusteeOrgId));
        }

        // Query params
        if (pageSize != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("pageSize", Configuration.ApiClient.ParameterToString(pageSize)));
        }

        if (pageNumber != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)));
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
            throw new ApiException(localVarStatusCode, "Error calling GetOrgauthorizationTrusteeUsers: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetOrgauthorizationTrusteeUsers: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<TrustUserEntityListing>(localVarStatusCode,
            localVarHeaders,
            (TrustUserEntityListing)Configuration.ApiClient.Deserialize(localVarResponse, typeof(TrustUserEntityListing)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// The list of trustee users for this organization (i.e. users granted access to this organization). 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <returns>Task of TrustUserEntityListing</returns>

    public async Task<TrustUserEntityListing> GetOrgauthorizationTrusteeUsersAsync(string trusteeOrgId, int? pageSize = null, int? pageNumber = null)
    {
        ApiResponse<TrustUserEntityListing> localVarResponse = await GetOrgauthorizationTrusteeUsersAsyncWithHttpInfo(trusteeOrgId, pageSize, pageNumber);
        return localVarResponse.Data;

    }

    /// <summary>
    /// The list of trustee users for this organization (i.e. users granted access to this organization). 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <returns>Task of ApiResponse (TrustUserEntityListing)</returns>

    public async Task<ApiResponse<TrustUserEntityListing>> GetOrgauthorizationTrusteeUsersAsyncWithHttpInfo(string trusteeOrgId, int? pageSize = null, int? pageNumber = null)
    {
        // verify the required parameter 'trusteeOrgId' is set
        if (trusteeOrgId == null)
        {
            throw new ApiException(400, "Missing required parameter 'trusteeOrgId' when calling OrganizationAuthorizationApi->GetOrgauthorizationTrusteeUsers");
        }

        var localVarPath = "/api/v2/orgauthorization/trustees/{trusteeOrgId}/users";
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
        if (trusteeOrgId != null)
        {
            localVarPathParams.Add("trusteeOrgId", Configuration.ApiClient.ParameterToString(trusteeOrgId));
        }

        // Query params
        if (pageSize != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("pageSize", Configuration.ApiClient.ParameterToString(pageSize)));
        }

        if (pageNumber != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)));
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
            throw new ApiException(localVarStatusCode, "Error calling GetOrgauthorizationTrusteeUsers: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetOrgauthorizationTrusteeUsers: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<TrustUserEntityListing>(localVarStatusCode,
            localVarHeaders,
            (TrustUserEntityListing)Configuration.ApiClient.Deserialize(localVarResponse, typeof(TrustUserEntityListing)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// The list of trustees for this organization (i.e. organizations granted access to this organization). 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <returns>TrustEntityListing</returns>

    public TrustEntityListing GetOrgauthorizationTrustees(int? pageSize = null, int? pageNumber = null)
    {
        ApiResponse<TrustEntityListing> localVarResponse = GetOrgauthorizationTrusteesWithHttpInfo(pageSize, pageNumber);
        return localVarResponse.Data;
    }

    /// <summary>
    /// The list of trustees for this organization (i.e. organizations granted access to this organization). 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <returns>ApiResponse of TrustEntityListing</returns>

    public ApiResponse<TrustEntityListing> GetOrgauthorizationTrusteesWithHttpInfo(int? pageSize = null, int? pageNumber = null)
    {

        var localVarPath = "/api/v2/orgauthorization/trustees";
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
            throw new ApiException(localVarStatusCode, "Error calling GetOrgauthorizationTrustees: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetOrgauthorizationTrustees: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<TrustEntityListing>(localVarStatusCode,
            localVarHeaders,
            (TrustEntityListing)Configuration.ApiClient.Deserialize(localVarResponse, typeof(TrustEntityListing)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// The list of trustees for this organization (i.e. organizations granted access to this organization). 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <returns>Task of TrustEntityListing</returns>

    public async Task<TrustEntityListing> GetOrgauthorizationTrusteesAsync(int? pageSize = null, int? pageNumber = null)
    {
        ApiResponse<TrustEntityListing> localVarResponse = await GetOrgauthorizationTrusteesAsyncWithHttpInfo(pageSize, pageNumber);
        return localVarResponse.Data;

    }

    /// <summary>
    /// The list of trustees for this organization (i.e. organizations granted access to this organization). 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <returns>Task of ApiResponse (TrustEntityListing)</returns>

    public async Task<ApiResponse<TrustEntityListing>> GetOrgauthorizationTrusteesAsyncWithHttpInfo(int? pageSize = null, int? pageNumber = null)
    {

        var localVarPath = "/api/v2/orgauthorization/trustees";
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
            throw new ApiException(localVarStatusCode, "Error calling GetOrgauthorizationTrustees: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetOrgauthorizationTrustees: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<TrustEntityListing>(localVarStatusCode,
            localVarHeaders,
            (TrustEntityListing)Configuration.ApiClient.Deserialize(localVarResponse, typeof(TrustEntityListing)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Get Customer Care organization ids. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>TrusteeReferenceList</returns>

    public TrusteeReferenceList GetOrgauthorizationTrusteesCare()
    {
        ApiResponse<TrusteeReferenceList> localVarResponse = GetOrgauthorizationTrusteesCareWithHttpInfo();
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get Customer Care organization ids. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>ApiResponse of TrusteeReferenceList</returns>

    public ApiResponse<TrusteeReferenceList> GetOrgauthorizationTrusteesCareWithHttpInfo()
    {

        var localVarPath = "/api/v2/orgauthorization/trustees/care";
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
            throw new ApiException(localVarStatusCode, "Error calling GetOrgauthorizationTrusteesCare: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetOrgauthorizationTrusteesCare: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<TrusteeReferenceList>(localVarStatusCode,
            localVarHeaders,
            (TrusteeReferenceList)Configuration.ApiClient.Deserialize(localVarResponse, typeof(TrusteeReferenceList)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Get Customer Care organization ids. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of TrusteeReferenceList</returns>

    public async Task<TrusteeReferenceList> GetOrgauthorizationTrusteesCareAsync()
    {
        ApiResponse<TrusteeReferenceList> localVarResponse = await GetOrgauthorizationTrusteesCareAsyncWithHttpInfo();
        return localVarResponse.Data;

    }

    /// <summary>
    /// Get Customer Care organization ids. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of ApiResponse (TrusteeReferenceList)</returns>

    public async Task<ApiResponse<TrusteeReferenceList>> GetOrgauthorizationTrusteesCareAsyncWithHttpInfo()
    {

        var localVarPath = "/api/v2/orgauthorization/trustees/care";
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
            throw new ApiException(localVarStatusCode, "Error calling GetOrgauthorizationTrusteesCare: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetOrgauthorizationTrusteesCare: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<TrusteeReferenceList>(localVarStatusCode,
            localVarHeaders,
            (TrusteeReferenceList)Configuration.ApiClient.Deserialize(localVarResponse, typeof(TrusteeReferenceList)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Get organization authorization trust with Customer Care, if one exists. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Trustee</returns>

    public Trustee GetOrgauthorizationTrusteesDefault()
    {
        ApiResponse<Trustee> localVarResponse = GetOrgauthorizationTrusteesDefaultWithHttpInfo();
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get organization authorization trust with Customer Care, if one exists. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>ApiResponse of Trustee</returns>

    public ApiResponse<Trustee> GetOrgauthorizationTrusteesDefaultWithHttpInfo()
    {

        var localVarPath = "/api/v2/orgauthorization/trustees/default";
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
            throw new ApiException(localVarStatusCode, "Error calling GetOrgauthorizationTrusteesDefault: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetOrgauthorizationTrusteesDefault: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<Trustee>(localVarStatusCode,
            localVarHeaders,
            (Trustee)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Trustee)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Get organization authorization trust with Customer Care, if one exists. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of Trustee</returns>

    public async Task<Trustee> GetOrgauthorizationTrusteesDefaultAsync()
    {
        ApiResponse<Trustee> localVarResponse = await GetOrgauthorizationTrusteesDefaultAsyncWithHttpInfo();
        return localVarResponse.Data;

    }

    /// <summary>
    /// Get organization authorization trust with Customer Care, if one exists. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of ApiResponse (Trustee)</returns>

    public async Task<ApiResponse<Trustee>> GetOrgauthorizationTrusteesDefaultAsyncWithHttpInfo()
    {

        var localVarPath = "/api/v2/orgauthorization/trustees/default";
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
            throw new ApiException(localVarStatusCode, "Error calling GetOrgauthorizationTrusteesDefault: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetOrgauthorizationTrusteesDefault: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<Trustee>(localVarStatusCode,
            localVarHeaders,
            (Trustee)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Trustee)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Get Org Trust 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trustorOrgId">Trustor Organization Id</param>
    /// <returns>Trustor</returns>

    public Trustor GetOrgauthorizationTrustor(string trustorOrgId)
    {
        ApiResponse<Trustor> localVarResponse = GetOrgauthorizationTrustorWithHttpInfo(trustorOrgId);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get Org Trust 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trustorOrgId">Trustor Organization Id</param>
    /// <returns>ApiResponse of Trustor</returns>

    public ApiResponse<Trustor> GetOrgauthorizationTrustorWithHttpInfo(string trustorOrgId)
    {
        // verify the required parameter 'trustorOrgId' is set
        if (trustorOrgId == null)
        {
            throw new ApiException(400, "Missing required parameter 'trustorOrgId' when calling OrganizationAuthorizationApi->GetOrgauthorizationTrustor");
        }

        var localVarPath = "/api/v2/orgauthorization/trustors/{trustorOrgId}";
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
        if (trustorOrgId != null)
        {
            localVarPathParams.Add("trustorOrgId", Configuration.ApiClient.ParameterToString(trustorOrgId));
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
            throw new ApiException(localVarStatusCode, "Error calling GetOrgauthorizationTrustor: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetOrgauthorizationTrustor: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<Trustor>(localVarStatusCode,
            localVarHeaders,
            (Trustor)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Trustor)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Get Org Trust 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trustorOrgId">Trustor Organization Id</param>
    /// <returns>Task of Trustor</returns>

    public async Task<Trustor> GetOrgauthorizationTrustorAsync(string trustorOrgId)
    {
        ApiResponse<Trustor> localVarResponse = await GetOrgauthorizationTrustorAsyncWithHttpInfo(trustorOrgId);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Get Org Trust 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trustorOrgId">Trustor Organization Id</param>
    /// <returns>Task of ApiResponse (Trustor)</returns>

    public async Task<ApiResponse<Trustor>> GetOrgauthorizationTrustorAsyncWithHttpInfo(string trustorOrgId)
    {
        // verify the required parameter 'trustorOrgId' is set
        if (trustorOrgId == null)
        {
            throw new ApiException(400, "Missing required parameter 'trustorOrgId' when calling OrganizationAuthorizationApi->GetOrgauthorizationTrustor");
        }

        var localVarPath = "/api/v2/orgauthorization/trustors/{trustorOrgId}";
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
        if (trustorOrgId != null)
        {
            localVarPathParams.Add("trustorOrgId", Configuration.ApiClient.ParameterToString(trustorOrgId));
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
            throw new ApiException(localVarStatusCode, "Error calling GetOrgauthorizationTrustor: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetOrgauthorizationTrustor: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<Trustor>(localVarStatusCode,
            localVarHeaders,
            (Trustor)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Trustor)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Get Cloned User 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trustorOrgId">Trustor Organization Id</param>
    /// <param name="trusteeUserId">Trustee User Id</param>
    /// <returns>ClonedUser</returns>

    public ClonedUser GetOrgauthorizationTrustorCloneduser(string trustorOrgId, string trusteeUserId)
    {
        ApiResponse<ClonedUser> localVarResponse = GetOrgauthorizationTrustorCloneduserWithHttpInfo(trustorOrgId, trusteeUserId);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get Cloned User 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trustorOrgId">Trustor Organization Id</param>
    /// <param name="trusteeUserId">Trustee User Id</param>
    /// <returns>ApiResponse of ClonedUser</returns>

    public ApiResponse<ClonedUser> GetOrgauthorizationTrustorCloneduserWithHttpInfo(string trustorOrgId, string trusteeUserId)
    {
        // verify the required parameter 'trustorOrgId' is set
        if (trustorOrgId == null)
        {
            throw new ApiException(400, "Missing required parameter 'trustorOrgId' when calling OrganizationAuthorizationApi->GetOrgauthorizationTrustorCloneduser");
        }
        // verify the required parameter 'trusteeUserId' is set
        if (trusteeUserId == null)
        {
            throw new ApiException(400, "Missing required parameter 'trusteeUserId' when calling OrganizationAuthorizationApi->GetOrgauthorizationTrustorCloneduser");
        }

        var localVarPath = "/api/v2/orgauthorization/trustors/{trustorOrgId}/clonedusers/{trusteeUserId}";
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
        if (trustorOrgId != null)
        {
            localVarPathParams.Add("trustorOrgId", Configuration.ApiClient.ParameterToString(trustorOrgId));
        }

        if (trusteeUserId != null)
        {
            localVarPathParams.Add("trusteeUserId", Configuration.ApiClient.ParameterToString(trusteeUserId));
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
            throw new ApiException(localVarStatusCode, "Error calling GetOrgauthorizationTrustorCloneduser: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetOrgauthorizationTrustorCloneduser: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<ClonedUser>(localVarStatusCode,
            localVarHeaders,
            (ClonedUser)Configuration.ApiClient.Deserialize(localVarResponse, typeof(ClonedUser)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Get Cloned User 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trustorOrgId">Trustor Organization Id</param>
    /// <param name="trusteeUserId">Trustee User Id</param>
    /// <returns>Task of ClonedUser</returns>

    public async Task<ClonedUser> GetOrgauthorizationTrustorCloneduserAsync(string trustorOrgId, string trusteeUserId)
    {
        ApiResponse<ClonedUser> localVarResponse = await GetOrgauthorizationTrustorCloneduserAsyncWithHttpInfo(trustorOrgId, trusteeUserId);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Get Cloned User 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trustorOrgId">Trustor Organization Id</param>
    /// <param name="trusteeUserId">Trustee User Id</param>
    /// <returns>Task of ApiResponse (ClonedUser)</returns>

    public async Task<ApiResponse<ClonedUser>> GetOrgauthorizationTrustorCloneduserAsyncWithHttpInfo(string trustorOrgId, string trusteeUserId)
    {
        // verify the required parameter 'trustorOrgId' is set
        if (trustorOrgId == null)
        {
            throw new ApiException(400, "Missing required parameter 'trustorOrgId' when calling OrganizationAuthorizationApi->GetOrgauthorizationTrustorCloneduser");
        }

        // verify the required parameter 'trusteeUserId' is set
        if (trusteeUserId == null)
        {
            throw new ApiException(400, "Missing required parameter 'trusteeUserId' when calling OrganizationAuthorizationApi->GetOrgauthorizationTrustorCloneduser");
        }

        var localVarPath = "/api/v2/orgauthorization/trustors/{trustorOrgId}/clonedusers/{trusteeUserId}";
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
        if (trustorOrgId != null)
        {
            localVarPathParams.Add("trustorOrgId", Configuration.ApiClient.ParameterToString(trustorOrgId));
        }

        if (trusteeUserId != null)
        {
            localVarPathParams.Add("trusteeUserId", Configuration.ApiClient.ParameterToString(trusteeUserId));
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
            throw new ApiException(localVarStatusCode, "Error calling GetOrgauthorizationTrustorCloneduser: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetOrgauthorizationTrustorCloneduser: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<ClonedUser>(localVarStatusCode,
            localVarHeaders,
            (ClonedUser)Configuration.ApiClient.Deserialize(localVarResponse, typeof(ClonedUser)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// The list of cloned users in the trustor organization (i.e. users with a native user record). 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trustorOrgId">Trustor Organization Id</param>
    /// <returns>ClonedUserEntityListing</returns>

    public ClonedUserEntityListing GetOrgauthorizationTrustorClonedusers(string trustorOrgId)
    {
        ApiResponse<ClonedUserEntityListing> localVarResponse = GetOrgauthorizationTrustorClonedusersWithHttpInfo(trustorOrgId);
        return localVarResponse.Data;
    }

    /// <summary>
    /// The list of cloned users in the trustor organization (i.e. users with a native user record). 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trustorOrgId">Trustor Organization Id</param>
    /// <returns>ApiResponse of ClonedUserEntityListing</returns>

    public ApiResponse<ClonedUserEntityListing> GetOrgauthorizationTrustorClonedusersWithHttpInfo(string trustorOrgId)
    {
        // verify the required parameter 'trustorOrgId' is set
        if (trustorOrgId == null)
        {
            throw new ApiException(400, "Missing required parameter 'trustorOrgId' when calling OrganizationAuthorizationApi->GetOrgauthorizationTrustorClonedusers");
        }

        var localVarPath = "/api/v2/orgauthorization/trustors/{trustorOrgId}/clonedusers";
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
        if (trustorOrgId != null)
        {
            localVarPathParams.Add("trustorOrgId", Configuration.ApiClient.ParameterToString(trustorOrgId));
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
            throw new ApiException(localVarStatusCode, "Error calling GetOrgauthorizationTrustorClonedusers: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetOrgauthorizationTrustorClonedusers: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<ClonedUserEntityListing>(localVarStatusCode,
            localVarHeaders,
            (ClonedUserEntityListing)Configuration.ApiClient.Deserialize(localVarResponse, typeof(ClonedUserEntityListing)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// The list of cloned users in the trustor organization (i.e. users with a native user record). 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trustorOrgId">Trustor Organization Id</param>
    /// <returns>Task of ClonedUserEntityListing</returns>

    public async Task<ClonedUserEntityListing> GetOrgauthorizationTrustorClonedusersAsync(string trustorOrgId)
    {
        ApiResponse<ClonedUserEntityListing> localVarResponse = await GetOrgauthorizationTrustorClonedusersAsyncWithHttpInfo(trustorOrgId);
        return localVarResponse.Data;

    }

    /// <summary>
    /// The list of cloned users in the trustor organization (i.e. users with a native user record). 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trustorOrgId">Trustor Organization Id</param>
    /// <returns>Task of ApiResponse (ClonedUserEntityListing)</returns>

    public async Task<ApiResponse<ClonedUserEntityListing>> GetOrgauthorizationTrustorClonedusersAsyncWithHttpInfo(string trustorOrgId)
    {
        // verify the required parameter 'trustorOrgId' is set
        if (trustorOrgId == null)
        {
            throw new ApiException(400, "Missing required parameter 'trustorOrgId' when calling OrganizationAuthorizationApi->GetOrgauthorizationTrustorClonedusers");
        }

        var localVarPath = "/api/v2/orgauthorization/trustors/{trustorOrgId}/clonedusers";
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
        if (trustorOrgId != null)
        {
            localVarPathParams.Add("trustorOrgId", Configuration.ApiClient.ParameterToString(trustorOrgId));
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
            throw new ApiException(localVarStatusCode, "Error calling GetOrgauthorizationTrustorClonedusers: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetOrgauthorizationTrustorClonedusers: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<ClonedUserEntityListing>(localVarStatusCode,
            localVarHeaders,
            (ClonedUserEntityListing)Configuration.ApiClient.Deserialize(localVarResponse, typeof(ClonedUserEntityListing)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Get Trustee Group 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trustorOrgId">Trustor Organization Id</param>
    /// <param name="trustorGroupId">Trustor Group Id</param>
    /// <returns>TrustGroup</returns>

    public TrustGroup GetOrgauthorizationTrustorGroup(string trustorOrgId, string trustorGroupId)
    {
        ApiResponse<TrustGroup> localVarResponse = GetOrgauthorizationTrustorGroupWithHttpInfo(trustorOrgId, trustorGroupId);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get Trustee Group 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trustorOrgId">Trustor Organization Id</param>
    /// <param name="trustorGroupId">Trustor Group Id</param>
    /// <returns>ApiResponse of TrustGroup</returns>

    public ApiResponse<TrustGroup> GetOrgauthorizationTrustorGroupWithHttpInfo(string trustorOrgId, string trustorGroupId)
    {
        // verify the required parameter 'trustorOrgId' is set
        if (trustorOrgId == null)
        {
            throw new ApiException(400, "Missing required parameter 'trustorOrgId' when calling OrganizationAuthorizationApi->GetOrgauthorizationTrustorGroup");
        }
        // verify the required parameter 'trustorGroupId' is set
        if (trustorGroupId == null)
        {
            throw new ApiException(400, "Missing required parameter 'trustorGroupId' when calling OrganizationAuthorizationApi->GetOrgauthorizationTrustorGroup");
        }

        var localVarPath = "/api/v2/orgauthorization/trustors/{trustorOrgId}/groups/{trustorGroupId}";
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
        if (trustorOrgId != null)
        {
            localVarPathParams.Add("trustorOrgId", Configuration.ApiClient.ParameterToString(trustorOrgId));
        }

        if (trustorGroupId != null)
        {
            localVarPathParams.Add("trustorGroupId", Configuration.ApiClient.ParameterToString(trustorGroupId));
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
            throw new ApiException(localVarStatusCode, "Error calling GetOrgauthorizationTrustorGroup: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetOrgauthorizationTrustorGroup: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<TrustGroup>(localVarStatusCode,
            localVarHeaders,
            (TrustGroup)Configuration.ApiClient.Deserialize(localVarResponse, typeof(TrustGroup)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Get Trustee Group 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trustorOrgId">Trustor Organization Id</param>
    /// <param name="trustorGroupId">Trustor Group Id</param>
    /// <returns>Task of TrustGroup</returns>

    public async Task<TrustGroup> GetOrgauthorizationTrustorGroupAsync(string trustorOrgId, string trustorGroupId)
    {
        ApiResponse<TrustGroup> localVarResponse = await GetOrgauthorizationTrustorGroupAsyncWithHttpInfo(trustorOrgId, trustorGroupId);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Get Trustee Group 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trustorOrgId">Trustor Organization Id</param>
    /// <param name="trustorGroupId">Trustor Group Id</param>
    /// <returns>Task of ApiResponse (TrustGroup)</returns>

    public async Task<ApiResponse<TrustGroup>> GetOrgauthorizationTrustorGroupAsyncWithHttpInfo(string trustorOrgId, string trustorGroupId)
    {
        // verify the required parameter 'trustorOrgId' is set
        if (trustorOrgId == null)
        {
            throw new ApiException(400, "Missing required parameter 'trustorOrgId' when calling OrganizationAuthorizationApi->GetOrgauthorizationTrustorGroup");
        }

        // verify the required parameter 'trustorGroupId' is set
        if (trustorGroupId == null)
        {
            throw new ApiException(400, "Missing required parameter 'trustorGroupId' when calling OrganizationAuthorizationApi->GetOrgauthorizationTrustorGroup");
        }

        var localVarPath = "/api/v2/orgauthorization/trustors/{trustorOrgId}/groups/{trustorGroupId}";
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
        if (trustorOrgId != null)
        {
            localVarPathParams.Add("trustorOrgId", Configuration.ApiClient.ParameterToString(trustorOrgId));
        }

        if (trustorGroupId != null)
        {
            localVarPathParams.Add("trustorGroupId", Configuration.ApiClient.ParameterToString(trustorGroupId));
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
            throw new ApiException(localVarStatusCode, "Error calling GetOrgauthorizationTrustorGroup: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetOrgauthorizationTrustorGroup: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<TrustGroup>(localVarStatusCode,
            localVarHeaders,
            (TrustGroup)Configuration.ApiClient.Deserialize(localVarResponse, typeof(TrustGroup)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// The list of groups in the trustor organization (i.e. groups granted access). 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trustorOrgId">Trustee Organization Id</param>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <returns>TrustGroupEntityListing</returns>

    public TrustGroupEntityListing GetOrgauthorizationTrustorGroups(string trustorOrgId, int? pageSize = null, int? pageNumber = null)
    {
        ApiResponse<TrustGroupEntityListing> localVarResponse = GetOrgauthorizationTrustorGroupsWithHttpInfo(trustorOrgId, pageSize, pageNumber);
        return localVarResponse.Data;
    }

    /// <summary>
    /// The list of groups in the trustor organization (i.e. groups granted access). 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trustorOrgId">Trustee Organization Id</param>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <returns>ApiResponse of TrustGroupEntityListing</returns>

    public ApiResponse<TrustGroupEntityListing> GetOrgauthorizationTrustorGroupsWithHttpInfo(string trustorOrgId, int? pageSize = null, int? pageNumber = null)
    {
        // verify the required parameter 'trustorOrgId' is set
        if (trustorOrgId == null)
        {
            throw new ApiException(400, "Missing required parameter 'trustorOrgId' when calling OrganizationAuthorizationApi->GetOrgauthorizationTrustorGroups");
        }

        var localVarPath = "/api/v2/orgauthorization/trustors/{trustorOrgId}/groups";
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
        if (trustorOrgId != null)
        {
            localVarPathParams.Add("trustorOrgId", Configuration.ApiClient.ParameterToString(trustorOrgId));
        }

        // Query params
        if (pageSize != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("pageSize", Configuration.ApiClient.ParameterToString(pageSize)));
        }

        if (pageNumber != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)));
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
            throw new ApiException(localVarStatusCode, "Error calling GetOrgauthorizationTrustorGroups: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetOrgauthorizationTrustorGroups: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<TrustGroupEntityListing>(localVarStatusCode,
            localVarHeaders,
            (TrustGroupEntityListing)Configuration.ApiClient.Deserialize(localVarResponse, typeof(TrustGroupEntityListing)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// The list of groups in the trustor organization (i.e. groups granted access). 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trustorOrgId">Trustee Organization Id</param>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <returns>Task of TrustGroupEntityListing</returns>

    public async Task<TrustGroupEntityListing> GetOrgauthorizationTrustorGroupsAsync(string trustorOrgId, int? pageSize = null, int? pageNumber = null)
    {
        ApiResponse<TrustGroupEntityListing> localVarResponse = await GetOrgauthorizationTrustorGroupsAsyncWithHttpInfo(trustorOrgId, pageSize, pageNumber);
        return localVarResponse.Data;

    }

    /// <summary>
    /// The list of groups in the trustor organization (i.e. groups granted access). 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trustorOrgId">Trustee Organization Id</param>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <returns>Task of ApiResponse (TrustGroupEntityListing)</returns>

    public async Task<ApiResponse<TrustGroupEntityListing>> GetOrgauthorizationTrustorGroupsAsyncWithHttpInfo(string trustorOrgId, int? pageSize = null, int? pageNumber = null)
    {
        // verify the required parameter 'trustorOrgId' is set
        if (trustorOrgId == null)
        {
            throw new ApiException(400, "Missing required parameter 'trustorOrgId' when calling OrganizationAuthorizationApi->GetOrgauthorizationTrustorGroups");
        }

        var localVarPath = "/api/v2/orgauthorization/trustors/{trustorOrgId}/groups";
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
        if (trustorOrgId != null)
        {
            localVarPathParams.Add("trustorOrgId", Configuration.ApiClient.ParameterToString(trustorOrgId));
        }

        // Query params
        if (pageSize != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("pageSize", Configuration.ApiClient.ParameterToString(pageSize)));
        }

        if (pageNumber != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)));
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
            throw new ApiException(localVarStatusCode, "Error calling GetOrgauthorizationTrustorGroups: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetOrgauthorizationTrustorGroups: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<TrustGroupEntityListing>(localVarStatusCode,
            localVarHeaders,
            (TrustGroupEntityListing)Configuration.ApiClient.Deserialize(localVarResponse, typeof(TrustGroupEntityListing)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Get Trustee User 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trustorOrgId">Trustor Organization Id</param>
    /// <param name="trusteeUserId">Trustee User Id</param>
    /// <returns>TrustUser</returns>

    public TrustUser GetOrgauthorizationTrustorUser(string trustorOrgId, string trusteeUserId)
    {
        ApiResponse<TrustUser> localVarResponse = GetOrgauthorizationTrustorUserWithHttpInfo(trustorOrgId, trusteeUserId);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get Trustee User 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trustorOrgId">Trustor Organization Id</param>
    /// <param name="trusteeUserId">Trustee User Id</param>
    /// <returns>ApiResponse of TrustUser</returns>

    public ApiResponse<TrustUser> GetOrgauthorizationTrustorUserWithHttpInfo(string trustorOrgId, string trusteeUserId)
    {
        // verify the required parameter 'trustorOrgId' is set
        if (trustorOrgId == null)
        {
            throw new ApiException(400, "Missing required parameter 'trustorOrgId' when calling OrganizationAuthorizationApi->GetOrgauthorizationTrustorUser");
        }
        // verify the required parameter 'trusteeUserId' is set
        if (trusteeUserId == null)
        {
            throw new ApiException(400, "Missing required parameter 'trusteeUserId' when calling OrganizationAuthorizationApi->GetOrgauthorizationTrustorUser");
        }

        var localVarPath = "/api/v2/orgauthorization/trustors/{trustorOrgId}/users/{trusteeUserId}";
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
        if (trustorOrgId != null)
        {
            localVarPathParams.Add("trustorOrgId", Configuration.ApiClient.ParameterToString(trustorOrgId));
        }

        if (trusteeUserId != null)
        {
            localVarPathParams.Add("trusteeUserId", Configuration.ApiClient.ParameterToString(trusteeUserId));
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
            throw new ApiException(localVarStatusCode, "Error calling GetOrgauthorizationTrustorUser: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetOrgauthorizationTrustorUser: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<TrustUser>(localVarStatusCode,
            localVarHeaders,
            (TrustUser)Configuration.ApiClient.Deserialize(localVarResponse, typeof(TrustUser)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Get Trustee User 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trustorOrgId">Trustor Organization Id</param>
    /// <param name="trusteeUserId">Trustee User Id</param>
    /// <returns>Task of TrustUser</returns>

    public async Task<TrustUser> GetOrgauthorizationTrustorUserAsync(string trustorOrgId, string trusteeUserId)
    {
        ApiResponse<TrustUser> localVarResponse = await GetOrgauthorizationTrustorUserAsyncWithHttpInfo(trustorOrgId, trusteeUserId);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Get Trustee User 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trustorOrgId">Trustor Organization Id</param>
    /// <param name="trusteeUserId">Trustee User Id</param>
    /// <returns>Task of ApiResponse (TrustUser)</returns>

    public async Task<ApiResponse<TrustUser>> GetOrgauthorizationTrustorUserAsyncWithHttpInfo(string trustorOrgId, string trusteeUserId)
    {
        // verify the required parameter 'trustorOrgId' is set
        if (trustorOrgId == null)
        {
            throw new ApiException(400, "Missing required parameter 'trustorOrgId' when calling OrganizationAuthorizationApi->GetOrgauthorizationTrustorUser");
        }

        // verify the required parameter 'trusteeUserId' is set
        if (trusteeUserId == null)
        {
            throw new ApiException(400, "Missing required parameter 'trusteeUserId' when calling OrganizationAuthorizationApi->GetOrgauthorizationTrustorUser");
        }

        var localVarPath = "/api/v2/orgauthorization/trustors/{trustorOrgId}/users/{trusteeUserId}";
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
        if (trustorOrgId != null)
        {
            localVarPathParams.Add("trustorOrgId", Configuration.ApiClient.ParameterToString(trustorOrgId));
        }

        if (trusteeUserId != null)
        {
            localVarPathParams.Add("trusteeUserId", Configuration.ApiClient.ParameterToString(trusteeUserId));
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
            throw new ApiException(localVarStatusCode, "Error calling GetOrgauthorizationTrustorUser: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetOrgauthorizationTrustorUser: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<TrustUser>(localVarStatusCode,
            localVarHeaders,
            (TrustUser)Configuration.ApiClient.Deserialize(localVarResponse, typeof(TrustUser)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// The list of users in the trustor organization (i.e. users granted access). 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trustorOrgId">Trustee Organization Id</param>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <returns>TrustUserEntityListing</returns>

    public TrustUserEntityListing GetOrgauthorizationTrustorUsers(string trustorOrgId, int? pageSize = null, int? pageNumber = null)
    {
        ApiResponse<TrustUserEntityListing> localVarResponse = GetOrgauthorizationTrustorUsersWithHttpInfo(trustorOrgId, pageSize, pageNumber);
        return localVarResponse.Data;
    }

    /// <summary>
    /// The list of users in the trustor organization (i.e. users granted access). 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trustorOrgId">Trustee Organization Id</param>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <returns>ApiResponse of TrustUserEntityListing</returns>

    public ApiResponse<TrustUserEntityListing> GetOrgauthorizationTrustorUsersWithHttpInfo(string trustorOrgId, int? pageSize = null, int? pageNumber = null)
    {
        // verify the required parameter 'trustorOrgId' is set
        if (trustorOrgId == null)
        {
            throw new ApiException(400, "Missing required parameter 'trustorOrgId' when calling OrganizationAuthorizationApi->GetOrgauthorizationTrustorUsers");
        }

        var localVarPath = "/api/v2/orgauthorization/trustors/{trustorOrgId}/users";
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
        if (trustorOrgId != null)
        {
            localVarPathParams.Add("trustorOrgId", Configuration.ApiClient.ParameterToString(trustorOrgId));
        }

        // Query params
        if (pageSize != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("pageSize", Configuration.ApiClient.ParameterToString(pageSize)));
        }

        if (pageNumber != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)));
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
            throw new ApiException(localVarStatusCode, "Error calling GetOrgauthorizationTrustorUsers: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetOrgauthorizationTrustorUsers: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<TrustUserEntityListing>(localVarStatusCode,
            localVarHeaders,
            (TrustUserEntityListing)Configuration.ApiClient.Deserialize(localVarResponse, typeof(TrustUserEntityListing)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// The list of users in the trustor organization (i.e. users granted access). 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trustorOrgId">Trustee Organization Id</param>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <returns>Task of TrustUserEntityListing</returns>

    public async Task<TrustUserEntityListing> GetOrgauthorizationTrustorUsersAsync(string trustorOrgId, int? pageSize = null, int? pageNumber = null)
    {
        ApiResponse<TrustUserEntityListing> localVarResponse = await GetOrgauthorizationTrustorUsersAsyncWithHttpInfo(trustorOrgId, pageSize, pageNumber);
        return localVarResponse.Data;

    }

    /// <summary>
    /// The list of users in the trustor organization (i.e. users granted access). 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trustorOrgId">Trustee Organization Id</param>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <returns>Task of ApiResponse (TrustUserEntityListing)</returns>

    public async Task<ApiResponse<TrustUserEntityListing>> GetOrgauthorizationTrustorUsersAsyncWithHttpInfo(string trustorOrgId, int? pageSize = null, int? pageNumber = null)
    {
        // verify the required parameter 'trustorOrgId' is set
        if (trustorOrgId == null)
        {
            throw new ApiException(400, "Missing required parameter 'trustorOrgId' when calling OrganizationAuthorizationApi->GetOrgauthorizationTrustorUsers");
        }

        var localVarPath = "/api/v2/orgauthorization/trustors/{trustorOrgId}/users";
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
        if (trustorOrgId != null)
        {
            localVarPathParams.Add("trustorOrgId", Configuration.ApiClient.ParameterToString(trustorOrgId));
        }

        // Query params
        if (pageSize != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("pageSize", Configuration.ApiClient.ParameterToString(pageSize)));
        }

        if (pageNumber != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)));
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
            throw new ApiException(localVarStatusCode, "Error calling GetOrgauthorizationTrustorUsers: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetOrgauthorizationTrustorUsers: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<TrustUserEntityListing>(localVarStatusCode,
            localVarHeaders,
            (TrustUserEntityListing)Configuration.ApiClient.Deserialize(localVarResponse, typeof(TrustUserEntityListing)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// The list of organizations that have authorized/trusted your organization. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <returns>TrustorEntityListing</returns>

    public TrustorEntityListing GetOrgauthorizationTrustors(int? pageSize = null, int? pageNumber = null)
    {
        ApiResponse<TrustorEntityListing> localVarResponse = GetOrgauthorizationTrustorsWithHttpInfo(pageSize, pageNumber);
        return localVarResponse.Data;
    }

    /// <summary>
    /// The list of organizations that have authorized/trusted your organization. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <returns>ApiResponse of TrustorEntityListing</returns>

    public ApiResponse<TrustorEntityListing> GetOrgauthorizationTrustorsWithHttpInfo(int? pageSize = null, int? pageNumber = null)
    {

        var localVarPath = "/api/v2/orgauthorization/trustors";
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
            throw new ApiException(localVarStatusCode, "Error calling GetOrgauthorizationTrustors: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetOrgauthorizationTrustors: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<TrustorEntityListing>(localVarStatusCode,
            localVarHeaders,
            (TrustorEntityListing)Configuration.ApiClient.Deserialize(localVarResponse, typeof(TrustorEntityListing)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// The list of organizations that have authorized/trusted your organization. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <returns>Task of TrustorEntityListing</returns>

    public async Task<TrustorEntityListing> GetOrgauthorizationTrustorsAsync(int? pageSize = null, int? pageNumber = null)
    {
        ApiResponse<TrustorEntityListing> localVarResponse = await GetOrgauthorizationTrustorsAsyncWithHttpInfo(pageSize, pageNumber);
        return localVarResponse.Data;

    }

    /// <summary>
    /// The list of organizations that have authorized/trusted your organization. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <returns>Task of ApiResponse (TrustorEntityListing)</returns>

    public async Task<ApiResponse<TrustorEntityListing>> GetOrgauthorizationTrustorsAsyncWithHttpInfo(int? pageSize = null, int? pageNumber = null)
    {

        var localVarPath = "/api/v2/orgauthorization/trustors";
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
            throw new ApiException(localVarStatusCode, "Error calling GetOrgauthorizationTrustors: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetOrgauthorizationTrustors: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<TrustorEntityListing>(localVarStatusCode,
            localVarHeaders,
            (TrustorEntityListing)Configuration.ApiClient.Deserialize(localVarResponse, typeof(TrustorEntityListing)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// A pairing id is created by the trustee and given to the trustor to create a trust. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Pairing Info</param>
    /// <returns>TrustRequest</returns>

    public TrustRequest PostOrgauthorizationPairings(TrustRequestCreate body)
    {
        ApiResponse<TrustRequest> localVarResponse = PostOrgauthorizationPairingsWithHttpInfo(body);
        return localVarResponse.Data;
    }

    /// <summary>
    /// A pairing id is created by the trustee and given to the trustor to create a trust. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Pairing Info</param>
    /// <returns>ApiResponse of TrustRequest</returns>

    public ApiResponse<TrustRequest> PostOrgauthorizationPairingsWithHttpInfo(TrustRequestCreate body)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling OrganizationAuthorizationApi->PostOrgauthorizationPairings");
        }

        var localVarPath = "/api/v2/orgauthorization/pairings";
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
            throw new ApiException(localVarStatusCode, "Error calling PostOrgauthorizationPairings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostOrgauthorizationPairings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<TrustRequest>(localVarStatusCode,
            localVarHeaders,
            (TrustRequest)Configuration.ApiClient.Deserialize(localVarResponse, typeof(TrustRequest)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// A pairing id is created by the trustee and given to the trustor to create a trust. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Pairing Info</param>
    /// <returns>Task of TrustRequest</returns>

    public async Task<TrustRequest> PostOrgauthorizationPairingsAsync(TrustRequestCreate body)
    {
        ApiResponse<TrustRequest> localVarResponse = await PostOrgauthorizationPairingsAsyncWithHttpInfo(body);
        return localVarResponse.Data;

    }

    /// <summary>
    /// A pairing id is created by the trustee and given to the trustor to create a trust. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Pairing Info</param>
    /// <returns>Task of ApiResponse (TrustRequest)</returns>

    public async Task<ApiResponse<TrustRequest>> PostOrgauthorizationPairingsAsyncWithHttpInfo(TrustRequestCreate body)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling OrganizationAuthorizationApi->PostOrgauthorizationPairings");
        }

        var localVarPath = "/api/v2/orgauthorization/pairings";
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
            throw new ApiException(localVarStatusCode, "Error calling PostOrgauthorizationPairings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostOrgauthorizationPairings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<TrustRequest>(localVarStatusCode,
            localVarHeaders,
            (TrustRequest)Configuration.ApiClient.Deserialize(localVarResponse, typeof(TrustRequest)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Add a group to the trust. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="body">Trust</param>
    /// <returns>TrustGroup</returns>

    public TrustGroup PostOrgauthorizationTrusteeGroups(string trusteeOrgId, TrustMemberCreate body)
    {
        ApiResponse<TrustGroup> localVarResponse = PostOrgauthorizationTrusteeGroupsWithHttpInfo(trusteeOrgId, body);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Add a group to the trust. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="body">Trust</param>
    /// <returns>ApiResponse of TrustGroup</returns>

    public ApiResponse<TrustGroup> PostOrgauthorizationTrusteeGroupsWithHttpInfo(string trusteeOrgId, TrustMemberCreate body)
    {
        // verify the required parameter 'trusteeOrgId' is set
        if (trusteeOrgId == null)
        {
            throw new ApiException(400, "Missing required parameter 'trusteeOrgId' when calling OrganizationAuthorizationApi->PostOrgauthorizationTrusteeGroups");
        }
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling OrganizationAuthorizationApi->PostOrgauthorizationTrusteeGroups");
        }

        var localVarPath = "/api/v2/orgauthorization/trustees/{trusteeOrgId}/groups";
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
        if (trusteeOrgId != null)
        {
            localVarPathParams.Add("trusteeOrgId", Configuration.ApiClient.ParameterToString(trusteeOrgId));
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
            throw new ApiException(localVarStatusCode, "Error calling PostOrgauthorizationTrusteeGroups: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostOrgauthorizationTrusteeGroups: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<TrustGroup>(localVarStatusCode,
            localVarHeaders,
            (TrustGroup)Configuration.ApiClient.Deserialize(localVarResponse, typeof(TrustGroup)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Add a group to the trust. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="body">Trust</param>
    /// <returns>Task of TrustGroup</returns>

    public async Task<TrustGroup> PostOrgauthorizationTrusteeGroupsAsync(string trusteeOrgId, TrustMemberCreate body)
    {
        ApiResponse<TrustGroup> localVarResponse = await PostOrgauthorizationTrusteeGroupsAsyncWithHttpInfo(trusteeOrgId, body);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Add a group to the trust. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="body">Trust</param>
    /// <returns>Task of ApiResponse (TrustGroup)</returns>

    public async Task<ApiResponse<TrustGroup>> PostOrgauthorizationTrusteeGroupsAsyncWithHttpInfo(string trusteeOrgId, TrustMemberCreate body)
    {
        // verify the required parameter 'trusteeOrgId' is set
        if (trusteeOrgId == null)
        {
            throw new ApiException(400, "Missing required parameter 'trusteeOrgId' when calling OrganizationAuthorizationApi->PostOrgauthorizationTrusteeGroups");
        }

        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling OrganizationAuthorizationApi->PostOrgauthorizationTrusteeGroups");
        }

        var localVarPath = "/api/v2/orgauthorization/trustees/{trusteeOrgId}/groups";
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
        if (trusteeOrgId != null)
        {
            localVarPathParams.Add("trusteeOrgId", Configuration.ApiClient.ParameterToString(trusteeOrgId));
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
            throw new ApiException(localVarStatusCode, "Error calling PostOrgauthorizationTrusteeGroups: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostOrgauthorizationTrusteeGroups: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<TrustGroup>(localVarStatusCode,
            localVarHeaders,
            (TrustGroup)Configuration.ApiClient.Deserialize(localVarResponse, typeof(TrustGroup)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Add a user to the trust. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="body">Trust</param>
    /// <returns>TrustUser</returns>

    public TrustUser PostOrgauthorizationTrusteeUsers(string trusteeOrgId, TrustMemberCreate body)
    {
        ApiResponse<TrustUser> localVarResponse = PostOrgauthorizationTrusteeUsersWithHttpInfo(trusteeOrgId, body);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Add a user to the trust. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="body">Trust</param>
    /// <returns>ApiResponse of TrustUser</returns>

    public ApiResponse<TrustUser> PostOrgauthorizationTrusteeUsersWithHttpInfo(string trusteeOrgId, TrustMemberCreate body)
    {
        // verify the required parameter 'trusteeOrgId' is set
        if (trusteeOrgId == null)
        {
            throw new ApiException(400, "Missing required parameter 'trusteeOrgId' when calling OrganizationAuthorizationApi->PostOrgauthorizationTrusteeUsers");
        }
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling OrganizationAuthorizationApi->PostOrgauthorizationTrusteeUsers");
        }

        var localVarPath = "/api/v2/orgauthorization/trustees/{trusteeOrgId}/users";
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
        if (trusteeOrgId != null)
        {
            localVarPathParams.Add("trusteeOrgId", Configuration.ApiClient.ParameterToString(trusteeOrgId));
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
            throw new ApiException(localVarStatusCode, "Error calling PostOrgauthorizationTrusteeUsers: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostOrgauthorizationTrusteeUsers: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<TrustUser>(localVarStatusCode,
            localVarHeaders,
            (TrustUser)Configuration.ApiClient.Deserialize(localVarResponse, typeof(TrustUser)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Add a user to the trust. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="body">Trust</param>
    /// <returns>Task of TrustUser</returns>

    public async Task<TrustUser> PostOrgauthorizationTrusteeUsersAsync(string trusteeOrgId, TrustMemberCreate body)
    {
        ApiResponse<TrustUser> localVarResponse = await PostOrgauthorizationTrusteeUsersAsyncWithHttpInfo(trusteeOrgId, body);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Add a user to the trust. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="body">Trust</param>
    /// <returns>Task of ApiResponse (TrustUser)</returns>

    public async Task<ApiResponse<TrustUser>> PostOrgauthorizationTrusteeUsersAsyncWithHttpInfo(string trusteeOrgId, TrustMemberCreate body)
    {
        // verify the required parameter 'trusteeOrgId' is set
        if (trusteeOrgId == null)
        {
            throw new ApiException(400, "Missing required parameter 'trusteeOrgId' when calling OrganizationAuthorizationApi->PostOrgauthorizationTrusteeUsers");
        }

        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling OrganizationAuthorizationApi->PostOrgauthorizationTrusteeUsers");
        }

        var localVarPath = "/api/v2/orgauthorization/trustees/{trusteeOrgId}/users";
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
        if (trusteeOrgId != null)
        {
            localVarPathParams.Add("trusteeOrgId", Configuration.ApiClient.ParameterToString(trusteeOrgId));
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
            throw new ApiException(localVarStatusCode, "Error calling PostOrgauthorizationTrusteeUsers: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostOrgauthorizationTrusteeUsers: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<TrustUser>(localVarStatusCode,
            localVarHeaders,
            (TrustUser)Configuration.ApiClient.Deserialize(localVarResponse, typeof(TrustUser)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Create a new organization authorization trust. This is required to grant other organizations access to your organization. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Trust</param>
    /// <returns>Trustee</returns>

    public Trustee PostOrgauthorizationTrustees(TrustCreate body)
    {
        ApiResponse<Trustee> localVarResponse = PostOrgauthorizationTrusteesWithHttpInfo(body);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Create a new organization authorization trust. This is required to grant other organizations access to your organization. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Trust</param>
    /// <returns>ApiResponse of Trustee</returns>

    public ApiResponse<Trustee> PostOrgauthorizationTrusteesWithHttpInfo(TrustCreate body)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling OrganizationAuthorizationApi->PostOrgauthorizationTrustees");
        }

        var localVarPath = "/api/v2/orgauthorization/trustees";
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
            throw new ApiException(localVarStatusCode, "Error calling PostOrgauthorizationTrustees: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostOrgauthorizationTrustees: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<Trustee>(localVarStatusCode,
            localVarHeaders,
            (Trustee)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Trustee)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Create a new organization authorization trust. This is required to grant other organizations access to your organization. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Trust</param>
    /// <returns>Task of Trustee</returns>

    public async Task<Trustee> PostOrgauthorizationTrusteesAsync(TrustCreate body)
    {
        ApiResponse<Trustee> localVarResponse = await PostOrgauthorizationTrusteesAsyncWithHttpInfo(body);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Create a new organization authorization trust. This is required to grant other organizations access to your organization. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Trust</param>
    /// <returns>Task of ApiResponse (Trustee)</returns>

    public async Task<ApiResponse<Trustee>> PostOrgauthorizationTrusteesAsyncWithHttpInfo(TrustCreate body)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling OrganizationAuthorizationApi->PostOrgauthorizationTrustees");
        }

        var localVarPath = "/api/v2/orgauthorization/trustees";
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
            throw new ApiException(localVarStatusCode, "Error calling PostOrgauthorizationTrustees: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostOrgauthorizationTrustees: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<Trustee>(localVarStatusCode,
            localVarHeaders,
            (Trustee)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Trustee)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Get Org Trustee Audits 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Values to scope the request.</param>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <param name="sortBy">Sort by (optional, default to "timestamp")</param>
    /// <param name="sortOrder">Sort order (optional, default to "descending")</param>
    /// <returns>Object</returns>

    public object PostOrgauthorizationTrusteesAudits(TrusteeAuditQueryRequest body, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null)
    {
        ApiResponse<object> localVarResponse = PostOrgauthorizationTrusteesAuditsWithHttpInfo(body, pageSize, pageNumber, sortBy, sortOrder);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get Org Trustee Audits 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Values to scope the request.</param>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <param name="sortBy">Sort by (optional, default to "timestamp")</param>
    /// <param name="sortOrder">Sort order (optional, default to "descending")</param>
    /// <returns>ApiResponse of Object</returns>

    public ApiResponse<object> PostOrgauthorizationTrusteesAuditsWithHttpInfo(TrusteeAuditQueryRequest body, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling OrganizationAuthorizationApi->PostOrgauthorizationTrusteesAudits");
        }

        var localVarPath = "/api/v2/orgauthorization/trustees/audits";
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

        if (sortBy != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("sortBy", Configuration.ApiClient.ParameterToString(sortBy)));
        }

        if (sortOrder != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)));
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
            throw new ApiException(localVarStatusCode, "Error calling PostOrgauthorizationTrusteesAudits: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostOrgauthorizationTrusteesAudits: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<object>(localVarStatusCode,
            localVarHeaders,
            (object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(object)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Get Org Trustee Audits 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Values to scope the request.</param>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <param name="sortBy">Sort by (optional, default to "timestamp")</param>
    /// <param name="sortOrder">Sort order (optional, default to "descending")</param>
    /// <returns>Task of Object</returns>

    public async Task<object> PostOrgauthorizationTrusteesAuditsAsync(TrusteeAuditQueryRequest body, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null)
    {
        ApiResponse<object> localVarResponse = await PostOrgauthorizationTrusteesAuditsAsyncWithHttpInfo(body, pageSize, pageNumber, sortBy, sortOrder);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Get Org Trustee Audits 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Values to scope the request.</param>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <param name="sortBy">Sort by (optional, default to "timestamp")</param>
    /// <param name="sortOrder">Sort order (optional, default to "descending")</param>
    /// <returns>Task of ApiResponse (Object)</returns>

    public async Task<ApiResponse<object>> PostOrgauthorizationTrusteesAuditsAsyncWithHttpInfo(TrusteeAuditQueryRequest body, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling OrganizationAuthorizationApi->PostOrgauthorizationTrusteesAudits");
        }

        var localVarPath = "/api/v2/orgauthorization/trustees/audits";
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

        if (sortBy != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("sortBy", Configuration.ApiClient.ParameterToString(sortBy)));
        }

        if (sortOrder != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)));
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
            throw new ApiException(localVarStatusCode, "Error calling PostOrgauthorizationTrusteesAudits: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostOrgauthorizationTrusteesAudits: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<object>(localVarStatusCode,
            localVarHeaders,
            (object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(object)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Create a new organization authorization trust with Customer Care. This is required to grant your regional Customer Care organization access to your organization. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="assignDefaultRole">Assign Admin role to default pairing with Customer Care (optional)</param>
    /// <param name="autoExpire">Automatically expire pairing after 30 days (optional)</param>
    /// <param name="assignFullAccess">Grant Customer Care full access to the organization (optional)</param>
    /// <param name="allowTrustedUserAccess">Make Customer Care a Trusted User (optional)</param>
    /// <returns>TrustEntityListing</returns>

    public TrustEntityListing PostOrgauthorizationTrusteesCare(bool? assignDefaultRole = null, bool? autoExpire = null, bool? assignFullAccess = null, bool? allowTrustedUserAccess = null)
    {
        ApiResponse<TrustEntityListing> localVarResponse = PostOrgauthorizationTrusteesCareWithHttpInfo(assignDefaultRole, autoExpire, assignFullAccess, allowTrustedUserAccess);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Create a new organization authorization trust with Customer Care. This is required to grant your regional Customer Care organization access to your organization. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="assignDefaultRole">Assign Admin role to default pairing with Customer Care (optional)</param>
    /// <param name="autoExpire">Automatically expire pairing after 30 days (optional)</param>
    /// <param name="assignFullAccess">Grant Customer Care full access to the organization (optional)</param>
    /// <param name="allowTrustedUserAccess">Make Customer Care a Trusted User (optional)</param>
    /// <returns>ApiResponse of TrustEntityListing</returns>

    public ApiResponse<TrustEntityListing> PostOrgauthorizationTrusteesCareWithHttpInfo(bool? assignDefaultRole = null, bool? autoExpire = null, bool? assignFullAccess = null, bool? allowTrustedUserAccess = null)
    {

        var localVarPath = "/api/v2/orgauthorization/trustees/care";
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
        if (assignDefaultRole != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("assignDefaultRole", Configuration.ApiClient.ParameterToString(assignDefaultRole)));
        }

        if (autoExpire != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("autoExpire", Configuration.ApiClient.ParameterToString(autoExpire)));
        }

        if (assignFullAccess != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("assignFullAccess", Configuration.ApiClient.ParameterToString(assignFullAccess)));
        }

        if (allowTrustedUserAccess != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("allowTrustedUserAccess", Configuration.ApiClient.ParameterToString(allowTrustedUserAccess)));
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
            throw new ApiException(localVarStatusCode, "Error calling PostOrgauthorizationTrusteesCare: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostOrgauthorizationTrusteesCare: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<TrustEntityListing>(localVarStatusCode,
            localVarHeaders,
            (TrustEntityListing)Configuration.ApiClient.Deserialize(localVarResponse, typeof(TrustEntityListing)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Create a new organization authorization trust with Customer Care. This is required to grant your regional Customer Care organization access to your organization. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="assignDefaultRole">Assign Admin role to default pairing with Customer Care (optional)</param>
    /// <param name="autoExpire">Automatically expire pairing after 30 days (optional)</param>
    /// <param name="assignFullAccess">Grant Customer Care full access to the organization (optional)</param>
    /// <param name="allowTrustedUserAccess">Make Customer Care a Trusted User (optional)</param>
    /// <returns>Task of TrustEntityListing</returns>

    public async Task<TrustEntityListing> PostOrgauthorizationTrusteesCareAsync(bool? assignDefaultRole = null, bool? autoExpire = null, bool? assignFullAccess = null, bool? allowTrustedUserAccess = null)
    {
        ApiResponse<TrustEntityListing> localVarResponse = await PostOrgauthorizationTrusteesCareAsyncWithHttpInfo(assignDefaultRole, autoExpire, assignFullAccess, allowTrustedUserAccess);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Create a new organization authorization trust with Customer Care. This is required to grant your regional Customer Care organization access to your organization. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="assignDefaultRole">Assign Admin role to default pairing with Customer Care (optional)</param>
    /// <param name="autoExpire">Automatically expire pairing after 30 days (optional)</param>
    /// <param name="assignFullAccess">Grant Customer Care full access to the organization (optional)</param>
    /// <param name="allowTrustedUserAccess">Make Customer Care a Trusted User (optional)</param>
    /// <returns>Task of ApiResponse (TrustEntityListing)</returns>

    public async Task<ApiResponse<TrustEntityListing>> PostOrgauthorizationTrusteesCareAsyncWithHttpInfo(bool? assignDefaultRole = null, bool? autoExpire = null, bool? assignFullAccess = null, bool? allowTrustedUserAccess = null)
    {

        var localVarPath = "/api/v2/orgauthorization/trustees/care";
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
        if (assignDefaultRole != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("assignDefaultRole", Configuration.ApiClient.ParameterToString(assignDefaultRole)));
        }

        if (autoExpire != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("autoExpire", Configuration.ApiClient.ParameterToString(autoExpire)));
        }

        if (assignFullAccess != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("assignFullAccess", Configuration.ApiClient.ParameterToString(assignFullAccess)));
        }

        if (allowTrustedUserAccess != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("allowTrustedUserAccess", Configuration.ApiClient.ParameterToString(allowTrustedUserAccess)));
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
            throw new ApiException(localVarStatusCode, "Error calling PostOrgauthorizationTrusteesCare: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostOrgauthorizationTrusteesCare: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<TrustEntityListing>(localVarStatusCode,
            localVarHeaders,
            (TrustEntityListing)Configuration.ApiClient.Deserialize(localVarResponse, typeof(TrustEntityListing)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Create a new organization authorization trust with Customer Care. This is required to grant your regional Customer Care organization access to your organization. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="assignDefaultRole">Assign Admin role to default pairing with Customer Care (optional)</param>
    /// <param name="autoExpire">Automatically expire pairing after 30 days (optional)</param>
    /// <returns>Trustee</returns>

    public Trustee PostOrgauthorizationTrusteesDefault(bool? assignDefaultRole = null, bool? autoExpire = null)
    {
        ApiResponse<Trustee> localVarResponse = PostOrgauthorizationTrusteesDefaultWithHttpInfo(assignDefaultRole, autoExpire);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Create a new organization authorization trust with Customer Care. This is required to grant your regional Customer Care organization access to your organization. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="assignDefaultRole">Assign Admin role to default pairing with Customer Care (optional)</param>
    /// <param name="autoExpire">Automatically expire pairing after 30 days (optional)</param>
    /// <returns>ApiResponse of Trustee</returns>

    public ApiResponse<Trustee> PostOrgauthorizationTrusteesDefaultWithHttpInfo(bool? assignDefaultRole = null, bool? autoExpire = null)
    {

        var localVarPath = "/api/v2/orgauthorization/trustees/default";
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
        if (assignDefaultRole != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("assignDefaultRole", Configuration.ApiClient.ParameterToString(assignDefaultRole)));
        }

        if (autoExpire != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("autoExpire", Configuration.ApiClient.ParameterToString(autoExpire)));
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
            throw new ApiException(localVarStatusCode, "Error calling PostOrgauthorizationTrusteesDefault: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostOrgauthorizationTrusteesDefault: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<Trustee>(localVarStatusCode,
            localVarHeaders,
            (Trustee)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Trustee)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Create a new organization authorization trust with Customer Care. This is required to grant your regional Customer Care organization access to your organization. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="assignDefaultRole">Assign Admin role to default pairing with Customer Care (optional)</param>
    /// <param name="autoExpire">Automatically expire pairing after 30 days (optional)</param>
    /// <returns>Task of Trustee</returns>

    public async Task<Trustee> PostOrgauthorizationTrusteesDefaultAsync(bool? assignDefaultRole = null, bool? autoExpire = null)
    {
        ApiResponse<Trustee> localVarResponse = await PostOrgauthorizationTrusteesDefaultAsyncWithHttpInfo(assignDefaultRole, autoExpire);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Create a new organization authorization trust with Customer Care. This is required to grant your regional Customer Care organization access to your organization. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="assignDefaultRole">Assign Admin role to default pairing with Customer Care (optional)</param>
    /// <param name="autoExpire">Automatically expire pairing after 30 days (optional)</param>
    /// <returns>Task of ApiResponse (Trustee)</returns>

    public async Task<ApiResponse<Trustee>> PostOrgauthorizationTrusteesDefaultAsyncWithHttpInfo(bool? assignDefaultRole = null, bool? autoExpire = null)
    {

        var localVarPath = "/api/v2/orgauthorization/trustees/default";
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
        if (assignDefaultRole != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("assignDefaultRole", Configuration.ApiClient.ParameterToString(assignDefaultRole)));
        }

        if (autoExpire != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("autoExpire", Configuration.ApiClient.ParameterToString(autoExpire)));
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
            throw new ApiException(localVarStatusCode, "Error calling PostOrgauthorizationTrusteesDefault: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostOrgauthorizationTrusteesDefault: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<Trustee>(localVarStatusCode,
            localVarHeaders,
            (Trustee)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Trustee)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Get Org Trustor Audits 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Values to scope the request.</param>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <param name="sortBy">Sort by (optional, default to "timestamp")</param>
    /// <param name="sortOrder">Sort order (optional, default to "descending")</param>
    /// <returns>Object</returns>

    public object PostOrgauthorizationTrustorAudits(TrustorAuditQueryRequest body, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null)
    {
        ApiResponse<object> localVarResponse = PostOrgauthorizationTrustorAuditsWithHttpInfo(body, pageSize, pageNumber, sortBy, sortOrder);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get Org Trustor Audits 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Values to scope the request.</param>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <param name="sortBy">Sort by (optional, default to "timestamp")</param>
    /// <param name="sortOrder">Sort order (optional, default to "descending")</param>
    /// <returns>ApiResponse of Object</returns>

    public ApiResponse<object> PostOrgauthorizationTrustorAuditsWithHttpInfo(TrustorAuditQueryRequest body, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling OrganizationAuthorizationApi->PostOrgauthorizationTrustorAudits");
        }

        var localVarPath = "/api/v2/orgauthorization/trustor/audits";
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

        if (sortBy != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("sortBy", Configuration.ApiClient.ParameterToString(sortBy)));
        }

        if (sortOrder != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)));
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
            throw new ApiException(localVarStatusCode, "Error calling PostOrgauthorizationTrustorAudits: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostOrgauthorizationTrustorAudits: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<object>(localVarStatusCode,
            localVarHeaders,
            (object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(object)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Get Org Trustor Audits 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Values to scope the request.</param>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <param name="sortBy">Sort by (optional, default to "timestamp")</param>
    /// <param name="sortOrder">Sort order (optional, default to "descending")</param>
    /// <returns>Task of Object</returns>

    public async Task<object> PostOrgauthorizationTrustorAuditsAsync(TrustorAuditQueryRequest body, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null)
    {
        ApiResponse<object> localVarResponse = await PostOrgauthorizationTrustorAuditsAsyncWithHttpInfo(body, pageSize, pageNumber, sortBy, sortOrder);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Get Org Trustor Audits 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Values to scope the request.</param>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <param name="sortBy">Sort by (optional, default to "timestamp")</param>
    /// <param name="sortOrder">Sort order (optional, default to "descending")</param>
    /// <returns>Task of ApiResponse (Object)</returns>

    public async Task<ApiResponse<object>> PostOrgauthorizationTrustorAuditsAsyncWithHttpInfo(TrustorAuditQueryRequest body, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling OrganizationAuthorizationApi->PostOrgauthorizationTrustorAudits");
        }

        var localVarPath = "/api/v2/orgauthorization/trustor/audits";
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

        if (sortBy != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("sortBy", Configuration.ApiClient.ParameterToString(sortBy)));
        }

        if (sortOrder != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)));
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
            throw new ApiException(localVarStatusCode, "Error calling PostOrgauthorizationTrustorAudits: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostOrgauthorizationTrustorAudits: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<object>(localVarStatusCode,
            localVarHeaders,
            (object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(object)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Update Org Trust 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="body">Client</param>
    /// <returns>Trustee</returns>

    public Trustee PutOrgauthorizationTrustee(string trusteeOrgId, TrustUpdate body)
    {
        ApiResponse<Trustee> localVarResponse = PutOrgauthorizationTrusteeWithHttpInfo(trusteeOrgId, body);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Update Org Trust 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="body">Client</param>
    /// <returns>ApiResponse of Trustee</returns>

    public ApiResponse<Trustee> PutOrgauthorizationTrusteeWithHttpInfo(string trusteeOrgId, TrustUpdate body)
    {
        // verify the required parameter 'trusteeOrgId' is set
        if (trusteeOrgId == null)
        {
            throw new ApiException(400, "Missing required parameter 'trusteeOrgId' when calling OrganizationAuthorizationApi->PutOrgauthorizationTrustee");
        }
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling OrganizationAuthorizationApi->PutOrgauthorizationTrustee");
        }

        var localVarPath = "/api/v2/orgauthorization/trustees/{trusteeOrgId}";
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
        if (trusteeOrgId != null)
        {
            localVarPathParams.Add("trusteeOrgId", Configuration.ApiClient.ParameterToString(trusteeOrgId));
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
            throw new ApiException(localVarStatusCode, "Error calling PutOrgauthorizationTrustee: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PutOrgauthorizationTrustee: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<Trustee>(localVarStatusCode,
            localVarHeaders,
            (Trustee)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Trustee)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Update Org Trust 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="body">Client</param>
    /// <returns>Task of Trustee</returns>

    public async Task<Trustee> PutOrgauthorizationTrusteeAsync(string trusteeOrgId, TrustUpdate body)
    {
        ApiResponse<Trustee> localVarResponse = await PutOrgauthorizationTrusteeAsyncWithHttpInfo(trusteeOrgId, body);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Update Org Trust 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="body">Client</param>
    /// <returns>Task of ApiResponse (Trustee)</returns>

    public async Task<ApiResponse<Trustee>> PutOrgauthorizationTrusteeAsyncWithHttpInfo(string trusteeOrgId, TrustUpdate body)
    {
        // verify the required parameter 'trusteeOrgId' is set
        if (trusteeOrgId == null)
        {
            throw new ApiException(400, "Missing required parameter 'trusteeOrgId' when calling OrganizationAuthorizationApi->PutOrgauthorizationTrustee");
        }

        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling OrganizationAuthorizationApi->PutOrgauthorizationTrustee");
        }

        var localVarPath = "/api/v2/orgauthorization/trustees/{trusteeOrgId}";
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
        if (trusteeOrgId != null)
        {
            localVarPathParams.Add("trusteeOrgId", Configuration.ApiClient.ParameterToString(trusteeOrgId));
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
            throw new ApiException(localVarStatusCode, "Error calling PutOrgauthorizationTrustee: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PutOrgauthorizationTrustee: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<Trustee>(localVarStatusCode,
            localVarHeaders,
            (Trustee)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Trustee)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Update Trustee Group Roles 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="trusteeGroupId">Trustee Group Id</param>
    /// <param name="body">Set of roles with corresponding divisions to apply</param>
    /// <returns>UserAuthorization</returns>

    public UserAuthorization PutOrgauthorizationTrusteeGroupRoledivisions(string trusteeOrgId, string trusteeGroupId, RoleDivisionGrants body)
    {
        ApiResponse<UserAuthorization> localVarResponse = PutOrgauthorizationTrusteeGroupRoledivisionsWithHttpInfo(trusteeOrgId, trusteeGroupId, body);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Update Trustee Group Roles 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="trusteeGroupId">Trustee Group Id</param>
    /// <param name="body">Set of roles with corresponding divisions to apply</param>
    /// <returns>ApiResponse of UserAuthorization</returns>

    public ApiResponse<UserAuthorization> PutOrgauthorizationTrusteeGroupRoledivisionsWithHttpInfo(string trusteeOrgId, string trusteeGroupId, RoleDivisionGrants body)
    {
        // verify the required parameter 'trusteeOrgId' is set
        if (trusteeOrgId == null)
        {
            throw new ApiException(400, "Missing required parameter 'trusteeOrgId' when calling OrganizationAuthorizationApi->PutOrgauthorizationTrusteeGroupRoledivisions");
        }
        // verify the required parameter 'trusteeGroupId' is set
        if (trusteeGroupId == null)
        {
            throw new ApiException(400, "Missing required parameter 'trusteeGroupId' when calling OrganizationAuthorizationApi->PutOrgauthorizationTrusteeGroupRoledivisions");
        }
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling OrganizationAuthorizationApi->PutOrgauthorizationTrusteeGroupRoledivisions");
        }

        var localVarPath = "/api/v2/orgauthorization/trustees/{trusteeOrgId}/groups/{trusteeGroupId}/roledivisions";
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
        if (trusteeOrgId != null)
        {
            localVarPathParams.Add("trusteeOrgId", Configuration.ApiClient.ParameterToString(trusteeOrgId));
        }

        if (trusteeGroupId != null)
        {
            localVarPathParams.Add("trusteeGroupId", Configuration.ApiClient.ParameterToString(trusteeGroupId));
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
            throw new ApiException(localVarStatusCode, "Error calling PutOrgauthorizationTrusteeGroupRoledivisions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PutOrgauthorizationTrusteeGroupRoledivisions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<UserAuthorization>(localVarStatusCode,
            localVarHeaders,
            (UserAuthorization)Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserAuthorization)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Update Trustee Group Roles 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="trusteeGroupId">Trustee Group Id</param>
    /// <param name="body">Set of roles with corresponding divisions to apply</param>
    /// <returns>Task of UserAuthorization</returns>

    public async Task<UserAuthorization> PutOrgauthorizationTrusteeGroupRoledivisionsAsync(string trusteeOrgId, string trusteeGroupId, RoleDivisionGrants body)
    {
        ApiResponse<UserAuthorization> localVarResponse = await PutOrgauthorizationTrusteeGroupRoledivisionsAsyncWithHttpInfo(trusteeOrgId, trusteeGroupId, body);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Update Trustee Group Roles 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="trusteeGroupId">Trustee Group Id</param>
    /// <param name="body">Set of roles with corresponding divisions to apply</param>
    /// <returns>Task of ApiResponse (UserAuthorization)</returns>

    public async Task<ApiResponse<UserAuthorization>> PutOrgauthorizationTrusteeGroupRoledivisionsAsyncWithHttpInfo(string trusteeOrgId, string trusteeGroupId, RoleDivisionGrants body)
    {
        // verify the required parameter 'trusteeOrgId' is set
        if (trusteeOrgId == null)
        {
            throw new ApiException(400, "Missing required parameter 'trusteeOrgId' when calling OrganizationAuthorizationApi->PutOrgauthorizationTrusteeGroupRoledivisions");
        }

        // verify the required parameter 'trusteeGroupId' is set
        if (trusteeGroupId == null)
        {
            throw new ApiException(400, "Missing required parameter 'trusteeGroupId' when calling OrganizationAuthorizationApi->PutOrgauthorizationTrusteeGroupRoledivisions");
        }

        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling OrganizationAuthorizationApi->PutOrgauthorizationTrusteeGroupRoledivisions");
        }

        var localVarPath = "/api/v2/orgauthorization/trustees/{trusteeOrgId}/groups/{trusteeGroupId}/roledivisions";
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
        if (trusteeOrgId != null)
        {
            localVarPathParams.Add("trusteeOrgId", Configuration.ApiClient.ParameterToString(trusteeOrgId));
        }

        if (trusteeGroupId != null)
        {
            localVarPathParams.Add("trusteeGroupId", Configuration.ApiClient.ParameterToString(trusteeGroupId));
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
            throw new ApiException(localVarStatusCode, "Error calling PutOrgauthorizationTrusteeGroupRoledivisions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PutOrgauthorizationTrusteeGroupRoledivisions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<UserAuthorization>(localVarStatusCode,
            localVarHeaders,
            (UserAuthorization)Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserAuthorization)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Update Trustee Group Roles 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="trusteeGroupId">Trustee Group Id</param>
    /// <param name="body">List of roles</param>
    /// <returns>UserAuthorization</returns>

    public UserAuthorization PutOrgauthorizationTrusteeGroupRoles(string trusteeOrgId, string trusteeGroupId, List<string> body)
    {
        ApiResponse<UserAuthorization> localVarResponse = PutOrgauthorizationTrusteeGroupRolesWithHttpInfo(trusteeOrgId, trusteeGroupId, body);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Update Trustee Group Roles 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="trusteeGroupId">Trustee Group Id</param>
    /// <param name="body">List of roles</param>
    /// <returns>ApiResponse of UserAuthorization</returns>

    public ApiResponse<UserAuthorization> PutOrgauthorizationTrusteeGroupRolesWithHttpInfo(string trusteeOrgId, string trusteeGroupId, List<string> body)
    {
        // verify the required parameter 'trusteeOrgId' is set
        if (trusteeOrgId == null)
        {
            throw new ApiException(400, "Missing required parameter 'trusteeOrgId' when calling OrganizationAuthorizationApi->PutOrgauthorizationTrusteeGroupRoles");
        }
        // verify the required parameter 'trusteeGroupId' is set
        if (trusteeGroupId == null)
        {
            throw new ApiException(400, "Missing required parameter 'trusteeGroupId' when calling OrganizationAuthorizationApi->PutOrgauthorizationTrusteeGroupRoles");
        }
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling OrganizationAuthorizationApi->PutOrgauthorizationTrusteeGroupRoles");
        }

        var localVarPath = "/api/v2/orgauthorization/trustees/{trusteeOrgId}/groups/{trusteeGroupId}/roles";
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
        if (trusteeOrgId != null)
        {
            localVarPathParams.Add("trusteeOrgId", Configuration.ApiClient.ParameterToString(trusteeOrgId));
        }

        if (trusteeGroupId != null)
        {
            localVarPathParams.Add("trusteeGroupId", Configuration.ApiClient.ParameterToString(trusteeGroupId));
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
            throw new ApiException(localVarStatusCode, "Error calling PutOrgauthorizationTrusteeGroupRoles: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PutOrgauthorizationTrusteeGroupRoles: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<UserAuthorization>(localVarStatusCode,
            localVarHeaders,
            (UserAuthorization)Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserAuthorization)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Update Trustee Group Roles 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="trusteeGroupId">Trustee Group Id</param>
    /// <param name="body">List of roles</param>
    /// <returns>Task of UserAuthorization</returns>

    public async Task<UserAuthorization> PutOrgauthorizationTrusteeGroupRolesAsync(string trusteeOrgId, string trusteeGroupId, List<string> body)
    {
        ApiResponse<UserAuthorization> localVarResponse = await PutOrgauthorizationTrusteeGroupRolesAsyncWithHttpInfo(trusteeOrgId, trusteeGroupId, body);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Update Trustee Group Roles 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="trusteeGroupId">Trustee Group Id</param>
    /// <param name="body">List of roles</param>
    /// <returns>Task of ApiResponse (UserAuthorization)</returns>

    public async Task<ApiResponse<UserAuthorization>> PutOrgauthorizationTrusteeGroupRolesAsyncWithHttpInfo(string trusteeOrgId, string trusteeGroupId, List<string> body)
    {
        // verify the required parameter 'trusteeOrgId' is set
        if (trusteeOrgId == null)
        {
            throw new ApiException(400, "Missing required parameter 'trusteeOrgId' when calling OrganizationAuthorizationApi->PutOrgauthorizationTrusteeGroupRoles");
        }

        // verify the required parameter 'trusteeGroupId' is set
        if (trusteeGroupId == null)
        {
            throw new ApiException(400, "Missing required parameter 'trusteeGroupId' when calling OrganizationAuthorizationApi->PutOrgauthorizationTrusteeGroupRoles");
        }

        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling OrganizationAuthorizationApi->PutOrgauthorizationTrusteeGroupRoles");
        }

        var localVarPath = "/api/v2/orgauthorization/trustees/{trusteeOrgId}/groups/{trusteeGroupId}/roles";
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
        if (trusteeOrgId != null)
        {
            localVarPathParams.Add("trusteeOrgId", Configuration.ApiClient.ParameterToString(trusteeOrgId));
        }

        if (trusteeGroupId != null)
        {
            localVarPathParams.Add("trusteeGroupId", Configuration.ApiClient.ParameterToString(trusteeGroupId));
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
            throw new ApiException(localVarStatusCode, "Error calling PutOrgauthorizationTrusteeGroupRoles: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PutOrgauthorizationTrusteeGroupRoles: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<UserAuthorization>(localVarStatusCode,
            localVarHeaders,
            (UserAuthorization)Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserAuthorization)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Update Trustee User Roles 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="trusteeUserId">Trustee User Id</param>
    /// <param name="body">Set of roles with corresponding divisions to apply</param>
    /// <returns>UserAuthorization</returns>

    public UserAuthorization PutOrgauthorizationTrusteeUserRoledivisions(string trusteeOrgId, string trusteeUserId, RoleDivisionGrants body)
    {
        ApiResponse<UserAuthorization> localVarResponse = PutOrgauthorizationTrusteeUserRoledivisionsWithHttpInfo(trusteeOrgId, trusteeUserId, body);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Update Trustee User Roles 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="trusteeUserId">Trustee User Id</param>
    /// <param name="body">Set of roles with corresponding divisions to apply</param>
    /// <returns>ApiResponse of UserAuthorization</returns>

    public ApiResponse<UserAuthorization> PutOrgauthorizationTrusteeUserRoledivisionsWithHttpInfo(string trusteeOrgId, string trusteeUserId, RoleDivisionGrants body)
    {
        // verify the required parameter 'trusteeOrgId' is set
        if (trusteeOrgId == null)
        {
            throw new ApiException(400, "Missing required parameter 'trusteeOrgId' when calling OrganizationAuthorizationApi->PutOrgauthorizationTrusteeUserRoledivisions");
        }
        // verify the required parameter 'trusteeUserId' is set
        if (trusteeUserId == null)
        {
            throw new ApiException(400, "Missing required parameter 'trusteeUserId' when calling OrganizationAuthorizationApi->PutOrgauthorizationTrusteeUserRoledivisions");
        }
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling OrganizationAuthorizationApi->PutOrgauthorizationTrusteeUserRoledivisions");
        }

        var localVarPath = "/api/v2/orgauthorization/trustees/{trusteeOrgId}/users/{trusteeUserId}/roledivisions";
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
        if (trusteeOrgId != null)
        {
            localVarPathParams.Add("trusteeOrgId", Configuration.ApiClient.ParameterToString(trusteeOrgId));
        }

        if (trusteeUserId != null)
        {
            localVarPathParams.Add("trusteeUserId", Configuration.ApiClient.ParameterToString(trusteeUserId));
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
            throw new ApiException(localVarStatusCode, "Error calling PutOrgauthorizationTrusteeUserRoledivisions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PutOrgauthorizationTrusteeUserRoledivisions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<UserAuthorization>(localVarStatusCode,
            localVarHeaders,
            (UserAuthorization)Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserAuthorization)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Update Trustee User Roles 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="trusteeUserId">Trustee User Id</param>
    /// <param name="body">Set of roles with corresponding divisions to apply</param>
    /// <returns>Task of UserAuthorization</returns>

    public async Task<UserAuthorization> PutOrgauthorizationTrusteeUserRoledivisionsAsync(string trusteeOrgId, string trusteeUserId, RoleDivisionGrants body)
    {
        ApiResponse<UserAuthorization> localVarResponse = await PutOrgauthorizationTrusteeUserRoledivisionsAsyncWithHttpInfo(trusteeOrgId, trusteeUserId, body);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Update Trustee User Roles 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="trusteeUserId">Trustee User Id</param>
    /// <param name="body">Set of roles with corresponding divisions to apply</param>
    /// <returns>Task of ApiResponse (UserAuthorization)</returns>

    public async Task<ApiResponse<UserAuthorization>> PutOrgauthorizationTrusteeUserRoledivisionsAsyncWithHttpInfo(string trusteeOrgId, string trusteeUserId, RoleDivisionGrants body)
    {
        // verify the required parameter 'trusteeOrgId' is set
        if (trusteeOrgId == null)
        {
            throw new ApiException(400, "Missing required parameter 'trusteeOrgId' when calling OrganizationAuthorizationApi->PutOrgauthorizationTrusteeUserRoledivisions");
        }

        // verify the required parameter 'trusteeUserId' is set
        if (trusteeUserId == null)
        {
            throw new ApiException(400, "Missing required parameter 'trusteeUserId' when calling OrganizationAuthorizationApi->PutOrgauthorizationTrusteeUserRoledivisions");
        }

        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling OrganizationAuthorizationApi->PutOrgauthorizationTrusteeUserRoledivisions");
        }

        var localVarPath = "/api/v2/orgauthorization/trustees/{trusteeOrgId}/users/{trusteeUserId}/roledivisions";
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
        if (trusteeOrgId != null)
        {
            localVarPathParams.Add("trusteeOrgId", Configuration.ApiClient.ParameterToString(trusteeOrgId));
        }

        if (trusteeUserId != null)
        {
            localVarPathParams.Add("trusteeUserId", Configuration.ApiClient.ParameterToString(trusteeUserId));
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
            throw new ApiException(localVarStatusCode, "Error calling PutOrgauthorizationTrusteeUserRoledivisions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PutOrgauthorizationTrusteeUserRoledivisions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<UserAuthorization>(localVarStatusCode,
            localVarHeaders,
            (UserAuthorization)Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserAuthorization)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Update Trustee User Roles 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="trusteeUserId">Trustee User Id</param>
    /// <param name="body">List of roles</param>
    /// <returns>UserAuthorization</returns>

    public UserAuthorization PutOrgauthorizationTrusteeUserRoles(string trusteeOrgId, string trusteeUserId, List<string> body)
    {
        ApiResponse<UserAuthorization> localVarResponse = PutOrgauthorizationTrusteeUserRolesWithHttpInfo(trusteeOrgId, trusteeUserId, body);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Update Trustee User Roles 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="trusteeUserId">Trustee User Id</param>
    /// <param name="body">List of roles</param>
    /// <returns>ApiResponse of UserAuthorization</returns>

    public ApiResponse<UserAuthorization> PutOrgauthorizationTrusteeUserRolesWithHttpInfo(string trusteeOrgId, string trusteeUserId, List<string> body)
    {
        // verify the required parameter 'trusteeOrgId' is set
        if (trusteeOrgId == null)
        {
            throw new ApiException(400, "Missing required parameter 'trusteeOrgId' when calling OrganizationAuthorizationApi->PutOrgauthorizationTrusteeUserRoles");
        }
        // verify the required parameter 'trusteeUserId' is set
        if (trusteeUserId == null)
        {
            throw new ApiException(400, "Missing required parameter 'trusteeUserId' when calling OrganizationAuthorizationApi->PutOrgauthorizationTrusteeUserRoles");
        }
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling OrganizationAuthorizationApi->PutOrgauthorizationTrusteeUserRoles");
        }

        var localVarPath = "/api/v2/orgauthorization/trustees/{trusteeOrgId}/users/{trusteeUserId}/roles";
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
        if (trusteeOrgId != null)
        {
            localVarPathParams.Add("trusteeOrgId", Configuration.ApiClient.ParameterToString(trusteeOrgId));
        }

        if (trusteeUserId != null)
        {
            localVarPathParams.Add("trusteeUserId", Configuration.ApiClient.ParameterToString(trusteeUserId));
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
            throw new ApiException(localVarStatusCode, "Error calling PutOrgauthorizationTrusteeUserRoles: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PutOrgauthorizationTrusteeUserRoles: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<UserAuthorization>(localVarStatusCode,
            localVarHeaders,
            (UserAuthorization)Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserAuthorization)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Update Trustee User Roles 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="trusteeUserId">Trustee User Id</param>
    /// <param name="body">List of roles</param>
    /// <returns>Task of UserAuthorization</returns>

    public async Task<UserAuthorization> PutOrgauthorizationTrusteeUserRolesAsync(string trusteeOrgId, string trusteeUserId, List<string> body)
    {
        ApiResponse<UserAuthorization> localVarResponse = await PutOrgauthorizationTrusteeUserRolesAsyncWithHttpInfo(trusteeOrgId, trusteeUserId, body);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Update Trustee User Roles 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trusteeOrgId">Trustee Organization Id</param>
    /// <param name="trusteeUserId">Trustee User Id</param>
    /// <param name="body">List of roles</param>
    /// <returns>Task of ApiResponse (UserAuthorization)</returns>

    public async Task<ApiResponse<UserAuthorization>> PutOrgauthorizationTrusteeUserRolesAsyncWithHttpInfo(string trusteeOrgId, string trusteeUserId, List<string> body)
    {
        // verify the required parameter 'trusteeOrgId' is set
        if (trusteeOrgId == null)
        {
            throw new ApiException(400, "Missing required parameter 'trusteeOrgId' when calling OrganizationAuthorizationApi->PutOrgauthorizationTrusteeUserRoles");
        }

        // verify the required parameter 'trusteeUserId' is set
        if (trusteeUserId == null)
        {
            throw new ApiException(400, "Missing required parameter 'trusteeUserId' when calling OrganizationAuthorizationApi->PutOrgauthorizationTrusteeUserRoles");
        }

        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling OrganizationAuthorizationApi->PutOrgauthorizationTrusteeUserRoles");
        }

        var localVarPath = "/api/v2/orgauthorization/trustees/{trusteeOrgId}/users/{trusteeUserId}/roles";
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
        if (trusteeOrgId != null)
        {
            localVarPathParams.Add("trusteeOrgId", Configuration.ApiClient.ParameterToString(trusteeOrgId));
        }

        if (trusteeUserId != null)
        {
            localVarPathParams.Add("trusteeUserId", Configuration.ApiClient.ParameterToString(trusteeUserId));
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
            throw new ApiException(localVarStatusCode, "Error calling PutOrgauthorizationTrusteeUserRoles: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PutOrgauthorizationTrusteeUserRoles: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<UserAuthorization>(localVarStatusCode,
            localVarHeaders,
            (UserAuthorization)Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserAuthorization)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Creates a clone of the trustee user in the trustor org. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trustorOrgId">Trustor Organization Id</param>
    /// <param name="trusteeUserId">Trustee User Id</param>
    /// <returns>ClonedUser</returns>

    public ClonedUser PutOrgauthorizationTrustorCloneduser(string trustorOrgId, string trusteeUserId)
    {
        ApiResponse<ClonedUser> localVarResponse = PutOrgauthorizationTrustorCloneduserWithHttpInfo(trustorOrgId, trusteeUserId);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Creates a clone of the trustee user in the trustor org. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trustorOrgId">Trustor Organization Id</param>
    /// <param name="trusteeUserId">Trustee User Id</param>
    /// <returns>ApiResponse of ClonedUser</returns>

    public ApiResponse<ClonedUser> PutOrgauthorizationTrustorCloneduserWithHttpInfo(string trustorOrgId, string trusteeUserId)
    {
        // verify the required parameter 'trustorOrgId' is set
        if (trustorOrgId == null)
        {
            throw new ApiException(400, "Missing required parameter 'trustorOrgId' when calling OrganizationAuthorizationApi->PutOrgauthorizationTrustorCloneduser");
        }
        // verify the required parameter 'trusteeUserId' is set
        if (trusteeUserId == null)
        {
            throw new ApiException(400, "Missing required parameter 'trusteeUserId' when calling OrganizationAuthorizationApi->PutOrgauthorizationTrustorCloneduser");
        }

        var localVarPath = "/api/v2/orgauthorization/trustors/{trustorOrgId}/clonedusers/{trusteeUserId}";
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
        if (trustorOrgId != null)
        {
            localVarPathParams.Add("trustorOrgId", Configuration.ApiClient.ParameterToString(trustorOrgId));
        }

        if (trusteeUserId != null)
        {
            localVarPathParams.Add("trusteeUserId", Configuration.ApiClient.ParameterToString(trusteeUserId));
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
            throw new ApiException(localVarStatusCode, "Error calling PutOrgauthorizationTrustorCloneduser: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PutOrgauthorizationTrustorCloneduser: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<ClonedUser>(localVarStatusCode,
            localVarHeaders,
            (ClonedUser)Configuration.ApiClient.Deserialize(localVarResponse, typeof(ClonedUser)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Creates a clone of the trustee user in the trustor org. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trustorOrgId">Trustor Organization Id</param>
    /// <param name="trusteeUserId">Trustee User Id</param>
    /// <returns>Task of ClonedUser</returns>

    public async Task<ClonedUser> PutOrgauthorizationTrustorCloneduserAsync(string trustorOrgId, string trusteeUserId)
    {
        ApiResponse<ClonedUser> localVarResponse = await PutOrgauthorizationTrustorCloneduserAsyncWithHttpInfo(trustorOrgId, trusteeUserId);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Creates a clone of the trustee user in the trustor org. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trustorOrgId">Trustor Organization Id</param>
    /// <param name="trusteeUserId">Trustee User Id</param>
    /// <returns>Task of ApiResponse (ClonedUser)</returns>

    public async Task<ApiResponse<ClonedUser>> PutOrgauthorizationTrustorCloneduserAsyncWithHttpInfo(string trustorOrgId, string trusteeUserId)
    {
        // verify the required parameter 'trustorOrgId' is set
        if (trustorOrgId == null)
        {
            throw new ApiException(400, "Missing required parameter 'trustorOrgId' when calling OrganizationAuthorizationApi->PutOrgauthorizationTrustorCloneduser");
        }

        // verify the required parameter 'trusteeUserId' is set
        if (trusteeUserId == null)
        {
            throw new ApiException(400, "Missing required parameter 'trusteeUserId' when calling OrganizationAuthorizationApi->PutOrgauthorizationTrustorCloneduser");
        }

        var localVarPath = "/api/v2/orgauthorization/trustors/{trustorOrgId}/clonedusers/{trusteeUserId}";
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
        if (trustorOrgId != null)
        {
            localVarPathParams.Add("trustorOrgId", Configuration.ApiClient.ParameterToString(trustorOrgId));
        }

        if (trusteeUserId != null)
        {
            localVarPathParams.Add("trusteeUserId", Configuration.ApiClient.ParameterToString(trusteeUserId));
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
            throw new ApiException(localVarStatusCode, "Error calling PutOrgauthorizationTrustorCloneduser: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PutOrgauthorizationTrustorCloneduser: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<ClonedUser>(localVarStatusCode,
            localVarHeaders,
            (ClonedUser)Configuration.ApiClient.Deserialize(localVarResponse, typeof(ClonedUser)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Add a Trustee Group to the trust. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trustorOrgId">Trustor Organization Id</param>
    /// <param name="trustorGroupId">Trustor Group Id</param>
    /// <returns>TrustGroup</returns>

    public TrustGroup PutOrgauthorizationTrustorGroup(string trustorOrgId, string trustorGroupId)
    {
        ApiResponse<TrustGroup> localVarResponse = PutOrgauthorizationTrustorGroupWithHttpInfo(trustorOrgId, trustorGroupId);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Add a Trustee Group to the trust. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trustorOrgId">Trustor Organization Id</param>
    /// <param name="trustorGroupId">Trustor Group Id</param>
    /// <returns>ApiResponse of TrustGroup</returns>

    public ApiResponse<TrustGroup> PutOrgauthorizationTrustorGroupWithHttpInfo(string trustorOrgId, string trustorGroupId)
    {
        // verify the required parameter 'trustorOrgId' is set
        if (trustorOrgId == null)
        {
            throw new ApiException(400, "Missing required parameter 'trustorOrgId' when calling OrganizationAuthorizationApi->PutOrgauthorizationTrustorGroup");
        }
        // verify the required parameter 'trustorGroupId' is set
        if (trustorGroupId == null)
        {
            throw new ApiException(400, "Missing required parameter 'trustorGroupId' when calling OrganizationAuthorizationApi->PutOrgauthorizationTrustorGroup");
        }

        var localVarPath = "/api/v2/orgauthorization/trustors/{trustorOrgId}/groups/{trustorGroupId}";
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
        if (trustorOrgId != null)
        {
            localVarPathParams.Add("trustorOrgId", Configuration.ApiClient.ParameterToString(trustorOrgId));
        }

        if (trustorGroupId != null)
        {
            localVarPathParams.Add("trustorGroupId", Configuration.ApiClient.ParameterToString(trustorGroupId));
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
            throw new ApiException(localVarStatusCode, "Error calling PutOrgauthorizationTrustorGroup: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PutOrgauthorizationTrustorGroup: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<TrustGroup>(localVarStatusCode,
            localVarHeaders,
            (TrustGroup)Configuration.ApiClient.Deserialize(localVarResponse, typeof(TrustGroup)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Add a Trustee Group to the trust. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trustorOrgId">Trustor Organization Id</param>
    /// <param name="trustorGroupId">Trustor Group Id</param>
    /// <returns>Task of TrustGroup</returns>

    public async Task<TrustGroup> PutOrgauthorizationTrustorGroupAsync(string trustorOrgId, string trustorGroupId)
    {
        ApiResponse<TrustGroup> localVarResponse = await PutOrgauthorizationTrustorGroupAsyncWithHttpInfo(trustorOrgId, trustorGroupId);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Add a Trustee Group to the trust. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trustorOrgId">Trustor Organization Id</param>
    /// <param name="trustorGroupId">Trustor Group Id</param>
    /// <returns>Task of ApiResponse (TrustGroup)</returns>

    public async Task<ApiResponse<TrustGroup>> PutOrgauthorizationTrustorGroupAsyncWithHttpInfo(string trustorOrgId, string trustorGroupId)
    {
        // verify the required parameter 'trustorOrgId' is set
        if (trustorOrgId == null)
        {
            throw new ApiException(400, "Missing required parameter 'trustorOrgId' when calling OrganizationAuthorizationApi->PutOrgauthorizationTrustorGroup");
        }

        // verify the required parameter 'trustorGroupId' is set
        if (trustorGroupId == null)
        {
            throw new ApiException(400, "Missing required parameter 'trustorGroupId' when calling OrganizationAuthorizationApi->PutOrgauthorizationTrustorGroup");
        }

        var localVarPath = "/api/v2/orgauthorization/trustors/{trustorOrgId}/groups/{trustorGroupId}";
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
        if (trustorOrgId != null)
        {
            localVarPathParams.Add("trustorOrgId", Configuration.ApiClient.ParameterToString(trustorOrgId));
        }

        if (trustorGroupId != null)
        {
            localVarPathParams.Add("trustorGroupId", Configuration.ApiClient.ParameterToString(trustorGroupId));
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
            throw new ApiException(localVarStatusCode, "Error calling PutOrgauthorizationTrustorGroup: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PutOrgauthorizationTrustorGroup: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<TrustGroup>(localVarStatusCode,
            localVarHeaders,
            (TrustGroup)Configuration.ApiClient.Deserialize(localVarResponse, typeof(TrustGroup)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Add a Trustee user to the trust. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trustorOrgId">Trustor Organization Id</param>
    /// <param name="trusteeUserId">Trustee User Id</param>
    /// <returns>TrustUser</returns>

    public TrustUser PutOrgauthorizationTrustorUser(string trustorOrgId, string trusteeUserId)
    {
        ApiResponse<TrustUser> localVarResponse = PutOrgauthorizationTrustorUserWithHttpInfo(trustorOrgId, trusteeUserId);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Add a Trustee user to the trust. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trustorOrgId">Trustor Organization Id</param>
    /// <param name="trusteeUserId">Trustee User Id</param>
    /// <returns>ApiResponse of TrustUser</returns>

    public ApiResponse<TrustUser> PutOrgauthorizationTrustorUserWithHttpInfo(string trustorOrgId, string trusteeUserId)
    {
        // verify the required parameter 'trustorOrgId' is set
        if (trustorOrgId == null)
        {
            throw new ApiException(400, "Missing required parameter 'trustorOrgId' when calling OrganizationAuthorizationApi->PutOrgauthorizationTrustorUser");
        }
        // verify the required parameter 'trusteeUserId' is set
        if (trusteeUserId == null)
        {
            throw new ApiException(400, "Missing required parameter 'trusteeUserId' when calling OrganizationAuthorizationApi->PutOrgauthorizationTrustorUser");
        }

        var localVarPath = "/api/v2/orgauthorization/trustors/{trustorOrgId}/users/{trusteeUserId}";
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
        if (trustorOrgId != null)
        {
            localVarPathParams.Add("trustorOrgId", Configuration.ApiClient.ParameterToString(trustorOrgId));
        }

        if (trusteeUserId != null)
        {
            localVarPathParams.Add("trusteeUserId", Configuration.ApiClient.ParameterToString(trusteeUserId));
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
            throw new ApiException(localVarStatusCode, "Error calling PutOrgauthorizationTrustorUser: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PutOrgauthorizationTrustorUser: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<TrustUser>(localVarStatusCode,
            localVarHeaders,
            (TrustUser)Configuration.ApiClient.Deserialize(localVarResponse, typeof(TrustUser)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Add a Trustee user to the trust. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trustorOrgId">Trustor Organization Id</param>
    /// <param name="trusteeUserId">Trustee User Id</param>
    /// <returns>Task of TrustUser</returns>

    public async Task<TrustUser> PutOrgauthorizationTrustorUserAsync(string trustorOrgId, string trusteeUserId)
    {
        ApiResponse<TrustUser> localVarResponse = await PutOrgauthorizationTrustorUserAsyncWithHttpInfo(trustorOrgId, trusteeUserId);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Add a Trustee user to the trust. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trustorOrgId">Trustor Organization Id</param>
    /// <param name="trusteeUserId">Trustee User Id</param>
    /// <returns>Task of ApiResponse (TrustUser)</returns>

    public async Task<ApiResponse<TrustUser>> PutOrgauthorizationTrustorUserAsyncWithHttpInfo(string trustorOrgId, string trusteeUserId)
    {
        // verify the required parameter 'trustorOrgId' is set
        if (trustorOrgId == null)
        {
            throw new ApiException(400, "Missing required parameter 'trustorOrgId' when calling OrganizationAuthorizationApi->PutOrgauthorizationTrustorUser");
        }

        // verify the required parameter 'trusteeUserId' is set
        if (trusteeUserId == null)
        {
            throw new ApiException(400, "Missing required parameter 'trusteeUserId' when calling OrganizationAuthorizationApi->PutOrgauthorizationTrustorUser");
        }

        var localVarPath = "/api/v2/orgauthorization/trustors/{trustorOrgId}/users/{trusteeUserId}";
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
        if (trustorOrgId != null)
        {
            localVarPathParams.Add("trustorOrgId", Configuration.ApiClient.ParameterToString(trustorOrgId));
        }

        if (trusteeUserId != null)
        {
            localVarPathParams.Add("trusteeUserId", Configuration.ApiClient.ParameterToString(trusteeUserId));
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
            throw new ApiException(localVarStatusCode, "Error calling PutOrgauthorizationTrustorUser: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PutOrgauthorizationTrustorUser: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<TrustUser>(localVarStatusCode,
            localVarHeaders,
            (TrustUser)Configuration.ApiClient.Deserialize(localVarResponse, typeof(TrustUser)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



}
