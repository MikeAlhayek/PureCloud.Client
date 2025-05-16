using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class QueueConversationVideoEventTopicMessageSticker
{
    /// <summary>
    /// The location of the sticker, useful for retrieving it
    /// </summary>
    /// <value>The location of the sticker, useful for retrieving it</value>
    public string Url { get; set; }

    /// <summary>
    /// The unique id of the the sticker object.
    /// </summary>
    /// <value>The unique id of the the sticker object.</value>
    public string Id { get; set; }
}
