namespace PureCloud.Client.Models;

public sealed class LogCaptureQueryRequest
{
    /// <summary>
    /// Order of results. Default order is ASC.
    /// </summary>
    public LogCaptureQueryRequestSortOrder? SortOrder { get; set; }

    /// <summary>
    /// Date and time range to query. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss
    /// </summary>
    public string Interval { get; set; }

    /// <summary>
    /// Id of the user to query.
    /// </summary>
    public string UserId { get; set; }
}
