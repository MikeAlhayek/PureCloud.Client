using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// KnowledgeCategoryRequest
/// </summary>

public partial class KnowledgeCategoryRequest : IEquatable<KnowledgeCategoryRequest>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="KnowledgeCategoryRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected KnowledgeCategoryRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="KnowledgeCategoryRequest" /> class.
    /// </summary>
    /// <param name="Name">Category name (required).</param>
    /// <param name="Description">Category description.</param>
    /// <param name="Parent">Category parent.</param>
    public KnowledgeCategoryRequest(string Name = null, string Description = null, DocumentCategoryInput Parent = null)
    {
        this.Name = Name;
        this.Description = Description;
        this.Parent = Parent;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; private set; }



    /// <summary>
    /// Category name
    /// </summary>
    /// <value>Category name</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// Category description
    /// </summary>
    /// <value>Category description</value>
    [JsonPropertyName("description")]
    public string Description { get; set; }



    /// <summary>
    /// Category parent
    /// </summary>
    /// <value>Category parent</value>
    [JsonPropertyName("parent")]
    public DocumentCategoryInput Parent { get; set; }



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
        sb.Append("class KnowledgeCategoryRequest {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  Parent: ").Append(Parent).Append("\n");
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
        return Equals(obj as KnowledgeCategoryRequest);
    }

    /// <summary>
    /// Returns true if KnowledgeCategoryRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of KnowledgeCategoryRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(KnowledgeCategoryRequest other)
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
                Parent == other.Parent ||
                Parent != null &&
                Parent.Equals(other.Parent)
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

            if (Parent != null)
            {
                hash = hash * 59 + Parent.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
