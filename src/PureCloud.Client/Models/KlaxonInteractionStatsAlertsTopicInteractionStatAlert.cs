using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class KlaxonInteractionStatsAlertsTopicInteractionStatAlert
{
    /// <summary>
    /// Gets or Sets Dimension
    /// </summary>
    public KlaxonInteractionStatsAlertsTopicInteractionStatAlertDimensionEnum? Dimension { get; set; }

    /// <summary>
    /// Gets or Sets Metric
    /// </summary>
    public KlaxonInteractionStatsAlertsTopicInteractionStatAlertMetricEnum? Metric { get; set; }

    /// <summary>
    /// Gets or Sets MediaType
    /// </summary>
    public KlaxonInteractionStatsAlertsTopicInteractionStatAlertMediaTypeEnum? MediaType { get; set; }

    /// <summary>
    /// Gets or Sets NumericRange
    /// </summary>
    public KlaxonInteractionStatsAlertsTopicInteractionStatAlertNumericRangeEnum? NumericRange { get; set; }

    /// <summary>
    /// Gets or Sets Statistic
    /// </summary>
    public KlaxonInteractionStatsAlertsTopicInteractionStatAlertStatisticEnum? Statistic { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets RuleId
    /// </summary>
    public string RuleId { get; set; }

    /// <summary>
    /// Gets or Sets DimensionValue
    /// </summary>
    public string DimensionValue { get; set; }

    /// <summary>
    /// Gets or Sets DimensionValueName
    /// </summary>
    public string DimensionValueName { get; set; }

    /// <summary>
    /// Gets or Sets Value
    /// </summary>
    public double? Value { get; set; }

    /// <summary>
    /// Gets or Sets Unread
    /// </summary>
    public bool? Unread { get; set; }

    /// <summary>
    /// Gets or Sets StartDate
    /// </summary>
    public DateTime? StartDate { get; set; }

    /// <summary>
    /// Gets or Sets EndDate
    /// </summary>
    public DateTime? EndDate { get; set; }

    /// <summary>
    /// Gets or Sets NotificationUsers
    /// </summary>
    public IEnumerable<KlaxonInteractionStatsAlertsTopicNotificationUser> NotificationUsers { get; set; }

    /// <summary>
    /// Gets or Sets AlertTypes
    /// </summary>
    public IEnumerable<KlaxonInteractionStatsAlertsTopicInteractionStatAlertAlertTypesEnum> AlertTypes { get; set; }
}
