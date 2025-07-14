using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class EmailEndTransferEvent
{
    /// <summary>
    /// Indicates whether the transfer completed successfully, was cancelled, or failed for some reason.
    /// </summary>
    /// <value>Indicates whether the transfer completed successfully, was cancelled, or failed for some reason.</value>
    public EmailEndTransferEventFinalStateEnum? FinalState { get; set; }

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
    /// The id (V4 UUID) used to identify the transfer already started by the external platform.
    /// </summary>
    /// <value>The id (V4 UUID) used to identify the transfer already started by the external platform.</value>
    public string CommandId { get; set; }

    /// <summary>
    /// The id (V4 UUID) of the communication that was being transferred.
    /// </summary>
    /// <value>The id (V4 UUID) of the communication that was being transferred.</value>
    public string ObjectCommunicationId { get; set; }
}
