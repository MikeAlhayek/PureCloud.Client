using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// DocumentBodyList
/// </summary>
[DataContract]
public partial class DocumentBodyList : IEquatable<DocumentBodyList>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="DocumentBodyList" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected DocumentBodyList() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="DocumentBodyList" /> class.
    /// </summary>
    /// <param name="Properties">Properties for the UnorderedList or OrderedList..</param>
    /// <param name="Blocks">The list of items for an OrderedList or an UnorderedList. (required).</param>
    public DocumentBodyList(DocumentBodyListBlockProperties Properties = null, List<DocumentBodyListBlock> Blocks = null)
    {
        this.Properties = Properties;
        this.Blocks = Blocks;

    }



    /// <summary>
    /// Properties for the UnorderedList or OrderedList.
    /// </summary>
    /// <value>Properties for the UnorderedList or OrderedList.</value>
    [DataMember(Name = "properties", EmitDefaultValue = false)]
    public DocumentBodyListBlockProperties Properties { get; set; }



    /// <summary>
    /// The list of items for an OrderedList or an UnorderedList.
    /// </summary>
    /// <value>The list of items for an OrderedList or an UnorderedList.</value>
    [DataMember(Name = "blocks", EmitDefaultValue = false)]
    public List<DocumentBodyListBlock> Blocks { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class DocumentBodyList {\n");

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
        return Equals(obj as DocumentBodyList);
    }

    /// <summary>
    /// Returns true if DocumentBodyList instances are equal
    /// </summary>
    /// <param name="other">Instance of DocumentBodyList to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DocumentBodyList other)
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
