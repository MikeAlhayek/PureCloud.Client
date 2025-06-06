using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// QualityAuditQueryExecutionResultsResponse
/// </summary>

public partial class QualityAuditQueryExecutionResultsResponse : IEquatable<QualityAuditQueryExecutionResultsResponse>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="QualityAuditQueryExecutionResultsResponse" /> class.
    /// </summary>
    /// <param name="Id">Id of the audit query execution request..</param>
    /// <param name="PageSize">Number of results in a page..</param>
    /// <param name="Cursor">Optional cursor to indicate where to resume the results..</param>
    /// <param name="Entities">List of audit messages..</param>
    public QualityAuditQueryExecutionResultsResponse(string Id = null, int? PageSize = null, string Cursor = null, List<QualityAuditLogMessage> Entities = null)
    {
        this.Id = Id;
        this.PageSize = PageSize;
        this.Cursor = Cursor;
        this.Entities = Entities;

    }



    /// <summary>
    /// Id of the audit query execution request.
    /// </summary>
    /// <value>Id of the audit query execution request.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// Number of results in a page.
    /// </summary>
    /// <value>Number of results in a page.</value>
    [JsonPropertyName("pageSize")]
    public int? PageSize { get; set; }



    /// <summary>
    /// Optional cursor to indicate where to resume the results.
    /// </summary>
    /// <value>Optional cursor to indicate where to resume the results.</value>
    [JsonPropertyName("cursor")]
    public string Cursor { get; set; }



    /// <summary>
    /// List of audit messages.
    /// </summary>
    /// <value>List of audit messages.</value>
    [JsonPropertyName("entities")]
    public List<QualityAuditLogMessage> Entities { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class QualityAuditQueryExecutionResultsResponse {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  PageSize: ").Append(PageSize).Append("\n");
        sb.Append("  Cursor: ").Append(Cursor).Append("\n");
        sb.Append("  Entities: ").Append(Entities).Append("\n");
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
        return Equals(obj as QualityAuditQueryExecutionResultsResponse);
    }

    /// <summary>
    /// Returns true if QualityAuditQueryExecutionResultsResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of QualityAuditQueryExecutionResultsResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(QualityAuditQueryExecutionResultsResponse other)
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
                Entities == other.Entities ||
                Entities != null &&
                Entities.SequenceEqual(other.Entities)
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

            if (Entities != null)
            {
                hash = hash * 59 + Entities.GetHashCode();
            }

            return hash;
        }
    }
}
