using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// UserScheduleShift
/// </summary>

public partial class UserScheduleShift : IEquatable<UserScheduleShift>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="UserScheduleShift" /> class.
    /// </summary>
    /// <param name="Id">ID of the schedule shift. This is only for the case of updating and deleting an existing shift.</param>
    /// <param name="Activities">List of activities in this shift.</param>
    /// <param name="Delete">If marked true for updating this schedule shift, it will be deleted.</param>
    /// <param name="ManuallyEdited">Whether the shift was set as manually edited.</param>
    public UserScheduleShift(string Id = null, List<UserScheduleActivity> Activities = null, bool? Delete = null, bool? ManuallyEdited = null)
    {
        this.Id = Id;
        this.Activities = Activities;
        this.Delete = Delete;
        this.ManuallyEdited = ManuallyEdited;

    }



    /// <summary>
    /// The schedule to which this shift belongs
    /// </summary>
    /// <value>The schedule to which this shift belongs</value>
    [JsonPropertyName("weekSchedule")]
    public WeekScheduleReference WeekSchedule { get; set; }



    /// <summary>
    /// ID of the schedule shift. This is only for the case of updating and deleting an existing shift
    /// </summary>
    /// <value>ID of the schedule shift. This is only for the case of updating and deleting an existing shift</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// Start time in UTC for this shift. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Start time in UTC for this shift. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("startDate")]
    public DateTime? StartDate { get; set; }



    /// <summary>
    /// Length of this shift in minutes
    /// </summary>
    /// <value>Length of this shift in minutes</value>
    [JsonPropertyName("lengthInMinutes")]
    public int? LengthInMinutes { get; set; }



    /// <summary>
    /// List of activities in this shift
    /// </summary>
    /// <value>List of activities in this shift</value>
    [JsonPropertyName("activities")]
    public List<UserScheduleActivity> Activities { get; set; }



    /// <summary>
    /// If marked true for updating this schedule shift, it will be deleted
    /// </summary>
    /// <value>If marked true for updating this schedule shift, it will be deleted</value>
    [JsonPropertyName("delete")]
    public bool? Delete { get; set; }



    /// <summary>
    /// Whether the shift was set as manually edited
    /// </summary>
    /// <value>Whether the shift was set as manually edited</value>
    [JsonPropertyName("manuallyEdited")]
    public bool? ManuallyEdited { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class UserScheduleShift {\n");

        sb.Append("  WeekSchedule: ").Append(WeekSchedule).Append("\n");
        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  StartDate: ").Append(StartDate).Append("\n");
        sb.Append("  LengthInMinutes: ").Append(LengthInMinutes).Append("\n");
        sb.Append("  Activities: ").Append(Activities).Append("\n");
        sb.Append("  Delete: ").Append(Delete).Append("\n");
        sb.Append("  ManuallyEdited: ").Append(ManuallyEdited).Append("\n");
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
        return Equals(obj as UserScheduleShift);
    }

    /// <summary>
    /// Returns true if UserScheduleShift instances are equal
    /// </summary>
    /// <param name="other">Instance of UserScheduleShift to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(UserScheduleShift other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                WeekSchedule == other.WeekSchedule ||
                WeekSchedule != null &&
                WeekSchedule.Equals(other.WeekSchedule)
            ) &&
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
                LengthInMinutes == other.LengthInMinutes ||
                LengthInMinutes != null &&
                LengthInMinutes.Equals(other.LengthInMinutes)
            ) &&
            (
                Activities == other.Activities ||
                Activities != null &&
                Activities.SequenceEqual(other.Activities)
            ) &&
            (
                Delete == other.Delete ||
                Delete != null &&
                Delete.Equals(other.Delete)
            ) &&
            (
                ManuallyEdited == other.ManuallyEdited ||
                ManuallyEdited != null &&
                ManuallyEdited.Equals(other.ManuallyEdited)
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
            if (WeekSchedule != null)
            {
                hash = hash * 59 + WeekSchedule.GetHashCode();
            }

            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            if (StartDate != null)
            {
                hash = hash * 59 + StartDate.GetHashCode();
            }

            if (LengthInMinutes != null)
            {
                hash = hash * 59 + LengthInMinutes.GetHashCode();
            }

            if (Activities != null)
            {
                hash = hash * 59 + Activities.GetHashCode();
            }

            if (Delete != null)
            {
                hash = hash * 59 + Delete.GetHashCode();
            }

            if (ManuallyEdited != null)
            {
                hash = hash * 59 + ManuallyEdited.GetHashCode();
            }

            return hash;
        }
    }
}
