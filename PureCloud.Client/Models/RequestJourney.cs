using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// RequestJourney
/// </summary>
[DataContract]
public partial class RequestJourney : IEquatable<RequestJourney>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="RequestJourney" /> class.
    /// </summary>
    /// <param name="Patterns">A list of zero or more patterns to match..</param>
    public RequestJourney(List<RequestJourneyPattern> Patterns = null)
    {
        this.Patterns = Patterns;

    }



    /// <summary>
    /// A list of zero or more patterns to match.
    /// </summary>
    /// <value>A list of zero or more patterns to match.</value>
    [DataMember(Name = "patterns", EmitDefaultValue = false)]
    public List<RequestJourneyPattern> Patterns { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class RequestJourney {\n");

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
        return Equals(obj as RequestJourney);
    }

    /// <summary>
    /// Returns true if RequestJourney instances are equal
    /// </summary>
    /// <param name="other">Instance of RequestJourney to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(RequestJourney other)
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
