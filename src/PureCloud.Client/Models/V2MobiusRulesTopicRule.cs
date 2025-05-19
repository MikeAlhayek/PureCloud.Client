using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class V2MobiusRulesTopicRule
{
    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    public V2MobiusRulesTopicRuleTypeEnum? Type { get; set; }

    /// <summary>
    /// Gets or Sets Action
    /// </summary>
    public V2MobiusRulesTopicRuleActionEnum? Action { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    public Guid? Id { get; set; }

    /// <summary>
    /// Gets or Sets UserId
    /// </summary>
    public Guid? UserId { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Notifications
    /// </summary>
    public IEnumerable<V2MobiusRulesTopicAlertNotification> Notifications { get; set; }

    /// <summary>
    /// Gets or Sets Conditions
    /// </summary>
    public V2MobiusRulesTopicCondition Conditions { get; set; }

    /// <summary>
    /// Gets or Sets Enabled
    /// </summary>
    public bool? Enabled { get; set; }

    /// <summary>
    /// Gets or Sets InAlarm
    /// </summary>
    public bool? InAlarm { get; set; }

    /// <summary>
    /// Gets or Sets DateCreated
    /// </summary>
    public DateTime? DateCreated { get; set; }

    /// <summary>
    /// Gets or Sets SendExitingAlarmNotification
    /// </summary>
    public bool? SendExitingAlarmNotification { get; set; }

    /// <summary>
    /// Gets or Sets WaitBetweenNotificationMs
    /// </summary>
    public long? WaitBetweenNotificationMs { get; set; }
}
