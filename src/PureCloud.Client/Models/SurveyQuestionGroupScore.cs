using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// SurveyQuestionGroupScore
/// </summary>

public partial class SurveyQuestionGroupScore : IEquatable<SurveyQuestionGroupScore>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SurveyQuestionGroupScore" /> class.
    /// </summary>
    /// <param name="QuestionGroupId">QuestionGroupId.</param>
    /// <param name="TotalScore">Score of all questions in the group.</param>
    /// <param name="MaxTotalScore">Maximum possible score of all questions in the group.</param>
    /// <param name="MarkedNA">True when the evaluation is submitted with a question group that does not have any answers. Only allowed when naEnabled is true or if set by the system.</param>
    /// <param name="SystemMarkedNA">If markedNA is true, systemMarkedNA indicates whether it was marked by a user or by the system due to visibility conditions. Always false if markedNA is false..</param>
    /// <param name="QuestionScores">QuestionScores.</param>
    public SurveyQuestionGroupScore(string QuestionGroupId = null, float? TotalScore = null, float? MaxTotalScore = null, bool? MarkedNA = null, bool? SystemMarkedNA = null, List<SurveyQuestionScore> QuestionScores = null)
    {
        this.QuestionGroupId = QuestionGroupId;
        this.TotalScore = TotalScore;
        this.MaxTotalScore = MaxTotalScore;
        this.MarkedNA = MarkedNA;
        this.SystemMarkedNA = SystemMarkedNA;
        this.QuestionScores = QuestionScores;

    }



    /// <summary>
    /// Gets or Sets QuestionGroupId
    /// </summary>
    [JsonPropertyName("questionGroupId")]
    public string QuestionGroupId { get; set; }



    /// <summary>
    /// Score of all questions in the group
    /// </summary>
    /// <value>Score of all questions in the group</value>
    [JsonPropertyName("totalScore")]
    public float? TotalScore { get; set; }



    /// <summary>
    /// Maximum possible score of all questions in the group
    /// </summary>
    /// <value>Maximum possible score of all questions in the group</value>
    [JsonPropertyName("maxTotalScore")]
    public float? MaxTotalScore { get; set; }



    /// <summary>
    /// True when the evaluation is submitted with a question group that does not have any answers. Only allowed when naEnabled is true or if set by the system
    /// </summary>
    /// <value>True when the evaluation is submitted with a question group that does not have any answers. Only allowed when naEnabled is true or if set by the system</value>
    [JsonPropertyName("markedNA")]
    public bool? MarkedNA { get; set; }



    /// <summary>
    /// If markedNA is true, systemMarkedNA indicates whether it was marked by a user or by the system due to visibility conditions. Always false if markedNA is false.
    /// </summary>
    /// <value>If markedNA is true, systemMarkedNA indicates whether it was marked by a user or by the system due to visibility conditions. Always false if markedNA is false.</value>
    [JsonPropertyName("systemMarkedNA")]
    public bool? SystemMarkedNA { get; set; }



    /// <summary>
    /// Gets or Sets QuestionScores
    /// </summary>
    [JsonPropertyName("questionScores")]
    public List<SurveyQuestionScore> QuestionScores { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class SurveyQuestionGroupScore {\n");

        sb.Append("  QuestionGroupId: ").Append(QuestionGroupId).Append("\n");
        sb.Append("  TotalScore: ").Append(TotalScore).Append("\n");
        sb.Append("  MaxTotalScore: ").Append(MaxTotalScore).Append("\n");
        sb.Append("  MarkedNA: ").Append(MarkedNA).Append("\n");
        sb.Append("  SystemMarkedNA: ").Append(SystemMarkedNA).Append("\n");
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
        return Equals(obj as SurveyQuestionGroupScore);
    }

    /// <summary>
    /// Returns true if SurveyQuestionGroupScore instances are equal
    /// </summary>
    /// <param name="other">Instance of SurveyQuestionGroupScore to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(SurveyQuestionGroupScore other)
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

            if (QuestionScores != null)
            {
                hash = hash * 59 + QuestionScores.GetHashCode();
            }

            return hash;
        }
    }
}
