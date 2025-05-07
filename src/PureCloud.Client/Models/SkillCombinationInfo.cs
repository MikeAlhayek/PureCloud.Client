using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// SkillCombinationInfo
/// </summary>

public partial class SkillCombinationInfo : IEquatable<SkillCombinationInfo>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SkillCombinationInfo" /> class.
    /// </summary>
    /// <param name="SkillCombination">A skill combination in the contact queue.</param>
    public SkillCombinationInfo(List<string> SkillCombination = null)
    {
        this.SkillCombination = SkillCombination;

    }



    /// <summary>
    /// A skill combination in the contact queue
    /// </summary>
    /// <value>A skill combination in the contact queue</value>
    [JsonPropertyName("skillCombination")]
    public List<string> SkillCombination { get; set; }



    /// <summary>
    /// Number of total contacts in the contact queue for this skill combination
    /// </summary>
    /// <value>Number of total contacts in the contact queue for this skill combination</value>
    [JsonPropertyName("totalCount")]
    public long? TotalCount { get; set; }



    /// <summary>
    /// Number of remaining contacts in the contact queue for this skill combination
    /// </summary>
    /// <value>Number of remaining contacts in the contact queue for this skill combination</value>
    [JsonPropertyName("remainingCount")]
    public long? RemainingCount { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class SkillCombinationInfo {\n");

        sb.Append("  SkillCombination: ").Append(SkillCombination).Append("\n");
        sb.Append("  TotalCount: ").Append(TotalCount).Append("\n");
        sb.Append("  RemainingCount: ").Append(RemainingCount).Append("\n");
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
        return Equals(obj as SkillCombinationInfo);
    }

    /// <summary>
    /// Returns true if SkillCombinationInfo instances are equal
    /// </summary>
    /// <param name="other">Instance of SkillCombinationInfo to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(SkillCombinationInfo other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                SkillCombination == other.SkillCombination ||
                SkillCombination != null &&
                SkillCombination.SequenceEqual(other.SkillCombination)
            ) &&
            (
                TotalCount == other.TotalCount ||
                TotalCount != null &&
                TotalCount.Equals(other.TotalCount)
            ) &&
            (
                RemainingCount == other.RemainingCount ||
                RemainingCount != null &&
                RemainingCount.Equals(other.RemainingCount)
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
            if (SkillCombination != null)
            {
                hash = hash * 59 + SkillCombination.GetHashCode();
            }

            if (TotalCount != null)
            {
                hash = hash * 59 + TotalCount.GetHashCode();
            }

            if (RemainingCount != null)
            {
                hash = hash * 59 + RemainingCount.GetHashCode();
            }

            return hash;
        }
    }
}
