using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class DialerSequenceScheduleConfigChangeScheduleRecurrence
{
    /// <summary>
    /// the recurrence id
    /// </summary>
    /// <value>the recurrence id</value>
    public string Id { get; set; }

    /// <summary>
    /// scheduled start time represented as an ISO-8601 string; for example, yyyy-MM-ddTHH:mm:ss.SSSZ
    /// </summary>
    /// <value>scheduled start time represented as an ISO-8601 string; for example, yyyy-MM-ddTHH:mm:ss.SSSZ</value>
    public string Start { get; set; }

    /// <summary>
    /// scheduled end time represented as an ISO-8601 string; for example, yyyy-MM-ddTHH:mm:ss.SSSZ
    /// </summary>
    /// <value>scheduled end time represented as an ISO-8601 string; for example, yyyy-MM-ddTHH:mm:ss.SSSZ</value>
    public string End { get; set; }

    /// <summary>
    /// the timezone the recurrence will use
    /// </summary>
    /// <value>the timezone the recurrence will use</value>
    public string TimeZone { get; set; }

    /// <summary>
    /// Gets or Sets Range
    /// </summary>
    public DialerSequenceScheduleConfigChangeRecurrenceRange Range { get; set; }

    /// <summary>
    /// Gets or Sets Pattern
    /// </summary>
    public DialerSequenceScheduleConfigChangeRecurrencePattern Pattern { get; set; }

    /// <summary>
    /// modifications to the original recurrence schedule
    /// </summary>
    /// <value>modifications to the original recurrence schedule</value>
    public IEnumerable<DialerSequenceScheduleConfigChangeAlteration> Alterations { get; set; }

    /// <summary>
    /// Gets or Sets AdditionalProperties
    /// </summary>
    public Dictionary<string, object> AdditionalProperties { get; set; }
}
