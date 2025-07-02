using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class AgentStateSegmentTypeCount
{
    /// <summary>
    /// Segment type
    /// </summary>
    /// <value>Segment type</value>
    public AgentStateSegmentTypeCountSegmentTypeEnum? SegmentType { get; set; }

    /// <summary>
    /// Count of segment type
    /// </summary>
    /// <value>Count of segment type</value>
    public int? Count { get; set; }
}
