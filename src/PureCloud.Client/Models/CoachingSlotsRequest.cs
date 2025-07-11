using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class CoachingSlotsRequest
{
    /// <summary>
    /// Range of time to get slots for scheduling coaching appointments. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss
    /// </summary>
    /// <value>Range of time to get slots for scheduling coaching appointments. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss</value>
    public string Interval { get; set; }

    /// <summary>
    /// The duration of coaching appointment to schedule in 15 minutes granularity up to maximum of 60 minutes
    /// </summary>
    /// <value>The duration of coaching appointment to schedule in 15 minutes granularity up to maximum of 60 minutes</value>
    public int? LengthInMinutes { get; set; }

    /// <summary>
    /// List of attendees to determine coaching appointment slots
    /// </summary>
    /// <value>List of attendees to determine coaching appointment slots</value>
    public IEnumerable<string> AttendeeIds { get; set; }

    /// <summary>
    /// List of facilitators to determine coaching appointment slots
    /// </summary>
    /// <value>List of facilitators to determine coaching appointment slots</value>
    public IEnumerable<string> FacilitatorIds { get; set; }

    /// <summary>
    /// List of appointment ids to exclude from consideration when determining blocked slots
    /// </summary>
    /// <value>List of appointment ids to exclude from consideration when determining blocked slots</value>
    public IEnumerable<string> InterruptibleAppointmentIds { get; set; }
}
