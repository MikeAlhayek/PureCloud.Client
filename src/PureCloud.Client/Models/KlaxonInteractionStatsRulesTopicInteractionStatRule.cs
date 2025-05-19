using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class KlaxonInteractionStatsRulesTopicInteractionStatRule
{
    /// <summary>
    /// Gets or Sets Dimension
    /// </summary>
    public KlaxonInteractionStatsRulesTopicInteractionStatRuleDimensionEnum? Dimension { get; set; }

    /// <summary>
    /// Gets or Sets Metric
    /// </summary>
    public KlaxonInteractionStatsRulesTopicInteractionStatRuleMetricEnum? Metric { get; set; }

    /// <summary>
    /// Gets or Sets MediaType
    /// </summary>
    public KlaxonInteractionStatsRulesTopicInteractionStatRuleMediaTypeEnum? MediaType { get; set; }

    /// <summary>
    /// Gets or Sets NumericRange
    /// </summary>
    public KlaxonInteractionStatsRulesTopicInteractionStatRuleNumericRangeEnum? NumericRange { get; set; }

    /// <summary>
    /// Gets or Sets Statistic
    /// </summary>
    public KlaxonInteractionStatsRulesTopicInteractionStatRuleStatisticEnum? Statistic { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    public string Name { get; set; }

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
    /// Gets or Sets InAlarm
    /// </summary>
    public bool? InAlarm { get; set; }

    /// <summary>
    /// Gets or Sets Enabled
    /// </summary>
    public bool? Enabled { get; set; }

    /// <summary>
    /// Gets or Sets NotificationUsers
    /// </summary>
    public IEnumerable<KlaxonInteractionStatsRulesTopicNotificationUser> NotificationUsers { get; set; }

    /// <summary>
    /// Gets or Sets AlertTypes
    /// </summary>
    public IEnumerable<KlaxonInteractionStatsRulesTopicInteractionStatRuleAlertTypesEnum> AlertTypes { get; set; }
}
