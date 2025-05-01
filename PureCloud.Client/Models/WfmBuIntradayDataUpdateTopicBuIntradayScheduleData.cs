using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// WfmBuIntradayDataUpdateTopicBuIntradayScheduleData
/// </summary>
[DataContract]
public partial class WfmBuIntradayDataUpdateTopicBuIntradayScheduleData : IEquatable<WfmBuIntradayDataUpdateTopicBuIntradayScheduleData>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="WfmBuIntradayDataUpdateTopicBuIntradayScheduleData" /> class.
    /// </summary>
    /// <param name="OnQueueTimeSeconds">OnQueueTimeSeconds.</param>
    public WfmBuIntradayDataUpdateTopicBuIntradayScheduleData(long? OnQueueTimeSeconds = null)
    {
        this.OnQueueTimeSeconds = OnQueueTimeSeconds;

    }



    /// <summary>
    /// Gets or Sets OnQueueTimeSeconds
    /// </summary>
    [DataMember(Name = "onQueueTimeSeconds", EmitDefaultValue = false)]
    public long? OnQueueTimeSeconds { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WfmBuIntradayDataUpdateTopicBuIntradayScheduleData {\n");

        sb.Append("  OnQueueTimeSeconds: ").Append(OnQueueTimeSeconds).Append("\n");
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
        return Equals(obj as WfmBuIntradayDataUpdateTopicBuIntradayScheduleData);
    }

    /// <summary>
    /// Returns true if WfmBuIntradayDataUpdateTopicBuIntradayScheduleData instances are equal
    /// </summary>
    /// <param name="other">Instance of WfmBuIntradayDataUpdateTopicBuIntradayScheduleData to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WfmBuIntradayDataUpdateTopicBuIntradayScheduleData other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                OnQueueTimeSeconds == other.OnQueueTimeSeconds ||
                OnQueueTimeSeconds != null &&
                OnQueueTimeSeconds.Equals(other.OnQueueTimeSeconds)
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
            if (OnQueueTimeSeconds != null)
            {
                hash = hash * 59 + OnQueueTimeSeconds.GetHashCode();
            }

            return hash;
        }
    }
}
