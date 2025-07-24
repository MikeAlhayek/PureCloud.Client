using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// Attachment object.
/// </summary>
public sealed class ConversationContentAttachment
{
    // The type of attachment this instance represents.
    public MediaType? MediaType { get; set; }

    // Provider specific ID for attachment. For example, a LINE sticker ID.
    public string Id { get; set; }

    // URL of the attachment.
    public string Url { get; set; }

    // Attachment mime type (https://www.iana.org/assignments/media-types/media-types.xhtml).
    public string Mime { get; set; }

    // Text associated with attachment such as an image caption.
    public string Text { get; set; }

    // Secure hash of the attachment content.
    public string Sha256 { get; set; }

    // Suggested file name for attachment.
    public string Filename { get; set; }

    // Size in bytes of the attachment content.
    public long? ContentSizeBytes { get; set; }
}
