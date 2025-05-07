using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AssessmentQuestionGroupScore
/// </summary>

public partial class AssessmentQuestionGroupScore : IEquatable<AssessmentQuestionGroupScore>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="AssessmentQuestionGroupScore" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected AssessmentQuestionGroupScore() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="AssessmentQuestionGroupScore" /> class.
    /// </summary>
    /// <param name="QuestionGroupId">The ID of the question group (required).</param>
    /// <param name="MarkedNA">True if this question group is marked NA.</param>
    /// <param name="SystemMarkedNA">If markedNA is true, systemMarkedNA indicates whether it was marked by a user or by the system due to visibility conditions. Always false if markedNA is false..</param>
    /// <param name="QuestionScores">The individual question scores.</param>
    public AssessmentQuestionGroupScore(string QuestionGroupId = null, bool? MarkedNA = null, bool? SystemMarkedNA = null, List<AssessmentQuestionScore> QuestionScores = null)
    {
        this.QuestionGroupId = QuestionGroupId;
        this.MarkedNA = MarkedNA;
        this.SystemMarkedNA = SystemMarkedNA;
        this.QuestionScores = QuestionScores;

    }



    /// <summary>
    /// The ID of the question group
    /// </summary>
    /// <value>The ID of the question group</value>
    [JsonPropertyName("questionGroupId")]
    public string QuestionGroupId { get; set; }



    /// <summary>
    /// The total score for the questions
    /// </summary>
    /// <value>The total score for the questions</value>
    [JsonPropertyName("totalScore")]
    public float? TotalScore { get; set; }



    /// <summary>
    /// The maximum total score for the questions
    /// </summary>
    /// <value>The maximum total score for the questions</value>
    [JsonPropertyName("maxTotalScore")]
    public float? MaxTotalScore { get; set; }



    /// <summary>
    /// True if this question group is marked NA
    /// </summary>
    /// <value>True if this question group is marked NA</value>
    [JsonPropertyName("markedNA")]
    public bool? MarkedNA { get; set; }



    /// <summary>
    /// If markedNA is true, systemMarkedNA indicates whether it was marked by a user or by the system due to visibility conditions. Always false if markedNA is false.
    /// </summary>
    /// <value>If markedNA is true, systemMarkedNA indicates whether it was marked by a user or by the system due to visibility conditions. Always false if markedNA is false.</value>
    [JsonPropertyName("systemMarkedNA")]
    public bool? SystemMarkedNA { get; set; }



    /// <summary>
    /// The total score for the critical questions
    /// </summary>
    /// <value>The total score for the critical questions</value>
    [JsonPropertyName("totalCriticalScore")]
    public float? TotalCriticalScore { get; set; }



    /// <summary>
    /// The maximum total score for the critical questions
    /// </summary>
    /// <value>The maximum total score for the critical questions</value>
    [JsonPropertyName("maxTotalCriticalScore")]
    public float? MaxTotalCriticalScore { get; set; }



    /// <summary>
    /// The total score for the non-critical questions
    /// </summary>
    /// <value>The total score for the non-critical questions</value>
    [JsonPropertyName("totalNonCriticalScore")]
    public float? TotalNonCriticalScore { get; set; }



    /// <summary>
    /// The maximum total score for the non-critical questions
    /// </summary>
    /// <value>The maximum total score for the non-critical questions</value>
    [JsonPropertyName("maxTotalNonCriticalScore")]
    public float? MaxTotalNonCriticalScore { get; set; }



    /// <summary>
    /// The unweighted total score for this question group
    /// </summary>
    /// <value>The unweighted total score for this question group</value>
    [JsonPropertyName("totalScoreUnweighted")]
    public float? TotalScoreUnweighted { get; set; }



    /// <summary>
    /// The maximum unweighted total score for this question group
    /// </summary>
    /// <value>The maximum unweighted total score for this question group</value>
    [JsonPropertyName("maxTotalScoreUnweighted")]
    public float? MaxTotalScoreUnweighted { get; set; }



    /// <summary>
    /// The unweighted total score for the critical questions
    /// </summary>
    /// <value>The unweighted total score for the critical questions</value>
    [JsonPropertyName("totalCriticalScoreUnweighted")]
    public float? TotalCriticalScoreUnweighted { get; set; }



    /// <summary>
    /// The maximum unweighted total score for the critical questions
    /// </summary>
    /// <value>The maximum unweighted total score for the critical questions</value>
    [JsonPropertyName("maxTotalCriticalScoreUnweighted")]
    public float? MaxTotalCriticalScoreUnweighted { get; set; }



    /// <summary>
    /// The total unweighted score for the non-critical questions
    /// </summary>
    /// <value>The total unweighted score for the non-critical questions</value>
    [JsonPropertyName("totalNonCriticalScoreUnweighted")]
    public float? TotalNonCriticalScoreUnweighted { get; set; }



    /// <summary>
    /// The maximum unweighted total score for the non-critical questions
    /// </summary>
    /// <value>The maximum unweighted total score for the non-critical questions</value>
    [JsonPropertyName("maxTotalNonCriticalScoreUnweighted")]
    public float? MaxTotalNonCriticalScoreUnweighted { get; set; }



    /// <summary>
    /// The individual question scores
    /// </summary>
    /// <value>The individual question scores</value>
    [JsonPropertyName("questionScores")]
    public List<AssessmentQuestionScore> QuestionScores { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AssessmentQuestionGroupScore {\n");

        sb.Append("  QuestionGroupId: ").Append(QuestionGroupId).Append("\n");
        sb.Append("  TotalScore: ").Append(TotalScore).Append("\n");
        sb.Append("  MaxTotalScore: ").Append(MaxTotalScore).Append("\n");
        sb.Append("  MarkedNA: ").Append(MarkedNA).Append("\n");
        sb.Append("  SystemMarkedNA: ").Append(SystemMarkedNA).Append("\n");
        sb.Append("  TotalCriticalScore: ").Append(TotalCriticalScore).Append("\n");
        sb.Append("  MaxTotalCriticalScore: ").Append(MaxTotalCriticalScore).Append("\n");
        sb.Append("  TotalNonCriticalScore: ").Append(TotalNonCriticalScore).Append("\n");
        sb.Append("  MaxTotalNonCriticalScore: ").Append(MaxTotalNonCriticalScore).Append("\n");
        sb.Append("  TotalScoreUnweighted: ").Append(TotalScoreUnweighted).Append("\n");
        sb.Append("  MaxTotalScoreUnweighted: ").Append(MaxTotalScoreUnweighted).Append("\n");
        sb.Append("  TotalCriticalScoreUnweighted: ").Append(TotalCriticalScoreUnweighted).Append("\n");
        sb.Append("  MaxTotalCriticalScoreUnweighted: ").Append(MaxTotalCriticalScoreUnweighted).Append("\n");
        sb.Append("  TotalNonCriticalScoreUnweighted: ").Append(TotalNonCriticalScoreUnweighted).Append("\n");
        sb.Append("  MaxTotalNonCriticalScoreUnweighted: ").Append(MaxTotalNonCriticalScoreUnweighted).Append("\n");
        sb.Append("  QuestionScores: ").Append(QuestionScores).Append("\n");
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
        return Equals(obj as AssessmentQuestionGroupScore);
    }

    /// <summary>
    /// Returns true if AssessmentQuestionGroupScore instances are equal
    /// </summary>
    /// <param name="other">Instance of AssessmentQuestionGroupScore to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AssessmentQuestionGroupScore other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                QuestionGroupId == other.QuestionGroupId ||
                QuestionGroupId != null &&
                QuestionGroupId.Equals(other.QuestionGroupId)
            ) &&
            (
                TotalScore == other.TotalScore ||
                TotalScore != null &&
                TotalScore.Equals(other.TotalScore)
            ) &&
            (
                MaxTotalScore == other.MaxTotalScore ||
                MaxTotalScore != null &&
                MaxTotalScore.Equals(other.MaxTotalScore)
            ) &&
            (
                MarkedNA == other.MarkedNA ||
                MarkedNA != null &&
                MarkedNA.Equals(other.MarkedNA)
            ) &&
            (
                SystemMarkedNA == other.SystemMarkedNA ||
                SystemMarkedNA != null &&
                SystemMarkedNA.Equals(other.SystemMarkedNA)
            ) &&
            (
                TotalCriticalScore == other.TotalCriticalScore ||
                TotalCriticalScore != null &&
                TotalCriticalScore.Equals(other.TotalCriticalScore)
            ) &&
            (
                MaxTotalCriticalScore == other.MaxTotalCriticalScore ||
                MaxTotalCriticalScore != null &&
                MaxTotalCriticalScore.Equals(other.MaxTotalCriticalScore)
            ) &&
            (
                TotalNonCriticalScore == other.TotalNonCriticalScore ||
                TotalNonCriticalScore != null &&
                TotalNonCriticalScore.Equals(other.TotalNonCriticalScore)
            ) &&
            (
                MaxTotalNonCriticalScore == other.MaxTotalNonCriticalScore ||
                MaxTotalNonCriticalScore != null &&
                MaxTotalNonCriticalScore.Equals(other.MaxTotalNonCriticalScore)
            ) &&
            (
                TotalScoreUnweighted == other.TotalScoreUnweighted ||
                TotalScoreUnweighted != null &&
                TotalScoreUnweighted.Equals(other.TotalScoreUnweighted)
            ) &&
            (
                MaxTotalScoreUnweighted == other.MaxTotalScoreUnweighted ||
                MaxTotalScoreUnweighted != null &&
                MaxTotalScoreUnweighted.Equals(other.MaxTotalScoreUnweighted)
            ) &&
            (
                TotalCriticalScoreUnweighted == other.TotalCriticalScoreUnweighted ||
                TotalCriticalScoreUnweighted != null &&
                TotalCriticalScoreUnweighted.Equals(other.TotalCriticalScoreUnweighted)
            ) &&
            (
                MaxTotalCriticalScoreUnweighted == other.MaxTotalCriticalScoreUnweighted ||
                MaxTotalCriticalScoreUnweighted != null &&
                MaxTotalCriticalScoreUnweighted.Equals(other.MaxTotalCriticalScoreUnweighted)
            ) &&
            (
                TotalNonCriticalScoreUnweighted == other.TotalNonCriticalScoreUnweighted ||
                TotalNonCriticalScoreUnweighted != null &&
                TotalNonCriticalScoreUnweighted.Equals(other.TotalNonCriticalScoreUnweighted)
            ) &&
            (
                MaxTotalNonCriticalScoreUnweighted == other.MaxTotalNonCriticalScoreUnweighted ||
                MaxTotalNonCriticalScoreUnweighted != null &&
                MaxTotalNonCriticalScoreUnweighted.Equals(other.MaxTotalNonCriticalScoreUnweighted)
            ) &&
            (
                QuestionScores == other.QuestionScores ||
                QuestionScores != null &&
                QuestionScores.SequenceEqual(other.QuestionScores)
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
            if (QuestionGroupId != null)
            {
                hash = hash * 59 + QuestionGroupId.GetHashCode();
            }

            if (TotalScore != null)
            {
                hash = hash * 59 + TotalScore.GetHashCode();
            }

            if (MaxTotalScore != null)
            {
                hash = hash * 59 + MaxTotalScore.GetHashCode();
            }

            if (MarkedNA != null)
            {
                hash = hash * 59 + MarkedNA.GetHashCode();
            }

            if (SystemMarkedNA != null)
            {
                hash = hash * 59 + SystemMarkedNA.GetHashCode();
            }

            if (TotalCriticalScore != null)
            {
                hash = hash * 59 + TotalCriticalScore.GetHashCode();
            }

            if (MaxTotalCriticalScore != null)
            {
                hash = hash * 59 + MaxTotalCriticalScore.GetHashCode();
            }

            if (TotalNonCriticalScore != null)
            {
                hash = hash * 59 + TotalNonCriticalScore.GetHashCode();
            }

            if (MaxTotalNonCriticalScore != null)
            {
                hash = hash * 59 + MaxTotalNonCriticalScore.GetHashCode();
            }

            if (TotalScoreUnweighted != null)
            {
                hash = hash * 59 + TotalScoreUnweighted.GetHashCode();
            }

            if (MaxTotalScoreUnweighted != null)
            {
                hash = hash * 59 + MaxTotalScoreUnweighted.GetHashCode();
            }

            if (TotalCriticalScoreUnweighted != null)
            {
                hash = hash * 59 + TotalCriticalScoreUnweighted.GetHashCode();
            }

            if (MaxTotalCriticalScoreUnweighted != null)
            {
                hash = hash * 59 + MaxTotalCriticalScoreUnweighted.GetHashCode();
            }

            if (TotalNonCriticalScoreUnweighted != null)
            {
                hash = hash * 59 + TotalNonCriticalScoreUnweighted.GetHashCode();
            }

            if (MaxTotalNonCriticalScoreUnweighted != null)
            {
                hash = hash * 59 + MaxTotalNonCriticalScoreUnweighted.GetHashCode();
            }

            if (QuestionScores != null)
            {
                hash = hash * 59 + QuestionScores.GetHashCode();
            }

            return hash;
        }
    }
}
