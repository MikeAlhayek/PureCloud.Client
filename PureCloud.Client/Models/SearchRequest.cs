using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// SearchRequest
/// </summary>

public partial class SearchRequest : IEquatable<SearchRequest>
{
    /// <summary>
    /// The sort order for results
    /// </summary>
    /// <value>The sort order for results</value>
    
    public enum SortOrderEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Asc for "ASC"
        /// </summary>
        [EnumMember(Value = "ASC")]
        Asc,

        /// <summary>
        /// Enum Desc for "DESC"
        /// </summary>
        [EnumMember(Value = "DESC")]
        Desc,

        /// <summary>
        /// Enum Score for "SCORE"
        /// </summary>
        [EnumMember(Value = "SCORE")]
        Score
    }
    /// <summary>
    /// The sort order for results
    /// </summary>
    /// <value>The sort order for results</value>
    [JsonPropertyName("sortOrder")]
    public SortOrderEnum? SortOrder { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="SearchRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected SearchRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="SearchRequest" /> class.
    /// </summary>
    /// <param name="SortOrder">The sort order for results.</param>
    /// <param name="SortBy">The field in the resource that you want to sort the results by.</param>
    /// <param name="PageSize">The number of results per page.</param>
    /// <param name="PageNumber">The page of resources you want to retrieve.</param>
    /// <param name="Sort">Multi-value sort order, list of multiple sort values.</param>
    /// <param name="ReturnFields">A List of strings.  Possible values are any field in the resource you are searching on.  The other option is to use ALL_FIELDS, when this is provided all fields in the resource will be returned in the search results..</param>
    /// <param name="Expand">Provides more details about a specified resource.</param>
    /// <param name="Types">Resource domain type to search (required).</param>
    /// <param name="Query">The search criteria.</param>
    /// <param name="Aggregations">Aggregation criteria.</param>
    public SearchRequest(SortOrderEnum? SortOrder = null, string SortBy = null, int? PageSize = null, int? PageNumber = null, List<SearchSort> Sort = null, List<string> ReturnFields = null, List<string> Expand = null, List<string> Types = null, List<SearchCriteria> Query = null, List<SearchAggregation> Aggregations = null)
    {
        this.SortOrder = SortOrder;
        this.SortBy = SortBy;
        this.PageSize = PageSize;
        this.PageNumber = PageNumber;
        this.Sort = Sort;
        this.ReturnFields = ReturnFields;
        this.Expand = Expand;
        this.Types = Types;
        this.Query = Query;
        this.Aggregations = Aggregations;

    }





    /// <summary>
    /// The field in the resource that you want to sort the results by
    /// </summary>
    /// <value>The field in the resource that you want to sort the results by</value>
    [JsonPropertyName("sortBy")]
    public string SortBy { get; set; }



    /// <summary>
    /// The number of results per page
    /// </summary>
    /// <value>The number of results per page</value>
    [JsonPropertyName("pageSize")]
    public int? PageSize { get; set; }



    /// <summary>
    /// The page of resources you want to retrieve
    /// </summary>
    /// <value>The page of resources you want to retrieve</value>
    [JsonPropertyName("pageNumber")]
    public int? PageNumber { get; set; }



    /// <summary>
    /// Multi-value sort order, list of multiple sort values
    /// </summary>
    /// <value>Multi-value sort order, list of multiple sort values</value>
    [JsonPropertyName("sort")]
    public List<SearchSort> Sort { get; set; }



    /// <summary>
    /// A List of strings.  Possible values are any field in the resource you are searching on.  The other option is to use ALL_FIELDS, when this is provided all fields in the resource will be returned in the search results.
    /// </summary>
    /// <value>A List of strings.  Possible values are any field in the resource you are searching on.  The other option is to use ALL_FIELDS, when this is provided all fields in the resource will be returned in the search results.</value>
    [JsonPropertyName("returnFields")]
    public List<string> ReturnFields { get; set; }



    /// <summary>
    /// Provides more details about a specified resource
    /// </summary>
    /// <value>Provides more details about a specified resource</value>
    [JsonPropertyName("expand")]
    public List<string> Expand { get; set; }



    /// <summary>
    /// Resource domain type to search
    /// </summary>
    /// <value>Resource domain type to search</value>
    [JsonPropertyName("types")]
    public List<string> Types { get; set; }



    /// <summary>
    /// The search criteria
    /// </summary>
    /// <value>The search criteria</value>
    [JsonPropertyName("query")]
    public List<SearchCriteria> Query { get; set; }



    /// <summary>
    /// Aggregation criteria
    /// </summary>
    /// <value>Aggregation criteria</value>
    [JsonPropertyName("aggregations")]
    public List<SearchAggregation> Aggregations { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class SearchRequest {\n");

        sb.Append("  SortOrder: ").Append(SortOrder).Append("\n");
        sb.Append("  SortBy: ").Append(SortBy).Append("\n");
        sb.Append("  PageSize: ").Append(PageSize).Append("\n");
        sb.Append("  PageNumber: ").Append(PageNumber).Append("\n");
        sb.Append("  Sort: ").Append(Sort).Append("\n");
        sb.Append("  ReturnFields: ").Append(ReturnFields).Append("\n");
        sb.Append("  Expand: ").Append(Expand).Append("\n");
        sb.Append("  Types: ").Append(Types).Append("\n");
        sb.Append("  Query: ").Append(Query).Append("\n");
        sb.Append("  Aggregations: ").Append(Aggregations).Append("\n");
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
        return Equals(obj as SearchRequest);
    }

    /// <summary>
    /// Returns true if SearchRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of SearchRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(SearchRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                SortOrder == other.SortOrder ||
                SortOrder != null &&
                SortOrder.Equals(other.SortOrder)
            ) &&
            (
                SortBy == other.SortBy ||
                SortBy != null &&
                SortBy.Equals(other.SortBy)
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
                Sort == other.Sort ||
                Sort != null &&
                Sort.SequenceEqual(other.Sort)
            ) &&
            (
                ReturnFields == other.ReturnFields ||
                ReturnFields != null &&
                ReturnFields.SequenceEqual(other.ReturnFields)
            ) &&
            (
                Expand == other.Expand ||
                Expand != null &&
                Expand.SequenceEqual(other.Expand)
            ) &&
            (
                Types == other.Types ||
                Types != null &&
                Types.SequenceEqual(other.Types)
            ) &&
            (
                Query == other.Query ||
                Query != null &&
                Query.SequenceEqual(other.Query)
            ) &&
            (
                Aggregations == other.Aggregations ||
                Aggregations != null &&
                Aggregations.SequenceEqual(other.Aggregations)
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
            if (SortOrder != null)
            {
                hash = hash * 59 + SortOrder.GetHashCode();
            }

            if (SortBy != null)
            {
                hash = hash * 59 + SortBy.GetHashCode();
            }

            if (PageSize != null)
            {
                hash = hash * 59 + PageSize.GetHashCode();
            }

            if (PageNumber != null)
            {
                hash = hash * 59 + PageNumber.GetHashCode();
            }

            if (Sort != null)
            {
                hash = hash * 59 + Sort.GetHashCode();
            }

            if (ReturnFields != null)
            {
                hash = hash * 59 + ReturnFields.GetHashCode();
            }

            if (Expand != null)
            {
                hash = hash * 59 + Expand.GetHashCode();
            }

            if (Types != null)
            {
                hash = hash * 59 + Types.GetHashCode();
            }

            if (Query != null)
            {
                hash = hash * 59 + Query.GetHashCode();
            }

            if (Aggregations != null)
            {
                hash = hash * 59 + Aggregations.GetHashCode();
            }

            return hash;
        }
    }
}
