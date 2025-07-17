using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class WorkdayPointsTrendItem
{
    /// <summary>
    /// workday date for the points trend. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
    /// </summary>
    /// <value>workday date for the points trend. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
    public string DateWorkday { get; set; }

    /// <summary>
    /// workday points for the date
    /// </summary>
    /// <value>workday points for the date</value>
    public double? Points { get; set; }
}
