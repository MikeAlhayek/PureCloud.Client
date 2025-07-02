using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ResolutionDetailQueryPredicate
{
    /// <summary>
    /// Optional type, can usually be inferred
    /// </summary>
    /// <value>Optional type, can usually be inferred</value>
    public ResolutionDetailQueryPredicateTypeEnum? Type { get; set; }

    /// <summary>
    /// Left hand side for metric predicates
    /// </summary>
    /// <value>Left hand side for metric predicates</value>
    public ResolutionDetailQueryPredicateMetricEnum? Metric { get; set; }

    /// <summary>
    /// Optional operator, default is matches
    /// </summary>
    /// <value>Optional operator, default is matches</value>
    public ResolutionDetailQueryPredicateOperatorEnum? Operator { get; set; }

    /// <summary>
    /// Right hand side for metric predicates
    /// </summary>
    /// <value>Right hand side for metric predicates</value>
    public string Value { get; set; }

    /// <summary>
    /// Right hand side for metric predicates
    /// </summary>
    /// <value>Right hand side for metric predicates</value>
    public NumericRange Range { get; set; }
}
