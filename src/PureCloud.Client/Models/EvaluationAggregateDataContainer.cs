using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class EvaluationAggregateDataContainer
{
    /// <summary>
    /// A mapping from dimension to value
    /// </summary>
    /// <value>A mapping from dimension to value</value>
    public Dictionary<string, string> Group { get; set; }

    /// <summary>
    /// Gets or Sets Data
    /// </summary>
    public IEnumerable<StatisticalResponse> Data { get; set; }
}
