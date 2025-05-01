using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AssessmentQuestionScore
/// </summary>
[DataContract]
public partial class AssessmentQuestionScore : IEquatable<AssessmentQuestionScore>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="AssessmentQuestionScore" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected AssessmentQuestionScore() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="AssessmentQuestionScore" /> class.
    /// </summary>
    /// <param name="Comments">Comments provided for the answer.</param>
    /// <param name="QuestionId">The ID of the question (required).</param>
    /// <param name="AnswerId">The ID of the selected answer.</param>
    /// <param name="MarkedNA">True if this question was marked as NA.</param>
    /// <param name="SystemMarkedNA">If markedNA is true, systemMarkedNA indicates whether it was marked by a user or by the system due to visibility conditions. Always false if markedNA is false..</param>
    /// <param name="FreeTextAnswer">Answer for free text answer type.</param>
    public AssessmentQuestionScore(string Comments = null, string QuestionId = null, string AnswerId = null, bool? MarkedNA = null, bool? SystemMarkedNA = null, string FreeTextAnswer = null)
    {
        this.Comments = Comments;
        this.QuestionId = QuestionId;
        this.AnswerId = AnswerId;
        this.MarkedNA = MarkedNA;
        this.SystemMarkedNA = SystemMarkedNA;
        this.FreeTextAnswer = FreeTextAnswer;

    }



    /// <summary>
    /// True if this was a failed Kill question
    /// </summary>
    /// <value>True if this was a failed Kill question</value>
    [DataMember(Name = "failedKillQuestion", EmitDefaultValue = false)]
    public bool? FailedKillQuestion { get; private set; }



    /// <summary>
    /// Comments provided for the answer
    /// </summary>
    /// <value>Comments provided for the answer</value>
    [DataMember(Name = "comments", EmitDefaultValue = false)]
    public string Comments { get; set; }



    /// <summary>
    /// The ID of the question
    /// </summary>
    /// <value>The ID of the question</value>
    [DataMember(Name = "questionId", EmitDefaultValue = false)]
    public string QuestionId { get; set; }



    /// <summary>
    /// The ID of the selected answer
    /// </summary>
    /// <value>The ID of the selected answer</value>
    [DataMember(Name = "answerId", EmitDefaultValue = false)]
    public string AnswerId { get; set; }



    /// <summary>
    /// The score received for this question
    /// </summary>
    /// <value>The score received for this question</value>
    [DataMember(Name = "score", EmitDefaultValue = false)]
    public int? Score { get; private set; }



    /// <summary>
    /// True if this question was marked as NA
    /// </summary>
    /// <value>True if this question was marked as NA</value>
    [DataMember(Name = "markedNA", EmitDefaultValue = false)]
    public bool? MarkedNA { get; set; }



    /// <summary>
    /// If markedNA is true, systemMarkedNA indicates whether it was marked by a user or by the system due to visibility conditions. Always false if markedNA is false.
    /// </summary>
    /// <value>If markedNA is true, systemMarkedNA indicates whether it was marked by a user or by the system due to visibility conditions. Always false if markedNA is false.</value>
    [DataMember(Name = "systemMarkedNA", EmitDefaultValue = false)]
    public bool? SystemMarkedNA { get; set; }



    /// <summary>
    /// Answer for free text answer type
    /// </summary>
    /// <value>Answer for free text answer type</value>
    [DataMember(Name = "freeTextAnswer", EmitDefaultValue = false)]
    public string FreeTextAnswer { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AssessmentQuestionScore {\n");

        sb.Append("  FailedKillQuestion: ").Append(FailedKillQuestion).Append("\n");
        sb.Append("  Comments: ").Append(Comments).Append("\n");
        sb.Append("  QuestionId: ").Append(QuestionId).Append("\n");
        sb.Append("  AnswerId: ").Append(AnswerId).Append("\n");
        sb.Append("  Score: ").Append(Score).Append("\n");
        sb.Append("  MarkedNA: ").Append(MarkedNA).Append("\n");
        sb.Append("  SystemMarkedNA: ").Append(SystemMarkedNA).Append("\n");
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
        return Equals(obj as AssessmentQuestionScore);
    }

    /// <summary>
    /// Returns true if AssessmentQuestionScore instances are equal
    /// </summary>
    /// <param name="other">Instance of AssessmentQuestionScore to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AssessmentQuestionScore other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                FailedKillQuestion == other.FailedKillQuestion ||
                FailedKillQuestion != null &&
                FailedKillQuestion.Equals(other.FailedKillQuestion)
            ) &&
            (
                Comments == other.Comments ||
                Comments != null &&
                Comments.Equals(other.Comments)
            ) &&
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
            if (FailedKillQuestion != null)
            {
                hash = hash * 59 + FailedKillQuestion.GetHashCode();
            }

            if (Comments != null)
            {
                hash = hash * 59 + Comments.GetHashCode();
            }

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

            if (FreeTextAnswer != null)
            {
                hash = hash * 59 + FreeTextAnswer.GetHashCode();
            }

            return hash;
        }
    }
}
