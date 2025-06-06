using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// CategoryEntity
/// </summary>

public partial class CategoryEntity : IEquatable<CategoryEntity>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="CategoryEntity" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected CategoryEntity() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="CategoryEntity" /> class.
    /// </summary>
    /// <param name="Id">The Id of the category. (required).</param>
    public CategoryEntity(string Id = null)
    {
        this.Id = Id;

    }



    /// <summary>
    /// The Id of the category.
    /// </summary>
    /// <value>The Id of the category.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// The selfUri of the category.
    /// </summary>
    /// <value>The selfUri of the category.</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CategoryEntity {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
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
        return Equals(obj as CategoryEntity);
    }

    /// <summary>
    /// Returns true if CategoryEntity instances are equal
    /// </summary>
    /// <param name="other">Instance of CategoryEntity to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CategoryEntity other)
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

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
