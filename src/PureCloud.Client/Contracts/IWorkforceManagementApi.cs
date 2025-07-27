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
    /// Get management units
    /// </summary>
    Task<ManagementUnitListing> GetManagementUnitsAsync(int? pageSize = null, int? pageNumber = null, string expand = null, string feature = null, string divisionId = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a management unit
    /// </summary>
    Task<ManagementUnit> GetManagementUnitAsync(string managementUnitId, List<string> expand = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a management unit
    /// </summary>
    Task DeleteManagementUnitAsync(string managementUnitId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get adherence data for users
    /// </summary>
    Task<List<UserScheduleAdherence>> GetAdherenceAsync(List<string> userId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get adherence explanation
    /// </summary>
    Task<AdherenceExplanationResponse> GetAdherenceExplanationAsync(string explanationId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create adherence explanation
    /// </summary>
    Task<AdherenceExplanationAsyncResponse> CreateAdherenceExplanationAsync(string agentId, AddAdherenceExplanationAdminRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get work plans
    /// </summary>
    Task<WorkPlanListResponse> GetWorkPlansAsync(string managementUnitId, List<string> expand = null, List<string> exclude = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a work plan
    /// </summary>
    Task<WorkPlan> GetWorkPlanAsync(string managementUnitId, string workPlanId, List<string> expand = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a work plan
    /// </summary>
    Task<WorkPlan> CreateWorkPlanAsync(string managementUnitId, CreateWorkPlan body, string validationMode = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update a work plan
    /// </summary>
    Task<WorkPlan> UpdateWorkPlanAsync(string managementUnitId, string workPlanId, WorkPlan body, string validationMode = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a work plan
    /// </summary>
    Task DeleteWorkPlanAsync(string managementUnitId, string workPlanId, CancellationToken cancellationToken = default);

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
    /// Get a short term forecast
    /// </summary>
    Task<BuShortTermForecast> GetForecastAsync(string businessUnitId, string weekDateId, string forecastId, List<string> expand = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a short term forecast
    /// </summary>
    Task DeleteForecastAsync(string businessUnitId, string weekDateId, string forecastId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a short term forecast
    /// </summary>
    Task<AsyncForecastOperationResult> CreateForecastAsync(string businessUnitId, string weekDateId, GenerateBuForecastRequest body, bool? forceAsync = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get time off requests
    /// </summary>
    Task<TimeOffRequestList> GetTimeOffRequestsAsync(string managementUnitId, bool? forceDownloadService = null, TimeOffRequestQueryBody body = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a time off request
    /// </summary>
    Task<TimeOffRequestResponse> CreateTimeOffRequestAsync(string managementUnitId, CreateAdminTimeOffRequest body, CancellationToken cancellationToken = default);

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
}