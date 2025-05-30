using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// OutlierInfo
/// </summary>

public partial class OutlierInfo : IEquatable<OutlierInfo>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="OutlierInfo" /> class.
    /// </summary>
    /// <param name="Outlier">Boolean to identify if an outlier or not..</param>
    /// <param name="Score">Outlier score for this utterance. The score is always 0 or greater and higher the score, the more outlier..</param>
    public OutlierInfo(bool? Outlier = null, float? Score = null)
    {
        this.Outlier = Outlier;
        this.Score = Score;

    }



    /// <summary>
    /// Boolean to identify if an outlier or not.
    /// </summary>
    /// <value>Boolean to identify if an outlier or not.</value>
    [JsonPropertyName("outlier")]
    public bool? Outlier { get; set; }



    /// <summary>
    /// Outlier score for this utterance. The score is always 0 or greater and higher the score, the more outlier.
    /// </summary>
    /// <value>Outlier score for this utterance. The score is always 0 or greater and higher the score, the more outlier.</value>
    [JsonPropertyName("score")]
    public float? Score { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class OutlierInfo {\n");

        sb.Append("  Outlier: ").Append(Outlier).Append("\n");
        sb.Append("  Score: ").Append(Score).Append("\n");
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
        return Equals(obj as OutlierInfo);
    }

    /// <summary>
    /// Returns true if OutlierInfo instances are equal
    /// </summary>
    /// <param name="other">Instance of OutlierInfo to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(OutlierInfo other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Outlier == other.Outlier ||
                Outlier != null &&
                Outlier.Equals(other.Outlier)
            ) &&
            (
                Score == other.Score ||
                Score != null &&
                Score.Equals(other.Score)
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
            if (Outlier != null)
            {
                hash = hash * 59 + Outlier.GetHashCode();
            }

            if (Score != null)
            {
                hash = hash * 59 + Score.GetHashCode();
            }

            return hash;
        }
    }
}
