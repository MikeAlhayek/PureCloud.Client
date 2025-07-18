using PureCloud.Client.Models;
using PureCloud.Client.Models.Groups;

namespace PureCloud.Client.Contracts;

public interface IGroupsApi
{
    Task DeleteGroupAsync(string groupId, CancellationToken cancellationToken = default);

    Task DeleteGroupDynamicsettingsAsync(string groupId, CancellationToken cancellationToken = default);

    Task DeleteGroupMembersAsync(string groupId, string ids, CancellationToken cancellationToken = default);

    Task<FieldConfig> GetFieldconfigAsync(string type, CancellationToken cancellationToken = default);

    Task<Group> GetGroupAsync(string groupId, CancellationToken cancellationToken = default);

    Task<DynamicGroupDefinition> GetGroupDynamicsettingsAsync(string groupId, CancellationToken cancellationToken = default);

    Task<UserEntityListing> GetGroupIndividualsAsync(string groupId, CancellationToken cancellationToken = default);

    Task<UserEntityListing> GetGroupMembersAsync(string groupId, int? pageSize = null, int? pageNumber = null, string sortOrder = null, List<string> expand = null, CancellationToken cancellationToken = default);

    Task<GroupProfile> GetGroupProfileAsync(string groupId, string fields = null, CancellationToken cancellationToken = default);

    Task<GroupEntityListing> GetGroupsAsync(int? pageSize = null, int? pageNumber = null, IList<string> id = null, List<string> jabberId = null, string sortOrder = null, CancellationToken cancellationToken = default);

    Task<GroupsSearchResponse> GetGroupsSearchAsync(string q64, IList<string> expand = null, CancellationToken cancellationToken = default);

    Task<GroupProfileEntityListing> GetProfilesGroupsAsync(int? pageSize = null, int? pageNumber = null, IList<string> id = null, List<string> jabberId = null, string sortOrder = null, CancellationToken cancellationToken = default);

    Task CreateGroupMembersAsync(string groupId, GroupMembersUpdate body, CancellationToken cancellationToken = default);

    Task<Group> CreateGroupsAsync(GroupCreate body, CancellationToken cancellationToken = default);

    Task<DynamicGroupQueryPreview> CreateGroupsDynamicsettingsPreviewAsync(DynamicGroupQuery body, CancellationToken cancellationToken = default);

    Task<GroupsSearchResponse> CreateGroupsSearchAsync(GroupSearchRequest body, CancellationToken cancellationToken = default);

    Task<Group> UpdateGroupAsync(string groupId, GroupUpdate body = null, CancellationToken cancellationToken = default);

    Task UpdateGroupDynamicsettingsAsync(string groupId, DynamicGroupQuery body, CancellationToken cancellationToken = default);
}
