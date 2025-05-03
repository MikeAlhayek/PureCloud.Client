using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// SearchShiftTradeResponse
/// </summary>

public partial class SearchShiftTradeResponse : IEquatable<SearchShiftTradeResponse>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SearchShiftTradeResponse" /> class.
    /// </summary>
    /// <param name="Trade">A trade which matches search criteria.</param>
    /// <param name="MatchingReceivingShiftIds">IDs of shifts which match the search criteria.</param>
    /// <param name="Preview">A preview of what the shift trade would look like if matched.</param>
    public SearchShiftTradeResponse(ShiftTradeResponse Trade = null, List<string> MatchingReceivingShiftIds = null, ShiftTradePreviewResponse Preview = null)
    {
        this.Trade = Trade;
        this.MatchingReceivingShiftIds = MatchingReceivingShiftIds;
        this.Preview = Preview;

    }



    /// <summary>
    /// A trade which matches search criteria
    /// </summary>
    /// <value>A trade which matches search criteria</value>
    [JsonPropertyName("trade")]
    public ShiftTradeResponse Trade { get; set; }



    /// <summary>
    /// IDs of shifts which match the search criteria
    /// </summary>
    /// <value>IDs of shifts which match the search criteria</value>
    [JsonPropertyName("matchingReceivingShiftIds")]
    public List<string> MatchingReceivingShiftIds { get; set; }



    /// <summary>
    /// A preview of what the shift trade would look like if matched
    /// </summary>
    /// <value>A preview of what the shift trade would look like if matched</value>
    [JsonPropertyName("preview")]
    public ShiftTradePreviewResponse Preview { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class SearchShiftTradeResponse {\n");

        sb.Append("  Trade: ").Append(Trade).Append("\n");
        sb.Append("  MatchingReceivingShiftIds: ").Append(MatchingReceivingShiftIds).Append("\n");
        sb.Append("  Preview: ").Append(Preview).Append("\n");
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
        return Equals(obj as SearchShiftTradeResponse);
    }

    /// <summary>
    /// Returns true if SearchShiftTradeResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of SearchShiftTradeResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(SearchShiftTradeResponse other)
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
                MatchingReceivingShiftIds == other.MatchingReceivingShiftIds ||
                MatchingReceivingShiftIds != null &&
                MatchingReceivingShiftIds.SequenceEqual(other.MatchingReceivingShiftIds)
            ) &&
            (
                Preview == other.Preview ||
                Preview != null &&
                Preview.Equals(other.Preview)
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

            if (MatchingReceivingShiftIds != null)
            {
                hash = hash * 59 + MatchingReceivingShiftIds.GetHashCode();
            }

            if (Preview != null)
            {
                hash = hash * 59 + Preview.GetHashCode();
            }

            return hash;
        }
    }
}
