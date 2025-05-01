using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// ContestRequesingParticipantDailyInfo
/// </summary>
[DataContract]
public partial class ContestRequesingParticipantDailyInfo : IEquatable<ContestRequesingParticipantDailyInfo>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ContestRequesingParticipantDailyInfo" /> class.
    /// </summary>
    /// <param name="DateWorkday">Workday of the contest info. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd.</param>
    /// <param name="ContestScore">The Contest score.</param>
    public ContestRequesingParticipantDailyInfo(string DateWorkday = null, ContestScoreRanked ContestScore = null)
    {
        this.DateWorkday = DateWorkday;
        this.ContestScore = ContestScore;

    }



    /// <summary>
    /// Workday of the contest info. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
    /// </summary>
    /// <value>Workday of the contest info. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
    [DataMember(Name = "dateWorkday", EmitDefaultValue = false)]
    public string DateWorkday { get; set; }



    /// <summary>
    /// The Contest score
    /// </summary>
    /// <value>The Contest score</value>
    [DataMember(Name = "contestScore", EmitDefaultValue = false)]
    public ContestScoreRanked ContestScore { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ContestRequesingParticipantDailyInfo {\n");

        sb.Append("  DateWorkday: ").Append(DateWorkday).Append("\n");
        sb.Append("  ContestScore: ").Append(ContestScore).Append("\n");
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
        return Equals(obj as ContestRequesingParticipantDailyInfo);
    }

    /// <summary>
    /// Returns true if ContestRequesingParticipantDailyInfo instances are equal
    /// </summary>
    /// <param name="other">Instance of ContestRequesingParticipantDailyInfo to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ContestRequesingParticipantDailyInfo other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                DateWorkday == other.DateWorkday ||
                DateWorkday != null &&
                DateWorkday.Equals(other.DateWorkday)
            ) &&
            (
                ContestScore == other.ContestScore ||
                ContestScore != null &&
                ContestScore.Equals(other.ContestScore)
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
            if (DateWorkday != null)
            {
                hash = hash * 59 + DateWorkday.GetHashCode();
            }

            if (ContestScore != null)
            {
                hash = hash * 59 + ContestScore.GetHashCode();
            }

            return hash;
        }
    }
}
