using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// QueueConversationVideoEventTopicSocialExpression
/// </summary>

public partial class QueueConversationVideoEventTopicSocialExpression : IEquatable<QueueConversationVideoEventTopicSocialExpression>
{
    /// <summary>
    /// Gets or Sets State
    /// </summary>
    
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
    /// Gets or Sets InitialState
    /// </summary>
    
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
        /// Enum Endpointdnd for "endpoint.dnd"
        /// </summary>
        [EnumMember(Value = "endpoint.dnd")]
        Endpointdnd,

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
        /// Enum Transferdnd for "transfer.dnd"
        /// </summary>
        [EnumMember(Value = "transfer.dnd")]
        Transferdnd,

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
    /// Gets or Sets State
    /// </summary>
    [JsonPropertyName("state")]
    public StateEnum? State { get; set; }
    /// <summary>
    /// Gets or Sets InitialState
    /// </summary>
    [JsonPropertyName("initialState")]
    public InitialStateEnum? InitialState { get; set; }
    /// <summary>
    /// System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects.
    /// </summary>
    /// <value>System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects.</value>
    [JsonPropertyName("disconnectType")]
    public DisconnectTypeEnum? DisconnectType { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="QueueConversationVideoEventTopicSocialExpression" /> class.
    /// </summary>
    /// <param name="State">State.</param>
    /// <param name="InitialState">InitialState.</param>
    /// <param name="Id">A globally unique identifier for this communication..</param>
    /// <param name="SocialMediaId">A globally unique identifier for the social media..</param>
    /// <param name="SocialMediaHub">The social network of the communication.</param>
    /// <param name="SocialUserName">The social media user name of the communication.</param>
    /// <param name="PreviewText">The text preview of the communication contents.</param>
    /// <param name="RecordingId">A globally unique identifier for the recording associated with this chat..</param>
    /// <param name="Held">True if this call is held and the person on this side hears silence..</param>
    /// <param name="Provider">The source provider of the social expression..</param>
    /// <param name="ScriptId">The UUID of the script to use..</param>
    /// <param name="PeerId">The id of the peer communication corresponding to a matching leg for this communication..</param>
    /// <param name="DisconnectType">System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects..</param>
    /// <param name="StartHoldTime">The timestamp the chat was placed on hold in the cloud clock if the chat is currently on hold..</param>
    /// <param name="ConnectedTime">The timestamp when this communication was connected in the cloud clock..</param>
    /// <param name="DisconnectedTime">The timestamp when this communication disconnected from the conversation in the provider clock..</param>
    /// <param name="Wrapup">Call wrap up or disposition data..</param>
    /// <param name="AfterCallWork">A communication&#39;s after-call work data..</param>
    /// <param name="AfterCallWorkRequired">Indicates if after-call is required for a communication. Only used when the ACW Setting is Agent Requested..</param>
    public QueueConversationVideoEventTopicSocialExpression(StateEnum? State = null, InitialStateEnum? InitialState = null, string Id = null, string SocialMediaId = null, string SocialMediaHub = null, string SocialUserName = null, string PreviewText = null, string RecordingId = null, bool? Held = null, string Provider = null, string ScriptId = null, string PeerId = null, DisconnectTypeEnum? DisconnectType = null, DateTime? StartHoldTime = null, DateTime? ConnectedTime = null, DateTime? DisconnectedTime = null, QueueConversationVideoEventTopicWrapup Wrapup = null, QueueConversationVideoEventTopicAfterCallWork AfterCallWork = null, bool? AfterCallWorkRequired = null)
    {
        this.State = State;
        this.InitialState = InitialState;
        this.Id = Id;
        this.SocialMediaId = SocialMediaId;
        this.SocialMediaHub = SocialMediaHub;
        this.SocialUserName = SocialUserName;
        this.PreviewText = PreviewText;
        this.RecordingId = RecordingId;
        this.Held = Held;
        this.Provider = Provider;
        this.ScriptId = ScriptId;
        this.PeerId = PeerId;
        this.DisconnectType = DisconnectType;
        this.StartHoldTime = StartHoldTime;
        this.ConnectedTime = ConnectedTime;
        this.DisconnectedTime = DisconnectedTime;
        this.Wrapup = Wrapup;
        this.AfterCallWork = AfterCallWork;
        this.AfterCallWorkRequired = AfterCallWorkRequired;

    }







    /// <summary>
    /// A globally unique identifier for this communication.
    /// </summary>
    /// <value>A globally unique identifier for this communication.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// A globally unique identifier for the social media.
    /// </summary>
    /// <value>A globally unique identifier for the social media.</value>
    [JsonPropertyName("socialMediaId")]
    public string SocialMediaId { get; set; }



    /// <summary>
    /// The social network of the communication
    /// </summary>
    /// <value>The social network of the communication</value>
    [JsonPropertyName("socialMediaHub")]
    public string SocialMediaHub { get; set; }



    /// <summary>
    /// The social media user name of the communication
    /// </summary>
    /// <value>The social media user name of the communication</value>
    [JsonPropertyName("socialUserName")]
    public string SocialUserName { get; set; }



    /// <summary>
    /// The text preview of the communication contents
    /// </summary>
    /// <value>The text preview of the communication contents</value>
    [JsonPropertyName("previewText")]
    public string PreviewText { get; set; }



    /// <summary>
    /// A globally unique identifier for the recording associated with this chat.
    /// </summary>
    /// <value>A globally unique identifier for the recording associated with this chat.</value>
    [JsonPropertyName("recordingId")]
    public string RecordingId { get; set; }



    /// <summary>
    /// True if this call is held and the person on this side hears silence.
    /// </summary>
    /// <value>True if this call is held and the person on this side hears silence.</value>
    [JsonPropertyName("held")]
    public bool? Held { get; set; }



    /// <summary>
    /// The source provider of the social expression.
    /// </summary>
    /// <value>The source provider of the social expression.</value>
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
    /// The timestamp the chat was placed on hold in the cloud clock if the chat is currently on hold.
    /// </summary>
    /// <value>The timestamp the chat was placed on hold in the cloud clock if the chat is currently on hold.</value>
    [JsonPropertyName("startHoldTime")]
    public DateTime? StartHoldTime { get; set; }



    /// <summary>
    /// The timestamp when this communication was connected in the cloud clock.
    /// </summary>
    /// <value>The timestamp when this communication was connected in the cloud clock.</value>
    [JsonPropertyName("connectedTime")]
    public DateTime? ConnectedTime { get; set; }



    /// <summary>
    /// The timestamp when this communication disconnected from the conversation in the provider clock.
    /// </summary>
    /// <value>The timestamp when this communication disconnected from the conversation in the provider clock.</value>
    [JsonPropertyName("disconnectedTime")]
    public DateTime? DisconnectedTime { get; set; }



    /// <summary>
    /// Call wrap up or disposition data.
    /// </summary>
    /// <value>Call wrap up or disposition data.</value>
    [JsonPropertyName("wrapup")]
    public QueueConversationVideoEventTopicWrapup Wrapup { get; set; }



    /// <summary>
    /// A communication&#39;s after-call work data.
    /// </summary>
    /// <value>A communication&#39;s after-call work data.</value>
    [JsonPropertyName("afterCallWork")]
    public QueueConversationVideoEventTopicAfterCallWork AfterCallWork { get; set; }



    /// <summary>
    /// Indicates if after-call is required for a communication. Only used when the ACW Setting is Agent Requested.
    /// </summary>
    /// <value>Indicates if after-call is required for a communication. Only used when the ACW Setting is Agent Requested.</value>
    [JsonPropertyName("afterCallWorkRequired")]
    public bool? AfterCallWorkRequired { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class QueueConversationVideoEventTopicSocialExpression {\n");

        sb.Append("  State: ").Append(State).Append("\n");
        sb.Append("  InitialState: ").Append(InitialState).Append("\n");
        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  SocialMediaId: ").Append(SocialMediaId).Append("\n");
        sb.Append("  SocialMediaHub: ").Append(SocialMediaHub).Append("\n");
        sb.Append("  SocialUserName: ").Append(SocialUserName).Append("\n");
        sb.Append("  PreviewText: ").Append(PreviewText).Append("\n");
        sb.Append("  RecordingId: ").Append(RecordingId).Append("\n");
        sb.Append("  Held: ").Append(Held).Append("\n");
        sb.Append("  Provider: ").Append(Provider).Append("\n");
        sb.Append("  ScriptId: ").Append(ScriptId).Append("\n");
        sb.Append("  PeerId: ").Append(PeerId).Append("\n");
        sb.Append("  DisconnectType: ").Append(DisconnectType).Append("\n");
        sb.Append("  StartHoldTime: ").Append(StartHoldTime).Append("\n");
        sb.Append("  ConnectedTime: ").Append(ConnectedTime).Append("\n");
        sb.Append("  DisconnectedTime: ").Append(DisconnectedTime).Append("\n");
        sb.Append("  Wrapup: ").Append(Wrapup).Append("\n");
        sb.Append("  AfterCallWork: ").Append(AfterCallWork).Append("\n");
        sb.Append("  AfterCallWorkRequired: ").Append(AfterCallWorkRequired).Append("\n");
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
        return Equals(obj as QueueConversationVideoEventTopicSocialExpression);
    }

    /// <summary>
    /// Returns true if QueueConversationVideoEventTopicSocialExpression instances are equal
    /// </summary>
    /// <param name="other">Instance of QueueConversationVideoEventTopicSocialExpression to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(QueueConversationVideoEventTopicSocialExpression other)
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
                SocialMediaId == other.SocialMediaId ||
                SocialMediaId != null &&
                SocialMediaId.Equals(other.SocialMediaId)
            ) &&
            (
                SocialMediaHub == other.SocialMediaHub ||
                SocialMediaHub != null &&
                SocialMediaHub.Equals(other.SocialMediaHub)
            ) &&
            (
                SocialUserName == other.SocialUserName ||
                SocialUserName != null &&
                SocialUserName.Equals(other.SocialUserName)
            ) &&
            (
                PreviewText == other.PreviewText ||
                PreviewText != null &&
                PreviewText.Equals(other.PreviewText)
            ) &&
            (
                RecordingId == other.RecordingId ||
                RecordingId != null &&
                RecordingId.Equals(other.RecordingId)
            ) &&
            (
                Held == other.Held ||
                Held != null &&
                Held.Equals(other.Held)
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

            if (SocialMediaId != null)
            {
                hash = hash * 59 + SocialMediaId.GetHashCode();
            }

            if (SocialMediaHub != null)
            {
                hash = hash * 59 + SocialMediaHub.GetHashCode();
            }

            if (SocialUserName != null)
            {
                hash = hash * 59 + SocialUserName.GetHashCode();
            }

            if (PreviewText != null)
            {
                hash = hash * 59 + PreviewText.GetHashCode();
            }

            if (RecordingId != null)
            {
                hash = hash * 59 + RecordingId.GetHashCode();
            }

            if (Held != null)
            {
                hash = hash * 59 + Held.GetHashCode();
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

            return hash;
        }
    }
}
