using PureCloud.Client.Models.Users;

namespace PureCloud.Client.Repositories;

public interface IUserRepository
{
    Task<User> CreateAsync(CreateUser user, CancellationToken cancellationToken = default);

    Task<User> DeleteAsync(string userId, CancellationToken cancellationToken = default);

    Task<User> GetAsync(string userId, UserSearchContext context = null, CancellationToken cancellationToken = default);

    Task<SearchResult<User>> SearchAsync(UserSearchRequest request, CancellationToken cancellationToken = default);

    Task<User> UpdateAsync(string userId, UpdateUser user, CancellationToken cancellationToken = default);

    Task<User> GetMeAsync(IEnumerable<string> expands = null, string integrationPresenceSource = null, CancellationToken cancellationToken = default);
}
