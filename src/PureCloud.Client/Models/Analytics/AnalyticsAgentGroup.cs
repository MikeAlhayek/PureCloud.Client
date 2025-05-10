namespace PureCloud.Client.Models.Analytics;

public sealed class AnalyticsAgentGroup
{
    /// <summary>
    /// Conditional group routing agent group type
    /// </summary>
    /// <value>Conditional group routing agent group type</value>
    public AgentGroupType? AgentGroupType { get; set; }

    /// <summary>
    /// Conditional group routing agent group identifier
    /// </summary>
    /// <value>Conditional group routing agent group identifier</value>
    public string AgentGroupId { get; set; }
}
