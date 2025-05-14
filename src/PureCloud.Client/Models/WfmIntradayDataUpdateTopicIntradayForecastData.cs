using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class WfmIntradayDataUpdateTopicIntradayForecastData
{
    /// <summary>
    /// Gets or Sets Offered
    /// </summary>
    public double? Offered { get; set; }

    /// <summary>
    /// Gets or Sets AverageTalkTimeSeconds
    /// </summary>
    public double? AverageTalkTimeSeconds { get; set; }

    /// <summary>
    /// Gets or Sets AverageAfterCallWorkSeconds
    /// </summary>
    public double? AverageAfterCallWorkSeconds { get; set; }
}
