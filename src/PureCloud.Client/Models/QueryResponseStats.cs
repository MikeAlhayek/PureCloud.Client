using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class QueryResponseStats
{
    /// <summary>
    /// The count for this metric
    /// </summary>
    /// <value>The count for this metric</value>
    public int? Count { get; set; }
}
