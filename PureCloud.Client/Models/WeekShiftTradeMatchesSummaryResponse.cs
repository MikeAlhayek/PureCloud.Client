using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WeekShiftTradeMatchesSummaryResponse
/// </summary>
[DataContract]
public partial class WeekShiftTradeMatchesSummaryResponse : IEquatable<WeekShiftTradeMatchesSummaryResponse>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="WeekShiftTradeMatchesSummaryResponse" /> class.
    /// </summary>
    /// <param name="WeekDate">The schedule week date in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd.</param>
    /// <param name="Count">The number of trades in the &#39;Matched&#39; state with the initiating shift in the given week.</param>
    public WeekShiftTradeMatchesSummaryResponse(string WeekDate = null, int? Count = null)
    {
        this.WeekDate = WeekDate;
        this.Count = Count;

    }



    /// <summary>
    /// The schedule week date in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
    /// </summary>
    /// <value>The schedule week date in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
    [DataMember(Name = "weekDate", EmitDefaultValue = false)]
    public string WeekDate { get; set; }



    /// <summary>
    /// The number of trades in the &#39;Matched&#39; state with the initiating shift in the given week
    /// </summary>
    /// <value>The number of trades in the &#39;Matched&#39; state with the initiating shift in the given week</value>
    [DataMember(Name = "count", EmitDefaultValue = false)]
    public int? Count { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WeekShiftTradeMatchesSummaryResponse {\n");

        sb.Append("  WeekDate: ").Append(WeekDate).Append("\n");
        sb.Append("  Count: ").Append(Count).Append("\n");
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
        return Equals(obj as WeekShiftTradeMatchesSummaryResponse);
    }

    /// <summary>
    /// Returns true if WeekShiftTradeMatchesSummaryResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of WeekShiftTradeMatchesSummaryResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WeekShiftTradeMatchesSummaryResponse other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                WeekDate == other.WeekDate ||
                WeekDate != null &&
                WeekDate.Equals(other.WeekDate)
            ) &&
            (
                Count == other.Count ||
                Count != null &&
                Count.Equals(other.Count)
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
            if (WeekDate != null)
            {
                hash = hash * 59 + WeekDate.GetHashCode();
            }

            if (Count != null)
            {
                hash = hash * 59 + Count.GetHashCode();
            }

            return hash;
        }
    }
}
