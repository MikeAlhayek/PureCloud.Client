using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ContentDatePickerAvailableTime
{
    /// <summary>
    /// The duration of the scheduling event in seconds.
    /// </summary>
    /// <value>The duration of the scheduling event in seconds.</value>
    public long? Duration { get; set; }

    /// <summary>
    /// The date and times of the event being scheduled. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date and times of the event being scheduled. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateTime { get; set; }
}
