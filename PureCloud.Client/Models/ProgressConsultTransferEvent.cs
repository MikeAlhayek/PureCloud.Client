using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ProgressConsultTransferEvent
/// </summary>

public partial class ProgressConsultTransferEvent : IEquatable<ProgressConsultTransferEvent>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="ProgressConsultTransferEvent" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected ProgressConsultTransferEvent() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ProgressConsultTransferEvent" /> class.
    /// </summary>
    /// <param name="EventId">A unique (V4 UUID) eventId for this event (required).</param>
    /// <param name="EventDateTime">A Date Time representing the time this event occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
    /// <param name="ConversationId">A unique Id (V4 UUID) identifying this conversation (required).</param>
    /// <param name="InitiatingCommunicationId">The id (V4 UUID) of the communication representing the participant that is initiating the transfer. (required).</param>
    /// <param name="DestinationCommunicationId">The id (V4 UUID) of the communication that is being transferred to. (required).</param>
    /// <param name="ObjectCommunicationId">The id (V4 UUID) of the communication that is being transferred. (required).</param>
    public ProgressConsultTransferEvent(string EventId = null, DateTime? EventDateTime = null, string ConversationId = null, string InitiatingCommunicationId = null, string DestinationCommunicationId = null, string ObjectCommunicationId = null)
    {
        this.EventId = EventId;
        this.EventDateTime = EventDateTime;
        this.ConversationId = ConversationId;
        this.InitiatingCommunicationId = InitiatingCommunicationId;
        this.DestinationCommunicationId = DestinationCommunicationId;
        this.ObjectCommunicationId = ObjectCommunicationId;

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
    /// The id (V4 UUID) of the communication representing the participant that is initiating the transfer.
    /// </summary>
    /// <value>The id (V4 UUID) of the communication representing the participant that is initiating the transfer.</value>
    [JsonPropertyName("initiatingCommunicationId")]
    public string InitiatingCommunicationId { get; set; }



    /// <summary>
    /// The id (V4 UUID) of the communication that is being transferred to.
    /// </summary>
    /// <value>The id (V4 UUID) of the communication that is being transferred to.</value>
    [JsonPropertyName("destinationCommunicationId")]
    public string DestinationCommunicationId { get; set; }



    /// <summary>
    /// The id (V4 UUID) of the communication that is being transferred.
    /// </summary>
    /// <value>The id (V4 UUID) of the communication that is being transferred.</value>
    [JsonPropertyName("objectCommunicationId")]
    public string ObjectCommunicationId { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ProgressConsultTransferEvent {\n");

        sb.Append("  EventId: ").Append(EventId).Append("\n");
        sb.Append("  EventDateTime: ").Append(EventDateTime).Append("\n");
        sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
        sb.Append("  InitiatingCommunicationId: ").Append(InitiatingCommunicationId).Append("\n");
        sb.Append("  DestinationCommunicationId: ").Append(DestinationCommunicationId).Append("\n");
        sb.Append("  ObjectCommunicationId: ").Append(ObjectCommunicationId).Append("\n");
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
        return Equals(obj as ProgressConsultTransferEvent);
    }

    /// <summary>
    /// Returns true if ProgressConsultTransferEvent instances are equal
    /// </summary>
    /// <param name="other">Instance of ProgressConsultTransferEvent to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ProgressConsultTransferEvent other)
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
                InitiatingCommunicationId == other.InitiatingCommunicationId ||
                InitiatingCommunicationId != null &&
                InitiatingCommunicationId.Equals(other.InitiatingCommunicationId)
            ) &&
            (
                DestinationCommunicationId == other.DestinationCommunicationId ||
                DestinationCommunicationId != null &&
                DestinationCommunicationId.Equals(other.DestinationCommunicationId)
            ) &&
            (
                ObjectCommunicationId == other.ObjectCommunicationId ||
                ObjectCommunicationId != null &&
                ObjectCommunicationId.Equals(other.ObjectCommunicationId)
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

            if (InitiatingCommunicationId != null)
            {
                hash = hash * 59 + InitiatingCommunicationId.GetHashCode();
            }

            if (DestinationCommunicationId != null)
            {
                hash = hash * 59 + DestinationCommunicationId.GetHashCode();
            }

            if (ObjectCommunicationId != null)
            {
                hash = hash * 59 + ObjectCommunicationId.GetHashCode();
            }

            return hash;
        }
    }
}
