using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// KlaxonHeartBeatRulesTopicHeartBeatRule
/// </summary>
[DataContract]
public partial class KlaxonHeartBeatRulesTopicHeartBeatRule : IEquatable<KlaxonHeartBeatRulesTopicHeartBeatRule>
{
    /// <summary>
    /// Gets or Sets AlertTypes
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum AlertTypesEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Sms for "SMS"
        /// </summary>
        [EnumMember(Value = "SMS")]
        Sms,

        /// <summary>
        /// Enum Device for "DEVICE"
        /// </summary>
        [EnumMember(Value = "DEVICE")]
        Device,

        /// <summary>
        /// Enum Email for "EMAIL"
        /// </summary>
        [EnumMember(Value = "EMAIL")]
        Email
    }
    /// <summary>
    /// Gets or Sets RuleType
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RuleTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Edge for "EDGE"
        /// </summary>
        [EnumMember(Value = "EDGE")]
        Edge
    }
    /// <summary>
    /// Gets or Sets RuleType
    /// </summary>
    [DataMember(Name = "ruleType", EmitDefaultValue = false)]
    public RuleTypeEnum? RuleType { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="KlaxonHeartBeatRulesTopicHeartBeatRule" /> class.
    /// </summary>
    /// <param name="Id">Id.</param>
    /// <param name="Name">Name.</param>
    /// <param name="SenderId">SenderId.</param>
    /// <param name="HeartBeatTimeoutInMinutes">HeartBeatTimeoutInMinutes.</param>
    /// <param name="Enabled">Enabled.</param>
    /// <param name="InAlarm">InAlarm.</param>
    /// <param name="NotificationUsers">NotificationUsers.</param>
    /// <param name="AlertTypes">AlertTypes.</param>
    /// <param name="RuleType">RuleType.</param>
    public KlaxonHeartBeatRulesTopicHeartBeatRule(string Id = null, string Name = null, string SenderId = null, double? HeartBeatTimeoutInMinutes = null, bool? Enabled = null, bool? InAlarm = null, List<KlaxonHeartBeatRulesTopicNotificationUser> NotificationUsers = null, List<AlertTypesEnum> AlertTypes = null, RuleTypeEnum? RuleType = null)
    {
        this.Id = Id;
        this.Name = Name;
        this.SenderId = SenderId;
        this.HeartBeatTimeoutInMinutes = HeartBeatTimeoutInMinutes;
        this.Enabled = Enabled;
        this.InAlarm = InAlarm;
        this.NotificationUsers = NotificationUsers;
        this.AlertTypes = AlertTypes;
        this.RuleType = RuleType;

    }



    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }



    /// <summary>
    /// Gets or Sets SenderId
    /// </summary>
    [DataMember(Name = "senderId", EmitDefaultValue = false)]
    public string SenderId { get; set; }



    /// <summary>
    /// Gets or Sets HeartBeatTimeoutInMinutes
    /// </summary>
    [DataMember(Name = "heartBeatTimeoutInMinutes", EmitDefaultValue = false)]
    public double? HeartBeatTimeoutInMinutes { get; set; }



    /// <summary>
    /// Gets or Sets Enabled
    /// </summary>
    [DataMember(Name = "enabled", EmitDefaultValue = false)]
    public bool? Enabled { get; set; }



    /// <summary>
    /// Gets or Sets InAlarm
    /// </summary>
    [DataMember(Name = "inAlarm", EmitDefaultValue = false)]
    public bool? InAlarm { get; set; }



    /// <summary>
    /// Gets or Sets NotificationUsers
    /// </summary>
    [DataMember(Name = "notificationUsers", EmitDefaultValue = false)]
    public List<KlaxonHeartBeatRulesTopicNotificationUser> NotificationUsers { get; set; }



    /// <summary>
    /// Gets or Sets AlertTypes
    /// </summary>
    [DataMember(Name = "alertTypes", EmitDefaultValue = false)]
    public List<AlertTypesEnum> AlertTypes { get; set; }




    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class KlaxonHeartBeatRulesTopicHeartBeatRule {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  SenderId: ").Append(SenderId).Append("\n");
        sb.Append("  HeartBeatTimeoutInMinutes: ").Append(HeartBeatTimeoutInMinutes).Append("\n");
        sb.Append("  Enabled: ").Append(Enabled).Append("\n");
        sb.Append("  InAlarm: ").Append(InAlarm).Append("\n");
        sb.Append("  NotificationUsers: ").Append(NotificationUsers).Append("\n");
        sb.Append("  AlertTypes: ").Append(AlertTypes).Append("\n");
        sb.Append("  RuleType: ").Append(RuleType).Append("\n");
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
        return this.Equals(obj as KlaxonHeartBeatRulesTopicHeartBeatRule);
    }

    /// <summary>
    /// Returns true if KlaxonHeartBeatRulesTopicHeartBeatRule instances are equal
    /// </summary>
    /// <param name="other">Instance of KlaxonHeartBeatRulesTopicHeartBeatRule to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(KlaxonHeartBeatRulesTopicHeartBeatRule other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                this.Id == other.Id ||
                this.Id != null &&
                this.Id.Equals(other.Id)
            ) &&
            (
                this.Name == other.Name ||
                this.Name != null &&
                this.Name.Equals(other.Name)
            ) &&
            (
                this.SenderId == other.SenderId ||
                this.SenderId != null &&
                this.SenderId.Equals(other.SenderId)
            ) &&
            (
                this.HeartBeatTimeoutInMinutes == other.HeartBeatTimeoutInMinutes ||
                this.HeartBeatTimeoutInMinutes != null &&
                this.HeartBeatTimeoutInMinutes.Equals(other.HeartBeatTimeoutInMinutes)
            ) &&
            (
                this.Enabled == other.Enabled ||
                this.Enabled != null &&
                this.Enabled.Equals(other.Enabled)
            ) &&
            (
                this.InAlarm == other.InAlarm ||
                this.InAlarm != null &&
                this.InAlarm.Equals(other.InAlarm)
            ) &&
            (
                this.NotificationUsers == other.NotificationUsers ||
                this.NotificationUsers != null &&
                this.NotificationUsers.SequenceEqual(other.NotificationUsers)
            ) &&
            (
                this.AlertTypes == other.AlertTypes ||
                this.AlertTypes != null &&
                this.AlertTypes.SequenceEqual(other.AlertTypes)
            ) &&
            (
                this.RuleType == other.RuleType ||
                this.RuleType != null &&
                this.RuleType.Equals(other.RuleType)
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
            if (this.Id != null)
            {
                hash = hash * 59 + this.Id.GetHashCode();
            }

            if (this.Name != null)
            {
                hash = hash * 59 + this.Name.GetHashCode();
            }

            if (this.SenderId != null)
            {
                hash = hash * 59 + this.SenderId.GetHashCode();
            }

            if (this.HeartBeatTimeoutInMinutes != null)
            {
                hash = hash * 59 + this.HeartBeatTimeoutInMinutes.GetHashCode();
            }

            if (this.Enabled != null)
            {
                hash = hash * 59 + this.Enabled.GetHashCode();
            }

            if (this.InAlarm != null)
            {
                hash = hash * 59 + this.InAlarm.GetHashCode();
            }

            if (this.NotificationUsers != null)
            {
                hash = hash * 59 + this.NotificationUsers.GetHashCode();
            }

            if (this.AlertTypes != null)
            {
                hash = hash * 59 + this.AlertTypes.GetHashCode();
            }

            if (this.RuleType != null)
            {
                hash = hash * 59 + this.RuleType.GetHashCode();
            }

            return hash;
        }
    }
}
