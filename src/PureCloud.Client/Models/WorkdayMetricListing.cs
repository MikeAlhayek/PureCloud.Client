using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class WorkdayMetricListing
{
    /// <summary>
    /// Gets or Sets Entities
    /// </summary>
    public IEnumerable<WorkdayMetric> Entities { get; set; }
}
