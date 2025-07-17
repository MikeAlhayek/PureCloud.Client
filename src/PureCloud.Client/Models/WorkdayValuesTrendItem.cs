using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class WorkdayValuesTrendItem
{
    /// <summary>
    /// The workday for the metric value. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
    /// </summary>
    /// <value>The workday for the metric value. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
    public string DateWorkday { get; set; }

    /// <summary>
    /// The metric value
    /// </summary>
    /// <value>The metric value</value>
    public double? Value { get; set; }
}
