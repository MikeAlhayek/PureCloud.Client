using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class DialerSequenceScheduleConfigChangeRecurrenceRange
{
    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    public DialerSequenceScheduleConfigChangeRecurrenceRangeTypeEnum? Type { get; set; }

    /// <summary>
    /// the range end date
    /// </summary>
    /// <value>the range end date</value>
    public string End { get; set; }

    /// <summary>
    /// the number of occurrences to happen before ending
    /// </summary>
    /// <value>the number of occurrences to happen before ending</value>
    public long? NumberOfOccurrences { get; set; }

    /// <summary>
    /// Gets or Sets AdditionalProperties
    /// </summary>
    public Dictionary<string, object> AdditionalProperties { get; set; }
}
