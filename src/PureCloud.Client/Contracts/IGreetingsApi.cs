using PureCloud.Client.Models;

namespace PureCloud.Client.Contracts;

public interface IGreetingsApi
{
    Task DeleteGreetingAsync(string greetingId, CancellationToken cancellationToken = default);

    Task<Greeting> GetGreetingAsync(string greetingId, CancellationToken cancellationToken = default);

    Task<GreetingMediaInfo> GetGreetingMediaAsync(string greetingId, string formatId = null, CancellationToken cancellationToken = default);

    Task<DomainEntityListing> GetGreetingsAsync(int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default);

    Task<DefaultGreetingList> GetGreetingsDefaultsAsync(CancellationToken cancellationToken = default);

    Task<GreetingListing> GetGroupGreetingsAsync(string groupId, int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default);

    Task<DefaultGreetingList> GetGroupGreetingsDefaultsAsync(string groupId, CancellationToken cancellationToken = default);

    Task<DomainEntityListing> GetUserGreetingsAsync(string userId, int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default);

    Task<DefaultGreetingList> GetUserGreetingsDefaultsAsync(string userId, CancellationToken cancellationToken = default);

    Task<Greeting> CreateGreetingAsync(Greeting body, CancellationToken cancellationToken = default);

    Task<Greeting> CreateGroupGreetingAsync(string groupId, Greeting body, CancellationToken cancellationToken = default);

    Task<Greeting> CreateUserGreetingAsync(string userId, Greeting body, CancellationToken cancellationToken = default);

    Task<Greeting> UpdateGreetingAsync(string greetingId, Greeting body, CancellationToken cancellationToken = default);

    Task<DefaultGreetingList> UpdateGreetingsDefaultsAsync(DefaultGreetingList body, CancellationToken cancellationToken = default);

    Task<DefaultGreetingList> UpdateGroupGreetingsDefaultsAsync(string groupId, DefaultGreetingList body, CancellationToken cancellationToken = default);

    Task<DefaultGreetingList> UpdateUserGreetingsDefaultsAsync(string userId, DefaultGreetingList body, CancellationToken cancellationToken = default);
}
