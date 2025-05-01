using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// QueueConversationSocialExpressionEventTopicEmail
/// </summary>
[DataContract]
public partial class QueueConversationSocialExpressionEventTopicEmail : IEquatable<QueueConversationSocialExpressionEventTopicEmail>
{
    /// <summary>
    /// Gets or Sets State
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum StateEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Alerting for "alerting"
        /// </summary>
        [EnumMember(Value = "alerting")]
        Alerting,

        /// <summary>
        /// Enum Connected for "connected"
        /// </summary>
        [EnumMember(Value = "connected")]
        Connected,

        /// <summary>
        /// Enum Disconnected for "disconnected"
        /// </summary>
        [EnumMember(Value = "disconnected")]
        Disconnected,

        /// <summary>
        /// Enum None for "none"
        /// </summary>
        [EnumMember(Value = "none")]
        None,

        /// <summary>
        /// Enum Transmitting for "transmitting"
        /// </summary>
        [EnumMember(Value = "transmitting")]
        Transmitting,

        /// <summary>
        /// Enum Parked for "parked"
        /// </summary>
        [EnumMember(Value = "parked")]
        Parked
    }
    /// <summary>
    /// Gets or Sets InitialState
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum InitialStateEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Alerting for "alerting"
        /// </summary>
        [EnumMember(Value = "alerting")]
        Alerting,

        /// <summary>
        /// Enum Connected for "connected"
        /// </summary>
        [EnumMember(Value = "connected")]
        Connected,

        /// <summary>
        /// Enum Disconnected for "disconnected"
        /// </summary>
        [EnumMember(Value = "disconnected")]
        Disconnected,

        /// <summary>
        /// Enum None for "none"
        /// </summary>
        [EnumMember(Value = "none")]
        None,

        /// <summary>
        /// Enum Transmitting for "transmitting"
        /// </summary>
        [EnumMember(Value = "transmitting")]
        Transmitting,

        /// <summary>
        /// Enum Parked for "parked"
        /// </summary>
        [EnumMember(Value = "parked")]
        Parked
    }
    /// <summary>
    /// System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects.
    /// </summary>
    /// <value>System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects.</value>
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
        /// Enum Endpoint for "endpoint"
        /// </summary>
        [EnumMember(Value = "endpoint")]
        Endpoint,

        /// <summary>
        /// Enum Client for "client"
        /// </summary>
        [EnumMember(Value = "client")]
        Client,

        /// <summary>
        /// Enum System for "system"
        /// </summary>
        [EnumMember(Value = "system")]
        System,

        /// <summary>
        /// Enum Timeout for "timeout"
        /// </summary>
        [EnumMember(Value = "timeout")]
        Timeout,

        /// <summary>
        /// Enum Transfer for "transfer"
        /// </summary>
        [EnumMember(Value = "transfer")]
        Transfer,

        /// <summary>
        /// Enum Transferconference for "transfer.conference"
        /// </summary>
        [EnumMember(Value = "transfer.conference")]
        Transferconference,

        /// <summary>
        /// Enum Transferconsult for "transfer.consult"
        /// </summary>
        [EnumMember(Value = "transfer.consult")]
        Transferconsult,

        /// <summary>
        /// Enum Transferforward for "transfer.forward"
        /// </summary>
        [EnumMember(Value = "transfer.forward")]
        Transferforward,

        /// <summary>
        /// Enum Transfernoanswer for "transfer.noanswer"
        /// </summary>
        [EnumMember(Value = "transfer.noanswer")]
        Transfernoanswer,

        /// <summary>
        /// Enum Transfernotavailable for "transfer.notavailable"
        /// </summary>
        [EnumMember(Value = "transfer.notavailable")]
        Transfernotavailable,

        /// <summary>
        /// Enum Transportfailure for "transport.failure"
        /// </summary>
        [EnumMember(Value = "transport.failure")]
        Transportfailure,

        /// <summary>
        /// Enum Error for "error"
        /// </summary>
        [EnumMember(Value = "error")]
        Error,

        /// <summary>
        /// Enum Peer for "peer"
        /// </summary>
        [EnumMember(Value = "peer")]
        Peer,

        /// <summary>
        /// Enum Other for "other"
        /// </summary>
        [EnumMember(Value = "other")]
        Other,

        /// <summary>
        /// Enum Spam for "spam"
        /// </summary>
        [EnumMember(Value = "spam")]
        Spam,

        /// <summary>
        /// Enum Uncallable for "uncallable"
        /// </summary>
        [EnumMember(Value = "uncallable")]
        Uncallable
    }
    /// <summary>
    /// Whether an email is inbound or outbound.
    /// </summary>
    /// <value>Whether an email is inbound or outbound.</value>
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
        /// Enum Outbound for "outbound"
        /// </summary>
        [EnumMember(Value = "outbound")]
        Outbound,

        /// <summary>
        /// Enum Inbound for "inbound"
        /// </summary>
        [EnumMember(Value = "inbound")]
        Inbound
    }
    /// <summary>
    /// Gets or Sets State
    /// </summary>
    [DataMember(Name = "state", EmitDefaultValue = false)]
    public StateEnum? State { get; set; }
    /// <summary>
    /// Gets or Sets InitialState
    /// </summary>
    [DataMember(Name = "initialState", EmitDefaultValue = false)]
    public InitialStateEnum? InitialState { get; set; }
    /// <summary>
    /// System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects.
    /// </summary>
    /// <value>System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects.</value>
    [DataMember(Name = "disconnectType", EmitDefaultValue = false)]
    public DisconnectTypeEnum? DisconnectType { get; set; }
    /// <summary>
    /// Whether an email is inbound or outbound.
    /// </summary>
    /// <value>Whether an email is inbound or outbound.</value>
    [DataMember(Name = "direction", EmitDefaultValue = false)]
    public DirectionEnum? Direction { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="QueueConversationSocialExpressionEventTopicEmail" /> class.
    /// </summary>
    /// <param name="Id">A globally unique identifier for this communication..</param>
    /// <param name="State">State.</param>
    /// <param name="InitialState">InitialState.</param>
    /// <param name="Held">True if this call is held and the person on this side hears silence..</param>
    /// <param name="AutoGenerated">Indicates that the email was auto-generated like an Out of Office reply..</param>
    /// <param name="Subject">The subject for the initial email that started this conversation..</param>
    /// <param name="Provider">The source provider of the email..</param>
    /// <param name="ScriptId">The UUID of the script to use..</param>
    /// <param name="PeerId">The id of the peer communication corresponding to a matching leg for this communication..</param>
    /// <param name="MessagesSent">The number of email messages sent by this participant..</param>
    /// <param name="ErrorInfo">Detailed information about an error response..</param>
    /// <param name="DisconnectType">System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects..</param>
    /// <param name="StartHoldTime">The timestamp the email was placed on hold in the cloud clock if the email is currently on hold..</param>
    /// <param name="ConnectedTime">The timestamp when this communication was connected in the cloud clock..</param>
    /// <param name="DisconnectedTime">The timestamp when this communication disconnected from the conversation in the provider clock..</param>
    /// <param name="MessageId">A globally unique identifier for the stored content of this communication..</param>
    /// <param name="Direction">Whether an email is inbound or outbound..</param>
    /// <param name="DraftAttachments">A list of uploaded attachments on the email draft..</param>
    /// <param name="Spam">Indicates if the inbound email was marked as spam..</param>
    /// <param name="Wrapup">Call wrap up or disposition data..</param>
    /// <param name="AfterCallWork">A communication&#39;s after-call work data..</param>
    /// <param name="AfterCallWorkRequired">Indicates if after-call is required for a communication. Only used when the ACW Setting is Agent Requested..</param>
    /// <param name="QueueMediaSettings">Represents the queue setting for this media..</param>
    /// <param name="ResumeTime">The time when a parked email should resume..</param>
    /// <param name="ParkTime">The time when an  parked email was parked..</param>
    public QueueConversationSocialExpressionEventTopicEmail(string Id = null, StateEnum? State = null, InitialStateEnum? InitialState = null, bool? Held = null, bool? AutoGenerated = null, string Subject = null, string Provider = null, string ScriptId = null, string PeerId = null, long? MessagesSent = null, QueueConversationSocialExpressionEventTopicErrorDetails ErrorInfo = null, DisconnectTypeEnum? DisconnectType = null, DateTime? StartHoldTime = null, DateTime? ConnectedTime = null, DateTime? DisconnectedTime = null, string MessageId = null, DirectionEnum? Direction = null, List<QueueConversationSocialExpressionEventTopicAttachment> DraftAttachments = null, bool? Spam = null, QueueConversationSocialExpressionEventTopicWrapup Wrapup = null, QueueConversationSocialExpressionEventTopicAfterCallWork AfterCallWork = null, bool? AfterCallWorkRequired = null, QueueConversationSocialExpressionEventTopicQueueMediaSettings QueueMediaSettings = null, DateTime? ResumeTime = null, DateTime? ParkTime = null)
    {
        this.Id = Id;
        this.State = State;
        this.InitialState = InitialState;
        this.Held = Held;
        this.AutoGenerated = AutoGenerated;
        this.Subject = Subject;
        this.Provider = Provider;
        this.ScriptId = ScriptId;
        this.PeerId = PeerId;
        this.MessagesSent = MessagesSent;
        this.ErrorInfo = ErrorInfo;
        this.DisconnectType = DisconnectType;
        this.StartHoldTime = StartHoldTime;
        this.ConnectedTime = ConnectedTime;
        this.DisconnectedTime = DisconnectedTime;
        this.MessageId = MessageId;
        this.Direction = Direction;
        this.DraftAttachments = DraftAttachments;
        this.Spam = Spam;
        this.Wrapup = Wrapup;
        this.AfterCallWork = AfterCallWork;
        this.AfterCallWorkRequired = AfterCallWorkRequired;
        this.QueueMediaSettings = QueueMediaSettings;
        this.ResumeTime = ResumeTime;
        this.ParkTime = ParkTime;

    }



    /// <summary>
    /// A globally unique identifier for this communication.
    /// </summary>
    /// <value>A globally unique identifier for this communication.</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }







    /// <summary>
    /// True if this call is held and the person on this side hears silence.
    /// </summary>
    /// <value>True if this call is held and the person on this side hears silence.</value>
    [DataMember(Name = "held", EmitDefaultValue = false)]
    public bool? Held { get; set; }



    /// <summary>
    /// Indicates that the email was auto-generated like an Out of Office reply.
    /// </summary>
    /// <value>Indicates that the email was auto-generated like an Out of Office reply.</value>
    [DataMember(Name = "autoGenerated", EmitDefaultValue = false)]
    public bool? AutoGenerated { get; set; }



    /// <summary>
    /// The subject for the initial email that started this conversation.
    /// </summary>
    /// <value>The subject for the initial email that started this conversation.</value>
    [DataMember(Name = "subject", EmitDefaultValue = false)]
    public string Subject { get; set; }



    /// <summary>
    /// The source provider of the email.
    /// </summary>
    /// <value>The source provider of the email.</value>
    [DataMember(Name = "provider", EmitDefaultValue = false)]
    public string Provider { get; set; }



    /// <summary>
    /// The UUID of the script to use.
    /// </summary>
    /// <value>The UUID of the script to use.</value>
    [DataMember(Name = "scriptId", EmitDefaultValue = false)]
    public string ScriptId { get; set; }



    /// <summary>
    /// The id of the peer communication corresponding to a matching leg for this communication.
    /// </summary>
    /// <value>The id of the peer communication corresponding to a matching leg for this communication.</value>
    [DataMember(Name = "peerId", EmitDefaultValue = false)]
    public string PeerId { get; set; }



    /// <summary>
    /// The number of email messages sent by this participant.
    /// </summary>
    /// <value>The number of email messages sent by this participant.</value>
    [DataMember(Name = "messagesSent", EmitDefaultValue = false)]
    public long? MessagesSent { get; set; }



    /// <summary>
    /// Detailed information about an error response.
    /// </summary>
    /// <value>Detailed information about an error response.</value>
    [DataMember(Name = "errorInfo", EmitDefaultValue = false)]
    public QueueConversationSocialExpressionEventTopicErrorDetails ErrorInfo { get; set; }





    /// <summary>
    /// The timestamp the email was placed on hold in the cloud clock if the email is currently on hold.
    /// </summary>
    /// <value>The timestamp the email was placed on hold in the cloud clock if the email is currently on hold.</value>
    [DataMember(Name = "startHoldTime", EmitDefaultValue = false)]
    public DateTime? StartHoldTime { get; set; }



    /// <summary>
    /// The timestamp when this communication was connected in the cloud clock.
    /// </summary>
    /// <value>The timestamp when this communication was connected in the cloud clock.</value>
    [DataMember(Name = "connectedTime", EmitDefaultValue = false)]
    public DateTime? ConnectedTime { get; set; }



    /// <summary>
    /// The timestamp when this communication disconnected from the conversation in the provider clock.
    /// </summary>
    /// <value>The timestamp when this communication disconnected from the conversation in the provider clock.</value>
    [DataMember(Name = "disconnectedTime", EmitDefaultValue = false)]
    public DateTime? DisconnectedTime { get; set; }



    /// <summary>
    /// A globally unique identifier for the stored content of this communication.
    /// </summary>
    /// <value>A globally unique identifier for the stored content of this communication.</value>
    [DataMember(Name = "messageId", EmitDefaultValue = false)]
    public string MessageId { get; set; }





    /// <summary>
    /// A list of uploaded attachments on the email draft.
    /// </summary>
    /// <value>A list of uploaded attachments on the email draft.</value>
    [DataMember(Name = "draftAttachments", EmitDefaultValue = false)]
    public List<QueueConversationSocialExpressionEventTopicAttachment> DraftAttachments { get; set; }



    /// <summary>
    /// Indicates if the inbound email was marked as spam.
    /// </summary>
    /// <value>Indicates if the inbound email was marked as spam.</value>
    [DataMember(Name = "spam", EmitDefaultValue = false)]
    public bool? Spam { get; set; }



    /// <summary>
    /// Call wrap up or disposition data.
    /// </summary>
    /// <value>Call wrap up or disposition data.</value>
    [DataMember(Name = "wrapup", EmitDefaultValue = false)]
    public QueueConversationSocialExpressionEventTopicWrapup Wrapup { get; set; }



    /// <summary>
    /// A communication&#39;s after-call work data.
    /// </summary>
    /// <value>A communication&#39;s after-call work data.</value>
    [DataMember(Name = "afterCallWork", EmitDefaultValue = false)]
    public QueueConversationSocialExpressionEventTopicAfterCallWork AfterCallWork { get; set; }



    /// <summary>
    /// Indicates if after-call is required for a communication. Only used when the ACW Setting is Agent Requested.
    /// </summary>
    /// <value>Indicates if after-call is required for a communication. Only used when the ACW Setting is Agent Requested.</value>
    [DataMember(Name = "afterCallWorkRequired", EmitDefaultValue = false)]
    public bool? AfterCallWorkRequired { get; set; }



    /// <summary>
    /// Represents the queue setting for this media.
    /// </summary>
    /// <value>Represents the queue setting for this media.</value>
    [DataMember(Name = "queueMediaSettings", EmitDefaultValue = false)]
    public QueueConversationSocialExpressionEventTopicQueueMediaSettings QueueMediaSettings { get; set; }



    /// <summary>
    /// The time when a parked email should resume.
    /// </summary>
    /// <value>The time when a parked email should resume.</value>
    [DataMember(Name = "resumeTime", EmitDefaultValue = false)]
    public DateTime? ResumeTime { get; set; }



    /// <summary>
    /// The time when an  parked email was parked.
    /// </summary>
    /// <value>The time when an  parked email was parked.</value>
    [DataMember(Name = "parkTime", EmitDefaultValue = false)]
    public DateTime? ParkTime { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class QueueConversationSocialExpressionEventTopicEmail {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  State: ").Append(State).Append("\n");
        sb.Append("  InitialState: ").Append(InitialState).Append("\n");
        sb.Append("  Held: ").Append(Held).Append("\n");
        sb.Append("  AutoGenerated: ").Append(AutoGenerated).Append("\n");
        sb.Append("  Subject: ").Append(Subject).Append("\n");
        sb.Append("  Provider: ").Append(Provider).Append("\n");
        sb.Append("  ScriptId: ").Append(ScriptId).Append("\n");
        sb.Append("  PeerId: ").Append(PeerId).Append("\n");
        sb.Append("  MessagesSent: ").Append(MessagesSent).Append("\n");
        sb.Append("  ErrorInfo: ").Append(ErrorInfo).Append("\n");
        sb.Append("  DisconnectType: ").Append(DisconnectType).Append("\n");
        sb.Append("  StartHoldTime: ").Append(StartHoldTime).Append("\n");
        sb.Append("  ConnectedTime: ").Append(ConnectedTime).Append("\n");
        sb.Append("  DisconnectedTime: ").Append(DisconnectedTime).Append("\n");
        sb.Append("  MessageId: ").Append(MessageId).Append("\n");
        sb.Append("  Direction: ").Append(Direction).Append("\n");
        sb.Append("  DraftAttachments: ").Append(DraftAttachments).Append("\n");
        sb.Append("  Spam: ").Append(Spam).Append("\n");
        sb.Append("  Wrapup: ").Append(Wrapup).Append("\n");
        sb.Append("  AfterCallWork: ").Append(AfterCallWork).Append("\n");
        sb.Append("  AfterCallWorkRequired: ").Append(AfterCallWorkRequired).Append("\n");
        sb.Append("  QueueMediaSettings: ").Append(QueueMediaSettings).Append("\n");
        sb.Append("  ResumeTime: ").Append(ResumeTime).Append("\n");
        sb.Append("  ParkTime: ").Append(ParkTime).Append("\n");
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
        return Equals(obj as QueueConversationSocialExpressionEventTopicEmail);
    }

    /// <summary>
    /// Returns true if QueueConversationSocialExpressionEventTopicEmail instances are equal
    /// </summary>
    /// <param name="other">Instance of QueueConversationSocialExpressionEventTopicEmail to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(QueueConversationSocialExpressionEventTopicEmail other)
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
                State == other.State ||
                State != null &&
                State.Equals(other.State)
            ) &&
            (
                InitialState == other.InitialState ||
                InitialState != null &&
                InitialState.Equals(other.InitialState)
            ) &&
            (
                Held == other.Held ||
                Held != null &&
                Held.Equals(other.Held)
            ) &&
            (
                AutoGenerated == other.AutoGenerated ||
                AutoGenerated != null &&
                AutoGenerated.Equals(other.AutoGenerated)
            ) &&
            (
                Subject == other.Subject ||
                Subject != null &&
                Subject.Equals(other.Subject)
            ) &&
            (
                Provider == other.Provider ||
                Provider != null &&
                Provider.Equals(other.Provider)
            ) &&
            (
                ScriptId == other.ScriptId ||
                ScriptId != null &&
                ScriptId.Equals(other.ScriptId)
            ) &&
            (
                PeerId == other.PeerId ||
                PeerId != null &&
                PeerId.Equals(other.PeerId)
            ) &&
            (
                MessagesSent == other.MessagesSent ||
                MessagesSent != null &&
                MessagesSent.Equals(other.MessagesSent)
            ) &&
            (
                ErrorInfo == other.ErrorInfo ||
                ErrorInfo != null &&
                ErrorInfo.Equals(other.ErrorInfo)
            ) &&
            (
                DisconnectType == other.DisconnectType ||
                DisconnectType != null &&
                DisconnectType.Equals(other.DisconnectType)
            ) &&
            (
                StartHoldTime == other.StartHoldTime ||
                StartHoldTime != null &&
                StartHoldTime.Equals(other.StartHoldTime)
            ) &&
            (
                ConnectedTime == other.ConnectedTime ||
                ConnectedTime != null &&
                ConnectedTime.Equals(other.ConnectedTime)
            ) &&
            (
                DisconnectedTime == other.DisconnectedTime ||
                DisconnectedTime != null &&
                DisconnectedTime.Equals(other.DisconnectedTime)
            ) &&
            (
                MessageId == other.MessageId ||
                MessageId != null &&
                MessageId.Equals(other.MessageId)
            ) &&
            (
                Direction == other.Direction ||
                Direction != null &&
                Direction.Equals(other.Direction)
            ) &&
            (
                DraftAttachments == other.DraftAttachments ||
                DraftAttachments != null &&
                DraftAttachments.SequenceEqual(other.DraftAttachments)
            ) &&
            (
                Spam == other.Spam ||
                Spam != null &&
                Spam.Equals(other.Spam)
            ) &&
            (
                Wrapup == other.Wrapup ||
                Wrapup != null &&
                Wrapup.Equals(other.Wrapup)
            ) &&
            (
                AfterCallWork == other.AfterCallWork ||
                AfterCallWork != null &&
                AfterCallWork.Equals(other.AfterCallWork)
            ) &&
            (
                AfterCallWorkRequired == other.AfterCallWorkRequired ||
                AfterCallWorkRequired != null &&
                AfterCallWorkRequired.Equals(other.AfterCallWorkRequired)
            ) &&
            (
                QueueMediaSettings == other.QueueMediaSettings ||
                QueueMediaSettings != null &&
                QueueMediaSettings.Equals(other.QueueMediaSettings)
            ) &&
            (
                ResumeTime == other.ResumeTime ||
                ResumeTime != null &&
                ResumeTime.Equals(other.ResumeTime)
            ) &&
            (
                ParkTime == other.ParkTime ||
                ParkTime != null &&
                ParkTime.Equals(other.ParkTime)
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

            if (State != null)
            {
                hash = hash * 59 + State.GetHashCode();
            }

            if (InitialState != null)
            {
                hash = hash * 59 + InitialState.GetHashCode();
            }

            if (Held != null)
            {
                hash = hash * 59 + Held.GetHashCode();
            }

            if (AutoGenerated != null)
            {
                hash = hash * 59 + AutoGenerated.GetHashCode();
            }

            if (Subject != null)
            {
                hash = hash * 59 + Subject.GetHashCode();
            }

            if (Provider != null)
            {
                hash = hash * 59 + Provider.GetHashCode();
            }

            if (ScriptId != null)
            {
                hash = hash * 59 + ScriptId.GetHashCode();
            }

            if (PeerId != null)
            {
                hash = hash * 59 + PeerId.GetHashCode();
            }

            if (MessagesSent != null)
            {
                hash = hash * 59 + MessagesSent.GetHashCode();
            }

            if (ErrorInfo != null)
            {
                hash = hash * 59 + ErrorInfo.GetHashCode();
            }

            if (DisconnectType != null)
            {
                hash = hash * 59 + DisconnectType.GetHashCode();
            }

            if (StartHoldTime != null)
            {
                hash = hash * 59 + StartHoldTime.GetHashCode();
            }

            if (ConnectedTime != null)
            {
                hash = hash * 59 + ConnectedTime.GetHashCode();
            }

            if (DisconnectedTime != null)
            {
                hash = hash * 59 + DisconnectedTime.GetHashCode();
            }

            if (MessageId != null)
            {
                hash = hash * 59 + MessageId.GetHashCode();
            }

            if (Direction != null)
            {
                hash = hash * 59 + Direction.GetHashCode();
            }

            if (DraftAttachments != null)
            {
                hash = hash * 59 + DraftAttachments.GetHashCode();
            }

            if (Spam != null)
            {
                hash = hash * 59 + Spam.GetHashCode();
            }

            if (Wrapup != null)
            {
                hash = hash * 59 + Wrapup.GetHashCode();
            }

            if (AfterCallWork != null)
            {
                hash = hash * 59 + AfterCallWork.GetHashCode();
            }

            if (AfterCallWorkRequired != null)
            {
                hash = hash * 59 + AfterCallWorkRequired.GetHashCode();
            }

            if (QueueMediaSettings != null)
            {
                hash = hash * 59 + QueueMediaSettings.GetHashCode();
            }

            if (ResumeTime != null)
            {
                hash = hash * 59 + ResumeTime.GetHashCode();
            }

            if (ParkTime != null)
            {
                hash = hash * 59 + ParkTime.GetHashCode();
            }

            return hash;
        }
    }
}
