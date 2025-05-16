using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class V2MobiusAlertsTopicConditionRulePredicate
{
    /// <summary>
    /// Gets or Sets MetricType
    /// </summary>
    public V2MobiusAlertsTopicConditionRulePredicateMetricTypeEnum? MetricType { get; set; }

    /// <summary>
    /// Gets or Sets MetricValueType
    /// </summary>
    public V2MobiusAlertsTopicConditionRulePredicateMetricValueTypeEnum? MetricValueType { get; set; }

    /// <summary>
    /// Gets or Sets MediaType
    /// </summary>
    public V2MobiusAlertsTopicConditionRulePredicateMediaTypeEnum? MediaType { get; set; }

    /// <summary>
    /// Gets or Sets ComparisonOperator
    /// </summary>
    public V2MobiusAlertsTopicConditionRulePredicateComparisonOperatorEnum? ComparisonOperator { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    public Guid? Id { get; set; }

    /// <summary>
    /// Gets or Sets Entity
    /// </summary>
    public V2MobiusAlertsTopicEntityProperties Entity { get; set; }

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
