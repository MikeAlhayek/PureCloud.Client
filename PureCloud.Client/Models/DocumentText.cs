using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// DocumentText
/// </summary>
[DataContract]
public partial class DocumentText : IEquatable<DocumentText>
{
    /// <summary>
    /// Gets or Sets Marks
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum MarksEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Bold for "Bold"
        /// </summary>
        [EnumMember(Value = "Bold")]
        Bold,

        /// <summary>
        /// Enum Italic for "Italic"
        /// </summary>
        [EnumMember(Value = "Italic")]
        Italic,

        /// <summary>
        /// Enum Underline for "Underline"
        /// </summary>
        [EnumMember(Value = "Underline")]
        Underline,

        /// <summary>
        /// Enum Strikethrough for "Strikethrough"
        /// </summary>
        [EnumMember(Value = "Strikethrough")]
        Strikethrough,

        /// <summary>
        /// Enum Subscript for "Subscript"
        /// </summary>
        [EnumMember(Value = "Subscript")]
        Subscript,

        /// <summary>
        /// Enum Superscript for "Superscript"
        /// </summary>
        [EnumMember(Value = "Superscript")]
        Superscript
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="DocumentText" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected DocumentText() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="DocumentText" /> class.
    /// </summary>
    /// <param name="Text">Text. (required).</param>
    /// <param name="Marks">The unique list of marks (whether it is bold and/or underlined etc.) for the text..</param>
    /// <param name="Hyperlink">The URL of the page OR an email OR the reference to the knowledge article that the hyperlink goes to. Possible URL value types are https://&lt;url link&gt; | mailto:&lt;email&gt; | grn:knowledge:::documentVariation/&lt;knowledgeBaseId&gt;/&lt;documentId&gt;/&lt;variationId&gt; | grn:knowledge:::document/&lt;knowledgeBaseId&gt;/&lt;documentId&gt; | grn:knowledge:::category/&lt;knowledgeBaseId&gt;/&lt;categoryId&gt; | grn:knowledge:::label/&lt;knowledgeBaseId&gt;/&lt;labelId&gt;.</param>
    /// <param name="Properties">The properties for the text..</param>
    public DocumentText(string Text = null, List<MarksEnum> Marks = null, string Hyperlink = null, DocumentTextProperties Properties = null)
    {
        this.Text = Text;
        this.Marks = Marks;
        this.Hyperlink = Hyperlink;
        this.Properties = Properties;

    }



    /// <summary>
    /// Text.
    /// </summary>
    /// <value>Text.</value>
    [DataMember(Name = "text", EmitDefaultValue = false)]
    public string Text { get; set; }



    /// <summary>
    /// The unique list of marks (whether it is bold and/or underlined etc.) for the text.
    /// </summary>
    /// <value>The unique list of marks (whether it is bold and/or underlined etc.) for the text.</value>
    [DataMember(Name = "marks", EmitDefaultValue = false)]
    public List<MarksEnum> Marks { get; set; }



    /// <summary>
    /// The URL of the page OR an email OR the reference to the knowledge article that the hyperlink goes to. Possible URL value types are https://&lt;url link&gt; | mailto:&lt;email&gt; | grn:knowledge:::documentVariation/&lt;knowledgeBaseId&gt;/&lt;documentId&gt;/&lt;variationId&gt; | grn:knowledge:::document/&lt;knowledgeBaseId&gt;/&lt;documentId&gt; | grn:knowledge:::category/&lt;knowledgeBaseId&gt;/&lt;categoryId&gt; | grn:knowledge:::label/&lt;knowledgeBaseId&gt;/&lt;labelId&gt;
    /// </summary>
    /// <value>The URL of the page OR an email OR the reference to the knowledge article that the hyperlink goes to. Possible URL value types are https://&lt;url link&gt; | mailto:&lt;email&gt; | grn:knowledge:::documentVariation/&lt;knowledgeBaseId&gt;/&lt;documentId&gt;/&lt;variationId&gt; | grn:knowledge:::document/&lt;knowledgeBaseId&gt;/&lt;documentId&gt; | grn:knowledge:::category/&lt;knowledgeBaseId&gt;/&lt;categoryId&gt; | grn:knowledge:::label/&lt;knowledgeBaseId&gt;/&lt;labelId&gt;</value>
    [DataMember(Name = "hyperlink", EmitDefaultValue = false)]
    public string Hyperlink { get; set; }



    /// <summary>
    /// The properties for the text.
    /// </summary>
    /// <value>The properties for the text.</value>
    [DataMember(Name = "properties", EmitDefaultValue = false)]
    public DocumentTextProperties Properties { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class DocumentText {\n");

        sb.Append("  Text: ").Append(Text).Append("\n");
        sb.Append("  Marks: ").Append(Marks).Append("\n");
        sb.Append("  Hyperlink: ").Append(Hyperlink).Append("\n");
        sb.Append("  Properties: ").Append(Properties).Append("\n");
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
        return Equals(obj as DocumentText);
    }

    /// <summary>
    /// Returns true if DocumentText instances are equal
    /// </summary>
    /// <param name="other">Instance of DocumentText to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DocumentText other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Text == other.Text ||
                Text != null &&
                Text.Equals(other.Text)
            ) &&
            (
                Marks == other.Marks ||
                Marks != null &&
                Marks.SequenceEqual(other.Marks)
            ) &&
            (
                Hyperlink == other.Hyperlink ||
                Hyperlink != null &&
                Hyperlink.Equals(other.Hyperlink)
            ) &&
            (
                Properties == other.Properties ||
                Properties != null &&
                Properties.Equals(other.Properties)
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
            if (Text != null)
            {
                hash = hash * 59 + Text.GetHashCode();
            }

            if (Marks != null)
            {
                hash = hash * 59 + Marks.GetHashCode();
            }

            if (Hyperlink != null)
            {
                hash = hash * 59 + Hyperlink.GetHashCode();
            }

            if (Properties != null)
            {
                hash = hash * 59 + Properties.GetHashCode();
            }

            return hash;
        }
    }
}
