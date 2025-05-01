using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WfmBuScheduleTopicBuScheduleGenerationResultSummary
/// </summary>
[DataContract]
public partial class WfmBuScheduleTopicBuScheduleGenerationResultSummary : IEquatable<WfmBuScheduleTopicBuScheduleGenerationResultSummary>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="WfmBuScheduleTopicBuScheduleGenerationResultSummary" /> class.
    /// </summary>
    /// <param name="Failed">Failed.</param>
    /// <param name="RunId">RunId.</param>
    /// <param name="MessageCount">MessageCount.</param>
    /// <param name="MessageSeverityCounts">MessageSeverityCounts.</param>
    public WfmBuScheduleTopicBuScheduleGenerationResultSummary(bool? Failed = null, string RunId = null, long? MessageCount = null, List<WfmBuScheduleTopicSchedulerMessageSeverityCount> MessageSeverityCounts = null)
    {
        this.Failed = Failed;
        this.RunId = RunId;
        this.MessageCount = MessageCount;
        this.MessageSeverityCounts = MessageSeverityCounts;

    }



    /// <summary>
    /// Gets or Sets Failed
    /// </summary>
    [DataMember(Name = "failed", EmitDefaultValue = false)]
    public bool? Failed { get; set; }



    /// <summary>
    /// Gets or Sets RunId
    /// </summary>
    [DataMember(Name = "runId", EmitDefaultValue = false)]
    public string RunId { get; set; }



    /// <summary>
    /// Gets or Sets MessageCount
    /// </summary>
    [DataMember(Name = "messageCount", EmitDefaultValue = false)]
    public long? MessageCount { get; set; }



    /// <summary>
    /// Gets or Sets MessageSeverityCounts
    /// </summary>
    [DataMember(Name = "messageSeverityCounts", EmitDefaultValue = false)]
    public List<WfmBuScheduleTopicSchedulerMessageSeverityCount> MessageSeverityCounts { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WfmBuScheduleTopicBuScheduleGenerationResultSummary {\n");

        sb.Append("  Failed: ").Append(Failed).Append("\n");
        sb.Append("  RunId: ").Append(RunId).Append("\n");
        sb.Append("  MessageCount: ").Append(MessageCount).Append("\n");
        sb.Append("  MessageSeverityCounts: ").Append(MessageSeverityCounts).Append("\n");
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
        return Equals(obj as WfmBuScheduleTopicBuScheduleGenerationResultSummary);
    }

    /// <summary>
    /// Returns true if WfmBuScheduleTopicBuScheduleGenerationResultSummary instances are equal
    /// </summary>
    /// <param name="other">Instance of WfmBuScheduleTopicBuScheduleGenerationResultSummary to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WfmBuScheduleTopicBuScheduleGenerationResultSummary other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Failed == other.Failed ||
                Failed != null &&
                Failed.Equals(other.Failed)
            ) &&
            (
                RunId == other.RunId ||
                RunId != null &&
                RunId.Equals(other.RunId)
            ) &&
            (
                MessageCount == other.MessageCount ||
                MessageCount != null &&
                MessageCount.Equals(other.MessageCount)
            ) &&
            (
                MessageSeverityCounts == other.MessageSeverityCounts ||
                MessageSeverityCounts != null &&
                MessageSeverityCounts.SequenceEqual(other.MessageSeverityCounts)
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
            if (Failed != null)
            {
                hash = hash * 59 + Failed.GetHashCode();
            }

            if (RunId != null)
            {
                hash = hash * 59 + RunId.GetHashCode();
            }

            if (MessageCount != null)
            {
                hash = hash * 59 + MessageCount.GetHashCode();
            }

            if (MessageSeverityCounts != null)
            {
                hash = hash * 59 + MessageSeverityCounts.GetHashCode();
            }

            return hash;
        }
    }
}
