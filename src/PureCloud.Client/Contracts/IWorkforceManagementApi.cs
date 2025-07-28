using PureCloud.Client.Models;

namespace PureCloud.Client.Contracts;

/// <summary>
/// Workforce Management API operations
/// </summary>
public interface IWorkforceManagementApi
{
    /// <summary>
    /// Get business units
    /// </summary>
    /// <param name="feature">The feature to filter by</param>
    /// <param name="divisionId">The division ID to filter by</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Business unit listing</returns>
    Task<BusinessUnitListing> GetBusinessUnitsAsync(string feature = null, string divisionId = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a business unit
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="expand">Include to access additional data on the business unit</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Business unit response</returns>
    Task<BusinessUnitResponse> GetBusinessUnitAsync(string businessUnitId, List<string> expand = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a business unit
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if deletion was successful</returns>
    Task<bool> DeleteBusinessUnitAsync(string businessUnitId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a management unit
    /// </summary>
    /// <param name="managementUnitId">The ID of the management unit</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if deletion was successful</returns>
    Task<bool> DeleteManagementUnitAsync(string managementUnitId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a management unit
    /// </summary>
    /// <param name="managementUnitId">The ID of the management unit</param>
    /// <param name="expand">Include to access additional data on the management unit</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Management unit as JSON string (simplified for now)</returns>
    Task<string> GetManagementUnitAsync(string managementUnitId, List<string> expand = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get management units
    /// </summary>
    /// <param name="pageSize">Page size for pagination</param>
    /// <param name="pageNumber">Page number for pagination</param>
    /// <param name="expand">Include to access additional data on the management units</param>
    /// <param name="feature">The feature to filter by</param>
    /// <param name="divisionId">The division ID to filter by</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Management unit listing as JSON string (simplified for now)</returns>
    Task<string> GetManagementUnitsAsync(int? pageSize = null, int? pageNumber = null, string expand = null, string feature = null, string divisionId = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get user schedule adherence records
    /// </summary>
    /// <param name="userId">List of user IDs</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>List of user schedule adherence records as JSON string (simplified for now)</returns>
    Task<string> GetAdherenceAsync(List<string> userId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get work plans for a management unit
    /// </summary>
    /// <param name="managementUnitId">The ID of the management unit</param>
    /// <param name="expand">Include to access additional data on the work plans</param>
    /// <param name="exclude">Exclude specific data from the work plans</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Work plan list as JSON string (simplified for now)</returns>
    Task<string> GetWorkPlansAsync(string managementUnitId, List<string> expand = null, List<string> exclude = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a new work plan
    /// </summary>
    /// <param name="managementUnitId">The ID of the management unit</param>
    /// <param name="body">The work plan creation request as JSON string</param>
    /// <param name="validationMode">Validation mode</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Created work plan as JSON string (simplified for now)</returns>
    Task<string> CreateWorkPlanAsync(string managementUnitId, string body, string validationMode = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the management unit to which the currently logged in agent belongs
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Agent management unit reference as JSON string (simplified for now)</returns>
    Task<string> GetMyManagementUnitAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Get activity codes
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Activity code container</returns>
    Task<ActivityCodeContainer> GetActivityCodesAsync(string businessUnitId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create an activity code
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="body">The activity code request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Created activity code</returns>
    Task<ActivityCode> CreateActivityCodeAsync(string businessUnitId, CreateActivityCodeRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete an activity code
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="activityCodeId">The ID of the activity code to delete</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if deletion was successful</returns>
    Task<bool> DeleteActivityCodeAsync(string businessUnitId, string activityCodeId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get schedules for a week
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="weekId">The week ID</param>
    /// <param name="includeOnlyPublished">Include only published schedules</param>
    /// <param name="expand">Expand parameter</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Schedule listing</returns>
    Task<BuScheduleListing> GetSchedulesAsync(string businessUnitId, string weekId, bool? includeOnlyPublished = null, string expand = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a schedule - simplified return type
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="weekId">The week ID</param>
    /// <param name="scheduleId">The schedule ID</param>
    /// <param name="expand">Expand parameter</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Schedule as JSON string</returns>
    Task<string> GetScheduleAsync(string businessUnitId, string weekId, string scheduleId, string expand = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a schedule
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="weekId">The week ID</param>
    /// <param name="scheduleId">The schedule ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if deletion was successful</returns>
    Task<bool> DeleteScheduleAsync(string businessUnitId, string weekId, string scheduleId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get short term forecasts - simplified return type
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="weekDateId">The week date ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Forecasts as JSON string</returns>
    Task<string> GetForecastsAsync(string businessUnitId, string weekDateId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a short term forecast
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="weekDateId">The week date ID</param>
    /// <param name="forecastId">The forecast ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if deletion was successful</returns>
    Task<bool> DeleteForecastAsync(string businessUnitId, string weekDateId, string forecastId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a time off request
    /// </summary>
    /// <param name="managementUnitId">The ID of the management unit</param>
    /// <param name="body">The time off request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Created time off request (temporarily simplified as string)</returns>
    Task<string> CreateTimeOffRequestAsync(string managementUnitId, CreateAdminTimeOffRequest body, CancellationToken cancellationToken = default);
}
