using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// FlowAggregationQuery
/// </summary>

public partial class FlowAggregationQuery : IEquatable<FlowAggregationQuery>
{
    /// <summary>
    /// Gets or Sets GroupBy
    /// </summary>
    
    public enum GroupByEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Activerouting for "activeRouting"
        /// </summary>
        [EnumMember(Value = "activeRouting")]
        Activerouting,

        /// <summary>
        /// Enum Activeskillid for "activeSkillId"
        /// </summary>
        [EnumMember(Value = "activeSkillId")]
        Activeskillid,

        /// <summary>
        /// Enum Addressfrom for "addressFrom"
        /// </summary>
        [EnumMember(Value = "addressFrom")]
        Addressfrom,

        /// <summary>
        /// Enum Addressto for "addressTo"
        /// </summary>
        [EnumMember(Value = "addressTo")]
        Addressto,

        /// <summary>
        /// Enum Agentassistantid for "agentAssistantId"
        /// </summary>
        [EnumMember(Value = "agentAssistantId")]
        Agentassistantid,

        /// <summary>
        /// Enum Agentbullseyering for "agentBullseyeRing"
        /// </summary>
        [EnumMember(Value = "agentBullseyeRing")]
        Agentbullseyering,

        /// <summary>
        /// Enum Agentowned for "agentOwned"
        /// </summary>
        [EnumMember(Value = "agentOwned")]
        Agentowned,

        /// <summary>
        /// Enum Agentrank for "agentRank"
        /// </summary>
        [EnumMember(Value = "agentRank")]
        Agentrank,

        /// <summary>
        /// Enum Agentscore for "agentScore"
        /// </summary>
        [EnumMember(Value = "agentScore")]
        Agentscore,

        /// <summary>
        /// Enum Ani for "ani"
        /// </summary>
        [EnumMember(Value = "ani")]
        Ani,

        /// <summary>
        /// Enum Assignerid for "assignerId"
        /// </summary>
        [EnumMember(Value = "assignerId")]
        Assignerid,

        /// <summary>
        /// Enum Authenticated for "authenticated"
        /// </summary>
        [EnumMember(Value = "authenticated")]
        Authenticated,

        /// <summary>
        /// Enum Conversationid for "conversationId"
        /// </summary>
        [EnumMember(Value = "conversationId")]
        Conversationid,

        /// <summary>
        /// Enum Conversationinitiator for "conversationInitiator"
        /// </summary>
        [EnumMember(Value = "conversationInitiator")]
        Conversationinitiator,

        /// <summary>
        /// Enum Convertedfrom for "convertedFrom"
        /// </summary>
        [EnumMember(Value = "convertedFrom")]
        Convertedfrom,

        /// <summary>
        /// Enum Convertedto for "convertedTo"
        /// </summary>
        [EnumMember(Value = "convertedTo")]
        Convertedto,

        /// <summary>
        /// Enum Customerparticipation for "customerParticipation"
        /// </summary>
        [EnumMember(Value = "customerParticipation")]
        Customerparticipation,

        /// <summary>
        /// Enum Deliverystatus for "deliveryStatus"
        /// </summary>
        [EnumMember(Value = "deliveryStatus")]
        Deliverystatus,

        /// <summary>
        /// Enum Destinationaddress for "destinationAddress"
        /// </summary>
        [EnumMember(Value = "destinationAddress")]
        Destinationaddress,

        /// <summary>
        /// Enum Direction for "direction"
        /// </summary>
        [EnumMember(Value = "direction")]
        Direction,

        /// <summary>
        /// Enum Disconnecttype for "disconnectType"
        /// </summary>
        [EnumMember(Value = "disconnectType")]
        Disconnecttype,

        /// <summary>
        /// Enum Divisionid for "divisionId"
        /// </summary>
        [EnumMember(Value = "divisionId")]
        Divisionid,

        /// <summary>
        /// Enum Dnis for "dnis"
        /// </summary>
        [EnumMember(Value = "dnis")]
        Dnis,

        /// <summary>
        /// Enum Edgeid for "edgeId"
        /// </summary>
        [EnumMember(Value = "edgeId")]
        Edgeid,

        /// <summary>
        /// Enum Eligibleagentcount for "eligibleAgentCount"
        /// </summary>
        [EnumMember(Value = "eligibleAgentCount")]
        Eligibleagentcount,

        /// <summary>
        /// Enum Endinglanguage for "endingLanguage"
        /// </summary>
        [EnumMember(Value = "endingLanguage")]
        Endinglanguage,

        /// <summary>
        /// Enum Entryreason for "entryReason"
        /// </summary>
        [EnumMember(Value = "entryReason")]
        Entryreason,

        /// <summary>
        /// Enum Entrytype for "entryType"
        /// </summary>
        [EnumMember(Value = "entryType")]
        Entrytype,

        /// <summary>
        /// Enum Errorcode for "errorCode"
        /// </summary>
        [EnumMember(Value = "errorCode")]
        Errorcode,

        /// <summary>
        /// Enum Exitreason for "exitReason"
        /// </summary>
        [EnumMember(Value = "exitReason")]
        Exitreason,

        /// <summary>
        /// Enum Extendeddeliverystatus for "extendedDeliveryStatus"
        /// </summary>
        [EnumMember(Value = "extendedDeliveryStatus")]
        Extendeddeliverystatus,

        /// <summary>
        /// Enum Externalcontactid for "externalContactId"
        /// </summary>
        [EnumMember(Value = "externalContactId")]
        Externalcontactid,

        /// <summary>
        /// Enum Externalmediacount for "externalMediaCount"
        /// </summary>
        [EnumMember(Value = "externalMediaCount")]
        Externalmediacount,

        /// <summary>
        /// Enum Externalorganizationid for "externalOrganizationId"
        /// </summary>
        [EnumMember(Value = "externalOrganizationId")]
        Externalorganizationid,

        /// <summary>
        /// Enum Externaltag for "externalTag"
        /// </summary>
        [EnumMember(Value = "externalTag")]
        Externaltag,

        /// <summary>
        /// Enum Firstqueue for "firstQueue"
        /// </summary>
        [EnumMember(Value = "firstQueue")]
        Firstqueue,

        /// <summary>
        /// Enum Flaggedreason for "flaggedReason"
        /// </summary>
        [EnumMember(Value = "flaggedReason")]
        Flaggedreason,

        /// <summary>
        /// Enum Flowid for "flowId"
        /// </summary>
        [EnumMember(Value = "flowId")]
        Flowid,

        /// <summary>
        /// Enum Flowintype for "flowInType"
        /// </summary>
        [EnumMember(Value = "flowInType")]
        Flowintype,

        /// <summary>
        /// Enum Flowmilestoneid for "flowMilestoneId"
        /// </summary>
        [EnumMember(Value = "flowMilestoneId")]
        Flowmilestoneid,

        /// <summary>
        /// Enum Flowname for "flowName"
        /// </summary>
        [EnumMember(Value = "flowName")]
        Flowname,

        /// <summary>
        /// Enum Flowouttype for "flowOutType"
        /// </summary>
        [EnumMember(Value = "flowOutType")]
        Flowouttype,

        /// <summary>
        /// Enum Flowoutcome for "flowOutcome"
        /// </summary>
        [EnumMember(Value = "flowOutcome")]
        Flowoutcome,

        /// <summary>
        /// Enum Flowoutcomeid for "flowOutcomeId"
        /// </summary>
        [EnumMember(Value = "flowOutcomeId")]
        Flowoutcomeid,

        /// <summary>
        /// Enum Flowoutcomevalue for "flowOutcomeValue"
        /// </summary>
        [EnumMember(Value = "flowOutcomeValue")]
        Flowoutcomevalue,

        /// <summary>
        /// Enum Flowsubtype for "flowSubType"
        /// </summary>
        [EnumMember(Value = "flowSubType")]
        Flowsubtype,

        /// <summary>
        /// Enum Flowtype for "flowType"
        /// </summary>
        [EnumMember(Value = "flowType")]
        Flowtype,

        /// <summary>
        /// Enum Flowversion for "flowVersion"
        /// </summary>
        [EnumMember(Value = "flowVersion")]
        Flowversion,

        /// <summary>
        /// Enum Groupid for "groupId"
        /// </summary>
        [EnumMember(Value = "groupId")]
        Groupid,

        /// <summary>
        /// Enum Interactiontype for "interactionType"
        /// </summary>
        [EnumMember(Value = "interactionType")]
        Interactiontype,

        /// <summary>
        /// Enum Journeyactionid for "journeyActionId"
        /// </summary>
        [EnumMember(Value = "journeyActionId")]
        Journeyactionid,

        /// <summary>
        /// Enum Journeyactionmapid for "journeyActionMapId"
        /// </summary>
        [EnumMember(Value = "journeyActionMapId")]
        Journeyactionmapid,

        /// <summary>
        /// Enum Journeyactionmapversion for "journeyActionMapVersion"
        /// </summary>
        [EnumMember(Value = "journeyActionMapVersion")]
        Journeyactionmapversion,

        /// <summary>
        /// Enum Journeycustomerid for "journeyCustomerId"
        /// </summary>
        [EnumMember(Value = "journeyCustomerId")]
        Journeycustomerid,

        /// <summary>
        /// Enum Journeycustomeridtype for "journeyCustomerIdType"
        /// </summary>
        [EnumMember(Value = "journeyCustomerIdType")]
        Journeycustomeridtype,

        /// <summary>
        /// Enum Journeycustomersessionid for "journeyCustomerSessionId"
        /// </summary>
        [EnumMember(Value = "journeyCustomerSessionId")]
        Journeycustomersessionid,

        /// <summary>
        /// Enum Journeycustomersessionidtype for "journeyCustomerSessionIdType"
        /// </summary>
        [EnumMember(Value = "journeyCustomerSessionIdType")]
        Journeycustomersessionidtype,

        /// <summary>
        /// Enum Knowledgebaseid for "knowledgeBaseId"
        /// </summary>
        [EnumMember(Value = "knowledgeBaseId")]
        Knowledgebaseid,

        /// <summary>
        /// Enum Mediacount for "mediaCount"
        /// </summary>
        [EnumMember(Value = "mediaCount")]
        Mediacount,

        /// <summary>
        /// Enum Mediatype for "mediaType"
        /// </summary>
        [EnumMember(Value = "mediaType")]
        Mediatype,

        /// <summary>
        /// Enum Messagetype for "messageType"
        /// </summary>
        [EnumMember(Value = "messageType")]
        Messagetype,

        /// <summary>
        /// Enum Originatingdirection for "originatingDirection"
        /// </summary>
        [EnumMember(Value = "originatingDirection")]
        Originatingdirection,

        /// <summary>
        /// Enum Outboundcampaignid for "outboundCampaignId"
        /// </summary>
        [EnumMember(Value = "outboundCampaignId")]
        Outboundcampaignid,

        /// <summary>
        /// Enum Outboundcontactid for "outboundContactId"
        /// </summary>
        [EnumMember(Value = "outboundContactId")]
        Outboundcontactid,

        /// <summary>
        /// Enum Outboundcontactlistid for "outboundContactListId"
        /// </summary>
        [EnumMember(Value = "outboundContactListId")]
        Outboundcontactlistid,

        /// <summary>
        /// Enum Participantname for "participantName"
        /// </summary>
        [EnumMember(Value = "participantName")]
        Participantname,

        /// <summary>
        /// Enum Peerid for "peerId"
        /// </summary>
        [EnumMember(Value = "peerId")]
        Peerid,

        /// <summary>
        /// Enum Proposedagentid for "proposedAgentId"
        /// </summary>
        [EnumMember(Value = "proposedAgentId")]
        Proposedagentid,

        /// <summary>
        /// Enum Provider for "provider"
        /// </summary>
        [EnumMember(Value = "provider")]
        Provider,

        /// <summary>
        /// Enum Purpose for "purpose"
        /// </summary>
        [EnumMember(Value = "purpose")]
        Purpose,

        /// <summary>
        /// Enum Queueid for "queueId"
        /// </summary>
        [EnumMember(Value = "queueId")]
        Queueid,

        /// <summary>
        /// Enum Recognitionfailurereason for "recognitionFailureReason"
        /// </summary>
        [EnumMember(Value = "recognitionFailureReason")]
        Recognitionfailurereason,

        /// <summary>
        /// Enum Remote for "remote"
        /// </summary>
        [EnumMember(Value = "remote")]
        Remote,

        /// <summary>
        /// Enum Removedskillid for "removedSkillId"
        /// </summary>
        [EnumMember(Value = "removedSkillId")]
        Removedskillid,

        /// <summary>
        /// Enum Requestedlanguageid for "requestedLanguageId"
        /// </summary>
        [EnumMember(Value = "requestedLanguageId")]
        Requestedlanguageid,

        /// <summary>
        /// Enum Requestedrouting for "requestedRouting"
        /// </summary>
        [EnumMember(Value = "requestedRouting")]
        Requestedrouting,

        /// <summary>
        /// Enum Requestedroutingskillid for "requestedRoutingSkillId"
        /// </summary>
        [EnumMember(Value = "requestedRoutingSkillId")]
        Requestedroutingskillid,

        /// <summary>
        /// Enum Roomid for "roomId"
        /// </summary>
        [EnumMember(Value = "roomId")]
        Roomid,

        /// <summary>
        /// Enum Routingpriority for "routingPriority"
        /// </summary>
        [EnumMember(Value = "routingPriority")]
        Routingpriority,

        /// <summary>
        /// Enum Routingring for "routingRing"
        /// </summary>
        [EnumMember(Value = "routingRing")]
        Routingring,

        /// <summary>
        /// Enum Routingrule for "routingRule"
        /// </summary>
        [EnumMember(Value = "routingRule")]
        Routingrule,

        /// <summary>
        /// Enum Routingruletype for "routingRuleType"
        /// </summary>
        [EnumMember(Value = "routingRuleType")]
        Routingruletype,

        /// <summary>
        /// Enum Scoredagentid for "scoredAgentId"
        /// </summary>
        [EnumMember(Value = "scoredAgentId")]
        Scoredagentid,

        /// <summary>
        /// Enum Selectedagentid for "selectedAgentId"
        /// </summary>
        [EnumMember(Value = "selectedAgentId")]
        Selectedagentid,

        /// <summary>
        /// Enum Selectedagentrank for "selectedAgentRank"
        /// </summary>
        [EnumMember(Value = "selectedAgentRank")]
        Selectedagentrank,

        /// <summary>
        /// Enum Selfserved for "selfServed"
        /// </summary>
        [EnumMember(Value = "selfServed")]
        Selfserved,

        /// <summary>
        /// Enum Sessiondnis for "sessionDnis"
        /// </summary>
        [EnumMember(Value = "sessionDnis")]
        Sessiondnis,

        /// <summary>
        /// Enum Sessionid for "sessionId"
        /// </summary>
        [EnumMember(Value = "sessionId")]
        Sessionid,

        /// <summary>
        /// Enum Startinglanguage for "startingLanguage"
        /// </summary>
        [EnumMember(Value = "startingLanguage")]
        Startinglanguage,

        /// <summary>
        /// Enum Stationid for "stationId"
        /// </summary>
        [EnumMember(Value = "stationId")]
        Stationid,

        /// <summary>
        /// Enum Teamid for "teamId"
        /// </summary>
        [EnumMember(Value = "teamId")]
        Teamid,

        /// <summary>
        /// Enum Transfertargetaddress for "transferTargetAddress"
        /// </summary>
        [EnumMember(Value = "transferTargetAddress")]
        Transfertargetaddress,

        /// <summary>
        /// Enum Transfertargetname for "transferTargetName"
        /// </summary>
        [EnumMember(Value = "transferTargetName")]
        Transfertargetname,

        /// <summary>
        /// Enum Transfertype for "transferType"
        /// </summary>
        [EnumMember(Value = "transferType")]
        Transfertype,

        /// <summary>
        /// Enum Usedrouting for "usedRouting"
        /// </summary>
        [EnumMember(Value = "usedRouting")]
        Usedrouting,

        /// <summary>
        /// Enum Userid for "userId"
        /// </summary>
        [EnumMember(Value = "userId")]
        Userid,

        /// <summary>
        /// Enum Videopresent for "videoPresent"
        /// </summary>
        [EnumMember(Value = "videoPresent")]
        Videopresent,

        /// <summary>
        /// Enum Waitinginteractioncount for "waitingInteractionCount"
        /// </summary>
        [EnumMember(Value = "waitingInteractionCount")]
        Waitinginteractioncount,

        /// <summary>
        /// Enum Wrapupcode for "wrapUpCode"
        /// </summary>
        [EnumMember(Value = "wrapUpCode")]
        Wrapupcode
    }
    /// <summary>
    /// Gets or Sets Metrics
    /// </summary>
    
    public enum MetricsEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Nflow for "nFlow"
        /// </summary>
        [EnumMember(Value = "nFlow")]
        Nflow,

        /// <summary>
        /// Enum Nflowmilestone for "nFlowMilestone"
        /// </summary>
        [EnumMember(Value = "nFlowMilestone")]
        Nflowmilestone,

        /// <summary>
        /// Enum Nflowoutcome for "nFlowOutcome"
        /// </summary>
        [EnumMember(Value = "nFlowOutcome")]
        Nflowoutcome,

        /// <summary>
        /// Enum Nflowoutcomefailed for "nFlowOutcomeFailed"
        /// </summary>
        [EnumMember(Value = "nFlowOutcomeFailed")]
        Nflowoutcomefailed,

        /// <summary>
        /// Enum Oflowmilestone for "oFlowMilestone"
        /// </summary>
        [EnumMember(Value = "oFlowMilestone")]
        Oflowmilestone,

        /// <summary>
        /// Enum Tflow for "tFlow"
        /// </summary>
        [EnumMember(Value = "tFlow")]
        Tflow,

        /// <summary>
        /// Enum Tflowdisconnect for "tFlowDisconnect"
        /// </summary>
        [EnumMember(Value = "tFlowDisconnect")]
        Tflowdisconnect,

        /// <summary>
        /// Enum Tflowexit for "tFlowExit"
        /// </summary>
        [EnumMember(Value = "tFlowExit")]
        Tflowexit,

        /// <summary>
        /// Enum Tflowoutcome for "tFlowOutcome"
        /// </summary>
        [EnumMember(Value = "tFlowOutcome")]
        Tflowoutcome
    }
    /// <summary>
    /// Dimension to use as the alternative timestamp for data in the aggregate.  Choosing \"eventTime\" uses the actual time of the data event.
    /// </summary>
    /// <value>Dimension to use as the alternative timestamp for data in the aggregate.  Choosing \"eventTime\" uses the actual time of the data event.</value>
    
    public enum AlternateTimeDimensionEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Eventtime for "eventTime"
        /// </summary>
        [EnumMember(Value = "eventTime")]
        Eventtime
    }
    /// <summary>
    /// Dimension to use as the alternative timestamp for data in the aggregate.  Choosing \"eventTime\" uses the actual time of the data event.
    /// </summary>
    /// <value>Dimension to use as the alternative timestamp for data in the aggregate.  Choosing \"eventTime\" uses the actual time of the data event.</value>
    [JsonPropertyName("alternateTimeDimension")]
    public AlternateTimeDimensionEnum? AlternateTimeDimension { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="FlowAggregationQuery" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected FlowAggregationQuery() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="FlowAggregationQuery" /> class.
    /// </summary>
    /// <param name="Interval">Behaves like one clause in a SQL WHERE. Specifies the date and time range of data being queried. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (required).</param>
    /// <param name="Granularity">Granularity aggregates metrics into subpartitions within the time interval specified. The default granularity is the same duration as the interval. Periods are represented as an ISO-8601 string. For example: P1D or P1DT12H.</param>
    /// <param name="TimeZone">Time zone context used to calculate response intervals (this allows resolving DST changes). The interval offset is used even when timeZone is specified. Default is UTC. Time zones are represented as a string of the zone name as found in the IANA time zone database. For example: UTC, Etc/UTC, or Europe/London.</param>
    /// <param name="GroupBy">Behaves like a SQL GROUPBY. Allows for multiple levels of grouping as a list of dimensions. Partitions resulting aggregate computations into distinct named subgroups rather than across the entire result set as if it were one group..</param>
    /// <param name="Filter">Behaves like a SQL WHERE clause. This is ANDed with the interval parameter. Expresses boolean logical predicates as well as dimensional filters.</param>
    /// <param name="Metrics">Behaves like a SQL SELECT clause. Only named metrics will be retrieved. (required).</param>
    /// <param name="FlattenMultivaluedDimensions">Flattens any multivalued dimensions used in response groups (e.g. [&#39;a&#39;,&#39;b&#39;,&#39;c&#39;]-&gt;&#39;a,b,c&#39;).</param>
    /// <param name="Views">Custom derived metric views.</param>
    /// <param name="AlternateTimeDimension">Dimension to use as the alternative timestamp for data in the aggregate.  Choosing \&quot;eventTime\&quot; uses the actual time of the data event..</param>
    public FlowAggregationQuery(string Interval = null, string Granularity = null, string TimeZone = null, List<GroupByEnum> GroupBy = null, FlowAggregateQueryFilter Filter = null, List<MetricsEnum> Metrics = null, bool? FlattenMultivaluedDimensions = null, List<FlowAggregationView> Views = null, AlternateTimeDimensionEnum? AlternateTimeDimension = null)
    {
        this.Interval = Interval;
        this.Granularity = Granularity;
        this.TimeZone = TimeZone;
        this.GroupBy = GroupBy;
        this.Filter = Filter;
        this.Metrics = Metrics;
        this.FlattenMultivaluedDimensions = FlattenMultivaluedDimensions;
        this.Views = Views;
        this.AlternateTimeDimension = AlternateTimeDimension;

    }



    /// <summary>
    /// Behaves like one clause in a SQL WHERE. Specifies the date and time range of data being queried. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss
    /// </summary>
    /// <value>Behaves like one clause in a SQL WHERE. Specifies the date and time range of data being queried. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss</value>
    [JsonPropertyName("interval")]
    public string Interval { get; set; }



    /// <summary>
    /// Granularity aggregates metrics into subpartitions within the time interval specified. The default granularity is the same duration as the interval. Periods are represented as an ISO-8601 string. For example: P1D or P1DT12H
    /// </summary>
    /// <value>Granularity aggregates metrics into subpartitions within the time interval specified. The default granularity is the same duration as the interval. Periods are represented as an ISO-8601 string. For example: P1D or P1DT12H</value>
    [JsonPropertyName("granularity")]
    public string Granularity { get; set; }



    /// <summary>
    /// Time zone context used to calculate response intervals (this allows resolving DST changes). The interval offset is used even when timeZone is specified. Default is UTC. Time zones are represented as a string of the zone name as found in the IANA time zone database. For example: UTC, Etc/UTC, or Europe/London
    /// </summary>
    /// <value>Time zone context used to calculate response intervals (this allows resolving DST changes). The interval offset is used even when timeZone is specified. Default is UTC. Time zones are represented as a string of the zone name as found in the IANA time zone database. For example: UTC, Etc/UTC, or Europe/London</value>
    [JsonPropertyName("timeZone")]
    public string TimeZone { get; set; }



    /// <summary>
    /// Behaves like a SQL GROUPBY. Allows for multiple levels of grouping as a list of dimensions. Partitions resulting aggregate computations into distinct named subgroups rather than across the entire result set as if it were one group.
    /// </summary>
    /// <value>Behaves like a SQL GROUPBY. Allows for multiple levels of grouping as a list of dimensions. Partitions resulting aggregate computations into distinct named subgroups rather than across the entire result set as if it were one group.</value>
    [JsonPropertyName("groupBy")]
    public List<GroupByEnum> GroupBy { get; set; }



    /// <summary>
    /// Behaves like a SQL WHERE clause. This is ANDed with the interval parameter. Expresses boolean logical predicates as well as dimensional filters
    /// </summary>
    /// <value>Behaves like a SQL WHERE clause. This is ANDed with the interval parameter. Expresses boolean logical predicates as well as dimensional filters</value>
    [JsonPropertyName("filter")]
    public FlowAggregateQueryFilter Filter { get; set; }



    /// <summary>
    /// Behaves like a SQL SELECT clause. Only named metrics will be retrieved.
    /// </summary>
    /// <value>Behaves like a SQL SELECT clause. Only named metrics will be retrieved.</value>
    [JsonPropertyName("metrics")]
    public List<MetricsEnum> Metrics { get; set; }



    /// <summary>
    /// Flattens any multivalued dimensions used in response groups (e.g. [&#39;a&#39;,&#39;b&#39;,&#39;c&#39;]-&gt;&#39;a,b,c&#39;)
    /// </summary>
    /// <value>Flattens any multivalued dimensions used in response groups (e.g. [&#39;a&#39;,&#39;b&#39;,&#39;c&#39;]-&gt;&#39;a,b,c&#39;)</value>
    [JsonPropertyName("flattenMultivaluedDimensions")]
    public bool? FlattenMultivaluedDimensions { get; set; }



    /// <summary>
    /// Custom derived metric views
    /// </summary>
    /// <value>Custom derived metric views</value>
    [JsonPropertyName("views")]
    public List<FlowAggregationView> Views { get; set; }




    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class FlowAggregationQuery {\n");

        sb.Append("  Interval: ").Append(Interval).Append("\n");
        sb.Append("  Granularity: ").Append(Granularity).Append("\n");
        sb.Append("  TimeZone: ").Append(TimeZone).Append("\n");
        sb.Append("  GroupBy: ").Append(GroupBy).Append("\n");
        sb.Append("  Filter: ").Append(Filter).Append("\n");
        sb.Append("  Metrics: ").Append(Metrics).Append("\n");
        sb.Append("  FlattenMultivaluedDimensions: ").Append(FlattenMultivaluedDimensions).Append("\n");
        sb.Append("  Views: ").Append(Views).Append("\n");
        sb.Append("  AlternateTimeDimension: ").Append(AlternateTimeDimension).Append("\n");
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
        return Equals(obj as FlowAggregationQuery);
    }

    /// <summary>
    /// Returns true if FlowAggregationQuery instances are equal
    /// </summary>
    /// <param name="other">Instance of FlowAggregationQuery to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(FlowAggregationQuery other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Interval == other.Interval ||
                Interval != null &&
                Interval.Equals(other.Interval)
            ) &&
            (
                Granularity == other.Granularity ||
                Granularity != null &&
                Granularity.Equals(other.Granularity)
            ) &&
            (
                TimeZone == other.TimeZone ||
                TimeZone != null &&
                TimeZone.Equals(other.TimeZone)
            ) &&
            (
                GroupBy == other.GroupBy ||
                GroupBy != null &&
                GroupBy.SequenceEqual(other.GroupBy)
            ) &&
            (
                Filter == other.Filter ||
                Filter != null &&
                Filter.Equals(other.Filter)
            ) &&
            (
                Metrics == other.Metrics ||
                Metrics != null &&
                Metrics.SequenceEqual(other.Metrics)
            ) &&
            (
                FlattenMultivaluedDimensions == other.FlattenMultivaluedDimensions ||
                FlattenMultivaluedDimensions != null &&
                FlattenMultivaluedDimensions.Equals(other.FlattenMultivaluedDimensions)
            ) &&
            (
                Views == other.Views ||
                Views != null &&
                Views.SequenceEqual(other.Views)
            ) &&
            (
                AlternateTimeDimension == other.AlternateTimeDimension ||
                AlternateTimeDimension != null &&
                AlternateTimeDimension.Equals(other.AlternateTimeDimension)
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
            if (Interval != null)
            {
                hash = hash * 59 + Interval.GetHashCode();
            }

            if (Granularity != null)
            {
                hash = hash * 59 + Granularity.GetHashCode();
            }

            if (TimeZone != null)
            {
                hash = hash * 59 + TimeZone.GetHashCode();
            }

            if (GroupBy != null)
            {
                hash = hash * 59 + GroupBy.GetHashCode();
            }

            if (Filter != null)
            {
                hash = hash * 59 + Filter.GetHashCode();
            }

            if (Metrics != null)
            {
                hash = hash * 59 + Metrics.GetHashCode();
            }

            if (FlattenMultivaluedDimensions != null)
            {
                hash = hash * 59 + FlattenMultivaluedDimensions.GetHashCode();
            }

            if (Views != null)
            {
                hash = hash * 59 + Views.GetHashCode();
            }

            if (AlternateTimeDimension != null)
            {
                hash = hash * 59 + AlternateTimeDimension.GetHashCode();
            }

            return hash;
        }
    }
}
