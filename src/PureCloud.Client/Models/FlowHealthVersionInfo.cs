using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// FlowHealthVersionInfo
/// </summary>

public partial class FlowHealthVersionInfo : IEquatable<FlowHealthVersionInfo>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="FlowHealthVersionInfo" /> class.
    /// </summary>
    public FlowHealthVersionInfo()
    {

    }



    /// <summary>
    /// Given flow&#39;s Version Info.
    /// </summary>
    /// <value>Given flow&#39;s Version Info.</value>
    [JsonPropertyName("flowVersion")]
    public AddressableEntityRef FlowVersion { get; set; }



    /// <summary>
    /// NLU Domain Info for this flow version.
    /// </summary>
    /// <value>NLU Domain Info for this flow version.</value>
    [JsonPropertyName("nluDomain")]
    public AddressableEntityRef NluDomain { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class FlowHealthVersionInfo {\n");

        sb.Append("  FlowVersion: ").Append(FlowVersion).Append("\n");
        sb.Append("  NluDomain: ").Append(NluDomain).Append("\n");
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
        return Equals(obj as FlowHealthVersionInfo);
    }

    /// <summary>
    /// Returns true if FlowHealthVersionInfo instances are equal
    /// </summary>
    /// <param name="other">Instance of FlowHealthVersionInfo to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(FlowHealthVersionInfo other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                FlowVersion == other.FlowVersion ||
                FlowVersion != null &&
                FlowVersion.Equals(other.FlowVersion)
            ) &&
            (
                NluDomain == other.NluDomain ||
                NluDomain != null &&
                NluDomain.Equals(other.NluDomain)
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
            if (FlowVersion != null)
            {
                hash = hash * 59 + FlowVersion.GetHashCode();
            }

            if (NluDomain != null)
            {
                hash = hash * 59 + NluDomain.GetHashCode();
            }

            return hash;
        }
    }
}
