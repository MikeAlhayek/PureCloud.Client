namespace PureCloud.Client.Models;

public sealed class ConversationChat
{
    /// <summary>
    /// The connection state of this communication.
    /// </summary>
    /// <value>The connection state of this communication.</value>
    public ConversationChatState? State { get; set; }

    /// <summary>
    /// The initial connection state of this communication.
    /// </summary>
    /// <value>The initial connection state of this communication.</value>
    public ConversationChatInitialState? InitialState { get; set; }

    /// <summary>
    /// The direction of the chat
    /// </summary>
    /// <value>The direction of the chat</value>
    public ConversationChatDirection? Direction { get; set; }

    /// <summary>
    /// System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects.
    /// </summary>
    /// <value>System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects.</value>
    public ConversationChatDisconnectType? DisconnectType { get; set; }

    /// <summary>
    /// A globally unique identifier for this communication.
    /// </summary>
    /// <value>A globally unique identifier for this communication.</value>
    public string Id { get; set; }

    /// <summary>
    /// The room id for the chat.
    /// </summary>
    /// <value>The room id for the chat.</value>
    public string RoomId { get; set; }

    /// <summary>
    /// A globally unique identifier for the recording associated with this chat.
    /// </summary>
    /// <value>A globally unique identifier for the recording associated with this chat.</value>
    public string RecordingId { get; set; }

    /// <summary>
    /// The time line of the participant&#39;s chat, divided into activity segments.
    /// </summary>
    /// <value>The time line of the participant&#39;s chat, divided into activity segments.</value>
    public IEnumerable<Segment> Segments { get; set; }

    /// <summary>
    /// True if this call is held and the person on this side hears silence.
    /// </summary>
    /// <value>True if this call is held and the person on this side hears silence.</value>
    public bool? Held { get; set; }

    /// <summary>
    /// The timestamp the chat was placed on hold in the cloud clock if the chat is currently on hold. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The timestamp the chat was placed on hold in the cloud clock if the chat is currently on hold. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? StartHoldTime { get; set; }

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
    /// The source provider for the email.
    /// </summary>
    /// <value>The source provider for the email.</value>
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
    /// If available, the URI to the avatar image of this communication.
    /// </summary>
    /// <value>If available, the URI to the avatar image of this communication.</value>
    public string AvatarImageUrl { get; set; }

    /// <summary>
    /// A subset of the Journey System&#39;s data relevant to a part of a conversation (for external linkage and internal usage/context).
    /// </summary>
    /// <value>A subset of the Journey System&#39;s data relevant to a part of a conversation (for external linkage and internal usage/context).</value>
    public JourneyContext JourneyContext { get; set; }

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
    /// Represents the queue settings for this media type.
    /// </summary>
    /// <value>Represents the queue settings for this media type.</value>
    public ConversationQueueMediaSettings QueueMediaSettings { get; set; }
}
