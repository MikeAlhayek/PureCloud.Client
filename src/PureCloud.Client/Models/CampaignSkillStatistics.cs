using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// CampaignSkillStatistics
/// </summary>

public partial class CampaignSkillStatistics : IEquatable<CampaignSkillStatistics>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CampaignSkillStatistics" /> class.
    /// </summary>
    public CampaignSkillStatistics()
    {

    }



    /// <summary>
    /// Number of available skill combinations for the campaign
    /// </summary>
    /// <value>Number of available skill combinations for the campaign</value>
    [JsonPropertyName("skillCombinations")]
    public int? SkillCombinations { get; private set; }



    /// <summary>
    /// Number of eligible agents with skills for campaign
    /// </summary>
    /// <value>Number of eligible agents with skills for campaign</value>
    [JsonPropertyName("eligibleSkilledAgents")]
    public int? EligibleSkilledAgents { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CampaignSkillStatistics {\n");

        sb.Append("  SkillCombinations: ").Append(SkillCombinations).Append("\n");
        sb.Append("  EligibleSkilledAgents: ").Append(EligibleSkilledAgents).Append("\n");
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
        return Equals(obj as CampaignSkillStatistics);
    }

    /// <summary>
    /// Returns true if CampaignSkillStatistics instances are equal
    /// </summary>
    /// <param name="other">Instance of CampaignSkillStatistics to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CampaignSkillStatistics other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                SkillCombinations == other.SkillCombinations ||
                SkillCombinations != null &&
                SkillCombinations.Equals(other.SkillCombinations)
            ) &&
            (
                EligibleSkilledAgents == other.EligibleSkilledAgents ||
                EligibleSkilledAgents != null &&
                EligibleSkilledAgents.Equals(other.EligibleSkilledAgents)
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
            if (SkillCombinations != null)
            {
                hash = hash * 59 + SkillCombinations.GetHashCode();
            }

            if (EligibleSkilledAgents != null)
            {
                hash = hash * 59 + EligibleSkilledAgents.GetHashCode();
            }

            return hash;
        }
    }
}
