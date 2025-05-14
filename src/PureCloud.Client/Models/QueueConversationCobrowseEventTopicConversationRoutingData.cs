using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class QueueConversationCobrowseEventTopicConversationRoutingData
{
    /// <summary>
    /// A UriReference for a resource
    /// </summary>
    /// <value>A UriReference for a resource</value>
    public QueueConversationCobrowseEventTopicUriReference Queue { get; set; }

    /// <summary>
    /// A UriReference for a resource
    /// </summary>
    /// <value>A UriReference for a resource</value>
    public QueueConversationCobrowseEventTopicUriReference Language { get; set; }

    /// <summary>
    /// The priority of the conversation to use for routing decisions
    /// </summary>
    /// <value>The priority of the conversation to use for routing decisions</value>
    public long? Priority { get; set; }

    /// <summary>
    /// The skills to use for routing decisions
    /// </summary>
    /// <value>The skills to use for routing decisions</value>
    public IEnumerable<QueueConversationCobrowseEventTopicUriReference> Skills { get; set; }

    /// <summary>
    /// A collection of agents and their assigned scores for this conversation (0 - 100, higher being better), for use in routing to preferred agents
    /// </summary>
    /// <value>A collection of agents and their assigned scores for this conversation (0 - 100, higher being better), for use in routing to preferred agents</value>
    public IEnumerable<QueueConversationCobrowseEventTopicScoredAgent> ScoredAgents { get; set; }
}
