using PureCloud.Client.Models;
using PureCloud.Client.Models.Teams;

namespace PureCloud.Client.Contracts;

public interface ITeamsApi
{
    Task<Team> GetTeamAsync(string teamId, string expand = null, CancellationToken cancellationToken = default);

    Task<TeamMemberEntityListing> GetTeamMembersAsync(string teamId, int? pageSize = null, string before = null, string after = null, string expand = null, CancellationToken cancellationToken = default);

    Task<TeamEntityListing> GetTeamsAsync(int? pageSize = null, string name = null, string after = null, string before = null, string expand = null, CancellationToken cancellationToken = default);

    Task<Team> CreateTeamAsync(Team body, CancellationToken cancellationToken = default);

    Task<Team> UpdateTeamAsync(string teamId, Team body, CancellationToken cancellationToken = default);

    Task DeleteTeamAsync(string teamId, CancellationToken cancellationToken = default);

    Task DeleteTeamMembersAsync(string teamId, string id, CancellationToken cancellationToken = default);

    Task<TeamMemberAddListingResponse> CreateTeamMembersAsync(string teamId, TeamMembers body, CancellationToken cancellationToken = default);

    Task<TeamActivityResponse> CreateAnalyticsTeamsActivityQueryAsync(TeamActivityQuery body, int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default);

    Task<TeamsSearchResponse> CreateTeamsSearchAsync(TeamSearchRequest body, CancellationToken cancellationToken = default);
}
