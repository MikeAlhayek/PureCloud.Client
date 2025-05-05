using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ServiceGoalTemplateImpactOverride
/// </summary>

public partial class ServiceGoalTemplateImpactOverride : IEquatable<ServiceGoalTemplateImpactOverride>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="ServiceGoalTemplateImpactOverride" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected ServiceGoalTemplateImpactOverride() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ServiceGoalTemplateImpactOverride" /> class.
    /// </summary>
    /// <param name="Enabled">Whether service goal overrides are enabled for this service goal template (required).</param>
    /// <param name="Impact">Settings controlling max percent increase and decrease of service goals for this service goal template (required).</param>
    public ServiceGoalTemplateImpactOverride(bool? Enabled = null, WfmServiceGoalImpactSettings Impact = null)
    {
        this.Enabled = Enabled;
        this.Impact = Impact;

    }



    /// <summary>
    /// Whether service goal overrides are enabled for this service goal template
    /// </summary>
    /// <value>Whether service goal overrides are enabled for this service goal template</value>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }



    /// <summary>
    /// Settings controlling max percent increase and decrease of service goals for this service goal template
    /// </summary>
    /// <value>Settings controlling max percent increase and decrease of service goals for this service goal template</value>
    [JsonPropertyName("impact")]
    public WfmServiceGoalImpactSettings Impact { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ServiceGoalTemplateImpactOverride {\n");

        sb.Append("  Enabled: ").Append(Enabled).Append("\n");
        sb.Append("  Impact: ").Append(Impact).Append("\n");
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
        return Equals(obj as ServiceGoalTemplateImpactOverride);
    }

    /// <summary>
    /// Returns true if ServiceGoalTemplateImpactOverride instances are equal
    /// </summary>
    /// <param name="other">Instance of ServiceGoalTemplateImpactOverride to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ServiceGoalTemplateImpactOverride other)
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
                Impact == other.Impact ||
                Impact != null &&
                Impact.Equals(other.Impact)
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

            if (Impact != null)
            {
                hash = hash * 59 + Impact.GetHashCode();
            }

            return hash;
        }
    }
}
