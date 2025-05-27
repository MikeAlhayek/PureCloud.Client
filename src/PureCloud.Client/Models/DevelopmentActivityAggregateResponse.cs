using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class DevelopmentActivityAggregateResponse
{
    /// <summary>
    /// The results of the query
    /// </summary>
    /// <value>The results of the query</value>
    public IEnumerable<DevelopmentActivityAggregateQueryResponseGroupedData> Results { get; set; }
}
