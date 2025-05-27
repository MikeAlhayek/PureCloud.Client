using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class SkillGroupCondition
{
    /// <summary>
    /// Operator that will be applied to the conditions
    /// </summary>
    /// <value>Operator that will be applied to the conditions</value>
    public SkillGroupConditionOperationEnum? Operation { get; set; }

    /// <summary>
    /// Routing skill conditions that will be used for building the query
    /// </summary>
    /// <value>Routing skill conditions that will be used for building the query</value>
    public IEnumerable<SkillGroupRoutingCondition> RoutingSkillConditions { get; set; }

    /// <summary>
    /// Routing skill conditions that will be used for building the query
    /// </summary>
    /// <value>Routing skill conditions that will be used for building the query</value>
    public IEnumerable<SkillGroupLanguageCondition> LanguageSkillConditions { get; set; }
}
