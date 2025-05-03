using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// CoachingSlotsRequest
/// </summary>

public partial class CoachingSlotsRequest : IEquatable<CoachingSlotsRequest>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="CoachingSlotsRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected CoachingSlotsRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="CoachingSlotsRequest" /> class.
    /// </summary>
    /// <param name="Interval">Range of time to get slots for scheduling coaching appointments. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (required).</param>
    /// <param name="LengthInMinutes">The duration of coaching appointment to schedule in 15 minutes granularity up to maximum of 60 minutes (required).</param>
    /// <param name="AttendeeIds">List of attendees to determine coaching appointment slots (required).</param>
    /// <param name="FacilitatorIds">List of facilitators to determine coaching appointment slots.</param>
    /// <param name="InterruptibleAppointmentIds">List of appointment ids to exclude from consideration when determining blocked slots.</param>
    public CoachingSlotsRequest(string Interval = null, int? LengthInMinutes = null, List<string> AttendeeIds = null, List<string> FacilitatorIds = null, List<string> InterruptibleAppointmentIds = null)
    {
        this.Interval = Interval;
        this.LengthInMinutes = LengthInMinutes;
        this.AttendeeIds = AttendeeIds;
        this.FacilitatorIds = FacilitatorIds;
        this.InterruptibleAppointmentIds = InterruptibleAppointmentIds;

    }



    /// <summary>
    /// Range of time to get slots for scheduling coaching appointments. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss
    /// </summary>
    /// <value>Range of time to get slots for scheduling coaching appointments. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss</value>
    [JsonPropertyName("interval")]
    public string Interval { get; set; }



    /// <summary>
    /// The duration of coaching appointment to schedule in 15 minutes granularity up to maximum of 60 minutes
    /// </summary>
    /// <value>The duration of coaching appointment to schedule in 15 minutes granularity up to maximum of 60 minutes</value>
    [JsonPropertyName("lengthInMinutes")]
    public int? LengthInMinutes { get; set; }



    /// <summary>
    /// List of attendees to determine coaching appointment slots
    /// </summary>
    /// <value>List of attendees to determine coaching appointment slots</value>
    [JsonPropertyName("attendeeIds")]
    public List<string> AttendeeIds { get; set; }



    /// <summary>
    /// List of facilitators to determine coaching appointment slots
    /// </summary>
    /// <value>List of facilitators to determine coaching appointment slots</value>
    [JsonPropertyName("facilitatorIds")]
    public List<string> FacilitatorIds { get; set; }



    /// <summary>
    /// List of appointment ids to exclude from consideration when determining blocked slots
    /// </summary>
    /// <value>List of appointment ids to exclude from consideration when determining blocked slots</value>
    [JsonPropertyName("interruptibleAppointmentIds")]
    public List<string> InterruptibleAppointmentIds { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CoachingSlotsRequest {\n");

        sb.Append("  Interval: ").Append(Interval).Append("\n");
        sb.Append("  LengthInMinutes: ").Append(LengthInMinutes).Append("\n");
        sb.Append("  AttendeeIds: ").Append(AttendeeIds).Append("\n");
        sb.Append("  FacilitatorIds: ").Append(FacilitatorIds).Append("\n");
        sb.Append("  InterruptibleAppointmentIds: ").Append(InterruptibleAppointmentIds).Append("\n");
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
        return Equals(obj as CoachingSlotsRequest);
    }

    /// <summary>
    /// Returns true if CoachingSlotsRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of CoachingSlotsRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CoachingSlotsRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Interval == other.Interval ||
                Interval != null &&
                Interval.Equals(other.Interval)
            ) &&
            (
                LengthInMinutes == other.LengthInMinutes ||
                LengthInMinutes != null &&
                LengthInMinutes.Equals(other.LengthInMinutes)
            ) &&
            (
                AttendeeIds == other.AttendeeIds ||
                AttendeeIds != null &&
                AttendeeIds.SequenceEqual(other.AttendeeIds)
            ) &&
            (
                FacilitatorIds == other.FacilitatorIds ||
                FacilitatorIds != null &&
                FacilitatorIds.SequenceEqual(other.FacilitatorIds)
            ) &&
            (
                InterruptibleAppointmentIds == other.InterruptibleAppointmentIds ||
                InterruptibleAppointmentIds != null &&
                InterruptibleAppointmentIds.SequenceEqual(other.InterruptibleAppointmentIds)
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
            if (Interval != null)
            {
                hash = hash * 59 + Interval.GetHashCode();
            }

            if (LengthInMinutes != null)
            {
                hash = hash * 59 + LengthInMinutes.GetHashCode();
            }

            if (AttendeeIds != null)
            {
                hash = hash * 59 + AttendeeIds.GetHashCode();
            }

            if (FacilitatorIds != null)
            {
                hash = hash * 59 + FacilitatorIds.GetHashCode();
            }

            if (InterruptibleAppointmentIds != null)
            {
                hash = hash * 59 + InterruptibleAppointmentIds.GetHashCode();
            }

            return hash;
        }
    }
}
