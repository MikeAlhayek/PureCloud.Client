using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class QueueConversationEventTopicMessage
{
    /// <summary>
    /// Gets or Sets State
    /// </summary>
    public QueueConversationEventTopicMessageStateEnum? State { get; set; }

    /// <summary>
    /// Gets or Sets InitialState
    /// </summary>
    public QueueConversationEventTopicMessageInitialStateEnum? InitialState { get; set; }

    /// <summary>
    /// Whether a message is inbound or outbound.
    /// </summary>
    /// <value>Whether a message is inbound or outbound.</value>
    public DirectionEnum? Direction { get; set; }

    /// <summary>
    /// System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects.
    /// </summary>
    /// <value>System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects.</value>
    public QueueConversationEventTopicMessageDisconnectTypeEnum? DisconnectType { get; set; }

    /// <summary>
    /// Indicates the type of message platform from which the message originated.
    /// </summary>
    /// <value>Indicates the type of message platform from which the message originated.</value>
    public QueueConversationEventTopicMessageTypeEnum? Type { get; set; }

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
    /// Detailed information about an error response.
    /// </summary>
    /// <value>Detailed information about an error response.</value>
    public QueueConversationEventTopicErrorDetails ErrorInfo { get; set; }

    /// <summary>
    /// The source provider of the email.
    /// </summary>
    /// <value>The source provider of the email.</value>
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
    /// The timestamp the email was placed on hold in the cloud clock if the email is currently on hold.
    /// </summary>
    /// <value>The timestamp the email was placed on hold in the cloud clock if the email is currently on hold.</value>
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
    /// Address and name data for a call endpoint.
    /// </summary>
    /// <value>Address and name data for a call endpoint.</value>
    public QueueConversationEventTopicAddress ToAddress { get; set; }

    /// <summary>
    /// Address and name data for a call endpoint.
    /// </summary>
    /// <value>Address and name data for a call endpoint.</value>
    public QueueConversationEventTopicAddress FromAddress { get; set; }

    /// <summary>
    /// The messages sent on this communication channel.
    /// </summary>
    /// <value>The messages sent on this communication channel.</value>
    public IEnumerable<QueueConversationEventTopicMessageDetails> Messages { get; set; }

    /// <summary>
    /// the messages transcript file uri.
    /// </summary>
    /// <value>the messages transcript file uri.</value>
    public string MessagesTranscriptUri { get; set; }

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
    /// A subset of the Journey System&#39;s data relevant to a part of a conversation (for external linkage and internal usage/context).
    /// </summary>
    /// <value>A subset of the Journey System&#39;s data relevant to a part of a conversation (for external linkage and internal usage/context).</value>
    public QueueConversationEventTopicJourneyContext JourneyContext { get; set; }

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
    /// UUID of virtual agent assistant that provide suggestions to the agent participant during the conversation.
    /// </summary>
    /// <value>UUID of virtual agent assistant that provide suggestions to the agent participant during the conversation.</value>
    public string AgentAssistantId { get; set; }

    /// <summary>
    /// Gets or Sets ByoSmsIntegrationId
    /// </summary>
    public string ByoSmsIntegrationId { get; set; }

    /// <summary>
    /// Represents the queue setting for this media.
    /// </summary>
    /// <value>Represents the queue setting for this media.</value>
    public QueueConversationEventTopicQueueMediaSettings QueueMediaSettings { get; set; }
}
