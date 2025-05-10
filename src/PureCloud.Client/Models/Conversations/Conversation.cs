namespace PureCloud.Client.Models;

public sealed class Conversation
{
    /// <summary>
    /// On update, 'paused' initiates a secure pause, 'active' resumes any paused recordings; otherwise indicates state of conversation recording.
    /// </summary>
    /// <value>On update, 'paused' initiates a secure pause, 'active' resumes any paused recordings; otherwise indicates state of conversation recording.</value>
    public ConversationRecordingState? RecordingState { get; set; }

    /// <summary>
    /// The conversation's state
    /// </summary>
    /// <value>The conversation's state</value>
    public ConversationState? State { get; set; }

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
    /// The external tag associated with the conversation.
    /// </summary>
    /// <value>The external tag associated with the conversation.</value>
    public string ExternalTag { get; set; }

    /// <summary>
    /// The time when the conversation started. This will be the time when the first participant joined the conversation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The time when the conversation started. This will be the time when the first participant joined the conversation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? StartTime { get; set; }

    /// <summary>
    /// The time when the conversation ended. This will be the time when the last participant left the conversation, or null when the conversation is still active. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The time when the conversation ended. This will be the time when the last participant left the conversation, or null when the conversation is still active. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? EndTime { get; set; }

    /// <summary>
    /// The address of the conversation as seen from an external participant. For phone calls this will be the DNIS for inbound calls and the ANI for outbound calls. For other media types this will be the address of the destination participant for inbound and the address of the initiating participant for outbound.
    /// </summary>
    /// <value>The address of the conversation as seen from an external participant. For phone calls this will be the DNIS for inbound calls and the ANI for outbound calls. For other media types this will be the address of the destination participant for inbound and the address of the initiating participant for outbound.</value>
    public string Address { get; set; }

    /// <summary>
    /// The list of all participants in the conversation.
    /// </summary>
    /// <value>The list of all participants in the conversation.</value>
    public IEnumerable<Participant> Participants { get; set; }

    /// <summary>
    /// A list of conversations to merge into this conversation to create a conference. This field is null except when being used to create a conference.
    /// </summary>
    /// <value>A list of conversations to merge into this conversation to create a conference. This field is null except when being used to create a conference.</value>
    public IEnumerable<string> ConversationIds { get; set; }

    /// <summary>
    /// If this is a conference conversation, then this field indicates the maximum number of participants allowed to participant in the conference.
    /// </summary>
    /// <value>If this is a conference conversation, then this field indicates the maximum number of participants allowed to participant in the conference.</value>
    public int? MaxParticipants { get; set; }

    /// <summary>
    /// Identifiers of divisions associated with this conversation
    /// </summary>
    /// <value>Identifiers of divisions associated with this conversation</value>
    public IEnumerable<ConversationDivisionMembership> Divisions { get; set; }

    /// <summary>
    /// The list of the most recent 20 transfer commands applied to this conversation.
    /// </summary>
    /// <value>The list of the most recent 20 transfer commands applied to this conversation.</value>
    public IEnumerable<TransferResponse> RecentTransfers { get; set; }

    /// <summary>
    /// True when the recording of this conversation is in secure pause status.
    /// </summary>
    /// <value>True when the recording of this conversation is in secure pause status.</value>
    public bool? SecurePause { get; set; }

    /// <summary>
    /// An optional label that categorizes the conversation.  Max-utilization settings can be configured at a per-label level
    /// </summary>
    /// <value>An optional label that categorizes the conversation.  Max-utilization settings can be configured at a per-label level</value>
    public string UtilizationLabelId { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
