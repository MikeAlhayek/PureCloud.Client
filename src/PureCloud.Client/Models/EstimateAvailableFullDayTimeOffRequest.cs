using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// EstimateAvailableFullDayTimeOffRequest
/// </summary>

public partial class EstimateAvailableFullDayTimeOffRequest : IEquatable<EstimateAvailableFullDayTimeOffRequest>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="EstimateAvailableFullDayTimeOffRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected EstimateAvailableFullDayTimeOffRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="EstimateAvailableFullDayTimeOffRequest" /> class.
    /// </summary>
    /// <param name="Date">Date in yyyy-MM-dd format for full day request. Should be interpreted in the business unit&#39;s configured time zone. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (required).</param>
    /// <param name="RequestedDurationMinutes">A requested length of time off request in minutes. If the value is null, then the system will use activity code length setting.</param>
    public EstimateAvailableFullDayTimeOffRequest(string Date = null, int? RequestedDurationMinutes = null)
    {
        this.Date = Date;
        this.RequestedDurationMinutes = RequestedDurationMinutes;

    }



    /// <summary>
    /// Date in yyyy-MM-dd format for full day request. Should be interpreted in the business unit&#39;s configured time zone. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
    /// </summary>
    /// <value>Date in yyyy-MM-dd format for full day request. Should be interpreted in the business unit&#39;s configured time zone. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
    [JsonPropertyName("date")]
    public string Date { get; set; }



    /// <summary>
    /// A requested length of time off request in minutes. If the value is null, then the system will use activity code length setting
    /// </summary>
    /// <value>A requested length of time off request in minutes. If the value is null, then the system will use activity code length setting</value>
    [JsonPropertyName("requestedDurationMinutes")]
    public int? RequestedDurationMinutes { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class EstimateAvailableFullDayTimeOffRequest {\n");

        sb.Append("  Date: ").Append(Date).Append("\n");
        sb.Append("  RequestedDurationMinutes: ").Append(RequestedDurationMinutes).Append("\n");
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
        return Equals(obj as EstimateAvailableFullDayTimeOffRequest);
    }

    /// <summary>
    /// Returns true if EstimateAvailableFullDayTimeOffRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of EstimateAvailableFullDayTimeOffRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(EstimateAvailableFullDayTimeOffRequest other)
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
                RequestedDurationMinutes == other.RequestedDurationMinutes ||
                RequestedDurationMinutes != null &&
                RequestedDurationMinutes.Equals(other.RequestedDurationMinutes)
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

            if (RequestedDurationMinutes != null)
            {
                hash = hash * 59 + RequestedDurationMinutes.GetHashCode();
            }

            return hash;
        }
    }
}
