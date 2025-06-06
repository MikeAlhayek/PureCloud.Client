using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// DashboardsSharedWith
/// </summary>

public partial class DashboardsSharedWith : IEquatable<DashboardsSharedWith>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DashboardsSharedWith" /> class.
    /// </summary>
    /// <param name="UserIds">The list of user ids to share the dashboard with.</param>
    /// <param name="TeamIds">The list of team ids to share the dashboard with.</param>
    public DashboardsSharedWith(List<string> UserIds = null, List<string> TeamIds = null)
    {
        this.UserIds = UserIds;
        this.TeamIds = TeamIds;

    }



    /// <summary>
    /// The list of user ids to share the dashboard with
    /// </summary>
    /// <value>The list of user ids to share the dashboard with</value>
    [JsonPropertyName("userIds")]
    public List<string> UserIds { get; set; }



    /// <summary>
    /// The list of team ids to share the dashboard with
    /// </summary>
    /// <value>The list of team ids to share the dashboard with</value>
    [JsonPropertyName("teamIds")]
    public List<string> TeamIds { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class DashboardsSharedWith {\n");

        sb.Append("  UserIds: ").Append(UserIds).Append("\n");
        sb.Append("  TeamIds: ").Append(TeamIds).Append("\n");
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
        return Equals(obj as DashboardsSharedWith);
    }

    /// <summary>
    /// Returns true if DashboardsSharedWith instances are equal
    /// </summary>
    /// <param name="other">Instance of DashboardsSharedWith to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DashboardsSharedWith other)
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
                TeamIds == other.TeamIds ||
                TeamIds != null &&
                TeamIds.SequenceEqual(other.TeamIds)
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

            if (TeamIds != null)
            {
                hash = hash * 59 + TeamIds.GetHashCode();
            }

            return hash;
        }
    }
}
