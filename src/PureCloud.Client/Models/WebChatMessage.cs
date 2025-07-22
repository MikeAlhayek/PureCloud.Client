using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class WebChatMessage
{
    /// <summary>
    /// The purpose of the message within the conversation, such as a standard text entry versus a greeting.
    /// </summary>
    /// <value>The purpose of the message within the conversation, such as a standard text entry versus a greeting.</value>
    public WebChatMessageBodyTypeEnum? BodyType { get; set; }

    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    public string Name { get; set; }

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
    /// The message body.
    /// </summary>
    /// <value>The message body.</value>
    public string Body { get; set; }

    /// <summary>
    /// The timestamp of the message, in ISO-8601 format
    /// </summary>
    /// <value>The timestamp of the message, in ISO-8601 format</value>
    public DateTime? Timestamp { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
