using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// BidGroupWorkPlanResponse
/// </summary>

public partial class BidGroupWorkPlanResponse : IEquatable<BidGroupWorkPlanResponse>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BidGroupWorkPlanResponse" /> class.
    /// </summary>
    /// <param name="ManagementUnit">The management unit to which this work plan belongs.  Nullable in some routes.</param>
    /// <param name="OverrideAgentCount">The modified agent count for this work plan.</param>
    public BidGroupWorkPlanResponse(ManagementUnitReference ManagementUnit = null, int? OverrideAgentCount = null)
    {
        this.ManagementUnit = ManagementUnit;
        this.OverrideAgentCount = OverrideAgentCount;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// The management unit to which this work plan belongs.  Nullable in some routes
    /// </summary>
    /// <value>The management unit to which this work plan belongs.  Nullable in some routes</value>
    [JsonPropertyName("managementUnit")]
    public ManagementUnitReference ManagementUnit { get; set; }



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
    public int? SuggestedAgentCount { get; set; }



    /// <summary>
    /// The range of agent slot count per work plan. The suggested slot count must be in agent count range
    /// </summary>
    /// <value>The range of agent slot count per work plan. The suggested slot count must be in agent count range</value>
    [JsonPropertyName("agentCountRange")]
    public AgentCountRange AgentCountRange { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class BidGroupWorkPlanResponse {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  ManagementUnit: ").Append(ManagementUnit).Append("\n");
        sb.Append("  OverrideAgentCount: ").Append(OverrideAgentCount).Append("\n");
        sb.Append("  SuggestedAgentCount: ").Append(SuggestedAgentCount).Append("\n");
        sb.Append("  AgentCountRange: ").Append(AgentCountRange).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
        return Equals(obj as BidGroupWorkPlanResponse);
    }

    /// <summary>
    /// Returns true if BidGroupWorkPlanResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of BidGroupWorkPlanResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(BidGroupWorkPlanResponse other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Id == other.Id ||
                Id != null &&
                Id.Equals(other.Id)
            ) &&
            (
                ManagementUnit == other.ManagementUnit ||
                ManagementUnit != null &&
                ManagementUnit.Equals(other.ManagementUnit)
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
            ) &&
            (
                SelfUri == other.SelfUri ||
                SelfUri != null &&
                SelfUri.Equals(other.SelfUri)
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
            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            if (ManagementUnit != null)
            {
                hash = hash * 59 + ManagementUnit.GetHashCode();
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

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
