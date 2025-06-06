using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AuditQueryServiceMapping
/// </summary>

public partial class AuditQueryServiceMapping : IEquatable<AuditQueryServiceMapping>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AuditQueryServiceMapping" /> class.
    /// </summary>
    /// <param name="Services">List of Services.</param>
    public AuditQueryServiceMapping(List<AuditQueryService> Services = null)
    {
        this.Services = Services;

    }



    /// <summary>
    /// List of Services
    /// </summary>
    /// <value>List of Services</value>
    [JsonPropertyName("services")]
    public List<AuditQueryService> Services { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AuditQueryServiceMapping {\n");

        sb.Append("  Services: ").Append(Services).Append("\n");
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
        return Equals(obj as AuditQueryServiceMapping);
    }

    /// <summary>
    /// Returns true if AuditQueryServiceMapping instances are equal
    /// </summary>
    /// <param name="other">Instance of AuditQueryServiceMapping to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AuditQueryServiceMapping other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Services == other.Services ||
                Services != null &&
                Services.SequenceEqual(other.Services)
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
            if (Services != null)
            {
                hash = hash * 59 + Services.GetHashCode();
            }

            return hash;
        }
    }
}
