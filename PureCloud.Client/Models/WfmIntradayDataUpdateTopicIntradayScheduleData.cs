using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WfmIntradayDataUpdateTopicIntradayScheduleData
/// </summary>
[DataContract]
public partial class WfmIntradayDataUpdateTopicIntradayScheduleData : IEquatable<WfmIntradayDataUpdateTopicIntradayScheduleData>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="WfmIntradayDataUpdateTopicIntradayScheduleData" /> class.
    /// </summary>
    /// <param name="OnQueueTimeSeconds">OnQueueTimeSeconds.</param>
    /// <param name="ScheduledTimeSeconds">ScheduledTimeSeconds.</param>
    public WfmIntradayDataUpdateTopicIntradayScheduleData(long? OnQueueTimeSeconds = null, long? ScheduledTimeSeconds = null)
    {
        this.OnQueueTimeSeconds = OnQueueTimeSeconds;
        this.ScheduledTimeSeconds = ScheduledTimeSeconds;

    }



    /// <summary>
    /// Gets or Sets OnQueueTimeSeconds
    /// </summary>
    [DataMember(Name = "onQueueTimeSeconds", EmitDefaultValue = false)]
    public long? OnQueueTimeSeconds { get; set; }



    /// <summary>
    /// Gets or Sets ScheduledTimeSeconds
    /// </summary>
    [DataMember(Name = "scheduledTimeSeconds", EmitDefaultValue = false)]
    public long? ScheduledTimeSeconds { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WfmIntradayDataUpdateTopicIntradayScheduleData {\n");

        sb.Append("  OnQueueTimeSeconds: ").Append(OnQueueTimeSeconds).Append("\n");
        sb.Append("  ScheduledTimeSeconds: ").Append(ScheduledTimeSeconds).Append("\n");
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
        return this.Equals(obj as WfmIntradayDataUpdateTopicIntradayScheduleData);
    }

    /// <summary>
    /// Returns true if WfmIntradayDataUpdateTopicIntradayScheduleData instances are equal
    /// </summary>
    /// <param name="other">Instance of WfmIntradayDataUpdateTopicIntradayScheduleData to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WfmIntradayDataUpdateTopicIntradayScheduleData other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                this.OnQueueTimeSeconds == other.OnQueueTimeSeconds ||
                this.OnQueueTimeSeconds != null &&
                this.OnQueueTimeSeconds.Equals(other.OnQueueTimeSeconds)
            ) &&
            (
                this.ScheduledTimeSeconds == other.ScheduledTimeSeconds ||
                this.ScheduledTimeSeconds != null &&
                this.ScheduledTimeSeconds.Equals(other.ScheduledTimeSeconds)
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
            if (this.OnQueueTimeSeconds != null)
            {
                hash = hash * 59 + this.OnQueueTimeSeconds.GetHashCode();
            }

            if (this.ScheduledTimeSeconds != null)
            {
                hash = hash * 59 + this.ScheduledTimeSeconds.GetHashCode();
            }

            return hash;
        }
    }
}
