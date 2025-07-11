using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class CoachingAppointmentStatusResponse
{
    /// <summary>
    /// The status of the coaching appointment
    /// </summary>
    /// <value>The status of the coaching appointment</value>
    public CoachingAppointmentStatusResponseStatusEnum? Status { get; set; }

    /// <summary>
    /// The coaching appointment this status belongs to
    /// </summary>
    /// <value>The coaching appointment this status belongs to</value>
    public CoachingAppointmentReference Appointment { get; set; }

    /// <summary>
    /// User who updated the status
    /// </summary>
    /// <value>User who updated the status</value>
    public UserReference CreatedBy { get; set; }

    /// <summary>
    /// Creation time of the status. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Creation time of the status. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateCreated { get; set; }
}
