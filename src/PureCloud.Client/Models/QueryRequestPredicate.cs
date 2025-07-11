using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class QueryRequestPredicate
{
    /// <summary>
    /// The dimension to be filtered
    /// </summary>
    /// <value>The dimension to be filtered</value>
    public QueryRequestPredicateDimensionEnum? Dimension { get; set; }

    /// <summary>
    /// The value to filter by
    /// </summary>
    /// <value>The value to filter by</value>
    public string Value { get; set; }
}
