using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AgentPossibleWorkShiftsRequest
/// </summary>

public partial class AgentPossibleWorkShiftsRequest : IEquatable<AgentPossibleWorkShiftsRequest>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="AgentPossibleWorkShiftsRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected AgentPossibleWorkShiftsRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="AgentPossibleWorkShiftsRequest" /> class.
    /// </summary>
    /// <param name="WeekStartDate">Start date of requested effective work plan, day of week will be in line with business unit start day of week. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (required).</param>
    /// <param name="WeekCount">Number of weeks for which to return possible work shifts (required).</param>
    public AgentPossibleWorkShiftsRequest(string WeekStartDate = null, int? WeekCount = null)
    {
        this.WeekStartDate = WeekStartDate;
        this.WeekCount = WeekCount;

    }



    /// <summary>
    /// Start date of requested effective work plan, day of week will be in line with business unit start day of week. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
    /// </summary>
    /// <value>Start date of requested effective work plan, day of week will be in line with business unit start day of week. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
    [JsonPropertyName("weekStartDate")]
    public string WeekStartDate { get; set; }



    /// <summary>
    /// Number of weeks for which to return possible work shifts
    /// </summary>
    /// <value>Number of weeks for which to return possible work shifts</value>
    [JsonPropertyName("weekCount")]
    public int? WeekCount { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AgentPossibleWorkShiftsRequest {\n");

        sb.Append("  WeekStartDate: ").Append(WeekStartDate).Append("\n");
        sb.Append("  WeekCount: ").Append(WeekCount).Append("\n");
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
        return Equals(obj as AgentPossibleWorkShiftsRequest);
    }

    /// <summary>
    /// Returns true if AgentPossibleWorkShiftsRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of AgentPossibleWorkShiftsRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AgentPossibleWorkShiftsRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                WeekStartDate == other.WeekStartDate ||
                WeekStartDate != null &&
                WeekStartDate.Equals(other.WeekStartDate)
            ) &&
            (
                WeekCount == other.WeekCount ||
                WeekCount != null &&
                WeekCount.Equals(other.WeekCount)
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
            if (WeekStartDate != null)
            {
                hash = hash * 59 + WeekStartDate.GetHashCode();
            }

            if (WeekCount != null)
            {
                hash = hash * 59 + WeekCount.GetHashCode();
            }

            return hash;
        }
    }
}
