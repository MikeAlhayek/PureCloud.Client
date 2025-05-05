using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// BidGroupWorkPlanRequest
/// </summary>

public partial class BidGroupWorkPlanRequest : IEquatable<BidGroupWorkPlanRequest>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="BidGroupWorkPlanRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected BidGroupWorkPlanRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="BidGroupWorkPlanRequest" /> class.
    /// </summary>
    /// <param name="WorkPlanId">The ID of the work plan used in the bid group (required).</param>
    /// <param name="OverrideAgentCount">The modified agent count for this work plan.</param>
    public BidGroupWorkPlanRequest(string WorkPlanId = null, int? OverrideAgentCount = null)
    {
        this.WorkPlanId = WorkPlanId;
        this.OverrideAgentCount = OverrideAgentCount;

    }



    /// <summary>
    /// The ID of the work plan used in the bid group
    /// </summary>
    /// <value>The ID of the work plan used in the bid group</value>
    [JsonPropertyName("workPlanId")]
    public string WorkPlanId { get; set; }



    /// <summary>
    /// The modified agent count for this work plan
    /// </summary>
    /// <value>The modified agent count for this work plan</value>
    [JsonPropertyName("overrideAgentCount")]
    public int? OverrideAgentCount { get; set; }



    /// <summary>
    /// The number of agents needed for this work plan to produce the optimal schedule
    /// </summary>
    /// <value>The number of agents needed for this work plan to produce the optimal schedule</value>
    [JsonPropertyName("suggestedAgentCount")]
    public int? SuggestedAgentCount { get; private set; }



    /// <summary>
    /// The range of agent slot count per work plan. The suggested slot count must be in agent count range
    /// </summary>
    /// <value>The range of agent slot count per work plan. The suggested slot count must be in agent count range</value>
    [JsonPropertyName("agentCountRange")]
    public AgentCountRange AgentCountRange { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class BidGroupWorkPlanRequest {\n");

        sb.Append("  WorkPlanId: ").Append(WorkPlanId).Append("\n");
        sb.Append("  OverrideAgentCount: ").Append(OverrideAgentCount).Append("\n");
        sb.Append("  SuggestedAgentCount: ").Append(SuggestedAgentCount).Append("\n");
        sb.Append("  AgentCountRange: ").Append(AgentCountRange).Append("\n");
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
        return Equals(obj as BidGroupWorkPlanRequest);
    }

    /// <summary>
    /// Returns true if BidGroupWorkPlanRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of BidGroupWorkPlanRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(BidGroupWorkPlanRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                WorkPlanId == other.WorkPlanId ||
                WorkPlanId != null &&
                WorkPlanId.Equals(other.WorkPlanId)
            ) &&
            (
                OverrideAgentCount == other.OverrideAgentCount ||
                OverrideAgentCount != null &&
                OverrideAgentCount.Equals(other.OverrideAgentCount)
            ) &&
            (
                SuggestedAgentCount == other.SuggestedAgentCount ||
                SuggestedAgentCount != null &&
                SuggestedAgentCount.Equals(other.SuggestedAgentCount)
            ) &&
            (
                AgentCountRange == other.AgentCountRange ||
                AgentCountRange != null &&
                AgentCountRange.Equals(other.AgentCountRange)
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
            if (WorkPlanId != null)
            {
                hash = hash * 59 + WorkPlanId.GetHashCode();
            }

            if (OverrideAgentCount != null)
            {
                hash = hash * 59 + OverrideAgentCount.GetHashCode();
            }

            if (SuggestedAgentCount != null)
            {
                hash = hash * 59 + SuggestedAgentCount.GetHashCode();
            }

            if (AgentCountRange != null)
            {
                hash = hash * 59 + AgentCountRange.GetHashCode();
            }

            return hash;
        }
    }
}
