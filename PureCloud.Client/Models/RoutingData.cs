using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// RoutingData
/// </summary>
[DataContract]
public partial class RoutingData : IEquatable<RoutingData>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="RoutingData" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected RoutingData() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="RoutingData" /> class.
    /// </summary>
    /// <param name="QueueId">The identifier of the routing queue (required).</param>
    /// <param name="LanguageId">The identifier of a language to be considered in routing.</param>
    /// <param name="Label">An optional label that categorizes the conversation.  Max-utilization settings can be configured at a per-label level.</param>
    /// <param name="Priority">The priority for routing.</param>
    /// <param name="SkillIds">A list of skill identifiers to be considered in routing.</param>
    /// <param name="PreferredAgentIds">A list of agents to be preferred in routing.</param>
    /// <param name="ScoredAgents">A list of scored agents for routing decisions. For Agent Owned Callbacks use one scored agent with a score of 100..</param>
    /// <param name="RoutingFlags">An array of flags indicating how the conversation should be routed. Use \&quot;AGENT_OWNED_CALLBACK\&quot; when creating an Agent Owned Callback..</param>
    public RoutingData(string QueueId = null, string LanguageId = null, string Label = null, int? Priority = null, List<string> SkillIds = null, List<string> PreferredAgentIds = null, List<ScoredAgent> ScoredAgents = null, List<string> RoutingFlags = null)
    {
        this.QueueId = QueueId;
        this.LanguageId = LanguageId;
        this.Label = Label;
        this.Priority = Priority;
        this.SkillIds = SkillIds;
        this.PreferredAgentIds = PreferredAgentIds;
        this.ScoredAgents = ScoredAgents;
        this.RoutingFlags = RoutingFlags;

    }



    /// <summary>
    /// The identifier of the routing queue
    /// </summary>
    /// <value>The identifier of the routing queue</value>
    [DataMember(Name = "queueId", EmitDefaultValue = false)]
    public string QueueId { get; set; }



    /// <summary>
    /// The identifier of a language to be considered in routing
    /// </summary>
    /// <value>The identifier of a language to be considered in routing</value>
    [DataMember(Name = "languageId", EmitDefaultValue = false)]
    public string LanguageId { get; set; }



    /// <summary>
    /// An optional label that categorizes the conversation.  Max-utilization settings can be configured at a per-label level
    /// </summary>
    /// <value>An optional label that categorizes the conversation.  Max-utilization settings can be configured at a per-label level</value>
    [DataMember(Name = "label", EmitDefaultValue = false)]
    public string Label { get; set; }



    /// <summary>
    /// The priority for routing
    /// </summary>
    /// <value>The priority for routing</value>
    [DataMember(Name = "priority", EmitDefaultValue = false)]
    public int? Priority { get; set; }



    /// <summary>
    /// A list of skill identifiers to be considered in routing
    /// </summary>
    /// <value>A list of skill identifiers to be considered in routing</value>
    [DataMember(Name = "skillIds", EmitDefaultValue = false)]
    public List<string> SkillIds { get; set; }



    /// <summary>
    /// A list of agents to be preferred in routing
    /// </summary>
    /// <value>A list of agents to be preferred in routing</value>
    [DataMember(Name = "preferredAgentIds", EmitDefaultValue = false)]
    public List<string> PreferredAgentIds { get; set; }



    /// <summary>
    /// A list of scored agents for routing decisions. For Agent Owned Callbacks use one scored agent with a score of 100.
    /// </summary>
    /// <value>A list of scored agents for routing decisions. For Agent Owned Callbacks use one scored agent with a score of 100.</value>
    [DataMember(Name = "scoredAgents", EmitDefaultValue = false)]
    public List<ScoredAgent> ScoredAgents { get; set; }



    /// <summary>
    /// An array of flags indicating how the conversation should be routed. Use \&quot;AGENT_OWNED_CALLBACK\&quot; when creating an Agent Owned Callback.
    /// </summary>
    /// <value>An array of flags indicating how the conversation should be routed. Use \&quot;AGENT_OWNED_CALLBACK\&quot; when creating an Agent Owned Callback.</value>
    [DataMember(Name = "routingFlags", EmitDefaultValue = false)]
    public List<string> RoutingFlags { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class RoutingData {\n");

        sb.Append("  QueueId: ").Append(QueueId).Append("\n");
        sb.Append("  LanguageId: ").Append(LanguageId).Append("\n");
        sb.Append("  Label: ").Append(Label).Append("\n");
        sb.Append("  Priority: ").Append(Priority).Append("\n");
        sb.Append("  SkillIds: ").Append(SkillIds).Append("\n");
        sb.Append("  PreferredAgentIds: ").Append(PreferredAgentIds).Append("\n");
        sb.Append("  ScoredAgents: ").Append(ScoredAgents).Append("\n");
        sb.Append("  RoutingFlags: ").Append(RoutingFlags).Append("\n");
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
        return Equals(obj as RoutingData);
    }

    /// <summary>
    /// Returns true if RoutingData instances are equal
    /// </summary>
    /// <param name="other">Instance of RoutingData to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(RoutingData other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                QueueId == other.QueueId ||
                QueueId != null &&
                QueueId.Equals(other.QueueId)
            ) &&
            (
                LanguageId == other.LanguageId ||
                LanguageId != null &&
                LanguageId.Equals(other.LanguageId)
            ) &&
            (
                Label == other.Label ||
                Label != null &&
                Label.Equals(other.Label)
            ) &&
            (
                Priority == other.Priority ||
                Priority != null &&
                Priority.Equals(other.Priority)
            ) &&
            (
                SkillIds == other.SkillIds ||
                SkillIds != null &&
                SkillIds.SequenceEqual(other.SkillIds)
            ) &&
            (
                PreferredAgentIds == other.PreferredAgentIds ||
                PreferredAgentIds != null &&
                PreferredAgentIds.SequenceEqual(other.PreferredAgentIds)
            ) &&
            (
                ScoredAgents == other.ScoredAgents ||
                ScoredAgents != null &&
                ScoredAgents.SequenceEqual(other.ScoredAgents)
            ) &&
            (
                RoutingFlags == other.RoutingFlags ||
                RoutingFlags != null &&
                RoutingFlags.SequenceEqual(other.RoutingFlags)
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
            if (QueueId != null)
            {
                hash = hash * 59 + QueueId.GetHashCode();
            }

            if (LanguageId != null)
            {
                hash = hash * 59 + LanguageId.GetHashCode();
            }

            if (Label != null)
            {
                hash = hash * 59 + Label.GetHashCode();
            }

            if (Priority != null)
            {
                hash = hash * 59 + Priority.GetHashCode();
            }

            if (SkillIds != null)
            {
                hash = hash * 59 + SkillIds.GetHashCode();
            }

            if (PreferredAgentIds != null)
            {
                hash = hash * 59 + PreferredAgentIds.GetHashCode();
            }

            if (ScoredAgents != null)
            {
                hash = hash * 59 + ScoredAgents.GetHashCode();
            }

            if (RoutingFlags != null)
            {
                hash = hash * 59 + RoutingFlags.GetHashCode();
            }

            return hash;
        }
    }
}
