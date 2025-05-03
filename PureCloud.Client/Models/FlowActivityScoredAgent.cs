using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// FlowActivityScoredAgent
/// </summary>

public partial class FlowActivityScoredAgent : IEquatable<FlowActivityScoredAgent>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="FlowActivityScoredAgent" /> class.
    /// </summary>
    /// <param name="AgentScore">Assigned agent score for this conversation (0 - 100, higher being better).</param>
    /// <param name="ScoredAgentId">Unique identifier for the agent that was scored for this conversation.</param>
    public FlowActivityScoredAgent(int? AgentScore = null, string ScoredAgentId = null)
    {
        this.AgentScore = AgentScore;
        this.ScoredAgentId = ScoredAgentId;

    }



    /// <summary>
    /// Assigned agent score for this conversation (0 - 100, higher being better)
    /// </summary>
    /// <value>Assigned agent score for this conversation (0 - 100, higher being better)</value>
    [JsonPropertyName("agentScore")]
    public int? AgentScore { get; set; }



    /// <summary>
    /// Unique identifier for the agent that was scored for this conversation
    /// </summary>
    /// <value>Unique identifier for the agent that was scored for this conversation</value>
    [JsonPropertyName("scoredAgentId")]
    public string ScoredAgentId { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class FlowActivityScoredAgent {\n");

        sb.Append("  AgentScore: ").Append(AgentScore).Append("\n");
        sb.Append("  ScoredAgentId: ").Append(ScoredAgentId).Append("\n");
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
        return Equals(obj as FlowActivityScoredAgent);
    }

    /// <summary>
    /// Returns true if FlowActivityScoredAgent instances are equal
    /// </summary>
    /// <param name="other">Instance of FlowActivityScoredAgent to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(FlowActivityScoredAgent other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                AgentScore == other.AgentScore ||
                AgentScore != null &&
                AgentScore.Equals(other.AgentScore)
            ) &&
            (
                ScoredAgentId == other.ScoredAgentId ||
                ScoredAgentId != null &&
                ScoredAgentId.Equals(other.ScoredAgentId)
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
            if (AgentScore != null)
            {
                hash = hash * 59 + AgentScore.GetHashCode();
            }

            if (ScoredAgentId != null)
            {
                hash = hash * 59 + ScoredAgentId.GetHashCode();
            }

            return hash;
        }
    }
}
