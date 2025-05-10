namespace PureCloud.Client.Models;

public sealed class Message
{
    /// <summary>
    /// The connection state of this communication.
    /// </summary>
    /// <value>The connection state of this communication.</value>
    public MessageState? State { get; set; }

    /// <summary>
    /// The initial connection state of this communication.
    /// </summary>
    /// <value>The initial connection state of this communication.</value>
    public MessageInitialState? InitialState { get; set; }

    /// <summary>
    /// The direction of the message.
    /// </summary>
    /// <value>The direction of the message.</value>
    public MessageDirection? Direction { get; set; }

    /// <summary>
    /// System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects.
    /// </summary>
    /// <value>System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects.</value>
    public MessageDisconnectType? DisconnectType { get; set; }

    /// <summary>
    /// Indicates the type of message platform from which the message originated.
    /// </summary>
    /// <value>Indicates the type of message platform from which the message originated.</value>
    public MessageType? Type { get; set; }

    /// <summary>
    /// A globally unique identifier for this communication.
    /// </summary>
    /// <value>A globally unique identifier for this communication.</value>
    public string Id { get; set; }

    /// <summary>
    /// True if this call is held and the person on this side hears silence.
    /// </summary>
    /// <value>True if this call is held and the person on this side hears silence.</value>
    public bool? Held { get; set; }

    /// <summary>
    /// The time line of the participant&#39;s message, divided into activity segments.
    /// </summary>
    /// <value>The time line of the participant&#39;s message, divided into activity segments.</value>
    public IEnumerable<Segment> Segments { get; set; }

    /// <summary>
    /// A globally unique identifier for the recording associated with this message.
    /// </summary>
    /// <value>A globally unique identifier for the recording associated with this message.</value>
    public string RecordingId { get; set; }

    /// <summary>
    /// Gets or Sets ErrorInfo
    /// </summary>
    public ErrorBody ErrorInfo { get; set; }

    /// <summary>
    /// The timestamp the message was placed on hold in the cloud clock if the message is currently on hold. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The timestamp the message was placed on hold in the cloud clock if the message is currently on hold. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
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
    /// The source provider for the message.
    /// </summary>
    /// <value>The source provider for the message.</value>
    public string Provider { get; set; }

    /// <summary>
    /// If true, the participant member is authenticated.
    /// </summary>
    /// <value>If true, the participant member is authenticated.</value>
    public bool? Authenticated { get; set; }

    /// <summary>
    /// Indicates the country where the recipient is associated in ISO 3166-1 alpha-2 format.
    /// </summary>
    /// <value>Indicates the country where the recipient is associated in ISO 3166-1 alpha-2 format.</value>
    public string RecipientCountry { get; set; }

    /// <summary>
    /// The type of the recipient. Eg: Provisioned phoneNumber is the recipient for sms message type.
    /// </summary>
    /// <value>The type of the recipient. Eg: Provisioned phoneNumber is the recipient for sms message type.</value>
    public string RecipientType { get; set; }

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
    /// Address and name data for a call endpoint.
    /// </summary>
    /// <value>Address and name data for a call endpoint.</value>
    public Address ToAddress { get; set; }

    /// <summary>
    /// Address and name data for a call endpoint.
    /// </summary>
    /// <value>Address and name data for a call endpoint.</value>
    public Address FromAddress { get; set; }

    /// <summary>
    /// The messages sent on this communication channel.
    /// </summary>
    /// <value>The messages sent on this communication channel.</value>
    public IEnumerable<MessageDetails> Messages { get; set; }

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
    /// UUID of virtual agent assistant that provide suggestions to the agent participant during the conversation.
    /// </summary>
    /// <value>UUID of virtual agent assistant that provide suggestions to the agent participant during the conversation.</value>
    public string AgentAssistantId { get; set; }

    /// <summary>
    /// The internal id representing the customer supplied sms integration message.
    /// </summary>
    /// <value>The internal id representing the customer supplied sms integration message.</value>
    public string ByoSmsIntegrationId { get; set; }

    /// <summary>
    /// Represents the queue settings for this media type.
    /// </summary>
    /// <value>Represents the queue settings for this media type.</value>
    public ConversationQueueMediaSettings QueueMediaSettings { get; set; }
}
