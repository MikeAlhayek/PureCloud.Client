using System.Text;
using System.Text.Json.Serialization;
using PureCloud.Client.Models.Users;

namespace PureCloud.Client.Models;

public sealed class SingleWorkdayAverageValues
{
    /// <summary>
    /// The targeted workday for average value query. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
    /// </summary>
    /// <value>The targeted workday for average value query. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
    public string DateWorkday { get; set; }

    /// <summary>
    /// The targeted division for the metrics
    /// </summary>
    /// <value>The targeted division for the metrics</value>
    public Division Division { get; set; }

    /// <summary>
    /// The targeted user for the metrics
    /// </summary>
    /// <value>The targeted user for the metrics</value>
    public UserReference User { get; set; }

    /// <summary>
    /// The time zone used for aggregating metric values
    /// </summary>
    /// <value>The time zone used for aggregating metric values</value>
    public string Timezone { get; set; }

    /// <summary>
    /// The metric value averages
    /// </summary>
    /// <value>The metric value averages</value>
    public IEnumerable<WorkdayValuesMetricItem> Results { get; set; }

    /// <summary>
    /// The targeted performance profile for the average points
    /// </summary>
    /// <value>The targeted performance profile for the average points</value>
    public AddressableEntityRef PerformanceProfile { get; set; }
}
