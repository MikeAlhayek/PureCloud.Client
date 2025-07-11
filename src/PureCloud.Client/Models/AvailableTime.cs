using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class AvailableTime
{
    /// <summary>
    /// Workforce Management activity category for this availability period
    /// </summary>
    /// <value>Workforce Management activity category for this availability period</value>
    public AvailableTimeActivityCategoryEnum? ActivityCategory { get; set; }

    /// <summary>
    /// Start of the availability period. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Start of the availability period. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateStart { get; set; }

    /// <summary>
    /// Length of availability period in minutes
    /// </summary>
    /// <value>Length of availability period in minutes</value>
    public int? LengthInMinutes { get; set; }

    /// <summary>
    /// Indicates if this availability period is paid in Workforce Management schedule
    /// </summary>
    /// <value>Indicates if this availability period is paid in Workforce Management schedule</value>
    public bool? IsPaid { get; set; }

    /// <summary>
    /// Workforce Management schedule information associated with the available time
    /// </summary>
    /// <value>Workforce Management schedule information associated with the available time</value>
    public WfmScheduleReference WfmSchedule { get; set; }
}
