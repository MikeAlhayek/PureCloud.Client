using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class WemCoachingUserNotificationTopicCoachingUserNotification
{
    /// <summary>
    /// Gets or Sets ActionType
    /// </summary>
    public WemCoachingUserNotificationTopicCoachingUserNotificationActionTypeEnum? ActionType { get; set; }

    /// <summary>
    /// Gets or Sets Relationship
    /// </summary>
    public WemCoachingUserNotificationTopicCoachingUserNotificationRelationshipEnum? Relationship { get; set; }

    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    public WemCoachingUserNotificationTopicCoachingUserNotificationStatusEnum? Status { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets MarkedAsRead
    /// </summary>
    public bool? MarkedAsRead { get; set; }

    /// <summary>
    /// Gets or Sets Appointment
    /// </summary>
    public WemCoachingUserNotificationTopicCoachingAppointmentReference Appointment { get; set; }

    /// <summary>
    /// Gets or Sets DateStart
    /// </summary>
    public DateTime? DateStart { get; set; }

    /// <summary>
    /// Gets or Sets LengthInMinutes
    /// </summary>
    public long? LengthInMinutes { get; set; }
}
