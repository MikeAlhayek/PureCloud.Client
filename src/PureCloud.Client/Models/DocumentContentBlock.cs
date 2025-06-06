using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// DocumentContentBlock
/// </summary>

public partial class DocumentContentBlock : IEquatable<DocumentContentBlock>
{
    /// <summary>
    /// The type of the paragraph block.
    /// </summary>
    /// <value>The type of the paragraph block.</value>
    
    public enum TypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Text for "Text"
        /// </summary>
        [EnumMember(Value = "Text")]
        Text,

        /// <summary>
        /// Enum Image for "Image"
        /// </summary>
        [EnumMember(Value = "Image")]
        Image,

        /// <summary>
        /// Enum Video for "Video"
        /// </summary>
        [EnumMember(Value = "Video")]
        Video
    }
    /// <summary>
    /// The type of the paragraph block.
    /// </summary>
    /// <value>The type of the paragraph block.</value>
    [JsonPropertyName("type")]
    public TypeEnum? Type { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="DocumentContentBlock" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected DocumentContentBlock() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="DocumentContentBlock" /> class.
    /// </summary>
    /// <param name="Type">The type of the paragraph block. (required).</param>
    /// <param name="Text">Text. It must contain a value if the type of the block is Text..</param>
    /// <param name="Image">Image. It must contain a value if the type of the block is Image..</param>
    /// <param name="Video">Video. It must contain a value if the type of the block is Video..</param>
    public DocumentContentBlock(TypeEnum? Type = null, DocumentText Text = null, DocumentBodyImage Image = null, DocumentBodyVideo Video = null)
    {
        this.Type = Type;
        this.Text = Text;
        this.Image = Image;
        this.Video = Video;

    }





    /// <summary>
    /// Text. It must contain a value if the type of the block is Text.
    /// </summary>
    /// <value>Text. It must contain a value if the type of the block is Text.</value>
    [JsonPropertyName("text")]
    public DocumentText Text { get; set; }



    /// <summary>
    /// Image. It must contain a value if the type of the block is Image.
    /// </summary>
    /// <value>Image. It must contain a value if the type of the block is Image.</value>
    [JsonPropertyName("image")]
    public DocumentBodyImage Image { get; set; }



    /// <summary>
    /// Video. It must contain a value if the type of the block is Video.
    /// </summary>
    /// <value>Video. It must contain a value if the type of the block is Video.</value>
    [JsonPropertyName("video")]
    public DocumentBodyVideo Video { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class DocumentContentBlock {\n");

        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  Text: ").Append(Text).Append("\n");
        sb.Append("  Image: ").Append(Image).Append("\n");
        sb.Append("  Video: ").Append(Video).Append("\n");
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
        return Equals(obj as DocumentContentBlock);
    }

    /// <summary>
    /// Returns true if DocumentContentBlock instances are equal
    /// </summary>
    /// <param name="other">Instance of DocumentContentBlock to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DocumentContentBlock other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Type == other.Type ||
                Type != null &&
                Type.Equals(other.Type)
            ) &&
            (
                Text == other.Text ||
                Text != null &&
                Text.Equals(other.Text)
            ) &&
            (
                Image == other.Image ||
                Image != null &&
                Image.Equals(other.Image)
            ) &&
            (
                Video == other.Video ||
                Video != null &&
                Video.Equals(other.Video)
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
            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
            }

            if (Text != null)
            {
                hash = hash * 59 + Text.GetHashCode();
            }

            if (Image != null)
            {
                hash = hash * 59 + Image.GetHashCode();
            }

            if (Video != null)
            {
                hash = hash * 59 + Video.GetHashCode();
            }

            return hash;
        }
    }
}
