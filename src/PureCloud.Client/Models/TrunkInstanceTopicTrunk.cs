using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class TrunkInstanceTopicTrunk
{
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets ConnectedStatus
    /// </summary>
    public TrunkInstanceTopicTrunkConnectedStatus ConnectedStatus { get; set; }

    /// <summary>
    /// Gets or Sets OptionsStatus
    /// </summary>
    public IEnumerable<TrunkInstanceTopicTrunkMetricsOptions> OptionsStatus { get; set; }

    /// <summary>
    /// Gets or Sets RegistersStatus
    /// </summary>
    public IEnumerable<TrunkInstanceTopicTrunkMetricsRegisters> RegistersStatus { get; set; }

    /// <summary>
    /// Gets or Sets IpStatus
    /// </summary>
    public TrunkInstanceTopicTrunkMetricsNetworkTypeIp IpStatus { get; set; }
}
