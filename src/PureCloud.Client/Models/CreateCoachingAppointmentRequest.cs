using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class CreateCoachingAppointmentRequest
{
    /// <summary>
    /// The name of coaching appointment.
    /// </summary>
    /// <value>The name of coaching appointment.</value>
    public string Name { get; set; }

    /// <summary>
    /// The description of coaching appointment.
    /// </summary>
    /// <value>The description of coaching appointment.</value>
    public string Description { get; set; }

    /// <summary>
    /// The date/time the coaching appointment starts. Times will be rounded down to the minute. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date/time the coaching appointment starts. Times will be rounded down to the minute. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateStart { get; set; }

    /// <summary>
    /// The duration of coaching appointment in minutes.
    /// </summary>
    /// <value>The duration of coaching appointment in minutes.</value>
    public int? LengthInMinutes { get; set; }

    /// <summary>
    /// The facilitator ID of coaching appointment.
    /// </summary>
    /// <value>The facilitator ID of coaching appointment.</value>
    public string FacilitatorId { get; set; }

    /// <summary>
    /// IDs of attendees in the coaching appointment.
    /// </summary>
    /// <value>IDs of attendees in the coaching appointment.</value>
    public IEnumerable<string> AttendeeIds { get; set; }

    /// <summary>
    /// IDs of conversations associated with this coaching appointment.
    /// </summary>
    /// <value>IDs of conversations associated with this coaching appointment.</value>
    public IEnumerable<string> ConversationIds { get; set; }

    /// <summary>
    /// IDs of documents associated with this coaching appointment.
    /// </summary>
    /// <value>IDs of documents associated with this coaching appointment.</value>
    public IEnumerable<string> DocumentIds { get; set; }

    /// <summary>
    /// The Workforce Management schedule the appointment is associated with.
    /// </summary>
    /// <value>The Workforce Management schedule the appointment is associated with.</value>
    public WfmScheduleReference WfmSchedule { get; set; }

    /// <summary>
    /// The list of external links related to the appointment
    /// </summary>
    /// <value>The list of external links related to the appointment</value>
    public IEnumerable<string> ExternalLinks { get; set; }

    /// <summary>
    /// The location of the appointment
    /// </summary>
    /// <value>The location of the appointment</value>
    public string Location { get; set; }

    /// <summary>
    /// Whether to share the insight data
    /// </summary>
    /// <value>Whether to share the insight data</value>
    public bool? ShareInsightsData { get; set; }
}
