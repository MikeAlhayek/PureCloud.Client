using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// List of available Action categories.
/// </summary>

public partial class Category : IEquatable<Category>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Category" /> class.
    /// </summary>
    /// <param name="Name">Category name.</param>
    public Category(string Name = null)
    {
        this.Name = Name;

    }



    /// <summary>
    /// Category name
    /// </summary>
    /// <value>Category name</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class Category {\n");

        sb.Append("  Name: ").Append(Name).Append("\n");
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
        return Equals(obj as Category);
    }

    /// <summary>
    /// Returns true if Category instances are equal
    /// </summary>
    /// <param name="other">Instance of Category to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Category other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
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
            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            return hash;
        }
    }
}
