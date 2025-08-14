using PureCloud.Client.Models;
using PureCloud.Client.Models.Teams;

namespace PureCloud.Client.Contracts;

public interface ITeamsApi
{
    /// <summary>
    /// Get team
    /// </summary>
    /// <param name="teamId">Team ID</param>
    /// <param name="expand">Expand the name on additional fields</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Team</returns>
    Task<Team> GetTeamAsync(string teamId, string expand = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get team members
    /// </summary>
    /// <param name="teamId">Team ID</param>
    /// <param name="pageSize">Page size</param>
    /// <param name="before">The cursor that points to the start of the set of entities</param>
    /// <param name="after">The cursor that points to the end of the set of entities</param>
    /// <param name="expand">Expand the name on additional fields</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>TeamMemberEntityListing</returns>
    Task<TeamMemberEntityListing> GetTeamMembersAsync(string teamId, int? pageSize = null, string before = null, string after = null, string expand = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get teams
    /// </summary>
    /// <param name="pageSize">Page size</param>
    /// <param name="name">Return only teams whose names start with this value</param>
    /// <param name="after">The cursor that points to the end of the set of entities</param>
    /// <param name="before">The cursor that points to the start of the set of entities</param>
    /// <param name="expand">Expand the name on additional fields</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>TeamEntityListing</returns>
    Task<TeamEntityListing> GetTeamsAsync(int? pageSize = null, string name = null, string after = null, string before = null, string expand = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a team
    /// </summary>
    /// <param name="body">Team</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Team</returns>
    Task<Team> CreateTeamAsync(Team body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update team
    /// </summary>
    /// <param name="teamId">Team ID</param>
    /// <param name="body">Team</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Team</returns>
    Task<Team> UpdateTeamAsync(string teamId, Team body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete team
    /// </summary>
    /// <param name="teamId">Team ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>bool</returns>
    Task<bool> DeleteTeamAsync(string teamId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete team members
    /// </summary>
    /// <param name="teamId">Team ID</param>
    /// <param name="id">Team member ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>bool</returns>
    Task<bool> DeleteTeamMembersAsync(string teamId, string id, CancellationToken cancellationToken = default);

    /// <summary>
    /// Add team members
    /// </summary>
    /// <param name="teamId">Team ID</param>
    /// <param name="body">TeamMembers</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>TeamMemberAddListingResponse</returns>
    Task<TeamMemberAddListingResponse> CreateTeamMembersAsync(string teamId, TeamMembers body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Query for team activity observations
    /// </summary>
    /// <param name="body">query</param>
    /// <param name="pageSize">The desired page size</param>
    /// <param name="pageNumber">The desired page number</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>TeamActivityResponse</returns>
    Task<TeamActivityResponse> CreateAnalyticsTeamsActivityQueryAsync(TeamActivityQuery body, int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Search teams
    /// </summary>
    /// <param name="body">Search request options</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>TeamsSearchResponse</returns>
    Task<TeamsSearchResponse> CreateTeamsSearchAsync(TeamSearchRequest body, CancellationToken cancellationToken = default);
}
