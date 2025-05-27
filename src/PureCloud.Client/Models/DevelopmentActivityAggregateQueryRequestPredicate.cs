using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class DevelopmentActivityAggregateQueryRequestPredicate
{
    /// <summary>
    /// Each predicates specifies a dimension.
    /// </summary>
    /// <value>Each predicates specifies a dimension.</value>
    public DevelopmentActivityAggregateQueryRequestPredicateDimensionEnum? Dimension { get; set; }

    /// <summary>
    /// Corresponding value for dimensions in predicates. If the dimension is type, Valid Values: Informational (deprecated), AssessedContent (deprecated), Assessment (deprecated), Coaching, External, Native
    /// </summary>
    /// <value>Corresponding value for dimensions in predicates. If the dimension is type, Valid Values: Informational (deprecated), AssessedContent (deprecated), Assessment (deprecated), Coaching, External, Native</value>
    public string Value { get; set; }
}
