using PureCloud.Client.Models.Users;

namespace PureCloud.Client.Contracts;

public interface IUserApi
{
    Task<User> CreateUserAsync(CreateUser user, CancellationToken cancellationToken = default);

    Task<User> DeleteUserAsync(string userId, CancellationToken cancellationToken = default);

    Task<User> GetUserAsync(string userId, UserSearchContext context = null, CancellationToken cancellationToken = default);

    Task<SearchResult<User>> SearchUsersAsync(UserSearchRequest request, CancellationToken cancellationToken = default);

    Task<User> UpdateUpdateAsync(string userId, UpdateUser user, CancellationToken cancellationToken = default);

    Task<User> GetCurrentUserAsync(IEnumerable<string> expands = null, string integrationPresenceSource = null, CancellationToken cancellationToken = default);
}
