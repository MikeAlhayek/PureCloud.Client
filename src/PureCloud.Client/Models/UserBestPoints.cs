using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class UserBestPoints
{
    /// <summary>
    /// The requested user for the best points
    /// </summary>
    /// <value>The requested user for the best points</value>
    public UserReference User { get; set; }

    /// <summary>
    /// List of best point for the requested user
    /// </summary>
    /// <value>List of best point for the requested user</value>
    public IEnumerable<UserBestPointsItem> BestPoints { get; set; }

}
