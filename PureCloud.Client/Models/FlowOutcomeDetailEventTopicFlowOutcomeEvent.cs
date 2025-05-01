using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// FlowOutcomeDetailEventTopicFlowOutcomeEvent
/// </summary>
[DataContract]
public partial class FlowOutcomeDetailEventTopicFlowOutcomeEvent : IEquatable<FlowOutcomeDetailEventTopicFlowOutcomeEvent>
{
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
    /// Gets or Sets FlowOutcomeValue
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum FlowOutcomeValueEnum
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
        /// Enum Success for "SUCCESS"
        /// </summary>
        [EnumMember(Value = "SUCCESS")]
        Success,

        /// <summary>
        /// Enum Failure for "FAILURE"
        /// </summary>
        [EnumMember(Value = "FAILURE")]
        Failure
    }
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
    /// Gets or Sets FlowOutcomeValue
    /// </summary>
    [DataMember(Name = "flowOutcomeValue", EmitDefaultValue = false)]
    public FlowOutcomeValueEnum? FlowOutcomeValue { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="FlowOutcomeDetailEventTopicFlowOutcomeEvent" /> class.
    /// </summary>
    /// <param name="EventTime">EventTime.</param>
    /// <param name="ConversationId">ConversationId.</param>
    /// <param name="ParticipantId">ParticipantId.</param>
    /// <param name="SessionId">SessionId.</param>
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
    /// <param name="FlowOutcomeId">FlowOutcomeId.</param>
    /// <param name="FlowOutcomeStartTime">FlowOutcomeStartTime.</param>
    /// <param name="FlowOutcomeEndTime">FlowOutcomeEndTime.</param>
    /// <param name="FlowOutcomeValue">FlowOutcomeValue.</param>
    /// <param name="FlowMilestones">FlowMilestones.</param>
    /// <param name="ConversationExternalContactIds">ConversationExternalContactIds.</param>
    /// <param name="ConversationExternalOrganizationIds">ConversationExternalOrganizationIds.</param>
    public FlowOutcomeDetailEventTopicFlowOutcomeEvent(long? EventTime = null, string ConversationId = null, string ParticipantId = null, string SessionId = null, MediaTypeEnum? MediaType = null, string Provider = null, DirectionEnum? Direction = null, string Ani = null, string Dnis = null, string AddressTo = null, string AddressFrom = null, string Subject = null, MessageTypeEnum? MessageType = null, FlowTypeEnum? FlowType = null, string FlowId = null, string DivisionId = null, string FlowVersion = null, Guid? FlowOutcomeId = null, long? FlowOutcomeStartTime = null, long? FlowOutcomeEndTime = null, FlowOutcomeValueEnum? FlowOutcomeValue = null, List<FlowOutcomeDetailEventTopicFlowMilestone> FlowMilestones = null, List<string> ConversationExternalContactIds = null, List<string> ConversationExternalOrganizationIds = null)
    {
        this.EventTime = EventTime;
        this.ConversationId = ConversationId;
        this.ParticipantId = ParticipantId;
        this.SessionId = SessionId;
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
        this.FlowOutcomeId = FlowOutcomeId;
        this.FlowOutcomeStartTime = FlowOutcomeStartTime;
        this.FlowOutcomeEndTime = FlowOutcomeEndTime;
        this.FlowOutcomeValue = FlowOutcomeValue;
        this.FlowMilestones = FlowMilestones;
        this.ConversationExternalContactIds = ConversationExternalContactIds;
        this.ConversationExternalOrganizationIds = ConversationExternalOrganizationIds;

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
    /// Gets or Sets FlowOutcomeId
    /// </summary>
    [DataMember(Name = "flowOutcomeId", EmitDefaultValue = false)]
    public Guid? FlowOutcomeId { get; set; }



    /// <summary>
    /// Gets or Sets FlowOutcomeStartTime
    /// </summary>
    [DataMember(Name = "flowOutcomeStartTime", EmitDefaultValue = false)]
    public long? FlowOutcomeStartTime { get; set; }



    /// <summary>
    /// Gets or Sets FlowOutcomeEndTime
    /// </summary>
    [DataMember(Name = "flowOutcomeEndTime", EmitDefaultValue = false)]
    public long? FlowOutcomeEndTime { get; set; }





    /// <summary>
    /// Gets or Sets FlowMilestones
    /// </summary>
    [DataMember(Name = "flowMilestones", EmitDefaultValue = false)]
    public List<FlowOutcomeDetailEventTopicFlowMilestone> FlowMilestones { get; set; }



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
        sb.Append("class FlowOutcomeDetailEventTopicFlowOutcomeEvent {\n");

        sb.Append("  EventTime: ").Append(EventTime).Append("\n");
        sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
        sb.Append("  ParticipantId: ").Append(ParticipantId).Append("\n");
        sb.Append("  SessionId: ").Append(SessionId).Append("\n");
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
        sb.Append("  FlowOutcomeId: ").Append(FlowOutcomeId).Append("\n");
        sb.Append("  FlowOutcomeStartTime: ").Append(FlowOutcomeStartTime).Append("\n");
        sb.Append("  FlowOutcomeEndTime: ").Append(FlowOutcomeEndTime).Append("\n");
        sb.Append("  FlowOutcomeValue: ").Append(FlowOutcomeValue).Append("\n");
        sb.Append("  FlowMilestones: ").Append(FlowMilestones).Append("\n");
        sb.Append("  ConversationExternalContactIds: ").Append(ConversationExternalContactIds).Append("\n");
        sb.Append("  ConversationExternalOrganizationIds: ").Append(ConversationExternalOrganizationIds).Append("\n");
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
        return Equals(obj as FlowOutcomeDetailEventTopicFlowOutcomeEvent);
    }

    /// <summary>
    /// Returns true if FlowOutcomeDetailEventTopicFlowOutcomeEvent instances are equal
    /// </summary>
    /// <param name="other">Instance of FlowOutcomeDetailEventTopicFlowOutcomeEvent to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(FlowOutcomeDetailEventTopicFlowOutcomeEvent other)
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
                FlowOutcomeId == other.FlowOutcomeId ||
                FlowOutcomeId != null &&
                FlowOutcomeId.Equals(other.FlowOutcomeId)
            ) &&
            (
                FlowOutcomeStartTime == other.FlowOutcomeStartTime ||
                FlowOutcomeStartTime != null &&
                FlowOutcomeStartTime.Equals(other.FlowOutcomeStartTime)
            ) &&
            (
                FlowOutcomeEndTime == other.FlowOutcomeEndTime ||
                FlowOutcomeEndTime != null &&
                FlowOutcomeEndTime.Equals(other.FlowOutcomeEndTime)
            ) &&
            (
                FlowOutcomeValue == other.FlowOutcomeValue ||
                FlowOutcomeValue != null &&
                FlowOutcomeValue.Equals(other.FlowOutcomeValue)
            ) &&
            (
                FlowMilestones == other.FlowMilestones ||
                FlowMilestones != null &&
                FlowMilestones.SequenceEqual(other.FlowMilestones)
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

            if (FlowOutcomeId != null)
            {
                hash = hash * 59 + FlowOutcomeId.GetHashCode();
            }

            if (FlowOutcomeStartTime != null)
            {
                hash = hash * 59 + FlowOutcomeStartTime.GetHashCode();
            }

            if (FlowOutcomeEndTime != null)
            {
                hash = hash * 59 + FlowOutcomeEndTime.GetHashCode();
            }

            if (FlowOutcomeValue != null)
            {
                hash = hash * 59 + FlowOutcomeValue.GetHashCode();
            }

            if (FlowMilestones != null)
            {
                hash = hash * 59 + FlowMilestones.GetHashCode();
            }

            if (ConversationExternalContactIds != null)
            {
                hash = hash * 59 + ConversationExternalContactIds.GetHashCode();
            }

            if (ConversationExternalOrganizationIds != null)
            {
                hash = hash * 59 + ConversationExternalOrganizationIds.GetHashCode();
            }

            return hash;
        }
    }
}
