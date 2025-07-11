using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class CoachingSlot
{
    /// <summary>
    /// Rating based on the staffing difference for scheduled slot
    /// </summary>
    /// <value>Rating based on the staffing difference for scheduled slot</value>
    public CoachingSlotDifferenceRatingEnum? DifferenceRating { get; set; }

    /// <summary>
    /// Start date and time of scheduled coaching appointment slot. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Start date and time of scheduled coaching appointment slot. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateStart { get; set; }

    /// <summary>
    /// Length of coaching appointment slot in minutes
    /// </summary>
    /// <value>Length of coaching appointment slot in minutes</value>
    public int? LengthInMinutes { get; set; }

    /// <summary>
    /// Difference between scheduled and forecast headcount for this slot after scheduling the coaching appointment
    /// </summary>
    /// <value>Difference between scheduled and forecast headcount for this slot after scheduling the coaching appointment</value>
    public double? StaffingDifference { get; set; }

    /// <summary>
    /// Workforce Management schedule information associated with the slot
    /// </summary>
    /// <value>Workforce Management schedule information associated with the slot</value>
    public WfmScheduleReference WfmSchedule { get; set; }
}
