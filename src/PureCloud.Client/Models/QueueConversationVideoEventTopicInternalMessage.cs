using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class QueueConversationVideoEventTopicInternalMessage
{
    /// <summary>
    /// Gets or Sets State
    /// </summary>
    public QueueConversationVideoEventTopicInternalMessageStateEnum? State { get; set; }

    /// <summary>
    /// Gets or Sets InitialState
    /// </summary>
    public QueueConversationVideoEventTopicInternalMessageInitialStateEnum? InitialState { get; set; }

    /// <summary>
    /// System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects.
    /// </summary>
    /// <value>System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects.</value>
    public QueueConversationVideoEventTopicInternalMessageDisconnectTypeEnum? DisconnectType { get; set; }

    /// <summary>
    /// A globally unique identifier for this communication.
    /// </summary>
    /// <value>A globally unique identifier for this communication.</value>
    public string Id { get; set; }

    /// <summary>
    /// The source provider of the message.
    /// </summary>
    /// <value>The source provider of the message.</value>
    public string Provider { get; set; }

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
    /// The user ID for the participant on receiving side of the internal message conversation.
    /// </summary>
    /// <value>The user ID for the participant on receiving side of the internal message conversation.</value>
    public string TargetUserId { get; set; }

    /// <summary>
    /// The user ID for the participant on sending side of the internal message conversation.
    /// </summary>
    /// <value>The user ID for the participant on sending side of the internal message conversation.</value>
    public string SourceUserId { get; set; }

    /// <summary>
    /// Address and name data for a call endpoint.
    /// </summary>
    /// <value>Address and name data for a call endpoint.</value>
    public QueueConversationVideoEventTopicAddress ToAddress { get; set; }

    /// <summary>
    /// Address and name data for a call endpoint.
    /// </summary>
    /// <value>Address and name data for a call endpoint.</value>
    public QueueConversationVideoEventTopicAddress FromAddress { get; set; }

    /// <summary>
    /// The messages sent on this communication channel.
    /// </summary>
    /// <value>The messages sent on this communication channel.</value>
    public IEnumerable<QueueConversationVideoEventTopicInternalMessageDetails> Messages { get; set; }
}
