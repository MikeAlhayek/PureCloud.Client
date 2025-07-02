using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ReportingTurnKnowledge
{
    /// <summary>
    /// The Knowledge Base ID that the captured knowledge data relates to.
    /// </summary>
    /// <value>The Knowledge Base ID that the captured knowledge data relates to.</value>
    public string KnowledgeBaseId { get; set; }

    /// <summary>
    /// The knowledge feedback data that was captured during this reporting turn.
    /// </summary>
    /// <value>The knowledge feedback data that was captured during this reporting turn.</value>
    public ReportingTurnKnowledgeFeedback Feedback { get; set; }

    /// <summary>
    /// The knowledge search data that was captured during this reporting turn.
    /// </summary>
    /// <value>The knowledge search data that was captured during this reporting turn.</value>
    public ReportingTurnKnowledgeSearch Search { get; set; }
}
