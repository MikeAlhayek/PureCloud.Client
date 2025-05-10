namespace PureCloud.Client.Models.Analytics;

public sealed class AnalyticsScoredAgent
{
    /// <summary>
    /// Assigned agent score for this conversation (0 - 100, higher being better)
    /// </summary>
    /// <value>Assigned agent score for this conversation (0 - 100, higher being better)</value>
    public int? AgentScore { get; set; }

    /// <summary>
    /// Unique identifier for the agent that was scored for this conversation
    /// </summary>
    /// <value>Unique identifier for the agent that was scored for this conversation</value>
    public string ScoredAgentId { get; set; }
}
