using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ChatSendMessageResponse
{
    /// <summary>
    /// The id of the created message
    /// </summary>
    /// <value>The id of the created message</value>
    public string Id { get; set; }
}
