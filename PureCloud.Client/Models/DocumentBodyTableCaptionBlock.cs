using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// DocumentBodyTableCaptionBlock
/// </summary>
[DataContract]
public partial class DocumentBodyTableCaptionBlock : IEquatable<DocumentBodyTableCaptionBlock>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="DocumentBodyTableCaptionBlock" /> class.
    /// </summary>
    [JsonConstructor]
    protected DocumentBodyTableCaptionBlock() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="DocumentBodyTableCaptionBlock" /> class.
    /// </summary>
    /// <param name="Blocks">The list of building blocks for the caption property. (required).</param>
    public DocumentBodyTableCaptionBlock(List<DocumentBodyTableCaptionItem> Blocks = null)
    {
        this.Blocks = Blocks;

    }



    /// <summary>
    /// The list of building blocks for the caption property.
    /// </summary>
    /// <value>The list of building blocks for the caption property.</value>
    [DataMember(Name = "blocks", EmitDefaultValue = false)]
    public List<DocumentBodyTableCaptionItem> Blocks { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class DocumentBodyTableCaptionBlock {\n");

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
        return this.Equals(obj as DocumentBodyTableCaptionBlock);
    }

    /// <summary>
    /// Returns true if DocumentBodyTableCaptionBlock instances are equal
    /// </summary>
    /// <param name="other">Instance of DocumentBodyTableCaptionBlock to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DocumentBodyTableCaptionBlock other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                this.Blocks == other.Blocks ||
                this.Blocks != null &&
                this.Blocks.SequenceEqual(other.Blocks)
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
            if (this.Blocks != null)
            {
                hash = hash * 59 + this.Blocks.GetHashCode();
            }

            return hash;
        }
    }
}
