namespace PureCloud.Client.Models;

public sealed class EvaluationDetailQueryPredicate
{
    /// <summary>
    /// Optional type, can usually be inferred
    /// </summary>
    public EvaluationDetailQueryPredicateTypeEnum? Type { get; set; }


    /// <summary>
    /// Left hand side for dimension predicates
    /// </summary>
    public EvaluationDetailQueryPredicateDimensionEnum? Dimension { get; set; }


    /// <summary>
    /// Left hand side for metric predicates
    /// </summary>
    public EvaluationDetailQueryPredicateMetricEnum? Metric { get; set; }


    /// <summary>
    /// Optional operator, default is matches
    /// </summary>
    public EvaluationDetailQueryPredicateOperatorEnum? Operator { get; set; }


    /// <summary>
    /// Right hand side for dimension or metric predicates
    /// </summary>
    public string Value { get; set; }


    /// <summary>
    /// Right hand side for dimension or metric predicates
    /// </summary>
    public NumericRange Range { get; set; }
}
