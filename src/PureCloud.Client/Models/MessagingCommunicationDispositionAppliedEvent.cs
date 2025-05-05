using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// MessagingCommunicationDispositionAppliedEvent
/// </summary>

public partial class MessagingCommunicationDispositionAppliedEvent : IEquatable<MessagingCommunicationDispositionAppliedEvent>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="MessagingCommunicationDispositionAppliedEvent" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected MessagingCommunicationDispositionAppliedEvent() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="MessagingCommunicationDispositionAppliedEvent" /> class.
    /// </summary>
    /// <param name="EventId">A unique (V4 UUID) eventId for this event (required).</param>
    /// <param name="EventDateTime">A Date Time representing the time this event occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
    /// <param name="ConversationId">A unique Id (V4 UUID) identifying this conversation (required).</param>
    /// <param name="CommunicationId">A unique Id (V4 UUID) identifying this communication (required).</param>
    /// <param name="Code">The wrapup-code (V4 UUID) used to disposition this interaction. If this value is not provided the disposition is considered skipped..</param>
    /// <param name="Notes">Text entered by the agent to describe the interaction or disposition. Ignored if the disposition is considered skipped..</param>
    /// <param name="Tags">The list of tags selected by the agent to describe the interaction or disposition. Ignored if the disposition is considered skipped..</param>
    public MessagingCommunicationDispositionAppliedEvent(string EventId = null, DateTime? EventDateTime = null, string ConversationId = null, string CommunicationId = null, string Code = null, string Notes = null, List<string> Tags = null)
    {
        this.EventId = EventId;
        this.EventDateTime = EventDateTime;
        this.ConversationId = ConversationId;
        this.CommunicationId = CommunicationId;
        this.Code = Code;
        this.Notes = Notes;
        this.Tags = Tags;

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
    /// A unique Id (V4 UUID) identifying this communication
    /// </summary>
    /// <value>A unique Id (V4 UUID) identifying this communication</value>
    [JsonPropertyName("communicationId")]
    public string CommunicationId { get; set; }



    /// <summary>
    /// The wrapup-code (V4 UUID) used to disposition this interaction. If this value is not provided the disposition is considered skipped.
    /// </summary>
    /// <value>The wrapup-code (V4 UUID) used to disposition this interaction. If this value is not provided the disposition is considered skipped.</value>
    [JsonPropertyName("code")]
    public string Code { get; set; }



    /// <summary>
    /// Text entered by the agent to describe the interaction or disposition. Ignored if the disposition is considered skipped.
    /// </summary>
    /// <value>Text entered by the agent to describe the interaction or disposition. Ignored if the disposition is considered skipped.</value>
    [JsonPropertyName("notes")]
    public string Notes { get; set; }



    /// <summary>
    /// The list of tags selected by the agent to describe the interaction or disposition. Ignored if the disposition is considered skipped.
    /// </summary>
    /// <value>The list of tags selected by the agent to describe the interaction or disposition. Ignored if the disposition is considered skipped.</value>
    [JsonPropertyName("tags")]
    public List<string> Tags { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class MessagingCommunicationDispositionAppliedEvent {\n");

        sb.Append("  EventId: ").Append(EventId).Append("\n");
        sb.Append("  EventDateTime: ").Append(EventDateTime).Append("\n");
        sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
        sb.Append("  CommunicationId: ").Append(CommunicationId).Append("\n");
        sb.Append("  Code: ").Append(Code).Append("\n");
        sb.Append("  Notes: ").Append(Notes).Append("\n");
        sb.Append("  Tags: ").Append(Tags).Append("\n");
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
        return Equals(obj as MessagingCommunicationDispositionAppliedEvent);
    }

    /// <summary>
    /// Returns true if MessagingCommunicationDispositionAppliedEvent instances are equal
    /// </summary>
    /// <param name="other">Instance of MessagingCommunicationDispositionAppliedEvent to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(MessagingCommunicationDispositionAppliedEvent other)
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
                Code == other.Code ||
                Code != null &&
                Code.Equals(other.Code)
            ) &&
            (
                Notes == other.Notes ||
                Notes != null &&
                Notes.Equals(other.Notes)
            ) &&
            (
                Tags == other.Tags ||
                Tags != null &&
                Tags.SequenceEqual(other.Tags)
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

            if (Code != null)
            {
                hash = hash * 59 + Code.GetHashCode();
            }

            if (Notes != null)
            {
                hash = hash * 59 + Notes.GetHashCode();
            }

            if (Tags != null)
            {
                hash = hash * 59 + Tags.GetHashCode();
            }

            return hash;
        }
    }
}
