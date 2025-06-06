using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ReportingExportJobRequest
/// </summary>

public partial class ReportingExportJobRequest : IEquatable<ReportingExportJobRequest>
{
    /// <summary>
    /// The requested format of the exported data
    /// </summary>
    /// <value>The requested format of the exported data</value>
    
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
    /// The type of view export job to be created
    /// </summary>
    /// <value>The type of view export job to be created</value>
    
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
        /// Enum ApiUsageView for "API_USAGE_VIEW"
        /// </summary>
        [EnumMember(Value = "API_USAGE_VIEW")]
        ApiUsageView,

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
        /// Enum LandingPage for "LANDING_PAGE"
        /// </summary>
        [EnumMember(Value = "LANDING_PAGE")]
        LandingPage,

        /// <summary>
        /// Enum DashboardSummary for "DASHBOARD_SUMMARY"
        /// </summary>
        [EnumMember(Value = "DASHBOARD_SUMMARY")]
        DashboardSummary,

        /// <summary>
        /// Enum DashboardDetail for "DASHBOARD_DETAIL"
        /// </summary>
        [EnumMember(Value = "DASHBOARD_DETAIL")]
        DashboardDetail,

        /// <summary>
        /// Enum DashboardUsers for "DASHBOARD_USERS"
        /// </summary>
        [EnumMember(Value = "DASHBOARD_USERS")]
        DashboardUsers,

        /// <summary>
        /// Enum DashboardUsersDetail for "DASHBOARD_USERS_DETAIL"
        /// </summary>
        [EnumMember(Value = "DASHBOARD_USERS_DETAIL")]
        DashboardUsersDetail,

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
        /// Enum AgentPerformanceMeView for "AGENT_PERFORMANCE_ME_VIEW"
        /// </summary>
        [EnumMember(Value = "AGENT_PERFORMANCE_ME_VIEW")]
        AgentPerformanceMeView,

        /// <summary>
        /// Enum AgentStatusMeView for "AGENT_STATUS_ME_VIEW"
        /// </summary>
        [EnumMember(Value = "AGENT_STATUS_ME_VIEW")]
        AgentStatusMeView,

        /// <summary>
        /// Enum AgentEvaluationMeView for "AGENT_EVALUATION_ME_VIEW"
        /// </summary>
        [EnumMember(Value = "AGENT_EVALUATION_ME_VIEW")]
        AgentEvaluationMeView,

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
        /// Enum ScheduledExportsView for "SCHEDULED_EXPORTS_VIEW"
        /// </summary>
        [EnumMember(Value = "SCHEDULED_EXPORTS_VIEW")]
        ScheduledExportsView,

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
        /// Enum AlertRulesView for "ALERT_RULES_VIEW"
        /// </summary>
        [EnumMember(Value = "ALERT_RULES_VIEW")]
        AlertRulesView,

        /// <summary>
        /// Enum ConfigureAlertRuleView for "CONFIGURE_ALERT_RULE_VIEW"
        /// </summary>
        [EnumMember(Value = "CONFIGURE_ALERT_RULE_VIEW")]
        ConfigureAlertRuleView,

        /// <summary>
        /// Enum PredictiveRoutingView for "PREDICTIVE_ROUTING_VIEW"
        /// </summary>
        [EnumMember(Value = "PREDICTIVE_ROUTING_VIEW")]
        PredictiveRoutingView,

        /// <summary>
        /// Enum PredictiveRoutingQueueOverview for "PREDICTIVE_ROUTING_QUEUE_OVERVIEW"
        /// </summary>
        [EnumMember(Value = "PREDICTIVE_ROUTING_QUEUE_OVERVIEW")]
        PredictiveRoutingQueueOverview,

        /// <summary>
        /// Enum PredictiveRoutingModelView for "PREDICTIVE_ROUTING_MODEL_VIEW"
        /// </summary>
        [EnumMember(Value = "PREDICTIVE_ROUTING_MODEL_VIEW")]
        PredictiveRoutingModelView,

        /// <summary>
        /// Enum PredictiveRoutingImpactView for "PREDICTIVE_ROUTING_IMPACT_VIEW"
        /// </summary>
        [EnumMember(Value = "PREDICTIVE_ROUTING_IMPACT_VIEW")]
        PredictiveRoutingImpactView,

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
        /// Enum KnowledgePerformanceView for "KNOWLEDGE_PERFORMANCE_VIEW"
        /// </summary>
        [EnumMember(Value = "KNOWLEDGE_PERFORMANCE_VIEW")]
        KnowledgePerformanceView,

        /// <summary>
        /// Enum AgentScorecardInsightsSummaryView for "AGENT_SCORECARD_INSIGHTS_SUMMARY_VIEW"
        /// </summary>
        [EnumMember(Value = "AGENT_SCORECARD_INSIGHTS_SUMMARY_VIEW")]
        AgentScorecardInsightsSummaryView,

        /// <summary>
        /// Enum AgentScorecardInsightsDetailView for "AGENT_SCORECARD_INSIGHTS_DETAIL_VIEW"
        /// </summary>
        [EnumMember(Value = "AGENT_SCORECARD_INSIGHTS_DETAIL_VIEW")]
        AgentScorecardInsightsDetailView,

        /// <summary>
        /// Enum QueueWrapupDetailView for "QUEUE_WRAPUP_DETAIL_VIEW"
        /// </summary>
        [EnumMember(Value = "QUEUE_WRAPUP_DETAIL_VIEW")]
        QueueWrapupDetailView,

        /// <summary>
        /// Enum InteractionDetailView for "INTERACTION_DETAIL_VIEW"
        /// </summary>
        [EnumMember(Value = "INTERACTION_DETAIL_VIEW")]
        InteractionDetailView,

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
        /// Enum AgentAssistPerformanceView for "AGENT_ASSIST_PERFORMANCE_VIEW"
        /// </summary>
        [EnumMember(Value = "AGENT_ASSIST_PERFORMANCE_VIEW")]
        AgentAssistPerformanceView,

        /// <summary>
        /// Enum ContactCenterPerformanceView for "CONTACT_CENTER_PERFORMANCE_VIEW"
        /// </summary>
        [EnumMember(Value = "CONTACT_CENTER_PERFORMANCE_VIEW")]
        ContactCenterPerformanceView,

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
        /// Enum SocialListeningView for "SOCIAL_LISTENING_VIEW"
        /// </summary>
        [EnumMember(Value = "SOCIAL_LISTENING_VIEW")]
        SocialListeningView,

        /// <summary>
        /// Enum SocialListeningPostsView for "SOCIAL_LISTENING_POSTS_VIEW"
        /// </summary>
        [EnumMember(Value = "SOCIAL_LISTENING_POSTS_VIEW")]
        SocialListeningPostsView,

        /// <summary>
        /// Enum AgentPerformanceTimelineDetailView for "AGENT_PERFORMANCE_TIMELINE_DETAIL_VIEW"
        /// </summary>
        [EnumMember(Value = "AGENT_PERFORMANCE_TIMELINE_DETAIL_VIEW")]
        AgentPerformanceTimelineDetailView,

        /// <summary>
        /// Enum DashboardSlideshows for "DASHBOARD_SLIDESHOWS"
        /// </summary>
        [EnumMember(Value = "DASHBOARD_SLIDESHOWS")]
        DashboardSlideshows,

        /// <summary>
        /// Enum DashboardSlideshowsDetail for "DASHBOARD_SLIDESHOWS_DETAIL"
        /// </summary>
        [EnumMember(Value = "DASHBOARD_SLIDESHOWS_DETAIL")]
        DashboardSlideshowsDetail,

        /// <summary>
        /// Enum AgentCopilotPerformanceView for "AGENT_COPILOT_PERFORMANCE_VIEW"
        /// </summary>
        [EnumMember(Value = "AGENT_COPILOT_PERFORMANCE_VIEW")]
        AgentCopilotPerformanceView,

        /// <summary>
        /// Enum AgentAssignedEvaluationMeView for "AGENT_ASSIGNED_EVALUATION_ME_VIEW"
        /// </summary>
        [EnumMember(Value = "AGENT_ASSIGNED_EVALUATION_ME_VIEW")]
        AgentAssignedEvaluationMeView,

        /// <summary>
        /// Enum VirtualAgentPerformanceView for "VIRTUAL_AGENT_PERFORMANCE_VIEW"
        /// </summary>
        [EnumMember(Value = "VIRTUAL_AGENT_PERFORMANCE_VIEW")]
        VirtualAgentPerformanceView
    }
    /// <summary>
    /// The user supplied csv delimiter string value either of type 'comma' or 'semicolon' permitted for the export request
    /// </summary>
    /// <value>The user supplied csv delimiter string value either of type 'comma' or 'semicolon' permitted for the export request</value>
    
    public enum CsvDelimiterEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Semicolon for "SEMICOLON"
        /// </summary>
        [EnumMember(Value = "SEMICOLON")]
        Semicolon,

        /// <summary>
        /// Enum Comma for "COMMA"
        /// </summary>
        [EnumMember(Value = "COMMA")]
        Comma
    }
    /// <summary>
    /// Indicates the duration format for the exports
    /// </summary>
    /// <value>Indicates the duration format for the exports</value>
    
    public enum DurationFormatEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Seconds for "Seconds"
        /// </summary>
        [EnumMember(Value = "Seconds")]
        Seconds,

        /// <summary>
        /// Enum Milliseconds for "Milliseconds"
        /// </summary>
        [EnumMember(Value = "Milliseconds")]
        Milliseconds,

        /// <summary>
        /// Enum Hhmmss for "Hhmmss"
        /// </summary>
        [EnumMember(Value = "Hhmmss")]
        Hhmmss,

        /// <summary>
        /// Enum Hms for "Hms"
        /// </summary>
        [EnumMember(Value = "Hms")]
        Hms
    }
    /// <summary>
    /// The requested format of the exported data
    /// </summary>
    /// <value>The requested format of the exported data</value>
    [JsonPropertyName("exportFormat")]
    public ExportFormatEnum? ExportFormat { get; set; }
    /// <summary>
    /// The type of view export job to be created
    /// </summary>
    /// <value>The type of view export job to be created</value>
    [JsonPropertyName("viewType")]
    public ViewTypeEnum? ViewType { get; set; }
    /// <summary>
    /// The user supplied csv delimiter string value either of type 'comma' or 'semicolon' permitted for the export request
    /// </summary>
    /// <value>The user supplied csv delimiter string value either of type 'comma' or 'semicolon' permitted for the export request</value>
    [JsonPropertyName("csvDelimiter")]
    public CsvDelimiterEnum? CsvDelimiter { get; set; }
    /// <summary>
    /// Indicates the duration format for the exports
    /// </summary>
    /// <value>Indicates the duration format for the exports</value>
    [JsonPropertyName("durationFormat")]
    public DurationFormatEnum? DurationFormat { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="ReportingExportJobRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected ReportingExportJobRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ReportingExportJobRequest" /> class.
    /// </summary>
    /// <param name="Name">The user supplied name of the export request (required).</param>
    /// <param name="TimeZone">The requested timezone of the exported data. Time zones are represented as a string of the zone name as found in the IANA time zone database. For example: UTC, Etc/UTC, or Europe/London (required).</param>
    /// <param name="ExportFormat">The requested format of the exported data (required).</param>
    /// <param name="Interval">The time period used to limit the the exported data. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (required).</param>
    /// <param name="Period">The Period of the request in which to break down the intervals. Periods are represented as an ISO-8601 string. For example: P1D or P1DT12H (required).</param>
    /// <param name="ViewType">The type of view export job to be created (required).</param>
    /// <param name="Filter">Filters to apply to create the view (required).</param>
    /// <param name="Read">Indicates if the request has been marked as read.</param>
    /// <param name="Locale">The locale used for localization of the exported data, i.e. en-US, es (required).</param>
    /// <param name="HasFormatDurations">Indicates if durations are formatted in hh:mm:ss format instead of ms.</param>
    /// <param name="HasSplitFilters">Indicates if filters will be split in aggregate detail exports.</param>
    /// <param name="ExcludeEmptyRows">Excludes empty rows from the exports.</param>
    /// <param name="HasSplitByMedia">Indicates if media type will be split in aggregate detail exports.</param>
    /// <param name="HasSummaryRow">Indicates if summary row needs to be present in exports.</param>
    /// <param name="CsvDelimiter">The user supplied csv delimiter string value either of type &#39;comma&#39; or &#39;semicolon&#39; permitted for the export request.</param>
    /// <param name="SelectedColumns">The list of ordered selected columns from the export view by the user.</param>
    /// <param name="HasCustomParticipantAttributes">Indicates if custom participant attributes will be exported.</param>
    /// <param name="RecipientEmails">The list of email recipients for the exports.</param>
    /// <param name="IncludeDurationFormatInHeader">Indicates whether to include selected duration format to the column headers.</param>
    /// <param name="DurationFormat">Indicates the duration format for the exports.</param>
    public ReportingExportJobRequest(string Name = null, string TimeZone = null, ExportFormatEnum? ExportFormat = null, string Interval = null, string Period = null, ViewTypeEnum? ViewType = null, ViewFilter Filter = null, bool? Read = null, string Locale = null, bool? HasFormatDurations = null, bool? HasSplitFilters = null, bool? ExcludeEmptyRows = null, bool? HasSplitByMedia = null, bool? HasSummaryRow = null, CsvDelimiterEnum? CsvDelimiter = null, List<SelectedColumns> SelectedColumns = null, bool? HasCustomParticipantAttributes = null, List<string> RecipientEmails = null, bool? IncludeDurationFormatInHeader = null, DurationFormatEnum? DurationFormat = null)
    {
        this.Name = Name;
        this.TimeZone = TimeZone;
        this.ExportFormat = ExportFormat;
        this.Interval = Interval;
        this.Period = Period;
        this.ViewType = ViewType;
        this.Filter = Filter;
        this.Read = Read;
        this.Locale = Locale;
        this.HasFormatDurations = HasFormatDurations;
        this.HasSplitFilters = HasSplitFilters;
        this.ExcludeEmptyRows = ExcludeEmptyRows;
        this.HasSplitByMedia = HasSplitByMedia;
        this.HasSummaryRow = HasSummaryRow;
        this.CsvDelimiter = CsvDelimiter;
        this.SelectedColumns = SelectedColumns;
        this.HasCustomParticipantAttributes = HasCustomParticipantAttributes;
        this.RecipientEmails = RecipientEmails;
        this.IncludeDurationFormatInHeader = IncludeDurationFormatInHeader;
        this.DurationFormat = DurationFormat;

    }



    /// <summary>
    /// The user supplied name of the export request
    /// </summary>
    /// <value>The user supplied name of the export request</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// The requested timezone of the exported data. Time zones are represented as a string of the zone name as found in the IANA time zone database. For example: UTC, Etc/UTC, or Europe/London
    /// </summary>
    /// <value>The requested timezone of the exported data. Time zones are represented as a string of the zone name as found in the IANA time zone database. For example: UTC, Etc/UTC, or Europe/London</value>
    [JsonPropertyName("timeZone")]
    public string TimeZone { get; set; }





    /// <summary>
    /// The time period used to limit the the exported data. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss
    /// </summary>
    /// <value>The time period used to limit the the exported data. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss</value>
    [JsonPropertyName("interval")]
    public string Interval { get; set; }



    /// <summary>
    /// The Period of the request in which to break down the intervals. Periods are represented as an ISO-8601 string. For example: P1D or P1DT12H
    /// </summary>
    /// <value>The Period of the request in which to break down the intervals. Periods are represented as an ISO-8601 string. For example: P1D or P1DT12H</value>
    [JsonPropertyName("period")]
    public string Period { get; set; }





    /// <summary>
    /// Filters to apply to create the view
    /// </summary>
    /// <value>Filters to apply to create the view</value>
    [JsonPropertyName("filter")]
    public ViewFilter Filter { get; set; }



    /// <summary>
    /// Indicates if the request has been marked as read
    /// </summary>
    /// <value>Indicates if the request has been marked as read</value>
    [JsonPropertyName("read")]
    public bool? Read { get; set; }



    /// <summary>
    /// The locale used for localization of the exported data, i.e. en-US, es
    /// </summary>
    /// <value>The locale used for localization of the exported data, i.e. en-US, es</value>
    [JsonPropertyName("locale")]
    public string Locale { get; set; }



    /// <summary>
    /// Indicates if durations are formatted in hh:mm:ss format instead of ms
    /// </summary>
    /// <value>Indicates if durations are formatted in hh:mm:ss format instead of ms</value>
    [JsonPropertyName("hasFormatDurations")]
    public bool? HasFormatDurations { get; set; }



    /// <summary>
    /// Indicates if filters will be split in aggregate detail exports
    /// </summary>
    /// <value>Indicates if filters will be split in aggregate detail exports</value>
    [JsonPropertyName("hasSplitFilters")]
    public bool? HasSplitFilters { get; set; }



    /// <summary>
    /// Excludes empty rows from the exports
    /// </summary>
    /// <value>Excludes empty rows from the exports</value>
    [JsonPropertyName("excludeEmptyRows")]
    public bool? ExcludeEmptyRows { get; set; }



    /// <summary>
    /// Indicates if media type will be split in aggregate detail exports
    /// </summary>
    /// <value>Indicates if media type will be split in aggregate detail exports</value>
    [JsonPropertyName("hasSplitByMedia")]
    public bool? HasSplitByMedia { get; set; }



    /// <summary>
    /// Indicates if summary row needs to be present in exports
    /// </summary>
    /// <value>Indicates if summary row needs to be present in exports</value>
    [JsonPropertyName("hasSummaryRow")]
    public bool? HasSummaryRow { get; set; }





    /// <summary>
    /// The list of ordered selected columns from the export view by the user
    /// </summary>
    /// <value>The list of ordered selected columns from the export view by the user</value>
    [JsonPropertyName("selectedColumns")]
    public List<SelectedColumns> SelectedColumns { get; set; }



    /// <summary>
    /// Indicates if custom participant attributes will be exported
    /// </summary>
    /// <value>Indicates if custom participant attributes will be exported</value>
    [JsonPropertyName("hasCustomParticipantAttributes")]
    public bool? HasCustomParticipantAttributes { get; set; }



    /// <summary>
    /// The list of email recipients for the exports
    /// </summary>
    /// <value>The list of email recipients for the exports</value>
    [JsonPropertyName("recipientEmails")]
    public List<string> RecipientEmails { get; set; }



    /// <summary>
    /// Indicates whether to include selected duration format to the column headers
    /// </summary>
    /// <value>Indicates whether to include selected duration format to the column headers</value>
    [JsonPropertyName("includeDurationFormatInHeader")]
    public bool? IncludeDurationFormatInHeader { get; set; }




    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ReportingExportJobRequest {\n");

        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  TimeZone: ").Append(TimeZone).Append("\n");
        sb.Append("  ExportFormat: ").Append(ExportFormat).Append("\n");
        sb.Append("  Interval: ").Append(Interval).Append("\n");
        sb.Append("  Period: ").Append(Period).Append("\n");
        sb.Append("  ViewType: ").Append(ViewType).Append("\n");
        sb.Append("  Filter: ").Append(Filter).Append("\n");
        sb.Append("  Read: ").Append(Read).Append("\n");
        sb.Append("  Locale: ").Append(Locale).Append("\n");
        sb.Append("  HasFormatDurations: ").Append(HasFormatDurations).Append("\n");
        sb.Append("  HasSplitFilters: ").Append(HasSplitFilters).Append("\n");
        sb.Append("  ExcludeEmptyRows: ").Append(ExcludeEmptyRows).Append("\n");
        sb.Append("  HasSplitByMedia: ").Append(HasSplitByMedia).Append("\n");
        sb.Append("  HasSummaryRow: ").Append(HasSummaryRow).Append("\n");
        sb.Append("  CsvDelimiter: ").Append(CsvDelimiter).Append("\n");
        sb.Append("  SelectedColumns: ").Append(SelectedColumns).Append("\n");
        sb.Append("  HasCustomParticipantAttributes: ").Append(HasCustomParticipantAttributes).Append("\n");
        sb.Append("  RecipientEmails: ").Append(RecipientEmails).Append("\n");
        sb.Append("  IncludeDurationFormatInHeader: ").Append(IncludeDurationFormatInHeader).Append("\n");
        sb.Append("  DurationFormat: ").Append(DurationFormat).Append("\n");
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
        return Equals(obj as ReportingExportJobRequest);
    }

    /// <summary>
    /// Returns true if ReportingExportJobRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of ReportingExportJobRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ReportingExportJobRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                TimeZone == other.TimeZone ||
                TimeZone != null &&
                TimeZone.Equals(other.TimeZone)
            ) &&
            (
                ExportFormat == other.ExportFormat ||
                ExportFormat != null &&
                ExportFormat.Equals(other.ExportFormat)
            ) &&
            (
                Interval == other.Interval ||
                Interval != null &&
                Interval.Equals(other.Interval)
            ) &&
            (
                Period == other.Period ||
                Period != null &&
                Period.Equals(other.Period)
            ) &&
            (
                ViewType == other.ViewType ||
                ViewType != null &&
                ViewType.Equals(other.ViewType)
            ) &&
            (
                Filter == other.Filter ||
                Filter != null &&
                Filter.Equals(other.Filter)
            ) &&
            (
                Read == other.Read ||
                Read != null &&
                Read.Equals(other.Read)
            ) &&
            (
                Locale == other.Locale ||
                Locale != null &&
                Locale.Equals(other.Locale)
            ) &&
            (
                HasFormatDurations == other.HasFormatDurations ||
                HasFormatDurations != null &&
                HasFormatDurations.Equals(other.HasFormatDurations)
            ) &&
            (
                HasSplitFilters == other.HasSplitFilters ||
                HasSplitFilters != null &&
                HasSplitFilters.Equals(other.HasSplitFilters)
            ) &&
            (
                ExcludeEmptyRows == other.ExcludeEmptyRows ||
                ExcludeEmptyRows != null &&
                ExcludeEmptyRows.Equals(other.ExcludeEmptyRows)
            ) &&
            (
                HasSplitByMedia == other.HasSplitByMedia ||
                HasSplitByMedia != null &&
                HasSplitByMedia.Equals(other.HasSplitByMedia)
            ) &&
            (
                HasSummaryRow == other.HasSummaryRow ||
                HasSummaryRow != null &&
                HasSummaryRow.Equals(other.HasSummaryRow)
            ) &&
            (
                CsvDelimiter == other.CsvDelimiter ||
                CsvDelimiter != null &&
                CsvDelimiter.Equals(other.CsvDelimiter)
            ) &&
            (
                SelectedColumns == other.SelectedColumns ||
                SelectedColumns != null &&
                SelectedColumns.SequenceEqual(other.SelectedColumns)
            ) &&
            (
                HasCustomParticipantAttributes == other.HasCustomParticipantAttributes ||
                HasCustomParticipantAttributes != null &&
                HasCustomParticipantAttributes.Equals(other.HasCustomParticipantAttributes)
            ) &&
            (
                RecipientEmails == other.RecipientEmails ||
                RecipientEmails != null &&
                RecipientEmails.SequenceEqual(other.RecipientEmails)
            ) &&
            (
                IncludeDurationFormatInHeader == other.IncludeDurationFormatInHeader ||
                IncludeDurationFormatInHeader != null &&
                IncludeDurationFormatInHeader.Equals(other.IncludeDurationFormatInHeader)
            ) &&
            (
                DurationFormat == other.DurationFormat ||
                DurationFormat != null &&
                DurationFormat.Equals(other.DurationFormat)
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
            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (TimeZone != null)
            {
                hash = hash * 59 + TimeZone.GetHashCode();
            }

            if (ExportFormat != null)
            {
                hash = hash * 59 + ExportFormat.GetHashCode();
            }

            if (Interval != null)
            {
                hash = hash * 59 + Interval.GetHashCode();
            }

            if (Period != null)
            {
                hash = hash * 59 + Period.GetHashCode();
            }

            if (ViewType != null)
            {
                hash = hash * 59 + ViewType.GetHashCode();
            }

            if (Filter != null)
            {
                hash = hash * 59 + Filter.GetHashCode();
            }

            if (Read != null)
            {
                hash = hash * 59 + Read.GetHashCode();
            }

            if (Locale != null)
            {
                hash = hash * 59 + Locale.GetHashCode();
            }

            if (HasFormatDurations != null)
            {
                hash = hash * 59 + HasFormatDurations.GetHashCode();
            }

            if (HasSplitFilters != null)
            {
                hash = hash * 59 + HasSplitFilters.GetHashCode();
            }

            if (ExcludeEmptyRows != null)
            {
                hash = hash * 59 + ExcludeEmptyRows.GetHashCode();
            }

            if (HasSplitByMedia != null)
            {
                hash = hash * 59 + HasSplitByMedia.GetHashCode();
            }

            if (HasSummaryRow != null)
            {
                hash = hash * 59 + HasSummaryRow.GetHashCode();
            }

            if (CsvDelimiter != null)
            {
                hash = hash * 59 + CsvDelimiter.GetHashCode();
            }

            if (SelectedColumns != null)
            {
                hash = hash * 59 + SelectedColumns.GetHashCode();
            }

            if (HasCustomParticipantAttributes != null)
            {
                hash = hash * 59 + HasCustomParticipantAttributes.GetHashCode();
            }

            if (RecipientEmails != null)
            {
                hash = hash * 59 + RecipientEmails.GetHashCode();
            }

            if (IncludeDurationFormatInHeader != null)
            {
                hash = hash * 59 + IncludeDurationFormatInHeader.GetHashCode();
            }

            if (DurationFormat != null)
            {
                hash = hash * 59 + DurationFormat.GetHashCode();
            }

            return hash;
        }
    }
}
