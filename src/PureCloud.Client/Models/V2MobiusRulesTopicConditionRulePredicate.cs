using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class V2MobiusRulesTopicConditionRulePredicate
{
    /// <summary>
    /// Gets or Sets MetricType
    /// </summary>
    public V2MobiusRulesTopicConditionRulePredicateMetricTypeEnum? MetricType { get; set; }

    /// <summary>
    /// Gets or Sets MetricValueType
    /// </summary>
    public V2MobiusRulesTopicConditionRulePredicateMetricValueTypeEnum? MetricValueType { get; set; }

    /// <summary>
    /// Gets or Sets MediaType
    /// </summary>
    public V2MobiusRulesTopicConditionRulePredicateMediaTypeEnum? MediaType { get; set; }

    /// <summary>
    /// Gets or Sets ComparisonOperator
    /// </summary>
    public V2MobiusRulesTopicConditionRulePredicateComparisonOperatorEnum? ComparisonOperator { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    public Guid? Id { get; set; }

    /// <summary>
    /// Gets or Sets Entity
    /// </summary>
    public V2MobiusRulesTopicEntityProperties Entity { get; set; }

    /// <summary>
    /// Gets or Sets Metric
    /// </summary>
    public string Metric { get; set; }

    /// <summary>
    /// Gets or Sets Value
    /// </summary>
    public double? Value { get; set; }

    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    public string Status { get; set; }

    /// <summary>
    /// Gets or Sets Topic
    /// </summary>
    public string Topic { get; set; }
}
