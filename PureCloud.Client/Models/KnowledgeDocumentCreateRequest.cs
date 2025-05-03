using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// KnowledgeDocumentCreateRequest
/// </summary>

public partial class KnowledgeDocumentCreateRequest : IEquatable<KnowledgeDocumentCreateRequest>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="KnowledgeDocumentCreateRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected KnowledgeDocumentCreateRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="KnowledgeDocumentCreateRequest" /> class.
    /// </summary>
    /// <param name="Title">Document title. (required).</param>
    /// <param name="Visible">Indicates if the knowledge document should be included in search results..</param>
    /// <param name="Alternatives">List of alternate phrases related to the title which improves search results..</param>
    /// <param name="CategoryId">The category associated with the document..</param>
    /// <param name="LabelIds">The ids of labels associated with the document..</param>
    /// <param name="ExternalId">The external id associated with the document..</param>
    /// <param name="ExternalUrl">The URL to external document..</param>
    public KnowledgeDocumentCreateRequest(string Title = null, bool? Visible = null, List<KnowledgeDocumentAlternative> Alternatives = null, string CategoryId = null, List<string> LabelIds = null, string ExternalId = null, string ExternalUrl = null)
    {
        this.Title = Title;
        this.Visible = Visible;
        this.Alternatives = Alternatives;
        this.CategoryId = CategoryId;
        this.LabelIds = LabelIds;
        this.ExternalId = ExternalId;
        this.ExternalUrl = ExternalUrl;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; private set; }



    /// <summary>
    /// Document title.
    /// </summary>
    /// <value>Document title.</value>
    [JsonPropertyName("title")]
    public string Title { get; set; }



    /// <summary>
    /// Indicates if the knowledge document should be included in search results.
    /// </summary>
    /// <value>Indicates if the knowledge document should be included in search results.</value>
    [JsonPropertyName("visible")]
    public bool? Visible { get; set; }



    /// <summary>
    /// List of alternate phrases related to the title which improves search results.
    /// </summary>
    /// <value>List of alternate phrases related to the title which improves search results.</value>
    [JsonPropertyName("alternatives")]
    public List<KnowledgeDocumentAlternative> Alternatives { get; set; }



    /// <summary>
    /// The category associated with the document.
    /// </summary>
    /// <value>The category associated with the document.</value>
    [JsonPropertyName("categoryId")]
    public string CategoryId { get; set; }



    /// <summary>
    /// The ids of labels associated with the document.
    /// </summary>
    /// <value>The ids of labels associated with the document.</value>
    [JsonPropertyName("labelIds")]
    public List<string> LabelIds { get; set; }



    /// <summary>
    /// The external id associated with the document.
    /// </summary>
    /// <value>The external id associated with the document.</value>
    [JsonPropertyName("externalId")]
    public string ExternalId { get; set; }



    /// <summary>
    /// The URL to external document.
    /// </summary>
    /// <value>The URL to external document.</value>
    [JsonPropertyName("externalUrl")]
    public string ExternalUrl { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class KnowledgeDocumentCreateRequest {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Title: ").Append(Title).Append("\n");
        sb.Append("  Visible: ").Append(Visible).Append("\n");
        sb.Append("  Alternatives: ").Append(Alternatives).Append("\n");
        sb.Append("  CategoryId: ").Append(CategoryId).Append("\n");
        sb.Append("  LabelIds: ").Append(LabelIds).Append("\n");
        sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
        sb.Append("  ExternalUrl: ").Append(ExternalUrl).Append("\n");
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
        return Equals(obj as KnowledgeDocumentCreateRequest);
    }

    /// <summary>
    /// Returns true if KnowledgeDocumentCreateRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of KnowledgeDocumentCreateRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(KnowledgeDocumentCreateRequest other)
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
                Title == other.Title ||
                Title != null &&
                Title.Equals(other.Title)
            ) &&
            (
                Visible == other.Visible ||
                Visible != null &&
                Visible.Equals(other.Visible)
            ) &&
            (
                Alternatives == other.Alternatives ||
                Alternatives != null &&
                Alternatives.SequenceEqual(other.Alternatives)
            ) &&
            (
                CategoryId == other.CategoryId ||
                CategoryId != null &&
                CategoryId.Equals(other.CategoryId)
            ) &&
            (
                LabelIds == other.LabelIds ||
                LabelIds != null &&
                LabelIds.SequenceEqual(other.LabelIds)
            ) &&
            (
                ExternalId == other.ExternalId ||
                ExternalId != null &&
                ExternalId.Equals(other.ExternalId)
            ) &&
            (
                ExternalUrl == other.ExternalUrl ||
                ExternalUrl != null &&
                ExternalUrl.Equals(other.ExternalUrl)
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

            if (Title != null)
            {
                hash = hash * 59 + Title.GetHashCode();
            }

            if (Visible != null)
            {
                hash = hash * 59 + Visible.GetHashCode();
            }

            if (Alternatives != null)
            {
                hash = hash * 59 + Alternatives.GetHashCode();
            }

            if (CategoryId != null)
            {
                hash = hash * 59 + CategoryId.GetHashCode();
            }

            if (LabelIds != null)
            {
                hash = hash * 59 + LabelIds.GetHashCode();
            }

            if (ExternalId != null)
            {
                hash = hash * 59 + ExternalId.GetHashCode();
            }

            if (ExternalUrl != null)
            {
                hash = hash * 59 + ExternalUrl.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
