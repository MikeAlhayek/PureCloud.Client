namespace PureCloud.Client.Models;

/// <summary>
/// EvaluationQuestionScore
/// </summary>

public sealed class EvaluationQuestionScore
{
    /// <summary>
    /// Gets or Sets QuestionId
    /// </summary>
    public string QuestionId { get; set; }

    /// <summary>
    /// Gets or Sets AnswerId
    /// </summary>
    public string AnswerId { get; set; }

    /// <summary>
    /// Unweighted score of the question
    /// </summary>
    /// <value>Unweighted score of the question</value>
    public int? Score { get; set; }

    /// <summary>
    /// True when the evaluation is submitted with a question that does not have an answer. Only allowed when naEnabled is true or if set by the system
    /// </summary>
    /// <value>True when the evaluation is submitted with a question that does not have an answer. Only allowed when naEnabled is true or if set by the system</value>
    public bool? MarkedNA { get; set; }

    /// <summary>
    /// If markedNA is true, systemMarkedNA indicates whether it was marked by a user or by the system due to visibility conditions. Always false if markedNA is false.
    /// </summary>
    /// <value>If markedNA is true, systemMarkedNA indicates whether it was marked by a user or by the system due to visibility conditions. Always false if markedNA is false.</value>
    public bool? SystemMarkedNA { get; set; }

    /// <summary>
    /// AnswerId found with evaluation assistance conditions
    /// </summary>
    /// <value>AnswerId found with evaluation assistance conditions</value>
    public string AssistedAnswerId { get; set; }

    /// <summary>
    /// Applicable only on fatal questions. Indicates that the answer selected was not the highest score available for the question
    /// </summary>
    /// <value>Applicable only on fatal questions. Indicates that the answer selected was not the highest score available for the question</value>
    public bool? FailedKillQuestion { get; set; }

    /// <summary>
    /// Comments from the evaluator specific to this question
    /// </summary>
    /// <value>Comments from the evaluator specific to this question</value>
    public string Comments { get; set; }

    /// <summary>
    /// Suggested AI answer
    /// </summary>
    /// <value>Suggested AI answer</value>
    public AiAnswer AiAnswer { get; set; }
}
