using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// KnowledgeDocumentReference
/// </summary>

public partial class KnowledgeDocumentReference : IEquatable<KnowledgeDocumentReference>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="KnowledgeDocumentReference" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected KnowledgeDocumentReference() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="KnowledgeDocumentReference" /> class.
    /// </summary>
    /// <param name="Id">The globally unique identifier for the document. (required).</param>
    /// <param name="KnowledgeBase">The knowledge base that the document belongs to. (required).</param>
    public KnowledgeDocumentReference(string Id = null, KnowledgeBaseReference KnowledgeBase = null)
    {
        this.Id = Id;
        this.KnowledgeBase = KnowledgeBase;

    }



    /// <summary>
    /// The globally unique identifier for the document.
    /// </summary>
    /// <value>The globally unique identifier for the document.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// The knowledge base that the document belongs to.
    /// </summary>
    /// <value>The knowledge base that the document belongs to.</value>
    [JsonPropertyName("knowledgeBase")]
    public KnowledgeBaseReference KnowledgeBase { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class KnowledgeDocumentReference {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  KnowledgeBase: ").Append(KnowledgeBase).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
        return Equals(obj as KnowledgeDocumentReference);
    }

    /// <summary>
    /// Returns true if KnowledgeDocumentReference instances are equal
    /// </summary>
    /// <param name="other">Instance of KnowledgeDocumentReference to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(KnowledgeDocumentReference other)
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
                KnowledgeBase == other.KnowledgeBase ||
                KnowledgeBase != null &&
                KnowledgeBase.Equals(other.KnowledgeBase)
            ) &&
            (
                SelfUri == other.SelfUri ||
                SelfUri != null &&
                SelfUri.Equals(other.SelfUri)
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

            if (KnowledgeBase != null)
            {
                hash = hash * 59 + KnowledgeBase.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
