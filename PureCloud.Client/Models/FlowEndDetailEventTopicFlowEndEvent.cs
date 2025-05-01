using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// FlowEndDetailEventTopicFlowEndEvent
/// </summary>
[DataContract]
public partial class FlowEndDetailEventTopicFlowEndEvent : IEquatable<FlowEndDetailEventTopicFlowEndEvent>
{
    /// <summary>
    /// Gets or Sets DisconnectType
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
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
    [JsonConverter(typeof(JsonStringEnumConverter))]
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
    [JsonConverter(typeof(JsonStringEnumConverter))]
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
    [JsonConverter(typeof(JsonStringEnumConverter))]
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
    /// Gets or Sets FlowType
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
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
        /// Enum Unknown for "UNKNOWN"
        /// </summary>
        [EnumMember(Value = "UNKNOWN")]
        Unknown,

        /// <summary>
        /// Enum Inboundcall for "INBOUNDCALL"
        /// </summary>
        [EnumMember(Value = "INBOUNDCALL")]
        Inboundcall,

        /// <summary>
        /// Enum Outboundcall for "OUTBOUNDCALL"
        /// </summary>
        [EnumMember(Value = "OUTBOUNDCALL")]
        Outboundcall,

        /// <summary>
        /// Enum Inqueuecall for "INQUEUECALL"
        /// </summary>
        [EnumMember(Value = "INQUEUECALL")]
        Inqueuecall,

        /// <summary>
        /// Enum Securecall for "SECURECALL"
        /// </summary>
        [EnumMember(Value = "SECURECALL")]
        Securecall,

        /// <summary>
        /// Enum Inboundemail for "INBOUNDEMAIL"
        /// </summary>
        [EnumMember(Value = "INBOUNDEMAIL")]
        Inboundemail,

        /// <summary>
        /// Enum Surveyinvite for "SURVEYINVITE"
        /// </summary>
        [EnumMember(Value = "SURVEYINVITE")]
        Surveyinvite,

        /// <summary>
        /// Enum Inboundshortmessage for "INBOUNDSHORTMESSAGE"
        /// </summary>
        [EnumMember(Value = "INBOUNDSHORTMESSAGE")]
        Inboundshortmessage,

        /// <summary>
        /// Enum Inboundchat for "INBOUNDCHAT"
        /// </summary>
        [EnumMember(Value = "INBOUNDCHAT")]
        Inboundchat,

        /// <summary>
        /// Enum Workflow for "WORKFLOW"
        /// </summary>
        [EnumMember(Value = "WORKFLOW")]
        Workflow,

        /// <summary>
        /// Enum Bot for "BOT"
        /// </summary>
        [EnumMember(Value = "BOT")]
        Bot,

        /// <summary>
        /// Enum Digitalbot for "DIGITALBOT"
        /// </summary>
        [EnumMember(Value = "DIGITALBOT")]
        Digitalbot,

        /// <summary>
        /// Enum Commonmodule for "COMMONMODULE"
        /// </summary>
        [EnumMember(Value = "COMMONMODULE")]
        Commonmodule,

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
        /// Enum Workitem for "WORKITEM"
        /// </summary>
        [EnumMember(Value = "WORKITEM")]
        Workitem,

        /// <summary>
        /// Enum Voicesurvey for "VOICESURVEY"
        /// </summary>
        [EnumMember(Value = "VOICESURVEY")]
        Voicesurvey
    }
    /// <summary>
    /// Gets or Sets ExitReason
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ExitReasonEnum
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
        /// Enum Disconnect for "DISCONNECT"
        /// </summary>
        [EnumMember(Value = "DISCONNECT")]
        Disconnect,

        /// <summary>
        /// Enum FlowDisconnect for "FLOW_DISCONNECT"
        /// </summary>
        [EnumMember(Value = "FLOW_DISCONNECT")]
        FlowDisconnect,

        /// <summary>
        /// Enum FlowErrorDisconnect for "FLOW_ERROR_DISCONNECT"
        /// </summary>
        [EnumMember(Value = "FLOW_ERROR_DISCONNECT")]
        FlowErrorDisconnect,

        /// <summary>
        /// Enum Transfer for "TRANSFER"
        /// </summary>
        [EnumMember(Value = "TRANSFER")]
        Transfer,

        /// <summary>
        /// Enum SessionExpireDisconnect for "SESSION_EXPIRE_DISCONNECT"
        /// </summary>
        [EnumMember(Value = "SESSION_EXPIRE_DISCONNECT")]
        SessionExpireDisconnect,

        /// <summary>
        /// Enum RecognitionFailureDisconnect for "RECOGNITION_FAILURE_DISCONNECT"
        /// </summary>
        [EnumMember(Value = "RECOGNITION_FAILURE_DISCONNECT")]
        RecognitionFailureDisconnect,

        /// <summary>
        /// Enum RecognitionFailureExit for "RECOGNITION_FAILURE_EXIT"
        /// </summary>
        [EnumMember(Value = "RECOGNITION_FAILURE_EXIT")]
        RecognitionFailureExit,

        /// <summary>
        /// Enum UserExit for "USER_EXIT"
        /// </summary>
        [EnumMember(Value = "USER_EXIT")]
        UserExit,

        /// <summary>
        /// Enum FlowExit for "FLOW_EXIT"
        /// </summary>
        [EnumMember(Value = "FLOW_EXIT")]
        FlowExit,

        /// <summary>
        /// Enum FlowErrorExit for "FLOW_ERROR_EXIT"
        /// </summary>
        [EnumMember(Value = "FLOW_ERROR_EXIT")]
        FlowErrorExit
    }
    /// <summary>
    /// Gets or Sets TransferType
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum TransferTypeEnum
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
        /// Enum Acd for "ACD"
        /// </summary>
        [EnumMember(Value = "ACD")]
        Acd,

        /// <summary>
        /// Enum User for "USER"
        /// </summary>
        [EnumMember(Value = "USER")]
        User,

        /// <summary>
        /// Enum Number for "NUMBER"
        /// </summary>
        [EnumMember(Value = "NUMBER")]
        Number,

        /// <summary>
        /// Enum AcdVoicemail for "ACD_VOICEMAIL"
        /// </summary>
        [EnumMember(Value = "ACD_VOICEMAIL")]
        AcdVoicemail,

        /// <summary>
        /// Enum UserVoicemail for "USER_VOICEMAIL"
        /// </summary>
        [EnumMember(Value = "USER_VOICEMAIL")]
        UserVoicemail,

        /// <summary>
        /// Enum GroupVoicemail for "GROUP_VOICEMAIL"
        /// </summary>
        [EnumMember(Value = "GROUP_VOICEMAIL")]
        GroupVoicemail,

        /// <summary>
        /// Enum Group for "GROUP"
        /// </summary>
        [EnumMember(Value = "GROUP")]
        Group,

        /// <summary>
        /// Enum Flow for "FLOW"
        /// </summary>
        [EnumMember(Value = "FLOW")]
        Flow,

        /// <summary>
        /// Enum SecureFlow for "SECURE_FLOW"
        /// </summary>
        [EnumMember(Value = "SECURE_FLOW")]
        SecureFlow,

        /// <summary>
        /// Enum ReturnToAgent for "RETURN_TO_AGENT"
        /// </summary>
        [EnumMember(Value = "RETURN_TO_AGENT")]
        ReturnToAgent
    }
    /// <summary>
    /// Gets or Sets DisconnectType
    /// </summary>
    [DataMember(Name = "disconnectType", EmitDefaultValue = false)]
    public DisconnectTypeEnum? DisconnectType { get; set; }
    /// <summary>
    /// Gets or Sets MediaType
    /// </summary>
    [DataMember(Name = "mediaType", EmitDefaultValue = false)]
    public MediaTypeEnum? MediaType { get; set; }
    /// <summary>
    /// Gets or Sets Direction
    /// </summary>
    [DataMember(Name = "direction", EmitDefaultValue = false)]
    public DirectionEnum? Direction { get; set; }
    /// <summary>
    /// Gets or Sets MessageType
    /// </summary>
    [DataMember(Name = "messageType", EmitDefaultValue = false)]
    public MessageTypeEnum? MessageType { get; set; }
    /// <summary>
    /// Gets or Sets FlowType
    /// </summary>
    [DataMember(Name = "flowType", EmitDefaultValue = false)]
    public FlowTypeEnum? FlowType { get; set; }
    /// <summary>
    /// Gets or Sets ExitReason
    /// </summary>
    [DataMember(Name = "exitReason", EmitDefaultValue = false)]
    public ExitReasonEnum? ExitReason { get; set; }
    /// <summary>
    /// Gets or Sets TransferType
    /// </summary>
    [DataMember(Name = "transferType", EmitDefaultValue = false)]
    public TransferTypeEnum? TransferType { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="FlowEndDetailEventTopicFlowEndEvent" /> class.
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
    /// <param name="Subject">Subject.</param>
    /// <param name="MessageType">MessageType.</param>
    /// <param name="FlowType">FlowType.</param>
    /// <param name="FlowId">FlowId.</param>
    /// <param name="DivisionId">DivisionId.</param>
    /// <param name="FlowVersion">FlowVersion.</param>
    /// <param name="ConnectedDurationMs">ConnectedDurationMs.</param>
    /// <param name="ConversationExternalContactIds">ConversationExternalContactIds.</param>
    /// <param name="ConversationExternalOrganizationIds">ConversationExternalOrganizationIds.</param>
    /// <param name="ExitReason">ExitReason.</param>
    /// <param name="TransferType">TransferType.</param>
    public FlowEndDetailEventTopicFlowEndEvent(long? EventTime = null, string ConversationId = null, string ParticipantId = null, string SessionId = null, DisconnectTypeEnum? DisconnectType = null, MediaTypeEnum? MediaType = null, string Provider = null, DirectionEnum? Direction = null, string Ani = null, string Dnis = null, string AddressTo = null, string AddressFrom = null, string Subject = null, MessageTypeEnum? MessageType = null, FlowTypeEnum? FlowType = null, string FlowId = null, string DivisionId = null, string FlowVersion = null, long? ConnectedDurationMs = null, List<string> ConversationExternalContactIds = null, List<string> ConversationExternalOrganizationIds = null, ExitReasonEnum? ExitReason = null, TransferTypeEnum? TransferType = null)
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
        this.Subject = Subject;
        this.MessageType = MessageType;
        this.FlowType = FlowType;
        this.FlowId = FlowId;
        this.DivisionId = DivisionId;
        this.FlowVersion = FlowVersion;
        this.ConnectedDurationMs = ConnectedDurationMs;
        this.ConversationExternalContactIds = ConversationExternalContactIds;
        this.ConversationExternalOrganizationIds = ConversationExternalOrganizationIds;
        this.ExitReason = ExitReason;
        this.TransferType = TransferType;

    }



    /// <summary>
    /// Gets or Sets EventTime
    /// </summary>
    [DataMember(Name = "eventTime", EmitDefaultValue = false)]
    public long? EventTime { get; set; }



    /// <summary>
    /// Gets or Sets ConversationId
    /// </summary>
    [DataMember(Name = "conversationId", EmitDefaultValue = false)]
    public string ConversationId { get; set; }



    /// <summary>
    /// Gets or Sets ParticipantId
    /// </summary>
    [DataMember(Name = "participantId", EmitDefaultValue = false)]
    public string ParticipantId { get; set; }



    /// <summary>
    /// Gets or Sets SessionId
    /// </summary>
    [DataMember(Name = "sessionId", EmitDefaultValue = false)]
    public string SessionId { get; set; }







    /// <summary>
    /// Gets or Sets Provider
    /// </summary>
    [DataMember(Name = "provider", EmitDefaultValue = false)]
    public string Provider { get; set; }





    /// <summary>
    /// Gets or Sets Ani
    /// </summary>
    [DataMember(Name = "ani", EmitDefaultValue = false)]
    public string Ani { get; set; }



    /// <summary>
    /// Gets or Sets Dnis
    /// </summary>
    [DataMember(Name = "dnis", EmitDefaultValue = false)]
    public string Dnis { get; set; }



    /// <summary>
    /// Gets or Sets AddressTo
    /// </summary>
    [DataMember(Name = "addressTo", EmitDefaultValue = false)]
    public string AddressTo { get; set; }



    /// <summary>
    /// Gets or Sets AddressFrom
    /// </summary>
    [DataMember(Name = "addressFrom", EmitDefaultValue = false)]
    public string AddressFrom { get; set; }



    /// <summary>
    /// Gets or Sets Subject
    /// </summary>
    [DataMember(Name = "subject", EmitDefaultValue = false)]
    public string Subject { get; set; }







    /// <summary>
    /// Gets or Sets FlowId
    /// </summary>
    [DataMember(Name = "flowId", EmitDefaultValue = false)]
    public string FlowId { get; set; }



    /// <summary>
    /// Gets or Sets DivisionId
    /// </summary>
    [DataMember(Name = "divisionId", EmitDefaultValue = false)]
    public string DivisionId { get; set; }



    /// <summary>
    /// Gets or Sets FlowVersion
    /// </summary>
    [DataMember(Name = "flowVersion", EmitDefaultValue = false)]
    public string FlowVersion { get; set; }



    /// <summary>
    /// Gets or Sets ConnectedDurationMs
    /// </summary>
    [DataMember(Name = "connectedDurationMs", EmitDefaultValue = false)]
    public long? ConnectedDurationMs { get; set; }



    /// <summary>
    /// Gets or Sets ConversationExternalContactIds
    /// </summary>
    [DataMember(Name = "conversationExternalContactIds", EmitDefaultValue = false)]
    public List<string> ConversationExternalContactIds { get; set; }



    /// <summary>
    /// Gets or Sets ConversationExternalOrganizationIds
    /// </summary>
    [DataMember(Name = "conversationExternalOrganizationIds", EmitDefaultValue = false)]
    public List<string> ConversationExternalOrganizationIds { get; set; }






    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class FlowEndDetailEventTopicFlowEndEvent {\n");

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
        sb.Append("  Subject: ").Append(Subject).Append("\n");
        sb.Append("  MessageType: ").Append(MessageType).Append("\n");
        sb.Append("  FlowType: ").Append(FlowType).Append("\n");
        sb.Append("  FlowId: ").Append(FlowId).Append("\n");
        sb.Append("  DivisionId: ").Append(DivisionId).Append("\n");
        sb.Append("  FlowVersion: ").Append(FlowVersion).Append("\n");
        sb.Append("  ConnectedDurationMs: ").Append(ConnectedDurationMs).Append("\n");
        sb.Append("  ConversationExternalContactIds: ").Append(ConversationExternalContactIds).Append("\n");
        sb.Append("  ConversationExternalOrganizationIds: ").Append(ConversationExternalOrganizationIds).Append("\n");
        sb.Append("  ExitReason: ").Append(ExitReason).Append("\n");
        sb.Append("  TransferType: ").Append(TransferType).Append("\n");
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
        return Equals(obj as FlowEndDetailEventTopicFlowEndEvent);
    }

    /// <summary>
    /// Returns true if FlowEndDetailEventTopicFlowEndEvent instances are equal
    /// </summary>
    /// <param name="other">Instance of FlowEndDetailEventTopicFlowEndEvent to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(FlowEndDetailEventTopicFlowEndEvent other)
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
                FlowType == other.FlowType ||
                FlowType != null &&
                FlowType.Equals(other.FlowType)
            ) &&
            (
                FlowId == other.FlowId ||
                FlowId != null &&
                FlowId.Equals(other.FlowId)
            ) &&
            (
                DivisionId == other.DivisionId ||
                DivisionId != null &&
                DivisionId.Equals(other.DivisionId)
            ) &&
            (
                FlowVersion == other.FlowVersion ||
                FlowVersion != null &&
                FlowVersion.Equals(other.FlowVersion)
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
                ExitReason == other.ExitReason ||
                ExitReason != null &&
                ExitReason.Equals(other.ExitReason)
            ) &&
            (
                TransferType == other.TransferType ||
                TransferType != null &&
                TransferType.Equals(other.TransferType)
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

            if (Subject != null)
            {
                hash = hash * 59 + Subject.GetHashCode();
            }

            if (MessageType != null)
            {
                hash = hash * 59 + MessageType.GetHashCode();
            }

            if (FlowType != null)
            {
                hash = hash * 59 + FlowType.GetHashCode();
            }

            if (FlowId != null)
            {
                hash = hash * 59 + FlowId.GetHashCode();
            }

            if (DivisionId != null)
            {
                hash = hash * 59 + DivisionId.GetHashCode();
            }

            if (FlowVersion != null)
            {
                hash = hash * 59 + FlowVersion.GetHashCode();
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

            if (ExitReason != null)
            {
                hash = hash * 59 + ExitReason.GetHashCode();
            }

            if (TransferType != null)
            {
                hash = hash * 59 + TransferType.GetHashCode();
            }

            return hash;
        }
    }
}
