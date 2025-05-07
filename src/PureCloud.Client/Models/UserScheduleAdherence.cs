using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// UserScheduleAdherence
/// </summary>

public partial class UserScheduleAdherence : IEquatable<UserScheduleAdherence>
{
    /// <summary>
    /// Activity for which the user is scheduled
    /// </summary>
    /// <value>Activity for which the user is scheduled</value>
    
    public enum ScheduledActivityCategoryEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Onqueuework for "OnQueueWork"
        /// </summary>
        [EnumMember(Value = "OnQueueWork")]
        Onqueuework,

        /// <summary>
        /// Enum Break for "Break"
        /// </summary>
        [EnumMember(Value = "Break")]
        Break,

        /// <summary>
        /// Enum Meal for "Meal"
        /// </summary>
        [EnumMember(Value = "Meal")]
        Meal,

        /// <summary>
        /// Enum Meeting for "Meeting"
        /// </summary>
        [EnumMember(Value = "Meeting")]
        Meeting,

        /// <summary>
        /// Enum Offqueuework for "OffQueueWork"
        /// </summary>
        [EnumMember(Value = "OffQueueWork")]
        Offqueuework,

        /// <summary>
        /// Enum Timeoff for "TimeOff"
        /// </summary>
        [EnumMember(Value = "TimeOff")]
        Timeoff,

        /// <summary>
        /// Enum Training for "Training"
        /// </summary>
        [EnumMember(Value = "Training")]
        Training,

        /// <summary>
        /// Enum Unavailable for "Unavailable"
        /// </summary>
        [EnumMember(Value = "Unavailable")]
        Unavailable,

        /// <summary>
        /// Enum Unscheduled for "Unscheduled"
        /// </summary>
        [EnumMember(Value = "Unscheduled")]
        Unscheduled
    }
    /// <summary>
    /// Actual underlying system presence value
    /// </summary>
    /// <value>Actual underlying system presence value</value>
    
    public enum SystemPresenceEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Available for "Available"
        /// </summary>
        [EnumMember(Value = "Available")]
        Available,

        /// <summary>
        /// Enum Away for "Away"
        /// </summary>
        [EnumMember(Value = "Away")]
        Away,

        /// <summary>
        /// Enum Busy for "Busy"
        /// </summary>
        [EnumMember(Value = "Busy")]
        Busy,

        /// <summary>
        /// Enum Offline for "Offline"
        /// </summary>
        [EnumMember(Value = "Offline")]
        Offline,

        /// <summary>
        /// Enum Idle for "Idle"
        /// </summary>
        [EnumMember(Value = "Idle")]
        Idle,

        /// <summary>
        /// Enum Onqueue for "OnQueue"
        /// </summary>
        [EnumMember(Value = "OnQueue")]
        Onqueue,

        /// <summary>
        /// Enum Meal for "Meal"
        /// </summary>
        [EnumMember(Value = "Meal")]
        Meal,

        /// <summary>
        /// Enum Training for "Training"
        /// </summary>
        [EnumMember(Value = "Training")]
        Training,

        /// <summary>
        /// Enum Meeting for "Meeting"
        /// </summary>
        [EnumMember(Value = "Meeting")]
        Meeting,

        /// <summary>
        /// Enum Break for "Break"
        /// </summary>
        [EnumMember(Value = "Break")]
        Break
    }
    /// <summary>
    /// Actual underlying routing status, used to determine whether a user is actually in adherence when OnQueue
    /// </summary>
    /// <value>Actual underlying routing status, used to determine whether a user is actually in adherence when OnQueue</value>
    
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
        Communicating
    }
    /// <summary>
    /// Activity in which the user is actually engaged
    /// </summary>
    /// <value>Activity in which the user is actually engaged</value>
    
    public enum ActualActivityCategoryEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Onqueuework for "OnQueueWork"
        /// </summary>
        [EnumMember(Value = "OnQueueWork")]
        Onqueuework,

        /// <summary>
        /// Enum Break for "Break"
        /// </summary>
        [EnumMember(Value = "Break")]
        Break,

        /// <summary>
        /// Enum Meal for "Meal"
        /// </summary>
        [EnumMember(Value = "Meal")]
        Meal,

        /// <summary>
        /// Enum Meeting for "Meeting"
        /// </summary>
        [EnumMember(Value = "Meeting")]
        Meeting,

        /// <summary>
        /// Enum Offqueuework for "OffQueueWork"
        /// </summary>
        [EnumMember(Value = "OffQueueWork")]
        Offqueuework,

        /// <summary>
        /// Enum Timeoff for "TimeOff"
        /// </summary>
        [EnumMember(Value = "TimeOff")]
        Timeoff,

        /// <summary>
        /// Enum Training for "Training"
        /// </summary>
        [EnumMember(Value = "Training")]
        Training,

        /// <summary>
        /// Enum Unavailable for "Unavailable"
        /// </summary>
        [EnumMember(Value = "Unavailable")]
        Unavailable,

        /// <summary>
        /// Enum Unscheduled for "Unscheduled"
        /// </summary>
        [EnumMember(Value = "Unscheduled")]
        Unscheduled
    }
    /// <summary>
    /// The user's current adherence state
    /// </summary>
    /// <value>The user's current adherence state</value>
    
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
    /// The impact of the user's current adherenceState
    /// </summary>
    /// <value>The impact of the user's current adherenceState</value>
    
    public enum ImpactEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Positive for "Positive"
        /// </summary>
        [EnumMember(Value = "Positive")]
        Positive,

        /// <summary>
        /// Enum Negative for "Negative"
        /// </summary>
        [EnumMember(Value = "Negative")]
        Negative,

        /// <summary>
        /// Enum Neutral for "Neutral"
        /// </summary>
        [EnumMember(Value = "Neutral")]
        Neutral,

        /// <summary>
        /// Enum Unknown for "Unknown"
        /// </summary>
        [EnumMember(Value = "Unknown")]
        Unknown
    }
    /// <summary>
    /// Activity for which the user is scheduled
    /// </summary>
    /// <value>Activity for which the user is scheduled</value>
    [JsonPropertyName("scheduledActivityCategory")]
    public ScheduledActivityCategoryEnum? ScheduledActivityCategory { get; set; }
    /// <summary>
    /// Actual underlying system presence value
    /// </summary>
    /// <value>Actual underlying system presence value</value>
    [JsonPropertyName("systemPresence")]
    public SystemPresenceEnum? SystemPresence { get; set; }
    /// <summary>
    /// Actual underlying routing status, used to determine whether a user is actually in adherence when OnQueue
    /// </summary>
    /// <value>Actual underlying routing status, used to determine whether a user is actually in adherence when OnQueue</value>
    [JsonPropertyName("routingStatus")]
    public RoutingStatusEnum? RoutingStatus { get; set; }
    /// <summary>
    /// Activity in which the user is actually engaged
    /// </summary>
    /// <value>Activity in which the user is actually engaged</value>
    [JsonPropertyName("actualActivityCategory")]
    public ActualActivityCategoryEnum? ActualActivityCategory { get; set; }
    /// <summary>
    /// The user's current adherence state
    /// </summary>
    /// <value>The user's current adherence state</value>
    [JsonPropertyName("adherenceState")]
    public AdherenceStateEnum? AdherenceState { get; set; }
    /// <summary>
    /// The impact of the user's current adherenceState
    /// </summary>
    /// <value>The impact of the user's current adherenceState</value>
    [JsonPropertyName("impact")]
    public ImpactEnum? Impact { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="UserScheduleAdherence" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    public UserScheduleAdherence(string Name = null)
    {
        this.Name = Name;

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
    /// The user for whom this status applies
    /// </summary>
    /// <value>The user for whom this status applies</value>
    [JsonPropertyName("user")]
    public UserReference User { get; set; }



    /// <summary>
    /// The business unit to which this user belongs
    /// </summary>
    /// <value>The business unit to which this user belongs</value>
    [JsonPropertyName("businessUnit")]
    public BusinessUnitReference BusinessUnit { get; set; }



    /// <summary>
    /// The management unit to which this user belongs
    /// </summary>
    /// <value>The management unit to which this user belongs</value>
    [JsonPropertyName("managementUnit")]
    public ManagementUnitReference ManagementUnit { get; set; }



    /// <summary>
    /// The team to which this user belongs
    /// </summary>
    /// <value>The team to which this user belongs</value>
    [JsonPropertyName("team")]
    public TeamReference Team { get; set; }





    /// <summary>
    /// Activity code for which the user is currently scheduled
    /// </summary>
    /// <value>Activity code for which the user is currently scheduled</value>
    [JsonPropertyName("scheduledActivityCode")]
    public ActivityCodeSummary ScheduledActivityCode { get; set; }





    /// <summary>
    /// Organization Secondary Presence Id.
    /// </summary>
    /// <value>Organization Secondary Presence Id.</value>
    [JsonPropertyName("organizationSecondaryPresenceId")]
    public string OrganizationSecondaryPresenceId { get; set; }







    /// <summary>
    /// Whether the user is marked OutOfOffice
    /// </summary>
    /// <value>Whether the user is marked OutOfOffice</value>
    [JsonPropertyName("isOutOfOffice")]
    public bool? IsOutOfOffice { get; set; }







    /// <summary>
    /// Currently applicable explanation for the adherence state
    /// </summary>
    /// <value>Currently applicable explanation for the adherence state</value>
    [JsonPropertyName("adherenceExplanation")]
    public RealTimeAdherenceExplanation AdherenceExplanation { get; set; }



    /// <summary>
    /// Time when the user entered the current adherenceState in ISO-8601 format
    /// </summary>
    /// <value>Time when the user entered the current adherenceState in ISO-8601 format</value>
    [JsonPropertyName("timeOfAdherenceChange")]
    public DateTime? TimeOfAdherenceChange { get; set; }



    /// <summary>
    /// Time when presence was last updated. Used to calculate time in current status. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Time when presence was last updated. Used to calculate time in current status. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("presenceUpdateTime")]
    public DateTime? PresenceUpdateTime { get; set; }



    /// <summary>
    /// The list of queues to which this user is joined
    /// </summary>
    /// <value>The list of queues to which this user is joined</value>
    [JsonPropertyName("activeQueues")]
    public List<QueueReference> ActiveQueues { get; set; }



    /// <summary>
    /// Time when the list of active queues for this user was last updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Time when the list of active queues for this user was last updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("activeQueuesModifiedTime")]
    public DateTime? ActiveQueuesModifiedTime { get; set; }



    /// <summary>
    /// For notification purposes. Used to indicate that a user was removed from the management unit
    /// </summary>
    /// <value>For notification purposes. Used to indicate that a user was removed from the management unit</value>
    [JsonPropertyName("removedFromManagementUnit")]
    public bool? RemovedFromManagementUnit { get; set; }



    /// <summary>
    /// A list of upcoming activities for which the user is scheduled
    /// </summary>
    /// <value>A list of upcoming activities for which the user is scheduled</value>
    [JsonPropertyName("nextActivityReminders")]
    public List<UserNextActivityReminder> NextActivityReminders { get; set; }



    /// <summary>
    /// Indicates whether the on-time adherence notification should be suppressed for the user
    /// </summary>
    /// <value>Indicates whether the on-time adherence notification should be suppressed for the user</value>
    [JsonPropertyName("suppressOnTimeReminder")]
    public bool? SuppressOnTimeReminder { get; set; }



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
        sb.Append("class UserScheduleAdherence {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  User: ").Append(User).Append("\n");
        sb.Append("  BusinessUnit: ").Append(BusinessUnit).Append("\n");
        sb.Append("  ManagementUnit: ").Append(ManagementUnit).Append("\n");
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
        sb.Append("  TimeOfAdherenceChange: ").Append(TimeOfAdherenceChange).Append("\n");
        sb.Append("  PresenceUpdateTime: ").Append(PresenceUpdateTime).Append("\n");
        sb.Append("  ActiveQueues: ").Append(ActiveQueues).Append("\n");
        sb.Append("  ActiveQueuesModifiedTime: ").Append(ActiveQueuesModifiedTime).Append("\n");
        sb.Append("  RemovedFromManagementUnit: ").Append(RemovedFromManagementUnit).Append("\n");
        sb.Append("  NextActivityReminders: ").Append(NextActivityReminders).Append("\n");
        sb.Append("  SuppressOnTimeReminder: ").Append(SuppressOnTimeReminder).Append("\n");
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
        return Equals(obj as UserScheduleAdherence);
    }

    /// <summary>
    /// Returns true if UserScheduleAdherence instances are equal
    /// </summary>
    /// <param name="other">Instance of UserScheduleAdherence to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(UserScheduleAdherence other)
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
                BusinessUnit == other.BusinessUnit ||
                BusinessUnit != null &&
                BusinessUnit.Equals(other.BusinessUnit)
            ) &&
            (
                ManagementUnit == other.ManagementUnit ||
                ManagementUnit != null &&
                ManagementUnit.Equals(other.ManagementUnit)
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
                TimeOfAdherenceChange == other.TimeOfAdherenceChange ||
                TimeOfAdherenceChange != null &&
                TimeOfAdherenceChange.Equals(other.TimeOfAdherenceChange)
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
                NextActivityReminders == other.NextActivityReminders ||
                NextActivityReminders != null &&
                NextActivityReminders.SequenceEqual(other.NextActivityReminders)
            ) &&
            (
                SuppressOnTimeReminder == other.SuppressOnTimeReminder ||
                SuppressOnTimeReminder != null &&
                SuppressOnTimeReminder.Equals(other.SuppressOnTimeReminder)
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

            if (BusinessUnit != null)
            {
                hash = hash * 59 + BusinessUnit.GetHashCode();
            }

            if (ManagementUnit != null)
            {
                hash = hash * 59 + ManagementUnit.GetHashCode();
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

            if (TimeOfAdherenceChange != null)
            {
                hash = hash * 59 + TimeOfAdherenceChange.GetHashCode();
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

            if (NextActivityReminders != null)
            {
                hash = hash * 59 + NextActivityReminders.GetHashCode();
            }

            if (SuppressOnTimeReminder != null)
            {
                hash = hash * 59 + SuppressOnTimeReminder.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
