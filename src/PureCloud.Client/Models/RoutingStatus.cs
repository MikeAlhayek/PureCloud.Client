namespace PureCloud.Client.Models;

public sealed class RoutingStatus
{
    /// <summary>
    /// Indicates the Routing State of the agent.  A value of OFF_QUEUE will be returned if the specified user does not exist.
    /// </summary>
    /// <value>Indicates the Routing State of the agent.  A value of OFF_QUEUE will be returned if the specified user does not exist.</value>
    public RoutingStatusEnum? Status { get; set; }

    /// <summary>
    /// The userId of the agent
    /// </summary>
    /// <value>The userId of the agent</value>
    public string UserId { get; set; }

    /// <summary>
    /// The timestamp when the agent went into this state. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The timestamp when the agent went into this state. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? StartTime { get; set; }
}
