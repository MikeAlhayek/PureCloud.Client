using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ReportingTurnKnowledgeFeedbackEvent
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
    /// The feedback rating for the search (1.0 - 5.0). 1 &#x3D; Negative, 5 &#x3D; Positive.
    /// </summary>
    /// <value>The feedback rating for the search (1.0 - 5.0). 1 &#x3D; Negative, 5 &#x3D; Positive.</value>
    public int? FeedbackRating { get; set; }

    /// <summary>
    /// The variation of the document.
    /// </summary>
    /// <value>The variation of the document.</value>
    public string DocumentVariationId { get; set; }

    /// <summary>
    /// The version of the document.
    /// </summary>
    /// <value>The version of the document.</value>
    public string DocumentVersionId { get; set; }
}
