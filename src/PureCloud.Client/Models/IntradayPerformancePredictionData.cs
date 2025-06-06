using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// IntradayPerformancePredictionData
/// </summary>

public partial class IntradayPerformancePredictionData : IEquatable<IntradayPerformancePredictionData>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="IntradayPerformancePredictionData" /> class.
    /// </summary>
    /// <param name="ServiceLevelPercent">Percentage of interactions that meets service level target as defined in the matching service goal templates.</param>
    /// <param name="AverageSpeedOfAnswerSeconds">Predicted average time in seconds it takes to answer an interaction once the interaction becomes available to be routed.</param>
    /// <param name="OccupancyPercent">Percentage of on-queue time for all agents in this group that are occupied handling interactions.</param>
    public IntradayPerformancePredictionData(double? ServiceLevelPercent = null, double? AverageSpeedOfAnswerSeconds = null, double? OccupancyPercent = null)
    {
        this.ServiceLevelPercent = ServiceLevelPercent;
        this.AverageSpeedOfAnswerSeconds = AverageSpeedOfAnswerSeconds;
        this.OccupancyPercent = OccupancyPercent;

    }



    /// <summary>
    /// Percentage of interactions that meets service level target as defined in the matching service goal templates
    /// </summary>
    /// <value>Percentage of interactions that meets service level target as defined in the matching service goal templates</value>
    [JsonPropertyName("serviceLevelPercent")]
    public double? ServiceLevelPercent { get; set; }



    /// <summary>
    /// Predicted average time in seconds it takes to answer an interaction once the interaction becomes available to be routed
    /// </summary>
    /// <value>Predicted average time in seconds it takes to answer an interaction once the interaction becomes available to be routed</value>
    [JsonPropertyName("averageSpeedOfAnswerSeconds")]
    public double? AverageSpeedOfAnswerSeconds { get; set; }



    /// <summary>
    /// Percentage of on-queue time for all agents in this group that are occupied handling interactions
    /// </summary>
    /// <value>Percentage of on-queue time for all agents in this group that are occupied handling interactions</value>
    [JsonPropertyName("occupancyPercent")]
    public double? OccupancyPercent { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class IntradayPerformancePredictionData {\n");

        sb.Append("  ServiceLevelPercent: ").Append(ServiceLevelPercent).Append("\n");
        sb.Append("  AverageSpeedOfAnswerSeconds: ").Append(AverageSpeedOfAnswerSeconds).Append("\n");
        sb.Append("  OccupancyPercent: ").Append(OccupancyPercent).Append("\n");
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
        return Equals(obj as IntradayPerformancePredictionData);
    }

    /// <summary>
    /// Returns true if IntradayPerformancePredictionData instances are equal
    /// </summary>
    /// <param name="other">Instance of IntradayPerformancePredictionData to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(IntradayPerformancePredictionData other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                ServiceLevelPercent == other.ServiceLevelPercent ||
                ServiceLevelPercent != null &&
                ServiceLevelPercent.Equals(other.ServiceLevelPercent)
            ) &&
            (
                AverageSpeedOfAnswerSeconds == other.AverageSpeedOfAnswerSeconds ||
                AverageSpeedOfAnswerSeconds != null &&
                AverageSpeedOfAnswerSeconds.Equals(other.AverageSpeedOfAnswerSeconds)
            ) &&
            (
                OccupancyPercent == other.OccupancyPercent ||
                OccupancyPercent != null &&
                OccupancyPercent.Equals(other.OccupancyPercent)
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
            if (ServiceLevelPercent != null)
            {
                hash = hash * 59 + ServiceLevelPercent.GetHashCode();
            }

            if (AverageSpeedOfAnswerSeconds != null)
            {
                hash = hash * 59 + AverageSpeedOfAnswerSeconds.GetHashCode();
            }

            if (OccupancyPercent != null)
            {
                hash = hash * 59 + OccupancyPercent.GetHashCode();
            }

            return hash;
        }
    }
}
