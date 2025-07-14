using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class EmailRoutingEstablishedEvent
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
    /// The id of the queue that is routing this conversation.
    /// </summary>
    /// <value>The id of the queue that is routing this conversation.</value>
    public string QueueId { get; set; }

    /// <summary>
    /// The unique identifiers for the skills that should be used to determine the destination for the conversation.
    /// </summary>
    /// <value>The unique identifiers for the skills that should be used to determine the destination for the conversation.</value>
    public IEnumerable<string> SkillIds { get; set; }

    /// <summary>
    /// The unique identifier for the language that should be used to determine the destination for the conversation.
    /// </summary>
    /// <value>The unique identifier for the language that should be used to determine the destination for the conversation.</value>
    public string LanguageId { get; set; }

    /// <summary>
    /// An optional label that categorizes the conversation. Max-utilization settings can be configured at a per-label level.
    /// </summary>
    /// <value>An optional label that categorizes the conversation. Max-utilization settings can be configured at a per-label level.</value>
    public string Label { get; set; }

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
