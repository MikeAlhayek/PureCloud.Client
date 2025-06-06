using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// DynamicGroupQuery
/// </summary>

public partial class DynamicGroupQuery : IEquatable<DynamicGroupQuery>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="DynamicGroupQuery" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected DynamicGroupQuery() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="DynamicGroupQuery" /> class.
    /// </summary>
    /// <param name="SkillConditions">The skill conditions that need to be used for this dynamic group (required).</param>
    public DynamicGroupQuery(List<DynamicGroupSkillCondition> SkillConditions = null)
    {
        this.SkillConditions = SkillConditions;

    }



    /// <summary>
    /// The skill conditions that need to be used for this dynamic group
    /// </summary>
    /// <value>The skill conditions that need to be used for this dynamic group</value>
    [JsonPropertyName("skillConditions")]
    public List<DynamicGroupSkillCondition> SkillConditions { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class DynamicGroupQuery {\n");

        sb.Append("  SkillConditions: ").Append(SkillConditions).Append("\n");
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
        return Equals(obj as DynamicGroupQuery);
    }

    /// <summary>
    /// Returns true if DynamicGroupQuery instances are equal
    /// </summary>
    /// <param name="other">Instance of DynamicGroupQuery to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DynamicGroupQuery other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                SkillConditions == other.SkillConditions ||
                SkillConditions != null &&
                SkillConditions.SequenceEqual(other.SkillConditions)
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
            if (SkillConditions != null)
            {
                hash = hash * 59 + SkillConditions.GetHashCode();
            }

            return hash;
        }
    }
}
