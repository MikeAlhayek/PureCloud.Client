using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// CommonRule
/// </summary>

public partial class CommonRule : IEquatable<CommonRule>
{
    /// <summary>
    /// The type of the rule.
    /// </summary>
    /// <value>The type of the rule.</value>
    
    public enum TypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Conversationmetrics for "ConversationMetrics"
        /// </summary>
        [EnumMember(Value = "ConversationMetrics")]
        Conversationmetrics,

        /// <summary>
        /// Enum Userpresence for "UserPresence"
        /// </summary>
        [EnumMember(Value = "UserPresence")]
        Userpresence,

        /// <summary>
        /// Enum Workforcemanagement for "WorkforceManagement"
        /// </summary>
        [EnumMember(Value = "WorkforceManagement")]
        Workforcemanagement,

        /// <summary>
        /// Enum Operationalconsole for "OperationalConsole"
        /// </summary>
        [EnumMember(Value = "OperationalConsole")]
        Operationalconsole,

        /// <summary>
        /// Enum Unknown for "Unknown"
        /// </summary>
        [EnumMember(Value = "Unknown")]
        Unknown
    }
    /// <summary>
    /// The type of the rule.
    /// </summary>
    /// <value>The type of the rule.</value>
    [JsonPropertyName("type")]
    public TypeEnum? Type { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="CommonRule" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected CommonRule() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="CommonRule" /> class.
    /// </summary>
    /// <param name="Name">Name of the rule (required).</param>
    /// <param name="Description">The description of the rule..</param>
    /// <param name="Enabled">Indicates if the rule is enabled..</param>
    /// <param name="Notifications">The alert notification types to trigger when alarm state changes as well as the users they will be sent to..</param>
    /// <param name="SendExitingAlarmNotifications">Indicates if the alert will send a notification when it is closed..</param>
    /// <param name="WaitBetweenNotificationMs">The amount of time in milliseconds to wait between notification..</param>
    /// <param name="Conditions">The set of metric conditions that would trigger an alert..</param>
    /// <param name="Type">The type of the rule. (required).</param>
    /// <param name="InAlarm">Indicates if the rule is in alarm state..</param>
    /// <param name="User">The entity that created the rule..</param>
    /// <param name="Version">The current version number of the rule..</param>
    /// <param name="DateCreated">The creation date of the rule when the rule was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="DateLastModified">The timestamp of the last update to the rule. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    public CommonRule(string Name = null, string Description = null, bool? Enabled = null, List<AlertNotification> Notifications = null, bool? SendExitingAlarmNotifications = null, long? WaitBetweenNotificationMs = null, CommonRuleConditions Conditions = null, TypeEnum? Type = null, bool? InAlarm = null, UserReference User = null, int? Version = null, DateTime? DateCreated = null, DateTime? DateLastModified = null)
    {
        this.Name = Name;
        this.Description = Description;
        this.Enabled = Enabled;
        this.Notifications = Notifications;
        this.SendExitingAlarmNotifications = SendExitingAlarmNotifications;
        this.WaitBetweenNotificationMs = WaitBetweenNotificationMs;
        this.Conditions = Conditions;
        this.Type = Type;
        this.InAlarm = InAlarm;
        this.User = User;
        this.Version = Version;
        this.DateCreated = DateCreated;
        this.DateLastModified = DateLastModified;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// Name of the rule
    /// </summary>
    /// <value>Name of the rule</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// The description of the rule.
    /// </summary>
    /// <value>The description of the rule.</value>
    [JsonPropertyName("description")]
    public string Description { get; set; }



    /// <summary>
    /// Indicates if the rule is enabled.
    /// </summary>
    /// <value>Indicates if the rule is enabled.</value>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }



    /// <summary>
    /// The alert notification types to trigger when alarm state changes as well as the users they will be sent to.
    /// </summary>
    /// <value>The alert notification types to trigger when alarm state changes as well as the users they will be sent to.</value>
    [JsonPropertyName("notifications")]
    public List<AlertNotification> Notifications { get; set; }



    /// <summary>
    /// Indicates if the alert will send a notification when it is closed.
    /// </summary>
    /// <value>Indicates if the alert will send a notification when it is closed.</value>
    [JsonPropertyName("sendExitingAlarmNotifications")]
    public bool? SendExitingAlarmNotifications { get; set; }



    /// <summary>
    /// The amount of time in milliseconds to wait between notification.
    /// </summary>
    /// <value>The amount of time in milliseconds to wait between notification.</value>
    [JsonPropertyName("waitBetweenNotificationMs")]
    public long? WaitBetweenNotificationMs { get; set; }



    /// <summary>
    /// The set of metric conditions that would trigger an alert.
    /// </summary>
    /// <value>The set of metric conditions that would trigger an alert.</value>
    [JsonPropertyName("conditions")]
    public CommonRuleConditions Conditions { get; set; }





    /// <summary>
    /// Indicates if the rule is in alarm state.
    /// </summary>
    /// <value>Indicates if the rule is in alarm state.</value>
    [JsonPropertyName("inAlarm")]
    public bool? InAlarm { get; set; }



    /// <summary>
    /// The entity that created the rule.
    /// </summary>
    /// <value>The entity that created the rule.</value>
    [JsonPropertyName("user")]
    public UserReference User { get; set; }



    /// <summary>
    /// The current version number of the rule.
    /// </summary>
    /// <value>The current version number of the rule.</value>
    [JsonPropertyName("version")]
    public int? Version { get; set; }



    /// <summary>
    /// The creation date of the rule when the rule was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The creation date of the rule when the rule was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateCreated")]
    public DateTime? DateCreated { get; set; }



    /// <summary>
    /// The timestamp of the last update to the rule. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The timestamp of the last update to the rule. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateLastModified")]
    public DateTime? DateLastModified { get; set; }



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
        sb.Append("class CommonRule {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  Enabled: ").Append(Enabled).Append("\n");
        sb.Append("  Notifications: ").Append(Notifications).Append("\n");
        sb.Append("  SendExitingAlarmNotifications: ").Append(SendExitingAlarmNotifications).Append("\n");
        sb.Append("  WaitBetweenNotificationMs: ").Append(WaitBetweenNotificationMs).Append("\n");
        sb.Append("  Conditions: ").Append(Conditions).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  InAlarm: ").Append(InAlarm).Append("\n");
        sb.Append("  User: ").Append(User).Append("\n");
        sb.Append("  Version: ").Append(Version).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
        sb.Append("  DateLastModified: ").Append(DateLastModified).Append("\n");
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
        return Equals(obj as CommonRule);
    }

    /// <summary>
    /// Returns true if CommonRule instances are equal
    /// </summary>
    /// <param name="other">Instance of CommonRule to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CommonRule other)
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
                Description == other.Description ||
                Description != null &&
                Description.Equals(other.Description)
            ) &&
            (
                Enabled == other.Enabled ||
                Enabled != null &&
                Enabled.Equals(other.Enabled)
            ) &&
            (
                Notifications == other.Notifications ||
                Notifications != null &&
                Notifications.SequenceEqual(other.Notifications)
            ) &&
            (
                SendExitingAlarmNotifications == other.SendExitingAlarmNotifications ||
                SendExitingAlarmNotifications != null &&
                SendExitingAlarmNotifications.Equals(other.SendExitingAlarmNotifications)
            ) &&
            (
                WaitBetweenNotificationMs == other.WaitBetweenNotificationMs ||
                WaitBetweenNotificationMs != null &&
                WaitBetweenNotificationMs.Equals(other.WaitBetweenNotificationMs)
            ) &&
            (
                Conditions == other.Conditions ||
                Conditions != null &&
                Conditions.Equals(other.Conditions)
            ) &&
            (
                Type == other.Type ||
                Type != null &&
                Type.Equals(other.Type)
            ) &&
            (
                InAlarm == other.InAlarm ||
                InAlarm != null &&
                InAlarm.Equals(other.InAlarm)
            ) &&
            (
                User == other.User ||
                User != null &&
                User.Equals(other.User)
            ) &&
            (
                Version == other.Version ||
                Version != null &&
                Version.Equals(other.Version)
            ) &&
            (
                DateCreated == other.DateCreated ||
                DateCreated != null &&
                DateCreated.Equals(other.DateCreated)
            ) &&
            (
                DateLastModified == other.DateLastModified ||
                DateLastModified != null &&
                DateLastModified.Equals(other.DateLastModified)
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

            if (Description != null)
            {
                hash = hash * 59 + Description.GetHashCode();
            }

            if (Enabled != null)
            {
                hash = hash * 59 + Enabled.GetHashCode();
            }

            if (Notifications != null)
            {
                hash = hash * 59 + Notifications.GetHashCode();
            }

            if (SendExitingAlarmNotifications != null)
            {
                hash = hash * 59 + SendExitingAlarmNotifications.GetHashCode();
            }

            if (WaitBetweenNotificationMs != null)
            {
                hash = hash * 59 + WaitBetweenNotificationMs.GetHashCode();
            }

            if (Conditions != null)
            {
                hash = hash * 59 + Conditions.GetHashCode();
            }

            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
            }

            if (InAlarm != null)
            {
                hash = hash * 59 + InAlarm.GetHashCode();
            }

            if (User != null)
            {
                hash = hash * 59 + User.GetHashCode();
            }

            if (Version != null)
            {
                hash = hash * 59 + Version.GetHashCode();
            }

            if (DateCreated != null)
            {
                hash = hash * 59 + DateCreated.GetHashCode();
            }

            if (DateLastModified != null)
            {
                hash = hash * 59 + DateLastModified.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
