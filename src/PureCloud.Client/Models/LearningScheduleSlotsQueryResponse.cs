using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// LearningScheduleSlotsQueryResponse
/// </summary>

public partial class LearningScheduleSlotsQueryResponse : IEquatable<LearningScheduleSlotsQueryResponse>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="LearningScheduleSlotsQueryResponse" /> class.
    /// </summary>
    /// <param name="SuggestedSlots">List of slots where Learning activity can be scheduled.</param>
    /// <param name="WfmScheduleActivities">Detailed data for WFM scheduled activities.</param>
    public LearningScheduleSlotsQueryResponse(List<LearningSlot> SuggestedSlots = null, List<LearningSlotWfmScheduleActivity> WfmScheduleActivities = null)
    {
        this.SuggestedSlots = SuggestedSlots;
        this.WfmScheduleActivities = WfmScheduleActivities;

    }



    /// <summary>
    /// List of slots where Learning activity can be scheduled
    /// </summary>
    /// <value>List of slots where Learning activity can be scheduled</value>
    [JsonPropertyName("suggestedSlots")]
    public List<LearningSlot> SuggestedSlots { get; set; }



    /// <summary>
    /// Detailed data for WFM scheduled activities
    /// </summary>
    /// <value>Detailed data for WFM scheduled activities</value>
    [JsonPropertyName("wfmScheduleActivities")]
    public List<LearningSlotWfmScheduleActivity> WfmScheduleActivities { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class LearningScheduleSlotsQueryResponse {\n");

        sb.Append("  SuggestedSlots: ").Append(SuggestedSlots).Append("\n");
        sb.Append("  WfmScheduleActivities: ").Append(WfmScheduleActivities).Append("\n");
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
        return Equals(obj as LearningScheduleSlotsQueryResponse);
    }

    /// <summary>
    /// Returns true if LearningScheduleSlotsQueryResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of LearningScheduleSlotsQueryResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(LearningScheduleSlotsQueryResponse other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                SuggestedSlots == other.SuggestedSlots ||
                SuggestedSlots != null &&
                SuggestedSlots.SequenceEqual(other.SuggestedSlots)
            ) &&
            (
                WfmScheduleActivities == other.WfmScheduleActivities ||
                WfmScheduleActivities != null &&
                WfmScheduleActivities.SequenceEqual(other.WfmScheduleActivities)
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
            if (SuggestedSlots != null)
            {
                hash = hash * 59 + SuggestedSlots.GetHashCode();
            }

            if (WfmScheduleActivities != null)
            {
                hash = hash * 59 + WfmScheduleActivities.GetHashCode();
            }

            return hash;
        }
    }
}
