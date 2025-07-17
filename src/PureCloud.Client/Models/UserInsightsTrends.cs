using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class UserInsightsTrends
{
    /// <summary>
    /// List of trend data in the comparative period
    /// </summary>
    /// <value>List of trend data in the comparative period</value>
    public IEnumerable<UserTrendData> ComparativePeriod { get; set; }

    /// <summary>
    /// List of trend data in the primary period
    /// </summary>
    /// <value>List of trend data in the primary period</value>
    public IEnumerable<UserTrendData> PrimaryPeriod { get; set; }
}
