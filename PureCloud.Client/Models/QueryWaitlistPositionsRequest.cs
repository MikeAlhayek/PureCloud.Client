using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// QueryWaitlistPositionsRequest
/// </summary>

public partial class QueryWaitlistPositionsRequest : IEquatable<QueryWaitlistPositionsRequest>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="QueryWaitlistPositionsRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected QueryWaitlistPositionsRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="QueryWaitlistPositionsRequest" /> class.
    /// </summary>
    /// <param name="TimeOffRequests">The list of the time off request ids for which to fetch the daily waitlist positions (required).</param>
    public QueryWaitlistPositionsRequest(List<UserTimeOffRequestReference> TimeOffRequests = null)
    {
        this.TimeOffRequests = TimeOffRequests;

    }



    /// <summary>
    /// The list of the time off request ids for which to fetch the daily waitlist positions
    /// </summary>
    /// <value>The list of the time off request ids for which to fetch the daily waitlist positions</value>
    [JsonPropertyName("timeOffRequests")]
    public List<UserTimeOffRequestReference> TimeOffRequests { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class QueryWaitlistPositionsRequest {\n");

        sb.Append("  TimeOffRequests: ").Append(TimeOffRequests).Append("\n");
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
        return Equals(obj as QueryWaitlistPositionsRequest);
    }

    /// <summary>
    /// Returns true if QueryWaitlistPositionsRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of QueryWaitlistPositionsRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(QueryWaitlistPositionsRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                TimeOffRequests == other.TimeOffRequests ||
                TimeOffRequests != null &&
                TimeOffRequests.SequenceEqual(other.TimeOffRequests)
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
            if (TimeOffRequests != null)
            {
                hash = hash * 59 + TimeOffRequests.GetHashCode();
            }

            return hash;
        }
    }
}
