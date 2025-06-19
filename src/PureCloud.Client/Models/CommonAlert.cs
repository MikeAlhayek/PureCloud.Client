using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class CommonAlert
{
    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// The user who created the rule that triggered the alert.
    /// </summary>
    /// <value>The user who created the rule that triggered the alert.</value>
    public UserReference User { get; set; }

    /// <summary>
    /// The properties of the rule that triggered the alert.
    /// </summary>
    /// <value>The properties of the rule that triggered the alert.</value>
    public AlertRuleProperties Rule { get; set; }

    /// <summary>
    /// The collection of notification methods and the ids of users who were notified by those methods.
    /// </summary>
    /// <value>The collection of notification methods and the ids of users who were notified by those methods.</value>
    public IEnumerable<AlertNotification> Notifications { get; set; }

    /// <summary>
    /// The timestamp of when the alert was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The timestamp of when the alert was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateStart { get; set; }

    /// <summary>
    /// The timestamp of when the alert ended. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The timestamp of when the alert ended. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateEnd { get; set; }

    /// <summary>
    /// Indicates if an alert is currently active.
    /// </summary>
    /// <value>Indicates if an alert is currently active.</value>
    public bool? Active { get; set; }

    /// <summary>
    /// Indicates if an alert has not been read.
    /// </summary>
    /// <value>Indicates if an alert has not been read.</value>
    public bool? Unread { get; set; }

    /// <summary>
    /// The amount of time to wait between notification. Time is in milliseconds.
    /// </summary>
    /// <value>The amount of time to wait between notification. Time is in milliseconds.</value>
    public long? WaitBetweenNotificationMs { get; set; }

    /// <summary>
    /// Flag indicating if the alert is in a muted state.
    /// </summary>
    /// <value>Flag indicating if the alert is in a muted state.</value>
    public bool? Muted { get; set; }

    /// <summary>
    /// Flag indicating if the alert is in a snoozed state.
    /// </summary>
    /// <value>Flag indicating if the alert is in a snoozed state.</value>
    public bool? Snoozed { get; set; }

    /// <summary>
    /// Timestamp of when the mute status of the alert should end. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Timestamp of when the mute status of the alert should end. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateMutedUntil { get; set; }

    /// <summary>
    /// Timestamp of when the snooze status of the alert should end. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Timestamp of when the snooze status of the alert should end. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateSnoozedUntil { get; set; }

    /// <summary>
    /// The conditions that make up the rule.
    /// </summary>
    /// <value>The conditions that make up the rule.</value>
    public CommonRuleConditions Conditions { get; set; }

    /// <summary>
    /// The id of the conversation instance that caused the alert to trigger.
    /// </summary>
    /// <value>The id of the conversation instance that caused the alert to trigger.</value>
    public string ConversationId { get; set; }

    /// <summary>
    /// Summary of the alert status of the entities defined in the conditions.  Is set when rule has instance-based or team member based rule predicates
    /// </summary>
    /// <value>Summary of the alert status of the entities defined in the conditions.  Is set when rule has instance-based or team member based rule predicates</value>
    public AlertSummary AlertSummary { get; set; }

    /// <summary>
    /// Gets or Sets RuleUri
    /// </summary>
    public string RuleUri { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
