using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// SchedulingSettingsRequest
/// </summary>

public partial class SchedulingSettingsRequest : IEquatable<SchedulingSettingsRequest>
{
    /// <summary>
    /// Start day of weekend for scheduling
    /// </summary>
    /// <value>Start day of weekend for scheduling</value>
    
    public enum StartDayOfWeekendEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Sunday for "Sunday"
        /// </summary>
        [EnumMember(Value = "Sunday")]
        Sunday,

        /// <summary>
        /// Enum Monday for "Monday"
        /// </summary>
        [EnumMember(Value = "Monday")]
        Monday,

        /// <summary>
        /// Enum Tuesday for "Tuesday"
        /// </summary>
        [EnumMember(Value = "Tuesday")]
        Tuesday,

        /// <summary>
        /// Enum Wednesday for "Wednesday"
        /// </summary>
        [EnumMember(Value = "Wednesday")]
        Wednesday,

        /// <summary>
        /// Enum Thursday for "Thursday"
        /// </summary>
        [EnumMember(Value = "Thursday")]
        Thursday,

        /// <summary>
        /// Enum Friday for "Friday"
        /// </summary>
        [EnumMember(Value = "Friday")]
        Friday,

        /// <summary>
        /// Enum Saturday for "Saturday"
        /// </summary>
        [EnumMember(Value = "Saturday")]
        Saturday
    }
    /// <summary>
    /// Start day of weekend for scheduling
    /// </summary>
    /// <value>Start day of weekend for scheduling</value>
    [JsonPropertyName("startDayOfWeekend")]
    public StartDayOfWeekendEnum? StartDayOfWeekend { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="SchedulingSettingsRequest" /> class.
    /// </summary>
    /// <param name="MaxOccupancyPercentForDeferredWork">Max occupancy percent for deferred work.</param>
    /// <param name="DefaultShrinkagePercent">Default shrinkage percent for scheduling.</param>
    /// <param name="ShrinkageOverrides">Shrinkage overrides for scheduling.</param>
    /// <param name="PlanningPeriod">Planning period settings for scheduling. Only one of planningPeriod or monthlyPlanningPeriod may be defined.</param>
    /// <param name="MonthlyPlanningPeriod">Monthly planning period setting for scheduling. Only one of planningPeriod or monthlyPlanningPeriod may be defined.</param>
    /// <param name="StartDayOfWeekend">Start day of weekend for scheduling.</param>
    public SchedulingSettingsRequest(int? MaxOccupancyPercentForDeferredWork = null, double? DefaultShrinkagePercent = null, ShrinkageOverrides ShrinkageOverrides = null, ValueWrapperPlanningPeriodSettings PlanningPeriod = null, ValueWrapperMonthlyPlanningPeriodSettings MonthlyPlanningPeriod = null, StartDayOfWeekendEnum? StartDayOfWeekend = null)
    {
        this.MaxOccupancyPercentForDeferredWork = MaxOccupancyPercentForDeferredWork;
        this.DefaultShrinkagePercent = DefaultShrinkagePercent;
        this.ShrinkageOverrides = ShrinkageOverrides;
        this.PlanningPeriod = PlanningPeriod;
        this.MonthlyPlanningPeriod = MonthlyPlanningPeriod;
        this.StartDayOfWeekend = StartDayOfWeekend;

    }



    /// <summary>
    /// Max occupancy percent for deferred work
    /// </summary>
    /// <value>Max occupancy percent for deferred work</value>
    [JsonPropertyName("maxOccupancyPercentForDeferredWork")]
    public int? MaxOccupancyPercentForDeferredWork { get; set; }



    /// <summary>
    /// Default shrinkage percent for scheduling
    /// </summary>
    /// <value>Default shrinkage percent for scheduling</value>
    [JsonPropertyName("defaultShrinkagePercent")]
    public double? DefaultShrinkagePercent { get; set; }



    /// <summary>
    /// Shrinkage overrides for scheduling
    /// </summary>
    /// <value>Shrinkage overrides for scheduling</value>
    [JsonPropertyName("shrinkageOverrides")]
    public ShrinkageOverrides ShrinkageOverrides { get; set; }



    /// <summary>
    /// Planning period settings for scheduling. Only one of planningPeriod or monthlyPlanningPeriod may be defined
    /// </summary>
    /// <value>Planning period settings for scheduling. Only one of planningPeriod or monthlyPlanningPeriod may be defined</value>
    [JsonPropertyName("planningPeriod")]
    public ValueWrapperPlanningPeriodSettings PlanningPeriod { get; set; }



    /// <summary>
    /// Monthly planning period setting for scheduling. Only one of planningPeriod or monthlyPlanningPeriod may be defined
    /// </summary>
    /// <value>Monthly planning period setting for scheduling. Only one of planningPeriod or monthlyPlanningPeriod may be defined</value>
    [JsonPropertyName("monthlyPlanningPeriod")]
    public ValueWrapperMonthlyPlanningPeriodSettings MonthlyPlanningPeriod { get; set; }




    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class SchedulingSettingsRequest {\n");

        sb.Append("  MaxOccupancyPercentForDeferredWork: ").Append(MaxOccupancyPercentForDeferredWork).Append("\n");
        sb.Append("  DefaultShrinkagePercent: ").Append(DefaultShrinkagePercent).Append("\n");
        sb.Append("  ShrinkageOverrides: ").Append(ShrinkageOverrides).Append("\n");
        sb.Append("  PlanningPeriod: ").Append(PlanningPeriod).Append("\n");
        sb.Append("  MonthlyPlanningPeriod: ").Append(MonthlyPlanningPeriod).Append("\n");
        sb.Append("  StartDayOfWeekend: ").Append(StartDayOfWeekend).Append("\n");
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
        return Equals(obj as SchedulingSettingsRequest);
    }

    /// <summary>
    /// Returns true if SchedulingSettingsRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of SchedulingSettingsRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(SchedulingSettingsRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                MaxOccupancyPercentForDeferredWork == other.MaxOccupancyPercentForDeferredWork ||
                MaxOccupancyPercentForDeferredWork != null &&
                MaxOccupancyPercentForDeferredWork.Equals(other.MaxOccupancyPercentForDeferredWork)
            ) &&
            (
                DefaultShrinkagePercent == other.DefaultShrinkagePercent ||
                DefaultShrinkagePercent != null &&
                DefaultShrinkagePercent.Equals(other.DefaultShrinkagePercent)
            ) &&
            (
                ShrinkageOverrides == other.ShrinkageOverrides ||
                ShrinkageOverrides != null &&
                ShrinkageOverrides.Equals(other.ShrinkageOverrides)
            ) &&
            (
                PlanningPeriod == other.PlanningPeriod ||
                PlanningPeriod != null &&
                PlanningPeriod.Equals(other.PlanningPeriod)
            ) &&
            (
                MonthlyPlanningPeriod == other.MonthlyPlanningPeriod ||
                MonthlyPlanningPeriod != null &&
                MonthlyPlanningPeriod.Equals(other.MonthlyPlanningPeriod)
            ) &&
            (
                StartDayOfWeekend == other.StartDayOfWeekend ||
                StartDayOfWeekend != null &&
                StartDayOfWeekend.Equals(other.StartDayOfWeekend)
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
            if (MaxOccupancyPercentForDeferredWork != null)
            {
                hash = hash * 59 + MaxOccupancyPercentForDeferredWork.GetHashCode();
            }

            if (DefaultShrinkagePercent != null)
            {
                hash = hash * 59 + DefaultShrinkagePercent.GetHashCode();
            }

            if (ShrinkageOverrides != null)
            {
                hash = hash * 59 + ShrinkageOverrides.GetHashCode();
            }

            if (PlanningPeriod != null)
            {
                hash = hash * 59 + PlanningPeriod.GetHashCode();
            }

            if (MonthlyPlanningPeriod != null)
            {
                hash = hash * 59 + MonthlyPlanningPeriod.GetHashCode();
            }

            if (StartDayOfWeekend != null)
            {
                hash = hash * 59 + StartDayOfWeekend.GetHashCode();
            }

            return hash;
        }
    }
}
