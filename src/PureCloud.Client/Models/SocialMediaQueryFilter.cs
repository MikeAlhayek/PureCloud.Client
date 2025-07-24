namespace PureCloud.Client.Models;

/// <summary>
/// SocialMediaQueryFilter
/// </summary>
public sealed class SocialMediaQueryFilter
{
    /// <summary>
    /// Boolean operation to apply to the provided predicates and clauses
    /// </summary>
    /// <value>Boolean operation to apply to the provided predicates and clauses</value>
    public SocialMediaQueryFilterType? Type { get; set; }

    /// <summary>
    /// Boolean 'and/or' logic with up to two-levels of nesting
    /// </summary>
    /// <value>Boolean 'and/or' logic with up to two-levels of nesting</value>
    public IEnumerable<SocialMediaQueryClause> Clauses { get; set; }

    /// <summary>
    /// Like a three-word sentence: (attribute-name) (operator) (target-value).
    /// </summary>
    /// <value>Like a three-word sentence: (attribute-name) (operator) (target-value).</value>
    public IEnumerable<SocialMediaQueryPredicate> Predicates { get; set; }
}