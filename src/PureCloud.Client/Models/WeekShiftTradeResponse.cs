using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WeekShiftTradeResponse
/// </summary>

public partial class WeekShiftTradeResponse : IEquatable<WeekShiftTradeResponse>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="WeekShiftTradeResponse" /> class.
    /// </summary>
    /// <param name="Trade">The shift trade details.</param>
    /// <param name="MatchReview">A preview of what the schedule would look like if the shift trade is approved plus any violations.</param>
    public WeekShiftTradeResponse(ShiftTradeResponse Trade = null, ShiftTradeMatchReviewResponse MatchReview = null)
    {
        this.Trade = Trade;
        this.MatchReview = MatchReview;

    }



    /// <summary>
    /// The shift trade details
    /// </summary>
    /// <value>The shift trade details</value>
    [JsonPropertyName("trade")]
    public ShiftTradeResponse Trade { get; set; }



    /// <summary>
    /// A preview of what the schedule would look like if the shift trade is approved plus any violations
    /// </summary>
    /// <value>A preview of what the schedule would look like if the shift trade is approved plus any violations</value>
    [JsonPropertyName("matchReview")]
    public ShiftTradeMatchReviewResponse MatchReview { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WeekShiftTradeResponse {\n");

        sb.Append("  Trade: ").Append(Trade).Append("\n");
        sb.Append("  MatchReview: ").Append(MatchReview).Append("\n");
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
        return Equals(obj as WeekShiftTradeResponse);
    }

    /// <summary>
    /// Returns true if WeekShiftTradeResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of WeekShiftTradeResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WeekShiftTradeResponse other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Trade == other.Trade ||
                Trade != null &&
                Trade.Equals(other.Trade)
            ) &&
            (
                MatchReview == other.MatchReview ||
                MatchReview != null &&
                MatchReview.Equals(other.MatchReview)
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
            if (Trade != null)
            {
                hash = hash * 59 + Trade.GetHashCode();
            }

            if (MatchReview != null)
            {
                hash = hash * 59 + MatchReview.GetHashCode();
            }

            return hash;
        }
    }
}
