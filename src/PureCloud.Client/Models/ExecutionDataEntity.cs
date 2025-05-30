using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Represents an individual result of an execution data lookup
/// </summary>

public partial class ExecutionDataEntity : IEquatable<ExecutionDataEntity>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ExecutionDataEntity" /> class.
    /// </summary>
    /// <param name="Id">The id of the execution requested.</param>
    /// <param name="DownloadUri">A downloadable link to the execution data file..</param>
    /// <param name="Failed">If the retrieval failed (not found, no permission, etc;), this will be set true..</param>
    /// <param name="StatusCode">This will contain the http status code for the failure.</param>
    public ExecutionDataEntity(string Id = null, string DownloadUri = null, bool? Failed = null, string StatusCode = null)
    {
        this.Id = Id;
        this.DownloadUri = DownloadUri;
        this.Failed = Failed;
        this.StatusCode = StatusCode;

    }



    /// <summary>
    /// The id of the execution requested
    /// </summary>
    /// <value>The id of the execution requested</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// A downloadable link to the execution data file.
    /// </summary>
    /// <value>A downloadable link to the execution data file.</value>
    [JsonPropertyName("downloadUri")]
    public string DownloadUri { get; set; }



    /// <summary>
    /// If the retrieval failed (not found, no permission, etc;), this will be set true.
    /// </summary>
    /// <value>If the retrieval failed (not found, no permission, etc;), this will be set true.</value>
    [JsonPropertyName("failed")]
    public bool? Failed { get; set; }



    /// <summary>
    /// This will contain the http status code for the failure
    /// </summary>
    /// <value>This will contain the http status code for the failure</value>
    [JsonPropertyName("statusCode")]
    public string StatusCode { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ExecutionDataEntity {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  DownloadUri: ").Append(DownloadUri).Append("\n");
        sb.Append("  Failed: ").Append(Failed).Append("\n");
        sb.Append("  StatusCode: ").Append(StatusCode).Append("\n");
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
        return Equals(obj as ExecutionDataEntity);
    }

    /// <summary>
    /// Returns true if ExecutionDataEntity instances are equal
    /// </summary>
    /// <param name="other">Instance of ExecutionDataEntity to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ExecutionDataEntity other)
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
                DownloadUri == other.DownloadUri ||
                DownloadUri != null &&
                DownloadUri.Equals(other.DownloadUri)
            ) &&
            (
                Failed == other.Failed ||
                Failed != null &&
                Failed.Equals(other.Failed)
            ) &&
            (
                StatusCode == other.StatusCode ||
                StatusCode != null &&
                StatusCode.Equals(other.StatusCode)
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

            if (DownloadUri != null)
            {
                hash = hash * 59 + DownloadUri.GetHashCode();
            }

            if (Failed != null)
            {
                hash = hash * 59 + Failed.GetHashCode();
            }

            if (StatusCode != null)
            {
                hash = hash * 59 + StatusCode.GetHashCode();
            }

            return hash;
        }
    }
}
