using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// TrustRequestCreate
/// </summary>

public partial class TrustRequestCreate : IEquatable<TrustRequestCreate>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="TrustRequestCreate" /> class.
    /// </summary>
    /// <param name="UserIds">The list of trustee users that are requesting access. If no users are specified, at least one group is required..</param>
    /// <param name="GroupIds">The list of trustee groups that are requesting access. If no groups are specified, at least one user is required..</param>
    public TrustRequestCreate(List<string> UserIds = null, List<string> GroupIds = null)
    {
        this.UserIds = UserIds;
        this.GroupIds = GroupIds;

    }



    /// <summary>
    /// The list of trustee users that are requesting access. If no users are specified, at least one group is required.
    /// </summary>
    /// <value>The list of trustee users that are requesting access. If no users are specified, at least one group is required.</value>
    [JsonPropertyName("userIds")]
    public List<string> UserIds { get; set; }



    /// <summary>
    /// The list of trustee groups that are requesting access. If no groups are specified, at least one user is required.
    /// </summary>
    /// <value>The list of trustee groups that are requesting access. If no groups are specified, at least one user is required.</value>
    [JsonPropertyName("groupIds")]
    public List<string> GroupIds { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class TrustRequestCreate {\n");

        sb.Append("  UserIds: ").Append(UserIds).Append("\n");
        sb.Append("  GroupIds: ").Append(GroupIds).Append("\n");
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
        return Equals(obj as TrustRequestCreate);
    }

    /// <summary>
    /// Returns true if TrustRequestCreate instances are equal
    /// </summary>
    /// <param name="other">Instance of TrustRequestCreate to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(TrustRequestCreate other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                UserIds == other.UserIds ||
                UserIds != null &&
                UserIds.SequenceEqual(other.UserIds)
            ) &&
            (
                GroupIds == other.GroupIds ||
                GroupIds != null &&
                GroupIds.SequenceEqual(other.GroupIds)
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
            if (UserIds != null)
            {
                hash = hash * 59 + UserIds.GetHashCode();
            }

            if (GroupIds != null)
            {
                hash = hash * 59 + GroupIds.GetHashCode();
            }

            return hash;
        }
    }
}
