using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WorkPlanBiddingAdminNotificationTopicWorkPlanBiddingNotification
/// </summary>
[DataContract]
public partial class WorkPlanBiddingAdminNotificationTopicWorkPlanBiddingNotification : IEquatable<WorkPlanBiddingAdminNotificationTopicWorkPlanBiddingNotification>
{
    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum StatusEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Unknown for "Unknown"
        /// </summary>
        [EnumMember(Value = "Unknown")]
        Unknown,

        /// <summary>
        /// Enum Draft for "Draft"
        /// </summary>
        [EnumMember(Value = "Draft")]
        Draft,

        /// <summary>
        /// Enum Locked for "Locked"
        /// </summary>
        [EnumMember(Value = "Locked")]
        Locked,

        /// <summary>
        /// Enum Scheduled for "Scheduled"
        /// </summary>
        [EnumMember(Value = "Scheduled")]
        Scheduled,

        /// <summary>
        /// Enum Optimized for "Optimized"
        /// </summary>
        [EnumMember(Value = "Optimized")]
        Optimized,

        /// <summary>
        /// Enum Open for "Open"
        /// </summary>
        [EnumMember(Value = "Open")]
        Open,

        /// <summary>
        /// Enum Closed for "Closed"
        /// </summary>
        [EnumMember(Value = "Closed")]
        Closed,

        /// <summary>
        /// Enum Processed for "Processed"
        /// </summary>
        [EnumMember(Value = "Processed")]
        Processed,

        /// <summary>
        /// Enum Published for "Published"
        /// </summary>
        [EnumMember(Value = "Published")]
        Published
    }
    /// <summary>
    /// Gets or Sets AgentRankingType
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum AgentRankingTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Unknown for "Unknown"
        /// </summary>
        [EnumMember(Value = "Unknown")]
        Unknown,

        /// <summary>
        /// Enum Hiredate for "HireDate"
        /// </summary>
        [EnumMember(Value = "HireDate")]
        Hiredate,

        /// <summary>
        /// Enum Performance for "Performance"
        /// </summary>
        [EnumMember(Value = "Performance")]
        Performance
    }
    /// <summary>
    /// Gets or Sets RankingTiebreakerType
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RankingTiebreakerTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Unknown for "Unknown"
        /// </summary>
        [EnumMember(Value = "Unknown")]
        Unknown,

        /// <summary>
        /// Enum Hiredate for "HireDate"
        /// </summary>
        [EnumMember(Value = "HireDate")]
        Hiredate,

        /// <summary>
        /// Enum Performance for "Performance"
        /// </summary>
        [EnumMember(Value = "Performance")]
        Performance,

        /// <summary>
        /// Enum Custom for "Custom"
        /// </summary>
        [EnumMember(Value = "Custom")]
        Custom,

        /// <summary>
        /// Enum Randomlyassign for "RandomlyAssign"
        /// </summary>
        [EnumMember(Value = "RandomlyAssign")]
        Randomlyassign
    }
    /// <summary>
    /// Gets or Sets WorkPlanFieldsVisibleToAgents
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum WorkPlanFieldsVisibleToAgentsEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Unknown for "Unknown"
        /// </summary>
        [EnumMember(Value = "Unknown")]
        Unknown,

        /// <summary>
        /// Enum Name for "Name"
        /// </summary>
        [EnumMember(Value = "Name")]
        Name,

        /// <summary>
        /// Enum Paidhours for "PaidHours"
        /// </summary>
        [EnumMember(Value = "PaidHours")]
        Paidhours
    }
    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    [DataMember(Name = "status", EmitDefaultValue = false)]
    public StatusEnum? Status { get; set; }
    /// <summary>
    /// Gets or Sets AgentRankingType
    /// </summary>
    [DataMember(Name = "agentRankingType", EmitDefaultValue = false)]
    public AgentRankingTypeEnum? AgentRankingType { get; set; }
    /// <summary>
    /// Gets or Sets RankingTiebreakerType
    /// </summary>
    [DataMember(Name = "rankingTiebreakerType", EmitDefaultValue = false)]
    public RankingTiebreakerTypeEnum? RankingTiebreakerType { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="WorkPlanBiddingAdminNotificationTopicWorkPlanBiddingNotification" /> class.
    /// </summary>
    /// <param name="Id">Id.</param>
    /// <param name="BuId">BuId.</param>
    /// <param name="Status">Status.</param>
    /// <param name="BidWindowStartDate">BidWindowStartDate.</param>
    /// <param name="BidWindowEndDate">BidWindowEndDate.</param>
    /// <param name="EffectiveDate">EffectiveDate.</param>
    /// <param name="AgentRankingType">AgentRankingType.</param>
    /// <param name="RankingTiebreakerType">RankingTiebreakerType.</param>
    /// <param name="WorkPlanFieldsVisibleToAgents">WorkPlanFieldsVisibleToAgents.</param>
    public WorkPlanBiddingAdminNotificationTopicWorkPlanBiddingNotification(string Id = null, string BuId = null, StatusEnum? Status = null, string BidWindowStartDate = null, string BidWindowEndDate = null, string EffectiveDate = null, AgentRankingTypeEnum? AgentRankingType = null, RankingTiebreakerTypeEnum? RankingTiebreakerType = null, List<WorkPlanFieldsVisibleToAgentsEnum> WorkPlanFieldsVisibleToAgents = null)
    {
        this.Id = Id;
        this.BuId = BuId;
        this.Status = Status;
        this.BidWindowStartDate = BidWindowStartDate;
        this.BidWindowEndDate = BidWindowEndDate;
        this.EffectiveDate = EffectiveDate;
        this.AgentRankingType = AgentRankingType;
        this.RankingTiebreakerType = RankingTiebreakerType;
        this.WorkPlanFieldsVisibleToAgents = WorkPlanFieldsVisibleToAgents;

    }



    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets BuId
    /// </summary>
    [DataMember(Name = "buId", EmitDefaultValue = false)]
    public string BuId { get; set; }





    /// <summary>
    /// Gets or Sets BidWindowStartDate
    /// </summary>
    [DataMember(Name = "bidWindowStartDate", EmitDefaultValue = false)]
    public string BidWindowStartDate { get; set; }



    /// <summary>
    /// Gets or Sets BidWindowEndDate
    /// </summary>
    [DataMember(Name = "bidWindowEndDate", EmitDefaultValue = false)]
    public string BidWindowEndDate { get; set; }



    /// <summary>
    /// Gets or Sets EffectiveDate
    /// </summary>
    [DataMember(Name = "effectiveDate", EmitDefaultValue = false)]
    public string EffectiveDate { get; set; }







    /// <summary>
    /// Gets or Sets WorkPlanFieldsVisibleToAgents
    /// </summary>
    [DataMember(Name = "workPlanFieldsVisibleToAgents", EmitDefaultValue = false)]
    public List<WorkPlanFieldsVisibleToAgentsEnum> WorkPlanFieldsVisibleToAgents { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WorkPlanBiddingAdminNotificationTopicWorkPlanBiddingNotification {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  BuId: ").Append(BuId).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  BidWindowStartDate: ").Append(BidWindowStartDate).Append("\n");
        sb.Append("  BidWindowEndDate: ").Append(BidWindowEndDate).Append("\n");
        sb.Append("  EffectiveDate: ").Append(EffectiveDate).Append("\n");
        sb.Append("  AgentRankingType: ").Append(AgentRankingType).Append("\n");
        sb.Append("  RankingTiebreakerType: ").Append(RankingTiebreakerType).Append("\n");
        sb.Append("  WorkPlanFieldsVisibleToAgents: ").Append(WorkPlanFieldsVisibleToAgents).Append("\n");
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
        return Equals(obj as WorkPlanBiddingAdminNotificationTopicWorkPlanBiddingNotification);
    }

    /// <summary>
    /// Returns true if WorkPlanBiddingAdminNotificationTopicWorkPlanBiddingNotification instances are equal
    /// </summary>
    /// <param name="other">Instance of WorkPlanBiddingAdminNotificationTopicWorkPlanBiddingNotification to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WorkPlanBiddingAdminNotificationTopicWorkPlanBiddingNotification other)
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
                BuId == other.BuId ||
                BuId != null &&
                BuId.Equals(other.BuId)
            ) &&
            (
                Status == other.Status ||
                Status != null &&
                Status.Equals(other.Status)
            ) &&
            (
                BidWindowStartDate == other.BidWindowStartDate ||
                BidWindowStartDate != null &&
                BidWindowStartDate.Equals(other.BidWindowStartDate)
            ) &&
            (
                BidWindowEndDate == other.BidWindowEndDate ||
                BidWindowEndDate != null &&
                BidWindowEndDate.Equals(other.BidWindowEndDate)
            ) &&
            (
                EffectiveDate == other.EffectiveDate ||
                EffectiveDate != null &&
                EffectiveDate.Equals(other.EffectiveDate)
            ) &&
            (
                AgentRankingType == other.AgentRankingType ||
                AgentRankingType != null &&
                AgentRankingType.Equals(other.AgentRankingType)
            ) &&
            (
                RankingTiebreakerType == other.RankingTiebreakerType ||
                RankingTiebreakerType != null &&
                RankingTiebreakerType.Equals(other.RankingTiebreakerType)
            ) &&
            (
                WorkPlanFieldsVisibleToAgents == other.WorkPlanFieldsVisibleToAgents ||
                WorkPlanFieldsVisibleToAgents != null &&
                WorkPlanFieldsVisibleToAgents.SequenceEqual(other.WorkPlanFieldsVisibleToAgents)
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

            if (BuId != null)
            {
                hash = hash * 59 + BuId.GetHashCode();
            }

            if (Status != null)
            {
                hash = hash * 59 + Status.GetHashCode();
            }

            if (BidWindowStartDate != null)
            {
                hash = hash * 59 + BidWindowStartDate.GetHashCode();
            }

            if (BidWindowEndDate != null)
            {
                hash = hash * 59 + BidWindowEndDate.GetHashCode();
            }

            if (EffectiveDate != null)
            {
                hash = hash * 59 + EffectiveDate.GetHashCode();
            }

            if (AgentRankingType != null)
            {
                hash = hash * 59 + AgentRankingType.GetHashCode();
            }

            if (RankingTiebreakerType != null)
            {
                hash = hash * 59 + RankingTiebreakerType.GetHashCode();
            }

            if (WorkPlanFieldsVisibleToAgents != null)
            {
                hash = hash * 59 + WorkPlanFieldsVisibleToAgents.GetHashCode();
            }

            return hash;
        }
    }
}
