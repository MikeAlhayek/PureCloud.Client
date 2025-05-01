using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ProgressTransferEvent
/// </summary>
[DataContract]
public partial class ProgressTransferEvent : IEquatable<ProgressTransferEvent>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="ProgressTransferEvent" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected ProgressTransferEvent() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ProgressTransferEvent" /> class.
    /// </summary>
    /// <param name="EventId">A unique (V4 UUID) eventId for this event (required).</param>
    /// <param name="EventDateTime">A Date Time representing the time this event occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
    /// <param name="ConversationId">A unique Id (V4 UUID) identifying this conversation (required).</param>
    /// <param name="CommandId">The id (V4 UUID) used to identify the transfer already started by the external platform. (required).</param>
    /// <param name="ObjectCommunicationId">The id (V4 UUID) of the communication that is being transferred. (required).</param>
    /// <param name="DestinationCommunicationId">The id (V4 UUID) of the communication that is being transferred to. (required).</param>
    public ProgressTransferEvent(string EventId = null, DateTime? EventDateTime = null, string ConversationId = null, string CommandId = null, string ObjectCommunicationId = null, string DestinationCommunicationId = null)
    {
        this.EventId = EventId;
        this.EventDateTime = EventDateTime;
        this.ConversationId = ConversationId;
        this.CommandId = CommandId;
        this.ObjectCommunicationId = ObjectCommunicationId;
        this.DestinationCommunicationId = DestinationCommunicationId;

    }



    /// <summary>
    /// A unique (V4 UUID) eventId for this event
    /// </summary>
    /// <value>A unique (V4 UUID) eventId for this event</value>
    [DataMember(Name = "eventId", EmitDefaultValue = false)]
    public string EventId { get; set; }



    /// <summary>
    /// A Date Time representing the time this event occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>A Date Time representing the time this event occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "eventDateTime", EmitDefaultValue = false)]
    public DateTime? EventDateTime { get; set; }



    /// <summary>
    /// A unique Id (V4 UUID) identifying this conversation
    /// </summary>
    /// <value>A unique Id (V4 UUID) identifying this conversation</value>
    [DataMember(Name = "conversationId", EmitDefaultValue = false)]
    public string ConversationId { get; set; }



    /// <summary>
    /// The id (V4 UUID) used to identify the transfer already started by the external platform.
    /// </summary>
    /// <value>The id (V4 UUID) used to identify the transfer already started by the external platform.</value>
    [DataMember(Name = "commandId", EmitDefaultValue = false)]
    public string CommandId { get; set; }



    /// <summary>
    /// The id (V4 UUID) of the communication that is being transferred.
    /// </summary>
    /// <value>The id (V4 UUID) of the communication that is being transferred.</value>
    [DataMember(Name = "objectCommunicationId", EmitDefaultValue = false)]
    public string ObjectCommunicationId { get; set; }



    /// <summary>
    /// The id (V4 UUID) of the communication that is being transferred to.
    /// </summary>
    /// <value>The id (V4 UUID) of the communication that is being transferred to.</value>
    [DataMember(Name = "destinationCommunicationId", EmitDefaultValue = false)]
    public string DestinationCommunicationId { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ProgressTransferEvent {\n");

        sb.Append("  EventId: ").Append(EventId).Append("\n");
        sb.Append("  EventDateTime: ").Append(EventDateTime).Append("\n");
        sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
        sb.Append("  CommandId: ").Append(CommandId).Append("\n");
        sb.Append("  ObjectCommunicationId: ").Append(ObjectCommunicationId).Append("\n");
        sb.Append("  DestinationCommunicationId: ").Append(DestinationCommunicationId).Append("\n");
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
        return Equals(obj as ProgressTransferEvent);
    }

    /// <summary>
    /// Returns true if ProgressTransferEvent instances are equal
    /// </summary>
    /// <param name="other">Instance of ProgressTransferEvent to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ProgressTransferEvent other)
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
                CommandId == other.CommandId ||
                CommandId != null &&
                CommandId.Equals(other.CommandId)
            ) &&
            (
                ObjectCommunicationId == other.ObjectCommunicationId ||
                ObjectCommunicationId != null &&
                ObjectCommunicationId.Equals(other.ObjectCommunicationId)
            ) &&
            (
                DestinationCommunicationId == other.DestinationCommunicationId ||
                DestinationCommunicationId != null &&
                DestinationCommunicationId.Equals(other.DestinationCommunicationId)
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

            if (CommandId != null)
            {
                hash = hash * 59 + CommandId.GetHashCode();
            }

            if (ObjectCommunicationId != null)
            {
                hash = hash * 59 + ObjectCommunicationId.GetHashCode();
            }

            if (DestinationCommunicationId != null)
            {
                hash = hash * 59 + DestinationCommunicationId.GetHashCode();
            }

            return hash;
        }
    }
}
