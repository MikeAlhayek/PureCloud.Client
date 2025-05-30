using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// FixedAvailability
/// </summary>

public partial class FixedAvailability : IEquatable<FixedAvailability>
{
    /// <summary>
    /// Gets or Sets DaysOfWeek
    /// </summary>
    
    public enum DaysOfWeekEnum
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
    /// Initializes a new instance of the <see cref="FixedAvailability" /> class.
    /// </summary>
    /// <param name="AvailabilityRange">The range of time of day the activity can be scheduled.</param>
    /// <param name="DateRange">The range of date for which the activity plan could be scheduled.</param>
    /// <param name="DaysOfWeek">The days of week available for scheduling. Empty list or null means daysOfWeek is not considered.</param>
    public FixedAvailability(AvailabilityRange AvailabilityRange = null, RequiredLocalDateRange DateRange = null, List<DaysOfWeekEnum> DaysOfWeek = null)
    {
        this.AvailabilityRange = AvailabilityRange;
        this.DateRange = DateRange;
        this.DaysOfWeek = DaysOfWeek;

    }



    /// <summary>
    /// The range of time of day the activity can be scheduled
    /// </summary>
    /// <value>The range of time of day the activity can be scheduled</value>
    [JsonPropertyName("availabilityRange")]
    public AvailabilityRange AvailabilityRange { get; set; }



    /// <summary>
    /// The range of date for which the activity plan could be scheduled
    /// </summary>
    /// <value>The range of date for which the activity plan could be scheduled</value>
    [JsonPropertyName("dateRange")]
    public RequiredLocalDateRange DateRange { get; set; }



    /// <summary>
    /// The days of week available for scheduling. Empty list or null means daysOfWeek is not considered
    /// </summary>
    /// <value>The days of week available for scheduling. Empty list or null means daysOfWeek is not considered</value>
    [JsonPropertyName("daysOfWeek")]
    public List<DaysOfWeekEnum> DaysOfWeek { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class FixedAvailability {\n");

        sb.Append("  AvailabilityRange: ").Append(AvailabilityRange).Append("\n");
        sb.Append("  DateRange: ").Append(DateRange).Append("\n");
        sb.Append("  DaysOfWeek: ").Append(DaysOfWeek).Append("\n");
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
        return Equals(obj as FixedAvailability);
    }

    /// <summary>
    /// Returns true if FixedAvailability instances are equal
    /// </summary>
    /// <param name="other">Instance of FixedAvailability to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(FixedAvailability other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                AvailabilityRange == other.AvailabilityRange ||
                AvailabilityRange != null &&
                AvailabilityRange.Equals(other.AvailabilityRange)
            ) &&
            (
                DateRange == other.DateRange ||
                DateRange != null &&
                DateRange.Equals(other.DateRange)
            ) &&
            (
                DaysOfWeek == other.DaysOfWeek ||
                DaysOfWeek != null &&
                DaysOfWeek.SequenceEqual(other.DaysOfWeek)
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
            if (AvailabilityRange != null)
            {
                hash = hash * 59 + AvailabilityRange.GetHashCode();
            }

            if (DateRange != null)
            {
                hash = hash * 59 + DateRange.GetHashCode();
            }

            if (DaysOfWeek != null)
            {
                hash = hash * 59 + DaysOfWeek.GetHashCode();
            }

            return hash;
        }
    }
}
