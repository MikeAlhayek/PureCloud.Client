using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// QueueConversationMessageEventTopicMessageMetadataEvent
/// </summary>
[DataContract]
public partial class QueueConversationMessageEventTopicMessageMetadataEvent : IEquatable<QueueConversationMessageEventTopicMessageMetadataEvent>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="QueueConversationMessageEventTopicMessageMetadataEvent" /> class.
    /// </summary>
    /// <param name="EventType">Type of this event element..</param>
    /// <param name="SubType">Event subtype, if any.</param>
    public QueueConversationMessageEventTopicMessageMetadataEvent(string EventType = null, string SubType = null)
    {
        this.EventType = EventType;
        this.SubType = SubType;

    }



    /// <summary>
    /// Type of this event element.
    /// </summary>
    /// <value>Type of this event element.</value>
    [DataMember(Name = "eventType", EmitDefaultValue = false)]
    public string EventType { get; set; }



    /// <summary>
    /// Event subtype, if any
    /// </summary>
    /// <value>Event subtype, if any</value>
    [DataMember(Name = "subType", EmitDefaultValue = false)]
    public string SubType { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class QueueConversationMessageEventTopicMessageMetadataEvent {\n");

        sb.Append("  EventType: ").Append(EventType).Append("\n");
        sb.Append("  SubType: ").Append(SubType).Append("\n");
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
        return Equals(obj as QueueConversationMessageEventTopicMessageMetadataEvent);
    }

    /// <summary>
    /// Returns true if QueueConversationMessageEventTopicMessageMetadataEvent instances are equal
    /// </summary>
    /// <param name="other">Instance of QueueConversationMessageEventTopicMessageMetadataEvent to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(QueueConversationMessageEventTopicMessageMetadataEvent other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                EventType == other.EventType ||
                EventType != null &&
                EventType.Equals(other.EventType)
            ) &&
            (
                SubType == other.SubType ||
                SubType != null &&
                SubType.Equals(other.SubType)
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
            if (EventType != null)
            {
                hash = hash * 59 + EventType.GetHashCode();
            }

            if (SubType != null)
            {
                hash = hash * 59 + SubType.GetHashCode();
            }

            return hash;
        }
    }
}
