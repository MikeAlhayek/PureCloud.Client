using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ReportingTurnKnowledgeSearch
{
    /// <summary>
    /// The ID of this knowledge search.
    /// </summary>
    /// <value>The ID of this knowledge search.</value>
    public string SearchId { get; set; }

    /// <summary>
    /// The list of search documents captured during this reporting turn.
    /// </summary>
    /// <value>The list of search documents captured during this reporting turn.</value>
    public IEnumerable<ReportingTurnKnowledgeDocument> Documents { get; set; }

    /// <summary>
    /// The search query that was used to search the Knowledge Base documents for a matching question.
    /// </summary>
    /// <value>The search query that was used to search the Knowledge Base documents for a matching question.</value>
    public string Query { get; set; }
}
