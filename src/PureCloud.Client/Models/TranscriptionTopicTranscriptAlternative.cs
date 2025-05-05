namespace PureCloud.Client.Models;

public sealed class TranscriptionTopicTranscriptAlternative
{
    /// <summary>
    /// Gets or Sets Confidence
    /// </summary>
    public double? Confidence { get; set; }

    /// <summary>
    /// Gets or Sets OffsetMs
    /// </summary>
    public long? OffsetMs { get; set; }

    /// <summary>
    /// Gets or Sets DurationMs
    /// </summary>
    public long? DurationMs { get; set; }

    /// <summary>
    /// Gets or Sets Transcript
    /// </summary>
    public string Transcript { get; set; }

    /// <summary>
    /// Gets or Sets Words
    /// </summary>
    public IEnumerable<TranscriptionTopicTranscriptWord> Words { get; set; }

    /// <summary>
    /// Gets or Sets DecoratedTranscript
    /// </summary>
    public string DecoratedTranscript { get; set; }

    /// <summary>
    /// Gets or Sets DecoratedWords
    /// </summary>
    public List<TranscriptionTopicTranscriptWord> DecoratedWords { get; set; }
}
