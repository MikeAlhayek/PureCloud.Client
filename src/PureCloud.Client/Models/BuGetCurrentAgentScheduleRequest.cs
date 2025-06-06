using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// BuGetCurrentAgentScheduleRequest
/// </summary>

public partial class BuGetCurrentAgentScheduleRequest : IEquatable<BuGetCurrentAgentScheduleRequest>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="BuGetCurrentAgentScheduleRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected BuGetCurrentAgentScheduleRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="BuGetCurrentAgentScheduleRequest" /> class.
    /// </summary>
    /// <param name="StartDate">Start date of the range to search. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
    /// <param name="EndDate">End date of the range to search. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
    public BuGetCurrentAgentScheduleRequest(DateTime? StartDate = null, DateTime? EndDate = null)
    {
        this.StartDate = StartDate;
        this.EndDate = EndDate;

    }



    /// <summary>
    /// Start date of the range to search. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Start date of the range to search. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("startDate")]
    public DateTime? StartDate { get; set; }



    /// <summary>
    /// End date of the range to search. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>End date of the range to search. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("endDate")]
    public DateTime? EndDate { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class BuGetCurrentAgentScheduleRequest {\n");

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
        return Equals(obj as BuGetCurrentAgentScheduleRequest);
    }

    /// <summary>
    /// Returns true if BuGetCurrentAgentScheduleRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of BuGetCurrentAgentScheduleRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(BuGetCurrentAgentScheduleRequest other)
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
