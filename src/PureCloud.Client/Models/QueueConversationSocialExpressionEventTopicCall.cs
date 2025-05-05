using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// QueueConversationSocialExpressionEventTopicCall
/// </summary>

public partial class QueueConversationSocialExpressionEventTopicCall : IEquatable<QueueConversationSocialExpressionEventTopicCall>
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
        /// Enum Uploading for "uploading"
        /// </summary>
        [EnumMember(Value = "uploading")]
        Uploading,

        /// <summary>
        /// Enum Converting for "converting"
        /// </summary>
        [EnumMember(Value = "converting")]
        Converting,

        /// <summary>
        /// Enum Transmitting for "transmitting"
        /// </summary>
        [EnumMember(Value = "transmitting")]
        Transmitting,

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
        /// Enum Uploading for "uploading"
        /// </summary>
        [EnumMember(Value = "uploading")]
        Uploading,

        /// <summary>
        /// Enum Converting for "converting"
        /// </summary>
        [EnumMember(Value = "converting")]
        Converting,

        /// <summary>
        /// Enum Transmitting for "transmitting"
        /// </summary>
        [EnumMember(Value = "transmitting")]
        Transmitting,

        /// <summary>
        /// Enum None for "none"
        /// </summary>
        [EnumMember(Value = "none")]
        None
    }
    /// <summary>
    /// State of recording on this call.
    /// </summary>
    /// <value>State of recording on this call.</value>
    
    public enum RecordingStateEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum None for "none"
        /// </summary>
        [EnumMember(Value = "none")]
        None,

        /// <summary>
        /// Enum Active for "active"
        /// </summary>
        [EnumMember(Value = "active")]
        Active,

        /// <summary>
        /// Enum Paused for "paused"
        /// </summary>
        [EnumMember(Value = "paused")]
        Paused
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
    /// Whether a call is inbound or outbound.
    /// </summary>
    /// <value>Whether a call is inbound or outbound.</value>
    
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
    [JsonPropertyName("state")]
    public StateEnum? State { get; set; }
    /// <summary>
    /// Gets or Sets InitialState
    /// </summary>
    [JsonPropertyName("initialState")]
    public InitialStateEnum? InitialState { get; set; }
    /// <summary>
    /// State of recording on this call.
    /// </summary>
    /// <value>State of recording on this call.</value>
    [JsonPropertyName("recordingState")]
    public RecordingStateEnum? RecordingState { get; set; }
    /// <summary>
    /// System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects.
    /// </summary>
    /// <value>System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects.</value>
    [JsonPropertyName("disconnectType")]
    public DisconnectTypeEnum? DisconnectType { get; set; }
    /// <summary>
    /// Whether a call is inbound or outbound.
    /// </summary>
    /// <value>Whether a call is inbound or outbound.</value>
    [JsonPropertyName("direction")]
    public DirectionEnum? Direction { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="QueueConversationSocialExpressionEventTopicCall" /> class.
    /// </summary>
    /// <param name="Id">A globally unique identifier for this communication..</param>
    /// <param name="State">State.</param>
    /// <param name="InitialState">InitialState.</param>
    /// <param name="Recording">True if this call is being recorded..</param>
    /// <param name="RecordingState">State of recording on this call..</param>
    /// <param name="Muted">True if this call is muted so that remote participants can&#39;t hear any audio from this end..</param>
    /// <param name="Confined">True if this call is held and the person on this side hears hold music..</param>
    /// <param name="Held">True if this call is held and the person on this side hears silence..</param>
    /// <param name="SecurePause">True when the recording of this call is in secure pause status..</param>
    /// <param name="ErrorInfo">ErrorInfo.</param>
    /// <param name="DisconnectType">System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects..</param>
    /// <param name="StartHoldTime">The timestamp the call was placed on hold in the cloud clock if the call is currently on hold..</param>
    /// <param name="Direction">Whether a call is inbound or outbound..</param>
    /// <param name="DocumentId">If call is a fax of a document in content management, the id of the document in content management..</param>
    /// <param name="Self">Self.</param>
    /// <param name="Other">Address and name data for a call endpoint..</param>
    /// <param name="Provider">The source provider of the call..</param>
    /// <param name="ScriptId">The UUID of the script to use..</param>
    /// <param name="PeerId">The id of the peer communication corresponding to a matching leg for this communication..</param>
    /// <param name="ConnectedTime">The timestamp when this communication was connected in the cloud clock..</param>
    /// <param name="DisconnectedTime">The timestamp when this communication disconnected from the conversation in the provider clock..</param>
    /// <param name="DisconnectReasons">List of reasons that this call was disconnected. This will be set once the call disconnects..</param>
    /// <param name="FaxStatus">FaxStatus.</param>
    /// <param name="UuiData">User to User Information (UUI) data managed by SIP session application..</param>
    /// <param name="BargedTime">The timestamp when this participant was connected to the barge conference in the provider clock..</param>
    /// <param name="Wrapup">Call wrap up or disposition data..</param>
    /// <param name="AfterCallWork">AfterCallWork.</param>
    /// <param name="AfterCallWorkRequired">Indicates if after-call is required for a communication. Only used when the ACW Setting is Agent Requested..</param>
    /// <param name="AgentAssistantId">UUID of virtual agent assistant that provide suggestions to the agent participant during the conversation..</param>
    /// <param name="QueueMediaSettings">QueueMediaSettings.</param>
    public QueueConversationSocialExpressionEventTopicCall(string Id = null, StateEnum? State = null, InitialStateEnum? InitialState = null, bool? Recording = null, RecordingStateEnum? RecordingState = null, bool? Muted = null, bool? Confined = null, bool? Held = null, bool? SecurePause = null, QueueConversationSocialExpressionEventTopicErrorDetails ErrorInfo = null, DisconnectTypeEnum? DisconnectType = null, DateTime? StartHoldTime = null, DirectionEnum? Direction = null, string DocumentId = null, QueueConversationSocialExpressionEventTopicAddress Self = null, QueueConversationSocialExpressionEventTopicAddress Other = null, string Provider = null, string ScriptId = null, string PeerId = null, DateTime? ConnectedTime = null, DateTime? DisconnectedTime = null, List<QueueConversationSocialExpressionEventTopicDisconnectReason> DisconnectReasons = null, QueueConversationSocialExpressionEventTopicFaxStatus FaxStatus = null, string UuiData = null, DateTime? BargedTime = null, QueueConversationSocialExpressionEventTopicWrapup Wrapup = null, QueueConversationSocialExpressionEventTopicAfterCallWork AfterCallWork = null, bool? AfterCallWorkRequired = null, string AgentAssistantId = null, QueueConversationSocialExpressionEventTopicQueueMediaSettings QueueMediaSettings = null)
    {
        this.Id = Id;
        this.State = State;
        this.InitialState = InitialState;
        this.Recording = Recording;
        this.RecordingState = RecordingState;
        this.Muted = Muted;
        this.Confined = Confined;
        this.Held = Held;
        this.SecurePause = SecurePause;
        this.ErrorInfo = ErrorInfo;
        this.DisconnectType = DisconnectType;
        this.StartHoldTime = StartHoldTime;
        this.Direction = Direction;
        this.DocumentId = DocumentId;
        this.Self = Self;
        this.Other = Other;
        this.Provider = Provider;
        this.ScriptId = ScriptId;
        this.PeerId = PeerId;
        this.ConnectedTime = ConnectedTime;
        this.DisconnectedTime = DisconnectedTime;
        this.DisconnectReasons = DisconnectReasons;
        this.FaxStatus = FaxStatus;
        this.UuiData = UuiData;
        this.BargedTime = BargedTime;
        this.Wrapup = Wrapup;
        this.AfterCallWork = AfterCallWork;
        this.AfterCallWorkRequired = AfterCallWorkRequired;
        this.AgentAssistantId = AgentAssistantId;
        this.QueueMediaSettings = QueueMediaSettings;

    }



    /// <summary>
    /// A globally unique identifier for this communication.
    /// </summary>
    /// <value>A globally unique identifier for this communication.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }







    /// <summary>
    /// True if this call is being recorded.
    /// </summary>
    /// <value>True if this call is being recorded.</value>
    [JsonPropertyName("recording")]
    public bool? Recording { get; set; }





    /// <summary>
    /// True if this call is muted so that remote participants can&#39;t hear any audio from this end.
    /// </summary>
    /// <value>True if this call is muted so that remote participants can&#39;t hear any audio from this end.</value>
    [JsonPropertyName("muted")]
    public bool? Muted { get; set; }



    /// <summary>
    /// True if this call is held and the person on this side hears hold music.
    /// </summary>
    /// <value>True if this call is held and the person on this side hears hold music.</value>
    [JsonPropertyName("confined")]
    public bool? Confined { get; set; }



    /// <summary>
    /// True if this call is held and the person on this side hears silence.
    /// </summary>
    /// <value>True if this call is held and the person on this side hears silence.</value>
    [JsonPropertyName("held")]
    public bool? Held { get; set; }



    /// <summary>
    /// True when the recording of this call is in secure pause status.
    /// </summary>
    /// <value>True when the recording of this call is in secure pause status.</value>
    [JsonPropertyName("securePause")]
    public bool? SecurePause { get; set; }



    /// <summary>
    /// Gets or Sets ErrorInfo
    /// </summary>
    [JsonPropertyName("errorInfo")]
    public QueueConversationSocialExpressionEventTopicErrorDetails ErrorInfo { get; set; }





    /// <summary>
    /// The timestamp the call was placed on hold in the cloud clock if the call is currently on hold.
    /// </summary>
    /// <value>The timestamp the call was placed on hold in the cloud clock if the call is currently on hold.</value>
    [JsonPropertyName("startHoldTime")]
    public DateTime? StartHoldTime { get; set; }





    /// <summary>
    /// If call is a fax of a document in content management, the id of the document in content management.
    /// </summary>
    /// <value>If call is a fax of a document in content management, the id of the document in content management.</value>
    [JsonPropertyName("documentId")]
    public string DocumentId { get; set; }



    /// <summary>
    /// Gets or Sets Self
    /// </summary>
    [JsonPropertyName("self")]
    public QueueConversationSocialExpressionEventTopicAddress Self { get; set; }



    /// <summary>
    /// Address and name data for a call endpoint.
    /// </summary>
    /// <value>Address and name data for a call endpoint.</value>
    [JsonPropertyName("other")]
    public QueueConversationSocialExpressionEventTopicAddress Other { get; set; }



    /// <summary>
    /// The source provider of the call.
    /// </summary>
    /// <value>The source provider of the call.</value>
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
    /// List of reasons that this call was disconnected. This will be set once the call disconnects.
    /// </summary>
    /// <value>List of reasons that this call was disconnected. This will be set once the call disconnects.</value>
    [JsonPropertyName("disconnectReasons")]
    public List<QueueConversationSocialExpressionEventTopicDisconnectReason> DisconnectReasons { get; set; }



    /// <summary>
    /// Gets or Sets FaxStatus
    /// </summary>
    [JsonPropertyName("faxStatus")]
    public QueueConversationSocialExpressionEventTopicFaxStatus FaxStatus { get; set; }



    /// <summary>
    /// User to User Information (UUI) data managed by SIP session application.
    /// </summary>
    /// <value>User to User Information (UUI) data managed by SIP session application.</value>
    [JsonPropertyName("uuiData")]
    public string UuiData { get; set; }



    /// <summary>
    /// The timestamp when this participant was connected to the barge conference in the provider clock.
    /// </summary>
    /// <value>The timestamp when this participant was connected to the barge conference in the provider clock.</value>
    [JsonPropertyName("bargedTime")]
    public DateTime? BargedTime { get; set; }



    /// <summary>
    /// Call wrap up or disposition data.
    /// </summary>
    /// <value>Call wrap up or disposition data.</value>
    [JsonPropertyName("wrapup")]
    public QueueConversationSocialExpressionEventTopicWrapup Wrapup { get; set; }



    /// <summary>
    /// Gets or Sets AfterCallWork
    /// </summary>
    [JsonPropertyName("afterCallWork")]
    public QueueConversationSocialExpressionEventTopicAfterCallWork AfterCallWork { get; set; }



    /// <summary>
    /// Indicates if after-call is required for a communication. Only used when the ACW Setting is Agent Requested.
    /// </summary>
    /// <value>Indicates if after-call is required for a communication. Only used when the ACW Setting is Agent Requested.</value>
    [JsonPropertyName("afterCallWorkRequired")]
    public bool? AfterCallWorkRequired { get; set; }



    /// <summary>
    /// UUID of virtual agent assistant that provide suggestions to the agent participant during the conversation.
    /// </summary>
    /// <value>UUID of virtual agent assistant that provide suggestions to the agent participant during the conversation.</value>
    [JsonPropertyName("agentAssistantId")]
    public string AgentAssistantId { get; set; }



    /// <summary>
    /// Gets or Sets QueueMediaSettings
    /// </summary>
    [JsonPropertyName("queueMediaSettings")]
    public QueueConversationSocialExpressionEventTopicQueueMediaSettings QueueMediaSettings { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class QueueConversationSocialExpressionEventTopicCall {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  State: ").Append(State).Append("\n");
        sb.Append("  InitialState: ").Append(InitialState).Append("\n");
        sb.Append("  Recording: ").Append(Recording).Append("\n");
        sb.Append("  RecordingState: ").Append(RecordingState).Append("\n");
        sb.Append("  Muted: ").Append(Muted).Append("\n");
        sb.Append("  Confined: ").Append(Confined).Append("\n");
        sb.Append("  Held: ").Append(Held).Append("\n");
        sb.Append("  SecurePause: ").Append(SecurePause).Append("\n");
        sb.Append("  ErrorInfo: ").Append(ErrorInfo).Append("\n");
        sb.Append("  DisconnectType: ").Append(DisconnectType).Append("\n");
        sb.Append("  StartHoldTime: ").Append(StartHoldTime).Append("\n");
        sb.Append("  Direction: ").Append(Direction).Append("\n");
        sb.Append("  DocumentId: ").Append(DocumentId).Append("\n");
        sb.Append("  Self: ").Append(Self).Append("\n");
        sb.Append("  Other: ").Append(Other).Append("\n");
        sb.Append("  Provider: ").Append(Provider).Append("\n");
        sb.Append("  ScriptId: ").Append(ScriptId).Append("\n");
        sb.Append("  PeerId: ").Append(PeerId).Append("\n");
        sb.Append("  ConnectedTime: ").Append(ConnectedTime).Append("\n");
        sb.Append("  DisconnectedTime: ").Append(DisconnectedTime).Append("\n");
        sb.Append("  DisconnectReasons: ").Append(DisconnectReasons).Append("\n");
        sb.Append("  FaxStatus: ").Append(FaxStatus).Append("\n");
        sb.Append("  UuiData: ").Append(UuiData).Append("\n");
        sb.Append("  BargedTime: ").Append(BargedTime).Append("\n");
        sb.Append("  Wrapup: ").Append(Wrapup).Append("\n");
        sb.Append("  AfterCallWork: ").Append(AfterCallWork).Append("\n");
        sb.Append("  AfterCallWorkRequired: ").Append(AfterCallWorkRequired).Append("\n");
        sb.Append("  AgentAssistantId: ").Append(AgentAssistantId).Append("\n");
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
        return Equals(obj as QueueConversationSocialExpressionEventTopicCall);
    }

    /// <summary>
    /// Returns true if QueueConversationSocialExpressionEventTopicCall instances are equal
    /// </summary>
    /// <param name="other">Instance of QueueConversationSocialExpressionEventTopicCall to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(QueueConversationSocialExpressionEventTopicCall other)
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
                Recording == other.Recording ||
                Recording != null &&
                Recording.Equals(other.Recording)
            ) &&
            (
                RecordingState == other.RecordingState ||
                RecordingState != null &&
                RecordingState.Equals(other.RecordingState)
            ) &&
            (
                Muted == other.Muted ||
                Muted != null &&
                Muted.Equals(other.Muted)
            ) &&
            (
                Confined == other.Confined ||
                Confined != null &&
                Confined.Equals(other.Confined)
            ) &&
            (
                Held == other.Held ||
                Held != null &&
                Held.Equals(other.Held)
            ) &&
            (
                SecurePause == other.SecurePause ||
                SecurePause != null &&
                SecurePause.Equals(other.SecurePause)
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
                Direction == other.Direction ||
                Direction != null &&
                Direction.Equals(other.Direction)
            ) &&
            (
                DocumentId == other.DocumentId ||
                DocumentId != null &&
                DocumentId.Equals(other.DocumentId)
            ) &&
            (
                Self == other.Self ||
                Self != null &&
                Self.Equals(other.Self)
            ) &&
            (
                Other == other.Other ||
                Other != null &&
                Other.Equals(other.Other)
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
                DisconnectReasons == other.DisconnectReasons ||
                DisconnectReasons != null &&
                DisconnectReasons.SequenceEqual(other.DisconnectReasons)
            ) &&
            (
                FaxStatus == other.FaxStatus ||
                FaxStatus != null &&
                FaxStatus.Equals(other.FaxStatus)
            ) &&
            (
                UuiData == other.UuiData ||
                UuiData != null &&
                UuiData.Equals(other.UuiData)
            ) &&
            (
                BargedTime == other.BargedTime ||
                BargedTime != null &&
                BargedTime.Equals(other.BargedTime)
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
                AgentAssistantId == other.AgentAssistantId ||
                AgentAssistantId != null &&
                AgentAssistantId.Equals(other.AgentAssistantId)
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

            if (Recording != null)
            {
                hash = hash * 59 + Recording.GetHashCode();
            }

            if (RecordingState != null)
            {
                hash = hash * 59 + RecordingState.GetHashCode();
            }

            if (Muted != null)
            {
                hash = hash * 59 + Muted.GetHashCode();
            }

            if (Confined != null)
            {
                hash = hash * 59 + Confined.GetHashCode();
            }

            if (Held != null)
            {
                hash = hash * 59 + Held.GetHashCode();
            }

            if (SecurePause != null)
            {
                hash = hash * 59 + SecurePause.GetHashCode();
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

            if (Direction != null)
            {
                hash = hash * 59 + Direction.GetHashCode();
            }

            if (DocumentId != null)
            {
                hash = hash * 59 + DocumentId.GetHashCode();
            }

            if (Self != null)
            {
                hash = hash * 59 + Self.GetHashCode();
            }

            if (Other != null)
            {
                hash = hash * 59 + Other.GetHashCode();
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

            if (ConnectedTime != null)
            {
                hash = hash * 59 + ConnectedTime.GetHashCode();
            }

            if (DisconnectedTime != null)
            {
                hash = hash * 59 + DisconnectedTime.GetHashCode();
            }

            if (DisconnectReasons != null)
            {
                hash = hash * 59 + DisconnectReasons.GetHashCode();
            }

            if (FaxStatus != null)
            {
                hash = hash * 59 + FaxStatus.GetHashCode();
            }

            if (UuiData != null)
            {
                hash = hash * 59 + UuiData.GetHashCode();
            }

            if (BargedTime != null)
            {
                hash = hash * 59 + BargedTime.GetHashCode();
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

            if (AgentAssistantId != null)
            {
                hash = hash * 59 + AgentAssistantId.GetHashCode();
            }

            if (QueueMediaSettings != null)
            {
                hash = hash * 59 + QueueMediaSettings.GetHashCode();
            }

            return hash;
        }
    }
}
