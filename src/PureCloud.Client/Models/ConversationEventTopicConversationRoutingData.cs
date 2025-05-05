namespace PureCloud.Client.Models;

/// <summary>
/// Information on how a communication should be routed to an agent.
/// </summary>

public sealed class ConversationEventTopicConversationRoutingData
{
    /// <summary>
    /// Gets or Sets Queue
    /// </summary>
    public ConversationEventTopicUriReference Queue { get; set; }

    /// <summary>
    /// A UriReference for a resource
    /// </summary>
    /// <value>A UriReference for a resource</value>
    public ConversationEventTopicUriReference Language { get; set; }

    /// <summary>
    /// The priority of the conversation to use for routing decisions
    /// </summary>
    /// <value>The priority of the conversation to use for routing decisions</value>
    public long? Priority { get; set; }

    /// <summary>
    /// The skills to use for routing decisions
    /// </summary>
    /// <value>The skills to use for routing decisions</value>
    public IEnumerable<ConversationEventTopicUriReference> Skills { get; set; }

    /// <summary>
    /// A collection of agents and their assigned scores for this conversation (0 - 100, higher being better), for use in routing to preferred agents
    /// </summary>
    /// <value>A collection of agents and their assigned scores for this conversation (0 - 100, higher being better), for use in routing to preferred agents</value>
    public IEnumerable<ConversationEventTopicScoredAgent> ScoredAgents { get; set; }
}
