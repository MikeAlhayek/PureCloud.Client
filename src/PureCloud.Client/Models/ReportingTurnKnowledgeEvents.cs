using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ReportingTurnKnowledgeEvents
{
    /// <summary>
    /// The knowledge search data captured during this reporting turn.
    /// </summary>
    /// <value>The knowledge search data captured during this reporting turn.</value>
    public IEnumerable<ReportingTurnKnowledgeSearchEvent> Search { get; set; }

    /// <summary>
    /// The knowledge feedback data captured during this reporting turn.
    /// </summary>
    /// <value>The knowledge feedback data captured during this reporting turn.</value>
    public IEnumerable<ReportingTurnKnowledgeFeedbackEvent> Feedback { get; set; }
}
