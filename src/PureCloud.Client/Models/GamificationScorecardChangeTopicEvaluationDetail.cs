using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class GamificationScorecardChangeTopicEvaluationDetail
{
    /// <summary>
    /// Gets or Sets EvaluationId
    /// </summary>
    public Guid? EvaluationId { get; set; }

    /// <summary>
    /// Gets or Sets ConversationId
    /// </summary>
    public Guid? ConversationId { get; set; }

    /// <summary>
    /// Gets or Sets ConversationDate
    /// </summary>
    public string ConversationDate { get; set; }

    /// <summary>
    /// Gets or Sets FormName
    /// </summary>
    public string FormName { get; set; }

    /// <summary>
    /// Gets or Sets Points
    /// </summary>
    public long? Points { get; set; }

    /// <summary>
    /// Gets or Sets MaxPoints
    /// </summary>
    public long? MaxPoints { get; set; }

    /// <summary>
    /// Gets or Sets EvaluationScore
    /// </summary>
    public long? EvaluationScore { get; set; }

    /// <summary>
    /// Gets or Sets EvaluationScoreDouble
    /// </summary>
    public double? EvaluationScoreDouble { get; set; }

    /// <summary>
    /// Gets or Sets MediaTypes
    /// </summary>
    public IEnumerable<string> MediaTypes { get; set; }
}
