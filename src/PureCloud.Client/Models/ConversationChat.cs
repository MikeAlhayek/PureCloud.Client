using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ConversationChat
/// </summary>

public partial class ConversationChat : IEquatable<ConversationChat>
{
    /// <summary>
    /// The connection state of this communication.
    /// </summary>
    /// <value>The connection state of this communication.</value>
    
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
        /// Enum Dialing for "dialing"
        /// </summary>
        [EnumMember(Value = "dialing")]
        Dialing,

        /// <summary>
        /// Enum Contacting for "contacting"
        /// </summary>
        [EnumMember(Value = "contacting")]
        Contacting,

        /// <summary>
        /// Enum Offering for "offering"
        /// </summary>
        [EnumMember(Value = "offering")]
        Offering,

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
        /// Enum Terminated for "terminated"
        /// </summary>
        [EnumMember(Value = "terminated")]
        Terminated,

        /// <summary>
        /// Enum None for "none"
        /// </summary>
        [EnumMember(Value = "none")]
        None
    }
    /// <summary>
    /// The initial connection state of this communication.
    /// </summary>
    /// <value>The initial connection state of this communication.</value>
    
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
        /// Enum Dialing for "dialing"
        /// </summary>
        [EnumMember(Value = "dialing")]
        Dialing,

        /// <summary>
        /// Enum Contacting for "contacting"
        /// </summary>
        [EnumMember(Value = "contacting")]
        Contacting,

        /// <summary>
        /// Enum Offering for "offering"
        /// </summary>
        [EnumMember(Value = "offering")]
        Offering,

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
        /// Enum Terminated for "terminated"
        /// </summary>
        [EnumMember(Value = "terminated")]
        Terminated,

        /// <summary>
        /// Enum None for "none"
        /// </summary>
        [EnumMember(Value = "none")]
        None
    }
    /// <summary>
    /// The direction of the chat
    /// </summary>
    /// <value>The direction of the chat</value>
    
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
    /// System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects.
    /// </summary>
    /// <value>System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects.</value>
    
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
        /// Enum Uncallable for "uncallable"
        /// </summary>
        [EnumMember(Value = "uncallable")]
        Uncallable,

        /// <summary>
        /// Enum Timeout for "timeout"
        /// </summary>
        [EnumMember(Value = "timeout")]
        Timeout
    }
    /// <summary>
    /// The connection state of this communication.
    /// </summary>
    /// <value>The connection state of this communication.</value>
    [JsonPropertyName("state")]
    public StateEnum? State { get; set; }
    /// <summary>
    /// The initial connection state of this communication.
    /// </summary>
    /// <value>The initial connection state of this communication.</value>
    [JsonPropertyName("initialState")]
    public InitialStateEnum? InitialState { get; set; }
    /// <summary>
    /// The direction of the chat
    /// </summary>
    /// <value>The direction of the chat</value>
    [JsonPropertyName("direction")]
    public DirectionEnum? Direction { get; set; }
    /// <summary>
    /// System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects.
    /// </summary>
    /// <value>System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects.</value>
    [JsonPropertyName("disconnectType")]
    public DisconnectTypeEnum? DisconnectType { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="ConversationChat" /> class.
    /// </summary>
    /// <param name="State">The connection state of this communication..</param>
    /// <param name="InitialState">The initial connection state of this communication..</param>
    /// <param name="Id">A globally unique identifier for this communication..</param>
    /// <param name="RoomId">The room id for the chat..</param>
    /// <param name="RecordingId">A globally unique identifier for the recording associated with this chat..</param>
    /// <param name="Segments">The time line of the participant&#39;s chat, divided into activity segments..</param>
    /// <param name="Held">True if this call is held and the person on this side hears silence..</param>
    /// <param name="Direction">The direction of the chat.</param>
    /// <param name="DisconnectType">System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects..</param>
    /// <param name="StartHoldTime">The timestamp the chat was placed on hold in the cloud clock if the chat is currently on hold. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="StartAlertingTime">The timestamp the communication has when it is first put into an alerting state. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="ConnectedTime">The timestamp when this communication was connected in the cloud clock. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="DisconnectedTime">The timestamp when this communication disconnected from the conversation in the provider clock. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="Provider">The source provider for the email..</param>
    /// <param name="ScriptId">The UUID of the script to use..</param>
    /// <param name="PeerId">The id of the peer communication corresponding to a matching leg for this communication..</param>
    /// <param name="AvatarImageUrl">If available, the URI to the avatar image of this communication..</param>
    /// <param name="JourneyContext">A subset of the Journey System&#39;s data relevant to a part of a conversation (for external linkage and internal usage/context)..</param>
    /// <param name="Wrapup">Call wrap up or disposition data..</param>
    /// <param name="AfterCallWork">After-call work for the communication..</param>
    /// <param name="AfterCallWorkRequired">Indicates if after-call work is required for a communication. Only used when the ACW Setting is Agent Requested..</param>
    /// <param name="QueueMediaSettings">Represents the queue settings for this media type..</param>
    public ConversationChat(StateEnum? State = null, InitialStateEnum? InitialState = null, string Id = null, string RoomId = null, string RecordingId = null, List<Segment> Segments = null, bool? Held = null, DirectionEnum? Direction = null, DisconnectTypeEnum? DisconnectType = null, DateTime? StartHoldTime = null, DateTime? StartAlertingTime = null, DateTime? ConnectedTime = null, DateTime? DisconnectedTime = null, string Provider = null, string ScriptId = null, string PeerId = null, string AvatarImageUrl = null, JourneyContext JourneyContext = null, Wrapup Wrapup = null, AfterCallWork AfterCallWork = null, bool? AfterCallWorkRequired = null, ConversationQueueMediaSettings QueueMediaSettings = null)
    {
        this.State = State;
        this.InitialState = InitialState;
        this.Id = Id;
        this.RoomId = RoomId;
        this.RecordingId = RecordingId;
        this.Segments = Segments;
        this.Held = Held;
        this.Direction = Direction;
        this.DisconnectType = DisconnectType;
        this.StartHoldTime = StartHoldTime;
        this.StartAlertingTime = StartAlertingTime;
        this.ConnectedTime = ConnectedTime;
        this.DisconnectedTime = DisconnectedTime;
        this.Provider = Provider;
        this.ScriptId = ScriptId;
        this.PeerId = PeerId;
        this.AvatarImageUrl = AvatarImageUrl;
        this.JourneyContext = JourneyContext;
        this.Wrapup = Wrapup;
        this.AfterCallWork = AfterCallWork;
        this.AfterCallWorkRequired = AfterCallWorkRequired;
        this.QueueMediaSettings = QueueMediaSettings;

    }







    /// <summary>
    /// A globally unique identifier for this communication.
    /// </summary>
    /// <value>A globally unique identifier for this communication.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// The room id for the chat.
    /// </summary>
    /// <value>The room id for the chat.</value>
    [JsonPropertyName("roomId")]
    public string RoomId { get; set; }



    /// <summary>
    /// A globally unique identifier for the recording associated with this chat.
    /// </summary>
    /// <value>A globally unique identifier for the recording associated with this chat.</value>
    [JsonPropertyName("recordingId")]
    public string RecordingId { get; set; }



    /// <summary>
    /// The time line of the participant&#39;s chat, divided into activity segments.
    /// </summary>
    /// <value>The time line of the participant&#39;s chat, divided into activity segments.</value>
    [JsonPropertyName("segments")]
    public List<Segment> Segments { get; set; }



    /// <summary>
    /// True if this call is held and the person on this side hears silence.
    /// </summary>
    /// <value>True if this call is held and the person on this side hears silence.</value>
    [JsonPropertyName("held")]
    public bool? Held { get; set; }







    /// <summary>
    /// The timestamp the chat was placed on hold in the cloud clock if the chat is currently on hold. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The timestamp the chat was placed on hold in the cloud clock if the chat is currently on hold. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("startHoldTime")]
    public DateTime? StartHoldTime { get; set; }



    /// <summary>
    /// The timestamp the communication has when it is first put into an alerting state. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The timestamp the communication has when it is first put into an alerting state. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("startAlertingTime")]
    public DateTime? StartAlertingTime { get; set; }



    /// <summary>
    /// The timestamp when this communication was connected in the cloud clock. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The timestamp when this communication was connected in the cloud clock. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("connectedTime")]
    public DateTime? ConnectedTime { get; set; }



    /// <summary>
    /// The timestamp when this communication disconnected from the conversation in the provider clock. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The timestamp when this communication disconnected from the conversation in the provider clock. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("disconnectedTime")]
    public DateTime? DisconnectedTime { get; set; }



    /// <summary>
    /// The source provider for the email.
    /// </summary>
    /// <value>The source provider for the email.</value>
    [JsonPropertyName("provider")]
    public string Provider { get; set; }



    /// <summary>
    /// The UUID of the script to use.
    /// </summary>
    /// <value>The UUID of the script to use.</value>
    [JsonPropertyName("scriptId")]
    public string ScriptId { get; set; }



    /// <summary>
    /// The id of the peer communication corresponding to a matching leg for this communication.
    /// </summary>
    /// <value>The id of the peer communication corresponding to a matching leg for this communication.</value>
    [JsonPropertyName("peerId")]
    public string PeerId { get; set; }



    /// <summary>
    /// If available, the URI to the avatar image of this communication.
    /// </summary>
    /// <value>If available, the URI to the avatar image of this communication.</value>
    [JsonPropertyName("avatarImageUrl")]
    public string AvatarImageUrl { get; set; }



    /// <summary>
    /// A subset of the Journey System&#39;s data relevant to a part of a conversation (for external linkage and internal usage/context).
    /// </summary>
    /// <value>A subset of the Journey System&#39;s data relevant to a part of a conversation (for external linkage and internal usage/context).</value>
    [JsonPropertyName("journeyContext")]
    public JourneyContext JourneyContext { get; set; }



    /// <summary>
    /// Call wrap up or disposition data.
    /// </summary>
    /// <value>Call wrap up or disposition data.</value>
    [JsonPropertyName("wrapup")]
    public Wrapup Wrapup { get; set; }



    /// <summary>
    /// After-call work for the communication.
    /// </summary>
    /// <value>After-call work for the communication.</value>
    [JsonPropertyName("afterCallWork")]
    public AfterCallWork AfterCallWork { get; set; }



    /// <summary>
    /// Indicates if after-call work is required for a communication. Only used when the ACW Setting is Agent Requested.
    /// </summary>
    /// <value>Indicates if after-call work is required for a communication. Only used when the ACW Setting is Agent Requested.</value>
    [JsonPropertyName("afterCallWorkRequired")]
    public bool? AfterCallWorkRequired { get; set; }



    /// <summary>
    /// Represents the queue settings for this media type.
    /// </summary>
    /// <value>Represents the queue settings for this media type.</value>
    [JsonPropertyName("queueMediaSettings")]
    public ConversationQueueMediaSettings QueueMediaSettings { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ConversationChat {\n");

        sb.Append("  State: ").Append(State).Append("\n");
        sb.Append("  InitialState: ").Append(InitialState).Append("\n");
        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  RoomId: ").Append(RoomId).Append("\n");
        sb.Append("  RecordingId: ").Append(RecordingId).Append("\n");
        sb.Append("  Segments: ").Append(Segments).Append("\n");
        sb.Append("  Held: ").Append(Held).Append("\n");
        sb.Append("  Direction: ").Append(Direction).Append("\n");
        sb.Append("  DisconnectType: ").Append(DisconnectType).Append("\n");
        sb.Append("  StartHoldTime: ").Append(StartHoldTime).Append("\n");
        sb.Append("  StartAlertingTime: ").Append(StartAlertingTime).Append("\n");
        sb.Append("  ConnectedTime: ").Append(ConnectedTime).Append("\n");
        sb.Append("  DisconnectedTime: ").Append(DisconnectedTime).Append("\n");
        sb.Append("  Provider: ").Append(Provider).Append("\n");
        sb.Append("  ScriptId: ").Append(ScriptId).Append("\n");
        sb.Append("  PeerId: ").Append(PeerId).Append("\n");
        sb.Append("  AvatarImageUrl: ").Append(AvatarImageUrl).Append("\n");
        sb.Append("  JourneyContext: ").Append(JourneyContext).Append("\n");
        sb.Append("  Wrapup: ").Append(Wrapup).Append("\n");
        sb.Append("  AfterCallWork: ").Append(AfterCallWork).Append("\n");
        sb.Append("  AfterCallWorkRequired: ").Append(AfterCallWorkRequired).Append("\n");
        sb.Append("  QueueMediaSettings: ").Append(QueueMediaSettings).Append("\n");
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
        return Equals(obj as ConversationChat);
    }

    /// <summary>
    /// Returns true if ConversationChat instances are equal
    /// </summary>
    /// <param name="other">Instance of ConversationChat to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ConversationChat other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
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
                Id == other.Id ||
                Id != null &&
                Id.Equals(other.Id)
            ) &&
            (
                RoomId == other.RoomId ||
                RoomId != null &&
                RoomId.Equals(other.RoomId)
            ) &&
            (
                RecordingId == other.RecordingId ||
                RecordingId != null &&
                RecordingId.Equals(other.RecordingId)
            ) &&
            (
                Segments == other.Segments ||
                Segments != null &&
                Segments.SequenceEqual(other.Segments)
            ) &&
            (
                Held == other.Held ||
                Held != null &&
                Held.Equals(other.Held)
            ) &&
            (
                Direction == other.Direction ||
                Direction != null &&
                Direction.Equals(other.Direction)
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
                StartAlertingTime == other.StartAlertingTime ||
                StartAlertingTime != null &&
                StartAlertingTime.Equals(other.StartAlertingTime)
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
                AvatarImageUrl == other.AvatarImageUrl ||
                AvatarImageUrl != null &&
                AvatarImageUrl.Equals(other.AvatarImageUrl)
            ) &&
            (
                JourneyContext == other.JourneyContext ||
                JourneyContext != null &&
                JourneyContext.Equals(other.JourneyContext)
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
            if (State != null)
            {
                hash = hash * 59 + State.GetHashCode();
            }

            if (InitialState != null)
            {
                hash = hash * 59 + InitialState.GetHashCode();
            }

            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            if (RoomId != null)
            {
                hash = hash * 59 + RoomId.GetHashCode();
            }

            if (RecordingId != null)
            {
                hash = hash * 59 + RecordingId.GetHashCode();
            }

            if (Segments != null)
            {
                hash = hash * 59 + Segments.GetHashCode();
            }

            if (Held != null)
            {
                hash = hash * 59 + Held.GetHashCode();
            }

            if (Direction != null)
            {
                hash = hash * 59 + Direction.GetHashCode();
            }

            if (DisconnectType != null)
            {
                hash = hash * 59 + DisconnectType.GetHashCode();
            }

            if (StartHoldTime != null)
            {
                hash = hash * 59 + StartHoldTime.GetHashCode();
            }

            if (StartAlertingTime != null)
            {
                hash = hash * 59 + StartAlertingTime.GetHashCode();
            }

            if (ConnectedTime != null)
            {
                hash = hash * 59 + ConnectedTime.GetHashCode();
            }

            if (DisconnectedTime != null)
            {
                hash = hash * 59 + DisconnectedTime.GetHashCode();
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

            if (AvatarImageUrl != null)
            {
                hash = hash * 59 + AvatarImageUrl.GetHashCode();
            }

            if (JourneyContext != null)
            {
                hash = hash * 59 + JourneyContext.GetHashCode();
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

            return hash;
        }
    }
}
