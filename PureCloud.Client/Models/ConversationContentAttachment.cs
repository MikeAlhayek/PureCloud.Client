using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Attachment object.
/// </summary>

public partial class ConversationContentAttachment : IEquatable<ConversationContentAttachment>
{
    /// <summary>
    /// The type of attachment this instance represents.
    /// </summary>
    /// <value>The type of attachment this instance represents.</value>
    
    public enum MediaTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Image for "Image"
        /// </summary>
        [EnumMember(Value = "Image")]
        Image,

        /// <summary>
        /// Enum Video for "Video"
        /// </summary>
        [EnumMember(Value = "Video")]
        Video,

        /// <summary>
        /// Enum Audio for "Audio"
        /// </summary>
        [EnumMember(Value = "Audio")]
        Audio,

        /// <summary>
        /// Enum File for "File"
        /// </summary>
        [EnumMember(Value = "File")]
        File,

        /// <summary>
        /// Enum Link for "Link"
        /// </summary>
        [EnumMember(Value = "Link")]
        Link
    }
    /// <summary>
    /// The type of attachment this instance represents.
    /// </summary>
    /// <value>The type of attachment this instance represents.</value>
    [JsonPropertyName("mediaType")]
    public MediaTypeEnum? MediaType { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="ConversationContentAttachment" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected ConversationContentAttachment() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ConversationContentAttachment" /> class.
    /// </summary>
    /// <param name="Id">Provider specific ID for attachment. For example, a LINE sticker ID..</param>
    /// <param name="MediaType">The type of attachment this instance represents. (required).</param>
    /// <param name="Url">URL of the attachment..</param>
    /// <param name="Mime">Attachment mime type (https://www.iana.org/assignments/media-types/media-types.xhtml)..</param>
    /// <param name="Text">Text associated with attachment such as an image caption..</param>
    /// <param name="Sha256">Secure hash of the attachment content..</param>
    /// <param name="Filename">Suggested file name for attachment..</param>
    /// <param name="ContentSizeBytes">Size in bytes of the attachment content..</param>
    public ConversationContentAttachment(string Id = null, MediaTypeEnum? MediaType = null, string Url = null, string Mime = null, string Text = null, string Sha256 = null, string Filename = null, long? ContentSizeBytes = null)
    {
        this.Id = Id;
        this.MediaType = MediaType;
        this.Url = Url;
        this.Mime = Mime;
        this.Text = Text;
        this.Sha256 = Sha256;
        this.Filename = Filename;
        this.ContentSizeBytes = ContentSizeBytes;

    }



    /// <summary>
    /// Provider specific ID for attachment. For example, a LINE sticker ID.
    /// </summary>
    /// <value>Provider specific ID for attachment. For example, a LINE sticker ID.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }





    /// <summary>
    /// URL of the attachment.
    /// </summary>
    /// <value>URL of the attachment.</value>
    [JsonPropertyName("url")]
    public string Url { get; set; }



    /// <summary>
    /// Attachment mime type (https://www.iana.org/assignments/media-types/media-types.xhtml).
    /// </summary>
    /// <value>Attachment mime type (https://www.iana.org/assignments/media-types/media-types.xhtml).</value>
    [JsonPropertyName("mime")]
    public string Mime { get; set; }



    /// <summary>
    /// Text associated with attachment such as an image caption.
    /// </summary>
    /// <value>Text associated with attachment such as an image caption.</value>
    [JsonPropertyName("text")]
    public string Text { get; set; }



    /// <summary>
    /// Secure hash of the attachment content.
    /// </summary>
    /// <value>Secure hash of the attachment content.</value>
    [JsonPropertyName("sha256")]
    public string Sha256 { get; set; }



    /// <summary>
    /// Suggested file name for attachment.
    /// </summary>
    /// <value>Suggested file name for attachment.</value>
    [JsonPropertyName("filename")]
    public string Filename { get; set; }



    /// <summary>
    /// Size in bytes of the attachment content.
    /// </summary>
    /// <value>Size in bytes of the attachment content.</value>
    [JsonPropertyName("contentSizeBytes")]
    public long? ContentSizeBytes { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ConversationContentAttachment {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  MediaType: ").Append(MediaType).Append("\n");
        sb.Append("  Url: ").Append(Url).Append("\n");
        sb.Append("  Mime: ").Append(Mime).Append("\n");
        sb.Append("  Text: ").Append(Text).Append("\n");
        sb.Append("  Sha256: ").Append(Sha256).Append("\n");
        sb.Append("  Filename: ").Append(Filename).Append("\n");
        sb.Append("  ContentSizeBytes: ").Append(ContentSizeBytes).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }


    /// <summary>
    /// Returns true if objects are equal
    /// </summary>
    /// <param name="obj">Object to be compared</param>
    /// <returns>Boolean</returns>
    public override bool Equals(object obj)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        return Equals(obj as ConversationContentAttachment);
    }

    /// <summary>
    /// Returns true if ConversationContentAttachment instances are equal
    /// </summary>
    /// <param name="other">Instance of ConversationContentAttachment to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ConversationContentAttachment other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Id == other.Id ||
                Id != null &&
                Id.Equals(other.Id)
            ) &&
            (
                MediaType == other.MediaType ||
                MediaType != null &&
                MediaType.Equals(other.MediaType)
            ) &&
            (
                Url == other.Url ||
                Url != null &&
                Url.Equals(other.Url)
            ) &&
            (
                Mime == other.Mime ||
                Mime != null &&
                Mime.Equals(other.Mime)
            ) &&
            (
                Text == other.Text ||
                Text != null &&
                Text.Equals(other.Text)
            ) &&
            (
                Sha256 == other.Sha256 ||
                Sha256 != null &&
                Sha256.Equals(other.Sha256)
            ) &&
            (
                Filename == other.Filename ||
                Filename != null &&
                Filename.Equals(other.Filename)
            ) &&
            (
                ContentSizeBytes == other.ContentSizeBytes ||
                ContentSizeBytes != null &&
                ContentSizeBytes.Equals(other.ContentSizeBytes)
            );
    }

    /// <summary>
    /// Gets the hash code
    /// </summary>
    /// <returns>Hash code</returns>
    public override int GetHashCode()
    {
        // credit: http://stackoverflow.com/a/263416/677735
        unchecked // Overflow is fine, just wrap
        {
            int hash = 41;
            // Suitable nullity checks etc, of course :)
            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            if (MediaType != null)
            {
                hash = hash * 59 + MediaType.GetHashCode();
            }

            if (Url != null)
            {
                hash = hash * 59 + Url.GetHashCode();
            }

            if (Mime != null)
            {
                hash = hash * 59 + Mime.GetHashCode();
            }

            if (Text != null)
            {
                hash = hash * 59 + Text.GetHashCode();
            }

            if (Sha256 != null)
            {
                hash = hash * 59 + Sha256.GetHashCode();
            }

            if (Filename != null)
            {
                hash = hash * 59 + Filename.GetHashCode();
            }

            if (ContentSizeBytes != null)
            {
                hash = hash * 59 + ContentSizeBytes.GetHashCode();
            }

            return hash;
        }
    }
}
