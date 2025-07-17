using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ContestPrizes
{
    /// <summary>
    /// The Contest Prize tier
    /// </summary>
    /// <value>The Contest Prize tier</value>
    public int? Tier { get; set; }

    /// <summary>
    /// The Contest Prize name
    /// </summary>
    /// <value>The Contest Prize name</value>
    public string Name { get; set; }

    /// <summary>
    /// The Contest Prize description
    /// </summary>
    /// <value>The Contest Prize description</value>
    public string Description { get; set; }

    /// <summary>
    /// The Contest Prize image id
    /// </summary>
    /// <value>The Contest Prize image id</value>
    public string ImageId { get; set; }

    /// <summary>
    /// The Contest Prize image url
    /// </summary>
    /// <value>The Contest Prize image url</value>
    public string ImageUrl { get; set; }

    /// <summary>
    /// The Contest Prize winner Count
    /// </summary>
    /// <value>The Contest Prize winner Count</value>
    public int? WinnersCount { get; set; }
}
