namespace PureCloud.Client.Models.Conversations;

public sealed class ConversationEventTopicCall
{
    /// <summary>
    /// Gets or Sets State
    /// </summary>
    public ConversationEventTopicCallState? State { get; set; }

    /// <summary>
    /// Gets or Sets InitialState
    /// </summary>
    public ConversationEventTopicCallInitialState? InitialState { get; set; }

    /// <summary>
    /// State of recording on this call.
    /// </summary>
    /// <value>State of recording on this call.</value>
    public ConversationEventTopicCallRecordingState? RecordingState { get; set; }

    /// <summary>
    /// System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects.
    /// </summary>
    /// <value>System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects.</value>
    public ConversationEventTopicCallDisconnectType? DisconnectType { get; set; }

    /// <summary>
    /// Whether a call is inbound or outbound.
    /// </summary>
    /// <value>Whether a call is inbound or outbound.</value>
    public ConversationEventTopicCallDirection? Direction { get; set; }

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
    /// Gets or Sets ErrorInfo
    /// </summary>
    public ConversationEventTopicErrorDetails ErrorInfo { get; set; }

    /// <summary>
    /// The timestamp the call was placed on hold in the cloud clock if the call is currently on hold.
    /// </summary>
    /// <value>The timestamp the call was placed on hold in the cloud clock if the call is currently on hold.</value>
    public DateTime? StartHoldTime { get; set; }

    /// <summary>
    /// If call is a fax of a document in content management, the id of the document in content management.
    /// </summary>
    /// <value>If call is a fax of a document in content management, the id of the document in content management.</value>
    public string DocumentId { get; set; }

    /// <summary>
    /// Gets or Sets Self
    /// </summary>
    public ConversationEventTopicAddress Self { get; set; }

    /// <summary>
    /// Address and name data for a call endpoint.
    /// </summary>
    /// <value>Address and name data for a call endpoint.</value>
    public ConversationEventTopicAddress Other { get; set; }

    /// <summary>
    /// The source provider of the call.
    /// </summary>
    /// <value>The source provider of the call.</value>
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
    /// The timestamp when this communication was connected in the cloud clock.
    /// </summary>
    /// <value>The timestamp when this communication was connected in the cloud clock.</value>
    public DateTime? ConnectedTime { get; set; }

    /// <summary>
    /// The timestamp when this communication disconnected from the conversation in the provider clock.
    /// </summary>
    /// <value>The timestamp when this communication disconnected from the conversation in the provider clock.</value>
    public DateTime? DisconnectedTime { get; set; }

    /// <summary>
    /// List of reasons that this call was disconnected. This will be set once the call disconnects.
    /// </summary>
    /// <value>List of reasons that this call was disconnected. This will be set once the call disconnects.</value>
    public IEnumerable<ConversationEventTopicDisconnectReason> DisconnectReasons { get; set; }

    /// <summary>
    /// Gets or Sets FaxStatus
    /// </summary>
    public ConversationEventTopicFaxStatus FaxStatus { get; set; }

    /// <summary>
    /// User to User Information (UUI) data managed by SIP session application.
    /// </summary>
    /// <value>User to User Information (UUI) data managed by SIP session application.</value>
    public string UuiData { get; set; }

    /// <summary>
    /// The timestamp when this participant was connected to the barge conference in the provider clock.
    /// </summary>
    /// <value>The timestamp when this participant was connected to the barge conference in the provider clock.</value>
    public DateTime? BargedTime { get; set; }

    /// <summary>
    /// Call wrap up or disposition data.
    /// </summary>
    /// <value>Call wrap up or disposition data.</value>
    public ConversationEventTopicWrapup Wrapup { get; set; }

    /// <summary>
    /// Gets or Sets AfterCallWork
    /// </summary>
    public ConversationEventTopicAfterCallWork AfterCallWork { get; set; }

    /// <summary>
    /// Indicates if after-call is required for a communication. Only used when the ACW Setting is Agent Requested.
    /// </summary>
    /// <value>Indicates if after-call is required for a communication. Only used when the ACW Setting is Agent Requested.</value>
    public bool? AfterCallWorkRequired { get; set; }

    /// <summary>
    /// UUID of virtual agent assistant that provide suggestions to the agent participant during the conversation.
    /// </summary>
    /// <value>UUID of virtual agent assistant that provide suggestions to the agent participant during the conversation.</value>
    public string AgentAssistantId { get; set; }

    /// <summary>
    /// Gets or Sets QueueMediaSettings
    /// </summary>
    public ConversationEventTopicQueueMediaSettings QueueMediaSettings { get; set; }
}
