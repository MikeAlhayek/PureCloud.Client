using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Call
/// </summary>

public partial class Call : IEquatable<Call>
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
        /// Enum Converting for "converting"
        /// </summary>
        [EnumMember(Value = "converting")]
        Converting,

        /// <summary>
        /// Enum Uploading for "uploading"
        /// </summary>
        [EnumMember(Value = "uploading")]
        Uploading,

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
        /// Enum Converting for "converting"
        /// </summary>
        [EnumMember(Value = "converting")]
        Converting,

        /// <summary>
        /// Enum Uploading for "uploading"
        /// </summary>
        [EnumMember(Value = "uploading")]
        Uploading,

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
    /// The direction of the call
    /// </summary>
    /// <value>The direction of the call</value>
    
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
        /// Enum Endpointdonotdisturb for "endpoint.donotdisturb"
        /// </summary>
        [EnumMember(Value = "endpoint.donotdisturb")]
        Endpointdonotdisturb,

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
        /// Enum Transferdonotdisturb for "transfer.donotdisturb"
        /// </summary>
        [EnumMember(Value = "transfer.donotdisturb")]
        Transferdonotdisturb,

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
    /// The direction of the call
    /// </summary>
    /// <value>The direction of the call</value>
    [JsonPropertyName("direction")]
    public DirectionEnum? Direction { get; set; }
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
    /// Initializes a new instance of the <see cref="Call" /> class.
    /// </summary>
    /// <param name="State">The connection state of this communication..</param>
    /// <param name="InitialState">The initial connection state of this communication..</param>
    /// <param name="Id">A globally unique identifier for this communication..</param>
    /// <param name="Direction">The direction of the call.</param>
    /// <param name="Recording">True if this call is being recorded..</param>
    /// <param name="RecordingState">State of recording on this call..</param>
    /// <param name="RecordersState">Contains the states of different recorders..</param>
    /// <param name="Muted">True if this call is muted so that remote participants can&#39;t hear any audio from this end..</param>
    /// <param name="Confined">True if this call is held and the person on this side hears hold music..</param>
    /// <param name="Held">True if this call is held and the person on this side hears silence..</param>
    /// <param name="SecurePause">True when the recording of this call is in secure pause status..</param>
    /// <param name="RecordingId">A globally unique identifier for the recording associated with this call..</param>
    /// <param name="Segments">The time line of the participant&#39;s call, divided into activity segments..</param>
    /// <param name="ErrorInfo">ErrorInfo.</param>
    /// <param name="DisconnectType">System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects..</param>
    /// <param name="StartHoldTime">The timestamp the call was placed on hold in the cloud clock if the call is currently on hold. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="DocumentId">If call is an outbound fax of a document from content management, then this is the id in content management..</param>
    /// <param name="StartAlertingTime">The timestamp the communication has when it is first put into an alerting state. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="ConnectedTime">The timestamp when this communication was connected in the cloud clock. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="DisconnectedTime">The timestamp when this communication disconnected from the conversation in the provider clock. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="DisconnectReasons">List of reasons that this call was disconnected. This will be set once the call disconnects..</param>
    /// <param name="FaxStatus">Extra information on fax transmission..</param>
    /// <param name="Provider">The source provider for the call..</param>
    /// <param name="ScriptId">The UUID of the script to use..</param>
    /// <param name="PeerId">The id of the peer communication corresponding to a matching leg for this communication..</param>
    /// <param name="UuiData">User to User Information (UUI) data managed by SIP session application..</param>
    /// <param name="Self">Address and name data for a call endpoint..</param>
    /// <param name="Other">Address and name data for a call endpoint..</param>
    /// <param name="Wrapup">Call wrap up or disposition data..</param>
    /// <param name="AfterCallWork">After-call work for the communication..</param>
    /// <param name="AfterCallWorkRequired">Indicates if after-call work is required for a communication. Only used when the ACW Setting is Agent Requested..</param>
    /// <param name="AgentAssistantId">UUID of virtual agent assistant that provide suggestions to the agent participant during the conversation..</param>
    /// <param name="QueueMediaSettings">Represents the queue settings for this media type..</param>
    /// <param name="Disposition">Call resolution data for Dialer bulk make calls commands..</param>
    public Call(StateEnum? State = null, InitialStateEnum? InitialState = null, string Id = null, DirectionEnum? Direction = null, bool? Recording = null, RecordingStateEnum? RecordingState = null, RecordersState RecordersState = null, bool? Muted = null, bool? Confined = null, bool? Held = null, bool? SecurePause = null, string RecordingId = null, List<Segment> Segments = null, ErrorInfo ErrorInfo = null, DisconnectTypeEnum? DisconnectType = null, DateTime? StartHoldTime = null, string DocumentId = null, DateTime? StartAlertingTime = null, DateTime? ConnectedTime = null, DateTime? DisconnectedTime = null, List<DisconnectReason> DisconnectReasons = null, FaxStatus FaxStatus = null, string Provider = null, string ScriptId = null, string PeerId = null, string UuiData = null, Address Self = null, Address Other = null, Wrapup Wrapup = null, AfterCallWork AfterCallWork = null, bool? AfterCallWorkRequired = null, string AgentAssistantId = null, ConversationQueueMediaSettings QueueMediaSettings = null, Disposition Disposition = null)
    {
        this.State = State;
        this.InitialState = InitialState;
        this.Id = Id;
        this.Direction = Direction;
        this.Recording = Recording;
        this.RecordingState = RecordingState;
        this.RecordersState = RecordersState;
        this.Muted = Muted;
        this.Confined = Confined;
        this.Held = Held;
        this.SecurePause = SecurePause;
        this.RecordingId = RecordingId;
        this.Segments = Segments;
        this.ErrorInfo = ErrorInfo;
        this.DisconnectType = DisconnectType;
        this.StartHoldTime = StartHoldTime;
        this.DocumentId = DocumentId;
        this.StartAlertingTime = StartAlertingTime;
        this.ConnectedTime = ConnectedTime;
        this.DisconnectedTime = DisconnectedTime;
        this.DisconnectReasons = DisconnectReasons;
        this.FaxStatus = FaxStatus;
        this.Provider = Provider;
        this.ScriptId = ScriptId;
        this.PeerId = PeerId;
        this.UuiData = UuiData;
        this.Self = Self;
        this.Other = Other;
        this.Wrapup = Wrapup;
        this.AfterCallWork = AfterCallWork;
        this.AfterCallWorkRequired = AfterCallWorkRequired;
        this.AgentAssistantId = AgentAssistantId;
        this.QueueMediaSettings = QueueMediaSettings;
        this.Disposition = Disposition;

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
    /// Contains the states of different recorders.
    /// </summary>
    /// <value>Contains the states of different recorders.</value>
    [JsonPropertyName("recordersState")]
    public RecordersState RecordersState { get; set; }



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
    /// A globally unique identifier for the recording associated with this call.
    /// </summary>
    /// <value>A globally unique identifier for the recording associated with this call.</value>
    [JsonPropertyName("recordingId")]
    public string RecordingId { get; set; }



    /// <summary>
    /// The time line of the participant&#39;s call, divided into activity segments.
    /// </summary>
    /// <value>The time line of the participant&#39;s call, divided into activity segments.</value>
    [JsonPropertyName("segments")]
    public List<Segment> Segments { get; set; }



    /// <summary>
    /// Gets or Sets ErrorInfo
    /// </summary>
    [JsonPropertyName("errorInfo")]
    public ErrorInfo ErrorInfo { get; set; }





    /// <summary>
    /// The timestamp the call was placed on hold in the cloud clock if the call is currently on hold. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The timestamp the call was placed on hold in the cloud clock if the call is currently on hold. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("startHoldTime")]
    public DateTime? StartHoldTime { get; set; }



    /// <summary>
    /// If call is an outbound fax of a document from content management, then this is the id in content management.
    /// </summary>
    /// <value>If call is an outbound fax of a document from content management, then this is the id in content management.</value>
    [JsonPropertyName("documentId")]
    public string DocumentId { get; set; }



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
    /// List of reasons that this call was disconnected. This will be set once the call disconnects.
    /// </summary>
    /// <value>List of reasons that this call was disconnected. This will be set once the call disconnects.</value>
    [JsonPropertyName("disconnectReasons")]
    public List<DisconnectReason> DisconnectReasons { get; set; }



    /// <summary>
    /// Extra information on fax transmission.
    /// </summary>
    /// <value>Extra information on fax transmission.</value>
    [JsonPropertyName("faxStatus")]
    public FaxStatus FaxStatus { get; set; }



    /// <summary>
    /// The source provider for the call.
    /// </summary>
    /// <value>The source provider for the call.</value>
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
    /// User to User Information (UUI) data managed by SIP session application.
    /// </summary>
    /// <value>User to User Information (UUI) data managed by SIP session application.</value>
    [JsonPropertyName("uuiData")]
    public string UuiData { get; set; }



    /// <summary>
    /// Address and name data for a call endpoint.
    /// </summary>
    /// <value>Address and name data for a call endpoint.</value>
    [JsonPropertyName("self")]
    public Address Self { get; set; }



    /// <summary>
    /// Address and name data for a call endpoint.
    /// </summary>
    /// <value>Address and name data for a call endpoint.</value>
    [JsonPropertyName("other")]
    public Address Other { get; set; }



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
    /// UUID of virtual agent assistant that provide suggestions to the agent participant during the conversation.
    /// </summary>
    /// <value>UUID of virtual agent assistant that provide suggestions to the agent participant during the conversation.</value>
    [JsonPropertyName("agentAssistantId")]
    public string AgentAssistantId { get; set; }



    /// <summary>
    /// Represents the queue settings for this media type.
    /// </summary>
    /// <value>Represents the queue settings for this media type.</value>
    [JsonPropertyName("queueMediaSettings")]
    public ConversationQueueMediaSettings QueueMediaSettings { get; set; }



    /// <summary>
    /// Call resolution data for Dialer bulk make calls commands.
    /// </summary>
    /// <value>Call resolution data for Dialer bulk make calls commands.</value>
    [JsonPropertyName("disposition")]
    public Disposition Disposition { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class Call {\n");

        sb.Append("  State: ").Append(State).Append("\n");
        sb.Append("  InitialState: ").Append(InitialState).Append("\n");
        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Direction: ").Append(Direction).Append("\n");
        sb.Append("  Recording: ").Append(Recording).Append("\n");
        sb.Append("  RecordingState: ").Append(RecordingState).Append("\n");
        sb.Append("  RecordersState: ").Append(RecordersState).Append("\n");
        sb.Append("  Muted: ").Append(Muted).Append("\n");
        sb.Append("  Confined: ").Append(Confined).Append("\n");
        sb.Append("  Held: ").Append(Held).Append("\n");
        sb.Append("  SecurePause: ").Append(SecurePause).Append("\n");
        sb.Append("  RecordingId: ").Append(RecordingId).Append("\n");
        sb.Append("  Segments: ").Append(Segments).Append("\n");
        sb.Append("  ErrorInfo: ").Append(ErrorInfo).Append("\n");
        sb.Append("  DisconnectType: ").Append(DisconnectType).Append("\n");
        sb.Append("  StartHoldTime: ").Append(StartHoldTime).Append("\n");
        sb.Append("  DocumentId: ").Append(DocumentId).Append("\n");
        sb.Append("  StartAlertingTime: ").Append(StartAlertingTime).Append("\n");
        sb.Append("  ConnectedTime: ").Append(ConnectedTime).Append("\n");
        sb.Append("  DisconnectedTime: ").Append(DisconnectedTime).Append("\n");
        sb.Append("  DisconnectReasons: ").Append(DisconnectReasons).Append("\n");
        sb.Append("  FaxStatus: ").Append(FaxStatus).Append("\n");
        sb.Append("  Provider: ").Append(Provider).Append("\n");
        sb.Append("  ScriptId: ").Append(ScriptId).Append("\n");
        sb.Append("  PeerId: ").Append(PeerId).Append("\n");
        sb.Append("  UuiData: ").Append(UuiData).Append("\n");
        sb.Append("  Self: ").Append(Self).Append("\n");
        sb.Append("  Other: ").Append(Other).Append("\n");
        sb.Append("  Wrapup: ").Append(Wrapup).Append("\n");
        sb.Append("  AfterCallWork: ").Append(AfterCallWork).Append("\n");
        sb.Append("  AfterCallWorkRequired: ").Append(AfterCallWorkRequired).Append("\n");
        sb.Append("  AgentAssistantId: ").Append(AgentAssistantId).Append("\n");
        sb.Append("  QueueMediaSettings: ").Append(QueueMediaSettings).Append("\n");
        sb.Append("  Disposition: ").Append(Disposition).Append("\n");
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
        return Equals(obj as Call);
    }

    /// <summary>
    /// Returns true if Call instances are equal
    /// </summary>
    /// <param name="other">Instance of Call to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Call other)
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
                Direction == other.Direction ||
                Direction != null &&
                Direction.Equals(other.Direction)
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
                RecordersState == other.RecordersState ||
                RecordersState != null &&
                RecordersState.Equals(other.RecordersState)
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
                DocumentId == other.DocumentId ||
                DocumentId != null &&
                DocumentId.Equals(other.DocumentId)
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
                UuiData == other.UuiData ||
                UuiData != null &&
                UuiData.Equals(other.UuiData)
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
            ) &&
            (
                Disposition == other.Disposition ||
                Disposition != null &&
                Disposition.Equals(other.Disposition)
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

            if (Direction != null)
            {
                hash = hash * 59 + Direction.GetHashCode();
            }

            if (Recording != null)
            {
                hash = hash * 59 + Recording.GetHashCode();
            }

            if (RecordingState != null)
            {
                hash = hash * 59 + RecordingState.GetHashCode();
            }

            if (RecordersState != null)
            {
                hash = hash * 59 + RecordersState.GetHashCode();
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

            if (RecordingId != null)
            {
                hash = hash * 59 + RecordingId.GetHashCode();
            }

            if (Segments != null)
            {
                hash = hash * 59 + Segments.GetHashCode();
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

            if (DocumentId != null)
            {
                hash = hash * 59 + DocumentId.GetHashCode();
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

            if (DisconnectReasons != null)
            {
                hash = hash * 59 + DisconnectReasons.GetHashCode();
            }

            if (FaxStatus != null)
            {
                hash = hash * 59 + FaxStatus.GetHashCode();
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

            if (UuiData != null)
            {
                hash = hash * 59 + UuiData.GetHashCode();
            }

            if (Self != null)
            {
                hash = hash * 59 + Self.GetHashCode();
            }

            if (Other != null)
            {
                hash = hash * 59 + Other.GetHashCode();
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

            if (Disposition != null)
            {
                hash = hash * 59 + Disposition.GetHashCode();
            }

            return hash;
        }
    }
}
