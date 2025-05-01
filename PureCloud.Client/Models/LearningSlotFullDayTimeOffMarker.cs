using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// LearningSlotFullDayTimeOffMarker
/// </summary>
[DataContract]
public partial class LearningSlotFullDayTimeOffMarker : IEquatable<LearningSlotFullDayTimeOffMarker>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="LearningSlotFullDayTimeOffMarker" /> class.
    /// </summary>
    /// <param name="BusinessUnitDate">The date of the time off marker, interpreted in the business unit&#39;s time zone. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd.</param>
    /// <param name="LengthMinutes">The length of the time off marker in minutes.</param>
    /// <param name="Description">The description of the time off marker.</param>
    /// <param name="ActivityCodeId">The ID of the activity code associated with the time off marker.</param>
    /// <param name="Paid">Whether the time off marker is paid.</param>
    /// <param name="TimeOffRequestId">The ID of the time off request.</param>
    public LearningSlotFullDayTimeOffMarker(string BusinessUnitDate = null, int? LengthMinutes = null, string Description = null, string ActivityCodeId = null, bool? Paid = null, string TimeOffRequestId = null)
    {
        this.BusinessUnitDate = BusinessUnitDate;
        this.LengthMinutes = LengthMinutes;
        this.Description = Description;
        this.ActivityCodeId = ActivityCodeId;
        this.Paid = Paid;
        this.TimeOffRequestId = TimeOffRequestId;

    }



    /// <summary>
    /// The date of the time off marker, interpreted in the business unit&#39;s time zone. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
    /// </summary>
    /// <value>The date of the time off marker, interpreted in the business unit&#39;s time zone. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
    [DataMember(Name = "businessUnitDate", EmitDefaultValue = false)]
    public string BusinessUnitDate { get; set; }



    /// <summary>
    /// The length of the time off marker in minutes
    /// </summary>
    /// <value>The length of the time off marker in minutes</value>
    [DataMember(Name = "lengthMinutes", EmitDefaultValue = false)]
    public int? LengthMinutes { get; set; }



    /// <summary>
    /// The description of the time off marker
    /// </summary>
    /// <value>The description of the time off marker</value>
    [DataMember(Name = "description", EmitDefaultValue = false)]
    public string Description { get; set; }



    /// <summary>
    /// The ID of the activity code associated with the time off marker
    /// </summary>
    /// <value>The ID of the activity code associated with the time off marker</value>
    [DataMember(Name = "activityCodeId", EmitDefaultValue = false)]
    public string ActivityCodeId { get; set; }



    /// <summary>
    /// Whether the time off marker is paid
    /// </summary>
    /// <value>Whether the time off marker is paid</value>
    [DataMember(Name = "paid", EmitDefaultValue = false)]
    public bool? Paid { get; set; }



    /// <summary>
    /// The ID of the time off request
    /// </summary>
    /// <value>The ID of the time off request</value>
    [DataMember(Name = "timeOffRequestId", EmitDefaultValue = false)]
    public string TimeOffRequestId { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class LearningSlotFullDayTimeOffMarker {\n");

        sb.Append("  BusinessUnitDate: ").Append(BusinessUnitDate).Append("\n");
        sb.Append("  LengthMinutes: ").Append(LengthMinutes).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  ActivityCodeId: ").Append(ActivityCodeId).Append("\n");
        sb.Append("  Paid: ").Append(Paid).Append("\n");
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
        return Equals(obj as LearningSlotFullDayTimeOffMarker);
    }

    /// <summary>
    /// Returns true if LearningSlotFullDayTimeOffMarker instances are equal
    /// </summary>
    /// <param name="other">Instance of LearningSlotFullDayTimeOffMarker to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(LearningSlotFullDayTimeOffMarker other)
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

            if (TimeOffRequestId != null)
            {
                hash = hash * 59 + TimeOffRequestId.GetHashCode();
            }

            return hash;
        }
    }
}
