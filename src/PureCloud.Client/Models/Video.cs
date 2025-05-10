namespace PureCloud.Client.Models;

public sealed class Video
{
    /// <summary>
    /// The connection state of this communication.
    /// </summary>
    /// <value>The connection state of this communication.</value>
    public VideoState? State { get; set; }

    /// <summary>
    /// The initial connection state of this communication.
    /// </summary>
    /// <value>The initial connection state of this communication.</value>
    public VideoInitialState? InitialState { get; set; }

    /// <summary>
    /// System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects.
    /// </summary>
    /// <value>System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects.</value>
    public VideoDisconnectType? DisconnectType { get; set; }

    /// <summary>
    /// A globally unique identifier for this communication.
    /// </summary>
    /// <value>A globally unique identifier for this communication.</value>
    public string Id { get; set; }

    /// <summary>
    /// The room id context (xmpp jid) for the conference session.
    /// </summary>
    /// <value>The room id context (xmpp jid) for the conference session.</value>
    public string Context { get; set; }

    /// <summary>
    /// Indicates whether this participant has muted their outgoing audio.
    /// </summary>
    /// <value>Indicates whether this participant has muted their outgoing audio.</value>
    public bool? AudioMuted { get; set; }

    /// <summary>
    /// Indicates whether this participant has muted/paused their outgoing video.
    /// </summary>
    /// <value>Indicates whether this participant has muted/paused their outgoing video.</value>
    public bool? VideoMuted { get; set; }

    /// <summary>
    /// Indicates whether this participant is sharing their screen to the session.
    /// </summary>
    /// <value>Indicates whether this participant is sharing their screen to the session.</value>
    public bool? SharingScreen { get; set; }

    /// <summary>
    /// The number of peer participants from the perspective of the participant in the conference.
    /// </summary>
    /// <value>The number of peer participants from the perspective of the participant in the conference.</value>
    public int? PeerCount { get; set; }

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
    /// The source provider for the video.
    /// </summary>
    /// <value>The source provider for the video.</value>
    public string Provider { get; set; }

    /// <summary>
    /// The id of the peer communication corresponding to a matching leg for this communication.
    /// </summary>
    /// <value>The id of the peer communication corresponding to a matching leg for this communication.</value>
    public string PeerId { get; set; }

    /// <summary>
    /// List of media stream ids
    /// </summary>
    /// <value>List of media stream ids</value>
    public IEnumerable<string> Msids { get; set; }

    /// <summary>
    /// Address and name data for a call endpoint.
    /// </summary>
    /// <value>Address and name data for a call endpoint.</value>
    public Address Self { get; set; }

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
