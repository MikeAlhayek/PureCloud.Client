using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// UserScheduleActivity
/// </summary>

public partial class UserScheduleActivity : IEquatable<UserScheduleActivity>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="UserScheduleActivity" /> class.
    /// </summary>
    /// <param name="ActivityCodeId">The id for the activity code.  Look up a map of activity codes with the activities route.</param>
    /// <param name="StartDate">Start time in UTC for this activity, in ISO-8601 format.</param>
    /// <param name="LengthInMinutes">Length in minutes for this activity.</param>
    /// <param name="Description">Description for this activity.</param>
    /// <param name="CountsAsPaidTime">Whether this activity is paid.</param>
    /// <param name="IsDstFallback">Whether this activity spans a DST fallback.</param>
    /// <param name="TimeOffRequestId">Time off request id of this activity.</param>
    public UserScheduleActivity(string ActivityCodeId = null, DateTime? StartDate = null, int? LengthInMinutes = null, string Description = null, bool? CountsAsPaidTime = null, bool? IsDstFallback = null, string TimeOffRequestId = null)
    {
        this.ActivityCodeId = ActivityCodeId;
        this.StartDate = StartDate;
        this.LengthInMinutes = LengthInMinutes;
        this.Description = Description;
        this.CountsAsPaidTime = CountsAsPaidTime;
        this.IsDstFallback = IsDstFallback;
        this.TimeOffRequestId = TimeOffRequestId;

    }



    /// <summary>
    /// The id for the activity code.  Look up a map of activity codes with the activities route
    /// </summary>
    /// <value>The id for the activity code.  Look up a map of activity codes with the activities route</value>
    [JsonPropertyName("activityCodeId")]
    public string ActivityCodeId { get; set; }



    /// <summary>
    /// Start time in UTC for this activity, in ISO-8601 format
    /// </summary>
    /// <value>Start time in UTC for this activity, in ISO-8601 format</value>
    [JsonPropertyName("startDate")]
    public DateTime? StartDate { get; set; }



    /// <summary>
    /// Length in minutes for this activity
    /// </summary>
    /// <value>Length in minutes for this activity</value>
    [JsonPropertyName("lengthInMinutes")]
    public int? LengthInMinutes { get; set; }



    /// <summary>
    /// Description for this activity
    /// </summary>
    /// <value>Description for this activity</value>
    [JsonPropertyName("description")]
    public string Description { get; set; }



    /// <summary>
    /// Whether this activity is paid
    /// </summary>
    /// <value>Whether this activity is paid</value>
    [JsonPropertyName("countsAsPaidTime")]
    public bool? CountsAsPaidTime { get; set; }



    /// <summary>
    /// Whether this activity spans a DST fallback
    /// </summary>
    /// <value>Whether this activity spans a DST fallback</value>
    [JsonPropertyName("isDstFallback")]
    public bool? IsDstFallback { get; set; }



    /// <summary>
    /// Time off request id of this activity
    /// </summary>
    /// <value>Time off request id of this activity</value>
    [JsonPropertyName("timeOffRequestId")]
    public string TimeOffRequestId { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class UserScheduleActivity {\n");

        sb.Append("  ActivityCodeId: ").Append(ActivityCodeId).Append("\n");
        sb.Append("  StartDate: ").Append(StartDate).Append("\n");
        sb.Append("  LengthInMinutes: ").Append(LengthInMinutes).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  CountsAsPaidTime: ").Append(CountsAsPaidTime).Append("\n");
        sb.Append("  IsDstFallback: ").Append(IsDstFallback).Append("\n");
        sb.Append("  TimeOffRequestId: ").Append(TimeOffRequestId).Append("\n");
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
        return Equals(obj as UserScheduleActivity);
    }

    /// <summary>
    /// Returns true if UserScheduleActivity instances are equal
    /// </summary>
    /// <param name="other">Instance of UserScheduleActivity to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(UserScheduleActivity other)
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
                Description == other.Description ||
                Description != null &&
                Description.Equals(other.Description)
            ) &&
            (
                CountsAsPaidTime == other.CountsAsPaidTime ||
                CountsAsPaidTime != null &&
                CountsAsPaidTime.Equals(other.CountsAsPaidTime)
            ) &&
            (
                IsDstFallback == other.IsDstFallback ||
                IsDstFallback != null &&
                IsDstFallback.Equals(other.IsDstFallback)
            ) &&
            (
                TimeOffRequestId == other.TimeOffRequestId ||
                TimeOffRequestId != null &&
                TimeOffRequestId.Equals(other.TimeOffRequestId)
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

            if (StartDate != null)
            {
                hash = hash * 59 + StartDate.GetHashCode();
            }

            if (LengthInMinutes != null)
            {
                hash = hash * 59 + LengthInMinutes.GetHashCode();
            }

            if (Description != null)
            {
                hash = hash * 59 + Description.GetHashCode();
            }

            if (CountsAsPaidTime != null)
            {
                hash = hash * 59 + CountsAsPaidTime.GetHashCode();
            }

            if (IsDstFallback != null)
            {
                hash = hash * 59 + IsDstFallback.GetHashCode();
            }

            if (TimeOffRequestId != null)
            {
                hash = hash * 59 + TimeOffRequestId.GetHashCode();
            }

            return hash;
        }
    }
}
