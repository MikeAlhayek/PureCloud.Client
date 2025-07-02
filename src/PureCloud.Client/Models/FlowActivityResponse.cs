using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class FlowActivityResponse
{
    /// <summary>
    /// Dimension that is used as an entityId
    /// </summary>
    /// <value>Dimension that is used as an entityId</value>
    public FlowActivityResponseEntityIdDimensionEnum? EntityIdDimension { get; set; }

    /// <summary>
    /// Query results
    /// </summary>
    /// <value>Query results</value>
    public IEnumerable<FlowActivityData> Results { get; set; }
}
