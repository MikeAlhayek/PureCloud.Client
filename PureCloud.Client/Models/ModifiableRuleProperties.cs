using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ModifiableRuleProperties
/// </summary>
[DataContract]
public partial class ModifiableRuleProperties : IEquatable<ModifiableRuleProperties>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="ModifiableRuleProperties" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected ModifiableRuleProperties() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ModifiableRuleProperties" /> class.
    /// </summary>
    /// <param name="Name">Name of the rule (required).</param>
    /// <param name="Description">The description of the rule..</param>
    /// <param name="Enabled">Indicates if the rule is enabled..</param>
    /// <param name="Notifications">The alert notification types to trigger when alarm state changes as well as the users they will be sent to..</param>
    /// <param name="SendExitingAlarmNotifications">Indicates if the alert will send a notification when it is closed..</param>
    /// <param name="WaitBetweenNotificationMs">The amount of time in milliseconds to wait between notification..</param>
    /// <param name="Conditions">The set of metric conditions that would trigger an alert..</param>
    public ModifiableRuleProperties(string Name = null, string Description = null, bool? Enabled = null, List<AlertNotification> Notifications = null, bool? SendExitingAlarmNotifications = null, long? WaitBetweenNotificationMs = null, CommonRuleConditions Conditions = null)
    {
        this.Name = Name;
        this.Description = Description;
        this.Enabled = Enabled;
        this.Notifications = Notifications;
        this.SendExitingAlarmNotifications = SendExitingAlarmNotifications;
        this.WaitBetweenNotificationMs = WaitBetweenNotificationMs;
        this.Conditions = Conditions;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; private set; }



    /// <summary>
    /// Name of the rule
    /// </summary>
    /// <value>Name of the rule</value>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }



    /// <summary>
    /// The description of the rule.
    /// </summary>
    /// <value>The description of the rule.</value>
    [DataMember(Name = "description", EmitDefaultValue = false)]
    public string Description { get; set; }



    /// <summary>
    /// Indicates if the rule is enabled.
    /// </summary>
    /// <value>Indicates if the rule is enabled.</value>
    [DataMember(Name = "enabled", EmitDefaultValue = false)]
    public bool? Enabled { get; set; }



    /// <summary>
    /// The alert notification types to trigger when alarm state changes as well as the users they will be sent to.
    /// </summary>
    /// <value>The alert notification types to trigger when alarm state changes as well as the users they will be sent to.</value>
    [DataMember(Name = "notifications", EmitDefaultValue = false)]
    public List<AlertNotification> Notifications { get; set; }



    /// <summary>
    /// Indicates if the alert will send a notification when it is closed.
    /// </summary>
    /// <value>Indicates if the alert will send a notification when it is closed.</value>
    [DataMember(Name = "sendExitingAlarmNotifications", EmitDefaultValue = false)]
    public bool? SendExitingAlarmNotifications { get; set; }



    /// <summary>
    /// The amount of time in milliseconds to wait between notification.
    /// </summary>
    /// <value>The amount of time in milliseconds to wait between notification.</value>
    [DataMember(Name = "waitBetweenNotificationMs", EmitDefaultValue = false)]
    public long? WaitBetweenNotificationMs { get; set; }



    /// <summary>
    /// The set of metric conditions that would trigger an alert.
    /// </summary>
    /// <value>The set of metric conditions that would trigger an alert.</value>
    [DataMember(Name = "conditions", EmitDefaultValue = false)]
    public CommonRuleConditions Conditions { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [DataMember(Name = "selfUri", EmitDefaultValue = false)]
    public string SelfUri { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ModifiableRuleProperties {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  Enabled: ").Append(Enabled).Append("\n");
        sb.Append("  Notifications: ").Append(Notifications).Append("\n");
        sb.Append("  SendExitingAlarmNotifications: ").Append(SendExitingAlarmNotifications).Append("\n");
        sb.Append("  WaitBetweenNotificationMs: ").Append(WaitBetweenNotificationMs).Append("\n");
        sb.Append("  Conditions: ").Append(Conditions).Append("\n");
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
        return Equals(obj as ModifiableRuleProperties);
    }

    /// <summary>
    /// Returns true if ModifiableRuleProperties instances are equal
    /// </summary>
    /// <param name="other">Instance of ModifiableRuleProperties to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ModifiableRuleProperties other)
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

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
