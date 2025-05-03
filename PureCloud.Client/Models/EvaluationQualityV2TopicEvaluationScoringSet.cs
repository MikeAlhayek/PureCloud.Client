using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// EvaluationQualityV2TopicEvaluationScoringSet
/// </summary>

public partial class EvaluationQualityV2TopicEvaluationScoringSet : IEquatable<EvaluationQualityV2TopicEvaluationScoringSet>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EvaluationQualityV2TopicEvaluationScoringSet" /> class.
    /// </summary>
    /// <param name="TotalScore">TotalScore.</param>
    /// <param name="TotalCriticalScore">TotalCriticalScore.</param>
    public EvaluationQualityV2TopicEvaluationScoringSet(long? TotalScore = null, long? TotalCriticalScore = null)
    {
        this.TotalScore = TotalScore;
        this.TotalCriticalScore = TotalCriticalScore;

    }



    /// <summary>
    /// Gets or Sets TotalScore
    /// </summary>
    [JsonPropertyName("totalScore")]
    public long? TotalScore { get; set; }



    /// <summary>
    /// Gets or Sets TotalCriticalScore
    /// </summary>
    [JsonPropertyName("totalCriticalScore")]
    public long? TotalCriticalScore { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class EvaluationQualityV2TopicEvaluationScoringSet {\n");

        sb.Append("  TotalScore: ").Append(TotalScore).Append("\n");
        sb.Append("  TotalCriticalScore: ").Append(TotalCriticalScore).Append("\n");
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
        return Equals(obj as EvaluationQualityV2TopicEvaluationScoringSet);
    }

    /// <summary>
    /// Returns true if EvaluationQualityV2TopicEvaluationScoringSet instances are equal
    /// </summary>
    /// <param name="other">Instance of EvaluationQualityV2TopicEvaluationScoringSet to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(EvaluationQualityV2TopicEvaluationScoringSet other)
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

            return hash;
        }
    }
}
