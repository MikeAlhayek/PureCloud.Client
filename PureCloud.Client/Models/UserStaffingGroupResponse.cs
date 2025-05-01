using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// UserStaffingGroupResponse
/// </summary>
[DataContract]
public partial class UserStaffingGroupResponse : IEquatable<UserStaffingGroupResponse>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="UserStaffingGroupResponse" /> class.
    /// </summary>
    /// <param name="User">The user associated with the staffing group.</param>
    /// <param name="StaffingGroup">The staffing group.</param>
    public UserStaffingGroupResponse(UserReference User = null, StaffingGroupReference StaffingGroup = null)
    {
        this.User = User;
        this.StaffingGroup = StaffingGroup;

    }



    /// <summary>
    /// The user associated with the staffing group
    /// </summary>
    /// <value>The user associated with the staffing group</value>
    [DataMember(Name = "user", EmitDefaultValue = false)]
    public UserReference User { get; set; }



    /// <summary>
    /// The staffing group
    /// </summary>
    /// <value>The staffing group</value>
    [DataMember(Name = "staffingGroup", EmitDefaultValue = false)]
    public StaffingGroupReference StaffingGroup { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class UserStaffingGroupResponse {\n");

        sb.Append("  User: ").Append(User).Append("\n");
        sb.Append("  StaffingGroup: ").Append(StaffingGroup).Append("\n");
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
        return Equals(obj as UserStaffingGroupResponse);
    }

    /// <summary>
    /// Returns true if UserStaffingGroupResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of UserStaffingGroupResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(UserStaffingGroupResponse other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                User == other.User ||
                User != null &&
                User.Equals(other.User)
            ) &&
            (
                StaffingGroup == other.StaffingGroup ||
                StaffingGroup != null &&
                StaffingGroup.Equals(other.StaffingGroup)
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
            if (User != null)
            {
                hash = hash * 59 + User.GetHashCode();
            }

            if (StaffingGroup != null)
            {
                hash = hash * 59 + StaffingGroup.GetHashCode();
            }

            return hash;
        }
    }
}
