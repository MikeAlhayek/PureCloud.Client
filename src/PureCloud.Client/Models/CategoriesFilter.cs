using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// CategoriesFilter
/// </summary>

public partial class CategoriesFilter : IEquatable<CategoriesFilter>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="CategoriesFilter" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected CategoriesFilter() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="CategoriesFilter" /> class.
    /// </summary>
    /// <param name="Entities">A list of categories to filter by. Articles matching any of the specified categories can be accessed. (required).</param>
    public CategoriesFilter(List<CategoryEntity> Entities = null)
    {
        this.Entities = Entities;

    }



    /// <summary>
    /// A list of categories to filter by. Articles matching any of the specified categories can be accessed.
    /// </summary>
    /// <value>A list of categories to filter by. Articles matching any of the specified categories can be accessed.</value>
    [JsonPropertyName("entities")]
    public List<CategoryEntity> Entities { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CategoriesFilter {\n");

        sb.Append("  Entities: ").Append(Entities).Append("\n");
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
        return Equals(obj as CategoriesFilter);
    }

    /// <summary>
    /// Returns true if CategoriesFilter instances are equal
    /// </summary>
    /// <param name="other">Instance of CategoriesFilter to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CategoriesFilter other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Entities == other.Entities ||
                Entities != null &&
                Entities.SequenceEqual(other.Entities)
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
            if (Entities != null)
            {
                hash = hash * 59 + Entities.GetHashCode();
            }

            return hash;
        }
    }
}
