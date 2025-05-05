using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ReportingTurnKnowledgeSearchEvent
/// </summary>

public partial class ReportingTurnKnowledgeSearchEvent : IEquatable<ReportingTurnKnowledgeSearchEvent>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ReportingTurnKnowledgeSearchEvent" /> class.
    /// </summary>
    /// <param name="SearchId">The ID of this knowledge search..</param>
    /// <param name="KnowledgeBaseId">The Knowledge Base ID that the captured knowledge data relates to..</param>
    /// <param name="Documents">The list of search documents that the feedback applies to..</param>
    /// <param name="SearchQuery">The search query that was used to search the Knowledge Base documents for a matching question..</param>
    /// <param name="AnswerDocumentId">The document ID of the search answer..</param>
    public ReportingTurnKnowledgeSearchEvent(string SearchId = null, string KnowledgeBaseId = null, List<ReportingTurnKnowledgeDocument> Documents = null, string SearchQuery = null, string AnswerDocumentId = null)
    {
        this.SearchId = SearchId;
        this.KnowledgeBaseId = KnowledgeBaseId;
        this.Documents = Documents;
        this.SearchQuery = SearchQuery;
        this.AnswerDocumentId = AnswerDocumentId;

    }



    /// <summary>
    /// The ID of this knowledge search.
    /// </summary>
    /// <value>The ID of this knowledge search.</value>
    [JsonPropertyName("searchId")]
    public string SearchId { get; set; }



    /// <summary>
    /// The Knowledge Base ID that the captured knowledge data relates to.
    /// </summary>
    /// <value>The Knowledge Base ID that the captured knowledge data relates to.</value>
    [JsonPropertyName("knowledgeBaseId")]
    public string KnowledgeBaseId { get; set; }



    /// <summary>
    /// The list of search documents that the feedback applies to.
    /// </summary>
    /// <value>The list of search documents that the feedback applies to.</value>
    [JsonPropertyName("documents")]
    public List<ReportingTurnKnowledgeDocument> Documents { get; set; }



    /// <summary>
    /// The search query that was used to search the Knowledge Base documents for a matching question.
    /// </summary>
    /// <value>The search query that was used to search the Knowledge Base documents for a matching question.</value>
    [JsonPropertyName("searchQuery")]
    public string SearchQuery { get; set; }



    /// <summary>
    /// The document ID of the search answer.
    /// </summary>
    /// <value>The document ID of the search answer.</value>
    [JsonPropertyName("answerDocumentId")]
    public string AnswerDocumentId { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ReportingTurnKnowledgeSearchEvent {\n");

        sb.Append("  SearchId: ").Append(SearchId).Append("\n");
        sb.Append("  KnowledgeBaseId: ").Append(KnowledgeBaseId).Append("\n");
        sb.Append("  Documents: ").Append(Documents).Append("\n");
        sb.Append("  SearchQuery: ").Append(SearchQuery).Append("\n");
        sb.Append("  AnswerDocumentId: ").Append(AnswerDocumentId).Append("\n");
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
        return Equals(obj as ReportingTurnKnowledgeSearchEvent);
    }

    /// <summary>
    /// Returns true if ReportingTurnKnowledgeSearchEvent instances are equal
    /// </summary>
    /// <param name="other">Instance of ReportingTurnKnowledgeSearchEvent to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ReportingTurnKnowledgeSearchEvent other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                SearchId == other.SearchId ||
                SearchId != null &&
                SearchId.Equals(other.SearchId)
            ) &&
            (
                KnowledgeBaseId == other.KnowledgeBaseId ||
                KnowledgeBaseId != null &&
                KnowledgeBaseId.Equals(other.KnowledgeBaseId)
            ) &&
            (
                Documents == other.Documents ||
                Documents != null &&
                Documents.SequenceEqual(other.Documents)
            ) &&
            (
                SearchQuery == other.SearchQuery ||
                SearchQuery != null &&
                SearchQuery.Equals(other.SearchQuery)
            ) &&
            (
                AnswerDocumentId == other.AnswerDocumentId ||
                AnswerDocumentId != null &&
                AnswerDocumentId.Equals(other.AnswerDocumentId)
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
            if (SearchId != null)
            {
                hash = hash * 59 + SearchId.GetHashCode();
            }

            if (KnowledgeBaseId != null)
            {
                hash = hash * 59 + KnowledgeBaseId.GetHashCode();
            }

            if (Documents != null)
            {
                hash = hash * 59 + Documents.GetHashCode();
            }

            if (SearchQuery != null)
            {
                hash = hash * 59 + SearchQuery.GetHashCode();
            }

            if (AnswerDocumentId != null)
            {
                hash = hash * 59 + AnswerDocumentId.GetHashCode();
            }

            return hash;
        }
    }
}
