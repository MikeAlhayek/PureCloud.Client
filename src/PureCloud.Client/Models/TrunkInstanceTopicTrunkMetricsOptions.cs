using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class TrunkInstanceTopicTrunkMetricsOptions
{
    /// <summary>
    /// Gets or Sets ProxyAddress
    /// </summary>
    public string ProxyAddress { get; set; }

    /// <summary>
    /// Gets or Sets OptionState
    /// </summary>
    public bool? OptionState { get; set; }

    /// <summary>
    /// Gets or Sets OptionStateTime
    /// </summary>
    public DateTime? OptionStateTime { get; set; }

    /// <summary>
    /// Gets or Sets ErrorInfo
    /// </summary>
    public TrunkInstanceTopicTrunkErrorInfo ErrorInfo { get; set; }
}
