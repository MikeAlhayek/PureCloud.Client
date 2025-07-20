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

    Task<BusinessUnit> GetBusinessUnitAsync(string businessUnitId, CancellationToken cancellationToken = default);
    Task<BusinessUnitActivityCode> GetBusinessUnitActivitycodeAsync(string businessUnitId, string activityCodeId, CancellationToken cancellationToken = default);
    Task<BusinessUnitActivityCodeListing> GetBusinessUnitActivitycodesAsync(string businessUnitId, CancellationToken cancellationToken = default);
    Task<ActivityPlanResponse> GetBusinessUnitActivityplanAsync(string businessUnitId, string activityPlanId, CancellationToken cancellationToken = default);
    Task<ActivityPlanRunJobResponse> GetBusinessUnitActivityplanRunsJobAsync(string businessUnitId, string activityPlanId, string jobId, CancellationToken cancellationToken = default);
    Task<ActivityPlanListing> GetBusinessUnitActivityplansAsync(string businessUnitId, string state = null, CancellationToken cancellationToken = default);
    Task<ActivityPlanJobListing> GetBusinessUnitActivityplansJobsAsync(string businessUnitId, CancellationToken cancellationToken = default);
    Task<AlternativeShiftSettingsResponse> GetBusinessUnitAlternativeshiftsSettingsAsync(string businessUnitId, CancellationToken cancellationToken = default);
    Task<AlternativeShiftTradeResponse> GetBusinessUnitAlternativeshiftsTradeAsync(string businessUnitId, string tradeId, CancellationToken cancellationToken = default);
    Task<BuAsyncAlternativeShiftTradeSearchResponse> GetBusinessUnitAlternativeshiftsTradesSearchJobAsync(string businessUnitId, string jobId, CancellationToken cancellationToken = default);
    Task<WfmIntradayPlanningGroupListing> GetBusinessUnitIntradayPlanninggroupsAsync(string businessUnitId, CancellationToken cancellationToken = default);
    Task<PlanningGroup> GetBusinessUnitPlanninggroupAsync(string businessUnitId, string planningGroupId, CancellationToken cancellationToken = default);
    Task<PlanningGroupList> GetBusinessUnitPlanninggroupsAsync(string businessUnitId, CancellationToken cancellationToken = default);
    Task<BuAsyncScheduleRunResponse> GetBusinessUnitSchedulingRunAsync(string businessUnitId, string runId, CancellationToken cancellationToken = default);
    Task<ScheduleGenerationResult> GetBusinessUnitSchedulingRunResultAsync(string businessUnitId, string runId, CancellationToken cancellationToken = default);
    Task<BuScheduleRunListing> GetBusinessUnitSchedulingRunsAsync(string businessUnitId, CancellationToken cancellationToken = default);
    Task<ServiceGoalTemplate> GetBusinessUnitServicegoaltemplateAsync(string businessUnitId, string serviceGoalTemplateId, CancellationToken cancellationToken = default);
    Task<ServiceGoalTemplateList> GetBusinessUnitServicegoaltemplatesAsync(string businessUnitId, CancellationToken cancellationToken = default);
    Task<StaffingGroupResponse> GetBusinessUnitStaffinggroupAsync(string businessUnitId, string staffingGroupId, CancellationToken cancellationToken = default);
    Task<StaffingGroupListing> GetBusinessUnitStaffinggroupsAsync(string businessUnitId, CancellationToken cancellationToken = default);
    Task<BuTimeOffLimitResponse> GetBusinessUnitTimeofflimitAsync(string businessUnitId, string timeOffLimitId, CancellationToken cancellationToken = default);
    Task<BuTimeOffLimitListing> GetBusinessUnitTimeofflimitsAsync(string businessUnitId, CancellationToken cancellationToken = default);
    Task<BuTimeOffPlanResponse> GetBusinessUnitTimeoffplanAsync(string businessUnitId, string timeOffPlanId, CancellationToken cancellationToken = default);
    Task<BuTimeOffPlanListing> GetBusinessUnitTimeoffplansAsync(string businessUnitId, CancellationToken cancellationToken = default);
    Task<BuScheduleMetadata> GetBusinessUnitWeekScheduleAsync(string businessUnitId, string weekId, string scheduleId, CancellationToken cancellationToken = default);
    Task<BuScheduleGenerationResultSummary> GetBusinessUnitWeekScheduleGenerationresultsAsync(string businessUnitId, string weekId, string scheduleId, CancellationToken cancellationToken = default);
    Task<BuHeadcountForecast> GetBusinessUnitWeekScheduleHeadcountforecastAsync(string businessUnitId, string weekId, string scheduleId, CancellationToken cancellationToken = default);
    Task<BuScheduleHistoryResponse> GetBusinessUnitWeekScheduleHistoryAgentAsync(string businessUnitId, string weekId, string scheduleId, string agentId, CancellationToken cancellationToken = default);
    Task<PerformancePredictionResponse> GetBusinessUnitWeekSchedulePerformancepredictionsAsync(string businessUnitId, string weekId, string scheduleId, CancellationToken cancellationToken = default);
    Task<PerformancePredictionRecalculationResponse> GetBusinessUnitWeekSchedulePerformancepredictionsRecalculationAsync(string businessUnitId, string weekId, string scheduleId, string recalculationId, CancellationToken cancellationToken = default);
    Task<BuScheduleListing> GetBusinessUnitWeekSchedulesAsync(string businessUnitId, string weekId, CancellationToken cancellationToken = default);
    Task<BuShortTermForecast> GetBusinessUnitWeekShorttermforecastAsync(string businessUnitId, string weekDateId, string forecastId, CancellationToken cancellationToken = default);
    Task<BuForecastResultResponse> GetBusinessUnitWeekShorttermforecastDataAsync(string businessUnitId, string weekDateId, string forecastId, int? weekNumber = null, bool? forceDownloadService = null, CancellationToken cancellationToken = default);
    Task<BuForecastGenerationResult> GetBusinessUnitWeekShorttermforecastGenerationresultsAsync(string businessUnitId, string weekDateId, string forecastId, CancellationToken cancellationToken = default);
    Task<LongTermForecastResultResponse> GetBusinessUnitWeekShorttermforecastLongtermforecastdataAsync(string businessUnitId, string weekDateId, string forecastId, bool? forceDownloadService = null, CancellationToken cancellationToken = default);
    Task<ForecastPlanningGroupsResponse> GetBusinessUnitWeekShorttermforecastPlanninggroupsAsync(string businessUnitId, string weekDateId, string forecastId, CancellationToken cancellationToken = default);
    Task<BuForecastStaffingRequirementsResultResponse> GetBusinessUnitWeekShorttermforecastStaffingrequirementAsync(string businessUnitId, string weekDateId, string forecastId, CancellationToken cancellationToken = default);
    Task<BuShortTermForecastListing> GetBusinessUnitWeekShorttermforecastsAsync(string businessUnitId, string weekDateId, CancellationToken cancellationToken = default);
    Task<WorkPlanBid> GetBusinessUnitWorkplanbidAsync(string businessUnitId, string bidId, CancellationToken cancellationToken = default);
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

    Task<ManagementUnit> GetManagementunitAsync(string managementUnitId, CancellationToken cancellationToken = default);
    Task<ActivityCodeContainer> GetManagementunitActivitycodesAsync(string managementUnitId, CancellationToken cancellationToken = default);
    Task<UserScheduleAdherence[]> GetManagementunitAdherenceAsync(string managementUnitId, bool? forceDownloadService = null, CancellationToken cancellationToken = default);
    Task<WfmAgent> GetManagementunitAgentAsync(string managementUnitId, string agentId, CancellationToken cancellationToken = default);
    Task<ShiftTradeListResponse> GetManagementunitAgentShifttradesAsync(string managementUnitId, string agentId, CancellationToken cancellationToken = default);
    Task<ShiftTradeMatchesSummaryResponse> GetManagementunitShifttradesMatchedAsync(string managementUnitId, CancellationToken cancellationToken = default);
    Task<WfmUserEntityListing> GetManagementunitShifttradesUsersAsync(string managementUnitId, CancellationToken cancellationToken = default);
    Task<TimeOffLimit> GetManagementunitTimeofflimitAsync(string managementUnitId, string timeOffLimitId, CancellationToken cancellationToken = default);
    Task<TimeOffLimitListing> GetManagementunitTimeofflimitsAsync(string managementUnitId, CancellationToken cancellationToken = default);
    Task<TimeOffPlan> GetManagementunitTimeoffplanAsync(string managementUnitId, string timeOffPlanId, CancellationToken cancellationToken = default);
    Task<TimeOffPlanListing> GetManagementunitTimeoffplansAsync(string managementUnitId, CancellationToken cancellationToken = default);
    Task<TimeOffRequestListing> GetManagementunitTimeoffrequestsAsync(string managementUnitId, bool? recentlyReviewed = null, CancellationToken cancellationToken = default);
    Task<TimeOffRequest> GetManagementunitTimeoffrequestAsync(string managementUnitId, string timeOffRequestId, CancellationToken cancellationToken = default);
    Task<TimeOffBalanceJobResponse> GetManagementunitUserTimeoffbalanceJobAsync(string managementUnitId, string userId, string jobId, CancellationToken cancellationToken = default);
    Task<TimeOffBalanceJobResponse> GetManagementunitUserTimeoffrequestTimeoffbalanceJobAsync(string managementUnitId, string userId, string timeOffRequestId, string jobId, CancellationToken cancellationToken = default);
    Task<WfmUserEntityListing> GetManagementunitUsersAsync(string managementUnitId, CancellationToken cancellationToken = default);
    Task<ShiftTrade> GetManagementunitWeekShifttradeAsync(string managementUnitId, string weekDateId, string tradeId, CancellationToken cancellationToken = default);
    Task<WeekShiftTradeListResponse> GetManagementunitWeekShifttradesAsync(string managementUnitId, string weekDateId, CancellationToken cancellationToken = default);
    Task<WorkPlan> GetManagementunitWorkplanAsync(string managementUnitId, string workPlanId, bool? includeOnly = null, CancellationToken cancellationToken = default);
    Task<WorkPlanRotationResponse> GetManagementunitWorkplanrotationAsync(string managementUnitId, string workPlanRotationId, CancellationToken cancellationToken = default);
    Task<WorkPlanRotationListResponse> GetManagementunitWorkplanrotationsAsync(string managementUnitId, CancellationToken cancellationToken = default);
    Task<WorkPlanListResponse> GetManagementunitWorkplansAsync(string managementUnitId, CancellationToken cancellationToken = default);

    Task<MuAgentsWorkPlansResult> CreateManagementunitAgentsWorkplansQueryAsync(string managementUnitId, MuAgentsWorkPlansQueryRequest body, CancellationToken cancellationToken = default);
    Task<WfmHistoricalAdherenceResponse> CreateManagementunitHistoricaladherencequeryAsync(string managementUnitId, WfmHistoricalAdherenceQuery body, CancellationToken cancellationToken = default);
    Task<MoveManagementUnitResponse> CreateManagementunitMoveAsync(string managementUnitId, MoveManagementUnitRequest body, CancellationToken cancellationToken = default);
    Task<UserScheduleSearchResponse> CreateManagementunitSchedulesSearchAsync(string managementUnitId, UserScheduleSearchRequest body, CancellationToken cancellationToken = default);
    Task<WfmHistoricalShrinkageResponse> CreateManagementunitShrinkageJobsAsync(string managementUnitId, WfmHistoricalShrinkageRequest body, CancellationToken cancellationToken = default);
    Task<TimeOffLimit> CreateManagementunitTimeofflimitsAsync(string managementUnitId, CreateTimeOffLimitRequest body, CancellationToken cancellationToken = default);
    Task<TimeOffLimitValueListing> CreateManagementunitTimeofflimitsValuesQueryAsync(string managementUnitId, QueryTimeOffLimitValuesRequest body, CancellationToken cancellationToken = default);
    Task<TimeOffPlan> CreateManagementunitTimeoffplansAsync(string managementUnitId, CreateTimeOffPlanRequest body, CancellationToken cancellationToken = default);
    Task<TimeOffRequest> CreateManagementunitTimeoffrequestsAsync(string managementUnitId, CreateTimeOffRequestRequest body, CancellationToken cancellationToken = default);
    Task<TimeOffIntegrationStatusResponseListing> CreateManagementunitTimeoffrequestsIntegrationstatusQueryAsync(string managementUnitId, QueryTimeOffIntegrationStatusRequest body, CancellationToken cancellationToken = default);
    Task<TimeOffRequestQueryResponse> CreateManagementunitTimeoffrequestsQueryAsync(string managementUnitId, TimeOffRequestQueryBody body, CancellationToken cancellationToken = default);
    Task<TimeOffRequestListing> CreateManagementunitTimeoffrequestsWaitlistpositionsQueryAsync(string managementUnitId, QueryWaitlistPositionsRequest body, CancellationToken cancellationToken = default);
    Task<TimeOffBalanceJobResponse> CreateManagementunitUserTimeoffbalanceJobsAsync(string managementUnitId, string userId, TimeOffBalanceRequest body, CancellationToken cancellationToken = default);
    Task<TimeOffBalanceJobResponse> CreateManagementunitUserTimeoffrequestTimeoffbalanceJobsAsync(string managementUnitId, string userId, string timeOffRequestId, TimeOffBalanceRequest body, CancellationToken cancellationToken = default);
    Task<EstimateTimeOffRequestResponse> CreateManagementunitUserTimeoffrequestsEstimateAsync(string managementUnitId, string userId, EstimateTimeOffRequestRequest body, CancellationToken cancellationToken = default);
    Task<TradeMatchResponse> CreateManagementunitWeekShifttradeMatchAsync(string managementUnitId, string weekDateId, string tradeId, MatchShiftTradeRequest body, CancellationToken cancellationToken = default);
    Task<ShiftTrade> CreateManagementunitWeekShifttradesAsync(string managementUnitId, string weekDateId, AddShiftTradeRequest body, CancellationToken cancellationToken = default);
    Task<SearchShiftTradesResponse> CreateManagementunitWeekShifttradesSearchAsync(string managementUnitId, string weekDateId, SearchShiftTradesRequest body, CancellationToken cancellationToken = default);
    Task<WorkPlan> CreateManagementunitWorkplanCopyAsync(string managementUnitId, string workPlanId, CopyWorkPlan body, CancellationToken cancellationToken = default);
    Task<ValidateWorkPlanResponse> CreateManagementunitWorkplanValidateAsync(string managementUnitId, string workPlanId, CancellationToken cancellationToken = default);
    Task<WorkPlanRotationResponse> CreateManagementunitWorkplanrotationCopyAsync(string managementUnitId, string workPlanRotationId, CopyWorkPlanRotationRequest body, CancellationToken cancellationToken = default);
    Task<WorkPlanRotationResponse> CreateManagementunitWorkplanrotationsAsync(string managementUnitId, CreateWorkPlanRotationRequest body, CancellationToken cancellationToken = default);
    Task<WorkPlan> CreateManagementunitWorkplansAsync(string managementUnitId, CreateWorkPlan body, CancellationToken cancellationToken = default);

    Task<ManagementUnit> PatchManagementunitAsync(string managementUnitId, UpdateManagementUnitRequest body, CancellationToken cancellationToken = default);
    Task<UpdateMuAgentWorkPlansBatchResponse> PatchManagementunitAgentsAsync(string managementUnitId, UpdateMuAgentWorkPlansBatchRequest body, CancellationToken cancellationToken = default);
    Task<BulkUpdateAgentWorkPlanBiddingPreferenceResponse> PatchManagementunitAgentsWorkplansBulkAsync(string managementUnitId, BulkUpdateAgentWorkPlanBiddingPreferenceRequest body, CancellationToken cancellationToken = default);
    Task<TimeOffLimit> PatchManagementunitTimeofflimitAsync(string managementUnitId, string timeOffLimitId, UpdateTimeOffLimitRequest body, CancellationToken cancellationToken = default);
    Task<TimeOffPlan> PatchManagementunitTimeoffplanAsync(string managementUnitId, string timeOffPlanId, UpdateTimeOffPlanRequest body, CancellationToken cancellationToken = default);
    Task<TimeOffRequestResponse> PatchManagementunitTimeoffrequestUserIntegrationstatusAsync(string managementUnitId, string timeOffRequestId, string userId, SetTimeOffIntegrationStatusRequest body, CancellationToken cancellationToken = default);
    Task<TimeOffRequest> PatchManagementunitUserTimeoffrequestAsync(string managementUnitId, string userId, string timeOffRequestId, AdminTimeOffRequestPatch body, CancellationToken cancellationToken = default);
    Task<ShiftTrade> PatchManagementunitWeekShifttradeAsync(string managementUnitId, string weekDateId, string tradeId, UpdateShiftTradeRequest body, CancellationToken cancellationToken = default);
    Task<WorkPlan> PatchManagementunitWorkplanAsync(string managementUnitId, string workPlanId, UpdateWorkPlan body, CancellationToken cancellationToken = default);
    Task<WorkPlanRotationResponse> PatchManagementunitWorkplanrotationAsync(string managementUnitId, string workPlanRotationId, UpdateWorkPlanRotationRequest body, CancellationToken cancellationToken = default);

    // Adherence Operations
    Task<UserScheduleAdherence[]> GetAdherenceAsync(IEnumerable<string> userIds, CancellationToken cancellationToken = default);
    Task<AdherenceExplanationResponse> GetAdherenceExplanationAsync(string explanationId, CancellationToken cancellationToken = default);
    Task<AdherenceExplanationJob> GetAdherenceExplanationsJobAsync(string jobId, CancellationToken cancellationToken = default);
    Task<WfmHistoricalAdherenceBulkJobResponse> GetAdherenceHistoricalBulkJobAsync(string jobId, CancellationToken cancellationToken = default);
    Task<WfmHistoricalAdherenceResponse> GetAdherenceHistoricalJobAsync(string jobId, CancellationToken cancellationToken = default);
    Task<AdherenceExplanationResponse> GetAgentAdherenceExplanationAsync(string agentId, string explanationId, CancellationToken cancellationToken = default);
    Task<ManagementUnit> GetAgentManagementunitAsync(string agentId, CancellationToken cancellationToken = default);
    Task<ManagementUnit> GetAgentsMeManagementunitAsync(CancellationToken cancellationToken = default);

    Task<WfmHistoricalAdherenceResponse> CreateAdherenceHistoricalAsync(WfmHistoricalAdherenceQuery body, CancellationToken cancellationToken = default);
    Task<WfmHistoricalAdherenceBulkJobResponse> CreateAdherenceHistoricalBulkAsync(WfmHistoricalAdherenceBulkQuery body, CancellationToken cancellationToken = default);
    Task<QueryAdherenceExplanationsResponse> CreateAdherenceExplanationsQueryAsync(AgentQueryAdherenceExplanationsRequest body, CancellationToken cancellationToken = default);

    // Calendar Operations
    Task<CalendarUrlResponse> GetCalendarDataIcsAsync(CancellationToken cancellationToken = default);
    Task<CalendarUrlResponse> GetCalendarUrlIcsAsync(CancellationToken cancellationToken = default);
    Task<bool> DeleteCalendarUrlIcsAsync(CancellationToken cancellationToken = default);
    Task<CalendarUrlResponse> CreateCalendarUrlIcsAsync(CancellationToken cancellationToken = default);

    // Business Units Listing
    Task<BusinessUnitListing> GetBusinessunitsAsync(string feature = null, string divisionId = null, CancellationToken cancellationToken = default);
    Task<BusinessUnitListing> GetBusinessunitsDivisionviewsAsync(List<string> divisionId = null, CancellationToken cancellationToken = default);
    Task<BusinessUnit> CreateBusinessunitsAsync(CreateBusinessUnitRequest body, CancellationToken cancellationToken = default);

    // Management Units Listing  
    Task<ManagementUnitListing> GetManagementunitsAsync(int? pageSize = null, int? pageNumber = null, string expand = null, string feature = null, string divisionId = null, CancellationToken cancellationToken = default);
    Task<ManagementUnitListing> CreateManagementunitsAsync(CreateManagementUnitRequest body, CancellationToken cancellationToken = default);

    // Time Off Operations
    Task<TimeOffBalanceJobResponse> GetTimeoffbalanceJobAsync(string jobId, CancellationToken cancellationToken = default);
    Task<TimeOffRequest> GetTimeoffrequestAsync(string timeOffRequestId, CancellationToken cancellationToken = default);
    Task<TimeOffRequestListing> GetTimeoffrequestsAsync(bool? recentlyReviewed = null, CancellationToken cancellationToken = default);
    Task<UserWorkPlanBidRanks> GetUserWorkplanbidranksAsync(string userId, CancellationToken cancellationToken = default);
    Task<UserWorkPlanBidListResponse> GetUserWorkplanbidsAsync(string userId, CancellationToken cancellationToken = default);
    Task<WorkPlanBidListResponse> GetWorkplanbidsAsync(CancellationToken cancellationToken = default);

    Task<TimeOffBalanceJobResponse> CreateTimeoffbalanceJobsAsync(TimeOffBalanceRequest body, CancellationToken cancellationToken = default);
    Task<QueryTimeOffLimitValuesResponse> CreateTimeofflimitsAvailableQueryAsync(QueryTimeOffLimitValuesRequest body, CancellationToken cancellationToken = default);
    Task<TimeOffRequest> CreateTimeoffrequestsAsync(CreateTimeOffRequestRequest body, CancellationToken cancellationToken = default);
    Task<EstimateTimeOffRequestResponse> CreateTimeoffrequestsEstimateAsync(EstimateTimeOffRequestRequest body, CancellationToken cancellationToken = default);
    Task<TimeOffIntegrationStatusResponseListing> CreateTimeoffrequestsIntegrationstatusQueryAsync(QueryTimeOffIntegrationStatusRequest body, CancellationToken cancellationToken = default);

    Task<TimeOffRequest> PatchTimeoffrequestAsync(string timeOffRequestId, AdminTimeOffRequestPatch body, CancellationToken cancellationToken = default);
    Task<UserWorkPlanBidRanks> PatchUserWorkplanbidranksAsync(string userId, WorkPlanBidRanks body, CancellationToken cancellationToken = default);
    Task<BulkUpdateAgentWorkPlanBiddingPreferenceResponse> PatchUsersWorkplanbidranksBulkAsync(BulkUpdateAgentWorkPlanBiddingPreferenceRequest body, CancellationToken cancellationToken = default);
    Task<AgentWorkPlanBiddingPreferenceResponse> PatchWorkplanbidPreferencesAsync(AgentWorkPlanBiddingPreferenceRequest body, CancellationToken cancellationToken = default);

    // Alternative Shifts and Other Operations
    Task<ListAlternativeShiftOffersResponse> GetAlternativeshiftsOffersJobAsync(string jobId, CancellationToken cancellationToken = default);
    Task<BuListAlternativeShiftOffersResponse> GetAlternativeshiftsOffersSearchJobAsync(string jobId, CancellationToken cancellationToken = default);
    Task<AlternativeShiftSettingsResponse> GetAlternativeshiftsSettingsAsync(CancellationToken cancellationToken = default);
    Task<AlternativeShiftTradeResponse> GetAlternativeshiftsTradeAsync(string tradeId, CancellationToken cancellationToken = default);
    Task<ListAlternativeShiftTradesResponse> GetAlternativeshiftsTradesJobAsync(string jobId, CancellationToken cancellationToken = default);
    Task<BuAlternativeShiftTradeStateResponse> GetAlternativeshiftsTradesStateJobAsync(string jobId, CancellationToken cancellationToken = default);

    Task<AlternativeShiftTradeResponse> PatchAlternativeshiftsTradeAsync(string tradeId, UpdateAlternativeShiftTradeRequest body, CancellationToken cancellationToken = default);
    Task<CreateAlternativeShiftTradeResponse> CreateAlternativeshiftsTradesAsync(CreateAlternativeShiftTradeRequest body, CancellationToken cancellationToken = default);

    // Additional Operations
    Task<LongRunningOperationStatusResponse> CreateAgentsAsync(WfmProcessUploadRequest body, CancellationToken cancellationToken = default);
    Task<HrisIntegrationsResponse> GetIntegrationsHrisAsync(CancellationToken cancellationToken = default);
    Task<HrisTimeOffTypesJobResponse> GetIntegrationsHrisTimeofftypesJobAsync(string jobId, CancellationToken cancellationToken = default);
    Task<HrisTimeOffTypesResponse> CreateIntegrationsHriTimeofftypesJobsAsync(HrisTimeOffTypesRequest body, CancellationToken cancellationToken = default);
    Task<AgentsIntegrationsListing> CreateAgentsIntegrationsHrisQueryAsync(QueryAgentsIntegrationsRequest body, CancellationToken cancellationToken = default);
    Task<BulkUpdateAgentAlternativeShiftResponse> CreateAgentsMePossibleworkshiftsAsync(QueryAlternativeShiftForAgentsRequest body, CancellationToken cancellationToken = default);
    Task<BuCurrentAgentScheduleSearchResponse> CreateAgentschedulesMineAsync(BuCurrentAgentScheduleSearchRequest body, CancellationToken cancellationToken = default);

    Task<HrisIntegrationResponse> UpdateAgentIntegrationsHrisAsync(string agentId, AgentIntegrationsRequest body, CancellationToken cancellationToken = default);
    Task<BuTimeOffLimitResponse> UpdateBusinessUnitTimeofflimitValuesAsync(string businessUnitId, string timeOffLimitId, BuSetTimeOffLimitValuesRequest body, CancellationToken cancellationToken = default);
    Task<TimeOffLimit> UpdateManagementunitTimeofflimitValuesAsync(string managementUnitId, string timeOffLimitId, SetTimeOffLimitValuesRequest body, CancellationToken cancellationToken = default);

    // Historical Data Operations
    Task<HistoricalImportDeleteJobResponse> GetHistoricaldataBulkRemoveJobAsync(string jobId, CancellationToken cancellationToken = default);
    Task<HistoricalImportDeleteJobListing> GetHistoricaldataBulkRemoveJobsAsync(CancellationToken cancellationToken = default);
    Task<HistoricalImportStatusListing> GetHistoricaldataDeletejobAsync(CancellationToken cancellationToken = default);
    Task<ImportStatusResponse> GetHistoricaldataImportstatusAsync(CancellationToken cancellationToken = default);
    Task<ImportStatusResponse> GetHistoricaldataImportstatusJobIdAsync(string jobId, CancellationToken cancellationToken = default);

    Task<HistoricalImportDeleteJobResponse> CreateHistoricaldataBulkRemoveJobsAsync(HistoricalImportDeleteJobRequest body, CancellationToken cancellationToken = default);
    Task<HistoricalImportStatusListing> CreateHistoricaldataDeletejobAsync(CancellationToken cancellationToken = default);

    // Notification and Schedule Operations
    Task<UpdateNotificationsResponse> CreateNotificationsUpdateAsync(UpdateNotificationsRequest body, CancellationToken cancellationToken = default);
    Task<UserScheduleContainer> CreateSchedulesAsync(CurrentUserScheduleRequestBody body, CancellationToken cancellationToken = default);
    Task<WfmHistoricalAdherenceResponse> CreateTeamAdherenceHistoricalAsync(WfmHistoricalAdherenceQuery body, CancellationToken cancellationToken = default);
    Task<WfmHistoricalShrinkageResponse> CreateTeamShrinkageJobsAsync(WfmHistoricalShrinkageRequest body, CancellationToken cancellationToken = default);
}
