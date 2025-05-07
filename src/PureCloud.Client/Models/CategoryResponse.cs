using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// CategoryResponse
/// </summary>

public partial class CategoryResponse : IEquatable<CategoryResponse>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="CategoryResponse" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected CategoryResponse() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="CategoryResponse" /> class.
    /// </summary>
    /// <param name="Name">The name of the category. (required).</param>
    /// <param name="Description">Description.</param>
    /// <param name="ExternalId">ExternalId.</param>
    /// <param name="DateCreated">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="DateModified">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="ParentCategory">The reference to category to which this category belongs to..</param>
    /// <param name="DocumentCount">Number of documents assigned to this category..</param>
    /// <param name="KnowledgeBase">The reference to knowledge base to which the category belongs to..</param>
    public CategoryResponse(string Name = null, string Description = null, string ExternalId = null, DateTime? DateCreated = null, DateTime? DateModified = null, CategoryReference ParentCategory = null, int? DocumentCount = null, KnowledgeBaseReference KnowledgeBase = null)
    {
        this.Name = Name;
        this.Description = Description;
        this.ExternalId = ExternalId;
        this.DateCreated = DateCreated;
        this.DateModified = DateModified;
        this.ParentCategory = ParentCategory;
        this.DocumentCount = DocumentCount;
        this.KnowledgeBase = KnowledgeBase;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// The name of the category.
    /// </summary>
    /// <value>The name of the category.</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [JsonPropertyName("description")]
    public string Description { get; set; }



    /// <summary>
    /// Gets or Sets ExternalId
    /// </summary>
    [JsonPropertyName("externalId")]
    public string ExternalId { get; set; }



    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateCreated")]
    public DateTime? DateCreated { get; set; }



    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateModified")]
    public DateTime? DateModified { get; set; }



    /// <summary>
    /// The reference to category to which this category belongs to.
    /// </summary>
    /// <value>The reference to category to which this category belongs to.</value>
    [JsonPropertyName("parentCategory")]
    public CategoryReference ParentCategory { get; set; }



    /// <summary>
    /// Number of documents assigned to this category.
    /// </summary>
    /// <value>Number of documents assigned to this category.</value>
    [JsonPropertyName("documentCount")]
    public int? DocumentCount { get; set; }



    /// <summary>
    /// The reference to knowledge base to which the category belongs to.
    /// </summary>
    /// <value>The reference to knowledge base to which the category belongs to.</value>
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
        sb.Append("class CategoryResponse {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
        sb.Append("  DateModified: ").Append(DateModified).Append("\n");
        sb.Append("  ParentCategory: ").Append(ParentCategory).Append("\n");
        sb.Append("  DocumentCount: ").Append(DocumentCount).Append("\n");
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
        return Equals(obj as CategoryResponse);
    }

    /// <summary>
    /// Returns true if CategoryResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of CategoryResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CategoryResponse other)
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
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                Description == other.Description ||
                Description != null &&
                Description.Equals(other.Description)
            ) &&
            (
                ExternalId == other.ExternalId ||
                ExternalId != null &&
                ExternalId.Equals(other.ExternalId)
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
                ParentCategory == other.ParentCategory ||
                ParentCategory != null &&
                ParentCategory.Equals(other.ParentCategory)
            ) &&
            (
                DocumentCount == other.DocumentCount ||
                DocumentCount != null &&
                DocumentCount.Equals(other.DocumentCount)
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

            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (Description != null)
            {
                hash = hash * 59 + Description.GetHashCode();
            }

            if (ExternalId != null)
            {
                hash = hash * 59 + ExternalId.GetHashCode();
            }

            if (DateCreated != null)
            {
                hash = hash * 59 + DateCreated.GetHashCode();
            }

            if (DateModified != null)
            {
                hash = hash * 59 + DateModified.GetHashCode();
            }

            if (ParentCategory != null)
            {
                hash = hash * 59 + ParentCategory.GetHashCode();
            }

            if (DocumentCount != null)
            {
                hash = hash * 59 + DocumentCount.GetHashCode();
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
