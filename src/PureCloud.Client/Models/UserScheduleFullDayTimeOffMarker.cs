using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// UserScheduleFullDayTimeOffMarker
/// </summary>

public partial class UserScheduleFullDayTimeOffMarker : IEquatable<UserScheduleFullDayTimeOffMarker>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="UserScheduleFullDayTimeOffMarker" /> class.
    /// </summary>
    /// <param name="ManagementUnitDate">The date associated with the time off request that this marker corresponds to.  Date only, in ISO-8601 format..</param>
    /// <param name="ActivityCodeId">The id for the activity code.  Look up a map of activity codes with the activities route.</param>
    /// <param name="IsPaid">Whether this is paid time off.</param>
    /// <param name="LengthInMinutes">The length in minutes of this time off marker.</param>
    /// <param name="Description">The description associated with the time off request that this marker corresponds to.</param>
    /// <param name="Delete">If marked true for updating an existing full day time off marker, it will be deleted.</param>
    public UserScheduleFullDayTimeOffMarker(string ManagementUnitDate = null, string ActivityCodeId = null, bool? IsPaid = null, int? LengthInMinutes = null, string Description = null, bool? Delete = null)
    {
        this.ManagementUnitDate = ManagementUnitDate;
        this.ActivityCodeId = ActivityCodeId;
        this.IsPaid = IsPaid;
        this.LengthInMinutes = LengthInMinutes;
        this.Description = Description;
        this.Delete = Delete;

    }



    /// <summary>
    /// The date associated with the time off request that this marker corresponds to.  Date only, in ISO-8601 format.
    /// </summary>
    /// <value>The date associated with the time off request that this marker corresponds to.  Date only, in ISO-8601 format.</value>
    [JsonPropertyName("managementUnitDate")]
    public string ManagementUnitDate { get; set; }



    /// <summary>
    /// The id for the activity code.  Look up a map of activity codes with the activities route
    /// </summary>
    /// <value>The id for the activity code.  Look up a map of activity codes with the activities route</value>
    [JsonPropertyName("activityCodeId")]
    public string ActivityCodeId { get; set; }



    /// <summary>
    /// Whether this is paid time off
    /// </summary>
    /// <value>Whether this is paid time off</value>
    [JsonPropertyName("isPaid")]
    public bool? IsPaid { get; set; }



    /// <summary>
    /// The length in minutes of this time off marker
    /// </summary>
    /// <value>The length in minutes of this time off marker</value>
    [JsonPropertyName("lengthInMinutes")]
    public int? LengthInMinutes { get; set; }



    /// <summary>
    /// The description associated with the time off request that this marker corresponds to
    /// </summary>
    /// <value>The description associated with the time off request that this marker corresponds to</value>
    [JsonPropertyName("description")]
    public string Description { get; set; }



    /// <summary>
    /// If marked true for updating an existing full day time off marker, it will be deleted
    /// </summary>
    /// <value>If marked true for updating an existing full day time off marker, it will be deleted</value>
    [JsonPropertyName("delete")]
    public bool? Delete { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class UserScheduleFullDayTimeOffMarker {\n");

        sb.Append("  ManagementUnitDate: ").Append(ManagementUnitDate).Append("\n");
        sb.Append("  ActivityCodeId: ").Append(ActivityCodeId).Append("\n");
        sb.Append("  IsPaid: ").Append(IsPaid).Append("\n");
        sb.Append("  LengthInMinutes: ").Append(LengthInMinutes).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
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
        return Equals(obj as UserScheduleFullDayTimeOffMarker);
    }

    /// <summary>
    /// Returns true if UserScheduleFullDayTimeOffMarker instances are equal
    /// </summary>
    /// <param name="other">Instance of UserScheduleFullDayTimeOffMarker to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(UserScheduleFullDayTimeOffMarker other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                ManagementUnitDate == other.ManagementUnitDate ||
                ManagementUnitDate != null &&
                ManagementUnitDate.Equals(other.ManagementUnitDate)
            ) &&
            (
                ActivityCodeId == other.ActivityCodeId ||
                ActivityCodeId != null &&
                ActivityCodeId.Equals(other.ActivityCodeId)
            ) &&
            (
                IsPaid == other.IsPaid ||
                IsPaid != null &&
                IsPaid.Equals(other.IsPaid)
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
            if (ManagementUnitDate != null)
            {
                hash = hash * 59 + ManagementUnitDate.GetHashCode();
            }

            if (ActivityCodeId != null)
            {
                hash = hash * 59 + ActivityCodeId.GetHashCode();
            }

            if (IsPaid != null)
            {
                hash = hash * 59 + IsPaid.GetHashCode();
            }

            if (LengthInMinutes != null)
            {
                hash = hash * 59 + LengthInMinutes.GetHashCode();
            }

            if (Description != null)
            {
                hash = hash * 59 + Description.GetHashCode();
            }

            if (Delete != null)
            {
                hash = hash * 59 + Delete.GetHashCode();
            }

            return hash;
        }
    }
}
