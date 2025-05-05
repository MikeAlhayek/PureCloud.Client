using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// CallableTime
/// </summary>

public partial class CallableTime : IEquatable<CallableTime>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="CallableTime" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected CallableTime() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="CallableTime" /> class.
    /// </summary>
    /// <param name="TimeSlots">The time intervals for which it is acceptable to place outbound calls. (required).</param>
    /// <param name="TimeZoneId">The time zone for the time slots; for example, Africa/Abidjan (required).</param>
    public CallableTime(List<CampaignTimeSlot> TimeSlots = null, string TimeZoneId = null)
    {
        this.TimeSlots = TimeSlots;
        this.TimeZoneId = TimeZoneId;

    }



    /// <summary>
    /// The time intervals for which it is acceptable to place outbound calls.
    /// </summary>
    /// <value>The time intervals for which it is acceptable to place outbound calls.</value>
    [JsonPropertyName("timeSlots")]
    public List<CampaignTimeSlot> TimeSlots { get; set; }



    /// <summary>
    /// The time zone for the time slots; for example, Africa/Abidjan
    /// </summary>
    /// <value>The time zone for the time slots; for example, Africa/Abidjan</value>
    [JsonPropertyName("timeZoneId")]
    public string TimeZoneId { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CallableTime {\n");

        sb.Append("  TimeSlots: ").Append(TimeSlots).Append("\n");
        sb.Append("  TimeZoneId: ").Append(TimeZoneId).Append("\n");
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
        return Equals(obj as CallableTime);
    }

    /// <summary>
    /// Returns true if CallableTime instances are equal
    /// </summary>
    /// <param name="other">Instance of CallableTime to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CallableTime other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                TimeSlots == other.TimeSlots ||
                TimeSlots != null &&
                TimeSlots.SequenceEqual(other.TimeSlots)
            ) &&
            (
                TimeZoneId == other.TimeZoneId ||
                TimeZoneId != null &&
                TimeZoneId.Equals(other.TimeZoneId)
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
            if (TimeSlots != null)
            {
                hash = hash * 59 + TimeSlots.GetHashCode();
            }

            if (TimeZoneId != null)
            {
                hash = hash * 59 + TimeZoneId.GetHashCode();
            }

            return hash;
        }
    }
}
