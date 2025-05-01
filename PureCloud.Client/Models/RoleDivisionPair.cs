using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// RoleDivisionPair
/// </summary>
[DataContract]
public partial class RoleDivisionPair : IEquatable<RoleDivisionPair>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="RoleDivisionPair" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected RoleDivisionPair() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="RoleDivisionPair" /> class.
    /// </summary>
    /// <param name="RoleId">The ID of the role (required).</param>
    /// <param name="DivisionId">The ID of the division (required).</param>
    public RoleDivisionPair(string RoleId = null, string DivisionId = null)
    {
        this.RoleId = RoleId;
        this.DivisionId = DivisionId;

    }



    /// <summary>
    /// The ID of the role
    /// </summary>
    /// <value>The ID of the role</value>
    [DataMember(Name = "roleId", EmitDefaultValue = false)]
    public string RoleId { get; set; }



    /// <summary>
    /// The ID of the division
    /// </summary>
    /// <value>The ID of the division</value>
    [DataMember(Name = "divisionId", EmitDefaultValue = false)]
    public string DivisionId { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class RoleDivisionPair {\n");

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
        return this.Equals(obj as RoleDivisionPair);
    }

    /// <summary>
    /// Returns true if RoleDivisionPair instances are equal
    /// </summary>
    /// <param name="other">Instance of RoleDivisionPair to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(RoleDivisionPair other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                this.RoleId == other.RoleId ||
                this.RoleId != null &&
                this.RoleId.Equals(other.RoleId)
            ) &&
            (
                this.DivisionId == other.DivisionId ||
                this.DivisionId != null &&
                this.DivisionId.Equals(other.DivisionId)
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
            if (this.RoleId != null)
            {
                hash = hash * 59 + this.RoleId.GetHashCode();
            }

            if (this.DivisionId != null)
            {
                hash = hash * 59 + this.DivisionId.GetHashCode();
            }

            return hash;
        }
    }
}
