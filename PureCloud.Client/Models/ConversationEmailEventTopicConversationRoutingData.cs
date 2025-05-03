using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ConversationEmailEventTopicConversationRoutingData
/// </summary>

public partial class ConversationEmailEventTopicConversationRoutingData : IEquatable<ConversationEmailEventTopicConversationRoutingData>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ConversationEmailEventTopicConversationRoutingData" /> class.
    /// </summary>
    /// <param name="Queue">A UriReference for a resource.</param>
    /// <param name="Language">A UriReference for a resource.</param>
    /// <param name="Priority">The priority of the conversation to use for routing decisions.</param>
    /// <param name="Skills">The skills to use for routing decisions.</param>
    /// <param name="ScoredAgents">A collection of agents and their assigned scores for this conversation (0 - 100, higher being better), for use in routing to preferred agents.</param>
    public ConversationEmailEventTopicConversationRoutingData(ConversationEmailEventTopicUriReference Queue = null, ConversationEmailEventTopicUriReference Language = null, long? Priority = null, List<ConversationEmailEventTopicUriReference> Skills = null, List<ConversationEmailEventTopicScoredAgent> ScoredAgents = null)
    {
        this.Queue = Queue;
        this.Language = Language;
        this.Priority = Priority;
        this.Skills = Skills;
        this.ScoredAgents = ScoredAgents;

    }



    /// <summary>
    /// A UriReference for a resource
    /// </summary>
    /// <value>A UriReference for a resource</value>
    [JsonPropertyName("queue")]
    public ConversationEmailEventTopicUriReference Queue { get; set; }



    /// <summary>
    /// A UriReference for a resource
    /// </summary>
    /// <value>A UriReference for a resource</value>
    [JsonPropertyName("language")]
    public ConversationEmailEventTopicUriReference Language { get; set; }



    /// <summary>
    /// The priority of the conversation to use for routing decisions
    /// </summary>
    /// <value>The priority of the conversation to use for routing decisions</value>
    [JsonPropertyName("priority")]
    public long? Priority { get; set; }



    /// <summary>
    /// The skills to use for routing decisions
    /// </summary>
    /// <value>The skills to use for routing decisions</value>
    [JsonPropertyName("skills")]
    public List<ConversationEmailEventTopicUriReference> Skills { get; set; }



    /// <summary>
    /// A collection of agents and their assigned scores for this conversation (0 - 100, higher being better), for use in routing to preferred agents
    /// </summary>
    /// <value>A collection of agents and their assigned scores for this conversation (0 - 100, higher being better), for use in routing to preferred agents</value>
    [JsonPropertyName("scoredAgents")]
    public List<ConversationEmailEventTopicScoredAgent> ScoredAgents { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ConversationEmailEventTopicConversationRoutingData {\n");

        sb.Append("  Queue: ").Append(Queue).Append("\n");
        sb.Append("  Language: ").Append(Language).Append("\n");
        sb.Append("  Priority: ").Append(Priority).Append("\n");
        sb.Append("  Skills: ").Append(Skills).Append("\n");
        sb.Append("  ScoredAgents: ").Append(ScoredAgents).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }


    /// <summary>
    /// Returns true if objects are equal
    /// </summary>
    /// <param name="obj">Object to be compared</param>
    /// <returns>Boolean</returns>
    public override bool Equals(object obj)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        return Equals(obj as ConversationEmailEventTopicConversationRoutingData);
    }

    /// <summary>
    /// Returns true if ConversationEmailEventTopicConversationRoutingData instances are equal
    /// </summary>
    /// <param name="other">Instance of ConversationEmailEventTopicConversationRoutingData to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ConversationEmailEventTopicConversationRoutingData other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Queue == other.Queue ||
                Queue != null &&
                Queue.Equals(other.Queue)
            ) &&
            (
                Language == other.Language ||
                Language != null &&
                Language.Equals(other.Language)
            ) &&
            (
                Priority == other.Priority ||
                Priority != null &&
                Priority.Equals(other.Priority)
            ) &&
            (
                Skills == other.Skills ||
                Skills != null &&
                Skills.SequenceEqual(other.Skills)
            ) &&
            (
                ScoredAgents == other.ScoredAgents ||
                ScoredAgents != null &&
                ScoredAgents.SequenceEqual(other.ScoredAgents)
            );
    }

    /// <summary>
    /// Gets the hash code
    /// </summary>
    /// <returns>Hash code</returns>
    public override int GetHashCode()
    {
        // credit: http://stackoverflow.com/a/263416/677735
        unchecked // Overflow is fine, just wrap
        {
            int hash = 41;
            // Suitable nullity checks etc, of course :)
            if (Queue != null)
            {
                hash = hash * 59 + Queue.GetHashCode();
            }

            if (Language != null)
            {
                hash = hash * 59 + Language.GetHashCode();
            }

            if (Priority != null)
            {
                hash = hash * 59 + Priority.GetHashCode();
            }

            if (Skills != null)
            {
                hash = hash * 59 + Skills.GetHashCode();
            }

            if (ScoredAgents != null)
            {
                hash = hash * 59 + ScoredAgents.GetHashCode();
            }

            return hash;
        }
    }
}
