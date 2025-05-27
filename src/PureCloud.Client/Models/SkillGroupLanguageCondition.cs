using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class SkillGroupLanguageCondition
{
    /// <summary>
    /// Comparator that will be applied to the proficiency
    /// </summary>
    /// <value>Comparator that will be applied to the proficiency</value>
    public SkillGroupLanguageConditionComparatorEnum? Comparator { get; set; }

    /// <summary>
    /// The language skill to be used in the skill condition query
    /// </summary>
    /// <value>The language skill to be used in the skill condition query</value>
    public string LanguageSkill { get; set; }

    /// <summary>
    /// The skill proficiency that will be used for the language skill. Integer range 0-5
    /// </summary>
    /// <value>The skill proficiency that will be used for the language skill. Integer range 0-5</value>
    public int? Proficiency { get; set; }

    /// <summary>
    /// Nested conditions to be applied to this skill condition
    /// </summary>
    /// <value>Nested conditions to be applied to this skill condition</value>
    public IEnumerable<SkillGroupCondition> ChildConditions { get; set; }
}
