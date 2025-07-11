using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class CoachingNotification
{
    /// <summary>
    /// Action causing the notification.
    /// </summary>
    /// <value>Action causing the notification.</value>
    public CoachingNotificationActionTypeEnum? ActionType { get; set; }

    /// <summary>
    /// The relationship of this user to this notification's appointment
    /// </summary>
    /// <value>The relationship of this user to this notification's appointment</value>
    public CoachingNotificationRelationshipEnum? Relationship { get; set; }

    /// <summary>
    /// The status of the appointment for this notification
    /// </summary>
    /// <value>The status of the appointment for this notification</value>
    public CoachingNotificationStatusEnum? Status { get; set; }

    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    public string Id { get; set; }

    /// <summary>
    /// The name of the appointment for this notification.
    /// </summary>
    /// <value>The name of the appointment for this notification.</value>
    public string Name { get; set; }

    /// <summary>
    /// Indicates if notification is read or unread
    /// </summary>
    /// <value>Indicates if notification is read or unread</value>
    public bool? MarkedAsRead { get; set; }

    /// <summary>
    /// The start time of the appointment relating to this notification. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The start time of the appointment relating to this notification. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateStart { get; set; }

    /// <summary>
    /// The duration of the appointment on this notification
    /// </summary>
    /// <value>The duration of the appointment on this notification</value>
    public int? LengthInMinutes { get; set; }

    /// <summary>
    /// The user of this notification
    /// </summary>
    /// <value>The user of this notification</value>
    public UserReference User { get; set; }

    /// <summary>
    /// The appointment
    /// </summary>
    /// <value>The appointment</value>
    public CoachingAppointmentResponse Appointment { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
