using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ContestWinnersRequest
{
    /// <summary>
    /// The Contest Winner tier
    /// </summary>
    /// <value>The Contest Winner tier</value>
    public int? Tier { get; set; }

    /// <summary>
    /// The Contest Winner users at the tier
    /// </summary>
    /// <value>The Contest Winner users at the tier</value>
    public IEnumerable<string> UserIds { get; set; }
}
