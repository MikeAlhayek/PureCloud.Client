namespace PureCloud.Client.Models;

public sealed class TranscriptionTopicTranscriptionMessage
{
    /// <summary>
    /// Gets or Sets EventTime
    /// </summary>
    public DateTime? EventTime { get; set; }

    /// <summary>
    /// Gets or Sets OrganizationId
    /// </summary>
    public string OrganizationId { get; set; }

    /// <summary>
    /// Gets or Sets ConversationId
    /// </summary>
    public string ConversationId { get; set; }

    /// <summary>
    /// Gets or Sets CommunicationId
    /// </summary>
    public string CommunicationId { get; set; }

    /// <summary>
    /// Gets or Sets SessionStartTimeMs
    /// </summary>
    public long? SessionStartTimeMs { get; set; }

    /// <summary>
    /// Gets or Sets TranscriptionStartTimeMs
    /// </summary>
    public long? TranscriptionStartTimeMs { get; set; }

    /// <summary>
    /// Gets or Sets Transcripts
    /// </summary>
    public IEnumerable<TranscriptionTopicTranscriptResult> Transcripts { get; set; }

    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    public TranscriptionTopicTranscriptionRequestStatus Status { get; set; }
}
