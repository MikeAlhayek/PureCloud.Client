using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// CreateWorkPlanActivity
/// </summary>
[DataContract]
public partial class CreateWorkPlanActivity : IEquatable<CreateWorkPlanActivity>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CreateWorkPlanActivity" /> class.
    /// </summary>
    /// <param name="ActivityCodeId">ID of the activity code associated with this activity.</param>
    /// <param name="Description">Description of the activity.</param>
    /// <param name="LengthMinutes">Length of the activity in minutes.</param>
    /// <param name="StartTimeIsRelativeToShiftStart">Whether the start time of the activity is relative to the start time of the shift it belongs to.</param>
    /// <param name="FlexibleStartTime">Whether the start time of the activity is flexible.</param>
    /// <param name="EarliestStartTimeMinutes">Earliest activity start in offset minutes relative to shift start time if startTimeIsRelativeToShiftStart &#x3D;&#x3D; true else its based on midnight. Used if flexibleStartTime &#x3D;&#x3D; true.</param>
    /// <param name="LatestStartTimeMinutes">Latest activity start in offset minutes relative to shift start time if startTimeIsRelativeToShiftStart &#x3D;&#x3D; true else its based on midnight. Used if flexibleStartTime &#x3D;&#x3D; true.</param>
    /// <param name="ExactStartTimeMinutes">Exact activity start in offset minutes relative to shift start time if startTimeIsRelativeToShiftStart &#x3D;&#x3D; true else its based on midnight. Used if flexibleStartTime &#x3D;&#x3D; false.</param>
    /// <param name="StartTimeIncrementMinutes">Increment in offset minutes that would contribute to different possible start times for the activity.</param>
    /// <param name="CountsAsPaidTime">Whether the activity is paid.</param>
    /// <param name="CountsAsContiguousWorkTime">Whether the activity duration is counted towards contiguous work time.</param>
    /// <param name="MinimumLengthFromShiftStartMinutes">The minimum duration between shift start and shift item (e.g., break or meal) start in minutes.</param>
    /// <param name="MinimumLengthFromShiftEndMinutes">The minimum duration between shift item (e.g., break or meal) end and shift end in minutes.</param>
    public CreateWorkPlanActivity(string ActivityCodeId = null, string Description = null, int? LengthMinutes = null, bool? StartTimeIsRelativeToShiftStart = null, bool? FlexibleStartTime = null, int? EarliestStartTimeMinutes = null, int? LatestStartTimeMinutes = null, int? ExactStartTimeMinutes = null, int? StartTimeIncrementMinutes = null, bool? CountsAsPaidTime = null, bool? CountsAsContiguousWorkTime = null, int? MinimumLengthFromShiftStartMinutes = null, int? MinimumLengthFromShiftEndMinutes = null)
    {
        this.ActivityCodeId = ActivityCodeId;
        this.Description = Description;
        this.LengthMinutes = LengthMinutes;
        this.StartTimeIsRelativeToShiftStart = StartTimeIsRelativeToShiftStart;
        this.FlexibleStartTime = FlexibleStartTime;
        this.EarliestStartTimeMinutes = EarliestStartTimeMinutes;
        this.LatestStartTimeMinutes = LatestStartTimeMinutes;
        this.ExactStartTimeMinutes = ExactStartTimeMinutes;
        this.StartTimeIncrementMinutes = StartTimeIncrementMinutes;
        this.CountsAsPaidTime = CountsAsPaidTime;
        this.CountsAsContiguousWorkTime = CountsAsContiguousWorkTime;
        this.MinimumLengthFromShiftStartMinutes = MinimumLengthFromShiftStartMinutes;
        this.MinimumLengthFromShiftEndMinutes = MinimumLengthFromShiftEndMinutes;

    }



    /// <summary>
    /// ID of the activity code associated with this activity
    /// </summary>
    /// <value>ID of the activity code associated with this activity</value>
    [DataMember(Name = "activityCodeId", EmitDefaultValue = false)]
    public string ActivityCodeId { get; set; }



    /// <summary>
    /// Description of the activity
    /// </summary>
    /// <value>Description of the activity</value>
    [DataMember(Name = "description", EmitDefaultValue = false)]
    public string Description { get; set; }



    /// <summary>
    /// Length of the activity in minutes
    /// </summary>
    /// <value>Length of the activity in minutes</value>
    [DataMember(Name = "lengthMinutes", EmitDefaultValue = false)]
    public int? LengthMinutes { get; set; }



    /// <summary>
    /// Whether the start time of the activity is relative to the start time of the shift it belongs to
    /// </summary>
    /// <value>Whether the start time of the activity is relative to the start time of the shift it belongs to</value>
    [DataMember(Name = "startTimeIsRelativeToShiftStart", EmitDefaultValue = false)]
    public bool? StartTimeIsRelativeToShiftStart { get; set; }



    /// <summary>
    /// Whether the start time of the activity is flexible
    /// </summary>
    /// <value>Whether the start time of the activity is flexible</value>
    [DataMember(Name = "flexibleStartTime", EmitDefaultValue = false)]
    public bool? FlexibleStartTime { get; set; }



    /// <summary>
    /// Earliest activity start in offset minutes relative to shift start time if startTimeIsRelativeToShiftStart &#x3D;&#x3D; true else its based on midnight. Used if flexibleStartTime &#x3D;&#x3D; true
    /// </summary>
    /// <value>Earliest activity start in offset minutes relative to shift start time if startTimeIsRelativeToShiftStart &#x3D;&#x3D; true else its based on midnight. Used if flexibleStartTime &#x3D;&#x3D; true</value>
    [DataMember(Name = "earliestStartTimeMinutes", EmitDefaultValue = false)]
    public int? EarliestStartTimeMinutes { get; set; }



    /// <summary>
    /// Latest activity start in offset minutes relative to shift start time if startTimeIsRelativeToShiftStart &#x3D;&#x3D; true else its based on midnight. Used if flexibleStartTime &#x3D;&#x3D; true
    /// </summary>
    /// <value>Latest activity start in offset minutes relative to shift start time if startTimeIsRelativeToShiftStart &#x3D;&#x3D; true else its based on midnight. Used if flexibleStartTime &#x3D;&#x3D; true</value>
    [DataMember(Name = "latestStartTimeMinutes", EmitDefaultValue = false)]
    public int? LatestStartTimeMinutes { get; set; }



    /// <summary>
    /// Exact activity start in offset minutes relative to shift start time if startTimeIsRelativeToShiftStart &#x3D;&#x3D; true else its based on midnight. Used if flexibleStartTime &#x3D;&#x3D; false
    /// </summary>
    /// <value>Exact activity start in offset minutes relative to shift start time if startTimeIsRelativeToShiftStart &#x3D;&#x3D; true else its based on midnight. Used if flexibleStartTime &#x3D;&#x3D; false</value>
    [DataMember(Name = "exactStartTimeMinutes", EmitDefaultValue = false)]
    public int? ExactStartTimeMinutes { get; set; }



    /// <summary>
    /// Increment in offset minutes that would contribute to different possible start times for the activity
    /// </summary>
    /// <value>Increment in offset minutes that would contribute to different possible start times for the activity</value>
    [DataMember(Name = "startTimeIncrementMinutes", EmitDefaultValue = false)]
    public int? StartTimeIncrementMinutes { get; set; }



    /// <summary>
    /// Whether the activity is paid
    /// </summary>
    /// <value>Whether the activity is paid</value>
    [DataMember(Name = "countsAsPaidTime", EmitDefaultValue = false)]
    public bool? CountsAsPaidTime { get; set; }



    /// <summary>
    /// Whether the activity duration is counted towards contiguous work time
    /// </summary>
    /// <value>Whether the activity duration is counted towards contiguous work time</value>
    [DataMember(Name = "countsAsContiguousWorkTime", EmitDefaultValue = false)]
    public bool? CountsAsContiguousWorkTime { get; set; }



    /// <summary>
    /// The minimum duration between shift start and shift item (e.g., break or meal) start in minutes
    /// </summary>
    /// <value>The minimum duration between shift start and shift item (e.g., break or meal) start in minutes</value>
    [DataMember(Name = "minimumLengthFromShiftStartMinutes", EmitDefaultValue = false)]
    public int? MinimumLengthFromShiftStartMinutes { get; set; }



    /// <summary>
    /// The minimum duration between shift item (e.g., break or meal) end and shift end in minutes
    /// </summary>
    /// <value>The minimum duration between shift item (e.g., break or meal) end and shift end in minutes</value>
    [DataMember(Name = "minimumLengthFromShiftEndMinutes", EmitDefaultValue = false)]
    public int? MinimumLengthFromShiftEndMinutes { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CreateWorkPlanActivity {\n");

        sb.Append("  ActivityCodeId: ").Append(ActivityCodeId).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  LengthMinutes: ").Append(LengthMinutes).Append("\n");
        sb.Append("  StartTimeIsRelativeToShiftStart: ").Append(StartTimeIsRelativeToShiftStart).Append("\n");
        sb.Append("  FlexibleStartTime: ").Append(FlexibleStartTime).Append("\n");
        sb.Append("  EarliestStartTimeMinutes: ").Append(EarliestStartTimeMinutes).Append("\n");
        sb.Append("  LatestStartTimeMinutes: ").Append(LatestStartTimeMinutes).Append("\n");
        sb.Append("  ExactStartTimeMinutes: ").Append(ExactStartTimeMinutes).Append("\n");
        sb.Append("  StartTimeIncrementMinutes: ").Append(StartTimeIncrementMinutes).Append("\n");
        sb.Append("  CountsAsPaidTime: ").Append(CountsAsPaidTime).Append("\n");
        sb.Append("  CountsAsContiguousWorkTime: ").Append(CountsAsContiguousWorkTime).Append("\n");
        sb.Append("  MinimumLengthFromShiftStartMinutes: ").Append(MinimumLengthFromShiftStartMinutes).Append("\n");
        sb.Append("  MinimumLengthFromShiftEndMinutes: ").Append(MinimumLengthFromShiftEndMinutes).Append("\n");
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
        return Equals(obj as CreateWorkPlanActivity);
    }

    /// <summary>
    /// Returns true if CreateWorkPlanActivity instances are equal
    /// </summary>
    /// <param name="other">Instance of CreateWorkPlanActivity to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CreateWorkPlanActivity other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                ActivityCodeId == other.ActivityCodeId ||
                ActivityCodeId != null &&
                ActivityCodeId.Equals(other.ActivityCodeId)
            ) &&
            (
                Description == other.Description ||
                Description != null &&
                Description.Equals(other.Description)
            ) &&
            (
                LengthMinutes == other.LengthMinutes ||
                LengthMinutes != null &&
                LengthMinutes.Equals(other.LengthMinutes)
            ) &&
            (
                StartTimeIsRelativeToShiftStart == other.StartTimeIsRelativeToShiftStart ||
                StartTimeIsRelativeToShiftStart != null &&
                StartTimeIsRelativeToShiftStart.Equals(other.StartTimeIsRelativeToShiftStart)
            ) &&
            (
                FlexibleStartTime == other.FlexibleStartTime ||
                FlexibleStartTime != null &&
                FlexibleStartTime.Equals(other.FlexibleStartTime)
            ) &&
            (
                EarliestStartTimeMinutes == other.EarliestStartTimeMinutes ||
                EarliestStartTimeMinutes != null &&
                EarliestStartTimeMinutes.Equals(other.EarliestStartTimeMinutes)
            ) &&
            (
                LatestStartTimeMinutes == other.LatestStartTimeMinutes ||
                LatestStartTimeMinutes != null &&
                LatestStartTimeMinutes.Equals(other.LatestStartTimeMinutes)
            ) &&
            (
                ExactStartTimeMinutes == other.ExactStartTimeMinutes ||
                ExactStartTimeMinutes != null &&
                ExactStartTimeMinutes.Equals(other.ExactStartTimeMinutes)
            ) &&
            (
                StartTimeIncrementMinutes == other.StartTimeIncrementMinutes ||
                StartTimeIncrementMinutes != null &&
                StartTimeIncrementMinutes.Equals(other.StartTimeIncrementMinutes)
            ) &&
            (
                CountsAsPaidTime == other.CountsAsPaidTime ||
                CountsAsPaidTime != null &&
                CountsAsPaidTime.Equals(other.CountsAsPaidTime)
            ) &&
            (
                CountsAsContiguousWorkTime == other.CountsAsContiguousWorkTime ||
                CountsAsContiguousWorkTime != null &&
                CountsAsContiguousWorkTime.Equals(other.CountsAsContiguousWorkTime)
            ) &&
            (
                MinimumLengthFromShiftStartMinutes == other.MinimumLengthFromShiftStartMinutes ||
                MinimumLengthFromShiftStartMinutes != null &&
                MinimumLengthFromShiftStartMinutes.Equals(other.MinimumLengthFromShiftStartMinutes)
            ) &&
            (
                MinimumLengthFromShiftEndMinutes == other.MinimumLengthFromShiftEndMinutes ||
                MinimumLengthFromShiftEndMinutes != null &&
                MinimumLengthFromShiftEndMinutes.Equals(other.MinimumLengthFromShiftEndMinutes)
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
            if (ActivityCodeId != null)
            {
                hash = hash * 59 + ActivityCodeId.GetHashCode();
            }

            if (Description != null)
            {
                hash = hash * 59 + Description.GetHashCode();
            }

            if (LengthMinutes != null)
            {
                hash = hash * 59 + LengthMinutes.GetHashCode();
            }

            if (StartTimeIsRelativeToShiftStart != null)
            {
                hash = hash * 59 + StartTimeIsRelativeToShiftStart.GetHashCode();
            }

            if (FlexibleStartTime != null)
            {
                hash = hash * 59 + FlexibleStartTime.GetHashCode();
            }

            if (EarliestStartTimeMinutes != null)
            {
                hash = hash * 59 + EarliestStartTimeMinutes.GetHashCode();
            }

            if (LatestStartTimeMinutes != null)
            {
                hash = hash * 59 + LatestStartTimeMinutes.GetHashCode();
            }

            if (ExactStartTimeMinutes != null)
            {
                hash = hash * 59 + ExactStartTimeMinutes.GetHashCode();
            }

            if (StartTimeIncrementMinutes != null)
            {
                hash = hash * 59 + StartTimeIncrementMinutes.GetHashCode();
            }

            if (CountsAsPaidTime != null)
            {
                hash = hash * 59 + CountsAsPaidTime.GetHashCode();
            }

            if (CountsAsContiguousWorkTime != null)
            {
                hash = hash * 59 + CountsAsContiguousWorkTime.GetHashCode();
            }

            if (MinimumLengthFromShiftStartMinutes != null)
            {
                hash = hash * 59 + MinimumLengthFromShiftStartMinutes.GetHashCode();
            }

            if (MinimumLengthFromShiftEndMinutes != null)
            {
                hash = hash * 59 + MinimumLengthFromShiftEndMinutes.GetHashCode();
            }

            return hash;
        }
    }
}
