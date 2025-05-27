using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class UserDetailQueryFilter
{
    /// <summary>
    /// Boolean operation to apply to the provided predicates and clauses
    /// </summary>
    /// <value>Boolean operation to apply to the provided predicates and clauses</value>
    public UserDetailQueryFilterTypeEnum? Type { get; set; }

    /// <summary>
    /// Boolean &#39;and/or&#39; logic with up to two-levels of nesting
    /// </summary>
    /// <value>Boolean &#39;and/or&#39; logic with up to two-levels of nesting</value>
    public IEnumerable<UserDetailQueryClause> Clauses { get; set; }

    /// <summary>
    /// Like a three-word sentence: (attribute-name) (operator) (target-value).
    /// </summary>
    /// <value>Like a three-word sentence: (attribute-name) (operator) (target-value).</value>
    public IEnumerable<UserDetailQueryPredicate> Predicates { get; set; }
}
