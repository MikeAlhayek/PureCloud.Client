namespace PureCloud.Client.Models;

public sealed class ConversationCallEventTopicCallConversation
{
    /// <summary>
    /// Gets or Sets RecordingState
    /// </summary>
    public ConversationCallEventTopicCallConversationRecordingState? RecordingState { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Participants
    /// </summary>
    public IEnumerable<ConversationCallEventTopicCallMediaParticipant> Participants { get; set; }

    /// <summary>
    /// Gets or Sets OtherMediaUris
    /// </summary>
    public IEnumerable<string> OtherMediaUris { get; set; }

    /// <summary>
    /// Gets or Sets Address
    /// </summary>
    public string Address { get; set; }

    /// <summary>
    /// Gets or Sets UtilizationLabelId
    /// </summary>
    public string UtilizationLabelId { get; set; }

    /// <summary>
    /// Gets or Sets Divisions
    /// </summary>
    public IEnumerable<ConversationCallEventTopicConversationDivisionMembership> Divisions { get; set; }

    /// <summary>
    /// Gets or Sets SecurePause
    /// </summary>
    public bool? SecurePause { get; set; }

    /// <summary>
    /// Gets or Sets MaxParticipants
    /// </summary>
    public long? MaxParticipants { get; set; }
}
