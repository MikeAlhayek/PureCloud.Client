using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// DateRange
/// </summary>

public partial class DateRange : IEquatable<DateRange>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DateRange" /> class.
    /// </summary>
    /// <param name="StartDate">The inclusive start of a date range in yyyy-MM-dd format. Should be interpreted in the management unit&#39;s configured time zone..</param>
    /// <param name="EndDate">The inclusive end of a date range in yyyy-MM-dd format. Should be interpreted in the management unit&#39;s configured time zone..</param>
    public DateRange(string StartDate = null, string EndDate = null)
    {
        this.StartDate = StartDate;
        this.EndDate = EndDate;

    }



    /// <summary>
    /// The inclusive start of a date range in yyyy-MM-dd format. Should be interpreted in the management unit&#39;s configured time zone.
    /// </summary>
    /// <value>The inclusive start of a date range in yyyy-MM-dd format. Should be interpreted in the management unit&#39;s configured time zone.</value>
    [JsonPropertyName("startDate")]
    public string StartDate { get; set; }



    /// <summary>
    /// The inclusive end of a date range in yyyy-MM-dd format. Should be interpreted in the management unit&#39;s configured time zone.
    /// </summary>
    /// <value>The inclusive end of a date range in yyyy-MM-dd format. Should be interpreted in the management unit&#39;s configured time zone.</value>
    [JsonPropertyName("endDate")]
    public string EndDate { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class DateRange {\n");

        sb.Append("  StartDate: ").Append(StartDate).Append("\n");
        sb.Append("  EndDate: ").Append(EndDate).Append("\n");
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
        return Equals(obj as DateRange);
    }

    /// <summary>
    /// Returns true if DateRange instances are equal
    /// </summary>
    /// <param name="other">Instance of DateRange to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DateRange other)
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
                EndDate == other.EndDate ||
                EndDate != null &&
                EndDate.Equals(other.EndDate)
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

            if (EndDate != null)
            {
                hash = hash * 59 + EndDate.GetHashCode();
            }

            return hash;
        }
    }
}
