using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloudPlatform.Client.V2.Model;

/// <summary>
/// CategoryResponse
/// </summary>
[DataContract]
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
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; private set; }



    /// <summary>
    /// The name of the category.
    /// </summary>
    /// <value>The name of the category.</value>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }



    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [DataMember(Name = "description", EmitDefaultValue = false)]
    public string Description { get; set; }



    /// <summary>
    /// Gets or Sets ExternalId
    /// </summary>
    [DataMember(Name = "externalId", EmitDefaultValue = false)]
    public string ExternalId { get; set; }



    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "dateCreated", EmitDefaultValue = false)]
    public DateTime? DateCreated { get; set; }



    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "dateModified", EmitDefaultValue = false)]
    public DateTime? DateModified { get; set; }



    /// <summary>
    /// The reference to category to which this category belongs to.
    /// </summary>
    /// <value>The reference to category to which this category belongs to.</value>
    [DataMember(Name = "parentCategory", EmitDefaultValue = false)]
    public CategoryReference ParentCategory { get; set; }



    /// <summary>
    /// Number of documents assigned to this category.
    /// </summary>
    /// <value>Number of documents assigned to this category.</value>
    [DataMember(Name = "documentCount", EmitDefaultValue = false)]
    public int? DocumentCount { get; set; }



    /// <summary>
    /// The reference to knowledge base to which the category belongs to.
    /// </summary>
    /// <value>The reference to knowledge base to which the category belongs to.</value>
    [DataMember(Name = "knowledgeBase", EmitDefaultValue = false)]
    public KnowledgeBaseReference KnowledgeBase { get; set; }



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
        return this.Equals(obj as CategoryResponse);
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
                this.Id == other.Id ||
                this.Id != null &&
                this.Id.Equals(other.Id)
            ) &&
            (
                this.Name == other.Name ||
                this.Name != null &&
                this.Name.Equals(other.Name)
            ) &&
            (
                this.Description == other.Description ||
                this.Description != null &&
                this.Description.Equals(other.Description)
            ) &&
            (
                this.ExternalId == other.ExternalId ||
                this.ExternalId != null &&
                this.ExternalId.Equals(other.ExternalId)
            ) &&
            (
                this.DateCreated == other.DateCreated ||
                this.DateCreated != null &&
                this.DateCreated.Equals(other.DateCreated)
            ) &&
            (
                this.DateModified == other.DateModified ||
                this.DateModified != null &&
                this.DateModified.Equals(other.DateModified)
            ) &&
            (
                this.ParentCategory == other.ParentCategory ||
                this.ParentCategory != null &&
                this.ParentCategory.Equals(other.ParentCategory)
            ) &&
            (
                this.DocumentCount == other.DocumentCount ||
                this.DocumentCount != null &&
                this.DocumentCount.Equals(other.DocumentCount)
            ) &&
            (
                this.KnowledgeBase == other.KnowledgeBase ||
                this.KnowledgeBase != null &&
                this.KnowledgeBase.Equals(other.KnowledgeBase)
            ) &&
            (
                this.SelfUri == other.SelfUri ||
                this.SelfUri != null &&
                this.SelfUri.Equals(other.SelfUri)
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
            if (this.Id != null)
            {
                hash = hash * 59 + this.Id.GetHashCode();
            }

            if (this.Name != null)
            {
                hash = hash * 59 + this.Name.GetHashCode();
            }

            if (this.Description != null)
            {
                hash = hash * 59 + this.Description.GetHashCode();
            }

            if (this.ExternalId != null)
            {
                hash = hash * 59 + this.ExternalId.GetHashCode();
            }

            if (this.DateCreated != null)
            {
                hash = hash * 59 + this.DateCreated.GetHashCode();
            }

            if (this.DateModified != null)
            {
                hash = hash * 59 + this.DateModified.GetHashCode();
            }

            if (this.ParentCategory != null)
            {
                hash = hash * 59 + this.ParentCategory.GetHashCode();
            }

            if (this.DocumentCount != null)
            {
                hash = hash * 59 + this.DocumentCount.GetHashCode();
            }

            if (this.KnowledgeBase != null)
            {
                hash = hash * 59 + this.KnowledgeBase.GetHashCode();
            }

            if (this.SelfUri != null)
            {
                hash = hash * 59 + this.SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
