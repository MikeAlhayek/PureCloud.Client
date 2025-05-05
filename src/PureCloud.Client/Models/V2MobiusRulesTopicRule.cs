using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// V2MobiusRulesTopicRule
/// </summary>

public partial class V2MobiusRulesTopicRule : IEquatable<V2MobiusRulesTopicRule>
{
    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    
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
    /// Gets or Sets Action
    /// </summary>
    
    public enum ActionEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Unknown for "UNKNOWN"
        /// </summary>
        [EnumMember(Value = "UNKNOWN")]
        Unknown,

        /// <summary>
        /// Enum Create for "CREATE"
        /// </summary>
        [EnumMember(Value = "CREATE")]
        Create,

        /// <summary>
        /// Enum Update for "UPDATE"
        /// </summary>
        [EnumMember(Value = "UPDATE")]
        Update,

        /// <summary>
        /// Enum Delete for "DELETE"
        /// </summary>
        [EnumMember(Value = "DELETE")]
        Delete
    }
    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [JsonPropertyName("type")]
    public TypeEnum? Type { get; set; }
    /// <summary>
    /// Gets or Sets Action
    /// </summary>
    [JsonPropertyName("action")]
    public ActionEnum? Action { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="V2MobiusRulesTopicRule" /> class.
    /// </summary>
    /// <param name="Id">Id.</param>
    /// <param name="UserId">UserId.</param>
    /// <param name="Name">Name.</param>
    /// <param name="Type">Type.</param>
    /// <param name="Notifications">Notifications.</param>
    /// <param name="Conditions">Conditions.</param>
    /// <param name="Enabled">Enabled.</param>
    /// <param name="InAlarm">InAlarm.</param>
    /// <param name="Action">Action.</param>
    /// <param name="DateCreated">DateCreated.</param>
    /// <param name="SendExitingAlarmNotification">SendExitingAlarmNotification.</param>
    /// <param name="WaitBetweenNotificationMs">WaitBetweenNotificationMs.</param>
    public V2MobiusRulesTopicRule(Guid? Id = null, Guid? UserId = null, string Name = null, TypeEnum? Type = null, List<V2MobiusRulesTopicAlertNotification> Notifications = null, V2MobiusRulesTopicCondition Conditions = null, bool? Enabled = null, bool? InAlarm = null, ActionEnum? Action = null, DateTime? DateCreated = null, bool? SendExitingAlarmNotification = null, long? WaitBetweenNotificationMs = null)
    {
        this.Id = Id;
        this.UserId = UserId;
        this.Name = Name;
        this.Type = Type;
        this.Notifications = Notifications;
        this.Conditions = Conditions;
        this.Enabled = Enabled;
        this.InAlarm = InAlarm;
        this.Action = Action;
        this.DateCreated = DateCreated;
        this.SendExitingAlarmNotification = SendExitingAlarmNotification;
        this.WaitBetweenNotificationMs = WaitBetweenNotificationMs;

    }



    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [JsonPropertyName("id")]
    public Guid? Id { get; set; }



    /// <summary>
    /// Gets or Sets UserId
    /// </summary>
    [JsonPropertyName("userId")]
    public Guid? UserId { get; set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }





    /// <summary>
    /// Gets or Sets Notifications
    /// </summary>
    [JsonPropertyName("notifications")]
    public List<V2MobiusRulesTopicAlertNotification> Notifications { get; set; }



    /// <summary>
    /// Gets or Sets Conditions
    /// </summary>
    [JsonPropertyName("conditions")]
    public V2MobiusRulesTopicCondition Conditions { get; set; }



    /// <summary>
    /// Gets or Sets Enabled
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }



    /// <summary>
    /// Gets or Sets InAlarm
    /// </summary>
    [JsonPropertyName("inAlarm")]
    public bool? InAlarm { get; set; }





    /// <summary>
    /// Gets or Sets DateCreated
    /// </summary>
    [JsonPropertyName("dateCreated")]
    public DateTime? DateCreated { get; set; }



    /// <summary>
    /// Gets or Sets SendExitingAlarmNotification
    /// </summary>
    [JsonPropertyName("sendExitingAlarmNotification")]
    public bool? SendExitingAlarmNotification { get; set; }



    /// <summary>
    /// Gets or Sets WaitBetweenNotificationMs
    /// </summary>
    [JsonPropertyName("waitBetweenNotificationMs")]
    public long? WaitBetweenNotificationMs { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class V2MobiusRulesTopicRule {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  UserId: ").Append(UserId).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  Notifications: ").Append(Notifications).Append("\n");
        sb.Append("  Conditions: ").Append(Conditions).Append("\n");
        sb.Append("  Enabled: ").Append(Enabled).Append("\n");
        sb.Append("  InAlarm: ").Append(InAlarm).Append("\n");
        sb.Append("  Action: ").Append(Action).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
        sb.Append("  SendExitingAlarmNotification: ").Append(SendExitingAlarmNotification).Append("\n");
        sb.Append("  WaitBetweenNotificationMs: ").Append(WaitBetweenNotificationMs).Append("\n");
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
        return Equals(obj as V2MobiusRulesTopicRule);
    }

    /// <summary>
    /// Returns true if V2MobiusRulesTopicRule instances are equal
    /// </summary>
    /// <param name="other">Instance of V2MobiusRulesTopicRule to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(V2MobiusRulesTopicRule other)
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
                UserId == other.UserId ||
                UserId != null &&
                UserId.Equals(other.UserId)
            ) &&
            (
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                Type == other.Type ||
                Type != null &&
                Type.Equals(other.Type)
            ) &&
            (
                Notifications == other.Notifications ||
                Notifications != null &&
                Notifications.SequenceEqual(other.Notifications)
            ) &&
            (
                Conditions == other.Conditions ||
                Conditions != null &&
                Conditions.Equals(other.Conditions)
            ) &&
            (
                Enabled == other.Enabled ||
                Enabled != null &&
                Enabled.Equals(other.Enabled)
            ) &&
            (
                InAlarm == other.InAlarm ||
                InAlarm != null &&
                InAlarm.Equals(other.InAlarm)
            ) &&
            (
                Action == other.Action ||
                Action != null &&
                Action.Equals(other.Action)
            ) &&
            (
                DateCreated == other.DateCreated ||
                DateCreated != null &&
                DateCreated.Equals(other.DateCreated)
            ) &&
            (
                SendExitingAlarmNotification == other.SendExitingAlarmNotification ||
                SendExitingAlarmNotification != null &&
                SendExitingAlarmNotification.Equals(other.SendExitingAlarmNotification)
            ) &&
            (
                WaitBetweenNotificationMs == other.WaitBetweenNotificationMs ||
                WaitBetweenNotificationMs != null &&
                WaitBetweenNotificationMs.Equals(other.WaitBetweenNotificationMs)
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

            if (UserId != null)
            {
                hash = hash * 59 + UserId.GetHashCode();
            }

            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
            }

            if (Notifications != null)
            {
                hash = hash * 59 + Notifications.GetHashCode();
            }

            if (Conditions != null)
            {
                hash = hash * 59 + Conditions.GetHashCode();
            }

            if (Enabled != null)
            {
                hash = hash * 59 + Enabled.GetHashCode();
            }

            if (InAlarm != null)
            {
                hash = hash * 59 + InAlarm.GetHashCode();
            }

            if (Action != null)
            {
                hash = hash * 59 + Action.GetHashCode();
            }

            if (DateCreated != null)
            {
                hash = hash * 59 + DateCreated.GetHashCode();
            }

            if (SendExitingAlarmNotification != null)
            {
                hash = hash * 59 + SendExitingAlarmNotification.GetHashCode();
            }

            if (WaitBetweenNotificationMs != null)
            {
                hash = hash * 59 + WaitBetweenNotificationMs.GetHashCode();
            }

            return hash;
        }
    }
}
