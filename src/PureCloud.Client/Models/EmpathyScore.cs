using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// EmpathyScore
/// </summary>

public partial class EmpathyScore : IEquatable<EmpathyScore>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EmpathyScore" /> class.
    /// </summary>
    /// <param name="Score">Empathy score of the agent involved in the conversation.</param>
    /// <param name="UserId">UserId of the agent involved in the conversation.</param>
    public EmpathyScore(double? Score = null, string UserId = null)
    {
        this.Score = Score;
        this.UserId = UserId;

    }



    /// <summary>
    /// Empathy score of the agent involved in the conversation
    /// </summary>
    /// <value>Empathy score of the agent involved in the conversation</value>
    [JsonPropertyName("score")]
    public double? Score { get; set; }



    /// <summary>
    /// UserId of the agent involved in the conversation
    /// </summary>
    /// <value>UserId of the agent involved in the conversation</value>
    [JsonPropertyName("userId")]
    public string UserId { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class EmpathyScore {\n");

        sb.Append("  Score: ").Append(Score).Append("\n");
        sb.Append("  UserId: ").Append(UserId).Append("\n");
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
        return Equals(obj as EmpathyScore);
    }

    /// <summary>
    /// Returns true if EmpathyScore instances are equal
    /// </summary>
    /// <param name="other">Instance of EmpathyScore to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(EmpathyScore other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Score == other.Score ||
                Score != null &&
                Score.Equals(other.Score)
            ) &&
            (
                UserId == other.UserId ||
                UserId != null &&
                UserId.Equals(other.UserId)
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
            if (Score != null)
            {
                hash = hash * 59 + Score.GetHashCode();
            }

            if (UserId != null)
            {
                hash = hash * 59 + UserId.GetHashCode();
            }

            return hash;
        }
    }
}
