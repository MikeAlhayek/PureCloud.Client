using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class QueueConversationEventTopicCallback
{
    /// <summary>
    /// Gets or Sets State
    /// </summary>
    public QueueConversationEventTopicCallbackStateEnum? State { get; set; }

    /// <summary>
    /// Gets or Sets InitialState
    /// </summary>
    public QueueConversationEventTopicCallbackInitialStateEnum? InitialState { get; set; }

    /// <summary>
    /// The direction of the call
    /// </summary>
    /// <value>The direction of the call</value>
    public DirectionEnum? Direction { get; set; }

    /// <summary>
    /// System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects.
    /// </summary>
    /// <value>System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects.</value>
    public QueueConversationEventTopicCallbackDisconnectTypeEnum? DisconnectType { get; set; }

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
    /// The timestamp the callback was placed on hold in the cloud clock if the callback is currently on hold.
    /// </summary>
    /// <value>The timestamp the callback was placed on hold in the cloud clock if the callback is currently on hold.</value>
    public DateTime? StartHoldTime { get; set; }

    /// <summary>
    /// Gets or Sets DialerPreview
    /// </summary>
    public QueueConversationEventTopicDialerPreview DialerPreview { get; set; }

    /// <summary>
    /// Gets or Sets Voicemail
    /// </summary>
    public QueueConversationEventTopicVoicemail Voicemail { get; set; }

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
    /// The id of the peer communication corresponding to a matching leg for this communication.
    /// </summary>
    /// <value>The id of the peer communication corresponding to a matching leg for this communication.</value>
    public string PeerId { get; set; }

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
    /// The source provider of the callback.
    /// </summary>
    /// <value>The source provider of the callback.</value>
    public string Provider { get; set; }

    /// <summary>
    /// The number of seconds before the system automatically places a call for a callback.  0 means the automatic placement is disabled.
    /// </summary>
    /// <value>The number of seconds before the system automatically places a call for a callback.  0 means the automatic placement is disabled.</value>
    public long? TimeoutSeconds { get; set; }

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
    /// The timestamp when this communication is scheduled in the provider clock. If this value is missing it indicates the callback will be placed immediately.
    /// </summary>
    /// <value>The timestamp when this communication is scheduled in the provider clock. If this value is missing it indicates the callback will be placed immediately.</value>
    public DateTime? CallbackScheduledTime { get; set; }

    /// <summary>
    /// The id of the config for automatically placing the callback (and handling the disposition). If null, the callback will not be placed automatically but routed to an agent as per normal.
    /// </summary>
    /// <value>The id of the config for automatically placing the callback (and handling the disposition). If null, the callback will not be placed automatically but routed to an agent as per normal.</value>
    public string AutomatedCallbackConfigId { get; set; }

    /// <summary>
    /// Call wrap up or disposition data.
    /// </summary>
    /// <value>Call wrap up or disposition data.</value>
    public QueueConversationEventTopicWrapup Wrapup { get; set; }

    /// <summary>
    /// A communication&#39;s after-call work data.
    /// </summary>
    /// <value>A communication&#39;s after-call work data.</value>
    public QueueConversationEventTopicAfterCallWork AfterCallWork { get; set; }

    /// <summary>
    /// Indicates if after-call is required for a communication. Only used when the ACW Setting is Agent Requested.
    /// </summary>
    /// <value>Indicates if after-call is required for a communication. Only used when the ACW Setting is Agent Requested.</value>
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
    /// Represents the queue setting for this media.
    /// </summary>
    /// <value>Represents the queue setting for this media.</value>
    public QueueConversationEventTopicQueueMediaSettings QueueMediaSettings { get; set; }
}
