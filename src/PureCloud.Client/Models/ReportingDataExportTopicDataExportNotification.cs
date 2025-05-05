using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ReportingDataExportTopicDataExportNotification
/// </summary>

public partial class ReportingDataExportTopicDataExportNotification : IEquatable<ReportingDataExportTopicDataExportNotification>
{
    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    
    public enum StatusEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Submitted for "SUBMITTED"
        /// </summary>
        [EnumMember(Value = "SUBMITTED")]
        Submitted,

        /// <summary>
        /// Enum Running for "RUNNING"
        /// </summary>
        [EnumMember(Value = "RUNNING")]
        Running,

        /// <summary>
        /// Enum Cancelling for "CANCELLING"
        /// </summary>
        [EnumMember(Value = "CANCELLING")]
        Cancelling,

        /// <summary>
        /// Enum Cancelled for "CANCELLED"
        /// </summary>
        [EnumMember(Value = "CANCELLED")]
        Cancelled,

        /// <summary>
        /// Enum Completed for "COMPLETED"
        /// </summary>
        [EnumMember(Value = "COMPLETED")]
        Completed,

        /// <summary>
        /// Enum CompletedWithPartialResults for "COMPLETED_WITH_PARTIAL_RESULTS"
        /// </summary>
        [EnumMember(Value = "COMPLETED_WITH_PARTIAL_RESULTS")]
        CompletedWithPartialResults,

        /// <summary>
        /// Enum Failed for "FAILED"
        /// </summary>
        [EnumMember(Value = "FAILED")]
        Failed
    }
    /// <summary>
    /// Gets or Sets ExportFormat
    /// </summary>
    
    public enum ExportFormatEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Csv for "CSV"
        /// </summary>
        [EnumMember(Value = "CSV")]
        Csv,

        /// <summary>
        /// Enum Pdf for "PDF"
        /// </summary>
        [EnumMember(Value = "PDF")]
        Pdf
    }
    /// <summary>
    /// Gets or Sets ViewType
    /// </summary>
    
    public enum ViewTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum QueuePerformanceSummaryView for "QUEUE_PERFORMANCE_SUMMARY_VIEW"
        /// </summary>
        [EnumMember(Value = "QUEUE_PERFORMANCE_SUMMARY_VIEW")]
        QueuePerformanceSummaryView,

        /// <summary>
        /// Enum QueuePerformanceDetailView for "QUEUE_PERFORMANCE_DETAIL_VIEW"
        /// </summary>
        [EnumMember(Value = "QUEUE_PERFORMANCE_DETAIL_VIEW")]
        QueuePerformanceDetailView,

        /// <summary>
        /// Enum InteractionSearchView for "INTERACTION_SEARCH_VIEW"
        /// </summary>
        [EnumMember(Value = "INTERACTION_SEARCH_VIEW")]
        InteractionSearchView,

        /// <summary>
        /// Enum AgentPerformanceSummaryView for "AGENT_PERFORMANCE_SUMMARY_VIEW"
        /// </summary>
        [EnumMember(Value = "AGENT_PERFORMANCE_SUMMARY_VIEW")]
        AgentPerformanceSummaryView,

        /// <summary>
        /// Enum AgentPerformanceDetailView for "AGENT_PERFORMANCE_DETAIL_VIEW"
        /// </summary>
        [EnumMember(Value = "AGENT_PERFORMANCE_DETAIL_VIEW")]
        AgentPerformanceDetailView,

        /// <summary>
        /// Enum AgentStatusSummaryView for "AGENT_STATUS_SUMMARY_VIEW"
        /// </summary>
        [EnumMember(Value = "AGENT_STATUS_SUMMARY_VIEW")]
        AgentStatusSummaryView,

        /// <summary>
        /// Enum AgentStatusDetailView for "AGENT_STATUS_DETAIL_VIEW"
        /// </summary>
        [EnumMember(Value = "AGENT_STATUS_DETAIL_VIEW")]
        AgentStatusDetailView,

        /// <summary>
        /// Enum AgentEvaluationSummaryView for "AGENT_EVALUATION_SUMMARY_VIEW"
        /// </summary>
        [EnumMember(Value = "AGENT_EVALUATION_SUMMARY_VIEW")]
        AgentEvaluationSummaryView,

        /// <summary>
        /// Enum AgentEvaluationDetailView for "AGENT_EVALUATION_DETAIL_VIEW"
        /// </summary>
        [EnumMember(Value = "AGENT_EVALUATION_DETAIL_VIEW")]
        AgentEvaluationDetailView,

        /// <summary>
        /// Enum AgentQueueDetailView for "AGENT_QUEUE_DETAIL_VIEW"
        /// </summary>
        [EnumMember(Value = "AGENT_QUEUE_DETAIL_VIEW")]
        AgentQueueDetailView,

        /// <summary>
        /// Enum AgentInteractionDetailView for "AGENT_INTERACTION_DETAIL_VIEW"
        /// </summary>
        [EnumMember(Value = "AGENT_INTERACTION_DETAIL_VIEW")]
        AgentInteractionDetailView,

        /// <summary>
        /// Enum AbandonInsightsView for "ABANDON_INSIGHTS_VIEW"
        /// </summary>
        [EnumMember(Value = "ABANDON_INSIGHTS_VIEW")]
        AbandonInsightsView,

        /// <summary>
        /// Enum SkillsPerformanceView for "SKILLS_PERFORMANCE_VIEW"
        /// </summary>
        [EnumMember(Value = "SKILLS_PERFORMANCE_VIEW")]
        SkillsPerformanceView,

        /// <summary>
        /// Enum SurveyFormPerformanceSummaryView for "SURVEY_FORM_PERFORMANCE_SUMMARY_VIEW"
        /// </summary>
        [EnumMember(Value = "SURVEY_FORM_PERFORMANCE_SUMMARY_VIEW")]
        SurveyFormPerformanceSummaryView,

        /// <summary>
        /// Enum SurveyFormPerformanceDetailView for "SURVEY_FORM_PERFORMANCE_DETAIL_VIEW"
        /// </summary>
        [EnumMember(Value = "SURVEY_FORM_PERFORMANCE_DETAIL_VIEW")]
        SurveyFormPerformanceDetailView,

        /// <summary>
        /// Enum DnisPerformanceSummaryView for "DNIS_PERFORMANCE_SUMMARY_VIEW"
        /// </summary>
        [EnumMember(Value = "DNIS_PERFORMANCE_SUMMARY_VIEW")]
        DnisPerformanceSummaryView,

        /// <summary>
        /// Enum DnisPerformanceDetailView for "DNIS_PERFORMANCE_DETAIL_VIEW"
        /// </summary>
        [EnumMember(Value = "DNIS_PERFORMANCE_DETAIL_VIEW")]
        DnisPerformanceDetailView,

        /// <summary>
        /// Enum WrapUpPerformanceSummaryView for "WRAP_UP_PERFORMANCE_SUMMARY_VIEW"
        /// </summary>
        [EnumMember(Value = "WRAP_UP_PERFORMANCE_SUMMARY_VIEW")]
        WrapUpPerformanceSummaryView,

        /// <summary>
        /// Enum AgentWrapUpPerformanceDetailView for "AGENT_WRAP_UP_PERFORMANCE_DETAIL_VIEW"
        /// </summary>
        [EnumMember(Value = "AGENT_WRAP_UP_PERFORMANCE_DETAIL_VIEW")]
        AgentWrapUpPerformanceDetailView,

        /// <summary>
        /// Enum QueueActivitySummaryView for "QUEUE_ACTIVITY_SUMMARY_VIEW"
        /// </summary>
        [EnumMember(Value = "QUEUE_ACTIVITY_SUMMARY_VIEW")]
        QueueActivitySummaryView,

        /// <summary>
        /// Enum QueueActivityDetailView for "QUEUE_ACTIVITY_DETAIL_VIEW"
        /// </summary>
        [EnumMember(Value = "QUEUE_ACTIVITY_DETAIL_VIEW")]
        QueueActivityDetailView,

        /// <summary>
        /// Enum AgentQueueActivitySummaryView for "AGENT_QUEUE_ACTIVITY_SUMMARY_VIEW"
        /// </summary>
        [EnumMember(Value = "AGENT_QUEUE_ACTIVITY_SUMMARY_VIEW")]
        AgentQueueActivitySummaryView,

        /// <summary>
        /// Enum QueueAgentDetailView for "QUEUE_AGENT_DETAIL_VIEW"
        /// </summary>
        [EnumMember(Value = "QUEUE_AGENT_DETAIL_VIEW")]
        QueueAgentDetailView,

        /// <summary>
        /// Enum QueueInteractionDetailView for "QUEUE_INTERACTION_DETAIL_VIEW"
        /// </summary>
        [EnumMember(Value = "QUEUE_INTERACTION_DETAIL_VIEW")]
        QueueInteractionDetailView,

        /// <summary>
        /// Enum AgentScheduleDetailView for "AGENT_SCHEDULE_DETAIL_VIEW"
        /// </summary>
        [EnumMember(Value = "AGENT_SCHEDULE_DETAIL_VIEW")]
        AgentScheduleDetailView,

        /// <summary>
        /// Enum IvrPerformanceSummaryView for "IVR_PERFORMANCE_SUMMARY_VIEW"
        /// </summary>
        [EnumMember(Value = "IVR_PERFORMANCE_SUMMARY_VIEW")]
        IvrPerformanceSummaryView,

        /// <summary>
        /// Enum IvrPerformanceDetailView for "IVR_PERFORMANCE_DETAIL_VIEW"
        /// </summary>
        [EnumMember(Value = "IVR_PERFORMANCE_DETAIL_VIEW")]
        IvrPerformanceDetailView,

        /// <summary>
        /// Enum AnswerInsightsView for "ANSWER_INSIGHTS_VIEW"
        /// </summary>
        [EnumMember(Value = "ANSWER_INSIGHTS_VIEW")]
        AnswerInsightsView,

        /// <summary>
        /// Enum HandleInsightsView for "HANDLE_INSIGHTS_VIEW"
        /// </summary>
        [EnumMember(Value = "HANDLE_INSIGHTS_VIEW")]
        HandleInsightsView,

        /// <summary>
        /// Enum TalkInsightsView for "TALK_INSIGHTS_VIEW"
        /// </summary>
        [EnumMember(Value = "TALK_INSIGHTS_VIEW")]
        TalkInsightsView,

        /// <summary>
        /// Enum HoldInsightsView for "HOLD_INSIGHTS_VIEW"
        /// </summary>
        [EnumMember(Value = "HOLD_INSIGHTS_VIEW")]
        HoldInsightsView,

        /// <summary>
        /// Enum AcwInsightsView for "ACW_INSIGHTS_VIEW"
        /// </summary>
        [EnumMember(Value = "ACW_INSIGHTS_VIEW")]
        AcwInsightsView,

        /// <summary>
        /// Enum WaitInsightsView for "WAIT_INSIGHTS_VIEW"
        /// </summary>
        [EnumMember(Value = "WAIT_INSIGHTS_VIEW")]
        WaitInsightsView,

        /// <summary>
        /// Enum AgentWrapUpPerformanceIntervalDetailView for "AGENT_WRAP_UP_PERFORMANCE_INTERVAL_DETAIL_VIEW"
        /// </summary>
        [EnumMember(Value = "AGENT_WRAP_UP_PERFORMANCE_INTERVAL_DETAIL_VIEW")]
        AgentWrapUpPerformanceIntervalDetailView,

        /// <summary>
        /// Enum FlowOutcomeSummaryView for "FLOW_OUTCOME_SUMMARY_VIEW"
        /// </summary>
        [EnumMember(Value = "FLOW_OUTCOME_SUMMARY_VIEW")]
        FlowOutcomeSummaryView,

        /// <summary>
        /// Enum FlowOutcomePerformanceDetailView for "FLOW_OUTCOME_PERFORMANCE_DETAIL_VIEW"
        /// </summary>
        [EnumMember(Value = "FLOW_OUTCOME_PERFORMANCE_DETAIL_VIEW")]
        FlowOutcomePerformanceDetailView,

        /// <summary>
        /// Enum FlowOutcomePerformanceIntervalDetailView for "FLOW_OUTCOME_PERFORMANCE_INTERVAL_DETAIL_VIEW"
        /// </summary>
        [EnumMember(Value = "FLOW_OUTCOME_PERFORMANCE_INTERVAL_DETAIL_VIEW")]
        FlowOutcomePerformanceIntervalDetailView,

        /// <summary>
        /// Enum FlowDestinationSummaryView for "FLOW_DESTINATION_SUMMARY_VIEW"
        /// </summary>
        [EnumMember(Value = "FLOW_DESTINATION_SUMMARY_VIEW")]
        FlowDestinationSummaryView,

        /// <summary>
        /// Enum FlowDestinationDetailView for "FLOW_DESTINATION_DETAIL_VIEW"
        /// </summary>
        [EnumMember(Value = "FLOW_DESTINATION_DETAIL_VIEW")]
        FlowDestinationDetailView,

        /// <summary>
        /// Enum ScheduledCallbacksView for "SCHEDULED_CALLBACKS_VIEW"
        /// </summary>
        [EnumMember(Value = "SCHEDULED_CALLBACKS_VIEW")]
        ScheduledCallbacksView,

        /// <summary>
        /// Enum ContentSearchView for "CONTENT_SEARCH_VIEW"
        /// </summary>
        [EnumMember(Value = "CONTENT_SEARCH_VIEW")]
        ContentSearchView,

        /// <summary>
        /// Enum JourneyActionMapSummaryView for "JOURNEY_ACTION_MAP_SUMMARY_VIEW"
        /// </summary>
        [EnumMember(Value = "JOURNEY_ACTION_MAP_SUMMARY_VIEW")]
        JourneyActionMapSummaryView,

        /// <summary>
        /// Enum JourneyOutcomeSummaryView for "JOURNEY_OUTCOME_SUMMARY_VIEW"
        /// </summary>
        [EnumMember(Value = "JOURNEY_OUTCOME_SUMMARY_VIEW")]
        JourneyOutcomeSummaryView,

        /// <summary>
        /// Enum JourneySegmentSummaryView for "JOURNEY_SEGMENT_SUMMARY_VIEW"
        /// </summary>
        [EnumMember(Value = "JOURNEY_SEGMENT_SUMMARY_VIEW")]
        JourneySegmentSummaryView,

        /// <summary>
        /// Enum AgentDevelopmentDetailView for "AGENT_DEVELOPMENT_DETAIL_VIEW"
        /// </summary>
        [EnumMember(Value = "AGENT_DEVELOPMENT_DETAIL_VIEW")]
        AgentDevelopmentDetailView,

        /// <summary>
        /// Enum AgentDevelopmentDetailMeView for "AGENT_DEVELOPMENT_DETAIL_ME_VIEW"
        /// </summary>
        [EnumMember(Value = "AGENT_DEVELOPMENT_DETAIL_ME_VIEW")]
        AgentDevelopmentDetailMeView,

        /// <summary>
        /// Enum AgentDevelopmentSummaryView for "AGENT_DEVELOPMENT_SUMMARY_VIEW"
        /// </summary>
        [EnumMember(Value = "AGENT_DEVELOPMENT_SUMMARY_VIEW")]
        AgentDevelopmentSummaryView,

        /// <summary>
        /// Enum AgentScorecardView for "AGENT_SCORECARD_VIEW"
        /// </summary>
        [EnumMember(Value = "AGENT_SCORECARD_VIEW")]
        AgentScorecardView,

        /// <summary>
        /// Enum AgentScorecardMeView for "AGENT_SCORECARD_ME_VIEW"
        /// </summary>
        [EnumMember(Value = "AGENT_SCORECARD_ME_VIEW")]
        AgentScorecardMeView,

        /// <summary>
        /// Enum AgentGamificationLeadershipView for "AGENT_GAMIFICATION_LEADERSHIP_VIEW"
        /// </summary>
        [EnumMember(Value = "AGENT_GAMIFICATION_LEADERSHIP_VIEW")]
        AgentGamificationLeadershipView,

        /// <summary>
        /// Enum AgentScheduleMeView for "AGENT_SCHEDULE_ME_VIEW"
        /// </summary>
        [EnumMember(Value = "AGENT_SCHEDULE_ME_VIEW")]
        AgentScheduleMeView,

        /// <summary>
        /// Enum BotPerformanceSummaryView for "BOT_PERFORMANCE_SUMMARY_VIEW"
        /// </summary>
        [EnumMember(Value = "BOT_PERFORMANCE_SUMMARY_VIEW")]
        BotPerformanceSummaryView,

        /// <summary>
        /// Enum BotPerformanceDetailView for "BOT_PERFORMANCE_DETAIL_VIEW"
        /// </summary>
        [EnumMember(Value = "BOT_PERFORMANCE_DETAIL_VIEW")]
        BotPerformanceDetailView,

        /// <summary>
        /// Enum TopicTrendSummaryView for "TOPIC_TREND_SUMMARY_VIEW"
        /// </summary>
        [EnumMember(Value = "TOPIC_TREND_SUMMARY_VIEW")]
        TopicTrendSummaryView,

        /// <summary>
        /// Enum TopicTrendDetailView for "TOPIC_TREND_DETAIL_VIEW"
        /// </summary>
        [EnumMember(Value = "TOPIC_TREND_DETAIL_VIEW")]
        TopicTrendDetailView,

        /// <summary>
        /// Enum ActionMapBlockedConstraintsDetailView for "ACTION_MAP_BLOCKED_CONSTRAINTS_DETAIL_VIEW"
        /// </summary>
        [EnumMember(Value = "ACTION_MAP_BLOCKED_CONSTRAINTS_DETAIL_VIEW")]
        ActionMapBlockedConstraintsDetailView,

        /// <summary>
        /// Enum ActionMapBlockedConstraintsIntervalDetailView for "ACTION_MAP_BLOCKED_CONSTRAINTS_INTERVAL_DETAIL_VIEW"
        /// </summary>
        [EnumMember(Value = "ACTION_MAP_BLOCKED_CONSTRAINTS_INTERVAL_DETAIL_VIEW")]
        ActionMapBlockedConstraintsIntervalDetailView,

        /// <summary>
        /// Enum FlowMilestonePerformanceDetailView for "FLOW_MILESTONE_PERFORMANCE_DETAIL_VIEW"
        /// </summary>
        [EnumMember(Value = "FLOW_MILESTONE_PERFORMANCE_DETAIL_VIEW")]
        FlowMilestonePerformanceDetailView,

        /// <summary>
        /// Enum FlowMilestonePerformanceIntervalDetailView for "FLOW_MILESTONE_PERFORMANCE_INTERVAL_DETAIL_VIEW"
        /// </summary>
        [EnumMember(Value = "FLOW_MILESTONE_PERFORMANCE_INTERVAL_DETAIL_VIEW")]
        FlowMilestonePerformanceIntervalDetailView,

        /// <summary>
        /// Enum AgentTopicSummaryView for "AGENT_TOPIC_SUMMARY_VIEW"
        /// </summary>
        [EnumMember(Value = "AGENT_TOPIC_SUMMARY_VIEW")]
        AgentTopicSummaryView,

        /// <summary>
        /// Enum AgentTopicDetailView for "AGENT_TOPIC_DETAIL_VIEW"
        /// </summary>
        [EnumMember(Value = "AGENT_TOPIC_DETAIL_VIEW")]
        AgentTopicDetailView,

        /// <summary>
        /// Enum QueueTopicSummaryView for "QUEUE_TOPIC_SUMMARY_VIEW"
        /// </summary>
        [EnumMember(Value = "QUEUE_TOPIC_SUMMARY_VIEW")]
        QueueTopicSummaryView,

        /// <summary>
        /// Enum QueueTopicDetailView for "QUEUE_TOPIC_DETAIL_VIEW"
        /// </summary>
        [EnumMember(Value = "QUEUE_TOPIC_DETAIL_VIEW")]
        QueueTopicDetailView,

        /// <summary>
        /// Enum FlowTopicSummaryView for "FLOW_TOPIC_SUMMARY_VIEW"
        /// </summary>
        [EnumMember(Value = "FLOW_TOPIC_SUMMARY_VIEW")]
        FlowTopicSummaryView,

        /// <summary>
        /// Enum FlowTopicDetailView for "FLOW_TOPIC_DETAIL_VIEW"
        /// </summary>
        [EnumMember(Value = "FLOW_TOPIC_DETAIL_VIEW")]
        FlowTopicDetailView,

        /// <summary>
        /// Enum AgentInteractionsMeView for "AGENT_INTERACTIONS_ME_VIEW"
        /// </summary>
        [EnumMember(Value = "AGENT_INTERACTIONS_ME_VIEW")]
        AgentInteractionsMeView,

        /// <summary>
        /// Enum DataActionsPerformanceSummaryView for "DATA_ACTIONS_PERFORMANCE_SUMMARY_VIEW"
        /// </summary>
        [EnumMember(Value = "DATA_ACTIONS_PERFORMANCE_SUMMARY_VIEW")]
        DataActionsPerformanceSummaryView,

        /// <summary>
        /// Enum DataActionsPerformanceDetailView for "DATA_ACTIONS_PERFORMANCE_DETAIL_VIEW"
        /// </summary>
        [EnumMember(Value = "DATA_ACTIONS_PERFORMANCE_DETAIL_VIEW")]
        DataActionsPerformanceDetailView,

        /// <summary>
        /// Enum AgentTimelineSummaryView for "AGENT_TIMELINE_SUMMARY_VIEW"
        /// </summary>
        [EnumMember(Value = "AGENT_TIMELINE_SUMMARY_VIEW")]
        AgentTimelineSummaryView,

        /// <summary>
        /// Enum AgentTimelineDetailView for "AGENT_TIMELINE_DETAIL_VIEW"
        /// </summary>
        [EnumMember(Value = "AGENT_TIMELINE_DETAIL_VIEW")]
        AgentTimelineDetailView,

        /// <summary>
        /// Enum AgentLoginLogoutSummaryView for "AGENT_LOGIN_LOGOUT_SUMMARY_VIEW"
        /// </summary>
        [EnumMember(Value = "AGENT_LOGIN_LOGOUT_SUMMARY_VIEW")]
        AgentLoginLogoutSummaryView,

        /// <summary>
        /// Enum AgentLoginLogoutDetailView for "AGENT_LOGIN_LOGOUT_DETAIL_VIEW"
        /// </summary>
        [EnumMember(Value = "AGENT_LOGIN_LOGOUT_DETAIL_VIEW")]
        AgentLoginLogoutDetailView,

        /// <summary>
        /// Enum CampaignPerformanceSummaryView for "CAMPAIGN_PERFORMANCE_SUMMARY_VIEW"
        /// </summary>
        [EnumMember(Value = "CAMPAIGN_PERFORMANCE_SUMMARY_VIEW")]
        CampaignPerformanceSummaryView,

        /// <summary>
        /// Enum CampaignPerformanceDetailView for "CAMPAIGN_PERFORMANCE_DETAIL_VIEW"
        /// </summary>
        [EnumMember(Value = "CAMPAIGN_PERFORMANCE_DETAIL_VIEW")]
        CampaignPerformanceDetailView,

        /// <summary>
        /// Enum QueueWrapupDetailView for "QUEUE_WRAPUP_DETAIL_VIEW"
        /// </summary>
        [EnumMember(Value = "QUEUE_WRAPUP_DETAIL_VIEW")]
        QueueWrapupDetailView,

        /// <summary>
        /// Enum CampaignInteractionDetailView for "CAMPAIGN_INTERACTION_DETAIL_VIEW"
        /// </summary>
        [EnumMember(Value = "CAMPAIGN_INTERACTION_DETAIL_VIEW")]
        CampaignInteractionDetailView,

        /// <summary>
        /// Enum CampaignAttemptDetailView for "CAMPAIGN_ATTEMPT_DETAIL_VIEW"
        /// </summary>
        [EnumMember(Value = "CAMPAIGN_ATTEMPT_DETAIL_VIEW")]
        CampaignAttemptDetailView,

        /// <summary>
        /// Enum WorkitemPerformanceSummaryView for "WORKITEM_PERFORMANCE_SUMMARY_VIEW"
        /// </summary>
        [EnumMember(Value = "WORKITEM_PERFORMANCE_SUMMARY_VIEW")]
        WorkitemPerformanceSummaryView,

        /// <summary>
        /// Enum QueueRoutingPerformanceView for "QUEUE_ROUTING_PERFORMANCE_VIEW"
        /// </summary>
        [EnumMember(Value = "QUEUE_ROUTING_PERFORMANCE_VIEW")]
        QueueRoutingPerformanceView,

        /// <summary>
        /// Enum AgentWorkitemPerformanceSummaryView for "AGENT_WORKITEM_PERFORMANCE_SUMMARY_VIEW"
        /// </summary>
        [EnumMember(Value = "AGENT_WORKITEM_PERFORMANCE_SUMMARY_VIEW")]
        AgentWorkitemPerformanceSummaryView,

        /// <summary>
        /// Enum AgentWorkitemPerformanceDetailView for "AGENT_WORKITEM_PERFORMANCE_DETAIL_VIEW"
        /// </summary>
        [EnumMember(Value = "AGENT_WORKITEM_PERFORMANCE_DETAIL_VIEW")]
        AgentWorkitemPerformanceDetailView,

        /// <summary>
        /// Enum QueueWorkitemPerformanceSummaryView for "QUEUE_WORKITEM_PERFORMANCE_SUMMARY_VIEW"
        /// </summary>
        [EnumMember(Value = "QUEUE_WORKITEM_PERFORMANCE_SUMMARY_VIEW")]
        QueueWorkitemPerformanceSummaryView,

        /// <summary>
        /// Enum QueueWorkitemPerformanceDetailView for "QUEUE_WORKITEM_PERFORMANCE_DETAIL_VIEW"
        /// </summary>
        [EnumMember(Value = "QUEUE_WORKITEM_PERFORMANCE_DETAIL_VIEW")]
        QueueWorkitemPerformanceDetailView,

        /// <summary>
        /// Enum EmailAgentPerformanceSummaryView for "EMAIL_AGENT_PERFORMANCE_SUMMARY_VIEW"
        /// </summary>
        [EnumMember(Value = "EMAIL_AGENT_PERFORMANCE_SUMMARY_VIEW")]
        EmailAgentPerformanceSummaryView,

        /// <summary>
        /// Enum EmailAgentPerformanceDetailView for "EMAIL_AGENT_PERFORMANCE_DETAIL_VIEW"
        /// </summary>
        [EnumMember(Value = "EMAIL_AGENT_PERFORMANCE_DETAIL_VIEW")]
        EmailAgentPerformanceDetailView,

        /// <summary>
        /// Enum MessagingAgentPerformanceSummaryView for "MESSAGING_AGENT_PERFORMANCE_SUMMARY_VIEW"
        /// </summary>
        [EnumMember(Value = "MESSAGING_AGENT_PERFORMANCE_SUMMARY_VIEW")]
        MessagingAgentPerformanceSummaryView,

        /// <summary>
        /// Enum MessagingAgentPerformanceDetailView for "MESSAGING_AGENT_PERFORMANCE_DETAIL_VIEW"
        /// </summary>
        [EnumMember(Value = "MESSAGING_AGENT_PERFORMANCE_DETAIL_VIEW")]
        MessagingAgentPerformanceDetailView,

        /// <summary>
        /// Enum EmailQueuePerformanceSummaryView for "EMAIL_QUEUE_PERFORMANCE_SUMMARY_VIEW"
        /// </summary>
        [EnumMember(Value = "EMAIL_QUEUE_PERFORMANCE_SUMMARY_VIEW")]
        EmailQueuePerformanceSummaryView,

        /// <summary>
        /// Enum EmailQueuePerformanceDetailView for "EMAIL_QUEUE_PERFORMANCE_DETAIL_VIEW"
        /// </summary>
        [EnumMember(Value = "EMAIL_QUEUE_PERFORMANCE_DETAIL_VIEW")]
        EmailQueuePerformanceDetailView,

        /// <summary>
        /// Enum MessagingQueuePerformanceSummaryView for "MESSAGING_QUEUE_PERFORMANCE_SUMMARY_VIEW"
        /// </summary>
        [EnumMember(Value = "MESSAGING_QUEUE_PERFORMANCE_SUMMARY_VIEW")]
        MessagingQueuePerformanceSummaryView,

        /// <summary>
        /// Enum MessagingQueuePerformanceDetailView for "MESSAGING_QUEUE_PERFORMANCE_DETAIL_VIEW"
        /// </summary>
        [EnumMember(Value = "MESSAGING_QUEUE_PERFORMANCE_DETAIL_VIEW")]
        MessagingQueuePerformanceDetailView,

        /// <summary>
        /// Enum AgentPerformanceTimelineDetailView for "AGENT_PERFORMANCE_TIMELINE_DETAIL_VIEW"
        /// </summary>
        [EnumMember(Value = "AGENT_PERFORMANCE_TIMELINE_DETAIL_VIEW")]
        AgentPerformanceTimelineDetailView
    }
    /// <summary>
    /// Gets or Sets ExportErrorMessagesType
    /// </summary>
    
    public enum ExportErrorMessagesTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum FailedConvertingExportJob for "FAILED_CONVERTING_EXPORT_JOB"
        /// </summary>
        [EnumMember(Value = "FAILED_CONVERTING_EXPORT_JOB")]
        FailedConvertingExportJob,

        /// <summary>
        /// Enum FailedNoDataExportJobFound for "FAILED_NO_DATA_EXPORT_JOB_FOUND"
        /// </summary>
        [EnumMember(Value = "FAILED_NO_DATA_EXPORT_JOB_FOUND")]
        FailedNoDataExportJobFound,

        /// <summary>
        /// Enum FailedGettingDataFromService for "FAILED_GETTING_DATA_FROM_SERVICE"
        /// </summary>
        [EnumMember(Value = "FAILED_GETTING_DATA_FROM_SERVICE")]
        FailedGettingDataFromService,

        /// <summary>
        /// Enum FailedGeneratingTempFile for "FAILED_GENERATING_TEMP_FILE"
        /// </summary>
        [EnumMember(Value = "FAILED_GENERATING_TEMP_FILE")]
        FailedGeneratingTempFile,

        /// <summary>
        /// Enum FailedSavingFileToS3 for "FAILED_SAVING_FILE_TO_S3"
        /// </summary>
        [EnumMember(Value = "FAILED_SAVING_FILE_TO_S3")]
        FailedSavingFileToS3,

        /// <summary>
        /// Enum FailedNotifyingSkywalkerOfDownload for "FAILED_NOTIFYING_SKYWALKER_OF_DOWNLOAD"
        /// </summary>
        [EnumMember(Value = "FAILED_NOTIFYING_SKYWALKER_OF_DOWNLOAD")]
        FailedNotifyingSkywalkerOfDownload,

        /// <summary>
        /// Enum FailedBuildingDownloadUrlFromSkywalkerResponse for "FAILED_BUILDING_DOWNLOAD_URL_FROM_SKYWALKER_RESPONSE"
        /// </summary>
        [EnumMember(Value = "FAILED_BUILDING_DOWNLOAD_URL_FROM_SKYWALKER_RESPONSE")]
        FailedBuildingDownloadUrlFromSkywalkerResponse,

        /// <summary>
        /// Enum ExportTypeNotImplemented for "EXPORT_TYPE_NOT_IMPLEMENTED"
        /// </summary>
        [EnumMember(Value = "EXPORT_TYPE_NOT_IMPLEMENTED")]
        ExportTypeNotImplemented,

        /// <summary>
        /// Enum ReachedMaximumAttemptOfRetry for "REACHED_MAXIMUM_ATTEMPT_OF_RETRY"
        /// </summary>
        [EnumMember(Value = "REACHED_MAXIMUM_ATTEMPT_OF_RETRY")]
        ReachedMaximumAttemptOfRetry,

        /// <summary>
        /// Enum FailedLongRunningExport for "FAILED_LONG_RUNNING_EXPORT"
        /// </summary>
        [EnumMember(Value = "FAILED_LONG_RUNNING_EXPORT")]
        FailedLongRunningExport,

        /// <summary>
        /// Enum TooManyRequestsFromAnOrganization for "TOO_MANY_REQUESTS_FROM_AN_ORGANIZATION"
        /// </summary>
        [EnumMember(Value = "TOO_MANY_REQUESTS_FROM_AN_ORGANIZATION")]
        TooManyRequestsFromAnOrganization,

        /// <summary>
        /// Enum FailedAsExportFileSizeIsGreaterThan10mb for "FAILED_AS_EXPORT_FILE_SIZE_IS_GREATER_THAN_10MB"
        /// </summary>
        [EnumMember(Value = "FAILED_AS_EXPORT_FILE_SIZE_IS_GREATER_THAN_10MB")]
        FailedAsExportFileSizeIsGreaterThan10mb,

        /// <summary>
        /// Enum NotAuthorizedToViewExport for "NOT_AUTHORIZED_TO_VIEW_EXPORT"
        /// </summary>
        [EnumMember(Value = "NOT_AUTHORIZED_TO_VIEW_EXPORT")]
        NotAuthorizedToViewExport,

        /// <summary>
        /// Enum StaticLinkExportFailed for "STATIC_LINK_EXPORT_FAILED"
        /// </summary>
        [EnumMember(Value = "STATIC_LINK_EXPORT_FAILED")]
        StaticLinkExportFailed,

        /// <summary>
        /// Enum TooManySearchCriteria for "TOO_MANY_SEARCH_CRITERIA"
        /// </summary>
        [EnumMember(Value = "TOO_MANY_SEARCH_CRITERIA")]
        TooManySearchCriteria,

        /// <summary>
        /// Enum SearchCriteriaValuesExceedLimit for "SEARCH_CRITERIA_VALUES_EXCEED_LIMIT"
        /// </summary>
        [EnumMember(Value = "SEARCH_CRITERIA_VALUES_EXCEED_LIMIT")]
        SearchCriteriaValuesExceedLimit,

        /// <summary>
        /// Enum ExportEmailFileSizeExceededLimit for "EXPORT_EMAIL_FILE_SIZE_EXCEEDED_LIMIT"
        /// </summary>
        [EnumMember(Value = "EXPORT_EMAIL_FILE_SIZE_EXCEEDED_LIMIT")]
        ExportEmailFileSizeExceededLimit,

        /// <summary>
        /// Enum CircuitBreakerOpenForViewType for "CIRCUIT_BREAKER_OPEN_FOR_VIEW_TYPE"
        /// </summary>
        [EnumMember(Value = "CIRCUIT_BREAKER_OPEN_FOR_VIEW_TYPE")]
        CircuitBreakerOpenForViewType
    }
    /// <summary>
    /// Gets or Sets Inner
    /// </summary>
    
    public enum InnerEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Sent for "Sent"
        /// </summary>
        [EnumMember(Value = "Sent")]
        Sent,

        /// <summary>
        /// Enum Pending for "Pending"
        /// </summary>
        [EnumMember(Value = "Pending")]
        Pending,

        /// <summary>
        /// Enum Failed for "Failed"
        /// </summary>
        [EnumMember(Value = "Failed")]
        Failed
    }
    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    [JsonPropertyName("status")]
    public StatusEnum? Status { get; set; }
    /// <summary>
    /// Gets or Sets ExportFormat
    /// </summary>
    [JsonPropertyName("exportFormat")]
    public ExportFormatEnum? ExportFormat { get; set; }
    /// <summary>
    /// Gets or Sets ViewType
    /// </summary>
    [JsonPropertyName("viewType")]
    public ViewTypeEnum? ViewType { get; set; }
    /// <summary>
    /// Gets or Sets ExportErrorMessagesType
    /// </summary>
    [JsonPropertyName("exportErrorMessagesType")]
    public ExportErrorMessagesTypeEnum? ExportErrorMessagesType { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="ReportingDataExportTopicDataExportNotification" /> class.
    /// </summary>
    /// <param name="Id">Id.</param>
    /// <param name="RunId">RunId.</param>
    /// <param name="Name">Name.</param>
    /// <param name="Status">Status.</param>
    /// <param name="ExportFormat">ExportFormat.</param>
    /// <param name="DownloadUrl">DownloadUrl.</param>
    /// <param name="ViewType">ViewType.</param>
    /// <param name="ExportErrorMessagesType">ExportErrorMessagesType.</param>
    /// <param name="Read">Read.</param>
    /// <param name="CreatedDateTime">CreatedDateTime.</param>
    /// <param name="ModifiedDateTime">ModifiedDateTime.</param>
    /// <param name="PercentageComplete">PercentageComplete.</param>
    /// <param name="EmailStatuses">EmailStatuses.</param>
    /// <param name="EmailErrorDescription">EmailErrorDescription.</param>
    /// <param name="ScheduleExpression">ScheduleExpression.</param>
    /// <param name="ScheduleStaticLinkUrl">ScheduleStaticLinkUrl.</param>
    /// <param name="ExportAllowedToRerun">ExportAllowedToRerun.</param>
    public ReportingDataExportTopicDataExportNotification(Guid? Id = null, Guid? RunId = null, string Name = null, StatusEnum? Status = null, ExportFormatEnum? ExportFormat = null, string DownloadUrl = null, ViewTypeEnum? ViewType = null, ExportErrorMessagesTypeEnum? ExportErrorMessagesType = null, bool? Read = null, DateTime? CreatedDateTime = null, DateTime? ModifiedDateTime = null, double? PercentageComplete = null, Dictionary<string, string> EmailStatuses = null, string EmailErrorDescription = null, string ScheduleExpression = null, string ScheduleStaticLinkUrl = null, bool? ExportAllowedToRerun = null)
    {
        this.Id = Id;
        this.RunId = RunId;
        this.Name = Name;
        this.Status = Status;
        this.ExportFormat = ExportFormat;
        this.DownloadUrl = DownloadUrl;
        this.ViewType = ViewType;
        this.ExportErrorMessagesType = ExportErrorMessagesType;
        this.Read = Read;
        this.CreatedDateTime = CreatedDateTime;
        this.ModifiedDateTime = ModifiedDateTime;
        this.PercentageComplete = PercentageComplete;
        this.EmailStatuses = EmailStatuses;
        this.EmailErrorDescription = EmailErrorDescription;
        this.ScheduleExpression = ScheduleExpression;
        this.ScheduleStaticLinkUrl = ScheduleStaticLinkUrl;
        this.ExportAllowedToRerun = ExportAllowedToRerun;

    }



    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [JsonPropertyName("id")]
    public Guid? Id { get; set; }



    /// <summary>
    /// Gets or Sets RunId
    /// </summary>
    [JsonPropertyName("runId")]
    public Guid? RunId { get; set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }







    /// <summary>
    /// Gets or Sets DownloadUrl
    /// </summary>
    [JsonPropertyName("downloadUrl")]
    public string DownloadUrl { get; set; }







    /// <summary>
    /// Gets or Sets Read
    /// </summary>
    [JsonPropertyName("read")]
    public bool? Read { get; set; }



    /// <summary>
    /// Gets or Sets CreatedDateTime
    /// </summary>
    [JsonPropertyName("createdDateTime")]
    public DateTime? CreatedDateTime { get; set; }



    /// <summary>
    /// Gets or Sets ModifiedDateTime
    /// </summary>
    [JsonPropertyName("modifiedDateTime")]
    public DateTime? ModifiedDateTime { get; set; }



    /// <summary>
    /// Gets or Sets PercentageComplete
    /// </summary>
    [JsonPropertyName("percentageComplete")]
    public double? PercentageComplete { get; set; }



    /// <summary>
    /// Gets or Sets EmailStatuses
    /// </summary>
    [JsonPropertyName("emailStatuses")]
    public Dictionary<string, string> EmailStatuses { get; set; }



    /// <summary>
    /// Gets or Sets EmailErrorDescription
    /// </summary>
    [JsonPropertyName("emailErrorDescription")]
    public string EmailErrorDescription { get; set; }



    /// <summary>
    /// Gets or Sets ScheduleExpression
    /// </summary>
    [JsonPropertyName("scheduleExpression")]
    public string ScheduleExpression { get; set; }



    /// <summary>
    /// Gets or Sets ScheduleStaticLinkUrl
    /// </summary>
    [JsonPropertyName("scheduleStaticLinkUrl")]
    public string ScheduleStaticLinkUrl { get; set; }



    /// <summary>
    /// Gets or Sets ExportAllowedToRerun
    /// </summary>
    [JsonPropertyName("exportAllowedToRerun")]
    public bool? ExportAllowedToRerun { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ReportingDataExportTopicDataExportNotification {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  RunId: ").Append(RunId).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  ExportFormat: ").Append(ExportFormat).Append("\n");
        sb.Append("  DownloadUrl: ").Append(DownloadUrl).Append("\n");
        sb.Append("  ViewType: ").Append(ViewType).Append("\n");
        sb.Append("  ExportErrorMessagesType: ").Append(ExportErrorMessagesType).Append("\n");
        sb.Append("  Read: ").Append(Read).Append("\n");
        sb.Append("  CreatedDateTime: ").Append(CreatedDateTime).Append("\n");
        sb.Append("  ModifiedDateTime: ").Append(ModifiedDateTime).Append("\n");
        sb.Append("  PercentageComplete: ").Append(PercentageComplete).Append("\n");
        sb.Append("  EmailStatuses: ").Append(EmailStatuses).Append("\n");
        sb.Append("  EmailErrorDescription: ").Append(EmailErrorDescription).Append("\n");
        sb.Append("  ScheduleExpression: ").Append(ScheduleExpression).Append("\n");
        sb.Append("  ScheduleStaticLinkUrl: ").Append(ScheduleStaticLinkUrl).Append("\n");
        sb.Append("  ExportAllowedToRerun: ").Append(ExportAllowedToRerun).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }


    /// <summary>
    /// Returns true if objects are equal
    /// </summary>
    /// <param name="obj">Object to be compared</param>
    /// <returns>Boolean</returns>
    public override bool Equals(object obj)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        return Equals(obj as ReportingDataExportTopicDataExportNotification);
    }

    /// <summary>
    /// Returns true if ReportingDataExportTopicDataExportNotification instances are equal
    /// </summary>
    /// <param name="other">Instance of ReportingDataExportTopicDataExportNotification to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ReportingDataExportTopicDataExportNotification other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Id == other.Id ||
                Id != null &&
                Id.Equals(other.Id)
            ) &&
            (
                RunId == other.RunId ||
                RunId != null &&
                RunId.Equals(other.RunId)
            ) &&
            (
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                Status == other.Status ||
                Status != null &&
                Status.Equals(other.Status)
            ) &&
            (
                ExportFormat == other.ExportFormat ||
                ExportFormat != null &&
                ExportFormat.Equals(other.ExportFormat)
            ) &&
            (
                DownloadUrl == other.DownloadUrl ||
                DownloadUrl != null &&
                DownloadUrl.Equals(other.DownloadUrl)
            ) &&
            (
                ViewType == other.ViewType ||
                ViewType != null &&
                ViewType.Equals(other.ViewType)
            ) &&
            (
                ExportErrorMessagesType == other.ExportErrorMessagesType ||
                ExportErrorMessagesType != null &&
                ExportErrorMessagesType.Equals(other.ExportErrorMessagesType)
            ) &&
            (
                Read == other.Read ||
                Read != null &&
                Read.Equals(other.Read)
            ) &&
            (
                CreatedDateTime == other.CreatedDateTime ||
                CreatedDateTime != null &&
                CreatedDateTime.Equals(other.CreatedDateTime)
            ) &&
            (
                ModifiedDateTime == other.ModifiedDateTime ||
                ModifiedDateTime != null &&
                ModifiedDateTime.Equals(other.ModifiedDateTime)
            ) &&
            (
                PercentageComplete == other.PercentageComplete ||
                PercentageComplete != null &&
                PercentageComplete.Equals(other.PercentageComplete)
            ) &&
            (
                EmailStatuses == other.EmailStatuses ||
                EmailStatuses != null &&
                EmailStatuses.SequenceEqual(other.EmailStatuses)
            ) &&
            (
                EmailErrorDescription == other.EmailErrorDescription ||
                EmailErrorDescription != null &&
                EmailErrorDescription.Equals(other.EmailErrorDescription)
            ) &&
            (
                ScheduleExpression == other.ScheduleExpression ||
                ScheduleExpression != null &&
                ScheduleExpression.Equals(other.ScheduleExpression)
            ) &&
            (
                ScheduleStaticLinkUrl == other.ScheduleStaticLinkUrl ||
                ScheduleStaticLinkUrl != null &&
                ScheduleStaticLinkUrl.Equals(other.ScheduleStaticLinkUrl)
            ) &&
            (
                ExportAllowedToRerun == other.ExportAllowedToRerun ||
                ExportAllowedToRerun != null &&
                ExportAllowedToRerun.Equals(other.ExportAllowedToRerun)
            );
    }

    /// <summary>
    /// Gets the hash code
    /// </summary>
    /// <returns>Hash code</returns>
    public override int GetHashCode()
    {
        // credit: http://stackoverflow.com/a/263416/677735
        unchecked // Overflow is fine, just wrap
        {
            int hash = 41;
            // Suitable nullity checks etc, of course :)
            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            if (RunId != null)
            {
                hash = hash * 59 + RunId.GetHashCode();
            }

            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (Status != null)
            {
                hash = hash * 59 + Status.GetHashCode();
            }

            if (ExportFormat != null)
            {
                hash = hash * 59 + ExportFormat.GetHashCode();
            }

            if (DownloadUrl != null)
            {
                hash = hash * 59 + DownloadUrl.GetHashCode();
            }

            if (ViewType != null)
            {
                hash = hash * 59 + ViewType.GetHashCode();
            }

            if (ExportErrorMessagesType != null)
            {
                hash = hash * 59 + ExportErrorMessagesType.GetHashCode();
            }

            if (Read != null)
            {
                hash = hash * 59 + Read.GetHashCode();
            }

            if (CreatedDateTime != null)
            {
                hash = hash * 59 + CreatedDateTime.GetHashCode();
            }

            if (ModifiedDateTime != null)
            {
                hash = hash * 59 + ModifiedDateTime.GetHashCode();
            }

            if (PercentageComplete != null)
            {
                hash = hash * 59 + PercentageComplete.GetHashCode();
            }

            if (EmailStatuses != null)
            {
                hash = hash * 59 + EmailStatuses.GetHashCode();
            }

            if (EmailErrorDescription != null)
            {
                hash = hash * 59 + EmailErrorDescription.GetHashCode();
            }

            if (ScheduleExpression != null)
            {
                hash = hash * 59 + ScheduleExpression.GetHashCode();
            }

            if (ScheduleStaticLinkUrl != null)
            {
                hash = hash * 59 + ScheduleStaticLinkUrl.GetHashCode();
            }

            if (ExportAllowedToRerun != null)
            {
                hash = hash * 59 + ExportAllowedToRerun.GetHashCode();
            }

            return hash;
        }
    }
}
