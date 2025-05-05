using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// TeamMembers
/// </summary>

public partial class TeamMembers : IEquatable<TeamMembers>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="TeamMembers" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected TeamMembers() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="TeamMembers" /> class.
    /// </summary>
    /// <param name="MemberIds">A list of the ids of the members to add or remove (required).</param>
    public TeamMembers(List<string> MemberIds = null)
    {
        this.MemberIds = MemberIds;

    }



    /// <summary>
    /// A list of the ids of the members to add or remove
    /// </summary>
    /// <value>A list of the ids of the members to add or remove</value>
    [JsonPropertyName("memberIds")]
    public List<string> MemberIds { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class TeamMembers {\n");

        sb.Append("  MemberIds: ").Append(MemberIds).Append("\n");
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
        return Equals(obj as TeamMembers);
    }

    /// <summary>
    /// Returns true if TeamMembers instances are equal
    /// </summary>
    /// <param name="other">Instance of TeamMembers to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(TeamMembers other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                MemberIds == other.MemberIds ||
                MemberIds != null &&
                MemberIds.SequenceEqual(other.MemberIds)
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
            if (MemberIds != null)
            {
                hash = hash * 59 + MemberIds.GetHashCode();
            }

            return hash;
        }
    }
}
