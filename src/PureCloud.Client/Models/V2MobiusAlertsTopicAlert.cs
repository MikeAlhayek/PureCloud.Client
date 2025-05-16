using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class V2MobiusAlertsTopicAlert
{
    /// <summary>
    /// Gets or Sets Action
    /// </summary>
    public V2MobiusAlertsTopicAlertActionEnum? Action { get; set; }

    /// <summary>
    /// Gets or Sets Rule
    /// </summary>
    public V2MobiusAlertsTopicAlertRuleProperties Rule { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    public Guid? Id { get; set; }

    /// <summary>
    /// Gets or Sets UserId
    /// </summary>
    public Guid? UserId { get; set; }

    /// <summary>
    /// Gets or Sets Notifications
    /// </summary>
    public IEnumerable<V2MobiusAlertsTopicAlertNotification> Notifications { get; set; }

    /// <summary>
    /// Gets or Sets DateStart
    /// </summary>
    public DateTime? DateStart { get; set; }

    /// <summary>
    /// Gets or Sets DateEnd
    /// </summary>
    public DateTime? DateEnd { get; set; }

    /// <summary>
    /// Gets or Sets Conditions
    /// </summary>
    public V2MobiusAlertsTopicCondition Conditions { get; set; }

    /// <summary>
    /// Gets or Sets AdditionalProperties
    /// </summary>
    public Dictionary<string, string> AdditionalProperties { get; set; }

    /// <summary>
    /// Gets or Sets Active
    /// </summary>
    public bool? Active { get; set; }

    /// <summary>
    /// Gets or Sets Unread
    /// </summary>
    public bool? Unread { get; set; }

    /// <summary>
    /// Gets or Sets Muted
    /// </summary>
    public bool? Muted { get; set; }

    /// <summary>
    /// Gets or Sets Snoozed
    /// </summary>
    public bool? Snoozed { get; set; }

    /// <summary>
    /// Gets or Sets DateMutedUntil
    /// </summary>
    public DateTime? DateMutedUntil { get; set; }

    /// <summary>
    /// Gets or Sets DateSnoozedUntil
    /// </summary>
    public DateTime? DateSnoozedUntil { get; set; }

    /// <summary>
    /// Gets or Sets AlertSummary
    /// </summary>
    public V2MobiusAlertsTopicAlertSummary AlertSummary { get; set; }

    /// <summary>
    /// Gets or Sets SendExitingAlarmNotification
    /// </summary>
    public bool? SendExitingAlarmNotification { get; set; }
}
