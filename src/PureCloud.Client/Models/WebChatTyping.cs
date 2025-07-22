using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class WebChatTyping
{
    /// <summary>
    /// The event identifier of this typing indicator event (useful to guard against event re-delivery
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// The identifier of the conversation
    /// </summary>
    /// <value>The identifier of the conversation</value>
    public WebChatConversation Conversation { get; set; }

    /// <summary>
    /// The member who sent the message
    /// </summary>
    /// <value>The member who sent the message</value>
    public WebChatMemberInfo Sender { get; set; }

    /// <summary>
    /// The timestamp of the message, in ISO-8601 format
    /// </summary>
    /// <value>The timestamp of the message, in ISO-8601 format</value>
    public DateTime? Timestamp { get; set; }
}
