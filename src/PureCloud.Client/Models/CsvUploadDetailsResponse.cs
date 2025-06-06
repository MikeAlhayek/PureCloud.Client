using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// CsvUploadDetailsResponse
/// </summary>

public partial class CsvUploadDetailsResponse : IEquatable<CsvUploadDetailsResponse>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="CsvUploadDetailsResponse" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected CsvUploadDetailsResponse() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="CsvUploadDetailsResponse" /> class.
    /// </summary>
    /// <param name="UploadId">Id for the upload (required).</param>
    /// <param name="FileName">File name for the upload.</param>
    /// <param name="ValidationResult">Validation for the upload (required).</param>
    public CsvUploadDetailsResponse(string UploadId = null, string FileName = null, ValidationResult ValidationResult = null)
    {
        this.UploadId = UploadId;
        this.FileName = FileName;
        this.ValidationResult = ValidationResult;

    }



    /// <summary>
    /// Id for the upload
    /// </summary>
    /// <value>Id for the upload</value>
    [JsonPropertyName("uploadId")]
    public string UploadId { get; set; }



    /// <summary>
    /// File name for the upload
    /// </summary>
    /// <value>File name for the upload</value>
    [JsonPropertyName("fileName")]
    public string FileName { get; set; }



    /// <summary>
    /// Validation for the upload
    /// </summary>
    /// <value>Validation for the upload</value>
    [JsonPropertyName("validationResult")]
    public ValidationResult ValidationResult { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CsvUploadDetailsResponse {\n");

        sb.Append("  UploadId: ").Append(UploadId).Append("\n");
        sb.Append("  FileName: ").Append(FileName).Append("\n");
        sb.Append("  ValidationResult: ").Append(ValidationResult).Append("\n");
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
        return Equals(obj as CsvUploadDetailsResponse);
    }

    /// <summary>
    /// Returns true if CsvUploadDetailsResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of CsvUploadDetailsResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CsvUploadDetailsResponse other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                UploadId == other.UploadId ||
                UploadId != null &&
                UploadId.Equals(other.UploadId)
            ) &&
            (
                FileName == other.FileName ||
                FileName != null &&
                FileName.Equals(other.FileName)
            ) &&
            (
                ValidationResult == other.ValidationResult ||
                ValidationResult != null &&
                ValidationResult.Equals(other.ValidationResult)
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
            if (UploadId != null)
            {
                hash = hash * 59 + UploadId.GetHashCode();
            }

            if (FileName != null)
            {
                hash = hash * 59 + FileName.GetHashCode();
            }

            if (ValidationResult != null)
            {
                hash = hash * 59 + ValidationResult.GetHashCode();
            }

            return hash;
        }
    }
}
