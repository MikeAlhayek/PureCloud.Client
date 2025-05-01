using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AcdStartDetailEventTopicAcdStartEvent
/// </summary>
[DataContract]
public partial class AcdStartDetailEventTopicAcdStartEvent : IEquatable<AcdStartDetailEventTopicAcdStartEvent>
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
    /// Initializes a new instance of the <see cref="AcdStartDetailEventTopicAcdStartEvent" /> class.
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
    /// <param name="CallbackUserName">CallbackUserName.</param>
    /// <param name="CallbackNumbers">CallbackNumbers.</param>
    /// <param name="CallbackScheduledTime">CallbackScheduledTime.</param>
    /// <param name="Subject">Subject.</param>
    /// <param name="MessageType">MessageType.</param>
    /// <param name="QueueId">QueueId.</param>
    /// <param name="DivisionId">DivisionId.</param>
    /// <param name="ConversationExternalContactIds">ConversationExternalContactIds.</param>
    /// <param name="ConversationExternalOrganizationIds">ConversationExternalOrganizationIds.</param>
    /// <param name="UtilizationLabel">UtilizationLabel.</param>
    /// <param name="RoutingPriority">RoutingPriority.</param>
    /// <param name="RequestedRoutingSkillIds">RequestedRoutingSkillIds.</param>
    public AcdStartDetailEventTopicAcdStartEvent(long? EventTime = null, string ConversationId = null, string ParticipantId = null, string SessionId = null, MediaTypeEnum? MediaType = null, string Provider = null, DirectionEnum? Direction = null, string Ani = null, string Dnis = null, string AddressTo = null, string AddressFrom = null, string CallbackUserName = null, List<string> CallbackNumbers = null, long? CallbackScheduledTime = null, string Subject = null, MessageTypeEnum? MessageType = null, string QueueId = null, string DivisionId = null, List<string> ConversationExternalContactIds = null, List<string> ConversationExternalOrganizationIds = null, string UtilizationLabel = null, long? RoutingPriority = null, List<Guid?> RequestedRoutingSkillIds = null)
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
        this.CallbackUserName = CallbackUserName;
        this.CallbackNumbers = CallbackNumbers;
        this.CallbackScheduledTime = CallbackScheduledTime;
        this.Subject = Subject;
        this.MessageType = MessageType;
        this.QueueId = QueueId;
        this.DivisionId = DivisionId;
        this.ConversationExternalContactIds = ConversationExternalContactIds;
        this.ConversationExternalOrganizationIds = ConversationExternalOrganizationIds;
        this.UtilizationLabel = UtilizationLabel;
        this.RoutingPriority = RoutingPriority;
        this.RequestedRoutingSkillIds = RequestedRoutingSkillIds;

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
    /// Gets or Sets CallbackUserName
    /// </summary>
    [DataMember(Name = "callbackUserName", EmitDefaultValue = false)]
    public string CallbackUserName { get; set; }



    /// <summary>
    /// Gets or Sets CallbackNumbers
    /// </summary>
    [DataMember(Name = "callbackNumbers", EmitDefaultValue = false)]
    public List<string> CallbackNumbers { get; set; }



    /// <summary>
    /// Gets or Sets CallbackScheduledTime
    /// </summary>
    [DataMember(Name = "callbackScheduledTime", EmitDefaultValue = false)]
    public long? CallbackScheduledTime { get; set; }



    /// <summary>
    /// Gets or Sets Subject
    /// </summary>
    [DataMember(Name = "subject", EmitDefaultValue = false)]
    public string Subject { get; set; }





    /// <summary>
    /// Gets or Sets QueueId
    /// </summary>
    [DataMember(Name = "queueId", EmitDefaultValue = false)]
    public string QueueId { get; set; }



    /// <summary>
    /// Gets or Sets DivisionId
    /// </summary>
    [DataMember(Name = "divisionId", EmitDefaultValue = false)]
    public string DivisionId { get; set; }



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
    /// Gets or Sets UtilizationLabel
    /// </summary>
    [DataMember(Name = "utilizationLabel", EmitDefaultValue = false)]
    public string UtilizationLabel { get; set; }



    /// <summary>
    /// Gets or Sets RoutingPriority
    /// </summary>
    [DataMember(Name = "routingPriority", EmitDefaultValue = false)]
    public long? RoutingPriority { get; set; }



    /// <summary>
    /// Gets or Sets RequestedRoutingSkillIds
    /// </summary>
    [DataMember(Name = "requestedRoutingSkillIds", EmitDefaultValue = false)]
    public List<Guid?> RequestedRoutingSkillIds { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AcdStartDetailEventTopicAcdStartEvent {\n");

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
        sb.Append("  CallbackUserName: ").Append(CallbackUserName).Append("\n");
        sb.Append("  CallbackNumbers: ").Append(CallbackNumbers).Append("\n");
        sb.Append("  CallbackScheduledTime: ").Append(CallbackScheduledTime).Append("\n");
        sb.Append("  Subject: ").Append(Subject).Append("\n");
        sb.Append("  MessageType: ").Append(MessageType).Append("\n");
        sb.Append("  QueueId: ").Append(QueueId).Append("\n");
        sb.Append("  DivisionId: ").Append(DivisionId).Append("\n");
        sb.Append("  ConversationExternalContactIds: ").Append(ConversationExternalContactIds).Append("\n");
        sb.Append("  ConversationExternalOrganizationIds: ").Append(ConversationExternalOrganizationIds).Append("\n");
        sb.Append("  UtilizationLabel: ").Append(UtilizationLabel).Append("\n");
        sb.Append("  RoutingPriority: ").Append(RoutingPriority).Append("\n");
        sb.Append("  RequestedRoutingSkillIds: ").Append(RequestedRoutingSkillIds).Append("\n");
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
        return Equals(obj as AcdStartDetailEventTopicAcdStartEvent);
    }

    /// <summary>
    /// Returns true if AcdStartDetailEventTopicAcdStartEvent instances are equal
    /// </summary>
    /// <param name="other">Instance of AcdStartDetailEventTopicAcdStartEvent to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AcdStartDetailEventTopicAcdStartEvent other)
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
                RoutingPriority == other.RoutingPriority ||
                RoutingPriority != null &&
                RoutingPriority.Equals(other.RoutingPriority)
            ) &&
            (
                RequestedRoutingSkillIds == other.RequestedRoutingSkillIds ||
                RequestedRoutingSkillIds != null &&
                RequestedRoutingSkillIds.SequenceEqual(other.RequestedRoutingSkillIds)
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

            if (RoutingPriority != null)
            {
                hash = hash * 59 + RoutingPriority.GetHashCode();
            }

            if (RequestedRoutingSkillIds != null)
            {
                hash = hash * 59 + RequestedRoutingSkillIds.GetHashCode();
            }

            return hash;
        }
    }
}
