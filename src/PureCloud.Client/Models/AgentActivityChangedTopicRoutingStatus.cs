using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class AgentActivityChangedTopicRoutingStatus
{
    /// <summary>
    /// Indicates the Routing State of the agent.
    /// </summary>
    /// <value>Indicates the Routing State of the agent.</value>
    public AgentActivityChangedTopicRoutingStatusStatusEnum? Status { get; set; }

    /// <summary>
    /// The timestamp when the agent went into this state.
    /// </summary>
    /// <value>The timestamp when the agent went into this state.</value>
    public DateTime? StartTime { get; set; }
}
