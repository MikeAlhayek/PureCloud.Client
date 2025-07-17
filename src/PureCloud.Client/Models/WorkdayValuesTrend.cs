using System.Text;
using System.Text.Json.Serialization;
using PureCloud.Client.Models.Users;

namespace PureCloud.Client.Models;

public sealed class WorkdayValuesTrend
{
    /// <summary>
    /// The start workday for the query range for the metric value trend. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
    /// </summary>
    /// <value>The start workday for the query range for the metric value trend. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
    public string DateStartWorkday { get; set; }

    /// <summary>
    /// The end workday for the query range for the metric value trend. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
    /// </summary>
    /// <value>The end workday for the query range for the metric value trend. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
    public string DateEndWorkday { get; set; }

    /// <summary>
    /// The reference workday used to determine the metric definition. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
    /// </summary>
    /// <value>The reference workday used to determine the metric definition. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
    public string DateReferenceWorkday { get; set; }

    /// <summary>
    /// The targeted division for the query
    /// </summary>
    /// <value>The targeted division for the query</value>
    public Division Division { get; set; }

    /// <summary>
    /// The targeted user for the query
    /// </summary>
    /// <value>The targeted user for the query</value>
    public UserReference User { get; set; }

    /// <summary>
    /// The time zone used for aggregating metric values
    /// </summary>
    /// <value>The time zone used for aggregating metric values</value>
    public string Timezone { get; set; }

    /// <summary>
    /// The metric value trends
    /// </summary>
    /// <value>The metric value trends</value>
    public IEnumerable<WorkdayValuesMetricItem> Results { get; set; }

    /// <summary>
    /// The targeted performance profile for the average points
    /// </summary>
    /// <value>The targeted performance profile for the average points</value>
    public AddressableEntityRef PerformanceProfile { get; set; }

    /// <summary>
    /// The targeted metric for the average points
    /// </summary>
    /// <value>The targeted metric for the average points</value>
    public AddressableEntityRef Metric { get; set; }
}
