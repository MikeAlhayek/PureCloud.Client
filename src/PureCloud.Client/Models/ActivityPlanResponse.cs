using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ActivityPlanResponse
/// </summary>

public partial class ActivityPlanResponse : IEquatable<ActivityPlanResponse>
{
    /// <summary>
    /// The type of the activity plan
    /// </summary>
    /// <value>The type of the activity plan</value>
    
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
        /// Enum Individual for "Individual"
        /// </summary>
        [EnumMember(Value = "Individual")]
        Individual,

        /// <summary>
        /// Enum Group for "Group"
        /// </summary>
        [EnumMember(Value = "Group")]
        Group
    }
    /// <summary>
    /// The optimization objective of this activity plan
    /// </summary>
    /// <value>The optimization objective of this activity plan</value>
    
    public enum OptimizationObjectiveEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Favorservicegoals for "FavorServiceGoals"
        /// </summary>
        [EnumMember(Value = "FavorServiceGoals")]
        Favorservicegoals,

        /// <summary>
        /// Enum Favorschedulingall for "FavorSchedulingAll"
        /// </summary>
        [EnumMember(Value = "FavorSchedulingAll")]
        Favorschedulingall
    }
    /// <summary>
    /// The state of this activity plan
    /// </summary>
    /// <value>The state of this activity plan</value>
    
    public enum StateEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Active for "Active"
        /// </summary>
        [EnumMember(Value = "Active")]
        Active,

        /// <summary>
        /// Enum Inactive for "Inactive"
        /// </summary>
        [EnumMember(Value = "Inactive")]
        Inactive
    }
    /// <summary>
    /// The type of the activity plan
    /// </summary>
    /// <value>The type of the activity plan</value>
    [JsonPropertyName("type")]
    public TypeEnum? Type { get; set; }
    /// <summary>
    /// The optimization objective of this activity plan
    /// </summary>
    /// <value>The optimization objective of this activity plan</value>
    [JsonPropertyName("optimizationObjective")]
    public OptimizationObjectiveEnum? OptimizationObjective { get; set; }
    /// <summary>
    /// The state of this activity plan
    /// </summary>
    /// <value>The state of this activity plan</value>
    [JsonPropertyName("state")]
    public StateEnum? State { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="ActivityPlanResponse" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected ActivityPlanResponse() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ActivityPlanResponse" /> class.
    /// </summary>
    /// <param name="Name">The name of the activity plan (required).</param>
    /// <param name="ManagementUnits">The management units to which this activity plan applies. Empty list or null means this activity plan applies to the entire business unit.</param>
    /// <param name="Description">The description of this activity plan (required).</param>
    /// <param name="ActivityCode">The activity code associated with this activity plan. It is recommended to load and cache the entire list of activity codes rather than look up individual codes (required).</param>
    /// <param name="Type">The type of the activity plan (required).</param>
    /// <param name="InitialSchedulePeriod">The initial schedule period of the activity plan (required).</param>
    /// <param name="LengthMinutes">The length of the activity in minutes (required).</param>
    /// <param name="GroupSettings">Group settings for this activity plan.</param>
    /// <param name="RecurrenceSettings">Recurrence settings for this activity plan.</param>
    /// <param name="AttendeesSearchRule">Attendee search rule for this activity plan.</param>
    /// <param name="Facilitated">Whether the sessions created by this activity plan should be facilitated (required).</param>
    /// <param name="FacilitatorsSearchRule">Facilitator search rule for this activity plan.</param>
    /// <param name="TransitionTimeMinutes">Transition time in minutes between facilitated sessions (required).</param>
    /// <param name="ServiceGoalImpactOverrides">Allowable service goal impact override settings for this activity plan.</param>
    /// <param name="OptimizationObjective">The optimization objective of this activity plan (required).</param>
    /// <param name="FixedAvailability">Fixed availability configuration for this activity plan.</param>
    /// <param name="State">The state of this activity plan (required).</param>
    /// <param name="CountsAsPaidTime">Whether the activity should count as paid time (required).</param>
    /// <param name="CreatedDate">The date the activity plan was created, in ISO-8601 format (required).</param>
    /// <param name="CreatedBy">The user who created this activity plan (required).</param>
    /// <param name="ModifiedDate">The date the activity plan was modified, in ISO-8601 format (required).</param>
    /// <param name="ModifiedBy">The last user to modify this activity plan. The id may be &#39;System&#39; if it was an automated process (required).</param>
    /// <param name="LastRunDate">The date the activity plan was last run, in ISO-8601 format.</param>
    /// <param name="LastRunBy">The last user to run this activity plan.</param>
    public ActivityPlanResponse(string Name = null, List<ManagementUnitReference> ManagementUnits = null, string Description = null, ActivityCodeReference ActivityCode = null, TypeEnum? Type = null, SchedulingPeriod InitialSchedulePeriod = null, int? LengthMinutes = null, GroupSettings GroupSettings = null, RecurrenceSettings RecurrenceSettings = null, UserSearchRule AttendeesSearchRule = null, bool? Facilitated = null, UserSearchRule FacilitatorsSearchRule = null, int? TransitionTimeMinutes = null, ActivityPlanServiceGoalImpactOverrides ServiceGoalImpactOverrides = null, OptimizationObjectiveEnum? OptimizationObjective = null, List<FixedAvailability> FixedAvailability = null, StateEnum? State = null, bool? CountsAsPaidTime = null, DateTime? CreatedDate = null, UserReference CreatedBy = null, DateTime? ModifiedDate = null, UserReference ModifiedBy = null, DateTime? LastRunDate = null, UserReference LastRunBy = null)
    {
        this.Name = Name;
        this.ManagementUnits = ManagementUnits;
        this.Description = Description;
        this.ActivityCode = ActivityCode;
        this.Type = Type;
        this.InitialSchedulePeriod = InitialSchedulePeriod;
        this.LengthMinutes = LengthMinutes;
        this.GroupSettings = GroupSettings;
        this.RecurrenceSettings = RecurrenceSettings;
        this.AttendeesSearchRule = AttendeesSearchRule;
        this.Facilitated = Facilitated;
        this.FacilitatorsSearchRule = FacilitatorsSearchRule;
        this.TransitionTimeMinutes = TransitionTimeMinutes;
        this.ServiceGoalImpactOverrides = ServiceGoalImpactOverrides;
        this.OptimizationObjective = OptimizationObjective;
        this.FixedAvailability = FixedAvailability;
        this.State = State;
        this.CountsAsPaidTime = CountsAsPaidTime;
        this.CreatedDate = CreatedDate;
        this.CreatedBy = CreatedBy;
        this.ModifiedDate = ModifiedDate;
        this.ModifiedBy = ModifiedBy;
        this.LastRunDate = LastRunDate;
        this.LastRunBy = LastRunBy;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// The name of the activity plan
    /// </summary>
    /// <value>The name of the activity plan</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// The management units to which this activity plan applies. Empty list or null means this activity plan applies to the entire business unit
    /// </summary>
    /// <value>The management units to which this activity plan applies. Empty list or null means this activity plan applies to the entire business unit</value>
    [JsonPropertyName("managementUnits")]
    public List<ManagementUnitReference> ManagementUnits { get; set; }



    /// <summary>
    /// The description of this activity plan
    /// </summary>
    /// <value>The description of this activity plan</value>
    [JsonPropertyName("description")]
    public string Description { get; set; }



    /// <summary>
    /// The activity code associated with this activity plan. It is recommended to load and cache the entire list of activity codes rather than look up individual codes
    /// </summary>
    /// <value>The activity code associated with this activity plan. It is recommended to load and cache the entire list of activity codes rather than look up individual codes</value>
    [JsonPropertyName("activityCode")]
    public ActivityCodeReference ActivityCode { get; set; }





    /// <summary>
    /// The initial schedule period of the activity plan
    /// </summary>
    /// <value>The initial schedule period of the activity plan</value>
    [JsonPropertyName("initialSchedulePeriod")]
    public SchedulingPeriod InitialSchedulePeriod { get; set; }



    /// <summary>
    /// The length of the activity in minutes
    /// </summary>
    /// <value>The length of the activity in minutes</value>
    [JsonPropertyName("lengthMinutes")]
    public int? LengthMinutes { get; set; }



    /// <summary>
    /// Group settings for this activity plan
    /// </summary>
    /// <value>Group settings for this activity plan</value>
    [JsonPropertyName("groupSettings")]
    public GroupSettings GroupSettings { get; set; }



    /// <summary>
    /// Recurrence settings for this activity plan
    /// </summary>
    /// <value>Recurrence settings for this activity plan</value>
    [JsonPropertyName("recurrenceSettings")]
    public RecurrenceSettings RecurrenceSettings { get; set; }



    /// <summary>
    /// Attendee search rule for this activity plan
    /// </summary>
    /// <value>Attendee search rule for this activity plan</value>
    [JsonPropertyName("attendeesSearchRule")]
    public UserSearchRule AttendeesSearchRule { get; set; }



    /// <summary>
    /// Whether the sessions created by this activity plan should be facilitated
    /// </summary>
    /// <value>Whether the sessions created by this activity plan should be facilitated</value>
    [JsonPropertyName("facilitated")]
    public bool? Facilitated { get; set; }



    /// <summary>
    /// Facilitator search rule for this activity plan
    /// </summary>
    /// <value>Facilitator search rule for this activity plan</value>
    [JsonPropertyName("facilitatorsSearchRule")]
    public UserSearchRule FacilitatorsSearchRule { get; set; }



    /// <summary>
    /// Transition time in minutes between facilitated sessions
    /// </summary>
    /// <value>Transition time in minutes between facilitated sessions</value>
    [JsonPropertyName("transitionTimeMinutes")]
    public int? TransitionTimeMinutes { get; set; }



    /// <summary>
    /// Allowable service goal impact override settings for this activity plan
    /// </summary>
    /// <value>Allowable service goal impact override settings for this activity plan</value>
    [JsonPropertyName("serviceGoalImpactOverrides")]
    public ActivityPlanServiceGoalImpactOverrides ServiceGoalImpactOverrides { get; set; }





    /// <summary>
    /// Fixed availability configuration for this activity plan
    /// </summary>
    /// <value>Fixed availability configuration for this activity plan</value>
    [JsonPropertyName("fixedAvailability")]
    public List<FixedAvailability> FixedAvailability { get; set; }





    /// <summary>
    /// Whether the activity should count as paid time
    /// </summary>
    /// <value>Whether the activity should count as paid time</value>
    [JsonPropertyName("countsAsPaidTime")]
    public bool? CountsAsPaidTime { get; set; }



    /// <summary>
    /// The date the activity plan was created, in ISO-8601 format
    /// </summary>
    /// <value>The date the activity plan was created, in ISO-8601 format</value>
    [JsonPropertyName("createdDate")]
    public DateTime? CreatedDate { get; set; }



    /// <summary>
    /// The user who created this activity plan
    /// </summary>
    /// <value>The user who created this activity plan</value>
    [JsonPropertyName("createdBy")]
    public UserReference CreatedBy { get; set; }



    /// <summary>
    /// The date the activity plan was modified, in ISO-8601 format
    /// </summary>
    /// <value>The date the activity plan was modified, in ISO-8601 format</value>
    [JsonPropertyName("modifiedDate")]
    public DateTime? ModifiedDate { get; set; }



    /// <summary>
    /// The last user to modify this activity plan. The id may be &#39;System&#39; if it was an automated process
    /// </summary>
    /// <value>The last user to modify this activity plan. The id may be &#39;System&#39; if it was an automated process</value>
    [JsonPropertyName("modifiedBy")]
    public UserReference ModifiedBy { get; set; }



    /// <summary>
    /// The date the activity plan was last run, in ISO-8601 format
    /// </summary>
    /// <value>The date the activity plan was last run, in ISO-8601 format</value>
    [JsonPropertyName("lastRunDate")]
    public DateTime? LastRunDate { get; set; }



    /// <summary>
    /// The last user to run this activity plan
    /// </summary>
    /// <value>The last user to run this activity plan</value>
    [JsonPropertyName("lastRunBy")]
    public UserReference LastRunBy { get; set; }



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
        sb.Append("class ActivityPlanResponse {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  ManagementUnits: ").Append(ManagementUnits).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  ActivityCode: ").Append(ActivityCode).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  InitialSchedulePeriod: ").Append(InitialSchedulePeriod).Append("\n");
        sb.Append("  LengthMinutes: ").Append(LengthMinutes).Append("\n");
        sb.Append("  GroupSettings: ").Append(GroupSettings).Append("\n");
        sb.Append("  RecurrenceSettings: ").Append(RecurrenceSettings).Append("\n");
        sb.Append("  AttendeesSearchRule: ").Append(AttendeesSearchRule).Append("\n");
        sb.Append("  Facilitated: ").Append(Facilitated).Append("\n");
        sb.Append("  FacilitatorsSearchRule: ").Append(FacilitatorsSearchRule).Append("\n");
        sb.Append("  TransitionTimeMinutes: ").Append(TransitionTimeMinutes).Append("\n");
        sb.Append("  ServiceGoalImpactOverrides: ").Append(ServiceGoalImpactOverrides).Append("\n");
        sb.Append("  OptimizationObjective: ").Append(OptimizationObjective).Append("\n");
        sb.Append("  FixedAvailability: ").Append(FixedAvailability).Append("\n");
        sb.Append("  State: ").Append(State).Append("\n");
        sb.Append("  CountsAsPaidTime: ").Append(CountsAsPaidTime).Append("\n");
        sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
        sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
        sb.Append("  ModifiedDate: ").Append(ModifiedDate).Append("\n");
        sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
        sb.Append("  LastRunDate: ").Append(LastRunDate).Append("\n");
        sb.Append("  LastRunBy: ").Append(LastRunBy).Append("\n");
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
        return Equals(obj as ActivityPlanResponse);
    }

    /// <summary>
    /// Returns true if ActivityPlanResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of ActivityPlanResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ActivityPlanResponse other)
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
                ManagementUnits == other.ManagementUnits ||
                ManagementUnits != null &&
                ManagementUnits.SequenceEqual(other.ManagementUnits)
            ) &&
            (
                Description == other.Description ||
                Description != null &&
                Description.Equals(other.Description)
            ) &&
            (
                ActivityCode == other.ActivityCode ||
                ActivityCode != null &&
                ActivityCode.Equals(other.ActivityCode)
            ) &&
            (
                Type == other.Type ||
                Type != null &&
                Type.Equals(other.Type)
            ) &&
            (
                InitialSchedulePeriod == other.InitialSchedulePeriod ||
                InitialSchedulePeriod != null &&
                InitialSchedulePeriod.Equals(other.InitialSchedulePeriod)
            ) &&
            (
                LengthMinutes == other.LengthMinutes ||
                LengthMinutes != null &&
                LengthMinutes.Equals(other.LengthMinutes)
            ) &&
            (
                GroupSettings == other.GroupSettings ||
                GroupSettings != null &&
                GroupSettings.Equals(other.GroupSettings)
            ) &&
            (
                RecurrenceSettings == other.RecurrenceSettings ||
                RecurrenceSettings != null &&
                RecurrenceSettings.Equals(other.RecurrenceSettings)
            ) &&
            (
                AttendeesSearchRule == other.AttendeesSearchRule ||
                AttendeesSearchRule != null &&
                AttendeesSearchRule.Equals(other.AttendeesSearchRule)
            ) &&
            (
                Facilitated == other.Facilitated ||
                Facilitated != null &&
                Facilitated.Equals(other.Facilitated)
            ) &&
            (
                FacilitatorsSearchRule == other.FacilitatorsSearchRule ||
                FacilitatorsSearchRule != null &&
                FacilitatorsSearchRule.Equals(other.FacilitatorsSearchRule)
            ) &&
            (
                TransitionTimeMinutes == other.TransitionTimeMinutes ||
                TransitionTimeMinutes != null &&
                TransitionTimeMinutes.Equals(other.TransitionTimeMinutes)
            ) &&
            (
                ServiceGoalImpactOverrides == other.ServiceGoalImpactOverrides ||
                ServiceGoalImpactOverrides != null &&
                ServiceGoalImpactOverrides.Equals(other.ServiceGoalImpactOverrides)
            ) &&
            (
                OptimizationObjective == other.OptimizationObjective ||
                OptimizationObjective != null &&
                OptimizationObjective.Equals(other.OptimizationObjective)
            ) &&
            (
                FixedAvailability == other.FixedAvailability ||
                FixedAvailability != null &&
                FixedAvailability.SequenceEqual(other.FixedAvailability)
            ) &&
            (
                State == other.State ||
                State != null &&
                State.Equals(other.State)
            ) &&
            (
                CountsAsPaidTime == other.CountsAsPaidTime ||
                CountsAsPaidTime != null &&
                CountsAsPaidTime.Equals(other.CountsAsPaidTime)
            ) &&
            (
                CreatedDate == other.CreatedDate ||
                CreatedDate != null &&
                CreatedDate.Equals(other.CreatedDate)
            ) &&
            (
                CreatedBy == other.CreatedBy ||
                CreatedBy != null &&
                CreatedBy.Equals(other.CreatedBy)
            ) &&
            (
                ModifiedDate == other.ModifiedDate ||
                ModifiedDate != null &&
                ModifiedDate.Equals(other.ModifiedDate)
            ) &&
            (
                ModifiedBy == other.ModifiedBy ||
                ModifiedBy != null &&
                ModifiedBy.Equals(other.ModifiedBy)
            ) &&
            (
                LastRunDate == other.LastRunDate ||
                LastRunDate != null &&
                LastRunDate.Equals(other.LastRunDate)
            ) &&
            (
                LastRunBy == other.LastRunBy ||
                LastRunBy != null &&
                LastRunBy.Equals(other.LastRunBy)
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

            if (ManagementUnits != null)
            {
                hash = hash * 59 + ManagementUnits.GetHashCode();
            }

            if (Description != null)
            {
                hash = hash * 59 + Description.GetHashCode();
            }

            if (ActivityCode != null)
            {
                hash = hash * 59 + ActivityCode.GetHashCode();
            }

            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
            }

            if (InitialSchedulePeriod != null)
            {
                hash = hash * 59 + InitialSchedulePeriod.GetHashCode();
            }

            if (LengthMinutes != null)
            {
                hash = hash * 59 + LengthMinutes.GetHashCode();
            }

            if (GroupSettings != null)
            {
                hash = hash * 59 + GroupSettings.GetHashCode();
            }

            if (RecurrenceSettings != null)
            {
                hash = hash * 59 + RecurrenceSettings.GetHashCode();
            }

            if (AttendeesSearchRule != null)
            {
                hash = hash * 59 + AttendeesSearchRule.GetHashCode();
            }

            if (Facilitated != null)
            {
                hash = hash * 59 + Facilitated.GetHashCode();
            }

            if (FacilitatorsSearchRule != null)
            {
                hash = hash * 59 + FacilitatorsSearchRule.GetHashCode();
            }

            if (TransitionTimeMinutes != null)
            {
                hash = hash * 59 + TransitionTimeMinutes.GetHashCode();
            }

            if (ServiceGoalImpactOverrides != null)
            {
                hash = hash * 59 + ServiceGoalImpactOverrides.GetHashCode();
            }

            if (OptimizationObjective != null)
            {
                hash = hash * 59 + OptimizationObjective.GetHashCode();
            }

            if (FixedAvailability != null)
            {
                hash = hash * 59 + FixedAvailability.GetHashCode();
            }

            if (State != null)
            {
                hash = hash * 59 + State.GetHashCode();
            }

            if (CountsAsPaidTime != null)
            {
                hash = hash * 59 + CountsAsPaidTime.GetHashCode();
            }

            if (CreatedDate != null)
            {
                hash = hash * 59 + CreatedDate.GetHashCode();
            }

            if (CreatedBy != null)
            {
                hash = hash * 59 + CreatedBy.GetHashCode();
            }

            if (ModifiedDate != null)
            {
                hash = hash * 59 + ModifiedDate.GetHashCode();
            }

            if (ModifiedBy != null)
            {
                hash = hash * 59 + ModifiedBy.GetHashCode();
            }

            if (LastRunDate != null)
            {
                hash = hash * 59 + LastRunDate.GetHashCode();
            }

            if (LastRunBy != null)
            {
                hash = hash * 59 + LastRunBy.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
