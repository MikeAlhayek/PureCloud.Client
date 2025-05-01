using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Configuration information for the integration
/// </summary>
[DataContract]
public partial class ClientAppConfigurationInfo : IEquatable<ClientAppConfigurationInfo>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ClientAppConfigurationInfo" /> class.
    /// </summary>
    public ClientAppConfigurationInfo()
    {

    }



    /// <summary>
    /// The current, active configuration for the integration.
    /// </summary>
    /// <value>The current, active configuration for the integration.</value>
    [DataMember(Name = "current", EmitDefaultValue = false)]
    public IntegrationConfiguration Current { get; private set; }



    /// <summary>
    /// The effective configuration for the app, containing the integration specific configuration along with overrides specified in the integration type.
    /// </summary>
    /// <value>The effective configuration for the app, containing the integration specific configuration along with overrides specified in the integration type.</value>
    [DataMember(Name = "effective", EmitDefaultValue = false)]
    public EffectiveConfiguration Effective { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ClientAppConfigurationInfo {\n");

        sb.Append("  Current: ").Append(Current).Append("\n");
        sb.Append("  Effective: ").Append(Effective).Append("\n");
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
        return this.Equals(obj as ClientAppConfigurationInfo);
    }

    /// <summary>
    /// Returns true if ClientAppConfigurationInfo instances are equal
    /// </summary>
    /// <param name="other">Instance of ClientAppConfigurationInfo to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ClientAppConfigurationInfo other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                this.Current == other.Current ||
                this.Current != null &&
                this.Current.Equals(other.Current)
            ) &&
            (
                this.Effective == other.Effective ||
                this.Effective != null &&
                this.Effective.Equals(other.Effective)
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
            if (this.Current != null)
            {
                hash = hash * 59 + this.Current.GetHashCode();
            }

            if (this.Effective != null)
            {
                hash = hash * 59 + this.Effective.GetHashCode();
            }

            return hash;
        }
    }
}
