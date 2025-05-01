using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// EvaluationQuestionGroupScore
/// </summary>
[DataContract]
public partial class EvaluationQuestionGroupScore : IEquatable<EvaluationQuestionGroupScore>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EvaluationQuestionGroupScore" /> class.
    /// </summary>
    /// <param name="QuestionGroupId">QuestionGroupId.</param>
    /// <param name="TotalScore">Score of all questions in the group.</param>
    /// <param name="MaxTotalScore">Maximum possible score of all questions in the group.</param>
    /// <param name="MarkedNA">True when the evaluation is submitted with a question group that does not have any answers. Only allowed when naEnabled is true or if set by the system.</param>
    /// <param name="SystemMarkedNA">If markedNA is true, systemMarkedNA indicates whether it was marked by a user or by the system due to visibility conditions. Always false if markedNA is false..</param>
    /// <param name="TotalCriticalScore">Score of only the critical questions in the group.</param>
    /// <param name="MaxTotalCriticalScore">Maximum possible score of only the critical questions in the group.</param>
    /// <param name="TotalNonCriticalScore">Score of only the non critical questions in the group.</param>
    /// <param name="MaxTotalNonCriticalScore">Maximum possible score of only the non critical questions in the group.</param>
    /// <param name="TotalScoreUnweighted">Unweighted score of all questions in the group.</param>
    /// <param name="MaxTotalScoreUnweighted">Maximum possible unweighted score of all questions in the group.</param>
    /// <param name="TotalCriticalScoreUnweighted">Unweighted score of only the critical questions in the group.</param>
    /// <param name="MaxTotalCriticalScoreUnweighted">Maximum possible unweighted score of only the critical questions in the group.</param>
    /// <param name="TotalNonCriticalScoreUnweighted">Unweighted score of only the non critical questions in the group.</param>
    /// <param name="MaxTotalNonCriticalScoreUnweighted">Maximum possible unweighted score of only the non critical questions in the group.</param>
    /// <param name="QuestionScores">QuestionScores.</param>
    public EvaluationQuestionGroupScore(string QuestionGroupId = null, float? TotalScore = null, float? MaxTotalScore = null, bool? MarkedNA = null, bool? SystemMarkedNA = null, float? TotalCriticalScore = null, float? MaxTotalCriticalScore = null, float? TotalNonCriticalScore = null, float? MaxTotalNonCriticalScore = null, float? TotalScoreUnweighted = null, float? MaxTotalScoreUnweighted = null, float? TotalCriticalScoreUnweighted = null, float? MaxTotalCriticalScoreUnweighted = null, float? TotalNonCriticalScoreUnweighted = null, float? MaxTotalNonCriticalScoreUnweighted = null, List<EvaluationQuestionScore> QuestionScores = null)
    {
        this.QuestionGroupId = QuestionGroupId;
        this.TotalScore = TotalScore;
        this.MaxTotalScore = MaxTotalScore;
        this.MarkedNA = MarkedNA;
        this.SystemMarkedNA = SystemMarkedNA;
        this.TotalCriticalScore = TotalCriticalScore;
        this.MaxTotalCriticalScore = MaxTotalCriticalScore;
        this.TotalNonCriticalScore = TotalNonCriticalScore;
        this.MaxTotalNonCriticalScore = MaxTotalNonCriticalScore;
        this.TotalScoreUnweighted = TotalScoreUnweighted;
        this.MaxTotalScoreUnweighted = MaxTotalScoreUnweighted;
        this.TotalCriticalScoreUnweighted = TotalCriticalScoreUnweighted;
        this.MaxTotalCriticalScoreUnweighted = MaxTotalCriticalScoreUnweighted;
        this.TotalNonCriticalScoreUnweighted = TotalNonCriticalScoreUnweighted;
        this.MaxTotalNonCriticalScoreUnweighted = MaxTotalNonCriticalScoreUnweighted;
        this.QuestionScores = QuestionScores;

    }



    /// <summary>
    /// Gets or Sets QuestionGroupId
    /// </summary>
    [DataMember(Name = "questionGroupId", EmitDefaultValue = false)]
    public string QuestionGroupId { get; set; }



    /// <summary>
    /// Score of all questions in the group
    /// </summary>
    /// <value>Score of all questions in the group</value>
    [DataMember(Name = "totalScore", EmitDefaultValue = false)]
    public float? TotalScore { get; set; }



    /// <summary>
    /// Maximum possible score of all questions in the group
    /// </summary>
    /// <value>Maximum possible score of all questions in the group</value>
    [DataMember(Name = "maxTotalScore", EmitDefaultValue = false)]
    public float? MaxTotalScore { get; set; }



    /// <summary>
    /// True when the evaluation is submitted with a question group that does not have any answers. Only allowed when naEnabled is true or if set by the system
    /// </summary>
    /// <value>True when the evaluation is submitted with a question group that does not have any answers. Only allowed when naEnabled is true or if set by the system</value>
    [DataMember(Name = "markedNA", EmitDefaultValue = false)]
    public bool? MarkedNA { get; set; }



    /// <summary>
    /// If markedNA is true, systemMarkedNA indicates whether it was marked by a user or by the system due to visibility conditions. Always false if markedNA is false.
    /// </summary>
    /// <value>If markedNA is true, systemMarkedNA indicates whether it was marked by a user or by the system due to visibility conditions. Always false if markedNA is false.</value>
    [DataMember(Name = "systemMarkedNA", EmitDefaultValue = false)]
    public bool? SystemMarkedNA { get; set; }



    /// <summary>
    /// Score of only the critical questions in the group
    /// </summary>
    /// <value>Score of only the critical questions in the group</value>
    [DataMember(Name = "totalCriticalScore", EmitDefaultValue = false)]
    public float? TotalCriticalScore { get; set; }



    /// <summary>
    /// Maximum possible score of only the critical questions in the group
    /// </summary>
    /// <value>Maximum possible score of only the critical questions in the group</value>
    [DataMember(Name = "maxTotalCriticalScore", EmitDefaultValue = false)]
    public float? MaxTotalCriticalScore { get; set; }



    /// <summary>
    /// Score of only the non critical questions in the group
    /// </summary>
    /// <value>Score of only the non critical questions in the group</value>
    [DataMember(Name = "totalNonCriticalScore", EmitDefaultValue = false)]
    public float? TotalNonCriticalScore { get; set; }



    /// <summary>
    /// Maximum possible score of only the non critical questions in the group
    /// </summary>
    /// <value>Maximum possible score of only the non critical questions in the group</value>
    [DataMember(Name = "maxTotalNonCriticalScore", EmitDefaultValue = false)]
    public float? MaxTotalNonCriticalScore { get; set; }



    /// <summary>
    /// Unweighted score of all questions in the group
    /// </summary>
    /// <value>Unweighted score of all questions in the group</value>
    [DataMember(Name = "totalScoreUnweighted", EmitDefaultValue = false)]
    public float? TotalScoreUnweighted { get; set; }



    /// <summary>
    /// Maximum possible unweighted score of all questions in the group
    /// </summary>
    /// <value>Maximum possible unweighted score of all questions in the group</value>
    [DataMember(Name = "maxTotalScoreUnweighted", EmitDefaultValue = false)]
    public float? MaxTotalScoreUnweighted { get; set; }



    /// <summary>
    /// Unweighted score of only the critical questions in the group
    /// </summary>
    /// <value>Unweighted score of only the critical questions in the group</value>
    [DataMember(Name = "totalCriticalScoreUnweighted", EmitDefaultValue = false)]
    public float? TotalCriticalScoreUnweighted { get; set; }



    /// <summary>
    /// Maximum possible unweighted score of only the critical questions in the group
    /// </summary>
    /// <value>Maximum possible unweighted score of only the critical questions in the group</value>
    [DataMember(Name = "maxTotalCriticalScoreUnweighted", EmitDefaultValue = false)]
    public float? MaxTotalCriticalScoreUnweighted { get; set; }



    /// <summary>
    /// Unweighted score of only the non critical questions in the group
    /// </summary>
    /// <value>Unweighted score of only the non critical questions in the group</value>
    [DataMember(Name = "totalNonCriticalScoreUnweighted", EmitDefaultValue = false)]
    public float? TotalNonCriticalScoreUnweighted { get; set; }



    /// <summary>
    /// Maximum possible unweighted score of only the non critical questions in the group
    /// </summary>
    /// <value>Maximum possible unweighted score of only the non critical questions in the group</value>
    [DataMember(Name = "maxTotalNonCriticalScoreUnweighted", EmitDefaultValue = false)]
    public float? MaxTotalNonCriticalScoreUnweighted { get; set; }



    /// <summary>
    /// Gets or Sets QuestionScores
    /// </summary>
    [DataMember(Name = "questionScores", EmitDefaultValue = false)]
    public List<EvaluationQuestionScore> QuestionScores { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class EvaluationQuestionGroupScore {\n");

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
        return Equals(obj as EvaluationQuestionGroupScore);
    }

    /// <summary>
    /// Returns true if EvaluationQuestionGroupScore instances are equal
    /// </summary>
    /// <param name="other">Instance of EvaluationQuestionGroupScore to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(EvaluationQuestionGroupScore other)
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
