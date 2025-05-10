namespace PureCloud.Client.Models;

/// <summary>
/// EvaluationScoringSet
/// </summary>

public sealed class EvaluationScoringSet
{
    /// <summary>
    /// Score of all questions
    /// </summary>
    /// <value>Score of all questions</value>
    public float? TotalScore { get; set; }

    /// <summary>
    /// Score of only the critical questions
    /// </summary>
    /// <value>Score of only the critical questions</value>
    public float? TotalCriticalScore { get; set; }

    /// <summary>
    /// Score of only the non-critical questions
    /// </summary>
    /// <value>Score of only the non-critical questions</value>
    public float? TotalNonCriticalScore { get; set; }

    /// <summary>
    /// Gets or Sets QuestionGroupScores
    /// </summary>
    public IEnumerable<EvaluationQuestionGroupScore> QuestionGroupScores { get; set; }

    /// <summary>
    /// Indicates that at least one fatal question was answered without having the highest score available for the question
    /// </summary>
    /// <value>Indicates that at least one fatal question was answered without having the highest score available for the question</value>
    public bool? AnyFailedKillQuestions { get; set; }

    /// <summary>
    /// Overall comments from the evaluator
    /// </summary>
    /// <value>Overall comments from the evaluator</value>
    public string Comments { get; set; }

    /// <summary>
    /// Overall private comments from the evaluator
    /// </summary>
    /// <value>Overall private comments from the evaluator</value>
    public string PrivateComments { get; set; }

    /// <summary>
    /// Comments from the agent while reviewing evaluation results
    /// </summary>
    /// <value>Comments from the agent while reviewing evaluation results</value>
    public string AgentComments { get; set; }

    /// <summary>
    /// List of topics found within the conversation&#39;s transcripts
    /// </summary>
    /// <value>List of topics found within the conversation&#39;s transcripts</value>
    public IEnumerable<TranscriptTopic> TranscriptTopics { get; set; }
}
