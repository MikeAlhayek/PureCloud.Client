using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// PhoneNumberColumn
/// </summary>

public partial class PhoneNumberColumn : IEquatable<PhoneNumberColumn>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PhoneNumberColumn" /> class.
    /// </summary>
    /// <param name="ColumnName">ColumnName.</param>
    /// <param name="Type">Type.</param>
    public PhoneNumberColumn(string ColumnName = null, string Type = null)
    {
        this.ColumnName = ColumnName;
        this.Type = Type;

    }



    /// <summary>
    /// Gets or Sets ColumnName
    /// </summary>
    [JsonPropertyName("columnName")]
    public string ColumnName { get; set; }



    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class PhoneNumberColumn {\n");

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
        return Equals(obj as PhoneNumberColumn);
    }

    /// <summary>
    /// Returns true if PhoneNumberColumn instances are equal
    /// </summary>
    /// <param name="other">Instance of PhoneNumberColumn to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(PhoneNumberColumn other)
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
