using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// OverallBestPoints
/// </summary>

public partial class OverallBestPoints : IEquatable<OverallBestPoints>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="OverallBestPoints" /> class.
    /// </summary>
    public OverallBestPoints()
    {

    }



    /// <summary>
    /// The requested division
    /// </summary>
    /// <value>The requested division</value>
    [JsonPropertyName("division")]
    public Division Division { get; set; }



    /// <summary>
    /// List of gamification best point items
    /// </summary>
    /// <value>List of gamification best point items</value>
    [JsonPropertyName("bestPoints")]
    public List<OverallBestPointsItem> BestPoints { get; set; }



    /// <summary>
    /// The targeted performance profile for the average points
    /// </summary>
    /// <value>The targeted performance profile for the average points</value>
    [JsonPropertyName("performanceProfile")]
    public AddressableEntityRef PerformanceProfile { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class OverallBestPoints {\n");

        sb.Append("  Division: ").Append(Division).Append("\n");
        sb.Append("  BestPoints: ").Append(BestPoints).Append("\n");
        sb.Append("  PerformanceProfile: ").Append(PerformanceProfile).Append("\n");
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
        return Equals(obj as OverallBestPoints);
    }

    /// <summary>
    /// Returns true if OverallBestPoints instances are equal
    /// </summary>
    /// <param name="other">Instance of OverallBestPoints to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(OverallBestPoints other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Division == other.Division ||
                Division != null &&
                Division.Equals(other.Division)
            ) &&
            (
                BestPoints == other.BestPoints ||
                BestPoints != null &&
                BestPoints.SequenceEqual(other.BestPoints)
            ) &&
            (
                PerformanceProfile == other.PerformanceProfile ||
                PerformanceProfile != null &&
                PerformanceProfile.Equals(other.PerformanceProfile)
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
            if (Division != null)
            {
                hash = hash * 59 + Division.GetHashCode();
            }

            if (BestPoints != null)
            {
                hash = hash * 59 + BestPoints.GetHashCode();
            }

            if (PerformanceProfile != null)
            {
                hash = hash * 59 + PerformanceProfile.GetHashCode();
            }

            return hash;
        }
    }
}
