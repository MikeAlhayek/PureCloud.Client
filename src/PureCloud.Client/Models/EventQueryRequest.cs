namespace PureCloud.Client.Models;

/// <summary>
/// EventQueryRequest
/// </summary>
public sealed class EventQueryRequest
{
    /// <summary>
    /// Date and time range to query. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss
    /// </summary>
    public string Interval { get; set; }

    /// <summary>
    /// Event definition IDs to query
    /// </summary>
    public IEnumerable<string> EventDefinitionIds { get; set; }
}
