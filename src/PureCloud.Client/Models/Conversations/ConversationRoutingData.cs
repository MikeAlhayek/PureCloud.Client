namespace PureCloud.Client.Models;

public sealed class ConversationRoutingData
{
    /// <summary>
    /// The queue to use for routing decisions
    /// </summary>
    /// <value>The queue to use for routing decisions</value>
    public AddressableEntityRef Queue { get; set; }

    /// <summary>
    /// The language to use for routing decisions
    /// </summary>
    /// <value>The language to use for routing decisions</value>
    public AddressableEntityRef Language { get; set; }

    /// <summary>
    /// The priority of the conversation to use for routing decisions
    /// </summary>
    /// <value>The priority of the conversation to use for routing decisions</value>
    public int? Priority { get; set; }

    /// <summary>
    /// The skills to use for routing decisions
    /// </summary>
    /// <value>The skills to use for routing decisions</value>
    public IEnumerable<AddressableEntityRef> Skills { get; set; }

    /// <summary>
    /// A collection of agents and their assigned scores for this conversation (0 - 100, higher being better), for use in routing to preferred agents
    /// </summary>
    /// <value>A collection of agents and their assigned scores for this conversation (0 - 100, higher being better), for use in routing to preferred agents</value>
    public IEnumerable<ScoredAgent> ScoredAgents { get; set; }

    /// <summary>
    /// An optional label that categorizes the conversation.  Max-utilization settings can be configured at a per-label level
    /// </summary>
    /// <value>An optional label that categorizes the conversation.  Max-utilization settings can be configured at a per-label level</value>
    public string Label { get; set; }
}
