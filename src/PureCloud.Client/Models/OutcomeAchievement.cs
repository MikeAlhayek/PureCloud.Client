using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// OutcomeAchievement
/// </summary>

public partial class OutcomeAchievement : IEquatable<OutcomeAchievement>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="OutcomeAchievement" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected OutcomeAchievement() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="OutcomeAchievement" /> class.
    /// </summary>
    /// <param name="Outcome">The outcome that was achieved. (required).</param>
    /// <param name="AchievedDate">Timestamp indicating when the outcome was achieved. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
    public OutcomeAchievement(AchievedOutcome Outcome = null, DateTime? AchievedDate = null)
    {
        this.Outcome = Outcome;
        this.AchievedDate = AchievedDate;

    }



    /// <summary>
    /// The outcome that was achieved.
    /// </summary>
    /// <value>The outcome that was achieved.</value>
    [JsonPropertyName("outcome")]
    public AchievedOutcome Outcome { get; set; }



    /// <summary>
    /// Timestamp indicating when the outcome was achieved. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Timestamp indicating when the outcome was achieved. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("achievedDate")]
    public DateTime? AchievedDate { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class OutcomeAchievement {\n");

        sb.Append("  Outcome: ").Append(Outcome).Append("\n");
        sb.Append("  AchievedDate: ").Append(AchievedDate).Append("\n");
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
        return Equals(obj as OutcomeAchievement);
    }

    /// <summary>
    /// Returns true if OutcomeAchievement instances are equal
    /// </summary>
    /// <param name="other">Instance of OutcomeAchievement to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(OutcomeAchievement other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Outcome == other.Outcome ||
                Outcome != null &&
                Outcome.Equals(other.Outcome)
            ) &&
            (
                AchievedDate == other.AchievedDate ||
                AchievedDate != null &&
                AchievedDate.Equals(other.AchievedDate)
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
            if (Outcome != null)
            {
                hash = hash * 59 + Outcome.GetHashCode();
            }

            if (AchievedDate != null)
            {
                hash = hash * 59 + AchievedDate.GetHashCode();
            }

            return hash;
        }
    }
}
