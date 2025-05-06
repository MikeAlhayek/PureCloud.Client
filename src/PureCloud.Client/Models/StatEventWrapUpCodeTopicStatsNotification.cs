using System.Collections;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class StatEventWrapUpCodeTopicStatsNotification
{
    /// <summary>
    /// Gets or Sets Group
    /// </summary>
    public Dictionary<string, string> Group { get; set; }


    /// <summary>
    /// Gets or Sets Data
    /// </summary>
    public IEnumerable<StatEventWrapUpCodeTopicIntervalMetrics> Data { get; set; }
}
