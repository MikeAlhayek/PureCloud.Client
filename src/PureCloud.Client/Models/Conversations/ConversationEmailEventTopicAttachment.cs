using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ConversationEmailEventTopicAttachment
{
    /// <summary>
    /// The unique identifier for the attachment.
    /// </summary>
    /// <value>The unique identifier for the attachment.</value>
    public string AttachmentId { get; set; }

    /// <summary>
    /// The name of the attachment.
    /// </summary>
    /// <value>The name of the attachment.</value>
    public string Name { get; set; }

    /// <summary>
    /// The content uri of the attachment. If set, this is commonly a public api download location.
    /// </summary>
    /// <value>The content uri of the attachment. If set, this is commonly a public api download location.</value>
    public string ContentUri { get; set; }

    /// <summary>
    /// The type of file the attachment is.
    /// </summary>
    /// <value>The type of file the attachment is.</value>
    public string ContentType { get; set; }

    /// <summary>
    /// The length of the attachment file.
    /// </summary>
    /// <value>The length of the attachment file.</value>
    public long? ContentLength { get; set; }
}
