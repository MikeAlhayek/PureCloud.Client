using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ConversationMessageEventTopicMessageMedia
{
    /// <summary>
    /// The location of the media, useful for retrieving it
    /// </summary>
    /// <value>The location of the media, useful for retrieving it</value>
    public string Url { get; set; }

    /// <summary>
    /// The optional internet media type of the the media object.  If null then the media type should be dictated by the url
    /// </summary>
    /// <value>The optional internet media type of the the media object.  If null then the media type should be dictated by the url</value>
    public string MediaType { get; set; }

    /// <summary>
    /// The optional content length of the the media object, in bytes.
    /// </summary>
    /// <value>The optional content length of the the media object, in bytes.</value>
    public long? ContentLengthBytes { get; set; }

    /// <summary>
    /// The optional name of the the media object.
    /// </summary>
    /// <value>The optional name of the the media object.</value>
    public string Name { get; set; }

    /// <summary>
    /// The optional id of the the media object.
    /// </summary>
    /// <value>The optional id of the the media object.</value>
    public string Id { get; set; }
}
