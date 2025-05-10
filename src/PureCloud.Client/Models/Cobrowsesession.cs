namespace PureCloud.Client.Models;

public sealed class CobrowseSession
{
    /// <summary>
    /// The connection state of this communication.
    /// </summary>
    /// <value>The connection state of this communication.</value>
    public CobrowsesessionState? State { get; set; }

    /// <summary>
    /// The initial connection state of this communication.
    /// </summary>
    /// <value>The initial connection state of this communication.</value>
    public CobrowsesessionInitialState? InitialState { get; set; }

    /// <summary>
    /// System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects.
    /// </summary>
    /// <value>System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects.</value>

    public CobrowsesessionDisconnectType? DisconnectType { get; set; }

    /// <summary>
    /// A globally unique identifier for this communication.
    /// </summary>
    /// <value>A globally unique identifier for this communication.</value>
    public string Id { get; set; }

    /// <summary>
    /// Address and name data for a call endpoint.
    /// </summary>
    /// <value>Address and name data for a call endpoint.</value>
    public Address Self { get; set; }

    /// <summary>
    /// The co-browse session ID.
    /// </summary>
    /// <value>The co-browse session ID.</value>
    public string CobrowseSessionId { get; set; }

    /// <summary>
    /// This value identifies the role of the co-browse client within the co-browse session (a client is a sharer or a viewer).
    /// </summary>
    /// <value>This value identifies the role of the co-browse client within the co-browse session (a client is a sharer or a viewer).</value>
    public string CobrowseRole { get; set; }

    /// <summary>
    /// ID of co-browse participants for which this client has been granted control (list is empty if this client cannot control any shared pages).
    /// </summary>
    /// <value>ID of co-browse participants for which this client has been granted control (list is empty if this client cannot control any shared pages).</value>
    public IEnumerable<string> Controlling { get; set; }

    /// <summary>
    /// The URL that can be used to open co-browse session in web browser.
    /// </summary>
    /// <value>The URL that can be used to open co-browse session in web browser.</value>
    public string ViewerUrl { get; set; }

    /// <summary>
    /// The time when the provider event which triggered this conversation update happened in the corrected provider clock (milliseconds since 1970-01-01 00:00:00 UTC). Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The time when the provider event which triggered this conversation update happened in the corrected provider clock (milliseconds since 1970-01-01 00:00:00 UTC). Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? ProviderEventTime { get; set; }

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
    /// The source provider for the co-browse session.
    /// </summary>
    /// <value>The source provider for the co-browse session.</value>
    public string Provider { get; set; }

    /// <summary>
    /// The id of the peer communication corresponding to a matching leg for this communication.
    /// </summary>
    /// <value>The id of the peer communication corresponding to a matching leg for this communication.</value>
    public string PeerId { get; set; }

    /// <summary>
    /// The time line of the participant&#39;s call, divided into activity segments.
    /// </summary>
    /// <value>The time line of the participant&#39;s call, divided into activity segments.</value>
    public IEnumerable<Segment> Segments { get; set; }

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
