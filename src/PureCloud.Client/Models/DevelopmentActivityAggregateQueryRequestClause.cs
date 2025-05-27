using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class DevelopmentActivityAggregateQueryRequestClause
{
    /// <summary>
    /// The logic used to combine the predicates
    /// </summary>
    /// <value>The logic used to combine the predicates</value>
    public DevelopmentActivityAggregateQueryRequestClauseTypeEnum? Type { get; set; }

    /// <summary>
    /// The list of predicates used to filter the data
    /// </summary>
    /// <value>The list of predicates used to filter the data</value>
    public IEnumerable<DevelopmentActivityAggregateQueryRequestPredicate> Predicates { get; set; }
}
