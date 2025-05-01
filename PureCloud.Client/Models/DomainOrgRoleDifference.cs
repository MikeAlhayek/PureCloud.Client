using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// DomainOrgRoleDifference
/// </summary>
[DataContract]
public partial class DomainOrgRoleDifference : IEquatable<DomainOrgRoleDifference>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DomainOrgRoleDifference" /> class.
    /// </summary>
    /// <param name="RemovedPermissionPolicies">RemovedPermissionPolicies.</param>
    /// <param name="AddedPermissionPolicies">AddedPermissionPolicies.</param>
    /// <param name="SamePermissionPolicies">SamePermissionPolicies.</param>
    /// <param name="UserOrgRole">UserOrgRole.</param>
    /// <param name="RoleFromDefault">RoleFromDefault.</param>
    public DomainOrgRoleDifference(List<DomainPermissionPolicy> RemovedPermissionPolicies = null, List<DomainPermissionPolicy> AddedPermissionPolicies = null, List<DomainPermissionPolicy> SamePermissionPolicies = null, DomainOrganizationRole UserOrgRole = null, DomainOrganizationRole RoleFromDefault = null)
    {
        this.RemovedPermissionPolicies = RemovedPermissionPolicies;
        this.AddedPermissionPolicies = AddedPermissionPolicies;
        this.SamePermissionPolicies = SamePermissionPolicies;
        this.UserOrgRole = UserOrgRole;
        this.RoleFromDefault = RoleFromDefault;

    }



    /// <summary>
    /// Gets or Sets RemovedPermissionPolicies
    /// </summary>
    [DataMember(Name = "removedPermissionPolicies", EmitDefaultValue = false)]
    public List<DomainPermissionPolicy> RemovedPermissionPolicies { get; set; }



    /// <summary>
    /// Gets or Sets AddedPermissionPolicies
    /// </summary>
    [DataMember(Name = "addedPermissionPolicies", EmitDefaultValue = false)]
    public List<DomainPermissionPolicy> AddedPermissionPolicies { get; set; }



    /// <summary>
    /// Gets or Sets SamePermissionPolicies
    /// </summary>
    [DataMember(Name = "samePermissionPolicies", EmitDefaultValue = false)]
    public List<DomainPermissionPolicy> SamePermissionPolicies { get; set; }



    /// <summary>
    /// Gets or Sets UserOrgRole
    /// </summary>
    [DataMember(Name = "userOrgRole", EmitDefaultValue = false)]
    public DomainOrganizationRole UserOrgRole { get; set; }



    /// <summary>
    /// Gets or Sets RoleFromDefault
    /// </summary>
    [DataMember(Name = "roleFromDefault", EmitDefaultValue = false)]
    public DomainOrganizationRole RoleFromDefault { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class DomainOrgRoleDifference {\n");

        sb.Append("  RemovedPermissionPolicies: ").Append(RemovedPermissionPolicies).Append("\n");
        sb.Append("  AddedPermissionPolicies: ").Append(AddedPermissionPolicies).Append("\n");
        sb.Append("  SamePermissionPolicies: ").Append(SamePermissionPolicies).Append("\n");
        sb.Append("  UserOrgRole: ").Append(UserOrgRole).Append("\n");
        sb.Append("  RoleFromDefault: ").Append(RoleFromDefault).Append("\n");
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
        return Equals(obj as DomainOrgRoleDifference);
    }

    /// <summary>
    /// Returns true if DomainOrgRoleDifference instances are equal
    /// </summary>
    /// <param name="other">Instance of DomainOrgRoleDifference to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DomainOrgRoleDifference other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                RemovedPermissionPolicies == other.RemovedPermissionPolicies ||
                RemovedPermissionPolicies != null &&
                RemovedPermissionPolicies.SequenceEqual(other.RemovedPermissionPolicies)
            ) &&
            (
                AddedPermissionPolicies == other.AddedPermissionPolicies ||
                AddedPermissionPolicies != null &&
                AddedPermissionPolicies.SequenceEqual(other.AddedPermissionPolicies)
            ) &&
            (
                SamePermissionPolicies == other.SamePermissionPolicies ||
                SamePermissionPolicies != null &&
                SamePermissionPolicies.SequenceEqual(other.SamePermissionPolicies)
            ) &&
            (
                UserOrgRole == other.UserOrgRole ||
                UserOrgRole != null &&
                UserOrgRole.Equals(other.UserOrgRole)
            ) &&
            (
                RoleFromDefault == other.RoleFromDefault ||
                RoleFromDefault != null &&
                RoleFromDefault.Equals(other.RoleFromDefault)
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
            if (RemovedPermissionPolicies != null)
            {
                hash = hash * 59 + RemovedPermissionPolicies.GetHashCode();
            }

            if (AddedPermissionPolicies != null)
            {
                hash = hash * 59 + AddedPermissionPolicies.GetHashCode();
            }

            if (SamePermissionPolicies != null)
            {
                hash = hash * 59 + SamePermissionPolicies.GetHashCode();
            }

            if (UserOrgRole != null)
            {
                hash = hash * 59 + UserOrgRole.GetHashCode();
            }

            if (RoleFromDefault != null)
            {
                hash = hash * 59 + RoleFromDefault.GetHashCode();
            }

            return hash;
        }
    }
}
