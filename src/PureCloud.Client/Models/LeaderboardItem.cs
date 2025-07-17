using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class LeaderboardItem
{
    /// <summary>
    /// The user object for this leaderboard rank
    /// </summary>
    /// <value>The user object for this leaderboard rank</value>
    public UserReference User { get; set; }

    /// <summary>
    /// The rank of the user
    /// </summary>
    /// <value>The rank of the user</value>
    public int? Rank { get; set; }

    /// <summary>
    /// The points collected by the user
    /// </summary>
    /// <value>The points collected by the user</value>
    public long? Points { get; set; }
}
