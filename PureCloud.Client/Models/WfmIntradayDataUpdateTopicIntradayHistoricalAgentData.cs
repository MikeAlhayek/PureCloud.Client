using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WfmIntradayDataUpdateTopicIntradayHistoricalAgentData
/// </summary>
[DataContract]
public partial class WfmIntradayDataUpdateTopicIntradayHistoricalAgentData : IEquatable<WfmIntradayDataUpdateTopicIntradayHistoricalAgentData>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="WfmIntradayDataUpdateTopicIntradayHistoricalAgentData" /> class.
    /// </summary>
    /// <param name="OnQueueTimeSeconds">OnQueueTimeSeconds.</param>
    /// <param name="InteractingTimeSeconds">InteractingTimeSeconds.</param>
    public WfmIntradayDataUpdateTopicIntradayHistoricalAgentData(double? OnQueueTimeSeconds = null, double? InteractingTimeSeconds = null)
    {
        this.OnQueueTimeSeconds = OnQueueTimeSeconds;
        this.InteractingTimeSeconds = InteractingTimeSeconds;

    }



    /// <summary>
    /// Gets or Sets OnQueueTimeSeconds
    /// </summary>
    [DataMember(Name = "onQueueTimeSeconds", EmitDefaultValue = false)]
    public double? OnQueueTimeSeconds { get; set; }



    /// <summary>
    /// Gets or Sets InteractingTimeSeconds
    /// </summary>
    [DataMember(Name = "interactingTimeSeconds", EmitDefaultValue = false)]
    public double? InteractingTimeSeconds { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WfmIntradayDataUpdateTopicIntradayHistoricalAgentData {\n");

        sb.Append("  OnQueueTimeSeconds: ").Append(OnQueueTimeSeconds).Append("\n");
        sb.Append("  InteractingTimeSeconds: ").Append(InteractingTimeSeconds).Append("\n");
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
        return Equals(obj as WfmIntradayDataUpdateTopicIntradayHistoricalAgentData);
    }

    /// <summary>
    /// Returns true if WfmIntradayDataUpdateTopicIntradayHistoricalAgentData instances are equal
    /// </summary>
    /// <param name="other">Instance of WfmIntradayDataUpdateTopicIntradayHistoricalAgentData to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WfmIntradayDataUpdateTopicIntradayHistoricalAgentData other)
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
            ) &&
            (
                InteractingTimeSeconds == other.InteractingTimeSeconds ||
                InteractingTimeSeconds != null &&
                InteractingTimeSeconds.Equals(other.InteractingTimeSeconds)
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

            if (InteractingTimeSeconds != null)
            {
                hash = hash * 59 + InteractingTimeSeconds.GetHashCode();
            }

            return hash;
        }
    }
}
