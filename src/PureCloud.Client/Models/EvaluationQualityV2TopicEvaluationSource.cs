using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class EvaluationQualityV2TopicEvaluationSource
{
    /// <summary>
    /// Gets or Sets EvaluationSourceType
    /// </summary>
    public string EvaluationSourceType { get; set; }

    /// <summary>
    /// Gets or Sets EvaluationSourceId
    /// </summary>
    public string EvaluationSourceId { get; set; }

    /// <summary>
    /// Gets or Sets EvaluationSourceName
    /// </summary>
    public string EvaluationSourceName { get; set; }
}
