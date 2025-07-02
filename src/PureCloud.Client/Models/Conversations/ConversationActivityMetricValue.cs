using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ConversationActivityMetricValue
{
    /// <summary>
    /// Metric
    /// </summary>
    /// <value>Metric</value>
    public ConversationActivityMetricValueMetricEnum? Metric { get; set; }

    /// <summary>
    /// Metric qualifier
    /// </summary>
    /// <value>Metric qualifier</value>
    public string Qualifier { get; set; }

    /// <summary>
    /// Entity ids for matching entities if details were requested
    /// </summary>
    /// <value>Entity ids for matching entities if details were requested</value>
    public IEnumerable<string> EntityIds { get; set; }

    /// <summary>
    /// Metric count
    /// </summary>
    /// <value>Metric count</value>
    public int? Count { get; set; }
}
