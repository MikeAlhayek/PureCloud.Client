using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WfmIntradayDataUpdateTopicIntradayHistoricalQueueData
/// </summary>
[DataContract]
public partial class WfmIntradayDataUpdateTopicIntradayHistoricalQueueData : IEquatable<WfmIntradayDataUpdateTopicIntradayHistoricalQueueData>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="WfmIntradayDataUpdateTopicIntradayHistoricalQueueData" /> class.
    /// </summary>
    /// <param name="Offered">Offered.</param>
    /// <param name="Completed">Completed.</param>
    /// <param name="Answered">Answered.</param>
    /// <param name="Abandoned">Abandoned.</param>
    /// <param name="AverageTalkTimeSeconds">AverageTalkTimeSeconds.</param>
    /// <param name="AverageAfterCallWorkSeconds">AverageAfterCallWorkSeconds.</param>
    /// <param name="ServiceLevelPercent">ServiceLevelPercent.</param>
    /// <param name="AverageSpeedOfAnswerSeconds">AverageSpeedOfAnswerSeconds.</param>
    public WfmIntradayDataUpdateTopicIntradayHistoricalQueueData(long? Offered = null, long? Completed = null, long? Answered = null, long? Abandoned = null, double? AverageTalkTimeSeconds = null, double? AverageAfterCallWorkSeconds = null, double? ServiceLevelPercent = null, double? AverageSpeedOfAnswerSeconds = null)
    {
        this.Offered = Offered;
        this.Completed = Completed;
        this.Answered = Answered;
        this.Abandoned = Abandoned;
        this.AverageTalkTimeSeconds = AverageTalkTimeSeconds;
        this.AverageAfterCallWorkSeconds = AverageAfterCallWorkSeconds;
        this.ServiceLevelPercent = ServiceLevelPercent;
        this.AverageSpeedOfAnswerSeconds = AverageSpeedOfAnswerSeconds;

    }



    /// <summary>
    /// Gets or Sets Offered
    /// </summary>
    [DataMember(Name = "offered", EmitDefaultValue = false)]
    public long? Offered { get; set; }



    /// <summary>
    /// Gets or Sets Completed
    /// </summary>
    [DataMember(Name = "completed", EmitDefaultValue = false)]
    public long? Completed { get; set; }



    /// <summary>
    /// Gets or Sets Answered
    /// </summary>
    [DataMember(Name = "answered", EmitDefaultValue = false)]
    public long? Answered { get; set; }



    /// <summary>
    /// Gets or Sets Abandoned
    /// </summary>
    [DataMember(Name = "abandoned", EmitDefaultValue = false)]
    public long? Abandoned { get; set; }



    /// <summary>
    /// Gets or Sets AverageTalkTimeSeconds
    /// </summary>
    [DataMember(Name = "averageTalkTimeSeconds", EmitDefaultValue = false)]
    public double? AverageTalkTimeSeconds { get; set; }



    /// <summary>
    /// Gets or Sets AverageAfterCallWorkSeconds
    /// </summary>
    [DataMember(Name = "averageAfterCallWorkSeconds", EmitDefaultValue = false)]
    public double? AverageAfterCallWorkSeconds { get; set; }



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
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WfmIntradayDataUpdateTopicIntradayHistoricalQueueData {\n");

        sb.Append("  Offered: ").Append(Offered).Append("\n");
        sb.Append("  Completed: ").Append(Completed).Append("\n");
        sb.Append("  Answered: ").Append(Answered).Append("\n");
        sb.Append("  Abandoned: ").Append(Abandoned).Append("\n");
        sb.Append("  AverageTalkTimeSeconds: ").Append(AverageTalkTimeSeconds).Append("\n");
        sb.Append("  AverageAfterCallWorkSeconds: ").Append(AverageAfterCallWorkSeconds).Append("\n");
        sb.Append("  ServiceLevelPercent: ").Append(ServiceLevelPercent).Append("\n");
        sb.Append("  AverageSpeedOfAnswerSeconds: ").Append(AverageSpeedOfAnswerSeconds).Append("\n");
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
        return Equals(obj as WfmIntradayDataUpdateTopicIntradayHistoricalQueueData);
    }

    /// <summary>
    /// Returns true if WfmIntradayDataUpdateTopicIntradayHistoricalQueueData instances are equal
    /// </summary>
    /// <param name="other">Instance of WfmIntradayDataUpdateTopicIntradayHistoricalQueueData to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WfmIntradayDataUpdateTopicIntradayHistoricalQueueData other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Offered == other.Offered ||
                Offered != null &&
                Offered.Equals(other.Offered)
            ) &&
            (
                Completed == other.Completed ||
                Completed != null &&
                Completed.Equals(other.Completed)
            ) &&
            (
                Answered == other.Answered ||
                Answered != null &&
                Answered.Equals(other.Answered)
            ) &&
            (
                Abandoned == other.Abandoned ||
                Abandoned != null &&
                Abandoned.Equals(other.Abandoned)
            ) &&
            (
                AverageTalkTimeSeconds == other.AverageTalkTimeSeconds ||
                AverageTalkTimeSeconds != null &&
                AverageTalkTimeSeconds.Equals(other.AverageTalkTimeSeconds)
            ) &&
            (
                AverageAfterCallWorkSeconds == other.AverageAfterCallWorkSeconds ||
                AverageAfterCallWorkSeconds != null &&
                AverageAfterCallWorkSeconds.Equals(other.AverageAfterCallWorkSeconds)
            ) &&
            (
                ServiceLevelPercent == other.ServiceLevelPercent ||
                ServiceLevelPercent != null &&
                ServiceLevelPercent.Equals(other.ServiceLevelPercent)
            ) &&
            (
                AverageSpeedOfAnswerSeconds == other.AverageSpeedOfAnswerSeconds ||
                AverageSpeedOfAnswerSeconds != null &&
                AverageSpeedOfAnswerSeconds.Equals(other.AverageSpeedOfAnswerSeconds)
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
            if (Offered != null)
            {
                hash = hash * 59 + Offered.GetHashCode();
            }

            if (Completed != null)
            {
                hash = hash * 59 + Completed.GetHashCode();
            }

            if (Answered != null)
            {
                hash = hash * 59 + Answered.GetHashCode();
            }

            if (Abandoned != null)
            {
                hash = hash * 59 + Abandoned.GetHashCode();
            }

            if (AverageTalkTimeSeconds != null)
            {
                hash = hash * 59 + AverageTalkTimeSeconds.GetHashCode();
            }

            if (AverageAfterCallWorkSeconds != null)
            {
                hash = hash * 59 + AverageAfterCallWorkSeconds.GetHashCode();
            }

            if (ServiceLevelPercent != null)
            {
                hash = hash * 59 + ServiceLevelPercent.GetHashCode();
            }

            if (AverageSpeedOfAnswerSeconds != null)
            {
                hash = hash * 59 + AverageSpeedOfAnswerSeconds.GetHashCode();
            }

            return hash;
        }
    }
}
