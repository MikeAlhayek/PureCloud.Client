using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ContactImportJobMetadata
/// </summary>
[DataContract]
public partial class ContactImportJobMetadata : IEquatable<ContactImportJobMetadata>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ContactImportJobMetadata" /> class.
    /// </summary>
    /// <param name="FileName">FileName.</param>
    /// <param name="DryRunFailedCount">DryRunFailedCount.</param>
    /// <param name="DryRunSuccessCount">DryRunSuccessCount.</param>
    /// <param name="DryRunReportDownloadUrl">DryRunReportDownloadUrl.</param>
    /// <param name="ImportFailedCount">ImportFailedCount.</param>
    /// <param name="ImportSuccessCount">ImportSuccessCount.</param>
    /// <param name="ImportReportDownloadUrl">ImportReportDownloadUrl.</param>
    public ContactImportJobMetadata(string FileName = null, int? DryRunFailedCount = null, int? DryRunSuccessCount = null, string DryRunReportDownloadUrl = null, int? ImportFailedCount = null, int? ImportSuccessCount = null, string ImportReportDownloadUrl = null)
    {
        this.FileName = FileName;
        this.DryRunFailedCount = DryRunFailedCount;
        this.DryRunSuccessCount = DryRunSuccessCount;
        this.DryRunReportDownloadUrl = DryRunReportDownloadUrl;
        this.ImportFailedCount = ImportFailedCount;
        this.ImportSuccessCount = ImportSuccessCount;
        this.ImportReportDownloadUrl = ImportReportDownloadUrl;

    }



    /// <summary>
    /// Gets or Sets FileName
    /// </summary>
    [DataMember(Name = "fileName", EmitDefaultValue = false)]
    public string FileName { get; set; }



    /// <summary>
    /// Gets or Sets DryRunFailedCount
    /// </summary>
    [DataMember(Name = "dryRunFailedCount", EmitDefaultValue = false)]
    public int? DryRunFailedCount { get; set; }



    /// <summary>
    /// Gets or Sets DryRunSuccessCount
    /// </summary>
    [DataMember(Name = "dryRunSuccessCount", EmitDefaultValue = false)]
    public int? DryRunSuccessCount { get; set; }



    /// <summary>
    /// Gets or Sets DryRunReportDownloadUrl
    /// </summary>
    [DataMember(Name = "dryRunReportDownloadUrl", EmitDefaultValue = false)]
    public string DryRunReportDownloadUrl { get; set; }



    /// <summary>
    /// Gets or Sets ImportFailedCount
    /// </summary>
    [DataMember(Name = "importFailedCount", EmitDefaultValue = false)]
    public int? ImportFailedCount { get; set; }



    /// <summary>
    /// Gets or Sets ImportSuccessCount
    /// </summary>
    [DataMember(Name = "importSuccessCount", EmitDefaultValue = false)]
    public int? ImportSuccessCount { get; set; }



    /// <summary>
    /// Gets or Sets ImportReportDownloadUrl
    /// </summary>
    [DataMember(Name = "importReportDownloadUrl", EmitDefaultValue = false)]
    public string ImportReportDownloadUrl { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ContactImportJobMetadata {\n");

        sb.Append("  FileName: ").Append(FileName).Append("\n");
        sb.Append("  DryRunFailedCount: ").Append(DryRunFailedCount).Append("\n");
        sb.Append("  DryRunSuccessCount: ").Append(DryRunSuccessCount).Append("\n");
        sb.Append("  DryRunReportDownloadUrl: ").Append(DryRunReportDownloadUrl).Append("\n");
        sb.Append("  ImportFailedCount: ").Append(ImportFailedCount).Append("\n");
        sb.Append("  ImportSuccessCount: ").Append(ImportSuccessCount).Append("\n");
        sb.Append("  ImportReportDownloadUrl: ").Append(ImportReportDownloadUrl).Append("\n");
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
        return Equals(obj as ContactImportJobMetadata);
    }

    /// <summary>
    /// Returns true if ContactImportJobMetadata instances are equal
    /// </summary>
    /// <param name="other">Instance of ContactImportJobMetadata to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ContactImportJobMetadata other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                FileName == other.FileName ||
                FileName != null &&
                FileName.Equals(other.FileName)
            ) &&
            (
                DryRunFailedCount == other.DryRunFailedCount ||
                DryRunFailedCount != null &&
                DryRunFailedCount.Equals(other.DryRunFailedCount)
            ) &&
            (
                DryRunSuccessCount == other.DryRunSuccessCount ||
                DryRunSuccessCount != null &&
                DryRunSuccessCount.Equals(other.DryRunSuccessCount)
            ) &&
            (
                DryRunReportDownloadUrl == other.DryRunReportDownloadUrl ||
                DryRunReportDownloadUrl != null &&
                DryRunReportDownloadUrl.Equals(other.DryRunReportDownloadUrl)
            ) &&
            (
                ImportFailedCount == other.ImportFailedCount ||
                ImportFailedCount != null &&
                ImportFailedCount.Equals(other.ImportFailedCount)
            ) &&
            (
                ImportSuccessCount == other.ImportSuccessCount ||
                ImportSuccessCount != null &&
                ImportSuccessCount.Equals(other.ImportSuccessCount)
            ) &&
            (
                ImportReportDownloadUrl == other.ImportReportDownloadUrl ||
                ImportReportDownloadUrl != null &&
                ImportReportDownloadUrl.Equals(other.ImportReportDownloadUrl)
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
            if (FileName != null)
            {
                hash = hash * 59 + FileName.GetHashCode();
            }

            if (DryRunFailedCount != null)
            {
                hash = hash * 59 + DryRunFailedCount.GetHashCode();
            }

            if (DryRunSuccessCount != null)
            {
                hash = hash * 59 + DryRunSuccessCount.GetHashCode();
            }

            if (DryRunReportDownloadUrl != null)
            {
                hash = hash * 59 + DryRunReportDownloadUrl.GetHashCode();
            }

            if (ImportFailedCount != null)
            {
                hash = hash * 59 + ImportFailedCount.GetHashCode();
            }

            if (ImportSuccessCount != null)
            {
                hash = hash * 59 + ImportSuccessCount.GetHashCode();
            }

            if (ImportReportDownloadUrl != null)
            {
                hash = hash * 59 + ImportReportDownloadUrl.GetHashCode();
            }

            return hash;
        }
    }
}
