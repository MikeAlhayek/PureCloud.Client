using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// DocumentBodyBlockWithHighlight
/// </summary>

public partial class DocumentBodyBlockWithHighlight : IEquatable<DocumentBodyBlockWithHighlight>
{
    /// <summary>
    /// The type of the block for the body. This determines which body block object (paragraph, list, video, image or table) would have a value.
    /// </summary>
    /// <value>The type of the block for the body. This determines which body block object (paragraph, list, video, image or table) would have a value.</value>
    
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
        /// Enum Paragraph for "Paragraph"
        /// </summary>
        [EnumMember(Value = "Paragraph")]
        Paragraph,

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
        /// Enum Orderedlist for "OrderedList"
        /// </summary>
        [EnumMember(Value = "OrderedList")]
        Orderedlist,

        /// <summary>
        /// Enum Unorderedlist for "UnorderedList"
        /// </summary>
        [EnumMember(Value = "UnorderedList")]
        Unorderedlist,

        /// <summary>
        /// Enum Table for "Table"
        /// </summary>
        [EnumMember(Value = "Table")]
        Table
    }
    /// <summary>
    /// The type of the block for the body. This determines which body block object (paragraph, list, video, image or table) would have a value.
    /// </summary>
    /// <value>The type of the block for the body. This determines which body block object (paragraph, list, video, image or table) would have a value.</value>
    [JsonPropertyName("type")]
    public TypeEnum? Type { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="DocumentBodyBlockWithHighlight" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected DocumentBodyBlockWithHighlight() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="DocumentBodyBlockWithHighlight" /> class.
    /// </summary>
    /// <param name="Type">The type of the block for the body. This determines which body block object (paragraph, list, video, image or table) would have a value. (required).</param>
    /// <param name="Image">Image. It must contain a value if the type of the block is Image..</param>
    /// <param name="Video">Video. It must contain a value if the type of the block is Video..</param>
    /// <param name="Paragraph">Paragraph. It must contain a value if the type of the block is Paragraph..</param>
    /// <param name="List">List. It must contain a value if the type of the block is UnorderedList or OrderedList..</param>
    /// <param name="Table">Table. It must contain a value if type of the block is Table..</param>
    public DocumentBodyBlockWithHighlight(TypeEnum? Type = null, DocumentBodyImage Image = null, DocumentBodyVideo Video = null, DocumentBodyParagraphWithHighlight Paragraph = null, DocumentBodyListWithHighlight List = null, DocumentBodyTableWithHighlight Table = null)
    {
        this.Type = Type;
        this.Image = Image;
        this.Video = Video;
        this.Paragraph = Paragraph;
        this.List = List;
        this.Table = Table;

    }





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
    /// Paragraph. It must contain a value if the type of the block is Paragraph.
    /// </summary>
    /// <value>Paragraph. It must contain a value if the type of the block is Paragraph.</value>
    [JsonPropertyName("paragraph")]
    public DocumentBodyParagraphWithHighlight Paragraph { get; set; }



    /// <summary>
    /// List. It must contain a value if the type of the block is UnorderedList or OrderedList.
    /// </summary>
    /// <value>List. It must contain a value if the type of the block is UnorderedList or OrderedList.</value>
    [JsonPropertyName("list")]
    public DocumentBodyListWithHighlight List { get; set; }



    /// <summary>
    /// Table. It must contain a value if type of the block is Table.
    /// </summary>
    /// <value>Table. It must contain a value if type of the block is Table.</value>
    [JsonPropertyName("table")]
    public DocumentBodyTableWithHighlight Table { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class DocumentBodyBlockWithHighlight {\n");

        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  Image: ").Append(Image).Append("\n");
        sb.Append("  Video: ").Append(Video).Append("\n");
        sb.Append("  Paragraph: ").Append(Paragraph).Append("\n");
        sb.Append("  List: ").Append(List).Append("\n");
        sb.Append("  Table: ").Append(Table).Append("\n");
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
        return Equals(obj as DocumentBodyBlockWithHighlight);
    }

    /// <summary>
    /// Returns true if DocumentBodyBlockWithHighlight instances are equal
    /// </summary>
    /// <param name="other">Instance of DocumentBodyBlockWithHighlight to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DocumentBodyBlockWithHighlight other)
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
                Image == other.Image ||
                Image != null &&
                Image.Equals(other.Image)
            ) &&
            (
                Video == other.Video ||
                Video != null &&
                Video.Equals(other.Video)
            ) &&
            (
                Paragraph == other.Paragraph ||
                Paragraph != null &&
                Paragraph.Equals(other.Paragraph)
            ) &&
            (
                List == other.List ||
                List != null &&
                List.Equals(other.List)
            ) &&
            (
                Table == other.Table ||
                Table != null &&
                Table.Equals(other.Table)
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

            if (Image != null)
            {
                hash = hash * 59 + Image.GetHashCode();
            }

            if (Video != null)
            {
                hash = hash * 59 + Video.GetHashCode();
            }

            if (Paragraph != null)
            {
                hash = hash * 59 + Paragraph.GetHashCode();
            }

            if (List != null)
            {
                hash = hash * 59 + List.GetHashCode();
            }

            if (Table != null)
            {
                hash = hash * 59 + Table.GetHashCode();
            }

            return hash;
        }
    }
}
