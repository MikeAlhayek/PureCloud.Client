namespace PureCloud.Client.Models.Conversations;

/// <summary>
/// ConversationEventTopicChat
/// </summary>
public sealed class ConversationEventTopicChat
{
    /// <summary>
    /// Gets or Sets State
    /// </summary>
    public ConversationEventTopicChatState? State { get; set; }

    /// <summary>
    /// Gets or Sets InitialState
    /// </summary>
    public ConversationEventTopicChatInitialState? InitialState { get; set; }

    /// <summary>
    /// System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects.
    /// </summary>
    /// <value>System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects.</value>
    public ConversationEventTopicChatDisconnectType? DisconnectType { get; set; }

    /// <summary>
    /// A globally unique identifier for this communication.
    /// </summary>
    /// <value>A globally unique identifier for this communication.</value>
    public string Id { get; set; }

    /// <summary>
    /// The source provider of the chat.
    /// </summary>
    /// <value>The source provider of the chat.</value>
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
    /// The room id for the chat.
    /// </summary>
    /// <value>The room id for the chat.</value>
    public string RoomId { get; set; }

    /// <summary>
    /// The avatar for the chat (if available).
    /// </summary>
    /// <value>The avatar for the chat (if available).</value>
    public string AvatarImageUrl { get; set; }

    /// <summary>
    /// True if this call is held and the person on this side hears silence.
    /// </summary>
    /// <value>True if this call is held and the person on this side hears silence.</value>
    public bool? Held { get; set; }

    /// <summary>
    /// The timestamp the chat was placed on hold in the cloud clock if the chat is currently on hold.
    /// </summary>
    /// <value>The timestamp the chat was placed on hold in the cloud clock if the chat is currently on hold.</value>
    public DateTime? StartHoldTime { get; set; }

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
    /// Gets or Sets JourneyContext
    /// </summary>
    public ConversationEventTopicJourneyContext JourneyContext { get; set; }

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
