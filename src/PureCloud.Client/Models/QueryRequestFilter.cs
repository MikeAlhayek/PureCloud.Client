using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class QueryRequestFilter
{
    /// <summary>
    /// The logic used to combine the clauses
    /// </summary>
    /// <value>The logic used to combine the clauses</value>
    public QueryRequestFilterTypeEnum? Type { get; set; }

    /// <summary>
    /// The list of clauses used to filter the data
    /// </summary>
    /// <value>The list of clauses used to filter the data</value>
    public IEnumerable<QueryRequestClause> Clauses { get; set; }
}
