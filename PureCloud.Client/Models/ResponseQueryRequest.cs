using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// Used to query for responses
/// </summary>
[DataContract]
public partial class ResponseQueryRequest : IEquatable<ResponseQueryRequest>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ResponseQueryRequest" /> class.
    /// </summary>
    /// <param name="QueryPhrase">Query phrase to search response text and name. If not set will match all..</param>
    /// <param name="PageSize">The maximum number of hits to return. Default: 25, Maximum: 500..</param>
    /// <param name="PageNumber">Page Number.</param>
    /// <param name="Filters">Filter the query results..</param>
    public ResponseQueryRequest(string QueryPhrase = null, int? PageSize = null, int? PageNumber = null, List<ResponseFilter> Filters = null)
    {
        this.QueryPhrase = QueryPhrase;
        this.PageSize = PageSize;
        this.PageNumber = PageNumber;
        this.Filters = Filters;

    }



    /// <summary>
    /// Query phrase to search response text and name. If not set will match all.
    /// </summary>
    /// <value>Query phrase to search response text and name. If not set will match all.</value>
    [DataMember(Name = "queryPhrase", EmitDefaultValue = false)]
    public string QueryPhrase { get; set; }



    /// <summary>
    /// The maximum number of hits to return. Default: 25, Maximum: 500.
    /// </summary>
    /// <value>The maximum number of hits to return. Default: 25, Maximum: 500.</value>
    [DataMember(Name = "pageSize", EmitDefaultValue = false)]
    public int? PageSize { get; set; }



    /// <summary>
    /// Page Number
    /// </summary>
    /// <value>Page Number</value>
    [DataMember(Name = "pageNumber", EmitDefaultValue = false)]
    public int? PageNumber { get; set; }



    /// <summary>
    /// Filter the query results.
    /// </summary>
    /// <value>Filter the query results.</value>
    [DataMember(Name = "filters", EmitDefaultValue = false)]
    public List<ResponseFilter> Filters { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ResponseQueryRequest {\n");

        sb.Append("  QueryPhrase: ").Append(QueryPhrase).Append("\n");
        sb.Append("  PageSize: ").Append(PageSize).Append("\n");
        sb.Append("  PageNumber: ").Append(PageNumber).Append("\n");
        sb.Append("  Filters: ").Append(Filters).Append("\n");
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
        return Equals(obj as ResponseQueryRequest);
    }

    /// <summary>
    /// Returns true if ResponseQueryRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of ResponseQueryRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ResponseQueryRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                QueryPhrase == other.QueryPhrase ||
                QueryPhrase != null &&
                QueryPhrase.Equals(other.QueryPhrase)
            ) &&
            (
                PageSize == other.PageSize ||
                PageSize != null &&
                PageSize.Equals(other.PageSize)
            ) &&
            (
                PageNumber == other.PageNumber ||
                PageNumber != null &&
                PageNumber.Equals(other.PageNumber)
            ) &&
            (
                Filters == other.Filters ||
                Filters != null &&
                Filters.SequenceEqual(other.Filters)
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
            if (QueryPhrase != null)
            {
                hash = hash * 59 + QueryPhrase.GetHashCode();
            }

            if (PageSize != null)
            {
                hash = hash * 59 + PageSize.GetHashCode();
            }

            if (PageNumber != null)
            {
                hash = hash * 59 + PageNumber.GetHashCode();
            }

            if (Filters != null)
            {
                hash = hash * 59 + Filters.GetHashCode();
            }

            return hash;
        }
    }
}
