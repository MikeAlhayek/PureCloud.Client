using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// DocumentBodyParagraphWithHighlight
/// </summary>

public partial class DocumentBodyParagraphWithHighlight : IEquatable<DocumentBodyParagraphWithHighlight>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="DocumentBodyParagraphWithHighlight" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected DocumentBodyParagraphWithHighlight() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="DocumentBodyParagraphWithHighlight" /> class.
    /// </summary>
    /// <param name="Blocks">The list of blocks for the paragraph. (required).</param>
    /// <param name="Properties">The properties for the paragraph..</param>
    public DocumentBodyParagraphWithHighlight(List<DocumentContentBlockWithHighlight> Blocks = null, DocumentBodyParagraphProperties Properties = null)
    {
        this.Blocks = Blocks;
        this.Properties = Properties;

    }



    /// <summary>
    /// The list of blocks for the paragraph.
    /// </summary>
    /// <value>The list of blocks for the paragraph.</value>
    [JsonPropertyName("blocks")]
    public List<DocumentContentBlockWithHighlight> Blocks { get; set; }



    /// <summary>
    /// The properties for the paragraph.
    /// </summary>
    /// <value>The properties for the paragraph.</value>
    [JsonPropertyName("properties")]
    public DocumentBodyParagraphProperties Properties { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class DocumentBodyParagraphWithHighlight {\n");

        sb.Append("  Blocks: ").Append(Blocks).Append("\n");
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
        return Equals(obj as DocumentBodyParagraphWithHighlight);
    }

    /// <summary>
    /// Returns true if DocumentBodyParagraphWithHighlight instances are equal
    /// </summary>
    /// <param name="other">Instance of DocumentBodyParagraphWithHighlight to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DocumentBodyParagraphWithHighlight other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Blocks == other.Blocks ||
                Blocks != null &&
                Blocks.SequenceEqual(other.Blocks)
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
            if (Blocks != null)
            {
                hash = hash * 59 + Blocks.GetHashCode();
            }

            if (Properties != null)
            {
                hash = hash * 59 + Properties.GetHashCode();
            }

            return hash;
        }
    }
}
