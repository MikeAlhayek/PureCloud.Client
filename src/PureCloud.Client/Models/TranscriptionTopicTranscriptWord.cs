using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// TranscriptionTopicTranscriptWord
/// </summary>

public partial class TranscriptionTopicTranscriptWord : IEquatable<TranscriptionTopicTranscriptWord>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="TranscriptionTopicTranscriptWord" /> class.
    /// </summary>
    /// <param name="Confidence">Confidence.</param>
    /// <param name="StartTimeMs">StartTimeMs.</param>
    /// <param name="OffsetMs">OffsetMs.</param>
    /// <param name="DurationMs">DurationMs.</param>
    /// <param name="Word">Word.</param>
    public TranscriptionTopicTranscriptWord(double? Confidence = null, long? StartTimeMs = null, long? OffsetMs = null, long? DurationMs = null, string Word = null)
    {
        this.Confidence = Confidence;
        this.StartTimeMs = StartTimeMs;
        this.OffsetMs = OffsetMs;
        this.DurationMs = DurationMs;
        this.Word = Word;

    }



    /// <summary>
    /// Gets or Sets Confidence
    /// </summary>
    [JsonPropertyName("confidence")]
    public double? Confidence { get; set; }



    /// <summary>
    /// Gets or Sets StartTimeMs
    /// </summary>
    [JsonPropertyName("startTimeMs")]
    public long? StartTimeMs { get; set; }



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
    /// Gets or Sets Word
    /// </summary>
    [JsonPropertyName("word")]
    public string Word { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class TranscriptionTopicTranscriptWord {\n");

        sb.Append("  Confidence: ").Append(Confidence).Append("\n");
        sb.Append("  StartTimeMs: ").Append(StartTimeMs).Append("\n");
        sb.Append("  OffsetMs: ").Append(OffsetMs).Append("\n");
        sb.Append("  DurationMs: ").Append(DurationMs).Append("\n");
        sb.Append("  Word: ").Append(Word).Append("\n");
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
        return Equals(obj as TranscriptionTopicTranscriptWord);
    }

    /// <summary>
    /// Returns true if TranscriptionTopicTranscriptWord instances are equal
    /// </summary>
    /// <param name="other">Instance of TranscriptionTopicTranscriptWord to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(TranscriptionTopicTranscriptWord other)
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
                StartTimeMs == other.StartTimeMs ||
                StartTimeMs != null &&
                StartTimeMs.Equals(other.StartTimeMs)
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
                Word == other.Word ||
                Word != null &&
                Word.Equals(other.Word)
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

            if (StartTimeMs != null)
            {
                hash = hash * 59 + StartTimeMs.GetHashCode();
            }

            if (OffsetMs != null)
            {
                hash = hash * 59 + OffsetMs.GetHashCode();
            }

            if (DurationMs != null)
            {
                hash = hash * 59 + DurationMs.GetHashCode();
            }

            if (Word != null)
            {
                hash = hash * 59 + Word.GetHashCode();
            }

            return hash;
        }
    }
}
