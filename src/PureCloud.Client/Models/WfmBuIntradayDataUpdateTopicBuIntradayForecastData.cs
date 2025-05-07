using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class WfmBuIntradayDataUpdateTopicBuIntradayForecastData
{
    /// <summary>
    /// Gets or Sets Offered
    /// </summary>
    public double? Offered { get; set; }

    /// <summary>
    /// Gets or Sets AverageHandleTimeSeconds
    /// </summary>
    public double? AverageHandleTimeSeconds { get; set; }
}
