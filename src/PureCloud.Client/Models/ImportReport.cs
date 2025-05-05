using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ImportReport
/// </summary>

public partial class ImportReport : IEquatable<ImportReport>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ImportReport" /> class.
    /// </summary>
    /// <param name="Errors">Errors.</param>
    /// <param name="Validated">Validated.</param>
    /// <param name="Imported">Imported.</param>
    /// <param name="TotalDocuments">TotalDocuments.</param>
    public ImportReport(List<ImportError> Errors = null, ResultCounters Validated = null, ResultCounters Imported = null, int? TotalDocuments = null)
    {
        this.Errors = Errors;
        this.Validated = Validated;
        this.Imported = Imported;
        this.TotalDocuments = TotalDocuments;

    }



    /// <summary>
    /// Gets or Sets Errors
    /// </summary>
    [JsonPropertyName("errors")]
    public List<ImportError> Errors { get; set; }



    /// <summary>
    /// Gets or Sets Validated
    /// </summary>
    [JsonPropertyName("validated")]
    public ResultCounters Validated { get; set; }



    /// <summary>
    /// Gets or Sets Imported
    /// </summary>
    [JsonPropertyName("imported")]
    public ResultCounters Imported { get; set; }



    /// <summary>
    /// Gets or Sets TotalDocuments
    /// </summary>
    [JsonPropertyName("totalDocuments")]
    public int? TotalDocuments { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ImportReport {\n");

        sb.Append("  Errors: ").Append(Errors).Append("\n");
        sb.Append("  Validated: ").Append(Validated).Append("\n");
        sb.Append("  Imported: ").Append(Imported).Append("\n");
        sb.Append("  TotalDocuments: ").Append(TotalDocuments).Append("\n");
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
        return Equals(obj as ImportReport);
    }

    /// <summary>
    /// Returns true if ImportReport instances are equal
    /// </summary>
    /// <param name="other">Instance of ImportReport to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ImportReport other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Errors == other.Errors ||
                Errors != null &&
                Errors.SequenceEqual(other.Errors)
            ) &&
            (
                Validated == other.Validated ||
                Validated != null &&
                Validated.Equals(other.Validated)
            ) &&
            (
                Imported == other.Imported ||
                Imported != null &&
                Imported.Equals(other.Imported)
            ) &&
            (
                TotalDocuments == other.TotalDocuments ||
                TotalDocuments != null &&
                TotalDocuments.Equals(other.TotalDocuments)
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
            if (Errors != null)
            {
                hash = hash * 59 + Errors.GetHashCode();
            }

            if (Validated != null)
            {
                hash = hash * 59 + Validated.GetHashCode();
            }

            if (Imported != null)
            {
                hash = hash * 59 + Imported.GetHashCode();
            }

            if (TotalDocuments != null)
            {
                hash = hash * 59 + TotalDocuments.GetHashCode();
            }

            return hash;
        }
    }
}
