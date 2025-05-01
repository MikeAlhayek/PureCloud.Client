using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// LicenseOrgToggle
/// </summary>
[DataContract]
public partial class LicenseOrgToggle : IEquatable<LicenseOrgToggle>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="LicenseOrgToggle" /> class.
    /// </summary>
    /// <param name="FeatureName">FeatureName.</param>
    /// <param name="Enabled">Enabled.</param>
    public LicenseOrgToggle(string FeatureName = null, bool? Enabled = null)
    {
        this.FeatureName = FeatureName;
        this.Enabled = Enabled;

    }



    /// <summary>
    /// Gets or Sets FeatureName
    /// </summary>
    [DataMember(Name = "featureName", EmitDefaultValue = false)]
    public string FeatureName { get; set; }



    /// <summary>
    /// Gets or Sets Enabled
    /// </summary>
    [DataMember(Name = "enabled", EmitDefaultValue = false)]
    public bool? Enabled { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class LicenseOrgToggle {\n");

        sb.Append("  FeatureName: ").Append(FeatureName).Append("\n");
        sb.Append("  Enabled: ").Append(Enabled).Append("\n");
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
        return Equals(obj as LicenseOrgToggle);
    }

    /// <summary>
    /// Returns true if LicenseOrgToggle instances are equal
    /// </summary>
    /// <param name="other">Instance of LicenseOrgToggle to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(LicenseOrgToggle other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                FeatureName == other.FeatureName ||
                FeatureName != null &&
                FeatureName.Equals(other.FeatureName)
            ) &&
            (
                Enabled == other.Enabled ||
                Enabled != null &&
                Enabled.Equals(other.Enabled)
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
            if (FeatureName != null)
            {
                hash = hash * 59 + FeatureName.GetHashCode();
            }

            if (Enabled != null)
            {
                hash = hash * 59 + Enabled.GetHashCode();
            }

            return hash;
        }
    }
}
