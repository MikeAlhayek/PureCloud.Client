namespace PureCloud.Client.Models;
public sealed class InternalMessage
{
    /// <summary>
    /// The connection state of this communication.
    /// </summary>
    /// <value>The connection state of this communication.</value>
    public InternalMessageState? State { get; set; }

    /// <summary>
    /// The initial connection state of this communication.
    /// </summary>
    /// <value>The initial connection state of this communication.</value>
    public InternalMessageInitialState? InitialState { get; set; }

    /// <summary>
    /// System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects.
    /// </summary>
    /// <value>System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects.</value>
    public InternalMessageDisconnectType? DisconnectType { get; set; }

    /// <summary>
    /// A globally unique identifier for this communication.
    /// </summary>
    /// <value>A globally unique identifier for this communication.</value>
    public string Id { get; set; }

    /// <summary>
    /// The time line of the participant&#39;s internal message, divided into activity segments.
    /// </summary>
    /// <value>The time line of the participant&#39;s internal message, divided into activity segments.</value>
    public IEnumerable<Segment> Segments { get; set; }

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
    /// The id of the peer communication corresponding to a matching leg for this communication.
    /// </summary>
    /// <value>The id of the peer communication corresponding to a matching leg for this communication.</value>
    public string PeerId { get; set; }

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
    /// Address for the participant on receiving side of the internal message communication.
    /// </summary>
    /// <value>Address for the participant on receiving side of the internal message communication.</value>
    public Address ToAddress { get; set; }

    /// <summary>
    /// Address for the participant on the sending side of the internal message communication.
    /// </summary>
    /// <value>Address for the participant on the sending side of the internal message communication.</value>
    public Address FromAddress { get; set; }

    /// <summary>
    /// The messages sent on this communication channel.
    /// </summary>
    /// <value>The messages sent on this communication channel.</value>
    public IEnumerable<InternalMessageDetails> Messages { get; set; }
}
