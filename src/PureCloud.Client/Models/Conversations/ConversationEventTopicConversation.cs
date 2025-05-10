namespace PureCloud.Client.Models.Conversations;

public sealed class ConversationEventTopicConversation
{
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets MaxParticipants
    /// </summary>
    public long? MaxParticipants { get; set; }

    /// <summary>
    /// Gets or Sets Participants
    /// </summary>
    public IEnumerable<ConversationEventTopicParticipant> Participants { get; set; }

    /// <summary>
    /// Gets or Sets RecentTransfers
    /// </summary>
    public IEnumerable<ConversationEventTopicTransferResponse> RecentTransfers { get; set; }

    /// <summary>
    /// Gets or Sets RecordingState
    /// </summary>
    public string RecordingState { get; set; }

    /// <summary>
    /// Gets or Sets Address
    /// </summary>
    public string Address { get; set; }

    /// <summary>
    /// Gets or Sets ExternalTag
    /// </summary>
    public string ExternalTag { get; set; }

    /// <summary>
    /// Gets or Sets UtilizationLabelId
    /// </summary>
    public string UtilizationLabelId { get; set; }

    /// <summary>
    /// Gets or Sets SecurePause
    /// </summary>
    public bool? SecurePause { get; set; }

    /// <summary>
    /// Gets or Sets Divisions
    /// </summary>
    public IEnumerable<ConversationEventTopicConversationDivisionMembership> Divisions { get; set; }
}
