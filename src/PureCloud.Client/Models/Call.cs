namespace PureCloud.Client.Models;

public sealed class Call
{
    /// <summary>
    /// The connection state of this communication.
    /// </summary>
    /// <value>The connection state of this communication.</value>
    public CallState? State { get; set; }

    /// <summary>
    /// The initial connection state of this communication.
    /// </summary>
    /// <value>The initial connection state of this communication.</value>
    public CallInitialState? InitialState { get; set; }

    /// <summary>
    /// The direction of the call
    /// </summary>
    /// <value>The direction of the call</value>
    public DirectionEnum? Direction { get; set; }

    /// <summary>
    /// State of recording on this call.
    /// </summary>
    /// <value>State of recording on this call.</value>
    public CallRecordingState? RecordingState { get; set; }

    /// <summary>
    /// System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects.
    /// </summary>
    /// <value>System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects.</value>
    public CallDisconnectType? DisconnectType { get; set; }

    /// <summary>
    /// A globally unique identifier for this communication.
    /// </summary>
    /// <value>A globally unique identifier for this communication.</value>
    public string Id { get; set; }

    /// <summary>
    /// True if this call is being recorded.
    /// </summary>
    /// <value>True if this call is being recorded.</value>
    public bool? Recording { get; set; }

    /// <summary>
    /// Contains the states of different recorders.
    /// </summary>
    /// <value>Contains the states of different recorders.</value>
    public RecordersState RecordersState { get; set; }

    /// <summary>
    /// True if this call is muted so that remote participants can&#39;t hear any audio from this end.
    /// </summary>
    /// <value>True if this call is muted so that remote participants can&#39;t hear any audio from this end.</value>
    public bool? Muted { get; set; }

    /// <summary>
    /// True if this call is held and the person on this side hears hold music.
    /// </summary>
    /// <value>True if this call is held and the person on this side hears hold music.</value>
    public bool? Confined { get; set; }

    /// <summary>
    /// True if this call is held and the person on this side hears silence.
    /// </summary>
    /// <value>True if this call is held and the person on this side hears silence.</value>
    public bool? Held { get; set; }

    /// <summary>
    /// True when the recording of this call is in secure pause status.
    /// </summary>
    /// <value>True when the recording of this call is in secure pause status.</value>
    public bool? SecurePause { get; set; }

    /// <summary>
    /// A globally unique identifier for the recording associated with this call.
    /// </summary>
    /// <value>A globally unique identifier for the recording associated with this call.</value>
    public string RecordingId { get; set; }

    /// <summary>
    /// The time line of the participant&#39;s call, divided into activity segments.
    /// </summary>
    /// <value>The time line of the participant&#39;s call, divided into activity segments.</value>
    public IEnumerable<Segment> Segments { get; set; }

    /// <summary>
    /// Gets or Sets ErrorInfo
    /// </summary>
    public ErrorInfo ErrorInfo { get; set; }

    /// <summary>
    /// The timestamp the call was placed on hold in the cloud clock if the call is currently on hold. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The timestamp the call was placed on hold in the cloud clock if the call is currently on hold. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? StartHoldTime { get; set; }

    /// <summary>
    /// If call is an outbound fax of a document from content management, then this is the id in content management.
    /// </summary>
    /// <value>If call is an outbound fax of a document from content management, then this is the id in content management.</value>
    public string DocumentId { get; set; }

    /// <summary>
    /// The timestamp the communication has when it is first put into an alerting state. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The timestamp the communication has when it is first put into an alerting state. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? StartAlertingTime { get; set; }

    /// <summary>
    /// The timestamp when this communication was connected in the cloud clock. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The timestamp when this communication was connected in the cloud clock. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? ConnectedTime { get; set; }

    /// <summary>
    /// The timestamp when this communication disconnected from the conversation in the provider clock. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The timestamp when this communication disconnected from the conversation in the provider clock. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DisconnectedTime { get; set; }

    /// <summary>
    /// List of reasons that this call was disconnected. This will be set once the call disconnects.
    /// </summary>
    /// <value>List of reasons that this call was disconnected. This will be set once the call disconnects.</value>
    public IEnumerable<DisconnectReason> DisconnectReasons { get; set; }

    /// <summary>
    /// Extra information on fax transmission.
    /// </summary>
    /// <value>Extra information on fax transmission.</value>
    public FaxStatus FaxStatus { get; set; }

    /// <summary>
    /// The source provider for the call.
    /// </summary>
    /// <value>The source provider for the call.</value>
    public string Provider { get; set; }

    /// <summary>
    /// The UUID of the script to use.
    /// </summary>
    /// <value>The UUID of the script to use.</value>
    public string ScriptId { get; set; }

    /// <summary>
    /// The id of the peer communication corresponding to a matching leg for this communication.
    /// </summary>
    /// <value>The id of the peer communication corresponding to a matching leg for this communication.</value>
    public string PeerId { get; set; }

    /// <summary>
    /// User to User Information (UUI) data managed by SIP session application.
    /// </summary>
    /// <value>User to User Information (UUI) data managed by SIP session application.</value>
    public string UuiData { get; set; }

    /// <summary>
    /// Address and name data for a call endpoint.
    /// </summary>
    /// <value>Address and name data for a call endpoint.</value>
    public Address Self { get; set; }

    /// <summary>
    /// Address and name data for a call endpoint.
    /// </summary>
    /// <value>Address and name data for a call endpoint.</value>
    public Address Other { get; set; }

    /// <summary>
    /// Call wrap up or disposition data.
    /// </summary>
    /// <value>Call wrap up or disposition data.</value>
    public Wrapup Wrapup { get; set; }

    /// <summary>
    /// After-call work for the communication.
    /// </summary>
    /// <value>After-call work for the communication.</value>
    public AfterCallWork AfterCallWork { get; set; }

    /// <summary>
    /// Indicates if after-call work is required for a communication. Only used when the ACW Setting is Agent Requested.
    /// </summary>
    /// <value>Indicates if after-call work is required for a communication. Only used when the ACW Setting is Agent Requested.</value>
    public bool? AfterCallWorkRequired { get; set; }

    /// <summary>
    /// UUID of virtual agent assistant that provide suggestions to the agent participant during the conversation.
    /// </summary>
    /// <value>UUID of virtual agent assistant that provide suggestions to the agent participant during the conversation.</value>
    public string AgentAssistantId { get; set; }

    /// <summary>
    /// Represents the queue settings for this media type.
    /// </summary>
    /// <value>Represents the queue settings for this media type.</value>
    public ConversationQueueMediaSettings QueueMediaSettings { get; set; }

    /// <summary>
    /// Call resolution data for Dialer bulk make calls commands.
    /// </summary>
    /// <value>Call resolution data for Dialer bulk make calls commands.</value>
    public Disposition Disposition { get; set; }
}
