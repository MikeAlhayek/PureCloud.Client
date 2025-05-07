using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// KnowledgeDocumentVersionReference
/// </summary>

public partial class KnowledgeDocumentVersionReference : IEquatable<KnowledgeDocumentVersionReference>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="KnowledgeDocumentVersionReference" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected KnowledgeDocumentVersionReference() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="KnowledgeDocumentVersionReference" /> class.
    /// </summary>
    /// <param name="VersionId">The globally unique identifier for the version of the document. (required).</param>
    public KnowledgeDocumentVersionReference(string VersionId = null)
    {
        this.VersionId = VersionId;

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
    /// The globally unique identifier for the version of the document.
    /// </summary>
    /// <value>The globally unique identifier for the version of the document.</value>
    [JsonPropertyName("versionId")]
    public string VersionId { get; set; }



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
        sb.Append("class KnowledgeDocumentVersionReference {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  KnowledgeBase: ").Append(KnowledgeBase).Append("\n");
        sb.Append("  VersionId: ").Append(VersionId).Append("\n");
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
        return Equals(obj as KnowledgeDocumentVersionReference);
    }

    /// <summary>
    /// Returns true if KnowledgeDocumentVersionReference instances are equal
    /// </summary>
    /// <param name="other">Instance of KnowledgeDocumentVersionReference to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(KnowledgeDocumentVersionReference other)
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
                VersionId == other.VersionId ||
                VersionId != null &&
                VersionId.Equals(other.VersionId)
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

            if (VersionId != null)
            {
                hash = hash * 59 + VersionId.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
