using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WfmBuIntradayDataUpdateTopicIntradayPerformancePredictionData
/// </summary>
[DataContract]
public partial class WfmBuIntradayDataUpdateTopicIntradayPerformancePredictionData : IEquatable<WfmBuIntradayDataUpdateTopicIntradayPerformancePredictionData>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="WfmBuIntradayDataUpdateTopicIntradayPerformancePredictionData" /> class.
    /// </summary>
    /// <param name="ServiceLevelPercent">ServiceLevelPercent.</param>
    /// <param name="AverageSpeedOfAnswerSeconds">AverageSpeedOfAnswerSeconds.</param>
    /// <param name="OccupancyPercent">OccupancyPercent.</param>
    public WfmBuIntradayDataUpdateTopicIntradayPerformancePredictionData(double? ServiceLevelPercent = null, double? AverageSpeedOfAnswerSeconds = null, double? OccupancyPercent = null)
    {
        this.ServiceLevelPercent = ServiceLevelPercent;
        this.AverageSpeedOfAnswerSeconds = AverageSpeedOfAnswerSeconds;
        this.OccupancyPercent = OccupancyPercent;

    }



    /// <summary>
    /// Gets or Sets ServiceLevelPercent
    /// </summary>
    [DataMember(Name = "serviceLevelPercent", EmitDefaultValue = false)]
    public double? ServiceLevelPercent { get; set; }



    /// <summary>
    /// Gets or Sets AverageSpeedOfAnswerSeconds
    /// </summary>
    [DataMember(Name = "averageSpeedOfAnswerSeconds", EmitDefaultValue = false)]
    public double? AverageSpeedOfAnswerSeconds { get; set; }



    /// <summary>
    /// Gets or Sets OccupancyPercent
    /// </summary>
    [DataMember(Name = "occupancyPercent", EmitDefaultValue = false)]
    public double? OccupancyPercent { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WfmBuIntradayDataUpdateTopicIntradayPerformancePredictionData {\n");

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
        return Equals(obj as WfmBuIntradayDataUpdateTopicIntradayPerformancePredictionData);
    }

    /// <summary>
    /// Returns true if WfmBuIntradayDataUpdateTopicIntradayPerformancePredictionData instances are equal
    /// </summary>
    /// <param name="other">Instance of WfmBuIntradayDataUpdateTopicIntradayPerformancePredictionData to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WfmBuIntradayDataUpdateTopicIntradayPerformancePredictionData other)
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
