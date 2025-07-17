using System.Text;
using System.Text.Json.Serialization;
using PureCloud.Client.Models.Users;

namespace PureCloud.Client.Models;

public sealed class OverallBestPoints
{
    /// <summary>
    /// The requested division
    /// </summary>
    /// <value>The requested division</value>
    public Division Division { get; set; }

    /// <summary>
    /// List of gamification best point items
    /// </summary>
    /// <value>List of gamification best point items</value>
    public IEnumerable<OverallBestPointsItem> BestPoints { get; set; }

    /// <summary>
    /// The targeted performance profile for the average points
    /// </summary>
    /// <value>The targeted performance profile for the average points</value>
    public AddressableEntityRef PerformanceProfile { get; set; }
}
