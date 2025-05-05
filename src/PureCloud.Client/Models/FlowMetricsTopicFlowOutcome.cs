namespace PureCloud.Client.Models;

/// <summary>
/// FlowMetricsTopicFlowOutcome
/// </summary>

public sealed class FlowMetricsTopicFlowOutcome
{
    /// <summary>
    /// Combination of unique flow outcome identifier and its value separated by colon
    /// </summary>
    /// <value>Combination of unique flow outcome identifier and its value separated by colon</value>
    public string FlowOutcome { get; set; }

    /// <summary>
    /// Unique identifier of a flow outcome
    /// </summary>
    /// <value>Unique identifier of a flow outcome</value>
    public string FlowOutcomeId { get; set; }

    /// <summary>
    /// Flow outcome value, e.g. SUCCESS
    /// </summary>
    /// <value>Flow outcome value, e.g. SUCCESS</value>
    public string FlowOutcomeValue { get; set; }
}
