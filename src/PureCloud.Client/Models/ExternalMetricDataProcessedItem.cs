using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ExternalMetricDataProcessedItem
{
    /// <summary>
    /// The type of the metric data. The default value is Total.
    /// </summary>
    /// <value>The type of the metric data. The default value is Total.</value>
    public ExternalMetricDataProcessedItemTypeEnum? Type { get; set; }

    /// <summary>
    /// The user ID. Must provide either userId or userEmail, but not both.
    /// </summary>
    /// <value>The user ID. Must provide either userId or userEmail, but not both.</value>
    public string UserId { get; set; }

    /// <summary>
    /// The user main email used in user&#39;s GenesysCloud account. Must provide either userId or userEmail, but not both.
    /// </summary>
    /// <value>The user main email used in user&#39;s GenesysCloud account. Must provide either userId or userEmail, but not both.</value>
    public string UserEmail { get; set; }

    /// <summary>
    /// The ID of the external metric definition
    /// </summary>
    /// <value>The ID of the external metric definition</value>
    public string MetricId { get; set; }

    /// <summary>
    /// The date of the metric data. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
    /// </summary>
    /// <value>The date of the metric data. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
    public string DateOccurred { get; set; }

    /// <summary>
    /// The value of the metric data. When value is null, the metric data will be deleted.
    /// </summary>
    /// <value>The value of the metric data. When value is null, the metric data will be deleted.</value>
    public double? Value { get; set; }

    /// <summary>
    /// The number of data points. The default value is 0 when type is Cumulative and the metric data already exists, otherwise 1. When total count reaches 0, the metric data will be deleted.
    /// </summary>
    /// <value>The number of data points. The default value is 0 when type is Cumulative and the metric data already exists, otherwise 1. When total count reaches 0, the metric data will be deleted.</value>
    public int? Count { get; set; }

    /// <summary>
    /// The total value of the metric data.
    /// </summary>
    /// <value>The total value of the metric data.</value>
    public double? TotalValue { get; set; }

    /// <summary>
    /// The total number of data points.
    /// </summary>
    /// <value>The total number of data points.</value>
    public int? TotalCount { get; set; }
}
