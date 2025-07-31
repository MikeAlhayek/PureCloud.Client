using PureCloud.Client.Models;

namespace PureCloud.Client.Contracts;

public interface ISCIMApi
{
    Task<bool> DeleteScimUserAsync(string userId, string ifMatch = null, CancellationToken cancellationToken = default);
    Task<bool> DeleteScimV2UserAsync(string userId, string ifMatch = null, CancellationToken cancellationToken = default);
    Task<ScimV2Group> GetScimGroupAsync(string groupId, IEnumerable<string> attributes = null, IEnumerable<string> excludedAttributes = null, string ifNoneMatch = null, CancellationToken cancellationToken = default);
    Task<ScimGroupListResponse> GetScimGroupsAsync(int? startIndex = null, int? count = null, IEnumerable<string> attributes = null, IEnumerable<string> excludedAttributes = null, string filter = null, CancellationToken cancellationToken = default);
    Task<ScimConfigResourceType> GetScimResourcetypeAsync(string resourceType, CancellationToken cancellationToken = default);
    Task<ScimConfigResourceTypesListResponse> GetScimResourcetypesAsync(CancellationToken cancellationToken = default);
    Task<ScimV2SchemaDefinition> GetScimSchemaAsync(string schemaId, CancellationToken cancellationToken = default);
    Task<ScimV2SchemaListResponse> GetScimSchemasAsync(string filter = null, CancellationToken cancellationToken = default);
    Task<ScimServiceProviderConfig> GetScimServiceproviderconfigAsync(string ifNoneMatch = null, CancellationToken cancellationToken = default);
    Task<ScimV2User> GetScimUserAsync(string userId, IEnumerable<string> attributes = null, IEnumerable<string> excludedAttributes = null, string ifNoneMatch = null, CancellationToken cancellationToken = default);
    Task<ScimUserListResponse> GetScimUsersAsync(int? startIndex = null, int? count = null, IEnumerable<string> attributes = null, IEnumerable<string> excludedAttributes = null, string filter = null, CancellationToken cancellationToken = default);
    Task<ScimV2Group> GetScimV2GroupAsync(string groupId, IEnumerable<string> attributes = null, IEnumerable<string> excludedAttributes = null, string ifNoneMatch = null, CancellationToken cancellationToken = default);
    Task<ScimGroupListResponse> GetScimV2GroupsAsync(string filter, int? startIndex = null, int? count = null, IEnumerable<string> attributes = null, IEnumerable<string> excludedAttributes = null, CancellationToken cancellationToken = default);
    Task<ScimConfigResourceType> GetScimV2ResourcetypeAsync(string resourceType, CancellationToken cancellationToken = default);
    Task<ScimConfigResourceTypesListResponse> GetScimV2ResourcetypesAsync(CancellationToken cancellationToken = default);
    Task<ScimV2SchemaDefinition> GetScimV2SchemaAsync(string schemaId, CancellationToken cancellationToken = default);
    Task<ScimV2SchemaListResponse> GetScimV2SchemasAsync(string filter = null, CancellationToken cancellationToken = default);
    Task<ScimServiceProviderConfig> GetScimV2ServiceproviderconfigAsync(string ifNoneMatch = null, CancellationToken cancellationToken = default);
    Task<ScimV2User> GetScimV2UserAsync(string userId, IEnumerable<string> attributes = null, IEnumerable<string> excludedAttributes = null, string ifNoneMatch = null, CancellationToken cancellationToken = default);
    Task<ScimUserListResponse> GetScimV2UsersAsync(int? startIndex = null, int? count = null, IEnumerable<string> attributes = null, IEnumerable<string> excludedAttributes = null, string filter = null, CancellationToken cancellationToken = default);
    Task<ScimV2Group> UpdateScimGroupAsync(string groupId, ScimV2PatchRequest body, string ifMatch = null, CancellationToken cancellationToken = default);
    Task<ScimV2User> UpdateScimUserAsync(string userId, ScimV2PatchRequest body, string ifMatch = null, CancellationToken cancellationToken = default);
    Task<ScimV2Group> UpdateScimV2GroupAsync(string groupId, ScimV2PatchRequest body, string ifMatch = null, CancellationToken cancellationToken = default);
    Task<ScimV2User> UpdateScimV2UserAsync(string userId, ScimV2PatchRequest body, string ifMatch = null, CancellationToken cancellationToken = default);
    Task<ScimV2User> CreateScimUserAsync(ScimV2CreateUser body, CancellationToken cancellationToken = default);
    Task<ScimV2User> CreateScimV2UserAsync(ScimV2CreateUser body, CancellationToken cancellationToken = default);
    Task<ScimV2Group> ReplaceScimGroupAsync(string groupId, ScimV2Group body, string ifMatch = null, CancellationToken cancellationToken = default);
    Task<ScimV2User> ReplaceScimUserAsync(string userId, ScimV2User body, string ifMatch = null, CancellationToken cancellationToken = default);
    Task<ScimV2Group> ReplaceScimV2GroupAsync(string groupId, ScimV2Group body, string ifMatch = null, CancellationToken cancellationToken = default);
    Task<ScimV2User> ReplaceScimV2UserAsync(string userId, ScimV2User body, string ifMatch = null, CancellationToken cancellationToken = default);
}