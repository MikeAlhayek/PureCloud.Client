using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class V2MobiusRulesTopicCondition
{
    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    public V2MobiusRulesTopicConditionTypeEnum? Type { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    public Guid? Id { get; set; }

    /// <summary>
    /// Gets or Sets Clauses
    /// </summary>
    public IEnumerable<V2MobiusRulesTopicCondition> Clauses { get; set; }

    /// <summary>
    /// Gets or Sets Predicates
    /// </summary>
    public IEnumerable<V2MobiusRulesTopicConditionRulePredicate> Predicates { get; set; }
}
