using PureCloud.Client.Models;

namespace PureCloud.Client.Contracts;

public interface IWorkforceManagementApi
{    Task DeleteBusinessunitAsync(string businessUnitId, CancellationToken cancellationToken = default);

    Task DeleteBusinessunitActivitycodeAsync(string businessUnitId, string activityCodeId, CancellationToken cancellationToken = default);

    Task DeleteBusinessunitPlanninggroupAsync(string businessUnitId, string planningGroupId, CancellationToken cancellationToken = default);

    Task DeleteBusinessunitSchedulingRunAsync(string businessUnitId, string runId, CancellationToken cancellationToken = default);

    Task DeleteBusinessunitServicegoaltemplateAsync(string businessUnitId, string serviceGoalTemplateId, CancellationToken cancellationToken = default);

    Task DeleteBusinessunitStaffinggroupAsync(string businessUnitId, string staffingGroupId, CancellationToken cancellationToken = default);

    Task DeleteBusinessunitTimeofflimitAsync(string businessUnitId, string timeOffLimitId, CancellationToken cancellationToken = default);

    Task DeleteBusinessunitTimeoffplanAsync(string businessUnitId, string timeOffPlanId, CancellationToken cancellationToken = default);

    Task<BuAsyncScheduleResponse> DeleteBusinessunitWeekScheduleAsync(string businessUnitId, string weekId, string scheduleId, CancellationToken cancellationToken = default);

    Task DeleteBusinessunitWeekShorttermforecastAsync(string businessUnitId, string weekDateId, string forecastId, CancellationToken cancellationToken = default);

    Task DeleteBusinessunitWorkplanbidAsync(string businessUnitId, string bidId, CancellationToken cancellationToken = default);

    Task DeleteBusinessunitWorkplanbidGroupAsync(string businessUnitId, string bidId, string bidGroupId, CancellationToken cancellationToken = default);

    Task DeleteCalendarUrlIcsAsync(CancellationToken cancellationToken = default);

    Task DeleteManagementunitAsync(string managementUnitId, CancellationToken cancellationToken = default);

    Task DeleteManagementunitTimeofflimitAsync(string managementUnitId, string timeOffLimitId, CancellationToken cancellationToken = default);

    Task DeleteManagementunitTimeoffplanAsync(string managementUnitId, string timeOffPlanId, CancellationToken cancellationToken = default);

    Task DeleteManagementunitWorkplanAsync(string managementUnitId, string workPlanId, CancellationToken cancellationToken = default);

    Task DeleteManagementunitWorkplanrotationAsync(string managementUnitId, string workPlanRotationId, CancellationToken cancellationToken = default);

    Task<AdherenceExplanationResponse> GetAdherenceExplanationAsync(string explanationId, CancellationToken cancellationToken = default);

    Task<AdherenceExplanationJob> GetAdherenceExplanationsJobAsync(string jobId, CancellationToken cancellationToken = default);

    Task<WfmHistoricalAdherenceBulkResponse> GetAdherenceHistoricalBulkJobAsync(string jobId, CancellationToken cancellationToken = default);

    Task<WfmHistoricalAdherenceResponse> GetAdherenceHistoricalJobAsync(string jobId, CancellationToken cancellationToken = default);

    Task<AdherenceExplanationResponse> GetAgentAdherenceExplanationAsync(string agentId, string explanationId, CancellationToken cancellationToken = default);

    Task<AgentManagementUnitReference> GetAgentManagementunitAsync(string agentId, CancellationToken cancellationToken = default);

    Task<AgentManagementUnitReference> GetAgentsMeManagementunitAsync(CancellationToken cancellationToken = default);

    Task<AlternativeShiftJobResponse> GetAlternativeshiftsOffersJobAsync(string jobId, CancellationToken cancellationToken = default);

    Task<AlternativeShiftJobResponse> GetAlternativeshiftsOffersSearchJobAsync(string jobId, CancellationToken cancellationToken = default);

    Task<AlternativeShiftBuSettingsResponse> GetAlternativeshiftsSettingsAsync(CancellationToken cancellationToken = default);

    Task<AlternativeShiftTradeResponse> GetAlternativeshiftsTradeAsync(string tradeId, CancellationToken cancellationToken = default);

    Task<ListAlternativeShiftTradesResponse> GetAlternativeshiftsTradesAsync(bool? forceAsync, CancellationToken cancellationToken = default);

    Task<AlternativeShiftJobResponse> GetAlternativeshiftsTradesJobAsync(string jobId, CancellationToken cancellationToken = default);

    Task<AlternativeShiftJobResponse> GetAlternativeshiftsTradesStateJobAsync(string jobId, CancellationToken cancellationToken = default);

    Task<BusinessUnitResponse> GetBusinessunitAsync(string businessUnitId, List<string> expand, CancellationToken cancellationToken = default);

    Task<BusinessUnitActivityCode> GetBusinessunitActivitycodeAsync(string businessUnitId, string activityCodeId, CancellationToken cancellationToken = default);

    Task<BusinessUnitActivityCodeListing> GetBusinessunitActivitycodesAsync(string businessUnitId, bool? forceDownloadService, CancellationToken cancellationToken = default);

    Task<ActivityPlanResponse> GetBusinessunitActivityplanAsync(string businessUnitId, string activityPlanId, CancellationToken cancellationToken = default);

    Task<ActivityPlanRunJobResponse> GetBusinessunitActivityplanRunsJobAsync(string businessUnitId, string activityPlanId, string jobId, CancellationToken cancellationToken = default);

    Task<ActivityPlanListing> GetBusinessunitActivityplansAsync(string businessUnitId, string state, CancellationToken cancellationToken = default);

    Task<ActivityPlanJobListing> GetBusinessunitActivityplansJobsAsync(string businessUnitId, CancellationToken cancellationToken = default);

    Task<AlternativeShiftBuSettingsResponse> GetBusinessunitAlternativeshiftsSettingsAsync(string businessUnitId, CancellationToken cancellationToken = default);

    Task<AlternativeShiftTradeResponse> GetBusinessunitAlternativeshiftsTradeAsync(string businessUnitId, string tradeId, CancellationToken cancellationToken = default);

    Task<BuAlternativeShiftJobResponse> GetBusinessunitAlternativeshiftsTradesSearchJobAsync(string businessUnitId, string jobId, CancellationToken cancellationToken = default);

    Task<WfmIntradayPlanningGroupListing> GetBusinessunitIntradayPlanninggroupsAsync(string businessUnitId, string date, CancellationToken cancellationToken = default);

    Task<ContinuousForecastGetSessionResponse> GetBusinessunitMainforecastContinuousforecastSessionAsync(string businessUnitId, CancellationToken cancellationToken = default);

    Task<ContinuousForecastSessionResponse> GetBusinessunitMainforecastContinuousforecastSessionSessionIdAsync(string businessUnitId, string sessionId, CancellationToken cancellationToken = default);

    Task<ContinuousForecastSnapshotResponse> GetBusinessunitMainforecastContinuousforecastSessionSessionIdSnapshotSnapshotIdAsync(string businessUnitId, string sessionId, string snapshotId, CancellationToken cancellationToken = default);

    Task<ManagementUnitListing> GetBusinessunitManagementunitsAsync(string businessUnitId, string feature, string divisionId, CancellationToken cancellationToken = default);

    Task<PlanningGroup> GetBusinessunitPlanninggroupAsync(string businessUnitId, string planningGroupId, CancellationToken cancellationToken = default);

    Task<PlanningGroupList> GetBusinessunitPlanninggroupsAsync(string businessUnitId, CancellationToken cancellationToken = default);

    Task<BuScheduleRun> GetBusinessunitSchedulingRunAsync(string businessUnitId, string runId, CancellationToken cancellationToken = default);

    Task<BuRescheduleResult> GetBusinessunitSchedulingRunResultAsync(string businessUnitId, string runId, List<string> managementUnitIds, List<string> expand, CancellationToken cancellationToken = default);

    Task<BuScheduleRunListing> GetBusinessunitSchedulingRunsAsync(string businessUnitId, CancellationToken cancellationToken = default);

    Task<ServiceGoalTemplate> GetBusinessunitServicegoaltemplateAsync(string businessUnitId, string serviceGoalTemplateId, List<string> expand, CancellationToken cancellationToken = default);

    Task<ServiceGoalTemplateList> GetBusinessunitServicegoaltemplatesAsync(string businessUnitId, List<string> expand, CancellationToken cancellationToken = default);

    Task<StaffingGroupResponse> GetBusinessunitStaffinggroupAsync(string businessUnitId, string staffingGroupId, CancellationToken cancellationToken = default);

    Task<StaffingGroupListing> GetBusinessunitStaffinggroupsAsync(string businessUnitId, string managementUnitId, CancellationToken cancellationToken = default);

    Task<BuTimeOffLimitResponse> GetBusinessunitTimeofflimitAsync(string businessUnitId, string timeOffLimitId, CancellationToken cancellationToken = default);

    Task<BuTimeOffLimitListing> GetBusinessunitTimeofflimitsAsync(string businessUnitId, string managementUnitId, CancellationToken cancellationToken = default);

    Task<BuTimeOffPlanResponse> GetBusinessunitTimeoffplanAsync(string businessUnitId, string timeOffPlanId, CancellationToken cancellationToken = default);

    Task<BuTimeOffPlanListing> GetBusinessunitTimeoffplansAsync(string businessUnitId, string managementUnitId, bool? forceDownloadService, CancellationToken cancellationToken = default);

    Task<BuScheduleMetadata> GetBusinessunitWeekScheduleAsync(string businessUnitId, string weekId, string scheduleId, string expand, CancellationToken cancellationToken = default);

    Task<ScheduleGenerationResult> GetBusinessunitWeekScheduleGenerationresultsAsync(string businessUnitId, string weekId, string scheduleId, CancellationToken cancellationToken = default);

    Task<BuHeadcountForecastResponse> GetBusinessunitWeekScheduleHeadcountforecastAsync(string businessUnitId, string weekId, string scheduleId, bool? forceDownload, CancellationToken cancellationToken = default);

    Task<BuAgentScheduleHistoryResponse> GetBusinessunitWeekScheduleHistoryAgentAsync(string businessUnitId, string weekId, string scheduleId, string agentId, CancellationToken cancellationToken = default);

    Task<PerformancePredictionResponse> GetBusinessunitWeekSchedulePerformancepredictionsAsync(string businessUnitId, string weekId, string scheduleId, CancellationToken cancellationToken = default);

    Task<PerformancePredictionRecalculationResponse> GetBusinessunitWeekSchedulePerformancepredictionsRecalculationAsync(string businessUnitId, string weekId, string scheduleId, string recalculationId, CancellationToken cancellationToken = default);

    Task<BuScheduleListing> GetBusinessunitWeekSchedulesAsync(string businessUnitId, string weekId, bool? includeOnlyPublished, string expand, CancellationToken cancellationToken = default);

    Task<BuShortTermForecast> GetBusinessunitWeekShorttermforecastAsync(string businessUnitId, string weekDateId, string forecastId, List<string> expand, CancellationToken cancellationToken = default);

    Task<BuForecastResultResponse> GetBusinessunitWeekShorttermforecastDataAsync(string businessUnitId, string weekDateId, string forecastId, int? weekNumber, bool? forceDownloadService, CancellationToken cancellationToken = default);

    Task<BuForecastGenerationResult> GetBusinessunitWeekShorttermforecastGenerationresultsAsync(string businessUnitId, string weekDateId, string forecastId, CancellationToken cancellationToken = default);

    Task<LongTermForecastResultResponse> GetBusinessunitWeekShorttermforecastLongtermforecastdataAsync(string businessUnitId, string weekDateId, string forecastId, bool? forceDownloadService, CancellationToken cancellationToken = default);

    Task<ForecastPlanningGroupsResponse> GetBusinessunitWeekShorttermforecastPlanninggroupsAsync(string businessUnitId, string weekDateId, string forecastId, CancellationToken cancellationToken = default);

    Task<BuForecastStaffingRequirementsResultResponse> GetBusinessunitWeekShorttermforecastStaffingrequirementAsync(string businessUnitId, string weekDateId, string forecastId, List<string> weekNumbers, CancellationToken cancellationToken = default);

    Task<BuShortTermForecastListing> GetBusinessunitWeekShorttermforecastsAsync(string businessUnitId, string weekDateId, CancellationToken cancellationToken = default);

    Task<WorkPlanBid> GetBusinessunitWorkplanbidAsync(string businessUnitId, string bidId, CancellationToken cancellationToken = default);

    Task<WorkPlanBidGroupResponse> GetBusinessunitWorkplanbidGroupAsync(string businessUnitId, string bidId, string bidGroupId, CancellationToken cancellationToken = default);

    Task<AdminAgentWorkPlanPreferenceResponse> GetBusinessunitWorkplanbidGroupPreferencesAsync(string businessUnitId, string bidId, string bidGroupId, CancellationToken cancellationToken = default);

    Task<WorkPlanBidGroupSummaryList> GetBusinessunitWorkplanbidGroupsSummaryAsync(string businessUnitId, string bidId, CancellationToken cancellationToken = default);

    Task<WorkPlanBidListResponse> GetBusinessunitWorkplanbidsAsync(string businessUnitId, CancellationToken cancellationToken = default);

    Task<BusinessUnitListing> GetBusinessunitsAsync(string feature, string divisionId, CancellationToken cancellationToken = default);

    Task<BusinessUnitListing> GetBusinessunitsDivisionviewsAsync(List<string> divisionId, CancellationToken cancellationToken = default);

    Task<string> GetCalendarDataIcsAsync(string calendarId, CancellationToken cancellationToken = default);

    Task<CalendarUrlResponse> GetCalendarUrlIcsAsync(CancellationToken cancellationToken = default);

    Task<HistoricalImportDeleteFilesJobResponse> GetHistoricaldataBulkRemoveJobAsync(string jobId, CancellationToken cancellationToken = default);

    Task<HistoricalImportOverallDeleteStatusResponse> GetHistoricaldataBulkRemoveJobsAsync(CancellationToken cancellationToken = default);

    Task<HistoricalImportDeleteJobResponse> GetHistoricaldataDeletejobAsync(CancellationToken cancellationToken = default);

    Task<HistoricalImportStatusListing> GetHistoricaldataImportstatusAsync(CancellationToken cancellationToken = default);

    Task<HistoricalImportStatusJobResponse> GetHistoricaldataImportstatusJobIdAsync(string jobId, CancellationToken cancellationToken = default);

    Task<WfmIntegrationListing> GetIntegrationsHrisAsync(CancellationToken cancellationToken = default);

    Task<HrisTimeOffTypesJobResponse> GetIntegrationsHrisTimeofftypesJobAsync(string jobId, CancellationToken cancellationToken = default);

    Task<ManagementUnit> GetManagementunitAsync(string managementUnitId, List<string> expand, CancellationToken cancellationToken = default);

    Task<ActivityCodeContainer> GetManagementunitActivitycodesAsync(string managementUnitId, CancellationToken cancellationToken = default);

    Task<UserScheduleAdherenceListing> GetManagementunitAdherenceAsync(string managementUnitId, bool? forceDownloadService, CancellationToken cancellationToken = default);

    Task<WfmAgent> GetManagementunitAgentAsync(string managementUnitId, string agentId, bool? excludeCapabilities, List<string> expand, CancellationToken cancellationToken = default);

    Task<ShiftTradeListResponse> GetManagementunitAgentShifttradesAsync(string managementUnitId, string agentId, CancellationToken cancellationToken = default);

    Task<ShiftTradeMatchesSummaryResponse> GetManagementunitShifttradesMatchedAsync(string managementUnitId, CancellationToken cancellationToken = default);

    Task<WfmUserEntityListing> GetManagementunitShifttradesUsersAsync(string managementUnitId, CancellationToken cancellationToken = default);

    Task<TimeOffLimit> GetManagementunitTimeofflimitAsync(string managementUnitId, string timeOffLimitId, CancellationToken cancellationToken = default);

    Task<TimeOffLimitListing> GetManagementunitTimeofflimitsAsync(string managementUnitId, CancellationToken cancellationToken = default);

    Task<TimeOffPlan> GetManagementunitTimeoffplanAsync(string managementUnitId, string timeOffPlanId, CancellationToken cancellationToken = default);

    Task<TimeOffPlanListing> GetManagementunitTimeoffplansAsync(string managementUnitId, CancellationToken cancellationToken = default);

    Task<TimeOffRequestResponse> GetManagementunitUserTimeoffrequestAsync(string managementUnitId, string userId, string timeOffRequestId, CancellationToken cancellationToken = default);

    Task<QueryTimeOffLimitValuesResponse> GetManagementunitUserTimeoffrequestTimeofflimitsAsync(string managementUnitId, string userId, string timeOffRequestId, CancellationToken cancellationToken = default);

    Task<TimeOffRequestList> GetManagementunitUserTimeoffrequestsAsync(string managementUnitId, string userId, CancellationToken cancellationToken = default);

    Task<WfmUserEntityListing> GetManagementunitUsersAsync(string managementUnitId, CancellationToken cancellationToken = default);

    Task<WeekScheduleResponse> GetManagementunitWeekScheduleAsync(string managementUnitId, string weekId, string scheduleId, string expand, bool? forceDownloadService, CancellationToken cancellationToken = default);

    Task<WeekScheduleListResponse> GetManagementunitWeekSchedulesAsync(string managementUnitId, string weekId, bool? includeOnlyPublished, string earliestWeekDate, string latestWeekDate, CancellationToken cancellationToken = default);

    Task<WeekShiftTradeListResponse> GetManagementunitWeekShifttradesAsync(string managementUnitId, string weekDateId, bool? evaluateMatches, bool? forceDownloadService, CancellationToken cancellationToken = default);

    Task<WorkPlan> GetManagementunitWorkplanAsync(string managementUnitId, string workPlanId, List<string> includeOnly, CancellationToken cancellationToken = default);

    Task<WorkPlanRotationResponse> GetManagementunitWorkplanrotationAsync(string managementUnitId, string workPlanRotationId, CancellationToken cancellationToken = default);

    Task<WorkPlanRotationListResponse> GetManagementunitWorkplanrotationsAsync(string managementUnitId, List<string> expand, CancellationToken cancellationToken = default);

    Task<WorkPlanListResponse> GetManagementunitWorkplansAsync(string managementUnitId, List<string> expand, List<string> exclude, CancellationToken cancellationToken = default);

    Task<ManagementUnitListing> GetManagementunitsAsync(int? pageSize, int? pageNumber, string expand, string feature, string divisionId, CancellationToken cancellationToken = default);

    Task<ManagementUnitListing> GetManagementunitsDivisionviewsAsync(List<string> divisionId, CancellationToken cancellationToken = default);

    Task<NotificationsResponse> GetNotificationsAsync(CancellationToken cancellationToken = default);

    Task<SchedulingStatusResponse> GetSchedulingjobAsync(string jobId, CancellationToken cancellationToken = default);

    Task<ShiftTradeListResponse> GetShifttradesAsync(CancellationToken cancellationToken = default);

    Task<WfmHistoricalShrinkageResponse> GetShrinkageJobAsync(string jobId, CancellationToken cancellationToken = default);

    Task<TimeOffBalanceJobResponse> GetTimeoffbalanceJobAsync(string jobId, CancellationToken cancellationToken = default);

    Task<TimeOffRequestResponse> GetTimeoffrequestAsync(string timeOffRequestId, CancellationToken cancellationToken = default);

    Task<WaitlistPositionListing> GetTimeoffrequestWaitlistpositionsAsync(string timeOffRequestId, CancellationToken cancellationToken = default);

    Task<TimeOffRequestList> GetTimeoffrequestsAsync(CancellationToken cancellationToken = default);

    Task<WorkPlanBidRanks> GetUserWorkplanbidranksAsync(string userId, CancellationToken cancellationToken = default);

    Task<AgentWorkPlanBiddingPreferenceResponse> GetWorkplanbidPreferencesAsync(string bidId, CancellationToken cancellationToken = default);

    Task<AgentWorkPlanListResponse> GetWorkplanbidWorkplansAsync(string bidId, CancellationToken cancellationToken = default);

    Task<AgentWorkPlanBids> GetWorkplanbidsAsync(CancellationToken cancellationToken = default);

    Task<AdherenceExplanationAsyncResponse> UpdateAgentAdherenceExplanationAsync(string agentId, string explanationId, UpdateAdherenceExplanationStatusRequest body, CancellationToken cancellationToken = default);

    Task<AlternativeShiftTradeResponse> UpdateAlternativeshiftsTradeAsync(string tradeId, AgentUpdateAlternativeShiftTradeRequest body, CancellationToken cancellationToken = default);

    Task<AlternativeShiftAsyncResponse> UpdateAlternativeshiftsTradesStateJobsAsync(AdminBulkUpdateAlternativeShiftTradeStateRequest body, CancellationToken cancellationToken = default);

    Task<BusinessUnitResponse> UpdateBusinessunitAsync(string businessUnitId, UpdateBusinessUnitRequest body, CancellationToken cancellationToken = default);

    Task<BusinessUnitActivityCode> UpdateBusinessunitActivitycodeAsync(string businessUnitId, string activityCodeId, UpdateActivityCodeRequest body, CancellationToken cancellationToken = default);

    Task<ActivityPlanResponse> UpdateBusinessunitActivityplanAsync(string businessUnitId, string activityPlanId, UpdateActivityPlanRequest body, CancellationToken cancellationToken = default);

    Task<AlternativeShiftBuSettingsResponse> UpdateBusinessunitAlternativeshiftsSettingsAsync(string businessUnitId, UpdateAlternativeShiftBuSettingsRequest body, CancellationToken cancellationToken = default);

    Task<PlanningGroup> UpdateBusinessunitPlanninggroupAsync(string businessUnitId, string planningGroupId, UpdatePlanningGroupRequest body, CancellationToken cancellationToken = default);

    Task UpdateBusinessunitSchedulingRunAsync(string businessUnitId, string runId, PatchBuScheduleRunRequest body, CancellationToken cancellationToken = default);

    Task<ServiceGoalTemplate> UpdateBusinessunitServicegoaltemplateAsync(string businessUnitId, string serviceGoalTemplateId, UpdateServiceGoalTemplate body, CancellationToken cancellationToken = default);

    Task<StaffingGroupResponse> UpdateBusinessunitStaffinggroupAsync(string businessUnitId, string staffingGroupId, UpdateStaffingGroupRequest body, CancellationToken cancellationToken = default);

    Task<BuTimeOffPlanResponse> UpdateBusinessunitTimeoffplanAsync(string businessUnitId, string timeOffPlanId, BuUpdateTimeOffPlanRequest body, CancellationToken cancellationToken = default);

    Task<WorkPlanBid> UpdateBusinessunitWorkplanbidAsync(string businessUnitId, string bidId, UpdateWorkPlanBid body, CancellationToken cancellationToken = default);

    Task<WorkPlanBidGroupResponse> UpdateBusinessunitWorkplanbidGroupAsync(string businessUnitId, string bidId, string bidGroupId, WorkPlanBidGroupUpdate body, CancellationToken cancellationToken = default);

    Task<AdminAgentWorkPlanPreferenceResponse> UpdateBusinessunitWorkplanbidGroupPreferencesAsync(string businessUnitId, string bidId, string bidGroupId, AgentsBidAssignedWorkPlanOverrideRequest body, CancellationToken cancellationToken = default);

    Task<ManagementUnit> UpdateManagementunitAsync(string managementUnitId, UpdateManagementUnitRequest body, CancellationToken cancellationToken = default);

    Task UpdateManagementunitAgentsAsync(string managementUnitId, UpdateMuAgentsRequest body, CancellationToken cancellationToken = default);

    Task<UpdateMuAgentWorkPlansBatchResponse> UpdateManagementunitAgentsWorkplansBulkAsync(string managementUnitId, UpdateMuAgentWorkPlansBatchRequest body, CancellationToken cancellationToken = default);

    Task<TimeOffLimit> UpdateManagementunitTimeofflimitAsync(string managementUnitId, string timeOffLimitId, UpdateTimeOffLimitRequest body, CancellationToken cancellationToken = default);

    Task<TimeOffPlan> UpdateManagementunitTimeoffplanAsync(string managementUnitId, string timeOffPlanId, UpdateTimeOffPlanRequest body, CancellationToken cancellationToken = default);

    Task<UserTimeOffIntegrationStatusResponse> UpdateManagementunitTimeoffrequestUserIntegrationstatusAsync(string managementUnitId, string timeOffRequestId, string userId, SetTimeOffIntegrationStatusRequest body, CancellationToken cancellationToken = default);

    Task<TimeOffRequestResponse> UpdateManagementunitUserTimeoffrequestAsync(string managementUnitId, string userId, string timeOffRequestId, AdminTimeOffRequestPatch body, CancellationToken cancellationToken = default);

    Task<ShiftTradeResponse> UpdateManagementunitWeekShifttradeAsync(string managementUnitId, string weekDateId, string tradeId, PatchShiftTradeRequest body, CancellationToken cancellationToken = default);

    Task<WorkPlan> UpdateManagementunitWorkplanAsync(string managementUnitId, string workPlanId, string validationMode, WorkPlan body, CancellationToken cancellationToken = default);

    Task<WorkPlanRotationResponse> UpdateManagementunitWorkplanrotationAsync(string managementUnitId, string workPlanRotationId, UpdateWorkPlanRotationRequest body, CancellationToken cancellationToken = default);

    Task<TimeOffRequestResponse> UpdateTimeoffrequestAsync(string timeOffRequestId, AgentTimeOffRequestPatch body, CancellationToken cancellationToken = default);

    Task<WorkPlanBidRanks> UpdateUserWorkplanbidranksAsync(string userId, WorkPlanBidRanks body, CancellationToken cancellationToken = default);

    Task<EntityListing> UpdateUsersWorkplanbidranksBulkAsync(List<WorkPlanBidRanks> body, CancellationToken cancellationToken = default);

    Task<AgentWorkPlanBiddingPreferenceResponse> UpdateWorkplanbidPreferencesAsync(string bidId, UpdateAgentWorkPlanBiddingPreference body, CancellationToken cancellationToken = default);

    Task<AdherenceExplanationAsyncResponse> CreateAdherenceExplanationsAsync(AddAdherenceExplanationAgentRequest body, CancellationToken cancellationToken = default);

    Task<QueryAdherenceExplanationsResponse> CreateAdherenceExplanationsQueryAsync(AgentQueryAdherenceExplanationsRequest body, bool? forceAsync, bool? forceDownloadService, CancellationToken cancellationToken = default);

    Task<WfmHistoricalAdherenceResponse> CreateAdherenceHistoricalAsync(WfmHistoricalAdherenceQueryForUsers body, CancellationToken cancellationToken = default);

    Task<WfmHistoricalAdherenceBulkResponse> CreateAdherenceHistoricalBulkAsync(WfmHistoricalAdherenceBulkQuery body, CancellationToken cancellationToken = default);

    Task<AdherenceExplanationAsyncResponse> CreateAgentAdherenceExplanationsAsync(string agentId, AddAdherenceExplanationAdminRequest body, CancellationToken cancellationToken = default);

    Task<AgentQueryAdherenceExplanationsResponse> CreateAgentAdherenceExplanationsQueryAsync(string agentId, AgentQueryAdherenceExplanationsRequest body, bool? forceAsync, bool? forceDownloadService, CancellationToken cancellationToken = default);

    Task<MoveAgentsResponse> CreateAgentsAsync(MoveAgentsRequest body, CancellationToken cancellationToken = default);

    Task<AgentsIntegrationsListing> CreateAgentsIntegrationsHrisQueryAsync(QueryAgentsIntegrationsRequest body, CancellationToken cancellationToken = default);

    Task<AgentPossibleWorkShiftsResponse> CreateAgentsMePossibleworkshiftsAsync(AgentPossibleWorkShiftsRequest body, CancellationToken cancellationToken = default);

    Task<BuCurrentAgentScheduleSearchResponse> CreateAgentschedulesMineAsync(BuGetCurrentAgentScheduleRequest body, CancellationToken cancellationToken = default);

    Task<AlternativeShiftAsyncResponse> CreateAlternativeshiftsOffersJobsAsync(AlternativeShiftOffersRequest body, CancellationToken cancellationToken = default);

    Task<AlternativeShiftAsyncResponse> CreateAlternativeshiftsOffersSearchJobsAsync(AlternativeShiftSearchOffersRequest body, CancellationToken cancellationToken = default);

    Task<AlternativeShiftTradeResponse> CreateAlternativeshiftsTradesAsync(CreateAlternativeShiftTradeRequest body, CancellationToken cancellationToken = default);

    Task<BusinessUnitActivityCode> CreateBusinessunitActivitycodesAsync(string businessUnitId, CreateActivityCodeRequest body, CancellationToken cancellationToken = default);

    Task<ActivityPlanJobResponse> CreateBusinessunitActivityplanRunsJobsAsync(string businessUnitId, string activityPlanId, CancellationToken cancellationToken = default);

    Task<ActivityPlanResponse> CreateBusinessunitActivityplansAsync(string businessUnitId, CreateActivityPlanRequest body, CancellationToken cancellationToken = default);

    Task<BuQueryAdherenceExplanationsResponse> CreateBusinessunitAdherenceExplanationsQueryAsync(string businessUnitId, BuQueryAdherenceExplanationsRequest body, bool? forceAsync, bool? forceDownloadService, CancellationToken cancellationToken = default);

    Task<BuAsyncAgentSchedulesSearchResponse> CreateBusinessunitAgentschedulesSearchAsync(string businessUnitId, bool? forceAsync, bool? forceDownloadService, BuSearchAgentSchedulesRequest body, CancellationToken cancellationToken = default);

    Task<BuListAlternativeShiftTradesResponse> CreateBusinessunitAlternativeshiftsTradesSearchAsync(string businessUnitId, SearchAlternativeShiftTradesRequest body, bool? forceAsync, CancellationToken cancellationToken = default);

    Task<AsyncIntradayResponse> CreateBusinessunitIntradayAsync(string businessUnitId, bool? forceAsync, IntradayPlanningGroupRequest body, CancellationToken cancellationToken = default);

    Task<PlanningGroup> CreateBusinessunitPlanninggroupsAsync(string businessUnitId, CreatePlanningGroupRequest body, CancellationToken cancellationToken = default);

    Task<ServiceGoalTemplate> CreateBusinessunitServicegoaltemplatesAsync(string businessUnitId, CreateServiceGoalTemplate body, CancellationToken cancellationToken = default);

    Task<StaffingGroupResponse> CreateBusinessunitStaffinggroupsAsync(string businessUnitId, CreateStaffingGroupRequest body, CancellationToken cancellationToken = default);

    Task<UserStaffingGroupListing> CreateBusinessunitStaffinggroupsQueryAsync(string businessUnitId, QueryUserStaffingGroupListRequest body, CancellationToken cancellationToken = default);

    Task<BuTimeOffLimitResponse> CreateBusinessunitTimeofflimitsAsync(string businessUnitId, BuCreateTimeOffLimitRequest body, CancellationToken cancellationToken = default);

    Task<BuTimeOffLimitValuesResponse> CreateBusinessunitTimeofflimitsValuesQueryAsync(string businessUnitId, QueryTimeOffLimitValuesRequest body, CancellationToken cancellationToken = default);

    Task<BuTimeOffPlanResponse> CreateBusinessunitTimeoffplansAsync(string businessUnitId, BuCreateTimeOffPlanRequest body, CancellationToken cancellationToken = default);

    Task<BuAsyncAgentSchedulesQueryResponse> CreateBusinessunitWeekScheduleAgentschedulesQueryAsync(string businessUnitId, string weekId, string scheduleId, BuQueryAgentSchedulesRequest body, bool? forceAsync, bool? forceDownloadService, CancellationToken cancellationToken = default);

    Task<BuAsyncScheduleResponse> CreateBusinessunitWeekScheduleCopyAsync(string businessUnitId, string weekId, string scheduleId, BuCopyScheduleRequest body, CancellationToken cancellationToken = default);

    Task<PerformancePredictionRecalculationResponse> CreateBusinessunitWeekSchedulePerformancepredictionsRecalculationsAsync(string businessUnitId, string weekId, string scheduleId, WfmProcessUploadRequest body, CancellationToken cancellationToken = default);

    Task<PerformancePredictionRecalculationUploadResponse> CreateBusinessunitWeekSchedulePerformancepredictionsRecalculationsUploadurlAsync(string businessUnitId, string weekId, string scheduleId, UploadUrlRequestBody body, CancellationToken cancellationToken = default);

    Task<BuAsyncScheduleRunResponse> CreateBusinessunitWeekScheduleRescheduleAsync(string businessUnitId, string weekId, string scheduleId, BuRescheduleRequest body, CancellationToken cancellationToken = default);

    Task<BuAsyncScheduleResponse> CreateBusinessunitWeekScheduleUpdateAsync(string businessUnitId, string weekId, string scheduleId, ProcessScheduleUpdateUploadRequest body, CancellationToken cancellationToken = default);

    Task<UpdateScheduleUploadResponse> CreateBusinessunitWeekScheduleUpdateUploadurlAsync(string businessUnitId, string weekId, string scheduleId, UploadUrlRequestBody body, CancellationToken cancellationToken = default);

    Task<BuScheduleMetadata> CreateBusinessunitWeekSchedulesAsync(string businessUnitId, string weekId, BuCreateBlankScheduleRequest body, CancellationToken cancellationToken = default);

    Task<BuAsyncScheduleRunResponse> CreateBusinessunitWeekSchedulesGenerateAsync(string businessUnitId, string weekId, BuGenerateScheduleRequest body, CancellationToken cancellationToken = default);

    Task<ScheduleUploadProcessingResponse> CreateBusinessunitWeekSchedulesImportAsync(string businessUnitId, string weekId, WfmProcessUploadRequest body, CancellationToken cancellationToken = default);

    Task<ImportScheduleUploadResponse> CreateBusinessunitWeekSchedulesImportUploadurlAsync(string businessUnitId, string weekId, UploadUrlRequestBody body, CancellationToken cancellationToken = default);

    Task<AsyncForecastOperationResult> CreateBusinessunitWeekShorttermforecastCopyAsync(string businessUnitId, string weekDateId, string forecastId, CopyBuForecastRequest body, bool? forceAsync, CancellationToken cancellationToken = default);

    Task<AsyncForecastOperationResult> CreateBusinessunitWeekShorttermforecastsGenerateAsync(string businessUnitId, string weekDateId, GenerateBuForecastRequest body, bool? forceAsync, CancellationToken cancellationToken = default);

    Task<ImportForecastResponse> CreateBusinessunitWeekShorttermforecastsImportAsync(string businessUnitId, string weekDateId, WfmProcessUploadRequest body, CancellationToken cancellationToken = default);

    Task<ImportForecastUploadResponse> CreateBusinessunitWeekShorttermforecastsImportUploadurlAsync(string businessUnitId, string weekDateId, UploadUrlRequestBody body, CancellationToken cancellationToken = default);

    Task<WorkPlanBid> CreateBusinessunitWorkplanbidCopyAsync(string businessUnitId, string bidId, CopyWorkPlanBid body, CancellationToken cancellationToken = default);

    Task<WorkPlanBidGroupResponse> CreateBusinessunitWorkplanbidGroupsAsync(string businessUnitId, string bidId, WorkPlanBidGroupCreate body, CancellationToken cancellationToken = default);

    Task<WorkPlanBid> CreateBusinessunitWorkplanbidsAsync(string businessUnitId, CreateWorkPlanBid body, CancellationToken cancellationToken = default);

    Task<BusinessUnitResponse> CreateBusinessunitsAsync(CreateBusinessUnitRequest body, CancellationToken cancellationToken = default);

    Task<CalendarUrlResponse> CreateCalendarUrlIcsAsync(string language, CancellationToken cancellationToken = default);

    Task<HistoricalImportDeleteFilesJobResponse> CreateHistoricaldataBulkRemoveJobsAsync(HistoricalImportDeleteFilesJobRequest body, CancellationToken cancellationToken = default);

    Task<HistoricalImportDeleteJobResponse> CreateHistoricaldataDeletejobAsync(CancellationToken cancellationToken = default);

    Task<ValidationServiceAsyncResponse> CreateHistoricaldataValidateAsync(ValidationServiceRequest body, CancellationToken cancellationToken = default);

    Task<HrisTimeOffTypesResponse> CreateIntegrationsHriTimeofftypesJobsAsync(string hrisIntegrationId, CancellationToken cancellationToken = default);

    Task<AgentsWorkPlansResponse> CreateManagementunitAgentsWorkplansQueryAsync(string managementUnitId, bool? forceDownloadService, GetAgentsWorkPlansRequest body, CancellationToken cancellationToken = default);

    Task<BuAsyncAgentSchedulesSearchResponse> CreateManagementunitAgentschedulesSearchAsync(string managementUnitId, bool? forceAsync, bool? forceDownloadService, BuSearchAgentSchedulesRequest body, CancellationToken cancellationToken = default);

    Task<WfmHistoricalAdherenceResponse> CreateManagementunitHistoricaladherencequeryAsync(string managementUnitId, WfmHistoricalAdherenceQuery body, CancellationToken cancellationToken = default);

    Task<MoveManagementUnitResponse> CreateManagementunitMoveAsync(string managementUnitId, MoveManagementUnitRequest body, CancellationToken cancellationToken = default);

    Task<UserScheduleContainer> CreateManagementunitSchedulesSearchAsync(string managementUnitId, UserListScheduleRequestBody body, CancellationToken cancellationToken = default);

    Task<WfmHistoricalShrinkageResponse> CreateManagementunitShrinkageJobsAsync(string managementUnitId, WfmHistoricalShrinkageRequest body, CancellationToken cancellationToken = default);

    Task<TimeOffLimit> CreateManagementunitTimeofflimitsAsync(string managementUnitId, CreateTimeOffLimitRequest body, CancellationToken cancellationToken = default);

    Task<QueryTimeOffLimitValuesResponse> CreateManagementunitTimeofflimitsValuesQueryAsync(string managementUnitId, QueryTimeOffLimitValuesRequest body, CancellationToken cancellationToken = default);

    Task<TimeOffPlan> CreateManagementunitTimeoffplansAsync(string managementUnitId, CreateTimeOffPlanRequest body, CancellationToken cancellationToken = default);

    Task<TimeOffRequestList> CreateManagementunitTimeoffrequestsAsync(string managementUnitId, CreateAdminTimeOffRequest body, CancellationToken cancellationToken = default);

    Task<UserTimeOffIntegrationStatusResponseListing> CreateManagementunitTimeoffrequestsIntegrationstatusQueryAsync(string managementUnitId, QueryTimeOffIntegrationStatusRequest body, CancellationToken cancellationToken = default);

    Task<TimeOffRequestListing> CreateManagementunitTimeoffrequestsQueryAsync(string managementUnitId, bool? forceDownloadService, TimeOffRequestQueryBody body, CancellationToken cancellationToken = default);

    Task<WaitlistPositionListing> CreateManagementunitTimeoffrequestsWaitlistpositionsQueryAsync(string managementUnitId, QueryWaitlistPositionsRequest body, CancellationToken cancellationToken = default);

    Task<TimeOffBalancesResponse> CreateManagementunitUserTimeoffbalanceJobsAsync(string managementUnitId, string userId, TimeOffBalanceRequest body, CancellationToken cancellationToken = default);

    Task<TimeOffBalancesResponse> CreateManagementunitUserTimeoffrequestTimeoffbalanceJobsAsync(string managementUnitId, string userId, string timeOffRequestId, CancellationToken cancellationToken = default);

    Task<EstimateAvailableTimeOffResponse> CreateManagementunitUserTimeoffrequestsEstimateAsync(string managementUnitId, string userId, EstimateAvailableTimeOffRequest body, CancellationToken cancellationToken = default);

    Task<MatchShiftTradeResponse> CreateManagementunitWeekShifttradeMatchAsync(string managementUnitId, string weekDateId, string tradeId, MatchShiftTradeRequest body, CancellationToken cancellationToken = default);

    Task<ShiftTradeResponse> CreateManagementunitWeekShifttradesAsync(string managementUnitId, string weekDateId, AddShiftTradeRequest body, CancellationToken cancellationToken = default);

    Task<SearchShiftTradesResponse> CreateManagementunitWeekShifttradesSearchAsync(string managementUnitId, string weekDateId, SearchShiftTradesRequest body, bool? forceDownloadService, CancellationToken cancellationToken = default);

    Task<BulkUpdateShiftTradeStateResponse> CreateManagementunitWeekShifttradesStateBulkAsync(string managementUnitId, string weekDateId, BulkShiftTradeStateUpdateRequest body, bool? forceAsync, CancellationToken cancellationToken = default);

    Task<WorkPlan> CreateManagementunitWorkplanCopyAsync(string managementUnitId, string workPlanId, CopyWorkPlan body, CancellationToken cancellationToken = default);

    Task<ValidateWorkPlanResponse> CreateManagementunitWorkplanValidateAsync(string managementUnitId, string workPlanId, List<string> expand, WorkPlanValidationRequest body, CancellationToken cancellationToken = default);

    Task<WorkPlanRotationResponse> CreateManagementunitWorkplanrotationCopyAsync(string managementUnitId, string workPlanRotationId, CopyWorkPlanRotationRequest body, CancellationToken cancellationToken = default);

    Task<WorkPlanRotationResponse> CreateManagementunitWorkplanrotationsAsync(string managementUnitId, AddWorkPlanRotationRequest body, CancellationToken cancellationToken = default);

    Task<WorkPlan> CreateManagementunitWorkplansAsync(string managementUnitId, string validationMode, CreateWorkPlan body, CancellationToken cancellationToken = default);

    Task<ManagementUnit> CreateManagementunitsAsync(CreateManagementUnitApiRequest body, CancellationToken cancellationToken = default);

    Task<UpdateNotificationsResponse> CreateNotificationsUpdateAsync(UpdateNotificationsRequest body, CancellationToken cancellationToken = default);

    Task<UserScheduleContainer> CreateSchedulesAsync(CurrentUserScheduleRequestBody body, CancellationToken cancellationToken = default);

    Task<WfmHistoricalAdherenceResponse> CreateTeamAdherenceHistoricalAsync(string teamId, WfmHistoricalAdherenceQueryForTeams body, CancellationToken cancellationToken = default);

    Task<WfmHistoricalShrinkageResponse> CreateTeamShrinkageJobsAsync(string teamId, WfmHistoricalShrinkageTeamsRequest body, CancellationToken cancellationToken = default);

    Task<TimeOffBalancesResponse> CreateTimeoffbalanceJobsAsync(TimeOffBalanceRequest body, CancellationToken cancellationToken = default);

    Task<AvailableTimeOffResponse> CreateTimeofflimitsAvailableQueryAsync(AvailableTimeOffRequest body, CancellationToken cancellationToken = default);

    Task<TimeOffRequestResponse> CreateTimeoffrequestsAsync(CreateAgentTimeOffRequest body, CancellationToken cancellationToken = default);

    Task<EstimateAvailableTimeOffResponse> CreateTimeoffrequestsEstimateAsync(EstimateAvailableTimeOffRequest body, CancellationToken cancellationToken = default);

    Task<TimeOffIntegrationStatusResponseListing> CreateTimeoffrequestsIntegrationstatusQueryAsync(CurrentUserTimeOffIntegrationStatusRequest body, CancellationToken cancellationToken = default);

    Task<AgentIntegrationsResponse> UpdateAgentIntegrationsHrisAsync(string agentId, AgentIntegrationsRequest body, CancellationToken cancellationToken = default);

    Task<BuTimeOffLimitResponse> UpdateBusinessunitTimeofflimitValuesAsync(string businessUnitId, string timeOffLimitId, BuSetTimeOffLimitValuesRequest body, CancellationToken cancellationToken = default);

    Task<TimeOffLimit> UpdateManagementunitTimeofflimitValuesAsync(string managementUnitId, string timeOffLimitId, SetTimeOffLimitValuesRequest body, CancellationToken cancellationToken = default);

}
