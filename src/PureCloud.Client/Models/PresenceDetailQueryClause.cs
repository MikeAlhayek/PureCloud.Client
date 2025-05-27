using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class PresenceDetailQueryClause
{
    /// <summary>
    /// Boolean operation to apply to the provided predicates
    /// </summary>
    /// <value>Boolean operation to apply to the provided predicates</value>
    public PresenceDetailQueryClauseTypeEnum? Type { get; set; }

    /// <summary>
    /// Like a three-word sentence: (attribute-name) (operator) (target-value).
    /// </summary>
    /// <value>Like a three-word sentence: (attribute-name) (operator) (target-value).</value>
    public IEnumerable<PresenceDetailQueryPredicate> Predicates { get; set; }
}
