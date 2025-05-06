using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public partial class AuditTopicAuditLogMessage
{
    /// <summary>
    /// Gets or Sets EntityType
    /// </summary>

    public enum EntityTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Feedback for "Feedback"
        /// </summary>
        [EnumMember(Value = "Feedback")]
        Feedback,

        /// <summary>
        /// Enum Document for "Document"
        /// </summary>
        [EnumMember(Value = "Document")]
        Document,

        /// <summary>
        /// Enum Workspace for "Workspace"
        /// </summary>
        [EnumMember(Value = "Workspace")]
        Workspace,

        /// <summary>
        /// Enum Tag for "Tag"
        /// </summary>
        [EnumMember(Value = "Tag")]
        Tag,

        /// <summary>
        /// Enum Accesstoken for "AccessToken"
        /// </summary>
        [EnumMember(Value = "AccessToken")]
        Accesstoken,

        /// <summary>
        /// Enum Oauthclientauthorization for "OAuthClientAuthorization"
        /// </summary>
        [EnumMember(Value = "OAuthClientAuthorization")]
        Oauthclientauthorization,

        /// <summary>
        /// Enum Authorganization for "AuthOrganization"
        /// </summary>
        [EnumMember(Value = "AuthOrganization")]
        Authorganization,

        /// <summary>
        /// Enum Oauthclient for "OAuthClient"
        /// </summary>
        [EnumMember(Value = "OAuthClient")]
        Oauthclient,

        /// <summary>
        /// Enum Authuser for "AuthUser"
        /// </summary>
        [EnumMember(Value = "AuthUser")]
        Authuser,

        /// <summary>
        /// Enum Organizationauthorizationtrust for "OrganizationAuthorizationTrust"
        /// </summary>
        [EnumMember(Value = "OrganizationAuthorizationTrust")]
        Organizationauthorizationtrust,

        /// <summary>
        /// Enum Organizationauthorizationusertrust for "OrganizationAuthorizationUserTrust"
        /// </summary>
        [EnumMember(Value = "OrganizationAuthorizationUserTrust")]
        Organizationauthorizationusertrust,

        /// <summary>
        /// Enum Role for "Role"
        /// </summary>
        [EnumMember(Value = "Role")]
        Role,

        /// <summary>
        /// Enum Rolesettings for "RoleSettings"
        /// </summary>
        [EnumMember(Value = "RoleSettings")]
        Rolesettings,

        /// <summary>
        /// Enum Policy for "Policy"
        /// </summary>
        [EnumMember(Value = "Policy")]
        Policy,

        /// <summary>
        /// Enum Voicemailuserpolicy for "VoicemailUserPolicy"
        /// </summary>
        [EnumMember(Value = "VoicemailUserPolicy")]
        Voicemailuserpolicy,

        /// <summary>
        /// Enum Userpresence for "UserPresence"
        /// </summary>
        [EnumMember(Value = "UserPresence")]
        Userpresence,

        /// <summary>
        /// Enum Dependencytrackingbuild for "DependencyTrackingBuild"
        /// </summary>
        [EnumMember(Value = "DependencyTrackingBuild")]
        Dependencytrackingbuild,

        /// <summary>
        /// Enum Flow for "Flow"
        /// </summary>
        [EnumMember(Value = "Flow")]
        Flow,

        /// <summary>
        /// Enum Prompt for "Prompt"
        /// </summary>
        [EnumMember(Value = "Prompt")]
        Prompt,

        /// <summary>
        /// Enum Promptresource for "PromptResource"
        /// </summary>
        [EnumMember(Value = "PromptResource")]
        Promptresource,

        /// <summary>
        /// Enum Flowoutcome for "FlowOutcome"
        /// </summary>
        [EnumMember(Value = "FlowOutcome")]
        Flowoutcome,

        /// <summary>
        /// Enum Flowmilestone for "FlowMilestone"
        /// </summary>
        [EnumMember(Value = "FlowMilestone")]
        Flowmilestone,

        /// <summary>
        /// Enum Grammar for "Grammar"
        /// </summary>
        [EnumMember(Value = "Grammar")]
        Grammar,

        /// <summary>
        /// Enum Grammarlanguage for "GrammarLanguage"
        /// </summary>
        [EnumMember(Value = "GrammarLanguage")]
        Grammarlanguage,

        /// <summary>
        /// Enum Agentroutinginfo for "AgentRoutingInfo"
        /// </summary>
        [EnumMember(Value = "AgentRoutingInfo")]
        Agentroutinginfo,

        /// <summary>
        /// Enum Queue for "Queue"
        /// </summary>
        [EnumMember(Value = "Queue")]
        Queue,

        /// <summary>
        /// Enum Wrapupcode for "WrapupCode"
        /// </summary>
        [EnumMember(Value = "WrapupCode")]
        Wrapupcode,

        /// <summary>
        /// Enum Maxorgroutingutilizationcapacity for "MaxOrgRoutingUtilizationCapacity"
        /// </summary>
        [EnumMember(Value = "MaxOrgRoutingUtilizationCapacity")]
        Maxorgroutingutilizationcapacity,

        /// <summary>
        /// Enum Conversationattributes for "ConversationAttributes"
        /// </summary>
        [EnumMember(Value = "ConversationAttributes")]
        Conversationattributes,

        /// <summary>
        /// Enum Routingutilizationtag for "RoutingUtilizationTag"
        /// </summary>
        [EnumMember(Value = "RoutingUtilizationTag")]
        Routingutilizationtag,

        /// <summary>
        /// Enum Evaluation for "Evaluation"
        /// </summary>
        [EnumMember(Value = "Evaluation")]
        Evaluation,

        /// <summary>
        /// Enum Calibration for "Calibration"
        /// </summary>
        [EnumMember(Value = "Calibration")]
        Calibration,

        /// <summary>
        /// Enum Survey for "Survey"
        /// </summary>
        [EnumMember(Value = "Survey")]
        Survey,

        /// <summary>
        /// Enum Evaluationform for "EvaluationForm"
        /// </summary>
        [EnumMember(Value = "EvaluationForm")]
        Evaluationform,

        /// <summary>
        /// Enum Surveyform for "SurveyForm"
        /// </summary>
        [EnumMember(Value = "SurveyForm")]
        Surveyform,

        /// <summary>
        /// Enum Recording for "Recording"
        /// </summary>
        [EnumMember(Value = "Recording")]
        Recording,

        /// <summary>
        /// Enum Screenrecording for "ScreenRecording"
        /// </summary>
        [EnumMember(Value = "ScreenRecording")]
        Screenrecording,

        /// <summary>
        /// Enum Bulkactions for "BulkActions"
        /// </summary>
        [EnumMember(Value = "BulkActions")]
        Bulkactions,

        /// <summary>
        /// Enum Orphanedrecording for "OrphanedRecording"
        /// </summary>
        [EnumMember(Value = "OrphanedRecording")]
        Orphanedrecording,

        /// <summary>
        /// Enum Recordingannotation for "RecordingAnnotation"
        /// </summary>
        [EnumMember(Value = "RecordingAnnotation")]
        Recordingannotation,

        /// <summary>
        /// Enum Recordingsettings for "RecordingSettings"
        /// </summary>
        [EnumMember(Value = "RecordingSettings")]
        Recordingsettings,

        /// <summary>
        /// Enum Recordingkey for "RecordingKey"
        /// </summary>
        [EnumMember(Value = "RecordingKey")]
        Recordingkey,

        /// <summary>
        /// Enum Recordingkeyconfig for "RecordingKeyConfig"
        /// </summary>
        [EnumMember(Value = "RecordingKeyConfig")]
        Recordingkeyconfig,

        /// <summary>
        /// Enum Topic for "Topic"
        /// </summary>
        [EnumMember(Value = "Topic")]
        Topic,

        /// <summary>
        /// Enum Program for "Program"
        /// </summary>
        [EnumMember(Value = "Program")]
        Program,

        /// <summary>
        /// Enum Category for "Category"
        /// </summary>
        [EnumMember(Value = "Category")]
        Category,

        /// <summary>
        /// Enum Sentimentfeedback for "SentimentFeedback"
        /// </summary>
        [EnumMember(Value = "SentimentFeedback")]
        Sentimentfeedback,

        /// <summary>
        /// Enum Dictionaryfeedback for "DictionaryFeedback"
        /// </summary>
        [EnumMember(Value = "DictionaryFeedback")]
        Dictionaryfeedback,

        /// <summary>
        /// Enum Interactionreprocessingjob for "InteractionReprocessingJob"
        /// </summary>
        [EnumMember(Value = "InteractionReprocessingJob")]
        Interactionreprocessingjob,

        /// <summary>
        /// Enum Segment for "Segment"
        /// </summary>
        [EnumMember(Value = "Segment")]
        Segment,

        /// <summary>
        /// Enum Outcome for "Outcome"
        /// </summary>
        [EnumMember(Value = "Outcome")]
        Outcome,

        /// <summary>
        /// Enum Actionmap for "ActionMap"
        /// </summary>
        [EnumMember(Value = "ActionMap")]
        Actionmap,

        /// <summary>
        /// Enum Actiontemplate for "ActionTemplate"
        /// </summary>
        [EnumMember(Value = "ActionTemplate")]
        Actiontemplate,

        /// <summary>
        /// Enum Clickstreamsettings for "ClickstreamSettings"
        /// </summary>
        [EnumMember(Value = "ClickstreamSettings")]
        Clickstreamsettings,

        /// <summary>
        /// Enum Eventtype for "EventType"
        /// </summary>
        [EnumMember(Value = "EventType")]
        Eventtype,

        /// <summary>
        /// Enum Sessiontype for "SessionType"
        /// </summary>
        [EnumMember(Value = "SessionType")]
        Sessiontype,

        /// <summary>
        /// Enum Knowledgebase for "KnowledgeBase"
        /// </summary>
        [EnumMember(Value = "KnowledgeBase")]
        Knowledgebase,

        /// <summary>
        /// Enum Knowledgecategory for "KnowledgeCategory"
        /// </summary>
        [EnumMember(Value = "KnowledgeCategory")]
        Knowledgecategory,

        /// <summary>
        /// Enum Knowledgecontext for "KnowledgeContext"
        /// </summary>
        [EnumMember(Value = "KnowledgeContext")]
        Knowledgecontext,

        /// <summary>
        /// Enum Knowledgecontextvalue for "KnowledgeContextValue"
        /// </summary>
        [EnumMember(Value = "KnowledgeContextValue")]
        Knowledgecontextvalue,

        /// <summary>
        /// Enum Knowledgedocument for "KnowledgeDocument"
        /// </summary>
        [EnumMember(Value = "KnowledgeDocument")]
        Knowledgedocument,

        /// <summary>
        /// Enum Knowledgedocumentvariation for "KnowledgeDocumentVariation"
        /// </summary>
        [EnumMember(Value = "KnowledgeDocumentVariation")]
        Knowledgedocumentvariation,

        /// <summary>
        /// Enum Knowledgelabel for "KnowledgeLabel"
        /// </summary>
        [EnumMember(Value = "KnowledgeLabel")]
        Knowledgelabel,

        /// <summary>
        /// Enum Knowledgetraining for "KnowledgeTraining"
        /// </summary>
        [EnumMember(Value = "KnowledgeTraining")]
        Knowledgetraining,

        /// <summary>
        /// Enum Knowledgesearchfeedback for "KnowledgeSearchFeedback"
        /// </summary>
        [EnumMember(Value = "KnowledgeSearchFeedback")]
        Knowledgesearchfeedback,

        /// <summary>
        /// Enum Transcriptionsettings for "TranscriptionSettings"
        /// </summary>
        [EnumMember(Value = "TranscriptionSettings")]
        Transcriptionsettings,

        /// <summary>
        /// Enum Speechtextanalyticssettings for "SpeechTextAnalyticsSettings"
        /// </summary>
        [EnumMember(Value = "SpeechTextAnalyticsSettings")]
        Speechtextanalyticssettings,

        /// <summary>
        /// Enum Appointment for "Appointment"
        /// </summary>
        [EnumMember(Value = "Appointment")]
        Appointment,

        /// <summary>
        /// Enum Annotation for "Annotation"
        /// </summary>
        [EnumMember(Value = "Annotation")]
        Annotation,

        /// <summary>
        /// Enum Organization for "Organization"
        /// </summary>
        [EnumMember(Value = "Organization")]
        Organization,

        /// <summary>
        /// Enum Module for "Module"
        /// </summary>
        [EnumMember(Value = "Module")]
        Module,

        /// <summary>
        /// Enum Rule for "Rule"
        /// </summary>
        [EnumMember(Value = "Rule")]
        Rule,

        /// <summary>
        /// Enum Assignment for "Assignment"
        /// </summary>
        [EnumMember(Value = "Assignment")]
        Assignment,

        /// <summary>
        /// Enum Contest for "Contest"
        /// </summary>
        [EnumMember(Value = "Contest")]
        Contest,

        /// <summary>
        /// Enum Recognition for "Recognition"
        /// </summary>
        [EnumMember(Value = "Recognition")]
        Recognition,

        /// <summary>
        /// Enum Activitycode for "ActivityCode"
        /// </summary>
        [EnumMember(Value = "ActivityCode")]
        Activitycode,

        /// <summary>
        /// Enum Activityplan for "ActivityPlan"
        /// </summary>
        [EnumMember(Value = "ActivityPlan")]
        Activityplan,

        /// <summary>
        /// Enum Activityplanoccurrence for "ActivityPlanOccurrence"
        /// </summary>
        [EnumMember(Value = "ActivityPlanOccurrence")]
        Activityplanoccurrence,

        /// <summary>
        /// Enum Adherenceexplanation for "AdherenceExplanation"
        /// </summary>
        [EnumMember(Value = "AdherenceExplanation")]
        Adherenceexplanation,

        /// <summary>
        /// Enum Alternativeshift for "AlternativeShift"
        /// </summary>
        [EnumMember(Value = "AlternativeShift")]
        Alternativeshift,

        /// <summary>
        /// Enum Businessunit for "BusinessUnit"
        /// </summary>
        [EnumMember(Value = "BusinessUnit")]
        Businessunit,

        /// <summary>
        /// Enum Forecast for "Forecast"
        /// </summary>
        [EnumMember(Value = "Forecast")]
        Forecast,

        /// <summary>
        /// Enum Managementunit for "ManagementUnit"
        /// </summary>
        [EnumMember(Value = "ManagementUnit")]
        Managementunit,

        /// <summary>
        /// Enum Planninggroup for "PlanningGroup"
        /// </summary>
        [EnumMember(Value = "PlanningGroup")]
        Planninggroup,

        /// <summary>
        /// Enum Schedule for "Schedule"
        /// </summary>
        [EnumMember(Value = "Schedule")]
        Schedule,

        /// <summary>
        /// Enum Servicegoaltemplate for "ServiceGoalTemplate"
        /// </summary>
        [EnumMember(Value = "ServiceGoalTemplate")]
        Servicegoaltemplate,

        /// <summary>
        /// Enum Shifttrade for "ShiftTrade"
        /// </summary>
        [EnumMember(Value = "ShiftTrade")]
        Shifttrade,

        /// <summary>
        /// Enum Timeofflimit for "TimeOffLimit"
        /// </summary>
        [EnumMember(Value = "TimeOffLimit")]
        Timeofflimit,

        /// <summary>
        /// Enum Timeoffplan for "TimeOffPlan"
        /// </summary>
        [EnumMember(Value = "TimeOffPlan")]
        Timeoffplan,

        /// <summary>
        /// Enum Timeoffrequest for "TimeOffRequest"
        /// </summary>
        [EnumMember(Value = "TimeOffRequest")]
        Timeoffrequest,

        /// <summary>
        /// Enum Workplan for "WorkPlan"
        /// </summary>
        [EnumMember(Value = "WorkPlan")]
        Workplan,

        /// <summary>
        /// Enum Workplanbid for "WorkPlanBid"
        /// </summary>
        [EnumMember(Value = "WorkPlanBid")]
        Workplanbid,

        /// <summary>
        /// Enum Workplanbidgroup for "WorkPlanBidGroup"
        /// </summary>
        [EnumMember(Value = "WorkPlanBidGroup")]
        Workplanbidgroup,

        /// <summary>
        /// Enum Workplanrotation for "WorkPlanRotation"
        /// </summary>
        [EnumMember(Value = "WorkPlanRotation")]
        Workplanrotation,

        /// <summary>
        /// Enum Historicaldata for "HistoricalData"
        /// </summary>
        [EnumMember(Value = "HistoricalData")]
        Historicaldata,

        /// <summary>
        /// Enum Staffinggroup for "StaffingGroup"
        /// </summary>
        [EnumMember(Value = "StaffingGroup")]
        Staffinggroup,

        /// <summary>
        /// Enum Trigger for "Trigger"
        /// </summary>
        [EnumMember(Value = "Trigger")]
        Trigger,

        /// <summary>
        /// Enum Response for "Response"
        /// </summary>
        [EnumMember(Value = "Response")]
        Response,

        /// <summary>
        /// Enum Responselibrary for "ResponseLibrary"
        /// </summary>
        [EnumMember(Value = "ResponseLibrary")]
        Responselibrary,

        /// <summary>
        /// Enum Responseasset for "ResponseAsset"
        /// </summary>
        [EnumMember(Value = "ResponseAsset")]
        Responseasset,

        /// <summary>
        /// Enum Skillgroup for "SkillGroup"
        /// </summary>
        [EnumMember(Value = "SkillGroup")]
        Skillgroup,

        /// <summary>
        /// Enum Directorygroup for "DirectoryGroup"
        /// </summary>
        [EnumMember(Value = "DirectoryGroup")]
        Directorygroup,

        /// <summary>
        /// Enum Team for "Team"
        /// </summary>
        [EnumMember(Value = "Team")]
        Team,

        /// <summary>
        /// Enum Skillgroupdefinition for "SkillGroupDefinition"
        /// </summary>
        [EnumMember(Value = "SkillGroupDefinition")]
        Skillgroupdefinition,

        /// <summary>
        /// Enum Edge for "Edge"
        /// </summary>
        [EnumMember(Value = "Edge")]
        Edge,

        /// <summary>
        /// Enum Edgegroup for "EdgeGroup"
        /// </summary>
        [EnumMember(Value = "EdgeGroup")]
        Edgegroup,

        /// <summary>
        /// Enum Voicemailpolicy for "VoicemailPolicy"
        /// </summary>
        [EnumMember(Value = "VoicemailPolicy")]
        Voicemailpolicy,

        /// <summary>
        /// Enum Routingtranscriptionsettings for "RoutingTranscriptionSettings"
        /// </summary>
        [EnumMember(Value = "RoutingTranscriptionSettings")]
        Routingtranscriptionsettings,

        /// <summary>
        /// Enum Trunk for "Trunk"
        /// </summary>
        [EnumMember(Value = "Trunk")]
        Trunk,

        /// <summary>
        /// Enum Trunkbase for "TrunkBase"
        /// </summary>
        [EnumMember(Value = "TrunkBase")]
        Trunkbase,

        /// <summary>
        /// Enum Schedulegroup for "ScheduleGroup"
        /// </summary>
        [EnumMember(Value = "ScheduleGroup")]
        Schedulegroup,

        /// <summary>
        /// Enum Emergencygroup for "EmergencyGroup"
        /// </summary>
        [EnumMember(Value = "EmergencyGroup")]
        Emergencygroup,

        /// <summary>
        /// Enum Ivr for "IVR"
        /// </summary>
        [EnumMember(Value = "IVR")]
        Ivr,

        /// <summary>
        /// Enum Alertablepresencesoverrides for "AlertablePresencesOverrides"
        /// </summary>
        [EnumMember(Value = "AlertablePresencesOverrides")]
        Alertablepresencesoverrides,

        /// <summary>
        /// Enum Did for "DID"
        /// </summary>
        [EnumMember(Value = "DID")]
        Did,

        /// <summary>
        /// Enum Didpool for "DIDPool"
        /// </summary>
        [EnumMember(Value = "DIDPool")]
        Didpool,

        /// <summary>
        /// Enum Extension for "Extension"
        /// </summary>
        [EnumMember(Value = "Extension")]
        Extension,

        /// <summary>
        /// Enum Extensionpool for "ExtensionPool"
        /// </summary>
        [EnumMember(Value = "ExtensionPool")]
        Extensionpool,

        /// <summary>
        /// Enum Phone for "Phone"
        /// </summary>
        [EnumMember(Value = "Phone")]
        Phone,

        /// <summary>
        /// Enum Phonebase for "PhoneBase"
        /// </summary>
        [EnumMember(Value = "PhoneBase")]
        Phonebase,

        /// <summary>
        /// Enum Line for "Line"
        /// </summary>
        [EnumMember(Value = "Line")]
        Line,

        /// <summary>
        /// Enum Linebase for "LineBase"
        /// </summary>
        [EnumMember(Value = "LineBase")]
        Linebase,

        /// <summary>
        /// Enum Outboundroute for "OutboundRoute"
        /// </summary>
        [EnumMember(Value = "OutboundRoute")]
        Outboundroute,

        /// <summary>
        /// Enum Numberplan for "NumberPlan"
        /// </summary>
        [EnumMember(Value = "NumberPlan")]
        Numberplan,

        /// <summary>
        /// Enum Site for "Site"
        /// </summary>
        [EnumMember(Value = "Site")]
        Site,

        /// <summary>
        /// Enum Attemptlimits for "AttemptLimits"
        /// </summary>
        [EnumMember(Value = "AttemptLimits")]
        Attemptlimits,

        /// <summary>
        /// Enum Callabletimeset for "CallableTimeSet"
        /// </summary>
        [EnumMember(Value = "CallableTimeSet")]
        Callabletimeset,

        /// <summary>
        /// Enum Campaign for "Campaign"
        /// </summary>
        [EnumMember(Value = "Campaign")]
        Campaign,

        /// <summary>
        /// Enum Campaignrule for "CampaignRule"
        /// </summary>
        [EnumMember(Value = "CampaignRule")]
        Campaignrule,

        /// <summary>
        /// Enum Campaignschedule for "CampaignSchedule"
        /// </summary>
        [EnumMember(Value = "CampaignSchedule")]
        Campaignschedule,

        /// <summary>
        /// Enum Sequence for "Sequence"
        /// </summary>
        [EnumMember(Value = "Sequence")]
        Sequence,

        /// <summary>
        /// Enum Sequenceschedule for "SequenceSchedule"
        /// </summary>
        [EnumMember(Value = "SequenceSchedule")]
        Sequenceschedule,

        /// <summary>
        /// Enum Contactlist for "ContactList"
        /// </summary>
        [EnumMember(Value = "ContactList")]
        Contactlist,

        /// <summary>
        /// Enum Contactlistfilter for "ContactListFilter"
        /// </summary>
        [EnumMember(Value = "ContactListFilter")]
        Contactlistfilter,

        /// <summary>
        /// Enum Contactlisttemplate for "ContactListTemplate"
        /// </summary>
        [EnumMember(Value = "ContactListTemplate")]
        Contactlisttemplate,

        /// <summary>
        /// Enum Digitalruleset for "DigitalRuleSet"
        /// </summary>
        [EnumMember(Value = "DigitalRuleSet")]
        Digitalruleset,

        /// <summary>
        /// Enum Dnclist for "DNCList"
        /// </summary>
        [EnumMember(Value = "DNCList")]
        Dnclist,

        /// <summary>
        /// Enum Filespecificationtemplate for "FileSpecificationTemplate"
        /// </summary>
        [EnumMember(Value = "FileSpecificationTemplate")]
        Filespecificationtemplate,

        /// <summary>
        /// Enum Importtemplate for "ImportTemplate"
        /// </summary>
        [EnumMember(Value = "ImportTemplate")]
        Importtemplate,

        /// <summary>
        /// Enum Organizationsettings for "OrganizationSettings"
        /// </summary>
        [EnumMember(Value = "OrganizationSettings")]
        Organizationsettings,

        /// <summary>
        /// Enum Callanalysisresponseset for "CallAnalysisResponseSet"
        /// </summary>
        [EnumMember(Value = "CallAnalysisResponseSet")]
        Callanalysisresponseset,

        /// <summary>
        /// Enum Ruleset for "RuleSet"
        /// </summary>
        [EnumMember(Value = "RuleSet")]
        Ruleset,

        /// <summary>
        /// Enum Wrapupcodemapping for "WrapUpCodeMapping"
        /// </summary>
        [EnumMember(Value = "WrapUpCodeMapping")]
        Wrapupcodemapping,

        /// <summary>
        /// Enum Messagingcampaign for "MessagingCampaign"
        /// </summary>
        [EnumMember(Value = "MessagingCampaign")]
        Messagingcampaign,

        /// <summary>
        /// Enum Messagingcampaignschedule for "MessagingCampaignSchedule"
        /// </summary>
        [EnumMember(Value = "MessagingCampaignSchedule")]
        Messagingcampaignschedule,

        /// <summary>
        /// Enum Emailcampaignschedule for "EmailCampaignSchedule"
        /// </summary>
        [EnumMember(Value = "EmailCampaignSchedule")]
        Emailcampaignschedule,

        /// <summary>
        /// Enum Predictor for "Predictor"
        /// </summary>
        [EnumMember(Value = "Predictor")]
        Predictor,

        /// <summary>
        /// Enum Kpispecification for "KpiSpecification"
        /// </summary>
        [EnumMember(Value = "KpiSpecification")]
        Kpispecification,

        /// <summary>
        /// Enum Metric for "Metric"
        /// </summary>
        [EnumMember(Value = "Metric")]
        Metric,

        /// <summary>
        /// Enum Status for "Status"
        /// </summary>
        [EnumMember(Value = "Status")]
        Status,

        /// <summary>
        /// Enum Profile for "Profile"
        /// </summary>
        [EnumMember(Value = "Profile")]
        Profile,

        /// <summary>
        /// Enum Profilemembers for "ProfileMembers"
        /// </summary>
        [EnumMember(Value = "ProfileMembers")]
        Profilemembers,

        /// <summary>
        /// Enum Action for "Action"
        /// </summary>
        [EnumMember(Value = "Action")]
        Action,

        /// <summary>
        /// Enum Actiondraft for "ActionDraft"
        /// </summary>
        [EnumMember(Value = "ActionDraft")]
        Actiondraft,

        /// <summary>
        /// Enum Integration for "Integration"
        /// </summary>
        [EnumMember(Value = "Integration")]
        Integration,

        /// <summary>
        /// Enum Webhook for "Webhook"
        /// </summary>
        [EnumMember(Value = "Webhook")]
        Webhook,

        /// <summary>
        /// Enum Dashboardsettings for "DashboardSettings"
        /// </summary>
        [EnumMember(Value = "DashboardSettings")]
        Dashboardsettings,

        /// <summary>
        /// Enum Insightsettings for "InsightSettings"
        /// </summary>
        [EnumMember(Value = "InsightSettings")]
        Insightsettings,

        /// <summary>
        /// Enum Analyticsreportingsettings for "AnalyticsReportingSettings"
        /// </summary>
        [EnumMember(Value = "AnalyticsReportingSettings")]
        Analyticsreportingsettings,

        /// <summary>
        /// Enum Customcalculations for "CustomCalculations"
        /// </summary>
        [EnumMember(Value = "CustomCalculations")]
        Customcalculations,

        /// <summary>
        /// Enum Scheduledexports for "ScheduledExports"
        /// </summary>
        [EnumMember(Value = "ScheduledExports")]
        Scheduledexports,

        /// <summary>
        /// Enum Exports for "Exports"
        /// </summary>
        [EnumMember(Value = "Exports")]
        Exports,

        /// <summary>
        /// Enum Exportpdftemplates for "ExportPdfTemplates"
        /// </summary>
        [EnumMember(Value = "ExportPdfTemplates")]
        Exportpdftemplates,

        /// <summary>
        /// Enum Changerequest for "ChangeRequest"
        /// </summary>
        [EnumMember(Value = "ChangeRequest")]
        Changerequest,

        /// <summary>
        /// Enum Migration for "Migration"
        /// </summary>
        [EnumMember(Value = "Migration")]
        Migration,

        /// <summary>
        /// Enum Externalmetricsdefinition for "ExternalMetricsDefinition"
        /// </summary>
        [EnumMember(Value = "ExternalMetricsDefinition")]
        Externalmetricsdefinition,

        /// <summary>
        /// Enum Externalmetricsdata for "ExternalMetricsData"
        /// </summary>
        [EnumMember(Value = "ExternalMetricsData")]
        Externalmetricsdata,

        /// <summary>
        /// Enum Schema for "Schema"
        /// </summary>
        [EnumMember(Value = "Schema")]
        Schema,

        /// <summary>
        /// Enum Row for "Row"
        /// </summary>
        [EnumMember(Value = "Row")]
        Row,

        /// <summary>
        /// Enum Bulk for "Bulk"
        /// </summary>
        [EnumMember(Value = "Bulk")]
        Bulk,

        /// <summary>
        /// Enum Supportedcontent for "SupportedContent"
        /// </summary>
        [EnumMember(Value = "SupportedContent")]
        Supportedcontent,

        /// <summary>
        /// Enum Conversationphonenumber for "ConversationPhoneNumber"
        /// </summary>
        [EnumMember(Value = "ConversationPhoneNumber")]
        Conversationphonenumber,

        /// <summary>
        /// Enum Conversationrecipient for "ConversationRecipient"
        /// </summary>
        [EnumMember(Value = "ConversationRecipient")]
        Conversationrecipient,

        /// <summary>
        /// Enum Conversationaccount for "ConversationAccount"
        /// </summary>
        [EnumMember(Value = "ConversationAccount")]
        Conversationaccount,

        /// <summary>
        /// Enum Conversationdefaultsupportedcontent for "ConversationDefaultSupportedContent"
        /// </summary>
        [EnumMember(Value = "ConversationDefaultSupportedContent")]
        Conversationdefaultsupportedcontent,

        /// <summary>
        /// Enum Conversationthreadingwindow for "ConversationThreadingWindow"
        /// </summary>
        [EnumMember(Value = "ConversationThreadingWindow")]
        Conversationthreadingwindow,

        /// <summary>
        /// Enum Deployment for "Deployment"
        /// </summary>
        [EnumMember(Value = "Deployment")]
        Deployment,

        /// <summary>
        /// Enum Configuration for "Configuration"
        /// </summary>
        [EnumMember(Value = "Configuration")]
        Configuration,

        /// <summary>
        /// Enum Configurationversion for "ConfigurationVersion"
        /// </summary>
        [EnumMember(Value = "ConfigurationVersion")]
        Configurationversion,

        /// <summary>
        /// Enum Edgepreferences for "EdgePreferences"
        /// </summary>
        [EnumMember(Value = "EdgePreferences")]
        Edgepreferences,

        /// <summary>
        /// Enum Edgetracelevel for "EdgeTraceLevel"
        /// </summary>
        [EnumMember(Value = "EdgeTraceLevel")]
        Edgetracelevel,

        /// <summary>
        /// Enum Organizationintegrationsaccess for "OrganizationIntegrationsAccess"
        /// </summary>
        [EnumMember(Value = "OrganizationIntegrationsAccess")]
        Organizationintegrationsaccess,

        /// <summary>
        /// Enum Supportfile for "SupportFile"
        /// </summary>
        [EnumMember(Value = "SupportFile")]
        Supportfile,

        /// <summary>
        /// Enum Edgelogzip for "EdgeLogZip"
        /// </summary>
        [EnumMember(Value = "EdgeLogZip")]
        Edgelogzip,

        /// <summary>
        /// Enum Pcaps for "Pcaps"
        /// </summary>
        [EnumMember(Value = "Pcaps")]
        Pcaps,

        /// <summary>
        /// Enum Mediadiagnosticstracefile for "MediaDiagnosticsTraceFile"
        /// </summary>
        [EnumMember(Value = "MediaDiagnosticsTraceFile")]
        Mediadiagnosticstracefile,

        /// <summary>
        /// Enum Edgepcaps for "EdgePcaps"
        /// </summary>
        [EnumMember(Value = "EdgePcaps")]
        Edgepcaps,

        /// <summary>
        /// Enum Edgelog for "EdgeLog"
        /// </summary>
        [EnumMember(Value = "EdgeLog")]
        Edgelog,

        /// <summary>
        /// Enum Organizationfeature for "OrganizationFeature"
        /// </summary>
        [EnumMember(Value = "OrganizationFeature")]
        Organizationfeature,

        /// <summary>
        /// Enum Product for "Product"
        /// </summary>
        [EnumMember(Value = "Product")]
        Product,

        /// <summary>
        /// Enum User for "User"
        /// </summary>
        [EnumMember(Value = "User")]
        User,

        /// <summary>
        /// Enum Location for "Location"
        /// </summary>
        [EnumMember(Value = "Location")]
        Location,

        /// <summary>
        /// Enum Conversation for "Conversation"
        /// </summary>
        [EnumMember(Value = "Conversation")]
        Conversation,

        /// <summary>
        /// Enum Organizationsuspension for "OrganizationSuspension"
        /// </summary>
        [EnumMember(Value = "OrganizationSuspension")]
        Organizationsuspension,

        /// <summary>
        /// Enum Operationalevent for "OperationalEvent"
        /// </summary>
        [EnumMember(Value = "OperationalEvent")]
        Operationalevent,

        /// <summary>
        /// Enum Participant for "Participant"
        /// </summary>
        [EnumMember(Value = "Participant")]
        Participant,

        /// <summary>
        /// Enum Contactschema for "ContactSchema"
        /// </summary>
        [EnumMember(Value = "ContactSchema")]
        Contactschema,

        /// <summary>
        /// Enum Externalorganizationschema for "ExternalOrganizationSchema"
        /// </summary>
        [EnumMember(Value = "ExternalOrganizationSchema")]
        Externalorganizationschema,

        /// <summary>
        /// Enum Workbin for "Workbin"
        /// </summary>
        [EnumMember(Value = "Workbin")]
        Workbin,

        /// <summary>
        /// Enum Worktype for "Worktype"
        /// </summary>
        [EnumMember(Value = "Worktype")]
        Worktype,

        /// <summary>
        /// Enum Bulkjob for "BulkJob"
        /// </summary>
        [EnumMember(Value = "BulkJob")]
        Bulkjob,

        /// <summary>
        /// Enum Credential for "Credential"
        /// </summary>
        [EnumMember(Value = "Credential")]
        Credential,

        /// <summary>
        /// Enum Numberorder for "NumberOrder"
        /// </summary>
        [EnumMember(Value = "NumberOrder")]
        Numberorder,

        /// <summary>
        /// Enum Enterpriseagreement for "EnterpriseAgreement"
        /// </summary>
        [EnumMember(Value = "EnterpriseAgreement")]
        Enterpriseagreement,

        /// <summary>
        /// Enum Vendorlisting for "VendorListing"
        /// </summary>
        [EnumMember(Value = "VendorListing")]
        Vendorlisting,

        /// <summary>
        /// Enum Gdprrequest for "GdprRequest"
        /// </summary>
        [EnumMember(Value = "GdprRequest")]
        Gdprrequest,

        /// <summary>
        /// Enum Exportrequest for "ExportRequest"
        /// </summary>
        [EnumMember(Value = "ExportRequest")]
        Exportrequest,

        /// <summary>
        /// Enum Defaultpanelsettings for "DefaultPanelSettings"
        /// </summary>
        [EnumMember(Value = "DefaultPanelSettings")]
        Defaultpanelsettings,

        /// <summary>
        /// Enum Inbounddomain for "InboundDomain"
        /// </summary>
        [EnumMember(Value = "InboundDomain")]
        Inbounddomain,

        /// <summary>
        /// Enum Outbounddomain for "OutboundDomain"
        /// </summary>
        [EnumMember(Value = "OutboundDomain")]
        Outbounddomain,

        /// <summary>
        /// Enum Inboundroute for "InboundRoute"
        /// </summary>
        [EnumMember(Value = "InboundRoute")]
        Inboundroute,

        /// <summary>
        /// Enum Organizationlimits for "OrganizationLimits"
        /// </summary>
        [EnumMember(Value = "OrganizationLimits")]
        Organizationlimits,

        /// <summary>
        /// Enum Composerpage for "ComposerPage"
        /// </summary>
        [EnumMember(Value = "ComposerPage")]
        Composerpage,

        /// <summary>
        /// Enum Composerpublishedscript for "ComposerPublishedScript"
        /// </summary>
        [EnumMember(Value = "ComposerPublishedScript")]
        Composerpublishedscript,

        /// <summary>
        /// Enum Composerscript for "ComposerScript"
        /// </summary>
        [EnumMember(Value = "ComposerScript")]
        Composerscript,

        /// <summary>
        /// Enum Composertemplate for "ComposerTemplate"
        /// </summary>
        [EnumMember(Value = "ComposerTemplate")]
        Composertemplate,

        /// <summary>
        /// Enum Intentminer for "IntentMiner"
        /// </summary>
        [EnumMember(Value = "IntentMiner")]
        Intentminer,

        /// <summary>
        /// Enum Topicminer for "TopicMiner"
        /// </summary>
        [EnumMember(Value = "TopicMiner")]
        Topicminer,

        /// <summary>
        /// Enum Softsuspension for "SoftSuspension"
        /// </summary>
        [EnumMember(Value = "SoftSuspension")]
        Softsuspension,

        /// <summary>
        /// Enum Journeyview for "JourneyView"
        /// </summary>
        [EnumMember(Value = "JourneyView")]
        Journeyview,

        /// <summary>
        /// Enum Customentity for "CustomEntity"
        /// </summary>
        [EnumMember(Value = "CustomEntity")]
        Customentity,

        /// <summary>
        /// Enum Directoryfeature for "DirectoryFeature"
        /// </summary>
        [EnumMember(Value = "DirectoryFeature")]
        Directoryfeature,

        /// <summary>
        /// Enum Rulecategory for "RuleCategory"
        /// </summary>
        [EnumMember(Value = "RuleCategory")]
        Rulecategory,

        /// <summary>
        /// Enum Decisiontable for "DecisionTable"
        /// </summary>
        [EnumMember(Value = "DecisionTable")]
        Decisiontable,

        /// <summary>
        /// Enum Decisiontableversion for "DecisionTableVersion"
        /// </summary>
        [EnumMember(Value = "DecisionTableVersion")]
        Decisiontableversion,

        /// <summary>
        /// Enum Decisiontablerow for "DecisionTableRow"
        /// </summary>
        [EnumMember(Value = "DecisionTableRow")]
        Decisiontablerow,

        /// <summary>
        /// Enum Escalationrule for "EscalationRule"
        /// </summary>
        [EnumMember(Value = "EscalationRule")]
        Escalationrule
    }
}
