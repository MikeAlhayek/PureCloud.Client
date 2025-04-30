using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloudPlatform.Client.V2.Model;

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
        return this.Equals(obj as CoachingSlotsResponse);
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
                this.SuggestedSlots == other.SuggestedSlots ||
                this.SuggestedSlots != null &&
                this.SuggestedSlots.SequenceEqual(other.SuggestedSlots)
            ) &&
            (
                this.AttendeeSchedules == other.AttendeeSchedules ||
                this.AttendeeSchedules != null &&
                this.AttendeeSchedules.SequenceEqual(other.AttendeeSchedules)
            ) &&
            (
                this.FacilitatorSchedules == other.FacilitatorSchedules ||
                this.FacilitatorSchedules != null &&
                this.FacilitatorSchedules.SequenceEqual(other.FacilitatorSchedules)
            ) &&
            (
                this.WfmScheduleActivities == other.WfmScheduleActivities ||
                this.WfmScheduleActivities != null &&
                this.WfmScheduleActivities.SequenceEqual(other.WfmScheduleActivities)
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
            if (this.SuggestedSlots != null)
            {
                hash = hash * 59 + this.SuggestedSlots.GetHashCode();
            }

            if (this.AttendeeSchedules != null)
            {
                hash = hash * 59 + this.AttendeeSchedules.GetHashCode();
            }

            if (this.FacilitatorSchedules != null)
            {
                hash = hash * 59 + this.FacilitatorSchedules.GetHashCode();
            }

            if (this.WfmScheduleActivities != null)
            {
                hash = hash * 59 + this.WfmScheduleActivities.GetHashCode();
            }

            return hash;
        }
    }
}
