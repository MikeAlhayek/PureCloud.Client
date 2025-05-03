using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WorkPlanShift
/// </summary>

public partial class WorkPlanShift : IEquatable<WorkPlanShift>
{
    /// <summary>
    /// The day off rule for agents to have next day off or previous day off. used if constrainDayOff = true
    /// </summary>
    /// <value>The day off rule for agents to have next day off or previous day off. used if constrainDayOff = true</value>
    
    public enum DayOffRuleEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Nextdayoff for "NextDayOff"
        /// </summary>
        [EnumMember(Value = "NextDayOff")]
        Nextdayoff,

        /// <summary>
        /// Enum Previousdayoff for "PreviousDayOff"
        /// </summary>
        [EnumMember(Value = "PreviousDayOff")]
        Previousdayoff
    }
    /// <summary>
    /// The day off rule for agents to have next day off or previous day off. used if constrainDayOff = true
    /// </summary>
    /// <value>The day off rule for agents to have next day off or previous day off. used if constrainDayOff = true</value>
    [JsonPropertyName("dayOffRule")]
    public DayOffRuleEnum? DayOffRule { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="WorkPlanShift" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected WorkPlanShift() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="WorkPlanShift" /> class.
    /// </summary>
    /// <param name="Name">Name of the shift (required).</param>
    /// <param name="Days">Days of the week applicable for this shift.</param>
    /// <param name="FlexibleStartTime">Whether the start time of the shift is flexible.</param>
    /// <param name="ExactStartTimeMinutesFromMidnight">Exact start time of the shift defined as offset minutes from midnight. Used if flexibleStartTime &#x3D;&#x3D; false.</param>
    /// <param name="EarliestStartTimeMinutesFromMidnight">Earliest start time of the shift defined as offset minutes from midnight. Used if flexibleStartTime &#x3D;&#x3D; true.</param>
    /// <param name="LatestStartTimeMinutesFromMidnight">Latest start time of the shift defined as offset minutes from midnight. Used if flexibleStartTime &#x3D;&#x3D; true.</param>
    /// <param name="ConstrainStopTime">Whether the latest stop time constraint for the shift is enabled.  Deprecated, use constrainLatestStopTime instead.</param>
    /// <param name="ConstrainLatestStopTime">Whether the latest stop time constraint for the shift is enabled.</param>
    /// <param name="LatestStopTimeMinutesFromMidnight">Latest stop time of the shift defined as offset minutes from midnight. Used if constrainStopTime &#x3D;&#x3D; true.</param>
    /// <param name="ConstrainEarliestStopTime">Whether the earliest stop time constraint for the shift is enabled.</param>
    /// <param name="EarliestStopTimeMinutesFromMidnight">This is the earliest time a shift can end.</param>
    /// <param name="StartIncrementMinutes">Increment in offset minutes that would contribute to different possible start times for the shift. Used if flexibleStartTime &#x3D;&#x3D; true.</param>
    /// <param name="FlexiblePaidTime">Whether the paid time setting for the shift is flexible.</param>
    /// <param name="ExactPaidTimeMinutes">Exact paid time in minutes configured for the shift. Used if flexiblePaidTime &#x3D;&#x3D; false.</param>
    /// <param name="MinimumPaidTimeMinutes">Minimum paid time in minutes configured for the shift. Used if flexiblePaidTime &#x3D;&#x3D; true.</param>
    /// <param name="MaximumPaidTimeMinutes">Maximum paid time in minutes configured for the shift. Used if flexiblePaidTime &#x3D;&#x3D; true.</param>
    /// <param name="ConstrainContiguousWorkTime">Whether the contiguous time constraint for the shift is enabled.</param>
    /// <param name="MinimumContiguousWorkTimeMinutes">Minimum contiguous time in minutes configured for the shift. Used if constrainContiguousWorkTime &#x3D;&#x3D; true.</param>
    /// <param name="MaximumContiguousWorkTimeMinutes">Maximum contiguous time in minutes configured for the shift. Used if constrainContiguousWorkTime &#x3D;&#x3D; true.</param>
    /// <param name="ConstrainDayOff">Whether day off rule is enabled.</param>
    /// <param name="DayOffRule">The day off rule for agents to have next day off or previous day off. used if constrainDayOff &#x3D; true.</param>
    /// <param name="Activities">Activities configured for this shift.</param>
    /// <param name="Id">ID of the shift. This is required only for the case of updating an existing shift.</param>
    /// <param name="Delete">If marked true for updating an existing shift, the shift will be permanently deleted.</param>
    /// <param name="ValidationId">ID of shift in the context of work plan validation.</param>
    public WorkPlanShift(string Name = null, SetWrapperDayOfWeek Days = null, bool? FlexibleStartTime = null, int? ExactStartTimeMinutesFromMidnight = null, int? EarliestStartTimeMinutesFromMidnight = null, int? LatestStartTimeMinutesFromMidnight = null, bool? ConstrainStopTime = null, bool? ConstrainLatestStopTime = null, int? LatestStopTimeMinutesFromMidnight = null, bool? ConstrainEarliestStopTime = null, int? EarliestStopTimeMinutesFromMidnight = null, int? StartIncrementMinutes = null, bool? FlexiblePaidTime = null, int? ExactPaidTimeMinutes = null, int? MinimumPaidTimeMinutes = null, int? MaximumPaidTimeMinutes = null, bool? ConstrainContiguousWorkTime = null, int? MinimumContiguousWorkTimeMinutes = null, int? MaximumContiguousWorkTimeMinutes = null, bool? ConstrainDayOff = null, DayOffRuleEnum? DayOffRule = null, List<WorkPlanActivity> Activities = null, string Id = null, bool? Delete = null, string ValidationId = null)
    {
        this.Name = Name;
        this.Days = Days;
        this.FlexibleStartTime = FlexibleStartTime;
        this.ExactStartTimeMinutesFromMidnight = ExactStartTimeMinutesFromMidnight;
        this.EarliestStartTimeMinutesFromMidnight = EarliestStartTimeMinutesFromMidnight;
        this.LatestStartTimeMinutesFromMidnight = LatestStartTimeMinutesFromMidnight;
        this.ConstrainStopTime = ConstrainStopTime;
        this.ConstrainLatestStopTime = ConstrainLatestStopTime;
        this.LatestStopTimeMinutesFromMidnight = LatestStopTimeMinutesFromMidnight;
        this.ConstrainEarliestStopTime = ConstrainEarliestStopTime;
        this.EarliestStopTimeMinutesFromMidnight = EarliestStopTimeMinutesFromMidnight;
        this.StartIncrementMinutes = StartIncrementMinutes;
        this.FlexiblePaidTime = FlexiblePaidTime;
        this.ExactPaidTimeMinutes = ExactPaidTimeMinutes;
        this.MinimumPaidTimeMinutes = MinimumPaidTimeMinutes;
        this.MaximumPaidTimeMinutes = MaximumPaidTimeMinutes;
        this.ConstrainContiguousWorkTime = ConstrainContiguousWorkTime;
        this.MinimumContiguousWorkTimeMinutes = MinimumContiguousWorkTimeMinutes;
        this.MaximumContiguousWorkTimeMinutes = MaximumContiguousWorkTimeMinutes;
        this.ConstrainDayOff = ConstrainDayOff;
        this.DayOffRule = DayOffRule;
        this.Activities = Activities;
        this.Id = Id;
        this.Delete = Delete;
        this.ValidationId = ValidationId;

    }



    /// <summary>
    /// Name of the shift
    /// </summary>
    /// <value>Name of the shift</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// Days of the week applicable for this shift
    /// </summary>
    /// <value>Days of the week applicable for this shift</value>
    [JsonPropertyName("days")]
    public SetWrapperDayOfWeek Days { get; set; }



    /// <summary>
    /// Whether the start time of the shift is flexible
    /// </summary>
    /// <value>Whether the start time of the shift is flexible</value>
    [JsonPropertyName("flexibleStartTime")]
    public bool? FlexibleStartTime { get; set; }



    /// <summary>
    /// Exact start time of the shift defined as offset minutes from midnight. Used if flexibleStartTime &#x3D;&#x3D; false
    /// </summary>
    /// <value>Exact start time of the shift defined as offset minutes from midnight. Used if flexibleStartTime &#x3D;&#x3D; false</value>
    [JsonPropertyName("exactStartTimeMinutesFromMidnight")]
    public int? ExactStartTimeMinutesFromMidnight { get; set; }



    /// <summary>
    /// Earliest start time of the shift defined as offset minutes from midnight. Used if flexibleStartTime &#x3D;&#x3D; true
    /// </summary>
    /// <value>Earliest start time of the shift defined as offset minutes from midnight. Used if flexibleStartTime &#x3D;&#x3D; true</value>
    [JsonPropertyName("earliestStartTimeMinutesFromMidnight")]
    public int? EarliestStartTimeMinutesFromMidnight { get; set; }



    /// <summary>
    /// Latest start time of the shift defined as offset minutes from midnight. Used if flexibleStartTime &#x3D;&#x3D; true
    /// </summary>
    /// <value>Latest start time of the shift defined as offset minutes from midnight. Used if flexibleStartTime &#x3D;&#x3D; true</value>
    [JsonPropertyName("latestStartTimeMinutesFromMidnight")]
    public int? LatestStartTimeMinutesFromMidnight { get; set; }



    /// <summary>
    /// Whether the latest stop time constraint for the shift is enabled.  Deprecated, use constrainLatestStopTime instead
    /// </summary>
    /// <value>Whether the latest stop time constraint for the shift is enabled.  Deprecated, use constrainLatestStopTime instead</value>
    [JsonPropertyName("constrainStopTime")]
    public bool? ConstrainStopTime { get; set; }



    /// <summary>
    /// Whether the latest stop time constraint for the shift is enabled
    /// </summary>
    /// <value>Whether the latest stop time constraint for the shift is enabled</value>
    [JsonPropertyName("constrainLatestStopTime")]
    public bool? ConstrainLatestStopTime { get; set; }



    /// <summary>
    /// Latest stop time of the shift defined as offset minutes from midnight. Used if constrainStopTime &#x3D;&#x3D; true
    /// </summary>
    /// <value>Latest stop time of the shift defined as offset minutes from midnight. Used if constrainStopTime &#x3D;&#x3D; true</value>
    [JsonPropertyName("latestStopTimeMinutesFromMidnight")]
    public int? LatestStopTimeMinutesFromMidnight { get; set; }



    /// <summary>
    /// Whether the earliest stop time constraint for the shift is enabled
    /// </summary>
    /// <value>Whether the earliest stop time constraint for the shift is enabled</value>
    [JsonPropertyName("constrainEarliestStopTime")]
    public bool? ConstrainEarliestStopTime { get; set; }



    /// <summary>
    /// This is the earliest time a shift can end
    /// </summary>
    /// <value>This is the earliest time a shift can end</value>
    [JsonPropertyName("earliestStopTimeMinutesFromMidnight")]
    public int? EarliestStopTimeMinutesFromMidnight { get; set; }



    /// <summary>
    /// Increment in offset minutes that would contribute to different possible start times for the shift. Used if flexibleStartTime &#x3D;&#x3D; true
    /// </summary>
    /// <value>Increment in offset minutes that would contribute to different possible start times for the shift. Used if flexibleStartTime &#x3D;&#x3D; true</value>
    [JsonPropertyName("startIncrementMinutes")]
    public int? StartIncrementMinutes { get; set; }



    /// <summary>
    /// Whether the paid time setting for the shift is flexible
    /// </summary>
    /// <value>Whether the paid time setting for the shift is flexible</value>
    [JsonPropertyName("flexiblePaidTime")]
    public bool? FlexiblePaidTime { get; set; }



    /// <summary>
    /// Exact paid time in minutes configured for the shift. Used if flexiblePaidTime &#x3D;&#x3D; false
    /// </summary>
    /// <value>Exact paid time in minutes configured for the shift. Used if flexiblePaidTime &#x3D;&#x3D; false</value>
    [JsonPropertyName("exactPaidTimeMinutes")]
    public int? ExactPaidTimeMinutes { get; set; }



    /// <summary>
    /// Minimum paid time in minutes configured for the shift. Used if flexiblePaidTime &#x3D;&#x3D; true
    /// </summary>
    /// <value>Minimum paid time in minutes configured for the shift. Used if flexiblePaidTime &#x3D;&#x3D; true</value>
    [JsonPropertyName("minimumPaidTimeMinutes")]
    public int? MinimumPaidTimeMinutes { get; set; }



    /// <summary>
    /// Maximum paid time in minutes configured for the shift. Used if flexiblePaidTime &#x3D;&#x3D; true
    /// </summary>
    /// <value>Maximum paid time in minutes configured for the shift. Used if flexiblePaidTime &#x3D;&#x3D; true</value>
    [JsonPropertyName("maximumPaidTimeMinutes")]
    public int? MaximumPaidTimeMinutes { get; set; }



    /// <summary>
    /// Whether the contiguous time constraint for the shift is enabled
    /// </summary>
    /// <value>Whether the contiguous time constraint for the shift is enabled</value>
    [JsonPropertyName("constrainContiguousWorkTime")]
    public bool? ConstrainContiguousWorkTime { get; set; }



    /// <summary>
    /// Minimum contiguous time in minutes configured for the shift. Used if constrainContiguousWorkTime &#x3D;&#x3D; true
    /// </summary>
    /// <value>Minimum contiguous time in minutes configured for the shift. Used if constrainContiguousWorkTime &#x3D;&#x3D; true</value>
    [JsonPropertyName("minimumContiguousWorkTimeMinutes")]
    public int? MinimumContiguousWorkTimeMinutes { get; set; }



    /// <summary>
    /// Maximum contiguous time in minutes configured for the shift. Used if constrainContiguousWorkTime &#x3D;&#x3D; true
    /// </summary>
    /// <value>Maximum contiguous time in minutes configured for the shift. Used if constrainContiguousWorkTime &#x3D;&#x3D; true</value>
    [JsonPropertyName("maximumContiguousWorkTimeMinutes")]
    public int? MaximumContiguousWorkTimeMinutes { get; set; }



    /// <summary>
    /// Whether day off rule is enabled
    /// </summary>
    /// <value>Whether day off rule is enabled</value>
    [JsonPropertyName("constrainDayOff")]
    public bool? ConstrainDayOff { get; set; }





    /// <summary>
    /// Activities configured for this shift
    /// </summary>
    /// <value>Activities configured for this shift</value>
    [JsonPropertyName("activities")]
    public List<WorkPlanActivity> Activities { get; set; }



    /// <summary>
    /// ID of the shift. This is required only for the case of updating an existing shift
    /// </summary>
    /// <value>ID of the shift. This is required only for the case of updating an existing shift</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// If marked true for updating an existing shift, the shift will be permanently deleted
    /// </summary>
    /// <value>If marked true for updating an existing shift, the shift will be permanently deleted</value>
    [JsonPropertyName("delete")]
    public bool? Delete { get; set; }



    /// <summary>
    /// ID of shift in the context of work plan validation
    /// </summary>
    /// <value>ID of shift in the context of work plan validation</value>
    [JsonPropertyName("validationId")]
    public string ValidationId { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WorkPlanShift {\n");

        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Days: ").Append(Days).Append("\n");
        sb.Append("  FlexibleStartTime: ").Append(FlexibleStartTime).Append("\n");
        sb.Append("  ExactStartTimeMinutesFromMidnight: ").Append(ExactStartTimeMinutesFromMidnight).Append("\n");
        sb.Append("  EarliestStartTimeMinutesFromMidnight: ").Append(EarliestStartTimeMinutesFromMidnight).Append("\n");
        sb.Append("  LatestStartTimeMinutesFromMidnight: ").Append(LatestStartTimeMinutesFromMidnight).Append("\n");
        sb.Append("  ConstrainStopTime: ").Append(ConstrainStopTime).Append("\n");
        sb.Append("  ConstrainLatestStopTime: ").Append(ConstrainLatestStopTime).Append("\n");
        sb.Append("  LatestStopTimeMinutesFromMidnight: ").Append(LatestStopTimeMinutesFromMidnight).Append("\n");
        sb.Append("  ConstrainEarliestStopTime: ").Append(ConstrainEarliestStopTime).Append("\n");
        sb.Append("  EarliestStopTimeMinutesFromMidnight: ").Append(EarliestStopTimeMinutesFromMidnight).Append("\n");
        sb.Append("  StartIncrementMinutes: ").Append(StartIncrementMinutes).Append("\n");
        sb.Append("  FlexiblePaidTime: ").Append(FlexiblePaidTime).Append("\n");
        sb.Append("  ExactPaidTimeMinutes: ").Append(ExactPaidTimeMinutes).Append("\n");
        sb.Append("  MinimumPaidTimeMinutes: ").Append(MinimumPaidTimeMinutes).Append("\n");
        sb.Append("  MaximumPaidTimeMinutes: ").Append(MaximumPaidTimeMinutes).Append("\n");
        sb.Append("  ConstrainContiguousWorkTime: ").Append(ConstrainContiguousWorkTime).Append("\n");
        sb.Append("  MinimumContiguousWorkTimeMinutes: ").Append(MinimumContiguousWorkTimeMinutes).Append("\n");
        sb.Append("  MaximumContiguousWorkTimeMinutes: ").Append(MaximumContiguousWorkTimeMinutes).Append("\n");
        sb.Append("  ConstrainDayOff: ").Append(ConstrainDayOff).Append("\n");
        sb.Append("  DayOffRule: ").Append(DayOffRule).Append("\n");
        sb.Append("  Activities: ").Append(Activities).Append("\n");
        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Delete: ").Append(Delete).Append("\n");
        sb.Append("  ValidationId: ").Append(ValidationId).Append("\n");
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
        return Equals(obj as WorkPlanShift);
    }

    /// <summary>
    /// Returns true if WorkPlanShift instances are equal
    /// </summary>
    /// <param name="other">Instance of WorkPlanShift to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WorkPlanShift other)
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
                Days == other.Days ||
                Days != null &&
                Days.Equals(other.Days)
            ) &&
            (
                FlexibleStartTime == other.FlexibleStartTime ||
                FlexibleStartTime != null &&
                FlexibleStartTime.Equals(other.FlexibleStartTime)
            ) &&
            (
                ExactStartTimeMinutesFromMidnight == other.ExactStartTimeMinutesFromMidnight ||
                ExactStartTimeMinutesFromMidnight != null &&
                ExactStartTimeMinutesFromMidnight.Equals(other.ExactStartTimeMinutesFromMidnight)
            ) &&
            (
                EarliestStartTimeMinutesFromMidnight == other.EarliestStartTimeMinutesFromMidnight ||
                EarliestStartTimeMinutesFromMidnight != null &&
                EarliestStartTimeMinutesFromMidnight.Equals(other.EarliestStartTimeMinutesFromMidnight)
            ) &&
            (
                LatestStartTimeMinutesFromMidnight == other.LatestStartTimeMinutesFromMidnight ||
                LatestStartTimeMinutesFromMidnight != null &&
                LatestStartTimeMinutesFromMidnight.Equals(other.LatestStartTimeMinutesFromMidnight)
            ) &&
            (
                ConstrainStopTime == other.ConstrainStopTime ||
                ConstrainStopTime != null &&
                ConstrainStopTime.Equals(other.ConstrainStopTime)
            ) &&
            (
                ConstrainLatestStopTime == other.ConstrainLatestStopTime ||
                ConstrainLatestStopTime != null &&
                ConstrainLatestStopTime.Equals(other.ConstrainLatestStopTime)
            ) &&
            (
                LatestStopTimeMinutesFromMidnight == other.LatestStopTimeMinutesFromMidnight ||
                LatestStopTimeMinutesFromMidnight != null &&
                LatestStopTimeMinutesFromMidnight.Equals(other.LatestStopTimeMinutesFromMidnight)
            ) &&
            (
                ConstrainEarliestStopTime == other.ConstrainEarliestStopTime ||
                ConstrainEarliestStopTime != null &&
                ConstrainEarliestStopTime.Equals(other.ConstrainEarliestStopTime)
            ) &&
            (
                EarliestStopTimeMinutesFromMidnight == other.EarliestStopTimeMinutesFromMidnight ||
                EarliestStopTimeMinutesFromMidnight != null &&
                EarliestStopTimeMinutesFromMidnight.Equals(other.EarliestStopTimeMinutesFromMidnight)
            ) &&
            (
                StartIncrementMinutes == other.StartIncrementMinutes ||
                StartIncrementMinutes != null &&
                StartIncrementMinutes.Equals(other.StartIncrementMinutes)
            ) &&
            (
                FlexiblePaidTime == other.FlexiblePaidTime ||
                FlexiblePaidTime != null &&
                FlexiblePaidTime.Equals(other.FlexiblePaidTime)
            ) &&
            (
                ExactPaidTimeMinutes == other.ExactPaidTimeMinutes ||
                ExactPaidTimeMinutes != null &&
                ExactPaidTimeMinutes.Equals(other.ExactPaidTimeMinutes)
            ) &&
            (
                MinimumPaidTimeMinutes == other.MinimumPaidTimeMinutes ||
                MinimumPaidTimeMinutes != null &&
                MinimumPaidTimeMinutes.Equals(other.MinimumPaidTimeMinutes)
            ) &&
            (
                MaximumPaidTimeMinutes == other.MaximumPaidTimeMinutes ||
                MaximumPaidTimeMinutes != null &&
                MaximumPaidTimeMinutes.Equals(other.MaximumPaidTimeMinutes)
            ) &&
            (
                ConstrainContiguousWorkTime == other.ConstrainContiguousWorkTime ||
                ConstrainContiguousWorkTime != null &&
                ConstrainContiguousWorkTime.Equals(other.ConstrainContiguousWorkTime)
            ) &&
            (
                MinimumContiguousWorkTimeMinutes == other.MinimumContiguousWorkTimeMinutes ||
                MinimumContiguousWorkTimeMinutes != null &&
                MinimumContiguousWorkTimeMinutes.Equals(other.MinimumContiguousWorkTimeMinutes)
            ) &&
            (
                MaximumContiguousWorkTimeMinutes == other.MaximumContiguousWorkTimeMinutes ||
                MaximumContiguousWorkTimeMinutes != null &&
                MaximumContiguousWorkTimeMinutes.Equals(other.MaximumContiguousWorkTimeMinutes)
            ) &&
            (
                ConstrainDayOff == other.ConstrainDayOff ||
                ConstrainDayOff != null &&
                ConstrainDayOff.Equals(other.ConstrainDayOff)
            ) &&
            (
                DayOffRule == other.DayOffRule ||
                DayOffRule != null &&
                DayOffRule.Equals(other.DayOffRule)
            ) &&
            (
                Activities == other.Activities ||
                Activities != null &&
                Activities.SequenceEqual(other.Activities)
            ) &&
            (
                Id == other.Id ||
                Id != null &&
                Id.Equals(other.Id)
            ) &&
            (
                Delete == other.Delete ||
                Delete != null &&
                Delete.Equals(other.Delete)
            ) &&
            (
                ValidationId == other.ValidationId ||
                ValidationId != null &&
                ValidationId.Equals(other.ValidationId)
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

            if (Days != null)
            {
                hash = hash * 59 + Days.GetHashCode();
            }

            if (FlexibleStartTime != null)
            {
                hash = hash * 59 + FlexibleStartTime.GetHashCode();
            }

            if (ExactStartTimeMinutesFromMidnight != null)
            {
                hash = hash * 59 + ExactStartTimeMinutesFromMidnight.GetHashCode();
            }

            if (EarliestStartTimeMinutesFromMidnight != null)
            {
                hash = hash * 59 + EarliestStartTimeMinutesFromMidnight.GetHashCode();
            }

            if (LatestStartTimeMinutesFromMidnight != null)
            {
                hash = hash * 59 + LatestStartTimeMinutesFromMidnight.GetHashCode();
            }

            if (ConstrainStopTime != null)
            {
                hash = hash * 59 + ConstrainStopTime.GetHashCode();
            }

            if (ConstrainLatestStopTime != null)
            {
                hash = hash * 59 + ConstrainLatestStopTime.GetHashCode();
            }

            if (LatestStopTimeMinutesFromMidnight != null)
            {
                hash = hash * 59 + LatestStopTimeMinutesFromMidnight.GetHashCode();
            }

            if (ConstrainEarliestStopTime != null)
            {
                hash = hash * 59 + ConstrainEarliestStopTime.GetHashCode();
            }

            if (EarliestStopTimeMinutesFromMidnight != null)
            {
                hash = hash * 59 + EarliestStopTimeMinutesFromMidnight.GetHashCode();
            }

            if (StartIncrementMinutes != null)
            {
                hash = hash * 59 + StartIncrementMinutes.GetHashCode();
            }

            if (FlexiblePaidTime != null)
            {
                hash = hash * 59 + FlexiblePaidTime.GetHashCode();
            }

            if (ExactPaidTimeMinutes != null)
            {
                hash = hash * 59 + ExactPaidTimeMinutes.GetHashCode();
            }

            if (MinimumPaidTimeMinutes != null)
            {
                hash = hash * 59 + MinimumPaidTimeMinutes.GetHashCode();
            }

            if (MaximumPaidTimeMinutes != null)
            {
                hash = hash * 59 + MaximumPaidTimeMinutes.GetHashCode();
            }

            if (ConstrainContiguousWorkTime != null)
            {
                hash = hash * 59 + ConstrainContiguousWorkTime.GetHashCode();
            }

            if (MinimumContiguousWorkTimeMinutes != null)
            {
                hash = hash * 59 + MinimumContiguousWorkTimeMinutes.GetHashCode();
            }

            if (MaximumContiguousWorkTimeMinutes != null)
            {
                hash = hash * 59 + MaximumContiguousWorkTimeMinutes.GetHashCode();
            }

            if (ConstrainDayOff != null)
            {
                hash = hash * 59 + ConstrainDayOff.GetHashCode();
            }

            if (DayOffRule != null)
            {
                hash = hash * 59 + DayOffRule.GetHashCode();
            }

            if (Activities != null)
            {
                hash = hash * 59 + Activities.GetHashCode();
            }

            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            if (Delete != null)
            {
                hash = hash * 59 + Delete.GetHashCode();
            }

            if (ValidationId != null)
            {
                hash = hash * 59 + ValidationId.GetHashCode();
            }

            return hash;
        }
    }
}
