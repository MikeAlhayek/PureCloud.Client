using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class EmailRoutingTransferEvent
{
    /// <summary>
    /// Indicates the desired type of transfer.
    /// </summary>
    /// <value>Indicates the desired type of transfer.</value>
    public EmailRoutingTransferEventTransferTypeEnum? TransferType { get; set; }

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
    /// The id (V4 UUID) used by the external platform to refer to the transfer in subsequent *Transfer events.
    /// </summary>
    /// <value>The id (V4 UUID) used by the external platform to refer to the transfer in subsequent *Transfer events.</value>
    public string CommandId { get; set; }

    /// <summary>
    /// Indicates the desired type of transfer.
    /// </summary>
    /// <value>Indicates the desired type of transfer.</value>
    public string InitiatingCommunicationId { get; set; }

    /// <summary>
    /// The id (V4 UUID) of the communication that is being transferred away from. In many cases this will be the same as the &#x60;initiatingCommunicationId&#x60;.
    /// </summary>
    /// <value>The id (V4 UUID) of the communication that is being transferred away from. In many cases this will be the same as the &#x60;initiatingCommunicationId&#x60;.</value>
    public string TargetCommunicationId { get; set; }

    /// <summary>
    /// The id (V4 UUID) of the communication that is being transferred.
    /// </summary>
    /// <value>The id (V4 UUID) of the communication that is being transferred.</value>
    public string ObjectCommunicationId { get; set; }

    /// <summary>
    /// The id (V4 UUID) of the desired destination queue that the object communication should be transferred to.
    /// </summary>
    /// <value>The id (V4 UUID) of the desired destination queue that the object communication should be transferred to.</value>
    public string DestinationQueueId { get; set; }

    /// <summary>
    /// The unique identifier (V4 UUID) for the language that should be used to determine the destination for the conversation.
    /// </summary>
    /// <value>The unique identifier (V4 UUID) for the language that should be used to determine the destination for the conversation.</value>
    public string LanguageId { get; set; }

    /// <summary>
    /// The unique identifiers (V4 UUID) for the skills that should be used to determine the destination for the conversation.
    /// </summary>
    /// <value>The unique identifiers (V4 UUID) for the skills that should be used to determine the destination for the conversation.</value>
    public IEnumerable<string> SkillIds { get; set; }
}
