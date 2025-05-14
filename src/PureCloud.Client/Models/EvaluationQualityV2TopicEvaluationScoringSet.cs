using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class EvaluationQualityV2TopicEvaluationScoringSet
{
    /// <summary>
    /// Gets or Sets TotalScore
    /// </summary>
    public long? TotalScore { get; set; }

    /// <summary>
    /// Gets or Sets TotalCriticalScore
    /// </summary>
    public long? TotalCriticalScore { get; set; }
}
