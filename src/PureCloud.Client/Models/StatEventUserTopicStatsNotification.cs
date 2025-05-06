using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class StatEventUserTopicStatsNotification
{
    /// <summary>
    /// Gets or Sets Group
    /// </summary>
    public Dictionary<string, string> Group { get; set; }


    /// <summary>
    /// Gets or Sets Data
    /// </summary>
    public IEnumerable<StatEventUserTopicIntervalMetrics> Data { get; set; }
}
