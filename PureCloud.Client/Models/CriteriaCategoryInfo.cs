using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// CriteriaCategoryInfo
/// </summary>
[DataContract]
public partial class CriteriaCategoryInfo : IEquatable<CriteriaCategoryInfo>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CriteriaCategoryInfo" /> class.
    /// </summary>
    /// <param name="CategoryId">CategoryId.</param>
    /// <param name="DisplayOrder">DisplayOrder.</param>
    public CriteriaCategoryInfo(string CategoryId = null, int? DisplayOrder = null)
    {
        this.CategoryId = CategoryId;
        this.DisplayOrder = DisplayOrder;

    }



    /// <summary>
    /// Gets or Sets CategoryId
    /// </summary>
    [DataMember(Name = "categoryId", EmitDefaultValue = false)]
    public string CategoryId { get; set; }



    /// <summary>
    /// Gets or Sets DisplayOrder
    /// </summary>
    [DataMember(Name = "displayOrder", EmitDefaultValue = false)]
    public int? DisplayOrder { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CriteriaCategoryInfo {\n");

        sb.Append("  CategoryId: ").Append(CategoryId).Append("\n");
        sb.Append("  DisplayOrder: ").Append(DisplayOrder).Append("\n");
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
        return Equals(obj as CriteriaCategoryInfo);
    }

    /// <summary>
    /// Returns true if CriteriaCategoryInfo instances are equal
    /// </summary>
    /// <param name="other">Instance of CriteriaCategoryInfo to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CriteriaCategoryInfo other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                CategoryId == other.CategoryId ||
                CategoryId != null &&
                CategoryId.Equals(other.CategoryId)
            ) &&
            (
                DisplayOrder == other.DisplayOrder ||
                DisplayOrder != null &&
                DisplayOrder.Equals(other.DisplayOrder)
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
            if (CategoryId != null)
            {
                hash = hash * 59 + CategoryId.GetHashCode();
            }

            if (DisplayOrder != null)
            {
                hash = hash * 59 + DisplayOrder.GetHashCode();
            }

            return hash;
        }
    }
}
