using PureCloud.Client.Models;

namespace PureCloud.Client.Contracts;

public interface IWorkforceManagementApi
{
    /// <summary>
    /// Get a list of UserScheduleAdherence records for the requested users
    /// </summary>
    /// <param name="userIds">User Id(s) for which to fetch current schedule adherence information. Min 1, Max of 100 userIds per request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Array of UserScheduleAdherence records</returns>
    Task<UserScheduleAdherence[]> GetAdherenceAsync(IEnumerable<string> userIds, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete business unit
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit, or 'mine' for the business unit of the logged-in user</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if successful</returns>
    Task<bool> DeleteBusinessUnitAsync(string businessUnitId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create adherence explanations query
    /// </summary>
    /// <param name="body">The query request body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Query adherence explanations response</returns>
    Task<QueryAdherenceExplanationsResponse> CreateAdherenceExplanationsQueryAsync(AgentQueryAdherenceExplanationsRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update business unit activity code
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="activityCodeId">The ID of the activity code</param>
    /// <param name="body">The updated activity code</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Updated business unit activity code</returns>
    Task<BusinessUnitActivityCode> PatchBusinessUnitActivityCodeAsync(string businessUnitId, string activityCodeId, UpdateActivityCodeRequest body = null, CancellationToken cancellationToken = default);
}