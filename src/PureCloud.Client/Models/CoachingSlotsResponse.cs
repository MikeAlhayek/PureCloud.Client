using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class CoachingSlotsResponse
{
    /// <summary>
    /// List of slots where coaching appointment can be scheduled
    /// </summary>
    /// <value>List of slots where coaching appointment can be scheduled</value>
    public IEnumerable<CoachingSlot> SuggestedSlots { get; set; }

    /// <summary>
    /// Periods of availability for attendees to schedule coaching appointment
    /// </summary>
    /// <value>Periods of availability for attendees to schedule coaching appointment</value>
    public IEnumerable<UserAvailableTimes> AttendeeSchedules { get; set; }

    /// <summary>
    /// Periods of availability for facilitators to schedule coaching appointment
    /// </summary>
    /// <value>Periods of availability for facilitators to schedule coaching appointment</value>
    public IEnumerable<UserAvailableTimes> FacilitatorSchedules { get; set; }

    /// <summary>
    /// Detailed data for WFM scheduled activities
    /// </summary>
    /// <value>Detailed data for WFM scheduled activities</value>
    public IEnumerable<WfmScheduleActivity> WfmScheduleActivities { get; set; }
}
