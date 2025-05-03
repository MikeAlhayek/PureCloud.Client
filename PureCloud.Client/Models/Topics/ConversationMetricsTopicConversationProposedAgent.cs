namespace PureCloud.Client.Models.Topics;

public sealed class ConversationMetricsTopicConversationProposedAgent
{
    /// <summary>
    /// Proposed agent rank for this conversation from predictive routing (lower is better)
    /// </summary>
    /// <value>Proposed agent rank for this conversation from predictive routing (lower is better)</value>
    public long? AgentRank { get; set; }

    /// <summary>
    /// Unique identifier for the agent that was proposed by predictive routing
    /// </summary>
    /// <value>Unique identifier for the agent that was proposed by predictive routing</value>
    public string ProposedAgentId { get; set; }
}
