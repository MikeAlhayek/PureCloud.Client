using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class DialerSequenceScheduleConfigChangeRecurrencePattern
{
    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    public DialerSequenceScheduleConfigChangeRecurrencePatternTypeEnum? Type { get; set; }

    /// <summary>
    /// the amount of time in between occurrences
    /// </summary>
    /// <value>the amount of time in between occurrences</value>
    public long? Interval { get; set; }

    /// <summary>
    /// the day(s) of the week the occurrence happens
    /// </summary>
    /// <value>the day(s) of the week the occurrence happens</value>
    public IEnumerable<string> DaysOfWeek { get; set; }

    /// <summary>
    /// Gets or Sets AdditionalProperties
    /// </summary>
    public Dictionary<string, object> AdditionalProperties { get; set; }
}
