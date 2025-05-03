using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// TranscriptionTopicTranscriptAlternative
/// </summary>

public partial class TranscriptionTopicTranscriptAlternative : IEquatable<TranscriptionTopicTranscriptAlternative>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="TranscriptionTopicTranscriptAlternative" /> class.
    /// </summary>
    /// <param name="Confidence">Confidence.</param>
    /// <param name="OffsetMs">OffsetMs.</param>
    /// <param name="DurationMs">DurationMs.</param>
    /// <param name="Transcript">Transcript.</param>
    /// <param name="Words">Words.</param>
    /// <param name="DecoratedTranscript">DecoratedTranscript.</param>
    /// <param name="DecoratedWords">DecoratedWords.</param>
    public TranscriptionTopicTranscriptAlternative(double? Confidence = null, long? OffsetMs = null, long? DurationMs = null, string Transcript = null, List<TranscriptionTopicTranscriptWord> Words = null, string DecoratedTranscript = null, List<TranscriptionTopicTranscriptWord> DecoratedWords = null)
    {
        this.Confidence = Confidence;
        this.OffsetMs = OffsetMs;
        this.DurationMs = DurationMs;
        this.Transcript = Transcript;
        this.Words = Words;
        this.DecoratedTranscript = DecoratedTranscript;
        this.DecoratedWords = DecoratedWords;

    }



    /// <summary>
    /// Gets or Sets Confidence
    /// </summary>
    [JsonPropertyName("confidence")]
    public double? Confidence { get; set; }



    /// <summary>
    /// Gets or Sets OffsetMs
    /// </summary>
    [JsonPropertyName("offsetMs")]
    public long? OffsetMs { get; set; }



    /// <summary>
    /// Gets or Sets DurationMs
    /// </summary>
    [JsonPropertyName("durationMs")]
    public long? DurationMs { get; set; }



    /// <summary>
    /// Gets or Sets Transcript
    /// </summary>
    [JsonPropertyName("transcript")]
    public string Transcript { get; set; }



    /// <summary>
    /// Gets or Sets Words
    /// </summary>
    [JsonPropertyName("words")]
    public List<TranscriptionTopicTranscriptWord> Words { get; set; }



    /// <summary>
    /// Gets or Sets DecoratedTranscript
    /// </summary>
    [JsonPropertyName("decoratedTranscript")]
    public string DecoratedTranscript { get; set; }



    /// <summary>
    /// Gets or Sets DecoratedWords
    /// </summary>
    [JsonPropertyName("decoratedWords")]
    public List<TranscriptionTopicTranscriptWord> DecoratedWords { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class TranscriptionTopicTranscriptAlternative {\n");

        sb.Append("  Confidence: ").Append(Confidence).Append("\n");
        sb.Append("  OffsetMs: ").Append(OffsetMs).Append("\n");
        sb.Append("  DurationMs: ").Append(DurationMs).Append("\n");
        sb.Append("  Transcript: ").Append(Transcript).Append("\n");
        sb.Append("  Words: ").Append(Words).Append("\n");
        sb.Append("  DecoratedTranscript: ").Append(DecoratedTranscript).Append("\n");
        sb.Append("  DecoratedWords: ").Append(DecoratedWords).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }


    /// <summary>
    /// Returns true if objects are equal
    /// </summary>
    /// <param name="obj">Object to be compared</param>
    /// <returns>Boolean</returns>
    public override bool Equals(object obj)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        return Equals(obj as TranscriptionTopicTranscriptAlternative);
    }

    /// <summary>
    /// Returns true if TranscriptionTopicTranscriptAlternative instances are equal
    /// </summary>
    /// <param name="other">Instance of TranscriptionTopicTranscriptAlternative to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(TranscriptionTopicTranscriptAlternative other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Confidence == other.Confidence ||
                Confidence != null &&
                Confidence.Equals(other.Confidence)
            ) &&
            (
                OffsetMs == other.OffsetMs ||
                OffsetMs != null &&
                OffsetMs.Equals(other.OffsetMs)
            ) &&
            (
                DurationMs == other.DurationMs ||
                DurationMs != null &&
                DurationMs.Equals(other.DurationMs)
            ) &&
            (
                Transcript == other.Transcript ||
                Transcript != null &&
                Transcript.Equals(other.Transcript)
            ) &&
            (
                Words == other.Words ||
                Words != null &&
                Words.SequenceEqual(other.Words)
            ) &&
            (
                DecoratedTranscript == other.DecoratedTranscript ||
                DecoratedTranscript != null &&
                DecoratedTranscript.Equals(other.DecoratedTranscript)
            ) &&
            (
                DecoratedWords == other.DecoratedWords ||
                DecoratedWords != null &&
                DecoratedWords.SequenceEqual(other.DecoratedWords)
            );
    }

    /// <summary>
    /// Gets the hash code
    /// </summary>
    /// <returns>Hash code</returns>
    public override int GetHashCode()
    {
        // credit: http://stackoverflow.com/a/263416/677735
        unchecked // Overflow is fine, just wrap
        {
            int hash = 41;
            // Suitable nullity checks etc, of course :)
            if (Confidence != null)
            {
                hash = hash * 59 + Confidence.GetHashCode();
            }

            if (OffsetMs != null)
            {
                hash = hash * 59 + OffsetMs.GetHashCode();
            }

            if (DurationMs != null)
            {
                hash = hash * 59 + DurationMs.GetHashCode();
            }

            if (Transcript != null)
            {
                hash = hash * 59 + Transcript.GetHashCode();
            }

            if (Words != null)
            {
                hash = hash * 59 + Words.GetHashCode();
            }

            if (DecoratedTranscript != null)
            {
                hash = hash * 59 + DecoratedTranscript.GetHashCode();
            }

            if (DecoratedWords != null)
            {
                hash = hash * 59 + DecoratedWords.GetHashCode();
            }

            return hash;
        }
    }
}
