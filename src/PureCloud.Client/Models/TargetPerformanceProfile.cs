using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// TargetPerformanceProfile
/// </summary>

public partial class TargetPerformanceProfile : IEquatable<TargetPerformanceProfile>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="TargetPerformanceProfile" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected TargetPerformanceProfile() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="TargetPerformanceProfile" /> class.
    /// </summary>
    /// <param name="TargetPerformanceProfileId">The target destination performanceProfileId for the linked metric. (required).</param>
    public TargetPerformanceProfile(string TargetPerformanceProfileId = null)
    {
        this.TargetPerformanceProfileId = TargetPerformanceProfileId;

    }



    /// <summary>
    /// The target destination performanceProfileId for the linked metric.
    /// </summary>
    /// <value>The target destination performanceProfileId for the linked metric.</value>
    [JsonPropertyName("targetPerformanceProfileId")]
    public string TargetPerformanceProfileId { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class TargetPerformanceProfile {\n");

        sb.Append("  TargetPerformanceProfileId: ").Append(TargetPerformanceProfileId).Append("\n");
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
        return Equals(obj as TargetPerformanceProfile);
    }

    /// <summary>
    /// Returns true if TargetPerformanceProfile instances are equal
    /// </summary>
    /// <param name="other">Instance of TargetPerformanceProfile to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(TargetPerformanceProfile other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                TargetPerformanceProfileId == other.TargetPerformanceProfileId ||
                TargetPerformanceProfileId != null &&
                TargetPerformanceProfileId.Equals(other.TargetPerformanceProfileId)
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
            if (TargetPerformanceProfileId != null)
            {
                hash = hash * 59 + TargetPerformanceProfileId.GetHashCode();
            }

            return hash;
        }
    }
}
