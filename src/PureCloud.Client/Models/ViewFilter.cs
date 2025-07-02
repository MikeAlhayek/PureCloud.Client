using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ViewFilter
{
    /// <summary>
    /// Filter to indicate the availability of the dashboard is public or private.
    /// </summary>
    /// <value>Filter to indicate the availability of the dashboard is public or private.</value>
    public ViewFilterAvailableDashboardEnum? AvailableDashboard { get; set; }

    /// <summary>
    /// The user supplied state value in the view
    /// </summary>
    /// <value>The user supplied state value in the view</value>
    public ViewFilterUserStateEnum? UserState { get; set; }

    /// <summary>
    /// The state of dashboard being filtered
    /// </summary>
    /// <value>The state of dashboard being filtered</value>
    public ViewFilterDashboardStateEnum? DashboardState { get; set; }

    /// <summary>
    /// The type of dashboard being filtered
    /// </summary>
    /// <value>The type of dashboard being filtered</value>
    public ViewFilterDashboardTypeEnum? DashboardType { get; set; }

    /// <summary>
    /// The type of dashboard access being filtered
    /// </summary>
    /// <value>The type of dashboard access being filtered</value>
    public ViewFilterDashboardAccessFilterEnum? DashboardAccessFilter { get; set; }

    /// <summary>
    /// Sets the role when viewing agent evaluations
    /// </summary>
    /// <value>Sets the role when viewing agent evaluations</value>
    public ViewFilterEvaluationRoleEnum? EvaluationRole { get; set; }

    /// <summary>
    /// The media types are used to filter the view
    /// </summary>
    /// <value>The media types are used to filter the view</value>
    public IEnumerable<ViewFilterMediaTypesEnum> MediaTypes { get; set; }

    /// <summary>
    /// The queue ids are used to filter the view
    /// </summary>
    /// <value>The queue ids are used to filter the view</value>
    public IEnumerable<string> QueueIds { get; set; }

    /// <summary>
    /// The skill ids are used to filter the view
    /// </summary>
    /// <value>The skill ids are used to filter the view</value>
    public IEnumerable<string> SkillIds { get; set; }

    /// <summary>
    /// The assigned user skill ids are used to filter the view
    /// </summary>
    /// <value>The assigned user skill ids are used to filter the view</value>
    public IEnumerable<string> AssignedSkillIds { get; set; }

    /// <summary>
    /// The skill groups used to filter the view
    /// </summary>
    /// <value>The skill groups used to filter the view</value>
    public IEnumerable<string> SkillGroups { get; set; }

    /// <summary>
    /// The language ids are used to filter the view
    /// </summary>
    /// <value>The language ids are used to filter the view</value>
    public IEnumerable<string> LanguageIds { get; set; }

    /// <summary>
    /// The assigned user language ids are used to filter the view
    /// </summary>
    /// <value>The assigned user language ids are used to filter the view</value>
    public IEnumerable<string> AssignedLanguageIds { get; set; }

    /// <summary>
    /// The language groups used to filter the view
    /// </summary>
    /// <value>The language groups used to filter the view</value>
    public IEnumerable<string> LanguageGroups { get; set; }

    /// <summary>
    /// The directions are used to filter the view
    /// </summary>
    /// <value>The directions are used to filter the view</value>
    public IEnumerable<ViewFilterDirectionsEnum> Directions { get; set; }

    /// <summary>
    /// The list of orginating directions used to filter the view
    /// </summary>
    /// <value>The list of orginating directions used to filter the view</value>
    public IEnumerable<ViewFilterOriginatingDirectionsEnum> OriginatingDirections { get; set; }

    /// <summary>
    /// The wrap up codes are used to filter the view
    /// </summary>
    /// <value>The wrap up codes are used to filter the view</value>
    public IEnumerable<string> WrapUpCodes { get; set; }

    /// <summary>
    /// The dnis list is used to filter the view
    /// </summary>
    /// <value>The dnis list is used to filter the view</value>
    public IEnumerable<string> DnisList { get; set; }

    /// <summary>
    /// The list of session dnis used to filter the view
    /// </summary>
    /// <value>The list of session dnis used to filter the view</value>
    public IEnumerable<string> SessionDnisList { get; set; }

    /// <summary>
    /// The user ids are used to fetch associated queues for the view
    /// </summary>
    /// <value>The user ids are used to fetch associated queues for the view</value>
    public IEnumerable<string> FilterQueuesByUserIds { get; set; }

    /// <summary>
    /// The queue ids are used to fetch associated users for the view
    /// </summary>
    /// <value>The queue ids are used to fetch associated users for the view</value>
    public IEnumerable<string> FilterUsersByQueueIds { get; set; }

    /// <summary>
    /// The user ids are used to filter the view
    /// </summary>
    /// <value>The user ids are used to filter the view</value>
    public IEnumerable<string> UserIds { get; set; }

    /// <summary>
    /// The management unit ids are used to filter the view
    /// </summary>
    /// <value>The management unit ids are used to filter the view</value>
    public IEnumerable<string> ManagementUnitIds { get; set; }

    /// <summary>
    /// The address To values are used to filter the view
    /// </summary>
    /// <value>The address To values are used to filter the view</value>
    public IEnumerable<string> AddressTos { get; set; }

    /// <summary>
    /// The address from values are used to filter the view
    /// </summary>
    /// <value>The address from values are used to filter the view</value>
    public IEnumerable<string> AddressFroms { get; set; }

    /// <summary>
    /// The outbound campaign ids are used to filter the view
    /// </summary>
    /// <value>The outbound campaign ids are used to filter the view</value>
    public IEnumerable<string> OutboundCampaignIds { get; set; }

    /// <summary>
    /// The outbound contact list ids are used to filter the view
    /// </summary>
    /// <value>The outbound contact list ids are used to filter the view</value>
    public IEnumerable<string> OutboundContactListIds { get; set; }

    /// <summary>
    /// The contact ids are used to filter the view
    /// </summary>
    /// <value>The contact ids are used to filter the view</value>
    public IEnumerable<string> ContactIds { get; set; }

    /// <summary>
    /// The external contact ids are used to filter the view
    /// </summary>
    /// <value>The external contact ids are used to filter the view</value>
    public IEnumerable<string> ExternalContactIds { get; set; }

    /// <summary>
    /// The external org ids are used to filter the view
    /// </summary>
    /// <value>The external org ids are used to filter the view</value>
    public IEnumerable<string> ExternalOrgIds { get; set; }

    /// <summary>
    /// The ani list ids are used to filter the view
    /// </summary>
    /// <value>The ani list ids are used to filter the view</value>
    public IEnumerable<string> AniList { get; set; }

    /// <summary>
    /// The durations in milliseconds used to filter the view
    /// </summary>
    /// <value>The durations in milliseconds used to filter the view</value>
    public IEnumerable<NumericRange> DurationsMilliseconds { get; set; }

    /// <summary>
    /// The acd durations in milliseconds used to filter the view
    /// </summary>
    /// <value>The acd durations in milliseconds used to filter the view</value>
    public IEnumerable<NumericRange> AcdDurationsMilliseconds { get; set; }

    /// <summary>
    /// The talk durations in milliseconds used to filter the view
    /// </summary>
    /// <value>The talk durations in milliseconds used to filter the view</value>
    public IEnumerable<NumericRange> TalkDurationsMilliseconds { get; set; }

    /// <summary>
    /// The acw durations in milliseconds used to filter the view
    /// </summary>
    /// <value>The acw durations in milliseconds used to filter the view</value>
    public IEnumerable<NumericRange> AcwDurationsMilliseconds { get; set; }

    /// <summary>
    /// The handle durations in milliseconds used to filter the view
    /// </summary>
    /// <value>The handle durations in milliseconds used to filter the view</value>
    public IEnumerable<NumericRange> HandleDurationsMilliseconds { get; set; }

    /// <summary>
    /// The hold durations in milliseconds used to filter the view
    /// </summary>
    /// <value>The hold durations in milliseconds used to filter the view</value>
    public IEnumerable<NumericRange> HoldDurationsMilliseconds { get; set; }

    /// <summary>
    /// The abandon durations in milliseconds used to filter the view
    /// </summary>
    /// <value>The abandon durations in milliseconds used to filter the view</value>
    public IEnumerable<NumericRange> AbandonDurationsMilliseconds { get; set; }

    /// <summary>
    /// The evaluationScore is used to filter the view
    /// </summary>
    /// <value>The evaluationScore is used to filter the view</value>
    public NumericRange EvaluationScore { get; set; }

    /// <summary>
    /// The evaluationCriticalScore is used to filter the view
    /// </summary>
    /// <value>The evaluationCriticalScore is used to filter the view</value>
    public NumericRange EvaluationCriticalScore { get; set; }

    /// <summary>
    /// The evaluation form ids are used to filter the view
    /// </summary>
    /// <value>The evaluation form ids are used to filter the view</value>
    public IEnumerable<string> EvaluationFormIds { get; set; }

    /// <summary>
    /// The evaluated agent ids are used to filter the view
    /// </summary>
    /// <value>The evaluated agent ids are used to filter the view</value>
    public IEnumerable<string> EvaluatedAgentIds { get; set; }

    /// <summary>
    /// The evaluator ids are used to filter the view
    /// </summary>
    /// <value>The evaluator ids are used to filter the view</value>
    public IEnumerable<string> EvaluatorIds { get; set; }

    /// <summary>
    /// Indicates filtering for transfers
    /// </summary>
    /// <value>Indicates filtering for transfers</value>
    public bool? Transferred { get; set; }

    /// <summary>
    /// Indicates filtering for abandons
    /// </summary>
    /// <value>Indicates filtering for abandons</value>
    public bool? Abandoned { get; set; }

    /// <summary>
    /// Indicates filtering for answered interactions
    /// </summary>
    /// <value>Indicates filtering for answered interactions</value>
    public bool? Answered { get; set; }

    /// <summary>
    /// The message media types used to filter the view
    /// </summary>
    /// <value>The message media types used to filter the view</value>
    public IEnumerable<ViewFilterMessageTypesEnum> MessageTypes { get; set; }

    /// <summary>
    /// The divison Ids used to filter the view
    /// </summary>
    /// <value>The divison Ids used to filter the view</value>
    public IEnumerable<string> DivisionIds { get; set; }

    /// <summary>
    /// The survey form ids used to filter the view
    /// </summary>
    /// <value>The survey form ids used to filter the view</value>
    public IEnumerable<string> SurveyFormIds { get; set; }

    /// <summary>
    /// The survey total score used to filter the view
    /// </summary>
    /// <value>The survey total score used to filter the view</value>
    public NumericRange SurveyTotalScore { get; set; }

    /// <summary>
    /// The survey NPS score used to filter the view
    /// </summary>
    /// <value>The survey NPS score used to filter the view</value>
    public NumericRange SurveyNpsScore { get; set; }

    /// <summary>
    /// The desired range for mos values
    /// </summary>
    /// <value>The desired range for mos values</value>
    public NumericRange Mos { get; set; }

    /// <summary>
    /// The survey question group score used to filter the view
    /// </summary>
    /// <value>The survey question group score used to filter the view</value>
    public NumericRange SurveyQuestionGroupScore { get; set; }

    /// <summary>
    /// The survey promoter score used to filter the view
    /// </summary>
    /// <value>The survey promoter score used to filter the view</value>
    public NumericRange SurveyPromoterScore { get; set; }

    /// <summary>
    /// The list of survey form context ids used to filter the view
    /// </summary>
    /// <value>The list of survey form context ids used to filter the view</value>
    public IEnumerable<string> SurveyFormContextIds { get; set; }

    /// <summary>
    /// The list of conversation ids used to filter the view
    /// </summary>
    /// <value>The list of conversation ids used to filter the view</value>
    public IEnumerable<string> ConversationIds { get; set; }

    /// <summary>
    /// The list of SIP call ids used to filter the view
    /// </summary>
    /// <value>The list of SIP call ids used to filter the view</value>
    public IEnumerable<string> SipCallIds { get; set; }

    /// <summary>
    /// Indicates filtering for ended
    /// </summary>
    /// <value>Indicates filtering for ended</value>
    public bool? IsEnded { get; set; }

    /// <summary>
    /// Indicates filtering for survey
    /// </summary>
    /// <value>Indicates filtering for survey</value>
    public bool? IsSurveyed { get; set; }

    /// <summary>
    /// The list of survey score ranges used to filter the view
    /// </summary>
    /// <value>The list of survey score ranges used to filter the view</value>
    public IEnumerable<NumericRange> SurveyScores { get; set; }

    /// <summary>
    /// The list of promoter score ranges used to filter the view
    /// </summary>
    /// <value>The list of promoter score ranges used to filter the view</value>
    public IEnumerable<NumericRange> PromoterScores { get; set; }

    /// <summary>
    /// Indicates filtering for campaign
    /// </summary>
    /// <value>Indicates filtering for campaign</value>
    public bool? IsCampaign { get; set; }

    /// <summary>
    /// The list of survey statuses used to filter the view
    /// </summary>
    /// <value>The list of survey statuses used to filter the view</value>
    public IEnumerable<string> SurveyStatuses { get; set; }

    /// <summary>
    /// A grouping of conversation level filters
    /// </summary>
    /// <value>A grouping of conversation level filters</value>
    public ConversationProperties ConversationProperties { get; set; }

    /// <summary>
    /// Indicates filtering for blind transferred
    /// </summary>
    /// <value>Indicates filtering for blind transferred</value>
    public bool? IsBlindTransferred { get; set; }

    /// <summary>
    /// Indicates filtering for consulted
    /// </summary>
    /// <value>Indicates filtering for consulted</value>
    public bool? IsConsulted { get; set; }

    /// <summary>
    /// Indicates filtering for consult transferred
    /// </summary>
    /// <value>Indicates filtering for consult transferred</value>
    public bool? IsConsultTransferred { get; set; }

    /// <summary>
    /// The list of remote participants used to filter the view
    /// </summary>
    /// <value>The list of remote participants used to filter the view</value>
    public IEnumerable<string> RemoteParticipants { get; set; }

    /// <summary>
    /// The list of flow Ids
    /// </summary>
    /// <value>The list of flow Ids</value>
    public IEnumerable<string> FlowIds { get; set; }

    /// <summary>
    /// A list of outcome ids of the flow
    /// </summary>
    /// <value>A list of outcome ids of the flow</value>
    public IEnumerable<string> FlowOutcomeIds { get; set; }

    /// <summary>
    /// A list of outcome values of the flow
    /// </summary>
    /// <value>A list of outcome values of the flow</value>
    public IEnumerable<ViewFilterFlowOutcomeValuesEnum> FlowOutcomeValues { get; set; }

    /// <summary>
    /// The list of destination types of the flow
    /// </summary>
    /// <value>The list of destination types of the flow</value>
    public IEnumerable<ViewFilterFlowDestinationTypesEnum> FlowDestinationTypes { get; set; }

    /// <summary>
    /// The list of reasons for the flow to disconnect
    /// </summary>
    /// <value>The list of reasons for the flow to disconnect</value>
    public IEnumerable<ViewFilterFlowDisconnectReasonsEnum> FlowDisconnectReasons { get; set; }

    /// <summary>
    /// A list of types of the flow
    /// </summary>
    /// <value>A list of types of the flow</value>
    public IEnumerable<ViewFilterFlowTypesEnum> FlowTypes { get; set; }

    /// <summary>
    /// A list of types of the flow entry
    /// </summary>
    /// <value>A list of types of the flow entry</value>
    public IEnumerable<ViewFilterFlowEntryTypesEnum> FlowEntryTypes { get; set; }

    /// <summary>
    /// A list of reasons of flow entry
    /// </summary>
    /// <value>A list of reasons of flow entry</value>
    public IEnumerable<string> FlowEntryReasons { get; set; }

    /// <summary>
    /// A list of versions of a flow
    /// </summary>
    /// <value>A list of versions of a flow</value>
    public IEnumerable<string> FlowVersions { get; set; }

    /// <summary>
    /// A list of directory group ids
    /// </summary>
    /// <value>A list of directory group ids</value>
    public IEnumerable<string> GroupIds { get; set; }

    /// <summary>
    /// Indicates filtering for journey customer id
    /// </summary>
    /// <value>Indicates filtering for journey customer id</value>
    public bool? HasJourneyCustomerId { get; set; }

    /// <summary>
    /// Indicates filtering for Journey action map id
    /// </summary>
    /// <value>Indicates filtering for Journey action map id</value>
    public bool? HasJourneyActionMapId { get; set; }

    /// <summary>
    /// Indicates filtering for Journey visit id
    /// </summary>
    /// <value>Indicates filtering for Journey visit id</value>
    public bool? HasJourneyVisitId { get; set; }

    /// <summary>
    /// Indicates filtering for presence of MMS media
    /// </summary>
    /// <value>Indicates filtering for presence of MMS media</value>
    public bool? HasMedia { get; set; }

    /// <summary>
    /// The role Ids used to filter the view
    /// </summary>
    /// <value>The role Ids used to filter the view</value>
    public IEnumerable<string> RoleIds { get; set; }

    /// <summary>
    /// The report to user IDs used to filter the view
    /// </summary>
    /// <value>The report to user IDs used to filter the view</value>
    public IEnumerable<string> ReportsTos { get; set; }

    /// <summary>
    /// The location Ids used to filter the view
    /// </summary>
    /// <value>The location Ids used to filter the view</value>
    public IEnumerable<string> LocationIds { get; set; }

    /// <summary>
    /// A list of flow out types
    /// </summary>
    /// <value>A list of flow out types</value>
    public IEnumerable<string> FlowOutTypes { get; set; }

    /// <summary>
    /// A list of providers
    /// </summary>
    /// <value>A list of providers</value>
    public IEnumerable<string> ProviderList { get; set; }

    /// <summary>
    /// A list of callback numbers or substrings of numbers (ex: [\&quot;317\&quot;, \&quot;13172222222\&quot;])
    /// </summary>
    /// <value>A list of callback numbers or substrings of numbers (ex: [\&quot;317\&quot;, \&quot;13172222222\&quot;])</value>
    public IEnumerable<string> CallbackNumberList { get; set; }

    /// <summary>
    /// An interval of time to filter for scheduled callbacks. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss
    /// </summary>
    /// <value>An interval of time to filter for scheduled callbacks. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss</value>
    public string CallbackInterval { get; set; }

    /// <summary>
    /// A list of routing types used
    /// </summary>
    /// <value>A list of routing types used</value>
    public IEnumerable<ViewFilterUsedRoutingTypesEnum> UsedRoutingTypes { get; set; }

    /// <summary>
    /// A list of routing types requested
    /// </summary>
    /// <value>A list of routing types requested</value>
    public IEnumerable<ViewFilterRequestedRoutingTypesEnum> RequestedRoutingTypes { get; set; }

    /// <summary>
    /// Indicates filtering for agent assist id
    /// </summary>
    /// <value>Indicates filtering for agent assist id</value>
    public bool? HasAgentAssistId { get; set; }

    /// <summary>
    /// A list of transcript contents requested
    /// </summary>
    /// <value>A list of transcript contents requested</value>
    public IEnumerable<Transcripts> Transcripts { get; set; }

    /// <summary>
    /// A list of transcript languages requested
    /// </summary>
    /// <value>A list of transcript languages requested</value>
    public IEnumerable<string> TranscriptLanguages { get; set; }

    /// <summary>
    /// A list of participant purpose requested
    /// </summary>
    /// <value>A list of participant purpose requested</value>
    public IEnumerable<ViewFilterParticipantPurposesEnum> ParticipantPurposes { get; set; }

    /// <summary>
    /// Indicates filtering for first queue data
    /// </summary>
    /// <value>Indicates filtering for first queue data</value>
    public bool? ShowFirstQueue { get; set; }

    /// <summary>
    /// The team ids used to filter the view data
    /// </summary>
    /// <value>The team ids used to filter the view data</value>
    public IEnumerable<string> TeamIds { get; set; }

    /// <summary>
    /// The team ids are used to fetch associated users for the view
    /// </summary>
    /// <value>The team ids are used to fetch associated users for the view</value>
    public IEnumerable<string> FilterUsersByTeamIds { get; set; }

    /// <summary>
    /// The journey action map ids are used to fetch action maps for the associated view
    /// </summary>
    /// <value>The journey action map ids are used to fetch action maps for the associated view</value>
    public IEnumerable<string> JourneyActionMapIds { get; set; }

    /// <summary>
    /// The journey outcome ids are used to fetch outcomes for the associated view
    /// </summary>
    /// <value>The journey outcome ids are used to fetch outcomes for the associated view</value>
    public IEnumerable<string> JourneyOutcomeIds { get; set; }

    /// <summary>
    /// The journey segment ids are used to fetch segments for the associated view
    /// </summary>
    /// <value>The journey segment ids are used to fetch segments for the associated view</value>
    public IEnumerable<string> JourneySegmentIds { get; set; }

    /// <summary>
    /// The journey action map types are used to filter action map data for the associated view
    /// </summary>
    /// <value>The journey action map types are used to filter action map data for the associated view</value>
    public IEnumerable<ViewFilterJourneyActionMapTypesEnum> JourneyActionMapTypes { get; set; }

    /// <summary>
    /// The list of development roles used to filter agent development view
    /// </summary>
    /// <value>The list of development roles used to filter agent development view</value>
    public IEnumerable<ViewFilterDevelopmentRoleListEnum> DevelopmentRoleList { get; set; }

    /// <summary>
    /// The list of development types used to filter agent development view
    /// </summary>
    /// <value>The list of development types used to filter agent development view</value>
    public IEnumerable<ViewFilterDevelopmentTypeListEnum> DevelopmentTypeList { get; set; }

    /// <summary>
    /// The list of development status used to filter agent development view
    /// </summary>
    /// <value>The list of development status used to filter agent development view</value>
    public IEnumerable<ViewFilterDevelopmentStatusListEnum> DevelopmentStatusList { get; set; }

    /// <summary>
    /// The list of development moduleIds used to filter agent development view
    /// </summary>
    /// <value>The list of development moduleIds used to filter agent development view</value>
    public IEnumerable<string> DevelopmentModuleIds { get; set; }

    /// <summary>
    /// Indicates filtering for development activities
    /// </summary>
    /// <value>Indicates filtering for development activities</value>
    public bool? DevelopmentActivityOverdue { get; set; }

    /// <summary>
    /// The customer sentiment score used to filter the view
    /// </summary>
    /// <value>The customer sentiment score used to filter the view</value>
    public NumericRange CustomerSentimentScore { get; set; }

    /// <summary>
    /// The customer sentiment trend used to filter the view
    /// </summary>
    /// <value>The customer sentiment trend used to filter the view</value>
    public NumericRange CustomerSentimentTrend { get; set; }

    /// <summary>
    /// The list of transfer targets used to filter flow data
    /// </summary>
    /// <value>The list of transfer targets used to filter flow data</value>
    public IEnumerable<string> FlowTransferTargets { get; set; }

    /// <summary>
    /// Filter for development name
    /// </summary>
    /// <value>Filter for development name</value>
    public string DevelopmentName { get; set; }

    /// <summary>
    /// Represents the topics detected in the transcript
    /// </summary>
    /// <value>Represents the topics detected in the transcript</value>
    public IEnumerable<string> TopicIds { get; set; }

    /// <summary>
    /// The list of external Tags used to filter conversation data
    /// </summary>
    /// <value>The list of external Tags used to filter conversation data</value>
    public IEnumerable<string> ExternalTags { get; set; }

    /// <summary>
    /// Indicates filtering for not responding users
    /// </summary>
    /// <value>Indicates filtering for not responding users</value>
    public bool? IsNotResponding { get; set; }

    /// <summary>
    /// Indicates filtering for the authenticated chat
    /// </summary>
    /// <value>Indicates filtering for the authenticated chat</value>
    public bool? IsAuthenticated { get; set; }

    /// <summary>
    /// The list of bot IDs used to filter bot views
    /// </summary>
    /// <value>The list of bot IDs used to filter bot views</value>
    public IEnumerable<string> BotIds { get; set; }

    /// <summary>
    /// The list of bot versions used to filter bot views
    /// </summary>
    /// <value>The list of bot versions used to filter bot views</value>
    public IEnumerable<string> BotVersions { get; set; }

    /// <summary>
    /// The list of bot message types used to filter bot views
    /// </summary>
    /// <value>The list of bot message types used to filter bot views</value>
    public IEnumerable<ViewFilterBotMessageTypesEnum> BotMessageTypes { get; set; }

    /// <summary>
    /// The list of bot providers used to filter bot views
    /// </summary>
    /// <value>The list of bot providers used to filter bot views</value>
    public IEnumerable<ViewFilterBotProviderListEnum> BotProviderList { get; set; }

    /// <summary>
    /// The list of bot products used to filter bot views
    /// </summary>
    /// <value>The list of bot products used to filter bot views</value>
    public IEnumerable<ViewFilterBotProductListEnum> BotProductList { get; set; }

    /// <summary>
    /// The list of bot recognition failure reasons used to filter bot views
    /// </summary>
    /// <value>The list of bot recognition failure reasons used to filter bot views</value>
    public IEnumerable<ViewFilterBotRecognitionFailureReasonListEnum> BotRecognitionFailureReasonList { get; set; }

    /// <summary>
    /// The list of bot intents used to filter bot views
    /// </summary>
    /// <value>The list of bot intents used to filter bot views</value>
    public IEnumerable<string> BotIntentList { get; set; }

    /// <summary>
    /// The list of bot final intents used to filter bot views
    /// </summary>
    /// <value>The list of bot final intents used to filter bot views</value>
    public IEnumerable<string> BotFinalIntentList { get; set; }

    /// <summary>
    /// The list of bot slots used to filter bot views
    /// </summary>
    /// <value>The list of bot slots used to filter bot views</value>
    public IEnumerable<string> BotSlotList { get; set; }

    /// <summary>
    /// The list of bot results used to filter bot views
    /// </summary>
    /// <value>The list of bot results used to filter bot views</value>
    public IEnumerable<ViewFilterBotResultListEnum> BotResultList { get; set; }

    /// <summary>
    /// The list of blocked reason used to filter action map constraints views
    /// </summary>
    /// <value>The list of blocked reason used to filter action map constraints views</value>
    public IEnumerable<ViewFilterBlockedReasonsEnum> BlockedReasons { get; set; }

    /// <summary>
    /// Indicates filtering for recorded
    /// </summary>
    /// <value>Indicates filtering for recorded</value>
    public bool? IsRecorded { get; set; }

    /// <summary>
    /// Indicates filtering for evaluation
    /// </summary>
    /// <value>Indicates filtering for evaluation</value>
    public bool? HasEvaluation { get; set; }

    /// <summary>
    /// Indicates filtering for scored evaluation
    /// </summary>
    /// <value>Indicates filtering for scored evaluation</value>
    public bool? HasScoredEvaluation { get; set; }

    /// <summary>
    /// The list of email delivery statuses used to filter views
    /// </summary>
    /// <value>The list of email delivery statuses used to filter views</value>
    public IEnumerable<ViewFilterEmailDeliveryStatusListEnum> EmailDeliveryStatusList { get; set; }

    /// <summary>
    /// Indicates filtering for agent owned callback interactions
    /// </summary>
    /// <value>Indicates filtering for agent owned callback interactions</value>
    public bool? IsAgentOwnedCallback { get; set; }

    /// <summary>
    /// The list of callback owners used to filter interactions
    /// </summary>
    /// <value>The list of callback owners used to filter interactions</value>
    public IEnumerable<string> AgentCallbackOwnerIds { get; set; }

    /// <summary>
    /// The list of transcript topics requested in filter
    /// </summary>
    /// <value>The list of transcript topics requested in filter</value>
    public IEnumerable<TranscriptTopics> TranscriptTopics { get; set; }

    /// <summary>
    /// The list of frequency cap reasons to filter offer constraints
    /// </summary>
    /// <value>The list of frequency cap reasons to filter offer constraints</value>
    public IEnumerable<string> JourneyFrequencyCapReasons { get; set; }

    /// <summary>
    /// The list of blocking action maps to filter offer constraints
    /// </summary>
    /// <value>The list of blocking action maps to filter offer constraints</value>
    public IEnumerable<string> JourneyBlockingActionMapIds { get; set; }

    /// <summary>
    /// The list of action targets to filter offer constraints
    /// </summary>
    /// <value>The list of action targets to filter offer constraints</value>
    public IEnumerable<string> JourneyActionTargetIds { get; set; }

    /// <summary>
    /// The list of blocking schedule groups to filter offer constraints
    /// </summary>
    /// <value>The list of blocking schedule groups to filter offer constraints</value>
    public IEnumerable<string> JourneyBlockingScheduleGroupIds { get; set; }

    /// <summary>
    /// The list of emergency schedule groups to filter offer constraints
    /// </summary>
    /// <value>The list of emergency schedule groups to filter offer constraints</value>
    public IEnumerable<string> JourneyBlockingEmergencyScheduleGroupIds { get; set; }

    /// <summary>
    /// The list of url equal conditions to filter offer constraints
    /// </summary>
    /// <value>The list of url equal conditions to filter offer constraints</value>
    public IEnumerable<string> JourneyUrlEqualConditions { get; set; }

    /// <summary>
    /// The list of url not equal conditions to filter offer constraints
    /// </summary>
    /// <value>The list of url not equal conditions to filter offer constraints</value>
    public IEnumerable<string> JourneyUrlNotEqualConditions { get; set; }

    /// <summary>
    /// The list of url starts with conditions to filter offer constraints
    /// </summary>
    /// <value>The list of url starts with conditions to filter offer constraints</value>
    public IEnumerable<string> JourneyUrlStartsWithConditions { get; set; }

    /// <summary>
    /// The list of url ends with conditions to filter offer constraints
    /// </summary>
    /// <value>The list of url ends with conditions to filter offer constraints</value>
    public IEnumerable<string> JourneyUrlEndsWithConditions { get; set; }

    /// <summary>
    /// The list of url contains any conditions to filter offer constraints
    /// </summary>
    /// <value>The list of url contains any conditions to filter offer constraints</value>
    public IEnumerable<string> JourneyUrlContainsAnyConditions { get; set; }

    /// <summary>
    /// The list of url not contains any conditions to filter offer constraints
    /// </summary>
    /// <value>The list of url not contains any conditions to filter offer constraints</value>
    public IEnumerable<string> JourneyUrlNotContainsAnyConditions { get; set; }

    /// <summary>
    /// The list of url contains all conditions to filter offer constraints
    /// </summary>
    /// <value>The list of url contains all conditions to filter offer constraints</value>
    public IEnumerable<string> JourneyUrlContainsAllConditions { get; set; }

    /// <summary>
    /// The list of url not contains all conditions to filter offer constraints
    /// </summary>
    /// <value>The list of url not contains all conditions to filter offer constraints</value>
    public IEnumerable<string> JourneyUrlNotContainsAllConditions { get; set; }

    /// <summary>
    /// The list of flow milestones to filter exports
    /// </summary>
    /// <value>The list of flow milestones to filter exports</value>
    public IEnumerable<string> FlowMilestoneIds { get; set; }

    /// <summary>
    /// Filter to indicate if Agent passed assessment or not
    /// </summary>
    /// <value>Filter to indicate if Agent passed assessment or not</value>
    public bool? IsAssessmentPassed { get; set; }

    /// <summary>
    /// The list to filter based on Brands (Bot/User/Agent) or End User who initiated the first message in the conversation
    /// </summary>
    /// <value>The list to filter based on Brands (Bot/User/Agent) or End User who initiated the first message in the conversation</value>
    public IEnumerable<string> ConversationInitiators { get; set; }

    /// <summary>
    /// Indicates if the customer has participated in an initiated conversation
    /// </summary>
    /// <value>Indicates if the customer has participated in an initiated conversation</value>
    public bool? HasCustomerParticipated { get; set; }

    /// <summary>
    /// Filter to indicate if interaction was ACD or non-ACD
    /// </summary>
    /// <value>Filter to indicate if interaction was ACD or non-ACD</value>
    public bool? IsAcdInteraction { get; set; }

    /// <summary>
    /// Filters to indicate if interaction has FAX
    /// </summary>
    /// <value>Filters to indicate if interaction has FAX</value>
    public bool? HasFax { get; set; }

    /// <summary>
    /// The list of Data Action IDs 
    /// </summary>
    /// <value>The list of Data Action IDs </value>
    public IEnumerable<string> DataActionIds { get; set; }

    /// <summary>
    /// Deprecated - Please use integrationIds instead
    /// </summary>
    /// <value>Deprecated - Please use integrationIds instead</value>
    public string ActionCategoryName { get; set; }

    /// <summary>
    /// The list of integration IDs for Data Action
    /// </summary>
    /// <value>The list of integration IDs for Data Action</value>
    public IEnumerable<string> IntegrationIds { get; set; }

    /// <summary>
    /// The list of Response codes for Data Action
    /// </summary>
    /// <value>The list of Response codes for Data Action</value>
    public IEnumerable<string> ResponseStatuses { get; set; }

    /// <summary>
    /// Filter to indicate whether the dashboard is favorite or unfavorite.
    /// </summary>
    /// <value>Filter to indicate whether the dashboard is favorite or unfavorite.</value>
    public bool? FavouriteDashboard { get; set; }

    /// <summary>
    /// Filter to indicate the dashboard owned by the user.
    /// </summary>
    /// <value>Filter to indicate the dashboard owned by the user.</value>
    public bool? MyDashboard { get; set; }

    /// <summary>
    /// The list of agent errors that are related to station
    /// </summary>
    /// <value>The list of agent errors that are related to station</value>
    public IEnumerable<string> StationErrors { get; set; }

    /// <summary>
    /// The canonical contact ids are used to filter the view
    /// </summary>
    /// <value>The canonical contact ids are used to filter the view</value>
    public IEnumerable<string> CanonicalContactIds { get; set; }

    /// <summary>
    /// The list of Alert Rule IDs
    /// </summary>
    /// <value>The list of Alert Rule IDs</value>
    public IEnumerable<string> AlertRuleIds { get; set; }

    /// <summary>
    /// The list of Evaluation Form Context IDs
    /// </summary>
    /// <value>The list of Evaluation Form Context IDs</value>
    public IEnumerable<string> EvaluationFormContextIds { get; set; }

    /// <summary>
    /// The evaluation statuses that are used to filter the view
    /// </summary>
    /// <value>The evaluation statuses that are used to filter the view</value>
    public IEnumerable<ViewFilterEvaluationStatusesEnum> EvaluationStatuses { get; set; }

    /// <summary>
    /// The list of Workbin IDs
    /// </summary>
    /// <value>The list of Workbin IDs</value>
    public IEnumerable<string> WorkbinIds { get; set; }

    /// <summary>
    /// The list of Worktype IDs
    /// </summary>
    /// <value>The list of Worktype IDs</value>
    public IEnumerable<string> WorktypeIds { get; set; }

    /// <summary>
    /// The list of Workitem IDs
    /// </summary>
    /// <value>The list of Workitem IDs</value>
    public IEnumerable<string> WorkitemIds { get; set; }

    /// <summary>
    /// The list of Workitem Assignee IDs
    /// </summary>
    /// <value>The list of Workitem Assignee IDs</value>
    public IEnumerable<string> WorkitemAssigneeIds { get; set; }

    /// <summary>
    /// The list of Workitem Statuses IDs
    /// </summary>
    /// <value>The list of Workitem Statuses IDs</value>
    public IEnumerable<string> WorkitemStatuses { get; set; }

    /// <summary>
    /// Deprecated - Use hasPciData or hasPiiData instead.
    /// </summary>
    /// <value>Deprecated - Use hasPciData or hasPiiData instead.</value>
    public bool? IsAnalyzedForSensitiveData { get; set; }

    /// <summary>
    /// Deprecated. Use hasPciData or hasPiiData instead.
    /// </summary>
    /// <value>Deprecated. Use hasPciData or hasPiiData instead.</value>
    public bool? HasSensitiveData { get; set; }

    /// <summary>
    /// Filter to indicate the transcript contains Pci data.
    /// </summary>
    /// <value>Filter to indicate the transcript contains Pci data.</value>
    public bool? HasPciData { get; set; }

    /// <summary>
    /// Filter to indicate the transcript contains Pii data.
    /// </summary>
    /// <value>Filter to indicate the transcript contains Pii data.</value>
    public bool? HasPiiData { get; set; }

    /// <summary>
    /// Filter for Sub Path
    /// </summary>
    /// <value>Filter for Sub Path</value>
    public string SubPath { get; set; }

    /// <summary>
    /// Filter to indicate if the customer cleared the conversation.
    /// </summary>
    /// <value>Filter to indicate if the customer cleared the conversation.</value>
    public bool? IsClearedByCustomer { get; set; }

    /// <summary>
    /// The evaluation assignee ids that are used to filter the view.
    /// </summary>
    /// <value>The evaluation assignee ids that are used to filter the view.</value>
    public IEnumerable<string> EvaluationAssigneeIds { get; set; }

    /// <summary>
    /// Filter to indicate that the user has no assigned evaluation.
    /// </summary>
    /// <value>Filter to indicate that the user has no assigned evaluation.</value>
    public bool? EvaluationAssigned { get; set; }

    /// <summary>
    /// The assistant ids that are used to filter the view.
    /// </summary>
    /// <value>The assistant ids that are used to filter the view.</value>
    public IEnumerable<string> AssistantIds { get; set; }

    /// <summary>
    /// The knowledge base ids that are used to filter the view.
    /// </summary>
    /// <value>The knowledge base ids that are used to filter the view.</value>
    public IEnumerable<string> KnowledgeBaseIds { get; set; }

    /// <summary>
    /// Filter to indicate if the interactions are parked.
    /// </summary>
    /// <value>Filter to indicate if the interactions are parked.</value>
    public bool? IsParked { get; set; }

    /// <summary>
    /// The agentEmpathyScore is used to filter the view
    /// </summary>
    /// <value>The agentEmpathyScore is used to filter the view</value>
    public NumericRange AgentEmpathyScore { get; set; }

    /// <summary>
    /// The surveyTypes is used to filter the view
    /// </summary>
    /// <value>The surveyTypes is used to filter the view</value>
    public IEnumerable<ViewFilterSurveyTypesEnum> SurveyTypes { get; set; }

    /// <summary>
    /// The list of Survey Response Status
    /// </summary>
    public IEnumerable<ViewFilterSurveyResponseStatusesEnum> SurveyResponseStatuses { get; set; }

    /// <summary>
    /// The botFlowTypes is used to filter the view
    /// </summary>
    /// <value>The botFlowTypes is used to filter the view</value>
    public IEnumerable<ViewFilterBotFlowTypesEnum> BotFlowTypes { get; set; }

    /// <summary>
    /// The agent talk durations in milliseconds used to filter the view
    /// </summary>
    /// <value>The agent talk durations in milliseconds used to filter the view</value>
    public IEnumerable<NumericRange> AgentTalkDurationMilliseconds { get; set; }

    /// <summary>
    /// The customer talk durations in milliseconds used to filter the view
    /// </summary>
    /// <value>The customer talk durations in milliseconds used to filter the view</value>
    public IEnumerable<NumericRange> CustomerTalkDurationMilliseconds { get; set; }

    /// <summary>
    /// The overtalk durations in milliseconds used to filter the view
    /// </summary>
    /// <value>The overtalk durations in milliseconds used to filter the view</value>
    public IEnumerable<NumericRange> OvertalkDurationMilliseconds { get; set; }

    /// <summary>
    /// The silence durations in milliseconds used to filter the view
    /// </summary>
    /// <value>The silence durations in milliseconds used to filter the view</value>
    public IEnumerable<NumericRange> SilenceDurationMilliseconds { get; set; }

    /// <summary>
    /// The acd durations in milliseconds used to filter the view
    /// </summary>
    /// <value>The acd durations in milliseconds used to filter the view</value>
    public IEnumerable<NumericRange> AcdDurationMilliseconds { get; set; }

    /// <summary>
    /// The ivr durations in milliseconds used to filter the view
    /// </summary>
    /// <value>The ivr durations in milliseconds used to filter the view</value>
    public IEnumerable<NumericRange> IvrDurationMilliseconds { get; set; }

    /// <summary>
    /// The other (hold/music) durations in milliseconds used to filter the view
    /// </summary>
    /// <value>The other (hold/music) durations in milliseconds used to filter the view</value>
    public IEnumerable<NumericRange> OtherDurationMilliseconds { get; set; }

    /// <summary>
    /// The agent talk percentage used to filter the view
    /// </summary>
    /// <value>The agent talk percentage used to filter the view</value>
    public NumericRange AgentTalkPercentage { get; set; }

    /// <summary>
    /// The customer talk percentage used to filter the view
    /// </summary>
    /// <value>The customer talk percentage used to filter the view</value>
    public NumericRange CustomerTalkPercentage { get; set; }

    /// <summary>
    /// The overtalk percentage used to filter the view
    /// </summary>
    /// <value>The overtalk percentage used to filter the view</value>
    public NumericRange OvertalkPercentage { get; set; }

    /// <summary>
    /// The silence percentage used to filter the view
    /// </summary>
    /// <value>The silence percentage used to filter the view</value>
    public NumericRange SilencePercentage { get; set; }

    /// <summary>
    /// The acd percentage used to filter the view
    /// </summary>
    /// <value>The acd percentage used to filter the view</value>
    public NumericRange AcdPercentage { get; set; }

    /// <summary>
    /// The ivr percentage used to filter the view
    /// </summary>
    /// <value>The ivr percentage used to filter the view</value>
    public NumericRange IvrPercentage { get; set; }

    /// <summary>
    /// The other (hold/music percentage used to filter the view
    /// </summary>
    /// <value>The other (hold/music percentage used to filter the view</value>
    public NumericRange OtherPercentage { get; set; }

    /// <summary>
    /// The overtalk instance range used to filter the view
    /// </summary>
    /// <value>The overtalk instance range used to filter the view</value>
    public NumericRange OvertalkInstances { get; set; }

    /// <summary>
    /// Filter to indicate if the screen is recorded
    /// </summary>
    /// <value>Filter to indicate if the screen is recorded</value>
    public bool? IsScreenRecorded { get; set; }

    /// <summary>
    /// The list of Screen Monitor User Ids
    /// </summary>
    /// <value>The list of Screen Monitor User Ids</value>
    public IEnumerable<string> ScreenMonitorUserIds { get; set; }

    /// <summary>
    /// The transcript durations in milliseconds used to filter the view
    /// </summary>
    /// <value>The transcript durations in milliseconds used to filter the view</value>
    public IEnumerable<NumericRange> TranscriptDurationMilliseconds { get; set; }

    /// <summary>
    /// The list of workitem status with worktype
    /// </summary>
    /// <value>The list of workitem status with worktype</value>
    public IEnumerable<WorkitemStatusFilter> WorkitemsStatuses { get; set; }

    /// <summary>
    /// List of countries for social filtering
    /// </summary>
    /// <value>List of countries for social filtering</value>
    public IEnumerable<string> SocialCountries { get; set; }

    /// <summary>
    /// List of languages for social filtering
    /// </summary>
    /// <value>List of languages for social filtering</value>
    public IEnumerable<string> SocialLanguages { get; set; }

    /// <summary>
    /// List of channels for social filtering
    /// </summary>
    /// <value>List of channels for social filtering</value>
    public IEnumerable<ViewFilterSocialChannelsEnum> SocialChannels { get; set; }

    /// <summary>
    /// The sentiment of the social post
    /// </summary>
    /// <value>The sentiment of the social post</value>
    public IEnumerable<ViewFilterSocialSentimentCategoryEnum> SocialSentimentCategory { get; set; }

    /// <summary>
    /// The list of topicIds for social filtering
    /// </summary>
    /// <value>The list of topicIds for social filtering</value>
    public IEnumerable<string> SocialTopicIds { get; set; }

    /// <summary>
    /// The list of ingestion ruleIds for social filtering
    /// </summary>
    /// <value>The list of ingestion ruleIds for social filtering</value>
    public IEnumerable<string> SocialIngestionRuleIds { get; set; }

    /// <summary>
    /// Filter to indicate if the post has created a conversation
    /// </summary>
    /// <value>Filter to indicate if the post has created a conversation</value>
    public bool? SocialConversationCreated { get; set; }

    /// <summary>
    /// The list of content Type for social filtering
    /// </summary>
    /// <value>The list of content Type for social filtering</value>
    public IEnumerable<ViewFilterSocialContentTypeEnum> SocialContentType { get; set; }

    /// <summary>
    /// The list of keywords for social filtering
    /// </summary>
    /// <value>The list of keywords for social filtering</value>
    public IEnumerable<SocialKeyword> SocialKeywords { get; set; }

    /// <summary>
    /// Filter to indicate if the post is escalated
    /// </summary>
    /// <value>Filter to indicate if the post is escalated</value>
    public bool? SocialPostEscalated { get; set; }

    /// <summary>
    /// Indicates if a social message was public or private
    /// </summary>
    /// <value>Indicates if a social message was public or private</value>
    public IEnumerable<ViewFilterSocialClassificationsEnum> SocialClassifications { get; set; }

    /// <summary>
    /// The manager ids used to fetch associated users for the view
    /// </summary>
    /// <value>The manager ids used to fetch associated users for the view</value>
    public IEnumerable<string> FilterUsersByManagerIds { get; set; }

    /// <summary>
    /// List of Dashboard slideshowIds to be filtered
    /// </summary>
    /// <value>List of Dashboard slideshowIds to be filtered</value>
    public IEnumerable<string> SlideshowIds { get; set; }

    /// <summary>
    /// Filter to indicate if the conversation has conference
    /// </summary>
    /// <value>Filter to indicate if the conversation has conference</value>
    public bool? Conferenced { get; set; }

    /// <summary>
    /// Filter to indicate if the conversation has video
    /// </summary>
    /// <value>Filter to indicate if the conversation has video</value>
    public bool? Video { get; set; }

    /// <summary>
    /// Filter to indicate if the conversation has linked interaction
    /// </summary>
    /// <value>Filter to indicate if the conversation has linked interaction</value>
    public bool? LinkedInteraction { get; set; }

    /// <summary>
    /// List of recommendation sources for filtering recommendation details pane
    /// </summary>
    /// <value>List of recommendation sources for filtering recommendation details pane</value>
    public IEnumerable<ViewFilterRecommendationSourcesEnum> RecommendationSources { get; set; }

    /// <summary>
    /// The queue ids are used to for comparison to the primary queue filter in reporting
    /// </summary>
    /// <value>The queue ids are used to for comparison to the primary queue filter in reporting</value>
    public IEnumerable<string> ComparisonQueueIds { get; set; }

    /// <summary>
    /// A list of metrics selected for the view
    /// </summary>
    /// <value>A list of metrics selected for the view</value>
    public IEnumerable<ViewFilterViewMetricsEnum> ViewMetrics { get; set; }

    /// <summary>
    /// A list of timeline categories
    /// </summary>
    /// <value>A list of timeline categories</value>
    public IEnumerable<string> TimelineCategories { get; set; }

    /// <summary>
    /// Filter to indicate for acw state
    /// </summary>
    /// <value>Filter to indicate for acw state</value>
    public bool? Acw { get; set; }

    /// <summary>
    /// A list of filtered segment types
    /// </summary>
    /// <value>A list of filtered segment types</value>
    public IEnumerable<ViewFilterSegmentTypesEnum> SegmentTypes { get; set; }

    /// <summary>
    /// A list of program ids for filtering
    /// </summary>
    /// <value>A list of program ids for filtering</value>
    public IEnumerable<string> ProgramIds { get; set; }

    /// <summary>
    /// A list of category ids for filtering
    /// </summary>
    /// <value>A list of category ids for filtering</value>
    public IEnumerable<string> CategoryIds { get; set; }
}
