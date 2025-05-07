using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// KnowledgeDocumentGuestSearch
/// </summary>

public partial class KnowledgeDocumentGuestSearch : IEquatable<KnowledgeDocumentGuestSearch>
{
    /// <summary>
    /// The type of the query that initiates the search.
    /// </summary>
    /// <value>The type of the query that initiates the search.</value>
    
    public enum QueryTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Autosearch for "AutoSearch"
        /// </summary>
        [EnumMember(Value = "AutoSearch")]
        Autosearch,

        /// <summary>
        /// Enum Manualsearch for "ManualSearch"
        /// </summary>
        [EnumMember(Value = "ManualSearch")]
        Manualsearch,

        /// <summary>
        /// Enum Suggestion for "Suggestion"
        /// </summary>
        [EnumMember(Value = "Suggestion")]
        Suggestion
    }
    /// <summary>
    /// The type of the query that initiates the search.
    /// </summary>
    /// <value>The type of the query that initiates the search.</value>
    [JsonPropertyName("queryType")]
    public QueryTypeEnum? QueryType { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="KnowledgeDocumentGuestSearch" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected KnowledgeDocumentGuestSearch() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="KnowledgeDocumentGuestSearch" /> class.
    /// </summary>
    /// <param name="Query">Query to search content in the knowledge base. Maximum of 30 records per query can be fetched. (required).</param>
    /// <param name="PageSize">Page size of the returned results..</param>
    /// <param name="PageNumber">Page number of the returned results..</param>
    /// <param name="QueryType">The type of the query that initiates the search..</param>
    public KnowledgeDocumentGuestSearch(string Query = null, int? PageSize = null, int? PageNumber = null, QueryTypeEnum? QueryType = null)
    {
        this.Query = Query;
        this.PageSize = PageSize;
        this.PageNumber = PageNumber;
        this.QueryType = QueryType;

    }



    /// <summary>
    /// Query to search content in the knowledge base. Maximum of 30 records per query can be fetched.
    /// </summary>
    /// <value>Query to search content in the knowledge base. Maximum of 30 records per query can be fetched.</value>
    [JsonPropertyName("query")]
    public string Query { get; set; }



    /// <summary>
    /// Page size of the returned results.
    /// </summary>
    /// <value>Page size of the returned results.</value>
    [JsonPropertyName("pageSize")]
    public int? PageSize { get; set; }



    /// <summary>
    /// Page number of the returned results.
    /// </summary>
    /// <value>Page number of the returned results.</value>
    [JsonPropertyName("pageNumber")]
    public int? PageNumber { get; set; }



    /// <summary>
    /// The globally unique identifier for the search.
    /// </summary>
    /// <value>The globally unique identifier for the search.</value>
    [JsonPropertyName("searchId")]
    public string SearchId { get; set; }



    /// <summary>
    /// The total number of documents matching the query.
    /// </summary>
    /// <value>The total number of documents matching the query.</value>
    [JsonPropertyName("total")]
    public int? Total { get; set; }



    /// <summary>
    /// Number of pages returned in the result calculated according to the pageSize and the total
    /// </summary>
    /// <value>Number of pages returned in the result calculated according to the pageSize and the total</value>
    [JsonPropertyName("pageCount")]
    public int? PageCount { get; set; }





    /// <summary>
    /// Session ID of the search.
    /// </summary>
    /// <value>Session ID of the search.</value>
    [JsonPropertyName("sessionId")]
    public string SessionId { get; set; }



    /// <summary>
    /// Documents that matched the search query.
    /// </summary>
    /// <value>Documents that matched the search query.</value>
    [JsonPropertyName("results")]
    public List<KnowledgeDocumentGuestSearchResult> Results { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class KnowledgeDocumentGuestSearch {\n");

        sb.Append("  Query: ").Append(Query).Append("\n");
        sb.Append("  PageSize: ").Append(PageSize).Append("\n");
        sb.Append("  PageNumber: ").Append(PageNumber).Append("\n");
        sb.Append("  SearchId: ").Append(SearchId).Append("\n");
        sb.Append("  Total: ").Append(Total).Append("\n");
        sb.Append("  PageCount: ").Append(PageCount).Append("\n");
        sb.Append("  QueryType: ").Append(QueryType).Append("\n");
        sb.Append("  SessionId: ").Append(SessionId).Append("\n");
        sb.Append("  Results: ").Append(Results).Append("\n");
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
        return Equals(obj as KnowledgeDocumentGuestSearch);
    }

    /// <summary>
    /// Returns true if KnowledgeDocumentGuestSearch instances are equal
    /// </summary>
    /// <param name="other">Instance of KnowledgeDocumentGuestSearch to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(KnowledgeDocumentGuestSearch other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Query == other.Query ||
                Query != null &&
                Query.Equals(other.Query)
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
                SearchId == other.SearchId ||
                SearchId != null &&
                SearchId.Equals(other.SearchId)
            ) &&
            (
                Total == other.Total ||
                Total != null &&
                Total.Equals(other.Total)
            ) &&
            (
                PageCount == other.PageCount ||
                PageCount != null &&
                PageCount.Equals(other.PageCount)
            ) &&
            (
                QueryType == other.QueryType ||
                QueryType != null &&
                QueryType.Equals(other.QueryType)
            ) &&
            (
                SessionId == other.SessionId ||
                SessionId != null &&
                SessionId.Equals(other.SessionId)
            ) &&
            (
                Results == other.Results ||
                Results != null &&
                Results.SequenceEqual(other.Results)
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
            if (Query != null)
            {
                hash = hash * 59 + Query.GetHashCode();
            }

            if (PageSize != null)
            {
                hash = hash * 59 + PageSize.GetHashCode();
            }

            if (PageNumber != null)
            {
                hash = hash * 59 + PageNumber.GetHashCode();
            }

            if (SearchId != null)
            {
                hash = hash * 59 + SearchId.GetHashCode();
            }

            if (Total != null)
            {
                hash = hash * 59 + Total.GetHashCode();
            }

            if (PageCount != null)
            {
                hash = hash * 59 + PageCount.GetHashCode();
            }

            if (QueryType != null)
            {
                hash = hash * 59 + QueryType.GetHashCode();
            }

            if (SessionId != null)
            {
                hash = hash * 59 + SessionId.GetHashCode();
            }

            if (Results != null)
            {
                hash = hash * 59 + Results.GetHashCode();
            }

            return hash;
        }
    }
}
