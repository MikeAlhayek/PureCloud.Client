namespace PureCloud.Client.Models;

public sealed class SocialExpression
{
    /// <summary>
    /// The connection state of this communication.
    /// </summary>
    /// <value>The connection state of this communication.</value>
    public SocialExpressionState? State { get; set; }

    /// <summary>
    /// System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects.
    /// </summary>
    /// <value>System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects.</value>
    public SocialExpressionDisconnectType? DisconnectType { get; set; }

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
    /// The user name for the communication.
    /// </summary>
    /// <value>The user name for the communication.</value>
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
    /// The source provider for the social expression.
    /// </summary>
    /// <value>The source provider for the social expression.</value>
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
}
