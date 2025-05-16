using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class AgentActivityChangedTopicAgentActivity
{
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets RoutingStatus
    /// </summary>
    public AgentActivityChangedTopicRoutingStatus RoutingStatus { get; set; }

    /// <summary>
    /// Gets or Sets Presence
    /// </summary>
    public AgentActivityChangedTopicPresence Presence { get; set; }

    /// <summary>
    /// Gets or Sets OutOfOffice
    /// </summary>
    public AgentActivityChangedTopicOutOfOffice OutOfOffice { get; set; }

    /// <summary>
    /// Gets or Sets ActiveQueueIds
    /// </summary>
    public IEnumerable<string> ActiveQueueIds { get; set; }

    /// <summary>
    /// Gets or Sets DateActiveQueuesChanged
    /// </summary>
    public DateTime? DateActiveQueuesChanged { get; set; }
}
