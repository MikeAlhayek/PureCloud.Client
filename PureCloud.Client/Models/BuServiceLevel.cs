using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// BuServiceLevel
/// </summary>

public partial class BuServiceLevel : IEquatable<BuServiceLevel>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="BuServiceLevel" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected BuServiceLevel() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="BuServiceLevel" /> class.
    /// </summary>
    /// <param name="Include">Whether to include service level targets in the associated configuration (required).</param>
    /// <param name="Percent">Service level target percent answered. Required if include &#x3D;&#x3D; true.</param>
    /// <param name="Seconds">Service level target answer time. Required if include &#x3D;&#x3D; true.</param>
    public BuServiceLevel(bool? Include = null, int? Percent = null, int? Seconds = null)
    {
        this.Include = Include;
        this.Percent = Percent;
        this.Seconds = Seconds;

    }



    /// <summary>
    /// Whether to include service level targets in the associated configuration
    /// </summary>
    /// <value>Whether to include service level targets in the associated configuration</value>
    [JsonPropertyName("include")]
    public bool? Include { get; set; }



    /// <summary>
    /// Service level target percent answered. Required if include &#x3D;&#x3D; true
    /// </summary>
    /// <value>Service level target percent answered. Required if include &#x3D;&#x3D; true</value>
    [JsonPropertyName("percent")]
    public int? Percent { get; set; }



    /// <summary>
    /// Service level target answer time. Required if include &#x3D;&#x3D; true
    /// </summary>
    /// <value>Service level target answer time. Required if include &#x3D;&#x3D; true</value>
    [JsonPropertyName("seconds")]
    public int? Seconds { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class BuServiceLevel {\n");

        sb.Append("  Include: ").Append(Include).Append("\n");
        sb.Append("  Percent: ").Append(Percent).Append("\n");
        sb.Append("  Seconds: ").Append(Seconds).Append("\n");
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
        return Equals(obj as BuServiceLevel);
    }

    /// <summary>
    /// Returns true if BuServiceLevel instances are equal
    /// </summary>
    /// <param name="other">Instance of BuServiceLevel to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(BuServiceLevel other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Include == other.Include ||
                Include != null &&
                Include.Equals(other.Include)
            ) &&
            (
                Percent == other.Percent ||
                Percent != null &&
                Percent.Equals(other.Percent)
            ) &&
            (
                Seconds == other.Seconds ||
                Seconds != null &&
                Seconds.Equals(other.Seconds)
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
            if (Include != null)
            {
                hash = hash * 59 + Include.GetHashCode();
            }

            if (Percent != null)
            {
                hash = hash * 59 + Percent.GetHashCode();
            }

            if (Seconds != null)
            {
                hash = hash * 59 + Seconds.GetHashCode();
            }

            return hash;
        }
    }
}
