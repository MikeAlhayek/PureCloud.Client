namespace PureCloud.Client.Models;

/// <summary>
/// EventAggregatesQueryRequest
/// </summary>
public sealed class EventAggregatesQueryRequest
{
    /// <summary>
    /// Date and time range to query. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss
    /// </summary>
    public string Interval { get; set; }
}
