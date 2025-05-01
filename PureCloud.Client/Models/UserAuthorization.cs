using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// UserAuthorization
/// </summary>
[DataContract]
public partial class UserAuthorization : IEquatable<UserAuthorization>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="UserAuthorization" /> class.
    /// </summary>
    /// <param name="Roles">Roles.</param>
    public UserAuthorization(List<DomainRole> Roles = null)
    {
        this.Roles = Roles;

    }



    /// <summary>
    /// Gets or Sets Roles
    /// </summary>
    [DataMember(Name = "roles", EmitDefaultValue = false)]
    public List<DomainRole> Roles { get; set; }



    /// <summary>
    /// A collection of the roles the user is not using
    /// </summary>
    /// <value>A collection of the roles the user is not using</value>
    [DataMember(Name = "unusedRoles", EmitDefaultValue = false)]
    public List<DomainRole> UnusedRoles { get; private set; }



    /// <summary>
    /// A collection of the permissions granted by all assigned roles
    /// </summary>
    /// <value>A collection of the permissions granted by all assigned roles</value>
    [DataMember(Name = "permissions", EmitDefaultValue = false)]
    public List<string> Permissions { get; private set; }



    /// <summary>
    /// The policies configured for assigned permissions.
    /// </summary>
    /// <value>The policies configured for assigned permissions.</value>
    [DataMember(Name = "permissionPolicies", EmitDefaultValue = false)]
    public List<ResourcePermissionPolicy> PermissionPolicies { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class UserAuthorization {\n");

        sb.Append("  Roles: ").Append(Roles).Append("\n");
        sb.Append("  UnusedRoles: ").Append(UnusedRoles).Append("\n");
        sb.Append("  Permissions: ").Append(Permissions).Append("\n");
        sb.Append("  PermissionPolicies: ").Append(PermissionPolicies).Append("\n");
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
        return Equals(obj as UserAuthorization);
    }

    /// <summary>
    /// Returns true if UserAuthorization instances are equal
    /// </summary>
    /// <param name="other">Instance of UserAuthorization to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(UserAuthorization other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Roles == other.Roles ||
                Roles != null &&
                Roles.SequenceEqual(other.Roles)
            ) &&
            (
                UnusedRoles == other.UnusedRoles ||
                UnusedRoles != null &&
                UnusedRoles.SequenceEqual(other.UnusedRoles)
            ) &&
            (
                Permissions == other.Permissions ||
                Permissions != null &&
                Permissions.SequenceEqual(other.Permissions)
            ) &&
            (
                PermissionPolicies == other.PermissionPolicies ||
                PermissionPolicies != null &&
                PermissionPolicies.SequenceEqual(other.PermissionPolicies)
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
            if (Roles != null)
            {
                hash = hash * 59 + Roles.GetHashCode();
            }

            if (UnusedRoles != null)
            {
                hash = hash * 59 + UnusedRoles.GetHashCode();
            }

            if (Permissions != null)
            {
                hash = hash * 59 + Permissions.GetHashCode();
            }

            if (PermissionPolicies != null)
            {
                hash = hash * 59 + PermissionPolicies.GetHashCode();
            }

            return hash;
        }
    }
}
