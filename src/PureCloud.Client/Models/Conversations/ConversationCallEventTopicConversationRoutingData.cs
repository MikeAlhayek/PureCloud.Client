using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models.Conversations;

public sealed class ConversationCallEventTopicConversationRoutingData
{
    /// <summary>
    /// A UriReference for a resource
    /// </summary>
    /// <value>A UriReference for a resource</value>
    public ConversationCallEventTopicUriReference Queue { get; set; }


    /// <summary>
    /// A UriReference for a resource
    /// </summary>
    /// <value>A UriReference for a resource</value>
    public ConversationCallEventTopicUriReference Language { get; set; }


    /// <summary>
    /// The priority of the conversation to use for routing decisions
    /// </summary>
    /// <value>The priority of the conversation to use for routing decisions</value>
    public long? Priority { get; set; }


    /// <summary>
    /// The skills to use for routing decisions
    /// </summary>
    /// <value>The skills to use for routing decisions</value>
    public IEnumerable<ConversationCallEventTopicUriReference> Skills { get; set; }


    /// <summary>
    /// A collection of agents and their assigned scores for this conversation (0 - 100, higher being better), for use in routing to preferred agents
    /// </summary>
    /// <value>A collection of agents and their assigned scores for this conversation (0 - 100, higher being better), for use in routing to preferred agents</value>
    public IEnumerable<ConversationCallEventTopicScoredAgent> ScoredAgents { get; set; }
}
