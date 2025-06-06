using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WaitlistPosition
/// </summary>

public partial class WaitlistPosition : IEquatable<WaitlistPosition>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="WaitlistPosition" /> class.
    /// </summary>
    /// <param name="TimeOffRequest">The time off request for this wait list position.</param>
    /// <param name="TimeOffLimit">The time off limit for which time off request is waitlisted.</param>
    /// <param name="Date">The date to which this wait list position applies, as defined by the time zone of the business unit. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd.</param>
    /// <param name="_WaitlistPosition">The time off request&#39;s position in the waitlist on the date. 1 means time off is the first in the waitlist.</param>
    public WaitlistPosition(TimeOffRequestReference TimeOffRequest = null, TimeOffLimitReference TimeOffLimit = null, string Date = null, int? _WaitlistPosition = null)
    {
        this.TimeOffRequest = TimeOffRequest;
        this.TimeOffLimit = TimeOffLimit;
        this.Date = Date;
        this._WaitlistPosition = _WaitlistPosition;

    }



    /// <summary>
    /// The time off request for this wait list position
    /// </summary>
    /// <value>The time off request for this wait list position</value>
    [JsonPropertyName("timeOffRequest")]
    public TimeOffRequestReference TimeOffRequest { get; set; }



    /// <summary>
    /// The time off limit for which time off request is waitlisted
    /// </summary>
    /// <value>The time off limit for which time off request is waitlisted</value>
    [JsonPropertyName("timeOffLimit")]
    public TimeOffLimitReference TimeOffLimit { get; set; }



    /// <summary>
    /// The date to which this wait list position applies, as defined by the time zone of the business unit. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
    /// </summary>
    /// <value>The date to which this wait list position applies, as defined by the time zone of the business unit. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
    [JsonPropertyName("date")]
    public string Date { get; set; }



    /// <summary>
    /// The time off request&#39;s position in the waitlist on the date. 1 means time off is the first in the waitlist
    /// </summary>
    /// <value>The time off request&#39;s position in the waitlist on the date. 1 means time off is the first in the waitlist</value>
    [JsonPropertyName("waitlistPosition")]
    public int? _WaitlistPosition { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WaitlistPosition {\n");

        sb.Append("  TimeOffRequest: ").Append(TimeOffRequest).Append("\n");
        sb.Append("  TimeOffLimit: ").Append(TimeOffLimit).Append("\n");
        sb.Append("  Date: ").Append(Date).Append("\n");
        sb.Append("  _WaitlistPosition: ").Append(_WaitlistPosition).Append("\n");
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
        return Equals(obj as WaitlistPosition);
    }

    /// <summary>
    /// Returns true if WaitlistPosition instances are equal
    /// </summary>
    /// <param name="other">Instance of WaitlistPosition to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WaitlistPosition other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                TimeOffRequest == other.TimeOffRequest ||
                TimeOffRequest != null &&
                TimeOffRequest.Equals(other.TimeOffRequest)
            ) &&
            (
                TimeOffLimit == other.TimeOffLimit ||
                TimeOffLimit != null &&
                TimeOffLimit.Equals(other.TimeOffLimit)
            ) &&
            (
                Date == other.Date ||
                Date != null &&
                Date.Equals(other.Date)
            ) &&
            (
                _WaitlistPosition == other._WaitlistPosition ||
                _WaitlistPosition != null &&
                _WaitlistPosition.Equals(other._WaitlistPosition)
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
            if (TimeOffRequest != null)
            {
                hash = hash * 59 + TimeOffRequest.GetHashCode();
            }

            if (TimeOffLimit != null)
            {
                hash = hash * 59 + TimeOffLimit.GetHashCode();
            }

            if (Date != null)
            {
                hash = hash * 59 + Date.GetHashCode();
            }

            if (_WaitlistPosition != null)
            {
                hash = hash * 59 + _WaitlistPosition.GetHashCode();
            }

            return hash;
        }
    }
}
