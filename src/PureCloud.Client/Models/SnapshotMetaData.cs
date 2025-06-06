using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// SnapshotMetaData
/// </summary>

public partial class SnapshotMetaData : IEquatable<SnapshotMetaData>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SnapshotMetaData" /> class.
    /// </summary>
    /// <param name="DownloadUrl">URL to fetch the snapshot meta data information.</param>
    /// <param name="DownloadResult">Result will always come via downloadUrls; however the schema is included for documentation.</param>
    public SnapshotMetaData(string DownloadUrl = null, SnapshotMetaDataResult DownloadResult = null)
    {
        this.DownloadUrl = DownloadUrl;
        this.DownloadResult = DownloadResult;

    }



    /// <summary>
    /// URL to fetch the snapshot meta data information
    /// </summary>
    /// <value>URL to fetch the snapshot meta data information</value>
    [JsonPropertyName("downloadUrl")]
    public string DownloadUrl { get; set; }



    /// <summary>
    /// Result will always come via downloadUrls; however the schema is included for documentation
    /// </summary>
    /// <value>Result will always come via downloadUrls; however the schema is included for documentation</value>
    [JsonPropertyName("downloadResult")]
    public SnapshotMetaDataResult DownloadResult { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class SnapshotMetaData {\n");

        sb.Append("  DownloadUrl: ").Append(DownloadUrl).Append("\n");
        sb.Append("  DownloadResult: ").Append(DownloadResult).Append("\n");
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
        return Equals(obj as SnapshotMetaData);
    }

    /// <summary>
    /// Returns true if SnapshotMetaData instances are equal
    /// </summary>
    /// <param name="other">Instance of SnapshotMetaData to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(SnapshotMetaData other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                DownloadUrl == other.DownloadUrl ||
                DownloadUrl != null &&
                DownloadUrl.Equals(other.DownloadUrl)
            ) &&
            (
                DownloadResult == other.DownloadResult ||
                DownloadResult != null &&
                DownloadResult.Equals(other.DownloadResult)
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
            if (DownloadUrl != null)
            {
                hash = hash * 59 + DownloadUrl.GetHashCode();
            }

            if (DownloadResult != null)
            {
                hash = hash * 59 + DownloadResult.GetHashCode();
            }

            return hash;
        }
    }
}
