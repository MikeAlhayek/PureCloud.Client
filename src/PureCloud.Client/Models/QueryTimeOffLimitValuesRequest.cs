using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// QueryTimeOffLimitValuesRequest
/// </summary>

public partial class QueryTimeOffLimitValuesRequest : IEquatable<QueryTimeOffLimitValuesRequest>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="QueryTimeOffLimitValuesRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected QueryTimeOffLimitValuesRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="QueryTimeOffLimitValuesRequest" /> class.
    /// </summary>
    /// <param name="TimeOffLimitId">The time off limit object id to retrieve values for. Required if activityCodeId is not specified.</param>
    /// <param name="ActivityCodeId">The activity code id to filter the affected limit objects by. Required if timeOffLimitId is not specified.</param>
    /// <param name="DateRanges">The list of the date ranges to return time off limit, allocated and waitlisted minutes. The valid number of date ranges is between 1 and 30. Maximum total number of days in all ranges in 366. (required).</param>
    public QueryTimeOffLimitValuesRequest(string TimeOffLimitId = null, string ActivityCodeId = null, List<LocalDateRange> DateRanges = null)
    {
        this.TimeOffLimitId = TimeOffLimitId;
        this.ActivityCodeId = ActivityCodeId;
        this.DateRanges = DateRanges;

    }



    /// <summary>
    /// The time off limit object id to retrieve values for. Required if activityCodeId is not specified
    /// </summary>
    /// <value>The time off limit object id to retrieve values for. Required if activityCodeId is not specified</value>
    [JsonPropertyName("timeOffLimitId")]
    public string TimeOffLimitId { get; set; }



    /// <summary>
    /// The activity code id to filter the affected limit objects by. Required if timeOffLimitId is not specified
    /// </summary>
    /// <value>The activity code id to filter the affected limit objects by. Required if timeOffLimitId is not specified</value>
    [JsonPropertyName("activityCodeId")]
    public string ActivityCodeId { get; set; }



    /// <summary>
    /// The list of the date ranges to return time off limit, allocated and waitlisted minutes. The valid number of date ranges is between 1 and 30. Maximum total number of days in all ranges in 366.
    /// </summary>
    /// <value>The list of the date ranges to return time off limit, allocated and waitlisted minutes. The valid number of date ranges is between 1 and 30. Maximum total number of days in all ranges in 366.</value>
    [JsonPropertyName("dateRanges")]
    public List<LocalDateRange> DateRanges { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class QueryTimeOffLimitValuesRequest {\n");

        sb.Append("  TimeOffLimitId: ").Append(TimeOffLimitId).Append("\n");
        sb.Append("  ActivityCodeId: ").Append(ActivityCodeId).Append("\n");
        sb.Append("  DateRanges: ").Append(DateRanges).Append("\n");
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
        return Equals(obj as QueryTimeOffLimitValuesRequest);
    }

    /// <summary>
    /// Returns true if QueryTimeOffLimitValuesRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of QueryTimeOffLimitValuesRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(QueryTimeOffLimitValuesRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                TimeOffLimitId == other.TimeOffLimitId ||
                TimeOffLimitId != null &&
                TimeOffLimitId.Equals(other.TimeOffLimitId)
            ) &&
            (
                ActivityCodeId == other.ActivityCodeId ||
                ActivityCodeId != null &&
                ActivityCodeId.Equals(other.ActivityCodeId)
            ) &&
            (
                DateRanges == other.DateRanges ||
                DateRanges != null &&
                DateRanges.SequenceEqual(other.DateRanges)
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
            if (TimeOffLimitId != null)
            {
                hash = hash * 59 + TimeOffLimitId.GetHashCode();
            }

            if (ActivityCodeId != null)
            {
                hash = hash * 59 + ActivityCodeId.GetHashCode();
            }

            if (DateRanges != null)
            {
                hash = hash * 59 + DateRanges.GetHashCode();
            }

            return hash;
        }
    }
}
