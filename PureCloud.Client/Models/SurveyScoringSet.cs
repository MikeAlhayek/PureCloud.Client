using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// SurveyScoringSet
/// </summary>
[DataContract]
public partial class SurveyScoringSet : IEquatable<SurveyScoringSet>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SurveyScoringSet" /> class.
    /// </summary>
    /// <param name="TotalScore">TotalScore.</param>
    /// <param name="NpsScore">NpsScore.</param>
    /// <param name="QuestionGroupScores">QuestionGroupScores.</param>
    public SurveyScoringSet(float? TotalScore = null, int? NpsScore = null, List<SurveyQuestionGroupScore> QuestionGroupScores = null)
    {
        this.TotalScore = TotalScore;
        this.NpsScore = NpsScore;
        this.QuestionGroupScores = QuestionGroupScores;

    }



    /// <summary>
    /// Gets or Sets TotalScore
    /// </summary>
    [DataMember(Name = "totalScore", EmitDefaultValue = false)]
    public float? TotalScore { get; set; }



    /// <summary>
    /// Gets or Sets NpsScore
    /// </summary>
    [DataMember(Name = "npsScore", EmitDefaultValue = false)]
    public int? NpsScore { get; set; }



    /// <summary>
    /// Gets or Sets QuestionGroupScores
    /// </summary>
    [DataMember(Name = "questionGroupScores", EmitDefaultValue = false)]
    public List<SurveyQuestionGroupScore> QuestionGroupScores { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class SurveyScoringSet {\n");

        sb.Append("  TotalScore: ").Append(TotalScore).Append("\n");
        sb.Append("  NpsScore: ").Append(NpsScore).Append("\n");
        sb.Append("  QuestionGroupScores: ").Append(QuestionGroupScores).Append("\n");
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
        return Equals(obj as SurveyScoringSet);
    }

    /// <summary>
    /// Returns true if SurveyScoringSet instances are equal
    /// </summary>
    /// <param name="other">Instance of SurveyScoringSet to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(SurveyScoringSet other)
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
                NpsScore == other.NpsScore ||
                NpsScore != null &&
                NpsScore.Equals(other.NpsScore)
            ) &&
            (
                QuestionGroupScores == other.QuestionGroupScores ||
                QuestionGroupScores != null &&
                QuestionGroupScores.SequenceEqual(other.QuestionGroupScores)
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

            if (NpsScore != null)
            {
                hash = hash * 59 + NpsScore.GetHashCode();
            }

            if (QuestionGroupScores != null)
            {
                hash = hash * 59 + QuestionGroupScores.GetHashCode();
            }

            return hash;
        }
    }
}
