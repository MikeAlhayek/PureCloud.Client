using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class DevelopmentActivityAggregateQueryRequestFilter
{
    /// <summary>
    /// The logic used to combine the clauses
    /// </summary>
    /// <value>The logic used to combine the clauses</value>
    public DevelopmentActivityAggregateQueryRequestFilterTypeEnum? Type { get; set; }

    /// <summary>
    /// The list of clauses used to filter the data. Note that clauses must filter by attendeeId and a maximum of 100 user IDs are allowed
    /// </summary>
    /// <value>The list of clauses used to filter the data. Note that clauses must filter by attendeeId and a maximum of 100 user IDs are allowed</value>
    public IEnumerable<DevelopmentActivityAggregateQueryRequestClause> Clauses { get; set; }
}
