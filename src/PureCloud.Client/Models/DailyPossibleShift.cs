using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// DailyPossibleShift
/// </summary>

public partial class DailyPossibleShift : IEquatable<DailyPossibleShift>
{
    /// <summary>
    /// Day of the shift
    /// </summary>
    /// <value>Day of the shift</value>
    
    public enum DayOfWeekEnum
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
    /// Day of the shift
    /// </summary>
    /// <value>Day of the shift</value>
    [JsonPropertyName("dayOfWeek")]
    public DayOfWeekEnum? DayOfWeek { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="DailyPossibleShift" /> class.
    /// </summary>
    /// <param name="DayOfWeek">Day of the shift.</param>
    /// <param name="EarliestShiftStartMinutesFromMidnight">Minutes of the earliest shift start from midnight. Note that midnight is 12:00 am in the time zone specified in the timeZone field (in the top level of the response).</param>
    /// <param name="Required">Whether this is a required shift.</param>
    /// <param name="MinimumPaidTimeMinutes">Minimum paid time in minutes of this daily shift.</param>
    /// <param name="MaximumPaidTimeMinutes">Maximum paid time in minutes of this daily shift.</param>
    /// <param name="IntervalScheduleProbabilities">The percentage of being scheduled in each interval between the earliest shift start and latest shift end. Range of the values: [0, 100]..</param>
    public DailyPossibleShift(DayOfWeekEnum? DayOfWeek = null, int? EarliestShiftStartMinutesFromMidnight = null, bool? Required = null, int? MinimumPaidTimeMinutes = null, int? MaximumPaidTimeMinutes = null, List<int?> IntervalScheduleProbabilities = null)
    {
        this.DayOfWeek = DayOfWeek;
        this.EarliestShiftStartMinutesFromMidnight = EarliestShiftStartMinutesFromMidnight;
        this.Required = Required;
        this.MinimumPaidTimeMinutes = MinimumPaidTimeMinutes;
        this.MaximumPaidTimeMinutes = MaximumPaidTimeMinutes;
        this.IntervalScheduleProbabilities = IntervalScheduleProbabilities;

    }





    /// <summary>
    /// Minutes of the earliest shift start from midnight. Note that midnight is 12:00 am in the time zone specified in the timeZone field (in the top level of the response)
    /// </summary>
    /// <value>Minutes of the earliest shift start from midnight. Note that midnight is 12:00 am in the time zone specified in the timeZone field (in the top level of the response)</value>
    [JsonPropertyName("earliestShiftStartMinutesFromMidnight")]
    public int? EarliestShiftStartMinutesFromMidnight { get; set; }



    /// <summary>
    /// Whether this is a required shift
    /// </summary>
    /// <value>Whether this is a required shift</value>
    [JsonPropertyName("required")]
    public bool? Required { get; set; }



    /// <summary>
    /// Minimum paid time in minutes of this daily shift
    /// </summary>
    /// <value>Minimum paid time in minutes of this daily shift</value>
    [JsonPropertyName("minimumPaidTimeMinutes")]
    public int? MinimumPaidTimeMinutes { get; set; }



    /// <summary>
    /// Maximum paid time in minutes of this daily shift
    /// </summary>
    /// <value>Maximum paid time in minutes of this daily shift</value>
    [JsonPropertyName("maximumPaidTimeMinutes")]
    public int? MaximumPaidTimeMinutes { get; set; }



    /// <summary>
    /// The percentage of being scheduled in each interval between the earliest shift start and latest shift end. Range of the values: [0, 100].
    /// </summary>
    /// <value>The percentage of being scheduled in each interval between the earliest shift start and latest shift end. Range of the values: [0, 100].</value>
    [JsonPropertyName("intervalScheduleProbabilities")]
    public List<int?> IntervalScheduleProbabilities { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class DailyPossibleShift {\n");

        sb.Append("  DayOfWeek: ").Append(DayOfWeek).Append("\n");
        sb.Append("  EarliestShiftStartMinutesFromMidnight: ").Append(EarliestShiftStartMinutesFromMidnight).Append("\n");
        sb.Append("  Required: ").Append(Required).Append("\n");
        sb.Append("  MinimumPaidTimeMinutes: ").Append(MinimumPaidTimeMinutes).Append("\n");
        sb.Append("  MaximumPaidTimeMinutes: ").Append(MaximumPaidTimeMinutes).Append("\n");
        sb.Append("  IntervalScheduleProbabilities: ").Append(IntervalScheduleProbabilities).Append("\n");
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
        return Equals(obj as DailyPossibleShift);
    }

    /// <summary>
    /// Returns true if DailyPossibleShift instances are equal
    /// </summary>
    /// <param name="other">Instance of DailyPossibleShift to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DailyPossibleShift other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                DayOfWeek == other.DayOfWeek ||
                DayOfWeek != null &&
                DayOfWeek.Equals(other.DayOfWeek)
            ) &&
            (
                EarliestShiftStartMinutesFromMidnight == other.EarliestShiftStartMinutesFromMidnight ||
                EarliestShiftStartMinutesFromMidnight != null &&
                EarliestShiftStartMinutesFromMidnight.Equals(other.EarliestShiftStartMinutesFromMidnight)
            ) &&
            (
                Required == other.Required ||
                Required != null &&
                Required.Equals(other.Required)
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
                IntervalScheduleProbabilities == other.IntervalScheduleProbabilities ||
                IntervalScheduleProbabilities != null &&
                IntervalScheduleProbabilities.SequenceEqual(other.IntervalScheduleProbabilities)
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
            if (DayOfWeek != null)
            {
                hash = hash * 59 + DayOfWeek.GetHashCode();
            }

            if (EarliestShiftStartMinutesFromMidnight != null)
            {
                hash = hash * 59 + EarliestShiftStartMinutesFromMidnight.GetHashCode();
            }

            if (Required != null)
            {
                hash = hash * 59 + Required.GetHashCode();
            }

            if (MinimumPaidTimeMinutes != null)
            {
                hash = hash * 59 + MinimumPaidTimeMinutes.GetHashCode();
            }

            if (MaximumPaidTimeMinutes != null)
            {
                hash = hash * 59 + MaximumPaidTimeMinutes.GetHashCode();
            }

            if (IntervalScheduleProbabilities != null)
            {
                hash = hash * 59 + IntervalScheduleProbabilities.GetHashCode();
            }

            return hash;
        }
    }
}
