using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class DynamicGroupSkillCondition
{
    /// <summary>
    /// Operator that will be applied to the conditions
    /// </summary>
    /// <value>Operator that will be applied to the conditions</value>
    public DynamicGroupSkillConditionOperationEnum? Operation { get; set; }

    /// <summary>
    /// Routing skill conditions that will be used for building the query
    /// </summary>
    /// <value>Routing skill conditions that will be used for building the query</value>
    public IEnumerable<DynamicGroupRoutingSkillCondition> RoutingSkillConditions { get; set; }

    /// <summary>
    /// Routing skill conditions that will be used for building the query
    /// </summary>
    /// <value>Routing skill conditions that will be used for building the query</value>
    public IEnumerable<DynamicGroupLanguageSkillCondition> LanguageSkillConditions { get; set; }
}
