using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ReportingInterval
{
    /// <summary>
    /// The granularity of the reporting interval period
    /// </summary>
    /// <value>The granularity of the reporting interval period</value>
    public ReportingIntervalIntervalTypeEnum? IntervalType { get; set; }

    /// <summary>
    /// The value of the reporting interval period for a given interval type
    /// </summary>
    /// <value>The value of the reporting interval period for a given interval type</value>
    public int? IntervalValue { get; set; }
}
