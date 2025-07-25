namespace PureCloud.Client.Models;

/// <summary>
/// Attachment object.
/// </summary>
public sealed class OpenContentAttachment
{
    /// <summary>
    /// The type of attachment this instance represents.
    /// </summary>
    /// <value>The type of attachment this instance represents.</value>
    public OpenContentAttachmentMediaType? MediaType { get; set; }

    /// <summary>
    /// Provider specific ID for attachment. For example, middleware media UUID.
    /// </summary>
    /// <value>Provider specific ID for attachment. For example, middleware media UUID.</value>
    public string Id { get; set; }

    /// <summary>
    /// URL of the attachment.
    /// </summary>
    /// <value>URL of the attachment.</value>
    public string Url { get; set; }

    /// <summary>
    /// Attachment mime type (https://www.iana.org/assignments/media-types/media-types.xhtml).
    /// </summary>
    /// <value>Attachment mime type (https://www.iana.org/assignments/media-types/media-types.xhtml).</value>
    public string Mime { get; set; }

    /// <summary>
    /// Text associated with attachment such as an image caption.
    /// </summary>
    /// <value>Text associated with attachment such as an image caption.</value>
    public string Text { get; set; }

    /// <summary>
    /// Secure hash of the attachment content.
    /// </summary>
    /// <value>Secure hash of the attachment content.</value>
    public string Sha256 { get; set; }

    /// <summary>
    /// Suggested file name for attachment.
    /// </summary>
    /// <value>Suggested file name for attachment.</value>
    public string Filename { get; set; }
}
