using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ConversationCallEventTopicConversationRoutingData
/// </summary>
[DataContract]
public partial class ConversationCallEventTopicConversationRoutingData : IEquatable<ConversationCallEventTopicConversationRoutingData>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ConversationCallEventTopicConversationRoutingData" /> class.
    /// </summary>
    /// <param name="Queue">A UriReference for a resource.</param>
    /// <param name="Language">A UriReference for a resource.</param>
    /// <param name="Priority">The priority of the conversation to use for routing decisions.</param>
    /// <param name="Skills">The skills to use for routing decisions.</param>
    /// <param name="ScoredAgents">A collection of agents and their assigned scores for this conversation (0 - 100, higher being better), for use in routing to preferred agents.</param>
    public ConversationCallEventTopicConversationRoutingData(ConversationCallEventTopicUriReference Queue = null, ConversationCallEventTopicUriReference Language = null, long? Priority = null, List<ConversationCallEventTopicUriReference> Skills = null, List<ConversationCallEventTopicScoredAgent> ScoredAgents = null)
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
    [DataMember(Name = "queue", EmitDefaultValue = false)]
    public ConversationCallEventTopicUriReference Queue { get; set; }



    /// <summary>
    /// A UriReference for a resource
    /// </summary>
    /// <value>A UriReference for a resource</value>
    [DataMember(Name = "language", EmitDefaultValue = false)]
    public ConversationCallEventTopicUriReference Language { get; set; }



    /// <summary>
    /// The priority of the conversation to use for routing decisions
    /// </summary>
    /// <value>The priority of the conversation to use for routing decisions</value>
    [DataMember(Name = "priority", EmitDefaultValue = false)]
    public long? Priority { get; set; }



    /// <summary>
    /// The skills to use for routing decisions
    /// </summary>
    /// <value>The skills to use for routing decisions</value>
    [DataMember(Name = "skills", EmitDefaultValue = false)]
    public List<ConversationCallEventTopicUriReference> Skills { get; set; }



    /// <summary>
    /// A collection of agents and their assigned scores for this conversation (0 - 100, higher being better), for use in routing to preferred agents
    /// </summary>
    /// <value>A collection of agents and their assigned scores for this conversation (0 - 100, higher being better), for use in routing to preferred agents</value>
    [DataMember(Name = "scoredAgents", EmitDefaultValue = false)]
    public List<ConversationCallEventTopicScoredAgent> ScoredAgents { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ConversationCallEventTopicConversationRoutingData {\n");

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
        return Equals(obj as ConversationCallEventTopicConversationRoutingData);
    }

    /// <summary>
    /// Returns true if ConversationCallEventTopicConversationRoutingData instances are equal
    /// </summary>
    /// <param name="other">Instance of ConversationCallEventTopicConversationRoutingData to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ConversationCallEventTopicConversationRoutingData other)
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
