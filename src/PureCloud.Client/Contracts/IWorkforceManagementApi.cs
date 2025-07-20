using PureCloud.Client.Models;

namespace PureCloud.Client.Contracts;

/// <summary>
/// Workforce Management API for managing business units, schedules, adherence, and workforce planning operations
/// </summary>
public interface IWorkforceManagementApi
{
    /// <summary>
    /// Delete a business unit by ID
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit to delete</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if the deletion was successful</returns>
    Task<bool> DeleteBusinessUnitAsync(string businessUnitId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a business unit activity code
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="activityCodeId">The ID of the activity code to delete</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if the deletion was successful</returns>
    Task<bool> DeleteBusinessUnitActivitycodeAsync(string businessUnitId, string activityCodeId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a business unit planning group
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="planningGroupId">The ID of the planning group to delete</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if the deletion was successful</returns>
    Task<bool> DeleteBusinessUnitPlanninggroupAsync(string businessUnitId, string planningGroupId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a business unit scheduling run
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="runId">The ID of the scheduling run to delete</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if the deletion was successful</returns>
    Task<bool> DeleteBusinessUnitSchedulingRunAsync(string businessUnitId, string runId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get an adherence explanation
    /// </summary>
    /// <param name="explanationId">The ID of the explanation to retrieve</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The adherence explanation</returns>
    Task<AdherenceExplanationResponse> GetAdherenceExplanationAsync(string explanationId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get status of an adherence explanation job
    /// </summary>
    /// <param name="jobId">The ID of the job to query</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The job status</returns>
    Task<AdherenceExplanationJobResponse> GetAdherenceExplanationsJobAsync(string jobId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get status of the historical adherence bulk job
    /// </summary>
    /// <param name="jobId">The ID of the job to query</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The job status</returns>
    Task<WfmHistoricalAdherenceBulkJobResponse> GetAdherenceHistoricalBulkJobAsync(string jobId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get status of the historical adherence job
    /// </summary>
    /// <param name="jobId">The ID of the job to query</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The job status</returns>
    Task<WfmHistoricalAdherenceResponse> GetAdherenceHistoricalJobAsync(string jobId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get an adherence explanation for an agent
    /// </summary>
    /// <param name="agentId">The ID of the agent</param>
    /// <param name="explanationId">The ID of the explanation</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The adherence explanation</returns>
    Task<AdherenceExplanationResponse> GetAgentAdherenceExplanationAsync(string agentId, string explanationId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the management unit to which the agent belongs
    /// </summary>
    /// <param name="agentId">The ID of the agent</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The management unit reference</returns>
    Task<AgentManagementUnitReference> GetAgentManagementunitAsync(string agentId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the management unit to which the currently logged in agent belongs
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The management unit reference</returns>
    Task<AgentManagementUnitReference> GetAgentsMeManagementunitAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Get alternative shifts offers job
    /// </summary>
    /// <param name="jobId">The ID of the job</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The alternative shift job response</returns>
    Task<AlternativeShiftJobResponse> GetAlternativeshiftsOffersJobAsync(string jobId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get alternative shifts offers search job
    /// </summary>
    /// <param name="jobId">The ID of the job</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The alternative shift job response</returns>
    Task<AlternativeShiftJobResponse> GetAlternativeshiftsOffersSearchJobAsync(string jobId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get alternative shift settings
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The alternative shift settings</returns>
    Task<AlternativeShiftBuSettingsResponse> GetAlternativeshiftsSettingsAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Get alternative shift trade by trade ID
    /// </summary>
    /// <param name="tradeId">The ID of the trade</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The alternative shift trade</returns>
    Task<AlternativeShiftTradeResponse> GetAlternativeshiftsTradeAsync(string tradeId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get alternative shift trades
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The alternative shift trades</returns>
    Task<AlternativeShiftTradeListing> GetAlternativeshiftsTradesAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Get alternative shift trades job
    /// </summary>
    /// <param name="jobId">The ID of the job</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The alternative shift job response</returns>
    Task<AlternativeShiftJobResponse> GetAlternativeshiftsTradesJobAsync(string jobId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get alternative shift trades state job
    /// </summary>
    /// <param name="jobId">The ID of the job</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The alternative shift job response</returns>
    Task<AlternativeShiftJobResponse> GetAlternativeshiftsTradesStateJobAsync(string jobId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get activity codes for a business unit
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The business unit activity code listing</returns>
    Task<BusinessUnitActivityCodeListing> GetBusinessUnitActivitycodesAsync(string businessUnitId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get an activity plan
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="activityPlanId">The ID of the activity plan</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The activity plan</returns>
    Task<ActivityPlanResponse> GetBusinessUnitActivityplanAsync(string businessUnitId, string activityPlanId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get activity plan job
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="activityPlanId">The ID of the activity plan</param>
    /// <param name="jobId">The ID of the job</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The activity plan job response</returns>
    Task<ActivityPlanJobResponse> GetBusinessUnitActivityplanRunsJobAsync(string businessUnitId, string activityPlanId, string jobId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get activity plans for a business unit
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The activity plan listing</returns>
    Task<ActivityPlanListing> GetBusinessUnitActivityplansAsync(string businessUnitId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get activity plan jobs for a business unit
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The activity plan job listing</returns>
    Task<ActivityPlanJobListing> GetBusinessUnitActivityplansJobsAsync(string businessUnitId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get alternative shift settings for a business unit
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The alternative shift settings</returns>
    Task<AlternativeShiftBuSettingsResponse> GetBusinessUnitAlternativeshiftsSettingsAsync(string businessUnitId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get alternative shift trade by business unit and trade ID
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="tradeId">The ID of the trade</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The alternative shift trade</returns>
    Task<AlternativeShiftTradeResponse> GetBusinessUnitAlternativeshiftsTradeAsync(string businessUnitId, string tradeId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get alternative shift trades search job for a business unit
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="jobId">The ID of the job</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The alternative shift job response</returns>
    Task<BuAlternativeShiftJobResponse> GetBusinessUnitAlternativeshiftsTradesSearchJobAsync(string businessUnitId, string jobId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get management units for a business unit
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The management unit listing</returns>
    Task<ManagementUnitListing> GetBusinessUnitManagementunitsAsync(string businessUnitId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get planning groups for a business unit
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The planning group listing</returns>
    Task<PlanningGroupList> GetBusinessUnitPlanninggroupsAsync(string businessUnitId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a scheduling run
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="runId">The ID of the scheduling run</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The scheduling run</returns>
    Task<BuScheduleRun> GetBusinessUnitSchedulingRunAsync(string businessUnitId, string runId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the result of a scheduling run
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="runId">The ID of the scheduling run</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The scheduling run result</returns>
    Task<BuAsyncScheduleRunResponse> GetBusinessUnitSchedulingRunResultAsync(string businessUnitId, string runId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get scheduling runs for a business unit
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The scheduling run listing</returns>
    Task<BuScheduleRunListing> GetBusinessUnitSchedulingRunsAsync(string businessUnitId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a service goal template
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="serviceGoalTemplateId">The ID of the service goal template</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The service goal template</returns>
    Task<ServiceGoalTemplate> GetBusinessUnitServicegoaltemplateAsync(string businessUnitId, string serviceGoalTemplateId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get service goal templates for a business unit
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The service goal template listing</returns>
    Task<ServiceGoalTemplateList> GetBusinessUnitServicegoaltemplatesAsync(string businessUnitId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a staffing group
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="staffingGroupId">The ID of the staffing group</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The staffing group</returns>
    Task<StaffingGroupResponse> GetBusinessUnitStaffinggroupAsync(string businessUnitId, string staffingGroupId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get staffing groups for a business unit
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The staffing group listing</returns>
    Task<StaffingGroupListing> GetBusinessUnitStaffinggroupsAsync(string businessUnitId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a time off limit
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="timeOffLimitId">The ID of the time off limit</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The time off limit</returns>
    Task<BuTimeOffLimitResponse> GetBusinessUnitTimeofflimitAsync(string businessUnitId, string timeOffLimitId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get time off limits for a business unit
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The time off limit listing</returns>
    Task<BuTimeOffLimitListing> GetBusinessUnitTimeofflimitsAsync(string businessUnitId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a time off plan
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="timeOffPlanId">The ID of the time off plan</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The time off plan</returns>
    Task<BuTimeOffPlanResponse> GetBusinessUnitTimeoffplanAsync(string businessUnitId, string timeOffPlanId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get time off plans for a business unit
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The time off plan listing</returns>
    Task<BuTimeOffPlanListing> GetBusinessUnitTimeoffplansAsync(string businessUnitId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a schedule for a business unit week
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="weekId">The week identifier</param>
    /// <param name="scheduleId">The ID of the schedule</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The schedule metadata</returns>
    Task<BuScheduleMetadata> GetBusinessUnitWeekScheduleAsync(string businessUnitId, string weekId, string scheduleId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get schedule generation results
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="weekId">The week identifier</param>
    /// <param name="scheduleId">The ID of the schedule</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The schedule generation result</returns>
    Task<ScheduleGenerationResult> GetBusinessUnitWeekScheduleGenerationresultsAsync(string businessUnitId, string weekId, string scheduleId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get schedule headcount forecast
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="weekId">The week identifier</param>
    /// <param name="scheduleId">The ID of the schedule</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The headcount forecast</returns>
    Task<BuHeadcountForecastResponse> GetBusinessUnitWeekScheduleHeadcountforecastAsync(string businessUnitId, string weekId, string scheduleId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get schedule history for an agent
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="weekId">The week identifier</param>
    /// <param name="scheduleId">The ID of the schedule</param>
    /// <param name="agentId">The ID of the agent</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The agent schedule history</returns>
    Task<BuAgentScheduleHistoryResponse> GetBusinessUnitWeekScheduleHistoryAgentAsync(string businessUnitId, string weekId, string scheduleId, string agentId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get schedule performance predictions
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="weekId">The week identifier</param>
    /// <param name="scheduleId">The ID of the schedule</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The performance prediction response</returns>
    Task<PerformancePredictionResponse> GetBusinessUnitWeekSchedulePerformancepredictionsAsync(string businessUnitId, string weekId, string scheduleId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get schedule performance predictions recalculation
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="weekId">The week identifier</param>
    /// <param name="scheduleId">The ID of the schedule</param>
    /// <param name="recalculationId">The ID of the recalculation</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The performance prediction recalculation response</returns>
    Task<PerformancePredictionRecalculationResponse> GetBusinessUnitWeekSchedulePerformancepredictionsRecalculationAsync(string businessUnitId, string weekId, string scheduleId, string recalculationId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get schedules for a business unit week
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="weekId">The week identifier</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The schedule listing</returns>
    Task<BuScheduleListing> GetBusinessUnitWeekSchedulesAsync(string businessUnitId, string weekId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a short term forecast
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="weekDateId">The week date identifier</param>
    /// <param name="forecastId">The ID of the forecast</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The short term forecast</returns>
    Task<BuShortTermForecast> GetBusinessUnitWeekShorttermforecastAsync(string businessUnitId, string weekDateId, string forecastId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get short term forecast data
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="weekDateId">The week date identifier</param>
    /// <param name="forecastId">The ID of the forecast</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The forecast operation result</returns>
    Task<AsyncForecastOperationResult> GetBusinessUnitWeekShorttermforecastDataAsync(string businessUnitId, string weekDateId, string forecastId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get calendar URL for ICS format
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The calendar URL response</returns>
    Task<CalendarUrlResponse> GetCalendarUrlIcsAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a business unit service goal template
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="serviceGoalTemplateId">The ID of the service goal template to delete</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if the deletion was successful</returns>
    Task<bool> DeleteBusinessUnitServicegoaltemplateAsync(string businessUnitId, string serviceGoalTemplateId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a business unit staffing group
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="staffingGroupId">The ID of the staffing group to delete</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if the deletion was successful</returns>
    Task<bool> DeleteBusinessUnitStaffinggroupAsync(string businessUnitId, string staffingGroupId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a business unit time off limit
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="timeOffLimitId">The ID of the time off limit to delete</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if the deletion was successful</returns>
    Task<bool> DeleteBusinessUnitTimeofflimitAsync(string businessUnitId, string timeOffLimitId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a business unit time off plan
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="timeOffPlanId">The ID of the time off plan to delete</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if the deletion was successful</returns>
    Task<bool> DeleteBusinessUnitTimeoffplanAsync(string businessUnitId, string timeOffPlanId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a business unit week schedule
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="weekId">The first day of the week schedule to delete in yyyy-MM-dd format</param>
    /// <param name="scheduleId">The ID of the schedule to delete</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The async schedule response</returns>
    Task<BuAsyncScheduleResponse> DeleteBusinessUnitWeekScheduleAsync(string businessUnitId, string weekId, string scheduleId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a business unit short term forecast
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="weekDateId">The week date for the forecast in yyyy-MM-dd format</param>
    /// <param name="forecastId">The ID of the forecast to delete</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if the deletion was successful</returns>
    Task<bool> DeleteBusinessUnitWeekShorttermforecastAsync(string businessUnitId, string weekDateId, string forecastId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a business unit work plan bid
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="bidId">The ID of the work plan bid to delete</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if the deletion was successful</returns>
    Task<bool> DeleteBusinessUnitWorkplanbidAsync(string businessUnitId, string bidId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a business unit work plan bid group
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="bidId">The ID of the work plan bid</param>
    /// <param name="bidGroupId">The ID of the bid group to delete</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if the deletion was successful</returns>
    Task<bool> DeleteBusinessUnitWorkplanbidGroupAsync(string businessUnitId, string bidId, string bidGroupId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a business unit
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The business unit information</returns>
    Task<BusinessUnit> GetBusinessUnitAsync(string businessUnitId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get an activity code from a business unit
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="activityCodeId">The ID of the activity code</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The activity code information</returns>
    Task<BusinessUnitActivityCode> GetBusinessUnitActivitycodeAsync(string businessUnitId, string activityCodeId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get activity codes for a business unit
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A listing of activity codes</returns>
    Task<BusinessUnitActivityCodeListing> GetBusinessUnitActivitycodesAsync(string businessUnitId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get an activity plan from a business unit
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="activityPlanId">The ID of the activity plan</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The activity plan information</returns>
    Task<ActivityPlanResponse> GetBusinessUnitActivityplanAsync(string businessUnitId, string activityPlanId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a specific job for an activity plan run
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="activityPlanId">The ID of the activity plan</param>
    /// <param name="jobId">The ID of the job</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The activity plan run job response</returns>
    Task<ActivityPlanRunJobResponse> GetBusinessUnitActivityplanRunsJobAsync(string businessUnitId, string activityPlanId, string jobId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get activity plans for a business unit
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="state">Optionally filter by state</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A listing of activity plans</returns>
    Task<ActivityPlanListing> GetBusinessUnitActivityplansAsync(string businessUnitId, string state = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get jobs for activity plans in a business unit
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A listing of activity plan jobs</returns>
    Task<ActivityPlanJobListing> GetBusinessUnitActivityplansJobsAsync(string businessUnitId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get alternative shift settings for a business unit
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The alternative shift settings</returns>
    Task<AlternativeShiftSettingsResponse> GetBusinessUnitAlternativeshiftsSettingsAsync(string businessUnitId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get an alternative shift trade for a business unit
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="tradeId">The ID of the trade</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The alternative shift trade information</returns>
    Task<AlternativeShiftTradeResponse> GetBusinessUnitAlternativeshiftsTradeAsync(string businessUnitId, string tradeId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get search job results for alternative shift trades
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="jobId">The ID of the search job</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The alternative shift trade search response</returns>
    Task<BuAsyncAlternativeShiftTradeSearchResponse> GetBusinessUnitAlternativeshiftsTradesSearchJobAsync(string businessUnitId, string jobId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get intraday planning groups for a business unit
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The intraday planning group listing</returns>
    Task<WfmIntradayPlanningGroupListing> GetBusinessUnitIntradayPlanninggroupsAsync(string businessUnitId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a planning group from a business unit
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="planningGroupId">The ID of the planning group</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The planning group information</returns>
    Task<PlanningGroup> GetBusinessUnitPlanninggroupAsync(string businessUnitId, string planningGroupId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get planning groups for a business unit
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A list of planning groups</returns>
    Task<PlanningGroupList> GetBusinessUnitPlanninggroupsAsync(string businessUnitId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a scheduling run for a business unit
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="runId">The ID of the run</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The schedule run response</returns>
    Task<BuAsyncScheduleRunResponse> GetBusinessUnitSchedulingRunAsync(string businessUnitId, string runId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get scheduling run result for a business unit
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="runId">The ID of the run</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The schedule generation result</returns>
    Task<ScheduleGenerationResult> GetBusinessUnitSchedulingRunResultAsync(string businessUnitId, string runId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get scheduling runs for a business unit
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A listing of schedule runs</returns>
    Task<BuScheduleRunListing> GetBusinessUnitSchedulingRunsAsync(string businessUnitId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a service goal template from a business unit
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="serviceGoalTemplateId">The ID of the service goal template</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The service goal template</returns>
    Task<ServiceGoalTemplate> GetBusinessUnitServicegoaltemplateAsync(string businessUnitId, string serviceGoalTemplateId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get service goal templates for a business unit
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A list of service goal templates</returns>
    Task<ServiceGoalTemplateList> GetBusinessUnitServicegoaltemplatesAsync(string businessUnitId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a staffing group from a business unit
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="staffingGroupId">The ID of the staffing group</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The staffing group response</returns>
    Task<StaffingGroupResponse> GetBusinessUnitStaffinggroupAsync(string businessUnitId, string staffingGroupId, CancellationToken cancellationToken = default);
    
    /// <summary>
    /// Get staffing groups for a business unit
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A listing of staffing groups</returns>
    Task<StaffingGroupListing> GetBusinessUnitStaffinggroupsAsync(string businessUnitId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a time off limit from a business unit
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="timeOffLimitId">The ID of the time off limit</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The time off limit response</returns>
    Task<BuTimeOffLimitResponse> GetBusinessUnitTimeofflimitAsync(string businessUnitId, string timeOffLimitId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get time off limits for a business unit
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A listing of time off limits</returns>
    Task<BuTimeOffLimitListing> GetBusinessUnitTimeofflimitsAsync(string businessUnitId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a time off plan from a business unit
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="timeOffPlanId">The ID of the time off plan</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The time off plan response</returns>
    Task<BuTimeOffPlanResponse> GetBusinessUnitTimeoffplanAsync(string businessUnitId, string timeOffPlanId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get time off plans for a business unit
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A listing of time off plans</returns>
    Task<BuTimeOffPlanListing> GetBusinessUnitTimeoffplansAsync(string businessUnitId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a schedule for a specific week in a business unit
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="weekId">The ID of the week</param>
    /// <param name="scheduleId">The ID of the schedule</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The schedule metadata</returns>
    Task<BuScheduleMetadata> GetBusinessUnitWeekScheduleAsync(string businessUnitId, string weekId, string scheduleId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get generation results for a schedule in a business unit week
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="weekId">The ID of the week</param>
    /// <param name="scheduleId">The ID of the schedule</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The schedule generation result summary</returns>
    Task<BuScheduleGenerationResultSummary> GetBusinessUnitWeekScheduleGenerationresultsAsync(string businessUnitId, string weekId, string scheduleId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get headcount forecast for a business unit week schedule
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="weekId">The ID of the week</param>
    /// <param name="scheduleId">The ID of the schedule</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The headcount forecast</returns>
    Task<BuHeadcountForecast> GetBusinessUnitWeekScheduleHeadcountforecastAsync(string businessUnitId, string weekId, string scheduleId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get schedule history for an agent in a business unit week
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="weekId">The ID of the week</param>
    /// <param name="scheduleId">The ID of the schedule</param>
    /// <param name="agentId">The ID of the agent</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The schedule history response</returns>
    Task<BuScheduleHistoryResponse> GetBusinessUnitWeekScheduleHistoryAgentAsync(string businessUnitId, string weekId, string scheduleId, string agentId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get performance predictions for a business unit week schedule
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="weekId">The ID of the week</param>
    /// <param name="scheduleId">The ID of the schedule</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The performance prediction response</returns>
    Task<PerformancePredictionResponse> GetBusinessUnitWeekSchedulePerformancepredictionsAsync(string businessUnitId, string weekId, string scheduleId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get performance prediction recalculation for a business unit week schedule
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="weekId">The ID of the week</param>
    /// <param name="scheduleId">The ID of the schedule</param>
    /// <param name="recalculationId">The ID of the recalculation</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The performance prediction recalculation response</returns>
    Task<PerformancePredictionRecalculationResponse> GetBusinessUnitWeekSchedulePerformancepredictionsRecalculationAsync(string businessUnitId, string weekId, string scheduleId, string recalculationId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get schedules for a business unit week
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="weekId">The ID of the week</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A listing of schedules</returns>
    Task<BuScheduleListing> GetBusinessUnitWeekSchedulesAsync(string businessUnitId, string weekId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a short term forecast for a business unit week
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="weekDateId">The week date ID</param>
    /// <param name="forecastId">The ID of the forecast</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The short term forecast</returns>
    Task<BuShortTermForecast> GetBusinessUnitWeekShorttermforecastAsync(string businessUnitId, string weekDateId, string forecastId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get forecast data for a business unit week
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="weekDateId">The week date ID</param>
    /// <param name="forecastId">The ID of the forecast</param>
    /// <param name="weekNumber">Optional week number</param>
    /// <param name="forceDownloadService">Optional force download service flag</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The forecast result response</returns>
    Task<BuForecastResultResponse> GetBusinessUnitWeekShorttermforecastDataAsync(string businessUnitId, string weekDateId, string forecastId, int? weekNumber = null, bool? forceDownloadService = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get forecast generation results for a business unit week
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="weekDateId">The week date ID</param>
    /// <param name="forecastId">The ID of the forecast</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The forecast generation result</returns>
    Task<BuForecastGenerationResult> GetBusinessUnitWeekShorttermforecastGenerationresultsAsync(string businessUnitId, string weekDateId, string forecastId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get long term forecast data for a business unit week short term forecast
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="weekDateId">The week date ID</param>
    /// <param name="forecastId">The ID of the forecast</param>
    /// <param name="forceDownloadService">Optional force download service flag</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The long term forecast result response</returns>
    Task<LongTermForecastResultResponse> GetBusinessUnitWeekShorttermforecastLongtermforecastdataAsync(string businessUnitId, string weekDateId, string forecastId, bool? forceDownloadService = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get planning groups for a business unit week short term forecast
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="weekDateId">The week date ID</param>
    /// <param name="forecastId">The ID of the forecast</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The forecast planning groups response</returns>
    Task<ForecastPlanningGroupsResponse> GetBusinessUnitWeekShorttermforecastPlanninggroupsAsync(string businessUnitId, string weekDateId, string forecastId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get staffing requirements for a business unit week short term forecast
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="weekDateId">The week date ID</param>
    /// <param name="forecastId">The ID of the forecast</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The forecast staffing requirements result response</returns>
    Task<BuForecastStaffingRequirementsResultResponse> GetBusinessUnitWeekShorttermforecastStaffingrequirementAsync(string businessUnitId, string weekDateId, string forecastId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get short term forecasts for a business unit week
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="weekDateId">The week date ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A listing of short term forecasts</returns>
    Task<BuShortTermForecastListing> GetBusinessUnitWeekShorttermforecastsAsync(string businessUnitId, string weekDateId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a work plan bid from a business unit
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="bidId">The ID of the work plan bid</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The work plan bid</returns>
    Task<WorkPlanBid> GetBusinessUnitWorkplanbidAsync(string businessUnitId, string bidId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a work plan bid group from a business unit
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="bidId">The ID of the work plan bid</param>
    /// <param name="bidGroupId">The ID of the bid group</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The work plan bid group response</returns>
    Task<WorkPlanBidGroupResponse> GetBusinessUnitWorkplanbidGroupAsync(string businessUnitId, string bidId, string bidGroupId, CancellationToken cancellationToken = default);
    Task<AgentWorkPlanBiddingPreferenceResponse> GetBusinessUnitWorkplanbidGroupPreferencesAsync(string businessUnitId, string bidId, string bidGroupId, CancellationToken cancellationToken = default);
    Task<WorkPlanBidGroupSummaryList> GetBusinessUnitWorkplanbidGroupsSummaryAsync(string businessUnitId, string bidId, CancellationToken cancellationToken = default);
    Task<WorkPlanBidListResponse> GetBusinessUnitWorkplanbidsAsync(string businessUnitId, CancellationToken cancellationToken = default);

    Task<ActivityPlanResponse> CreateBusinessUnitActivityplansAsync(string businessUnitId, CreateActivityPlanRequest body, CancellationToken cancellationToken = default);
    Task<ActivityPlanJobResponse> CreateBusinessUnitActivityplanRunsJobsAsync(string businessUnitId, string activityPlanId, CancellationToken cancellationToken = default);
    Task<PlanningGroup> CreateBusinessUnitPlanninggroupsAsync(string businessUnitId, CreatePlanningGroupRequest body, CancellationToken cancellationToken = default);
    Task<ServiceGoalTemplate> CreateBusinessUnitServicegoaltemplatesAsync(string businessUnitId, CreateServiceGoalTemplate body, CancellationToken cancellationToken = default);
    Task<StaffingGroupResponse> CreateBusinessUnitStaffinggroupsAsync(string businessUnitId, CreateStaffingGroupRequest body, CancellationToken cancellationToken = default);
    Task<UserStaffingGroupListing> CreateBusinessUnitStaffinggroupsQueryAsync(string businessUnitId, QueryUserStaffingGroupListRequest body, CancellationToken cancellationToken = default);
    Task<BuTimeOffLimitResponse> CreateBusinessUnitTimeofflimitsAsync(string businessUnitId, BuCreateTimeOffLimitRequest body, CancellationToken cancellationToken = default);
    Task<BuTimeOffLimitValueListing> CreateBusinessUnitTimeofflimitsValuesQueryAsync(string businessUnitId, QueryTimeOffLimitValuesRequest body, CancellationToken cancellationToken = default);
    Task<BuTimeOffPlanResponse> CreateBusinessUnitTimeoffplansAsync(string businessUnitId, BuCreateTimeOffPlanRequest body, CancellationToken cancellationToken = default);
    Task<BuAsyncScheduleResponse> CreateBusinessUnitWeekSchedulesAsync(string businessUnitId, string weekId, BuCreateBlankScheduleRequest body, CancellationToken cancellationToken = default);
    Task<BuAsyncScheduleResponse> CreateBusinessUnitWeekSchedulesImportAsync(string businessUnitId, string weekId, WfmProcessUploadRequest body, CancellationToken cancellationToken = default);
    Task<ImportScheduleUploadResponse> CreateBusinessUnitWeekSchedulesImportUploadurlAsync(string businessUnitId, string weekId, UploadUrlRequestBody body, CancellationToken cancellationToken = default);
    Task<PerformancePredictionRecalculationResponse> CreateBusinessUnitWeekSchedulePerformancepredictionsRecalculationsAsync(string businessUnitId, string weekId, string scheduleId, WfmProcessUploadRequest body, CancellationToken cancellationToken = default);
    Task<PerformancePredictionRecalculationUploadResponse> CreateBusinessUnitWeekSchedulePerformancepredictionsRecalculationsUploadurlAsync(string businessUnitId, string weekId, string scheduleId, UploadUrlRequestBody body, CancellationToken cancellationToken = default);
    Task<UpdateScheduleUploadResponse> CreateBusinessUnitWeekScheduleUpdateUploadurlAsync(string businessUnitId, string weekId, string scheduleId, UploadUrlRequestBody body, CancellationToken cancellationToken = default);
    Task<AsyncForecastOperationResult> CreateBusinessUnitWeekShorttermforecastsImportAsync(string businessUnitId, string weekDateId, WfmProcessUploadRequest body, CancellationToken cancellationToken = default);
    Task<ImportForecastUploadResponse> CreateBusinessUnitWeekShorttermforecastsImportUploadurlAsync(string businessUnitId, string weekDateId, UploadUrlRequestBody body, CancellationToken cancellationToken = default);
    Task<WorkPlanBid> CreateBusinessUnitWorkplanbidCopyAsync(string businessUnitId, string bidId, CopyWorkPlanBid body, CancellationToken cancellationToken = default);
    Task<WorkPlanBidGroupResponse> CreateBusinessUnitWorkplanbidGroupsAsync(string businessUnitId, string bidId, WorkPlanBidGroupCreate body, CancellationToken cancellationToken = default);
    Task<WorkPlanBid> CreateBusinessUnitWorkplanbidsAsync(string businessUnitId, CreateWorkPlanBid body, CancellationToken cancellationToken = default);

    Task<BusinessUnit> PatchBusinessUnitAsync(string businessUnitId, UpdateBusinessUnitRequest body, CancellationToken cancellationToken = default);
    Task<BusinessUnitActivityCode> PatchBusinessUnitActivitycodeAsync(string businessUnitId, string activityCodeId, UpdateActivityCodeRequest body, CancellationToken cancellationToken = default);
    Task<ActivityPlanResponse> PatchBusinessUnitActivityplanAsync(string businessUnitId, string activityPlanId, UpdateActivityPlanRequest body, CancellationToken cancellationToken = default);
    Task<AlternativeShiftSettingsResponse> PatchBusinessUnitAlternativeshiftsSettingsAsync(string businessUnitId, UpdateAlternativeShiftSettingsRequest body, CancellationToken cancellationToken = default);
    Task<PlanningGroup> PatchBusinessUnitPlanninggroupAsync(string businessUnitId, string planningGroupId, UpdatePlanningGroupRequest body, CancellationToken cancellationToken = default);
    Task<BuAsyncScheduleRunResponse> PatchBusinessUnitSchedulingRunAsync(string businessUnitId, string runId, UpdateScheduleRunRequest body, CancellationToken cancellationToken = default);
    Task<ServiceGoalTemplate> PatchBusinessUnitServicegoaltemplateAsync(string businessUnitId, string serviceGoalTemplateId, UpdateServiceGoalTemplate body, CancellationToken cancellationToken = default);
    Task<StaffingGroupResponse> PatchBusinessUnitStaffinggroupAsync(string businessUnitId, string staffingGroupId, UpdateStaffingGroupRequest body, CancellationToken cancellationToken = default);
    Task<BuTimeOffPlanResponse> PatchBusinessUnitTimeoffplanAsync(string businessUnitId, string timeOffPlanId, BuUpdateTimeOffPlanRequest body, CancellationToken cancellationToken = default);
    Task<WorkPlanBid> PatchBusinessUnitWorkplanbidAsync(string businessUnitId, string bidId, UpdateWorkPlanBid body, CancellationToken cancellationToken = default);
    Task<WorkPlanBidGroupResponse> PatchBusinessUnitWorkplanbidGroupAsync(string businessUnitId, string bidId, string bidGroupId, WorkPlanBidGroupUpdate body, CancellationToken cancellationToken = default);
    Task<AgentWorkPlanBiddingPreferenceResponse> PatchBusinessUnitWorkplanbidGroupPreferencesAsync(string businessUnitId, string bidId, string bidGroupId, AgentWorkPlanBiddingPreferenceRequest body, CancellationToken cancellationToken = default);

    // Management Unit Operations
    Task<bool> DeleteManagementunitAsync(string managementUnitId, CancellationToken cancellationToken = default);
    Task<bool> DeleteManagementunitTimeofflimitAsync(string managementUnitId, string timeOffLimitId, CancellationToken cancellationToken = default);
    Task<bool> DeleteManagementunitTimeoffplanAsync(string managementUnitId, string timeOffPlanId, CancellationToken cancellationToken = default);
    Task<bool> DeleteManagementunitWorkplanAsync(string managementUnitId, string workPlanId, CancellationToken cancellationToken = default);
    Task<bool> DeleteManagementunitWorkplanrotationAsync(string managementUnitId, string workPlanRotationId, CancellationToken cancellationToken = default);

    
    /// <summary>
    /// Get a management unit
    /// </summary>
    /// <param name="managementUnitId">The ID of the management unit</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The management unit information</returns>
    Task<ManagementUnit> GetManagementunitAsync(string managementUnitId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get activity codes for a management unit
    /// </summary>
    /// <param name="managementUnitId">The ID of the management unit</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The activity code container</returns>
    Task<ActivityCodeContainer> GetManagementunitActivitycodesAsync(string managementUnitId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get adherence data for a management unit
    /// </summary>
    /// <param name="managementUnitId">The ID of the management unit</param>
    /// <param name="forceDownloadService">Optional force download service flag</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Array of user schedule adherence</returns>
    Task<UserScheduleAdherence[]> GetManagementunitAdherenceAsync(string managementUnitId, bool? forceDownloadService = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get an agent from a management unit
    /// </summary>
    /// <param name="managementUnitId">The ID of the management unit</param>
    /// <param name="agentId">The ID of the agent</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The WFM agent information</returns>
    Task<WfmAgent> GetManagementunitAgentAsync(string managementUnitId, string agentId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get shift trades for an agent in a management unit
    /// </summary>
    /// <param name="managementUnitId">The ID of the management unit</param>
    /// <param name="agentId">The ID of the agent</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The shift trade list response</returns>
    Task<ShiftTradeListResponse> GetManagementunitAgentShifttradesAsync(string managementUnitId, string agentId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get matched shift trades for a management unit
    /// </summary>
    /// <param name="managementUnitId">The ID of the management unit</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The shift trade matches summary response</returns>
    Task<ShiftTradeMatchesSummaryResponse> GetManagementunitShifttradesMatchedAsync(string managementUnitId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get users available for shift trades in a management unit
    /// </summary>
    /// <param name="managementUnitId">The ID of the management unit</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The WFM user entity listing</returns>
    Task<WfmUserEntityListing> GetManagementunitShifttradesUsersAsync(string managementUnitId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a time off limit from a management unit
    /// </summary>
    /// <param name="managementUnitId">The ID of the management unit</param>
    /// <param name="timeOffLimitId">The ID of the time off limit</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The time off limit</returns>
    Task<TimeOffLimit> GetManagementunitTimeofflimitAsync(string managementUnitId, string timeOffLimitId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get time off limits for a management unit
    /// </summary>
    /// <param name="managementUnitId">The ID of the management unit</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A listing of time off limits</returns>
    Task<TimeOffLimitListing> GetManagementunitTimeofflimitsAsync(string managementUnitId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a time off plan from a management unit
    /// </summary>
    /// <param name="managementUnitId">The ID of the management unit</param>
    /// <param name="timeOffPlanId">The ID of the time off plan</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The time off plan</returns>
    Task<TimeOffPlan> GetManagementunitTimeoffplanAsync(string managementUnitId, string timeOffPlanId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get time off plans for a management unit
    /// </summary>
    /// <param name="managementUnitId">The ID of the management unit</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A listing of time off plans</returns>
    Task<TimeOffPlanListing> GetManagementunitTimeoffplansAsync(string managementUnitId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get time off requests for a management unit
    /// </summary>
    /// <param name="managementUnitId">The ID of the management unit</param>
    /// <param name="recentlyReviewed">Optional filter for recently reviewed requests</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A listing of time off requests</returns>
    Task<TimeOffRequestListing> GetManagementunitTimeoffrequestsAsync(string managementUnitId, bool? recentlyReviewed = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a time off request from a management unit
    /// </summary>
    /// <param name="managementUnitId">The ID of the management unit</param>
    /// <param name="timeOffRequestId">The ID of the time off request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The time off request</returns>
    Task<TimeOffRequest> GetManagementunitTimeoffrequestAsync(string managementUnitId, string timeOffRequestId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get time off balance job for a user in a management unit
    /// </summary>
    /// <param name="managementUnitId">The ID of the management unit</param>
    /// <param name="userId">The ID of the user</param>
    /// <param name="jobId">The ID of the job</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The time off balance job response</returns>
    Task<TimeOffBalanceJobResponse> GetManagementunitUserTimeoffbalanceJobAsync(string managementUnitId, string userId, string jobId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get time off balance job for a user time off request in a management unit
    /// </summary>
    /// <param name="managementUnitId">The ID of the management unit</param>
    /// <param name="userId">The ID of the user</param>
    /// <param name="timeOffRequestId">The ID of the time off request</param>
    /// <param name="jobId">The ID of the job</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The time off balance job response</returns>
    Task<TimeOffBalanceJobResponse> GetManagementunitUserTimeoffrequestTimeoffbalanceJobAsync(string managementUnitId, string userId, string timeOffRequestId, string jobId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get users for a management unit
    /// </summary>
    /// <param name="managementUnitId">The ID of the management unit</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The WFM user entity listing</returns>
    Task<WfmUserEntityListing> GetManagementunitUsersAsync(string managementUnitId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a shift trade for a management unit week
    /// </summary>
    /// <param name="managementUnitId">The ID of the management unit</param>
    /// <param name="weekDateId">The week date ID</param>
    /// <param name="tradeId">The ID of the trade</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The shift trade</returns>
    Task<ShiftTrade> GetManagementunitWeekShifttradeAsync(string managementUnitId, string weekDateId, string tradeId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get shift trades for a management unit week
    /// </summary>
    /// <param name="managementUnitId">The ID of the management unit</param>
    /// <param name="weekDateId">The week date ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The list of shift trades for the week</returns>
    Task<WeekShiftTradeListResponse> GetManagementunitWeekShifttradesAsync(string managementUnitId, string weekDateId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a work plan from a management unit
    /// </summary>
    /// <param name="managementUnitId">The ID of the management unit</param>
    /// <param name="workPlanId">The ID of the work plan</param>
    /// <param name="includeOnly">Optional filter to include only specific elements</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The work plan</returns>
    Task<WorkPlan> GetManagementunitWorkplanAsync(string managementUnitId, string workPlanId, bool? includeOnly = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a work plan rotation from a management unit
    /// </summary>
    /// <param name="managementUnitId">The ID of the management unit</param>
    /// <param name="workPlanRotationId">The ID of the work plan rotation</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The work plan rotation</returns>
    Task<WorkPlanRotationResponse> GetManagementunitWorkplanrotationAsync(string managementUnitId, string workPlanRotationId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get work plan rotations from a management unit
    /// </summary>
    /// <param name="managementUnitId">The ID of the management unit</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The list of work plan rotations</returns>
    Task<WorkPlanRotationListResponse> GetManagementunitWorkplanrotationsAsync(string managementUnitId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get work plans from a management unit
    /// </summary>
    /// <param name="managementUnitId">The ID of the management unit</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The list of work plans</returns>
    Task<WorkPlanListResponse> GetManagementunitWorkplansAsync(string managementUnitId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Query agent work plans for a management unit
    /// </summary>
    /// <param name="managementUnitId">The ID of the management unit</param>
    /// <param name="body">The query request body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The query result for agent work plans</returns>
    Task<MuAgentsWorkPlansResult> CreateManagementunitAgentsWorkplansQueryAsync(string managementUnitId, MuAgentsWorkPlansQueryRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Query historical adherence for a management unit
    /// </summary>
    /// <param name="managementUnitId">The ID of the management unit</param>
    /// <param name="body">The historical adherence query request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The historical adherence response</returns>
    Task<WfmHistoricalAdherenceResponse> CreateManagementunitHistoricaladherencequeryAsync(string managementUnitId, WfmHistoricalAdherenceQuery body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Move a management unit to another business unit
    /// </summary>
    /// <param name="managementUnitId">The ID of the management unit</param>
    /// <param name="body">The move request details</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The move operation response</returns>
    Task<MoveManagementUnitResponse> CreateManagementunitMoveAsync(string managementUnitId, MoveManagementUnitRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Search schedules for a management unit
    /// </summary>
    /// <param name="managementUnitId">The ID of the management unit</param>
    /// <param name="body">The schedule search request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The schedule search response</returns>
    Task<UserScheduleSearchResponse> CreateManagementunitSchedulesSearchAsync(string managementUnitId, UserScheduleSearchRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create shrinkage jobs for a management unit
    /// </summary>
    /// <param name="managementUnitId">The ID of the management unit</param>
    /// <param name="body">The shrinkage request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The shrinkage response</returns>
    Task<WfmHistoricalShrinkageResponse> CreateManagementunitShrinkageJobsAsync(string managementUnitId, WfmHistoricalShrinkageRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a time off limit for a management unit
    /// </summary>
    /// <param name="managementUnitId">The ID of the management unit</param>
    /// <param name="body">The time off limit creation request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The created time off limit</returns>
    Task<TimeOffLimit> CreateManagementunitTimeofflimitsAsync(string managementUnitId, CreateTimeOffLimitRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Query time off limit values for a management unit
    /// </summary>
    /// <param name="managementUnitId">The ID of the management unit</param>
    /// <param name="body">The query request for time off limit values</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The time off limit values</returns>
    Task<TimeOffLimitValueListing> CreateManagementunitTimeofflimitsValuesQueryAsync(string managementUnitId, QueryTimeOffLimitValuesRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a time off plan for a management unit
    /// </summary>
    /// <param name="managementUnitId">The ID of the management unit</param>
    /// <param name="body">The time off plan creation request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The created time off plan</returns>
    Task<TimeOffPlan> CreateManagementunitTimeoffplansAsync(string managementUnitId, CreateTimeOffPlanRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a time off request for a management unit
    /// </summary>
    /// <param name="managementUnitId">The ID of the management unit</param>
    /// <param name="body">The time off request creation details</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The created time off request</returns>
    Task<TimeOffRequest> CreateManagementunitTimeoffrequestsAsync(string managementUnitId, CreateTimeOffRequestRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Query time off request integration status for a management unit
    /// </summary>
    /// <param name="managementUnitId">The ID of the management unit</param>
    /// <param name="body">The integration status query request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The integration status response listing</returns>
    Task<TimeOffIntegrationStatusResponseListing> CreateManagementunitTimeoffrequestsIntegrationstatusQueryAsync(string managementUnitId, QueryTimeOffIntegrationStatusRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Query time off requests for a management unit
    /// </summary>
    /// <param name="managementUnitId">The ID of the management unit</param>
    /// <param name="body">The time off request query body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The time off request query response</returns>
    Task<TimeOffRequestQueryResponse> CreateManagementunitTimeoffrequestsQueryAsync(string managementUnitId, TimeOffRequestQueryBody body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Query waitlist positions for time off requests in a management unit
    /// </summary>
    /// <param name="managementUnitId">The ID of the management unit</param>
    /// <param name="body">The waitlist positions query request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The time off request listing with waitlist positions</returns>
    Task<TimeOffRequestListing> CreateManagementunitTimeoffrequestsWaitlistpositionsQueryAsync(string managementUnitId, QueryWaitlistPositionsRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create time off balance jobs for a user in a management unit
    /// </summary>
    /// <param name="managementUnitId">The ID of the management unit</param>
    /// <param name="userId">The ID of the user</param>
    /// <param name="body">The time off balance request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The time off balance job response</returns>
    Task<TimeOffBalanceJobResponse> CreateManagementunitUserTimeoffbalanceJobsAsync(string managementUnitId, string userId, TimeOffBalanceRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create time off balance jobs for a user's time off request in a management unit
    /// </summary>
    /// <param name="managementUnitId">The ID of the management unit</param>
    /// <param name="userId">The ID of the user</param>
    /// <param name="timeOffRequestId">The ID of the time off request</param>
    /// <param name="body">The time off balance request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The time off balance job response</returns>
    Task<TimeOffBalanceJobResponse> CreateManagementunitUserTimeoffrequestTimeoffbalanceJobsAsync(string managementUnitId, string userId, string timeOffRequestId, TimeOffBalanceRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Estimate time off request for a user in a management unit
    /// </summary>
    /// <param name="managementUnitId">The ID of the management unit</param>
    /// <param name="userId">The ID of the user</param>
    /// <param name="body">The time off request estimation details</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The time off request estimation response</returns>
    Task<EstimateTimeOffRequestResponse> CreateManagementunitUserTimeoffrequestsEstimateAsync(string managementUnitId, string userId, EstimateTimeOffRequestRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Match a shift trade for a management unit week
    /// </summary>
    /// <param name="managementUnitId">The ID of the management unit</param>
    /// <param name="weekDateId">The week date ID</param>
    /// <param name="tradeId">The ID of the trade</param>
    /// <param name="body">The shift trade match request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The trade match response</returns>
    Task<TradeMatchResponse> CreateManagementunitWeekShifttradeMatchAsync(string managementUnitId, string weekDateId, string tradeId, MatchShiftTradeRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create shift trades for a management unit week
    /// </summary>
    /// <param name="managementUnitId">The ID of the management unit</param>
    /// <param name="weekDateId">The week date ID</param>
    /// <param name="body">The shift trade creation request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The created shift trade</returns>
    Task<ShiftTrade> CreateManagementunitWeekShifttradesAsync(string managementUnitId, string weekDateId, AddShiftTradeRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Search shift trades for a management unit week
    /// </summary>
    /// <param name="managementUnitId">The ID of the management unit</param>
    /// <param name="weekDateId">The week date ID</param>
    /// <param name="body">The shift trade search request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The shift trade search response</returns>
    Task<SearchShiftTradesResponse> CreateManagementunitWeekShifttradesSearchAsync(string managementUnitId, string weekDateId, SearchShiftTradesRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Copy a work plan in a management unit
    /// </summary>
    /// <param name="managementUnitId">The ID of the management unit</param>
    /// <param name="workPlanId">The ID of the work plan to copy</param>
    /// <param name="body">The work plan copy request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The copied work plan</returns>
    Task<WorkPlan> CreateManagementunitWorkplanCopyAsync(string managementUnitId, string workPlanId, CopyWorkPlan body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Validate a work plan for a management unit
    /// </summary>
    /// <param name="managementUnitId">The ID of the management unit</param>
    /// <param name="workPlanId">The ID of the work plan to validate</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The work plan validation response</returns>
    Task<ValidateWorkPlanResponse> CreateManagementunitWorkplanValidateAsync(string managementUnitId, string workPlanId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Copy a work plan rotation in a management unit
    /// </summary>
    /// <param name="managementUnitId">The ID of the management unit</param>
    /// <param name="workPlanRotationId">The ID of the work plan rotation to copy</param>
    /// <param name="body">The work plan rotation copy request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The copied work plan rotation</returns>
    Task<WorkPlanRotationResponse> CreateManagementunitWorkplanrotationCopyAsync(string managementUnitId, string workPlanRotationId, CopyWorkPlanRotationRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create work plan rotations for a management unit
    /// </summary>
    /// <param name="managementUnitId">The ID of the management unit</param>
    /// <param name="body">The work plan rotation creation request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The created work plan rotation</returns>
    Task<WorkPlanRotationResponse> CreateManagementunitWorkplanrotationsAsync(string managementUnitId, CreateWorkPlanRotationRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create work plans for a management unit
    /// </summary>
    /// <param name="managementUnitId">The ID of the management unit</param>
    /// <param name="body">The work plan creation request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The created work plan</returns>
    Task<WorkPlan> CreateManagementunitWorkplansAsync(string managementUnitId, CreateWorkPlan body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update a management unit
    /// </summary>
    /// <param name="managementUnitId">The ID of the management unit</param>
    /// <param name="body">The management unit update request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The updated management unit</returns>
    Task<ManagementUnit> PatchManagementunitAsync(string managementUnitId, UpdateManagementUnitRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update agents' work plans in a management unit
    /// </summary>
    /// <param name="managementUnitId">The ID of the management unit</param>
    /// <param name="body">The batch update request for agent work plans</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The batch update response</returns>
    Task<UpdateMuAgentWorkPlansBatchResponse> PatchManagementunitAgentsAsync(string managementUnitId, UpdateMuAgentWorkPlansBatchRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Bulk update agent work plan bidding preferences for a management unit
    /// </summary>
    /// <param name="managementUnitId">The ID of the management unit</param>
    /// <param name="body">The bulk update request for bidding preferences</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The bulk update response</returns>
    Task<BulkUpdateAgentWorkPlanBiddingPreferenceResponse> PatchManagementunitAgentsWorkplansBulkAsync(string managementUnitId, BulkUpdateAgentWorkPlanBiddingPreferenceRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update a time off limit for a management unit
    /// </summary>
    /// <param name="managementUnitId">The ID of the management unit</param>
    /// <param name="timeOffLimitId">The ID of the time off limit</param>
    /// <param name="body">The time off limit update request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The updated time off limit</returns>
    Task<TimeOffLimit> PatchManagementunitTimeofflimitAsync(string managementUnitId, string timeOffLimitId, UpdateTimeOffLimitRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update a time off plan for a management unit
    /// </summary>
    /// <param name="managementUnitId">The ID of the management unit</param>
    /// <param name="timeOffPlanId">The ID of the time off plan</param>
    /// <param name="body">The time off plan update request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The updated time off plan</returns>
    Task<TimeOffPlan> PatchManagementunitTimeoffplanAsync(string managementUnitId, string timeOffPlanId, UpdateTimeOffPlanRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Set integration status for a user's time off request in a management unit
    /// </summary>
    /// <param name="managementUnitId">The ID of the management unit</param>
    /// <param name="timeOffRequestId">The ID of the time off request</param>
    /// <param name="userId">The ID of the user</param>
    /// <param name="body">The integration status request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The time off request response</returns>
    Task<TimeOffRequestResponse> PatchManagementunitTimeoffrequestUserIntegrationstatusAsync(string managementUnitId, string timeOffRequestId, string userId, SetTimeOffIntegrationStatusRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update a user's time off request in a management unit
    /// </summary>
    /// <param name="managementUnitId">The ID of the management unit</param>
    /// <param name="userId">The ID of the user</param>
    /// <param name="timeOffRequestId">The ID of the time off request</param>
    /// <param name="body">The time off request patch</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The updated time off request</returns>
    Task<TimeOffRequest> PatchManagementunitUserTimeoffrequestAsync(string managementUnitId, string userId, string timeOffRequestId, AdminTimeOffRequestPatch body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update a shift trade for a management unit week
    /// </summary>
    /// <param name="managementUnitId">The ID of the management unit</param>
    /// <param name="weekDateId">The week date ID</param>
    /// <param name="tradeId">The ID of the trade</param>
    /// <param name="body">The shift trade update request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The updated shift trade</returns>
    Task<ShiftTrade> PatchManagementunitWeekShifttradeAsync(string managementUnitId, string weekDateId, string tradeId, UpdateShiftTradeRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update a work plan for a management unit
    /// </summary>
    /// <param name="managementUnitId">The ID of the management unit</param>
    /// <param name="workPlanId">The ID of the work plan</param>
    /// <param name="body">The work plan update request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The updated work plan</returns>
    Task<WorkPlan> PatchManagementunitWorkplanAsync(string managementUnitId, string workPlanId, UpdateWorkPlan body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update a work plan rotation for a management unit
    /// </summary>
    /// <param name="managementUnitId">The ID of the management unit</param>
    /// <param name="workPlanRotationId">The ID of the work plan rotation</param>
    /// <param name="body">The work plan rotation update request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The updated work plan rotation</returns>
    Task<WorkPlanRotationResponse> PatchManagementunitWorkplanrotationAsync(string managementUnitId, string workPlanRotationId, UpdateWorkPlanRotationRequest body, CancellationToken cancellationToken = default);

    // Adherence Operations
    /// <summary>
    /// Get user schedule adherence
    /// </summary>
    /// <param name="userIds">The collection of user IDs to get adherence for</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Array of user schedule adherence data</returns>
    Task<UserScheduleAdherence[]> GetAdherenceAsync(IEnumerable<string> userIds, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get adherence explanation
    /// </summary>
    /// <param name="explanationId">The ID of the explanation</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The adherence explanation response</returns>
    Task<AdherenceExplanationResponse> GetAdherenceExplanationAsync(string explanationId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get adherence explanations job
    /// </summary>
    /// <param name="jobId">The ID of the job</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The adherence explanation job</returns>
    Task<AdherenceExplanationJob> GetAdherenceExplanationsJobAsync(string jobId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get historical adherence bulk job
    /// </summary>
    /// <param name="jobId">The ID of the job</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The historical adherence bulk job response</returns>
    Task<WfmHistoricalAdherenceBulkJobResponse> GetAdherenceHistoricalBulkJobAsync(string jobId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get historical adherence job
    /// </summary>
    /// <param name="jobId">The ID of the job</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The historical adherence response</returns>
    Task<WfmHistoricalAdherenceResponse> GetAdherenceHistoricalJobAsync(string jobId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get agent adherence explanation
    /// </summary>
    /// <param name="agentId">The ID of the agent</param>
    /// <param name="explanationId">The ID of the explanation</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The adherence explanation response</returns>
    Task<AdherenceExplanationResponse> GetAgentAdherenceExplanationAsync(string agentId, string explanationId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get agent management unit
    /// </summary>
    /// <param name="agentId">The ID of the agent</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The management unit</returns>
    Task<ManagementUnit> GetAgentManagementunitAsync(string agentId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get current user's management unit
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The management unit</returns>
    Task<ManagementUnit> GetAgentsMeManagementunitAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Create historical adherence query
    /// </summary>
    /// <param name="body">The historical adherence query</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The historical adherence response</returns>
    Task<WfmHistoricalAdherenceResponse> CreateAdherenceHistoricalAsync(WfmHistoricalAdherenceQuery body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create historical adherence bulk query
    /// </summary>
    /// <param name="body">The historical adherence bulk query</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The historical adherence bulk job response</returns>
    Task<WfmHistoricalAdherenceBulkJobResponse> CreateAdherenceHistoricalBulkAsync(WfmHistoricalAdherenceBulkQuery body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Query adherence explanations
    /// </summary>
    /// <param name="body">The agent query adherence explanations request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The query adherence explanations response</returns>
    Task<QueryAdherenceExplanationsResponse> CreateAdherenceExplanationsQueryAsync(AgentQueryAdherenceExplanationsRequest body, CancellationToken cancellationToken = default);

    // Calendar Operations
    /// <summary>
    /// Get calendar data ICS
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The calendar URL response</returns>
    Task<CalendarUrlResponse> GetCalendarDataIcsAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Get calendar URL ICS
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The calendar URL response</returns>
    Task<CalendarUrlResponse> GetCalendarUrlIcsAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete calendar URL ICS
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if deletion was successful</returns>
    Task<bool> DeleteCalendarUrlIcsAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Create calendar URL ICS
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The calendar URL response</returns>
    Task<CalendarUrlResponse> CreateCalendarUrlIcsAsync(CancellationToken cancellationToken = default);

    // Business Units Listing
    /// <summary>
    /// Get business units
    /// </summary>
    /// <param name="feature">Optional feature filter</param>
    /// <param name="divisionId">Optional division ID filter</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The business unit listing</returns>
    Task<BusinessUnitListing> GetBusinessunitsAsync(string feature = null, string divisionId = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get business units division views
    /// </summary>
    /// <param name="divisionId">Optional list of division IDs</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The business unit listing</returns>
    Task<BusinessUnitListing> GetBusinessunitsDivisionviewsAsync(List<string> divisionId = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a business unit
    /// </summary>
    /// <param name="body">The business unit creation request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The created business unit</returns>
    Task<BusinessUnit> CreateBusinessunitsAsync(CreateBusinessUnitRequest body, CancellationToken cancellationToken = default);

    // Management Units Listing  
    /// <summary>
    /// Get management units
    /// </summary>
    /// <param name="pageSize">Optional page size</param>
    /// <param name="pageNumber">Optional page number</param>
    /// <param name="expand">Optional expand parameter</param>
    /// <param name="feature">Optional feature filter</param>
    /// <param name="divisionId">Optional division ID filter</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The management unit listing</returns>
    Task<ManagementUnitListing> GetManagementunitsAsync(int? pageSize = null, int? pageNumber = null, string expand = null, string feature = null, string divisionId = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create management units
    /// </summary>
    /// <param name="body">The management unit creation request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The management unit listing</returns>
    Task<ManagementUnitListing> CreateManagementunitsAsync(CreateManagementUnitRequest body, CancellationToken cancellationToken = default);

    // Time Off Operations
    /// <summary>
    /// Get time off balance job
    /// </summary>
    /// <param name="jobId">The ID of the job</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The time off balance job response</returns>
    Task<TimeOffBalanceJobResponse> GetTimeoffbalanceJobAsync(string jobId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get time off request
    /// </summary>
    /// <param name="timeOffRequestId">The ID of the time off request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The time off request</returns>
    Task<TimeOffRequest> GetTimeoffrequestAsync(string timeOffRequestId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get time off requests
    /// </summary>
    /// <param name="recentlyReviewed">Optional filter for recently reviewed requests</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The time off request listing</returns>
    Task<TimeOffRequestListing> GetTimeoffrequestsAsync(bool? recentlyReviewed = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get user work plan bid ranks
    /// </summary>
    /// <param name="userId">The ID of the user</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The user work plan bid ranks</returns>
    Task<UserWorkPlanBidRanks> GetUserWorkplanbidranksAsync(string userId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get user work plan bids
    /// </summary>
    /// <param name="userId">The ID of the user</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The user work plan bid list response</returns>
    Task<UserWorkPlanBidListResponse> GetUserWorkplanbidsAsync(string userId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get work plan bids
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The work plan bid list response</returns>
    Task<WorkPlanBidListResponse> GetWorkplanbidsAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Create time off balance jobs
    /// </summary>
    /// <param name="body">The time off balance request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The time off balance job response</returns>
    Task<TimeOffBalanceJobResponse> CreateTimeoffbalanceJobsAsync(TimeOffBalanceRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Query available time off limits
    /// </summary>
    /// <param name="body">The query time off limit values request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The query time off limit values response</returns>
    Task<QueryTimeOffLimitValuesResponse> CreateTimeofflimitsAvailableQueryAsync(QueryTimeOffLimitValuesRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create time off requests
    /// </summary>
    /// <param name="body">The time off request creation request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The created time off request</returns>
    Task<TimeOffRequest> CreateTimeoffrequestsAsync(CreateTimeOffRequestRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Estimate time off requests
    /// </summary>
    /// <param name="body">The time off request estimation request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The estimate time off request response</returns>
    Task<EstimateTimeOffRequestResponse> CreateTimeoffrequestsEstimateAsync(EstimateTimeOffRequestRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Query time off request integration status
    /// </summary>
    /// <param name="body">The query time off integration status request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The time off integration status response listing</returns>
    Task<TimeOffIntegrationStatusResponseListing> CreateTimeoffrequestsIntegrationstatusQueryAsync(QueryTimeOffIntegrationStatusRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update time off request
    /// </summary>
    /// <param name="timeOffRequestId">The ID of the time off request</param>
    /// <param name="body">The admin time off request patch</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The updated time off request</returns>
    Task<TimeOffRequest> PatchTimeoffrequestAsync(string timeOffRequestId, AdminTimeOffRequestPatch body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update user work plan bid ranks
    /// </summary>
    /// <param name="userId">The ID of the user</param>
    /// <param name="body">The work plan bid ranks</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The updated user work plan bid ranks</returns>
    Task<UserWorkPlanBidRanks> PatchUserWorkplanbidranksAsync(string userId, WorkPlanBidRanks body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Bulk update user work plan bid ranks
    /// </summary>
    /// <param name="body">The bulk update agent work plan bidding preference request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The bulk update agent work plan bidding preference response</returns>
    Task<BulkUpdateAgentWorkPlanBiddingPreferenceResponse> PatchUsersWorkplanbidranksBulkAsync(BulkUpdateAgentWorkPlanBiddingPreferenceRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update work plan bid preferences
    /// </summary>
    /// <param name="body">The agent work plan bidding preference request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The agent work plan bidding preference response</returns>
    Task<AgentWorkPlanBiddingPreferenceResponse> PatchWorkplanbidPreferencesAsync(AgentWorkPlanBiddingPreferenceRequest body, CancellationToken cancellationToken = default);

    // Alternative Shifts and Other Operations
    /// <summary>
    /// Get alternative shift offers job
    /// </summary>
    /// <param name="jobId">The ID of the job</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The list alternative shift offers response</returns>
    Task<ListAlternativeShiftOffersResponse> GetAlternativeshiftsOffersJobAsync(string jobId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get alternative shift offers search job
    /// </summary>
    /// <param name="jobId">The ID of the job</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The business unit list alternative shift offers response</returns>
    Task<BuListAlternativeShiftOffersResponse> GetAlternativeshiftsOffersSearchJobAsync(string jobId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get alternative shift settings
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The alternative shift settings response</returns>
    Task<AlternativeShiftSettingsResponse> GetAlternativeshiftsSettingsAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Get alternative shift trade
    /// </summary>
    /// <param name="tradeId">The ID of the trade</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The alternative shift trade response</returns>
    Task<AlternativeShiftTradeResponse> GetAlternativeshiftsTradeAsync(string tradeId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get alternative shift trades job
    /// </summary>
    /// <param name="jobId">The ID of the job</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The list alternative shift trades response</returns>
    Task<ListAlternativeShiftTradesResponse> GetAlternativeshiftsTradesJobAsync(string jobId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get alternative shift trades state job
    /// </summary>
    /// <param name="jobId">The ID of the job</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The business unit alternative shift trade state response</returns>
    Task<BuAlternativeShiftTradeStateResponse> GetAlternativeshiftsTradesStateJobAsync(string jobId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update alternative shift trade
    /// </summary>
    /// <param name="tradeId">The ID of the trade</param>
    /// <param name="body">The update alternative shift trade request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The updated alternative shift trade response</returns>
    Task<AlternativeShiftTradeResponse> PatchAlternativeshiftsTradeAsync(string tradeId, UpdateAlternativeShiftTradeRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create alternative shift trades
    /// </summary>
    /// <param name="body">The create alternative shift trade request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The create alternative shift trade response</returns>
    Task<CreateAlternativeShiftTradeResponse> CreateAlternativeshiftsTradesAsync(CreateAlternativeShiftTradeRequest body, CancellationToken cancellationToken = default);

    // Additional Operations
    /// <summary>
    /// Create agents upload operation
    /// </summary>
    /// <param name="body">The WFM process upload request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The long running operation status response</returns>
    Task<LongRunningOperationStatusResponse> CreateAgentsAsync(WfmProcessUploadRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get HRIS integrations
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The HRIS integrations response</returns>
    Task<HrisIntegrationsResponse> GetIntegrationsHrisAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Get HRIS time off types job
    /// </summary>
    /// <param name="jobId">The ID of the job</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The HRIS time off types job response</returns>
    Task<HrisTimeOffTypesJobResponse> GetIntegrationsHrisTimeofftypesJobAsync(string jobId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create HRIS time off types jobs
    /// </summary>
    /// <param name="body">The HRIS time off types request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The HRIS time off types response</returns>
    Task<HrisTimeOffTypesResponse> CreateIntegrationsHriTimeofftypesJobsAsync(HrisTimeOffTypesRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Query agents integrations HRIS
    /// </summary>
    /// <param name="body">The query agents integrations request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The agents integrations listing</returns>
    Task<AgentsIntegrationsListing> CreateAgentsIntegrationsHrisQueryAsync(QueryAgentsIntegrationsRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create possible work shifts for current agent
    /// </summary>
    /// <param name="body">The query alternative shift for agents request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The bulk update agent alternative shift response</returns>
    Task<BulkUpdateAgentAlternativeShiftResponse> CreateAgentsMePossibleworkshiftsAsync(QueryAlternativeShiftForAgentsRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create agent schedules mine
    /// </summary>
    /// <param name="body">The business unit current agent schedule search request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The business unit current agent schedule search response</returns>
    Task<BuCurrentAgentScheduleSearchResponse> CreateAgentschedulesMineAsync(BuCurrentAgentScheduleSearchRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update agent integrations HRIS
    /// </summary>
    /// <param name="agentId">The ID of the agent</param>
    /// <param name="body">The agent integrations request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The HRIS integration response</returns>
    Task<HrisIntegrationResponse> UpdateAgentIntegrationsHrisAsync(string agentId, AgentIntegrationsRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update business unit time off limit values
    /// </summary>
    /// <param name="businessUnitId">The ID of the business unit</param>
    /// <param name="timeOffLimitId">The ID of the time off limit</param>
    /// <param name="body">The business unit set time off limit values request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The business unit time off limit response</returns>
    Task<BuTimeOffLimitResponse> UpdateBusinessUnitTimeofflimitValuesAsync(string businessUnitId, string timeOffLimitId, BuSetTimeOffLimitValuesRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update management unit time off limit values
    /// </summary>
    /// <param name="managementUnitId">The ID of the management unit</param>
    /// <param name="timeOffLimitId">The ID of the time off limit</param>
    /// <param name="body">The set time off limit values request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The updated time off limit</returns>
    Task<TimeOffLimit> UpdateManagementunitTimeofflimitValuesAsync(string managementUnitId, string timeOffLimitId, SetTimeOffLimitValuesRequest body, CancellationToken cancellationToken = default);

    // Historical Data Operations
    /// <summary>
    /// Get historical data bulk remove job
    /// </summary>
    /// <param name="jobId">The ID of the job</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The historical import delete job response</returns>
    Task<HistoricalImportDeleteJobResponse> GetHistoricaldataBulkRemoveJobAsync(string jobId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get historical data bulk remove jobs
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The historical import delete job listing</returns>
    Task<HistoricalImportDeleteJobListing> GetHistoricaldataBulkRemoveJobsAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Get historical data delete job
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The historical import status listing</returns>
    Task<HistoricalImportStatusListing> GetHistoricaldataDeletejobAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Get historical data import status
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The import status response</returns>
    Task<ImportStatusResponse> GetHistoricaldataImportstatusAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Get historical data import status by job ID
    /// </summary>
    /// <param name="jobId">The ID of the job</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The import status response</returns>
    Task<ImportStatusResponse> GetHistoricaldataImportstatusJobIdAsync(string jobId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create historical data bulk remove jobs
    /// </summary>
    /// <param name="body">The historical import delete job request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The historical import delete job response</returns>
    Task<HistoricalImportDeleteJobResponse> CreateHistoricaldataBulkRemoveJobsAsync(HistoricalImportDeleteJobRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create historical data delete job
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The historical import status listing</returns>
    Task<HistoricalImportStatusListing> CreateHistoricaldataDeletejobAsync(CancellationToken cancellationToken = default);

    // Notification and Schedule Operations
    /// <summary>
    /// Create notifications update
    /// </summary>
    /// <param name="body">The update notifications request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The update notifications response</returns>
    Task<UpdateNotificationsResponse> CreateNotificationsUpdateAsync(UpdateNotificationsRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create schedules
    /// </summary>
    /// <param name="body">The current user schedule request body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The user schedule container</returns>
    Task<UserScheduleContainer> CreateSchedulesAsync(CurrentUserScheduleRequestBody body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create team adherence historical query
    /// </summary>
    /// <param name="body">The WFM historical adherence query</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The WFM historical adherence response</returns>
    Task<WfmHistoricalAdherenceResponse> CreateTeamAdherenceHistoricalAsync(WfmHistoricalAdherenceQuery body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create team shrinkage jobs
    /// </summary>
    /// <param name="body">The WFM historical shrinkage request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The WFM historical shrinkage response</returns>
    Task<WfmHistoricalShrinkageResponse> CreateTeamShrinkageJobsAsync(WfmHistoricalShrinkageRequest body, CancellationToken cancellationToken = default);
}

