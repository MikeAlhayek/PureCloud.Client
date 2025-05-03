using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// CategoryReference
/// </summary>

public partial class CategoryReference : IEquatable<CategoryReference>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="CategoryReference" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected CategoryReference() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="CategoryReference" /> class.
    /// </summary>
    /// <param name="Id">The globally unique identifier for the category. (required).</param>
    /// <param name="Name">Category name..</param>
    /// <param name="ParentCategory">The reference to category to which this category belongs to..</param>
    public CategoryReference(string Id = null, string Name = null, CategoryReference ParentCategory = null)
    {
        this.Id = Id;
        this.Name = Name;
        this.ParentCategory = ParentCategory;

    }



    /// <summary>
    /// The globally unique identifier for the category.
    /// </summary>
    /// <value>The globally unique identifier for the category.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// Category name.
    /// </summary>
    /// <value>Category name.</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// The reference to category to which this category belongs to.
    /// </summary>
    /// <value>The reference to category to which this category belongs to.</value>
    [JsonPropertyName("parentCategory")]
    public CategoryReference ParentCategory { get; set; }



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
        sb.Append("class CategoryReference {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  ParentCategory: ").Append(ParentCategory).Append("\n");
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
        return Equals(obj as CategoryReference);
    }

    /// <summary>
    /// Returns true if CategoryReference instances are equal
    /// </summary>
    /// <param name="other">Instance of CategoryReference to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CategoryReference other)
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
                ParentCategory == other.ParentCategory ||
                ParentCategory != null &&
                ParentCategory.Equals(other.ParentCategory)
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

            if (ParentCategory != null)
            {
                hash = hash * 59 + ParentCategory.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
