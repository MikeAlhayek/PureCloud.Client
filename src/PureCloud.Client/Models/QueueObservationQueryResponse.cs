using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;


public sealed class QueueObservationQueryResponse
{
    /// <summary>
    /// A mapping from system presence to a list of organization presence ids
    /// </summary>
    /// <value>A mapping from system presence to a list of organization presence ids</value>
    public Dictionary<string, IEnumerable<string>> SystemToOrganizationMappings { get; set; }

    /// <summary>
    /// Gets or Sets Results
    /// </summary>
    public IEnumerable<QueueObservationDataContainer> Results { get; set; }
}
