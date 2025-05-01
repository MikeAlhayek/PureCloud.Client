using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// KnowledgeDocumentSuggestionResultDocument
/// </summary>
[DataContract]
public partial class KnowledgeDocumentSuggestionResultDocument : IEquatable<KnowledgeDocumentSuggestionResultDocument>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="KnowledgeDocumentSuggestionResultDocument" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected KnowledgeDocumentSuggestionResultDocument() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="KnowledgeDocumentSuggestionResultDocument" /> class.
    /// </summary>
    /// <param name="Id">The globally unique identifier for the document. (required).</param>
    /// <param name="KnowledgeBase">The knowledge base that the document belongs to. (required).</param>
    /// <param name="Title">The title of the document. (required).</param>
    public KnowledgeDocumentSuggestionResultDocument(string Id = null, KnowledgeBaseReference KnowledgeBase = null, string Title = null)
    {
        this.Id = Id;
        this.KnowledgeBase = KnowledgeBase;
        this.Title = Title;

    }



    /// <summary>
    /// The globally unique identifier for the document.
    /// </summary>
    /// <value>The globally unique identifier for the document.</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }



    /// <summary>
    /// The knowledge base that the document belongs to.
    /// </summary>
    /// <value>The knowledge base that the document belongs to.</value>
    [DataMember(Name = "knowledgeBase", EmitDefaultValue = false)]
    public KnowledgeBaseReference KnowledgeBase { get; set; }



    /// <summary>
    /// The title of the document.
    /// </summary>
    /// <value>The title of the document.</value>
    [DataMember(Name = "title", EmitDefaultValue = false)]
    public string Title { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [DataMember(Name = "selfUri", EmitDefaultValue = false)]
    public string SelfUri { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class KnowledgeDocumentSuggestionResultDocument {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  KnowledgeBase: ").Append(KnowledgeBase).Append("\n");
        sb.Append("  Title: ").Append(Title).Append("\n");
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
        return Equals(obj as KnowledgeDocumentSuggestionResultDocument);
    }

    /// <summary>
    /// Returns true if KnowledgeDocumentSuggestionResultDocument instances are equal
    /// </summary>
    /// <param name="other">Instance of KnowledgeDocumentSuggestionResultDocument to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(KnowledgeDocumentSuggestionResultDocument other)
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
                Title == other.Title ||
                Title != null &&
                Title.Equals(other.Title)
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

            if (Title != null)
            {
                hash = hash * 59 + Title.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
