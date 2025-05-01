using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// BuAgentScheduleShiftRequest
/// </summary>
[DataContract]
public partial class BuAgentScheduleShiftRequest : IEquatable<BuAgentScheduleShiftRequest>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BuAgentScheduleShiftRequest" /> class.
    /// </summary>
    /// <param name="Id">The ID of the shift.</param>
    /// <param name="Activities">The activities associated with this shift.</param>
    /// <param name="ManuallyEdited">Whether this shift was manually edited. This is only set by clients and is used for rescheduling.</param>
    public BuAgentScheduleShiftRequest(string Id = null, List<BuAgentScheduleActivity> Activities = null, bool? ManuallyEdited = null)
    {
        this.Id = Id;
        this.Activities = Activities;
        this.ManuallyEdited = ManuallyEdited;

    }



    /// <summary>
    /// The ID of the shift
    /// </summary>
    /// <value>The ID of the shift</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }



    /// <summary>
    /// The start date of this shift. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The start date of this shift. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "startDate", EmitDefaultValue = false)]
    public DateTime? StartDate { get; private set; }



    /// <summary>
    /// The length of this shift in minutes
    /// </summary>
    /// <value>The length of this shift in minutes</value>
    [DataMember(Name = "lengthMinutes", EmitDefaultValue = false)]
    public int? LengthMinutes { get; private set; }



    /// <summary>
    /// The activities associated with this shift
    /// </summary>
    /// <value>The activities associated with this shift</value>
    [DataMember(Name = "activities", EmitDefaultValue = false)]
    public List<BuAgentScheduleActivity> Activities { get; set; }



    /// <summary>
    /// Whether this shift was manually edited. This is only set by clients and is used for rescheduling
    /// </summary>
    /// <value>Whether this shift was manually edited. This is only set by clients and is used for rescheduling</value>
    [DataMember(Name = "manuallyEdited", EmitDefaultValue = false)]
    public bool? ManuallyEdited { get; set; }



    /// <summary>
    /// The schedule to which this shift belongs
    /// </summary>
    /// <value>The schedule to which this shift belongs</value>
    [DataMember(Name = "schedule", EmitDefaultValue = false)]
    public BuScheduleReference Schedule { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class BuAgentScheduleShiftRequest {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  StartDate: ").Append(StartDate).Append("\n");
        sb.Append("  LengthMinutes: ").Append(LengthMinutes).Append("\n");
        sb.Append("  Activities: ").Append(Activities).Append("\n");
        sb.Append("  ManuallyEdited: ").Append(ManuallyEdited).Append("\n");
        sb.Append("  Schedule: ").Append(Schedule).Append("\n");
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
        return this.Equals(obj as BuAgentScheduleShiftRequest);
    }

    /// <summary>
    /// Returns true if BuAgentScheduleShiftRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of BuAgentScheduleShiftRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(BuAgentScheduleShiftRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                this.Id == other.Id ||
                this.Id != null &&
                this.Id.Equals(other.Id)
            ) &&
            (
                this.StartDate == other.StartDate ||
                this.StartDate != null &&
                this.StartDate.Equals(other.StartDate)
            ) &&
            (
                this.LengthMinutes == other.LengthMinutes ||
                this.LengthMinutes != null &&
                this.LengthMinutes.Equals(other.LengthMinutes)
            ) &&
            (
                this.Activities == other.Activities ||
                this.Activities != null &&
                this.Activities.SequenceEqual(other.Activities)
            ) &&
            (
                this.ManuallyEdited == other.ManuallyEdited ||
                this.ManuallyEdited != null &&
                this.ManuallyEdited.Equals(other.ManuallyEdited)
            ) &&
            (
                this.Schedule == other.Schedule ||
                this.Schedule != null &&
                this.Schedule.Equals(other.Schedule)
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
            if (this.Id != null)
            {
                hash = hash * 59 + this.Id.GetHashCode();
            }

            if (this.StartDate != null)
            {
                hash = hash * 59 + this.StartDate.GetHashCode();
            }

            if (this.LengthMinutes != null)
            {
                hash = hash * 59 + this.LengthMinutes.GetHashCode();
            }

            if (this.Activities != null)
            {
                hash = hash * 59 + this.Activities.GetHashCode();
            }

            if (this.ManuallyEdited != null)
            {
                hash = hash * 59 + this.ManuallyEdited.GetHashCode();
            }

            if (this.Schedule != null)
            {
                hash = hash * 59 + this.Schedule.GetHashCode();
            }

            return hash;
        }
    }
}
