using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class SummaryAsyncAggregateQueryResponse
{
    /// <summary>
    /// Gets or Sets Results
    /// </summary>
    public IEnumerable<SummaryAggregateDataContainer> Results { get; set; }

    /// <summary>
    /// Cursor token to retrieve next page
    /// </summary>
    /// <value>Cursor token to retrieve next page</value>
    public string Cursor { get; set; }
}
