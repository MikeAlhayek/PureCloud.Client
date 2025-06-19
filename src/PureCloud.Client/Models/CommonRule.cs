using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class CommonRule
{
    /// <summary>
    /// The type of the rule.
    /// </summary>
    /// <value>The type of the rule.</value>
    public CommonRuleTypeEnum? Type { get; set; }

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
    public List<AlertNotification> Notifications { get; set; }

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
    /// Indicates if the rule is in alarm state.
    /// </summary>
    /// <value>Indicates if the rule is in alarm state.</value>
    public bool? InAlarm { get; set; }

    /// <summary>
    /// The entity that created the rule.
    /// </summary>
    /// <value>The entity that created the rule.</value>
    public UserReference User { get; set; }

    /// <summary>
    /// The current version number of the rule.
    /// </summary>
    /// <value>The current version number of the rule.</value>
    public int? Version { get; set; }

    /// <summary>
    /// The creation date of the rule when the rule was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The creation date of the rule when the rule was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateCreated { get; set; }

    /// <summary>
    /// The timestamp of the last update to the rule. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The timestamp of the last update to the rule. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateLastModified { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
