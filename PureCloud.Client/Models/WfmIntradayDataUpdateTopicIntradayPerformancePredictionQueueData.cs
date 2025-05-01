using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WfmIntradayDataUpdateTopicIntradayPerformancePredictionQueueData
/// </summary>
[DataContract]
public partial class WfmIntradayDataUpdateTopicIntradayPerformancePredictionQueueData : IEquatable<WfmIntradayDataUpdateTopicIntradayPerformancePredictionQueueData>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="WfmIntradayDataUpdateTopicIntradayPerformancePredictionQueueData" /> class.
    /// </summary>
    /// <param name="ServiceLevelPercent">ServiceLevelPercent.</param>
    /// <param name="AverageSpeedOfAnswerSeconds">AverageSpeedOfAnswerSeconds.</param>
    /// <param name="NumberOfInteractions">NumberOfInteractions.</param>
    public WfmIntradayDataUpdateTopicIntradayPerformancePredictionQueueData(double? ServiceLevelPercent = null, double? AverageSpeedOfAnswerSeconds = null, double? NumberOfInteractions = null)
    {
        this.ServiceLevelPercent = ServiceLevelPercent;
        this.AverageSpeedOfAnswerSeconds = AverageSpeedOfAnswerSeconds;
        this.NumberOfInteractions = NumberOfInteractions;

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
    /// Gets or Sets NumberOfInteractions
    /// </summary>
    [DataMember(Name = "numberOfInteractions", EmitDefaultValue = false)]
    public double? NumberOfInteractions { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WfmIntradayDataUpdateTopicIntradayPerformancePredictionQueueData {\n");

        sb.Append("  ServiceLevelPercent: ").Append(ServiceLevelPercent).Append("\n");
        sb.Append("  AverageSpeedOfAnswerSeconds: ").Append(AverageSpeedOfAnswerSeconds).Append("\n");
        sb.Append("  NumberOfInteractions: ").Append(NumberOfInteractions).Append("\n");
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
        return Equals(obj as WfmIntradayDataUpdateTopicIntradayPerformancePredictionQueueData);
    }

    /// <summary>
    /// Returns true if WfmIntradayDataUpdateTopicIntradayPerformancePredictionQueueData instances are equal
    /// </summary>
    /// <param name="other">Instance of WfmIntradayDataUpdateTopicIntradayPerformancePredictionQueueData to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WfmIntradayDataUpdateTopicIntradayPerformancePredictionQueueData other)
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
                NumberOfInteractions == other.NumberOfInteractions ||
                NumberOfInteractions != null &&
                NumberOfInteractions.Equals(other.NumberOfInteractions)
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

            if (NumberOfInteractions != null)
            {
                hash = hash * 59 + NumberOfInteractions.GetHashCode();
            }

            return hash;
        }
    }
}
