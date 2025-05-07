using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// HistoricalImportStatusJobResponse
/// </summary>

public partial class HistoricalImportStatusJobResponse : IEquatable<HistoricalImportStatusJobResponse>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="HistoricalImportStatusJobResponse" /> class.
    /// </summary>
    /// <param name="ImportStatusResult">The historical import status result of the import job.</param>
    public HistoricalImportStatusJobResponse(HistoricalImportStatus ImportStatusResult = null)
    {
        this.ImportStatusResult = ImportStatusResult;

    }



    /// <summary>
    /// The job id for the import request
    /// </summary>
    /// <value>The job id for the import request</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// The historical import status result of the import job
    /// </summary>
    /// <value>The historical import status result of the import job</value>
    [JsonPropertyName("importStatusResult")]
    public HistoricalImportStatus ImportStatusResult { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class HistoricalImportStatusJobResponse {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  ImportStatusResult: ").Append(ImportStatusResult).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
        return Equals(obj as HistoricalImportStatusJobResponse);
    }

    /// <summary>
    /// Returns true if HistoricalImportStatusJobResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of HistoricalImportStatusJobResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(HistoricalImportStatusJobResponse other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Id == other.Id ||
                Id != null &&
                Id.Equals(other.Id)
            ) &&
            (
                ImportStatusResult == other.ImportStatusResult ||
                ImportStatusResult != null &&
                ImportStatusResult.Equals(other.ImportStatusResult)
            ) &&
            (
                SelfUri == other.SelfUri ||
                SelfUri != null &&
                SelfUri.Equals(other.SelfUri)
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
            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            if (ImportStatusResult != null)
            {
                hash = hash * 59 + ImportStatusResult.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
