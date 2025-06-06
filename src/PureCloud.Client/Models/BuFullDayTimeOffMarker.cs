using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// BuFullDayTimeOffMarker
/// </summary>

public partial class BuFullDayTimeOffMarker : IEquatable<BuFullDayTimeOffMarker>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BuFullDayTimeOffMarker" /> class.
    /// </summary>
    /// <param name="BusinessUnitDate">The date of the time off marker, interpreted in the business unit&#39;s time zone. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd.</param>
    /// <param name="LengthMinutes">The length of the time off marker in minutes.</param>
    /// <param name="Description">The description of the time off marker.</param>
    /// <param name="ActivityCodeId">The ID of the activity code associated with the time off marker.</param>
    /// <param name="Paid">Whether the time off marker is paid.</param>
    /// <param name="PayableMinutes">Payable minutes for the time off marker.</param>
    /// <param name="TimeOffRequestId">The ID of the time off request.</param>
    /// <param name="TimeOffRequestSyncVersion">The sync version of the full day time off request for which the scheduled activity is associated.</param>
    /// <param name="Delete">Set to &#39;true&#39; to delete this time off marker. Will always be null on responses, only has an effect on schedule update.</param>
    public BuFullDayTimeOffMarker(string BusinessUnitDate = null, int? LengthMinutes = null, string Description = null, string ActivityCodeId = null, bool? Paid = null, int? PayableMinutes = null, string TimeOffRequestId = null, int? TimeOffRequestSyncVersion = null, bool? Delete = null)
    {
        this.BusinessUnitDate = BusinessUnitDate;
        this.LengthMinutes = LengthMinutes;
        this.Description = Description;
        this.ActivityCodeId = ActivityCodeId;
        this.Paid = Paid;
        this.PayableMinutes = PayableMinutes;
        this.TimeOffRequestId = TimeOffRequestId;
        this.TimeOffRequestSyncVersion = TimeOffRequestSyncVersion;
        this.Delete = Delete;

    }



    /// <summary>
    /// The date of the time off marker, interpreted in the business unit&#39;s time zone. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
    /// </summary>
    /// <value>The date of the time off marker, interpreted in the business unit&#39;s time zone. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
    [JsonPropertyName("businessUnitDate")]
    public string BusinessUnitDate { get; set; }



    /// <summary>
    /// The length of the time off marker in minutes
    /// </summary>
    /// <value>The length of the time off marker in minutes</value>
    [JsonPropertyName("lengthMinutes")]
    public int? LengthMinutes { get; set; }



    /// <summary>
    /// The description of the time off marker
    /// </summary>
    /// <value>The description of the time off marker</value>
    [JsonPropertyName("description")]
    public string Description { get; set; }



    /// <summary>
    /// The ID of the activity code associated with the time off marker
    /// </summary>
    /// <value>The ID of the activity code associated with the time off marker</value>
    [JsonPropertyName("activityCodeId")]
    public string ActivityCodeId { get; set; }



    /// <summary>
    /// Whether the time off marker is paid
    /// </summary>
    /// <value>Whether the time off marker is paid</value>
    [JsonPropertyName("paid")]
    public bool? Paid { get; set; }



    /// <summary>
    /// Payable minutes for the time off marker
    /// </summary>
    /// <value>Payable minutes for the time off marker</value>
    [JsonPropertyName("payableMinutes")]
    public int? PayableMinutes { get; set; }



    /// <summary>
    /// The ID of the time off request
    /// </summary>
    /// <value>The ID of the time off request</value>
    [JsonPropertyName("timeOffRequestId")]
    public string TimeOffRequestId { get; set; }



    /// <summary>
    /// The sync version of the full day time off request for which the scheduled activity is associated
    /// </summary>
    /// <value>The sync version of the full day time off request for which the scheduled activity is associated</value>
    [JsonPropertyName("timeOffRequestSyncVersion")]
    public int? TimeOffRequestSyncVersion { get; set; }



    /// <summary>
    /// Set to &#39;true&#39; to delete this time off marker. Will always be null on responses, only has an effect on schedule update
    /// </summary>
    /// <value>Set to &#39;true&#39; to delete this time off marker. Will always be null on responses, only has an effect on schedule update</value>
    [JsonPropertyName("delete")]
    public bool? Delete { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class BuFullDayTimeOffMarker {\n");

        sb.Append("  BusinessUnitDate: ").Append(BusinessUnitDate).Append("\n");
        sb.Append("  LengthMinutes: ").Append(LengthMinutes).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  ActivityCodeId: ").Append(ActivityCodeId).Append("\n");
        sb.Append("  Paid: ").Append(Paid).Append("\n");
        sb.Append("  PayableMinutes: ").Append(PayableMinutes).Append("\n");
        sb.Append("  TimeOffRequestId: ").Append(TimeOffRequestId).Append("\n");
        sb.Append("  TimeOffRequestSyncVersion: ").Append(TimeOffRequestSyncVersion).Append("\n");
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
        return Equals(obj as BuFullDayTimeOffMarker);
    }

    /// <summary>
    /// Returns true if BuFullDayTimeOffMarker instances are equal
    /// </summary>
    /// <param name="other">Instance of BuFullDayTimeOffMarker to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(BuFullDayTimeOffMarker other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                BusinessUnitDate == other.BusinessUnitDate ||
                BusinessUnitDate != null &&
                BusinessUnitDate.Equals(other.BusinessUnitDate)
            ) &&
            (
                LengthMinutes == other.LengthMinutes ||
                LengthMinutes != null &&
                LengthMinutes.Equals(other.LengthMinutes)
            ) &&
            (
                Description == other.Description ||
                Description != null &&
                Description.Equals(other.Description)
            ) &&
            (
                ActivityCodeId == other.ActivityCodeId ||
                ActivityCodeId != null &&
                ActivityCodeId.Equals(other.ActivityCodeId)
            ) &&
            (
                Paid == other.Paid ||
                Paid != null &&
                Paid.Equals(other.Paid)
            ) &&
            (
                PayableMinutes == other.PayableMinutes ||
                PayableMinutes != null &&
                PayableMinutes.Equals(other.PayableMinutes)
            ) &&
            (
                TimeOffRequestId == other.TimeOffRequestId ||
                TimeOffRequestId != null &&
                TimeOffRequestId.Equals(other.TimeOffRequestId)
            ) &&
            (
                TimeOffRequestSyncVersion == other.TimeOffRequestSyncVersion ||
                TimeOffRequestSyncVersion != null &&
                TimeOffRequestSyncVersion.Equals(other.TimeOffRequestSyncVersion)
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
            if (BusinessUnitDate != null)
            {
                hash = hash * 59 + BusinessUnitDate.GetHashCode();
            }

            if (LengthMinutes != null)
            {
                hash = hash * 59 + LengthMinutes.GetHashCode();
            }

            if (Description != null)
            {
                hash = hash * 59 + Description.GetHashCode();
            }

            if (ActivityCodeId != null)
            {
                hash = hash * 59 + ActivityCodeId.GetHashCode();
            }

            if (Paid != null)
            {
                hash = hash * 59 + Paid.GetHashCode();
            }

            if (PayableMinutes != null)
            {
                hash = hash * 59 + PayableMinutes.GetHashCode();
            }

            if (TimeOffRequestId != null)
            {
                hash = hash * 59 + TimeOffRequestId.GetHashCode();
            }

            if (TimeOffRequestSyncVersion != null)
            {
                hash = hash * 59 + TimeOffRequestSyncVersion.GetHashCode();
            }

            if (Delete != null)
            {
                hash = hash * 59 + Delete.GetHashCode();
            }

            return hash;
        }
    }
}
