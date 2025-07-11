using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class CoachingAppointmentStatusRequest
{
    /// <summary>
    /// The status of the coaching appointment
    /// </summary>
    /// <value>The status of the coaching appointment</value>
    public CoachingAppointmentStatusRequestStatusEnum? Status { get; set; }
}
