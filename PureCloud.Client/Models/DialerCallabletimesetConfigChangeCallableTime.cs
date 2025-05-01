using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// DialerCallabletimesetConfigChangeCallableTime
/// </summary>
[DataContract]
public partial class DialerCallabletimesetConfigChangeCallableTime : IEquatable<DialerCallabletimesetConfigChangeCallableTime>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DialerCallabletimesetConfigChangeCallableTime" /> class.
    /// </summary>
    /// <param name="TimeSlots">The time slots.</param>
    /// <param name="TimeZoneId">The ISO ID for the timezone.</param>
    /// <param name="AdditionalProperties">AdditionalProperties.</param>
    public DialerCallabletimesetConfigChangeCallableTime(List<DialerCallabletimesetConfigChangeTimeSlot> TimeSlots = null, string TimeZoneId = null, Dictionary<string, object> AdditionalProperties = null)
    {
        this.TimeSlots = TimeSlots;
        this.TimeZoneId = TimeZoneId;
        this.AdditionalProperties = AdditionalProperties;

    }



    /// <summary>
    /// The time slots
    /// </summary>
    /// <value>The time slots</value>
    [DataMember(Name = "timeSlots", EmitDefaultValue = false)]
    public List<DialerCallabletimesetConfigChangeTimeSlot> TimeSlots { get; set; }



    /// <summary>
    /// The ISO ID for the timezone
    /// </summary>
    /// <value>The ISO ID for the timezone</value>
    [DataMember(Name = "timeZoneId", EmitDefaultValue = false)]
    public string TimeZoneId { get; set; }



    /// <summary>
    /// Gets or Sets AdditionalProperties
    /// </summary>
    [DataMember(Name = "additionalProperties", EmitDefaultValue = false)]
    public Dictionary<string, object> AdditionalProperties { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class DialerCallabletimesetConfigChangeCallableTime {\n");

        sb.Append("  TimeSlots: ").Append(TimeSlots).Append("\n");
        sb.Append("  TimeZoneId: ").Append(TimeZoneId).Append("\n");
        sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
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
        return Equals(obj as DialerCallabletimesetConfigChangeCallableTime);
    }

    /// <summary>
    /// Returns true if DialerCallabletimesetConfigChangeCallableTime instances are equal
    /// </summary>
    /// <param name="other">Instance of DialerCallabletimesetConfigChangeCallableTime to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DialerCallabletimesetConfigChangeCallableTime other)
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
            ) &&
            (
                AdditionalProperties == other.AdditionalProperties ||
                AdditionalProperties != null &&
                AdditionalProperties.SequenceEqual(other.AdditionalProperties)
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

            if (AdditionalProperties != null)
            {
                hash = hash * 59 + AdditionalProperties.GetHashCode();
            }

            return hash;
        }
    }
}
