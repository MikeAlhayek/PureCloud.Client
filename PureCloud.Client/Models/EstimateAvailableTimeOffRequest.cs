using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// EstimateAvailableTimeOffRequest
/// </summary>

public partial class EstimateAvailableTimeOffRequest : IEquatable<EstimateAvailableTimeOffRequest>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="EstimateAvailableTimeOffRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected EstimateAvailableTimeOffRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="EstimateAvailableTimeOffRequest" /> class.
    /// </summary>
    /// <param name="FullDayDates">Full day dates. partialDayDates must be empty if this field is populated.</param>
    /// <param name="PartialDayDates">Partial day dates. fullDayDates must be empty if this field is populated.</param>
    /// <param name="ActivityCodeId">The ID of the activity code associated with the time off request. Activity code must be of the TimeOff category (required).</param>
    /// <param name="Paid">Whether this estimate is for a paid time off request (required).</param>
    public EstimateAvailableTimeOffRequest(List<EstimateAvailableFullDayTimeOffRequest> FullDayDates = null, List<EstimateAvailablePartialDayTimeOffRequest> PartialDayDates = null, string ActivityCodeId = null, bool? Paid = null)
    {
        this.FullDayDates = FullDayDates;
        this.PartialDayDates = PartialDayDates;
        this.ActivityCodeId = ActivityCodeId;
        this.Paid = Paid;

    }



    /// <summary>
    /// Full day dates. partialDayDates must be empty if this field is populated
    /// </summary>
    /// <value>Full day dates. partialDayDates must be empty if this field is populated</value>
    [JsonPropertyName("fullDayDates")]
    public List<EstimateAvailableFullDayTimeOffRequest> FullDayDates { get; set; }



    /// <summary>
    /// Partial day dates. fullDayDates must be empty if this field is populated
    /// </summary>
    /// <value>Partial day dates. fullDayDates must be empty if this field is populated</value>
    [JsonPropertyName("partialDayDates")]
    public List<EstimateAvailablePartialDayTimeOffRequest> PartialDayDates { get; set; }



    /// <summary>
    /// The ID of the activity code associated with the time off request. Activity code must be of the TimeOff category
    /// </summary>
    /// <value>The ID of the activity code associated with the time off request. Activity code must be of the TimeOff category</value>
    [JsonPropertyName("activityCodeId")]
    public string ActivityCodeId { get; set; }



    /// <summary>
    /// Whether this estimate is for a paid time off request
    /// </summary>
    /// <value>Whether this estimate is for a paid time off request</value>
    [JsonPropertyName("paid")]
    public bool? Paid { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class EstimateAvailableTimeOffRequest {\n");

        sb.Append("  FullDayDates: ").Append(FullDayDates).Append("\n");
        sb.Append("  PartialDayDates: ").Append(PartialDayDates).Append("\n");
        sb.Append("  ActivityCodeId: ").Append(ActivityCodeId).Append("\n");
        sb.Append("  Paid: ").Append(Paid).Append("\n");
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
        return Equals(obj as EstimateAvailableTimeOffRequest);
    }

    /// <summary>
    /// Returns true if EstimateAvailableTimeOffRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of EstimateAvailableTimeOffRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(EstimateAvailableTimeOffRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                FullDayDates == other.FullDayDates ||
                FullDayDates != null &&
                FullDayDates.SequenceEqual(other.FullDayDates)
            ) &&
            (
                PartialDayDates == other.PartialDayDates ||
                PartialDayDates != null &&
                PartialDayDates.SequenceEqual(other.PartialDayDates)
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
            if (FullDayDates != null)
            {
                hash = hash * 59 + FullDayDates.GetHashCode();
            }

            if (PartialDayDates != null)
            {
                hash = hash * 59 + PartialDayDates.GetHashCode();
            }

            if (ActivityCodeId != null)
            {
                hash = hash * 59 + ActivityCodeId.GetHashCode();
            }

            if (Paid != null)
            {
                hash = hash * 59 + Paid.GetHashCode();
            }

            return hash;
        }
    }
}
