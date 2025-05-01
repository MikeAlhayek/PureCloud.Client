using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// RoutingConversationAttributesRequest
/// </summary>
[DataContract]
public partial class RoutingConversationAttributesRequest : IEquatable<RoutingConversationAttributesRequest>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="RoutingConversationAttributesRequest" /> class.
    /// </summary>
    /// <param name="Priority">Priority for the conversation.  Each point of priority is equivalent to one minute of time in queue.  Range:[-25000000, 25000000].  To reset, specify 0..</param>
    /// <param name="SkillIds">Skill requirements for the conversation.  To remove all skill requirements, specify an empty list, i.e. []..</param>
    /// <param name="LanguageId">Language requirement for the conversation.  To remove the language requirement, specify an empty string, i.e., \&quot;\&quot;..</param>
    /// <param name="LabelId">Label requirement for the conversation.  To remove the label requirement (setting it to System Default Label), specify an empty string, i.e., \&quot;\&quot;..</param>
    /// <param name="RequestScoredAgents">RequestScoredAgents.</param>
    public RoutingConversationAttributesRequest(int? Priority = null, List<string> SkillIds = null, string LanguageId = null, string LabelId = null, List<RequestScoredAgent> RequestScoredAgents = null)
    {
        this.Priority = Priority;
        this.SkillIds = SkillIds;
        this.LanguageId = LanguageId;
        this.LabelId = LabelId;
        this.RequestScoredAgents = RequestScoredAgents;

    }



    /// <summary>
    /// Priority for the conversation.  Each point of priority is equivalent to one minute of time in queue.  Range:[-25000000, 25000000].  To reset, specify 0.
    /// </summary>
    /// <value>Priority for the conversation.  Each point of priority is equivalent to one minute of time in queue.  Range:[-25000000, 25000000].  To reset, specify 0.</value>
    [DataMember(Name = "priority", EmitDefaultValue = false)]
    public int? Priority { get; set; }



    /// <summary>
    /// Skill requirements for the conversation.  To remove all skill requirements, specify an empty list, i.e. [].
    /// </summary>
    /// <value>Skill requirements for the conversation.  To remove all skill requirements, specify an empty list, i.e. [].</value>
    [DataMember(Name = "skillIds", EmitDefaultValue = false)]
    public List<string> SkillIds { get; set; }



    /// <summary>
    /// Language requirement for the conversation.  To remove the language requirement, specify an empty string, i.e., \&quot;\&quot;.
    /// </summary>
    /// <value>Language requirement for the conversation.  To remove the language requirement, specify an empty string, i.e., \&quot;\&quot;.</value>
    [DataMember(Name = "languageId", EmitDefaultValue = false)]
    public string LanguageId { get; set; }



    /// <summary>
    /// Label requirement for the conversation.  To remove the label requirement (setting it to System Default Label), specify an empty string, i.e., \&quot;\&quot;.
    /// </summary>
    /// <value>Label requirement for the conversation.  To remove the label requirement (setting it to System Default Label), specify an empty string, i.e., \&quot;\&quot;.</value>
    [DataMember(Name = "labelId", EmitDefaultValue = false)]
    public string LabelId { get; set; }



    /// <summary>
    /// Gets or Sets RequestScoredAgents
    /// </summary>
    [DataMember(Name = "requestScoredAgents", EmitDefaultValue = false)]
    public List<RequestScoredAgent> RequestScoredAgents { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class RoutingConversationAttributesRequest {\n");

        sb.Append("  Priority: ").Append(Priority).Append("\n");
        sb.Append("  SkillIds: ").Append(SkillIds).Append("\n");
        sb.Append("  LanguageId: ").Append(LanguageId).Append("\n");
        sb.Append("  LabelId: ").Append(LabelId).Append("\n");
        sb.Append("  RequestScoredAgents: ").Append(RequestScoredAgents).Append("\n");
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
        return Equals(obj as RoutingConversationAttributesRequest);
    }

    /// <summary>
    /// Returns true if RoutingConversationAttributesRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of RoutingConversationAttributesRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(RoutingConversationAttributesRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
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
                LanguageId == other.LanguageId ||
                LanguageId != null &&
                LanguageId.Equals(other.LanguageId)
            ) &&
            (
                LabelId == other.LabelId ||
                LabelId != null &&
                LabelId.Equals(other.LabelId)
            ) &&
            (
                RequestScoredAgents == other.RequestScoredAgents ||
                RequestScoredAgents != null &&
                RequestScoredAgents.SequenceEqual(other.RequestScoredAgents)
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
            if (Priority != null)
            {
                hash = hash * 59 + Priority.GetHashCode();
            }

            if (SkillIds != null)
            {
                hash = hash * 59 + SkillIds.GetHashCode();
            }

            if (LanguageId != null)
            {
                hash = hash * 59 + LanguageId.GetHashCode();
            }

            if (LabelId != null)
            {
                hash = hash * 59 + LabelId.GetHashCode();
            }

            if (RequestScoredAgents != null)
            {
                hash = hash * 59 + RequestScoredAgents.GetHashCode();
            }

            return hash;
        }
    }
}
