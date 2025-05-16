using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class TrunkInstanceTopicTrunkConnectedStatus
{
    /// <summary>
    /// Gets or Sets Connected
    /// </summary>
    public bool? Connected { get; set; }

    /// <summary>
    /// Gets or Sets ConnectedStateTime
    /// </summary>
    public DateTime? ConnectedStateTime { get; set; }
}
