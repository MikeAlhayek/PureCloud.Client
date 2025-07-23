namespace PureCloud.Client.Models;

/// <summary>
/// EventAggregatesResponse
/// </summary>
public sealed class EventAggregatesResponse
{
    /// <summary>
    /// Interval for returned aggregates. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss
    /// </summary>
    public string Interval { get; set; }

    /// <summary>
    /// Aggregates by event definition
    /// </summary>
    public IEnumerable<EventDefinitionAggregates> EventDefinitionAggregates { get; set; }
}
