using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AvailableTimeOffRequest
/// </summary>

public partial class AvailableTimeOffRequest : IEquatable<AvailableTimeOffRequest>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="AvailableTimeOffRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected AvailableTimeOffRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="AvailableTimeOffRequest" /> class.
    /// </summary>
    /// <param name="ActivityCodeId">The ID for activity code to query available time off minutes (required).</param>
    /// <param name="DateRanges">A list of date ranges of available time off minutes. A maximum number of date ranges is 30. The maximum total number of days in all ranges is 366. If no ranges are specified, then only the presence of the associated time off limit object will be checked. In such case, if the association exists, then the response will contain a list with of a single element filled with timeOffLimitId only..</param>
    public AvailableTimeOffRequest(string ActivityCodeId = null, List<LocalDateRange> DateRanges = null)
    {
        this.ActivityCodeId = ActivityCodeId;
        this.DateRanges = DateRanges;

    }



    /// <summary>
    /// The ID for activity code to query available time off minutes
    /// </summary>
    /// <value>The ID for activity code to query available time off minutes</value>
    [JsonPropertyName("activityCodeId")]
    public string ActivityCodeId { get; set; }



    /// <summary>
    /// A list of date ranges of available time off minutes. A maximum number of date ranges is 30. The maximum total number of days in all ranges is 366. If no ranges are specified, then only the presence of the associated time off limit object will be checked. In such case, if the association exists, then the response will contain a list with of a single element filled with timeOffLimitId only.
    /// </summary>
    /// <value>A list of date ranges of available time off minutes. A maximum number of date ranges is 30. The maximum total number of days in all ranges is 366. If no ranges are specified, then only the presence of the associated time off limit object will be checked. In such case, if the association exists, then the response will contain a list with of a single element filled with timeOffLimitId only.</value>
    [JsonPropertyName("dateRanges")]
    public List<LocalDateRange> DateRanges { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AvailableTimeOffRequest {\n");

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
        return Equals(obj as AvailableTimeOffRequest);
    }

    /// <summary>
    /// Returns true if AvailableTimeOffRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of AvailableTimeOffRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AvailableTimeOffRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
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
