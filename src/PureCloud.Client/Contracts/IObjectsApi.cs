using PureCloud.Client.Models;

namespace PureCloud.Client.Contracts;

public interface IObjectsApi
{
    /// <summary>
    /// Get an authorization division by ID.
    /// </summary>
    /// <param name="divisionId">Division ID</param>
    /// <param name="objectCount">Get count of objects in this division, defaults to false</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <returns>AuthzDivision</returns>
    Task<AuthzDivision> GetAuthorizationDivisionAsync(string divisionId, bool? objectCount = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a list of authorization divisions.
    /// </summary>
    /// <param name="pageSize">The total page size requested</param>
    /// <param name="pageNumber">The page number requested</param>
    /// <param name="sortBy">variable name requested to sort by</param>
    /// <param name="expands">variable name requested by expand list</param>
    /// <param name="nextPage">next page token</param>
    /// <param name="previousPage">Previous page token</param>
    /// <param name="objectCount">Include the count of objects contained in the division</param>
    /// <param name="ids">Optionally request specific divisions by their IDs</param>
    /// <param name="name">Search term to filter by division name</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <returns>AuthzDivisionEntityListing</returns>
    Task<AuthzDivisionEntityListing> GetAuthorizationDivisionsAsync(int? pageSize = null, int? pageNumber = null, string sortBy = null, IEnumerable<string> expands = null, string nextPage = null, string previousPage = null, bool? objectCount = null, IEnumerable<string> ids = null, string name = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a new authorization division.
    /// </summary>
    /// <param name="body">Division</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <returns>AuthzDivision</returns>
    Task<AuthzDivision> CreateAuthorizationDivisionAsync(AuthzDivision body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update an authorization division.
    /// </summary>
    /// <param name="divisionId">Division ID</param>
    /// <param name="body">Updated division data</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <returns>AuthzDivision</returns>
    Task<AuthzDivision> UpdateAuthorizationDivisionAsync(string divisionId, AuthzDivision body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete an authorization division.
    /// </summary>
    /// <param name="divisionId">Division ID</param>
    /// <param name="force">Force delete this division as well as the grants and objects associated with it</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <returns>Task</returns>
    Task DeleteAuthorizationDivisionAsync(string divisionId, bool? force = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a list of soft deleted divisions for the org.
    /// </summary>
    /// <param name="pageNumber">The page number requested</param>
    /// <param name="pageSize">The total page size requested</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <returns>AuthzDivisionEntityListing</returns>
    Task<AuthzDivisionEntityListing> GetAuthorizationDivisionsDeletedAsync(int? pageNumber = null, int? pageSize = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieve the home division for the organization.
    /// </summary>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <returns>AuthzDivision</returns>
    Task<AuthzDivision> GetAuthorizationDivisionsHomeAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Returns the maximum allowed number of divisions.
    /// </summary>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <returns>int?</returns>
    Task<int?> GetAuthorizationDivisionsLimitAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Assign a list of objects to a division.
    /// </summary>
    /// <param name="divisionId">Division ID</param>
    /// <param name="objectType">The type of the objects. must be one of the valid object types</param>
    /// <param name="body">Object Id List</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <returns>Task</returns>
    Task CreateAuthorizationDivisionObjectsAsync(string divisionId, string objectType, IEnumerable<string> body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieve a list of all divisions defined for the organization with cursor-based pagination.
    /// </summary>
    /// <param name="before">The cursor that points to the start of the set of entities that has been returned.</param>
    /// <param name="after">The cursor that points to the end of the set of entities that has been returned.</param>
    /// <param name="pageSize">Number of entities to return. Maximum of 100.</param>
    /// <param name="ids">Optionally request specific divisions by their IDs</param>
    /// <param name="name">Search term to filter by division name</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <returns>AuthzDivisionCursorListing</returns>
    Task<AuthzDivisionCursorListing> GetAuthorizationDivisionsQueryAsync(string before = null, string after = null, string pageSize = null, IEnumerable<string> ids = null, string name = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Recreate a previously deleted division.
    /// </summary>
    /// <param name="divisionId">Division ID</param>
    /// <param name="body">Recreated division data</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <returns>AuthzDivision</returns>
    Task<AuthzDivision> PostAuthorizationDivisionRestoreAsync(string divisionId, AuthzDivision body, CancellationToken cancellationToken = default);
}
