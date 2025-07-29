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
}
