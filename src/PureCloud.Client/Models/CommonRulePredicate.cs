using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class CommonRulePredicate
{
    /// <summary>
    /// The type of metric being evaluated.
    /// </summary>
    /// <value>The type of metric being evaluated.</value>
    public CommonRulePredicateMetricTypeEnum? MetricType { get; set; }

    /// <summary>
    /// The type of metric value being evaluated.
    /// </summary>
    /// <value>The type of metric value being evaluated.</value>
    public CommonRulePredicateMetricValueTypeEnum? MetricValueType { get; set; }

    /// <summary>
    /// The comparison operator being performed on the metric.
    /// </summary>
    /// <value>The comparison operator being performed on the metric.</value>
    public CommonRulePredicateComparisonOperatorEnum? ComparisonOperator { get; set; }

    /// <summary>
    /// The media type of the conversation the metric describes.
    /// </summary>
    /// <value>The media type of the conversation the metric describes.</value>
    public CommonRulePredicateMediaTypeEnum? MediaType { get; set; }

    /// <summary>
    /// The metric being evaluated.
    /// </summary>
    /// <value>The metric being evaluated.</value>
    public CommonRulePredicateMetricEnum? Metric { get; set; }

    /// <summary>
    /// The value the metric will be compared to.
    /// </summary>
    /// <value>The value the metric will be compared to.</value>
    public double? Value { get; set; }

    /// <summary>
    /// The status of the entity corresponding to the metric.
    /// </summary>
    /// <value>The status of the entity corresponding to the metric.</value>
    public string Status { get; set; }

    /// <summary>
    /// The operational console topic corresponding to the metric.
    /// </summary>
    /// <value>The operational console topic corresponding to the metric.</value>
    public string Topic { get; set; }

    /// <summary>
    /// The entity whose metric is being represented.
    /// </summary>
    /// <value>The entity whose metric is being represented.</value>
    public CommonRulePredicateEntity Entity { get; set; }
}
