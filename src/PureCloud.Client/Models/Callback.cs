namespace PureCloud.Client.Models;

public sealed class Callback
{
    /// <summary>
    /// The connection state of this communication.
    /// </summary>
    /// <value>The connection state of this communication.</value>
    public CallbackState? State { get; set; }

    /// <summary>
    /// The initial connection state of this communication.
    /// </summary>
    /// <value>The initial connection state of this communication.</value>
    public CallbackInitialState? InitialState { get; set; }

    /// <summary>
    /// The direction of the call
    /// </summary>
    /// <value>The direction of the call</value>
    public CallbackDirection? Direction { get; set; }

    /// <summary>
    /// System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects.
    /// </summary>
    /// <value>System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects.</value>
    public CallbackDisconnectType? DisconnectType { get; set; }

    /// <summary>
    /// A globally unique identifier for this communication.
    /// </summary>
    /// <value>A globally unique identifier for this communication.</value>
    public string Id { get; set; }

    /// <summary>
    /// The time line of the participant&#39;s callback, divided into activity segments.
    /// </summary>
    /// <value>The time line of the participant&#39;s callback, divided into activity segments.</value>
    public IEnumerable<Segment> Segments { get; set; }

    /// <summary>
    /// True if this call is held and the person on this side hears silence.
    /// </summary>
    /// <value>True if this call is held and the person on this side hears silence.</value>
    public bool? Held { get; set; }

    /// <summary>
    /// The timestamp the callback was placed on hold in the cloud clock if the callback is currently on hold. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The timestamp the callback was placed on hold in the cloud clock if the callback is currently on hold. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? StartHoldTime { get; set; }

    /// <summary>
    /// The preview data to be used when this callback is a Preview.
    /// </summary>
    /// <value>The preview data to be used when this callback is a Preview.</value>
    public DialerPreview DialerPreview { get; set; }

    /// <summary>
    /// The voicemail data to be used when this callback is an ACD voicemail.
    /// </summary>
    /// <value>The voicemail data to be used when this callback is an ACD voicemail.</value>
    public Voicemail Voicemail { get; set; }

    /// <summary>
    /// The phone number(s) to use to place the callback.
    /// </summary>
    /// <value>The phone number(s) to use to place the callback.</value>
    public IEnumerable<string> CallbackNumbers { get; set; }

    /// <summary>
    /// The name of the user requesting a callback.
    /// </summary>
    /// <value>The name of the user requesting a callback.</value>
    public string CallbackUserName { get; set; }

    /// <summary>
    /// The UUID of the script to use.
    /// </summary>
    /// <value>The UUID of the script to use.</value>
    public string ScriptId { get; set; }

    /// <summary>
    /// True if the call for the callback uses external dialing.
    /// </summary>
    /// <value>True if the call for the callback uses external dialing.</value>
    public bool? ExternalCampaign { get; set; }

    /// <summary>
    /// True if the ability to skip a callback should be enabled.
    /// </summary>
    /// <value>True if the ability to skip a callback should be enabled.</value>
    public bool? SkipEnabled { get; set; }

    /// <summary>
    /// The number of seconds before the system automatically places a call for a callback.  0 means the automatic placement is disabled.
    /// </summary>
    /// <value>The number of seconds before the system automatically places a call for a callback.  0 means the automatic placement is disabled.</value>
    public int? TimeoutSeconds { get; set; }

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
    /// The timestamp when this communication is scheduled in the provider clock. If this value is missing it indicates the callback will be placed immediately. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The timestamp when this communication is scheduled in the provider clock. If this value is missing it indicates the callback will be placed immediately. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? CallbackScheduledTime { get; set; }

    /// <summary>
    /// The id of the config for automatically placing the callback (and handling the disposition). If null, the callback will not be placed automatically but routed to an agent as per normal.
    /// </summary>
    /// <value>The id of the config for automatically placing the callback (and handling the disposition). If null, the callback will not be placed automatically but routed to an agent as per normal.</value>
    public string AutomatedCallbackConfigId { get; set; }

    /// <summary>
    /// The source provider for the callback.
    /// </summary>
    /// <value>The source provider for the callback.</value>
    public string Provider { get; set; }

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

    /// <summary>
    /// The phone number displayed to recipients of the phone call. The value should conform to the E164 format.
    /// </summary>
    /// <value>The phone number displayed to recipients of the phone call. The value should conform to the E164 format.</value>
    public string CallerId { get; set; }

    /// <summary>
    /// The name displayed to recipients of the phone call.
    /// </summary>
    /// <value>The name displayed to recipients of the phone call.</value>
    public string CallerIdName { get; set; }

    /// <summary>
    /// Represents the queue settings for this media type.
    /// </summary>
    /// <value>Represents the queue settings for this media type.</value>
    public ConversationQueueMediaSettings QueueMediaSettings { get; set; }
}
