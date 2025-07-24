namespace PureCloud.Client.Models;

/// <summary>
/// SocialMediaQueryClause
/// </summary>
public sealed class SocialMediaQueryClause
{
    /// <summary>
    /// Boolean operation to apply to the provided predicates
    /// </summary>
    /// <value>Boolean operation to apply to the provided predicates</value>
    public SocialMediaQueryClauseType? Type { get; set; }

    /// <summary>
    /// Like a three-word sentence: (attribute-name) (operator) (target-value).
    /// </summary>
    /// <value>Like a three-word sentence: (attribute-name) (operator) (target-value).</value>
    public IEnumerable<SocialMediaQueryPredicate> Predicates { get; set; }
}