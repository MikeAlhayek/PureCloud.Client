using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class RoutingActivityData
{
    /// <summary>
    /// A mapping from grouping dimension to value
    /// </summary>
    /// <value>A mapping from grouping dimension to value</value>
    public Dictionary<string, string> Group { get; set; }

    /// <summary>
    /// Data for metrics
    /// </summary>
    /// <value>Data for metrics</value>
    public IEnumerable<RoutingActivityMetricValue> Data { get; set; }

    /// <summary>
    /// Flag for a truncated list of entities. If truncated, the first half of the list of entities will contain the oldest entities and the second half the newest entities.
    /// </summary>
    public bool? Truncated { get; set; }

    /// <summary>
    /// Details for active entities
    /// </summary>
    /// <value>Details for active entities</value>
    public IEnumerable<RoutingActivityEntityData> Entities { get; set; }
}
