namespace PureCloud.Client.Models;


public sealed class EvaluationSettings
{
    /// <summary>
    /// Whether revisions are allowed for evaluations. When enabled, rescoring creates a new version of the evaluation and retracts the existing evaluation version. Does not apply for calibration evaluations.
    /// </summary>
    /// <value>Whether revisions are allowed for evaluations. When enabled, rescoring creates a new version of the evaluation and retracts the existing evaluation version. Does not apply for calibration evaluations.</value>
    public bool? RevisionsEnabled { get; set; }

    /// <summary>
    /// Whether disputes are allowed for evaluations. Does not apply for calibration evaluations.
    /// </summary>
    /// <value>Whether disputes are allowed for evaluations. Does not apply for calibration evaluations.</value>
    public bool? DisputesEnabled { get; set; }

    /// <summary>
    /// The maximum number of disputes allowed for an evaluation.
    /// </summary>
    /// <value>The maximum number of disputes allowed for an evaluation.</value>
    public int? DisputesAllowedPerEvaluation { get; set; }

    /// <summary>
    /// A list of assignees responsible for handling each dispute. This list size needs to be equal to disputesAllowedPerEvaluation.
    /// </summary>
    /// <value>A list of assignees responsible for handling each dispute. This list size needs to be equal to disputesAllowedPerEvaluation.</value>
    public IEnumerable<EvaluationSettingsAssignee> DisputesAssignees { get; set; }
}
