using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ConversationActivityQueryPredicate
{
    /// <summary>
    /// Optional type, can usually be inferred
    /// </summary>
    /// <value>Optional type, can usually be inferred</value>
    public ConversationActivityQueryPredicateTypeEnum? Type { get; set; }

    /// <summary>
    /// Left hand side for dimension predicates
    /// </summary>
    /// <value>Left hand side for dimension predicates</value>
    public ConversationActivityQueryPredicateDimensionEnum? Dimension { get; set; }

    /// <summary>
    /// Optional operator, default is matches
    /// </summary>
    /// <value>Optional operator, default is matches</value>
    public ConversationActivityQueryPredicateOperatorEnum? Operator { get; set; }

    /// <summary>
    /// Right hand side for dimension predicates
    /// </summary>
    /// <value>Right hand side for dimension predicates</value>
    public string Value { get; set; }
}
