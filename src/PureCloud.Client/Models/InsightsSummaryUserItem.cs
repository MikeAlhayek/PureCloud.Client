using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class InsightsSummaryUserItem
{
    /// <summary>
    /// Queried user
    /// </summary>
    /// <value>Queried user</value>
    public UserReference User { get; set; }

    /// <summary>
    /// The list of insights data for each metric of the user
    /// </summary>
    /// <value>The list of insights data for each metric of the user</value>
    public IEnumerable<InsightsSummaryMetricItem> MetricData { get; set; }

    /// <summary>
    /// Overall insights data of the user
    /// </summary>
    /// <value>Overall insights data of the user</value>
    public InsightsSummaryOverallItem OverallData { get; set; }

    /// <summary>
    /// Ranking of the user
    /// </summary>
    /// <value>Ranking of the user</value>
    public int? Ranking { get; set; }
}
