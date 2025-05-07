using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// BuUpdateAgentScheduleShift
/// </summary>

public partial class BuUpdateAgentScheduleShift : IEquatable<BuUpdateAgentScheduleShift>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BuUpdateAgentScheduleShift" /> class.
    /// </summary>
    /// <param name="Id">The ID of the shift.</param>
    /// <param name="Activities">The activities associated with this shift.</param>
    /// <param name="ManuallyEdited">Whether this shift was manually edited. This is only set by clients and is used for rescheduling.</param>
    /// <param name="Delete">Set to true to delete the shift from the agent&#39;s schedule.</param>
    public BuUpdateAgentScheduleShift(string Id = null, List<BuAgentScheduleActivity> Activities = null, bool? ManuallyEdited = null, bool? Delete = null)
    {
        this.Id = Id;
        this.Activities = Activities;
        this.ManuallyEdited = ManuallyEdited;
        this.Delete = Delete;

    }



    /// <summary>
    /// The ID of the shift
    /// </summary>
    /// <value>The ID of the shift</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// The start date of this shift. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The start date of this shift. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("startDate")]
    public DateTime? StartDate { get; set; }



    /// <summary>
    /// The length of this shift in minutes
    /// </summary>
    /// <value>The length of this shift in minutes</value>
    [JsonPropertyName("lengthMinutes")]
    public int? LengthMinutes { get; set; }



    /// <summary>
    /// The activities associated with this shift
    /// </summary>
    /// <value>The activities associated with this shift</value>
    [JsonPropertyName("activities")]
    public List<BuAgentScheduleActivity> Activities { get; set; }



    /// <summary>
    /// Whether this shift was manually edited. This is only set by clients and is used for rescheduling
    /// </summary>
    /// <value>Whether this shift was manually edited. This is only set by clients and is used for rescheduling</value>
    [JsonPropertyName("manuallyEdited")]
    public bool? ManuallyEdited { get; set; }



    /// <summary>
    /// The schedule to which this shift belongs
    /// </summary>
    /// <value>The schedule to which this shift belongs</value>
    [JsonPropertyName("schedule")]
    public BuScheduleReference Schedule { get; set; }



    /// <summary>
    /// Set to true to delete the shift from the agent&#39;s schedule
    /// </summary>
    /// <value>Set to true to delete the shift from the agent&#39;s schedule</value>
    [JsonPropertyName("delete")]
    public bool? Delete { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class BuUpdateAgentScheduleShift {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  StartDate: ").Append(StartDate).Append("\n");
        sb.Append("  LengthMinutes: ").Append(LengthMinutes).Append("\n");
        sb.Append("  Activities: ").Append(Activities).Append("\n");
        sb.Append("  ManuallyEdited: ").Append(ManuallyEdited).Append("\n");
        sb.Append("  Schedule: ").Append(Schedule).Append("\n");
        sb.Append("  Delete: ").Append(Delete).Append("\n");
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
        return Equals(obj as BuUpdateAgentScheduleShift);
    }

    /// <summary>
    /// Returns true if BuUpdateAgentScheduleShift instances are equal
    /// </summary>
    /// <param name="other">Instance of BuUpdateAgentScheduleShift to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(BuUpdateAgentScheduleShift other)
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
            ) &&
            (
                Delete == other.Delete ||
                Delete != null &&
                Delete.Equals(other.Delete)
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

            if (Delete != null)
            {
                hash = hash * 59 + Delete.GetHashCode();
            }

            return hash;
        }
    }
}
