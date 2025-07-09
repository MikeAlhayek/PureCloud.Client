using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class HealthInfo
{
    /// <summary>
    /// Status of health computation for this intent.
    /// </summary>
    /// <value>Status of health computation for this intent.</value>
    public HealthInfoStatusEnum? Status { get; set; }

    /// <summary>
    /// Error details for the intent, if any.
    /// </summary>
    /// <value>Error details for the intent, if any.</value>
    public FlowHealthErrorInfo ErrorInfo { get; set; }

    /// <summary>
    /// Overall health score for the intent ranged between 0 and 100 as 100 is the perfect health score.
    /// </summary>
    /// <value>Overall health score for the intent ranged between 0 and 100 as 100 is the perfect health score.</value>
    public float? OverallScore { get; set; }

    /// <summary>
    /// Number of issues found in the intent.
    /// </summary>
    /// <value>Number of issues found in the intent.</value>
    public long? IssueCount { get; set; }

    /// <summary>
    /// Validation results for the intent.
    /// </summary>
    /// <value>Validation results for the intent.</value>
    public IEnumerable<HealthInfoStaticValidationResultsEnum> StaticValidationResults { get; set; }

    /// <summary>
    /// Utterances for this intent.
    /// </summary>
    /// <value>Utterances for this intent.</value>
    public IEnumerable<FlowHealthIntentUtterance> Utterances { get; set; }
}
