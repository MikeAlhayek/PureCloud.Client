using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// PatchJourney
/// </summary>

public partial class PatchJourney : IEquatable<PatchJourney>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PatchJourney" /> class.
    /// </summary>
    /// <param name="Patterns">A list of zero or more patterns to match..</param>
    public PatchJourney(List<PatchJourneyPattern> Patterns = null)
    {
        this.Patterns = Patterns;

    }



    /// <summary>
    /// A list of zero or more patterns to match.
    /// </summary>
    /// <value>A list of zero or more patterns to match.</value>
    [JsonPropertyName("patterns")]
    public List<PatchJourneyPattern> Patterns { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class PatchJourney {\n");

        sb.Append("  Patterns: ").Append(Patterns).Append("\n");
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
        return Equals(obj as PatchJourney);
    }

    /// <summary>
    /// Returns true if PatchJourney instances are equal
    /// </summary>
    /// <param name="other">Instance of PatchJourney to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(PatchJourney other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Patterns == other.Patterns ||
                Patterns != null &&
                Patterns.SequenceEqual(other.Patterns)
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
            if (Patterns != null)
            {
                hash = hash * 59 + Patterns.GetHashCode();
            }

            return hash;
        }
    }
}
