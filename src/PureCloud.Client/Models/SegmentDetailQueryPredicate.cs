using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class SegmentDetailQueryPredicate
{
    /// <summary>
    /// Optional type, can usually be inferred
    /// </summary>
    /// <value>Optional type, can usually be inferred</value>
    public SegmentDetailQueryPredicateTypeEnum? Type { get; set; }

    /// <summary>
    /// Left hand side for dimension predicates
    /// </summary>
    /// <value>Left hand side for dimension predicates</value>
    public SegmentDetailQueryPredicateDimensionEnum? Dimension { get; set; }

    /// <summary>
    /// Left hand side for property predicates
    /// </summary>
    /// <value>Left hand side for property predicates</value>
    public SegmentDetailQueryPredicatePropertyTypeEnum? PropertyType { get; set; }

    /// <summary>
    /// Left hand side for metric predicates
    /// </summary>
    /// <value>Left hand side for metric predicates</value>
    public SegmentDetailQueryPredicateMetricEnum? Metric { get; set; }

    /// <summary>
    /// Optional operator, default is matches
    /// </summary>
    /// <value>Optional operator, default is matches</value>
    public SegmentDetailQueryPredicateOperatorEnum? Operator { get; set; }

    /// <summary>
    /// Left hand side for property predicates
    /// </summary>
    /// <value>Left hand side for property predicates</value>
    public string Property { get; set; }

    /// <summary>
    /// Right hand side for dimension, metric, or property predicates
    /// </summary>
    /// <value>Right hand side for dimension, metric, or property predicates</value>
    public string Value { get; set; }

    /// <summary>
    /// Right hand side for dimension, metric, or property predicates
    /// </summary>
    public NumericRange Range { get; set; }
}
