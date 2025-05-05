using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// EstimateAvailableFullDayTimeOffResponse
/// </summary>

public partial class EstimateAvailableFullDayTimeOffResponse : IEquatable<EstimateAvailableFullDayTimeOffResponse>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="EstimateAvailableFullDayTimeOffResponse" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected EstimateAvailableFullDayTimeOffResponse() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="EstimateAvailableFullDayTimeOffResponse" /> class.
    /// </summary>
    /// <param name="Date">Date in yyyy-MM-dd format for full day request. Should be interpreted in the business unit&#39;s configured time zone. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (required).</param>
    /// <param name="DurationMinutes">An estimation of time off request length in minutes (required).</param>
    /// <param name="PayableMinutes">An estimation of payable part of time off request in minutes (required).</param>
    /// <param name="Flexible">Whether there is flexibility for a user to choose different hours than the system estimated (required).</param>
    public EstimateAvailableFullDayTimeOffResponse(string Date = null, int? DurationMinutes = null, int? PayableMinutes = null, bool? Flexible = null)
    {
        this.Date = Date;
        this.DurationMinutes = DurationMinutes;
        this.PayableMinutes = PayableMinutes;
        this.Flexible = Flexible;

    }



    /// <summary>
    /// Date in yyyy-MM-dd format for full day request. Should be interpreted in the business unit&#39;s configured time zone. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
    /// </summary>
    /// <value>Date in yyyy-MM-dd format for full day request. Should be interpreted in the business unit&#39;s configured time zone. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
    [JsonPropertyName("date")]
    public string Date { get; set; }



    /// <summary>
    /// An estimation of time off request length in minutes
    /// </summary>
    /// <value>An estimation of time off request length in minutes</value>
    [JsonPropertyName("durationMinutes")]
    public int? DurationMinutes { get; set; }



    /// <summary>
    /// An estimation of payable part of time off request in minutes
    /// </summary>
    /// <value>An estimation of payable part of time off request in minutes</value>
    [JsonPropertyName("payableMinutes")]
    public int? PayableMinutes { get; set; }



    /// <summary>
    /// Whether there is flexibility for a user to choose different hours than the system estimated
    /// </summary>
    /// <value>Whether there is flexibility for a user to choose different hours than the system estimated</value>
    [JsonPropertyName("flexible")]
    public bool? Flexible { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class EstimateAvailableFullDayTimeOffResponse {\n");

        sb.Append("  Date: ").Append(Date).Append("\n");
        sb.Append("  DurationMinutes: ").Append(DurationMinutes).Append("\n");
        sb.Append("  PayableMinutes: ").Append(PayableMinutes).Append("\n");
        sb.Append("  Flexible: ").Append(Flexible).Append("\n");
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
        return Equals(obj as EstimateAvailableFullDayTimeOffResponse);
    }

    /// <summary>
    /// Returns true if EstimateAvailableFullDayTimeOffResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of EstimateAvailableFullDayTimeOffResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(EstimateAvailableFullDayTimeOffResponse other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Date == other.Date ||
                Date != null &&
                Date.Equals(other.Date)
            ) &&
            (
                DurationMinutes == other.DurationMinutes ||
                DurationMinutes != null &&
                DurationMinutes.Equals(other.DurationMinutes)
            ) &&
            (
                PayableMinutes == other.PayableMinutes ||
                PayableMinutes != null &&
                PayableMinutes.Equals(other.PayableMinutes)
            ) &&
            (
                Flexible == other.Flexible ||
                Flexible != null &&
                Flexible.Equals(other.Flexible)
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
            if (Date != null)
            {
                hash = hash * 59 + Date.GetHashCode();
            }

            if (DurationMinutes != null)
            {
                hash = hash * 59 + DurationMinutes.GetHashCode();
            }

            if (PayableMinutes != null)
            {
                hash = hash * 59 + PayableMinutes.GetHashCode();
            }

            if (Flexible != null)
            {
                hash = hash * 59 + Flexible.GetHashCode();
            }

            return hash;
        }
    }
}
