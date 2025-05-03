using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Column
/// </summary>

public partial class Column : IEquatable<Column>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Column" /> class.
    /// </summary>
    /// <param name="ColumnName">Column name. Mandatory for Fixed position/length file format..</param>
    /// <param name="ColumnNumber">0 based column number in delimited file format.</param>
    /// <param name="StartPosition">Zero-based position of the first column&#39;s character. Mandatory for Fixed position/length file format..</param>
    /// <param name="Length">Column width. Mandatory for Fixed position/length file format..</param>
    public Column(string ColumnName = null, int? ColumnNumber = null, int? StartPosition = null, int? Length = null)
    {
        this.ColumnName = ColumnName;
        this.ColumnNumber = ColumnNumber;
        this.StartPosition = StartPosition;
        this.Length = Length;

    }



    /// <summary>
    /// Column name. Mandatory for Fixed position/length file format.
    /// </summary>
    /// <value>Column name. Mandatory for Fixed position/length file format.</value>
    [JsonPropertyName("columnName")]
    public string ColumnName { get; set; }



    /// <summary>
    /// 0 based column number in delimited file format
    /// </summary>
    /// <value>0 based column number in delimited file format</value>
    [JsonPropertyName("columnNumber")]
    public int? ColumnNumber { get; set; }



    /// <summary>
    /// Zero-based position of the first column&#39;s character. Mandatory for Fixed position/length file format.
    /// </summary>
    /// <value>Zero-based position of the first column&#39;s character. Mandatory for Fixed position/length file format.</value>
    [JsonPropertyName("startPosition")]
    public int? StartPosition { get; set; }



    /// <summary>
    /// Column width. Mandatory for Fixed position/length file format.
    /// </summary>
    /// <value>Column width. Mandatory for Fixed position/length file format.</value>
    [JsonPropertyName("length")]
    public int? Length { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class Column {\n");

        sb.Append("  ColumnName: ").Append(ColumnName).Append("\n");
        sb.Append("  ColumnNumber: ").Append(ColumnNumber).Append("\n");
        sb.Append("  StartPosition: ").Append(StartPosition).Append("\n");
        sb.Append("  Length: ").Append(Length).Append("\n");
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
        return Equals(obj as Column);
    }

    /// <summary>
    /// Returns true if Column instances are equal
    /// </summary>
    /// <param name="other">Instance of Column to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Column other)
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
                ColumnNumber == other.ColumnNumber ||
                ColumnNumber != null &&
                ColumnNumber.Equals(other.ColumnNumber)
            ) &&
            (
                StartPosition == other.StartPosition ||
                StartPosition != null &&
                StartPosition.Equals(other.StartPosition)
            ) &&
            (
                Length == other.Length ||
                Length != null &&
                Length.Equals(other.Length)
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

            if (ColumnNumber != null)
            {
                hash = hash * 59 + ColumnNumber.GetHashCode();
            }

            if (StartPosition != null)
            {
                hash = hash * 59 + StartPosition.GetHashCode();
            }

            if (Length != null)
            {
                hash = hash * 59 + Length.GetHashCode();
            }

            return hash;
        }
    }
}
