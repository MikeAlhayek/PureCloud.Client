using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// KnowledgeDocumentCopy
/// </summary>

public partial class KnowledgeDocumentCopy : IEquatable<KnowledgeDocumentCopy>
{
    /// <summary>
    /// The type of the query that surfaced the document.
    /// </summary>
    /// <value>The type of the query that surfaced the document.</value>
    
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
        /// Enum Unknown for "Unknown"
        /// </summary>
        [EnumMember(Value = "Unknown")]
        Unknown,

        /// <summary>
        /// Enum Article for "Article"
        /// </summary>
        [EnumMember(Value = "Article")]
        Article,

        /// <summary>
        /// Enum Autosearch for "AutoSearch"
        /// </summary>
        [EnumMember(Value = "AutoSearch")]
        Autosearch,

        /// <summary>
        /// Enum Category for "Category"
        /// </summary>
        [EnumMember(Value = "Category")]
        Category,

        /// <summary>
        /// Enum Manualsearch for "ManualSearch"
        /// </summary>
        [EnumMember(Value = "ManualSearch")]
        Manualsearch,

        /// <summary>
        /// Enum Recommendation for "Recommendation"
        /// </summary>
        [EnumMember(Value = "Recommendation")]
        Recommendation,

        /// <summary>
        /// Enum Suggestion for "Suggestion"
        /// </summary>
        [EnumMember(Value = "Suggestion")]
        Suggestion
    }
    /// <summary>
    /// The method how knowledge was surfaced. Article: Full article was shown. Snippet: A snippet from the article was shown. Highlight: A highlighted answer in a snippet was shown.
    /// </summary>
    /// <value>The method how knowledge was surfaced. Article: Full article was shown. Snippet: A snippet from the article was shown. Highlight: A highlighted answer in a snippet was shown.</value>
    
    public enum SurfacingMethodEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Unknown for "Unknown"
        /// </summary>
        [EnumMember(Value = "Unknown")]
        Unknown,

        /// <summary>
        /// Enum Article for "Article"
        /// </summary>
        [EnumMember(Value = "Article")]
        Article,

        /// <summary>
        /// Enum Snippet for "Snippet"
        /// </summary>
        [EnumMember(Value = "Snippet")]
        Snippet,

        /// <summary>
        /// Enum Highlight for "Highlight"
        /// </summary>
        [EnumMember(Value = "Highlight")]
        Highlight
    }
    /// <summary>
    /// The type of the query that surfaced the document.
    /// </summary>
    /// <value>The type of the query that surfaced the document.</value>
    [JsonPropertyName("queryType")]
    public QueryTypeEnum? QueryType { get; set; }
    /// <summary>
    /// The method how knowledge was surfaced. Article: Full article was shown. Snippet: A snippet from the article was shown. Highlight: A highlighted answer in a snippet was shown.
    /// </summary>
    /// <value>The method how knowledge was surfaced. Article: Full article was shown. Snippet: A snippet from the article was shown. Highlight: A highlighted answer in a snippet was shown.</value>
    [JsonPropertyName("surfacingMethod")]
    public SurfacingMethodEnum? SurfacingMethod { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="KnowledgeDocumentCopy" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected KnowledgeDocumentCopy() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="KnowledgeDocumentCopy" /> class.
    /// </summary>
    /// <param name="DocumentVariationId">The variation of the document whose content was copied. (required).</param>
    /// <param name="DocumentVersionId">The version of the document whose content was copied. (required).</param>
    /// <param name="SearchId">The search that surfaced the document whose content was copied..</param>
    /// <param name="QueryType">The type of the query that surfaced the document..</param>
    /// <param name="SurfacingMethod">The method how knowledge was surfaced. Article: Full article was shown. Snippet: A snippet from the article was shown. Highlight: A highlighted answer in a snippet was shown..</param>
    /// <param name="ConversationContext">Conversation context information, if the document content is copied in the context of a conversation..</param>
    /// <param name="Application">The client application in which the document content was copied. (required).</param>
    public KnowledgeDocumentCopy(string DocumentVariationId = null, string DocumentVersionId = null, string SearchId = null, QueryTypeEnum? QueryType = null, SurfacingMethodEnum? SurfacingMethod = null, KnowledgeConversationContext ConversationContext = null, KnowledgeSearchClientApplication Application = null)
    {
        this.DocumentVariationId = DocumentVariationId;
        this.DocumentVersionId = DocumentVersionId;
        this.SearchId = SearchId;
        this.QueryType = QueryType;
        this.SurfacingMethod = SurfacingMethod;
        this.ConversationContext = ConversationContext;
        this.Application = Application;

    }



    /// <summary>
    /// The variation of the document whose content was copied.
    /// </summary>
    /// <value>The variation of the document whose content was copied.</value>
    [JsonPropertyName("documentVariationId")]
    public string DocumentVariationId { get; set; }



    /// <summary>
    /// The version of the document whose content was copied.
    /// </summary>
    /// <value>The version of the document whose content was copied.</value>
    [JsonPropertyName("documentVersionId")]
    public string DocumentVersionId { get; set; }



    /// <summary>
    /// The search that surfaced the document whose content was copied.
    /// </summary>
    /// <value>The search that surfaced the document whose content was copied.</value>
    [JsonPropertyName("searchId")]
    public string SearchId { get; set; }







    /// <summary>
    /// Knowledge session ID.
    /// </summary>
    /// <value>Knowledge session ID.</value>
    [JsonPropertyName("sessionId")]
    public string SessionId { get; private set; }



    /// <summary>
    /// Conversation context information, if the document content is copied in the context of a conversation.
    /// </summary>
    /// <value>Conversation context information, if the document content is copied in the context of a conversation.</value>
    [JsonPropertyName("conversationContext")]
    public KnowledgeConversationContext ConversationContext { get; set; }



    /// <summary>
    /// The client application in which the document content was copied.
    /// </summary>
    /// <value>The client application in which the document content was copied.</value>
    [JsonPropertyName("application")]
    public KnowledgeSearchClientApplication Application { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class KnowledgeDocumentCopy {\n");

        sb.Append("  DocumentVariationId: ").Append(DocumentVariationId).Append("\n");
        sb.Append("  DocumentVersionId: ").Append(DocumentVersionId).Append("\n");
        sb.Append("  SearchId: ").Append(SearchId).Append("\n");
        sb.Append("  QueryType: ").Append(QueryType).Append("\n");
        sb.Append("  SurfacingMethod: ").Append(SurfacingMethod).Append("\n");
        sb.Append("  SessionId: ").Append(SessionId).Append("\n");
        sb.Append("  ConversationContext: ").Append(ConversationContext).Append("\n");
        sb.Append("  Application: ").Append(Application).Append("\n");
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
        return Equals(obj as KnowledgeDocumentCopy);
    }

    /// <summary>
    /// Returns true if KnowledgeDocumentCopy instances are equal
    /// </summary>
    /// <param name="other">Instance of KnowledgeDocumentCopy to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(KnowledgeDocumentCopy other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                DocumentVariationId == other.DocumentVariationId ||
                DocumentVariationId != null &&
                DocumentVariationId.Equals(other.DocumentVariationId)
            ) &&
            (
                DocumentVersionId == other.DocumentVersionId ||
                DocumentVersionId != null &&
                DocumentVersionId.Equals(other.DocumentVersionId)
            ) &&
            (
                SearchId == other.SearchId ||
                SearchId != null &&
                SearchId.Equals(other.SearchId)
            ) &&
            (
                QueryType == other.QueryType ||
                QueryType != null &&
                QueryType.Equals(other.QueryType)
            ) &&
            (
                SurfacingMethod == other.SurfacingMethod ||
                SurfacingMethod != null &&
                SurfacingMethod.Equals(other.SurfacingMethod)
            ) &&
            (
                SessionId == other.SessionId ||
                SessionId != null &&
                SessionId.Equals(other.SessionId)
            ) &&
            (
                ConversationContext == other.ConversationContext ||
                ConversationContext != null &&
                ConversationContext.Equals(other.ConversationContext)
            ) &&
            (
                Application == other.Application ||
                Application != null &&
                Application.Equals(other.Application)
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
            if (DocumentVariationId != null)
            {
                hash = hash * 59 + DocumentVariationId.GetHashCode();
            }

            if (DocumentVersionId != null)
            {
                hash = hash * 59 + DocumentVersionId.GetHashCode();
            }

            if (SearchId != null)
            {
                hash = hash * 59 + SearchId.GetHashCode();
            }

            if (QueryType != null)
            {
                hash = hash * 59 + QueryType.GetHashCode();
            }

            if (SurfacingMethod != null)
            {
                hash = hash * 59 + SurfacingMethod.GetHashCode();
            }

            if (SessionId != null)
            {
                hash = hash * 59 + SessionId.GetHashCode();
            }

            if (ConversationContext != null)
            {
                hash = hash * 59 + ConversationContext.GetHashCode();
            }

            if (Application != null)
            {
                hash = hash * 59 + Application.GetHashCode();
            }

            return hash;
        }
    }
}
