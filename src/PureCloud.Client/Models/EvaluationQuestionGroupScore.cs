namespace PureCloud.Client.Models;

/// <summary>
/// EvaluationQuestionGroupScore
/// </summary>

public sealed class EvaluationQuestionGroupScore
{
    /// <summary>
    /// Gets or Sets QuestionGroupId
    /// </summary>
    public string QuestionGroupId { get; set; }

    /// <summary>
    /// Score of all questions in the group
    /// </summary>
    /// <value>Score of all questions in the group</value>
    public float? TotalScore { get; set; }

    /// <summary>
    /// Maximum possible score of all questions in the group
    /// </summary>
    /// <value>Maximum possible score of all questions in the group</value>
    public float? MaxTotalScore { get; set; }

    /// <summary>
    /// True when the evaluation is submitted with a question group that does not have any answers. Only allowed when naEnabled is true or if set by the system
    /// </summary>
    /// <value>True when the evaluation is submitted with a question group that does not have any answers. Only allowed when naEnabled is true or if set by the system</value>
    public bool? MarkedNA { get; set; }

    /// <summary>
    /// If markedNA is true, systemMarkedNA indicates whether it was marked by a user or by the system due to visibility conditions. Always false if markedNA is false.
    /// </summary>
    /// <value>If markedNA is true, systemMarkedNA indicates whether it was marked by a user or by the system due to visibility conditions. Always false if markedNA is false.</value>
    public bool? SystemMarkedNA { get; set; }

    /// <summary>
    /// Score of only the critical questions in the group
    /// </summary>
    /// <value>Score of only the critical questions in the group</value>
    public float? TotalCriticalScore { get; set; }

    /// <summary>
    /// Maximum possible score of only the critical questions in the group
    /// </summary>
    /// <value>Maximum possible score of only the critical questions in the group</value>
    public float? MaxTotalCriticalScore { get; set; }

    /// <summary>
    /// Score of only the non critical questions in the group
    /// </summary>
    /// <value>Score of only the non critical questions in the group</value>
    public float? TotalNonCriticalScore { get; set; }

    /// <summary>
    /// Maximum possible score of only the non critical questions in the group
    /// </summary>
    /// <value>Maximum possible score of only the non critical questions in the group</value>
    public float? MaxTotalNonCriticalScore { get; set; }

    /// <summary>
    /// Unweighted score of all questions in the group
    /// </summary>
    /// <value>Unweighted score of all questions in the group</value>
    public float? TotalScoreUnweighted { get; set; }

    /// <summary>
    /// Maximum possible unweighted score of all questions in the group
    /// </summary>
    /// <value>Maximum possible unweighted score of all questions in the group</value>
    public float? MaxTotalScoreUnweighted { get; set; }

    /// <summary>
    /// Unweighted score of only the critical questions in the group
    /// </summary>
    /// <value>Unweighted score of only the critical questions in the group</value>
    public float? TotalCriticalScoreUnweighted { get; set; }

    /// <summary>
    /// Maximum possible unweighted score of only the critical questions in the group
    /// </summary>
    /// <value>Maximum possible unweighted score of only the critical questions in the group</value>
    public float? MaxTotalCriticalScoreUnweighted { get; set; }

    /// <summary>
    /// Unweighted score of only the non critical questions in the group
    /// </summary>
    /// <value>Unweighted score of only the non critical questions in the group</value>
    public float? TotalNonCriticalScoreUnweighted { get; set; }

    /// <summary>
    /// Maximum possible unweighted score of only the non critical questions in the group
    /// </summary>
    /// <value>Maximum possible unweighted score of only the non critical questions in the group</value>
    public float? MaxTotalNonCriticalScoreUnweighted { get; set; }

    /// <summary>
    /// Gets or Sets QuestionScores
    /// </summary>
    public IEnumerable<EvaluationQuestionScore> QuestionScores { get; set; }
}
