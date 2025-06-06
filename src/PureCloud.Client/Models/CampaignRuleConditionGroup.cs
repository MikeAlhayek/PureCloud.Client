using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// CampaignRuleConditionGroup
/// </summary>

public partial class CampaignRuleConditionGroup : IEquatable<CampaignRuleConditionGroup>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="CampaignRuleConditionGroup" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected CampaignRuleConditionGroup() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="CampaignRuleConditionGroup" /> class.
    /// </summary>
    /// <param name="MatchAnyConditions">Whether or not this condition group should be evaluated as true if any of sub conditions is matched (required).</param>
    /// <param name="Conditions">The parameters for the CampaignRuleCondition. (required).</param>
    public CampaignRuleConditionGroup(bool? MatchAnyConditions = null, List<CampaignRuleCondition> Conditions = null)
    {
        this.MatchAnyConditions = MatchAnyConditions;
        this.Conditions = Conditions;

    }



    /// <summary>
    /// Whether or not this condition group should be evaluated as true if any of sub conditions is matched
    /// </summary>
    /// <value>Whether or not this condition group should be evaluated as true if any of sub conditions is matched</value>
    [JsonPropertyName("matchAnyConditions")]
    public bool? MatchAnyConditions { get; set; }



    /// <summary>
    /// The parameters for the CampaignRuleCondition.
    /// </summary>
    /// <value>The parameters for the CampaignRuleCondition.</value>
    [JsonPropertyName("conditions")]
    public List<CampaignRuleCondition> Conditions { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CampaignRuleConditionGroup {\n");

        sb.Append("  MatchAnyConditions: ").Append(MatchAnyConditions).Append("\n");
        sb.Append("  Conditions: ").Append(Conditions).Append("\n");
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
        return Equals(obj as CampaignRuleConditionGroup);
    }

    /// <summary>
    /// Returns true if CampaignRuleConditionGroup instances are equal
    /// </summary>
    /// <param name="other">Instance of CampaignRuleConditionGroup to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CampaignRuleConditionGroup other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                MatchAnyConditions == other.MatchAnyConditions ||
                MatchAnyConditions != null &&
                MatchAnyConditions.Equals(other.MatchAnyConditions)
            ) &&
            (
                Conditions == other.Conditions ||
                Conditions != null &&
                Conditions.SequenceEqual(other.Conditions)
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
            if (MatchAnyConditions != null)
            {
                hash = hash * 59 + MatchAnyConditions.GetHashCode();
            }

            if (Conditions != null)
            {
                hash = hash * 59 + Conditions.GetHashCode();
            }

            return hash;
        }
    }
}
