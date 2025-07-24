using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class RecordingAttachment
{
    /// <summary>
    /// The type of attachment this instance represents.
    /// </summary>
    /// <value>The type of attachment this instance represents.</value>
    public RecordingAttachmentMediaTypeEnum? MediaType { get; set; }

    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    public string Id { get; set; }

    /// <summary>
    /// URL of the attachment.
    /// </summary>
    /// <value>URL of the attachment.</value>
    public string Url { get; set; }

    /// <summary>
    /// Attachment mime type.
    /// </summary>
    /// <value>Attachment mime type.</value>
    public string Mime { get; set; }

    /// <summary>
    /// Text associated with attachment such as an image caption.
    /// </summary>
    /// <value>Text associated with attachment such as an image caption.</value>
    public string Text { get; set; }

    /// <summary>
    /// Suggested file name for attachment.
    /// </summary>
    /// <value>Suggested file name for attachment.</value>
    public string FileName { get; set; }
}
