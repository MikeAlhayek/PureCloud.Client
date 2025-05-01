using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// The time interval to place outbound calls
/// </summary>
[DataContract]
public partial class DialerOutboundSettingsConfigChangeAtzmTimeSlotWithTimeZone : IEquatable<DialerOutboundSettingsConfigChangeAtzmTimeSlotWithTimeZone>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DialerOutboundSettingsConfigChangeAtzmTimeSlotWithTimeZone" /> class.
    /// </summary>
    /// <param name="TimeZoneId">The time zone to use for contacts that cannot be mapped.</param>
    /// <param name="EarliestCallableTime">The earliest time to dial a contact.</param>
    /// <param name="LatestCallableTime">The latest time to dial a contact.</param>
    public DialerOutboundSettingsConfigChangeAtzmTimeSlotWithTimeZone(string TimeZoneId = null, string EarliestCallableTime = null, string LatestCallableTime = null)
    {
        this.TimeZoneId = TimeZoneId;
        this.EarliestCallableTime = EarliestCallableTime;
        this.LatestCallableTime = LatestCallableTime;

    }



    /// <summary>
    /// The time zone to use for contacts that cannot be mapped
    /// </summary>
    /// <value>The time zone to use for contacts that cannot be mapped</value>
    [DataMember(Name = "timeZoneId", EmitDefaultValue = false)]
    public string TimeZoneId { get; set; }



    /// <summary>
    /// The earliest time to dial a contact
    /// </summary>
    /// <value>The earliest time to dial a contact</value>
    [DataMember(Name = "earliestCallableTime", EmitDefaultValue = false)]
    public string EarliestCallableTime { get; set; }



    /// <summary>
    /// The latest time to dial a contact
    /// </summary>
    /// <value>The latest time to dial a contact</value>
    [DataMember(Name = "latestCallableTime", EmitDefaultValue = false)]
    public string LatestCallableTime { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class DialerOutboundSettingsConfigChangeAtzmTimeSlotWithTimeZone {\n");

        sb.Append("  TimeZoneId: ").Append(TimeZoneId).Append("\n");
        sb.Append("  EarliestCallableTime: ").Append(EarliestCallableTime).Append("\n");
        sb.Append("  LatestCallableTime: ").Append(LatestCallableTime).Append("\n");
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
        return Equals(obj as DialerOutboundSettingsConfigChangeAtzmTimeSlotWithTimeZone);
    }

    /// <summary>
    /// Returns true if DialerOutboundSettingsConfigChangeAtzmTimeSlotWithTimeZone instances are equal
    /// </summary>
    /// <param name="other">Instance of DialerOutboundSettingsConfigChangeAtzmTimeSlotWithTimeZone to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DialerOutboundSettingsConfigChangeAtzmTimeSlotWithTimeZone other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                TimeZoneId == other.TimeZoneId ||
                TimeZoneId != null &&
                TimeZoneId.Equals(other.TimeZoneId)
            ) &&
            (
                EarliestCallableTime == other.EarliestCallableTime ||
                EarliestCallableTime != null &&
                EarliestCallableTime.Equals(other.EarliestCallableTime)
            ) &&
            (
                LatestCallableTime == other.LatestCallableTime ||
                LatestCallableTime != null &&
                LatestCallableTime.Equals(other.LatestCallableTime)
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
            if (TimeZoneId != null)
            {
                hash = hash * 59 + TimeZoneId.GetHashCode();
            }

            if (EarliestCallableTime != null)
            {
                hash = hash * 59 + EarliestCallableTime.GetHashCode();
            }

            if (LatestCallableTime != null)
            {
                hash = hash * 59 + LatestCallableTime.GetHashCode();
            }

            return hash;
        }
    }
}
