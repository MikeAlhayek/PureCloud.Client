using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// FlowOutcomeDetailEventTopicFlowMilestone
/// </summary>

public partial class FlowOutcomeDetailEventTopicFlowMilestone : IEquatable<FlowOutcomeDetailEventTopicFlowMilestone>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="FlowOutcomeDetailEventTopicFlowMilestone" /> class.
    /// </summary>
    /// <param name="MilestoneId">MilestoneId.</param>
    /// <param name="MilestoneTime">MilestoneTime.</param>
    public FlowOutcomeDetailEventTopicFlowMilestone(Guid? MilestoneId = null, long? MilestoneTime = null)
    {
        this.MilestoneId = MilestoneId;
        this.MilestoneTime = MilestoneTime;

    }



    /// <summary>
    /// Gets or Sets MilestoneId
    /// </summary>
    [JsonPropertyName("milestoneId")]
    public Guid? MilestoneId { get; set; }



    /// <summary>
    /// Gets or Sets MilestoneTime
    /// </summary>
    [JsonPropertyName("milestoneTime")]
    public long? MilestoneTime { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class FlowOutcomeDetailEventTopicFlowMilestone {\n");

        sb.Append("  MilestoneId: ").Append(MilestoneId).Append("\n");
        sb.Append("  MilestoneTime: ").Append(MilestoneTime).Append("\n");
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
        return Equals(obj as FlowOutcomeDetailEventTopicFlowMilestone);
    }

    /// <summary>
    /// Returns true if FlowOutcomeDetailEventTopicFlowMilestone instances are equal
    /// </summary>
    /// <param name="other">Instance of FlowOutcomeDetailEventTopicFlowMilestone to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(FlowOutcomeDetailEventTopicFlowMilestone other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                MilestoneId == other.MilestoneId ||
                MilestoneId != null &&
                MilestoneId.Equals(other.MilestoneId)
            ) &&
            (
                MilestoneTime == other.MilestoneTime ||
                MilestoneTime != null &&
                MilestoneTime.Equals(other.MilestoneTime)
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
            if (MilestoneId != null)
            {
                hash = hash * 59 + MilestoneId.GetHashCode();
            }

            if (MilestoneTime != null)
            {
                hash = hash * 59 + MilestoneTime.GetHashCode();
            }

            return hash;
        }
    }
}
