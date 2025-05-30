using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// CallableWindow
/// </summary>

public partial class CallableWindow : IEquatable<CallableWindow>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CallableWindow" /> class.
    /// </summary>
    /// <param name="Mapped">The time interval to place outbound calls, for contacts that can be mapped to a time zone..</param>
    /// <param name="Unmapped">The time interval and time zone to place outbound calls, for contacts that cannot be mapped to a time zone..</param>
    public CallableWindow(AtzmTimeSlot Mapped = null, AtzmTimeSlotWithTimeZone Unmapped = null)
    {
        this.Mapped = Mapped;
        this.Unmapped = Unmapped;

    }



    /// <summary>
    /// The time interval to place outbound calls, for contacts that can be mapped to a time zone.
    /// </summary>
    /// <value>The time interval to place outbound calls, for contacts that can be mapped to a time zone.</value>
    [JsonPropertyName("mapped")]
    public AtzmTimeSlot Mapped { get; set; }



    /// <summary>
    /// The time interval and time zone to place outbound calls, for contacts that cannot be mapped to a time zone.
    /// </summary>
    /// <value>The time interval and time zone to place outbound calls, for contacts that cannot be mapped to a time zone.</value>
    [JsonPropertyName("unmapped")]
    public AtzmTimeSlotWithTimeZone Unmapped { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CallableWindow {\n");

        sb.Append("  Mapped: ").Append(Mapped).Append("\n");
        sb.Append("  Unmapped: ").Append(Unmapped).Append("\n");
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
        return Equals(obj as CallableWindow);
    }

    /// <summary>
    /// Returns true if CallableWindow instances are equal
    /// </summary>
    /// <param name="other">Instance of CallableWindow to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CallableWindow other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Mapped == other.Mapped ||
                Mapped != null &&
                Mapped.Equals(other.Mapped)
            ) &&
            (
                Unmapped == other.Unmapped ||
                Unmapped != null &&
                Unmapped.Equals(other.Unmapped)
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
            if (Mapped != null)
            {
                hash = hash * 59 + Mapped.GetHashCode();
            }

            if (Unmapped != null)
            {
                hash = hash * 59 + Unmapped.GetHashCode();
            }

            return hash;
        }
    }
}
