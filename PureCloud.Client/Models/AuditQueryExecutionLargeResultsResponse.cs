using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// AuditQueryExecutionLargeResultsResponse
/// </summary>
[DataContract]
public partial class AuditQueryExecutionLargeResultsResponse : IEquatable<AuditQueryExecutionLargeResultsResponse>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AuditQueryExecutionLargeResultsResponse" /> class.
    /// </summary>
    /// <param name="Id">Id of the audit query execution request..</param>
    /// <param name="PageSize">Number of results in a page..</param>
    /// <param name="Cursor">Optional cursor to indicate where to resume the results..</param>
    /// <param name="DownloadUrl">The presigned url which can be used to download the results..</param>
    public AuditQueryExecutionLargeResultsResponse(string Id = null, int? PageSize = null, string Cursor = null, string DownloadUrl = null)
    {
        this.Id = Id;
        this.PageSize = PageSize;
        this.Cursor = Cursor;
        this.DownloadUrl = DownloadUrl;

    }



    /// <summary>
    /// Id of the audit query execution request.
    /// </summary>
    /// <value>Id of the audit query execution request.</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }



    /// <summary>
    /// Number of results in a page.
    /// </summary>
    /// <value>Number of results in a page.</value>
    [DataMember(Name = "pageSize", EmitDefaultValue = false)]
    public int? PageSize { get; set; }



    /// <summary>
    /// Optional cursor to indicate where to resume the results.
    /// </summary>
    /// <value>Optional cursor to indicate where to resume the results.</value>
    [DataMember(Name = "cursor", EmitDefaultValue = false)]
    public string Cursor { get; set; }



    /// <summary>
    /// The presigned url which can be used to download the results.
    /// </summary>
    /// <value>The presigned url which can be used to download the results.</value>
    [DataMember(Name = "downloadUrl", EmitDefaultValue = false)]
    public string DownloadUrl { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AuditQueryExecutionLargeResultsResponse {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  PageSize: ").Append(PageSize).Append("\n");
        sb.Append("  Cursor: ").Append(Cursor).Append("\n");
        sb.Append("  DownloadUrl: ").Append(DownloadUrl).Append("\n");
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
        return Equals(obj as AuditQueryExecutionLargeResultsResponse);
    }

    /// <summary>
    /// Returns true if AuditQueryExecutionLargeResultsResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of AuditQueryExecutionLargeResultsResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AuditQueryExecutionLargeResultsResponse other)
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
                PageSize == other.PageSize ||
                PageSize != null &&
                PageSize.Equals(other.PageSize)
            ) &&
            (
                Cursor == other.Cursor ||
                Cursor != null &&
                Cursor.Equals(other.Cursor)
            ) &&
            (
                DownloadUrl == other.DownloadUrl ||
                DownloadUrl != null &&
                DownloadUrl.Equals(other.DownloadUrl)
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

            if (PageSize != null)
            {
                hash = hash * 59 + PageSize.GetHashCode();
            }

            if (Cursor != null)
            {
                hash = hash * 59 + Cursor.GetHashCode();
            }

            if (DownloadUrl != null)
            {
                hash = hash * 59 + DownloadUrl.GetHashCode();
            }

            return hash;
        }
    }
}
