using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class EmailCommunicationEndedEvent
{
    /// <summary>
    /// Indicates how this communication was ended.
    /// </summary>
    /// <value>Indicates how this communication was ended.</value>
    public EmailCommunicationEndedEventDisconnectTypeEnum? DisconnectType { get; set; }

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
    /// A unique Id (V4 UUID) identifying this conversation
    /// </summary>
    /// <value>A unique Id (V4 UUID) identifying this conversation</value>
    public string ConversationId { get; set; }

    /// <summary>
    /// A unique Id (V4 UUID) identifying this communication.
    /// </summary>
    /// <value>A unique Id (V4 UUID) identifying this communication.</value>
    public string CommunicationId { get; set; }
}
