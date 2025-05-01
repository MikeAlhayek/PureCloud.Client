using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// SurveyQuestionScore
/// </summary>
[DataContract]
public partial class SurveyQuestionScore : IEquatable<SurveyQuestionScore>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SurveyQuestionScore" /> class.
    /// </summary>
    /// <param name="QuestionId">QuestionId.</param>
    /// <param name="AnswerId">AnswerId.</param>
    /// <param name="Score">Unweighted score of the question.</param>
    /// <param name="MarkedNA">True when the evaluation is submitted with a question that does not have an answer. Only allowed when naEnabled is true or if set by the system.</param>
    /// <param name="SystemMarkedNA">If markedNA is true, systemMarkedNA indicates whether it was marked by a user or by the system due to visibility conditions. Always false if markedNA is false..</param>
    /// <param name="AssistedAnswerId">AnswerId found with evaluation assistance conditions.</param>
    /// <param name="NpsScore">NpsScore.</param>
    /// <param name="NpsTextAnswer">NpsTextAnswer.</param>
    /// <param name="FreeTextAnswer">FreeTextAnswer.</param>
    public SurveyQuestionScore(string QuestionId = null, string AnswerId = null, int? Score = null, bool? MarkedNA = null, bool? SystemMarkedNA = null, string AssistedAnswerId = null, int? NpsScore = null, string NpsTextAnswer = null, string FreeTextAnswer = null)
    {
        this.QuestionId = QuestionId;
        this.AnswerId = AnswerId;
        this.Score = Score;
        this.MarkedNA = MarkedNA;
        this.SystemMarkedNA = SystemMarkedNA;
        this.AssistedAnswerId = AssistedAnswerId;
        this.NpsScore = NpsScore;
        this.NpsTextAnswer = NpsTextAnswer;
        this.FreeTextAnswer = FreeTextAnswer;

    }



    /// <summary>
    /// Gets or Sets QuestionId
    /// </summary>
    [DataMember(Name = "questionId", EmitDefaultValue = false)]
    public string QuestionId { get; set; }



    /// <summary>
    /// Gets or Sets AnswerId
    /// </summary>
    [DataMember(Name = "answerId", EmitDefaultValue = false)]
    public string AnswerId { get; set; }



    /// <summary>
    /// Unweighted score of the question
    /// </summary>
    /// <value>Unweighted score of the question</value>
    [DataMember(Name = "score", EmitDefaultValue = false)]
    public int? Score { get; set; }



    /// <summary>
    /// True when the evaluation is submitted with a question that does not have an answer. Only allowed when naEnabled is true or if set by the system
    /// </summary>
    /// <value>True when the evaluation is submitted with a question that does not have an answer. Only allowed when naEnabled is true or if set by the system</value>
    [DataMember(Name = "markedNA", EmitDefaultValue = false)]
    public bool? MarkedNA { get; set; }



    /// <summary>
    /// If markedNA is true, systemMarkedNA indicates whether it was marked by a user or by the system due to visibility conditions. Always false if markedNA is false.
    /// </summary>
    /// <value>If markedNA is true, systemMarkedNA indicates whether it was marked by a user or by the system due to visibility conditions. Always false if markedNA is false.</value>
    [DataMember(Name = "systemMarkedNA", EmitDefaultValue = false)]
    public bool? SystemMarkedNA { get; set; }



    /// <summary>
    /// AnswerId found with evaluation assistance conditions
    /// </summary>
    /// <value>AnswerId found with evaluation assistance conditions</value>
    [DataMember(Name = "assistedAnswerId", EmitDefaultValue = false)]
    public string AssistedAnswerId { get; set; }



    /// <summary>
    /// Gets or Sets NpsScore
    /// </summary>
    [DataMember(Name = "npsScore", EmitDefaultValue = false)]
    public int? NpsScore { get; set; }



    /// <summary>
    /// Gets or Sets NpsTextAnswer
    /// </summary>
    [DataMember(Name = "npsTextAnswer", EmitDefaultValue = false)]
    public string NpsTextAnswer { get; set; }



    /// <summary>
    /// Gets or Sets FreeTextAnswer
    /// </summary>
    [DataMember(Name = "freeTextAnswer", EmitDefaultValue = false)]
    public string FreeTextAnswer { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class SurveyQuestionScore {\n");

        sb.Append("  QuestionId: ").Append(QuestionId).Append("\n");
        sb.Append("  AnswerId: ").Append(AnswerId).Append("\n");
        sb.Append("  Score: ").Append(Score).Append("\n");
        sb.Append("  MarkedNA: ").Append(MarkedNA).Append("\n");
        sb.Append("  SystemMarkedNA: ").Append(SystemMarkedNA).Append("\n");
        sb.Append("  AssistedAnswerId: ").Append(AssistedAnswerId).Append("\n");
        sb.Append("  NpsScore: ").Append(NpsScore).Append("\n");
        sb.Append("  NpsTextAnswer: ").Append(NpsTextAnswer).Append("\n");
        sb.Append("  FreeTextAnswer: ").Append(FreeTextAnswer).Append("\n");
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
        return Equals(obj as SurveyQuestionScore);
    }

    /// <summary>
    /// Returns true if SurveyQuestionScore instances are equal
    /// </summary>
    /// <param name="other">Instance of SurveyQuestionScore to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(SurveyQuestionScore other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                QuestionId == other.QuestionId ||
                QuestionId != null &&
                QuestionId.Equals(other.QuestionId)
            ) &&
            (
                AnswerId == other.AnswerId ||
                AnswerId != null &&
                AnswerId.Equals(other.AnswerId)
            ) &&
            (
                Score == other.Score ||
                Score != null &&
                Score.Equals(other.Score)
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
                AssistedAnswerId == other.AssistedAnswerId ||
                AssistedAnswerId != null &&
                AssistedAnswerId.Equals(other.AssistedAnswerId)
            ) &&
            (
                NpsScore == other.NpsScore ||
                NpsScore != null &&
                NpsScore.Equals(other.NpsScore)
            ) &&
            (
                NpsTextAnswer == other.NpsTextAnswer ||
                NpsTextAnswer != null &&
                NpsTextAnswer.Equals(other.NpsTextAnswer)
            ) &&
            (
                FreeTextAnswer == other.FreeTextAnswer ||
                FreeTextAnswer != null &&
                FreeTextAnswer.Equals(other.FreeTextAnswer)
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
            if (QuestionId != null)
            {
                hash = hash * 59 + QuestionId.GetHashCode();
            }

            if (AnswerId != null)
            {
                hash = hash * 59 + AnswerId.GetHashCode();
            }

            if (Score != null)
            {
                hash = hash * 59 + Score.GetHashCode();
            }

            if (MarkedNA != null)
            {
                hash = hash * 59 + MarkedNA.GetHashCode();
            }

            if (SystemMarkedNA != null)
            {
                hash = hash * 59 + SystemMarkedNA.GetHashCode();
            }

            if (AssistedAnswerId != null)
            {
                hash = hash * 59 + AssistedAnswerId.GetHashCode();
            }

            if (NpsScore != null)
            {
                hash = hash * 59 + NpsScore.GetHashCode();
            }

            if (NpsTextAnswer != null)
            {
                hash = hash * 59 + NpsTextAnswer.GetHashCode();
            }

            if (FreeTextAnswer != null)
            {
                hash = hash * 59 + FreeTextAnswer.GetHashCode();
            }

            return hash;
        }
    }
}
