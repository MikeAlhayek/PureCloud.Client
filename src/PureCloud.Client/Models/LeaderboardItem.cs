using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// LeaderboardItem
/// </summary>

public partial class LeaderboardItem : IEquatable<LeaderboardItem>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="LeaderboardItem" /> class.
    /// </summary>
    public LeaderboardItem()
    {

    }



    /// <summary>
    /// The user object for this leaderboard rank
    /// </summary>
    /// <value>The user object for this leaderboard rank</value>
    [JsonPropertyName("user")]
    public UserReference User { get; private set; }



    /// <summary>
    /// The rank of the user
    /// </summary>
    /// <value>The rank of the user</value>
    [JsonPropertyName("rank")]
    public int? Rank { get; private set; }



    /// <summary>
    /// The points collected by the user
    /// </summary>
    /// <value>The points collected by the user</value>
    [JsonPropertyName("points")]
    public long? Points { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class LeaderboardItem {\n");

        sb.Append("  User: ").Append(User).Append("\n");
        sb.Append("  Rank: ").Append(Rank).Append("\n");
        sb.Append("  Points: ").Append(Points).Append("\n");
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
        return Equals(obj as LeaderboardItem);
    }

    /// <summary>
    /// Returns true if LeaderboardItem instances are equal
    /// </summary>
    /// <param name="other">Instance of LeaderboardItem to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(LeaderboardItem other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                User == other.User ||
                User != null &&
                User.Equals(other.User)
            ) &&
            (
                Rank == other.Rank ||
                Rank != null &&
                Rank.Equals(other.Rank)
            ) &&
            (
                Points == other.Points ||
                Points != null &&
                Points.Equals(other.Points)
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
            if (User != null)
            {
                hash = hash * 59 + User.GetHashCode();
            }

            if (Rank != null)
            {
                hash = hash * 59 + Rank.GetHashCode();
            }

            if (Points != null)
            {
                hash = hash * 59 + Points.GetHashCode();
            }

            return hash;
        }
    }
}
