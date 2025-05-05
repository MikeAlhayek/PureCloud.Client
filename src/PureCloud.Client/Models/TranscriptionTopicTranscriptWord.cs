namespace PureCloud.Client.Models;

public sealed class TranscriptionTopicTranscriptWord
{
    /// <summary>
    /// Gets or Sets Confidence
    /// </summary>
    public double? Confidence { get; set; }

    /// <summary>
    /// Gets or Sets StartTimeMs
    /// </summary>
    public long? StartTimeMs { get; set; }

    /// <summary>
    /// Gets or Sets OffsetMs
    /// </summary>
    public long? OffsetMs { get; set; }

    /// <summary>
    /// Gets or Sets DurationMs
    /// </summary>
    public long? DurationMs { get; set; }

    /// <summary>
    /// Gets or Sets Word
    /// </summary>
    public string Word { get; set; }
}
