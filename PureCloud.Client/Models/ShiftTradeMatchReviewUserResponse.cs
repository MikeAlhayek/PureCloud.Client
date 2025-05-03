using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ShiftTradeMatchReviewUserResponse
/// </summary>

public partial class ShiftTradeMatchReviewUserResponse : IEquatable<ShiftTradeMatchReviewUserResponse>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ShiftTradeMatchReviewUserResponse" /> class.
    /// </summary>
    /// <param name="WeeklyMinimumPaidMinutes">The minimum weekly paid minutes for this user per the work plan tied to the agent schedule.</param>
    /// <param name="WeeklyMaximumPaidMinutes">The maximum weekly paid minutes for this user per the work plan tied to the agent schedule.</param>
    /// <param name="PreTradeSchedulePaidMinutes">The paid minutes on the week schedule for this user prior to the shift trade.</param>
    /// <param name="PostTradeSchedulePaidMinutes">The paid minutes on the week schedule for this user if the shift trade is approved.</param>
    /// <param name="PostTradeNewShift">Preview of what the shift will look like for the opposite side of this trade after the match is approved.</param>
    public ShiftTradeMatchReviewUserResponse(int? WeeklyMinimumPaidMinutes = null, int? WeeklyMaximumPaidMinutes = null, int? PreTradeSchedulePaidMinutes = null, int? PostTradeSchedulePaidMinutes = null, ShiftTradePreviewResponse PostTradeNewShift = null)
    {
        this.WeeklyMinimumPaidMinutes = WeeklyMinimumPaidMinutes;
        this.WeeklyMaximumPaidMinutes = WeeklyMaximumPaidMinutes;
        this.PreTradeSchedulePaidMinutes = PreTradeSchedulePaidMinutes;
        this.PostTradeSchedulePaidMinutes = PostTradeSchedulePaidMinutes;
        this.PostTradeNewShift = PostTradeNewShift;

    }



    /// <summary>
    /// The minimum weekly paid minutes for this user per the work plan tied to the agent schedule
    /// </summary>
    /// <value>The minimum weekly paid minutes for this user per the work plan tied to the agent schedule</value>
    [JsonPropertyName("weeklyMinimumPaidMinutes")]
    public int? WeeklyMinimumPaidMinutes { get; set; }



    /// <summary>
    /// The maximum weekly paid minutes for this user per the work plan tied to the agent schedule
    /// </summary>
    /// <value>The maximum weekly paid minutes for this user per the work plan tied to the agent schedule</value>
    [JsonPropertyName("weeklyMaximumPaidMinutes")]
    public int? WeeklyMaximumPaidMinutes { get; set; }



    /// <summary>
    /// The paid minutes on the week schedule for this user prior to the shift trade
    /// </summary>
    /// <value>The paid minutes on the week schedule for this user prior to the shift trade</value>
    [JsonPropertyName("preTradeSchedulePaidMinutes")]
    public int? PreTradeSchedulePaidMinutes { get; set; }



    /// <summary>
    /// The paid minutes on the week schedule for this user if the shift trade is approved
    /// </summary>
    /// <value>The paid minutes on the week schedule for this user if the shift trade is approved</value>
    [JsonPropertyName("postTradeSchedulePaidMinutes")]
    public int? PostTradeSchedulePaidMinutes { get; set; }



    /// <summary>
    /// Preview of what the shift will look like for the opposite side of this trade after the match is approved
    /// </summary>
    /// <value>Preview of what the shift will look like for the opposite side of this trade after the match is approved</value>
    [JsonPropertyName("postTradeNewShift")]
    public ShiftTradePreviewResponse PostTradeNewShift { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ShiftTradeMatchReviewUserResponse {\n");

        sb.Append("  WeeklyMinimumPaidMinutes: ").Append(WeeklyMinimumPaidMinutes).Append("\n");
        sb.Append("  WeeklyMaximumPaidMinutes: ").Append(WeeklyMaximumPaidMinutes).Append("\n");
        sb.Append("  PreTradeSchedulePaidMinutes: ").Append(PreTradeSchedulePaidMinutes).Append("\n");
        sb.Append("  PostTradeSchedulePaidMinutes: ").Append(PostTradeSchedulePaidMinutes).Append("\n");
        sb.Append("  PostTradeNewShift: ").Append(PostTradeNewShift).Append("\n");
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
        return Equals(obj as ShiftTradeMatchReviewUserResponse);
    }

    /// <summary>
    /// Returns true if ShiftTradeMatchReviewUserResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of ShiftTradeMatchReviewUserResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ShiftTradeMatchReviewUserResponse other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                WeeklyMinimumPaidMinutes == other.WeeklyMinimumPaidMinutes ||
                WeeklyMinimumPaidMinutes != null &&
                WeeklyMinimumPaidMinutes.Equals(other.WeeklyMinimumPaidMinutes)
            ) &&
            (
                WeeklyMaximumPaidMinutes == other.WeeklyMaximumPaidMinutes ||
                WeeklyMaximumPaidMinutes != null &&
                WeeklyMaximumPaidMinutes.Equals(other.WeeklyMaximumPaidMinutes)
            ) &&
            (
                PreTradeSchedulePaidMinutes == other.PreTradeSchedulePaidMinutes ||
                PreTradeSchedulePaidMinutes != null &&
                PreTradeSchedulePaidMinutes.Equals(other.PreTradeSchedulePaidMinutes)
            ) &&
            (
                PostTradeSchedulePaidMinutes == other.PostTradeSchedulePaidMinutes ||
                PostTradeSchedulePaidMinutes != null &&
                PostTradeSchedulePaidMinutes.Equals(other.PostTradeSchedulePaidMinutes)
            ) &&
            (
                PostTradeNewShift == other.PostTradeNewShift ||
                PostTradeNewShift != null &&
                PostTradeNewShift.Equals(other.PostTradeNewShift)
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
            if (WeeklyMinimumPaidMinutes != null)
            {
                hash = hash * 59 + WeeklyMinimumPaidMinutes.GetHashCode();
            }

            if (WeeklyMaximumPaidMinutes != null)
            {
                hash = hash * 59 + WeeklyMaximumPaidMinutes.GetHashCode();
            }

            if (PreTradeSchedulePaidMinutes != null)
            {
                hash = hash * 59 + PreTradeSchedulePaidMinutes.GetHashCode();
            }

            if (PostTradeSchedulePaidMinutes != null)
            {
                hash = hash * 59 + PostTradeSchedulePaidMinutes.GetHashCode();
            }

            if (PostTradeNewShift != null)
            {
                hash = hash * 59 + PostTradeNewShift.GetHashCode();
            }

            return hash;
        }
    }
}
