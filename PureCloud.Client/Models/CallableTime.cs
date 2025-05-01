using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloudPlatform.Client.V2.Model;

/// <summary>
/// CallableTime
/// </summary>
[DataContract]
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
    [DataMember(Name = "timeSlots", EmitDefaultValue = false)]
    public List<CampaignTimeSlot> TimeSlots { get; set; }



    /// <summary>
    /// The time zone for the time slots; for example, Africa/Abidjan
    /// </summary>
    /// <value>The time zone for the time slots; for example, Africa/Abidjan</value>
    [DataMember(Name = "timeZoneId", EmitDefaultValue = false)]
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
        return this.Equals(obj as CallableTime);
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
                this.TimeSlots == other.TimeSlots ||
                this.TimeSlots != null &&
                this.TimeSlots.SequenceEqual(other.TimeSlots)
            ) &&
            (
                this.TimeZoneId == other.TimeZoneId ||
                this.TimeZoneId != null &&
                this.TimeZoneId.Equals(other.TimeZoneId)
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
            if (this.TimeSlots != null)
            {
                hash = hash * 59 + this.TimeSlots.GetHashCode();
            }

            if (this.TimeZoneId != null)
            {
                hash = hash * 59 + this.TimeZoneId.GetHashCode();
            }

            return hash;
        }
    }
}
