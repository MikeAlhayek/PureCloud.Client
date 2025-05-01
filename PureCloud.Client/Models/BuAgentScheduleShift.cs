using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// BuAgentScheduleShift
/// </summary>
[DataContract]
public partial class BuAgentScheduleShift : IEquatable<BuAgentScheduleShift>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BuAgentScheduleShift" /> class.
    /// </summary>
    /// <param name="Id">The ID of the shift.</param>
    /// <param name="Activities">The activities associated with this shift.</param>
    /// <param name="ManuallyEdited">Whether this shift was manually edited. This is only set by clients and is used for rescheduling.</param>
    public BuAgentScheduleShift(string Id = null, List<BuAgentScheduleActivity> Activities = null, bool? ManuallyEdited = null)
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
        sb.Append("class BuAgentScheduleShift {\n");

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
        return Equals(obj as BuAgentScheduleShift);
    }

    /// <summary>
    /// Returns true if BuAgentScheduleShift instances are equal
    /// </summary>
    /// <param name="other">Instance of BuAgentScheduleShift to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(BuAgentScheduleShift other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Id == other.Id ||
                Id != null &&
                Id.Equals(other.Id)
            ) &&
            (
                StartDate == other.StartDate ||
                StartDate != null &&
                StartDate.Equals(other.StartDate)
            ) &&
            (
                LengthMinutes == other.LengthMinutes ||
                LengthMinutes != null &&
                LengthMinutes.Equals(other.LengthMinutes)
            ) &&
            (
                Activities == other.Activities ||
                Activities != null &&
                Activities.SequenceEqual(other.Activities)
            ) &&
            (
                ManuallyEdited == other.ManuallyEdited ||
                ManuallyEdited != null &&
                ManuallyEdited.Equals(other.ManuallyEdited)
            ) &&
            (
                Schedule == other.Schedule ||
                Schedule != null &&
                Schedule.Equals(other.Schedule)
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
            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            if (StartDate != null)
            {
                hash = hash * 59 + StartDate.GetHashCode();
            }

            if (LengthMinutes != null)
            {
                hash = hash * 59 + LengthMinutes.GetHashCode();
            }

            if (Activities != null)
            {
                hash = hash * 59 + Activities.GetHashCode();
            }

            if (ManuallyEdited != null)
            {
                hash = hash * 59 + ManuallyEdited.GetHashCode();
            }

            if (Schedule != null)
            {
                hash = hash * 59 + Schedule.GetHashCode();
            }

            return hash;
        }
    }
}
