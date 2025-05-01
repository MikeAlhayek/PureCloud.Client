using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AuditQueryRequest
/// </summary>
[DataContract]
public partial class AuditQueryRequest : IEquatable<AuditQueryRequest>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="AuditQueryRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected AuditQueryRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="AuditQueryRequest" /> class.
    /// </summary>
    /// <param name="Interval">Date and time range of data to query. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ssZ/YYYY-MM-DDThh:mm:ssZ (required).</param>
    /// <param name="ServiceName">Name of the service to query audits for..</param>
    /// <param name="Filters">Additional filters for the query..</param>
    /// <param name="Sort">Sort parameter for the query..</param>
    public AuditQueryRequest(string Interval = null, string ServiceName = null, List<AuditQueryFilter> Filters = null, List<AuditQuerySort> Sort = null)
    {
        this.Interval = Interval;
        this.ServiceName = ServiceName;
        this.Filters = Filters;
        this.Sort = Sort;

    }



    /// <summary>
    /// Date and time range of data to query. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ssZ/YYYY-MM-DDThh:mm:ssZ
    /// </summary>
    /// <value>Date and time range of data to query. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ssZ/YYYY-MM-DDThh:mm:ssZ</value>
    [DataMember(Name = "interval", EmitDefaultValue = false)]
    public string Interval { get; set; }



    /// <summary>
    /// Name of the service to query audits for.
    /// </summary>
    /// <value>Name of the service to query audits for.</value>
    [DataMember(Name = "serviceName", EmitDefaultValue = false)]
    public string ServiceName { get; set; }



    /// <summary>
    /// Additional filters for the query.
    /// </summary>
    /// <value>Additional filters for the query.</value>
    [DataMember(Name = "filters", EmitDefaultValue = false)]
    public List<AuditQueryFilter> Filters { get; set; }



    /// <summary>
    /// Sort parameter for the query.
    /// </summary>
    /// <value>Sort parameter for the query.</value>
    [DataMember(Name = "sort", EmitDefaultValue = false)]
    public List<AuditQuerySort> Sort { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AuditQueryRequest {\n");

        sb.Append("  Interval: ").Append(Interval).Append("\n");
        sb.Append("  ServiceName: ").Append(ServiceName).Append("\n");
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
        return Equals(obj as AuditQueryRequest);
    }

    /// <summary>
    /// Returns true if AuditQueryRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of AuditQueryRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AuditQueryRequest other)
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
                ServiceName == other.ServiceName ||
                ServiceName != null &&
                ServiceName.Equals(other.ServiceName)
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

            if (ServiceName != null)
            {
                hash = hash * 59 + ServiceName.GetHashCode();
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
