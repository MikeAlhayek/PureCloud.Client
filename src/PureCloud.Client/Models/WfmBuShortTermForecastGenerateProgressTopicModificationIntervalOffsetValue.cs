using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class WfmBuShortTermForecastGenerateProgressTopicModificationIntervalOffsetValue
{
    /// <summary>
    /// Gets or Sets IntervalIndex
    /// </summary>
    public long? IntervalIndex { get; set; }

    /// <summary>
    /// Gets or Sets Value
    /// </summary>
    public double? Value { get; set; }
}
