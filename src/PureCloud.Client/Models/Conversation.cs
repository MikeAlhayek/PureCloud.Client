using PureCloud.Client.Models.Conversations;

namespace PureCloud.Client.Models;

/// <summary>
/// Conversation
/// </summary>
public sealed class Conversation
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
    /// The external tag associated with the conversation.
    /// </summary>
    public string ExternalTag { get; set; }

    /// <summary>
    /// The time when the conversation started. This will be the time when the first participant joined the conversation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    public DateTime? StartTime { get; set; }

    /// <summary>
    /// The time when the conversation ended. This will be the time when the last participant left the conversation, or null when the conversation is still active. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    public DateTime? EndTime { get; set; }

    /// <summary>
    /// Identifiers of divisions associated with this conversation
    /// </summary>
    public IEnumerable<ConversationDivisionMembership> Divisions { get; set; }

    /// <summary>
    /// True when the recording of this conversation is in secure pause status.
    /// </summary>
    public bool? SecurePause { get; set; }

    /// <summary>
    /// An optional label that categorizes the conversation.  Max-utilization settings can be configured at a per-label level
    /// </summary>
    public string UtilizationLabelId { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    public string SelfUri { get; set; }

    /// <summary>
    /// Gets or Sets Participants
    /// </summary>
    public IEnumerable<ParticipantBasic> Participants { get; set; }
}