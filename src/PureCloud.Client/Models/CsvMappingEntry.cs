using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// CsvMappingEntry
/// </summary>

public partial class CsvMappingEntry : IEquatable<CsvMappingEntry>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="CsvMappingEntry" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected CsvMappingEntry() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="CsvMappingEntry" /> class.
    /// </summary>
    /// <param name="SourceField">CSV field to map data from (required).</param>
    /// <param name="TargetField">Json path to map data to (required).</param>
    public CsvMappingEntry(string SourceField = null, string TargetField = null)
    {
        this.SourceField = SourceField;
        this.TargetField = TargetField;

    }



    /// <summary>
    /// CSV field to map data from
    /// </summary>
    /// <value>CSV field to map data from</value>
    [JsonPropertyName("sourceField")]
    public string SourceField { get; set; }



    /// <summary>
    /// Json path to map data to
    /// </summary>
    /// <value>Json path to map data to</value>
    [JsonPropertyName("targetField")]
    public string TargetField { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CsvMappingEntry {\n");

        sb.Append("  SourceField: ").Append(SourceField).Append("\n");
        sb.Append("  TargetField: ").Append(TargetField).Append("\n");
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
        return Equals(obj as CsvMappingEntry);
    }

    /// <summary>
    /// Returns true if CsvMappingEntry instances are equal
    /// </summary>
    /// <param name="other">Instance of CsvMappingEntry to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CsvMappingEntry other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                SourceField == other.SourceField ||
                SourceField != null &&
                SourceField.Equals(other.SourceField)
            ) &&
            (
                TargetField == other.TargetField ||
                TargetField != null &&
                TargetField.Equals(other.TargetField)
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
            if (SourceField != null)
            {
                hash = hash * 59 + SourceField.GetHashCode();
            }

            if (TargetField != null)
            {
                hash = hash * 59 + TargetField.GetHashCode();
            }

            return hash;
        }
    }
}
