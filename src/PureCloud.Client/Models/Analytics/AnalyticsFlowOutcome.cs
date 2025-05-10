namespace PureCloud.Client.Models.Analytics;

public sealed class AnalyticsFlowOutcome
{
    /// <summary>
    /// Combination of unique flow outcome identifier and its value separated by colon
    /// </summary>
    /// <value>Combination of unique flow outcome identifier and its value separated by colon</value>
    public string FlowOutcome { get; set; }

    /// <summary>
    /// The outcome ending timestamp in ISO 8601 format. This may be null if the outcome did not succeed.
    /// </summary>
    /// <value>The outcome ending timestamp in ISO 8601 format. This may be null if the outcome did not succeed.</value>
    public DateTime? FlowOutcomeEndTimestamp { get; set; }

    /// <summary>
    /// Unique identifier of a flow outcome
    /// </summary>
    /// <value>Unique identifier of a flow outcome</value>
    public string FlowOutcomeId { get; set; }

    /// <summary>
    /// The outcome starting timestamp in ISO 8601 format
    /// </summary>
    /// <value>The outcome starting timestamp in ISO 8601 format</value>
    public DateTime? FlowOutcomeStartTimestamp { get; set; }

    /// <summary>
    /// Flow outcome value, e.g. SUCCESS
    /// </summary>
    /// <value>Flow outcome value, e.g. SUCCESS</value>
    public string FlowOutcomeValue { get; set; }
}
