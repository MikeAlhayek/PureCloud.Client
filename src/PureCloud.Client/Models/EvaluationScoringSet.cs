using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// EvaluationScoringSet
/// </summary>

public partial class EvaluationScoringSet : IEquatable<EvaluationScoringSet>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EvaluationScoringSet" /> class.
    /// </summary>
    /// <param name="TotalScore">Score of all questions.</param>
    /// <param name="TotalCriticalScore">Score of only the critical questions.</param>
    /// <param name="TotalNonCriticalScore">Score of only the non-critical questions.</param>
    /// <param name="QuestionGroupScores">QuestionGroupScores.</param>
    /// <param name="AnyFailedKillQuestions">Indicates that at least one fatal question was answered without having the highest score available for the question.</param>
    /// <param name="Comments">Overall comments from the evaluator.</param>
    /// <param name="PrivateComments">Overall private comments from the evaluator.</param>
    /// <param name="AgentComments">Comments from the agent while reviewing evaluation results.</param>
    /// <param name="TranscriptTopics">List of topics found within the conversation&#39;s transcripts.</param>
    public EvaluationScoringSet(float? TotalScore = null, float? TotalCriticalScore = null, float? TotalNonCriticalScore = null, List<EvaluationQuestionGroupScore> QuestionGroupScores = null, bool? AnyFailedKillQuestions = null, string Comments = null, string PrivateComments = null, string AgentComments = null, List<TranscriptTopic> TranscriptTopics = null)
    {
        this.TotalScore = TotalScore;
        this.TotalCriticalScore = TotalCriticalScore;
        this.TotalNonCriticalScore = TotalNonCriticalScore;
        this.QuestionGroupScores = QuestionGroupScores;
        this.AnyFailedKillQuestions = AnyFailedKillQuestions;
        this.Comments = Comments;
        this.PrivateComments = PrivateComments;
        this.AgentComments = AgentComments;
        this.TranscriptTopics = TranscriptTopics;

    }



    /// <summary>
    /// Score of all questions
    /// </summary>
    /// <value>Score of all questions</value>
    [JsonPropertyName("totalScore")]
    public float? TotalScore { get; set; }



    /// <summary>
    /// Score of only the critical questions
    /// </summary>
    /// <value>Score of only the critical questions</value>
    [JsonPropertyName("totalCriticalScore")]
    public float? TotalCriticalScore { get; set; }



    /// <summary>
    /// Score of only the non-critical questions
    /// </summary>
    /// <value>Score of only the non-critical questions</value>
    [JsonPropertyName("totalNonCriticalScore")]
    public float? TotalNonCriticalScore { get; set; }



    /// <summary>
    /// Gets or Sets QuestionGroupScores
    /// </summary>
    [JsonPropertyName("questionGroupScores")]
    public List<EvaluationQuestionGroupScore> QuestionGroupScores { get; set; }



    /// <summary>
    /// Indicates that at least one fatal question was answered without having the highest score available for the question
    /// </summary>
    /// <value>Indicates that at least one fatal question was answered without having the highest score available for the question</value>
    [JsonPropertyName("anyFailedKillQuestions")]
    public bool? AnyFailedKillQuestions { get; set; }



    /// <summary>
    /// Overall comments from the evaluator
    /// </summary>
    /// <value>Overall comments from the evaluator</value>
    [JsonPropertyName("comments")]
    public string Comments { get; set; }



    /// <summary>
    /// Overall private comments from the evaluator
    /// </summary>
    /// <value>Overall private comments from the evaluator</value>
    [JsonPropertyName("privateComments")]
    public string PrivateComments { get; set; }



    /// <summary>
    /// Comments from the agent while reviewing evaluation results
    /// </summary>
    /// <value>Comments from the agent while reviewing evaluation results</value>
    [JsonPropertyName("agentComments")]
    public string AgentComments { get; set; }



    /// <summary>
    /// List of topics found within the conversation&#39;s transcripts
    /// </summary>
    /// <value>List of topics found within the conversation&#39;s transcripts</value>
    [JsonPropertyName("transcriptTopics")]
    public List<TranscriptTopic> TranscriptTopics { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class EvaluationScoringSet {\n");

        sb.Append("  TotalScore: ").Append(TotalScore).Append("\n");
        sb.Append("  TotalCriticalScore: ").Append(TotalCriticalScore).Append("\n");
        sb.Append("  TotalNonCriticalScore: ").Append(TotalNonCriticalScore).Append("\n");
        sb.Append("  QuestionGroupScores: ").Append(QuestionGroupScores).Append("\n");
        sb.Append("  AnyFailedKillQuestions: ").Append(AnyFailedKillQuestions).Append("\n");
        sb.Append("  Comments: ").Append(Comments).Append("\n");
        sb.Append("  PrivateComments: ").Append(PrivateComments).Append("\n");
        sb.Append("  AgentComments: ").Append(AgentComments).Append("\n");
        sb.Append("  TranscriptTopics: ").Append(TranscriptTopics).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }


    /// <summary>
    /// Returns true if objects are equal
    /// </summary>
    /// <param name="obj">Object to be compared</param>
    /// <returns>Boolean</returns>
    public override bool Equals(object obj)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        return Equals(obj as EvaluationScoringSet);
    }

    /// <summary>
    /// Returns true if EvaluationScoringSet instances are equal
    /// </summary>
    /// <param name="other">Instance of EvaluationScoringSet to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(EvaluationScoringSet other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                TotalScore == other.TotalScore ||
                TotalScore != null &&
                TotalScore.Equals(other.TotalScore)
            ) &&
            (
                TotalCriticalScore == other.TotalCriticalScore ||
                TotalCriticalScore != null &&
                TotalCriticalScore.Equals(other.TotalCriticalScore)
            ) &&
            (
                TotalNonCriticalScore == other.TotalNonCriticalScore ||
                TotalNonCriticalScore != null &&
                TotalNonCriticalScore.Equals(other.TotalNonCriticalScore)
            ) &&
            (
                QuestionGroupScores == other.QuestionGroupScores ||
                QuestionGroupScores != null &&
                QuestionGroupScores.SequenceEqual(other.QuestionGroupScores)
            ) &&
            (
                AnyFailedKillQuestions == other.AnyFailedKillQuestions ||
                AnyFailedKillQuestions != null &&
                AnyFailedKillQuestions.Equals(other.AnyFailedKillQuestions)
            ) &&
            (
                Comments == other.Comments ||
                Comments != null &&
                Comments.Equals(other.Comments)
            ) &&
            (
                PrivateComments == other.PrivateComments ||
                PrivateComments != null &&
                PrivateComments.Equals(other.PrivateComments)
            ) &&
            (
                AgentComments == other.AgentComments ||
                AgentComments != null &&
                AgentComments.Equals(other.AgentComments)
            ) &&
            (
                TranscriptTopics == other.TranscriptTopics ||
                TranscriptTopics != null &&
                TranscriptTopics.SequenceEqual(other.TranscriptTopics)
            );
    }

    /// <summary>
    /// Gets the hash code
    /// </summary>
    /// <returns>Hash code</returns>
    public override int GetHashCode()
    {
        // credit: http://stackoverflow.com/a/263416/677735
        unchecked // Overflow is fine, just wrap
        {
            int hash = 41;
            // Suitable nullity checks etc, of course :)
            if (TotalScore != null)
            {
                hash = hash * 59 + TotalScore.GetHashCode();
            }

            if (TotalCriticalScore != null)
            {
                hash = hash * 59 + TotalCriticalScore.GetHashCode();
            }

            if (TotalNonCriticalScore != null)
            {
                hash = hash * 59 + TotalNonCriticalScore.GetHashCode();
            }

            if (QuestionGroupScores != null)
            {
                hash = hash * 59 + QuestionGroupScores.GetHashCode();
            }

            if (AnyFailedKillQuestions != null)
            {
                hash = hash * 59 + AnyFailedKillQuestions.GetHashCode();
            }

            if (Comments != null)
            {
                hash = hash * 59 + Comments.GetHashCode();
            }

            if (PrivateComments != null)
            {
                hash = hash * 59 + PrivateComments.GetHashCode();
            }

            if (AgentComments != null)
            {
                hash = hash * 59 + AgentComments.GetHashCode();
            }

            if (TranscriptTopics != null)
            {
                hash = hash * 59 + TranscriptTopics.GetHashCode();
            }

            return hash;
        }
    }
}
