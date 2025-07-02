using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ReportingTurnKnowledgeDocument
{
    /// <summary>
    /// The ID of the knowledge document.
    /// </summary>
    /// <value>The ID of the knowledge document.</value>
    public string Id { get; set; }

    /// <summary>
    /// The the question that was used to match against the search query.
    /// </summary>
    /// <value>The the question that was used to match against the search query.</value>
    public string Question { get; set; }

    /// <summary>
    /// The corresponding answer to the question.
    /// </summary>
    /// <value>The corresponding answer to the question.</value>
    public string Answer { get; set; }

    /// <summary>
    /// The confidence score of how well the question matched the search query.
    /// </summary>
    /// <value>The confidence score of how well the question matched the search query.</value>
    public double? Confidence { get; set; }
}
