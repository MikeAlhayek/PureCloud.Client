namespace PureCloud.Client.Models;

public sealed class ConversationEventTopicVideo
{
    /// <summary>
    /// Gets or Sets State
    /// </summary>
    public ConversationEventTopicVideoState? State { get; set; }

    /// <summary>
    /// Gets or Sets InitialState
    /// </summary>
    public ConversationEventTopicVideoInitialState? InitialState { get; set; }

    /// <summary>
    /// System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects.
    /// </summary>
    /// <value>System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects.</value>
    public ConversationEventTopicVideoDisconnectType? DisconnectType { get; set; }

    /// <summary>
    /// Address and name data for a call endpoint.
    /// </summary>
    /// <value>Address and name data for a call endpoint.</value>
    public ConversationEventTopicAddress Self { get; set; }

    /// <summary>
    /// A globally unique identifier for this communication.
    /// </summary>
    /// <value>A globally unique identifier for this communication.</value>
    public string Id { get; set; }

    /// <summary>
    /// The room id context (xmpp jid) for the conference session.
    /// </summary>
    /// <value>The room id context (xmpp jid) for the conference session.</value>
    public string Context { get; set; }

    /// <summary>
    /// Indicates whether this participant has muted their outgoing audio.
    /// </summary>
    /// <value>Indicates whether this participant has muted their outgoing audio.</value>
    public bool? AudioMuted { get; set; }

    /// <summary>
    /// Indicates whether this participant has muted/paused their outgoing video.
    /// </summary>
    /// <value>Indicates whether this participant has muted/paused their outgoing video.</value>
    public bool? VideoMuted { get; set; }

    /// <summary>
    /// Indicates whether this participant is sharing their screen to the session.
    /// </summary>
    /// <value>Indicates whether this participant is sharing their screen to the session.</value>
    public bool? SharingScreen { get; set; }

    /// <summary>
    /// The number of peer participants from the perspective of the participant in the conference.
    /// </summary>
    /// <value>The number of peer participants from the perspective of the participant in the conference.</value>
    public object PeerCount { get; set; }

    /// <summary>
    /// The media provider controlling the video.
    /// </summary>
    /// <value>The media provider controlling the video.</value>
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
    /// List of media stream ids
    /// </summary>
    /// <value>List of media stream ids</value>
    public IEnumerable<string> Msids { get; set; }

    /// <summary>
    /// Call wrap up or disposition data.
    /// </summary>
    /// <value>Call wrap up or disposition data.</value>
    public ConversationEventTopicWrapup Wrapup { get; set; }

    /// <summary>
    /// A communication&#39;s after-call work data.
    /// </summary>
    /// <value>A communication&#39;s after-call work data.</value>
    public ConversationEventTopicAfterCallWork AfterCallWork { get; set; }

    /// <summary>
    /// Indicates if after-call is required for a communication. Only used when the ACW Setting is Agent Requested.
    /// </summary>
    /// <value>Indicates if after-call is required for a communication. Only used when the ACW Setting is Agent Requested.</value>
    public bool? AfterCallWorkRequired { get; set; }

    /// <summary>
    /// Represents the queue setting for this media.
    /// </summary>
    /// <value>Represents the queue setting for this media.</value>
    public ConversationEventTopicQueueMediaSettings QueueMediaSettings { get; set; }
}
