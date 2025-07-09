using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class LocaleHealth
{
    /// <summary>
    /// Overall health score for the intent.
    /// </summary>
    /// <value>Overall health score for the intent.</value>
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
    public IEnumerable<LocaleHealthStaticValidationResultsEnum> StaticValidationResults { get; set; }
}
