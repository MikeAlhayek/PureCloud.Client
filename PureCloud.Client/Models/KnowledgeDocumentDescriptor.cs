using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// KnowledgeDocumentDescriptor
/// </summary>
[DataContract]
public partial class KnowledgeDocumentDescriptor : IEquatable<KnowledgeDocumentDescriptor>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="KnowledgeDocumentDescriptor" /> class.
    /// </summary>
    public KnowledgeDocumentDescriptor()
    {

    }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class KnowledgeDocumentDescriptor {\n");

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
        return this.Equals(obj as KnowledgeDocumentDescriptor);
    }

    /// <summary>
    /// Returns true if KnowledgeDocumentDescriptor instances are equal
    /// </summary>
    /// <param name="other">Instance of KnowledgeDocumentDescriptor to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(KnowledgeDocumentDescriptor other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true && false;
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
            return hash;
        }
    }
}
