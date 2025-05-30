using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// DynamicLineBalancingSettings
/// </summary>

public partial class DynamicLineBalancingSettings : IEquatable<DynamicLineBalancingSettings>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DynamicLineBalancingSettings" /> class.
    /// </summary>
    /// <param name="Enabled">Indicates that this campaign is subject of dynamic line balancing.</param>
    /// <param name="RelativeWeight">Relative weight of this campaign in dynamic line balancing.</param>
    public DynamicLineBalancingSettings(bool? Enabled = null, int? RelativeWeight = null)
    {
        this.Enabled = Enabled;
        this.RelativeWeight = RelativeWeight;

    }



    /// <summary>
    /// Indicates that this campaign is subject of dynamic line balancing
    /// </summary>
    /// <value>Indicates that this campaign is subject of dynamic line balancing</value>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }



    /// <summary>
    /// Relative weight of this campaign in dynamic line balancing
    /// </summary>
    /// <value>Relative weight of this campaign in dynamic line balancing</value>
    [JsonPropertyName("relativeWeight")]
    public int? RelativeWeight { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class DynamicLineBalancingSettings {\n");

        sb.Append("  Enabled: ").Append(Enabled).Append("\n");
        sb.Append("  RelativeWeight: ").Append(RelativeWeight).Append("\n");
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
        return Equals(obj as DynamicLineBalancingSettings);
    }

    /// <summary>
    /// Returns true if DynamicLineBalancingSettings instances are equal
    /// </summary>
    /// <param name="other">Instance of DynamicLineBalancingSettings to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DynamicLineBalancingSettings other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Enabled == other.Enabled ||
                Enabled != null &&
                Enabled.Equals(other.Enabled)
            ) &&
            (
                RelativeWeight == other.RelativeWeight ||
                RelativeWeight != null &&
                RelativeWeight.Equals(other.RelativeWeight)
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
            if (Enabled != null)
            {
                hash = hash * 59 + Enabled.GetHashCode();
            }

            if (RelativeWeight != null)
            {
                hash = hash * 59 + RelativeWeight.GetHashCode();
            }

            return hash;
        }
    }
}
