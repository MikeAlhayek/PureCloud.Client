using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ProgramTopicLinksTestPhraseMatchedTranscript
{
    /// <summary>
    /// Gets or Sets MediaType
    /// </summary>
    public ProgramTopicLinksTestPhraseMatchedTranscriptMediaTypeEnum? MediaType { get; set; }

    /// <summary>
    /// Gets or Sets Timestamp
    /// </summary>
    public long? Timestamp { get; set; }

    /// <summary>
    /// Gets or Sets TranscriptId
    /// </summary>
    public string TranscriptId { get; set; }

    /// <summary>
    /// Gets or Sets CommunicationId
    public string CommunicationId { get; set; }

    /// <summary>
    /// Gets or Sets ConversationId
    /// </summary>
    public string ConversationId { get; set; }

    /// <summary>
    /// Gets or Sets DetectedPhrases
    /// </summary>
    public IEnumerable<ProgramTopicLinksTestPhraseDetectedPhrase> DetectedPhrases { get; set; }
}
