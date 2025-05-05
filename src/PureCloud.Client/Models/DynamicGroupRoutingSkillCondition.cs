using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// DynamicGroupRoutingSkillCondition
/// </summary>

public partial class DynamicGroupRoutingSkillCondition : IEquatable<DynamicGroupRoutingSkillCondition>
{
    /// <summary>
    /// Comparator that will be applied to the proficiency
    /// </summary>
    /// <value>Comparator that will be applied to the proficiency</value>
    
    public enum ComparatorEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Equalto for "EqualTo"
        /// </summary>
        [EnumMember(Value = "EqualTo")]
        Equalto,

        /// <summary>
        /// Enum Notequalto for "NotEqualTo"
        /// </summary>
        [EnumMember(Value = "NotEqualTo")]
        Notequalto,

        /// <summary>
        /// Enum Lessthan for "LessThan"
        /// </summary>
        [EnumMember(Value = "LessThan")]
        Lessthan,

        /// <summary>
        /// Enum Greaterthan for "GreaterThan"
        /// </summary>
        [EnumMember(Value = "GreaterThan")]
        Greaterthan,

        /// <summary>
        /// Enum Greaterthanorequalto for "GreaterThanOrEqualTo"
        /// </summary>
        [EnumMember(Value = "GreaterThanOrEqualTo")]
        Greaterthanorequalto,

        /// <summary>
        /// Enum Lessthanorequalto for "LessThanOrEqualTo"
        /// </summary>
        [EnumMember(Value = "LessThanOrEqualTo")]
        Lessthanorequalto
    }
    /// <summary>
    /// Comparator that will be applied to the proficiency
    /// </summary>
    /// <value>Comparator that will be applied to the proficiency</value>
    [JsonPropertyName("comparator")]
    public ComparatorEnum? Comparator { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="DynamicGroupRoutingSkillCondition" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected DynamicGroupRoutingSkillCondition() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="DynamicGroupRoutingSkillCondition" /> class.
    /// </summary>
    /// <param name="RoutingSkill">The routing skill to be used in the skill condition query (required).</param>
    /// <param name="Comparator">Comparator that will be applied to the proficiency (required).</param>
    /// <param name="Proficiency">The skill proficiency that will be used for the routing skill. Integer range 0-5 (required).</param>
    /// <param name="ChildConditions">Nested conditions to be applied to this skill condition.</param>
    public DynamicGroupRoutingSkillCondition(string RoutingSkill = null, ComparatorEnum? Comparator = null, int? Proficiency = null, List<DynamicGroupSkillCondition> ChildConditions = null)
    {
        this.RoutingSkill = RoutingSkill;
        this.Comparator = Comparator;
        this.Proficiency = Proficiency;
        this.ChildConditions = ChildConditions;

    }



    /// <summary>
    /// The routing skill to be used in the skill condition query
    /// </summary>
    /// <value>The routing skill to be used in the skill condition query</value>
    [JsonPropertyName("routingSkill")]
    public string RoutingSkill { get; set; }





    /// <summary>
    /// The skill proficiency that will be used for the routing skill. Integer range 0-5
    /// </summary>
    /// <value>The skill proficiency that will be used for the routing skill. Integer range 0-5</value>
    [JsonPropertyName("proficiency")]
    public int? Proficiency { get; set; }



    /// <summary>
    /// Nested conditions to be applied to this skill condition
    /// </summary>
    /// <value>Nested conditions to be applied to this skill condition</value>
    [JsonPropertyName("childConditions")]
    public List<DynamicGroupSkillCondition> ChildConditions { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class DynamicGroupRoutingSkillCondition {\n");

        sb.Append("  RoutingSkill: ").Append(RoutingSkill).Append("\n");
        sb.Append("  Comparator: ").Append(Comparator).Append("\n");
        sb.Append("  Proficiency: ").Append(Proficiency).Append("\n");
        sb.Append("  ChildConditions: ").Append(ChildConditions).Append("\n");
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
        return Equals(obj as DynamicGroupRoutingSkillCondition);
    }

    /// <summary>
    /// Returns true if DynamicGroupRoutingSkillCondition instances are equal
    /// </summary>
    /// <param name="other">Instance of DynamicGroupRoutingSkillCondition to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DynamicGroupRoutingSkillCondition other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                RoutingSkill == other.RoutingSkill ||
                RoutingSkill != null &&
                RoutingSkill.Equals(other.RoutingSkill)
            ) &&
            (
                Comparator == other.Comparator ||
                Comparator != null &&
                Comparator.Equals(other.Comparator)
            ) &&
            (
                Proficiency == other.Proficiency ||
                Proficiency != null &&
                Proficiency.Equals(other.Proficiency)
            ) &&
            (
                ChildConditions == other.ChildConditions ||
                ChildConditions != null &&
                ChildConditions.SequenceEqual(other.ChildConditions)
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
            if (RoutingSkill != null)
            {
                hash = hash * 59 + RoutingSkill.GetHashCode();
            }

            if (Comparator != null)
            {
                hash = hash * 59 + Comparator.GetHashCode();
            }

            if (Proficiency != null)
            {
                hash = hash * 59 + Proficiency.GetHashCode();
            }

            if (ChildConditions != null)
            {
                hash = hash * 59 + ChildConditions.GetHashCode();
            }

            return hash;
        }
    }
}
