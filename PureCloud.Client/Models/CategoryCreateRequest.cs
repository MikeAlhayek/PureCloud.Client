using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// CategoryCreateRequest
/// </summary>
[DataContract]
public partial class CategoryCreateRequest : IEquatable<CategoryCreateRequest>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="CategoryCreateRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected CategoryCreateRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="CategoryCreateRequest" /> class.
    /// </summary>
    /// <param name="Name">The name of the category. (required).</param>
    /// <param name="ParentCategoryId">ParentCategoryId.</param>
    /// <param name="Description">The description for the category..</param>
    /// <param name="ExternalId">The external id associated with the category..</param>
    public CategoryCreateRequest(string Name = null, string ParentCategoryId = null, string Description = null, string ExternalId = null)
    {
        this.Name = Name;
        this.ParentCategoryId = ParentCategoryId;
        this.Description = Description;
        this.ExternalId = ExternalId;

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
    /// Gets or Sets ParentCategoryId
    /// </summary>
    [DataMember(Name = "parentCategoryId", EmitDefaultValue = false)]
    public string ParentCategoryId { get; set; }



    /// <summary>
    /// The description for the category.
    /// </summary>
    /// <value>The description for the category.</value>
    [DataMember(Name = "description", EmitDefaultValue = false)]
    public string Description { get; set; }



    /// <summary>
    /// The external id associated with the category.
    /// </summary>
    /// <value>The external id associated with the category.</value>
    [DataMember(Name = "externalId", EmitDefaultValue = false)]
    public string ExternalId { get; set; }



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
        sb.Append("class CategoryCreateRequest {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  ParentCategoryId: ").Append(ParentCategoryId).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
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
        return Equals(obj as CategoryCreateRequest);
    }

    /// <summary>
    /// Returns true if CategoryCreateRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of CategoryCreateRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CategoryCreateRequest other)
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
                ParentCategoryId == other.ParentCategoryId ||
                ParentCategoryId != null &&
                ParentCategoryId.Equals(other.ParentCategoryId)
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

            if (ParentCategoryId != null)
            {
                hash = hash * 59 + ParentCategoryId.GetHashCode();
            }

            if (Description != null)
            {
                hash = hash * 59 + Description.GetHashCode();
            }

            if (ExternalId != null)
            {
                hash = hash * 59 + ExternalId.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
