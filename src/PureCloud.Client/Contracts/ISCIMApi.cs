using PureCloud.Client.Models;

namespace PureCloud.Client.Contracts;

public interface ISCIMApi
{
    Task<ScimUserListResponse> GetScimUsersAsync(int? startIndex = null, int? count = null, IEnumerable<string> attributes = null, IEnumerable<string> excludedAttributes = null, string filter = null, CancellationToken cancellationToken = default);

    Task<ScimV2User> GetScimUserAsync(string userId, IEnumerable<string> attributes = null, IEnumerable<string> excludedAttributes = null, string ifNoneMatch = null, CancellationToken cancellationToken = default);

    Task<ScimV2User> CreateScimUserAsync(ScimV2CreateUser body, CancellationToken cancellationToken = default);

    Task<ScimV2User> UpdateScimUserAsync(string userId, ScimV2User body, string ifMatch = null, CancellationToken cancellationToken = default);

    Task DeleteScimUserAsync(string userId, string ifMatch = null, CancellationToken cancellationToken = default);
}