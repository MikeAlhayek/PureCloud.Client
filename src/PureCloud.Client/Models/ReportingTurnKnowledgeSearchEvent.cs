using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ReportingTurnKnowledgeSearchEvent
{
    /// <summary>
    /// The ID of this knowledge search.
    /// </summary>
    /// <value>The ID of this knowledge search.</value>
    public string SearchId { get; set; }

    /// <summary>
    /// The Knowledge Base ID that the captured knowledge data relates to.
    /// </summary>
    /// <value>The Knowledge Base ID that the captured knowledge data relates to.</value>
    public string KnowledgeBaseId { get; set; }

    /// <summary>
    /// The list of search documents that the feedback applies to.
    /// </summary>
    /// <value>The list of search documents that the feedback applies to.</value>
    public IEnumerable<ReportingTurnKnowledgeDocument> Documents { get; set; }

    /// <summary>
    /// The search query that was used to search the Knowledge Base documents for a matching question.
    /// </summary>
    /// <value>The search query that was used to search the Knowledge Base documents for a matching question.</value>
    public string SearchQuery { get; set; }

    /// <summary>
    /// The document ID of the search answer.
    /// </summary>
    /// <value>The document ID of the search answer.</value>
    public string AnswerDocumentId { get; set; }
}
