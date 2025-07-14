using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class UserPresenceEvent
{
    /// <summary>
    /// A unique (V4 UUID) eventId for this event
    /// </summary>
    /// <value>A unique (V4 UUID) eventId for this event</value>
    public string EventId { get; set; }

    /// <summary>
    /// A Date Time representing the time this event occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>A Date Time representing the time this event occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? EventDateTime { get; set; }

    /// <summary>
    /// The User ID of the user associated with this UserPresence
    /// </summary>
    /// <value>The User ID of the user associated with this UserPresence</value>
    public string UserId { get; set; }

    /// <summary>
    /// The id (V4 UUID) of the presence source being updated
    /// </summary>
    /// <value>The id (V4 UUID) of the presence source being updated</value>
    public string SourceId { get; set; }

    /// <summary>
    /// The id (UUID) of the presence definition that the user presence is associated with
    /// </summary>
    /// <value>The id (UUID) of the presence definition that the user presence is associated with</value>
    public string PresenceDefinitionId { get; set; }

    /// <summary>
    /// The message associated with the presence
    /// </summary>
    /// <value>The message associated with the presence</value>
    public string Message { get; set; }
}
