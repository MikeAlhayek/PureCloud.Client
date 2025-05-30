using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// QMAuditQueryRequest
/// </summary>

public partial class QMAuditQueryRequest : IEquatable<QMAuditQueryRequest>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="QMAuditQueryRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected QMAuditQueryRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="QMAuditQueryRequest" /> class.
    /// </summary>
    /// <param name="Interval">Date and time range of data to query. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (required).</param>
    /// <param name="Filters">List of filters for the query. (required).</param>
    /// <param name="Sort">Sort parameter for the query..</param>
    public QMAuditQueryRequest(string Interval = null, List<QualityAuditQueryFilter> Filters = null, List<AuditQuerySort> Sort = null)
    {
        this.Interval = Interval;
        this.Filters = Filters;
        this.Sort = Sort;

    }



    /// <summary>
    /// Date and time range of data to query. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss
    /// </summary>
    /// <value>Date and time range of data to query. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss</value>
    [JsonPropertyName("interval")]
    public string Interval { get; set; }



    /// <summary>
    /// List of filters for the query.
    /// </summary>
    /// <value>List of filters for the query.</value>
    [JsonPropertyName("filters")]
    public List<QualityAuditQueryFilter> Filters { get; set; }



    /// <summary>
    /// Sort parameter for the query.
    /// </summary>
    /// <value>Sort parameter for the query.</value>
    [JsonPropertyName("sort")]
    public List<AuditQuerySort> Sort { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class QMAuditQueryRequest {\n");

        sb.Append("  Interval: ").Append(Interval).Append("\n");
        sb.Append("  Filters: ").Append(Filters).Append("\n");
        sb.Append("  Sort: ").Append(Sort).Append("\n");
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
        return Equals(obj as QMAuditQueryRequest);
    }

    /// <summary>
    /// Returns true if QMAuditQueryRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of QMAuditQueryRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(QMAuditQueryRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Interval == other.Interval ||
                Interval != null &&
                Interval.Equals(other.Interval)
            ) &&
            (
                Filters == other.Filters ||
                Filters != null &&
                Filters.SequenceEqual(other.Filters)
            ) &&
            (
                Sort == other.Sort ||
                Sort != null &&
                Sort.SequenceEqual(other.Sort)
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
            if (Interval != null)
            {
                hash = hash * 59 + Interval.GetHashCode();
            }

            if (Filters != null)
            {
                hash = hash * 59 + Filters.GetHashCode();
            }

            if (Sort != null)
            {
                hash = hash * 59 + Sort.GetHashCode();
            }

            return hash;
        }
    }
}
