using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// CoachingSlot
/// </summary>

public partial class CoachingSlot : IEquatable<CoachingSlot>
{
    /// <summary>
    /// Rating based on the staffing difference for scheduled slot
    /// </summary>
    /// <value>Rating based on the staffing difference for scheduled slot</value>
    
    public enum DifferenceRatingEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Poor for "Poor"
        /// </summary>
        [EnumMember(Value = "Poor")]
        Poor,

        /// <summary>
        /// Enum Neutral for "Neutral"
        /// </summary>
        [EnumMember(Value = "Neutral")]
        Neutral,

        /// <summary>
        /// Enum Good for "Good"
        /// </summary>
        [EnumMember(Value = "Good")]
        Good
    }
    /// <summary>
    /// Rating based on the staffing difference for scheduled slot
    /// </summary>
    /// <value>Rating based on the staffing difference for scheduled slot</value>
    [JsonPropertyName("differenceRating")]
    public DifferenceRatingEnum? DifferenceRating { get; private set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="CoachingSlot" /> class.
    /// </summary>
    public CoachingSlot()
    {

    }



    /// <summary>
    /// Start date and time of scheduled coaching appointment slot. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Start date and time of scheduled coaching appointment slot. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateStart")]
    public DateTime? DateStart { get; private set; }



    /// <summary>
    /// Length of coaching appointment slot in minutes
    /// </summary>
    /// <value>Length of coaching appointment slot in minutes</value>
    [JsonPropertyName("lengthInMinutes")]
    public int? LengthInMinutes { get; private set; }



    /// <summary>
    /// Difference between scheduled and forecast headcount for this slot after scheduling the coaching appointment
    /// </summary>
    /// <value>Difference between scheduled and forecast headcount for this slot after scheduling the coaching appointment</value>
    [JsonPropertyName("staffingDifference")]
    public double? StaffingDifference { get; private set; }





    /// <summary>
    /// Workforce Management schedule information associated with the slot
    /// </summary>
    /// <value>Workforce Management schedule information associated with the slot</value>
    [JsonPropertyName("wfmSchedule")]
    public WfmScheduleReference WfmSchedule { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CoachingSlot {\n");

        sb.Append("  DateStart: ").Append(DateStart).Append("\n");
        sb.Append("  LengthInMinutes: ").Append(LengthInMinutes).Append("\n");
        sb.Append("  StaffingDifference: ").Append(StaffingDifference).Append("\n");
        sb.Append("  DifferenceRating: ").Append(DifferenceRating).Append("\n");
        sb.Append("  WfmSchedule: ").Append(WfmSchedule).Append("\n");
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
        return Equals(obj as CoachingSlot);
    }

    /// <summary>
    /// Returns true if CoachingSlot instances are equal
    /// </summary>
    /// <param name="other">Instance of CoachingSlot to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CoachingSlot other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                DateStart == other.DateStart ||
                DateStart != null &&
                DateStart.Equals(other.DateStart)
            ) &&
            (
                LengthInMinutes == other.LengthInMinutes ||
                LengthInMinutes != null &&
                LengthInMinutes.Equals(other.LengthInMinutes)
            ) &&
            (
                StaffingDifference == other.StaffingDifference ||
                StaffingDifference != null &&
                StaffingDifference.Equals(other.StaffingDifference)
            ) &&
            (
                DifferenceRating == other.DifferenceRating ||
                DifferenceRating != null &&
                DifferenceRating.Equals(other.DifferenceRating)
            ) &&
            (
                WfmSchedule == other.WfmSchedule ||
                WfmSchedule != null &&
                WfmSchedule.Equals(other.WfmSchedule)
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
            if (DateStart != null)
            {
                hash = hash * 59 + DateStart.GetHashCode();
            }

            if (LengthInMinutes != null)
            {
                hash = hash * 59 + LengthInMinutes.GetHashCode();
            }

            if (StaffingDifference != null)
            {
                hash = hash * 59 + StaffingDifference.GetHashCode();
            }

            if (DifferenceRating != null)
            {
                hash = hash * 59 + DifferenceRating.GetHashCode();
            }

            if (WfmSchedule != null)
            {
                hash = hash * 59 + WfmSchedule.GetHashCode();
            }

            return hash;
        }
    }
}
