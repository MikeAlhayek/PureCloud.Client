namespace PureCloud.Client.Models;

/// <summary>
/// EvaluationQuestionGroup
/// </summary>

public sealed class EvaluationQuestionGroup
{
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// An identifier for this question group that stays the same across versions of the form.
    /// </summary>
    /// <value>An identifier for this question group that stays the same across versions of the form.</value>
    public string ContextId { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    public string Type { get; set; }

    /// <summary>
    /// Gets or Sets DefaultAnswersToHighest
    /// </summary>
    public bool? DefaultAnswersToHighest { get; set; }

    /// <summary>
    /// Gets or Sets DefaultAnswersToNA
    /// </summary>
    public bool? DefaultAnswersToNA { get; set; }

    /// <summary>
    /// Gets or Sets NaEnabled
    /// </summary>
    public bool? NaEnabled { get; set; }

    /// <summary>
    /// Gets or Sets Weight
    /// </summary>
    public float? Weight { get; set; }

    /// <summary>
    /// Gets or Sets ManualWeight
    /// </summary>
    public bool? ManualWeight { get; set; }

    /// <summary>
    /// Gets or Sets Questions
    /// </summary>
    public IEnumerable<EvaluationQuestion> Questions { get; set; }

    /// <summary>
    /// Gets or Sets VisibilityCondition
    /// </summary>
    public VisibilityCondition VisibilityCondition { get; set; }
}
