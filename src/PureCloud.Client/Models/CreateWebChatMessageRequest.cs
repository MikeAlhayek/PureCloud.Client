using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class CreateWebChatMessageRequest
{
    /// <summary>
    /// The purpose of the message within the conversation, such as a standard text entry versus a greeting.
    /// </summary>
    /// <value>The purpose of the message within the conversation, such as a standard text entry versus a greeting.</value>
    public CreateWebChatMessageRequestBodyTypeEnum? BodyType { get; set; }

    /// <summary>
    /// The message body. Note that message bodies are limited to 4,000 characters.
    /// </summary>
    /// <value>The message body. Note that message bodies are limited to 4,000 characters.</value>
    public string Body { get; set; }
}
