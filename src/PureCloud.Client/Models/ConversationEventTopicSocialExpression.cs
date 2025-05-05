namespace PureCloud.Client.Models;

public partial class ConversationEventTopicSocialExpression
{
    /// <summary>
    /// Gets or Sets State
    /// </summary>
    public ConversationEventTopicSocialExpressionState? State { get; set; }

    /// <summary>
    /// Gets or Sets InitialState
    /// </summary>
    public ConversationEventTopicSocialExpressionInitialState? InitialState { get; set; }

    /// <summary>
    /// System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects.
    /// </summary>
    /// <value>System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects.</value>
    public ConversationEventTopicSocialExpressionDisconnectType? DisconnectType { get; set; }

    /// <summary>
    /// A globally unique identifier for this communication.
    /// </summary>
    /// <value>A globally unique identifier for this communication.</value>
    public string Id { get; set; }

    /// <summary>
    /// A globally unique identifier for the social media.
    /// </summary>
    /// <value>A globally unique identifier for the social media.</value>
    public string SocialMediaId { get; set; }

    /// <summary>
    /// The social network of the communication
    /// </summary>
    /// <value>The social network of the communication</value>
    public string SocialMediaHub { get; set; }

    /// <summary>
    /// The social media user name of the communication
    /// </summary>
    /// <value>The social media user name of the communication</value>
    public string SocialUserName { get; set; }

    /// <summary>
    /// The text preview of the communication contents
    /// </summary>
    /// <value>The text preview of the communication contents</value>
    public string PreviewText { get; set; }

    /// <summary>
    /// A globally unique identifier for the recording associated with this chat.
    /// </summary>
    /// <value>A globally unique identifier for the recording associated with this chat.</value>
    public string RecordingId { get; set; }

    /// <summary>
    /// True if this call is held and the person on this side hears silence.
    /// </summary>
    /// <value>True if this call is held and the person on this side hears silence.</value>
    public bool? Held { get; set; }

    /// <summary>
    /// The source provider of the social expression.
    /// </summary>
    /// <value>The source provider of the social expression.</value>
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
}
