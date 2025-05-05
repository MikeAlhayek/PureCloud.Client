using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// EmailUserEstablishedEvent
/// </summary>

public partial class EmailUserEstablishedEvent : IEquatable<EmailUserEstablishedEvent>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="EmailUserEstablishedEvent" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected EmailUserEstablishedEvent() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="EmailUserEstablishedEvent" /> class.
    /// </summary>
    /// <param name="EventId">A unique (V4 UUID) eventId for this event (required).</param>
    /// <param name="EventDateTime">A Date Time representing the time this event occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
    /// <param name="ConversationId">A unique Id (V4 UUID) identifying this conversation (required).</param>
    /// <param name="CommunicationId">A unique Id (V4 UUID) identifying this communication. (required).</param>
    /// <param name="UserId">A unique Id (V4 UUID) identifying the user this communication belongs to. (required).</param>
    /// <param name="QueueId">A unique Id (V4 UUID) identifying the queue that the user is emailing on behalf of. Applies to outbound emails only..</param>
    /// <param name="AfterCallWorkRequired">Indicates whether or not this user will be required to complete after call work..</param>
    /// <param name="InitialConfiguration">Metadata about this communication. (required).</param>
    /// <param name="SourceConfiguration">Metadata about the source of this communication&#39;s interaction. (required).</param>
    public EmailUserEstablishedEvent(string EventId = null, DateTime? EventDateTime = null, string ConversationId = null, string CommunicationId = null, string UserId = null, string QueueId = null, bool? AfterCallWorkRequired = null, EmailInitialConfiguration InitialConfiguration = null, SourceConfiguration SourceConfiguration = null)
    {
        this.EventId = EventId;
        this.EventDateTime = EventDateTime;
        this.ConversationId = ConversationId;
        this.CommunicationId = CommunicationId;
        this.UserId = UserId;
        this.QueueId = QueueId;
        this.AfterCallWorkRequired = AfterCallWorkRequired;
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
    /// A unique Id (V4 UUID) identifying the user this communication belongs to.
    /// </summary>
    /// <value>A unique Id (V4 UUID) identifying the user this communication belongs to.</value>
    [JsonPropertyName("userId")]
    public string UserId { get; set; }



    /// <summary>
    /// A unique Id (V4 UUID) identifying the queue that the user is emailing on behalf of. Applies to outbound emails only.
    /// </summary>
    /// <value>A unique Id (V4 UUID) identifying the queue that the user is emailing on behalf of. Applies to outbound emails only.</value>
    [JsonPropertyName("queueId")]
    public string QueueId { get; set; }



    /// <summary>
    /// Indicates whether or not this user will be required to complete after call work.
    /// </summary>
    /// <value>Indicates whether or not this user will be required to complete after call work.</value>
    [JsonPropertyName("afterCallWorkRequired")]
    public bool? AfterCallWorkRequired { get; set; }



    /// <summary>
    /// Metadata about this communication.
    /// </summary>
    /// <value>Metadata about this communication.</value>
    [JsonPropertyName("initialConfiguration")]
    public EmailInitialConfiguration InitialConfiguration { get; set; }



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
        sb.Append("class EmailUserEstablishedEvent {\n");

        sb.Append("  EventId: ").Append(EventId).Append("\n");
        sb.Append("  EventDateTime: ").Append(EventDateTime).Append("\n");
        sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
        sb.Append("  CommunicationId: ").Append(CommunicationId).Append("\n");
        sb.Append("  UserId: ").Append(UserId).Append("\n");
        sb.Append("  QueueId: ").Append(QueueId).Append("\n");
        sb.Append("  AfterCallWorkRequired: ").Append(AfterCallWorkRequired).Append("\n");
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
        return Equals(obj as EmailUserEstablishedEvent);
    }

    /// <summary>
    /// Returns true if EmailUserEstablishedEvent instances are equal
    /// </summary>
    /// <param name="other">Instance of EmailUserEstablishedEvent to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(EmailUserEstablishedEvent other)
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
                UserId == other.UserId ||
                UserId != null &&
                UserId.Equals(other.UserId)
            ) &&
            (
                QueueId == other.QueueId ||
                QueueId != null &&
                QueueId.Equals(other.QueueId)
            ) &&
            (
                AfterCallWorkRequired == other.AfterCallWorkRequired ||
                AfterCallWorkRequired != null &&
                AfterCallWorkRequired.Equals(other.AfterCallWorkRequired)
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

            if (UserId != null)
            {
                hash = hash * 59 + UserId.GetHashCode();
            }

            if (QueueId != null)
            {
                hash = hash * 59 + QueueId.GetHashCode();
            }

            if (AfterCallWorkRequired != null)
            {
                hash = hash * 59 + AfterCallWorkRequired.GetHashCode();
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
