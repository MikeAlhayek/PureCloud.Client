using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class DynamicGroupRoutingSkillCondition
{
    /// <summary>
    /// Comparator that will be applied to the proficiency
    /// </summary>
    /// <value>Comparator that will be applied to the proficiency</value>
    public DynamicGroupRoutingSkillConditionComparatorEnum? Comparator { get; set; }

    /// <summary>
    /// The routing skill to be used in the skill condition query
    /// </summary>
    /// <value>The routing skill to be used in the skill condition query</value>
    public string RoutingSkill { get; set; }

    /// <summary>
    /// The skill proficiency that will be used for the routing skill. Integer range 0-5
    /// </summary>
    /// <value>The skill proficiency that will be used for the routing skill. Integer range 0-5</value>
    public int? Proficiency { get; set; }

    /// <summary>
    /// Nested conditions to be applied to this skill condition
    /// </summary>
    /// <value>Nested conditions to be applied to this skill condition</value>
    public IEnumerable<DynamicGroupSkillCondition> ChildConditions { get; set; }
}
