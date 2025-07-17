using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class QualityEvaluationScoreItem
{
    /// <summary>
    /// The id of evaluation
    /// </summary>
    /// <value>The id of evaluation</value>
    public string EvaluationId { get; set; }

    /// <summary>
    /// The id of conversation
    /// </summary>
    /// <value>The id of conversation</value>
    public string ConversationId { get; set; }

    /// <summary>
    /// The date of conversation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date of conversation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? ConversationDate { get; set; }

    /// <summary>
    /// The end date of conversation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The end date of conversation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? ConversationEndDate { get; set; }

    /// <summary>
    /// The name of form
    /// </summary>
    /// <value>The name of form</value>
    public string FormName { get; set; }

    /// <summary>
    /// Gamification points earned for this metric
    /// </summary>
    /// <value>Gamification points earned for this metric</value>
    public int? Points { get; set; }

    /// <summary>
    /// The quality score of evaluation as a percentage
    /// </summary>
    /// <value>The quality score of evaluation as a percentage</value>
    public double? EvaluationScore { get; set; }

    /// <summary>
    /// The maximum Gamification points a user may earn for this metric
    /// </summary>
    /// <value>The maximum Gamification points a user may earn for this metric</value>
    public int? MaxPoints { get; set; }

    /// <summary>
    /// A list of media types for the metric
    /// </summary>
    /// <value>A list of media types for the metric</value>
    public IEnumerable<QualityEvaluationScoreItemMediaTypesEnum> MediaTypes { get; set; }
}
