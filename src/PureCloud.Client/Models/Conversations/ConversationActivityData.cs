using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ConversationActivityData
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
    public IEnumerable<ConversationActivityMetricValue> Data { get; set; }

    /// <summary>
    /// Flag for a truncated list of entities. If truncated, the first half of the list of entities will contain the oldest entities and the second half the newest entities.
    /// </summary>
    /// <value>Flag for a truncated list of entities. If truncated, the first half of the list of entities will contain the oldest entities and the second half the newest entities.</value>
    public bool? Truncated { get; set; }

    /// <summary>
    /// Details for active entities
    /// </summary>
    /// <value>Details for active entities</value>
    public IEnumerable<ConversationActivityEntityData> Entities { get; set; }
}
