using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// V2MobiusAlertsTopicAlert
/// </summary>
[DataContract]
public partial class V2MobiusAlertsTopicAlert : IEquatable<V2MobiusAlertsTopicAlert>
{
    /// <summary>
    /// Gets or Sets Action
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
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
        Delete,

        /// <summary>
        /// Enum Close for "CLOSE"
        /// </summary>
        [EnumMember(Value = "CLOSE")]
        Close,

        /// <summary>
        /// Enum Renotify for "RENOTIFY"
        /// </summary>
        [EnumMember(Value = "RENOTIFY")]
        Renotify,

        /// <summary>
        /// Enum BulkDelete for "BULK_DELETE"
        /// </summary>
        [EnumMember(Value = "BULK_DELETE")]
        BulkDelete,

        /// <summary>
        /// Enum BulkUpdate for "BULK_UPDATE"
        /// </summary>
        [EnumMember(Value = "BULK_UPDATE")]
        BulkUpdate,

        /// <summary>
        /// Enum UnreadCountUpdate for "UNREAD_COUNT_UPDATE"
        /// </summary>
        [EnumMember(Value = "UNREAD_COUNT_UPDATE")]
        UnreadCountUpdate
    }
    /// <summary>
    /// Gets or Sets Action
    /// </summary>
    [DataMember(Name = "action", EmitDefaultValue = false)]
    public ActionEnum? Action { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="V2MobiusAlertsTopicAlert" /> class.
    /// </summary>
    /// <param name="Rule">Rule.</param>
    /// <param name="Id">Id.</param>
    /// <param name="UserId">UserId.</param>
    /// <param name="Notifications">Notifications.</param>
    /// <param name="DateStart">DateStart.</param>
    /// <param name="DateEnd">DateEnd.</param>
    /// <param name="Conditions">Conditions.</param>
    /// <param name="AdditionalProperties">AdditionalProperties.</param>
    /// <param name="Active">Active.</param>
    /// <param name="Unread">Unread.</param>
    /// <param name="Muted">Muted.</param>
    /// <param name="Snoozed">Snoozed.</param>
    /// <param name="DateMutedUntil">DateMutedUntil.</param>
    /// <param name="DateSnoozedUntil">DateSnoozedUntil.</param>
    /// <param name="Action">Action.</param>
    /// <param name="AlertSummary">AlertSummary.</param>
    /// <param name="SendExitingAlarmNotification">SendExitingAlarmNotification.</param>
    public V2MobiusAlertsTopicAlert(V2MobiusAlertsTopicAlertRuleProperties Rule = null, Guid? Id = null, Guid? UserId = null, List<V2MobiusAlertsTopicAlertNotification> Notifications = null, DateTime? DateStart = null, DateTime? DateEnd = null, V2MobiusAlertsTopicCondition Conditions = null, Dictionary<string, string> AdditionalProperties = null, bool? Active = null, bool? Unread = null, bool? Muted = null, bool? Snoozed = null, DateTime? DateMutedUntil = null, DateTime? DateSnoozedUntil = null, ActionEnum? Action = null, V2MobiusAlertsTopicAlertSummary AlertSummary = null, bool? SendExitingAlarmNotification = null)
    {
        this.Rule = Rule;
        this.Id = Id;
        this.UserId = UserId;
        this.Notifications = Notifications;
        this.DateStart = DateStart;
        this.DateEnd = DateEnd;
        this.Conditions = Conditions;
        this.AdditionalProperties = AdditionalProperties;
        this.Active = Active;
        this.Unread = Unread;
        this.Muted = Muted;
        this.Snoozed = Snoozed;
        this.DateMutedUntil = DateMutedUntil;
        this.DateSnoozedUntil = DateSnoozedUntil;
        this.Action = Action;
        this.AlertSummary = AlertSummary;
        this.SendExitingAlarmNotification = SendExitingAlarmNotification;

    }



    /// <summary>
    /// Gets or Sets Rule
    /// </summary>
    [DataMember(Name = "rule", EmitDefaultValue = false)]
    public V2MobiusAlertsTopicAlertRuleProperties Rule { get; set; }



    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public Guid? Id { get; set; }



    /// <summary>
    /// Gets or Sets UserId
    /// </summary>
    [DataMember(Name = "userId", EmitDefaultValue = false)]
    public Guid? UserId { get; set; }



    /// <summary>
    /// Gets or Sets Notifications
    /// </summary>
    [DataMember(Name = "notifications", EmitDefaultValue = false)]
    public List<V2MobiusAlertsTopicAlertNotification> Notifications { get; set; }



    /// <summary>
    /// Gets or Sets DateStart
    /// </summary>
    [DataMember(Name = "dateStart", EmitDefaultValue = false)]
    public DateTime? DateStart { get; set; }



    /// <summary>
    /// Gets or Sets DateEnd
    /// </summary>
    [DataMember(Name = "dateEnd", EmitDefaultValue = false)]
    public DateTime? DateEnd { get; set; }



    /// <summary>
    /// Gets or Sets Conditions
    /// </summary>
    [DataMember(Name = "conditions", EmitDefaultValue = false)]
    public V2MobiusAlertsTopicCondition Conditions { get; set; }



    /// <summary>
    /// Gets or Sets AdditionalProperties
    /// </summary>
    [DataMember(Name = "additionalProperties", EmitDefaultValue = false)]
    public Dictionary<string, string> AdditionalProperties { get; set; }



    /// <summary>
    /// Gets or Sets Active
    /// </summary>
    [DataMember(Name = "active", EmitDefaultValue = false)]
    public bool? Active { get; set; }



    /// <summary>
    /// Gets or Sets Unread
    /// </summary>
    [DataMember(Name = "unread", EmitDefaultValue = false)]
    public bool? Unread { get; set; }



    /// <summary>
    /// Gets or Sets Muted
    /// </summary>
    [DataMember(Name = "muted", EmitDefaultValue = false)]
    public bool? Muted { get; set; }



    /// <summary>
    /// Gets or Sets Snoozed
    /// </summary>
    [DataMember(Name = "snoozed", EmitDefaultValue = false)]
    public bool? Snoozed { get; set; }



    /// <summary>
    /// Gets or Sets DateMutedUntil
    /// </summary>
    [DataMember(Name = "dateMutedUntil", EmitDefaultValue = false)]
    public DateTime? DateMutedUntil { get; set; }



    /// <summary>
    /// Gets or Sets DateSnoozedUntil
    /// </summary>
    [DataMember(Name = "dateSnoozedUntil", EmitDefaultValue = false)]
    public DateTime? DateSnoozedUntil { get; set; }





    /// <summary>
    /// Gets or Sets AlertSummary
    /// </summary>
    [DataMember(Name = "alertSummary", EmitDefaultValue = false)]
    public V2MobiusAlertsTopicAlertSummary AlertSummary { get; set; }



    /// <summary>
    /// Gets or Sets SendExitingAlarmNotification
    /// </summary>
    [DataMember(Name = "sendExitingAlarmNotification", EmitDefaultValue = false)]
    public bool? SendExitingAlarmNotification { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class V2MobiusAlertsTopicAlert {\n");

        sb.Append("  Rule: ").Append(Rule).Append("\n");
        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  UserId: ").Append(UserId).Append("\n");
        sb.Append("  Notifications: ").Append(Notifications).Append("\n");
        sb.Append("  DateStart: ").Append(DateStart).Append("\n");
        sb.Append("  DateEnd: ").Append(DateEnd).Append("\n");
        sb.Append("  Conditions: ").Append(Conditions).Append("\n");
        sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
        sb.Append("  Active: ").Append(Active).Append("\n");
        sb.Append("  Unread: ").Append(Unread).Append("\n");
        sb.Append("  Muted: ").Append(Muted).Append("\n");
        sb.Append("  Snoozed: ").Append(Snoozed).Append("\n");
        sb.Append("  DateMutedUntil: ").Append(DateMutedUntil).Append("\n");
        sb.Append("  DateSnoozedUntil: ").Append(DateSnoozedUntil).Append("\n");
        sb.Append("  Action: ").Append(Action).Append("\n");
        sb.Append("  AlertSummary: ").Append(AlertSummary).Append("\n");
        sb.Append("  SendExitingAlarmNotification: ").Append(SendExitingAlarmNotification).Append("\n");
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
        return Equals(obj as V2MobiusAlertsTopicAlert);
    }

    /// <summary>
    /// Returns true if V2MobiusAlertsTopicAlert instances are equal
    /// </summary>
    /// <param name="other">Instance of V2MobiusAlertsTopicAlert to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(V2MobiusAlertsTopicAlert other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Rule == other.Rule ||
                Rule != null &&
                Rule.Equals(other.Rule)
            ) &&
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
                Conditions == other.Conditions ||
                Conditions != null &&
                Conditions.Equals(other.Conditions)
            ) &&
            (
                AdditionalProperties == other.AdditionalProperties ||
                AdditionalProperties != null &&
                AdditionalProperties.SequenceEqual(other.AdditionalProperties)
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
                Action == other.Action ||
                Action != null &&
                Action.Equals(other.Action)
            ) &&
            (
                AlertSummary == other.AlertSummary ||
                AlertSummary != null &&
                AlertSummary.Equals(other.AlertSummary)
            ) &&
            (
                SendExitingAlarmNotification == other.SendExitingAlarmNotification ||
                SendExitingAlarmNotification != null &&
                SendExitingAlarmNotification.Equals(other.SendExitingAlarmNotification)
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
            if (Rule != null)
            {
                hash = hash * 59 + Rule.GetHashCode();
            }

            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            if (UserId != null)
            {
                hash = hash * 59 + UserId.GetHashCode();
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

            if (Conditions != null)
            {
                hash = hash * 59 + Conditions.GetHashCode();
            }

            if (AdditionalProperties != null)
            {
                hash = hash * 59 + AdditionalProperties.GetHashCode();
            }

            if (Active != null)
            {
                hash = hash * 59 + Active.GetHashCode();
            }

            if (Unread != null)
            {
                hash = hash * 59 + Unread.GetHashCode();
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

            if (Action != null)
            {
                hash = hash * 59 + Action.GetHashCode();
            }

            if (AlertSummary != null)
            {
                hash = hash * 59 + AlertSummary.GetHashCode();
            }

            if (SendExitingAlarmNotification != null)
            {
                hash = hash * 59 + SendExitingAlarmNotification.GetHashCode();
            }

            return hash;
        }
    }
}
