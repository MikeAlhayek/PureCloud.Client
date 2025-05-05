using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Metadata information about a message.
/// </summary>

public partial class QueueConversationVideoEventTopicMessageMetadata : IEquatable<QueueConversationVideoEventTopicMessageMetadata>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="QueueConversationVideoEventTopicMessageMetadata" /> class.
    /// </summary>
    /// <param name="Type">Message type..</param>
    /// <param name="Events">List of message events, if any.</param>
    /// <param name="Content">List of message content, if any.</param>
    public QueueConversationVideoEventTopicMessageMetadata(string Type = null, List<QueueConversationVideoEventTopicMessageMetadataEvent> Events = null, List<QueueConversationVideoEventTopicMessageMetadataContent> Content = null)
    {
        this.Type = Type;
        this.Events = Events;
        this.Content = Content;

    }



    /// <summary>
    /// Message type.
    /// </summary>
    /// <value>Message type.</value>
    [JsonPropertyName("type")]
    public string Type { get; set; }



    /// <summary>
    /// List of message events, if any
    /// </summary>
    /// <value>List of message events, if any</value>
    [JsonPropertyName("events")]
    public List<QueueConversationVideoEventTopicMessageMetadataEvent> Events { get; set; }



    /// <summary>
    /// List of message content, if any
    /// </summary>
    /// <value>List of message content, if any</value>
    [JsonPropertyName("content")]
    public List<QueueConversationVideoEventTopicMessageMetadataContent> Content { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class QueueConversationVideoEventTopicMessageMetadata {\n");

        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  Events: ").Append(Events).Append("\n");
        sb.Append("  Content: ").Append(Content).Append("\n");
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
        return Equals(obj as QueueConversationVideoEventTopicMessageMetadata);
    }

    /// <summary>
    /// Returns true if QueueConversationVideoEventTopicMessageMetadata instances are equal
    /// </summary>
    /// <param name="other">Instance of QueueConversationVideoEventTopicMessageMetadata to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(QueueConversationVideoEventTopicMessageMetadata other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Type == other.Type ||
                Type != null &&
                Type.Equals(other.Type)
            ) &&
            (
                Events == other.Events ||
                Events != null &&
                Events.SequenceEqual(other.Events)
            ) &&
            (
                Content == other.Content ||
                Content != null &&
                Content.SequenceEqual(other.Content)
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
            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
            }

            if (Events != null)
            {
                hash = hash * 59 + Events.GetHashCode();
            }

            if (Content != null)
            {
                hash = hash * 59 + Content.GetHashCode();
            }

            return hash;
        }
    }
}
