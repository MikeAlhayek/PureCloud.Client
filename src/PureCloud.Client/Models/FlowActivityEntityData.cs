using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// FlowActivityEntityData
/// </summary>

public partial class FlowActivityEntityData : IEquatable<FlowActivityEntityData>
{
    /// <summary>
    /// Activity metric
    /// </summary>
    /// <value>Activity metric</value>
    
    public enum MetricEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Oflow for "oFlow"
        /// </summary>
        [EnumMember(Value = "oFlow")]
        Oflow
    }
    /// <summary>
    /// Active routing method
    /// </summary>
    /// <value>Active routing method</value>
    
    public enum ActiveRoutingEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Bullseye for "Bullseye"
        /// </summary>
        [EnumMember(Value = "Bullseye")]
        Bullseye,

        /// <summary>
        /// Enum Conditional for "Conditional"
        /// </summary>
        [EnumMember(Value = "Conditional")]
        Conditional,

        /// <summary>
        /// Enum Direct for "Direct"
        /// </summary>
        [EnumMember(Value = "Direct")]
        Direct,

        /// <summary>
        /// Enum Last for "Last"
        /// </summary>
        [EnumMember(Value = "Last")]
        Last,

        /// <summary>
        /// Enum Manual for "Manual"
        /// </summary>
        [EnumMember(Value = "Manual")]
        Manual,

        /// <summary>
        /// Enum Predictive for "Predictive"
        /// </summary>
        [EnumMember(Value = "Predictive")]
        Predictive,

        /// <summary>
        /// Enum Preferred for "Preferred"
        /// </summary>
        [EnumMember(Value = "Preferred")]
        Preferred,

        /// <summary>
        /// Enum Standard for "Standard"
        /// </summary>
        [EnumMember(Value = "Standard")]
        Standard,

        /// <summary>
        /// Enum Vip for "Vip"
        /// </summary>
        [EnumMember(Value = "Vip")]
        Vip
    }
    /// <summary>
    /// The direction of the communication
    /// </summary>
    /// <value>The direction of the communication</value>
    
    public enum DirectionEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Inbound for "inbound"
        /// </summary>
        [EnumMember(Value = "inbound")]
        Inbound,

        /// <summary>
        /// Enum Outbound for "outbound"
        /// </summary>
        [EnumMember(Value = "outbound")]
        Outbound
    }
    /// <summary>
    /// The type of this flow
    /// </summary>
    /// <value>The type of this flow</value>
    
    public enum FlowTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Bot for "BOT"
        /// </summary>
        [EnumMember(Value = "BOT")]
        Bot,

        /// <summary>
        /// Enum Commonmodule for "COMMONMODULE"
        /// </summary>
        [EnumMember(Value = "COMMONMODULE")]
        Commonmodule,

        /// <summary>
        /// Enum Digitalbot for "DIGITALBOT"
        /// </summary>
        [EnumMember(Value = "DIGITALBOT")]
        Digitalbot,

        /// <summary>
        /// Enum Inboundcall for "INBOUNDCALL"
        /// </summary>
        [EnumMember(Value = "INBOUNDCALL")]
        Inboundcall,

        /// <summary>
        /// Enum Inboundchat for "INBOUNDCHAT"
        /// </summary>
        [EnumMember(Value = "INBOUNDCHAT")]
        Inboundchat,

        /// <summary>
        /// Enum Inboundemail for "INBOUNDEMAIL"
        /// </summary>
        [EnumMember(Value = "INBOUNDEMAIL")]
        Inboundemail,

        /// <summary>
        /// Enum Inboundshortmessage for "INBOUNDSHORTMESSAGE"
        /// </summary>
        [EnumMember(Value = "INBOUNDSHORTMESSAGE")]
        Inboundshortmessage,

        /// <summary>
        /// Enum Inqueuecall for "INQUEUECALL"
        /// </summary>
        [EnumMember(Value = "INQUEUECALL")]
        Inqueuecall,

        /// <summary>
        /// Enum Inqueueemail for "INQUEUEEMAIL"
        /// </summary>
        [EnumMember(Value = "INQUEUEEMAIL")]
        Inqueueemail,

        /// <summary>
        /// Enum Inqueueshortmessage for "INQUEUESHORTMESSAGE"
        /// </summary>
        [EnumMember(Value = "INQUEUESHORTMESSAGE")]
        Inqueueshortmessage,

        /// <summary>
        /// Enum Outboundcall for "OUTBOUNDCALL"
        /// </summary>
        [EnumMember(Value = "OUTBOUNDCALL")]
        Outboundcall,

        /// <summary>
        /// Enum Securecall for "SECURECALL"
        /// </summary>
        [EnumMember(Value = "SECURECALL")]
        Securecall,

        /// <summary>
        /// Enum Speech for "SPEECH"
        /// </summary>
        [EnumMember(Value = "SPEECH")]
        Speech,

        /// <summary>
        /// Enum Surveyinvite for "SURVEYINVITE"
        /// </summary>
        [EnumMember(Value = "SURVEYINVITE")]
        Surveyinvite,

        /// <summary>
        /// Enum Voice for "VOICE"
        /// </summary>
        [EnumMember(Value = "VOICE")]
        Voice,

        /// <summary>
        /// Enum Voicemail for "VOICEMAIL"
        /// </summary>
        [EnumMember(Value = "VOICEMAIL")]
        Voicemail,

        /// <summary>
        /// Enum Voicesurvey for "VOICESURVEY"
        /// </summary>
        [EnumMember(Value = "VOICESURVEY")]
        Voicesurvey,

        /// <summary>
        /// Enum Workflow for "WORKFLOW"
        /// </summary>
        [EnumMember(Value = "WORKFLOW")]
        Workflow,

        /// <summary>
        /// Enum Workitem for "WORKITEM"
        /// </summary>
        [EnumMember(Value = "WORKITEM")]
        Workitem
    }
    /// <summary>
    /// The session media type
    /// </summary>
    /// <value>The session media type</value>
    
    public enum MediaTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Callback for "callback"
        /// </summary>
        [EnumMember(Value = "callback")]
        Callback,

        /// <summary>
        /// Enum Chat for "chat"
        /// </summary>
        [EnumMember(Value = "chat")]
        Chat,

        /// <summary>
        /// Enum Cobrowse for "cobrowse"
        /// </summary>
        [EnumMember(Value = "cobrowse")]
        Cobrowse,

        /// <summary>
        /// Enum Email for "email"
        /// </summary>
        [EnumMember(Value = "email")]
        Email,

        /// <summary>
        /// Enum Internalmessage for "internalmessage"
        /// </summary>
        [EnumMember(Value = "internalmessage")]
        Internalmessage,

        /// <summary>
        /// Enum Message for "message"
        /// </summary>
        [EnumMember(Value = "message")]
        Message,

        /// <summary>
        /// Enum Screenshare for "screenshare"
        /// </summary>
        [EnumMember(Value = "screenshare")]
        Screenshare,

        /// <summary>
        /// Enum Unknown for "unknown"
        /// </summary>
        [EnumMember(Value = "unknown")]
        Unknown,

        /// <summary>
        /// Enum Video for "video"
        /// </summary>
        [EnumMember(Value = "video")]
        Video,

        /// <summary>
        /// Enum Voice for "voice"
        /// </summary>
        [EnumMember(Value = "voice")]
        Voice
    }
    /// <summary>
    /// Gets or Sets RequestedRoutings
    /// </summary>
    
    public enum RequestedRoutingsEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Bullseye for "Bullseye"
        /// </summary>
        [EnumMember(Value = "Bullseye")]
        Bullseye,

        /// <summary>
        /// Enum Conditional for "Conditional"
        /// </summary>
        [EnumMember(Value = "Conditional")]
        Conditional,

        /// <summary>
        /// Enum Direct for "Direct"
        /// </summary>
        [EnumMember(Value = "Direct")]
        Direct,

        /// <summary>
        /// Enum Last for "Last"
        /// </summary>
        [EnumMember(Value = "Last")]
        Last,

        /// <summary>
        /// Enum Manual for "Manual"
        /// </summary>
        [EnumMember(Value = "Manual")]
        Manual,

        /// <summary>
        /// Enum Predictive for "Predictive"
        /// </summary>
        [EnumMember(Value = "Predictive")]
        Predictive,

        /// <summary>
        /// Enum Preferred for "Preferred"
        /// </summary>
        [EnumMember(Value = "Preferred")]
        Preferred,

        /// <summary>
        /// Enum Standard for "Standard"
        /// </summary>
        [EnumMember(Value = "Standard")]
        Standard,

        /// <summary>
        /// Enum Vip for "Vip"
        /// </summary>
        [EnumMember(Value = "Vip")]
        Vip
    }
    /// <summary>
    /// Complete routing method
    /// </summary>
    /// <value>Complete routing method</value>
    
    public enum UsedRoutingEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Bullseye for "Bullseye"
        /// </summary>
        [EnumMember(Value = "Bullseye")]
        Bullseye,

        /// <summary>
        /// Enum Conditional for "Conditional"
        /// </summary>
        [EnumMember(Value = "Conditional")]
        Conditional,

        /// <summary>
        /// Enum Direct for "Direct"
        /// </summary>
        [EnumMember(Value = "Direct")]
        Direct,

        /// <summary>
        /// Enum Last for "Last"
        /// </summary>
        [EnumMember(Value = "Last")]
        Last,

        /// <summary>
        /// Enum Manual for "Manual"
        /// </summary>
        [EnumMember(Value = "Manual")]
        Manual,

        /// <summary>
        /// Enum Predictive for "Predictive"
        /// </summary>
        [EnumMember(Value = "Predictive")]
        Predictive,

        /// <summary>
        /// Enum Preferred for "Preferred"
        /// </summary>
        [EnumMember(Value = "Preferred")]
        Preferred,

        /// <summary>
        /// Enum Standard for "Standard"
        /// </summary>
        [EnumMember(Value = "Standard")]
        Standard,

        /// <summary>
        /// Enum Vip for "Vip"
        /// </summary>
        [EnumMember(Value = "Vip")]
        Vip
    }
    /// <summary>
    /// Activity metric
    /// </summary>
    /// <value>Activity metric</value>
    [JsonPropertyName("metric")]
    public MetricEnum? Metric { get; set; }
    /// <summary>
    /// Active routing method
    /// </summary>
    /// <value>Active routing method</value>
    [JsonPropertyName("activeRouting")]
    public ActiveRoutingEnum? ActiveRouting { get; set; }
    /// <summary>
    /// The direction of the communication
    /// </summary>
    /// <value>The direction of the communication</value>
    [JsonPropertyName("direction")]
    public DirectionEnum? Direction { get; set; }
    /// <summary>
    /// The type of this flow
    /// </summary>
    /// <value>The type of this flow</value>
    [JsonPropertyName("flowType")]
    public FlowTypeEnum? FlowType { get; set; }
    /// <summary>
    /// The session media type
    /// </summary>
    /// <value>The session media type</value>
    [JsonPropertyName("mediaType")]
    public MediaTypeEnum? MediaType { get; set; }
    /// <summary>
    /// Complete routing method
    /// </summary>
    /// <value>Complete routing method</value>
    [JsonPropertyName("usedRouting")]
    public UsedRoutingEnum? UsedRouting { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="FlowActivityEntityData" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected FlowActivityEntityData() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="FlowActivityEntityData" /> class.
    /// </summary>
    /// <param name="ActivityDate">The time at which the activity was observed. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
    /// <param name="Metric">Activity metric.</param>
    /// <param name="ActiveRouting">Active routing method.</param>
    /// <param name="AddressFrom">The address that initiated an action.</param>
    /// <param name="AddressTo">The address receiving an action.</param>
    /// <param name="Ani">Automatic Number Identification (caller&#39;s number).</param>
    /// <param name="ConversationId">Unique identifier for the conversation.</param>
    /// <param name="ConvertedFrom">Session media type that was converted from in case of a media type conversion.</param>
    /// <param name="ConvertedTo">Session media type that was converted to in case of a media type conversion.</param>
    /// <param name="Direction">The direction of the communication.</param>
    /// <param name="Dnis">Dialed number identification service (number dialed by the calling party).</param>
    /// <param name="FlowId">The unique identifier of this flow.</param>
    /// <param name="FlowType">The type of this flow.</param>
    /// <param name="MediaType">The session media type.</param>
    /// <param name="ParticipantName">A human readable name identifying the participant.</param>
    /// <param name="QueueId">Queue identifier.</param>
    /// <param name="RequestedLanguageId">Unique identifier for the language requested for an interaction.</param>
    /// <param name="RequestedRoutingSkillIds">Unique identifier(s) for skill(s) requested for an interaction.</param>
    /// <param name="RequestedRoutings">Routing type(s) for requested/attempted routing methods..</param>
    /// <param name="RoutingPriority">Routing priority for the current interaction.</param>
    /// <param name="SessionId">The unique identifier of this session.</param>
    /// <param name="TeamId">The team ID the user is a member of.</param>
    /// <param name="UsedRouting">Complete routing method.</param>
    /// <param name="UserId">Unique identifier for the user.</param>
    /// <param name="ScoredAgents">Scored agents.</param>
    public FlowActivityEntityData(DateTime? ActivityDate = null, MetricEnum? Metric = null, ActiveRoutingEnum? ActiveRouting = null, string AddressFrom = null, string AddressTo = null, string Ani = null, string ConversationId = null, string ConvertedFrom = null, string ConvertedTo = null, DirectionEnum? Direction = null, string Dnis = null, string FlowId = null, FlowTypeEnum? FlowType = null, MediaTypeEnum? MediaType = null, string ParticipantName = null, string QueueId = null, string RequestedLanguageId = null, List<string> RequestedRoutingSkillIds = null, List<RequestedRoutingsEnum> RequestedRoutings = null, long? RoutingPriority = null, string SessionId = null, string TeamId = null, UsedRoutingEnum? UsedRouting = null, string UserId = null, List<FlowActivityScoredAgent> ScoredAgents = null)
    {
        this.ActivityDate = ActivityDate;
        this.Metric = Metric;
        this.ActiveRouting = ActiveRouting;
        this.AddressFrom = AddressFrom;
        this.AddressTo = AddressTo;
        this.Ani = Ani;
        this.ConversationId = ConversationId;
        this.ConvertedFrom = ConvertedFrom;
        this.ConvertedTo = ConvertedTo;
        this.Direction = Direction;
        this.Dnis = Dnis;
        this.FlowId = FlowId;
        this.FlowType = FlowType;
        this.MediaType = MediaType;
        this.ParticipantName = ParticipantName;
        this.QueueId = QueueId;
        this.RequestedLanguageId = RequestedLanguageId;
        this.RequestedRoutingSkillIds = RequestedRoutingSkillIds;
        this.RequestedRoutings = RequestedRoutings;
        this.RoutingPriority = RoutingPriority;
        this.SessionId = SessionId;
        this.TeamId = TeamId;
        this.UsedRouting = UsedRouting;
        this.UserId = UserId;
        this.ScoredAgents = ScoredAgents;

    }



    /// <summary>
    /// The time at which the activity was observed. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The time at which the activity was observed. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("activityDate")]
    public DateTime? ActivityDate { get; set; }







    /// <summary>
    /// The address that initiated an action
    /// </summary>
    /// <value>The address that initiated an action</value>
    [JsonPropertyName("addressFrom")]
    public string AddressFrom { get; set; }



    /// <summary>
    /// The address receiving an action
    /// </summary>
    /// <value>The address receiving an action</value>
    [JsonPropertyName("addressTo")]
    public string AddressTo { get; set; }



    /// <summary>
    /// Automatic Number Identification (caller&#39;s number)
    /// </summary>
    /// <value>Automatic Number Identification (caller&#39;s number)</value>
    [JsonPropertyName("ani")]
    public string Ani { get; set; }



    /// <summary>
    /// Unique identifier for the conversation
    /// </summary>
    /// <value>Unique identifier for the conversation</value>
    [JsonPropertyName("conversationId")]
    public string ConversationId { get; set; }



    /// <summary>
    /// Session media type that was converted from in case of a media type conversion
    /// </summary>
    /// <value>Session media type that was converted from in case of a media type conversion</value>
    [JsonPropertyName("convertedFrom")]
    public string ConvertedFrom { get; set; }



    /// <summary>
    /// Session media type that was converted to in case of a media type conversion
    /// </summary>
    /// <value>Session media type that was converted to in case of a media type conversion</value>
    [JsonPropertyName("convertedTo")]
    public string ConvertedTo { get; set; }





    /// <summary>
    /// Dialed number identification service (number dialed by the calling party)
    /// </summary>
    /// <value>Dialed number identification service (number dialed by the calling party)</value>
    [JsonPropertyName("dnis")]
    public string Dnis { get; set; }



    /// <summary>
    /// The unique identifier of this flow
    /// </summary>
    /// <value>The unique identifier of this flow</value>
    [JsonPropertyName("flowId")]
    public string FlowId { get; set; }







    /// <summary>
    /// A human readable name identifying the participant
    /// </summary>
    /// <value>A human readable name identifying the participant</value>
    [JsonPropertyName("participantName")]
    public string ParticipantName { get; set; }



    /// <summary>
    /// Queue identifier
    /// </summary>
    /// <value>Queue identifier</value>
    [JsonPropertyName("queueId")]
    public string QueueId { get; set; }



    /// <summary>
    /// Unique identifier for the language requested for an interaction
    /// </summary>
    /// <value>Unique identifier for the language requested for an interaction</value>
    [JsonPropertyName("requestedLanguageId")]
    public string RequestedLanguageId { get; set; }



    /// <summary>
    /// Unique identifier(s) for skill(s) requested for an interaction
    /// </summary>
    /// <value>Unique identifier(s) for skill(s) requested for an interaction</value>
    [JsonPropertyName("requestedRoutingSkillIds")]
    public List<string> RequestedRoutingSkillIds { get; set; }



    /// <summary>
    /// Routing type(s) for requested/attempted routing methods.
    /// </summary>
    /// <value>Routing type(s) for requested/attempted routing methods.</value>
    [JsonPropertyName("requestedRoutings")]
    public List<RequestedRoutingsEnum> RequestedRoutings { get; set; }



    /// <summary>
    /// Routing priority for the current interaction
    /// </summary>
    /// <value>Routing priority for the current interaction</value>
    [JsonPropertyName("routingPriority")]
    public long? RoutingPriority { get; set; }



    /// <summary>
    /// The unique identifier of this session
    /// </summary>
    /// <value>The unique identifier of this session</value>
    [JsonPropertyName("sessionId")]
    public string SessionId { get; set; }



    /// <summary>
    /// The team ID the user is a member of
    /// </summary>
    /// <value>The team ID the user is a member of</value>
    [JsonPropertyName("teamId")]
    public string TeamId { get; set; }





    /// <summary>
    /// Unique identifier for the user
    /// </summary>
    /// <value>Unique identifier for the user</value>
    [JsonPropertyName("userId")]
    public string UserId { get; set; }



    /// <summary>
    /// Scored agents
    /// </summary>
    /// <value>Scored agents</value>
    [JsonPropertyName("scoredAgents")]
    public List<FlowActivityScoredAgent> ScoredAgents { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class FlowActivityEntityData {\n");

        sb.Append("  ActivityDate: ").Append(ActivityDate).Append("\n");
        sb.Append("  Metric: ").Append(Metric).Append("\n");
        sb.Append("  ActiveRouting: ").Append(ActiveRouting).Append("\n");
        sb.Append("  AddressFrom: ").Append(AddressFrom).Append("\n");
        sb.Append("  AddressTo: ").Append(AddressTo).Append("\n");
        sb.Append("  Ani: ").Append(Ani).Append("\n");
        sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
        sb.Append("  ConvertedFrom: ").Append(ConvertedFrom).Append("\n");
        sb.Append("  ConvertedTo: ").Append(ConvertedTo).Append("\n");
        sb.Append("  Direction: ").Append(Direction).Append("\n");
        sb.Append("  Dnis: ").Append(Dnis).Append("\n");
        sb.Append("  FlowId: ").Append(FlowId).Append("\n");
        sb.Append("  FlowType: ").Append(FlowType).Append("\n");
        sb.Append("  MediaType: ").Append(MediaType).Append("\n");
        sb.Append("  ParticipantName: ").Append(ParticipantName).Append("\n");
        sb.Append("  QueueId: ").Append(QueueId).Append("\n");
        sb.Append("  RequestedLanguageId: ").Append(RequestedLanguageId).Append("\n");
        sb.Append("  RequestedRoutingSkillIds: ").Append(RequestedRoutingSkillIds).Append("\n");
        sb.Append("  RequestedRoutings: ").Append(RequestedRoutings).Append("\n");
        sb.Append("  RoutingPriority: ").Append(RoutingPriority).Append("\n");
        sb.Append("  SessionId: ").Append(SessionId).Append("\n");
        sb.Append("  TeamId: ").Append(TeamId).Append("\n");
        sb.Append("  UsedRouting: ").Append(UsedRouting).Append("\n");
        sb.Append("  UserId: ").Append(UserId).Append("\n");
        sb.Append("  ScoredAgents: ").Append(ScoredAgents).Append("\n");
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
        return Equals(obj as FlowActivityEntityData);
    }

    /// <summary>
    /// Returns true if FlowActivityEntityData instances are equal
    /// </summary>
    /// <param name="other">Instance of FlowActivityEntityData to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(FlowActivityEntityData other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                ActivityDate == other.ActivityDate ||
                ActivityDate != null &&
                ActivityDate.Equals(other.ActivityDate)
            ) &&
            (
                Metric == other.Metric ||
                Metric != null &&
                Metric.Equals(other.Metric)
            ) &&
            (
                ActiveRouting == other.ActiveRouting ||
                ActiveRouting != null &&
                ActiveRouting.Equals(other.ActiveRouting)
            ) &&
            (
                AddressFrom == other.AddressFrom ||
                AddressFrom != null &&
                AddressFrom.Equals(other.AddressFrom)
            ) &&
            (
                AddressTo == other.AddressTo ||
                AddressTo != null &&
                AddressTo.Equals(other.AddressTo)
            ) &&
            (
                Ani == other.Ani ||
                Ani != null &&
                Ani.Equals(other.Ani)
            ) &&
            (
                ConversationId == other.ConversationId ||
                ConversationId != null &&
                ConversationId.Equals(other.ConversationId)
            ) &&
            (
                ConvertedFrom == other.ConvertedFrom ||
                ConvertedFrom != null &&
                ConvertedFrom.Equals(other.ConvertedFrom)
            ) &&
            (
                ConvertedTo == other.ConvertedTo ||
                ConvertedTo != null &&
                ConvertedTo.Equals(other.ConvertedTo)
            ) &&
            (
                Direction == other.Direction ||
                Direction != null &&
                Direction.Equals(other.Direction)
            ) &&
            (
                Dnis == other.Dnis ||
                Dnis != null &&
                Dnis.Equals(other.Dnis)
            ) &&
            (
                FlowId == other.FlowId ||
                FlowId != null &&
                FlowId.Equals(other.FlowId)
            ) &&
            (
                FlowType == other.FlowType ||
                FlowType != null &&
                FlowType.Equals(other.FlowType)
            ) &&
            (
                MediaType == other.MediaType ||
                MediaType != null &&
                MediaType.Equals(other.MediaType)
            ) &&
            (
                ParticipantName == other.ParticipantName ||
                ParticipantName != null &&
                ParticipantName.Equals(other.ParticipantName)
            ) &&
            (
                QueueId == other.QueueId ||
                QueueId != null &&
                QueueId.Equals(other.QueueId)
            ) &&
            (
                RequestedLanguageId == other.RequestedLanguageId ||
                RequestedLanguageId != null &&
                RequestedLanguageId.Equals(other.RequestedLanguageId)
            ) &&
            (
                RequestedRoutingSkillIds == other.RequestedRoutingSkillIds ||
                RequestedRoutingSkillIds != null &&
                RequestedRoutingSkillIds.SequenceEqual(other.RequestedRoutingSkillIds)
            ) &&
            (
                RequestedRoutings == other.RequestedRoutings ||
                RequestedRoutings != null &&
                RequestedRoutings.SequenceEqual(other.RequestedRoutings)
            ) &&
            (
                RoutingPriority == other.RoutingPriority ||
                RoutingPriority != null &&
                RoutingPriority.Equals(other.RoutingPriority)
            ) &&
            (
                SessionId == other.SessionId ||
                SessionId != null &&
                SessionId.Equals(other.SessionId)
            ) &&
            (
                TeamId == other.TeamId ||
                TeamId != null &&
                TeamId.Equals(other.TeamId)
            ) &&
            (
                UsedRouting == other.UsedRouting ||
                UsedRouting != null &&
                UsedRouting.Equals(other.UsedRouting)
            ) &&
            (
                UserId == other.UserId ||
                UserId != null &&
                UserId.Equals(other.UserId)
            ) &&
            (
                ScoredAgents == other.ScoredAgents ||
                ScoredAgents != null &&
                ScoredAgents.SequenceEqual(other.ScoredAgents)
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
            if (ActivityDate != null)
            {
                hash = hash * 59 + ActivityDate.GetHashCode();
            }

            if (Metric != null)
            {
                hash = hash * 59 + Metric.GetHashCode();
            }

            if (ActiveRouting != null)
            {
                hash = hash * 59 + ActiveRouting.GetHashCode();
            }

            if (AddressFrom != null)
            {
                hash = hash * 59 + AddressFrom.GetHashCode();
            }

            if (AddressTo != null)
            {
                hash = hash * 59 + AddressTo.GetHashCode();
            }

            if (Ani != null)
            {
                hash = hash * 59 + Ani.GetHashCode();
            }

            if (ConversationId != null)
            {
                hash = hash * 59 + ConversationId.GetHashCode();
            }

            if (ConvertedFrom != null)
            {
                hash = hash * 59 + ConvertedFrom.GetHashCode();
            }

            if (ConvertedTo != null)
            {
                hash = hash * 59 + ConvertedTo.GetHashCode();
            }

            if (Direction != null)
            {
                hash = hash * 59 + Direction.GetHashCode();
            }

            if (Dnis != null)
            {
                hash = hash * 59 + Dnis.GetHashCode();
            }

            if (FlowId != null)
            {
                hash = hash * 59 + FlowId.GetHashCode();
            }

            if (FlowType != null)
            {
                hash = hash * 59 + FlowType.GetHashCode();
            }

            if (MediaType != null)
            {
                hash = hash * 59 + MediaType.GetHashCode();
            }

            if (ParticipantName != null)
            {
                hash = hash * 59 + ParticipantName.GetHashCode();
            }

            if (QueueId != null)
            {
                hash = hash * 59 + QueueId.GetHashCode();
            }

            if (RequestedLanguageId != null)
            {
                hash = hash * 59 + RequestedLanguageId.GetHashCode();
            }

            if (RequestedRoutingSkillIds != null)
            {
                hash = hash * 59 + RequestedRoutingSkillIds.GetHashCode();
            }

            if (RequestedRoutings != null)
            {
                hash = hash * 59 + RequestedRoutings.GetHashCode();
            }

            if (RoutingPriority != null)
            {
                hash = hash * 59 + RoutingPriority.GetHashCode();
            }

            if (SessionId != null)
            {
                hash = hash * 59 + SessionId.GetHashCode();
            }

            if (TeamId != null)
            {
                hash = hash * 59 + TeamId.GetHashCode();
            }

            if (UsedRouting != null)
            {
                hash = hash * 59 + UsedRouting.GetHashCode();
            }

            if (UserId != null)
            {
                hash = hash * 59 + UserId.GetHashCode();
            }

            if (ScoredAgents != null)
            {
                hash = hash * 59 + ScoredAgents.GetHashCode();
            }

            return hash;
        }
    }
}
