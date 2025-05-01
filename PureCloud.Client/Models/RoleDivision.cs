using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// RoleDivision
/// </summary>
[DataContract]
public partial class RoleDivision : IEquatable<RoleDivision>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="RoleDivision" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected RoleDivision() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="RoleDivision" /> class.
    /// </summary>
    /// <param name="RoleId">Role to be associated with the given division which forms a grant (required).</param>
    /// <param name="DivisionId">Division associated with the given role which forms a grant (required).</param>
    public RoleDivision(string RoleId = null, string DivisionId = null)
    {
        this.RoleId = RoleId;
        this.DivisionId = DivisionId;

    }



    /// <summary>
    /// Role to be associated with the given division which forms a grant
    /// </summary>
    /// <value>Role to be associated with the given division which forms a grant</value>
    [DataMember(Name = "roleId", EmitDefaultValue = false)]
    public string RoleId { get; set; }



    /// <summary>
    /// Division associated with the given role which forms a grant
    /// </summary>
    /// <value>Division associated with the given role which forms a grant</value>
    [DataMember(Name = "divisionId", EmitDefaultValue = false)]
    public string DivisionId { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class RoleDivision {\n");

        sb.Append("  RoleId: ").Append(RoleId).Append("\n");
        sb.Append("  DivisionId: ").Append(DivisionId).Append("\n");
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
        return Equals(obj as RoleDivision);
    }

    /// <summary>
    /// Returns true if RoleDivision instances are equal
    /// </summary>
    /// <param name="other">Instance of RoleDivision to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(RoleDivision other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                RoleId == other.RoleId ||
                RoleId != null &&
                RoleId.Equals(other.RoleId)
            ) &&
            (
                DivisionId == other.DivisionId ||
                DivisionId != null &&
                DivisionId.Equals(other.DivisionId)
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
            if (RoleId != null)
            {
                hash = hash * 59 + RoleId.GetHashCode();
            }

            if (DivisionId != null)
            {
                hash = hash * 59 + DivisionId.GetHashCode();
            }

            return hash;
        }
    }
}
