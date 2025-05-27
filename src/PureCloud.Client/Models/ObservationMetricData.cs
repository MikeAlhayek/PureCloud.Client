using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ObservationMetricData
{
    /// <summary>
    /// Gets or Sets Metric
    /// </summary>
    public string Metric { get; set; }

    /// <summary>
    /// Gets or Sets Qualifier
    /// </summary>
    public string Qualifier { get; set; }

    /// <summary>
    /// Gets or Sets Stats
    /// </summary>
    public StatisticalSummary Stats { get; set; }

    /// <summary>
    /// Flag for a truncated list of observations. If truncated, the first half of the list of observations will contain the oldest observations and the second half the newest observations.
    /// </summary>
    /// <value>Flag for a truncated list of observations. If truncated, the first half of the list of observations will contain the oldest observations and the second half the newest observations.</value>
    public bool? Truncated { get; set; }

    /// <summary>
    /// List of observations sorted by timestamp in ascending order. This list may be truncated.
    /// </summary>
    /// <value>List of observations sorted by timestamp in ascending order. This list may be truncated.</value>
    public IEnumerable<ObservationValue> Observations { get; set; }
}
