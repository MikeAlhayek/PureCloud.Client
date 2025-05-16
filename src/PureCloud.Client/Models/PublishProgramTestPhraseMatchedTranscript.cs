using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class PublishProgramTestPhraseMatchedTranscript
{
    /// <summary>
    /// Gets or Sets MediaType
    /// </summary>
    public PublishProgramTestPhraseMatchedTranscriptMediaTypeEnum? MediaType { get; set; }

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
    /// </summary>
    public string CommunicationId { get; set; }

    /// <summary>
    /// Gets or Sets ConversationId
    /// </summary>
    public string ConversationId { get; set; }

    /// <summary>
    /// Gets or Sets DetectedPhrases
    /// </summary>
    public IEnumerable<PublishProgramTestPhraseDetectedPhrase> DetectedPhrases { get; set; }
}
