using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class CoachingAppointmentResponse
{
    /// <summary>
    /// The status of coaching appointment
    /// </summary>
    /// <value>The status of coaching appointment</value>
    public CoachingAppointmentResponseStatusEnum? Status { get; set; }

    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    public string Id { get; set; }

    /// <summary>
    /// The name of coaching appointment
    /// </summary>
    /// <value>The name of coaching appointment</value>
    public string Name { get; set; }

    /// <summary>
    /// The description of coaching appointment
    /// </summary>
    /// <value>The description of coaching appointment</value>
    public string Description { get; set; }

    /// <summary>
    /// The date/time the coaching appointment starts. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date/time the coaching appointment starts. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateStart { get; set; }

    /// <summary>
    /// The duration of coaching appointment in minutes
    /// </summary>
    /// <value>The duration of coaching appointment in minutes</value>
    public int? LengthInMinutes { get; set; }

    /// <summary>
    /// The facilitator of coaching appointment
    /// </summary>
    /// <value>The facilitator of coaching appointment</value>
    public UserReference Facilitator { get; set; }

    /// <summary>
    /// The list of attendees attending the coaching
    /// </summary>
    /// <value>The list of attendees attending the coaching</value>
    public IEnumerable<UserReference> Attendees { get; set; }

    /// <summary>
    /// The user who created the coaching appointment
    /// </summary>
    public UserReference CreatedBy { get; set; }

    /// <summary>
    /// The date/time the coaching appointment was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date/time the coaching appointment was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateCreated { get; set; }

    /// <summary>
    /// The last user to modify the coaching appointment
    /// </summary>
    /// <value>The last user to modify the coaching appointment</value>
    public UserReference ModifiedBy { get; set; }

    /// <summary>
    /// The date/time the coaching appointment was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date/time the coaching appointment was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateModified { get; set; }

    /// <summary>
    /// The list of conversations associated with coaching appointment.
    /// </summary>
    /// <value>The list of conversations associated with coaching appointment.</value>
    public IEnumerable<ConversationReference> Conversations { get; set; }

    /// <summary>
    /// The list of documents associated with coaching appointment.
    /// </summary>
    /// <value>The list of documents associated with coaching appointment.</value>
    public IEnumerable<DocumentReference> Documents { get; set; }

    /// <summary>
    /// Whether the appointment is overdue.
    /// </summary>
    /// <value>Whether the appointment is overdue.</value>
    public bool? IsOverdue { get; set; }

    /// <summary>
    /// The Workforce Management schedule the appointment is associated with.
    /// </summary>
    /// <value>The Workforce Management schedule the appointment is associated with.</value>
    public WfmScheduleReference WfmSchedule { get; set; }

    /// <summary>
    /// The date/time the coaching appointment was set to completed status. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date/time the coaching appointment was set to completed status. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateCompleted { get; set; }

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

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
