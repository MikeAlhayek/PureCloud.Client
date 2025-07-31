using PureCloud.Client.Models;

namespace PureCloud.Client.Contracts;

public interface ISCIMApi
{
    /// <summary>
    /// Delete a user.
    /// </summary>
    /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/users.</param>
    /// <param name="ifMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/users/{userId}. Example: "42". If the ETag is different from the version on the server, returns 400 with a "scimType" of "invalidVers".</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<bool> DeleteScimUserAsync(string userId, string ifMatch = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a user.
    /// </summary>
    /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/v2/users.</param>
    /// <param name="ifMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/v2/users/{userId}. Example: "42". If the ETag is different from the version on the server, returns 400 with a "scimType" of "invalidVers".</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<bool> DeleteScimV2UserAsync(string userId, string ifMatch = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a group.
    /// </summary>
    /// <param name="groupId">The ID of a group. Returned with GET /api/v2/scim/groups.</param>
    /// <param name="attributes">Indicates which attributes to include. Returns these attributes and the "id", "displayName", and "meta" attributes. Use "attributes" to avoid expensive secondary calls for the default attributes.</param>
    /// <param name="excludedAttributes">Indicates which attributes to exclude. Returns the default attributes minus "excludedAttributes". Always returns "id", "displayName", and "meta" attributes.</param>
    /// <param name="ifNoneMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/groups/{groupId}. Example: "42". If the ETag is the same as the version on the server, returns 304 and does not return the requested resource.</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<ScimV2Group> GetScimGroupAsync(string groupId, IEnumerable<string> attributes = null, IEnumerable<string> excludedAttributes = null, string ifNoneMatch = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a list of groups.
    /// </summary>
    /// <param name="startIndex">The 1-based index of the first query result.</param>
    /// <param name="count">The requested number of items per page. A value of 0 returns "totalResults".</param>
    /// <param name="attributes">Indicates which attributes to include. Returns these attributes and the "id", "displayName", and "meta" attributes. Use "attributes" to avoid expensive secondary calls for the default attributes.</param>
    /// <param name="excludedAttributes">Indicates which attributes to exclude. Returns the default attributes minus "excludedAttributes". Always returns "id", "displayName", and "meta" attributes.</param>
    /// <param name="filter">Filters results. If nothing is specified, returns all groups. Examples of valid values: "displayName eq groupName", "members.value eq userId".</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<ScimGroupListResponse> GetScimGroupsAsync(int? startIndex = null, int? count = null, IEnumerable<string> attributes = null, IEnumerable<string> excludedAttributes = null, string filter = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a resource type.
    /// </summary>
    /// <param name="resourceType">The type of resource. Returned with GET /api/v2/scim/resourcetypes.</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<ScimConfigResourceType> GetScimResourcetypeAsync(string resourceType, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a list of resource types.
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<ScimConfigResourceTypesListResponse> GetScimResourcetypesAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a schema.
    /// </summary>
    /// <param name="schemaId">The ID of a schema.</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<ScimV2SchemaDefinition> GetScimSchemaAsync(string schemaId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a list of schemas.
    /// </summary>
    /// <param name="filter">Filters results.</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<ScimV2SchemaListResponse> GetScimSchemasAsync(string filter = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a service provider's configuration.
    /// </summary>
    /// <param name="ifNoneMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/serviceproviderconfig. Example: "42". If the ETag is the same as the version on the server, returns 304 and does not return the requested resource.</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<ScimServiceProviderConfig> GetScimServiceproviderconfigAsync(string ifNoneMatch = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a user.
    /// </summary>
    /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/users.</param>
    /// <param name="attributes">Indicates which attributes to include. Returns these attributes and the "id", "active", and "meta" attributes. Use "attributes" to avoid expensive secondary calls for the default attributes.</param>
    /// <param name="excludedAttributes">Indicates which attributes to exclude. Returns the default attributes minus "excludedAttributes". Always returns "id", "active", and "meta" attributes.</param>
    /// <param name="ifNoneMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/users/{userId}. Example: "42". If the ETag is the same as the version on the server, returns 304 and does not return the requested resource.</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<ScimV2User> GetScimUserAsync(string userId, IEnumerable<string> attributes = null, IEnumerable<string> excludedAttributes = null, string ifNoneMatch = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a list of users.
    /// </summary>
    /// <param name="startIndex">The 1-based index of the first query result.</param>
    /// <param name="count">The requested number of items per page. A value of 0 returns "totalResults".</param>
    /// <param name="attributes">Indicates which attributes to include. Returns these attributes and the "id", "active", and "meta" attributes. Use "attributes" to avoid expensive secondary calls for the default attributes.</param>
    /// <param name="excludedAttributes">Indicates which attributes to exclude. Returns the default attributes minus "excludedAttributes". Always returns "id", "active", and "meta" attributes.</param>
    /// <param name="filter">Filters results. If nothing is specified, returns all users. Examples of valid values: "id eq 857449b0-d9e7-4cd0-acbf-a6adfb9f83fa", "userName eq search@sample.org", "manager eq 16e10e2f-1136-43fe-bb84-eac073168a49", "email eq search@sample.org", "division eq divisionName", "externalId eq 167844", "active eq false", "employeeNumber eq 9876543210".</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<ScimUserListResponse> GetScimUsersAsync(int? startIndex = null, int? count = null, IEnumerable<string> attributes = null, IEnumerable<string> excludedAttributes = null, string filter = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a group.
    /// </summary>
    /// <param name="groupId">The ID of a group. Returned with GET /api/v2/scim/v2/groups.</param>
    /// <param name="attributes">Indicates which attributes to include. Returns these attributes and the "id", "displayName", and "meta" attributes. Use "attributes" to avoid expensive secondary calls for the default attributes.</param>
    /// <param name="excludedAttributes">Indicates which attributes to exclude. Returns the default attributes minus "excludedAttributes". Always returns "id", "displayName", and "meta" attributes.</param>
    /// <param name="ifNoneMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/v2/groups/{groupId}. Example: "42". If the ETag is the same as the version on the server, returns 304 and does not return the requested resource.</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<ScimV2Group> GetScimV2GroupAsync(string groupId, IEnumerable<string> attributes = null, IEnumerable<string> excludedAttributes = null, string ifNoneMatch = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a list of groups.
    /// </summary>
    /// <param name="filter">Filters results. If nothing is specified, returns all groups. Examples of valid values: "displayName eq groupName", "members.value eq userId".</param>
    /// <param name="startIndex">The 1-based index of the first query result.</param>
    /// <param name="count">The requested number of items per page. A value of 0 returns "totalResults".</param>
    /// <param name="attributes">Indicates which attributes to include. Returns these attributes and the "id", "displayName", and "meta" attributes. Use "attributes" to avoid expensive secondary calls for the default attributes.</param>
    /// <param name="excludedAttributes">Indicates which attributes to exclude. Returns the default attributes minus "excludedAttributes". Always returns "id", "displayName", and "meta" attributes.</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<ScimGroupListResponse> GetScimV2GroupsAsync(string filter, int? startIndex = null, int? count = null, IEnumerable<string> attributes = null, IEnumerable<string> excludedAttributes = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a resource type.
    /// </summary>
    /// <param name="resourceType">The type of resource. Returned with GET /api/v2/scim/v2/resourcetypes.</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<ScimConfigResourceType> GetScimV2ResourcetypeAsync(string resourceType, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a list of resource types.
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<ScimConfigResourceTypesListResponse> GetScimV2ResourcetypesAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a schema.
    /// </summary>
    /// <param name="schemaId">The ID of a schema.</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<ScimV2SchemaDefinition> GetScimV2SchemaAsync(string schemaId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a list of schemas.
    /// </summary>
    /// <param name="filter">Filters results.</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<ScimV2SchemaListResponse> GetScimV2SchemasAsync(string filter = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a service provider's configuration.
    /// </summary>
    /// <param name="ifNoneMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/v2/serviceproviderconfig. Example: "42". If the ETag is the same as the version on the server, returns 304 and does not return the requested resource.</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<ScimServiceProviderConfig> GetScimV2ServiceproviderconfigAsync(string ifNoneMatch = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a user.
    /// </summary>
    /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/v2/users.</param>
    /// <param name="attributes">Indicates which attributes to include. Returns these attributes and the "id", "active", and "meta" attributes. Use "attributes" to avoid expensive secondary calls for the default attributes.</param>
    /// <param name="excludedAttributes">Indicates which attributes to exclude. Returns the default attributes minus "excludedAttributes". Always returns "id", "active", and "meta" attributes.</param>
    /// <param name="ifNoneMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/v2/users/{userId}. Example: "42". If the ETag is the same as the version on the server, returns 304 and does not return the requested resource.</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<ScimV2User> GetScimV2UserAsync(string userId, IEnumerable<string> attributes = null, IEnumerable<string> excludedAttributes = null, string ifNoneMatch = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a list of users.
    /// </summary>
    /// <param name="startIndex">The 1-based index of the first query result.</param>
    /// <param name="count">The requested number of items per page. A value of 0 returns "totalResults".</param>
    /// <param name="attributes">Indicates which attributes to include. Returns these attributes and the "id", "active", and "meta" attributes. Use "attributes" to avoid expensive secondary calls for the default attributes.</param>
    /// <param name="excludedAttributes">Indicates which attributes to exclude. Returns the default attributes minus "excludedAttributes". Always returns "id", "active", and "meta" attributes.</param>
    /// <param name="filter">Filters results. If nothing is specified, returns all users. Examples of valid values: "id eq 857449b0-d9e7-4cd0-acbf-a6adfb9f83fa", "userName eq search@sample.org", "manager eq 16e10e2f-1136-43fe-bb84-eac073168a49", "email eq search@sample.org", "division eq divisionName", "externalId eq 167844", "active eq false", "employeeNumber eq 9876543210".</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<ScimUserListResponse> GetScimV2UsersAsync(int? startIndex = null, int? count = null, IEnumerable<string> attributes = null, IEnumerable<string> excludedAttributes = null, string filter = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Modify a group.
    /// </summary>
    /// <param name="groupId">The ID of a group. Returned with GET /api/v2/scim/groups.</param>
    /// <param name="body">The information used to modify a group.</param>
    /// <param name="ifMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/groups/{groupId}. Example: "42". If the ETag is different from the version on the server, returns 400 with a "scimType" of "invalidVers".</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<ScimV2Group> UpdateScimGroupAsync(string groupId, ScimV2PatchRequest body, string ifMatch = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Modify a user.
    /// </summary>
    /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/users.</param>
    /// <param name="body">The information used to modify a user.</param>
    /// <param name="ifMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/users/{userId}. Example: "42". If the ETag is different from the version on the server, returns 400 with a "scimType" of "invalidVers".</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<ScimV2User> UpdateScimUserAsync(string userId, ScimV2PatchRequest body, string ifMatch = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Modify a group.
    /// </summary>
    /// <param name="groupId">The ID of a group. Returned with GET /api/v2/scim/v2/groups.</param>
    /// <param name="body">The information used to modify a group.</param>
    /// <param name="ifMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/v2/groups/{groupId}. Example: "42". If the ETag is different from the version on the server, returns 400 with a "scimType" of "invalidVers".</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<ScimV2Group> UpdateScimV2GroupAsync(string groupId, ScimV2PatchRequest body, string ifMatch = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Modify a user.
    /// </summary>
    /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/v2/users.</param>
    /// <param name="body">The information used to modify a user.</param>
    /// <param name="ifMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/v2/users/{userId}. Example: "42". If the ETag is different from the version on the server, returns 400 with a "scimType" of "invalidVers".</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<ScimV2User> UpdateScimV2UserAsync(string userId, ScimV2PatchRequest body, string ifMatch = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a user.
    /// </summary>
    /// <param name="body">User</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<ScimV2User> CreateScimUserAsync(ScimV2CreateUser body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a user.
    /// </summary>
    /// <param name="body">User</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<ScimV2User> CreateScimV2UserAsync(ScimV2CreateUser body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Replace a group.
    /// </summary>
    /// <param name="groupId">The ID of a group. Returned with GET /api/v2/scim/groups.</param>
    /// <param name="body">Group</param>
    /// <param name="ifMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/groups/{groupId}. Example: "42". If the ETag is different from the version on the server, returns 400 with a "scimType" of "invalidVers".</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<ScimV2Group> ReplaceScimGroupAsync(string groupId, ScimV2Group body, string ifMatch = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Replace a user.
    /// </summary>
    /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/users.</param>
    /// <param name="body">User</param>
    /// <param name="ifMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/users/{userId}. Example: "42". If the ETag is different from the version on the server, returns 400 with a "scimType" of "invalidVers".</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<ScimV2User> ReplaceScimUserAsync(string userId, ScimV2User body, string ifMatch = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Replace a group.
    /// </summary>
    /// <param name="groupId">The ID of a group. Returned with GET /api/v2/scim/v2/groups.</param>
    /// <param name="body">Group</param>
    /// <param name="ifMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/v2/groups/{groupId}. Example: "42". If the ETag is different from the version on the server, returns 400 with a "scimType" of "invalidVers".</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<ScimV2Group> ReplaceScimV2GroupAsync(string groupId, ScimV2Group body, string ifMatch = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Replace a user.
    /// </summary>
    /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/v2/users.</param>
    /// <param name="body">User</param>
    /// <param name="ifMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/v2/users/{userId}. Example: "42". If the ETag is different from the version on the server, returns 400 with a "scimType" of "invalidVers".</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<ScimV2User> ReplaceScimV2UserAsync(string userId, ScimV2User body, string ifMatch = null, CancellationToken cancellationToken = default);
}
