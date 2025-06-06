using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ArticlesFilter
/// </summary>

public partial class ArticlesFilter : IEquatable<ArticlesFilter>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ArticlesFilter" /> class.
    /// </summary>
    /// <param name="Labels">The labels filter..</param>
    /// <param name="Categories">The categories filter..</param>
    public ArticlesFilter(LabelsFilter Labels = null, CategoriesFilter Categories = null)
    {
        this.Labels = Labels;
        this.Categories = Categories;

    }



    /// <summary>
    /// The labels filter.
    /// </summary>
    /// <value>The labels filter.</value>
    [JsonPropertyName("labels")]
    public LabelsFilter Labels { get; set; }



    /// <summary>
    /// The categories filter.
    /// </summary>
    /// <value>The categories filter.</value>
    [JsonPropertyName("categories")]
    public CategoriesFilter Categories { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ArticlesFilter {\n");

        sb.Append("  Labels: ").Append(Labels).Append("\n");
        sb.Append("  Categories: ").Append(Categories).Append("\n");
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
        return Equals(obj as ArticlesFilter);
    }

    /// <summary>
    /// Returns true if ArticlesFilter instances are equal
    /// </summary>
    /// <param name="other">Instance of ArticlesFilter to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ArticlesFilter other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Labels == other.Labels ||
                Labels != null &&
                Labels.Equals(other.Labels)
            ) &&
            (
                Categories == other.Categories ||
                Categories != null &&
                Categories.Equals(other.Categories)
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
            if (Labels != null)
            {
                hash = hash * 59 + Labels.GetHashCode();
            }

            if (Categories != null)
            {
                hash = hash * 59 + Categories.GetHashCode();
            }

            return hash;
        }
    }
}
