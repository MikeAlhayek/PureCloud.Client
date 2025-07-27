using PureCloud.Client.Models;

namespace PureCloud.Client.Contracts;

public interface IWorkforceManagementApi
{
    Task DeleteBusinessunitAsync(string businessUnitId, CancellationToken cancellationToken = default);

    Task DeleteBusinessunitActivitycodeAsync(string businessUnitId, string activityCodeId, CancellationToken cancellationToken = default);

    Task DeleteBusinessunitPlanninggroupAsync(string businessUnitId, string planningGroupId, CancellationToken cancellationToken = default);

    Task DeleteBusinessunitSchedulingRunAsync(string businessUnitId, string runId, CancellationToken cancellationToken = default);

    Task DeleteBusinessunitServicegoaltemplateAsync(string businessUnitId, string serviceGoalTemplateId, CancellationToken cancellationToken = default);

    Task DeleteBusinessunitStaffinggroupAsync(string businessUnitId, string staffingGroupId, CancellationToken cancellationToken = default);

    Task DeleteBusinessunitTimeofflimitAsync(string businessUnitId, string timeOffLimitId, CancellationToken cancellationToken = default);

    Task DeleteBusinessunitTimeoffplanAsync(string businessUnitId, string timeOffPlanId, CancellationToken cancellationToken = default);

    Task DeleteBusinessunitWeekScheduleAsync(string businessUnitId, string weekId, string scheduleId, CancellationToken cancellationToken = default);

    Task DeleteBusinessunitWeekShorttermforecastAsync(string businessUnitId, string weekDateId, string forecastId, CancellationToken cancellationToken = default);

    Task DeleteBusinessunitWorkplanbidAsync(string businessUnitId, string bidId, CancellationToken cancellationToken = default);

    Task DeleteBusinessunitWorkplanbidGroupAsync(string businessUnitId, string bidId, string bidGroupId, CancellationToken cancellationToken = default);

    Task DeleteCalendarUrlIcsAsync(CancellationToken cancellationToken = default);

    Task DeleteManagementunitAsync(string managementUnitId, CancellationToken cancellationToken = default);

    Task DeleteManagementunitTimeofflimitAsync(string managementUnitId, string timeOffLimitId, CancellationToken cancellationToken = default);

    Task DeleteManagementunitTimeoffplanAsync(string managementUnitId, string timeOffPlanId, CancellationToken cancellationToken = default);

    Task DeleteManagementunitWorkplanAsync(string managementUnitId, string workPlanId, CancellationToken cancellationToken = default);

    Task DeleteManagementunitWorkplanrotationAsync(string managementUnitId, string workPlanRotationId, CancellationToken cancellationToken = default);

    Task GetAdherenceAsync(List<string> userId, CancellationToken cancellationToken = default);

    Task GetAdherenceExplanationAsync(string explanationId, CancellationToken cancellationToken = default);

    Task GetAdherenceExplanationsJobAsync(string jobId, CancellationToken cancellationToken = default);

    Task GetAdherenceHistoricalBulkJobAsync(string jobId, CancellationToken cancellationToken = default);

    Task GetAdherenceHistoricalJobAsync(string jobId, CancellationToken cancellationToken = default);

    Task GetAgentAdherenceExplanationAsync(string agentId, string explanationId, CancellationToken cancellationToken = default);

    Task GetAgentManagementunitAsync(string agentId, CancellationToken cancellationToken = default);

    Task GetAgentsMeManagementunitAsync(CancellationToken cancellationToken = default);

    Task GetAlternativeshiftsOffersJobAsync(string jobId, CancellationToken cancellationToken = default);

    Task GetAlternativeshiftsOffersSearchJobAsync(string jobId, CancellationToken cancellationToken = default);

    Task GetAlternativeshiftsSettingsAsync(CancellationToken cancellationToken = default);

    Task GetAlternativeshiftsTradeAsync(string tradeId, CancellationToken cancellationToken = default);

    Task GetAlternativeshiftsTradesAsync(bool? forceAsync = null, CancellationToken cancellationToken = default);

    Task GetAlternativeshiftsTradesJobAsync(string jobId, CancellationToken cancellationToken = default);

    Task GetAlternativeshiftsTradesStateJobAsync(string jobId, CancellationToken cancellationToken = default);

    Task GetBusinessunitAsync(string businessUnitId, List<string> expand, CancellationToken cancellationToken = default);

    Task GetBusinessunitActivitycodeAsync(string businessUnitId, string activityCodeId, CancellationToken cancellationToken = default);

    Task GetBusinessunitActivitycodesAsync(string businessUnitId, bool? forceDownloadService = null, CancellationToken cancellationToken = default);

    Task GetBusinessunitActivityplanAsync(string businessUnitId, string activityPlanId, CancellationToken cancellationToken = default);

    Task GetBusinessunitActivityplanRunsJobAsync(string businessUnitId, string activityPlanId, string jobId, CancellationToken cancellationToken = default);

    Task GetBusinessunitActivityplansAsync(string businessUnitId, string state, CancellationToken cancellationToken = default);

    Task GetBusinessunitActivityplansJobsAsync(string businessUnitId, CancellationToken cancellationToken = default);

    Task GetBusinessunitAlternativeshiftsSettingsAsync(string businessUnitId, CancellationToken cancellationToken = default);

    Task GetBusinessunitAlternativeshiftsTradeAsync(string businessUnitId, string tradeId, CancellationToken cancellationToken = default);

    Task GetBusinessunitAlternativeshiftsTradesSearchJobAsync(string businessUnitId, string jobId, CancellationToken cancellationToken = default);

    Task GetBusinessunitIntradayPlanninggroupsAsync(string businessUnitId, string date, CancellationToken cancellationToken = default);

    Task GetBusinessunitMainforecastContinuousforecastSessionAsync(string businessUnitId, CancellationToken cancellationToken = default);

    Task GetBusinessunitMainforecastContinuousforecastSessionSessionIdAsync(string businessUnitId, string sessionId, CancellationToken cancellationToken = default);

    Task GetBusinessunitMainforecastContinuousforecastSessionSessionIdSnapshotSnapshotIdAsync(string businessUnitId, string sessionId, string snapshotId, CancellationToken cancellationToken = default);

    Task GetBusinessunitManagementunitsAsync(string businessUnitId, string feature, string divisionId, CancellationToken cancellationToken = default);

    Task GetBusinessunitPlanninggroupAsync(string businessUnitId, string planningGroupId, CancellationToken cancellationToken = default);

    Task GetBusinessunitPlanninggroupsAsync(string businessUnitId, CancellationToken cancellationToken = default);

    Task GetBusinessunitSchedulingRunAsync(string businessUnitId, string runId, CancellationToken cancellationToken = default);

    Task GetBusinessunitSchedulingRunResultAsync(string businessUnitId, string runId, List<string> managementUnitIds, List<string> expand, CancellationToken cancellationToken = default);

    Task GetBusinessunitSchedulingRunsAsync(string businessUnitId, CancellationToken cancellationToken = default);

    Task GetBusinessunitServicegoaltemplateAsync(string businessUnitId, string serviceGoalTemplateId, List<string> expand, CancellationToken cancellationToken = default);

    Task GetBusinessunitServicegoaltemplatesAsync(string businessUnitId, List<string> expand, CancellationToken cancellationToken = default);

    Task GetBusinessunitStaffinggroupAsync(string businessUnitId, string staffingGroupId, CancellationToken cancellationToken = default);

    Task GetBusinessunitStaffinggroupsAsync(string businessUnitId, string managementUnitId, CancellationToken cancellationToken = default);

    Task GetBusinessunitTimeofflimitAsync(string businessUnitId, string timeOffLimitId, CancellationToken cancellationToken = default);

    Task GetBusinessunitTimeofflimitsAsync(string businessUnitId, string managementUnitId, CancellationToken cancellationToken = default);

    Task GetBusinessunitTimeoffplanAsync(string businessUnitId, string timeOffPlanId, CancellationToken cancellationToken = default);

    Task GetBusinessunitTimeoffplansAsync(string businessUnitId, string managementUnitId, bool? forceDownloadService = null, CancellationToken cancellationToken = default);

    Task GetBusinessunitWeekScheduleAsync(string businessUnitId, string weekId, string scheduleId, string expand, CancellationToken cancellationToken = default);

    Task GetBusinessunitWeekScheduleGenerationresultsAsync(string businessUnitId, string weekId, string scheduleId, CancellationToken cancellationToken = default);

    Task GetBusinessunitWeekScheduleHeadcountforecastAsync(string businessUnitId, string weekId, string scheduleId, bool? forceDownload = null, CancellationToken cancellationToken = default);

    Task GetBusinessunitWeekScheduleHistoryAgentAsync(string businessUnitId, string weekId, string scheduleId, string agentId, CancellationToken cancellationToken = default);

    Task GetBusinessunitWeekSchedulePerformancepredictionsAsync(string businessUnitId, string weekId, string scheduleId, CancellationToken cancellationToken = default);

    Task GetBusinessunitWeekSchedulePerformancepredictionsRecalculationAsync(string businessUnitId, string weekId, string scheduleId, string recalculationId, CancellationToken cancellationToken = default);

    Task GetBusinessunitWeekSchedulesAsync(string businessUnitId, string weekId, string expand, bool? includeOnlyPublished = null, CancellationToken cancellationToken = default);

    Task GetBusinessunitWeekShorttermforecastAsync(string businessUnitId, string weekDateId, string forecastId, List<string> expand, CancellationToken cancellationToken = default);

    Task GetBusinessunitWeekShorttermforecastDataAsync(string businessUnitId, string weekDateId, string forecastId, int? weekNumber = null, bool? forceDownloadService = null, CancellationToken cancellationToken = default);

    Task GetBusinessunitWeekShorttermforecastGenerationresultsAsync(string businessUnitId, string weekDateId, string forecastId, CancellationToken cancellationToken = default);

    Task GetBusinessunitWeekShorttermforecastLongtermforecastdataAsync(string businessUnitId, string weekDateId, string forecastId, bool? forceDownloadService = null, CancellationToken cancellationToken = default);

    Task GetBusinessunitWeekShorttermforecastPlanninggroupsAsync(string businessUnitId, string weekDateId, string forecastId, CancellationToken cancellationToken = default);

    Task GetBusinessunitWeekShorttermforecastStaffingrequirementAsync(string businessUnitId, string weekDateId, string forecastId, List<string> weekNumbers, CancellationToken cancellationToken = default);

    Task GetBusinessunitWeekShorttermforecastsAsync(string businessUnitId, string weekDateId, CancellationToken cancellationToken = default);

    Task GetBusinessunitWorkplanbidAsync(string businessUnitId, string bidId, CancellationToken cancellationToken = default);

    Task GetBusinessunitWorkplanbidGroupAsync(string businessUnitId, string bidId, string bidGroupId, CancellationToken cancellationToken = default);

    Task GetBusinessunitWorkplanbidGroupPreferencesAsync(string businessUnitId, string bidId, string bidGroupId, CancellationToken cancellationToken = default);

    Task GetBusinessunitWorkplanbidGroupsSummaryAsync(string businessUnitId, string bidId, CancellationToken cancellationToken = default);

    Task GetBusinessunitWorkplanbidsAsync(string businessUnitId, CancellationToken cancellationToken = default);

    Task GetBusinessunitsAsync(string feature, string divisionId, CancellationToken cancellationToken = default);

    Task GetBusinessunitsDivisionviewsAsync(List<string> divisionId, CancellationToken cancellationToken = default);

    Task GetCalendarDataIcsAsync(string calendarId, CancellationToken cancellationToken = default);

    Task GetCalendarUrlIcsAsync(CancellationToken cancellationToken = default);

    Task GetHistoricaldataBulkRemoveJobAsync(string jobId, CancellationToken cancellationToken = default);

    Task GetHistoricaldataBulkRemoveJobsAsync(CancellationToken cancellationToken = default);

    Task GetHistoricaldataDeletejobAsync(CancellationToken cancellationToken = default);

    Task GetHistoricaldataImportstatusAsync(CancellationToken cancellationToken = default);

    Task GetHistoricaldataImportstatusJobIdAsync(string jobId, CancellationToken cancellationToken = default);

    Task GetIntegrationsHrisAsync(CancellationToken cancellationToken = default);

    Task GetIntegrationsHrisTimeofftypesJobAsync(string jobId, CancellationToken cancellationToken = default);

    Task GetManagementunitAsync(string managementUnitId, List<string> expand, CancellationToken cancellationToken = default);

    Task GetManagementunitActivitycodesAsync(string managementUnitId, CancellationToken cancellationToken = default);

    Task GetManagementunitAdherenceAsync(string managementUnitId, bool? forceDownloadService = null, CancellationToken cancellationToken = default);

    Task GetManagementunitAgentAsync(string managementUnitId, string agentId, List<string> expand, bool? excludeCapabilities = null, CancellationToken cancellationToken = default);

    Task GetManagementunitAgentShifttradesAsync(string managementUnitId, string agentId, CancellationToken cancellationToken = default);

    Task GetManagementunitShifttradesMatchedAsync(string managementUnitId, CancellationToken cancellationToken = default);

    Task GetManagementunitShifttradesUsersAsync(string managementUnitId, CancellationToken cancellationToken = default);

    Task GetManagementunitTimeofflimitAsync(string managementUnitId, string timeOffLimitId, CancellationToken cancellationToken = default);

    Task GetManagementunitTimeofflimitsAsync(string managementUnitId, CancellationToken cancellationToken = default);

    Task GetManagementunitTimeoffplanAsync(string managementUnitId, string timeOffPlanId, CancellationToken cancellationToken = default);

    Task GetManagementunitTimeoffplansAsync(string managementUnitId, CancellationToken cancellationToken = default);

    Task GetManagementunitUserTimeoffrequestAsync(string managementUnitId, string userId, string timeOffRequestId, CancellationToken cancellationToken = default);

    Task GetManagementunitUserTimeoffrequestTimeofflimitsAsync(string managementUnitId, string userId, string timeOffRequestId, CancellationToken cancellationToken = default);

    Task GetManagementunitUserTimeoffrequestsAsync(string managementUnitId, string userId, CancellationToken cancellationToken = default);

    Task GetManagementunitUsersAsync(string managementUnitId, CancellationToken cancellationToken = default);

    Task GetManagementunitWeekScheduleAsync(string managementUnitId, string weekId, string scheduleId, string expand, bool? forceDownloadService = null, CancellationToken cancellationToken = default);

    Task GetManagementunitWeekSchedulesAsync(string managementUnitId, string weekId, string earliestWeekDate, string latestWeekDate, bool? includeOnlyPublished = null, CancellationToken cancellationToken = default);

    Task GetManagementunitWeekShifttradesAsync(string managementUnitId, string weekDateId, bool? evaluateMatches = null, bool? forceDownloadService = null, CancellationToken cancellationToken = default);

    Task GetManagementunitWorkplanAsync(string managementUnitId, string workPlanId, List<string> includeOnly, CancellationToken cancellationToken = default);

    Task GetManagementunitWorkplanrotationAsync(string managementUnitId, string workPlanRotationId, CancellationToken cancellationToken = default);

    Task GetManagementunitWorkplanrotationsAsync(string managementUnitId, List<string> expand, CancellationToken cancellationToken = default);

    Task GetManagementunitWorkplansAsync(string managementUnitId, List<string> expand, List<string> exclude, CancellationToken cancellationToken = default);

    Task GetManagementunitsAsync(string expand, string feature, string divisionId, int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default);

    Task GetManagementunitsDivisionviewsAsync(List<string> divisionId, CancellationToken cancellationToken = default);

    Task GetNotificationsAsync(CancellationToken cancellationToken = default);

    Task GetSchedulingjobAsync(string jobId, CancellationToken cancellationToken = default);

    Task GetShifttradesAsync(CancellationToken cancellationToken = default);

    Task GetShrinkageJobAsync(string jobId, CancellationToken cancellationToken = default);

    Task GetTimeoffbalanceJobAsync(string jobId, CancellationToken cancellationToken = default);

    Task GetTimeoffrequestAsync(string timeOffRequestId, CancellationToken cancellationToken = default);

    Task GetTimeoffrequestWaitlistpositionsAsync(string timeOffRequestId, CancellationToken cancellationToken = default);

    Task GetTimeoffrequestsAsync(CancellationToken cancellationToken = default);

    Task GetUserWorkplanbidranksAsync(string userId, CancellationToken cancellationToken = default);

    Task GetWorkplanbidPreferencesAsync(string bidId, CancellationToken cancellationToken = default);

    Task GetWorkplanbidWorkplansAsync(string bidId, CancellationToken cancellationToken = default);

    Task GetWorkplanbidsAsync(CancellationToken cancellationToken = default);

    Task UpdateAgentAdherenceExplanationAsync(string agentId, string explanationId, UpdateAdherenceExplanationStatusRequest body, CancellationToken cancellationToken = default);

    Task UpdateAlternativeshiftsTradeAsync(string tradeId, AgentUpdateAlternativeShiftTradeRequest body, CancellationToken cancellationToken = default);

    Task UpdateAlternativeshiftsTradesStateJobsAsync(AdminBulkUpdateAlternativeShiftTradeStateRequest body, CancellationToken cancellationToken = default);

    Task UpdateBusinessunitAsync(string businessUnitId, UpdateBusinessUnitRequest body, CancellationToken cancellationToken = default);

    Task UpdateBusinessunitActivitycodeAsync(string businessUnitId, string activityCodeId, UpdateActivityCodeRequest body, CancellationToken cancellationToken = default);

    Task UpdateBusinessunitActivityplanAsync(string businessUnitId, string activityPlanId, UpdateActivityPlanRequest body, CancellationToken cancellationToken = default);

    Task UpdateBusinessunitAlternativeshiftsSettingsAsync(string businessUnitId, UpdateAlternativeShiftBuSettingsRequest body, CancellationToken cancellationToken = default);

    Task UpdateBusinessunitPlanninggroupAsync(string businessUnitId, string planningGroupId, UpdatePlanningGroupRequest body, CancellationToken cancellationToken = default);

    Task UpdateBusinessunitSchedulingRunAsync(string businessUnitId, string runId, PatchBuScheduleRunRequest body, CancellationToken cancellationToken = default);

    Task UpdateBusinessunitServicegoaltemplateAsync(string businessUnitId, string serviceGoalTemplateId, UpdateServiceGoalTemplate body, CancellationToken cancellationToken = default);

    Task UpdateBusinessunitStaffinggroupAsync(string businessUnitId, string staffingGroupId, UpdateStaffingGroupRequest body, CancellationToken cancellationToken = default);

    Task UpdateBusinessunitTimeoffplanAsync(string businessUnitId, string timeOffPlanId, BuUpdateTimeOffPlanRequest body, CancellationToken cancellationToken = default);

    Task UpdateBusinessunitWorkplanbidAsync(string businessUnitId, string bidId, UpdateWorkPlanBid body, CancellationToken cancellationToken = default);

    Task UpdateBusinessunitWorkplanbidGroupAsync(string businessUnitId, string bidId, string bidGroupId, WorkPlanBidGroupUpdate body, CancellationToken cancellationToken = default);

    Task UpdateBusinessunitWorkplanbidGroupPreferencesAsync(string businessUnitId, string bidId, string bidGroupId, AgentsBidAssignedWorkPlanOverrideRequest body, CancellationToken cancellationToken = default);

    Task UpdateManagementunitAsync(string managementUnitId, UpdateManagementUnitRequest body, CancellationToken cancellationToken = default);

    Task UpdateManagementunitAgentsAsync(string managementUnitId, UpdateMuAgentsRequest body, CancellationToken cancellationToken = default);

    Task UpdateManagementunitAgentsWorkplansBulkAsync(string managementUnitId, UpdateMuAgentWorkPlansBatchRequest body, CancellationToken cancellationToken = default);

    Task UpdateManagementunitTimeofflimitAsync(string managementUnitId, string timeOffLimitId, UpdateTimeOffLimitRequest body, CancellationToken cancellationToken = default);

    Task UpdateManagementunitTimeoffplanAsync(string managementUnitId, string timeOffPlanId, UpdateTimeOffPlanRequest body, CancellationToken cancellationToken = default);

    Task UpdateManagementunitTimeoffrequestUserIntegrationstatusAsync(string managementUnitId, string timeOffRequestId, string userId, SetTimeOffIntegrationStatusRequest body, CancellationToken cancellationToken = default);

    Task UpdateManagementunitUserTimeoffrequestAsync(string managementUnitId, string userId, string timeOffRequestId, AdminTimeOffRequestPatch body, CancellationToken cancellationToken = default);

    Task UpdateManagementunitWeekShifttradeAsync(string managementUnitId, string weekDateId, string tradeId, PatchShiftTradeRequest body, CancellationToken cancellationToken = default);

    Task UpdateManagementunitWorkplanAsync(string managementUnitId, string workPlanId, string validationMode, WorkPlan body, CancellationToken cancellationToken = default);

    Task UpdateManagementunitWorkplanrotationAsync(string managementUnitId, string workPlanRotationId, UpdateWorkPlanRotationRequest body, CancellationToken cancellationToken = default);

    Task UpdateTimeoffrequestAsync(string timeOffRequestId, AgentTimeOffRequestPatch body, CancellationToken cancellationToken = default);

    Task UpdateUserWorkplanbidranksAsync(string userId, WorkPlanBidRanks body, CancellationToken cancellationToken = default);

    Task UpdateUsersWorkplanbidranksBulkAsync(List<WorkPlanBidRanks> body, CancellationToken cancellationToken = default);

    Task UpdateWorkplanbidPreferencesAsync(string bidId, UpdateAgentWorkPlanBiddingPreference body, CancellationToken cancellationToken = default);

    Task CreateAdherenceExplanationsAsync(AddAdherenceExplanationAgentRequest body, CancellationToken cancellationToken = default);

    Task CreateAdherenceExplanationsQueryAsync(AgentQueryAdherenceExplanationsRequest body, bool? forceAsync = null, bool? forceDownloadService = null, CancellationToken cancellationToken = default);

    Task CreateAdherenceHistoricalAsync(WfmHistoricalAdherenceQueryForUsers body, CancellationToken cancellationToken = default);

    Task CreateAdherenceHistoricalBulkAsync(WfmHistoricalAdherenceBulkQuery body, CancellationToken cancellationToken = default);

    Task CreateAgentAdherenceExplanationsAsync(string agentId, AddAdherenceExplanationAdminRequest body, CancellationToken cancellationToken = default);

    Task CreateAgentAdherenceExplanationsQueryAsync(string agentId, AgentQueryAdherenceExplanationsRequest body, bool? forceAsync = null, bool? forceDownloadService = null, CancellationToken cancellationToken = default);

    Task CreateAgentsAsync(MoveAgentsRequest body, CancellationToken cancellationToken = default);

    Task CreateAgentsIntegrationsHrisQueryAsync(QueryAgentsIntegrationsRequest body, CancellationToken cancellationToken = default);

    Task CreateAgentsMePossibleworkshiftsAsync(AgentPossibleWorkShiftsRequest body, CancellationToken cancellationToken = default);

    Task CreateAgentschedulesMineAsync(BuGetCurrentAgentScheduleRequest body, CancellationToken cancellationToken = default);

    Task CreateAlternativeshiftsOffersJobsAsync(AlternativeShiftOffersRequest body, CancellationToken cancellationToken = default);

    Task CreateAlternativeshiftsOffersSearchJobsAsync(AlternativeShiftSearchOffersRequest body, CancellationToken cancellationToken = default);

    Task CreateAlternativeshiftsTradesAsync(CreateAlternativeShiftTradeRequest body, CancellationToken cancellationToken = default);

    Task CreateBusinessunitActivitycodesAsync(string businessUnitId, CreateActivityCodeRequest body, CancellationToken cancellationToken = default);

    Task CreateBusinessunitActivityplanRunsJobsAsync(string businessUnitId, string activityPlanId, CancellationToken cancellationToken = default);

    Task CreateBusinessunitActivityplansAsync(string businessUnitId, CreateActivityPlanRequest body, CancellationToken cancellationToken = default);

    Task CreateBusinessunitAdherenceExplanationsQueryAsync(string businessUnitId, BuQueryAdherenceExplanationsRequest body, bool? forceAsync = null, bool? forceDownloadService = null, CancellationToken cancellationToken = default);

    Task CreateBusinessunitAgentschedulesSearchAsync(string businessUnitId, BuSearchAgentSchedulesRequest body, bool? forceAsync = null, bool? forceDownloadService = null, CancellationToken cancellationToken = default);

    Task CreateBusinessunitAlternativeshiftsTradesSearchAsync(string businessUnitId, SearchAlternativeShiftTradesRequest body, bool? forceAsync = null, CancellationToken cancellationToken = default);

    Task CreateBusinessunitIntradayAsync(string businessUnitId, IntradayPlanningGroupRequest body, bool? forceAsync = null, CancellationToken cancellationToken = default);

    Task CreateBusinessunitPlanninggroupsAsync(string businessUnitId, CreatePlanningGroupRequest body, CancellationToken cancellationToken = default);

    Task CreateBusinessunitServicegoaltemplatesAsync(string businessUnitId, CreateServiceGoalTemplate body, CancellationToken cancellationToken = default);

    Task CreateBusinessunitStaffinggroupsAsync(string businessUnitId, CreateStaffingGroupRequest body, CancellationToken cancellationToken = default);

    Task CreateBusinessunitStaffinggroupsQueryAsync(string businessUnitId, QueryUserStaffingGroupListRequest body, CancellationToken cancellationToken = default);

    Task CreateBusinessunitTimeofflimitsAsync(string businessUnitId, BuCreateTimeOffLimitRequest body, CancellationToken cancellationToken = default);

    Task CreateBusinessunitTimeofflimitsValuesQueryAsync(string businessUnitId, QueryTimeOffLimitValuesRequest body, CancellationToken cancellationToken = default);

    Task CreateBusinessunitTimeoffplansAsync(string businessUnitId, BuCreateTimeOffPlanRequest body, CancellationToken cancellationToken = default);

    Task CreateBusinessunitWeekScheduleAgentschedulesQueryAsync(string businessUnitId, string weekId, string scheduleId, BuQueryAgentSchedulesRequest body, bool? forceAsync = null, bool? forceDownloadService = null, CancellationToken cancellationToken = default);

    Task CreateBusinessunitWeekScheduleCopyAsync(string businessUnitId, string weekId, string scheduleId, BuCopyScheduleRequest body, CancellationToken cancellationToken = default);

    Task CreateBusinessunitWeekSchedulePerformancepredictionsRecalculationsAsync(string businessUnitId, string weekId, string scheduleId, WfmProcessUploadRequest body, CancellationToken cancellationToken = default);

    Task CreateBusinessunitWeekSchedulePerformancepredictionsRecalculationsUploadurlAsync(string businessUnitId, string weekId, string scheduleId, UploadUrlRequestBody body, CancellationToken cancellationToken = default);

    Task CreateBusinessunitWeekScheduleRescheduleAsync(string businessUnitId, string weekId, string scheduleId, BuRescheduleRequest body, CancellationToken cancellationToken = default);

    Task CreateBusinessunitWeekScheduleUpdateAsync(string businessUnitId, string weekId, string scheduleId, ProcessScheduleUpdateUploadRequest body, CancellationToken cancellationToken = default);

    Task CreateBusinessunitWeekScheduleUpdateUploadurlAsync(string businessUnitId, string weekId, string scheduleId, UploadUrlRequestBody body, CancellationToken cancellationToken = default);

    Task CreateBusinessunitWeekSchedulesAsync(string businessUnitId, string weekId, BuCreateBlankScheduleRequest body, CancellationToken cancellationToken = default);

    Task CreateBusinessunitWeekSchedulesGenerateAsync(string businessUnitId, string weekId, BuGenerateScheduleRequest body, CancellationToken cancellationToken = default);

    Task CreateBusinessunitWeekSchedulesImportAsync(string businessUnitId, string weekId, WfmProcessUploadRequest body, CancellationToken cancellationToken = default);

    Task CreateBusinessunitWeekSchedulesImportUploadurlAsync(string businessUnitId, string weekId, UploadUrlRequestBody body, CancellationToken cancellationToken = default);

    Task CreateBusinessunitWeekShorttermforecastCopyAsync(string businessUnitId, string weekDateId, string forecastId, CopyBuForecastRequest body, bool? forceAsync = null, CancellationToken cancellationToken = default);

    Task CreateBusinessunitWeekShorttermforecastsGenerateAsync(string businessUnitId, string weekDateId, GenerateBuForecastRequest body, bool? forceAsync = null, CancellationToken cancellationToken = default);

    Task CreateBusinessunitWeekShorttermforecastsImportAsync(string businessUnitId, string weekDateId, WfmProcessUploadRequest body, CancellationToken cancellationToken = default);

    Task CreateBusinessunitWeekShorttermforecastsImportUploadurlAsync(string businessUnitId, string weekDateId, UploadUrlRequestBody body, CancellationToken cancellationToken = default);

    Task CreateBusinessunitWorkplanbidCopyAsync(string businessUnitId, string bidId, CopyWorkPlanBid body, CancellationToken cancellationToken = default);

    Task CreateBusinessunitWorkplanbidGroupsAsync(string businessUnitId, string bidId, WorkPlanBidGroupCreate body, CancellationToken cancellationToken = default);

    Task CreateBusinessunitWorkplanbidsAsync(string businessUnitId, CreateWorkPlanBid body, CancellationToken cancellationToken = default);

    Task CreateBusinessunitsAsync(CreateBusinessUnitRequest body, CancellationToken cancellationToken = default);

    Task CreateCalendarUrlIcsAsync(string language, CancellationToken cancellationToken = default);

    Task CreateHistoricaldataBulkRemoveJobsAsync(HistoricalImportDeleteFilesJobRequest body, CancellationToken cancellationToken = default);

    Task CreateHistoricaldataDeletejobAsync(CancellationToken cancellationToken = default);

    Task CreateHistoricaldataValidateAsync(ValidationServiceRequest body, CancellationToken cancellationToken = default);

    Task CreateIntegrationsHriTimeofftypesJobsAsync(string hrisIntegrationId, CancellationToken cancellationToken = default);

    Task CreateManagementunitAgentsWorkplansQueryAsync(string managementUnitId, GetAgentsWorkPlansRequest body, bool? forceDownloadService = null, CancellationToken cancellationToken = default);

    Task CreateManagementunitAgentschedulesSearchAsync(string managementUnitId, BuSearchAgentSchedulesRequest body, bool? forceAsync = null, bool? forceDownloadService = null, CancellationToken cancellationToken = default);

    Task CreateManagementunitHistoricaladherencequeryAsync(string managementUnitId, WfmHistoricalAdherenceQuery body, CancellationToken cancellationToken = default);

    Task CreateManagementunitMoveAsync(string managementUnitId, MoveManagementUnitRequest body, CancellationToken cancellationToken = default);

    Task CreateManagementunitSchedulesSearchAsync(string managementUnitId, UserListScheduleRequestBody body, CancellationToken cancellationToken = default);

    Task CreateManagementunitShrinkageJobsAsync(string managementUnitId, WfmHistoricalShrinkageRequest body, CancellationToken cancellationToken = default);

    Task CreateManagementunitTimeofflimitsAsync(string managementUnitId, CreateTimeOffLimitRequest body, CancellationToken cancellationToken = default);

    Task CreateManagementunitTimeofflimitsValuesQueryAsync(string managementUnitId, QueryTimeOffLimitValuesRequest body, CancellationToken cancellationToken = default);

    Task CreateManagementunitTimeoffplansAsync(string managementUnitId, CreateTimeOffPlanRequest body, CancellationToken cancellationToken = default);

    Task CreateManagementunitTimeoffrequestsAsync(string managementUnitId, CreateAdminTimeOffRequest body, CancellationToken cancellationToken = default);

    Task CreateManagementunitTimeoffrequestsIntegrationstatusQueryAsync(string managementUnitId, QueryTimeOffIntegrationStatusRequest body, CancellationToken cancellationToken = default);

    Task CreateManagementunitTimeoffrequestsQueryAsync(string managementUnitId, TimeOffRequestQueryBody body, bool? forceDownloadService = null, CancellationToken cancellationToken = default);

    Task CreateManagementunitTimeoffrequestsWaitlistpositionsQueryAsync(string managementUnitId, QueryWaitlistPositionsRequest body, CancellationToken cancellationToken = default);

    Task CreateManagementunitUserTimeoffbalanceJobsAsync(string managementUnitId, string userId, TimeOffBalanceRequest body, CancellationToken cancellationToken = default);

    Task CreateManagementunitUserTimeoffrequestTimeoffbalanceJobsAsync(string managementUnitId, string userId, string timeOffRequestId, CancellationToken cancellationToken = default);

    Task CreateManagementunitUserTimeoffrequestsEstimateAsync(string managementUnitId, string userId, EstimateAvailableTimeOffRequest body, CancellationToken cancellationToken = default);

    Task CreateManagementunitWeekShifttradeMatchAsync(string managementUnitId, string weekDateId, string tradeId, MatchShiftTradeRequest body, CancellationToken cancellationToken = default);

    Task CreateManagementunitWeekShifttradesAsync(string managementUnitId, string weekDateId, AddShiftTradeRequest body, CancellationToken cancellationToken = default);

    Task CreateManagementunitWeekShifttradesSearchAsync(string managementUnitId, string weekDateId, SearchShiftTradesRequest body, bool? forceDownloadService = null, CancellationToken cancellationToken = default);

    Task CreateManagementunitWeekShifttradesStateBulkAsync(string managementUnitId, string weekDateId, BulkShiftTradeStateUpdateRequest body, bool? forceAsync = null, CancellationToken cancellationToken = default);

    Task CreateManagementunitWorkplanCopyAsync(string managementUnitId, string workPlanId, CopyWorkPlan body, CancellationToken cancellationToken = default);

    Task CreateManagementunitWorkplanValidateAsync(string managementUnitId, string workPlanId, List<string> expand, WorkPlanValidationRequest body, CancellationToken cancellationToken = default);

    Task CreateManagementunitWorkplanrotationCopyAsync(string managementUnitId, string workPlanRotationId, CopyWorkPlanRotationRequest body, CancellationToken cancellationToken = default);

    Task CreateManagementunitWorkplanrotationsAsync(string managementUnitId, AddWorkPlanRotationRequest body, CancellationToken cancellationToken = default);

    Task CreateManagementunitWorkplansAsync(string managementUnitId, string validationMode, CreateWorkPlan body, CancellationToken cancellationToken = default);

    Task CreateManagementunitsAsync(CreateManagementUnitApiRequest body, CancellationToken cancellationToken = default);

    Task CreateNotificationsUpdateAsync(UpdateNotificationsRequest body, CancellationToken cancellationToken = default);

    Task CreateSchedulesAsync(CurrentUserScheduleRequestBody body, CancellationToken cancellationToken = default);

    Task CreateTeamAdherenceHistoricalAsync(string teamId, WfmHistoricalAdherenceQueryForTeams body, CancellationToken cancellationToken = default);

    Task CreateTeamShrinkageJobsAsync(string teamId, WfmHistoricalShrinkageTeamsRequest body, CancellationToken cancellationToken = default);

    Task CreateTimeoffbalanceJobsAsync(TimeOffBalanceRequest body, CancellationToken cancellationToken = default);

    Task CreateTimeofflimitsAvailableQueryAsync(AvailableTimeOffRequest body, CancellationToken cancellationToken = default);

    Task CreateTimeoffrequestsAsync(CreateAgentTimeOffRequest body, CancellationToken cancellationToken = default);

    Task CreateTimeoffrequestsEstimateAsync(EstimateAvailableTimeOffRequest body, CancellationToken cancellationToken = default);

    Task CreateTimeoffrequestsIntegrationstatusQueryAsync(CurrentUserTimeOffIntegrationStatusRequest body, CancellationToken cancellationToken = default);

    Task UpdateAgentIntegrationsHrisAsync(string agentId, AgentIntegrationsRequest body, CancellationToken cancellationToken = default);

    Task UpdateBusinessunitTimeofflimitValuesAsync(string businessUnitId, string timeOffLimitId, BuSetTimeOffLimitValuesRequest body, CancellationToken cancellationToken = default);

    Task UpdateManagementunitTimeofflimitValuesAsync(string managementUnitId, string timeOffLimitId, SetTimeOffLimitValuesRequest body, CancellationToken cancellationToken = default);
}
