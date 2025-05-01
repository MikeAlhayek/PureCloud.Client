using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WfmUserScheduleAdherenceUpdatedMuTopicUserScheduleAdherenceUpdate
/// </summary>
[DataContract]
public partial class WfmUserScheduleAdherenceUpdatedMuTopicUserScheduleAdherenceUpdate : IEquatable<WfmUserScheduleAdherenceUpdatedMuTopicUserScheduleAdherenceUpdate>
{
    /// <summary>
    /// Gets or Sets RoutingStatus
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RoutingStatusEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Empty for "__EMPTY__"
        /// </summary>
        [EnumMember(Value = "__EMPTY__")]
        Empty,

        /// <summary>
        /// Enum OffQueue for "OFF_QUEUE"
        /// </summary>
        [EnumMember(Value = "OFF_QUEUE")]
        OffQueue,

        /// <summary>
        /// Enum Idle for "IDLE"
        /// </summary>
        [EnumMember(Value = "IDLE")]
        Idle,

        /// <summary>
        /// Enum Interacting for "INTERACTING"
        /// </summary>
        [EnumMember(Value = "INTERACTING")]
        Interacting,

        /// <summary>
        /// Enum NotResponding for "NOT_RESPONDING"
        /// </summary>
        [EnumMember(Value = "NOT_RESPONDING")]
        NotResponding,

        /// <summary>
        /// Enum Communicating for "COMMUNICATING"
        /// </summary>
        [EnumMember(Value = "COMMUNICATING")]
        Communicating,

        /// <summary>
        /// Enum Offline for "OFFLINE"
        /// </summary>
        [EnumMember(Value = "OFFLINE")]
        Offline
    }
    /// <summary>
    /// Gets or Sets AdherenceState
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum AdherenceStateEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Inadherence for "InAdherence"
        /// </summary>
        [EnumMember(Value = "InAdherence")]
        Inadherence,

        /// <summary>
        /// Enum Outofadherence for "OutOfAdherence"
        /// </summary>
        [EnumMember(Value = "OutOfAdherence")]
        Outofadherence,

        /// <summary>
        /// Enum Unscheduled for "Unscheduled"
        /// </summary>
        [EnumMember(Value = "Unscheduled")]
        Unscheduled,

        /// <summary>
        /// Enum Unknown for "Unknown"
        /// </summary>
        [EnumMember(Value = "Unknown")]
        Unknown,

        /// <summary>
        /// Enum Ignored for "Ignored"
        /// </summary>
        [EnumMember(Value = "Ignored")]
        Ignored,

        /// <summary>
        /// Enum Explained for "Explained"
        /// </summary>
        [EnumMember(Value = "Explained")]
        Explained
    }
    /// <summary>
    /// Gets or Sets RoutingStatus
    /// </summary>
    [DataMember(Name = "routingStatus", EmitDefaultValue = false)]
    public RoutingStatusEnum? RoutingStatus { get; set; }
    /// <summary>
    /// Gets or Sets AdherenceState
    /// </summary>
    [DataMember(Name = "adherenceState", EmitDefaultValue = false)]
    public AdherenceStateEnum? AdherenceState { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="WfmUserScheduleAdherenceUpdatedMuTopicUserScheduleAdherenceUpdate" /> class.
    /// </summary>
    /// <param name="User">User.</param>
    /// <param name="ManagementUnitId">ManagementUnitId.</param>
    /// <param name="Team">Team.</param>
    /// <param name="ScheduledActivityCategory">ScheduledActivityCategory.</param>
    /// <param name="ScheduledActivityCode">ScheduledActivityCode.</param>
    /// <param name="SystemPresence">SystemPresence.</param>
    /// <param name="OrganizationSecondaryPresenceId">OrganizationSecondaryPresenceId.</param>
    /// <param name="RoutingStatus">RoutingStatus.</param>
    /// <param name="ActualActivityCategory">ActualActivityCategory.</param>
    /// <param name="IsOutOfOffice">IsOutOfOffice.</param>
    /// <param name="AdherenceState">AdherenceState.</param>
    /// <param name="Impact">Impact.</param>
    /// <param name="AdherenceExplanation">AdherenceExplanation.</param>
    /// <param name="AdherenceChangeTime">AdherenceChangeTime.</param>
    /// <param name="PresenceUpdateTime">PresenceUpdateTime.</param>
    /// <param name="ActiveQueues">ActiveQueues.</param>
    /// <param name="ActiveQueuesModifiedTime">ActiveQueuesModifiedTime.</param>
    /// <param name="RemovedFromManagementUnit">RemovedFromManagementUnit.</param>
    /// <param name="SuppressOnTimeReminder">SuppressOnTimeReminder.</param>
    /// <param name="NextActivityReminders">NextActivityReminders.</param>
    public WfmUserScheduleAdherenceUpdatedMuTopicUserScheduleAdherenceUpdate(WfmUserScheduleAdherenceUpdatedMuTopicUserReference User = null, string ManagementUnitId = null, WfmUserScheduleAdherenceUpdatedMuTopicUriReference Team = null, string ScheduledActivityCategory = null, WfmUserScheduleAdherenceUpdatedMuTopicActivityCodeReference ScheduledActivityCode = null, string SystemPresence = null, string OrganizationSecondaryPresenceId = null, RoutingStatusEnum? RoutingStatus = null, string ActualActivityCategory = null, bool? IsOutOfOffice = null, AdherenceStateEnum? AdherenceState = null, string Impact = null, WfmUserScheduleAdherenceUpdatedMuTopicRealTimeAdherenceExplanation AdherenceExplanation = null, DateTime? AdherenceChangeTime = null, DateTime? PresenceUpdateTime = null, List<WfmUserScheduleAdherenceUpdatedMuTopicQueueReference> ActiveQueues = null, DateTime? ActiveQueuesModifiedTime = null, bool? RemovedFromManagementUnit = null, bool? SuppressOnTimeReminder = null, List<WfmUserScheduleAdherenceUpdatedMuTopicUserNextActivityReminder> NextActivityReminders = null)
    {
        this.User = User;
        this.ManagementUnitId = ManagementUnitId;
        this.Team = Team;
        this.ScheduledActivityCategory = ScheduledActivityCategory;
        this.ScheduledActivityCode = ScheduledActivityCode;
        this.SystemPresence = SystemPresence;
        this.OrganizationSecondaryPresenceId = OrganizationSecondaryPresenceId;
        this.RoutingStatus = RoutingStatus;
        this.ActualActivityCategory = ActualActivityCategory;
        this.IsOutOfOffice = IsOutOfOffice;
        this.AdherenceState = AdherenceState;
        this.Impact = Impact;
        this.AdherenceExplanation = AdherenceExplanation;
        this.AdherenceChangeTime = AdherenceChangeTime;
        this.PresenceUpdateTime = PresenceUpdateTime;
        this.ActiveQueues = ActiveQueues;
        this.ActiveQueuesModifiedTime = ActiveQueuesModifiedTime;
        this.RemovedFromManagementUnit = RemovedFromManagementUnit;
        this.SuppressOnTimeReminder = SuppressOnTimeReminder;
        this.NextActivityReminders = NextActivityReminders;

    }



    /// <summary>
    /// Gets or Sets User
    /// </summary>
    [DataMember(Name = "user", EmitDefaultValue = false)]
    public WfmUserScheduleAdherenceUpdatedMuTopicUserReference User { get; set; }



    /// <summary>
    /// Gets or Sets ManagementUnitId
    /// </summary>
    [DataMember(Name = "managementUnitId", EmitDefaultValue = false)]
    public string ManagementUnitId { get; set; }



    /// <summary>
    /// Gets or Sets Team
    /// </summary>
    [DataMember(Name = "team", EmitDefaultValue = false)]
    public WfmUserScheduleAdherenceUpdatedMuTopicUriReference Team { get; set; }



    /// <summary>
    /// Gets or Sets ScheduledActivityCategory
    /// </summary>
    [DataMember(Name = "scheduledActivityCategory", EmitDefaultValue = false)]
    public string ScheduledActivityCategory { get; set; }



    /// <summary>
    /// Gets or Sets ScheduledActivityCode
    /// </summary>
    [DataMember(Name = "scheduledActivityCode", EmitDefaultValue = false)]
    public WfmUserScheduleAdherenceUpdatedMuTopicActivityCodeReference ScheduledActivityCode { get; set; }



    /// <summary>
    /// Gets or Sets SystemPresence
    /// </summary>
    [DataMember(Name = "systemPresence", EmitDefaultValue = false)]
    public string SystemPresence { get; set; }



    /// <summary>
    /// Gets or Sets OrganizationSecondaryPresenceId
    /// </summary>
    [DataMember(Name = "organizationSecondaryPresenceId", EmitDefaultValue = false)]
    public string OrganizationSecondaryPresenceId { get; set; }





    /// <summary>
    /// Gets or Sets ActualActivityCategory
    /// </summary>
    [DataMember(Name = "actualActivityCategory", EmitDefaultValue = false)]
    public string ActualActivityCategory { get; set; }



    /// <summary>
    /// Gets or Sets IsOutOfOffice
    /// </summary>
    [DataMember(Name = "isOutOfOffice", EmitDefaultValue = false)]
    public bool? IsOutOfOffice { get; set; }





    /// <summary>
    /// Gets or Sets Impact
    /// </summary>
    [DataMember(Name = "impact", EmitDefaultValue = false)]
    public string Impact { get; set; }



    /// <summary>
    /// Gets or Sets AdherenceExplanation
    /// </summary>
    [DataMember(Name = "adherenceExplanation", EmitDefaultValue = false)]
    public WfmUserScheduleAdherenceUpdatedMuTopicRealTimeAdherenceExplanation AdherenceExplanation { get; set; }



    /// <summary>
    /// Gets or Sets AdherenceChangeTime
    /// </summary>
    [DataMember(Name = "adherenceChangeTime", EmitDefaultValue = false)]
    public DateTime? AdherenceChangeTime { get; set; }



    /// <summary>
    /// Gets or Sets PresenceUpdateTime
    /// </summary>
    [DataMember(Name = "presenceUpdateTime", EmitDefaultValue = false)]
    public DateTime? PresenceUpdateTime { get; set; }



    /// <summary>
    /// Gets or Sets ActiveQueues
    /// </summary>
    [DataMember(Name = "activeQueues", EmitDefaultValue = false)]
    public List<WfmUserScheduleAdherenceUpdatedMuTopicQueueReference> ActiveQueues { get; set; }



    /// <summary>
    /// Gets or Sets ActiveQueuesModifiedTime
    /// </summary>
    [DataMember(Name = "activeQueuesModifiedTime", EmitDefaultValue = false)]
    public DateTime? ActiveQueuesModifiedTime { get; set; }



    /// <summary>
    /// Gets or Sets RemovedFromManagementUnit
    /// </summary>
    [DataMember(Name = "removedFromManagementUnit", EmitDefaultValue = false)]
    public bool? RemovedFromManagementUnit { get; set; }



    /// <summary>
    /// Gets or Sets SuppressOnTimeReminder
    /// </summary>
    [DataMember(Name = "suppressOnTimeReminder", EmitDefaultValue = false)]
    public bool? SuppressOnTimeReminder { get; set; }



    /// <summary>
    /// Gets or Sets NextActivityReminders
    /// </summary>
    [DataMember(Name = "nextActivityReminders", EmitDefaultValue = false)]
    public List<WfmUserScheduleAdherenceUpdatedMuTopicUserNextActivityReminder> NextActivityReminders { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WfmUserScheduleAdherenceUpdatedMuTopicUserScheduleAdherenceUpdate {\n");

        sb.Append("  User: ").Append(User).Append("\n");
        sb.Append("  ManagementUnitId: ").Append(ManagementUnitId).Append("\n");
        sb.Append("  Team: ").Append(Team).Append("\n");
        sb.Append("  ScheduledActivityCategory: ").Append(ScheduledActivityCategory).Append("\n");
        sb.Append("  ScheduledActivityCode: ").Append(ScheduledActivityCode).Append("\n");
        sb.Append("  SystemPresence: ").Append(SystemPresence).Append("\n");
        sb.Append("  OrganizationSecondaryPresenceId: ").Append(OrganizationSecondaryPresenceId).Append("\n");
        sb.Append("  RoutingStatus: ").Append(RoutingStatus).Append("\n");
        sb.Append("  ActualActivityCategory: ").Append(ActualActivityCategory).Append("\n");
        sb.Append("  IsOutOfOffice: ").Append(IsOutOfOffice).Append("\n");
        sb.Append("  AdherenceState: ").Append(AdherenceState).Append("\n");
        sb.Append("  Impact: ").Append(Impact).Append("\n");
        sb.Append("  AdherenceExplanation: ").Append(AdherenceExplanation).Append("\n");
        sb.Append("  AdherenceChangeTime: ").Append(AdherenceChangeTime).Append("\n");
        sb.Append("  PresenceUpdateTime: ").Append(PresenceUpdateTime).Append("\n");
        sb.Append("  ActiveQueues: ").Append(ActiveQueues).Append("\n");
        sb.Append("  ActiveQueuesModifiedTime: ").Append(ActiveQueuesModifiedTime).Append("\n");
        sb.Append("  RemovedFromManagementUnit: ").Append(RemovedFromManagementUnit).Append("\n");
        sb.Append("  SuppressOnTimeReminder: ").Append(SuppressOnTimeReminder).Append("\n");
        sb.Append("  NextActivityReminders: ").Append(NextActivityReminders).Append("\n");
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
        return Equals(obj as WfmUserScheduleAdherenceUpdatedMuTopicUserScheduleAdherenceUpdate);
    }

    /// <summary>
    /// Returns true if WfmUserScheduleAdherenceUpdatedMuTopicUserScheduleAdherenceUpdate instances are equal
    /// </summary>
    /// <param name="other">Instance of WfmUserScheduleAdherenceUpdatedMuTopicUserScheduleAdherenceUpdate to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WfmUserScheduleAdherenceUpdatedMuTopicUserScheduleAdherenceUpdate other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                User == other.User ||
                User != null &&
                User.Equals(other.User)
            ) &&
            (
                ManagementUnitId == other.ManagementUnitId ||
                ManagementUnitId != null &&
                ManagementUnitId.Equals(other.ManagementUnitId)
            ) &&
            (
                Team == other.Team ||
                Team != null &&
                Team.Equals(other.Team)
            ) &&
            (
                ScheduledActivityCategory == other.ScheduledActivityCategory ||
                ScheduledActivityCategory != null &&
                ScheduledActivityCategory.Equals(other.ScheduledActivityCategory)
            ) &&
            (
                ScheduledActivityCode == other.ScheduledActivityCode ||
                ScheduledActivityCode != null &&
                ScheduledActivityCode.Equals(other.ScheduledActivityCode)
            ) &&
            (
                SystemPresence == other.SystemPresence ||
                SystemPresence != null &&
                SystemPresence.Equals(other.SystemPresence)
            ) &&
            (
                OrganizationSecondaryPresenceId == other.OrganizationSecondaryPresenceId ||
                OrganizationSecondaryPresenceId != null &&
                OrganizationSecondaryPresenceId.Equals(other.OrganizationSecondaryPresenceId)
            ) &&
            (
                RoutingStatus == other.RoutingStatus ||
                RoutingStatus != null &&
                RoutingStatus.Equals(other.RoutingStatus)
            ) &&
            (
                ActualActivityCategory == other.ActualActivityCategory ||
                ActualActivityCategory != null &&
                ActualActivityCategory.Equals(other.ActualActivityCategory)
            ) &&
            (
                IsOutOfOffice == other.IsOutOfOffice ||
                IsOutOfOffice != null &&
                IsOutOfOffice.Equals(other.IsOutOfOffice)
            ) &&
            (
                AdherenceState == other.AdherenceState ||
                AdherenceState != null &&
                AdherenceState.Equals(other.AdherenceState)
            ) &&
            (
                Impact == other.Impact ||
                Impact != null &&
                Impact.Equals(other.Impact)
            ) &&
            (
                AdherenceExplanation == other.AdherenceExplanation ||
                AdherenceExplanation != null &&
                AdherenceExplanation.Equals(other.AdherenceExplanation)
            ) &&
            (
                AdherenceChangeTime == other.AdherenceChangeTime ||
                AdherenceChangeTime != null &&
                AdherenceChangeTime.Equals(other.AdherenceChangeTime)
            ) &&
            (
                PresenceUpdateTime == other.PresenceUpdateTime ||
                PresenceUpdateTime != null &&
                PresenceUpdateTime.Equals(other.PresenceUpdateTime)
            ) &&
            (
                ActiveQueues == other.ActiveQueues ||
                ActiveQueues != null &&
                ActiveQueues.SequenceEqual(other.ActiveQueues)
            ) &&
            (
                ActiveQueuesModifiedTime == other.ActiveQueuesModifiedTime ||
                ActiveQueuesModifiedTime != null &&
                ActiveQueuesModifiedTime.Equals(other.ActiveQueuesModifiedTime)
            ) &&
            (
                RemovedFromManagementUnit == other.RemovedFromManagementUnit ||
                RemovedFromManagementUnit != null &&
                RemovedFromManagementUnit.Equals(other.RemovedFromManagementUnit)
            ) &&
            (
                SuppressOnTimeReminder == other.SuppressOnTimeReminder ||
                SuppressOnTimeReminder != null &&
                SuppressOnTimeReminder.Equals(other.SuppressOnTimeReminder)
            ) &&
            (
                NextActivityReminders == other.NextActivityReminders ||
                NextActivityReminders != null &&
                NextActivityReminders.SequenceEqual(other.NextActivityReminders)
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
            if (User != null)
            {
                hash = hash * 59 + User.GetHashCode();
            }

            if (ManagementUnitId != null)
            {
                hash = hash * 59 + ManagementUnitId.GetHashCode();
            }

            if (Team != null)
            {
                hash = hash * 59 + Team.GetHashCode();
            }

            if (ScheduledActivityCategory != null)
            {
                hash = hash * 59 + ScheduledActivityCategory.GetHashCode();
            }

            if (ScheduledActivityCode != null)
            {
                hash = hash * 59 + ScheduledActivityCode.GetHashCode();
            }

            if (SystemPresence != null)
            {
                hash = hash * 59 + SystemPresence.GetHashCode();
            }

            if (OrganizationSecondaryPresenceId != null)
            {
                hash = hash * 59 + OrganizationSecondaryPresenceId.GetHashCode();
            }

            if (RoutingStatus != null)
            {
                hash = hash * 59 + RoutingStatus.GetHashCode();
            }

            if (ActualActivityCategory != null)
            {
                hash = hash * 59 + ActualActivityCategory.GetHashCode();
            }

            if (IsOutOfOffice != null)
            {
                hash = hash * 59 + IsOutOfOffice.GetHashCode();
            }

            if (AdherenceState != null)
            {
                hash = hash * 59 + AdherenceState.GetHashCode();
            }

            if (Impact != null)
            {
                hash = hash * 59 + Impact.GetHashCode();
            }

            if (AdherenceExplanation != null)
            {
                hash = hash * 59 + AdherenceExplanation.GetHashCode();
            }

            if (AdherenceChangeTime != null)
            {
                hash = hash * 59 + AdherenceChangeTime.GetHashCode();
            }

            if (PresenceUpdateTime != null)
            {
                hash = hash * 59 + PresenceUpdateTime.GetHashCode();
            }

            if (ActiveQueues != null)
            {
                hash = hash * 59 + ActiveQueues.GetHashCode();
            }

            if (ActiveQueuesModifiedTime != null)
            {
                hash = hash * 59 + ActiveQueuesModifiedTime.GetHashCode();
            }

            if (RemovedFromManagementUnit != null)
            {
                hash = hash * 59 + RemovedFromManagementUnit.GetHashCode();
            }

            if (SuppressOnTimeReminder != null)
            {
                hash = hash * 59 + SuppressOnTimeReminder.GetHashCode();
            }

            if (NextActivityReminders != null)
            {
                hash = hash * 59 + NextActivityReminders.GetHashCode();
            }

            return hash;
        }
    }
}
