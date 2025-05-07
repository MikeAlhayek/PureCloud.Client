using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// KnowledgeDocumentFeedbackResponse
/// </summary>

public partial class KnowledgeDocumentFeedbackResponse : IEquatable<KnowledgeDocumentFeedbackResponse>
{
    /// <summary>
    /// Feedback rating.
    /// </summary>
    /// <value>Feedback rating.</value>
    
    public enum RatingEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Negative for "Negative"
        /// </summary>
        [EnumMember(Value = "Negative")]
        Negative,

        /// <summary>
        /// Enum Positive for "Positive"
        /// </summary>
        [EnumMember(Value = "Positive")]
        Positive
    }
    /// <summary>
    /// Feedback reason.
    /// </summary>
    /// <value>Feedback reason.</value>
    
    public enum ReasonEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Documentcontent for "DocumentContent"
        /// </summary>
        [EnumMember(Value = "DocumentContent")]
        Documentcontent,

        /// <summary>
        /// Enum Searchresults for "SearchResults"
        /// </summary>
        [EnumMember(Value = "SearchResults")]
        Searchresults
    }
    /// <summary>
    /// The type of the query that surfaced the document on which the feedback was given.
    /// </summary>
    /// <value>The type of the query that surfaced the document on which the feedback was given.</value>
    
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
    /// The state of the feedback.
    /// </summary>
    /// <value>The state of the feedback.</value>
    
    public enum StateEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Draft for "Draft"
        /// </summary>
        [EnumMember(Value = "Draft")]
        Draft,

        /// <summary>
        /// Enum Final for "Final"
        /// </summary>
        [EnumMember(Value = "Final")]
        Final
    }
    /// <summary>
    /// Feedback rating.
    /// </summary>
    /// <value>Feedback rating.</value>
    [JsonPropertyName("rating")]
    public RatingEnum? Rating { get; set; }
    /// <summary>
    /// Feedback reason.
    /// </summary>
    /// <value>Feedback reason.</value>
    [JsonPropertyName("reason")]
    public ReasonEnum? Reason { get; set; }
    /// <summary>
    /// The type of the query that surfaced the document on which the feedback was given.
    /// </summary>
    /// <value>The type of the query that surfaced the document on which the feedback was given.</value>
    [JsonPropertyName("queryType")]
    public QueryTypeEnum? QueryType { get; set; }
    /// <summary>
    /// The method how knowledge was surfaced. Article: Full article was shown. Snippet: A snippet from the article was shown. Highlight: A highlighted answer in a snippet was shown.
    /// </summary>
    /// <value>The method how knowledge was surfaced. Article: Full article was shown. Snippet: A snippet from the article was shown. Highlight: A highlighted answer in a snippet was shown.</value>
    [JsonPropertyName("surfacingMethod")]
    public SurfacingMethodEnum? SurfacingMethod { get; set; }
    /// <summary>
    /// The state of the feedback.
    /// </summary>
    /// <value>The state of the feedback.</value>
    [JsonPropertyName("state")]
    public StateEnum? State { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="KnowledgeDocumentFeedbackResponse" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected KnowledgeDocumentFeedbackResponse() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="KnowledgeDocumentFeedbackResponse" /> class.
    /// </summary>
    /// <param name="DocumentVariation">The variation of the document on which feedback was given. (required).</param>
    /// <param name="Rating">Feedback rating. (required).</param>
    /// <param name="Reason">Feedback reason..</param>
    /// <param name="Comment">Free-text comment of the feedback. Maximum length: 2000 characters..</param>
    /// <param name="Search">The search that surfaced the document on which feedback was given..</param>
    /// <param name="QueryType">The type of the query that surfaced the document on which the feedback was given..</param>
    /// <param name="SurfacingMethod">The method how knowledge was surfaced. Article: Full article was shown. Snippet: A snippet from the article was shown. Highlight: A highlighted answer in a snippet was shown..</param>
    /// <param name="State">The state of the feedback..</param>
    /// <param name="Document">The document on which feedback was given..</param>
    /// <param name="Application">The client application from which feedback was given..</param>
    /// <param name="ConversationContext">Conversation context information if the feedback is given in the context of a conversation..</param>
    public KnowledgeDocumentFeedbackResponse(EntityReference DocumentVariation = null, RatingEnum? Rating = null, ReasonEnum? Reason = null, string Comment = null, EntityReference Search = null, QueryTypeEnum? QueryType = null, SurfacingMethodEnum? SurfacingMethod = null, StateEnum? State = null, KnowledgeDocumentVersionReference Document = null, KnowledgeSearchClientApplication Application = null, KnowledgeConversationContextResponse ConversationContext = null)
    {
        this.DocumentVariation = DocumentVariation;
        this.Rating = Rating;
        this.Reason = Reason;
        this.Comment = Comment;
        this.Search = Search;
        this.QueryType = QueryType;
        this.SurfacingMethod = SurfacingMethod;
        this.State = State;
        this.Document = Document;
        this.Application = Application;
        this.ConversationContext = ConversationContext;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// The variation of the document on which feedback was given.
    /// </summary>
    /// <value>The variation of the document on which feedback was given.</value>
    [JsonPropertyName("documentVariation")]
    public EntityReference DocumentVariation { get; set; }







    /// <summary>
    /// Free-text comment of the feedback. Maximum length: 2000 characters.
    /// </summary>
    /// <value>Free-text comment of the feedback. Maximum length: 2000 characters.</value>
    [JsonPropertyName("comment")]
    public string Comment { get; set; }



    /// <summary>
    /// The search that surfaced the document on which feedback was given.
    /// </summary>
    /// <value>The search that surfaced the document on which feedback was given.</value>
    [JsonPropertyName("search")]
    public EntityReference Search { get; set; }



    /// <summary>
    /// Knowledge guest session ID.
    /// </summary>
    /// <value>Knowledge guest session ID.</value>
    [JsonPropertyName("sessionId")]
    public string SessionId { get; set; }



    /// <summary>
    /// The date and time of the feedback. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date and time of the feedback. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateCreated")]
    public DateTime? DateCreated { get; set; }









    /// <summary>
    /// The document on which feedback was given.
    /// </summary>
    /// <value>The document on which feedback was given.</value>
    [JsonPropertyName("document")]
    public KnowledgeDocumentVersionReference Document { get; set; }



    /// <summary>
    /// The client application from which feedback was given.
    /// </summary>
    /// <value>The client application from which feedback was given.</value>
    [JsonPropertyName("application")]
    public KnowledgeSearchClientApplication Application { get; set; }



    /// <summary>
    /// Conversation context information if the feedback is given in the context of a conversation.
    /// </summary>
    /// <value>Conversation context information if the feedback is given in the context of a conversation.</value>
    [JsonPropertyName("conversationContext")]
    public KnowledgeConversationContextResponse ConversationContext { get; set; }



    /// <summary>
    /// The user who created the feedback.
    /// </summary>
    /// <value>The user who created the feedback.</value>
    [JsonPropertyName("user")]
    public AddressableEntityRef User { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class KnowledgeDocumentFeedbackResponse {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  DocumentVariation: ").Append(DocumentVariation).Append("\n");
        sb.Append("  Rating: ").Append(Rating).Append("\n");
        sb.Append("  Reason: ").Append(Reason).Append("\n");
        sb.Append("  Comment: ").Append(Comment).Append("\n");
        sb.Append("  Search: ").Append(Search).Append("\n");
        sb.Append("  SessionId: ").Append(SessionId).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
        sb.Append("  QueryType: ").Append(QueryType).Append("\n");
        sb.Append("  SurfacingMethod: ").Append(SurfacingMethod).Append("\n");
        sb.Append("  State: ").Append(State).Append("\n");
        sb.Append("  Document: ").Append(Document).Append("\n");
        sb.Append("  Application: ").Append(Application).Append("\n");
        sb.Append("  ConversationContext: ").Append(ConversationContext).Append("\n");
        sb.Append("  User: ").Append(User).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
        return Equals(obj as KnowledgeDocumentFeedbackResponse);
    }

    /// <summary>
    /// Returns true if KnowledgeDocumentFeedbackResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of KnowledgeDocumentFeedbackResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(KnowledgeDocumentFeedbackResponse other)
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
                DocumentVariation == other.DocumentVariation ||
                DocumentVariation != null &&
                DocumentVariation.Equals(other.DocumentVariation)
            ) &&
            (
                Rating == other.Rating ||
                Rating != null &&
                Rating.Equals(other.Rating)
            ) &&
            (
                Reason == other.Reason ||
                Reason != null &&
                Reason.Equals(other.Reason)
            ) &&
            (
                Comment == other.Comment ||
                Comment != null &&
                Comment.Equals(other.Comment)
            ) &&
            (
                Search == other.Search ||
                Search != null &&
                Search.Equals(other.Search)
            ) &&
            (
                SessionId == other.SessionId ||
                SessionId != null &&
                SessionId.Equals(other.SessionId)
            ) &&
            (
                DateCreated == other.DateCreated ||
                DateCreated != null &&
                DateCreated.Equals(other.DateCreated)
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
                State == other.State ||
                State != null &&
                State.Equals(other.State)
            ) &&
            (
                Document == other.Document ||
                Document != null &&
                Document.Equals(other.Document)
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
                User == other.User ||
                User != null &&
                User.Equals(other.User)
            ) &&
            (
                SelfUri == other.SelfUri ||
                SelfUri != null &&
                SelfUri.Equals(other.SelfUri)
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

            if (DocumentVariation != null)
            {
                hash = hash * 59 + DocumentVariation.GetHashCode();
            }

            if (Rating != null)
            {
                hash = hash * 59 + Rating.GetHashCode();
            }

            if (Reason != null)
            {
                hash = hash * 59 + Reason.GetHashCode();
            }

            if (Comment != null)
            {
                hash = hash * 59 + Comment.GetHashCode();
            }

            if (Search != null)
            {
                hash = hash * 59 + Search.GetHashCode();
            }

            if (SessionId != null)
            {
                hash = hash * 59 + SessionId.GetHashCode();
            }

            if (DateCreated != null)
            {
                hash = hash * 59 + DateCreated.GetHashCode();
            }

            if (QueryType != null)
            {
                hash = hash * 59 + QueryType.GetHashCode();
            }

            if (SurfacingMethod != null)
            {
                hash = hash * 59 + SurfacingMethod.GetHashCode();
            }

            if (State != null)
            {
                hash = hash * 59 + State.GetHashCode();
            }

            if (Document != null)
            {
                hash = hash * 59 + Document.GetHashCode();
            }

            if (Application != null)
            {
                hash = hash * 59 + Application.GetHashCode();
            }

            if (ConversationContext != null)
            {
                hash = hash * 59 + ConversationContext.GetHashCode();
            }

            if (User != null)
            {
                hash = hash * 59 + User.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
