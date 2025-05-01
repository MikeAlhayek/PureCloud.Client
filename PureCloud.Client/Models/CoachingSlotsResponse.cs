using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// CoachingSlotsResponse
/// </summary>
[DataContract]
public partial class CoachingSlotsResponse : IEquatable<CoachingSlotsResponse>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CoachingSlotsResponse" /> class.
    /// </summary>
    public CoachingSlotsResponse()
    {

    }



    /// <summary>
    /// List of slots where coaching appointment can be scheduled
    /// </summary>
    /// <value>List of slots where coaching appointment can be scheduled</value>
    [DataMember(Name = "suggestedSlots", EmitDefaultValue = false)]
    public List<CoachingSlot> SuggestedSlots { get; private set; }



    /// <summary>
    /// Periods of availability for attendees to schedule coaching appointment
    /// </summary>
    /// <value>Periods of availability for attendees to schedule coaching appointment</value>
    [DataMember(Name = "attendeeSchedules", EmitDefaultValue = false)]
    public List<UserAvailableTimes> AttendeeSchedules { get; private set; }



    /// <summary>
    /// Periods of availability for facilitators to schedule coaching appointment
    /// </summary>
    /// <value>Periods of availability for facilitators to schedule coaching appointment</value>
    [DataMember(Name = "facilitatorSchedules", EmitDefaultValue = false)]
    public List<UserAvailableTimes> FacilitatorSchedules { get; private set; }



    /// <summary>
    /// Detailed data for WFM scheduled activities
    /// </summary>
    /// <value>Detailed data for WFM scheduled activities</value>
    [DataMember(Name = "wfmScheduleActivities", EmitDefaultValue = false)]
    public List<WfmScheduleActivity> WfmScheduleActivities { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CoachingSlotsResponse {\n");

        sb.Append("  SuggestedSlots: ").Append(SuggestedSlots).Append("\n");
        sb.Append("  AttendeeSchedules: ").Append(AttendeeSchedules).Append("\n");
        sb.Append("  FacilitatorSchedules: ").Append(FacilitatorSchedules).Append("\n");
        sb.Append("  WfmScheduleActivities: ").Append(WfmScheduleActivities).Append("\n");
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
        return Equals(obj as CoachingSlotsResponse);
    }

    /// <summary>
    /// Returns true if CoachingSlotsResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of CoachingSlotsResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CoachingSlotsResponse other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                SuggestedSlots == other.SuggestedSlots ||
                SuggestedSlots != null &&
                SuggestedSlots.SequenceEqual(other.SuggestedSlots)
            ) &&
            (
                AttendeeSchedules == other.AttendeeSchedules ||
                AttendeeSchedules != null &&
                AttendeeSchedules.SequenceEqual(other.AttendeeSchedules)
            ) &&
            (
                FacilitatorSchedules == other.FacilitatorSchedules ||
                FacilitatorSchedules != null &&
                FacilitatorSchedules.SequenceEqual(other.FacilitatorSchedules)
            ) &&
            (
                WfmScheduleActivities == other.WfmScheduleActivities ||
                WfmScheduleActivities != null &&
                WfmScheduleActivities.SequenceEqual(other.WfmScheduleActivities)
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
            if (SuggestedSlots != null)
            {
                hash = hash * 59 + SuggestedSlots.GetHashCode();
            }

            if (AttendeeSchedules != null)
            {
                hash = hash * 59 + AttendeeSchedules.GetHashCode();
            }

            if (FacilitatorSchedules != null)
            {
                hash = hash * 59 + FacilitatorSchedules.GetHashCode();
            }

            if (WfmScheduleActivities != null)
            {
                hash = hash * 59 + WfmScheduleActivities.GetHashCode();
            }

            return hash;
        }
    }
}
