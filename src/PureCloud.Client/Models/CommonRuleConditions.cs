using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;


public sealed class CommonRuleConditions
{
    /// <summary>
    /// the logic operator performed.
    /// </summary>
    /// <value>the logic operator performed.</value>
    public CommonRuleConditionsTypeEnum? Type { get; set; }

    /// <summary>
    /// The list of predicates groups to be evaluated
    /// </summary>
    /// <value>The list of predicates groups to be evaluated</value>
    public IEnumerable<CommonRuleConditions> Clauses { get; set; }

    /// <summary>
    /// The list of rule metric predicates to be evaluated.
    /// </summary>
    /// <value>The list of rule metric predicates to be evaluated.</value>
    public IEnumerable<CommonRulePredicate> Predicates { get; set; }

    /// <summary>
    /// The id.
    /// </summary>
    /// <value>The id.</value>
    public string Id { get; set; }
}
