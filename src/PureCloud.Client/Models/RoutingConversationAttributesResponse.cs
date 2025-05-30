using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// RoutingConversationAttributesResponse
/// </summary>

public partial class RoutingConversationAttributesResponse : IEquatable<RoutingConversationAttributesResponse>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="RoutingConversationAttributesResponse" /> class.
    /// </summary>
    /// <param name="Priority">Current priority value on in-queue conversation. Range:[-25000000, 25000000].</param>
    /// <param name="Skills">Current routing skills on in-queue conversation.</param>
    /// <param name="Language">Current language on in-queue conversation.</param>
    /// <param name="Label">Current label on in-queue conversation.</param>
    /// <param name="ScoredAgents">Current scored agents on in-queue conversation.</param>
    public RoutingConversationAttributesResponse(int? Priority = null, List<RoutingSkill> Skills = null, Language Language = null, UtilizationLabel Label = null, List<ScoredAgent> ScoredAgents = null)
    {
        this.Priority = Priority;
        this.Skills = Skills;
        this.Language = Language;
        this.Label = Label;
        this.ScoredAgents = ScoredAgents;

    }



    /// <summary>
    /// Current priority value on in-queue conversation. Range:[-25000000, 25000000]
    /// </summary>
    /// <value>Current priority value on in-queue conversation. Range:[-25000000, 25000000]</value>
    [JsonPropertyName("priority")]
    public int? Priority { get; set; }



    /// <summary>
    /// Current routing skills on in-queue conversation
    /// </summary>
    /// <value>Current routing skills on in-queue conversation</value>
    [JsonPropertyName("skills")]
    public List<RoutingSkill> Skills { get; set; }



    /// <summary>
    /// Current language on in-queue conversation
    /// </summary>
    /// <value>Current language on in-queue conversation</value>
    [JsonPropertyName("language")]
    public Language Language { get; set; }



    /// <summary>
    /// Current label on in-queue conversation
    /// </summary>
    /// <value>Current label on in-queue conversation</value>
    [JsonPropertyName("label")]
    public UtilizationLabel Label { get; set; }



    /// <summary>
    /// Current scored agents on in-queue conversation
    /// </summary>
    /// <value>Current scored agents on in-queue conversation</value>
    [JsonPropertyName("scoredAgents")]
    public List<ScoredAgent> ScoredAgents { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class RoutingConversationAttributesResponse {\n");

        sb.Append("  Priority: ").Append(Priority).Append("\n");
        sb.Append("  Skills: ").Append(Skills).Append("\n");
        sb.Append("  Language: ").Append(Language).Append("\n");
        sb.Append("  Label: ").Append(Label).Append("\n");
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
        return Equals(obj as RoutingConversationAttributesResponse);
    }

    /// <summary>
    /// Returns true if RoutingConversationAttributesResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of RoutingConversationAttributesResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(RoutingConversationAttributesResponse other)
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
                Skills == other.Skills ||
                Skills != null &&
                Skills.SequenceEqual(other.Skills)
            ) &&
            (
                Language == other.Language ||
                Language != null &&
                Language.Equals(other.Language)
            ) &&
            (
                Label == other.Label ||
                Label != null &&
                Label.Equals(other.Label)
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
            if (Priority != null)
            {
                hash = hash * 59 + Priority.GetHashCode();
            }

            if (Skills != null)
            {
                hash = hash * 59 + Skills.GetHashCode();
            }

            if (Language != null)
            {
                hash = hash * 59 + Language.GetHashCode();
            }

            if (Label != null)
            {
                hash = hash * 59 + Label.GetHashCode();
            }

            if (ScoredAgents != null)
            {
                hash = hash * 59 + ScoredAgents.GetHashCode();
            }

            return hash;
        }
    }
}
