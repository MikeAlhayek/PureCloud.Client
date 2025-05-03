using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AuthzGrant
/// </summary>

public partial class AuthzGrant : IEquatable<AuthzGrant>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AuthzGrant" /> class.
    /// </summary>
    /// <param name="SubjectId">SubjectId.</param>
    /// <param name="Division">Division.</param>
    /// <param name="Role">Role.</param>
    /// <param name="GrantMadeAt">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    public AuthzGrant(string SubjectId = null, AuthzDivision Division = null, AuthzGrantRole Role = null, DateTime? GrantMadeAt = null)
    {
        this.SubjectId = SubjectId;
        this.Division = Division;
        this.Role = Role;
        this.GrantMadeAt = GrantMadeAt;

    }



    /// <summary>
    /// Gets or Sets SubjectId
    /// </summary>
    [JsonPropertyName("subjectId")]
    public string SubjectId { get; set; }



    /// <summary>
    /// Gets or Sets Division
    /// </summary>
    [JsonPropertyName("division")]
    public AuthzDivision Division { get; set; }



    /// <summary>
    /// Gets or Sets Role
    /// </summary>
    [JsonPropertyName("role")]
    public AuthzGrantRole Role { get; set; }



    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("grantMadeAt")]
    public DateTime? GrantMadeAt { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AuthzGrant {\n");

        sb.Append("  SubjectId: ").Append(SubjectId).Append("\n");
        sb.Append("  Division: ").Append(Division).Append("\n");
        sb.Append("  Role: ").Append(Role).Append("\n");
        sb.Append("  GrantMadeAt: ").Append(GrantMadeAt).Append("\n");
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
        return Equals(obj as AuthzGrant);
    }

    /// <summary>
    /// Returns true if AuthzGrant instances are equal
    /// </summary>
    /// <param name="other">Instance of AuthzGrant to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AuthzGrant other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                SubjectId == other.SubjectId ||
                SubjectId != null &&
                SubjectId.Equals(other.SubjectId)
            ) &&
            (
                Division == other.Division ||
                Division != null &&
                Division.Equals(other.Division)
            ) &&
            (
                Role == other.Role ||
                Role != null &&
                Role.Equals(other.Role)
            ) &&
            (
                GrantMadeAt == other.GrantMadeAt ||
                GrantMadeAt != null &&
                GrantMadeAt.Equals(other.GrantMadeAt)
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
            if (SubjectId != null)
            {
                hash = hash * 59 + SubjectId.GetHashCode();
            }

            if (Division != null)
            {
                hash = hash * 59 + Division.GetHashCode();
            }

            if (Role != null)
            {
                hash = hash * 59 + Role.GetHashCode();
            }

            if (GrantMadeAt != null)
            {
                hash = hash * 59 + GrantMadeAt.GetHashCode();
            }

            return hash;
        }
    }
}
