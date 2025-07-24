namespace PureCloud.Client.Models;

/// <summary>
/// SocialMediaQueryPredicate
/// </summary>
public sealed class SocialMediaQueryPredicate
{
    /// <summary>
    /// Optional type, can usually be inferred
    /// </summary>
    /// <value>Optional type, can usually be inferred</value>
    public SocialMediaQueryPredicateType? Type { get; set; }

    /// <summary>
    /// Left hand side for dimension predicates
    /// </summary>
    /// <value>Left hand side for dimension predicates</value>
    public SocialMediaQueryPredicateDimension? Dimension { get; set; }

    /// <summary>
    /// Optional operator, default is matches
    /// </summary>
    /// <value>Optional operator, default is matches</value>
    public SocialMediaQueryPredicateOperator? Operator { get; set; }

    /// <summary>
    /// Right hand side for dimension predicates
    /// </summary>
    /// <value>Right hand side for dimension predicates</value>
    public string Value { get; set; }

    /// <summary>
    /// Right hand side for dimension predicates
    /// </summary>
    /// <value>Right hand side for dimension predicates</value>
    public NumericRange Range { get; set; }
}