using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Attachment object.
/// </summary>
[DataContract]
public partial class WebMessagingAttachment : IEquatable<WebMessagingAttachment>
{
    /// <summary>
    /// The type of attachment this instance represents.
    /// </summary>
    /// <value>The type of attachment this instance represents.</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
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
    [DataMember(Name = "mediaType", EmitDefaultValue = false)]
    public MediaTypeEnum? MediaType { get; private set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="WebMessagingAttachment" /> class.
    /// </summary>
    public WebMessagingAttachment()
    {

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; private set; }





    /// <summary>
    /// URL of the attachment.
    /// </summary>
    /// <value>URL of the attachment.</value>
    [DataMember(Name = "url", EmitDefaultValue = false)]
    public string Url { get; private set; }



    /// <summary>
    /// Attachment mime type (https://www.iana.org/assignments/media-types/media-types.xhtml).
    /// </summary>
    /// <value>Attachment mime type (https://www.iana.org/assignments/media-types/media-types.xhtml).</value>
    [DataMember(Name = "mime", EmitDefaultValue = false)]
    public string Mime { get; private set; }



    /// <summary>
    /// Text associated with attachment such as an image caption.
    /// </summary>
    /// <value>Text associated with attachment such as an image caption.</value>
    [DataMember(Name = "text", EmitDefaultValue = false)]
    public string Text { get; private set; }



    /// <summary>
    /// Secure hash of the attachment content.
    /// </summary>
    /// <value>Secure hash of the attachment content.</value>
    [DataMember(Name = "sha256", EmitDefaultValue = false)]
    public string Sha256 { get; private set; }



    /// <summary>
    /// Suggested file name for attachment.
    /// </summary>
    /// <value>Suggested file name for attachment.</value>
    [DataMember(Name = "filename", EmitDefaultValue = false)]
    public string Filename { get; private set; }



    /// <summary>
    /// The file size associated with the file
    /// </summary>
    /// <value>The file size associated with the file</value>
    [DataMember(Name = "fileSize", EmitDefaultValue = false)]
    public int? FileSize { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WebMessagingAttachment {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  MediaType: ").Append(MediaType).Append("\n");
        sb.Append("  Url: ").Append(Url).Append("\n");
        sb.Append("  Mime: ").Append(Mime).Append("\n");
        sb.Append("  Text: ").Append(Text).Append("\n");
        sb.Append("  Sha256: ").Append(Sha256).Append("\n");
        sb.Append("  Filename: ").Append(Filename).Append("\n");
        sb.Append("  FileSize: ").Append(FileSize).Append("\n");
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
        return Equals(obj as WebMessagingAttachment);
    }

    /// <summary>
    /// Returns true if WebMessagingAttachment instances are equal
    /// </summary>
    /// <param name="other">Instance of WebMessagingAttachment to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WebMessagingAttachment other)
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
                FileSize == other.FileSize ||
                FileSize != null &&
                FileSize.Equals(other.FileSize)
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

            if (FileSize != null)
            {
                hash = hash * 59 + FileSize.GetHashCode();
            }

            return hash;
        }
    }
}
