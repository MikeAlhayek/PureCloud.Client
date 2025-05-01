using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// SelectedColumns
/// </summary>
[DataContract]
public partial class SelectedColumns : IEquatable<SelectedColumns>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SelectedColumns" /> class.
    /// </summary>
    /// <param name="ColumnOrder">Indicates the order/position of the selected column.</param>
    /// <param name="ColumnName">Indicates enum name of the column from the export view.</param>
    public SelectedColumns(int? ColumnOrder = null, string ColumnName = null)
    {
        this.ColumnOrder = ColumnOrder;
        this.ColumnName = ColumnName;

    }



    /// <summary>
    /// Indicates the order/position of the selected column
    /// </summary>
    /// <value>Indicates the order/position of the selected column</value>
    [DataMember(Name = "columnOrder", EmitDefaultValue = false)]
    public int? ColumnOrder { get; set; }



    /// <summary>
    /// Indicates enum name of the column from the export view
    /// </summary>
    /// <value>Indicates enum name of the column from the export view</value>
    [DataMember(Name = "columnName", EmitDefaultValue = false)]
    public string ColumnName { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class SelectedColumns {\n");

        sb.Append("  ColumnOrder: ").Append(ColumnOrder).Append("\n");
        sb.Append("  ColumnName: ").Append(ColumnName).Append("\n");
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
        return Equals(obj as SelectedColumns);
    }

    /// <summary>
    /// Returns true if SelectedColumns instances are equal
    /// </summary>
    /// <param name="other">Instance of SelectedColumns to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(SelectedColumns other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                ColumnOrder == other.ColumnOrder ||
                ColumnOrder != null &&
                ColumnOrder.Equals(other.ColumnOrder)
            ) &&
            (
                ColumnName == other.ColumnName ||
                ColumnName != null &&
                ColumnName.Equals(other.ColumnName)
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
            if (ColumnOrder != null)
            {
                hash = hash * 59 + ColumnOrder.GetHashCode();
            }

            if (ColumnName != null)
            {
                hash = hash * 59 + ColumnName.GetHashCode();
            }

            return hash;
        }
    }
}
