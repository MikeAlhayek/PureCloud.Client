using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// V2WemEngagementCelebrationUpdatesTopicContestWinners
/// </summary>
[DataContract]
public partial class V2WemEngagementCelebrationUpdatesTopicContestWinners : IEquatable<V2WemEngagementCelebrationUpdatesTopicContestWinners>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="V2WemEngagementCelebrationUpdatesTopicContestWinners" /> class.
    /// </summary>
    /// <param name="Tier">Tier.</param>
    /// <param name="WinnersCount">WinnersCount.</param>
    /// <param name="ContestScore">ContestScore.</param>
    /// <param name="Users">Users.</param>
    public V2WemEngagementCelebrationUpdatesTopicContestWinners(long? Tier = null, long? WinnersCount = null, V2WemEngagementCelebrationUpdatesTopicContestWinnersScore ContestScore = null, List<V2WemEngagementCelebrationUpdatesTopicContestWinnersUsers> Users = null)
    {
        this.Tier = Tier;
        this.WinnersCount = WinnersCount;
        this.ContestScore = ContestScore;
        this.Users = Users;

    }



    /// <summary>
    /// Gets or Sets Tier
    /// </summary>
    [DataMember(Name = "tier", EmitDefaultValue = false)]
    public long? Tier { get; set; }



    /// <summary>
    /// Gets or Sets WinnersCount
    /// </summary>
    [DataMember(Name = "winnersCount", EmitDefaultValue = false)]
    public long? WinnersCount { get; set; }



    /// <summary>
    /// Gets or Sets ContestScore
    /// </summary>
    [DataMember(Name = "contestScore", EmitDefaultValue = false)]
    public V2WemEngagementCelebrationUpdatesTopicContestWinnersScore ContestScore { get; set; }



    /// <summary>
    /// Gets or Sets Users
    /// </summary>
    [DataMember(Name = "users", EmitDefaultValue = false)]
    public List<V2WemEngagementCelebrationUpdatesTopicContestWinnersUsers> Users { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class V2WemEngagementCelebrationUpdatesTopicContestWinners {\n");

        sb.Append("  Tier: ").Append(Tier).Append("\n");
        sb.Append("  WinnersCount: ").Append(WinnersCount).Append("\n");
        sb.Append("  ContestScore: ").Append(ContestScore).Append("\n");
        sb.Append("  Users: ").Append(Users).Append("\n");
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
        return Equals(obj as V2WemEngagementCelebrationUpdatesTopicContestWinners);
    }

    /// <summary>
    /// Returns true if V2WemEngagementCelebrationUpdatesTopicContestWinners instances are equal
    /// </summary>
    /// <param name="other">Instance of V2WemEngagementCelebrationUpdatesTopicContestWinners to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(V2WemEngagementCelebrationUpdatesTopicContestWinners other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Tier == other.Tier ||
                Tier != null &&
                Tier.Equals(other.Tier)
            ) &&
            (
                WinnersCount == other.WinnersCount ||
                WinnersCount != null &&
                WinnersCount.Equals(other.WinnersCount)
            ) &&
            (
                ContestScore == other.ContestScore ||
                ContestScore != null &&
                ContestScore.Equals(other.ContestScore)
            ) &&
            (
                Users == other.Users ||
                Users != null &&
                Users.SequenceEqual(other.Users)
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
            if (Tier != null)
            {
                hash = hash * 59 + Tier.GetHashCode();
            }

            if (WinnersCount != null)
            {
                hash = hash * 59 + WinnersCount.GetHashCode();
            }

            if (ContestScore != null)
            {
                hash = hash * 59 + ContestScore.GetHashCode();
            }

            if (Users != null)
            {
                hash = hash * 59 + Users.GetHashCode();
            }

            return hash;
        }
    }
}
