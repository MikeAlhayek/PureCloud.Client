using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AcdEndDetailEventTopicAcdEndEvent
/// </summary>

public partial class AcdEndDetailEventTopicAcdEndEvent : IEquatable<AcdEndDetailEventTopicAcdEndEvent>
{
    /// <summary>
    /// Gets or Sets DisconnectType
    /// </summary>
    
    public enum DisconnectTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Unknown for "UNKNOWN"
        /// </summary>
        [EnumMember(Value = "UNKNOWN")]
        Unknown,

        /// <summary>
        /// Enum Endpoint for "ENDPOINT"
        /// </summary>
        [EnumMember(Value = "ENDPOINT")]
        Endpoint,

        /// <summary>
        /// Enum Client for "CLIENT"
        /// </summary>
        [EnumMember(Value = "CLIENT")]
        Client,

        /// <summary>
        /// Enum System for "SYSTEM"
        /// </summary>
        [EnumMember(Value = "SYSTEM")]
        System,

        /// <summary>
        /// Enum Transfer for "TRANSFER"
        /// </summary>
        [EnumMember(Value = "TRANSFER")]
        Transfer,

        /// <summary>
        /// Enum Error for "ERROR"
        /// </summary>
        [EnumMember(Value = "ERROR")]
        Error,

        /// <summary>
        /// Enum Peer for "PEER"
        /// </summary>
        [EnumMember(Value = "PEER")]
        Peer,

        /// <summary>
        /// Enum Other for "OTHER"
        /// </summary>
        [EnumMember(Value = "OTHER")]
        Other,

        /// <summary>
        /// Enum Spam for "SPAM"
        /// </summary>
        [EnumMember(Value = "SPAM")]
        Spam,

        /// <summary>
        /// Enum Timeout for "TIMEOUT"
        /// </summary>
        [EnumMember(Value = "TIMEOUT")]
        Timeout,

        /// <summary>
        /// Enum TransportFailure for "TRANSPORT_FAILURE"
        /// </summary>
        [EnumMember(Value = "TRANSPORT_FAILURE")]
        TransportFailure,

        /// <summary>
        /// Enum ConferenceTransfer for "CONFERENCE_TRANSFER"
        /// </summary>
        [EnumMember(Value = "CONFERENCE_TRANSFER")]
        ConferenceTransfer,

        /// <summary>
        /// Enum ConsultTransfer for "CONSULT_TRANSFER"
        /// </summary>
        [EnumMember(Value = "CONSULT_TRANSFER")]
        ConsultTransfer,

        /// <summary>
        /// Enum ForwardTransfer for "FORWARD_TRANSFER"
        /// </summary>
        [EnumMember(Value = "FORWARD_TRANSFER")]
        ForwardTransfer,

        /// <summary>
        /// Enum NoAnswerTransfer for "NO_ANSWER_TRANSFER"
        /// </summary>
        [EnumMember(Value = "NO_ANSWER_TRANSFER")]
        NoAnswerTransfer,

        /// <summary>
        /// Enum NotAvailableTransfer for "NOT_AVAILABLE_TRANSFER"
        /// </summary>
        [EnumMember(Value = "NOT_AVAILABLE_TRANSFER")]
        NotAvailableTransfer,

        /// <summary>
        /// Enum Uncallable for "UNCALLABLE"
        /// </summary>
        [EnumMember(Value = "UNCALLABLE")]
        Uncallable,

        /// <summary>
        /// Enum DndEndpoint for "DND_ENDPOINT"
        /// </summary>
        [EnumMember(Value = "DND_ENDPOINT")]
        DndEndpoint,

        /// <summary>
        /// Enum DndTransfer for "DND_TRANSFER"
        /// </summary>
        [EnumMember(Value = "DND_TRANSFER")]
        DndTransfer
    }
    /// <summary>
    /// Gets or Sets MediaType
    /// </summary>
    
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
        /// Enum Unknown for "UNKNOWN"
        /// </summary>
        [EnumMember(Value = "UNKNOWN")]
        Unknown,

        /// <summary>
        /// Enum Voice for "VOICE"
        /// </summary>
        [EnumMember(Value = "VOICE")]
        Voice,

        /// <summary>
        /// Enum Chat for "CHAT"
        /// </summary>
        [EnumMember(Value = "CHAT")]
        Chat,

        /// <summary>
        /// Enum Email for "EMAIL"
        /// </summary>
        [EnumMember(Value = "EMAIL")]
        Email,

        /// <summary>
        /// Enum Callback for "CALLBACK"
        /// </summary>
        [EnumMember(Value = "CALLBACK")]
        Callback,

        /// <summary>
        /// Enum Cobrowse for "COBROWSE"
        /// </summary>
        [EnumMember(Value = "COBROWSE")]
        Cobrowse,

        /// <summary>
        /// Enum Video for "VIDEO"
        /// </summary>
        [EnumMember(Value = "VIDEO")]
        Video,

        /// <summary>
        /// Enum Screenshare for "SCREENSHARE"
        /// </summary>
        [EnumMember(Value = "SCREENSHARE")]
        Screenshare,

        /// <summary>
        /// Enum Message for "MESSAGE"
        /// </summary>
        [EnumMember(Value = "MESSAGE")]
        Message,

        /// <summary>
        /// Enum Internalmessage for "INTERNALMESSAGE"
        /// </summary>
        [EnumMember(Value = "INTERNALMESSAGE")]
        Internalmessage
    }
    /// <summary>
    /// Gets or Sets Direction
    /// </summary>
    
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
        /// Enum Unknown for "UNKNOWN"
        /// </summary>
        [EnumMember(Value = "UNKNOWN")]
        Unknown,

        /// <summary>
        /// Enum Inbound for "INBOUND"
        /// </summary>
        [EnumMember(Value = "INBOUND")]
        Inbound,

        /// <summary>
        /// Enum Outbound for "OUTBOUND"
        /// </summary>
        [EnumMember(Value = "OUTBOUND")]
        Outbound
    }
    /// <summary>
    /// Gets or Sets MessageType
    /// </summary>
    
    public enum MessageTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Unknown for "UNKNOWN"
        /// </summary>
        [EnumMember(Value = "UNKNOWN")]
        Unknown,

        /// <summary>
        /// Enum Sms for "SMS"
        /// </summary>
        [EnumMember(Value = "SMS")]
        Sms,

        /// <summary>
        /// Enum Twitter for "TWITTER"
        /// </summary>
        [EnumMember(Value = "TWITTER")]
        Twitter,

        /// <summary>
        /// Enum Facebook for "FACEBOOK"
        /// </summary>
        [EnumMember(Value = "FACEBOOK")]
        Facebook,

        /// <summary>
        /// Enum Line for "LINE"
        /// </summary>
        [EnumMember(Value = "LINE")]
        Line,

        /// <summary>
        /// Enum Whatsapp for "WHATSAPP"
        /// </summary>
        [EnumMember(Value = "WHATSAPP")]
        Whatsapp,

        /// <summary>
        /// Enum Webmessaging for "WEBMESSAGING"
        /// </summary>
        [EnumMember(Value = "WEBMESSAGING")]
        Webmessaging,

        /// <summary>
        /// Enum Open for "OPEN"
        /// </summary>
        [EnumMember(Value = "OPEN")]
        Open,

        /// <summary>
        /// Enum Instagram for "INSTAGRAM"
        /// </summary>
        [EnumMember(Value = "INSTAGRAM")]
        Instagram,

        /// <summary>
        /// Enum Apple for "APPLE"
        /// </summary>
        [EnumMember(Value = "APPLE")]
        Apple
    }
    /// <summary>
    /// Gets or Sets AcdOutcome
    /// </summary>
    
    public enum AcdOutcomeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Unknown for "UNKNOWN"
        /// </summary>
        [EnumMember(Value = "UNKNOWN")]
        Unknown,

        /// <summary>
        /// Enum Abandon for "ABANDON"
        /// </summary>
        [EnumMember(Value = "ABANDON")]
        Abandon,

        /// <summary>
        /// Enum Answered for "ANSWERED"
        /// </summary>
        [EnumMember(Value = "ANSWERED")]
        Answered,

        /// <summary>
        /// Enum FlowOut for "FLOW_OUT"
        /// </summary>
        [EnumMember(Value = "FLOW_OUT")]
        FlowOut
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
        /// Enum Unknown for "UNKNOWN"
        /// </summary>
        [EnumMember(Value = "UNKNOWN")]
        Unknown,

        /// <summary>
        /// Enum Manual for "MANUAL"
        /// </summary>
        [EnumMember(Value = "MANUAL")]
        Manual,

        /// <summary>
        /// Enum Predictive for "PREDICTIVE"
        /// </summary>
        [EnumMember(Value = "PREDICTIVE")]
        Predictive,

        /// <summary>
        /// Enum Preferred for "PREFERRED"
        /// </summary>
        [EnumMember(Value = "PREFERRED")]
        Preferred,

        /// <summary>
        /// Enum Last for "LAST"
        /// </summary>
        [EnumMember(Value = "LAST")]
        Last,

        /// <summary>
        /// Enum Bullseye for "BULLSEYE"
        /// </summary>
        [EnumMember(Value = "BULLSEYE")]
        Bullseye,

        /// <summary>
        /// Enum Standard for "STANDARD"
        /// </summary>
        [EnumMember(Value = "STANDARD")]
        Standard,

        /// <summary>
        /// Enum Other for "OTHER"
        /// </summary>
        [EnumMember(Value = "OTHER")]
        Other,

        /// <summary>
        /// Enum Conditional for "CONDITIONAL"
        /// </summary>
        [EnumMember(Value = "CONDITIONAL")]
        Conditional,

        /// <summary>
        /// Enum Vip for "VIP"
        /// </summary>
        [EnumMember(Value = "VIP")]
        Vip
    }
    /// <summary>
    /// Gets or Sets UsedRouting
    /// </summary>
    
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
        /// Enum Unknown for "UNKNOWN"
        /// </summary>
        [EnumMember(Value = "UNKNOWN")]
        Unknown,

        /// <summary>
        /// Enum Manual for "MANUAL"
        /// </summary>
        [EnumMember(Value = "MANUAL")]
        Manual,

        /// <summary>
        /// Enum Predictive for "PREDICTIVE"
        /// </summary>
        [EnumMember(Value = "PREDICTIVE")]
        Predictive,

        /// <summary>
        /// Enum Preferred for "PREFERRED"
        /// </summary>
        [EnumMember(Value = "PREFERRED")]
        Preferred,

        /// <summary>
        /// Enum Last for "LAST"
        /// </summary>
        [EnumMember(Value = "LAST")]
        Last,

        /// <summary>
        /// Enum Bullseye for "BULLSEYE"
        /// </summary>
        [EnumMember(Value = "BULLSEYE")]
        Bullseye,

        /// <summary>
        /// Enum Standard for "STANDARD"
        /// </summary>
        [EnumMember(Value = "STANDARD")]
        Standard,

        /// <summary>
        /// Enum Other for "OTHER"
        /// </summary>
        [EnumMember(Value = "OTHER")]
        Other,

        /// <summary>
        /// Enum Conditional for "CONDITIONAL"
        /// </summary>
        [EnumMember(Value = "CONDITIONAL")]
        Conditional,

        /// <summary>
        /// Enum Vip for "VIP"
        /// </summary>
        [EnumMember(Value = "VIP")]
        Vip
    }
    /// <summary>
    /// Gets or Sets DisconnectType
    /// </summary>
    [JsonPropertyName("disconnectType")]
    public DisconnectTypeEnum? DisconnectType { get; set; }
    /// <summary>
    /// Gets or Sets MediaType
    /// </summary>
    [JsonPropertyName("mediaType")]
    public MediaTypeEnum? MediaType { get; set; }
    /// <summary>
    /// Gets or Sets Direction
    /// </summary>
    [JsonPropertyName("direction")]
    public DirectionEnum? Direction { get; set; }
    /// <summary>
    /// Gets or Sets MessageType
    /// </summary>
    [JsonPropertyName("messageType")]
    public MessageTypeEnum? MessageType { get; set; }
    /// <summary>
    /// Gets or Sets AcdOutcome
    /// </summary>
    [JsonPropertyName("acdOutcome")]
    public AcdOutcomeEnum? AcdOutcome { get; set; }
    /// <summary>
    /// Gets or Sets UsedRouting
    /// </summary>
    [JsonPropertyName("usedRouting")]
    public UsedRoutingEnum? UsedRouting { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="AcdEndDetailEventTopicAcdEndEvent" /> class.
    /// </summary>
    /// <param name="EventTime">EventTime.</param>
    /// <param name="ConversationId">ConversationId.</param>
    /// <param name="ParticipantId">ParticipantId.</param>
    /// <param name="SessionId">SessionId.</param>
    /// <param name="DisconnectType">DisconnectType.</param>
    /// <param name="MediaType">MediaType.</param>
    /// <param name="Provider">Provider.</param>
    /// <param name="Direction">Direction.</param>
    /// <param name="Ani">Ani.</param>
    /// <param name="Dnis">Dnis.</param>
    /// <param name="AddressTo">AddressTo.</param>
    /// <param name="AddressFrom">AddressFrom.</param>
    /// <param name="CallbackUserName">CallbackUserName.</param>
    /// <param name="CallbackNumbers">CallbackNumbers.</param>
    /// <param name="CallbackScheduledTime">CallbackScheduledTime.</param>
    /// <param name="Subject">Subject.</param>
    /// <param name="MessageType">MessageType.</param>
    /// <param name="QueueId">QueueId.</param>
    /// <param name="DivisionId">DivisionId.</param>
    /// <param name="AcdOutcome">AcdOutcome.</param>
    /// <param name="AnsweredUserId">AnsweredUserId.</param>
    /// <param name="RequestedRoutings">RequestedRoutings.</param>
    /// <param name="UsedRouting">UsedRouting.</param>
    /// <param name="RequestedRoutingSkillIds">RequestedRoutingSkillIds.</param>
    /// <param name="RequestedLanguageId">RequestedLanguageId.</param>
    /// <param name="RequestedRoutingUserIds">RequestedRoutingUserIds.</param>
    /// <param name="RoutingPriority">RoutingPriority.</param>
    /// <param name="ConnectedDurationMs">ConnectedDurationMs.</param>
    /// <param name="ConversationExternalContactIds">ConversationExternalContactIds.</param>
    /// <param name="ConversationExternalOrganizationIds">ConversationExternalOrganizationIds.</param>
    /// <param name="UtilizationLabel">UtilizationLabel.</param>
    /// <param name="FlowType">FlowType.</param>
    public AcdEndDetailEventTopicAcdEndEvent(long? EventTime = null, string ConversationId = null, string ParticipantId = null, string SessionId = null, DisconnectTypeEnum? DisconnectType = null, MediaTypeEnum? MediaType = null, string Provider = null, DirectionEnum? Direction = null, string Ani = null, string Dnis = null, string AddressTo = null, string AddressFrom = null, string CallbackUserName = null, List<string> CallbackNumbers = null, long? CallbackScheduledTime = null, string Subject = null, MessageTypeEnum? MessageType = null, string QueueId = null, string DivisionId = null, AcdOutcomeEnum? AcdOutcome = null, string AnsweredUserId = null, List<RequestedRoutingsEnum> RequestedRoutings = null, UsedRoutingEnum? UsedRouting = null, List<Guid?> RequestedRoutingSkillIds = null, string RequestedLanguageId = null, List<Guid?> RequestedRoutingUserIds = null, long? RoutingPriority = null, long? ConnectedDurationMs = null, List<string> ConversationExternalContactIds = null, List<string> ConversationExternalOrganizationIds = null, string UtilizationLabel = null, string FlowType = null)
    {
        this.EventTime = EventTime;
        this.ConversationId = ConversationId;
        this.ParticipantId = ParticipantId;
        this.SessionId = SessionId;
        this.DisconnectType = DisconnectType;
        this.MediaType = MediaType;
        this.Provider = Provider;
        this.Direction = Direction;
        this.Ani = Ani;
        this.Dnis = Dnis;
        this.AddressTo = AddressTo;
        this.AddressFrom = AddressFrom;
        this.CallbackUserName = CallbackUserName;
        this.CallbackNumbers = CallbackNumbers;
        this.CallbackScheduledTime = CallbackScheduledTime;
        this.Subject = Subject;
        this.MessageType = MessageType;
        this.QueueId = QueueId;
        this.DivisionId = DivisionId;
        this.AcdOutcome = AcdOutcome;
        this.AnsweredUserId = AnsweredUserId;
        this.RequestedRoutings = RequestedRoutings;
        this.UsedRouting = UsedRouting;
        this.RequestedRoutingSkillIds = RequestedRoutingSkillIds;
        this.RequestedLanguageId = RequestedLanguageId;
        this.RequestedRoutingUserIds = RequestedRoutingUserIds;
        this.RoutingPriority = RoutingPriority;
        this.ConnectedDurationMs = ConnectedDurationMs;
        this.ConversationExternalContactIds = ConversationExternalContactIds;
        this.ConversationExternalOrganizationIds = ConversationExternalOrganizationIds;
        this.UtilizationLabel = UtilizationLabel;
        this.FlowType = FlowType;

    }



    /// <summary>
    /// Gets or Sets EventTime
    /// </summary>
    [JsonPropertyName("eventTime")]
    public long? EventTime { get; set; }



    /// <summary>
    /// Gets or Sets ConversationId
    /// </summary>
    [JsonPropertyName("conversationId")]
    public string ConversationId { get; set; }



    /// <summary>
    /// Gets or Sets ParticipantId
    /// </summary>
    [JsonPropertyName("participantId")]
    public string ParticipantId { get; set; }



    /// <summary>
    /// Gets or Sets SessionId
    /// </summary>
    [JsonPropertyName("sessionId")]
    public string SessionId { get; set; }







    /// <summary>
    /// Gets or Sets Provider
    /// </summary>
    [JsonPropertyName("provider")]
    public string Provider { get; set; }





    /// <summary>
    /// Gets or Sets Ani
    /// </summary>
    [JsonPropertyName("ani")]
    public string Ani { get; set; }



    /// <summary>
    /// Gets or Sets Dnis
    /// </summary>
    [JsonPropertyName("dnis")]
    public string Dnis { get; set; }



    /// <summary>
    /// Gets or Sets AddressTo
    /// </summary>
    [JsonPropertyName("addressTo")]
    public string AddressTo { get; set; }



    /// <summary>
    /// Gets or Sets AddressFrom
    /// </summary>
    [JsonPropertyName("addressFrom")]
    public string AddressFrom { get; set; }



    /// <summary>
    /// Gets or Sets CallbackUserName
    /// </summary>
    [JsonPropertyName("callbackUserName")]
    public string CallbackUserName { get; set; }



    /// <summary>
    /// Gets or Sets CallbackNumbers
    /// </summary>
    [JsonPropertyName("callbackNumbers")]
    public List<string> CallbackNumbers { get; set; }



    /// <summary>
    /// Gets or Sets CallbackScheduledTime
    /// </summary>
    [JsonPropertyName("callbackScheduledTime")]
    public long? CallbackScheduledTime { get; set; }



    /// <summary>
    /// Gets or Sets Subject
    /// </summary>
    [JsonPropertyName("subject")]
    public string Subject { get; set; }





    /// <summary>
    /// Gets or Sets QueueId
    /// </summary>
    [JsonPropertyName("queueId")]
    public string QueueId { get; set; }



    /// <summary>
    /// Gets or Sets DivisionId
    /// </summary>
    [JsonPropertyName("divisionId")]
    public string DivisionId { get; set; }





    /// <summary>
    /// Gets or Sets AnsweredUserId
    /// </summary>
    [JsonPropertyName("answeredUserId")]
    public string AnsweredUserId { get; set; }



    /// <summary>
    /// Gets or Sets RequestedRoutings
    /// </summary>
    [JsonPropertyName("requestedRoutings")]
    public List<RequestedRoutingsEnum> RequestedRoutings { get; set; }





    /// <summary>
    /// Gets or Sets RequestedRoutingSkillIds
    /// </summary>
    [JsonPropertyName("requestedRoutingSkillIds")]
    public List<Guid?> RequestedRoutingSkillIds { get; set; }



    /// <summary>
    /// Gets or Sets RequestedLanguageId
    /// </summary>
    [JsonPropertyName("requestedLanguageId")]
    public string RequestedLanguageId { get; set; }



    /// <summary>
    /// Gets or Sets RequestedRoutingUserIds
    /// </summary>
    [JsonPropertyName("requestedRoutingUserIds")]
    public List<Guid?> RequestedRoutingUserIds { get; set; }



    /// <summary>
    /// Gets or Sets RoutingPriority
    /// </summary>
    [JsonPropertyName("routingPriority")]
    public long? RoutingPriority { get; set; }



    /// <summary>
    /// Gets or Sets ConnectedDurationMs
    /// </summary>
    [JsonPropertyName("connectedDurationMs")]
    public long? ConnectedDurationMs { get; set; }



    /// <summary>
    /// Gets or Sets ConversationExternalContactIds
    /// </summary>
    [JsonPropertyName("conversationExternalContactIds")]
    public List<string> ConversationExternalContactIds { get; set; }



    /// <summary>
    /// Gets or Sets ConversationExternalOrganizationIds
    /// </summary>
    [JsonPropertyName("conversationExternalOrganizationIds")]
    public List<string> ConversationExternalOrganizationIds { get; set; }



    /// <summary>
    /// Gets or Sets UtilizationLabel
    /// </summary>
    [JsonPropertyName("utilizationLabel")]
    public string UtilizationLabel { get; set; }



    /// <summary>
    /// Gets or Sets FlowType
    /// </summary>
    [JsonPropertyName("flowType")]
    public string FlowType { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AcdEndDetailEventTopicAcdEndEvent {\n");

        sb.Append("  EventTime: ").Append(EventTime).Append("\n");
        sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
        sb.Append("  ParticipantId: ").Append(ParticipantId).Append("\n");
        sb.Append("  SessionId: ").Append(SessionId).Append("\n");
        sb.Append("  DisconnectType: ").Append(DisconnectType).Append("\n");
        sb.Append("  MediaType: ").Append(MediaType).Append("\n");
        sb.Append("  Provider: ").Append(Provider).Append("\n");
        sb.Append("  Direction: ").Append(Direction).Append("\n");
        sb.Append("  Ani: ").Append(Ani).Append("\n");
        sb.Append("  Dnis: ").Append(Dnis).Append("\n");
        sb.Append("  AddressTo: ").Append(AddressTo).Append("\n");
        sb.Append("  AddressFrom: ").Append(AddressFrom).Append("\n");
        sb.Append("  CallbackUserName: ").Append(CallbackUserName).Append("\n");
        sb.Append("  CallbackNumbers: ").Append(CallbackNumbers).Append("\n");
        sb.Append("  CallbackScheduledTime: ").Append(CallbackScheduledTime).Append("\n");
        sb.Append("  Subject: ").Append(Subject).Append("\n");
        sb.Append("  MessageType: ").Append(MessageType).Append("\n");
        sb.Append("  QueueId: ").Append(QueueId).Append("\n");
        sb.Append("  DivisionId: ").Append(DivisionId).Append("\n");
        sb.Append("  AcdOutcome: ").Append(AcdOutcome).Append("\n");
        sb.Append("  AnsweredUserId: ").Append(AnsweredUserId).Append("\n");
        sb.Append("  RequestedRoutings: ").Append(RequestedRoutings).Append("\n");
        sb.Append("  UsedRouting: ").Append(UsedRouting).Append("\n");
        sb.Append("  RequestedRoutingSkillIds: ").Append(RequestedRoutingSkillIds).Append("\n");
        sb.Append("  RequestedLanguageId: ").Append(RequestedLanguageId).Append("\n");
        sb.Append("  RequestedRoutingUserIds: ").Append(RequestedRoutingUserIds).Append("\n");
        sb.Append("  RoutingPriority: ").Append(RoutingPriority).Append("\n");
        sb.Append("  ConnectedDurationMs: ").Append(ConnectedDurationMs).Append("\n");
        sb.Append("  ConversationExternalContactIds: ").Append(ConversationExternalContactIds).Append("\n");
        sb.Append("  ConversationExternalOrganizationIds: ").Append(ConversationExternalOrganizationIds).Append("\n");
        sb.Append("  UtilizationLabel: ").Append(UtilizationLabel).Append("\n");
        sb.Append("  FlowType: ").Append(FlowType).Append("\n");
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
        return Equals(obj as AcdEndDetailEventTopicAcdEndEvent);
    }

    /// <summary>
    /// Returns true if AcdEndDetailEventTopicAcdEndEvent instances are equal
    /// </summary>
    /// <param name="other">Instance of AcdEndDetailEventTopicAcdEndEvent to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AcdEndDetailEventTopicAcdEndEvent other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                EventTime == other.EventTime ||
                EventTime != null &&
                EventTime.Equals(other.EventTime)
            ) &&
            (
                ConversationId == other.ConversationId ||
                ConversationId != null &&
                ConversationId.Equals(other.ConversationId)
            ) &&
            (
                ParticipantId == other.ParticipantId ||
                ParticipantId != null &&
                ParticipantId.Equals(other.ParticipantId)
            ) &&
            (
                SessionId == other.SessionId ||
                SessionId != null &&
                SessionId.Equals(other.SessionId)
            ) &&
            (
                DisconnectType == other.DisconnectType ||
                DisconnectType != null &&
                DisconnectType.Equals(other.DisconnectType)
            ) &&
            (
                MediaType == other.MediaType ||
                MediaType != null &&
                MediaType.Equals(other.MediaType)
            ) &&
            (
                Provider == other.Provider ||
                Provider != null &&
                Provider.Equals(other.Provider)
            ) &&
            (
                Direction == other.Direction ||
                Direction != null &&
                Direction.Equals(other.Direction)
            ) &&
            (
                Ani == other.Ani ||
                Ani != null &&
                Ani.Equals(other.Ani)
            ) &&
            (
                Dnis == other.Dnis ||
                Dnis != null &&
                Dnis.Equals(other.Dnis)
            ) &&
            (
                AddressTo == other.AddressTo ||
                AddressTo != null &&
                AddressTo.Equals(other.AddressTo)
            ) &&
            (
                AddressFrom == other.AddressFrom ||
                AddressFrom != null &&
                AddressFrom.Equals(other.AddressFrom)
            ) &&
            (
                CallbackUserName == other.CallbackUserName ||
                CallbackUserName != null &&
                CallbackUserName.Equals(other.CallbackUserName)
            ) &&
            (
                CallbackNumbers == other.CallbackNumbers ||
                CallbackNumbers != null &&
                CallbackNumbers.SequenceEqual(other.CallbackNumbers)
            ) &&
            (
                CallbackScheduledTime == other.CallbackScheduledTime ||
                CallbackScheduledTime != null &&
                CallbackScheduledTime.Equals(other.CallbackScheduledTime)
            ) &&
            (
                Subject == other.Subject ||
                Subject != null &&
                Subject.Equals(other.Subject)
            ) &&
            (
                MessageType == other.MessageType ||
                MessageType != null &&
                MessageType.Equals(other.MessageType)
            ) &&
            (
                QueueId == other.QueueId ||
                QueueId != null &&
                QueueId.Equals(other.QueueId)
            ) &&
            (
                DivisionId == other.DivisionId ||
                DivisionId != null &&
                DivisionId.Equals(other.DivisionId)
            ) &&
            (
                AcdOutcome == other.AcdOutcome ||
                AcdOutcome != null &&
                AcdOutcome.Equals(other.AcdOutcome)
            ) &&
            (
                AnsweredUserId == other.AnsweredUserId ||
                AnsweredUserId != null &&
                AnsweredUserId.Equals(other.AnsweredUserId)
            ) &&
            (
                RequestedRoutings == other.RequestedRoutings ||
                RequestedRoutings != null &&
                RequestedRoutings.SequenceEqual(other.RequestedRoutings)
            ) &&
            (
                UsedRouting == other.UsedRouting ||
                UsedRouting != null &&
                UsedRouting.Equals(other.UsedRouting)
            ) &&
            (
                RequestedRoutingSkillIds == other.RequestedRoutingSkillIds ||
                RequestedRoutingSkillIds != null &&
                RequestedRoutingSkillIds.SequenceEqual(other.RequestedRoutingSkillIds)
            ) &&
            (
                RequestedLanguageId == other.RequestedLanguageId ||
                RequestedLanguageId != null &&
                RequestedLanguageId.Equals(other.RequestedLanguageId)
            ) &&
            (
                RequestedRoutingUserIds == other.RequestedRoutingUserIds ||
                RequestedRoutingUserIds != null &&
                RequestedRoutingUserIds.SequenceEqual(other.RequestedRoutingUserIds)
            ) &&
            (
                RoutingPriority == other.RoutingPriority ||
                RoutingPriority != null &&
                RoutingPriority.Equals(other.RoutingPriority)
            ) &&
            (
                ConnectedDurationMs == other.ConnectedDurationMs ||
                ConnectedDurationMs != null &&
                ConnectedDurationMs.Equals(other.ConnectedDurationMs)
            ) &&
            (
                ConversationExternalContactIds == other.ConversationExternalContactIds ||
                ConversationExternalContactIds != null &&
                ConversationExternalContactIds.SequenceEqual(other.ConversationExternalContactIds)
            ) &&
            (
                ConversationExternalOrganizationIds == other.ConversationExternalOrganizationIds ||
                ConversationExternalOrganizationIds != null &&
                ConversationExternalOrganizationIds.SequenceEqual(other.ConversationExternalOrganizationIds)
            ) &&
            (
                UtilizationLabel == other.UtilizationLabel ||
                UtilizationLabel != null &&
                UtilizationLabel.Equals(other.UtilizationLabel)
            ) &&
            (
                FlowType == other.FlowType ||
                FlowType != null &&
                FlowType.Equals(other.FlowType)
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
            if (EventTime != null)
            {
                hash = hash * 59 + EventTime.GetHashCode();
            }

            if (ConversationId != null)
            {
                hash = hash * 59 + ConversationId.GetHashCode();
            }

            if (ParticipantId != null)
            {
                hash = hash * 59 + ParticipantId.GetHashCode();
            }

            if (SessionId != null)
            {
                hash = hash * 59 + SessionId.GetHashCode();
            }

            if (DisconnectType != null)
            {
                hash = hash * 59 + DisconnectType.GetHashCode();
            }

            if (MediaType != null)
            {
                hash = hash * 59 + MediaType.GetHashCode();
            }

            if (Provider != null)
            {
                hash = hash * 59 + Provider.GetHashCode();
            }

            if (Direction != null)
            {
                hash = hash * 59 + Direction.GetHashCode();
            }

            if (Ani != null)
            {
                hash = hash * 59 + Ani.GetHashCode();
            }

            if (Dnis != null)
            {
                hash = hash * 59 + Dnis.GetHashCode();
            }

            if (AddressTo != null)
            {
                hash = hash * 59 + AddressTo.GetHashCode();
            }

            if (AddressFrom != null)
            {
                hash = hash * 59 + AddressFrom.GetHashCode();
            }

            if (CallbackUserName != null)
            {
                hash = hash * 59 + CallbackUserName.GetHashCode();
            }

            if (CallbackNumbers != null)
            {
                hash = hash * 59 + CallbackNumbers.GetHashCode();
            }

            if (CallbackScheduledTime != null)
            {
                hash = hash * 59 + CallbackScheduledTime.GetHashCode();
            }

            if (Subject != null)
            {
                hash = hash * 59 + Subject.GetHashCode();
            }

            if (MessageType != null)
            {
                hash = hash * 59 + MessageType.GetHashCode();
            }

            if (QueueId != null)
            {
                hash = hash * 59 + QueueId.GetHashCode();
            }

            if (DivisionId != null)
            {
                hash = hash * 59 + DivisionId.GetHashCode();
            }

            if (AcdOutcome != null)
            {
                hash = hash * 59 + AcdOutcome.GetHashCode();
            }

            if (AnsweredUserId != null)
            {
                hash = hash * 59 + AnsweredUserId.GetHashCode();
            }

            if (RequestedRoutings != null)
            {
                hash = hash * 59 + RequestedRoutings.GetHashCode();
            }

            if (UsedRouting != null)
            {
                hash = hash * 59 + UsedRouting.GetHashCode();
            }

            if (RequestedRoutingSkillIds != null)
            {
                hash = hash * 59 + RequestedRoutingSkillIds.GetHashCode();
            }

            if (RequestedLanguageId != null)
            {
                hash = hash * 59 + RequestedLanguageId.GetHashCode();
            }

            if (RequestedRoutingUserIds != null)
            {
                hash = hash * 59 + RequestedRoutingUserIds.GetHashCode();
            }

            if (RoutingPriority != null)
            {
                hash = hash * 59 + RoutingPriority.GetHashCode();
            }

            if (ConnectedDurationMs != null)
            {
                hash = hash * 59 + ConnectedDurationMs.GetHashCode();
            }

            if (ConversationExternalContactIds != null)
            {
                hash = hash * 59 + ConversationExternalContactIds.GetHashCode();
            }

            if (ConversationExternalOrganizationIds != null)
            {
                hash = hash * 59 + ConversationExternalOrganizationIds.GetHashCode();
            }

            if (UtilizationLabel != null)
            {
                hash = hash * 59 + UtilizationLabel.GetHashCode();
            }

            if (FlowType != null)
            {
                hash = hash * 59 + FlowType.GetHashCode();
            }

            return hash;
        }
    }
}
