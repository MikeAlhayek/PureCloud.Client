namespace PureCloud.Client.Models.Analytics;

/// <summary>
/// AnalyticsProposedAgent
/// </summary>

public sealed class AnalyticsProposedAgent
{
    /// <summary>
    /// Proposed agent rank for this conversation from predictive routing (lower is better)
    /// </summary>
    /// <value>Proposed agent rank for this conversation from predictive routing (lower is better)</value>
    public int? AgentRank { get; set; }

    /// <summary>
    /// Unique identifier for the agent that was proposed by predictive routing
    /// </summary>
    /// <value>Unique identifier for the agent that was proposed by predictive routing</value>
    public string ProposedAgentId { get; set; }
}
