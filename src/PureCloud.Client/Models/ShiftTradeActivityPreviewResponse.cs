using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ShiftTradeActivityPreviewResponse
/// </summary>

public partial class ShiftTradeActivityPreviewResponse : IEquatable<ShiftTradeActivityPreviewResponse>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ShiftTradeActivityPreviewResponse" /> class.
    /// </summary>
    /// <param name="StartDate">The start date and time of this activity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="LengthMinutes">The length in minutes of this activity.</param>
    /// <param name="ActivityCodeId">The ID of the activity code for this activity.</param>
    /// <param name="CountsAsPaidTime">Whether this activity counts as paid time.</param>
    /// <param name="PayableMinutes">Payable minutes for this activity.</param>
    public ShiftTradeActivityPreviewResponse(DateTime? StartDate = null, int? LengthMinutes = null, string ActivityCodeId = null, bool? CountsAsPaidTime = null, int? PayableMinutes = null)
    {
        this.StartDate = StartDate;
        this.LengthMinutes = LengthMinutes;
        this.ActivityCodeId = ActivityCodeId;
        this.CountsAsPaidTime = CountsAsPaidTime;
        this.PayableMinutes = PayableMinutes;

    }



    /// <summary>
    /// The start date and time of this activity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The start date and time of this activity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("startDate")]
    public DateTime? StartDate { get; set; }



    /// <summary>
    /// The length in minutes of this activity
    /// </summary>
    /// <value>The length in minutes of this activity</value>
    [JsonPropertyName("lengthMinutes")]
    public int? LengthMinutes { get; set; }



    /// <summary>
    /// The ID of the activity code for this activity
    /// </summary>
    /// <value>The ID of the activity code for this activity</value>
    [JsonPropertyName("activityCodeId")]
    public string ActivityCodeId { get; set; }



    /// <summary>
    /// Whether this activity counts as paid time
    /// </summary>
    /// <value>Whether this activity counts as paid time</value>
    [JsonPropertyName("countsAsPaidTime")]
    public bool? CountsAsPaidTime { get; set; }



    /// <summary>
    /// Payable minutes for this activity
    /// </summary>
    /// <value>Payable minutes for this activity</value>
    [JsonPropertyName("payableMinutes")]
    public int? PayableMinutes { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ShiftTradeActivityPreviewResponse {\n");

        sb.Append("  StartDate: ").Append(StartDate).Append("\n");
        sb.Append("  LengthMinutes: ").Append(LengthMinutes).Append("\n");
        sb.Append("  ActivityCodeId: ").Append(ActivityCodeId).Append("\n");
        sb.Append("  CountsAsPaidTime: ").Append(CountsAsPaidTime).Append("\n");
        sb.Append("  PayableMinutes: ").Append(PayableMinutes).Append("\n");
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
        return Equals(obj as ShiftTradeActivityPreviewResponse);
    }

    /// <summary>
    /// Returns true if ShiftTradeActivityPreviewResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of ShiftTradeActivityPreviewResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ShiftTradeActivityPreviewResponse other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
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
                ActivityCodeId == other.ActivityCodeId ||
                ActivityCodeId != null &&
                ActivityCodeId.Equals(other.ActivityCodeId)
            ) &&
            (
                CountsAsPaidTime == other.CountsAsPaidTime ||
                CountsAsPaidTime != null &&
                CountsAsPaidTime.Equals(other.CountsAsPaidTime)
            ) &&
            (
                PayableMinutes == other.PayableMinutes ||
                PayableMinutes != null &&
                PayableMinutes.Equals(other.PayableMinutes)
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
            if (StartDate != null)
            {
                hash = hash * 59 + StartDate.GetHashCode();
            }

            if (LengthMinutes != null)
            {
                hash = hash * 59 + LengthMinutes.GetHashCode();
            }

            if (ActivityCodeId != null)
            {
                hash = hash * 59 + ActivityCodeId.GetHashCode();
            }

            if (CountsAsPaidTime != null)
            {
                hash = hash * 59 + CountsAsPaidTime.GetHashCode();
            }

            if (PayableMinutes != null)
            {
                hash = hash * 59 + PayableMinutes.GetHashCode();
            }

            return hash;
        }
    }
}
