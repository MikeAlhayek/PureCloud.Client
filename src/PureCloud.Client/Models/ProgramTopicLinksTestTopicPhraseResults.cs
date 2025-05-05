using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ProgramTopicLinksTestTopicPhraseResults
/// </summary>

public partial class ProgramTopicLinksTestTopicPhraseResults : IEquatable<ProgramTopicLinksTestTopicPhraseResults>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ProgramTopicLinksTestTopicPhraseResults" /> class.
    /// </summary>
    /// <param name="ProcessedTranscriptsCount">ProcessedTranscriptsCount.</param>
    /// <param name="MatchedTranscriptsCount">MatchedTranscriptsCount.</param>
    /// <param name="MatchedTranscripts">MatchedTranscripts.</param>
    public ProgramTopicLinksTestTopicPhraseResults(long? ProcessedTranscriptsCount = null, long? MatchedTranscriptsCount = null, List<ProgramTopicLinksTestPhraseMatchedTranscript> MatchedTranscripts = null)
    {
        this.ProcessedTranscriptsCount = ProcessedTranscriptsCount;
        this.MatchedTranscriptsCount = MatchedTranscriptsCount;
        this.MatchedTranscripts = MatchedTranscripts;

    }



    /// <summary>
    /// Gets or Sets ProcessedTranscriptsCount
    /// </summary>
    [JsonPropertyName("processedTranscriptsCount")]
    public long? ProcessedTranscriptsCount { get; set; }



    /// <summary>
    /// Gets or Sets MatchedTranscriptsCount
    /// </summary>
    [JsonPropertyName("matchedTranscriptsCount")]
    public long? MatchedTranscriptsCount { get; set; }



    /// <summary>
    /// Gets or Sets MatchedTranscripts
    /// </summary>
    [JsonPropertyName("matchedTranscripts")]
    public List<ProgramTopicLinksTestPhraseMatchedTranscript> MatchedTranscripts { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ProgramTopicLinksTestTopicPhraseResults {\n");

        sb.Append("  ProcessedTranscriptsCount: ").Append(ProcessedTranscriptsCount).Append("\n");
        sb.Append("  MatchedTranscriptsCount: ").Append(MatchedTranscriptsCount).Append("\n");
        sb.Append("  MatchedTranscripts: ").Append(MatchedTranscripts).Append("\n");
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
        return Equals(obj as ProgramTopicLinksTestTopicPhraseResults);
    }

    /// <summary>
    /// Returns true if ProgramTopicLinksTestTopicPhraseResults instances are equal
    /// </summary>
    /// <param name="other">Instance of ProgramTopicLinksTestTopicPhraseResults to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ProgramTopicLinksTestTopicPhraseResults other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                ProcessedTranscriptsCount == other.ProcessedTranscriptsCount ||
                ProcessedTranscriptsCount != null &&
                ProcessedTranscriptsCount.Equals(other.ProcessedTranscriptsCount)
            ) &&
            (
                MatchedTranscriptsCount == other.MatchedTranscriptsCount ||
                MatchedTranscriptsCount != null &&
                MatchedTranscriptsCount.Equals(other.MatchedTranscriptsCount)
            ) &&
            (
                MatchedTranscripts == other.MatchedTranscripts ||
                MatchedTranscripts != null &&
                MatchedTranscripts.SequenceEqual(other.MatchedTranscripts)
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
            if (ProcessedTranscriptsCount != null)
            {
                hash = hash * 59 + ProcessedTranscriptsCount.GetHashCode();
            }

            if (MatchedTranscriptsCount != null)
            {
                hash = hash * 59 + MatchedTranscriptsCount.GetHashCode();
            }

            if (MatchedTranscripts != null)
            {
                hash = hash * 59 + MatchedTranscripts.GetHashCode();
            }

            return hash;
        }
    }
}
