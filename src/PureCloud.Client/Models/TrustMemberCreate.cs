using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// TrustMemberCreate
/// </summary>

public partial class TrustMemberCreate : IEquatable<TrustMemberCreate>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="TrustMemberCreate" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected TrustMemberCreate() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="TrustMemberCreate" /> class.
    /// </summary>
    /// <param name="Id">Trustee User or Group Id (required).</param>
    /// <param name="RoleIds">The list of roles to be granted to this user or group. Roles will be granted in all divisions..</param>
    /// <param name="RoleDivisions">The list of trustor organization roles granting this user or group access paired with the divisions for those roles..</param>
    public TrustMemberCreate(string Id = null, List<string> RoleIds = null, RoleDivisionGrants RoleDivisions = null)
    {
        this.Id = Id;
        this.RoleIds = RoleIds;
        this.RoleDivisions = RoleDivisions;

    }



    /// <summary>
    /// Trustee User or Group Id
    /// </summary>
    /// <value>Trustee User or Group Id</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// The list of roles to be granted to this user or group. Roles will be granted in all divisions.
    /// </summary>
    /// <value>The list of roles to be granted to this user or group. Roles will be granted in all divisions.</value>
    [JsonPropertyName("roleIds")]
    public List<string> RoleIds { get; set; }



    /// <summary>
    /// The list of trustor organization roles granting this user or group access paired with the divisions for those roles.
    /// </summary>
    /// <value>The list of trustor organization roles granting this user or group access paired with the divisions for those roles.</value>
    [JsonPropertyName("roleDivisions")]
    public RoleDivisionGrants RoleDivisions { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class TrustMemberCreate {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  RoleIds: ").Append(RoleIds).Append("\n");
        sb.Append("  RoleDivisions: ").Append(RoleDivisions).Append("\n");
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
        return Equals(obj as TrustMemberCreate);
    }

    /// <summary>
    /// Returns true if TrustMemberCreate instances are equal
    /// </summary>
    /// <param name="other">Instance of TrustMemberCreate to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(TrustMemberCreate other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Id == other.Id ||
                Id != null &&
                Id.Equals(other.Id)
            ) &&
            (
                RoleIds == other.RoleIds ||
                RoleIds != null &&
                RoleIds.SequenceEqual(other.RoleIds)
            ) &&
            (
                RoleDivisions == other.RoleDivisions ||
                RoleDivisions != null &&
                RoleDivisions.Equals(other.RoleDivisions)
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
            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            if (RoleIds != null)
            {
                hash = hash * 59 + RoleIds.GetHashCode();
            }

            if (RoleDivisions != null)
            {
                hash = hash * 59 + RoleDivisions.GetHashCode();
            }

            return hash;
        }
    }
}
