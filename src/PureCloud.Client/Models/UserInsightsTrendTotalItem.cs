using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class UserInsightsTrendTotalItem
{
    /// <summary>
    /// Trends for the metric
    /// </summary>
    /// <value>Trends for the metric</value>
    public UserInsightsTrends Trends { get; set; }
}
