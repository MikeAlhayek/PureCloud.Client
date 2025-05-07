using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// CommonAlert
/// </summary>

public partial class CommonAlert : IEquatable<CommonAlert>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="CommonAlert" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected CommonAlert() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="CommonAlert" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="User">The user who created the rule that triggered the alert. (required).</param>
    /// <param name="Rule">The properties of the rule that triggered the alert. (required).</param>
    /// <param name="Notifications">The collection of notification methods and the ids of users who were notified by those methods. (required).</param>
    /// <param name="DateStart">The timestamp of when the alert was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
    /// <param name="DateEnd">The timestamp of when the alert ended. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="Active">Indicates if an alert is currently active. (required).</param>
    /// <param name="Unread">Indicates if an alert has not been read. (required).</param>
    /// <param name="WaitBetweenNotificationMs">The amount of time to wait between notification. Time is in milliseconds. (required).</param>
    /// <param name="Muted">Flag indicating if the alert is in a muted state. (required).</param>
    /// <param name="Snoozed">Flag indicating if the alert is in a snoozed state. (required).</param>
    /// <param name="DateMutedUntil">Timestamp of when the mute status of the alert should end. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
    /// <param name="DateSnoozedUntil">Timestamp of when the snooze status of the alert should end. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
    /// <param name="Conditions">The conditions that make up the rule. (required).</param>
    /// <param name="ConversationId">The id of the conversation instance that caused the alert to trigger..</param>
    /// <param name="AlertSummary">Summary of the alert status of the entities defined in the conditions.  Is set when rule has instance-based or team member based rule predicates.</param>
    /// <param name="RuleUri">RuleUri.</param>
    public CommonAlert(string Name = null, UserReference User = null, AlertRuleProperties Rule = null, List<AlertNotification> Notifications = null, DateTime? DateStart = null, DateTime? DateEnd = null, bool? Active = null, bool? Unread = null, long? WaitBetweenNotificationMs = null, bool? Muted = null, bool? Snoozed = null, DateTime? DateMutedUntil = null, DateTime? DateSnoozedUntil = null, CommonRuleConditions Conditions = null, string ConversationId = null, AlertSummary AlertSummary = null, string RuleUri = null)
    {
        this.Name = Name;
        this.User = User;
        this.Rule = Rule;
        this.Notifications = Notifications;
        this.DateStart = DateStart;
        this.DateEnd = DateEnd;
        this.Active = Active;
        this.Unread = Unread;
        this.WaitBetweenNotificationMs = WaitBetweenNotificationMs;
        this.Muted = Muted;
        this.Snoozed = Snoozed;
        this.DateMutedUntil = DateMutedUntil;
        this.DateSnoozedUntil = DateSnoozedUntil;
        this.Conditions = Conditions;
        this.ConversationId = ConversationId;
        this.AlertSummary = AlertSummary;
        this.RuleUri = RuleUri;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// The user who created the rule that triggered the alert.
    /// </summary>
    /// <value>The user who created the rule that triggered the alert.</value>
    [JsonPropertyName("user")]
    public UserReference User { get; set; }



    /// <summary>
    /// The properties of the rule that triggered the alert.
    /// </summary>
    /// <value>The properties of the rule that triggered the alert.</value>
    [JsonPropertyName("rule")]
    public AlertRuleProperties Rule { get; set; }



    /// <summary>
    /// The collection of notification methods and the ids of users who were notified by those methods.
    /// </summary>
    /// <value>The collection of notification methods and the ids of users who were notified by those methods.</value>
    [JsonPropertyName("notifications")]
    public List<AlertNotification> Notifications { get; set; }



    /// <summary>
    /// The timestamp of when the alert was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The timestamp of when the alert was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateStart")]
    public DateTime? DateStart { get; set; }



    /// <summary>
    /// The timestamp of when the alert ended. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The timestamp of when the alert ended. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateEnd")]
    public DateTime? DateEnd { get; set; }



    /// <summary>
    /// Indicates if an alert is currently active.
    /// </summary>
    /// <value>Indicates if an alert is currently active.</value>
    [JsonPropertyName("active")]
    public bool? Active { get; set; }



    /// <summary>
    /// Indicates if an alert has not been read.
    /// </summary>
    /// <value>Indicates if an alert has not been read.</value>
    [JsonPropertyName("unread")]
    public bool? Unread { get; set; }



    /// <summary>
    /// The amount of time to wait between notification. Time is in milliseconds.
    /// </summary>
    /// <value>The amount of time to wait between notification. Time is in milliseconds.</value>
    [JsonPropertyName("waitBetweenNotificationMs")]
    public long? WaitBetweenNotificationMs { get; set; }



    /// <summary>
    /// Flag indicating if the alert is in a muted state.
    /// </summary>
    /// <value>Flag indicating if the alert is in a muted state.</value>
    [JsonPropertyName("muted")]
    public bool? Muted { get; set; }



    /// <summary>
    /// Flag indicating if the alert is in a snoozed state.
    /// </summary>
    /// <value>Flag indicating if the alert is in a snoozed state.</value>
    [JsonPropertyName("snoozed")]
    public bool? Snoozed { get; set; }



    /// <summary>
    /// Timestamp of when the mute status of the alert should end. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Timestamp of when the mute status of the alert should end. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateMutedUntil")]
    public DateTime? DateMutedUntil { get; set; }



    /// <summary>
    /// Timestamp of when the snooze status of the alert should end. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Timestamp of when the snooze status of the alert should end. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateSnoozedUntil")]
    public DateTime? DateSnoozedUntil { get; set; }



    /// <summary>
    /// The conditions that make up the rule.
    /// </summary>
    /// <value>The conditions that make up the rule.</value>
    [JsonPropertyName("conditions")]
    public CommonRuleConditions Conditions { get; set; }



    /// <summary>
    /// The id of the conversation instance that caused the alert to trigger.
    /// </summary>
    /// <value>The id of the conversation instance that caused the alert to trigger.</value>
    [JsonPropertyName("conversationId")]
    public string ConversationId { get; set; }



    /// <summary>
    /// Summary of the alert status of the entities defined in the conditions.  Is set when rule has instance-based or team member based rule predicates
    /// </summary>
    /// <value>Summary of the alert status of the entities defined in the conditions.  Is set when rule has instance-based or team member based rule predicates</value>
    [JsonPropertyName("alertSummary")]
    public AlertSummary AlertSummary { get; set; }



    /// <summary>
    /// Gets or Sets RuleUri
    /// </summary>
    [JsonPropertyName("ruleUri")]
    public string RuleUri { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CommonAlert {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  User: ").Append(User).Append("\n");
        sb.Append("  Rule: ").Append(Rule).Append("\n");
        sb.Append("  Notifications: ").Append(Notifications).Append("\n");
        sb.Append("  DateStart: ").Append(DateStart).Append("\n");
        sb.Append("  DateEnd: ").Append(DateEnd).Append("\n");
        sb.Append("  Active: ").Append(Active).Append("\n");
        sb.Append("  Unread: ").Append(Unread).Append("\n");
        sb.Append("  WaitBetweenNotificationMs: ").Append(WaitBetweenNotificationMs).Append("\n");
        sb.Append("  Muted: ").Append(Muted).Append("\n");
        sb.Append("  Snoozed: ").Append(Snoozed).Append("\n");
        sb.Append("  DateMutedUntil: ").Append(DateMutedUntil).Append("\n");
        sb.Append("  DateSnoozedUntil: ").Append(DateSnoozedUntil).Append("\n");
        sb.Append("  Conditions: ").Append(Conditions).Append("\n");
        sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
        sb.Append("  AlertSummary: ").Append(AlertSummary).Append("\n");
        sb.Append("  RuleUri: ").Append(RuleUri).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }


    /// <summary>
    /// Returns true if objects are equal
    /// </summary>
    /// <param name="obj">Object to be compared</param>
    /// <returns>Boolean</returns>
    public override bool Equals(object obj)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        return Equals(obj as CommonAlert);
    }

    /// <summary>
    /// Returns true if CommonAlert instances are equal
    /// </summary>
    /// <param name="other">Instance of CommonAlert to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CommonAlert other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Id == other.Id ||
                Id != null &&
                Id.Equals(other.Id)
            ) &&
            (
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                User == other.User ||
                User != null &&
                User.Equals(other.User)
            ) &&
            (
                Rule == other.Rule ||
                Rule != null &&
                Rule.Equals(other.Rule)
            ) &&
            (
                Notifications == other.Notifications ||
                Notifications != null &&
                Notifications.SequenceEqual(other.Notifications)
            ) &&
            (
                DateStart == other.DateStart ||
                DateStart != null &&
                DateStart.Equals(other.DateStart)
            ) &&
            (
                DateEnd == other.DateEnd ||
                DateEnd != null &&
                DateEnd.Equals(other.DateEnd)
            ) &&
            (
                Active == other.Active ||
                Active != null &&
                Active.Equals(other.Active)
            ) &&
            (
                Unread == other.Unread ||
                Unread != null &&
                Unread.Equals(other.Unread)
            ) &&
            (
                WaitBetweenNotificationMs == other.WaitBetweenNotificationMs ||
                WaitBetweenNotificationMs != null &&
                WaitBetweenNotificationMs.Equals(other.WaitBetweenNotificationMs)
            ) &&
            (
                Muted == other.Muted ||
                Muted != null &&
                Muted.Equals(other.Muted)
            ) &&
            (
                Snoozed == other.Snoozed ||
                Snoozed != null &&
                Snoozed.Equals(other.Snoozed)
            ) &&
            (
                DateMutedUntil == other.DateMutedUntil ||
                DateMutedUntil != null &&
                DateMutedUntil.Equals(other.DateMutedUntil)
            ) &&
            (
                DateSnoozedUntil == other.DateSnoozedUntil ||
                DateSnoozedUntil != null &&
                DateSnoozedUntil.Equals(other.DateSnoozedUntil)
            ) &&
            (
                Conditions == other.Conditions ||
                Conditions != null &&
                Conditions.Equals(other.Conditions)
            ) &&
            (
                ConversationId == other.ConversationId ||
                ConversationId != null &&
                ConversationId.Equals(other.ConversationId)
            ) &&
            (
                AlertSummary == other.AlertSummary ||
                AlertSummary != null &&
                AlertSummary.Equals(other.AlertSummary)
            ) &&
            (
                RuleUri == other.RuleUri ||
                RuleUri != null &&
                RuleUri.Equals(other.RuleUri)
            ) &&
            (
                SelfUri == other.SelfUri ||
                SelfUri != null &&
                SelfUri.Equals(other.SelfUri)
            );
    }

    /// <summary>
    /// Gets the hash code
    /// </summary>
    /// <returns>Hash code</returns>
    public override int GetHashCode()
    {
        // credit: http://stackoverflow.com/a/263416/677735
        unchecked // Overflow is fine, just wrap
        {
            int hash = 41;
            // Suitable nullity checks etc, of course :)
            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (User != null)
            {
                hash = hash * 59 + User.GetHashCode();
            }

            if (Rule != null)
            {
                hash = hash * 59 + Rule.GetHashCode();
            }

            if (Notifications != null)
            {
                hash = hash * 59 + Notifications.GetHashCode();
            }

            if (DateStart != null)
            {
                hash = hash * 59 + DateStart.GetHashCode();
            }

            if (DateEnd != null)
            {
                hash = hash * 59 + DateEnd.GetHashCode();
            }

            if (Active != null)
            {
                hash = hash * 59 + Active.GetHashCode();
            }

            if (Unread != null)
            {
                hash = hash * 59 + Unread.GetHashCode();
            }

            if (WaitBetweenNotificationMs != null)
            {
                hash = hash * 59 + WaitBetweenNotificationMs.GetHashCode();
            }

            if (Muted != null)
            {
                hash = hash * 59 + Muted.GetHashCode();
            }

            if (Snoozed != null)
            {
                hash = hash * 59 + Snoozed.GetHashCode();
            }

            if (DateMutedUntil != null)
            {
                hash = hash * 59 + DateMutedUntil.GetHashCode();
            }

            if (DateSnoozedUntil != null)
            {
                hash = hash * 59 + DateSnoozedUntil.GetHashCode();
            }

            if (Conditions != null)
            {
                hash = hash * 59 + Conditions.GetHashCode();
            }

            if (ConversationId != null)
            {
                hash = hash * 59 + ConversationId.GetHashCode();
            }

            if (AlertSummary != null)
            {
                hash = hash * 59 + AlertSummary.GetHashCode();
            }

            if (RuleUri != null)
            {
                hash = hash * 59 + RuleUri.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
