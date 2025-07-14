using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class EmailUserEstablishedEvent
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
    /// A unique Id (V4 UUID) identifying this communication.
    /// </summary>
    /// <value>A unique Id (V4 UUID) identifying this communication.</value>
    public string CommunicationId { get; set; }

    /// <summary>
    /// A unique Id (V4 UUID) identifying the user this communication belongs to.
    /// </summary>
    /// <value>A unique Id (V4 UUID) identifying the user this communication belongs to.</value>
    public string UserId { get; set; }

    /// <summary>
    /// A unique Id (V4 UUID) identifying the queue that the user is emailing on behalf of. Applies to outbound emails only.
    /// </summary>
    /// <value>A unique Id (V4 UUID) identifying the queue that the user is emailing on behalf of. Applies to outbound emails only.</value>
    public string QueueId { get; set; }

    /// <summary>
    /// Indicates whether or not this user will be required to complete after call work.
    /// </summary>
    /// <value>Indicates whether or not this user will be required to complete after call work.</value>
    public bool? AfterCallWorkRequired { get; set; }

    /// <summary>
    /// Metadata about this communication.
    /// </summary>
    /// <value>Metadata about this communication.</value>
    public EmailInitialConfiguration InitialConfiguration { get; set; }

    /// <summary>
    /// Metadata about the source of this communication&#39;s interaction.
    /// </summary>
    /// <value>Metadata about the source of this communication&#39;s interaction.</value>
    public SourceConfiguration SourceConfiguration { get; set; }
}
