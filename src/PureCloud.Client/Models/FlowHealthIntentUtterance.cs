using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class FlowHealthIntentUtterance
{
    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    public string Id { get; set; }

    /// <summary>
    /// Utterance Text.
    /// </summary>
    /// <value>Utterance Text.</value>
    public string Text { get; set; }

    /// <summary>
    /// Number of issues found for this utterance.
    /// </summary>
    /// <value>Number of issues found for this utterance.</value>
    public long? IssueCount { get; set; }

    /// <summary>
    /// Validation results for this utterance.
    /// </summary>
    /// <value>Validation results for this utterance.</value>
    public IEnumerable<FlowHealthIntentUtteranceStaticValidationResultsEnum> StaticValidationResults { get; set; }

    /// <summary>
    /// Details about this utterance being an outlier or not.
    /// </summary>
    /// <value>Details about this utterance being an outlier or not.</value>
    public OutlierInfo OutlierInfo { get; set; }

    /// <summary>
    /// Confusion details with other utterances.
    /// </summary>
    /// <value>Confusion details with other utterances.</value>
    public ConfusionInfo ConfusionInfo { get; set; }
}
