using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WebChatTyping
/// </summary>

public partial class WebChatTyping : IEquatable<WebChatTyping>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="WebChatTyping" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected WebChatTyping() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="WebChatTyping" /> class.
    /// </summary>
    /// <param name="Id">The event identifier of this typing indicator event (useful to guard against event re-delivery (required).</param>
    /// <param name="Conversation">The identifier of the conversation (required).</param>
    /// <param name="Sender">The member who sent the message (required).</param>
    /// <param name="Timestamp">The timestamp of the message, in ISO-8601 format (required).</param>
    public WebChatTyping(string Id = null, WebChatConversation Conversation = null, WebChatMemberInfo Sender = null, DateTime? Timestamp = null)
    {
        this.Id = Id;
        this.Conversation = Conversation;
        this.Sender = Sender;
        this.Timestamp = Timestamp;

    }



    /// <summary>
    /// The event identifier of this typing indicator event (useful to guard against event re-delivery
    /// </summary>
    /// <value>The event identifier of this typing indicator event (useful to guard against event re-delivery</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// The identifier of the conversation
    /// </summary>
    /// <value>The identifier of the conversation</value>
    [JsonPropertyName("conversation")]
    public WebChatConversation Conversation { get; set; }



    /// <summary>
    /// The member who sent the message
    /// </summary>
    /// <value>The member who sent the message</value>
    [JsonPropertyName("sender")]
    public WebChatMemberInfo Sender { get; set; }



    /// <summary>
    /// The timestamp of the message, in ISO-8601 format
    /// </summary>
    /// <value>The timestamp of the message, in ISO-8601 format</value>
    [JsonPropertyName("timestamp")]
    public DateTime? Timestamp { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WebChatTyping {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Conversation: ").Append(Conversation).Append("\n");
        sb.Append("  Sender: ").Append(Sender).Append("\n");
        sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
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
        return Equals(obj as WebChatTyping);
    }

    /// <summary>
    /// Returns true if WebChatTyping instances are equal
    /// </summary>
    /// <param name="other">Instance of WebChatTyping to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WebChatTyping other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Id == other.Id ||
                Id != null &&
                Id.Equals(other.Id)
            ) &&
            (
                Conversation == other.Conversation ||
                Conversation != null &&
                Conversation.Equals(other.Conversation)
            ) &&
            (
                Sender == other.Sender ||
                Sender != null &&
                Sender.Equals(other.Sender)
            ) &&
            (
                Timestamp == other.Timestamp ||
                Timestamp != null &&
                Timestamp.Equals(other.Timestamp)
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
            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            if (Conversation != null)
            {
                hash = hash * 59 + Conversation.GetHashCode();
            }

            if (Sender != null)
            {
                hash = hash * 59 + Sender.GetHashCode();
            }

            if (Timestamp != null)
            {
                hash = hash * 59 + Timestamp.GetHashCode();
            }

            return hash;
        }
    }
}
