using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// QueueConversationSocialExpressionEventTopicMessageMetadataEvent
/// </summary>
[DataContract]
public partial class QueueConversationSocialExpressionEventTopicMessageMetadataEvent : IEquatable<QueueConversationSocialExpressionEventTopicMessageMetadataEvent>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="QueueConversationSocialExpressionEventTopicMessageMetadataEvent" /> class.
    /// </summary>
    /// <param name="EventType">Type of this event element..</param>
    /// <param name="SubType">Event subtype, if any.</param>
    public QueueConversationSocialExpressionEventTopicMessageMetadataEvent(string EventType = null, string SubType = null)
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
        sb.Append("class QueueConversationSocialExpressionEventTopicMessageMetadataEvent {\n");

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
        return Equals(obj as QueueConversationSocialExpressionEventTopicMessageMetadataEvent);
    }

    /// <summary>
    /// Returns true if QueueConversationSocialExpressionEventTopicMessageMetadataEvent instances are equal
    /// </summary>
    /// <param name="other">Instance of QueueConversationSocialExpressionEventTopicMessageMetadataEvent to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(QueueConversationSocialExpressionEventTopicMessageMetadataEvent other)
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
