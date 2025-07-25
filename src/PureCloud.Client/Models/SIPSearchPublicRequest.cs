namespace PureCloud.Client.Models;

/// <summary>
/// SIPSearchPublicRequest
/// </summary>
public sealed class SIPSearchPublicRequest
{
    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Unique identification of the placed call.
    /// </summary>
    public string CallId { get; set; }

    /// <summary>
    /// SIP user to who the call was placed.
    /// </summary>
    public string ToUser { get; set; }

    /// <summary>
    /// SIP user who placed the call.
    /// </summary>
    public string FromUser { get; set; }

    /// <summary>
    /// Unique identification of the conversation.
    /// </summary>
    public string ConversationId { get; set; }

    /// <summary>
    /// Unique identification of the participant.
    /// </summary>
    public string ParticipantId { get; set; }

    /// <summary>
    /// Start date of the search. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.
    /// </summary>
    public DateTime? DateStart { get; set; }

    /// <summary>
    /// End date of the search. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.
    /// </summary>
    public DateTime? DateEnd { get; set; }

    /// <summary>
    /// The URI for this object.
    /// </summary>
    public string SelfUri { get; set; }
}
