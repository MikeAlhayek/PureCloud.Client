using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ReportingTurnKnowledgeFeedback
{
    /// <summary>
    /// The ID of the original knowledge search that this feedback relates to.
    /// </summary>
    /// <value>The ID of the original knowledge search that this feedback relates to.</value>
    public string SearchId { get; set; }

    /// <summary>
    /// The feedback rating for the search (1.0 - 5.0). 1 &#x3D; Negative, 5 &#x3D; Positive.
    /// </summary>
    /// <value>The feedback rating for the search (1.0 - 5.0). 1 &#x3D; Negative, 5 &#x3D; Positive.</value>
    public int? Rating { get; set; }

    /// <summary>
    /// The list of search documents that the feedback applies to.
    /// </summary>
    /// <value>The list of search documents that the feedback applies to.</value>
    public IEnumerable<ReportingTurnKnowledgeDocument> Documents { get; set; }
}
