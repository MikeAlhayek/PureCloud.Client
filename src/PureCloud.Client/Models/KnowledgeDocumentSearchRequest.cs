using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// KnowledgeDocumentSearchRequest
/// </summary>

public partial class KnowledgeDocumentSearchRequest : IEquatable<KnowledgeDocumentSearchRequest>
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
    /// The sort order for search results.
    /// </summary>
    /// <value>The sort order for search results.</value>
    
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
        /// Enum Asc for "Asc"
        /// </summary>
        [EnumMember(Value = "Asc")]
        Asc,

        /// <summary>
        /// Enum Desc for "Desc"
        /// </summary>
        [EnumMember(Value = "Desc")]
        Desc
    }
    /// <summary>
    /// The field in the documents that you want to sort the search results by.
    /// </summary>
    /// <value>The field in the documents that you want to sort the search results by.</value>
    
    public enum SortByEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Confidencescore for "ConfidenceScore"
        /// </summary>
        [EnumMember(Value = "ConfidenceScore")]
        Confidencescore,

        /// <summary>
        /// Enum Datecreated for "DateCreated"
        /// </summary>
        [EnumMember(Value = "DateCreated")]
        Datecreated,

        /// <summary>
        /// Enum Datemodified for "DateModified"
        /// </summary>
        [EnumMember(Value = "DateModified")]
        Datemodified,

        /// <summary>
        /// Enum Categoryname for "CategoryName"
        /// </summary>
        [EnumMember(Value = "CategoryName")]
        Categoryname,

        /// <summary>
        /// Enum Labelname for "LabelName"
        /// </summary>
        [EnumMember(Value = "LabelName")]
        Labelname
    }
    /// <summary>
    /// Gets or Sets AnswerMode
    /// </summary>
    
    public enum AnswerModeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Answerhighlight for "AnswerHighlight"
        /// </summary>
        [EnumMember(Value = "AnswerHighlight")]
        Answerhighlight,

        /// <summary>
        /// Enum Answergeneration for "AnswerGeneration"
        /// </summary>
        [EnumMember(Value = "AnswerGeneration")]
        Answergeneration
    }
    /// <summary>
    /// The type of the query that initiates the search.
    /// </summary>
    /// <value>The type of the query that initiates the search.</value>
    [JsonPropertyName("queryType")]
    public QueryTypeEnum? QueryType { get; set; }
    /// <summary>
    /// The sort order for search results.
    /// </summary>
    /// <value>The sort order for search results.</value>
    [JsonPropertyName("sortOrder")]
    public SortOrderEnum? SortOrder { get; set; }
    /// <summary>
    /// The field in the documents that you want to sort the search results by.
    /// </summary>
    /// <value>The field in the documents that you want to sort the search results by.</value>
    [JsonPropertyName("sortBy")]
    public SortByEnum? SortBy { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="KnowledgeDocumentSearchRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected KnowledgeDocumentSearchRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="KnowledgeDocumentSearchRequest" /> class.
    /// </summary>
    /// <param name="Query">Query to search content in the knowledge base. Maximum of 30 records per query can be fetched. (required).</param>
    /// <param name="PageSize">Page size of the returned results..</param>
    /// <param name="PageNumber">Page number of the returned results..</param>
    /// <param name="QueryType">The type of the query that initiates the search..</param>
    /// <param name="IncludeDraftDocuments">Indicates whether the search results would also include draft documents..</param>
    /// <param name="Interval">Retrieves the documents created/modified/published in specified date and time range..</param>
    /// <param name="Filter">Filter for the document search..</param>
    /// <param name="SortOrder">The sort order for search results..</param>
    /// <param name="SortBy">The field in the documents that you want to sort the search results by..</param>
    /// <param name="Application">The client application details from which search request was sent..</param>
    /// <param name="ConversationContext">Conversation context information if the search is initiated in the context of a conversation..</param>
    /// <param name="ConfidenceThreshold">The confidence threshold for the search results. If applied, the returned results will have an equal or higher confidence than the threshold. The value should be between 0 to 1..</param>
    /// <param name="AnswerHighlightTopResults">The number of articles to be sent for answer-highlighting. Can range from 1-5..</param>
    /// <param name="AnswerMode">Allows extracted answers from an article (AnswerHighlight) and/or AI-generated answers (AnswerGeneration). Default mode: AnswerHighlight. Use this property with answerHighlightTopResults..</param>
    public KnowledgeDocumentSearchRequest(string Query = null, int? PageSize = null, int? PageNumber = null, QueryTypeEnum? QueryType = null, bool? IncludeDraftDocuments = null, DocumentQueryInterval Interval = null, DocumentQuery Filter = null, SortOrderEnum? SortOrder = null, SortByEnum? SortBy = null, KnowledgeSearchClientApplication Application = null, KnowledgeConversationContext ConversationContext = null, float? ConfidenceThreshold = null, int? AnswerHighlightTopResults = null, List<AnswerModeEnum> AnswerMode = null)
    {
        this.Query = Query;
        this.PageSize = PageSize;
        this.PageNumber = PageNumber;
        this.QueryType = QueryType;
        this.IncludeDraftDocuments = IncludeDraftDocuments;
        this.Interval = Interval;
        this.Filter = Filter;
        this.SortOrder = SortOrder;
        this.SortBy = SortBy;
        this.Application = Application;
        this.ConversationContext = ConversationContext;
        this.ConfidenceThreshold = ConfidenceThreshold;
        this.AnswerHighlightTopResults = AnswerHighlightTopResults;
        this.AnswerMode = AnswerMode;

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
    /// Indicates whether the search results would also include draft documents.
    /// </summary>
    /// <value>Indicates whether the search results would also include draft documents.</value>
    [JsonPropertyName("includeDraftDocuments")]
    public bool? IncludeDraftDocuments { get; set; }



    /// <summary>
    /// Retrieves the documents created/modified/published in specified date and time range.
    /// </summary>
    /// <value>Retrieves the documents created/modified/published in specified date and time range.</value>
    [JsonPropertyName("interval")]
    public DocumentQueryInterval Interval { get; set; }



    /// <summary>
    /// Filter for the document search.
    /// </summary>
    /// <value>Filter for the document search.</value>
    [JsonPropertyName("filter")]
    public DocumentQuery Filter { get; set; }







    /// <summary>
    /// The client application details from which search request was sent.
    /// </summary>
    /// <value>The client application details from which search request was sent.</value>
    [JsonPropertyName("application")]
    public KnowledgeSearchClientApplication Application { get; set; }



    /// <summary>
    /// Conversation context information if the search is initiated in the context of a conversation.
    /// </summary>
    /// <value>Conversation context information if the search is initiated in the context of a conversation.</value>
    [JsonPropertyName("conversationContext")]
    public KnowledgeConversationContext ConversationContext { get; set; }



    /// <summary>
    /// The confidence threshold for the search results. If applied, the returned results will have an equal or higher confidence than the threshold. The value should be between 0 to 1.
    /// </summary>
    /// <value>The confidence threshold for the search results. If applied, the returned results will have an equal or higher confidence than the threshold. The value should be between 0 to 1.</value>
    [JsonPropertyName("confidenceThreshold")]
    public float? ConfidenceThreshold { get; set; }



    /// <summary>
    /// The number of articles to be sent for answer-highlighting. Can range from 1-5.
    /// </summary>
    /// <value>The number of articles to be sent for answer-highlighting. Can range from 1-5.</value>
    [JsonPropertyName("answerHighlightTopResults")]
    public int? AnswerHighlightTopResults { get; set; }



    /// <summary>
    /// Allows extracted answers from an article (AnswerHighlight) and/or AI-generated answers (AnswerGeneration). Default mode: AnswerHighlight. Use this property with answerHighlightTopResults.
    /// </summary>
    /// <value>Allows extracted answers from an article (AnswerHighlight) and/or AI-generated answers (AnswerGeneration). Default mode: AnswerHighlight. Use this property with answerHighlightTopResults.</value>
    [JsonPropertyName("answerMode")]
    public List<AnswerModeEnum> AnswerMode { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class KnowledgeDocumentSearchRequest {\n");

        sb.Append("  Query: ").Append(Query).Append("\n");
        sb.Append("  PageSize: ").Append(PageSize).Append("\n");
        sb.Append("  PageNumber: ").Append(PageNumber).Append("\n");
        sb.Append("  SearchId: ").Append(SearchId).Append("\n");
        sb.Append("  Total: ").Append(Total).Append("\n");
        sb.Append("  PageCount: ").Append(PageCount).Append("\n");
        sb.Append("  QueryType: ").Append(QueryType).Append("\n");
        sb.Append("  IncludeDraftDocuments: ").Append(IncludeDraftDocuments).Append("\n");
        sb.Append("  Interval: ").Append(Interval).Append("\n");
        sb.Append("  Filter: ").Append(Filter).Append("\n");
        sb.Append("  SortOrder: ").Append(SortOrder).Append("\n");
        sb.Append("  SortBy: ").Append(SortBy).Append("\n");
        sb.Append("  Application: ").Append(Application).Append("\n");
        sb.Append("  ConversationContext: ").Append(ConversationContext).Append("\n");
        sb.Append("  ConfidenceThreshold: ").Append(ConfidenceThreshold).Append("\n");
        sb.Append("  AnswerHighlightTopResults: ").Append(AnswerHighlightTopResults).Append("\n");
        sb.Append("  AnswerMode: ").Append(AnswerMode).Append("\n");
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
        return Equals(obj as KnowledgeDocumentSearchRequest);
    }

    /// <summary>
    /// Returns true if KnowledgeDocumentSearchRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of KnowledgeDocumentSearchRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(KnowledgeDocumentSearchRequest other)
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
                IncludeDraftDocuments == other.IncludeDraftDocuments ||
                IncludeDraftDocuments != null &&
                IncludeDraftDocuments.Equals(other.IncludeDraftDocuments)
            ) &&
            (
                Interval == other.Interval ||
                Interval != null &&
                Interval.Equals(other.Interval)
            ) &&
            (
                Filter == other.Filter ||
                Filter != null &&
                Filter.Equals(other.Filter)
            ) &&
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
                Application == other.Application ||
                Application != null &&
                Application.Equals(other.Application)
            ) &&
            (
                ConversationContext == other.ConversationContext ||
                ConversationContext != null &&
                ConversationContext.Equals(other.ConversationContext)
            ) &&
            (
                ConfidenceThreshold == other.ConfidenceThreshold ||
                ConfidenceThreshold != null &&
                ConfidenceThreshold.Equals(other.ConfidenceThreshold)
            ) &&
            (
                AnswerHighlightTopResults == other.AnswerHighlightTopResults ||
                AnswerHighlightTopResults != null &&
                AnswerHighlightTopResults.Equals(other.AnswerHighlightTopResults)
            ) &&
            (
                AnswerMode == other.AnswerMode ||
                AnswerMode != null &&
                AnswerMode.SequenceEqual(other.AnswerMode)
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

            if (IncludeDraftDocuments != null)
            {
                hash = hash * 59 + IncludeDraftDocuments.GetHashCode();
            }

            if (Interval != null)
            {
                hash = hash * 59 + Interval.GetHashCode();
            }

            if (Filter != null)
            {
                hash = hash * 59 + Filter.GetHashCode();
            }

            if (SortOrder != null)
            {
                hash = hash * 59 + SortOrder.GetHashCode();
            }

            if (SortBy != null)
            {
                hash = hash * 59 + SortBy.GetHashCode();
            }

            if (Application != null)
            {
                hash = hash * 59 + Application.GetHashCode();
            }

            if (ConversationContext != null)
            {
                hash = hash * 59 + ConversationContext.GetHashCode();
            }

            if (ConfidenceThreshold != null)
            {
                hash = hash * 59 + ConfidenceThreshold.GetHashCode();
            }

            if (AnswerHighlightTopResults != null)
            {
                hash = hash * 59 + AnswerHighlightTopResults.GetHashCode();
            }

            if (AnswerMode != null)
            {
                hash = hash * 59 + AnswerMode.GetHashCode();
            }

            return hash;
        }
    }
}
