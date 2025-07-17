using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class InsightsTrends
{
    /// <summary>
    /// List of trend data in the comparative period
    /// </summary>
    /// <value>List of trend data in the comparative period</value>
    public IEnumerable<TrendData> ComparativePeriod { get; set; }

    /// <summary>
    /// List of trend data in the primary period
    /// </summary>
    /// <value>List of trend data in the primary period</value>
    public IEnumerable<TrendData> PrimaryPeriod { get; set; }
}
