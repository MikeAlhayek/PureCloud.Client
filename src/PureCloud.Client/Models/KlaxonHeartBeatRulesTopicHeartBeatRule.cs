using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class KlaxonHeartBeatRulesTopicHeartBeatRule
{
    /// <summary>
    /// Gets or Sets RuleType
    /// </summary>
    public KlaxonHeartBeatRulesTopicHeartBeatRuleRuleTypeEnum? RuleType { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets SenderId
    /// </summary>
    public string SenderId { get; set; }

    /// <summary>
    /// Gets or Sets HeartBeatTimeoutInMinutes
    /// </summary>
    public double? HeartBeatTimeoutInMinutes { get; set; }

    /// <summary>
    /// Gets or Sets Enabled
    /// </summary>
    public bool? Enabled { get; set; }

    /// <summary>
    /// Gets or Sets InAlarm
    /// </summary>
    public bool? InAlarm { get; set; }

    /// <summary>
    /// Gets or Sets NotificationUsers
    /// </summary>
    public IEnumerable<KlaxonHeartBeatRulesTopicNotificationUser> NotificationUsers { get; set; }

    /// <summary>
    /// Gets or Sets AlertTypes
    /// </summary>
    public IEnumerable<KlaxonHeartBeatRulesTopicHeartBeatRuleAlertTypesEnum> AlertTypes { get; set; }
}
