using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ConsultTransferEvent
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
    /// A unique Id (V4 UUID) identifying this conversation
    /// </summary>
    /// <value>A unique Id (V4 UUID) identifying this conversation</value>
    public string ConversationId { get; set; }

    /// <summary>
    /// The id (V4 UUID) of the communication representing the participant that is initiating the transfer.
    /// </summary>
    /// <value>The id (V4 UUID) of the communication representing the participant that is initiating the transfer.</value>
    public string InitiatingCommunicationId { get; set; }

    /// <summary>
    /// The id (V4 UUID) of the communication that is being transferred to.
    /// </summary>
    /// <value>The id (V4 UUID) of the communication that is being transferred to.</value>
    public string DestinationCommunicationId { get; set; }

    /// <summary>
    /// The id (V4 UUID) of the communication that is being transferred.
    /// </summary>
    /// <value>The id (V4 UUID) of the communication that is being transferred.</value>
    public string ObjectCommunicationId { get; set; }
}
