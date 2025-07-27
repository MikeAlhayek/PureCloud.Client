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
    Task<BusinessUnitListing> GetBusinessUnitsAsync(string feature = null, string divisionId = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a business unit
    /// </summary>
    Task<BusinessUnitResponse> GetBusinessUnitAsync(string businessUnitId, List<string> expand = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a business unit
    /// </summary>
    Task DeleteBusinessUnitAsync(string businessUnitId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a management unit
    /// </summary>
    Task DeleteManagementUnitAsync(string managementUnitId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get activity codes
    /// </summary>
    Task<ActivityCodeContainer> GetActivityCodesAsync(string businessUnitId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create an activity code
    /// </summary>
    Task<ActivityCode> CreateActivityCodeAsync(string businessUnitId, CreateActivityCodeRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete an activity code
    /// </summary>
    Task DeleteActivityCodeAsync(string businessUnitId, string activityCodeId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get schedules for a week
    /// </summary>
    Task<BuScheduleListing> GetSchedulesAsync(string businessUnitId, string weekId, bool? includeOnlyPublished = null, string expand = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a schedule
    /// </summary>
    Task<BuScheduleMetadata> GetScheduleAsync(string businessUnitId, string weekId, string scheduleId, string expand = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a schedule
    /// </summary>
    Task<BuAsyncScheduleResponse> DeleteScheduleAsync(string businessUnitId, string weekId, string scheduleId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get short term forecasts
    /// </summary>
    Task<BuShortTermForecastListing> GetForecastsAsync(string businessUnitId, string weekDateId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a short term forecast
    /// </summary>
    Task DeleteForecastAsync(string businessUnitId, string weekDateId, string forecastId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a time off request
    /// </summary>
    Task<string> CreateTimeOffRequestAsync(string managementUnitId, CreateAdminTimeOffRequest body, CancellationToken cancellationToken = default);
}