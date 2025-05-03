using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// FlowMetricsTopicFlowProposedAgent
/// </summary>

public partial class FlowMetricsTopicFlowProposedAgent : IEquatable<FlowMetricsTopicFlowProposedAgent>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="FlowMetricsTopicFlowProposedAgent" /> class.
    /// </summary>
    /// <param name="AgentRank">Proposed agent rank for this conversation from predictive routing (lower is better).</param>
    /// <param name="ProposedAgentId">Unique identifier for the agent that was proposed by predictive routing.</param>
    public FlowMetricsTopicFlowProposedAgent(long? AgentRank = null, string ProposedAgentId = null)
    {
        this.AgentRank = AgentRank;
        this.ProposedAgentId = ProposedAgentId;

    }



    /// <summary>
    /// Proposed agent rank for this conversation from predictive routing (lower is better)
    /// </summary>
    /// <value>Proposed agent rank for this conversation from predictive routing (lower is better)</value>
    [JsonPropertyName("agentRank")]
    public long? AgentRank { get; set; }



    /// <summary>
    /// Unique identifier for the agent that was proposed by predictive routing
    /// </summary>
    /// <value>Unique identifier for the agent that was proposed by predictive routing</value>
    [JsonPropertyName("proposedAgentId")]
    public string ProposedAgentId { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class FlowMetricsTopicFlowProposedAgent {\n");

        sb.Append("  AgentRank: ").Append(AgentRank).Append("\n");
        sb.Append("  ProposedAgentId: ").Append(ProposedAgentId).Append("\n");
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
        return Equals(obj as FlowMetricsTopicFlowProposedAgent);
    }

    /// <summary>
    /// Returns true if FlowMetricsTopicFlowProposedAgent instances are equal
    /// </summary>
    /// <param name="other">Instance of FlowMetricsTopicFlowProposedAgent to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(FlowMetricsTopicFlowProposedAgent other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                AgentRank == other.AgentRank ||
                AgentRank != null &&
                AgentRank.Equals(other.AgentRank)
            ) &&
            (
                ProposedAgentId == other.ProposedAgentId ||
                ProposedAgentId != null &&
                ProposedAgentId.Equals(other.ProposedAgentId)
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
            if (AgentRank != null)
            {
                hash = hash * 59 + AgentRank.GetHashCode();
            }

            if (ProposedAgentId != null)
            {
                hash = hash * 59 + ProposedAgentId.GetHashCode();
            }

            return hash;
        }
    }
}
