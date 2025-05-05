using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// DocumentBodyTableCellBlock
/// </summary>

public partial class DocumentBodyTableCellBlock : IEquatable<DocumentBodyTableCellBlock>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="DocumentBodyTableCellBlock" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected DocumentBodyTableCellBlock() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="DocumentBodyTableCellBlock" /> class.
    /// </summary>
    /// <param name="Properties">The properties for the table cell..</param>
    /// <param name="Blocks">The list of content blocks for the table. (required).</param>
    public DocumentBodyTableCellBlock(DocumentBodyTableCellBlockProperties Properties = null, List<DocumentTableContentBlock> Blocks = null)
    {
        this.Properties = Properties;
        this.Blocks = Blocks;

    }



    /// <summary>
    /// The properties for the table cell.
    /// </summary>
    /// <value>The properties for the table cell.</value>
    [JsonPropertyName("properties")]
    public DocumentBodyTableCellBlockProperties Properties { get; set; }



    /// <summary>
    /// The list of content blocks for the table.
    /// </summary>
    /// <value>The list of content blocks for the table.</value>
    [JsonPropertyName("blocks")]
    public List<DocumentTableContentBlock> Blocks { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class DocumentBodyTableCellBlock {\n");

        sb.Append("  Properties: ").Append(Properties).Append("\n");
        sb.Append("  Blocks: ").Append(Blocks).Append("\n");
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
        return Equals(obj as DocumentBodyTableCellBlock);
    }

    /// <summary>
    /// Returns true if DocumentBodyTableCellBlock instances are equal
    /// </summary>
    /// <param name="other">Instance of DocumentBodyTableCellBlock to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DocumentBodyTableCellBlock other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Properties == other.Properties ||
                Properties != null &&
                Properties.Equals(other.Properties)
            ) &&
            (
                Blocks == other.Blocks ||
                Blocks != null &&
                Blocks.SequenceEqual(other.Blocks)
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
            if (Properties != null)
            {
                hash = hash * 59 + Properties.GetHashCode();
            }

            if (Blocks != null)
            {
                hash = hash * 59 + Blocks.GetHashCode();
            }

            return hash;
        }
    }
}
