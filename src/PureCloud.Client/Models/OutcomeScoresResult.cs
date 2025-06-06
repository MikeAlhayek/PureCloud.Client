using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// OutcomeScoresResult
/// </summary>

public partial class OutcomeScoresResult : IEquatable<OutcomeScoresResult>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="OutcomeScoresResult" /> class.
    /// </summary>
    /// <param name="OutcomeScores">List of scored outcomes in the session..</param>
    public OutcomeScoresResult(List<OutcomeScore> OutcomeScores = null)
    {
        this.OutcomeScores = OutcomeScores;

    }



    /// <summary>
    /// List of scored outcomes in the session.
    /// </summary>
    /// <value>List of scored outcomes in the session.</value>
    [JsonPropertyName("outcomeScores")]
    public List<OutcomeScore> OutcomeScores { get; set; }



    /// <summary>
    /// Timestamp indicating the last time that the event was scored. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Timestamp indicating the last time that the event was scored. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("modifiedDate")]
    public DateTime? ModifiedDate { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class OutcomeScoresResult {\n");

        sb.Append("  OutcomeScores: ").Append(OutcomeScores).Append("\n");
        sb.Append("  ModifiedDate: ").Append(ModifiedDate).Append("\n");
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
        return Equals(obj as OutcomeScoresResult);
    }

    /// <summary>
    /// Returns true if OutcomeScoresResult instances are equal
    /// </summary>
    /// <param name="other">Instance of OutcomeScoresResult to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(OutcomeScoresResult other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                OutcomeScores == other.OutcomeScores ||
                OutcomeScores != null &&
                OutcomeScores.SequenceEqual(other.OutcomeScores)
            ) &&
            (
                ModifiedDate == other.ModifiedDate ||
                ModifiedDate != null &&
                ModifiedDate.Equals(other.ModifiedDate)
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
            if (OutcomeScores != null)
            {
                hash = hash * 59 + OutcomeScores.GetHashCode();
            }

            if (ModifiedDate != null)
            {
                hash = hash * 59 + ModifiedDate.GetHashCode();
            }

            return hash;
        }
    }
}
