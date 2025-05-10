namespace PureCloud.Client.Models.Analytics;

public sealed class AnalyticsResolution
{
    /// <summary>
    /// Specifies when an event occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Specifies when an event occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? EventTime { get; set; }

    /// <summary>
    /// The ID of the last queue on which the conversation was handled.
    /// </summary>
    /// <value>The ID of the last queue on which the conversation was handled.</value>
    public string QueueId { get; set; }

    /// <summary>
    /// The ID of the last user who handled the conversation.
    /// </summary>
    /// <value>The ID of the last user who handled the conversation.</value>
    public string UserId { get; set; }

    /// <summary>
    /// Gets or Sets NNextContactAvoided
    /// </summary>
    public long? NNextContactAvoided { get; set; }
}
