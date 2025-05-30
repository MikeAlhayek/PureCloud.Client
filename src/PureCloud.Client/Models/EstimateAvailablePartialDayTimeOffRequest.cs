using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// EstimateAvailablePartialDayTimeOffRequest
/// </summary>

public partial class EstimateAvailablePartialDayTimeOffRequest : IEquatable<EstimateAvailablePartialDayTimeOffRequest>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="EstimateAvailablePartialDayTimeOffRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected EstimateAvailablePartialDayTimeOffRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="EstimateAvailablePartialDayTimeOffRequest" /> class.
    /// </summary>
    /// <param name="Date">Start date-time in ISO-8601 format for partial day request (required).</param>
    /// <param name="RequestedDurationMinutes">A requested length of time off request in minutes. If the value is null, then the system will use activity code length setting.</param>
    public EstimateAvailablePartialDayTimeOffRequest(DateTime? Date = null, int? RequestedDurationMinutes = null)
    {
        this.Date = Date;
        this.RequestedDurationMinutes = RequestedDurationMinutes;

    }



    /// <summary>
    /// Start date-time in ISO-8601 format for partial day request
    /// </summary>
    /// <value>Start date-time in ISO-8601 format for partial day request</value>
    [JsonPropertyName("date")]
    public DateTime? Date { get; set; }



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
        sb.Append("class EstimateAvailablePartialDayTimeOffRequest {\n");

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
        return Equals(obj as EstimateAvailablePartialDayTimeOffRequest);
    }

    /// <summary>
    /// Returns true if EstimateAvailablePartialDayTimeOffRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of EstimateAvailablePartialDayTimeOffRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(EstimateAvailablePartialDayTimeOffRequest other)
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
