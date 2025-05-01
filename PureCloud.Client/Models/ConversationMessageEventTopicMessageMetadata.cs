using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ConversationMessageEventTopicMessageMetadata
/// </summary>
[DataContract]
public partial class ConversationMessageEventTopicMessageMetadata : IEquatable<ConversationMessageEventTopicMessageMetadata>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ConversationMessageEventTopicMessageMetadata" /> class.
    /// </summary>
    /// <param name="Type">Message type..</param>
    /// <param name="Events">List of message events, if any.</param>
    /// <param name="Content">List of message content, if any.</param>
    public ConversationMessageEventTopicMessageMetadata(string Type = null, List<ConversationMessageEventTopicMessageMetadataEvent> Events = null, List<ConversationMessageEventTopicMessageMetadataContent> Content = null)
    {
        this.Type = Type;
        this.Events = Events;
        this.Content = Content;

    }



    /// <summary>
    /// Message type.
    /// </summary>
    /// <value>Message type.</value>
    [DataMember(Name = "type", EmitDefaultValue = false)]
    public string Type { get; set; }



    /// <summary>
    /// List of message events, if any
    /// </summary>
    /// <value>List of message events, if any</value>
    [DataMember(Name = "events", EmitDefaultValue = false)]
    public List<ConversationMessageEventTopicMessageMetadataEvent> Events { get; set; }



    /// <summary>
    /// List of message content, if any
    /// </summary>
    /// <value>List of message content, if any</value>
    [DataMember(Name = "content", EmitDefaultValue = false)]
    public List<ConversationMessageEventTopicMessageMetadataContent> Content { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ConversationMessageEventTopicMessageMetadata {\n");

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
        return Equals(obj as ConversationMessageEventTopicMessageMetadata);
    }

    /// <summary>
    /// Returns true if ConversationMessageEventTopicMessageMetadata instances are equal
    /// </summary>
    /// <param name="other">Instance of ConversationMessageEventTopicMessageMetadata to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ConversationMessageEventTopicMessageMetadata other)
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
