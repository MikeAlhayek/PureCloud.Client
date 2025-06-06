using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// QueryRequest
/// </summary>

public partial class QueryRequest : IEquatable<QueryRequest>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="QueryRequest" /> class.
    /// </summary>
    /// <param name="QueryPhrase">QueryPhrase.</param>
    /// <param name="PageNumber">PageNumber.</param>
    /// <param name="PageSize">PageSize.</param>
    /// <param name="FacetNameRequests">FacetNameRequests.</param>
    /// <param name="Sort">Sort.</param>
    /// <param name="Filters">Filters.</param>
    /// <param name="AttributeFilters">AttributeFilters.</param>
    /// <param name="IncludeShares">IncludeShares.</param>
    public QueryRequest(string QueryPhrase = null, int? PageNumber = null, int? PageSize = null, List<string> FacetNameRequests = null, List<SortItem> Sort = null, List<ContentFilterItem> Filters = null, List<AttributeFilterItem> AttributeFilters = null, bool? IncludeShares = null)
    {
        this.QueryPhrase = QueryPhrase;
        this.PageNumber = PageNumber;
        this.PageSize = PageSize;
        this.FacetNameRequests = FacetNameRequests;
        this.Sort = Sort;
        this.Filters = Filters;
        this.AttributeFilters = AttributeFilters;
        this.IncludeShares = IncludeShares;

    }



    /// <summary>
    /// Gets or Sets QueryPhrase
    /// </summary>
    [JsonPropertyName("queryPhrase")]
    public string QueryPhrase { get; set; }



    /// <summary>
    /// Gets or Sets PageNumber
    /// </summary>
    [JsonPropertyName("pageNumber")]
    public int? PageNumber { get; set; }



    /// <summary>
    /// Gets or Sets PageSize
    /// </summary>
    [JsonPropertyName("pageSize")]
    public int? PageSize { get; set; }



    /// <summary>
    /// Gets or Sets FacetNameRequests
    /// </summary>
    [JsonPropertyName("facetNameRequests")]
    public List<string> FacetNameRequests { get; set; }



    /// <summary>
    /// Gets or Sets Sort
    /// </summary>
    [JsonPropertyName("sort")]
    public List<SortItem> Sort { get; set; }



    /// <summary>
    /// Gets or Sets Filters
    /// </summary>
    [JsonPropertyName("filters")]
    public List<ContentFilterItem> Filters { get; set; }



    /// <summary>
    /// Gets or Sets AttributeFilters
    /// </summary>
    [JsonPropertyName("attributeFilters")]
    public List<AttributeFilterItem> AttributeFilters { get; set; }



    /// <summary>
    /// Gets or Sets IncludeShares
    /// </summary>
    [JsonPropertyName("includeShares")]
    public bool? IncludeShares { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class QueryRequest {\n");

        sb.Append("  QueryPhrase: ").Append(QueryPhrase).Append("\n");
        sb.Append("  PageNumber: ").Append(PageNumber).Append("\n");
        sb.Append("  PageSize: ").Append(PageSize).Append("\n");
        sb.Append("  FacetNameRequests: ").Append(FacetNameRequests).Append("\n");
        sb.Append("  Sort: ").Append(Sort).Append("\n");
        sb.Append("  Filters: ").Append(Filters).Append("\n");
        sb.Append("  AttributeFilters: ").Append(AttributeFilters).Append("\n");
        sb.Append("  IncludeShares: ").Append(IncludeShares).Append("\n");
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
        return Equals(obj as QueryRequest);
    }

    /// <summary>
    /// Returns true if QueryRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of QueryRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(QueryRequest other)
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
                PageNumber == other.PageNumber ||
                PageNumber != null &&
                PageNumber.Equals(other.PageNumber)
            ) &&
            (
                PageSize == other.PageSize ||
                PageSize != null &&
                PageSize.Equals(other.PageSize)
            ) &&
            (
                FacetNameRequests == other.FacetNameRequests ||
                FacetNameRequests != null &&
                FacetNameRequests.SequenceEqual(other.FacetNameRequests)
            ) &&
            (
                Sort == other.Sort ||
                Sort != null &&
                Sort.SequenceEqual(other.Sort)
            ) &&
            (
                Filters == other.Filters ||
                Filters != null &&
                Filters.SequenceEqual(other.Filters)
            ) &&
            (
                AttributeFilters == other.AttributeFilters ||
                AttributeFilters != null &&
                AttributeFilters.SequenceEqual(other.AttributeFilters)
            ) &&
            (
                IncludeShares == other.IncludeShares ||
                IncludeShares != null &&
                IncludeShares.Equals(other.IncludeShares)
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

            if (PageNumber != null)
            {
                hash = hash * 59 + PageNumber.GetHashCode();
            }

            if (PageSize != null)
            {
                hash = hash * 59 + PageSize.GetHashCode();
            }

            if (FacetNameRequests != null)
            {
                hash = hash * 59 + FacetNameRequests.GetHashCode();
            }

            if (Sort != null)
            {
                hash = hash * 59 + Sort.GetHashCode();
            }

            if (Filters != null)
            {
                hash = hash * 59 + Filters.GetHashCode();
            }

            if (AttributeFilters != null)
            {
                hash = hash * 59 + AttributeFilters.GetHashCode();
            }

            if (IncludeShares != null)
            {
                hash = hash * 59 + IncludeShares.GetHashCode();
            }

            return hash;
        }
    }
}
