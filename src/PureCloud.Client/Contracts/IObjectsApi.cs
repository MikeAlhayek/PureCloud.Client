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
    Task<AuthzDivisionEntityListing> GetAuthorizationDivisionsAsync(int? pageSize = null, int? pageNumber = null, string sortBy = null, IEnumerable<string> expands = null, string nextPage = null, string previousPage = null, bool? objectCount = null, IEnumerable<string> ids = null, string name = null, CancellationToken cancellationToken = default);

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

    /// <summary>
    /// Get a list of soft deleted divisions for the org.
    /// </summary>
    Task<AuthzDivisionEntityListing> GetAuthorizationDivisionsDeletedAsync(int? pageNumber = null, int? pageSize = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieve the home division for the organization.
    /// </summary>
    Task<AuthzDivision> GetAuthorizationDivisionsHomeAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Returns the maximum allowed number of divisions.
    /// </summary>
    Task<int?> GetAuthorizationDivisionsLimitAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Assign a list of objects to a division.
    /// </summary>
    Task CreateAuthorizationDivisionObjectsAsync(string divisionId, string objectType, IEnumerable<string> body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieve a list of all divisions defined for the organization with cursor-based pagination.
    /// </summary>
    Task<AuthzDivisionCursorListing> GetAuthorizationDivisionsQueryAsync(string before = null, string after = null, string pageSize = null, IEnumerable<string> ids = null, string name = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Recreate a previously deleted division.
    /// </summary>
    Task<AuthzDivision> PostAuthorizationDivisionRestoreAsync(string divisionId, AuthzDivision body, CancellationToken cancellationToken = default);
}
