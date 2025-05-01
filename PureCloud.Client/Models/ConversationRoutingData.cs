using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// ConversationRoutingData
/// </summary>
[DataContract]
public partial class ConversationRoutingData : IEquatable<ConversationRoutingData>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ConversationRoutingData" /> class.
    /// </summary>
    /// <param name="Queue">The queue to use for routing decisions.</param>
    /// <param name="Language">The language to use for routing decisions.</param>
    /// <param name="Priority">The priority of the conversation to use for routing decisions.</param>
    /// <param name="Skills">The skills to use for routing decisions.</param>
    /// <param name="ScoredAgents">A collection of agents and their assigned scores for this conversation (0 - 100, higher being better), for use in routing to preferred agents.</param>
    /// <param name="Label">An optional label that categorizes the conversation.  Max-utilization settings can be configured at a per-label level.</param>
    public ConversationRoutingData(AddressableEntityRef Queue = null, AddressableEntityRef Language = null, int? Priority = null, List<AddressableEntityRef> Skills = null, List<ScoredAgent> ScoredAgents = null, string Label = null)
    {
        this.Queue = Queue;
        this.Language = Language;
        this.Priority = Priority;
        this.Skills = Skills;
        this.ScoredAgents = ScoredAgents;
        this.Label = Label;

    }



    /// <summary>
    /// The queue to use for routing decisions
    /// </summary>
    /// <value>The queue to use for routing decisions</value>
    [DataMember(Name = "queue", EmitDefaultValue = false)]
    public AddressableEntityRef Queue { get; set; }



    /// <summary>
    /// The language to use for routing decisions
    /// </summary>
    /// <value>The language to use for routing decisions</value>
    [DataMember(Name = "language", EmitDefaultValue = false)]
    public AddressableEntityRef Language { get; set; }



    /// <summary>
    /// The priority of the conversation to use for routing decisions
    /// </summary>
    /// <value>The priority of the conversation to use for routing decisions</value>
    [DataMember(Name = "priority", EmitDefaultValue = false)]
    public int? Priority { get; set; }



    /// <summary>
    /// The skills to use for routing decisions
    /// </summary>
    /// <value>The skills to use for routing decisions</value>
    [DataMember(Name = "skills", EmitDefaultValue = false)]
    public List<AddressableEntityRef> Skills { get; set; }



    /// <summary>
    /// A collection of agents and their assigned scores for this conversation (0 - 100, higher being better), for use in routing to preferred agents
    /// </summary>
    /// <value>A collection of agents and their assigned scores for this conversation (0 - 100, higher being better), for use in routing to preferred agents</value>
    [DataMember(Name = "scoredAgents", EmitDefaultValue = false)]
    public List<ScoredAgent> ScoredAgents { get; set; }



    /// <summary>
    /// An optional label that categorizes the conversation.  Max-utilization settings can be configured at a per-label level
    /// </summary>
    /// <value>An optional label that categorizes the conversation.  Max-utilization settings can be configured at a per-label level</value>
    [DataMember(Name = "label", EmitDefaultValue = false)]
    public string Label { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ConversationRoutingData {\n");

        sb.Append("  Queue: ").Append(Queue).Append("\n");
        sb.Append("  Language: ").Append(Language).Append("\n");
        sb.Append("  Priority: ").Append(Priority).Append("\n");
        sb.Append("  Skills: ").Append(Skills).Append("\n");
        sb.Append("  ScoredAgents: ").Append(ScoredAgents).Append("\n");
        sb.Append("  Label: ").Append(Label).Append("\n");
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
        return Equals(obj as ConversationRoutingData);
    }

    /// <summary>
    /// Returns true if ConversationRoutingData instances are equal
    /// </summary>
    /// <param name="other">Instance of ConversationRoutingData to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ConversationRoutingData other)
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
            ) &&
            (
                Label == other.Label ||
                Label != null &&
                Label.Equals(other.Label)
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

            if (Label != null)
            {
                hash = hash * 59 + Label.GetHashCode();
            }

            return hash;
        }
    }
}
