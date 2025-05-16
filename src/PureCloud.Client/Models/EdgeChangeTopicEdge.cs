using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class EdgeChangeTopicEdge
{
    /// <summary>
    /// Gets or Sets OnlineStatus
    /// </summary>
    public EdgeChangeTopicEdgeOnlineStatusEnum? OnlineStatus { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    public string Id { get; set; }
}
