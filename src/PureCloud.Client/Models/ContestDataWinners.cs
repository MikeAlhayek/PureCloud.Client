using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ContestDataWinners
/// </summary>

public partial class ContestDataWinners : IEquatable<ContestDataWinners>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ContestDataWinners" /> class.
    /// </summary>
    /// <param name="Tier">Tier of the winners.</param>
    /// <param name="WinnersCount">Number of winners in this tier.</param>
    /// <param name="ContestScore">Number of winners in this tier.</param>
    /// <param name="Users">List of users in this tier.</param>
    public ContestDataWinners(int? Tier = null, int? WinnersCount = null, ContestCompleteDataScore ContestScore = null, List<ContestDataWinnersUsers> Users = null)
    {
        this.Tier = Tier;
        this.WinnersCount = WinnersCount;
        this.ContestScore = ContestScore;
        this.Users = Users;

    }



    /// <summary>
    /// Tier of the winners
    /// </summary>
    /// <value>Tier of the winners</value>
    [JsonPropertyName("tier")]
    public int? Tier { get; set; }



    /// <summary>
    /// Number of winners in this tier
    /// </summary>
    /// <value>Number of winners in this tier</value>
    [JsonPropertyName("winnersCount")]
    public int? WinnersCount { get; set; }



    /// <summary>
    /// Number of winners in this tier
    /// </summary>
    /// <value>Number of winners in this tier</value>
    [JsonPropertyName("contestScore")]
    public ContestCompleteDataScore ContestScore { get; set; }



    /// <summary>
    /// List of users in this tier
    /// </summary>
    /// <value>List of users in this tier</value>
    [JsonPropertyName("users")]
    public List<ContestDataWinnersUsers> Users { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ContestDataWinners {\n");

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
        return Equals(obj as ContestDataWinners);
    }

    /// <summary>
    /// Returns true if ContestDataWinners instances are equal
    /// </summary>
    /// <param name="other">Instance of ContestDataWinners to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ContestDataWinners other)
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
