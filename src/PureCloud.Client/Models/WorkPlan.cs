using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WorkPlan
/// </summary>

public partial class WorkPlan : IEquatable<WorkPlan>
{
    /// <summary>
    /// This constraint ensures that an agent starts each workday within a user-defined time threshold
    /// </summary>
    /// <value>This constraint ensures that an agent starts each workday within a user-defined time threshold</value>
    
    public enum ShiftStartVarianceTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Shiftstart for "ShiftStart"
        /// </summary>
        [EnumMember(Value = "ShiftStart")]
        Shiftstart,

        /// <summary>
        /// Enum Shiftstartandpaidduration for "ShiftStartAndPaidDuration"
        /// </summary>
        [EnumMember(Value = "ShiftStartAndPaidDuration")]
        Shiftstartandpaidduration
    }
    /// <summary>
    /// This constraint ensures that an agent starts each workday within a user-defined time threshold
    /// </summary>
    /// <value>This constraint ensures that an agent starts each workday within a user-defined time threshold</value>
    [JsonPropertyName("shiftStartVarianceType")]
    public ShiftStartVarianceTypeEnum? ShiftStartVarianceType { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="WorkPlan" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected WorkPlan() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="WorkPlan" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="Enabled">Whether the work plan is enabled for scheduling.</param>
    /// <param name="ConstrainWeeklyPaidTime">Whether the weekly paid time constraint is enabled for this work plan.</param>
    /// <param name="FlexibleWeeklyPaidTime">Whether the weekly paid time constraint is flexible for this work plan.</param>
    /// <param name="WeeklyExactPaidMinutes">Exact weekly paid time in minutes for this work plan. Used if flexibleWeeklyPaidTime &#x3D;&#x3D; false.</param>
    /// <param name="WeeklyMinimumPaidMinutes">Minimum weekly paid time in minutes for this work plan. Used if flexibleWeeklyPaidTime &#x3D;&#x3D; true.</param>
    /// <param name="WeeklyMaximumPaidMinutes">Maximum weekly paid time in minutes for this work plan. Used if flexibleWeeklyPaidTime &#x3D;&#x3D; true.</param>
    /// <param name="ConstrainPaidTimeGranularity">Whether paid time granularity is constrained for this work plan.</param>
    /// <param name="PaidTimeGranularityMinutes">Granularity in minutes allowed for shift paid time in this work plan. Used if constrainPaidTimeGranularity &#x3D;&#x3D; true.</param>
    /// <param name="ConstrainMinimumTimeBetweenShifts">Whether the minimum time between shifts constraint is enabled for this work plan.</param>
    /// <param name="MinimumTimeBetweenShiftsMinutes">Minimum time between shifts in minutes defined in this work plan. Used if constrainMinimumTimeBetweenShifts &#x3D;&#x3D; true.</param>
    /// <param name="MaximumDays">Maximum number days in a week allowed to be scheduled for this work plan.</param>
    /// <param name="MinimumConsecutiveNonWorkingMinutesPerWeek">Minimum amount of consecutive non working minutes per week that agents who are assigned this work plan are allowed to have off.</param>
    /// <param name="ConstrainMaximumConsecutiveWorkingWeekends">Whether to constrain the maximum consecutive working weekends.</param>
    /// <param name="MaximumConsecutiveWorkingWeekends">The maximum number of consecutive weekends that agents who are assigned to this work plan are allowed to work.</param>
    /// <param name="MinimumWorkingDaysPerWeek">The minimum number of days that agents assigned to a work plan must work per week.</param>
    /// <param name="ConstrainMaximumConsecutiveWorkingDays">Whether to constrain the maximum consecutive working days.</param>
    /// <param name="MaximumConsecutiveWorkingDays">The maximum number of consecutive days that agents assigned to this work plan are allowed to work. Used if constrainMaximumConsecutiveWorkingDays &#x3D;&#x3D; true.</param>
    /// <param name="MinimumShiftStartDistanceMinutes">The time period in minutes for the duration between the start times of two consecutive working days.</param>
    /// <param name="MinimumDaysOffPerPlanningPeriod">Minimum days off in the planning period.</param>
    /// <param name="MaximumDaysOffPerPlanningPeriod">Maximum days off in the planning period.</param>
    /// <param name="MinimumPaidMinutesPerPlanningPeriod">Minimum paid minutes in the planning period.</param>
    /// <param name="MaximumPaidMinutesPerPlanningPeriod">Maximum paid minutes in the planning period.</param>
    /// <param name="OptionalDays">Optional days to schedule for this work plan.</param>
    /// <param name="ShiftStartVarianceType">This constraint ensures that an agent starts each workday within a user-defined time threshold.</param>
    /// <param name="ShiftStartVariances">Variance in minutes among start times of shifts in this work plan.</param>
    /// <param name="Shifts">Shifts in this work plan.</param>
    /// <param name="Agents">Agents in this work plan.</param>
    /// <param name="AgentCount">Number of agents in this work plan.</param>
    /// <param name="Metadata">Version metadata for this work plan (required).</param>
    public WorkPlan(string Name = null, bool? Enabled = null, bool? ConstrainWeeklyPaidTime = null, bool? FlexibleWeeklyPaidTime = null, int? WeeklyExactPaidMinutes = null, int? WeeklyMinimumPaidMinutes = null, int? WeeklyMaximumPaidMinutes = null, bool? ConstrainPaidTimeGranularity = null, int? PaidTimeGranularityMinutes = null, bool? ConstrainMinimumTimeBetweenShifts = null, int? MinimumTimeBetweenShiftsMinutes = null, int? MaximumDays = null, int? MinimumConsecutiveNonWorkingMinutesPerWeek = null, bool? ConstrainMaximumConsecutiveWorkingWeekends = null, int? MaximumConsecutiveWorkingWeekends = null, int? MinimumWorkingDaysPerWeek = null, bool? ConstrainMaximumConsecutiveWorkingDays = null, int? MaximumConsecutiveWorkingDays = null, int? MinimumShiftStartDistanceMinutes = null, int? MinimumDaysOffPerPlanningPeriod = null, int? MaximumDaysOffPerPlanningPeriod = null, int? MinimumPaidMinutesPerPlanningPeriod = null, int? MaximumPaidMinutesPerPlanningPeriod = null, SetWrapperDayOfWeek OptionalDays = null, ShiftStartVarianceTypeEnum? ShiftStartVarianceType = null, ListWrapperShiftStartVariance ShiftStartVariances = null, List<WorkPlanShift> Shifts = null, List<DeletableUserReference> Agents = null, int? AgentCount = null, WfmVersionedEntityMetadata Metadata = null)
    {
        this.Name = Name;
        this.Enabled = Enabled;
        this.ConstrainWeeklyPaidTime = ConstrainWeeklyPaidTime;
        this.FlexibleWeeklyPaidTime = FlexibleWeeklyPaidTime;
        this.WeeklyExactPaidMinutes = WeeklyExactPaidMinutes;
        this.WeeklyMinimumPaidMinutes = WeeklyMinimumPaidMinutes;
        this.WeeklyMaximumPaidMinutes = WeeklyMaximumPaidMinutes;
        this.ConstrainPaidTimeGranularity = ConstrainPaidTimeGranularity;
        this.PaidTimeGranularityMinutes = PaidTimeGranularityMinutes;
        this.ConstrainMinimumTimeBetweenShifts = ConstrainMinimumTimeBetweenShifts;
        this.MinimumTimeBetweenShiftsMinutes = MinimumTimeBetweenShiftsMinutes;
        this.MaximumDays = MaximumDays;
        this.MinimumConsecutiveNonWorkingMinutesPerWeek = MinimumConsecutiveNonWorkingMinutesPerWeek;
        this.ConstrainMaximumConsecutiveWorkingWeekends = ConstrainMaximumConsecutiveWorkingWeekends;
        this.MaximumConsecutiveWorkingWeekends = MaximumConsecutiveWorkingWeekends;
        this.MinimumWorkingDaysPerWeek = MinimumWorkingDaysPerWeek;
        this.ConstrainMaximumConsecutiveWorkingDays = ConstrainMaximumConsecutiveWorkingDays;
        this.MaximumConsecutiveWorkingDays = MaximumConsecutiveWorkingDays;
        this.MinimumShiftStartDistanceMinutes = MinimumShiftStartDistanceMinutes;
        this.MinimumDaysOffPerPlanningPeriod = MinimumDaysOffPerPlanningPeriod;
        this.MaximumDaysOffPerPlanningPeriod = MaximumDaysOffPerPlanningPeriod;
        this.MinimumPaidMinutesPerPlanningPeriod = MinimumPaidMinutesPerPlanningPeriod;
        this.MaximumPaidMinutesPerPlanningPeriod = MaximumPaidMinutesPerPlanningPeriod;
        this.OptionalDays = OptionalDays;
        this.ShiftStartVarianceType = ShiftStartVarianceType;
        this.ShiftStartVariances = ShiftStartVariances;
        this.Shifts = Shifts;
        this.Agents = Agents;
        this.AgentCount = AgentCount;
        this.Metadata = Metadata;

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
    /// Whether the work plan is enabled for scheduling
    /// </summary>
    /// <value>Whether the work plan is enabled for scheduling</value>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }



    /// <summary>
    /// Whether the work plan is valid or not
    /// </summary>
    /// <value>Whether the work plan is valid or not</value>
    [JsonPropertyName("valid")]
    public bool? Valid { get; set; }



    /// <summary>
    /// Whether the weekly paid time constraint is enabled for this work plan
    /// </summary>
    /// <value>Whether the weekly paid time constraint is enabled for this work plan</value>
    [JsonPropertyName("constrainWeeklyPaidTime")]
    public bool? ConstrainWeeklyPaidTime { get; set; }



    /// <summary>
    /// Whether the weekly paid time constraint is flexible for this work plan
    /// </summary>
    /// <value>Whether the weekly paid time constraint is flexible for this work plan</value>
    [JsonPropertyName("flexibleWeeklyPaidTime")]
    public bool? FlexibleWeeklyPaidTime { get; set; }



    /// <summary>
    /// Exact weekly paid time in minutes for this work plan. Used if flexibleWeeklyPaidTime &#x3D;&#x3D; false
    /// </summary>
    /// <value>Exact weekly paid time in minutes for this work plan. Used if flexibleWeeklyPaidTime &#x3D;&#x3D; false</value>
    [JsonPropertyName("weeklyExactPaidMinutes")]
    public int? WeeklyExactPaidMinutes { get; set; }



    /// <summary>
    /// Minimum weekly paid time in minutes for this work plan. Used if flexibleWeeklyPaidTime &#x3D;&#x3D; true
    /// </summary>
    /// <value>Minimum weekly paid time in minutes for this work plan. Used if flexibleWeeklyPaidTime &#x3D;&#x3D; true</value>
    [JsonPropertyName("weeklyMinimumPaidMinutes")]
    public int? WeeklyMinimumPaidMinutes { get; set; }



    /// <summary>
    /// Maximum weekly paid time in minutes for this work plan. Used if flexibleWeeklyPaidTime &#x3D;&#x3D; true
    /// </summary>
    /// <value>Maximum weekly paid time in minutes for this work plan. Used if flexibleWeeklyPaidTime &#x3D;&#x3D; true</value>
    [JsonPropertyName("weeklyMaximumPaidMinutes")]
    public int? WeeklyMaximumPaidMinutes { get; set; }



    /// <summary>
    /// Whether paid time granularity is constrained for this work plan
    /// </summary>
    /// <value>Whether paid time granularity is constrained for this work plan</value>
    [JsonPropertyName("constrainPaidTimeGranularity")]
    public bool? ConstrainPaidTimeGranularity { get; set; }



    /// <summary>
    /// Granularity in minutes allowed for shift paid time in this work plan. Used if constrainPaidTimeGranularity &#x3D;&#x3D; true
    /// </summary>
    /// <value>Granularity in minutes allowed for shift paid time in this work plan. Used if constrainPaidTimeGranularity &#x3D;&#x3D; true</value>
    [JsonPropertyName("paidTimeGranularityMinutes")]
    public int? PaidTimeGranularityMinutes { get; set; }



    /// <summary>
    /// Whether the minimum time between shifts constraint is enabled for this work plan
    /// </summary>
    /// <value>Whether the minimum time between shifts constraint is enabled for this work plan</value>
    [JsonPropertyName("constrainMinimumTimeBetweenShifts")]
    public bool? ConstrainMinimumTimeBetweenShifts { get; set; }



    /// <summary>
    /// Minimum time between shifts in minutes defined in this work plan. Used if constrainMinimumTimeBetweenShifts &#x3D;&#x3D; true
    /// </summary>
    /// <value>Minimum time between shifts in minutes defined in this work plan. Used if constrainMinimumTimeBetweenShifts &#x3D;&#x3D; true</value>
    [JsonPropertyName("minimumTimeBetweenShiftsMinutes")]
    public int? MinimumTimeBetweenShiftsMinutes { get; set; }



    /// <summary>
    /// Maximum number days in a week allowed to be scheduled for this work plan
    /// </summary>
    /// <value>Maximum number days in a week allowed to be scheduled for this work plan</value>
    [JsonPropertyName("maximumDays")]
    public int? MaximumDays { get; set; }



    /// <summary>
    /// Minimum amount of consecutive non working minutes per week that agents who are assigned this work plan are allowed to have off
    /// </summary>
    /// <value>Minimum amount of consecutive non working minutes per week that agents who are assigned this work plan are allowed to have off</value>
    [JsonPropertyName("minimumConsecutiveNonWorkingMinutesPerWeek")]
    public int? MinimumConsecutiveNonWorkingMinutesPerWeek { get; set; }



    /// <summary>
    /// Whether to constrain the maximum consecutive working weekends
    /// </summary>
    /// <value>Whether to constrain the maximum consecutive working weekends</value>
    [JsonPropertyName("constrainMaximumConsecutiveWorkingWeekends")]
    public bool? ConstrainMaximumConsecutiveWorkingWeekends { get; set; }



    /// <summary>
    /// The maximum number of consecutive weekends that agents who are assigned to this work plan are allowed to work
    /// </summary>
    /// <value>The maximum number of consecutive weekends that agents who are assigned to this work plan are allowed to work</value>
    [JsonPropertyName("maximumConsecutiveWorkingWeekends")]
    public int? MaximumConsecutiveWorkingWeekends { get; set; }



    /// <summary>
    /// The minimum number of days that agents assigned to a work plan must work per week
    /// </summary>
    /// <value>The minimum number of days that agents assigned to a work plan must work per week</value>
    [JsonPropertyName("minimumWorkingDaysPerWeek")]
    public int? MinimumWorkingDaysPerWeek { get; set; }



    /// <summary>
    /// Whether to constrain the maximum consecutive working days
    /// </summary>
    /// <value>Whether to constrain the maximum consecutive working days</value>
    [JsonPropertyName("constrainMaximumConsecutiveWorkingDays")]
    public bool? ConstrainMaximumConsecutiveWorkingDays { get; set; }



    /// <summary>
    /// The maximum number of consecutive days that agents assigned to this work plan are allowed to work. Used if constrainMaximumConsecutiveWorkingDays &#x3D;&#x3D; true
    /// </summary>
    /// <value>The maximum number of consecutive days that agents assigned to this work plan are allowed to work. Used if constrainMaximumConsecutiveWorkingDays &#x3D;&#x3D; true</value>
    [JsonPropertyName("maximumConsecutiveWorkingDays")]
    public int? MaximumConsecutiveWorkingDays { get; set; }



    /// <summary>
    /// The time period in minutes for the duration between the start times of two consecutive working days
    /// </summary>
    /// <value>The time period in minutes for the duration between the start times of two consecutive working days</value>
    [JsonPropertyName("minimumShiftStartDistanceMinutes")]
    public int? MinimumShiftStartDistanceMinutes { get; set; }



    /// <summary>
    /// Minimum days off in the planning period
    /// </summary>
    /// <value>Minimum days off in the planning period</value>
    [JsonPropertyName("minimumDaysOffPerPlanningPeriod")]
    public int? MinimumDaysOffPerPlanningPeriod { get; set; }



    /// <summary>
    /// Maximum days off in the planning period
    /// </summary>
    /// <value>Maximum days off in the planning period</value>
    [JsonPropertyName("maximumDaysOffPerPlanningPeriod")]
    public int? MaximumDaysOffPerPlanningPeriod { get; set; }



    /// <summary>
    /// Minimum paid minutes in the planning period
    /// </summary>
    /// <value>Minimum paid minutes in the planning period</value>
    [JsonPropertyName("minimumPaidMinutesPerPlanningPeriod")]
    public int? MinimumPaidMinutesPerPlanningPeriod { get; set; }



    /// <summary>
    /// Maximum paid minutes in the planning period
    /// </summary>
    /// <value>Maximum paid minutes in the planning period</value>
    [JsonPropertyName("maximumPaidMinutesPerPlanningPeriod")]
    public int? MaximumPaidMinutesPerPlanningPeriod { get; set; }



    /// <summary>
    /// Optional days to schedule for this work plan
    /// </summary>
    /// <value>Optional days to schedule for this work plan</value>
    [JsonPropertyName("optionalDays")]
    public SetWrapperDayOfWeek OptionalDays { get; set; }





    /// <summary>
    /// Variance in minutes among start times of shifts in this work plan
    /// </summary>
    /// <value>Variance in minutes among start times of shifts in this work plan</value>
    [JsonPropertyName("shiftStartVariances")]
    public ListWrapperShiftStartVariance ShiftStartVariances { get; set; }



    /// <summary>
    /// Shifts in this work plan
    /// </summary>
    /// <value>Shifts in this work plan</value>
    [JsonPropertyName("shifts")]
    public List<WorkPlanShift> Shifts { get; set; }



    /// <summary>
    /// Agents in this work plan
    /// </summary>
    /// <value>Agents in this work plan</value>
    [JsonPropertyName("agents")]
    public List<DeletableUserReference> Agents { get; set; }



    /// <summary>
    /// Number of agents in this work plan
    /// </summary>
    /// <value>Number of agents in this work plan</value>
    [JsonPropertyName("agentCount")]
    public int? AgentCount { get; set; }



    /// <summary>
    /// Version metadata for this work plan
    /// </summary>
    /// <value>Version metadata for this work plan</value>
    [JsonPropertyName("metadata")]
    public WfmVersionedEntityMetadata Metadata { get; set; }



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
        sb.Append("class WorkPlan {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Enabled: ").Append(Enabled).Append("\n");
        sb.Append("  Valid: ").Append(Valid).Append("\n");
        sb.Append("  ConstrainWeeklyPaidTime: ").Append(ConstrainWeeklyPaidTime).Append("\n");
        sb.Append("  FlexibleWeeklyPaidTime: ").Append(FlexibleWeeklyPaidTime).Append("\n");
        sb.Append("  WeeklyExactPaidMinutes: ").Append(WeeklyExactPaidMinutes).Append("\n");
        sb.Append("  WeeklyMinimumPaidMinutes: ").Append(WeeklyMinimumPaidMinutes).Append("\n");
        sb.Append("  WeeklyMaximumPaidMinutes: ").Append(WeeklyMaximumPaidMinutes).Append("\n");
        sb.Append("  ConstrainPaidTimeGranularity: ").Append(ConstrainPaidTimeGranularity).Append("\n");
        sb.Append("  PaidTimeGranularityMinutes: ").Append(PaidTimeGranularityMinutes).Append("\n");
        sb.Append("  ConstrainMinimumTimeBetweenShifts: ").Append(ConstrainMinimumTimeBetweenShifts).Append("\n");
        sb.Append("  MinimumTimeBetweenShiftsMinutes: ").Append(MinimumTimeBetweenShiftsMinutes).Append("\n");
        sb.Append("  MaximumDays: ").Append(MaximumDays).Append("\n");
        sb.Append("  MinimumConsecutiveNonWorkingMinutesPerWeek: ").Append(MinimumConsecutiveNonWorkingMinutesPerWeek).Append("\n");
        sb.Append("  ConstrainMaximumConsecutiveWorkingWeekends: ").Append(ConstrainMaximumConsecutiveWorkingWeekends).Append("\n");
        sb.Append("  MaximumConsecutiveWorkingWeekends: ").Append(MaximumConsecutiveWorkingWeekends).Append("\n");
        sb.Append("  MinimumWorkingDaysPerWeek: ").Append(MinimumWorkingDaysPerWeek).Append("\n");
        sb.Append("  ConstrainMaximumConsecutiveWorkingDays: ").Append(ConstrainMaximumConsecutiveWorkingDays).Append("\n");
        sb.Append("  MaximumConsecutiveWorkingDays: ").Append(MaximumConsecutiveWorkingDays).Append("\n");
        sb.Append("  MinimumShiftStartDistanceMinutes: ").Append(MinimumShiftStartDistanceMinutes).Append("\n");
        sb.Append("  MinimumDaysOffPerPlanningPeriod: ").Append(MinimumDaysOffPerPlanningPeriod).Append("\n");
        sb.Append("  MaximumDaysOffPerPlanningPeriod: ").Append(MaximumDaysOffPerPlanningPeriod).Append("\n");
        sb.Append("  MinimumPaidMinutesPerPlanningPeriod: ").Append(MinimumPaidMinutesPerPlanningPeriod).Append("\n");
        sb.Append("  MaximumPaidMinutesPerPlanningPeriod: ").Append(MaximumPaidMinutesPerPlanningPeriod).Append("\n");
        sb.Append("  OptionalDays: ").Append(OptionalDays).Append("\n");
        sb.Append("  ShiftStartVarianceType: ").Append(ShiftStartVarianceType).Append("\n");
        sb.Append("  ShiftStartVariances: ").Append(ShiftStartVariances).Append("\n");
        sb.Append("  Shifts: ").Append(Shifts).Append("\n");
        sb.Append("  Agents: ").Append(Agents).Append("\n");
        sb.Append("  AgentCount: ").Append(AgentCount).Append("\n");
        sb.Append("  Metadata: ").Append(Metadata).Append("\n");
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
        return Equals(obj as WorkPlan);
    }

    /// <summary>
    /// Returns true if WorkPlan instances are equal
    /// </summary>
    /// <param name="other">Instance of WorkPlan to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WorkPlan other)
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
                Enabled == other.Enabled ||
                Enabled != null &&
                Enabled.Equals(other.Enabled)
            ) &&
            (
                Valid == other.Valid ||
                Valid != null &&
                Valid.Equals(other.Valid)
            ) &&
            (
                ConstrainWeeklyPaidTime == other.ConstrainWeeklyPaidTime ||
                ConstrainWeeklyPaidTime != null &&
                ConstrainWeeklyPaidTime.Equals(other.ConstrainWeeklyPaidTime)
            ) &&
            (
                FlexibleWeeklyPaidTime == other.FlexibleWeeklyPaidTime ||
                FlexibleWeeklyPaidTime != null &&
                FlexibleWeeklyPaidTime.Equals(other.FlexibleWeeklyPaidTime)
            ) &&
            (
                WeeklyExactPaidMinutes == other.WeeklyExactPaidMinutes ||
                WeeklyExactPaidMinutes != null &&
                WeeklyExactPaidMinutes.Equals(other.WeeklyExactPaidMinutes)
            ) &&
            (
                WeeklyMinimumPaidMinutes == other.WeeklyMinimumPaidMinutes ||
                WeeklyMinimumPaidMinutes != null &&
                WeeklyMinimumPaidMinutes.Equals(other.WeeklyMinimumPaidMinutes)
            ) &&
            (
                WeeklyMaximumPaidMinutes == other.WeeklyMaximumPaidMinutes ||
                WeeklyMaximumPaidMinutes != null &&
                WeeklyMaximumPaidMinutes.Equals(other.WeeklyMaximumPaidMinutes)
            ) &&
            (
                ConstrainPaidTimeGranularity == other.ConstrainPaidTimeGranularity ||
                ConstrainPaidTimeGranularity != null &&
                ConstrainPaidTimeGranularity.Equals(other.ConstrainPaidTimeGranularity)
            ) &&
            (
                PaidTimeGranularityMinutes == other.PaidTimeGranularityMinutes ||
                PaidTimeGranularityMinutes != null &&
                PaidTimeGranularityMinutes.Equals(other.PaidTimeGranularityMinutes)
            ) &&
            (
                ConstrainMinimumTimeBetweenShifts == other.ConstrainMinimumTimeBetweenShifts ||
                ConstrainMinimumTimeBetweenShifts != null &&
                ConstrainMinimumTimeBetweenShifts.Equals(other.ConstrainMinimumTimeBetweenShifts)
            ) &&
            (
                MinimumTimeBetweenShiftsMinutes == other.MinimumTimeBetweenShiftsMinutes ||
                MinimumTimeBetweenShiftsMinutes != null &&
                MinimumTimeBetweenShiftsMinutes.Equals(other.MinimumTimeBetweenShiftsMinutes)
            ) &&
            (
                MaximumDays == other.MaximumDays ||
                MaximumDays != null &&
                MaximumDays.Equals(other.MaximumDays)
            ) &&
            (
                MinimumConsecutiveNonWorkingMinutesPerWeek == other.MinimumConsecutiveNonWorkingMinutesPerWeek ||
                MinimumConsecutiveNonWorkingMinutesPerWeek != null &&
                MinimumConsecutiveNonWorkingMinutesPerWeek.Equals(other.MinimumConsecutiveNonWorkingMinutesPerWeek)
            ) &&
            (
                ConstrainMaximumConsecutiveWorkingWeekends == other.ConstrainMaximumConsecutiveWorkingWeekends ||
                ConstrainMaximumConsecutiveWorkingWeekends != null &&
                ConstrainMaximumConsecutiveWorkingWeekends.Equals(other.ConstrainMaximumConsecutiveWorkingWeekends)
            ) &&
            (
                MaximumConsecutiveWorkingWeekends == other.MaximumConsecutiveWorkingWeekends ||
                MaximumConsecutiveWorkingWeekends != null &&
                MaximumConsecutiveWorkingWeekends.Equals(other.MaximumConsecutiveWorkingWeekends)
            ) &&
            (
                MinimumWorkingDaysPerWeek == other.MinimumWorkingDaysPerWeek ||
                MinimumWorkingDaysPerWeek != null &&
                MinimumWorkingDaysPerWeek.Equals(other.MinimumWorkingDaysPerWeek)
            ) &&
            (
                ConstrainMaximumConsecutiveWorkingDays == other.ConstrainMaximumConsecutiveWorkingDays ||
                ConstrainMaximumConsecutiveWorkingDays != null &&
                ConstrainMaximumConsecutiveWorkingDays.Equals(other.ConstrainMaximumConsecutiveWorkingDays)
            ) &&
            (
                MaximumConsecutiveWorkingDays == other.MaximumConsecutiveWorkingDays ||
                MaximumConsecutiveWorkingDays != null &&
                MaximumConsecutiveWorkingDays.Equals(other.MaximumConsecutiveWorkingDays)
            ) &&
            (
                MinimumShiftStartDistanceMinutes == other.MinimumShiftStartDistanceMinutes ||
                MinimumShiftStartDistanceMinutes != null &&
                MinimumShiftStartDistanceMinutes.Equals(other.MinimumShiftStartDistanceMinutes)
            ) &&
            (
                MinimumDaysOffPerPlanningPeriod == other.MinimumDaysOffPerPlanningPeriod ||
                MinimumDaysOffPerPlanningPeriod != null &&
                MinimumDaysOffPerPlanningPeriod.Equals(other.MinimumDaysOffPerPlanningPeriod)
            ) &&
            (
                MaximumDaysOffPerPlanningPeriod == other.MaximumDaysOffPerPlanningPeriod ||
                MaximumDaysOffPerPlanningPeriod != null &&
                MaximumDaysOffPerPlanningPeriod.Equals(other.MaximumDaysOffPerPlanningPeriod)
            ) &&
            (
                MinimumPaidMinutesPerPlanningPeriod == other.MinimumPaidMinutesPerPlanningPeriod ||
                MinimumPaidMinutesPerPlanningPeriod != null &&
                MinimumPaidMinutesPerPlanningPeriod.Equals(other.MinimumPaidMinutesPerPlanningPeriod)
            ) &&
            (
                MaximumPaidMinutesPerPlanningPeriod == other.MaximumPaidMinutesPerPlanningPeriod ||
                MaximumPaidMinutesPerPlanningPeriod != null &&
                MaximumPaidMinutesPerPlanningPeriod.Equals(other.MaximumPaidMinutesPerPlanningPeriod)
            ) &&
            (
                OptionalDays == other.OptionalDays ||
                OptionalDays != null &&
                OptionalDays.Equals(other.OptionalDays)
            ) &&
            (
                ShiftStartVarianceType == other.ShiftStartVarianceType ||
                ShiftStartVarianceType != null &&
                ShiftStartVarianceType.Equals(other.ShiftStartVarianceType)
            ) &&
            (
                ShiftStartVariances == other.ShiftStartVariances ||
                ShiftStartVariances != null &&
                ShiftStartVariances.Equals(other.ShiftStartVariances)
            ) &&
            (
                Shifts == other.Shifts ||
                Shifts != null &&
                Shifts.SequenceEqual(other.Shifts)
            ) &&
            (
                Agents == other.Agents ||
                Agents != null &&
                Agents.SequenceEqual(other.Agents)
            ) &&
            (
                AgentCount == other.AgentCount ||
                AgentCount != null &&
                AgentCount.Equals(other.AgentCount)
            ) &&
            (
                Metadata == other.Metadata ||
                Metadata != null &&
                Metadata.Equals(other.Metadata)
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

            if (Enabled != null)
            {
                hash = hash * 59 + Enabled.GetHashCode();
            }

            if (Valid != null)
            {
                hash = hash * 59 + Valid.GetHashCode();
            }

            if (ConstrainWeeklyPaidTime != null)
            {
                hash = hash * 59 + ConstrainWeeklyPaidTime.GetHashCode();
            }

            if (FlexibleWeeklyPaidTime != null)
            {
                hash = hash * 59 + FlexibleWeeklyPaidTime.GetHashCode();
            }

            if (WeeklyExactPaidMinutes != null)
            {
                hash = hash * 59 + WeeklyExactPaidMinutes.GetHashCode();
            }

            if (WeeklyMinimumPaidMinutes != null)
            {
                hash = hash * 59 + WeeklyMinimumPaidMinutes.GetHashCode();
            }

            if (WeeklyMaximumPaidMinutes != null)
            {
                hash = hash * 59 + WeeklyMaximumPaidMinutes.GetHashCode();
            }

            if (ConstrainPaidTimeGranularity != null)
            {
                hash = hash * 59 + ConstrainPaidTimeGranularity.GetHashCode();
            }

            if (PaidTimeGranularityMinutes != null)
            {
                hash = hash * 59 + PaidTimeGranularityMinutes.GetHashCode();
            }

            if (ConstrainMinimumTimeBetweenShifts != null)
            {
                hash = hash * 59 + ConstrainMinimumTimeBetweenShifts.GetHashCode();
            }

            if (MinimumTimeBetweenShiftsMinutes != null)
            {
                hash = hash * 59 + MinimumTimeBetweenShiftsMinutes.GetHashCode();
            }

            if (MaximumDays != null)
            {
                hash = hash * 59 + MaximumDays.GetHashCode();
            }

            if (MinimumConsecutiveNonWorkingMinutesPerWeek != null)
            {
                hash = hash * 59 + MinimumConsecutiveNonWorkingMinutesPerWeek.GetHashCode();
            }

            if (ConstrainMaximumConsecutiveWorkingWeekends != null)
            {
                hash = hash * 59 + ConstrainMaximumConsecutiveWorkingWeekends.GetHashCode();
            }

            if (MaximumConsecutiveWorkingWeekends != null)
            {
                hash = hash * 59 + MaximumConsecutiveWorkingWeekends.GetHashCode();
            }

            if (MinimumWorkingDaysPerWeek != null)
            {
                hash = hash * 59 + MinimumWorkingDaysPerWeek.GetHashCode();
            }

            if (ConstrainMaximumConsecutiveWorkingDays != null)
            {
                hash = hash * 59 + ConstrainMaximumConsecutiveWorkingDays.GetHashCode();
            }

            if (MaximumConsecutiveWorkingDays != null)
            {
                hash = hash * 59 + MaximumConsecutiveWorkingDays.GetHashCode();
            }

            if (MinimumShiftStartDistanceMinutes != null)
            {
                hash = hash * 59 + MinimumShiftStartDistanceMinutes.GetHashCode();
            }

            if (MinimumDaysOffPerPlanningPeriod != null)
            {
                hash = hash * 59 + MinimumDaysOffPerPlanningPeriod.GetHashCode();
            }

            if (MaximumDaysOffPerPlanningPeriod != null)
            {
                hash = hash * 59 + MaximumDaysOffPerPlanningPeriod.GetHashCode();
            }

            if (MinimumPaidMinutesPerPlanningPeriod != null)
            {
                hash = hash * 59 + MinimumPaidMinutesPerPlanningPeriod.GetHashCode();
            }

            if (MaximumPaidMinutesPerPlanningPeriod != null)
            {
                hash = hash * 59 + MaximumPaidMinutesPerPlanningPeriod.GetHashCode();
            }

            if (OptionalDays != null)
            {
                hash = hash * 59 + OptionalDays.GetHashCode();
            }

            if (ShiftStartVarianceType != null)
            {
                hash = hash * 59 + ShiftStartVarianceType.GetHashCode();
            }

            if (ShiftStartVariances != null)
            {
                hash = hash * 59 + ShiftStartVariances.GetHashCode();
            }

            if (Shifts != null)
            {
                hash = hash * 59 + Shifts.GetHashCode();
            }

            if (Agents != null)
            {
                hash = hash * 59 + Agents.GetHashCode();
            }

            if (AgentCount != null)
            {
                hash = hash * 59 + AgentCount.GetHashCode();
            }

            if (Metadata != null)
            {
                hash = hash * 59 + Metadata.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
