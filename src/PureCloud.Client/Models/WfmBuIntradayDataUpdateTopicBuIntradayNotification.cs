using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class WfmBuIntradayDataUpdateTopicBuIntradayNotification
{
    /// <summary>
    /// Gets or Sets OperationId
    /// </summary>
    public string OperationId { get; set; }

    /// <summary>
    /// Gets or Sets Result
    /// </summary>
    public WfmBuIntradayDataUpdateTopicBuIntradayResult Result { get; set; }
}
