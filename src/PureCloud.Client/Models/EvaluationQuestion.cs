namespace PureCloud.Client.Models;

public sealed class EvaluationQuestion
{
    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    public EvaluationQuestionType? Type { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// An identifier for this question that stays the same across versions of the form.
    /// </summary>
    /// <value>An identifier for this question that stays the same across versions of the form.</value>
    public string ContextId { get; set; }

    /// <summary>
    /// Gets or Sets Text
    /// </summary>
    public string Text { get; set; }

    /// <summary>
    /// Gets or Sets HelpText
    /// </summary>
    public string HelpText { get; set; }

    /// <summary>
    /// Gets or Sets NaEnabled
    /// </summary>
    public bool? NaEnabled { get; set; }

    /// <summary>
    /// Gets or Sets CommentsRequired
    /// </summary>
    public bool? CommentsRequired { get; set; }

    /// <summary>
    /// Gets or Sets VisibilityCondition
    /// </summary>
    public VisibilityCondition VisibilityCondition { get; set; }

    /// <summary>
    /// Options from which to choose an answer for this question. Only used by Multiple Choice type questions.
    /// </summary>
    /// <value>Options from which to choose an answer for this question. Only used by Multiple Choice type questions.</value>
    public IEnumerable<AnswerOption> AnswerOptions { get; set; }

    /// <summary>
    /// Gets or Sets IsKill
    /// </summary>
    public bool? IsKill { get; set; }

    /// <summary>
    /// Gets or Sets IsCritical
    /// </summary>
    public bool? IsCritical { get; set; }
}
