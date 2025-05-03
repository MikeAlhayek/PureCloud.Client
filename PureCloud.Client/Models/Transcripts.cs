using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Transcripts
/// </summary>

public partial class Transcripts : IEquatable<Transcripts>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Transcripts" /> class.
    /// </summary>
    /// <param name="ExactMatch">List of transcript contents which needs to satisfy exact match criteria.</param>
    /// <param name="Contains">List of transcript contents which needs to satisfy contains criteria.</param>
    /// <param name="DoesNotContain">List of transcript contents which needs to satisfy does not contain criteria.</param>
    public Transcripts(List<string> ExactMatch = null, List<string> Contains = null, List<string> DoesNotContain = null)
    {
        this.ExactMatch = ExactMatch;
        this.Contains = Contains;
        this.DoesNotContain = DoesNotContain;

    }



    /// <summary>
    /// List of transcript contents which needs to satisfy exact match criteria
    /// </summary>
    /// <value>List of transcript contents which needs to satisfy exact match criteria</value>
    [JsonPropertyName("exactMatch")]
    public List<string> ExactMatch { get; set; }



    /// <summary>
    /// List of transcript contents which needs to satisfy contains criteria
    /// </summary>
    /// <value>List of transcript contents which needs to satisfy contains criteria</value>
    [JsonPropertyName("contains")]
    public List<string> Contains { get; set; }



    /// <summary>
    /// List of transcript contents which needs to satisfy does not contain criteria
    /// </summary>
    /// <value>List of transcript contents which needs to satisfy does not contain criteria</value>
    [JsonPropertyName("doesNotContain")]
    public List<string> DoesNotContain { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class Transcripts {\n");

        sb.Append("  ExactMatch: ").Append(ExactMatch).Append("\n");
        sb.Append("  Contains: ").Append(Contains).Append("\n");
        sb.Append("  DoesNotContain: ").Append(DoesNotContain).Append("\n");
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
        return Equals(obj as Transcripts);
    }

    /// <summary>
    /// Returns true if Transcripts instances are equal
    /// </summary>
    /// <param name="other">Instance of Transcripts to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Transcripts other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                ExactMatch == other.ExactMatch ||
                ExactMatch != null &&
                ExactMatch.SequenceEqual(other.ExactMatch)
            ) &&
            (
                Contains == other.Contains ||
                Contains != null &&
                Contains.SequenceEqual(other.Contains)
            ) &&
            (
                DoesNotContain == other.DoesNotContain ||
                DoesNotContain != null &&
                DoesNotContain.SequenceEqual(other.DoesNotContain)
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
            if (ExactMatch != null)
            {
                hash = hash * 59 + ExactMatch.GetHashCode();
            }

            if (Contains != null)
            {
                hash = hash * 59 + Contains.GetHashCode();
            }

            if (DoesNotContain != null)
            {
                hash = hash * 59 + DoesNotContain.GetHashCode();
            }

            return hash;
        }
    }
}
