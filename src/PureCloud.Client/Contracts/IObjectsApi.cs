using PureCloud.Client.Models;

namespace PureCloud.Client.Contracts;

public interface IObjectsApi
{
    /// <summary>
    /// Get an authorization division by ID.
    /// </summary>
    Task<AuthzDivision> GetAuthorizationDivisionAsync(string divisionId, bool? objectCount = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a list of authorization divisions.
    /// </summary>
    Task<AuthzDivisionEntityListing> GetAuthorizationDivisionsAsync(int? pageSize = null, int? pageNumber = null, string sortBy = null, IEnumerable<string> expand = null, string nextPage = null, string previousPage = null, bool? objectCount = null, IEnumerable<string> id = null, string name = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a new authorization division.
    /// </summary>
    Task<AuthzDivision> CreateAuthorizationDivisionAsync(AuthzDivision body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update an authorization division.
    /// </summary>
    Task<AuthzDivision> UpdateAuthorizationDivisionAsync(string divisionId, AuthzDivision body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete an authorization division.
    /// </summary>
    Task DeleteAuthorizationDivisionAsync(string divisionId, bool? force = null, CancellationToken cancellationToken = default);
}