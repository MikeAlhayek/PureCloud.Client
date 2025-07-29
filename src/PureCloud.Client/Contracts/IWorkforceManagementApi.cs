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
    /// <param name="expands">Include to access additional data on the business unit</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Business unit response</returns>
    Task<BusinessUnitResponse> GetBusinessUnitAsync(string businessUnitId, IEnumerable<string> expands = null, CancellationToken cancellationToken = default);

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
    /// <param name="expands">Include to access additional data on the management unit</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Management unit as JSON string (simplified for now)</returns>
    Task<string> GetManagementUnitAsync(string managementUnitId, IEnumerable<string> expands = null, CancellationToken cancellationToken = default);

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
    /// <param name="expands">Include to access additional data on the work plans</param>
    /// <param name="exclude">Exclude specific data from the work plans</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Work plan list as JSON string (simplified for now)</returns>
    Task<string> GetWorkPlansAsync(string managementUnitId, IEnumerable<string> expands = null, List<string> exclude = null, CancellationToken cancellationToken = default);

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

    /// <summary>
    /// Delete planning group
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="planningGroupId">The ID of the planning group to delete</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if deletion was successful</returns>
    Task<bool> DeletePlanningGroupAsync(string businessUnitId, string planningGroupId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get planning group
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="planningGroupId">The ID of the planning group</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Planning group (temporarily simplified as string)</returns>
    Task<string> GetPlanningGroupAsync(string businessUnitId, string planningGroupId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get planning groups
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Planning groups list (temporarily simplified as string)</returns>
    Task<string> GetPlanningGroupsAsync(string businessUnitId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get activity plan
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="activityPlanId">The ID of the activity plan</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Activity plan (temporarily simplified as string)</returns>
    Task<string> GetActivityPlanAsync(string businessUnitId, string activityPlanId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get activity plans
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="state">Filter by state</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Activity plans list (temporarily simplified as string)</returns>
    Task<string> GetActivityPlansAsync(string businessUnitId, string state = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get activity plan jobs
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Activity plan jobs list (temporarily simplified as string)</returns>
    Task<string> GetActivityPlanJobsAsync(string businessUnitId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get activity plan run job
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="activityPlanId">The ID of the activity plan</param>
    /// <param name="jobId">The ID of the job</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Activity plan run job (temporarily simplified as string)</returns>
    Task<string> GetActivityPlanRunJobAsync(string businessUnitId, string activityPlanId, string jobId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete service goal template
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="serviceGoalTemplateId">The ID of the service goal template to delete</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if deletion was successful</returns>
    Task<bool> DeleteServiceGoalTemplateAsync(string businessUnitId, string serviceGoalTemplateId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete staffing group
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="staffingGroupId">The ID of the staffing group to delete</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if deletion was successful</returns>
    Task<bool> DeleteStaffingGroupAsync(string businessUnitId, string staffingGroupId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete work plan
    /// </summary>
    /// <param name="managementUnitId">The ID of the management unit</param>
    /// <param name="workPlanId">The ID of the work plan to delete</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if deletion was successful</returns>
    Task<bool> DeleteWorkPlanAsync(string managementUnitId, string workPlanId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete work plan rotation
    /// </summary>
    /// <param name="managementUnitId">The ID of the management unit</param>
    /// <param name="workPlanRotationId">The ID of the work plan rotation to delete</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if deletion was successful</returns>
    Task<bool> DeleteWorkPlanRotationAsync(string managementUnitId, string workPlanRotationId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get adherence explanation
    /// </summary>
    /// <param name="explanationId">The ID of the explanation</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Adherence explanation (temporarily simplified as string)</returns>
    Task<string> GetAdherenceExplanationAsync(string explanationId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get adherence explanations job
    /// </summary>
    /// <param name="jobId">The ID of the job</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Adherence explanations job (temporarily simplified as string)</returns>
    Task<string> GetAdherenceExplanationsJobAsync(string jobId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get adherence historical bulk job
    /// </summary>
    /// <param name="jobId">The ID of the job</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Adherence historical bulk job (temporarily simplified as string)</returns>
    Task<string> GetAdherenceHistoricalBulkJobAsync(string jobId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get adherence historical job
    /// </summary>
    /// <param name="jobId">The ID of the job</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Adherence historical job (temporarily simplified as string)</returns>
    Task<string> GetAdherenceHistoricalJobAsync(string jobId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get agent adherence explanation
    /// </summary>
    /// <param name="agentId">The ID of the agent</param>
    /// <param name="explanationId">The ID of the explanation</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Agent adherence explanation (temporarily simplified as string)</returns>
    Task<string> GetAgentAdherenceExplanationAsync(string agentId, string explanationId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get agent management unit
    /// </summary>
    /// <param name="agentId">The ID of the agent</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Agent management unit (temporarily simplified as string)</returns>
    Task<string> GetAgentManagementUnitAsync(string agentId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete time off limit
    /// </summary>
    /// <param name="managementUnitId">The ID of the management unit</param>
    /// <param name="timeOffLimitId">The ID of the time off limit to delete</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if deletion was successful</returns>
    Task<bool> DeleteTimeOffLimitAsync(string managementUnitId, string timeOffLimitId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete time off plan
    /// </summary>
    /// <param name="managementUnitId">The ID of the management unit</param>
    /// <param name="timeOffPlanId">The ID of the time off plan to delete</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if deletion was successful</returns>
    Task<bool> DeleteTimeOffPlanAsync(string managementUnitId, string timeOffPlanId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get alternative shifts settings
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Alternative shifts settings (temporarily simplified as string)</returns>
    Task<string> GetAlternativeShiftsSettingsAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Get alternative shifts trade
    /// </summary>
    /// <param name="tradeId">The ID of the trade</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Alternative shifts trade (temporarily simplified as string)</returns>
    Task<string> GetAlternativeShiftsTradeAsync(string tradeId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get alternative shifts trades
    /// </summary>
    /// <param name="forceAsync">Force async</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Alternative shifts trades list (temporarily simplified as string)</returns>
    Task<string> GetAlternativeShiftsTradesAsync(bool? forceAsync = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get alternative shifts trades job
    /// </summary>
    /// <param name="jobId">The ID of the job</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Alternative shifts trades job (temporarily simplified as string)</returns>
    Task<string> GetAlternativeShiftsTradesJobAsync(string jobId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get alternative shifts offers job
    /// </summary>
    /// <param name="jobId">The ID of the job</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Alternative shifts offers job (temporarily simplified as string)</returns>
    Task<string> GetAlternativeShiftsOffersJobAsync(string jobId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get business unit alternative shifts settings
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Business unit alternative shifts settings (temporarily simplified as string)</returns>
    Task<string> GetBusinessUnitAlternativeShiftsSettingsAsync(string businessUnitId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get business unit alternative shifts trade
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="tradeId">The ID of the trade</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Business unit alternative shifts trade (temporarily simplified as string)</returns>
    Task<string> GetBusinessUnitAlternativeShiftsTradeAsync(string businessUnitId, string tradeId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get business unit alternative shifts trades search job
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="jobId">The ID of the job</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Business unit alternative shifts trades search job (temporarily simplified as string)</returns>
    Task<string> GetBusinessUnitAlternativeShiftsTradesSearchJobAsync(string businessUnitId, string jobId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete work plan bid
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="bidId">The ID of the bid to delete</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if deletion was successful</returns>
    Task<bool> DeleteWorkPlanBidAsync(string businessUnitId, string bidId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete work plan bid group
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="bidId">The ID of the bid</param>
    /// <param name="bidGroupId">The ID of the bid group to delete</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if deletion was successful</returns>
    Task<bool> DeleteWorkPlanBidGroupAsync(string businessUnitId, string bidId, string bidGroupId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get business unit intraday planning groups
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="date">The target date</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Business unit intraday planning groups (temporarily simplified as string)</returns>
    Task<string> GetBusinessUnitIntradayPlanningGroupsAsync(string businessUnitId, string date, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get business unit management units
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="feature">Feature filter</param>
    /// <param name="divisionId">Division ID filter</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Business unit management units (temporarily simplified as string)</returns>
    Task<string> GetBusinessUnitManagementUnitsAsync(string businessUnitId, string feature = null, string divisionId = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete calendar URL ICS
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if deletion was successful</returns>
    Task<bool> DeleteCalendarUrlIcsAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete business unit time off limit
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="timeOffLimitId">The ID of the time off limit to delete</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if deletion was successful</returns>
    Task<bool> DeleteBusinessUnitTimeOffLimitAsync(string businessUnitId, string timeOffLimitId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete business unit time off plan
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="timeOffPlanId">The ID of the time off plan to delete</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if deletion was successful</returns>
    Task<bool> DeleteBusinessUnitTimeOffPlanAsync(string businessUnitId, string timeOffPlanId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete scheduling run
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="runId">The ID of the run to delete</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if deletion was successful</returns>
    Task<bool> DeleteSchedulingRunAsync(string businessUnitId, string runId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create adherence explanation
    /// </summary>
    /// <param name="body">Adherence explanation request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Created adherence explanation (temporarily simplified as string)</returns>
    Task<string> CreateAdherenceExplanationAsync(string body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Query adherence explanations
    /// </summary>
    /// <param name="body">Query request</param>
    /// <param name="forceAsync">Force async</param>
    /// <param name="forceDownloadService">Force download service</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Query result (temporarily simplified as string)</returns>
    Task<string> QueryAdherenceExplanationsAsync(string body, bool? forceAsync = null, bool? forceDownloadService = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create adherence historical
    /// </summary>
    /// <param name="body">Historical request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Historical response (temporarily simplified as string)</returns>
    Task<string> CreateAdherenceHistoricalAsync(string body = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create adherence historical bulk
    /// </summary>
    /// <param name="body">Historical bulk request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Historical bulk response (temporarily simplified as string)</returns>
    Task<string> CreateAdherenceHistoricalBulkAsync(string body = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create agent adherence explanation
    /// </summary>
    /// <param name="agentId">The ID of the agent</param>
    /// <param name="body">Adherence explanation request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Created adherence explanation (temporarily simplified as string)</returns>
    Task<string> CreateAgentAdherenceExplanationAsync(string agentId, string body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create activity plan
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="body">Activity plan request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Created activity plan (temporarily simplified as string)</returns>
    Task<string> CreateActivityPlanAsync(string businessUnitId, string body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create activity plan run job
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="activityPlanId">The ID of the activity plan</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Created job (temporarily simplified as string)</returns>
    Task<string> CreateActivityPlanRunJobAsync(string businessUnitId, string activityPlanId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create alternative shift trade
    /// </summary>
    /// <param name="body">Trade request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Created trade (temporarily simplified as string)</returns>
    Task<string> CreateAlternativeShiftTradeAsync(string body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create alternative shift offers job
    /// </summary>
    /// <param name="body">Offers request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Created job (temporarily simplified as string)</returns>
    Task<string> CreateAlternativeShiftOffersJobAsync(string body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Search alternative shift offers
    /// </summary>
    /// <param name="body">Search request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Search results (temporarily simplified as string)</returns>
    Task<string> SearchAlternativeShiftOffersAsync(string body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Search business unit alternative shift trades
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="body">Search request</param>
    /// <param name="forceAsync">Force async</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Search results (temporarily simplified as string)</returns>
    Task<string> SearchBusinessUnitAlternativeShiftTradesAsync(string businessUnitId, string body, bool? forceAsync = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Search business unit agent schedules
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="body">Search request</param>
    /// <param name="forceAsync">Force async</param>
    /// <param name="forceDownloadService">Force download service</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Search results (temporarily simplified as string)</returns>
    Task<string> SearchBusinessUnitAgentSchedulesAsync(string businessUnitId, string body = null, bool? forceAsync = null, bool? forceDownloadService = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create business unit intraday
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="body">Intraday request</param>
    /// <param name="forceAsync">Force async</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Intraday response (temporarily simplified as string)</returns>
    Task<string> CreateBusinessUnitIntradayAsync(string businessUnitId, string body = null, bool? forceAsync = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Move agents
    /// </summary>
    /// <param name="body">Move request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Move response (temporarily simplified as string)</returns>
    Task<string> MoveAgentsAsync(string body = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Query agents integrations
    /// </summary>
    /// <param name="body">Query request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Query results (temporarily simplified as string)</returns>
    Task<string> QueryAgentsIntegrationsAsync(string body = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get agents possible work shifts
    /// </summary>
    /// <param name="body">Work shifts request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Possible work shifts (temporarily simplified as string)</returns>
    Task<string> GetAgentsPossibleWorkShiftsAsync(string body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get my agent schedule
    /// </summary>
    /// <param name="body">Schedule request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Agent schedule (temporarily simplified as string)</returns>
    Task<string> GetMyAgentScheduleAsync(string body = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update agent adherence explanation
    /// </summary>
    /// <param name="agentId">The ID of the agent</param>
    /// <param name="explanationId">The ID of the explanation</param>
    /// <param name="body">Update request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Updated explanation (temporarily simplified as string)</returns>
    Task<string> UpdateAgentAdherenceExplanationAsync(string agentId, string explanationId, string body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update alternative shift trade
    /// </summary>
    /// <param name="tradeId">The ID of the trade</param>
    /// <param name="body">Update request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Updated trade (temporarily simplified as string)</returns>
    Task<string> UpdateAlternativeShiftTradeAsync(string tradeId, string body = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update business unit
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="body">Update request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Updated business unit</returns>
    Task<BusinessUnitResponse> UpdateBusinessUnitAsync(string businessUnitId, string body = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update activity code
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="activityCodeId">The ID of the activity code</param>
    /// <param name="body">Update request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Updated activity code</returns>
    Task<ActivityCode> UpdateActivityCodeAsync(string businessUnitId, string activityCodeId, string body = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update activity plan
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="activityPlanId">The ID of the activity plan</param>
    /// <param name="body">Update request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Updated activity plan (temporarily simplified as string)</returns>
    Task<string> UpdateActivityPlanAsync(string businessUnitId, string activityPlanId, string body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update planning group
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="planningGroupId">The ID of the planning group</param>
    /// <param name="body">Update request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Updated planning group (temporarily simplified as string)</returns>
    Task<string> UpdatePlanningGroupAsync(string businessUnitId, string planningGroupId, string body = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update scheduling run
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="runId">The ID of the run</param>
    /// <param name="body">Update request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task UpdateSchedulingRunAsync(string businessUnitId, string runId, string body = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update service goal template
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="serviceGoalTemplateId">The ID of the service goal template</param>
    /// <param name="body">Update request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Updated service goal template (temporarily simplified as string)</returns>
    Task<string> UpdateServiceGoalTemplateAsync(string businessUnitId, string serviceGoalTemplateId, string body = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update staffing group
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="staffingGroupId">The ID of the staffing group</param>
    /// <param name="body">Update request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Updated staffing group (temporarily simplified as string)</returns>
    Task<string> UpdateStaffingGroupAsync(string businessUnitId, string staffingGroupId, string body = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update work plan
    /// </summary>
    /// <param name="managementUnitId">The ID of the management unit</param>
    /// <param name="workPlanId">The ID of the work plan</param>
    /// <param name="body">Update request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Updated work plan (temporarily simplified as string)</returns>
    Task<string> UpdateWorkPlanAsync(string managementUnitId, string workPlanId, string body = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update time off plan
    /// </summary>
    /// <param name="managementUnitId">The ID of the management unit</param>
    /// <param name="timeOffPlanId">The ID of the time off plan</param>
    /// <param name="body">Update request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Updated time off plan (temporarily simplified as string)</returns>
    Task<string> UpdateTimeOffPlanAsync(string managementUnitId, string timeOffPlanId, string body = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get business unit activity code
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="activityCodeId">The ID of the activity code</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Activity code (temporarily simplified as string)</returns>
    Task<string> GetBusinessUnitActivityCodeAsync(string businessUnitId, string activityCodeId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get work plan
    /// </summary>
    /// <param name="managementUnitId">The ID of the management unit</param>
    /// <param name="workPlanId">The ID of the work plan</param>
    /// <param name="includeOnly">Include only specific fields</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Work plan (temporarily simplified as string)</returns>
    Task<string> GetWorkPlanAsync(string managementUnitId, string workPlanId, IEnumerable<string> includeOnly = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get work plan rotations
    /// </summary>
    /// <param name="managementUnitId">The ID of the management unit</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Work plan rotations (temporarily simplified as string)</returns>
    Task<string> GetWorkPlanRotationsAsync(string managementUnitId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get work plan rotation
    /// </summary>
    /// <param name="managementUnitId">The ID of the management unit</param>
    /// <param name="workPlanRotationId">The ID of the work plan rotation</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Work plan rotation (temporarily simplified as string)</returns>
    Task<string> GetWorkPlanRotationAsync(string managementUnitId, string workPlanRotationId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get time off limits
    /// </summary>
    /// <param name="managementUnitId">The ID of the management unit</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Time off limits (temporarily simplified as string)</returns>
    Task<string> GetTimeOffLimitsAsync(string managementUnitId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get time off limit
    /// </summary>
    /// <param name="managementUnitId">The ID of the management unit</param>
    /// <param name="timeOffLimitId">The ID of the time off limit</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Time off limit (temporarily simplified as string)</returns>
    Task<string> GetTimeOffLimitAsync(string managementUnitId, string timeOffLimitId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get time off plans
    /// </summary>
    /// <param name="managementUnitId">The ID of the management unit</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Time off plans (temporarily simplified as string)</returns>
    Task<string> GetTimeOffPlansAsync(string managementUnitId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get time off plan
    /// </summary>
    /// <param name="managementUnitId">The ID of the management unit</param>
    /// <param name="timeOffPlanId">The ID of the time off plan</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Time off plan (temporarily simplified as string)</returns>
    Task<string> GetTimeOffPlanAsync(string managementUnitId, string timeOffPlanId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get short term forecast
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="weekDateId">The week date ID</param>
    /// <param name="forecastId">The ID of the forecast</param>
    /// <param name="expands">Expand options</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Short term forecast (temporarily simplified as string)</returns>
    Task<string> GetShortTermForecastAsync(string businessUnitId, string weekDateId, string forecastId, IEnumerable<string> expands = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get short term forecast data
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="weekDateId">The week date ID</param>
    /// <param name="forecastId">The ID of the forecast</param>
    /// <param name="weekNumber">Week number</param>
    /// <param name="forceDownloadService">Force download service</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Forecast data (temporarily simplified as string)</returns>
    Task<string> GetShortTermForecastDataAsync(string businessUnitId, string weekDateId, string forecastId, int? weekNumber = null, bool? forceDownloadService = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get short term forecast generation results
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="weekDateId">The week date ID</param>
    /// <param name="forecastId">The ID of the forecast</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Generation results (temporarily simplified as string)</returns>
    Task<string> GetShortTermForecastGenerationResultsAsync(string businessUnitId, string weekDateId, string forecastId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get short term forecast planning groups
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="weekDateId">The week date ID</param>
    /// <param name="forecastId">The ID of the forecast</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Planning groups (temporarily simplified as string)</returns>
    Task<string> GetShortTermForecastPlanningGroupsAsync(string businessUnitId, string weekDateId, string forecastId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get short term forecast staffing requirement
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="weekDateId">The week date ID</param>
    /// <param name="forecastId">The ID of the forecast</param>
    /// <param name="weekNumbers">Week numbers</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Staffing requirement (temporarily simplified as string)</returns>
    Task<string> GetShortTermForecastStaffingRequirementAsync(string businessUnitId, string weekDateId, string forecastId, IEnumerable<string> weekNumbers = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get short term forecasts
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="weekDateId">The week date ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Short term forecasts list (temporarily simplified as string)</returns>
    Task<string> GetShortTermForecastsAsync(string businessUnitId, string weekDateId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get schedule headcount forecast
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="weekId">The week ID</param>
    /// <param name="scheduleId">The ID of the schedule</param>
    /// <param name="forceDownload">Force download</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Headcount forecast (temporarily simplified as string)</returns>
    Task<string> GetScheduleHeadcountForecastAsync(string businessUnitId, string weekId, string scheduleId, bool? forceDownload = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get time off requests
    /// </summary>
    /// <param name="managementUnitId">The ID of the management unit</param>
    /// <param name="recentlyReviewed">Recently reviewed filter</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Time off requests list (temporarily simplified as string)</returns>
    Task<string> GetTimeOffRequestsAsync(string managementUnitId, bool? recentlyReviewed = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get time off request
    /// </summary>
    /// <param name="managementUnitId">The ID of the management unit</param>
    /// <param name="timeOffRequestId">The ID of the time off request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Time off request (temporarily simplified as string)</returns>
    Task<string> GetTimeOffRequestAsync(string managementUnitId, string timeOffRequestId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create short term forecast
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="weekDateId">The week date ID</param>
    /// <param name="body">Forecast request</param>
    /// <param name="forceAsync">Force async</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Created forecast (temporarily simplified as string)</returns>
    Task<string> CreateShortTermForecastAsync(string businessUnitId, string weekDateId, string body, bool? forceAsync = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Generate short term forecast
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="weekDateId">The week date ID</param>
    /// <param name="forecastId">The ID of the forecast</param>
    /// <param name="body">Generation request</param>
    /// <param name="forceAsync">Force async</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Generation result (temporarily simplified as string)</returns>
    Task<string> GenerateShortTermForecastAsync(string businessUnitId, string weekDateId, string forecastId, string body, bool? forceAsync = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Copy short term forecast
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="weekDateId">The week date ID</param>
    /// <param name="forecastId">The ID of the forecast</param>
    /// <param name="body">Copy request</param>
    /// <param name="forceAsync">Force async</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Copy result (temporarily simplified as string)</returns>
    Task<string> CopyShortTermForecastAsync(string businessUnitId, string weekDateId, string forecastId, string body, bool? forceAsync = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update short term forecast
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="weekDateId">The week date ID</param>
    /// <param name="forecastId">The ID of the forecast</param>
    /// <param name="body">Update request</param>
    /// <param name="forceAsync">Force async</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Updated forecast (temporarily simplified as string)</returns>
    Task<string> UpdateShortTermForecastAsync(string businessUnitId, string weekDateId, string forecastId, string body, bool? forceAsync = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create time off requests
    /// </summary>
    /// <param name="managementUnitId">The ID of the management unit</param>
    /// <param name="body">Time off requests</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Created requests (temporarily simplified as string)</returns>
    Task<string> CreateTimeOffRequestsAsync(string managementUnitId, string body = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update time off request
    /// </summary>
    /// <param name="managementUnitId">The ID of the management unit</param>
    /// <param name="timeOffRequestId">The ID of the time off request</param>
    /// <param name="body">Update request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Updated request (temporarily simplified as string)</returns>
    Task<string> UpdateTimeOffRequestAsync(string managementUnitId, string timeOffRequestId, string body = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get notification subscriptions
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Notification subscriptions (temporarily simplified as string)</returns>
    Task<string> GetNotificationSubscriptionsAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Create notification subscription
    /// </summary>
    /// <param name="body">Subscription request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Created subscription (temporarily simplified as string)</returns>
    Task<string> CreateNotificationSubscriptionAsync(string body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete notification subscription
    /// </summary>
    /// <param name="subscriptionId">The ID of the subscription to delete</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if deletion was successful</returns>
    Task<bool> DeleteNotificationSubscriptionAsync(string subscriptionId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get business unit settings
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Business unit settings (temporarily simplified as string)</returns>
    Task<string> GetBusinessUnitSettingsAsync(string businessUnitId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update business unit settings
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="body">Settings update request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Updated settings (temporarily simplified as string)</returns>
    Task<string> UpdateBusinessUnitSettingsAsync(string businessUnitId, string body = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get schedule generation results
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="weekId">The week ID</param>
    /// <param name="scheduleId">The ID of the schedule</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Generation results (temporarily simplified as string)</returns>
    Task<string> GetScheduleGenerationResultsAsync(string businessUnitId, string weekId, string scheduleId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get schedule history for agent
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="weekId">The week ID</param>
    /// <param name="scheduleId">The ID of the schedule</param>
    /// <param name="agentId">The ID of the agent</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Schedule history (temporarily simplified as string)</returns>
    Task<string> GetScheduleHistoryAgentAsync(string businessUnitId, string weekId, string scheduleId, string agentId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get schedule performance predictions
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="weekId">The week ID</param>
    /// <param name="scheduleId">The ID of the schedule</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Performance predictions (temporarily simplified as string)</returns>
    Task<string> GetSchedulePerformancePredictionsAsync(string businessUnitId, string weekId, string scheduleId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get schedule performance predictions recalculation
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="weekId">The week ID</param>
    /// <param name="scheduleId">The ID of the schedule</param>
    /// <param name="recalculationId">The ID of the recalculation</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Performance predictions recalculation (temporarily simplified as string)</returns>
    Task<string> GetSchedulePerformancePredictionsRecalculationAsync(string businessUnitId, string weekId, string scheduleId, string recalculationId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get management unit schedule
    /// </summary>
    /// <param name="managementUnitId">The ID of the management unit</param>
    /// <param name="weekId">The week ID</param>
    /// <param name="scheduleId">The ID of the schedule</param>
    /// <param name="expand">Expand options</param>
    /// <param name="forceDownloadService">Force download service</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Management unit schedule (temporarily simplified as string)</returns>
    Task<string> GetManagementUnitScheduleAsync(string managementUnitId, string weekId, string scheduleId, string expand = null, bool? forceDownloadService = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Query schedule agent schedules
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="weekId">The week ID</param>
    /// <param name="scheduleId">The ID of the schedule</param>
    /// <param name="body">Query request</param>
    /// <param name="forceAsync">Force async</param>
    /// <param name="forceDownloadService">Force download service</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Query results (temporarily simplified as string)</returns>
    Task<string> QueryScheduleAgentSchedulesAsync(string businessUnitId, string weekId, string scheduleId, string body, bool? forceAsync = null, bool? forceDownloadService = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Copy schedule
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="weekId">The week ID</param>
    /// <param name="scheduleId">The ID of the schedule</param>
    /// <param name="body">Copy request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Copy result (temporarily simplified as string)</returns>
    Task<string> CopyScheduleAsync(string businessUnitId, string weekId, string scheduleId, string body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create schedule performance predictions recalculation
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="weekId">The week ID</param>
    /// <param name="scheduleId">The ID of the schedule</param>
    /// <param name="body">Recalculation request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Recalculation result (temporarily simplified as string)</returns>
    Task<string> CreateSchedulePerformancePredictionsRecalculationAsync(string businessUnitId, string weekId, string scheduleId, string body = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create schedule performance predictions recalculation upload URL
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="weekId">The week ID</param>
    /// <param name="scheduleId">The ID of the schedule</param>
    /// <param name="body">Upload URL request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Upload URL (temporarily simplified as string)</returns>
    Task<string> CreateSchedulePerformancePredictionsRecalculationUploadUrlAsync(string businessUnitId, string weekId, string scheduleId, string body = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Reschedule
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="weekId">The week ID</param>
    /// <param name="scheduleId">The ID of the schedule</param>
    /// <param name="body">Reschedule request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Reschedule result (temporarily simplified as string)</returns>
    Task<string> RescheduleAsync(string businessUnitId, string weekId, string scheduleId, string body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update schedule
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="weekId">The week ID</param>
    /// <param name="scheduleId">The ID of the schedule</param>
    /// <param name="body">Update request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Update result (temporarily simplified as string)</returns>
    Task<string> UpdateScheduleAsync(string businessUnitId, string weekId, string scheduleId, string body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create schedule update upload URL
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="weekId">The week ID</param>
    /// <param name="scheduleId">The ID of the schedule</param>
    /// <param name="body">Upload URL request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Upload URL (temporarily simplified as string)</returns>
    Task<string> CreateScheduleUpdateUploadUrlAsync(string businessUnitId, string weekId, string scheduleId, string body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Search management unit agent schedules
    /// </summary>
    /// <param name="managementUnitId">The ID of the management unit</param>
    /// <param name="body">Search request</param>
    /// <param name="forceAsync">Force async</param>
    /// <param name="forceDownloadService">Force download service</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Search results (temporarily simplified as string)</returns>
    Task<string> SearchManagementUnitAgentSchedulesAsync(string managementUnitId, string body = null, bool? forceAsync = null, bool? forceDownloadService = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get users
    /// </summary>
    /// <param name="pageSize">Page size</param>
    /// <param name="pageNumber">Page number</param>
    /// <param name="sortBy">Sort by</param>
    /// <param name="expands">Expand options</param>
    /// <param name="feature">Feature filter</param>
    /// <param name="state">State filter</param>
    /// <param name="divisionId">Division ID filter</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Users list (temporarily simplified as string)</returns>
    Task<string> GetUsersAsync(int? pageSize = null, int? pageNumber = null, string sortBy = null, IEnumerable<string> expands = null, string feature = null, string state = null, string divisionId = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get user
    /// </summary>
    /// <param name="userId">The ID of the user</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>User (temporarily simplified as string)</returns>
    Task<string> GetUserAsync(string userId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get calendar URL ICS
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Calendar URL ICS (temporarily simplified as string)</returns>
    Task<string> GetCalendarUrlIcsAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Create calendar URL ICS
    /// </summary>
    /// <param name="body">Calendar URL request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Created calendar URL (temporarily simplified as string)</returns>
    Task<string> CreateCalendarUrlIcsAsync(string body = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get time zones
    /// </summary>
    /// <param name="pageSize">Page size</param>
    /// <param name="pageNumber">Page number</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Time zones list (temporarily simplified as string)</returns>
    Task<string> GetTimeZonesAsync(int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get time zone
    /// </summary>
    /// <param name="timeZoneId">The ID of the time zone</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Time zone (temporarily simplified as string)</returns>
    Task<string> GetTimeZoneAsync(string timeZoneId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get business units division views
    /// </summary>
    /// <param name="divisionId">Division IDs</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Business units division views (temporarily simplified as string)</returns>
    Task<string> GetBusinessUnitsDivisionViewsAsync(IEnumerable<string> divisionId = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get business unit activity plans
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="state">State filter</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Activity plans (temporarily simplified as string)</returns>
    Task<string> GetBusinessUnitActivityPlansAsync(string businessUnitId, string state = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get business unit activity plan jobs
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Activity plan jobs (temporarily simplified as string)</returns>
    Task<string> GetBusinessUnitActivityPlanJobsAsync(string businessUnitId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get business unit activity plan run job
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="jobId">The ID of the job</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Activity plan run job (temporarily simplified as string)</returns>
    Task<string> GetBusinessUnitActivityPlanRunJobAsync(string businessUnitId, string jobId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get business unit service goal template
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="serviceGoalTemplateId">The ID of the service goal template</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Service goal template (temporarily simplified as string)</returns>
    Task<string> GetBusinessUnitServiceGoalTemplateAsync(string businessUnitId, string serviceGoalTemplateId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get business unit service goal templates
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="expand">Expand options</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Service goal templates (temporarily simplified as string)</returns>
    Task<string> GetBusinessUnitServiceGoalTemplatesAsync(string businessUnitId, IEnumerable<string> expand = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get business unit staffing group
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="staffingGroupId">The ID of the staffing group</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Staffing group (temporarily simplified as string)</returns>
    Task<string> GetBusinessUnitStaffingGroupAsync(string businessUnitId, string staffingGroupId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get business unit staffing groups
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Staffing groups (temporarily simplified as string)</returns>
    Task<string> GetBusinessUnitStaffingGroupsAsync(string businessUnitId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get business unit time off limits
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="managementUnitId">Management unit ID filter</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Time off limits (temporarily simplified as string)</returns>
    Task<string> GetBusinessUnitTimeOffLimitsAsync(string businessUnitId, string managementUnitId = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get business unit time off limit
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="timeOffLimitId">The ID of the time off limit</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Time off limit (temporarily simplified as string)</returns>
    Task<string> GetBusinessUnitTimeOffLimitAsync(string businessUnitId, string timeOffLimitId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get business unit time off plans
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="managementUnitId">Management unit ID filter</param>
    /// <param name="forceDownloadService">Force download service</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Time off plans (temporarily simplified as string)</returns>
    Task<string> GetBusinessUnitTimeOffPlansAsync(string businessUnitId, string managementUnitId = null, bool? forceDownloadService = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get business unit time off plan
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="timeOffPlanId">The ID of the time off plan</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Time off plan (temporarily simplified as string)</returns>
    Task<string> GetBusinessUnitTimeOffPlanAsync(string businessUnitId, string timeOffPlanId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get business unit week schedules
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="weekId">The week ID</param>
    /// <param name="includeOnlyPublished">Include only published schedules</param>
    /// <param name="expand">Expand options</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Week schedules (temporarily simplified as string)</returns>
    Task<string> GetBusinessUnitWeekSchedulesAsync(string businessUnitId, string weekId, bool? includeOnlyPublished = null, IEnumerable<string> expand = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get business unit week schedule
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="weekId">The week ID</param>
    /// <param name="scheduleId">The ID of the schedule</param>
    /// <param name="expand">Expand options</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Week schedule (temporarily simplified as string)</returns>
    Task<string> GetBusinessUnitWeekScheduleAsync(string businessUnitId, string weekId, string scheduleId, IEnumerable<string> expand = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get business unit week schedule generation results
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="weekId">The week ID</param>
    /// <param name="scheduleId">The ID of the schedule</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Schedule generation results (temporarily simplified as string)</returns>
    Task<string> GetBusinessUnitWeekScheduleGenerationResultsAsync(string businessUnitId, string weekId, string scheduleId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get business unit week short term forecasts
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="weekDateId">The week date ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Short term forecasts (temporarily simplified as string)</returns>
    Task<string> GetBusinessUnitWeekShortTermForecastsAsync(string businessUnitId, string weekDateId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get business unit week short term forecast
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="weekDateId">The week date ID</param>
    /// <param name="forecastId">The ID of the forecast</param>
    /// <param name="expand">Expand options</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Short term forecast (temporarily simplified as string)</returns>
    Task<string> GetBusinessUnitWeekShortTermForecastAsync(string businessUnitId, string weekDateId, string forecastId, IEnumerable<string> expand = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get business unit week short term forecast data
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="weekDateId">The week date ID</param>
    /// <param name="forecastId">The ID of the forecast</param>
    /// <param name="weekNumber">Week number</param>
    /// <param name="forceDownloadService">Force download service</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Forecast data (temporarily simplified as string)</returns>
    Task<string> GetBusinessUnitWeekShortTermForecastDataAsync(string businessUnitId, string weekDateId, string forecastId, int? weekNumber = null, bool? forceDownloadService = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get business unit week short term forecast generation results
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="weekDateId">The week date ID</param>
    /// <param name="forecastId">The ID of the forecast</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Generation results (temporarily simplified as string)</returns>
    Task<string> GetBusinessUnitWeekShortTermForecastGenerationResultsAsync(string businessUnitId, string weekDateId, string forecastId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get business unit week short term forecast planning groups
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="weekDateId">The week date ID</param>
    /// <param name="forecastId">The ID of the forecast</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Planning groups (temporarily simplified as string)</returns>
    Task<string> GetBusinessUnitWeekShortTermForecastPlanningGroupsAsync(string businessUnitId, string weekDateId, string forecastId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get business unit week short term forecast staffing requirement
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="weekDateId">The week date ID</param>
    /// <param name="forecastId">The ID of the forecast</param>
    /// <param name="weekNumbers">Week numbers</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Staffing requirement (temporarily simplified as string)</returns>
    Task<string> GetBusinessUnitWeekShortTermForecastStaffingRequirementAsync(string businessUnitId, string weekDateId, string forecastId, IEnumerable<string> weekNumbers = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get business unit work plan bids
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Work plan bids (temporarily simplified as string)</returns>
    Task<string> GetBusinessUnitWorkPlanBidsAsync(string businessUnitId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get business unit work plan bid
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="bidId">The ID of the bid</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Work plan bid (temporarily simplified as string)</returns>
    Task<string> GetBusinessUnitWorkPlanBidAsync(string businessUnitId, string bidId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get business unit work plan bid group
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="bidId">The ID of the bid</param>
    /// <param name="bidGroupId">The ID of the bid group</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Work plan bid group (temporarily simplified as string)</returns>
    Task<string> GetBusinessUnitWorkPlanBidGroupAsync(string businessUnitId, string bidId, string bidGroupId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get business unit work plan bid group summary
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="bidId">The ID of the bid</param>
    /// <param name="bidGroupId">The ID of the bid group</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Work plan bid group summary (temporarily simplified as string)</returns>
    Task<string> GetBusinessUnitWorkPlanBidGroupSummaryAsync(string businessUnitId, string bidId, string bidGroupId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get business unit work plan bid group preferences
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="bidId">The ID of the bid</param>
    /// <param name="bidGroupId">The ID of the bid group</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Work plan bid group preferences (temporarily simplified as string)</returns>
    Task<string> GetBusinessUnitWorkPlanBidGroupPreferencesAsync(string businessUnitId, string bidId, string bidGroupId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get management unit work plans
    /// </summary>
    /// <param name="managementUnitId">The ID of the management unit</param>
    /// <param name="expand">Expand options</param>
    /// <param name="exclude">Exclude options</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Work plans (temporarily simplified as string)</returns>
    Task<string> GetManagementUnitWorkPlansAsync(string managementUnitId, IEnumerable<string> expand = null, IEnumerable<string> exclude = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get management unit work plan
    /// </summary>
    /// <param name="managementUnitId">The ID of the management unit</param>
    /// <param name="workPlanId">The ID of the work plan</param>
    /// <param name="includeOnly">Include only specific fields</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Work plan (temporarily simplified as string)</returns>
    Task<string> GetManagementUnitWorkPlanAsync(string managementUnitId, string workPlanId, IEnumerable<string> includeOnly = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get management unit work plan rotation
    /// </summary>
    /// <param name="managementUnitId">The ID of the management unit</param>
    /// <param name="workPlanRotationId">The ID of the work plan rotation</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Work plan rotation (temporarily simplified as string)</returns>
    Task<string> GetManagementUnitWorkPlanRotationAsync(string managementUnitId, string workPlanRotationId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get management unit schedules
    /// </summary>
    /// <param name="managementUnitId">The ID of the management unit</param>
    /// <param name="includeOnlyPublished">Include only published schedules</param>
    /// <param name="earliestWeekDate">Earliest week date</param>
    /// <param name="latestWeekDate">Latest week date</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Schedules (temporarily simplified as string)</returns>
    Task<string> GetManagementUnitSchedulesAsync(string managementUnitId, bool? includeOnlyPublished = null, string earliestWeekDate = null, string latestWeekDate = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get management unit time off requests
    /// </summary>
    /// <param name="managementUnitId">The ID of the management unit</param>
    /// <param name="recentlyReviewed">Recently reviewed filter</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Time off requests (temporarily simplified as string)</returns>
    Task<string> GetManagementUnitTimeOffRequestsAsync(string managementUnitId, bool? recentlyReviewed = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get management unit time off request
    /// </summary>
    /// <param name="managementUnitId">The ID of the management unit</param>
    /// <param name="timeOffRequestId">The ID of the time off request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Time off request (temporarily simplified as string)</returns>
    Task<string> GetManagementUnitTimeOffRequestAsync(string managementUnitId, string timeOffRequestId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create business unit service goal template
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="body">Service goal template request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Created service goal template (temporarily simplified as string)</returns>
    Task<string> CreateBusinessUnitServiceGoalTemplateAsync(string businessUnitId, string body = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create business unit staffing group
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="body">Staffing group request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Created staffing group (temporarily simplified as string)</returns>
    Task<string> CreateBusinessUnitStaffingGroupAsync(string businessUnitId, string body = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create business unit time off limit
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="body">Time off limit request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Created time off limit (temporarily simplified as string)</returns>
    Task<string> CreateBusinessUnitTimeOffLimitAsync(string businessUnitId, string body = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create business unit time off plan
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="body">Time off plan request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Created time off plan (temporarily simplified as string)</returns>
    Task<string> CreateBusinessUnitTimeOffPlanAsync(string businessUnitId, string body = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create business unit week schedule
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="weekId">The week ID</param>
    /// <param name="body">Schedule request</param>
    /// <param name="forceAsync">Force async</param>
    /// <param name="forceDownloadService">Force download service</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Created schedule (temporarily simplified as string)</returns>
    Task<string> CreateBusinessUnitWeekScheduleAsync(string businessUnitId, string weekId, string body, bool? forceAsync = null, bool? forceDownloadService = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create business unit week schedule copy
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="weekId">The week ID</param>
    /// <param name="scheduleId">The ID of the schedule</param>
    /// <param name="body">Copy request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Copy result (temporarily simplified as string)</returns>
    Task<string> CreateBusinessUnitWeekScheduleCopyAsync(string businessUnitId, string weekId, string scheduleId, string body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create business unit week schedule reschedule
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="weekId">The week ID</param>
    /// <param name="scheduleId">The ID of the schedule</param>
    /// <param name="body">Reschedule request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Reschedule result (temporarily simplified as string)</returns>
    Task<string> CreateBusinessUnitWeekScheduleRescheduleAsync(string businessUnitId, string weekId, string scheduleId, string body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create business unit work plan bid
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="body">Work plan bid request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Created work plan bid (temporarily simplified as string)</returns>
    Task<string> CreateBusinessUnitWorkPlanBidAsync(string businessUnitId, string body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create business unit work plan bid group
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="bidId">The ID of the bid</param>
    /// <param name="body">Bid group request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Created bid group (temporarily simplified as string)</returns>
    Task<string> CreateBusinessUnitWorkPlanBidGroupAsync(string businessUnitId, string bidId, string body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create management unit
    /// </summary>
    /// <param name="body">Management unit request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Created management unit (temporarily simplified as string)</returns>
    Task<string> CreateManagementUnitAsync(string body = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create management unit time off limit
    /// </summary>
    /// <param name="managementUnitId">The ID of the management unit</param>
    /// <param name="body">Time off limit request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Created time off limit (temporarily simplified as string)</returns>
    Task<string> CreateManagementUnitTimeOffLimitAsync(string managementUnitId, string body = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create management unit time off plan
    /// </summary>
    /// <param name="managementUnitId">The ID of the management unit</param>
    /// <param name="body">Time off plan request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Created time off plan (temporarily simplified as string)</returns>
    Task<string> CreateManagementUnitTimeOffPlanAsync(string managementUnitId, string body = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create management unit work plan rotation
    /// </summary>
    /// <param name="managementUnitId">The ID of the management unit</param>
    /// <param name="body">Work plan rotation request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Created work plan rotation (temporarily simplified as string)</returns>
    Task<string> CreateManagementUnitWorkPlanRotationAsync(string managementUnitId, string body = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create management unit work plan
    /// </summary>
    /// <param name="managementUnitId">The ID of the management unit</param>
    /// <param name="body">Work plan request</param>
    /// <param name="validationMode">Validation mode</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Created work plan (temporarily simplified as string)</returns>
    Task<string> CreateManagementUnitWorkPlanAsync(string managementUnitId, string body, string validationMode = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create schedules
    /// </summary>
    /// <param name="body">Schedules request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Created schedules (temporarily simplified as string)</returns>
    Task<string> CreateSchedulesAsync(string body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create time off balance job
    /// </summary>
    /// <param name="body">Time off balance job request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Created job (temporarily simplified as string)</returns>
    Task<string> CreateTimeOffBalanceJobAsync(string body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create time off limits available query
    /// </summary>
    /// <param name="body">Query request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Query results (temporarily simplified as string)</returns>
    Task<string> CreateTimeOffLimitsAvailableQueryAsync(string body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create time off requests estimate
    /// </summary>
    /// <param name="body">Estimate request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Estimate results (temporarily simplified as string)</returns>
    Task<string> CreateTimeOffRequestsEstimateAsync(string body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create time off requests integration status query
    /// </summary>
    /// <param name="body">Query request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Query results (temporarily simplified as string)</returns>
    Task<string> CreateTimeOffRequestsIntegrationStatusQueryAsync(string body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create team adherence historical
    /// </summary>
    /// <param name="teamId">The ID of the team</param>
    /// <param name="body">Historical request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Historical results (temporarily simplified as string)</returns>
    Task<string> CreateTeamAdherenceHistoricalAsync(string teamId, string body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create team shrinkage job
    /// </summary>
    /// <param name="teamId">The ID of the team</param>
    /// <param name="body">Shrinkage job request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Created job (temporarily simplified as string)</returns>
    Task<string> CreateTeamShrinkageJobAsync(string teamId, string body = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update agent integrations HRIS
    /// </summary>
    /// <param name="agentId">The ID of the agent</param>
    /// <param name="body">HRIS update request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Update results (temporarily simplified as string)</returns>
    Task<string> UpdateAgentIntegrationsHrisAsync(string agentId, string body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update business unit time off limit values
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="timeOffLimitId">The ID of the time off limit</param>
    /// <param name="body">Update request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Update results (temporarily simplified as string)</returns>
    Task<string> UpdateBusinessUnitTimeOffLimitValuesAsync(string businessUnitId, string timeOffLimitId, string body = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update management unit time off limit values
    /// </summary>
    /// <param name="managementUnitId">The ID of the management unit</param>
    /// <param name="timeOffLimitId">The ID of the time off limit</param>
    /// <param name="body">Update request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Update results (temporarily simplified as string)</returns>
    Task<string> UpdateManagementUnitTimeOffLimitValuesAsync(string managementUnitId, string timeOffLimitId, string body = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Validate management unit work plan
    /// </summary>
    /// <param name="managementUnitId">The ID of the management unit</param>
    /// <param name="workPlanId">The ID of the work plan</param>
    /// <param name="body">Validation request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Validation results (temporarily simplified as string)</returns>
    Task<string> ValidateManagementUnitWorkPlanAsync(string managementUnitId, string workPlanId, string body = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Copy management unit work plan
    /// </summary>
    /// <param name="managementUnitId">The ID of the management unit</param>
    /// <param name="workPlanId">The ID of the work plan</param>
    /// <param name="body">Copy request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Copy results (temporarily simplified as string)</returns>
    Task<string> CopyManagementUnitWorkPlanAsync(string managementUnitId, string workPlanId, string body = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Copy management unit work plan rotation
    /// </summary>
    /// <param name="managementUnitId">The ID of the management unit</param>
    /// <param name="workPlanRotationId">The ID of the work plan rotation</param>
    /// <param name="body">Copy request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Copy results (temporarily simplified as string)</returns>
    Task<string> CopyManagementUnitWorkPlanRotationAsync(string managementUnitId, string workPlanRotationId, string body = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create agents
    /// </summary>
    /// <param name="body">Agents request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Created agents (temporarily simplified as string)</returns>
    Task<string> CreateAgentsAsync(string body = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Query agent adherence explanations
    /// </summary>
    /// <param name="agentId">The ID of the agent</param>
    /// <param name="body">Query request</param>
    /// <param name="forceAsync">Force async</param>
    /// <param name="forceDownloadService">Force download service</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Query results (temporarily simplified as string)</returns>
    Task<string> QueryAgentAdherenceExplanationsAsync(string agentId, string body, bool? forceAsync = null, bool? forceDownloadService = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Query agents integrations HRIS
    /// </summary>
    /// <param name="body">Query request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Query results (temporarily simplified as string)</returns>
    Task<string> QueryAgentsIntegrationsHrisAsync(string body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update notifications
    /// </summary>
    /// <param name="body">Update request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Update results (temporarily simplified as string)</returns>
    Task<string> UpdateNotificationsAsync(string body, CancellationToken cancellationToken = default);
}
