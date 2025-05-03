using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// GroupMembersUpdate
/// </summary>

public partial class GroupMembersUpdate : IEquatable<GroupMembersUpdate>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="GroupMembersUpdate" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected GroupMembersUpdate() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="GroupMembersUpdate" /> class.
    /// </summary>
    /// <param name="MemberIds">A list of the ids of the members to add. A maximum of 50 members are allowed per request. (required).</param>
    /// <param name="Version">The current group version. (required).</param>
    public GroupMembersUpdate(List<string> MemberIds = null, int? Version = null)
    {
        this.MemberIds = MemberIds;
        this.Version = Version;

    }



    /// <summary>
    /// A list of the ids of the members to add. A maximum of 50 members are allowed per request.
    /// </summary>
    /// <value>A list of the ids of the members to add. A maximum of 50 members are allowed per request.</value>
    [JsonPropertyName("memberIds")]
    public List<string> MemberIds { get; set; }



    /// <summary>
    /// The current group version.
    /// </summary>
    /// <value>The current group version.</value>
    [JsonPropertyName("version")]
    public int? Version { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class GroupMembersUpdate {\n");

        sb.Append("  MemberIds: ").Append(MemberIds).Append("\n");
        sb.Append("  Version: ").Append(Version).Append("\n");
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
        return Equals(obj as GroupMembersUpdate);
    }

    /// <summary>
    /// Returns true if GroupMembersUpdate instances are equal
    /// </summary>
    /// <param name="other">Instance of GroupMembersUpdate to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(GroupMembersUpdate other)
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
            ) &&
            (
                Version == other.Version ||
                Version != null &&
                Version.Equals(other.Version)
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

            if (Version != null)
            {
                hash = hash * 59 + Version.GetHashCode();
            }

            return hash;
        }
    }
}
