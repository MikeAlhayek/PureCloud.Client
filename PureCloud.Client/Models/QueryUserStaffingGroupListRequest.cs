using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// QueryUserStaffingGroupListRequest
/// </summary>
[DataContract]
public partial class QueryUserStaffingGroupListRequest : IEquatable<QueryUserStaffingGroupListRequest>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="QueryUserStaffingGroupListRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected QueryUserStaffingGroupListRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="QueryUserStaffingGroupListRequest" /> class.
    /// </summary>
    /// <param name="UserIds">The set of user IDs to fetch associated staffing groups (required).</param>
    public QueryUserStaffingGroupListRequest(List<string> UserIds = null)
    {
        this.UserIds = UserIds;

    }



    /// <summary>
    /// The set of user IDs to fetch associated staffing groups
    /// </summary>
    /// <value>The set of user IDs to fetch associated staffing groups</value>
    [DataMember(Name = "userIds", EmitDefaultValue = false)]
    public List<string> UserIds { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class QueryUserStaffingGroupListRequest {\n");

        sb.Append("  UserIds: ").Append(UserIds).Append("\n");
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
        return Equals(obj as QueryUserStaffingGroupListRequest);
    }

    /// <summary>
    /// Returns true if QueryUserStaffingGroupListRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of QueryUserStaffingGroupListRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(QueryUserStaffingGroupListRequest other)
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

            return hash;
        }
    }
}
