using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// DomainPhysicalCapabilities
/// </summary>

public partial class DomainPhysicalCapabilities : IEquatable<DomainPhysicalCapabilities>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DomainPhysicalCapabilities" /> class.
    /// </summary>
    /// <param name="Vlan">Vlan.</param>
    /// <param name="Team">Team.</param>
    public DomainPhysicalCapabilities(bool? Vlan = null, bool? Team = null)
    {
        this.Vlan = Vlan;
        this.Team = Team;

    }



    /// <summary>
    /// Gets or Sets Vlan
    /// </summary>
    [JsonPropertyName("vlan")]
    public bool? Vlan { get; set; }



    /// <summary>
    /// Gets or Sets Team
    /// </summary>
    [JsonPropertyName("team")]
    public bool? Team { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class DomainPhysicalCapabilities {\n");

        sb.Append("  Vlan: ").Append(Vlan).Append("\n");
        sb.Append("  Team: ").Append(Team).Append("\n");
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
        return Equals(obj as DomainPhysicalCapabilities);
    }

    /// <summary>
    /// Returns true if DomainPhysicalCapabilities instances are equal
    /// </summary>
    /// <param name="other">Instance of DomainPhysicalCapabilities to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DomainPhysicalCapabilities other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Vlan == other.Vlan ||
                Vlan != null &&
                Vlan.Equals(other.Vlan)
            ) &&
            (
                Team == other.Team ||
                Team != null &&
                Team.Equals(other.Team)
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
            if (Vlan != null)
            {
                hash = hash * 59 + Vlan.GetHashCode();
            }

            if (Team != null)
            {
                hash = hash * 59 + Team.GetHashCode();
            }

            return hash;
        }
    }
}
