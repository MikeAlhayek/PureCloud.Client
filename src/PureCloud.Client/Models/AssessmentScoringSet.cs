using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AssessmentScoringSet
/// </summary>

public partial class AssessmentScoringSet : IEquatable<AssessmentScoringSet>
{
    /// <summary>
    /// Gets or Sets FailureReasons
    /// </summary>
    
    public enum FailureReasonsEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Score for "Score"
        /// </summary>
        [EnumMember(Value = "Score")]
        Score,

        /// <summary>
        /// Enum Criticalscore for "CriticalScore"
        /// </summary>
        [EnumMember(Value = "CriticalScore")]
        Criticalscore,

        /// <summary>
        /// Enum Killquestion for "KillQuestion"
        /// </summary>
        [EnumMember(Value = "KillQuestion")]
        Killquestion
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="AssessmentScoringSet" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected AssessmentScoringSet() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="AssessmentScoringSet" /> class.
    /// </summary>
    /// <param name="QuestionGroupScores">The individual scores for each question group (required).</param>
    /// <param name="Comments">Comments provided for these answers..</param>
    /// <param name="AgentComments">Comments provided by agent..</param>
    public AssessmentScoringSet(List<AssessmentQuestionGroupScore> QuestionGroupScores = null, string Comments = null, string AgentComments = null)
    {
        this.QuestionGroupScores = QuestionGroupScores;
        this.Comments = Comments;
        this.AgentComments = AgentComments;

    }



    /// <summary>
    /// The total score of the answers
    /// </summary>
    /// <value>The total score of the answers</value>
    [JsonPropertyName("totalScore")]
    public float? TotalScore { get; set; }



    /// <summary>
    /// The total score for the critical questions
    /// </summary>
    /// <value>The total score for the critical questions</value>
    [JsonPropertyName("totalCriticalScore")]
    public float? TotalCriticalScore { get; set; }



    /// <summary>
    /// The total score for the non-critical questions
    /// </summary>
    /// <value>The total score for the non-critical questions</value>
    [JsonPropertyName("totalNonCriticalScore")]
    public float? TotalNonCriticalScore { get; set; }



    /// <summary>
    /// The individual scores for each question group
    /// </summary>
    /// <value>The individual scores for each question group</value>
    [JsonPropertyName("questionGroupScores")]
    public List<AssessmentQuestionGroupScore> QuestionGroupScores { get; set; }



    /// <summary>
    /// If the assessment was not passed, the reasons for failure.
    /// </summary>
    /// <value>If the assessment was not passed, the reasons for failure.</value>
    [JsonPropertyName("failureReasons")]
    public List<FailureReasonsEnum> FailureReasons { get; set; }



    /// <summary>
    /// Comments provided for these answers.
    /// </summary>
    /// <value>Comments provided for these answers.</value>
    [JsonPropertyName("comments")]
    public string Comments { get; set; }



    /// <summary>
    /// Comments provided by agent.
    /// </summary>
    /// <value>Comments provided by agent.</value>
    [JsonPropertyName("agentComments")]
    public string AgentComments { get; set; }



    /// <summary>
    /// True if the assessment was passed
    /// </summary>
    /// <value>True if the assessment was passed</value>
    [JsonPropertyName("isPassed")]
    public bool? IsPassed { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AssessmentScoringSet {\n");

        sb.Append("  TotalScore: ").Append(TotalScore).Append("\n");
        sb.Append("  TotalCriticalScore: ").Append(TotalCriticalScore).Append("\n");
        sb.Append("  TotalNonCriticalScore: ").Append(TotalNonCriticalScore).Append("\n");
        sb.Append("  QuestionGroupScores: ").Append(QuestionGroupScores).Append("\n");
        sb.Append("  FailureReasons: ").Append(FailureReasons).Append("\n");
        sb.Append("  Comments: ").Append(Comments).Append("\n");
        sb.Append("  AgentComments: ").Append(AgentComments).Append("\n");
        sb.Append("  IsPassed: ").Append(IsPassed).Append("\n");
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
        return Equals(obj as AssessmentScoringSet);
    }

    /// <summary>
    /// Returns true if AssessmentScoringSet instances are equal
    /// </summary>
    /// <param name="other">Instance of AssessmentScoringSet to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AssessmentScoringSet other)
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
                FailureReasons == other.FailureReasons ||
                FailureReasons != null &&
                FailureReasons.SequenceEqual(other.FailureReasons)
            ) &&
            (
                Comments == other.Comments ||
                Comments != null &&
                Comments.Equals(other.Comments)
            ) &&
            (
                AgentComments == other.AgentComments ||
                AgentComments != null &&
                AgentComments.Equals(other.AgentComments)
            ) &&
            (
                IsPassed == other.IsPassed ||
                IsPassed != null &&
                IsPassed.Equals(other.IsPassed)
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

            if (FailureReasons != null)
            {
                hash = hash * 59 + FailureReasons.GetHashCode();
            }

            if (Comments != null)
            {
                hash = hash * 59 + Comments.GetHashCode();
            }

            if (AgentComments != null)
            {
                hash = hash * 59 + AgentComments.GetHashCode();
            }

            if (IsPassed != null)
            {
                hash = hash * 59 + IsPassed.GetHashCode();
            }

            return hash;
        }
    }
}
