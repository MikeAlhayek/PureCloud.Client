using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// MessagingRoutingEstablishedEvent
/// </summary>

public partial class MessagingRoutingEstablishedEvent : IEquatable<MessagingRoutingEstablishedEvent>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="MessagingRoutingEstablishedEvent" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected MessagingRoutingEstablishedEvent() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="MessagingRoutingEstablishedEvent" /> class.
    /// </summary>
    /// <param name="EventId">A unique (V4 UUID) eventId for this event (required).</param>
    /// <param name="EventDateTime">A Date Time representing the time this event occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
    /// <param name="ConversationId">A unique Id (V4 UUID) identifying this conversation (required).</param>
    /// <param name="CommunicationId">A unique Id (V4 UUID) identifying this communication. (required).</param>
    /// <param name="QueueId">The id of the queue that is routing this conversation. (required).</param>
    /// <param name="SkillIds">The unique identifiers for the skills that should be used to determine the destination for the conversation..</param>
    /// <param name="LanguageId">The unique identifier for the language that should be used to determine the destination for the conversation..</param>
    /// <param name="Label">An optional label that categorizes the conversation. Max-utilization settings can be configured at a per-label level..</param>
    /// <param name="InitialConfiguration">Metadata about this communication. (required).</param>
    /// <param name="SourceConfiguration">Metadata about the source of this communication&#39;s interaction. (required).</param>
    public MessagingRoutingEstablishedEvent(string EventId = null, DateTime? EventDateTime = null, string ConversationId = null, string CommunicationId = null, string QueueId = null, List<string> SkillIds = null, string LanguageId = null, string Label = null, MessagingInitialConfiguration InitialConfiguration = null, SourceConfiguration SourceConfiguration = null)
    {
        this.EventId = EventId;
        this.EventDateTime = EventDateTime;
        this.ConversationId = ConversationId;
        this.CommunicationId = CommunicationId;
        this.QueueId = QueueId;
        this.SkillIds = SkillIds;
        this.LanguageId = LanguageId;
        this.Label = Label;
        this.InitialConfiguration = InitialConfiguration;
        this.SourceConfiguration = SourceConfiguration;

    }



    /// <summary>
    /// A unique (V4 UUID) eventId for this event
    /// </summary>
    /// <value>A unique (V4 UUID) eventId for this event</value>
    [JsonPropertyName("eventId")]
    public string EventId { get; set; }



    /// <summary>
    /// A Date Time representing the time this event occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>A Date Time representing the time this event occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("eventDateTime")]
    public DateTime? EventDateTime { get; set; }



    /// <summary>
    /// A unique Id (V4 UUID) identifying this conversation
    /// </summary>
    /// <value>A unique Id (V4 UUID) identifying this conversation</value>
    [JsonPropertyName("conversationId")]
    public string ConversationId { get; set; }



    /// <summary>
    /// A unique Id (V4 UUID) identifying this communication.
    /// </summary>
    /// <value>A unique Id (V4 UUID) identifying this communication.</value>
    [JsonPropertyName("communicationId")]
    public string CommunicationId { get; set; }



    /// <summary>
    /// The id of the queue that is routing this conversation.
    /// </summary>
    /// <value>The id of the queue that is routing this conversation.</value>
    [JsonPropertyName("queueId")]
    public string QueueId { get; set; }



    /// <summary>
    /// The unique identifiers for the skills that should be used to determine the destination for the conversation.
    /// </summary>
    /// <value>The unique identifiers for the skills that should be used to determine the destination for the conversation.</value>
    [JsonPropertyName("skillIds")]
    public List<string> SkillIds { get; set; }



    /// <summary>
    /// The unique identifier for the language that should be used to determine the destination for the conversation.
    /// </summary>
    /// <value>The unique identifier for the language that should be used to determine the destination for the conversation.</value>
    [JsonPropertyName("languageId")]
    public string LanguageId { get; set; }



    /// <summary>
    /// An optional label that categorizes the conversation. Max-utilization settings can be configured at a per-label level.
    /// </summary>
    /// <value>An optional label that categorizes the conversation. Max-utilization settings can be configured at a per-label level.</value>
    [JsonPropertyName("label")]
    public string Label { get; set; }



    /// <summary>
    /// Metadata about this communication.
    /// </summary>
    /// <value>Metadata about this communication.</value>
    [JsonPropertyName("initialConfiguration")]
    public MessagingInitialConfiguration InitialConfiguration { get; set; }



    /// <summary>
    /// Metadata about the source of this communication&#39;s interaction.
    /// </summary>
    /// <value>Metadata about the source of this communication&#39;s interaction.</value>
    [JsonPropertyName("sourceConfiguration")]
    public SourceConfiguration SourceConfiguration { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class MessagingRoutingEstablishedEvent {\n");

        sb.Append("  EventId: ").Append(EventId).Append("\n");
        sb.Append("  EventDateTime: ").Append(EventDateTime).Append("\n");
        sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
        sb.Append("  CommunicationId: ").Append(CommunicationId).Append("\n");
        sb.Append("  QueueId: ").Append(QueueId).Append("\n");
        sb.Append("  SkillIds: ").Append(SkillIds).Append("\n");
        sb.Append("  LanguageId: ").Append(LanguageId).Append("\n");
        sb.Append("  Label: ").Append(Label).Append("\n");
        sb.Append("  InitialConfiguration: ").Append(InitialConfiguration).Append("\n");
        sb.Append("  SourceConfiguration: ").Append(SourceConfiguration).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }


    /// <summary>
    /// Returns true if objects are equal
    /// </summary>
    /// <param name="obj">Object to be compared</param>
    /// <returns>Boolean</returns>
    public override bool Equals(object obj)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        return Equals(obj as MessagingRoutingEstablishedEvent);
    }

    /// <summary>
    /// Returns true if MessagingRoutingEstablishedEvent instances are equal
    /// </summary>
    /// <param name="other">Instance of MessagingRoutingEstablishedEvent to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(MessagingRoutingEstablishedEvent other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                EventId == other.EventId ||
                EventId != null &&
                EventId.Equals(other.EventId)
            ) &&
            (
                EventDateTime == other.EventDateTime ||
                EventDateTime != null &&
                EventDateTime.Equals(other.EventDateTime)
            ) &&
            (
                ConversationId == other.ConversationId ||
                ConversationId != null &&
                ConversationId.Equals(other.ConversationId)
            ) &&
            (
                CommunicationId == other.CommunicationId ||
                CommunicationId != null &&
                CommunicationId.Equals(other.CommunicationId)
            ) &&
            (
                QueueId == other.QueueId ||
                QueueId != null &&
                QueueId.Equals(other.QueueId)
            ) &&
            (
                SkillIds == other.SkillIds ||
                SkillIds != null &&
                SkillIds.SequenceEqual(other.SkillIds)
            ) &&
            (
                LanguageId == other.LanguageId ||
                LanguageId != null &&
                LanguageId.Equals(other.LanguageId)
            ) &&
            (
                Label == other.Label ||
                Label != null &&
                Label.Equals(other.Label)
            ) &&
            (
                InitialConfiguration == other.InitialConfiguration ||
                InitialConfiguration != null &&
                InitialConfiguration.Equals(other.InitialConfiguration)
            ) &&
            (
                SourceConfiguration == other.SourceConfiguration ||
                SourceConfiguration != null &&
                SourceConfiguration.Equals(other.SourceConfiguration)
            );
    }

    /// <summary>
    /// Gets the hash code
    /// </summary>
    /// <returns>Hash code</returns>
    public override int GetHashCode()
    {
        // credit: http://stackoverflow.com/a/263416/677735
        unchecked // Overflow is fine, just wrap
        {
            int hash = 41;
            // Suitable nullity checks etc, of course :)
            if (EventId != null)
            {
                hash = hash * 59 + EventId.GetHashCode();
            }

            if (EventDateTime != null)
            {
                hash = hash * 59 + EventDateTime.GetHashCode();
            }

            if (ConversationId != null)
            {
                hash = hash * 59 + ConversationId.GetHashCode();
            }

            if (CommunicationId != null)
            {
                hash = hash * 59 + CommunicationId.GetHashCode();
            }

            if (QueueId != null)
            {
                hash = hash * 59 + QueueId.GetHashCode();
            }

            if (SkillIds != null)
            {
                hash = hash * 59 + SkillIds.GetHashCode();
            }

            if (LanguageId != null)
            {
                hash = hash * 59 + LanguageId.GetHashCode();
            }

            if (Label != null)
            {
                hash = hash * 59 + Label.GetHashCode();
            }

            if (InitialConfiguration != null)
            {
                hash = hash * 59 + InitialConfiguration.GetHashCode();
            }

            if (SourceConfiguration != null)
            {
                hash = hash * 59 + SourceConfiguration.GetHashCode();
            }

            return hash;
        }
    }
}
