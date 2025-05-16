using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class TrunkInstanceTopicTrunkMetricsRegisters
{
    /// <summary>
    /// Gets or Sets ProxyAddress
    /// </summary>
    public string ProxyAddress { get; set; }

    /// <summary>
    /// Gets or Sets RegisterState
    /// </summary>
    public bool? RegisterState { get; set; }

    /// <summary>
    /// Gets or Sets RegisterStateTime
    /// </summary>
    public DateTime? RegisterStateTime { get; set; }

    /// <summary>
    /// Gets or Sets ErrorInfo
    /// </summary>
    public TrunkInstanceTopicTrunkErrorInfo ErrorInfo { get; set; }
}
