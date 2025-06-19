using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ModifiableRuleProperties
{
    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    public string Id { get; set; }

    /// <summary>
    /// Name of the rule
    /// </summary>
    /// <value>Name of the rule</value>
    public string Name { get; set; }

    /// <summary>
    /// The description of the rule.
    /// </summary>
    /// <value>The description of the rule.</value>
    public string Description { get; set; }

    /// <summary>
    /// Indicates if the rule is enabled.
    /// </summary>
    /// <value>Indicates if the rule is enabled.</value>
    public bool? Enabled { get; set; }

    /// <summary>
    /// The alert notification types to trigger when alarm state changes as well as the users they will be sent to.
    /// </summary>
    /// <value>The alert notification types to trigger when alarm state changes as well as the users they will be sent to.</value>
    public IEnumerable<AlertNotification> Notifications { get; set; }

    /// <summary>
    /// Indicates if the alert will send a notification when it is closed.
    /// </summary>
    /// <value>Indicates if the alert will send a notification when it is closed.</value>
    public bool? SendExitingAlarmNotifications { get; set; }

    /// <summary>
    /// The amount of time in milliseconds to wait between notification.
    /// </summary>
    /// <value>The amount of time in milliseconds to wait between notification.</value>
    public long? WaitBetweenNotificationMs { get; set; }

    /// <summary>
    /// The set of metric conditions that would trigger an alert.
    /// </summary>
    /// <value>The set of metric conditions that would trigger an alert.</value>
    public CommonRuleConditions Conditions { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
