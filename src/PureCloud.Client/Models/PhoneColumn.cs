using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// PhoneColumn
/// </summary>

public partial class PhoneColumn : IEquatable<PhoneColumn>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="PhoneColumn" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected PhoneColumn() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="PhoneColumn" /> class.
    /// </summary>
    /// <param name="ColumnName">The name of the phone column. (required).</param>
    /// <param name="Type">The type of the phone column. For example, &#39;cell&#39; or &#39;home&#39;. (required).</param>
    public PhoneColumn(string ColumnName = null, string Type = null)
    {
        this.ColumnName = ColumnName;
        this.Type = Type;

    }



    /// <summary>
    /// The name of the phone column.
    /// </summary>
    /// <value>The name of the phone column.</value>
    [JsonPropertyName("columnName")]
    public string ColumnName { get; set; }



    /// <summary>
    /// The type of the phone column. For example, &#39;cell&#39; or &#39;home&#39;.
    /// </summary>
    /// <value>The type of the phone column. For example, &#39;cell&#39; or &#39;home&#39;.</value>
    [JsonPropertyName("type")]
    public string Type { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class PhoneColumn {\n");

        sb.Append("  ColumnName: ").Append(ColumnName).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
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
        return Equals(obj as PhoneColumn);
    }

    /// <summary>
    /// Returns true if PhoneColumn instances are equal
    /// </summary>
    /// <param name="other">Instance of PhoneColumn to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(PhoneColumn other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                ColumnName == other.ColumnName ||
                ColumnName != null &&
                ColumnName.Equals(other.ColumnName)
            ) &&
            (
                Type == other.Type ||
                Type != null &&
                Type.Equals(other.Type)
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
            if (ColumnName != null)
            {
                hash = hash * 59 + ColumnName.GetHashCode();
            }

            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
            }

            return hash;
        }
    }
}
