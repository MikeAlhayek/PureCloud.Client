using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// KlaxonHeartBeatAlertsTopicHeartBeatAlert
/// </summary>

public partial class KlaxonHeartBeatAlertsTopicHeartBeatAlert : IEquatable<KlaxonHeartBeatAlertsTopicHeartBeatAlert>
{
    /// <summary>
    /// Gets or Sets AlertTypes
    /// </summary>
    
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
    [JsonPropertyName("ruleType")]
    public RuleTypeEnum? RuleType { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="KlaxonHeartBeatAlertsTopicHeartBeatAlert" /> class.
    /// </summary>
    /// <param name="Id">Id.</param>
    /// <param name="Name">Name.</param>
    /// <param name="SenderId">SenderId.</param>
    /// <param name="HeartBeatTimeoutInMinutes">HeartBeatTimeoutInMinutes.</param>
    /// <param name="RuleId">RuleId.</param>
    /// <param name="StartDate">StartDate.</param>
    /// <param name="EndDate">EndDate.</param>
    /// <param name="NotificationUsers">NotificationUsers.</param>
    /// <param name="AlertTypes">AlertTypes.</param>
    /// <param name="RuleType">RuleType.</param>
    public KlaxonHeartBeatAlertsTopicHeartBeatAlert(string Id = null, string Name = null, string SenderId = null, double? HeartBeatTimeoutInMinutes = null, string RuleId = null, DateTime? StartDate = null, DateTime? EndDate = null, List<KlaxonHeartBeatAlertsTopicNotificationUser> NotificationUsers = null, List<AlertTypesEnum> AlertTypes = null, RuleTypeEnum? RuleType = null)
    {
        this.Id = Id;
        this.Name = Name;
        this.SenderId = SenderId;
        this.HeartBeatTimeoutInMinutes = HeartBeatTimeoutInMinutes;
        this.RuleId = RuleId;
        this.StartDate = StartDate;
        this.EndDate = EndDate;
        this.NotificationUsers = NotificationUsers;
        this.AlertTypes = AlertTypes;
        this.RuleType = RuleType;

    }



    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// Gets or Sets SenderId
    /// </summary>
    [JsonPropertyName("senderId")]
    public string SenderId { get; set; }



    /// <summary>
    /// Gets or Sets HeartBeatTimeoutInMinutes
    /// </summary>
    [JsonPropertyName("heartBeatTimeoutInMinutes")]
    public double? HeartBeatTimeoutInMinutes { get; set; }



    /// <summary>
    /// Gets or Sets RuleId
    /// </summary>
    [JsonPropertyName("ruleId")]
    public string RuleId { get; set; }



    /// <summary>
    /// Gets or Sets StartDate
    /// </summary>
    [JsonPropertyName("startDate")]
    public DateTime? StartDate { get; set; }



    /// <summary>
    /// Gets or Sets EndDate
    /// </summary>
    [JsonPropertyName("endDate")]
    public DateTime? EndDate { get; set; }



    /// <summary>
    /// Gets or Sets NotificationUsers
    /// </summary>
    [JsonPropertyName("notificationUsers")]
    public List<KlaxonHeartBeatAlertsTopicNotificationUser> NotificationUsers { get; set; }



    /// <summary>
    /// Gets or Sets AlertTypes
    /// </summary>
    [JsonPropertyName("alertTypes")]
    public List<AlertTypesEnum> AlertTypes { get; set; }




    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class KlaxonHeartBeatAlertsTopicHeartBeatAlert {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  SenderId: ").Append(SenderId).Append("\n");
        sb.Append("  HeartBeatTimeoutInMinutes: ").Append(HeartBeatTimeoutInMinutes).Append("\n");
        sb.Append("  RuleId: ").Append(RuleId).Append("\n");
        sb.Append("  StartDate: ").Append(StartDate).Append("\n");
        sb.Append("  EndDate: ").Append(EndDate).Append("\n");
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
        return Equals(obj as KlaxonHeartBeatAlertsTopicHeartBeatAlert);
    }

    /// <summary>
    /// Returns true if KlaxonHeartBeatAlertsTopicHeartBeatAlert instances are equal
    /// </summary>
    /// <param name="other">Instance of KlaxonHeartBeatAlertsTopicHeartBeatAlert to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(KlaxonHeartBeatAlertsTopicHeartBeatAlert other)
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
                SenderId == other.SenderId ||
                SenderId != null &&
                SenderId.Equals(other.SenderId)
            ) &&
            (
                HeartBeatTimeoutInMinutes == other.HeartBeatTimeoutInMinutes ||
                HeartBeatTimeoutInMinutes != null &&
                HeartBeatTimeoutInMinutes.Equals(other.HeartBeatTimeoutInMinutes)
            ) &&
            (
                RuleId == other.RuleId ||
                RuleId != null &&
                RuleId.Equals(other.RuleId)
            ) &&
            (
                StartDate == other.StartDate ||
                StartDate != null &&
                StartDate.Equals(other.StartDate)
            ) &&
            (
                EndDate == other.EndDate ||
                EndDate != null &&
                EndDate.Equals(other.EndDate)
            ) &&
            (
                NotificationUsers == other.NotificationUsers ||
                NotificationUsers != null &&
                NotificationUsers.SequenceEqual(other.NotificationUsers)
            ) &&
            (
                AlertTypes == other.AlertTypes ||
                AlertTypes != null &&
                AlertTypes.SequenceEqual(other.AlertTypes)
            ) &&
            (
                RuleType == other.RuleType ||
                RuleType != null &&
                RuleType.Equals(other.RuleType)
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

            if (SenderId != null)
            {
                hash = hash * 59 + SenderId.GetHashCode();
            }

            if (HeartBeatTimeoutInMinutes != null)
            {
                hash = hash * 59 + HeartBeatTimeoutInMinutes.GetHashCode();
            }

            if (RuleId != null)
            {
                hash = hash * 59 + RuleId.GetHashCode();
            }

            if (StartDate != null)
            {
                hash = hash * 59 + StartDate.GetHashCode();
            }

            if (EndDate != null)
            {
                hash = hash * 59 + EndDate.GetHashCode();
            }

            if (NotificationUsers != null)
            {
                hash = hash * 59 + NotificationUsers.GetHashCode();
            }

            if (AlertTypes != null)
            {
                hash = hash * 59 + AlertTypes.GetHashCode();
            }

            if (RuleType != null)
            {
                hash = hash * 59 + RuleType.GetHashCode();
            }

            return hash;
        }
    }
}
