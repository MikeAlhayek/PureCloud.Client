using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// User information for a Line account
/// </summary>

public partial class LineId : IEquatable<LineId>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="LineId" /> class.
    /// </summary>
    /// <param name="Ids">The set of Line userIds that this person has. Each userId is specific to the Line channel that the user interacts with..</param>
    /// <param name="DisplayName">The displayName of this person&#39;s account in Line.</param>
    public LineId(List<LineUserId> Ids = null, string DisplayName = null)
    {
        this.Ids = Ids;
        this.DisplayName = DisplayName;

    }



    /// <summary>
    /// The set of Line userIds that this person has. Each userId is specific to the Line channel that the user interacts with.
    /// </summary>
    /// <value>The set of Line userIds that this person has. Each userId is specific to the Line channel that the user interacts with.</value>
    [JsonPropertyName("ids")]
    public List<LineUserId> Ids { get; set; }



    /// <summary>
    /// The displayName of this person&#39;s account in Line
    /// </summary>
    /// <value>The displayName of this person&#39;s account in Line</value>
    [JsonPropertyName("displayName")]
    public string DisplayName { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class LineId {\n");

        sb.Append("  Ids: ").Append(Ids).Append("\n");
        sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
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
        return Equals(obj as LineId);
    }

    /// <summary>
    /// Returns true if LineId instances are equal
    /// </summary>
    /// <param name="other">Instance of LineId to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(LineId other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Ids == other.Ids ||
                Ids != null &&
                Ids.SequenceEqual(other.Ids)
            ) &&
            (
                DisplayName == other.DisplayName ||
                DisplayName != null &&
                DisplayName.Equals(other.DisplayName)
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
            if (Ids != null)
            {
                hash = hash * 59 + Ids.GetHashCode();
            }

            if (DisplayName != null)
            {
                hash = hash * 59 + DisplayName.GetHashCode();
            }

            return hash;
        }
    }
}
