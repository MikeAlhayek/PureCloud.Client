using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// CreateGeneralProgramTestTopicPhraseResults
/// </summary>
[DataContract]
public partial class CreateGeneralProgramTestTopicPhraseResults : IEquatable<CreateGeneralProgramTestTopicPhraseResults>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CreateGeneralProgramTestTopicPhraseResults" /> class.
    /// </summary>
    /// <param name="ProcessedTranscriptsCount">ProcessedTranscriptsCount.</param>
    /// <param name="MatchedTranscriptsCount">MatchedTranscriptsCount.</param>
    /// <param name="MatchedTranscripts">MatchedTranscripts.</param>
    public CreateGeneralProgramTestTopicPhraseResults(long? ProcessedTranscriptsCount = null, long? MatchedTranscriptsCount = null, List<CreateGeneralProgramTestPhraseMatchedTranscript> MatchedTranscripts = null)
    {
        this.ProcessedTranscriptsCount = ProcessedTranscriptsCount;
        this.MatchedTranscriptsCount = MatchedTranscriptsCount;
        this.MatchedTranscripts = MatchedTranscripts;

    }



    /// <summary>
    /// Gets or Sets ProcessedTranscriptsCount
    /// </summary>
    [DataMember(Name = "processedTranscriptsCount", EmitDefaultValue = false)]
    public long? ProcessedTranscriptsCount { get; set; }



    /// <summary>
    /// Gets or Sets MatchedTranscriptsCount
    /// </summary>
    [DataMember(Name = "matchedTranscriptsCount", EmitDefaultValue = false)]
    public long? MatchedTranscriptsCount { get; set; }



    /// <summary>
    /// Gets or Sets MatchedTranscripts
    /// </summary>
    [DataMember(Name = "matchedTranscripts", EmitDefaultValue = false)]
    public List<CreateGeneralProgramTestPhraseMatchedTranscript> MatchedTranscripts { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CreateGeneralProgramTestTopicPhraseResults {\n");

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
        return Equals(obj as CreateGeneralProgramTestTopicPhraseResults);
    }

    /// <summary>
    /// Returns true if CreateGeneralProgramTestTopicPhraseResults instances are equal
    /// </summary>
    /// <param name="other">Instance of CreateGeneralProgramTestTopicPhraseResults to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CreateGeneralProgramTestTopicPhraseResults other)
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
