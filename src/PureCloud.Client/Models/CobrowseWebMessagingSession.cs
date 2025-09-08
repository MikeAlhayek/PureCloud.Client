namespace PureCloud.Client.Models;

/// <summary>
/// CobrowseWebMessagingSession
/// </summary>
public sealed class CobrowseWebMessagingSession
{
    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Cobrowse session join code
    /// </summary>
    /// <value>Cobrowse session join code</value>
    public string JoinCode { get; set; }

    /// <summary>
    /// WebSocket URL for the JS client
    /// </summary>
    /// <value>WebSocket URL for the JS client</value>
    public string WebsocketUrl { get; set; }

    /// <summary>
    /// Date when Cobrowse Offer Expires. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date when Cobrowse Offer Expires. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateOfferEnds { get; set; }

    /// <summary>
    /// CommunicationType for Cobrowse Session
    /// </summary>
    /// <value>CommunicationType for Cobrowse Session</value>
    public CobrowseWebMessagingSessionCommunicationType? CommunicationType { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}