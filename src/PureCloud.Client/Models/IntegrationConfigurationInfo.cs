using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Configuration information for the integration
/// </summary>

public partial class IntegrationConfigurationInfo : IEquatable<IntegrationConfigurationInfo>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="IntegrationConfigurationInfo" /> class.
    /// </summary>
    public IntegrationConfigurationInfo()
    {

    }



    /// <summary>
    /// The current, active configuration for the integration.
    /// </summary>
    /// <value>The current, active configuration for the integration.</value>
    [JsonPropertyName("current")]
    public IntegrationConfiguration Current { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class IntegrationConfigurationInfo {\n");

        sb.Append("  Current: ").Append(Current).Append("\n");
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
        return Equals(obj as IntegrationConfigurationInfo);
    }

    /// <summary>
    /// Returns true if IntegrationConfigurationInfo instances are equal
    /// </summary>
    /// <param name="other">Instance of IntegrationConfigurationInfo to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(IntegrationConfigurationInfo other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Current == other.Current ||
                Current != null &&
                Current.Equals(other.Current)
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
            if (Current != null)
            {
                hash = hash * 59 + Current.GetHashCode();
            }

            return hash;
        }
    }
}
