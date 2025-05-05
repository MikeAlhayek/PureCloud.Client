using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// KnowledgeDocumentGuestSearchRequest
/// </summary>

public partial class KnowledgeDocumentGuestSearchRequest : IEquatable<KnowledgeDocumentGuestSearchRequest>
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
    /// Initializes a new instance of the <see cref="KnowledgeDocumentGuestSearchRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected KnowledgeDocumentGuestSearchRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="KnowledgeDocumentGuestSearchRequest" /> class.
    /// </summary>
    /// <param name="Query">Query to search content in the knowledge base. Maximum of 30 records per query can be fetched. (required).</param>
    /// <param name="PageSize">Page size of the returned results..</param>
    /// <param name="PageNumber">Page number of the returned results..</param>
    /// <param name="QueryType">The type of the query that initiates the search..</param>
    /// <param name="AnswerHighlightTopResults">The number of articles to be sent for answer-highlighting. Can range from 1-5..</param>
    /// <param name="IncludeDraftDocuments">Indicates whether the search results would also include draft documents..</param>
    public KnowledgeDocumentGuestSearchRequest(string Query = null, int? PageSize = null, int? PageNumber = null, QueryTypeEnum? QueryType = null, int? AnswerHighlightTopResults = null, bool? IncludeDraftDocuments = null)
    {
        this.Query = Query;
        this.PageSize = PageSize;
        this.PageNumber = PageNumber;
        this.QueryType = QueryType;
        this.AnswerHighlightTopResults = AnswerHighlightTopResults;
        this.IncludeDraftDocuments = IncludeDraftDocuments;

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
    public string SearchId { get; private set; }



    /// <summary>
    /// The total number of documents matching the query.
    /// </summary>
    /// <value>The total number of documents matching the query.</value>
    [JsonPropertyName("total")]
    public int? Total { get; private set; }



    /// <summary>
    /// Number of pages returned in the result calculated according to the pageSize and the total
    /// </summary>
    /// <value>Number of pages returned in the result calculated according to the pageSize and the total</value>
    [JsonPropertyName("pageCount")]
    public int? PageCount { get; private set; }





    /// <summary>
    /// Session ID of the search.
    /// </summary>
    /// <value>Session ID of the search.</value>
    [JsonPropertyName("sessionId")]
    public string SessionId { get; private set; }



    /// <summary>
    /// The number of articles to be sent for answer-highlighting. Can range from 1-5.
    /// </summary>
    /// <value>The number of articles to be sent for answer-highlighting. Can range from 1-5.</value>
    [JsonPropertyName("answerHighlightTopResults")]
    public int? AnswerHighlightTopResults { get; set; }



    /// <summary>
    /// Indicates whether the search results would also include draft documents.
    /// </summary>
    /// <value>Indicates whether the search results would also include draft documents.</value>
    [JsonPropertyName("includeDraftDocuments")]
    public bool? IncludeDraftDocuments { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class KnowledgeDocumentGuestSearchRequest {\n");

        sb.Append("  Query: ").Append(Query).Append("\n");
        sb.Append("  PageSize: ").Append(PageSize).Append("\n");
        sb.Append("  PageNumber: ").Append(PageNumber).Append("\n");
        sb.Append("  SearchId: ").Append(SearchId).Append("\n");
        sb.Append("  Total: ").Append(Total).Append("\n");
        sb.Append("  PageCount: ").Append(PageCount).Append("\n");
        sb.Append("  QueryType: ").Append(QueryType).Append("\n");
        sb.Append("  SessionId: ").Append(SessionId).Append("\n");
        sb.Append("  AnswerHighlightTopResults: ").Append(AnswerHighlightTopResults).Append("\n");
        sb.Append("  IncludeDraftDocuments: ").Append(IncludeDraftDocuments).Append("\n");
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
        return Equals(obj as KnowledgeDocumentGuestSearchRequest);
    }

    /// <summary>
    /// Returns true if KnowledgeDocumentGuestSearchRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of KnowledgeDocumentGuestSearchRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(KnowledgeDocumentGuestSearchRequest other)
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
                AnswerHighlightTopResults == other.AnswerHighlightTopResults ||
                AnswerHighlightTopResults != null &&
                AnswerHighlightTopResults.Equals(other.AnswerHighlightTopResults)
            ) &&
            (
                IncludeDraftDocuments == other.IncludeDraftDocuments ||
                IncludeDraftDocuments != null &&
                IncludeDraftDocuments.Equals(other.IncludeDraftDocuments)
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

            if (AnswerHighlightTopResults != null)
            {
                hash = hash * 59 + AnswerHighlightTopResults.GetHashCode();
            }

            if (IncludeDraftDocuments != null)
            {
                hash = hash * 59 + IncludeDraftDocuments.GetHashCode();
            }

            return hash;
        }
    }
}
