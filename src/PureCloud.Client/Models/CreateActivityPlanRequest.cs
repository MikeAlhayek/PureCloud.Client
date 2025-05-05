using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// CreateActivityPlanRequest
/// </summary>

public partial class CreateActivityPlanRequest : IEquatable<CreateActivityPlanRequest>
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
    /// Initializes a new instance of the <see cref="CreateActivityPlanRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected CreateActivityPlanRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="CreateActivityPlanRequest" /> class.
    /// </summary>
    /// <param name="Name">The name of the activity plan (required).</param>
    /// <param name="ManagementUnitIds">The management units to which this activity plan applies. Empty list or null means this activity plan applies to the entire business unit.</param>
    /// <param name="Description">The description of the activity plan.</param>
    /// <param name="ActivityCodeId">The activity code associated with the activity plan (required).</param>
    /// <param name="Type">The type of the activity plan (required).</param>
    /// <param name="LengthMinutes">The length in minutes of the activity plan (required).</param>
    /// <param name="InitialSchedulePeriod">The initial scheduling period for the activity plan (required).</param>
    /// <param name="GroupSettings">Group settings for the activity plan.</param>
    /// <param name="RecurrenceSettings">Settings controlling recurrence for the activity plan. If not set the activity plan will only occur once.</param>
    /// <param name="AttendeesSearchRule">Attendee search rule for this activity plan.</param>
    /// <param name="Facilitated">Whether the sessions created by this activity plan should be facilitated.</param>
    /// <param name="FacilitatorsSearchRule">Facilitator search rule for this activity plan.</param>
    /// <param name="TransitionTimeMinutes">Transition time in minutes between facilitated sessions (required).</param>
    /// <param name="ServiceGoalImpactOverrides">Allowable service goal impact override settings for this activity plan. If not set the business unit setting will be used.</param>
    /// <param name="OptimizationObjective">The optimization objective of this activity plan (required).</param>
    /// <param name="State">The state of this activity plan (required).</param>
    /// <param name="CountsAsPaidTime">Whether the activity should count as paid time (required).</param>
    /// <param name="FixedAvailability">Fixed availability configuration for the activity plan.</param>
    public CreateActivityPlanRequest(string Name = null, List<string> ManagementUnitIds = null, string Description = null, string ActivityCodeId = null, TypeEnum? Type = null, int? LengthMinutes = null, SchedulingPeriod InitialSchedulePeriod = null, GroupSettings GroupSettings = null, RecurrenceSettings RecurrenceSettings = null, UserSearchRule AttendeesSearchRule = null, bool? Facilitated = null, UserSearchRule FacilitatorsSearchRule = null, int? TransitionTimeMinutes = null, ActivityPlanServiceGoalImpactOverrides ServiceGoalImpactOverrides = null, OptimizationObjectiveEnum? OptimizationObjective = null, StateEnum? State = null, bool? CountsAsPaidTime = null, List<FixedAvailability> FixedAvailability = null)
    {
        this.Name = Name;
        this.ManagementUnitIds = ManagementUnitIds;
        this.Description = Description;
        this.ActivityCodeId = ActivityCodeId;
        this.Type = Type;
        this.LengthMinutes = LengthMinutes;
        this.InitialSchedulePeriod = InitialSchedulePeriod;
        this.GroupSettings = GroupSettings;
        this.RecurrenceSettings = RecurrenceSettings;
        this.AttendeesSearchRule = AttendeesSearchRule;
        this.Facilitated = Facilitated;
        this.FacilitatorsSearchRule = FacilitatorsSearchRule;
        this.TransitionTimeMinutes = TransitionTimeMinutes;
        this.ServiceGoalImpactOverrides = ServiceGoalImpactOverrides;
        this.OptimizationObjective = OptimizationObjective;
        this.State = State;
        this.CountsAsPaidTime = CountsAsPaidTime;
        this.FixedAvailability = FixedAvailability;

    }



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
    [JsonPropertyName("managementUnitIds")]
    public List<string> ManagementUnitIds { get; set; }



    /// <summary>
    /// The description of the activity plan
    /// </summary>
    /// <value>The description of the activity plan</value>
    [JsonPropertyName("description")]
    public string Description { get; set; }



    /// <summary>
    /// The activity code associated with the activity plan
    /// </summary>
    /// <value>The activity code associated with the activity plan</value>
    [JsonPropertyName("activityCodeId")]
    public string ActivityCodeId { get; set; }





    /// <summary>
    /// The length in minutes of the activity plan
    /// </summary>
    /// <value>The length in minutes of the activity plan</value>
    [JsonPropertyName("lengthMinutes")]
    public int? LengthMinutes { get; set; }



    /// <summary>
    /// The initial scheduling period for the activity plan
    /// </summary>
    /// <value>The initial scheduling period for the activity plan</value>
    [JsonPropertyName("initialSchedulePeriod")]
    public SchedulingPeriod InitialSchedulePeriod { get; set; }



    /// <summary>
    /// Group settings for the activity plan
    /// </summary>
    /// <value>Group settings for the activity plan</value>
    [JsonPropertyName("groupSettings")]
    public GroupSettings GroupSettings { get; set; }



    /// <summary>
    /// Settings controlling recurrence for the activity plan. If not set the activity plan will only occur once
    /// </summary>
    /// <value>Settings controlling recurrence for the activity plan. If not set the activity plan will only occur once</value>
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
    /// Allowable service goal impact override settings for this activity plan. If not set the business unit setting will be used
    /// </summary>
    /// <value>Allowable service goal impact override settings for this activity plan. If not set the business unit setting will be used</value>
    [JsonPropertyName("serviceGoalImpactOverrides")]
    public ActivityPlanServiceGoalImpactOverrides ServiceGoalImpactOverrides { get; set; }







    /// <summary>
    /// Whether the activity should count as paid time
    /// </summary>
    /// <value>Whether the activity should count as paid time</value>
    [JsonPropertyName("countsAsPaidTime")]
    public bool? CountsAsPaidTime { get; set; }



    /// <summary>
    /// Fixed availability configuration for the activity plan
    /// </summary>
    /// <value>Fixed availability configuration for the activity plan</value>
    [JsonPropertyName("fixedAvailability")]
    public List<FixedAvailability> FixedAvailability { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CreateActivityPlanRequest {\n");

        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  ManagementUnitIds: ").Append(ManagementUnitIds).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  ActivityCodeId: ").Append(ActivityCodeId).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  LengthMinutes: ").Append(LengthMinutes).Append("\n");
        sb.Append("  InitialSchedulePeriod: ").Append(InitialSchedulePeriod).Append("\n");
        sb.Append("  GroupSettings: ").Append(GroupSettings).Append("\n");
        sb.Append("  RecurrenceSettings: ").Append(RecurrenceSettings).Append("\n");
        sb.Append("  AttendeesSearchRule: ").Append(AttendeesSearchRule).Append("\n");
        sb.Append("  Facilitated: ").Append(Facilitated).Append("\n");
        sb.Append("  FacilitatorsSearchRule: ").Append(FacilitatorsSearchRule).Append("\n");
        sb.Append("  TransitionTimeMinutes: ").Append(TransitionTimeMinutes).Append("\n");
        sb.Append("  ServiceGoalImpactOverrides: ").Append(ServiceGoalImpactOverrides).Append("\n");
        sb.Append("  OptimizationObjective: ").Append(OptimizationObjective).Append("\n");
        sb.Append("  State: ").Append(State).Append("\n");
        sb.Append("  CountsAsPaidTime: ").Append(CountsAsPaidTime).Append("\n");
        sb.Append("  FixedAvailability: ").Append(FixedAvailability).Append("\n");
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
        return Equals(obj as CreateActivityPlanRequest);
    }

    /// <summary>
    /// Returns true if CreateActivityPlanRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of CreateActivityPlanRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CreateActivityPlanRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                ManagementUnitIds == other.ManagementUnitIds ||
                ManagementUnitIds != null &&
                ManagementUnitIds.SequenceEqual(other.ManagementUnitIds)
            ) &&
            (
                Description == other.Description ||
                Description != null &&
                Description.Equals(other.Description)
            ) &&
            (
                ActivityCodeId == other.ActivityCodeId ||
                ActivityCodeId != null &&
                ActivityCodeId.Equals(other.ActivityCodeId)
            ) &&
            (
                Type == other.Type ||
                Type != null &&
                Type.Equals(other.Type)
            ) &&
            (
                LengthMinutes == other.LengthMinutes ||
                LengthMinutes != null &&
                LengthMinutes.Equals(other.LengthMinutes)
            ) &&
            (
                InitialSchedulePeriod == other.InitialSchedulePeriod ||
                InitialSchedulePeriod != null &&
                InitialSchedulePeriod.Equals(other.InitialSchedulePeriod)
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
                FixedAvailability == other.FixedAvailability ||
                FixedAvailability != null &&
                FixedAvailability.SequenceEqual(other.FixedAvailability)
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
            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (ManagementUnitIds != null)
            {
                hash = hash * 59 + ManagementUnitIds.GetHashCode();
            }

            if (Description != null)
            {
                hash = hash * 59 + Description.GetHashCode();
            }

            if (ActivityCodeId != null)
            {
                hash = hash * 59 + ActivityCodeId.GetHashCode();
            }

            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
            }

            if (LengthMinutes != null)
            {
                hash = hash * 59 + LengthMinutes.GetHashCode();
            }

            if (InitialSchedulePeriod != null)
            {
                hash = hash * 59 + InitialSchedulePeriod.GetHashCode();
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

            if (State != null)
            {
                hash = hash * 59 + State.GetHashCode();
            }

            if (CountsAsPaidTime != null)
            {
                hash = hash * 59 + CountsAsPaidTime.GetHashCode();
            }

            if (FixedAvailability != null)
            {
                hash = hash * 59 + FixedAvailability.GetHashCode();
            }

            return hash;
        }
    }
}
