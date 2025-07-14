using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class UserRoutingStatusEvent
{
    /// <summary>
    /// The agent's current routing status.
    /// </summary>
    /// <value>The agent's current routing status.</value>
    public UserRoutingStatusEventStatusEnum? Status { get; set; }

    /// <summary>
    /// A unique (UUID) eventId for this event
    /// </summary>
    /// <value>A unique (UUID) eventId for this event</value>
    public string EventId { get; set; }

    /// <summary>
    /// A timestamp as epoch representing the time this event occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>A timestamp as epoch representing the time this event occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? EventDateTime { get; set; }

    /// <summary>
    /// Unique identifier of the agent.
    /// </summary>
    /// <value>Unique identifier of the agent.</value>
    public string AgentId { get; set; }

    /// <summary>
    /// The agent&#39;s source platform Id.
    /// </summary>
    /// <value>The agent&#39;s source platform Id.</value>
    public string SourceId { get; set; }
}
