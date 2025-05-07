using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// DocumentVariationAnswer
/// </summary>

public partial class DocumentVariationAnswer : IEquatable<DocumentVariationAnswer>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="DocumentVariationAnswer" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected DocumentVariationAnswer() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="DocumentVariationAnswer" /> class.
    /// </summary>
    /// <param name="DocumentVersion">The version of the document..</param>
    /// <param name="Contexts">The context values associated with the variation. (required).</param>
    /// <param name="Priority">The priority of the variation..</param>
    /// <param name="Name">The name of the variation..</param>
    /// <param name="Body">The content for the variation..</param>
    public DocumentVariationAnswer(AddressableEntityRef DocumentVersion = null, List<DocumentVariationContext> Contexts = null, int? Priority = null, string Name = null, DocumentBodyWithHighlight Body = null)
    {
        this.DocumentVersion = DocumentVersion;
        this.Contexts = Contexts;
        this.Priority = Priority;
        this.Name = Name;
        this.Body = Body;

    }



    /// <summary>
    /// The globally unique identifier for the variation.
    /// </summary>
    /// <value>The globally unique identifier for the variation.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// The creation date-time for the document variation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The creation date-time for the document variation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateCreated")]
    public DateTime? DateCreated { get; set; }



    /// <summary>
    /// The last modification date-time for the document variation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The last modification date-time for the document variation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateModified")]
    public DateTime? DateModified { get; set; }



    /// <summary>
    /// The version of the document.
    /// </summary>
    /// <value>The version of the document.</value>
    [JsonPropertyName("documentVersion")]
    public AddressableEntityRef DocumentVersion { get; set; }



    /// <summary>
    /// The context values associated with the variation.
    /// </summary>
    /// <value>The context values associated with the variation.</value>
    [JsonPropertyName("contexts")]
    public List<DocumentVariationContext> Contexts { get; set; }



    /// <summary>
    /// The reference to document to which the variation is associated.
    /// </summary>
    /// <value>The reference to document to which the variation is associated.</value>
    [JsonPropertyName("document")]
    public KnowledgeDocumentReference Document { get; set; }



    /// <summary>
    /// The priority of the variation.
    /// </summary>
    /// <value>The priority of the variation.</value>
    [JsonPropertyName("priority")]
    public int? Priority { get; set; }



    /// <summary>
    /// The name of the variation.
    /// </summary>
    /// <value>The name of the variation.</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// The content for the variation.
    /// </summary>
    /// <value>The content for the variation.</value>
    [JsonPropertyName("body")]
    public DocumentBodyWithHighlight Body { get; set; }



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
        sb.Append("class DocumentVariationAnswer {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
        sb.Append("  DateModified: ").Append(DateModified).Append("\n");
        sb.Append("  DocumentVersion: ").Append(DocumentVersion).Append("\n");
        sb.Append("  Contexts: ").Append(Contexts).Append("\n");
        sb.Append("  Document: ").Append(Document).Append("\n");
        sb.Append("  Priority: ").Append(Priority).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Body: ").Append(Body).Append("\n");
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
        return Equals(obj as DocumentVariationAnswer);
    }

    /// <summary>
    /// Returns true if DocumentVariationAnswer instances are equal
    /// </summary>
    /// <param name="other">Instance of DocumentVariationAnswer to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DocumentVariationAnswer other)
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
                DateCreated == other.DateCreated ||
                DateCreated != null &&
                DateCreated.Equals(other.DateCreated)
            ) &&
            (
                DateModified == other.DateModified ||
                DateModified != null &&
                DateModified.Equals(other.DateModified)
            ) &&
            (
                DocumentVersion == other.DocumentVersion ||
                DocumentVersion != null &&
                DocumentVersion.Equals(other.DocumentVersion)
            ) &&
            (
                Contexts == other.Contexts ||
                Contexts != null &&
                Contexts.SequenceEqual(other.Contexts)
            ) &&
            (
                Document == other.Document ||
                Document != null &&
                Document.Equals(other.Document)
            ) &&
            (
                Priority == other.Priority ||
                Priority != null &&
                Priority.Equals(other.Priority)
            ) &&
            (
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                Body == other.Body ||
                Body != null &&
                Body.Equals(other.Body)
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

            if (DateCreated != null)
            {
                hash = hash * 59 + DateCreated.GetHashCode();
            }

            if (DateModified != null)
            {
                hash = hash * 59 + DateModified.GetHashCode();
            }

            if (DocumentVersion != null)
            {
                hash = hash * 59 + DocumentVersion.GetHashCode();
            }

            if (Contexts != null)
            {
                hash = hash * 59 + Contexts.GetHashCode();
            }

            if (Document != null)
            {
                hash = hash * 59 + Document.GetHashCode();
            }

            if (Priority != null)
            {
                hash = hash * 59 + Priority.GetHashCode();
            }

            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (Body != null)
            {
                hash = hash * 59 + Body.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
