using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Adjacents
/// </summary>

public partial class Adjacents : IEquatable<Adjacents>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Adjacents" /> class.
    /// </summary>
    /// <param name="Superiors">Superiors.</param>
    /// <param name="Siblings">Siblings.</param>
    /// <param name="DirectReports">DirectReports.</param>
    public Adjacents(List<User> Superiors = null, List<User> Siblings = null, List<User> DirectReports = null)
    {
        this.Superiors = Superiors;
        this.Siblings = Siblings;
        this.DirectReports = DirectReports;

    }



    /// <summary>
    /// Gets or Sets Superiors
    /// </summary>
    [JsonPropertyName("superiors")]
    public List<User> Superiors { get; set; }



    /// <summary>
    /// Gets or Sets Siblings
    /// </summary>
    [JsonPropertyName("siblings")]
    public List<User> Siblings { get; set; }



    /// <summary>
    /// Gets or Sets DirectReports
    /// </summary>
    [JsonPropertyName("directReports")]
    public List<User> DirectReports { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class Adjacents {\n");

        sb.Append("  Superiors: ").Append(Superiors).Append("\n");
        sb.Append("  Siblings: ").Append(Siblings).Append("\n");
        sb.Append("  DirectReports: ").Append(DirectReports).Append("\n");
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
        return Equals(obj as Adjacents);
    }

    /// <summary>
    /// Returns true if Adjacents instances are equal
    /// </summary>
    /// <param name="other">Instance of Adjacents to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Adjacents other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Superiors == other.Superiors ||
                Superiors != null &&
                Superiors.SequenceEqual(other.Superiors)
            ) &&
            (
                Siblings == other.Siblings ||
                Siblings != null &&
                Siblings.SequenceEqual(other.Siblings)
            ) &&
            (
                DirectReports == other.DirectReports ||
                DirectReports != null &&
                DirectReports.SequenceEqual(other.DirectReports)
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
            if (Superiors != null)
            {
                hash = hash * 59 + Superiors.GetHashCode();
            }

            if (Siblings != null)
            {
                hash = hash * 59 + Siblings.GetHashCode();
            }

            if (DirectReports != null)
            {
                hash = hash * 59 + DirectReports.GetHashCode();
            }

            return hash;
        }
    }
}
