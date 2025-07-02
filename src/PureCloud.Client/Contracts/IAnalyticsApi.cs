using PureCloud.Client.Models;
using PureCloud.Client.Models.Analytics;

namespace PureCloud.Client.Contracts;

public interface IAnalyticsApi
{
    Task<bool> DeleteAnalyticsConversationsDetailsJobAsync(string jobId, CancellationToken cancellationToken = default);

    Task<bool> DeleteAnalyticsUsersDetailsJobAsync(string jobId, CancellationToken cancellationToken = default);

    Task<AsyncQueryStatus> GetAnalyticsActionsAggregatesJobAsync(string jobId, CancellationToken cancellationToken = default);

    Task<ActionAsyncAggregateQueryResponse> GetAnalyticsActionsAggregatesJobResultsAsync(string jobId, string cursor = null, CancellationToken cancellationToken = default);

    Task<AnalyticsAgentStateAgentResponse> GetAnalyticsAgentStatusAsync(string userId, CancellationToken cancellationToken = default);

    Task<AsyncQueryStatus> GetAnalyticsAgentcopilotsAggregatesJobAsync(string jobId, CancellationToken cancellationToken = default);

    Task<AgentCopilotAsyncAggregateQueryResponse> GetAnalyticsAgentcopilotsAggregatesJobResultsAsync(string jobId, string cursor = null, CancellationToken cancellationToken = default);

    Task<ReportingTurnsResponse> GetAnalyticsBotflowDivisionsReportingturnsAsync(string botFlowId, string after = null, string pageSize = null, string interval = null, string actionId = null, string sessionId = null, string language = null, string askActionResults = null, CancellationToken cancellationToken = default);

    Task<ReportingTurnsResponse> GetAnalyticsBotflowReportingturnsAsync(string botFlowId, string after = null, string pageSize = null, string interval = null, string actionId = null, string sessionId = null, string language = null, string askActionResults = null, CancellationToken cancellationToken = default);

    Task<SessionsResponse> GetAnalyticsBotflowSessionsAsync(string botFlowId, string after = null, string pageSize = null, string interval = null, string botResultCategories = null, string endLanguage = null, CancellationToken cancellationToken = default);

    Task<AsyncQueryStatus> GetAnalyticsBotsAggregatesJobAsync(string jobId, CancellationToken cancellationToken = default);

    Task<BotAsyncAggregateQueryResponse> GetAnalyticsBotsAggregatesJobResultsAsync(string jobId, string cursor = null, CancellationToken cancellationToken = default);

    Task<AnalyticsConversationWithoutAttributes> GetAnalyticsConversationDetailsAsync(string conversationId, CancellationToken cancellationToken = default);

    Task<AsyncQueryStatus> GetAnalyticsConversationsAggregatesJobAsync(string jobId, CancellationToken cancellationToken = default);

    Task<ConversationAsyncAggregateQueryResponse> GetAnalyticsConversationsAggregatesJobResultsAsync(string jobId, string cursor = null, CancellationToken cancellationToken = default);

    Task<AnalyticsConversationWithoutAttributesMultiGetResponse> GetAnalyticsConversationsDetailsAsync(List<string> id = null, CancellationToken cancellationToken = default);

    Task<AsyncQueryStatus> GetAnalyticsConversationsDetailsJobAsync(string jobId, CancellationToken cancellationToken = default);

    Task<AnalyticsConversationAsyncQueryResponse> GetAnalyticsConversationsDetailsJobResultsAsync(string jobId, string cursor = null, int? pageSize = null, CancellationToken cancellationToken = default);

    Task<DataAvailabilityResponse> GetAnalyticsConversationsDetailsJobsAvailabilityAsync(CancellationToken cancellationToken = default);

    Task<AnalyticsDataRetentionResponse> GetAnalyticsDataretentionSettingsAsync(CancellationToken cancellationToken = default);

    Task<AsyncQueryStatus> GetAnalyticsEvaluationsAggregatesJobAsync(string jobId, CancellationToken cancellationToken = default);

    Task<EvaluationAsyncAggregateQueryResponse> GetAnalyticsEvaluationsAggregatesJobResultsAsync(string jobId, string cursor = null, CancellationToken cancellationToken = default);

    Task<AsyncQueryStatus> GetAnalyticsFlowexecutionsAggregatesJobAsync(string jobId, CancellationToken cancellationToken = default);

    Task<FlowExecutionAsyncAggregateQueryResponse> GetAnalyticsFlowexecutionsAggregatesJobResultsAsync(string jobId, string cursor = null, CancellationToken cancellationToken = default);

    Task<AsyncQueryStatus> GetAnalyticsFlowsAggregatesJobAsync(string jobId, CancellationToken cancellationToken = default);

    Task<FlowAsyncAggregateQueryResponse> GetAnalyticsFlowsAggregatesJobResultsAsync(string jobId, string cursor = null, CancellationToken cancellationToken = default);

    Task<AsyncQueryStatus> GetAnalyticsJourneysAggregatesJobAsync(string jobId, CancellationToken cancellationToken = default);

    Task<JourneyAsyncAggregateQueryResponse> GetAnalyticsJourneysAggregatesJobResultsAsync(string jobId, string cursor = null, CancellationToken cancellationToken = default);

    Task<AsyncQueryStatus> GetAnalyticsKnowledgeAggregatesJobAsync(string jobId, CancellationToken cancellationToken = default);

    Task<KnowledgeAsyncAggregateQueryResponse> GetAnalyticsKnowledgeAggregatesJobResultsAsync(string jobId, string cursor = null, CancellationToken cancellationToken = default);

    Task<DashboardUser> GetAnalyticsReportingDashboardsUserAsync(string userId, CancellationToken cancellationToken = default);

    Task<DashboardUserListing> GetAnalyticsReportingDashboardsUsersAsync(string sortBy = null, int? pageNumber = null, int? pageSize = null, List<string> id = null, string state = null, bool? deletedOnly = null, CancellationToken cancellationToken = default);

    Task<ReportingExportJobListing> GetAnalyticsReportingExportsAsync(int? pageNumber = null, int? pageSize = null, CancellationToken cancellationToken = default);

    Task<ReportingExportMetadataJobListing> GetAnalyticsReportingExportsMetadataAsync(CancellationToken cancellationToken = default);

    Task<DashboardConfigurationListing> GetAnalyticsReportingSettingsDashboardsQueryAsync(string dashboardType, string dashboardAccessFilter, string name = null, string dashboardState = null, string sortBy = null, int? pageNumber = null, int? pageSize = null, CancellationToken cancellationToken = default);

    Task<DashboardConfigurationListing> GetAnalyticsReportingSettingsUserDashboardsAsync(string userId, string sortBy = null, int? pageNumber = null, int? pageSize = null, bool? publicOnly = null, bool? favoriteOnly = null, bool? deletedOnly = null, string name = null, CancellationToken cancellationToken = default);

    Task<AsyncQueryStatus> GetAnalyticsResolutionsAggregatesJobAsync(string jobId, CancellationToken cancellationToken = default);

    Task<ResolutionAsyncAggregateQueryResponse> GetAnalyticsResolutionsAggregatesJobResultsAsync(string jobId, string cursor = null, CancellationToken cancellationToken = default);

    Task<AsyncQueryStatus> GetAnalyticsSummariesAggregatesJobAsync(string jobId, CancellationToken cancellationToken = default);

    Task<SummaryAsyncAggregateQueryResponse> GetAnalyticsSummariesAggregatesJobResultsAsync(string jobId, string cursor = null, CancellationToken cancellationToken = default);

    Task<AsyncQueryStatus> GetAnalyticsSurveysAggregatesJobAsync(string jobId, CancellationToken cancellationToken = default);

    Task<SurveyAsyncAggregateQueryResponse> GetAnalyticsSurveysAggregatesJobResultsAsync(string jobId, string cursor = null, CancellationToken cancellationToken = default);

    Task<AsyncQueryStatus> GetAnalyticsTaskmanagementAggregatesJobAsync(string jobId, CancellationToken cancellationToken = default);

    Task<TaskManagementAsyncAggregateQueryResponse> GetAnalyticsTaskmanagementAggregatesJobResultsAsync(string jobId, string cursor = null, CancellationToken cancellationToken = default);

    Task<AsyncQueryStatus> GetAnalyticsTranscriptsAggregatesJobAsync(string jobId, CancellationToken cancellationToken = default);

    Task<TranscriptAsyncAggregateQueryResponse> GetAnalyticsTranscriptsAggregatesJobResultsAsync(string jobId, string cursor = null, CancellationToken cancellationToken = default);

    Task<AsyncQueryStatus> GetAnalyticsUsersAggregatesJobAsync(string jobId, CancellationToken cancellationToken = default);

    Task<UserAsyncAggregateQueryResponse> GetAnalyticsUsersAggregatesJobResultsAsync(string jobId, string cursor = null, CancellationToken cancellationToken = default);

    Task<AsyncQueryStatus> GetAnalyticsUsersDetailsJobAsync(string jobId, CancellationToken cancellationToken = default);

    Task<AnalyticsUserDetailsAsyncQueryResponse> GetAnalyticsUsersDetailsJobResultsAsync(string jobId, string cursor = null, int? pageSize = null, CancellationToken cancellationToken = default);

    Task<DataAvailabilityResponse> GetAnalyticsUsersDetailsJobsAvailabilityAsync(CancellationToken cancellationToken = default);

    Task<AnalyticsReportingSettings> PatchAnalyticsReportingSettingsAsync(AnalyticsReportingSettings body, CancellationToken cancellationToken = default);

    Task<AsyncQueryResponse> CreateAnalyticsActionsAggregatesJobsAsync(ActionAsyncAggregationQuery body, CancellationToken cancellationToken = default);

    Task<ActionAggregateQueryResponse> CreateAnalyticsActionsAggregatesQueryAsync(ActionAggregationQuery body, CancellationToken cancellationToken = default);

    Task<AsyncQueryResponse> CreateAnalyticsAgentcopilotsAggregatesJobsAsync(AgentCopilotAsyncAggregationQuery body, CancellationToken cancellationToken = default);

    Task<AgentCopilotAggregateQueryResponse> CreateAnalyticsAgentcopilotsAggregatesQueryAsync(AgentCopilotAggregationQuery body, CancellationToken cancellationToken = default);

    Task<AnalyticsAgentStateCountsResponse> CreateAnalyticsAgentsStatusCountsAsync(AgentStateCountsRequest body, CancellationToken cancellationToken = default);

    Task<AnalyticsAgentStateQueryResponse> CreateAnalyticsAgentsStatusQueryAsync(AgentStateQueryRequest body, CancellationToken cancellationToken = default);

    Task<AsyncQueryResponse> CreateAnalyticsBotsAggregatesJobsAsync(BotAsyncAggregationQuery body, CancellationToken cancellationToken = default);

    Task<BotAggregateQueryResponse> CreateAnalyticsBotsAggregatesQueryAsync(BotAggregationQuery body, CancellationToken cancellationToken = default);

    Task<PropertyIndexRequest> CreateAnalyticsConversationDetailsPropertiesAsync(string conversationId, PropertyIndexRequest body, CancellationToken cancellationToken = default);

    Task<ConversationActivityResponse> CreateAnalyticsConversationsActivityQueryAsync(ConversationActivityQuery body, int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default);

    Task<AsyncQueryResponse> CreateAnalyticsConversationsAggregatesJobsAsync(ConversationAsyncAggregationQuery body, CancellationToken cancellationToken = default);

    Task<ConversationAggregateQueryResponse> CreateAnalyticsConversationsAggregatesQueryAsync(ConversationAggregationQuery body, CancellationToken cancellationToken = default);

    Task<AsyncQueryResponse> CreateAnalyticsConversationsDetailsJobsAsync(AsyncConversationQuery body, CancellationToken cancellationToken = default);

    Task<AnalyticsConversationQueryResponse> CreateAnalyticsConversationsDetailsQueryAsync(ConversationQuery body, CancellationToken cancellationToken = default);

    Task<AnalyticsConversationWithoutAttributesMultiGetResponse> CreateAnalyticsConversationsTranscriptsQueryAsync(TranscriptConversationDetailSearchRequest body, CancellationToken cancellationToken = default);

    Task<AsyncQueryResponse> CreateAnalyticsEvaluationsAggregatesJobsAsync(EvaluationAsyncAggregationQuery body, CancellationToken cancellationToken = default);

    Task<EvaluationAggregateQueryResponse> CreateAnalyticsEvaluationsAggregatesQueryAsync(EvaluationAggregationQuery body, CancellationToken cancellationToken = default);

    Task<AsyncQueryResponse> CreateAnalyticsFlowexecutionsAggregatesJobsAsync(FlowExecutionAsyncAggregationQuery body, CancellationToken cancellationToken = default);

    Task<FlowExecutionAggregateQueryResponse> CreateAnalyticsFlowexecutionsAggregatesQueryAsync(FlowExecutionAggregationQuery body, CancellationToken cancellationToken = default);

    Task<FlowActivityResponse> CreateAnalyticsFlowsActivityQueryAsync(FlowActivityQuery body, int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default);

    Task<AsyncQueryResponse> CreateAnalyticsFlowsAggregatesJobsAsync(FlowAsyncAggregationQuery body, CancellationToken cancellationToken = default);

    Task<FlowAggregateQueryResponse> CreateAnalyticsFlowsAggregatesQueryAsync(FlowAggregationQuery body, CancellationToken cancellationToken = default);

    Task<FlowObservationQueryResponse> CreateAnalyticsFlowsObservationsQueryAsync(FlowObservationQuery body, CancellationToken cancellationToken = default);

    Task<AsyncQueryResponse> CreateAnalyticsJourneysAggregatesJobsAsync(JourneyAsyncAggregationQuery body, CancellationToken cancellationToken = default);

    Task<JourneyAggregateQueryResponse> CreateAnalyticsJourneysAggregatesQueryAsync(JourneyAggregationQuery body, CancellationToken cancellationToken = default);

    Task<AsyncQueryResponse> CreateAnalyticsKnowledgeAggregatesJobsAsync(KnowledgeAsyncAggregationQuery body, CancellationToken cancellationToken = default);

    Task<KnowledgeAggregateQueryResponse> CreateAnalyticsKnowledgeAggregatesQueryAsync(KnowledgeAggregationQuery body, CancellationToken cancellationToken = default);

    Task<QueueObservationQueryResponse> CreateAnalyticsQueuesObservationsQueryAsync(QueueObservationQuery body, CancellationToken cancellationToken = default);

    Task<RateLimitAggregateQueryResponse> CreateAnalyticsRatelimitsAggregatesQueryAsync(RateLimitAggregationQuery body, CancellationToken cancellationToken = default);

    Task<object> CreateAnalyticsReportingDashboardsUsersBulkRemoveAsync(IList<string> body, CancellationToken cancellationToken = default);

    Task<ReportingExportJobResponse> CreateAnalyticsReportingExportsAsync(ReportingExportJobRequest body, CancellationToken cancellationToken = default);

    Task<object> CreateAnalyticsReportingSettingsDashboardsBulkRemoveAsync(DashboardConfigurationBulkRequest body, CancellationToken cancellationToken = default);

    Task<DashboardConfigurationListing> CreateAnalyticsReportingSettingsDashboardsQueryAsync(DashboardConfigurationQueryRequest body, CancellationToken cancellationToken = default);

    Task<AsyncQueryResponse> CreateAnalyticsResolutionsAggregatesJobsAsync(ResolutionAsyncAggregationQuery body, CancellationToken cancellationToken = default);

    Task<ResolutionAggregateQueryResponse> CreateAnalyticsResolutionsAggregatesQueryAsync(ResolutionAggregationQuery body, CancellationToken cancellationToken = default);

    Task<RoutingActivityResponse> CreateAnalyticsRoutingActivityQueryAsync(RoutingActivityQuery body, int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default);

    Task<AsyncQueryResponse> CreateAnalyticsSummariesAggregatesJobsAsync(SummaryAsyncAggregationQuery body, CancellationToken cancellationToken = default);

    Task<SummaryAggregateQueryResponse> CreateAnalyticsSummariesAggregatesQueryAsync(SummaryAggregationQuery body, CancellationToken cancellationToken = default);

    Task<AsyncQueryResponse> CreateAnalyticsSurveysAggregatesJobsAsync(SurveyAsyncAggregationQuery body, CancellationToken cancellationToken = default);

    Task<SurveyAggregateQueryResponse> CreateAnalyticsSurveysAggregatesQueryAsync(SurveyAggregationQuery body, CancellationToken cancellationToken = default);

    Task<AsyncQueryResponse> CreateAnalyticsTaskmanagementAggregatesJobsAsync(TaskManagementAsyncAggregationQuery body, CancellationToken cancellationToken = default);

    Task<TaskManagementAggregateQueryResponse> CreateAnalyticsTaskmanagementAggregatesQueryAsync(TaskManagementAggregationQuery body, CancellationToken cancellationToken = default);

    Task<TeamActivityResponse> CreateAnalyticsTeamsActivityQueryAsync(TeamActivityQuery body, int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default);

    Task<AsyncQueryResponse> CreateAnalyticsTranscriptsAggregatesJobsAsync(TranscriptAsyncAggregationQuery body, CancellationToken cancellationToken = default);

    Task<TranscriptAggregateQueryResponse> CreateAnalyticsTranscriptsAggregatesQueryAsync(TranscriptAggregationQuery body, CancellationToken cancellationToken = default);

    Task<UserActivityResponse> CreateAnalyticsUsersActivityQueryAsync(UserActivityQuery body, int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default);

    Task<AsyncQueryResponse> CreateAnalyticsUsersAggregatesJobsAsync(UserAsyncAggregationQuery body, CancellationToken cancellationToken = default);

    Task<UserAggregateQueryResponse> CreateAnalyticsUsersAggregatesQueryAsync(UserAggregationQuery body, CancellationToken cancellationToken = default);

    Task<AsyncQueryResponse> CreateAnalyticsUsersDetailsJobsAsync(AsyncUserDetailsQuery body, CancellationToken cancellationToken = default);

    Task<AnalyticsUserDetailsQueryResponse> CreateAnalyticsUsersDetailsQueryAsync(UserDetailsQuery body, CancellationToken cancellationToken = default);

    Task<UserObservationQueryResponse> CreateAnalyticsUsersObservationsQueryAsync(UserObservationQuery body, CancellationToken cancellationToken = default);

    Task<AnalyticsDataRetentionResponse> UpdateAnalyticsDataRetentionSettingsAsync(UpdateAnalyticsDataRetentionRequest body, CancellationToken cancellationToken = default);
}
