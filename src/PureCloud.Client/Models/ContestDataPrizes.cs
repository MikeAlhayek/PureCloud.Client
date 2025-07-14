using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ContestDataPrizes
{
    /// <summary>
    /// Tier of the prize
    /// </summary>
    /// <value>Tier of the prize</value>
    public int? Tier { get; set; }

    /// <summary>
    /// Name of the prize
    /// </summary>
    /// <value>Name of the prize</value>
    public string Name { get; set; }

    /// <summary>
    /// Id of the prize image
    /// </summary>
    /// <value>Id of the prize image</value>
    public string ImageId { get; set; }
}
