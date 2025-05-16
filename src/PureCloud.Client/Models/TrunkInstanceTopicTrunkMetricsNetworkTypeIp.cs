using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class TrunkInstanceTopicTrunkMetricsNetworkTypeIp
{
    /// <summary>
    /// Gets or Sets Address
    /// </summary>
    public string Address { get; set; }

    /// <summary>
    /// Gets or Sets ErrorInfo
    /// </summary>
    public TrunkInstanceTopicTrunkErrorInfo ErrorInfo { get; set; }
}
